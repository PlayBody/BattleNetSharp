using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Grids;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Serialization
{
	// Token: 0x020008DC RID: 2268
	public static class GridSerializer
	{
		// Token: 0x0600B68D RID: 46733 RVA: 0x002D6584 File Offset: 0x002D4784
		public static string SerializeGrid(Grid grid)
		{
			GridDto gridDto = grid.ToDto();
			XmlSerializer xmlSerializer = new XmlSerializer(gridDto.GetType());
			string text;
			using (StringWriter stringWriter = new StringWriter())
			{
				xmlSerializer.Serialize(stringWriter, gridDto);
				text = stringWriter.ToString();
			}
			return text;
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x002D65DC File Offset: 0x002D47DC
		public static Grid DeSerializeGrid(string gridString)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(GridDto));
			Grid grid;
			using (StringReader stringReader = new StringReader(gridString))
			{
				GridDto gridDto = (GridDto)xmlSerializer.Deserialize(stringReader);
				Node[,] array = new Node[gridDto.Nodes.Length, gridDto.Nodes[0].Length];
				for (int i = 0; i < gridDto.Nodes.Length; i++)
				{
					for (int j = 0; j < gridDto.Nodes[0].Length; j++)
					{
						NodeDto nodeDto = gridDto.Nodes[i][j];
						Node node = new Node(nodeDto.Position.FromDto());
						array[i, j] = node;
					}
				}
				for (int k = 0; k < gridDto.Nodes.Length; k++)
				{
					for (int l = 0; l < gridDto.Nodes[0].Length; l++)
					{
						NodeDto nodeDto2 = gridDto.Nodes[k][l];
						Node node2 = array[k, l];
						foreach (EdgeDto edgeDto in nodeDto2.OutGoingEdges)
						{
							Node node3 = array[edgeDto.End.X, edgeDto.End.Y];
							node2.Connect(node3, edgeDto.TraversalVelocity.FromDto());
						}
					}
				}
				grid = Grid.CreateGridFrom2DArrayOfNodes(array);
			}
			return grid;
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x002D67B4 File Offset: 0x002D49B4
		private static GridDto ToDto(this Grid grid)
		{
			Dictionary<INode, GridPosition> dictionary = new Dictionary<INode, GridPosition>();
			NodeDto[][] array = new NodeDto[grid.Columns][];
			for (int i = 0; i < grid.Columns; i++)
			{
				for (int j = 0; j < grid.Rows; j++)
				{
					GridPosition gridPosition = new GridPosition(i, j);
					dictionary[grid.GetNode(gridPosition)] = gridPosition;
				}
			}
			for (int k = 0; k < grid.Columns; k++)
			{
				array[k] = new NodeDto[grid.Rows];
				for (int l = 0; l < grid.Rows; l++)
				{
					array[k][l] = grid.GetNode(new GridPosition(k, l)).ToDto(dictionary);
				}
			}
			return new GridDto
			{
				Nodes = array
			};
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x002D6898 File Offset: 0x002D4A98
		private static NodeDto ToDto(this INode node, Dictionary<INode, GridPosition> nodeToGridPositionDict)
		{
			return new NodeDto
			{
				Position = node.Position.ToDto(),
				GridPosition = nodeToGridPositionDict[node].ToDto(),
				OutGoingEdges = node.Outgoing.ToDto(nodeToGridPositionDict),
				IncomingEdges = node.Incoming.ToDto(nodeToGridPositionDict)
			};
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x002D68FC File Offset: 0x002D4AFC
		private static List<EdgeDto> ToDto(this IList<IEdge> edge, Dictionary<INode, GridPosition> nodeToGridPositionDict)
		{
			return edge.Select((IEdge e) => e.ToDto(nodeToGridPositionDict)).ToList<EdgeDto>();
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x002D6934 File Offset: 0x002D4B34
		private static EdgeDto ToDto(this IEdge edge, Dictionary<INode, GridPosition> nodeToGridPositionDict)
		{
			return new EdgeDto
			{
				TraversalVelocity = edge.TraversalVelocity.ToDto(),
				Start = nodeToGridPositionDict[edge.Start].ToDto(),
				End = nodeToGridPositionDict[edge.End].ToDto()
			};
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x002D6990 File Offset: 0x002D4B90
		private static VelocityDto ToDto(this Velocity velocity)
		{
			return new VelocityDto
			{
				MetersPerSecond = velocity.MetersPerSecond
			};
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x002D69B8 File Offset: 0x002D4BB8
		private static Velocity FromDto(this VelocityDto velocity)
		{
			return Velocity.FromMetersPerSecond(velocity.MetersPerSecond);
		}

		// Token: 0x0600B695 RID: 46741 RVA: 0x002D69D8 File Offset: 0x002D4BD8
		private static PositionDto ToDto(this Position position)
		{
			return new PositionDto
			{
				X = position.X,
				Y = position.Y
			};
		}

		// Token: 0x0600B696 RID: 46742 RVA: 0x002D6A0C File Offset: 0x002D4C0C
		private static Position FromDto(this PositionDto position)
		{
			return new Position(position.X, position.Y);
		}

		// Token: 0x0600B697 RID: 46743 RVA: 0x002D6A30 File Offset: 0x002D4C30
		private static GridPositionDto ToDto(this GridPosition position)
		{
			return new GridPositionDto
			{
				X = position.X,
				Y = position.Y
			};
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x002D6A64 File Offset: 0x002D4C64
		private static GridPosition FromDto(this GridPositionDto position)
		{
			return new GridPosition(position.X, position.Y);
		}
	}
}

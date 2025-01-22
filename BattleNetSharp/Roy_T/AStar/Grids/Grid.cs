using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Grids
{
	// Token: 0x020008EC RID: 2284
	public sealed class Grid
	{
		// Token: 0x0600B724 RID: 46884 RVA: 0x002D79F8 File Offset: 0x002D5BF8
		public static Grid CreateGridWithLateralConnections(GridSize gridSize, Size cellSize, Velocity traversalVelocity)
		{
			Grid.CheckArguments(gridSize, cellSize, traversalVelocity);
			Grid grid = new Grid(gridSize, cellSize);
			grid.CreateLateralConnections(traversalVelocity);
			return grid;
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x002D7A24 File Offset: 0x002D5C24
		public static Grid CreateGridWithDiagonalConnections(GridSize gridSize, Size cellSize, Velocity traversalVelocity)
		{
			Grid.CheckArguments(gridSize, cellSize, traversalVelocity);
			Grid grid = new Grid(gridSize, cellSize);
			grid.CreateDiagonalConnections(traversalVelocity);
			return grid;
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x002D7A50 File Offset: 0x002D5C50
		public static Grid CreateGridWithLateralAndDiagonalConnections(GridSize gridSize, Size cellSize, Velocity traversalVelocity)
		{
			Grid.CheckArguments(gridSize, cellSize, traversalVelocity);
			Grid grid = new Grid(gridSize, cellSize);
			grid.CreateDiagonalConnections(traversalVelocity);
			grid.CreateLateralConnections(traversalVelocity);
			return grid;
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x002D7A84 File Offset: 0x002D5C84
		public static Grid CreateGridFrom2DArrayOfNodes(Node[,] nodes)
		{
			return new Grid(nodes);
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x002D7A9C File Offset: 0x002D5C9C
		private static void CheckGridSize(GridSize gridSize)
		{
			bool flag = gridSize.Columns < 1;
			if (flag)
			{
				string text = "gridSize";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Argument ");
				defaultInterpolatedStringHandler.AppendFormatted("Columns");
				defaultInterpolatedStringHandler.AppendLiteral(" is ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridSize.Columns);
				defaultInterpolatedStringHandler.AppendLiteral(" but should be >= 1");
				throw new ArgumentOutOfRangeException(text, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			bool flag2 = gridSize.Rows < 1;
			if (flag2)
			{
				string text2 = "gridSize";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Argument ");
				defaultInterpolatedStringHandler.AppendFormatted("Rows");
				defaultInterpolatedStringHandler.AppendLiteral(" is ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(gridSize.Rows);
				defaultInterpolatedStringHandler.AppendLiteral(" but should be >= 1");
				throw new ArgumentOutOfRangeException(text2, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x002D7B88 File Offset: 0x002D5D88
		private static void CheckArguments(GridSize gridSize, Size cellSize, Velocity defaultSpeed)
		{
			Grid.CheckGridSize(gridSize);
			bool flag = cellSize.Width <= Distance.Zero;
			if (flag)
			{
				string text = "cellSize";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Argument ");
				defaultInterpolatedStringHandler.AppendFormatted("Width");
				defaultInterpolatedStringHandler.AppendLiteral(" is ");
				defaultInterpolatedStringHandler.AppendFormatted<Distance>(cellSize.Width);
				defaultInterpolatedStringHandler.AppendLiteral(" but should be > ");
				defaultInterpolatedStringHandler.AppendFormatted<Distance>(Distance.Zero);
				throw new ArgumentOutOfRangeException(text, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			bool flag2 = cellSize.Height <= Distance.Zero;
			if (flag2)
			{
				string text2 = "cellSize";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Argument ");
				defaultInterpolatedStringHandler.AppendFormatted("Height");
				defaultInterpolatedStringHandler.AppendLiteral(" is ");
				defaultInterpolatedStringHandler.AppendFormatted<Distance>(cellSize.Height);
				defaultInterpolatedStringHandler.AppendLiteral(" but should be > ");
				defaultInterpolatedStringHandler.AppendFormatted<Distance>(Distance.Zero);
				throw new ArgumentOutOfRangeException(text2, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			bool flag3 = defaultSpeed.MetersPerSecond <= 0f;
			if (flag3)
			{
				string text3 = "defaultSpeed";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Argument ");
				defaultInterpolatedStringHandler.AppendFormatted("defaultSpeed");
				defaultInterpolatedStringHandler.AppendLiteral(" is ");
				defaultInterpolatedStringHandler.AppendFormatted<Velocity>(defaultSpeed);
				defaultInterpolatedStringHandler.AppendLiteral(" but should be > 0.0 m/s");
				throw new ArgumentOutOfRangeException(text3, defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x002D7D10 File Offset: 0x002D5F10
		private Grid(Node[,] nodes)
		{
			this.GridSize = new GridSize(nodes.GetLength(0), nodes.GetLength(1));
			Grid.CheckGridSize(this.GridSize);
			this.Nodes = nodes;
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x002D7D46 File Offset: 0x002D5F46
		private Grid(GridSize gridSize, Size cellSize)
		{
			this.GridSize = gridSize;
			this.Nodes = new Node[gridSize.Columns, gridSize.Rows];
			this.CreateNodes(cellSize);
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x002D7D78 File Offset: 0x002D5F78
		private void CreateNodes(Size cellSize)
		{
			for (int i = 0; i < this.Columns; i++)
			{
				for (int j = 0; j < this.Rows; j++)
				{
					this.Nodes[i, j] = new Node(Position.FromOffset(cellSize.Width * (float)i, cellSize.Height * (float)j));
				}
			}
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x002D7DE8 File Offset: 0x002D5FE8
		private void CreateLateralConnections(Velocity defaultSpeed)
		{
			for (int i = 0; i < this.Columns; i++)
			{
				for (int j = 0; j < this.Rows; j++)
				{
					Node node = this.Nodes[i, j];
					bool flag = i < this.Columns - 1;
					if (flag)
					{
						Node node2 = this.Nodes[i + 1, j];
						node.Connect(node2, defaultSpeed);
						node2.Connect(node, defaultSpeed);
					}
					bool flag2 = j < this.Rows - 1;
					if (flag2)
					{
						Node node3 = this.Nodes[i, j + 1];
						node.Connect(node3, defaultSpeed);
						node3.Connect(node, defaultSpeed);
					}
				}
			}
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002D7EB0 File Offset: 0x002D60B0
		private void CreateDiagonalConnections(Velocity defaultSpeed)
		{
			for (int i = 0; i < this.Columns; i++)
			{
				for (int j = 0; j < this.Rows; j++)
				{
					Node node = this.Nodes[i, j];
					bool flag = i < this.Columns - 1 && j < this.Rows - 1;
					if (flag)
					{
						Node node2 = this.Nodes[i + 1, j + 1];
						node.Connect(node2, defaultSpeed);
						node2.Connect(node, defaultSpeed);
					}
					bool flag2 = i > 0 && j < this.Rows - 1;
					if (flag2)
					{
						Node node3 = this.Nodes[i - 1, j + 1];
						node.Connect(node3, defaultSpeed);
						node3.Connect(node, defaultSpeed);
					}
				}
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600B72F RID: 46895 RVA: 0x002D7F91 File Offset: 0x002D6191
		public GridSize GridSize { get; }

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600B730 RID: 46896 RVA: 0x002D7F9C File Offset: 0x002D619C
		public int Columns
		{
			get
			{
				return this.GridSize.Columns;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600B731 RID: 46897 RVA: 0x002D7FB8 File Offset: 0x002D61B8
		public int Rows
		{
			get
			{
				return this.GridSize.Rows;
			}
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x002D7FD3 File Offset: 0x002D61D3
		public INode GetNode(GridPosition position)
		{
			return this.Nodes[position.X, position.Y];
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x002D7FF0 File Offset: 0x002D61F0
		public IReadOnlyList<INode> GetAllNodes()
		{
			List<INode> list = new List<INode>(this.Columns * this.Rows);
			for (int i = 0; i < this.Columns; i++)
			{
				for (int j = 0; j < this.Rows; j++)
				{
					list.Add(this.Nodes[i, j]);
				}
			}
			return list;
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x002D805C File Offset: 0x002D625C
		public void DisconnectNode(GridPosition position)
		{
			Node node = this.Nodes[position.X, position.Y];
			foreach (IEdge edge in node.Outgoing)
			{
				INode end = edge.End;
				end.Incoming.Remove(edge);
			}
			node.Outgoing.Clear();
			foreach (IEdge edge2 in node.Incoming)
			{
				INode start = edge2.Start;
				start.Outgoing.Remove(edge2);
			}
			node.Incoming.Clear();
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x002D8144 File Offset: 0x002D6344
		public void RemoveDiagonalConnectionsIntersectingWithNode(GridPosition position)
		{
			GridPosition gridPosition = new GridPosition(position.X - 1, position.Y);
			GridPosition gridPosition2 = new GridPosition(position.X, position.Y - 1);
			GridPosition gridPosition3 = new GridPosition(position.X + 1, position.Y);
			GridPosition gridPosition4 = new GridPosition(position.X, position.Y + 1);
			bool flag = this.IsInsideGrid(gridPosition) && this.IsInsideGrid(gridPosition2);
			if (flag)
			{
				this.RemoveEdge(gridPosition, gridPosition2);
				this.RemoveEdge(gridPosition2, gridPosition);
			}
			bool flag2 = this.IsInsideGrid(gridPosition2) && this.IsInsideGrid(gridPosition3);
			if (flag2)
			{
				this.RemoveEdge(gridPosition2, gridPosition3);
				this.RemoveEdge(gridPosition3, gridPosition2);
			}
			bool flag3 = this.IsInsideGrid(gridPosition3) && this.IsInsideGrid(gridPosition4);
			if (flag3)
			{
				this.RemoveEdge(gridPosition3, gridPosition4);
				this.RemoveEdge(gridPosition4, gridPosition3);
			}
			bool flag4 = this.IsInsideGrid(gridPosition4) && this.IsInsideGrid(gridPosition);
			if (flag4)
			{
				this.RemoveEdge(gridPosition4, gridPosition);
				this.RemoveEdge(gridPosition, gridPosition4);
			}
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x002D8264 File Offset: 0x002D6464
		public void RemoveEdge(GridPosition from, GridPosition to)
		{
			Node node = this.Nodes[from.X, from.Y];
			Node node2 = this.Nodes[to.X, to.Y];
			node.Disconnect(node2);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002D82B0 File Offset: 0x002D64B0
		public void AddEdge(GridPosition from, GridPosition to, Velocity traversalVelocity)
		{
			Node node = this.Nodes[from.X, from.Y];
			Node node2 = this.Nodes[to.X, to.Y];
			node.Connect(node2, traversalVelocity);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002D82FB File Offset: 0x002D64FB
		private bool IsInsideGrid(GridPosition position)
		{
			return position.X >= 0 && position.X < this.Columns && position.Y >= 0 && position.Y < this.Rows;
		}

		// Token: 0x040069D1 RID: 27089
		private readonly Node[,] Nodes;
	}
}

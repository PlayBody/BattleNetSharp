using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using D2Map.Pathfinding;
using D4.Map;
using D4Packets.Files;
using Utilities;
using WoW.Packets;

namespace D4a.Map
{
	// Token: 0x020008C8 RID: 2248
	public static class Mapper
	{
		// Token: 0x0600B636 RID: 46646 RVA: 0x002C6CC8 File Offset: 0x002C4EC8
		public static float GetWallDist(CollisionHeightFields grid, int x, int y)
		{
			for (int i = 1; i < 4096; i++)
			{
				ushort num = ushort.MaxValue;
				for (int j = -i; j <= i; j++)
				{
					for (int k = -i; k <= i; k++)
					{
						bool flag = k != i && k != -i && j != i && j != -i;
						if (!flag)
						{
							int num2 = x + j + (y + k) * (int)grid.info.countX;
							bool flag2 = num2 < 0 || num2 >= grid.fields.Count;
							if (!flag2)
							{
								CollisionHeightField collisionHeightField = grid.fields[num2];
								bool flag3 = collisionHeightField.gameFlags != 1024;
								if (flag3)
								{
									ushort num3 = (ushort)Math.Sqrt((double)(j * j + k * k));
									bool flag4 = num3 < num;
									if (flag4)
									{
										num = num3;
									}
								}
							}
						}
					}
				}
				bool flag5 = num != ushort.MaxValue;
				if (flag5)
				{
					return (float)num;
				}
			}
			return 0f;
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x002C6DFC File Offset: 0x002C4FFC
		public static void test()
		{
			Dictionary<uint, Scene> dictionary = new Dictionary<uint, Scene>();
			Dictionary<uint, string> dictionary2 = new Dictionary<uint, string>();
			Dictionary<uint, Appearance> dictionary3 = new Dictionary<uint, Appearance>();
			foreach (string text in Directory.GetFiles("C:\\Users\\shalzuth\\Downloads\\Base\\meta\\Appearance\\"))
			{
				bool flag = text.Contains("remesh");
				if (!flag)
				{
					bool flag2 = !text.Contains("Sanctuary_Eastern_Continent_N10_E01");
					if (!flag2)
					{
						Appearance appearance = new Appearance();
						byte[] array = File.ReadAllBytes(text);
						byte[] array2 = File.ReadAllBytes(text.Replace("meta", "payload"));
						appearance.payloadOffset = array.Length;
						appearance.FromBitReader(new BitReader(array.Concat(array2).ToArray<byte>(), 0));
						dictionary3[appearance.Header.SnoId] = appearance;
						Bitmap bitmap = new Bitmap((int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwColumns, (int)appearance.Data.ptSceneData[0].ptSurfaceGrid[0].dwRows);
						float cellWidth = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.cellWidth;
						StringBuilder stringBuilder = new StringBuilder();
						Dictionary<int, Vector3> dictionary4 = new Dictionary<int, Vector3>();
						int num = 0;
						while ((long)num < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY))
						{
							int num2 = 0;
							while ((long)num2 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX))
							{
								float num3 = (float)num * cellWidth + cellWidth / 2f;
								float num4 = (float)num2 * cellWidth + cellWidth / 2f;
								float num5 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num2 + num * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX].height / 100f;
								stringBuilder.AppendLine(string.Concat(new string[]
								{
									"v ",
									num3.ToString(),
									" ",
									num4.ToString(),
									" ",
									num5.ToString()
								}));
								dictionary4.Add(num2 + num * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX, new Vector3
								{
									X = num3,
									Y = num4,
									Z = num5
								});
								num2++;
							}
							num++;
						}
						int num6 = 1;
						while ((long)num6 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY - 1U)))
						{
							int num7 = 1;
							while ((long)num7 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX - 1U)))
							{
								CollisionHeightField collisionHeightField = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num7 + num6 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								bool flag3 = collisionHeightField.gameFlags != 1024;
								if (!flag3)
								{
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1 ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 + 1) + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 - 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1 ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1"
									}));
									stringBuilder.AppendLine(string.Concat(new string[]
									{
										"f ",
										((long)num6 * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)(num7 - 1) + 1L).ToString(),
										"//1 ",
										((long)(num6 + 1) * (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX) + (long)num7 + 1L).ToString(),
										"//1"
									}));
								}
								num7++;
							}
							num6++;
						}
						File.WriteAllText("heightmap2.obj", stringBuilder.ToString());
						stringBuilder = new StringBuilder();
						int num8 = 0;
						while ((long)num8 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX))
						{
							int num9 = 0;
							while ((long)num9 < (long)((ulong)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY))
							{
								float num10 = (float)num9 * cellWidth + cellWidth / 2f;
								float num11 = (float)num8 * cellWidth + cellWidth / 2f;
								float num12 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num8 + num9 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX].height / 100f;
								stringBuilder.AppendLine(string.Concat(new string[]
								{
									"v ",
									num10.ToString(),
									" ",
									num11.ToString(),
									" ",
									num12.ToString()
								}));
								num9++;
							}
							num8++;
						}
						D2Map.Pathfinding.Node[,] array3 = new D2Map.Pathfinding.Node[(int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX, (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY];
						D4.Map.Node[,] array4 = new D4.Map.Node[(int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX, (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY];
						int num13 = 1;
						while ((long)num13 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countY - 1U)))
						{
							int num14 = 1;
							while ((long)num14 < (long)((ulong)(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX - 1U)))
							{
								CollisionHeightField collisionHeightField2 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num14 + num13 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								bool flag4 = collisionHeightField2.gameFlags != 1024;
								int num15 = 20;
								CollisionHeightField collisionHeightField3 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num14 - 1 + num13 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								CollisionHeightField collisionHeightField4 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num14 + 1 + num13 * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								CollisionHeightField collisionHeightField5 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num14 + (num13 + 1) * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								CollisionHeightField collisionHeightField6 = appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].fields[num14 + (num13 - 1) * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX];
								List<CollisionHeightField> list = new List<CollisionHeightField> { collisionHeightField3, collisionHeightField4, collisionHeightField5, collisionHeightField6 };
								float wallDist = Mapper.GetWallDist(appearance.Data.ptSceneData[0].ptCollisionHeightFields[0], num14, num13);
								foreach (CollisionHeightField collisionHeightField7 in list)
								{
									bool flag5 = collisionHeightField2.gameFlags == 1024 && collisionHeightField7.gameFlags == 1024 && Math.Abs(collisionHeightField2.height - collisionHeightField7.height) > (float)num15;
									if (flag5)
									{
										flag4 = true;
									}
								}
								array3[num13, num14] = new D2Map.Pathfinding.Node(num13, num14, flag4, wallDist, new List<int> { 1 }, false);
								array4[num14, num13] = new D4.Map.Node(num14, num13, flag4);
								num14++;
							}
							num13++;
						}
						float num16 = 38f / cellWidth;
						float num17 = 72f / cellWidth;
						float num18 = 60f / cellWidth;
						float num19 = 78f / cellWidth;
						AStar astar = new AStar(array3, new Vector2(num16, num17), new Vector2(num18, num19));
						List<D2Map.Pathfinding.Node> list2 = astar.GetPath().ToList<D2Map.Pathfinding.Node>();
						for (int j = 1; j < list2.Count; j++)
						{
							int num20 = list2[j - 1].Y * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX + list2[j - 1].X;
							int num21 = list2[j].Y * (int)appearance.Data.ptSceneData[0].ptCollisionHeightFields[0].info.countX + list2[j].X;
							stringBuilder.AppendLine("l " + num20.ToString() + " " + num21.ToString());
						}
						File.WriteAllText("pather.obj", stringBuilder.ToString());
					}
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BattleNetSharp.D2.Data.Generated
{
	// Token: 0x02000B18 RID: 2840
	internal class Generator
	{
		// Token: 0x0600BE82 RID: 48770 RVA: 0x0048C2BC File Offset: 0x0048A4BC
		public static void CreateCsFromTxt(string file)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = File.ReadAllLines(file);
			List<string> list = array[0].Split('\t', StringSplitOptions.None).ToList<string>();
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
			stringBuilder.AppendLine("using System;");
			stringBuilder.AppendLine("using System.Collections.Generic;");
			stringBuilder.AppendLine("namespace D2Data.Generated");
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("\tpublic class " + fileNameWithoutExtension);
			stringBuilder.AppendLine("\t{");
			List<string> list2 = new List<string>();
			for (int i = 0; i < list.Count<string>(); i++)
			{
				for (int j = 1; j < array.Count<string>(); j++)
				{
					bool flag = array[j].Split('\t', StringSplitOptions.None)[i].Length > 0;
					if (flag)
					{
						string text = "String";
						int num;
						bool flag2 = int.TryParse(array[j].Split('\t', StringSplitOptions.None)[i], out num);
						if (flag2)
						{
							text = "Int32";
						}
						stringBuilder.AppendLine(string.Concat(new string[]
						{
							"\t\tpublic ",
							text,
							" ",
							list[i].Replace("(", "").Replace("/", "").Replace(")", "")
								.Replace("*", "")
								.Replace("-", "_")
								.Replace(" ", ""),
							" = ",
							(text == "String") ? "\"\"" : "0xbeeef",
							";"
						}));
						while (list2.Count < i)
						{
							list2.Add("bad");
						}
						list2.Add(text);
						break;
					}
				}
			}
			stringBuilder.AppendLine(string.Concat(new string[] { "\t\tpublic static List<", fileNameWithoutExtension, "> ", fileNameWithoutExtension, "List = new List<", fileNameWithoutExtension, ">{" }));
			for (int k = 1; k < array.Count<string>(); k++)
			{
				List<string> list3 = new List<string>();
				for (int l = 0; l < list.Count<string>(); l++)
				{
					bool flag3 = array[k].Split('\t', StringSplitOptions.None)[l].Length > 0;
					if (flag3)
					{
						bool flag4 = list2[l] == "Int32";
						if (flag4)
						{
							list3.Add(list[l].Replace("(", "").Replace("/", "").Replace(")", "")
								.Replace("*", "")
								.Replace("-", "_")
								.Replace(" ", "") + " = " + array[k].Split('\t', StringSplitOptions.None)[l]);
						}
						else
						{
							list3.Add(list[l].Replace("(", "").Replace("/", "").Replace(")", "")
								.Replace("*", "")
								.Replace("-", "_")
								.Replace(" ", "") + " = \"" + array[k].Split('\t', StringSplitOptions.None)[l].Replace("\"", "") + "\"");
						}
					}
				}
				stringBuilder.AppendLine(string.Concat(new string[]
				{
					"\t\t\tnew ",
					fileNameWithoutExtension,
					"{ ",
					string.Join(",", list3),
					"},"
				}));
			}
			stringBuilder.AppendLine("\t\t};");
			stringBuilder.AppendLine("\t}");
			stringBuilder.AppendLine("}");
			File.WriteAllText(Path.GetFileNameWithoutExtension(file) + ".cs", stringBuilder.ToString());
		}
	}
}

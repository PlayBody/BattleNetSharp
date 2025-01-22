using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;

namespace D4Data
{
	// Token: 0x020008D3 RID: 2259
	public class ScriptedAttributeInitializer
	{
		// Token: 0x0600B666 RID: 46694 RVA: 0x002D59BC File Offset: 0x002D3BBC
		public static int Pin(int a, int b, int c)
		{
			bool flag = b > a;
			int num;
			if (flag)
			{
				num = b;
			}
			else
			{
				bool flag2 = a > c;
				if (flag2)
				{
					num = c;
				}
				else
				{
					num = a;
				}
			}
			return num;
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x002D59E8 File Offset: 0x002D3BE8
		public static float Pin(float a, float b, float c)
		{
			bool flag = b > a;
			float num;
			if (flag)
			{
				num = b;
			}
			else
			{
				bool flag2 = a > c;
				if (flag2)
				{
					num = c;
				}
				else
				{
					num = a;
				}
			}
			return num;
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x002D5A14 File Offset: 0x002D3C14
		public static void ProcessAttributes(GameAttribute[] attributes)
		{
			Dictionary<string, GameAttribute> attributeLookup = attributes.ToDictionary((GameAttribute attr) => attr.Name);
			Dictionary<GameAttribute, string> dictionary = new Dictionary<GameAttribute, string>();
			int i = 0;
			while (i < attributes.Length)
			{
				GameAttribute attr = attributes[i];
				bool flag = attr.ScriptA.Length > 0 && attr.ScriptA != "0";
				string text;
				if (flag)
				{
					text = attr.ScriptA;
					goto IL_00EB;
				}
				bool flag2 = attr.ScriptB.Length > 0 && attr.ScriptB != "0";
				if (flag2)
				{
					text = attr.ScriptB;
					goto IL_00EB;
				}
				IL_0187:
				i++;
				continue;
				IL_00EB:
				attr.ScriptedAndSettable = false;
				text = Regex.Replace(text, "([A-Za-z_]\\w*)(\\.Agg)?(\\#[A-Za-z_]\\w*)?(?=[^\\(\\w]|\\z)( \\?)?", delegate(Match match)
				{
					string value = match.Groups[1].Value;
					bool flag7 = !attributeLookup.ContainsKey(value);
					if (flag7)
					{
						throw new ScriptedAttributeInitializerError("invalid identifer parsed: " + value);
					}
					GameAttribute gameAttribute2 = attributeLookup[value];
					int? num = null;
					string text10 = "_key";
					bool flag8 = false;
					bool success = match.Groups[3].Success;
					if (success)
					{
						string text11 = match.Groups[3].Value.ToUpper();
						string text12 = text11;
						if (text12 != null)
						{
							switch (text12.Length)
							{
							case 5:
							{
								char c = text12[1];
								if (c <= 'F')
								{
									if (c != 'C')
									{
										if (c != 'F')
										{
											goto IL_0212;
										}
										if (!(text12 == "#FIRE"))
										{
											goto IL_0212;
										}
										num = new int?(1);
									}
									else
									{
										if (!(text12 == "#COLD"))
										{
											goto IL_0212;
										}
										num = new int?(3);
									}
								}
								else if (c != 'H')
								{
									if (c != 'N')
									{
										goto IL_0212;
									}
									if (!(text12 == "#NONE"))
									{
										goto IL_0212;
									}
									num = null;
								}
								else
								{
									if (!(text12 == "#HOLY"))
									{
										goto IL_0212;
									}
									num = new int?(6);
								}
								break;
							}
							case 6:
							case 8:
								goto IL_0212;
							case 7:
							{
								char c = text12[1];
								if (c != 'A')
								{
									if (c != 'P')
									{
										goto IL_0212;
									}
									if (!(text12 == "#POISON"))
									{
										goto IL_0212;
									}
									num = new int?(4);
								}
								else
								{
									if (!(text12 == "#ARCANE"))
									{
										goto IL_0212;
									}
									num = new int?(5);
								}
								break;
							}
							case 9:
								if (!(text12 == "#PHYSICAL"))
								{
									goto IL_0212;
								}
								num = new int?(0);
								break;
							case 10:
								if (!(text12 == "#LIGHTNING"))
								{
									goto IL_0212;
								}
								num = new int?(2);
								break;
							default:
								goto IL_0212;
							}
							bool flag9 = num == null;
							if (flag9)
							{
								text10 = "null";
							}
							else
							{
								text10 = num.ToString();
							}
							flag8 = true;
							goto IL_025D;
						}
						IL_0212:
						throw new ScriptedAttributeInitializerError("error processing attribute script, invalid key in identifier: " + match.Groups[3].Value);
					}
					IL_025D:
					string text13 = "";
					bool success2 = match.Groups[4].Success;
					if (success2)
					{
						text13 = ((gameAttribute2 is GameAttributeI) ? " > 0 ?" : " ?");
					}
					bool success3 = match.Groups[2].Success;
					string text14;
					if (success3)
					{
						attr.ScriptedAndSettable = true;
						text14 = string.Concat(new string[] { "_map._RawGetAttribute(GameAttribute.", value, ", ", text10, ")", text13 });
					}
					else
					{
						bool flag10 = gameAttribute2.Dependents == null;
						if (flag10)
						{
							gameAttribute2.Dependents = new List<GameAttributeDependency>();
						}
						gameAttribute2.Dependents.Add(new GameAttributeDependency(attr, num, flag8, false));
						text14 = string.Concat(new string[] { "_map[GameAttribute.", value, ", ", text10, "]", text13 });
					}
					return text14;
				});
				text = Regex.Replace(text, "floor\\(", "(float)Math.Floor(", RegexOptions.IgnoreCase);
				text = Regex.Replace(text, "max\\(", "Math.Max(", RegexOptions.IgnoreCase);
				text = Regex.Replace(text, "min\\(", "Math.Min(", RegexOptions.IgnoreCase);
				text = Regex.Replace(text, "pin\\(", "ScriptedAttributeInitializer.Pin(", RegexOptions.IgnoreCase);
				text = Regex.Replace(text, "\\d+\\.\\d+", "$0f");
				dictionary[attr] = text;
				goto IL_0187;
			}
			string text2 = Path.Combine(Path.GetTempPath(), "DFenSscriptedAttributeFuncs");
			string text3 = "";
			text3 += "//Blizzless Project 2022 \r\nusing System;\r\nusing System.Runtime;\r\nusing DFS.GameServer.AttributesSystem;\r\nusing DFS.GameServer.Base;\r\n\r\nnamespace DFS.GameServer.AttributesSystem.GeneratedCode\r\n{\r\n\tpublic class ScriptedAttributeFuncs\r\n\t{\r\n";
			foreach (KeyValuePair<GameAttribute, string> keyValuePair in dictionary)
			{
				string text4 = ((keyValuePair.Key is GameAttributeF) ? "float" : "int");
				text3 += string.Format("\t\tpublic static Func<GameAttributeMap, int?, GameAttributeValue> {0} = (_map, _key) => new GameAttributeValue(({1})({2}));", keyValuePair.Key.Name, text4, keyValuePair.Value);
			}
			text3 += "\t}\r\n}\r\n";
			SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(text3, null, "", null, default(CancellationToken));
			string location = typeof(Enumerable).GetTypeInfo().Assembly.Location;
			DirectoryInfo parent = Directory.GetParent(location);
			MetadataReference[] array = new MetadataReference[]
			{
				MetadataReference.CreateFromFile(typeof(object).Assembly.Location, default(MetadataReferenceProperties), null),
				MetadataReference.CreateFromFile(parent.FullName + Path.DirectorySeparatorChar.ToString() + "mscorlib.dll", default(MetadataReferenceProperties), null),
				MetadataReference.CreateFromFile(parent.FullName + Path.DirectorySeparatorChar.ToString() + "System.Runtime.dll", default(MetadataReferenceProperties), null),
				MetadataReference.CreateFromFile(typeof(GameAttributeValue).Assembly.Location, default(MetadataReferenceProperties), null),
				MetadataReference.CreateFromFile(typeof(GameAttributeMap).Assembly.Location, default(MetadataReferenceProperties), null)
			};
			string randomFileName = Path.GetRandomFileName();
			IEnumerable<SyntaxTree> enumerable = new SyntaxTree[] { syntaxTree };
			IEnumerable<MetadataReference> enumerable2 = array;
			OutputKind outputKind = 2;
			bool flag3 = false;
			string text5 = null;
			string text6 = null;
			string text7 = null;
			IEnumerable<string> enumerable3 = null;
			OptimizationLevel optimizationLevel = 0;
			bool flag4 = false;
			bool flag5 = false;
			string text8 = null;
			string text9 = null;
			AssemblyIdentityComparer @default = DesktopAssemblyIdentityComparer.Default;
			CSharpCompilation csharpCompilation = CSharpCompilation.Create(randomFileName, enumerable, enumerable2, new CSharpCompilationOptions(outputKind, flag3, text5, text6, text7, enumerable3, optimizationLevel, flag4, flag5, text8, text9, default(ImmutableArray<byte>), null, 0, 0, 4, null, true, false, null, null, null, @default, null, false, 0, 0));
			using (MemoryStream memoryStream = new MemoryStream())
			{
				EmitResult emitResult = csharpCompilation.Emit(memoryStream, null, null, null, null, null, null, null, null, null, default(CancellationToken));
				bool flag6 = !emitResult.Success;
				if (flag6)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendLine("encountered errors compiling attribute funcs: ");
					IEnumerable<Diagnostic> enumerable4 = emitResult.Diagnostics.Where((Diagnostic diagnostic) => diagnostic.IsWarningAsError || diagnostic.Severity == 3);
					foreach (Diagnostic diagnostic2 in enumerable4)
					{
						stringBuilder.AppendLine(string.Format("\t{0}: {1}", diagnostic2.Id, diagnostic2.GetMessage(null)));
					}
					throw new ScriptedAttributeInitializerError(stringBuilder.ToString());
				}
				memoryStream.Seek(0L, SeekOrigin.Begin);
				Assembly assembly = AssemblyLoadContext.Default.LoadFromStream(memoryStream);
				Type type = assembly.GetType("DFS.GameServer.AttributesSystem.GeneratedCode.ScriptedAttributeFuncs");
				foreach (GameAttribute gameAttribute in dictionary.Keys)
				{
					gameAttribute.ScriptFunc = (Func<GameAttributeMap, int?, GameAttributeValue>)type.GetField(gameAttribute.Name).GetValue(null);
				}
			}
		}
	}
}

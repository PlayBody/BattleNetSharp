using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Microsoft.CSharp.RuntimeBinder;
using Utilities;

namespace D4Packets
{
	// Token: 0x0200083C RID: 2108
	public class CASCPacket
	{
		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600B584 RID: 46468 RVA: 0x002C3E91 File Offset: 0x002C2091
		// (set) Token: 0x0600B585 RID: 46469 RVA: 0x002C3E99 File Offset: 0x002C2099
		public int payloadOffset { get; set; } = 0;

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600B586 RID: 46470 RVA: 0x002C3EA2 File Offset: 0x002C20A2
		// (set) Token: 0x0600B587 RID: 46471 RVA: 0x002C3EAA File Offset: 0x002C20AA
		public bool readFromPayload { get; set; } = false;

		// Token: 0x0600B588 RID: 46472 RVA: 0x002C3EB4 File Offset: 0x002C20B4
		public virtual void FromBitReader(BitReader reader)
		{
			int position = reader.Position;
			IOrderedEnumerable<FieldInfo> orderedEnumerable = from f in base.GetType().GetFields()
				orderby f.MetadataToken
				select f;
			foreach (FieldInfo fieldInfo in orderedEnumerable)
			{
				bool flag = fieldInfo.Name.Contains("j0095");
				if (flag)
				{
					Console.WriteLine(fieldInfo.Name);
				}
				int num = (this.readFromPayload ? (reader.Position / 8 - this.payloadOffset) : (reader.Position / 8));
				Type type = fieldInfo.FieldType;
				bool isEnum = fieldInfo.FieldType.IsEnum;
				if (isEnum)
				{
					type = Enum.GetUnderlyingType(fieldInfo.FieldType);
				}
				bool flag2 = type.Equals(typeof(byte));
				if (flag2)
				{
					fieldInfo.SetValue(this, reader.ReadByte());
				}
				else
				{
					bool flag3 = type.Equals(typeof(ushort));
					if (flag3)
					{
						fieldInfo.SetValue(this, reader.ReadUInt16());
					}
					else
					{
						bool flag4 = type.Equals(typeof(uint));
						if (flag4)
						{
							fieldInfo.SetValue(this, reader.ReadUInt32());
						}
						else
						{
							bool flag5 = type.Equals(typeof(ulong));
							if (flag5)
							{
								fieldInfo.SetValue(this, reader.ReadUInt64());
							}
							else
							{
								bool flag6 = type.Equals(typeof(short));
								if (flag6)
								{
									fieldInfo.SetValue(this, (short)reader.ReadUInt16());
								}
								else
								{
									bool flag7 = type.Equals(typeof(int));
									if (flag7)
									{
										fieldInfo.SetValue(this, (int)reader.ReadUInt32());
									}
									else
									{
										bool flag8 = type.Equals(typeof(long));
										if (flag8)
										{
											fieldInfo.SetValue(this, (long)reader.ReadUInt64());
										}
										else
										{
											bool flag9 = type.Equals(typeof(float));
											if (flag9)
											{
												fieldInfo.SetValue(this, BitConverter.ToSingle(reader.ReadBytes(4U)));
											}
											else
											{
												bool flag10 = type.IsAssignableTo(typeof(IMessage));
												if (flag10)
												{
													PropertyInfo property = type.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
													MessageParser messageParser = (MessageParser)property.GetValue(null);
													fieldInfo.SetValue(this, messageParser.ParseFrom(reader.ReadBlob(16UL)));
												}
												else
												{
													bool flag11 = type.Equals(typeof(string));
													if (flag11)
													{
														bool flag12 = fieldInfo.Name.Contains("_");
														if (flag12)
														{
															int num2 = int.Parse(fieldInfo.Name.Split(new char[] { '_' }).Last<string>());
														}
													}
													else
													{
														bool flag13 = type.ToString().Contains("List");
														if (flag13)
														{
															List<object> list = new List<object>();
															Type type2 = type.GetGenericArguments()[0];
															int num3 = (int)reader.ReadUInt32();
															int num4 = (int)reader.ReadUInt32();
															int num5 = (int)reader.ReadUInt32();
															int num6 = (int)reader.ReadUInt32();
															int num7 = Math.Max(num5, 0);
															int num8 = Math.Max(num6, 0);
															object obj = Activator.CreateInstance(type);
															MethodInfo method = type.GetMethod("Add");
															bool flag14 = num7 > 0 && num8 > 0;
															if (flag14)
															{
																int position2 = reader.Position;
																object obj2 = fieldInfo.GetCustomAttributes(typeof(FieldFlags), true).FirstOrDefault<object>();
																bool flag15 = obj2 != null || this.readFromPayload;
																if (flag15)
																{
																	num7 += this.payloadOffset - 16;
																	this.readFromPayload = true;
																}
																reader.Position = 8 * (num7 + 16);
																bool flag16 = this.readFromPayload && this.payloadOffset == 0;
																if (flag16)
																{
																	continue;
																}
																while (reader.Position / 8 < num7 + num8 + 16)
																{
																	bool flag17 = reader.Position / 8 - this.payloadOffset == 29568;
																	if (flag17)
																	{
																	}
																	object obj3 = Activator.CreateInstance(type2);
																	object obj4 = new object();
																	bool flag18 = obj3.GetType().IsSubclassOf(typeof(CASCPacket));
																	if (flag18)
																	{
																		CASCPacket cascpacket = (CASCPacket)Activator.CreateInstance(type2);
																		cascpacket.payloadOffset = this.payloadOffset;
																		cascpacket.readFromPayload = this.readFromPayload;
																		cascpacket.FromBitReader(reader);
																		obj4 = cascpacket;
																	}
																	else
																	{
																		bool flag19 = obj3 is ushort;
																		if (flag19)
																		{
																			obj4 = reader.ReadUInt16();
																		}
																		else
																		{
																			bool flag20 = obj3 is float;
																			if (flag20)
																			{
																				obj4 = reader.ReadSingle();
																			}
																			else
																			{
																				bool flag21 = obj3 is uint;
																				if (flag21)
																				{
																					obj4 = reader.ReadUInt32();
																				}
																				else
																				{
																					bool flag22 = obj3 is byte;
																					if (flag22)
																					{
																						obj4 = reader.ReadByte();
																					}
																				}
																			}
																		}
																	}
																	method.Invoke(obj, new object[] { obj4 });
																}
																bool flag23 = obj2 != null;
																if (flag23)
																{
																	this.readFromPayload = false;
																}
																reader.Position = position2;
															}
															fieldInfo.SetValue(this, obj);
														}
														else
														{
															bool flag24 = type.Equals(typeof(DateTime));
															if (flag24)
															{
																fieldInfo.SetValue(this, DateTime.FromBinary((long)reader.ReadUInt64()));
															}
															else
															{
																bool flag25 = type.IsSubclassOf(typeof(CASCPacket));
																if (flag25)
																{
																	Type type3 = base.GetType();
																	CASCPacket cascpacket2 = (CASCPacket)Activator.CreateInstance(type);
																	cascpacket2.payloadOffset = this.payloadOffset;
																	cascpacket2.readFromPayload = this.readFromPayload;
																	cascpacket2.FromBitReader(reader);
																	fieldInfo.SetValue(this, cascpacket2);
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

        // Token: 0x0600B589 RID: 46473 RVA: 0x002C44E0 File Offset: 0x002C26E0
        public override string ToString()
        {
            var fields = GetType().GetFields().OrderBy(f => f.MetadataToken);
            string result = "";

            foreach (var field in fields)
            {
                var value = field.GetValue(this);
                result += $"\t{field.Name}({value?.GetType() ?? typeof(object)}) = {value}\n";

                // Handle fields that are lists or collections
                if (field.FieldType.ToString().Contains("List") && value is IEnumerable enumerable)
                {
                    if (enumerable == null)
                    {
                        result += "\t\tnull\n";
                    }
                    else
                    {
                        foreach (var item in enumerable)
                        {
                            result += $"\t\t{item?.ToString() ?? "null"}\n";
                        }
                    }
                }
            }

            return result;
        }
    }
}

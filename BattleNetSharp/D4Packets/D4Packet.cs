using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using BattleNetSharp;
using BattleNetSharp.D4.Packets;
using Google.Protobuf;
using Lz4;
using Microsoft.CSharp.RuntimeBinder;
using Utilities;

namespace D4Packets
{
	// Token: 0x0200083D RID: 2109
	public class D4Packet
	{
		// Token: 0x0600B58B RID: 46475 RVA: 0x002C4913 File Offset: 0x002C2B13
		public D4Packet()
		{
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x002C491D File Offset: 0x002C2B1D
		public D4Packet(BitReaderD4 dr)
		{
			this.FromBitReader(dr);
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x002C4930 File Offset: 0x002C2B30
		public static D4Packet GetPacket(byte[] packetBytes, Crypto crypto, out int size)
		{
			UPPacket uppacket = new UPPacket();
			bool flag = crypto != null;
			if (flag)
			{
				uppacket = new UPPacket(packetBytes);
				size = 3 + uppacket.PacketSize;
				crypto.Crypt.Decrypt(crypto.IV, uppacket.Data, uppacket.Tag, uppacket.Data, null);
				crypto.Counter += 1U;
			}
			else
			{
				uppacket.Compressed = false;
				uppacket.Data = packetBytes;
				size = 0;
			}
			bool compressed = uppacket.Compressed;
			if (compressed)
			{
				uppacket.Data = Lz4DecoderStream.Decompress(uppacket.Data);
			}
			BitReaderD4 bitReaderD = new BitReaderD4(32768);
			bitReaderD.AppendData(uppacket.Data);
			int num = bitReaderD.ReadInt(11);
			string[] array = new string[6];
			array[0] = "recv : ";
			array[1] = num.ToString();
			array[2] = " : ";
			int num2 = 3;
			Opcodes opcodes = (Opcodes)num;
			array[num2] = opcodes.ToString();
			array[4] = " : ";
			array[5] = Convert.ToHexString(uppacket.Data);
			Console.WriteLine(string.Concat(array));
			bool flag2 = D4Packet.opcodeClassDict.ContainsKey((Opcodes)num);
			D4Packet d4Packet2;
			if (flag2)
			{
				bitReaderD = new BitReaderD4(32768);
				bitReaderD.AppendData(uppacket.Data);
				D4Packet d4Packet = (D4Packet)Activator.CreateInstance(D4Packet.opcodeClassDict[(Opcodes)num]);
				d4Packet.FromBitReader(bitReaderD);
				d4Packet2 = d4Packet;
			}
			else
			{
				d4Packet2 = null;
			}
			return d4Packet2;
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x002C4A90 File Offset: 0x002C2C90
		public object Read(Type fieldType, BitReaderD4 reader, uint? bitLen, int? maxStringLen)
		{
			uint? num = bitLen;
			uint num2 = 0U;
			bool flag = (num.GetValueOrDefault() > num2) & (num != null);
			object obj;
			if (flag)
			{
				obj = Convert.ChangeType(reader.ReadInt((int)bitLen.Value), fieldType);
			}
			else
			{
				bool isEnum = fieldType.IsEnum;
				if (isEnum)
				{
					fieldType = Enum.GetUnderlyingType(fieldType);
				}
				bool flag2 = fieldType.Equals(typeof(byte));
				if (flag2)
				{
					obj = reader.ReadByte();
				}
				else
				{
					bool flag3 = fieldType.Equals(typeof(bool));
					if (flag3)
					{
						obj = reader.ReadBool();
					}
					else
					{
						bool flag4 = fieldType.Equals(typeof(ushort));
						if (flag4)
						{
							obj = reader.ReadUInt16();
						}
						else
						{
							bool flag5 = fieldType.Equals(typeof(uint));
							if (flag5)
							{
								obj = reader.ReadUInt32();
							}
							else
							{
								bool flag6 = fieldType.Equals(typeof(ulong));
								if (flag6)
								{
									obj = reader.ReadUInt64(64);
								}
								else
								{
									bool flag7 = fieldType.Equals(typeof(short));
									if (flag7)
									{
										obj = (short)reader.ReadInt(16);
									}
									else
									{
										bool flag8 = fieldType.Equals(typeof(int));
										if (flag8)
										{
											obj = reader.ReadInt(32);
										}
										else
										{
											bool flag9 = fieldType.Equals(typeof(long));
											if (flag9)
											{
												obj = reader.ReadInt64(64);
											}
											else
											{
												bool flag10 = fieldType.Equals(typeof(float));
												if (flag10)
												{
													obj = reader.ReadFloat32();
												}
												else
												{
													bool flag11 = fieldType.IsAssignableTo(typeof(IMessage));
													if (flag11)
													{
														PropertyInfo property = fieldType.GetProperty("Parser", BindingFlags.Static | BindingFlags.Public);
														MessageParser messageParser = (MessageParser)property.GetValue(null);
														byte[] array = reader.ReadBlob(16);
														Console.WriteLine(Convert.ToHexString(array));
														obj = messageParser.ParseFrom(array);
													}
													else
													{
														bool flag12 = fieldType.Equals(typeof(string));
														if (flag12)
														{
															obj = reader.ReadCharArray(maxStringLen.Value);
														}
														else
														{
															bool flag13 = fieldType.Equals(typeof(DateTime));
															if (flag13)
															{
																obj = DateTime.FromBinary((long)reader.ReadUInt64(64));
															}
															else
															{
																bool flag14 = fieldType.IsSubclassOf(typeof(D4Packet));
																if (!flag14)
																{
																	string text = "need to parse this type : ";
																	Type type = fieldType;
																	throw new Exception(text + ((type != null) ? type.ToString() : null));
																}
																D4Packet d4Packet = (D4Packet)Activator.CreateInstance(fieldType);
																d4Packet.FromBitReader(reader);
																obj = d4Packet;
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
			return obj;
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x002C4D50 File Offset: 0x002C2F50
		public virtual void FromBitReader(BitReaderD4 reader)
		{
			object obj = base.GetType().GetCustomAttributes(false).FirstOrDefault((object a) => a is D4Packet.OpcodeAttribute);
			bool flag = obj != null;
			if (flag)
			{
				int num = reader.ReadInt(11);
				int num2 = reader.ReadInt(2);
				bool flag2 = reader.ReadBool();
			}
			IOrderedEnumerable<FieldInfo> orderedEnumerable = from f in base.GetType().GetFields()
				orderby f.MetadataToken
				select f;
			foreach (FieldInfo fieldInfo in orderedEnumerable)
			{
				DynamicLen dynamicLen = (DynamicLen)fieldInfo.GetCustomAttributes(typeof(DynamicLen), true).FirstOrDefault<object>();
				FixedLen fixedLen = (FixedLen)fieldInfo.GetCustomAttributes(typeof(FixedLen), true).FirstOrDefault<object>();
				Type type = fieldInfo.FieldType;
				bool flag3 = D4Packet.nullable.Create(fieldInfo).WriteState == NullabilityState.Nullable;
				if (flag3)
				{
					bool flag4 = !reader.ReadBool();
					if (flag4)
					{
						continue;
					}
					bool flag5 = type.GenericTypeArguments.Length != 0;
					if (flag5)
					{
						type = type.GenericTypeArguments[0];
					}
				}
				bool isArray = type.IsArray;
				if (isArray)
				{
					type = type.GetElementType();
					uint num3 = ((fixedLen != null) ? fixedLen.len : ((dynamicLen != null) ? reader.ReadUInt(dynamicLen.len) : 0U));
					Array array = Array.CreateInstance(type, new long[] { (long)((ulong)num3) });
					int num4 = 0;
					while ((long)num4 < (long)((ulong)num3))
					{
						array.SetValue(this.Read(type, reader, new uint?(0U), new int?(0)), num4);
						num4++;
					}
					fieldInfo.SetValue(this, array);
				}
				else
				{
					fieldInfo.SetValue(this, this.Read(type, reader, (fixedLen != null) ? new uint?(fixedLen.len) : null, (dynamicLen != null) ? new int?(dynamicLen.len) : null));
				}
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x002C4FA8 File Offset: 0x002C31A8
		private static NullabilityInfoContext nullable
		{
			get
			{
				return new NullabilityInfoContext();
			}
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x002C4FB0 File Offset: 0x002C31B0
		public void Write(object val, BitReaderD4 writer, uint? bitLen, int? stringMaxLen)
		{
			uint? num = bitLen;
			uint num2 = 0U;
			bool flag = (num.GetValueOrDefault() > num2) & (num != null);
			if (flag)
			{
				writer.WriteInt((int)bitLen.Value, (int)Convert.ChangeType(val, typeof(int)));
			}
			else
			{
				bool isEnum = val.GetType().IsEnum;
				if (isEnum)
				{
					val = Convert.ChangeType(val, Type.GetTypeCode(Enum.GetUnderlyingType(val.GetType())));
				}
				bool flag2 = val is byte;
				if (flag2)
				{
					writer.Write((byte)val);
				}
				else
				{
					bool flag3 = val is bool;
					if (flag3)
					{
						writer.WriteBool((bool)val);
					}
					else
					{
						bool flag4 = val is ushort;
						if (flag4)
						{
							writer.Write((ushort)val);
						}
						else
						{
							bool flag5 = val is uint;
							if (flag5)
							{
								writer.Write((uint)val);
							}
							else
							{
								bool flag6 = val is ulong;
								if (flag6)
								{
									writer.Write((ulong)val);
								}
								else
								{
									bool flag7 = val is short;
									if (flag7)
									{
										writer.Write((short)val);
									}
									else
									{
										bool flag8 = val is int;
										if (flag8)
										{
											writer.Write((int)val);
										}
										else
										{
											bool flag9 = val is long;
											if (flag9)
											{
												writer.Write((long)val);
											}
											else
											{
												bool flag10 = val is float;
												if (flag10)
												{
													writer.WriteFloat32((float)val);
												}
												else
												{
													bool isEnum2 = val.GetType().IsEnum;
													if (isEnum2)
													{
														writer.Write((uint)val);
													}
													else
													{
														bool flag11 = val is string;
														if (flag11)
														{
															writer.WriteCharArray(stringMaxLen.Value, (string)val);
														}
														else
														{
															bool flag12 = val is DateTime;
															if (flag12)
															{
																writer.Write(((DateTime)val).ToBinary());
															}
															else
															{
																bool flag13 = val is IMessage;
																if (flag13)
																{
																	Console.WriteLine(Convert.ToHexString(MessageExtensions.ToByteArray((IMessage)val)));
																	writer.WriteBlob(16, MessageExtensions.ToByteArray((IMessage)val));
																}
																else
																{
																	bool flag14 = val is D4Packet;
																	if (!flag14)
																	{
																		string text = "need to parse this type : ";
																		Type type = val.GetType();
																		throw new Exception(text + ((type != null) ? type.ToString() : null));
																	}
																	((D4Packet)val).Write(writer);
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

		// Token: 0x0600B592 RID: 46482 RVA: 0x002C5240 File Offset: 0x002C3440
		public void Write(BitReaderD4 writer)
		{
			IOrderedEnumerable<FieldInfo> orderedEnumerable = from f in base.GetType().GetFields()
				orderby f.MetadataToken
				select f;
			foreach (FieldInfo fieldInfo in orderedEnumerable)
			{
				DynamicLen dynamicLen = (DynamicLen)fieldInfo.GetCustomAttributes(typeof(DynamicLen), true).FirstOrDefault<object>();
				FixedLen fixedLen = (FixedLen)fieldInfo.GetCustomAttributes(typeof(FixedLen), true).FirstOrDefault<object>();
				object obj = fieldInfo.GetValue(this);
				bool flag = D4Packet.nullable.Create(fieldInfo).WriteState == NullabilityState.Nullable;
				if (flag)
				{
					writer.WriteBool(obj != null);
					bool flag2 = obj == null;
					if (flag2)
					{
						continue;
					}
				}
				bool flag3 = !fieldInfo.FieldType.IsArray && obj == null;
				if (flag3)
				{
					obj = Activator.CreateInstance(fieldInfo.FieldType);
				}
				bool isArray = fieldInfo.FieldType.IsArray;
				if (isArray)
				{
					bool flag4 = dynamicLen != null;
					if (flag4)
					{
						int num = 0;
						bool flag5 = obj != null;
						if (flag5)
						{
							foreach (object obj2 in ((IEnumerable)obj))
							{
								num++;
							}
						}
						writer.WriteInt(dynamicLen.len, num);
					}
					bool flag6 = obj != null;
					if (flag6)
					{
						foreach (object obj3 in ((IEnumerable)obj))
						{
							this.Write(obj3 ?? Activator.CreateInstance(fieldInfo.FieldType.GetElementType()), writer, new uint?(0U), new int?(0));
						}
					}
				}
				else
				{
					this.Write(obj, writer, (fixedLen != null) ? new uint?(fixedLen.len) : null, (dynamicLen != null) ? new int?(dynamicLen.len) : null);
				}
			}
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x002C54CC File Offset: 0x002C36CC
		public virtual byte[] ToArray()
		{
			BitReaderD4 bitReaderD = new BitReaderD4(32768);
			object obj = base.GetType().GetCustomAttributes(false).FirstOrDefault((object a) => a is D4Packet.OpcodeAttribute);
			bool flag = obj != null;
			if (flag)
			{
				int opcode = (int)(obj as D4Packet.OpcodeAttribute).Opcode;
				bitReaderD.WriteInt(11, opcode);
				bitReaderD.WriteInt(2, 1);
				bitReaderD.WriteBool(false);
			}
			this.Write(bitReaderD);
			byte[] allBufferBytes = bitReaderD.GetAllBufferBytes();
			bool flag2 = obj != null;
			if (flag2)
			{
				Console.WriteLine(string.Concat(new string[]
				{
					"send : ",
					((int)(obj as D4Packet.OpcodeAttribute).Opcode).ToString(),
					" : ",
					(obj as D4Packet.OpcodeAttribute).Opcode.ToString(),
					" : ",
					Convert.ToHexString(allBufferBytes)
				}));
			}
			return allBufferBytes;
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x002C55D0 File Offset: 0x002C37D0
		public virtual byte[] ToEncryptedArray(Crypto crypto)
		{
			UPPacket uppacket = new UPPacket();
			uppacket.Compressed = false;
			uppacket.Data = this.ToArray();
			crypto.Crypt.Encrypt(crypto.IV, uppacket.Data, uppacket.Data, uppacket.Tag, null);
			crypto.Counter += 1U;
			return uppacket.GetBytes();
		}

        // Token: 0x0600B595 RID: 46485 RVA: 0x002C5634 File Offset: 0x002C3834
        public override string ToString()
        {
            var orderedFields = GetType().GetFields().OrderBy(f => f.MetadataToken);
            string result = "";

            foreach (var field in orderedFields)
            {
                var value = field.GetValue(this);
                result += $"\t{field.Name}({value?.GetType() ?? typeof(object)}) = {value}\n";

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

        // Token: 0x0400627A RID: 25210
        public static Dictionary<Opcodes, Type> opcodeClassDict = (from t in typeof(D4Packet).Assembly.GetTypes()
			where t.IsSubclassOf(typeof(D4Packet)) && !t.IsAbstract && (D4Packet.OpcodeAttribute)Attribute.GetCustomAttribute(t, typeof(D4Packet.OpcodeAttribute), false) != null
			select t).ToDictionary((Type x) => ((D4Packet.OpcodeAttribute)Attribute.GetCustomAttribute(x, typeof(D4Packet.OpcodeAttribute), false)).Opcode, (Type x) => x);

		// Token: 0x020012EC RID: 4844
		[AttributeUsage(AttributeTargets.Class)]
		public class OpcodeAttribute : Attribute
		{
			// Token: 0x1700396B RID: 14699
			// (get) Token: 0x0600DEA8 RID: 57000 RVA: 0x004C205C File Offset: 0x004C025C
			// (set) Token: 0x0600DEA9 RID: 57001 RVA: 0x004C2064 File Offset: 0x004C0264
			public Opcodes Opcode { get; private set; }

			// Token: 0x0600DEAA RID: 57002 RVA: 0x004C206D File Offset: 0x004C026D
			public OpcodeAttribute(Opcodes opcode)
			{
				this.Opcode = opcode;
			}
		}
	}
}

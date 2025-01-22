using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000046 RID: 70
	public sealed class AnimPermutationInformation : IMessage<AnimPermutationInformation>, IMessage, IEquatable<AnimPermutationInformation>, IDeepCloneable<AnimPermutationInformation>, IBufferMessage
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00019F5C File Offset: 0x0001815C
		[DebuggerNonUserCode]
		public static MessageParser<AnimPermutationInformation> Parser
		{
			get
			{
				return AnimPermutationInformation._parser;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00019F74 File Offset: 0x00018174
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[47];
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00019F98 File Offset: 0x00018198
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimPermutationInformation.Descriptor;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00019FAF File Offset: 0x000181AF
		[DebuggerNonUserCode]
		public AnimPermutationInformation()
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00019FBC File Offset: 0x000181BC
		[DebuggerNonUserCode]
		public AnimPermutationInformation(AnimPermutationInformation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.permutationIndex_ = other.permutationIndex_;
			this.payloadSize_ = other.payloadSize_;
			this.removedOnGen8_ = other.removedOnGen8_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001A020 File Offset: 0x00018220
		[DebuggerNonUserCode]
		public AnimPermutationInformation Clone()
		{
			return new AnimPermutationInformation(this);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001A038 File Offset: 0x00018238
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0001A069 File Offset: 0x00018269
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = AnimPermutationInformation.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001A084 File Offset: 0x00018284
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001A0A1 File Offset: 0x000182A1
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001A0B4 File Offset: 0x000182B4
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0001A0E5 File Offset: 0x000182E5
		[DebuggerNonUserCode]
		public int PermutationIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int permutationIndexDefaultValue;
				if (flag)
				{
					permutationIndexDefaultValue = this.permutationIndex_;
				}
				else
				{
					permutationIndexDefaultValue = AnimPermutationInformation.PermutationIndexDefaultValue;
				}
				return permutationIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.permutationIndex_ = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001A100 File Offset: 0x00018300
		[DebuggerNonUserCode]
		public bool HasPermutationIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001A11D File Offset: 0x0001831D
		[DebuggerNonUserCode]
		public void ClearPermutationIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001A130 File Offset: 0x00018330
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0001A161 File Offset: 0x00018361
		[DebuggerNonUserCode]
		public float PayloadSize
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float payloadSizeDefaultValue;
				if (flag)
				{
					payloadSizeDefaultValue = this.payloadSize_;
				}
				else
				{
					payloadSizeDefaultValue = AnimPermutationInformation.PayloadSizeDefaultValue;
				}
				return payloadSizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.payloadSize_ = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001A17C File Offset: 0x0001837C
		[DebuggerNonUserCode]
		public bool HasPayloadSize
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001A199 File Offset: 0x00018399
		[DebuggerNonUserCode]
		public void ClearPayloadSize()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001A1AC File Offset: 0x000183AC
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0001A1DD File Offset: 0x000183DD
		[DebuggerNonUserCode]
		public bool RemovedOnGen8
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool removedOnGen8DefaultValue;
				if (flag)
				{
					removedOnGen8DefaultValue = this.removedOnGen8_;
				}
				else
				{
					removedOnGen8DefaultValue = AnimPermutationInformation.RemovedOnGen8DefaultValue;
				}
				return removedOnGen8DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.removedOnGen8_ = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001A1F8 File Offset: 0x000183F8
		[DebuggerNonUserCode]
		public bool HasRemovedOnGen8
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001A215 File Offset: 0x00018415
		[DebuggerNonUserCode]
		public void ClearRemovedOnGen8()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001A228 File Offset: 0x00018428
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimPermutationInformation);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001A248 File Offset: 0x00018448
		[DebuggerNonUserCode]
		public bool Equals(AnimPermutationInformation other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PermutationIndex != other.PermutationIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PayloadSize, other.PayloadSize);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.RemovedOnGen8 != other.RemovedOnGen8;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001A300 File Offset: 0x00018500
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				num ^= this.PermutationIndex.GetHashCode();
			}
			bool hasPayloadSize = this.HasPayloadSize;
			if (hasPayloadSize)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PayloadSize);
			}
			bool hasRemovedOnGen = this.HasRemovedOnGen8;
			if (hasRemovedOnGen)
			{
				num ^= this.RemovedOnGen8.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001A3AC File Offset: 0x000185AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001A3C4 File Offset: 0x000185C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001A3D0 File Offset: 0x000185D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PermutationIndex);
			}
			bool hasPayloadSize = this.HasPayloadSize;
			if (hasPayloadSize)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PayloadSize);
			}
			bool hasRemovedOnGen = this.HasRemovedOnGen8;
			if (hasRemovedOnGen)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.RemovedOnGen8);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001A484 File Offset: 0x00018684
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PermutationIndex);
			}
			bool hasPayloadSize = this.HasPayloadSize;
			if (hasPayloadSize)
			{
				num += 5;
			}
			bool hasRemovedOnGen = this.HasRemovedOnGen8;
			if (hasRemovedOnGen)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001A514 File Offset: 0x00018714
		[DebuggerNonUserCode]
		public void MergeFrom(AnimPermutationInformation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasPermutationIndex = other.HasPermutationIndex;
				if (hasPermutationIndex)
				{
					this.PermutationIndex = other.PermutationIndex;
				}
				bool hasPayloadSize = other.HasPayloadSize;
				if (hasPayloadSize)
				{
					this.PayloadSize = other.PayloadSize;
				}
				bool hasRemovedOnGen = other.HasRemovedOnGen8;
				if (hasRemovedOnGen)
				{
					this.RemovedOnGen8 = other.RemovedOnGen8;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001A5AA File Offset: 0x000187AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001A5B8 File Offset: 0x000187B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.PermutationIndex = input.ReadInt32();
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.RemovedOnGen8 = input.ReadBool();
				}
				else
				{
					this.PayloadSize = input.ReadFloat();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400025E RID: 606
		private static readonly MessageParser<AnimPermutationInformation> _parser = new MessageParser<AnimPermutationInformation>(() => new AnimPermutationInformation());

		// Token: 0x0400025F RID: 607
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000260 RID: 608
		private int _hasBits0;

		// Token: 0x04000261 RID: 609
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000262 RID: 610
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x04000263 RID: 611
		private int snoHandle_;

		// Token: 0x04000264 RID: 612
		public const int PermutationIndexFieldNumber = 2;

		// Token: 0x04000265 RID: 613
		private static readonly int PermutationIndexDefaultValue = 0;

		// Token: 0x04000266 RID: 614
		private int permutationIndex_;

		// Token: 0x04000267 RID: 615
		public const int PayloadSizeFieldNumber = 3;

		// Token: 0x04000268 RID: 616
		private static readonly float PayloadSizeDefaultValue = 0f;

		// Token: 0x04000269 RID: 617
		private float payloadSize_;

		// Token: 0x0400026A RID: 618
		public const int RemovedOnGen8FieldNumber = 4;

		// Token: 0x0400026B RID: 619
		private static readonly bool RemovedOnGen8DefaultValue = false;

		// Token: 0x0400026C RID: 620
		private bool removedOnGen8_;
	}
}

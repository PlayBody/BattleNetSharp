using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F9 RID: 505
	public sealed class DebugLootInstanceMessage : IMessage<DebugLootInstanceMessage>, IMessage, IEquatable<DebugLootInstanceMessage>, IDeepCloneable<DebugLootInstanceMessage>, IBufferMessage
	{
		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x000DB400 File Offset: 0x000D9600
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootInstanceMessage> Parser
		{
			get
			{
				return DebugLootInstanceMessage._parser;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x000DB418 File Offset: 0x000D9618
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[62];
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x000DB43C File Offset: 0x000D963C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootInstanceMessage.Descriptor;
			}
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x000DB453 File Offset: 0x000D9653
		[DebuggerNonUserCode]
		public DebugLootInstanceMessage()
		{
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x000DB460 File Offset: 0x000D9660
		[DebuggerNonUserCode]
		public DebugLootInstanceMessage(DebugLootInstanceMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.instanceId_ = other.instanceId_;
			this.end_ = other.end_;
			this.looter_ = ((other.looter_ != null) ? other.looter_.Clone() : null);
			this.lootee_ = ((other.lootee_ != null) ? other.lootee_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x000DB4E4 File Offset: 0x000D96E4
		[DebuggerNonUserCode]
		public DebugLootInstanceMessage Clone()
		{
			return new DebugLootInstanceMessage(this);
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x000DB4FC File Offset: 0x000D96FC
		// (set) Token: 0x06003776 RID: 14198 RVA: 0x000DB52D File Offset: 0x000D972D
		[DebuggerNonUserCode]
		public uint InstanceId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint instanceIdDefaultValue;
				if (flag)
				{
					instanceIdDefaultValue = this.instanceId_;
				}
				else
				{
					instanceIdDefaultValue = DebugLootInstanceMessage.InstanceIdDefaultValue;
				}
				return instanceIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.instanceId_ = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x000DB548 File Offset: 0x000D9748
		[DebuggerNonUserCode]
		public bool HasInstanceId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x000DB565 File Offset: 0x000D9765
		[DebuggerNonUserCode]
		public void ClearInstanceId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x000DB578 File Offset: 0x000D9778
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x000DB5A9 File Offset: 0x000D97A9
		[DebuggerNonUserCode]
		public bool End
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool endDefaultValue;
				if (flag)
				{
					endDefaultValue = this.end_;
				}
				else
				{
					endDefaultValue = DebugLootInstanceMessage.EndDefaultValue;
				}
				return endDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.end_ = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x000DB5C4 File Offset: 0x000D97C4
		[DebuggerNonUserCode]
		public bool HasEnd
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x000DB5E1 File Offset: 0x000D97E1
		[DebuggerNonUserCode]
		public void ClearEnd()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x000DB5F4 File Offset: 0x000D97F4
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x000DB60C File Offset: 0x000D980C
		[DebuggerNonUserCode]
		public DebugLootActorInfo Looter
		{
			get
			{
				return this.looter_;
			}
			set
			{
				this.looter_ = value;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x000DB618 File Offset: 0x000D9818
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x000DB630 File Offset: 0x000D9830
		[DebuggerNonUserCode]
		public DebugLootActorInfo Lootee
		{
			get
			{
				return this.lootee_;
			}
			set
			{
				this.lootee_ = value;
			}
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x000DB63C File Offset: 0x000D983C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootInstanceMessage);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x000DB65C File Offset: 0x000D985C
		[DebuggerNonUserCode]
		public bool Equals(DebugLootInstanceMessage other)
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
					bool flag4 = this.InstanceId != other.InstanceId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.End != other.End;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Looter, other.Looter);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Lootee, other.Lootee);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000DB710 File Offset: 0x000D9910
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num ^= this.InstanceId.GetHashCode();
			}
			bool hasEnd = this.HasEnd;
			if (hasEnd)
			{
				num ^= this.End.GetHashCode();
			}
			bool flag = this.looter_ != null;
			if (flag)
			{
				num ^= this.Looter.GetHashCode();
			}
			bool flag2 = this.lootee_ != null;
			if (flag2)
			{
				num ^= this.Lootee.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000DB7B8 File Offset: 0x000D99B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000DB7D0 File Offset: 0x000D99D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x000DB7DC File Offset: 0x000D99DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.InstanceId);
			}
			bool hasEnd = this.HasEnd;
			if (hasEnd)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.End);
			}
			bool flag = this.looter_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Looter);
			}
			bool flag2 = this.lootee_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Lootee);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000DB898 File Offset: 0x000D9A98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInstanceId = this.HasInstanceId;
			if (hasInstanceId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InstanceId);
			}
			bool hasEnd = this.HasEnd;
			if (hasEnd)
			{
				num += 2;
			}
			bool flag = this.looter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Looter);
			}
			bool flag2 = this.lootee_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lootee);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000DB93C File Offset: 0x000D9B3C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootInstanceMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInstanceId = other.HasInstanceId;
				if (hasInstanceId)
				{
					this.InstanceId = other.InstanceId;
				}
				bool hasEnd = other.HasEnd;
				if (hasEnd)
				{
					this.End = other.End;
				}
				bool flag2 = other.looter_ != null;
				if (flag2)
				{
					bool flag3 = this.looter_ == null;
					if (flag3)
					{
						this.Looter = new DebugLootActorInfo();
					}
					this.Looter.MergeFrom(other.Looter);
				}
				bool flag4 = other.lootee_ != null;
				if (flag4)
				{
					bool flag5 = this.lootee_ == null;
					if (flag5)
					{
						this.Lootee = new DebugLootActorInfo();
					}
					this.Lootee.MergeFrom(other.Lootee);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000DBA1F File Offset: 0x000D9C1F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x000DBA2C File Offset: 0x000D9C2C
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
							goto IL_002B;
						}
						this.End = input.ReadBool();
					}
					else
					{
						this.InstanceId = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002B;
					}
					bool flag = this.lootee_ == null;
					if (flag)
					{
						this.Lootee = new DebugLootActorInfo();
					}
					input.ReadMessage(this.Lootee);
				}
				else
				{
					bool flag2 = this.looter_ == null;
					if (flag2)
					{
						this.Looter = new DebugLootActorInfo();
					}
					input.ReadMessage(this.Looter);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040019D7 RID: 6615
		private static readonly MessageParser<DebugLootInstanceMessage> _parser = new MessageParser<DebugLootInstanceMessage>(() => new DebugLootInstanceMessage());

		// Token: 0x040019D8 RID: 6616
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019D9 RID: 6617
		private int _hasBits0;

		// Token: 0x040019DA RID: 6618
		public const int InstanceIdFieldNumber = 1;

		// Token: 0x040019DB RID: 6619
		private static readonly uint InstanceIdDefaultValue = 0U;

		// Token: 0x040019DC RID: 6620
		private uint instanceId_;

		// Token: 0x040019DD RID: 6621
		public const int EndFieldNumber = 2;

		// Token: 0x040019DE RID: 6622
		private static readonly bool EndDefaultValue = false;

		// Token: 0x040019DF RID: 6623
		private bool end_;

		// Token: 0x040019E0 RID: 6624
		public const int LooterFieldNumber = 3;

		// Token: 0x040019E1 RID: 6625
		private DebugLootActorInfo looter_;

		// Token: 0x040019E2 RID: 6626
		public const int LooteeFieldNumber = 4;

		// Token: 0x040019E3 RID: 6627
		private DebugLootActorInfo lootee_;
	}
}

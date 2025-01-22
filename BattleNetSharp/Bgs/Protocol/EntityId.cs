using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000357 RID: 855
	public sealed class EntityId : IMessage<EntityId>, IMessage, IEquatable<EntityId>, IDeepCloneable<EntityId>, IBufferMessage
	{
		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x060058AC RID: 22700 RVA: 0x00157010 File Offset: 0x00155210
		[DebuggerNonUserCode]
		public static MessageParser<EntityId> Parser
		{
			get
			{
				return EntityId._parser;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x060058AD RID: 22701 RVA: 0x00157028 File Offset: 0x00155228
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EntityTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x0015704C File Offset: 0x0015524C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityId.Descriptor;
			}
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00157063 File Offset: 0x00155263
		[DebuggerNonUserCode]
		public EntityId()
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x0015706D File Offset: 0x0015526D
		[DebuggerNonUserCode]
		public EntityId(EntityId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.high_ = other.high_;
			this.low_ = other.low_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x001570AC File Offset: 0x001552AC
		[DebuggerNonUserCode]
		public EntityId Clone()
		{
			return new EntityId(this);
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x060058B2 RID: 22706 RVA: 0x001570C4 File Offset: 0x001552C4
		// (set) Token: 0x060058B3 RID: 22707 RVA: 0x001570F5 File Offset: 0x001552F5
		[DebuggerNonUserCode]
		public ulong High
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong highDefaultValue;
				if (flag)
				{
					highDefaultValue = this.high_;
				}
				else
				{
					highDefaultValue = EntityId.HighDefaultValue;
				}
				return highDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.high_ = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060058B4 RID: 22708 RVA: 0x00157110 File Offset: 0x00155310
		[DebuggerNonUserCode]
		public bool HasHigh
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x0015712D File Offset: 0x0015532D
		[DebuggerNonUserCode]
		public void ClearHigh()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x00157140 File Offset: 0x00155340
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x00157171 File Offset: 0x00155371
		[DebuggerNonUserCode]
		public ulong Low
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong lowDefaultValue;
				if (flag)
				{
					lowDefaultValue = this.low_;
				}
				else
				{
					lowDefaultValue = EntityId.LowDefaultValue;
				}
				return lowDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.low_ = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x0015718C File Offset: 0x0015538C
		[DebuggerNonUserCode]
		public bool HasLow
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x001571A9 File Offset: 0x001553A9
		[DebuggerNonUserCode]
		public void ClearLow()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x001571BC File Offset: 0x001553BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityId);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x001571DC File Offset: 0x001553DC
		[DebuggerNonUserCode]
		public bool Equals(EntityId other)
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
					bool flag4 = this.High != other.High;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Low != other.Low;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00157250 File Offset: 0x00155450
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHigh = this.HasHigh;
			if (hasHigh)
			{
				num ^= this.High.GetHashCode();
			}
			bool hasLow = this.HasLow;
			if (hasLow)
			{
				num ^= this.Low.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x001572BC File Offset: 0x001554BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x001572D4 File Offset: 0x001554D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x001572E0 File Offset: 0x001554E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHigh = this.HasHigh;
			if (hasHigh)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.High);
			}
			bool hasLow = this.HasLow;
			if (hasLow)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(this.Low);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00157350 File Offset: 0x00155550
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHigh = this.HasHigh;
			if (hasHigh)
			{
				num += 9;
			}
			bool hasLow = this.HasLow;
			if (hasLow)
			{
				num += 9;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x001573A8 File Offset: 0x001555A8
		[DebuggerNonUserCode]
		public void MergeFrom(EntityId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHigh = other.HasHigh;
				if (hasHigh)
				{
					this.High = other.High;
				}
				bool hasLow = other.HasLow;
				if (hasLow)
				{
					this.Low = other.Low;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x0015740A File Offset: 0x0015560A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00157418 File Offset: 0x00155618
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 9U)
				{
					if (num3 != 17U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Low = input.ReadFixed64();
					}
				}
				else
				{
					this.High = input.ReadFixed64();
				}
			}
		}

		// Token: 0x04002875 RID: 10357
		private static readonly MessageParser<EntityId> _parser = new MessageParser<EntityId>(() => new EntityId());

		// Token: 0x04002876 RID: 10358
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002877 RID: 10359
		private int _hasBits0;

		// Token: 0x04002878 RID: 10360
		public const int HighFieldNumber = 1;

		// Token: 0x04002879 RID: 10361
		private static readonly ulong HighDefaultValue = 0UL;

		// Token: 0x0400287A RID: 10362
		private ulong high_;

		// Token: 0x0400287B RID: 10363
		public const int LowFieldNumber = 2;

		// Token: 0x0400287C RID: 10364
		private static readonly ulong LowDefaultValue = 0UL;

		// Token: 0x0400287D RID: 10365
		private ulong low_;
	}
}

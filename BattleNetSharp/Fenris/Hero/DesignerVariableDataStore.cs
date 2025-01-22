using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B1 RID: 433
	public sealed class DesignerVariableDataStore : IMessage<DesignerVariableDataStore>, IMessage, IEquatable<DesignerVariableDataStore>, IDeepCloneable<DesignerVariableDataStore>, IBufferMessage
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000B2B5C File Offset: 0x000B0D5C
		[DebuggerNonUserCode]
		public static MessageParser<DesignerVariableDataStore> Parser
		{
			get
			{
				return DesignerVariableDataStore._parser;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000B2B74 File Offset: 0x000B0D74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000B2B98 File Offset: 0x000B0D98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DesignerVariableDataStore.Descriptor;
			}
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000B2BAF File Offset: 0x000B0DAF
		[DebuggerNonUserCode]
		public DesignerVariableDataStore()
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000B2BB9 File Offset: 0x000B0DB9
		[DebuggerNonUserCode]
		public DesignerVariableDataStore(DesignerVariableDataStore other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.trackedValue_ = other.trackedValue_;
			this.resetData_ = other.resetData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000B2BF8 File Offset: 0x000B0DF8
		[DebuggerNonUserCode]
		public DesignerVariableDataStore Clone()
		{
			return new DesignerVariableDataStore(this);
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x000B2C10 File Offset: 0x000B0E10
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x000B2C41 File Offset: 0x000B0E41
		[DebuggerNonUserCode]
		public int TrackedValue
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int trackedValueDefaultValue;
				if (flag)
				{
					trackedValueDefaultValue = this.trackedValue_;
				}
				else
				{
					trackedValueDefaultValue = DesignerVariableDataStore.TrackedValueDefaultValue;
				}
				return trackedValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.trackedValue_ = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000B2C5C File Offset: 0x000B0E5C
		[DebuggerNonUserCode]
		public bool HasTrackedValue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000B2C79 File Offset: 0x000B0E79
		[DebuggerNonUserCode]
		public void ClearTrackedValue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x000B2CBD File Offset: 0x000B0EBD
		[DebuggerNonUserCode]
		public int ResetData
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int resetDataDefaultValue;
				if (flag)
				{
					resetDataDefaultValue = this.resetData_;
				}
				else
				{
					resetDataDefaultValue = DesignerVariableDataStore.ResetDataDefaultValue;
				}
				return resetDataDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.resetData_ = value;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000B2CD8 File Offset: 0x000B0ED8
		[DebuggerNonUserCode]
		public bool HasResetData
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000B2CF5 File Offset: 0x000B0EF5
		[DebuggerNonUserCode]
		public void ClearResetData()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000B2D08 File Offset: 0x000B0F08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DesignerVariableDataStore);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000B2D28 File Offset: 0x000B0F28
		[DebuggerNonUserCode]
		public bool Equals(DesignerVariableDataStore other)
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
					bool flag4 = this.TrackedValue != other.TrackedValue;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ResetData != other.ResetData;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTrackedValue = this.HasTrackedValue;
			if (hasTrackedValue)
			{
				num ^= this.TrackedValue.GetHashCode();
			}
			bool hasResetData = this.HasResetData;
			if (hasResetData)
			{
				num ^= this.ResetData.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000B2E08 File Offset: 0x000B1008
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000B2E20 File Offset: 0x000B1020
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000B2E2C File Offset: 0x000B102C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTrackedValue = this.HasTrackedValue;
			if (hasTrackedValue)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TrackedValue);
			}
			bool hasResetData = this.HasResetData;
			if (hasResetData)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ResetData);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000B2E9C File Offset: 0x000B109C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTrackedValue = this.HasTrackedValue;
			if (hasTrackedValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrackedValue);
			}
			bool hasResetData = this.HasResetData;
			if (hasResetData)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetData);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000B2F08 File Offset: 0x000B1108
		[DebuggerNonUserCode]
		public void MergeFrom(DesignerVariableDataStore other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTrackedValue = other.HasTrackedValue;
				if (hasTrackedValue)
				{
					this.TrackedValue = other.TrackedValue;
				}
				bool hasResetData = other.HasResetData;
				if (hasResetData)
				{
					this.ResetData = other.ResetData;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000B2F6A File Offset: 0x000B116A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000B2F78 File Offset: 0x000B1178
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ResetData = input.ReadInt32();
					}
				}
				else
				{
					this.TrackedValue = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400149B RID: 5275
		private static readonly MessageParser<DesignerVariableDataStore> _parser = new MessageParser<DesignerVariableDataStore>(() => new DesignerVariableDataStore());

		// Token: 0x0400149C RID: 5276
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400149D RID: 5277
		private int _hasBits0;

		// Token: 0x0400149E RID: 5278
		public const int TrackedValueFieldNumber = 1;

		// Token: 0x0400149F RID: 5279
		private static readonly int TrackedValueDefaultValue = 0;

		// Token: 0x040014A0 RID: 5280
		private int trackedValue_;

		// Token: 0x040014A1 RID: 5281
		public const int ResetDataFieldNumber = 2;

		// Token: 0x040014A2 RID: 5282
		private static readonly int ResetDataDefaultValue = 0;

		// Token: 0x040014A3 RID: 5283
		private int resetData_;
	}
}

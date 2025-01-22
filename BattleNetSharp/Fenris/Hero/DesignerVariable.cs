using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000192 RID: 402
	public sealed class DesignerVariable : IMessage<DesignerVariable>, IMessage, IEquatable<DesignerVariable>, IDeepCloneable<DesignerVariable>, IBufferMessage
	{
		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000A6A38 File Offset: 0x000A4C38
		[DebuggerNonUserCode]
		public static MessageParser<DesignerVariable> Parser
		{
			get
			{
				return DesignerVariable._parser;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000A6A50 File Offset: 0x000A4C50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000A6A74 File Offset: 0x000A4C74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DesignerVariable.Descriptor;
			}
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000A6A8B File Offset: 0x000A4C8B
		[DebuggerNonUserCode]
		public DesignerVariable()
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000A6A98 File Offset: 0x000A4C98
		[DebuggerNonUserCode]
		public DesignerVariable(DesignerVariable other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gbidDesignerVariable_ = other.gbidDesignerVariable_;
			this.payloadValue_ = other.payloadValue_;
			this.resetValue_ = other.resetValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000A6AF0 File Offset: 0x000A4CF0
		[DebuggerNonUserCode]
		public DesignerVariable Clone()
		{
			return new DesignerVariable(this);
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000A6B08 File Offset: 0x000A4D08
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x000A6B39 File Offset: 0x000A4D39
		[DebuggerNonUserCode]
		public int GbidDesignerVariable
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int gbidDesignerVariableDefaultValue;
				if (flag)
				{
					gbidDesignerVariableDefaultValue = this.gbidDesignerVariable_;
				}
				else
				{
					gbidDesignerVariableDefaultValue = DesignerVariable.GbidDesignerVariableDefaultValue;
				}
				return gbidDesignerVariableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gbidDesignerVariable_ = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000A6B54 File Offset: 0x000A4D54
		[DebuggerNonUserCode]
		public bool HasGbidDesignerVariable
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x000A6B71 File Offset: 0x000A4D71
		[DebuggerNonUserCode]
		public void ClearGbidDesignerVariable()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000A6B84 File Offset: 0x000A4D84
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x000A6BB5 File Offset: 0x000A4DB5
		[DebuggerNonUserCode]
		public int PayloadValue
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int payloadValueDefaultValue;
				if (flag)
				{
					payloadValueDefaultValue = this.payloadValue_;
				}
				else
				{
					payloadValueDefaultValue = DesignerVariable.PayloadValueDefaultValue;
				}
				return payloadValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.payloadValue_ = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000A6BD0 File Offset: 0x000A4DD0
		[DebuggerNonUserCode]
		public bool HasPayloadValue
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000A6BED File Offset: 0x000A4DED
		[DebuggerNonUserCode]
		public void ClearPayloadValue()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000A6C00 File Offset: 0x000A4E00
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x000A6C31 File Offset: 0x000A4E31
		[DebuggerNonUserCode]
		public int ResetValue
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int resetValueDefaultValue;
				if (flag)
				{
					resetValueDefaultValue = this.resetValue_;
				}
				else
				{
					resetValueDefaultValue = DesignerVariable.ResetValueDefaultValue;
				}
				return resetValueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.resetValue_ = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000A6C4C File Offset: 0x000A4E4C
		[DebuggerNonUserCode]
		public bool HasResetValue
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000A6C69 File Offset: 0x000A4E69
		[DebuggerNonUserCode]
		public void ClearResetValue()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000A6C7C File Offset: 0x000A4E7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DesignerVariable);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000A6C9C File Offset: 0x000A4E9C
		[DebuggerNonUserCode]
		public bool Equals(DesignerVariable other)
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
					bool flag4 = this.GbidDesignerVariable != other.GbidDesignerVariable;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PayloadValue != other.PayloadValue;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ResetValue != other.ResetValue;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000A6D28 File Offset: 0x000A4F28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGbidDesignerVariable = this.HasGbidDesignerVariable;
			if (hasGbidDesignerVariable)
			{
				num ^= this.GbidDesignerVariable.GetHashCode();
			}
			bool hasPayloadValue = this.HasPayloadValue;
			if (hasPayloadValue)
			{
				num ^= this.PayloadValue.GetHashCode();
			}
			bool hasResetValue = this.HasResetValue;
			if (hasResetValue)
			{
				num ^= this.ResetValue.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000A6DB4 File Offset: 0x000A4FB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000A6DCC File Offset: 0x000A4FCC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000A6DD8 File Offset: 0x000A4FD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGbidDesignerVariable = this.HasGbidDesignerVariable;
			if (hasGbidDesignerVariable)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.GbidDesignerVariable);
			}
			bool hasPayloadValue = this.HasPayloadValue;
			if (hasPayloadValue)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PayloadValue);
			}
			bool hasResetValue = this.HasResetValue;
			if (hasResetValue)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ResetValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000A6E68 File Offset: 0x000A5068
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGbidDesignerVariable = this.HasGbidDesignerVariable;
			if (hasGbidDesignerVariable)
			{
				num += 5;
			}
			bool hasPayloadValue = this.HasPayloadValue;
			if (hasPayloadValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PayloadValue);
			}
			bool hasResetValue = this.HasResetValue;
			if (hasResetValue)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetValue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000A6EE8 File Offset: 0x000A50E8
		[DebuggerNonUserCode]
		public void MergeFrom(DesignerVariable other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGbidDesignerVariable = other.HasGbidDesignerVariable;
				if (hasGbidDesignerVariable)
				{
					this.GbidDesignerVariable = other.GbidDesignerVariable;
				}
				bool hasPayloadValue = other.HasPayloadValue;
				if (hasPayloadValue)
				{
					this.PayloadValue = other.PayloadValue;
				}
				bool hasResetValue = other.HasResetValue;
				if (hasResetValue)
				{
					this.ResetValue = other.ResetValue;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000A6F63 File Offset: 0x000A5163
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000A6F70 File Offset: 0x000A5170
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ResetValue = input.ReadInt32();
						}
					}
					else
					{
						this.PayloadValue = input.ReadInt32();
					}
				}
				else
				{
					this.GbidDesignerVariable = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x0400131A RID: 4890
		private static readonly MessageParser<DesignerVariable> _parser = new MessageParser<DesignerVariable>(() => new DesignerVariable());

		// Token: 0x0400131B RID: 4891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400131C RID: 4892
		private int _hasBits0;

		// Token: 0x0400131D RID: 4893
		public const int GbidDesignerVariableFieldNumber = 1;

		// Token: 0x0400131E RID: 4894
		private static readonly int GbidDesignerVariableDefaultValue = 0;

		// Token: 0x0400131F RID: 4895
		private int gbidDesignerVariable_;

		// Token: 0x04001320 RID: 4896
		public const int PayloadValueFieldNumber = 2;

		// Token: 0x04001321 RID: 4897
		private static readonly int PayloadValueDefaultValue = 0;

		// Token: 0x04001322 RID: 4898
		private int payloadValue_;

		// Token: 0x04001323 RID: 4899
		public const int ResetValueFieldNumber = 3;

		// Token: 0x04001324 RID: 4900
		private static readonly int ResetValueDefaultValue = 0;

		// Token: 0x04001325 RID: 4901
		private int resetValue_;
	}
}

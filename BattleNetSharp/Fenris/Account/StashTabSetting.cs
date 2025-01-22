using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D5 RID: 725
	public sealed class StashTabSetting : IMessage<StashTabSetting>, IMessage, IEquatable<StashTabSetting>, IDeepCloneable<StashTabSetting>, IBufferMessage
	{
		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x00125790 File Offset: 0x00123990
		[DebuggerNonUserCode]
		public static MessageParser<StashTabSetting> Parser
		{
			get
			{
				return StashTabSetting._parser;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x001257A8 File Offset: 0x001239A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x001257CC File Offset: 0x001239CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StashTabSetting.Descriptor;
			}
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x001257E3 File Offset: 0x001239E3
		[DebuggerNonUserCode]
		public StashTabSetting()
		{
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x001257F0 File Offset: 0x001239F0
		[DebuggerNonUserCode]
		public StashTabSetting(StashTabSetting other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.tabIndex_ = other.tabIndex_;
			this.iconIndex_ = other.iconIndex_;
			this.tabName_ = other.tabName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00125848 File Offset: 0x00123A48
		[DebuggerNonUserCode]
		public StashTabSetting Clone()
		{
			return new StashTabSetting(this);
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x00125860 File Offset: 0x00123A60
		// (set) Token: 0x06004CBE RID: 19646 RVA: 0x00125891 File Offset: 0x00123A91
		[DebuggerNonUserCode]
		public uint TabIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint tabIndexDefaultValue;
				if (flag)
				{
					tabIndexDefaultValue = this.tabIndex_;
				}
				else
				{
					tabIndexDefaultValue = StashTabSetting.TabIndexDefaultValue;
				}
				return tabIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.tabIndex_ = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x001258AC File Offset: 0x00123AAC
		[DebuggerNonUserCode]
		public bool HasTabIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x001258C9 File Offset: 0x00123AC9
		[DebuggerNonUserCode]
		public void ClearTabIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x001258DC File Offset: 0x00123ADC
		// (set) Token: 0x06004CC2 RID: 19650 RVA: 0x0012590D File Offset: 0x00123B0D
		[DebuggerNonUserCode]
		public uint IconIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint iconIndexDefaultValue;
				if (flag)
				{
					iconIndexDefaultValue = this.iconIndex_;
				}
				else
				{
					iconIndexDefaultValue = StashTabSetting.IconIndexDefaultValue;
				}
				return iconIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.iconIndex_ = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x00125928 File Offset: 0x00123B28
		[DebuggerNonUserCode]
		public bool HasIconIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00125945 File Offset: 0x00123B45
		[DebuggerNonUserCode]
		public void ClearIconIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x00125958 File Offset: 0x00123B58
		// (set) Token: 0x06004CC6 RID: 19654 RVA: 0x00125979 File Offset: 0x00123B79
		[DebuggerNonUserCode]
		public string TabName
		{
			get
			{
				return this.tabName_ ?? StashTabSetting.TabNameDefaultValue;
			}
			set
			{
				this.tabName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004CC7 RID: 19655 RVA: 0x00125990 File Offset: 0x00123B90
		[DebuggerNonUserCode]
		public bool HasTabName
		{
			get
			{
				return this.tabName_ != null;
			}
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x001259AB File Offset: 0x00123BAB
		[DebuggerNonUserCode]
		public void ClearTabName()
		{
			this.tabName_ = null;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x001259B8 File Offset: 0x00123BB8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StashTabSetting);
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x001259D8 File Offset: 0x00123BD8
		[DebuggerNonUserCode]
		public bool Equals(StashTabSetting other)
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
					bool flag4 = this.TabIndex != other.TabIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IconIndex != other.IconIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TabName != other.TabName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x00125A64 File Offset: 0x00123C64
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTabIndex = this.HasTabIndex;
			if (hasTabIndex)
			{
				num ^= this.TabIndex.GetHashCode();
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				num ^= this.IconIndex.GetHashCode();
			}
			bool hasTabName = this.HasTabName;
			if (hasTabName)
			{
				num ^= this.TabName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00125AEC File Offset: 0x00123CEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00125B04 File Offset: 0x00123D04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00125B10 File Offset: 0x00123D10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTabIndex = this.HasTabIndex;
			if (hasTabIndex)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TabIndex);
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.IconIndex);
			}
			bool hasTabName = this.HasTabName;
			if (hasTabName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TabName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00125BA0 File Offset: 0x00123DA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTabIndex = this.HasTabIndex;
			if (hasTabIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TabIndex);
			}
			bool hasIconIndex = this.HasIconIndex;
			if (hasIconIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IconIndex);
			}
			bool hasTabName = this.HasTabName;
			if (hasTabName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TabName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00125C2C File Offset: 0x00123E2C
		[DebuggerNonUserCode]
		public void MergeFrom(StashTabSetting other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTabIndex = other.HasTabIndex;
				if (hasTabIndex)
				{
					this.TabIndex = other.TabIndex;
				}
				bool hasIconIndex = other.HasIconIndex;
				if (hasIconIndex)
				{
					this.IconIndex = other.IconIndex;
				}
				bool hasTabName = other.HasTabName;
				if (hasTabName)
				{
					this.TabName = other.TabName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00125CA7 File Offset: 0x00123EA7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00125CB4 File Offset: 0x00123EB4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TabName = input.ReadString();
						}
					}
					else
					{
						this.IconIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.TabIndex = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002238 RID: 8760
		private static readonly MessageParser<StashTabSetting> _parser = new MessageParser<StashTabSetting>(() => new StashTabSetting());

		// Token: 0x04002239 RID: 8761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400223A RID: 8762
		private int _hasBits0;

		// Token: 0x0400223B RID: 8763
		public const int TabIndexFieldNumber = 1;

		// Token: 0x0400223C RID: 8764
		private static readonly uint TabIndexDefaultValue = 0U;

		// Token: 0x0400223D RID: 8765
		private uint tabIndex_;

		// Token: 0x0400223E RID: 8766
		public const int IconIndexFieldNumber = 2;

		// Token: 0x0400223F RID: 8767
		private static readonly uint IconIndexDefaultValue = 0U;

		// Token: 0x04002240 RID: 8768
		private uint iconIndex_;

		// Token: 0x04002241 RID: 8769
		public const int TabNameFieldNumber = 3;

		// Token: 0x04002242 RID: 8770
		private static readonly string TabNameDefaultValue = "";

		// Token: 0x04002243 RID: 8771
		private string tabName_;
	}
}

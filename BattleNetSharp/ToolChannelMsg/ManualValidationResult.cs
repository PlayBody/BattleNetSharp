using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000059 RID: 89
	public sealed class ManualValidationResult : IMessage<ManualValidationResult>, IMessage, IEquatable<ManualValidationResult>, IDeepCloneable<ManualValidationResult>, IBufferMessage
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		[DebuggerNonUserCode]
		public static MessageParser<ManualValidationResult> Parser
		{
			get
			{
				return ManualValidationResult._parser;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0001FF10 File Offset: 0x0001E110
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[66];
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0001FF34 File Offset: 0x0001E134
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ManualValidationResult.Descriptor;
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001FF4B File Offset: 0x0001E14B
		[DebuggerNonUserCode]
		public ManualValidationResult()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001FF58 File Offset: 0x0001E158
		[DebuggerNonUserCode]
		public ManualValidationResult(ManualValidationResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.message_ = other.message_;
			this.validationType_ = other.validationType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		[DebuggerNonUserCode]
		public ManualValidationResult Clone()
		{
			return new ManualValidationResult(this);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00020005 File Offset: 0x0001E205
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = ManualValidationResult.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00020020 File Offset: 0x0001E220
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0002003D File Offset: 0x0001E23D
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00020050 File Offset: 0x0001E250
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00020081 File Offset: 0x0001E281
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = ManualValidationResult.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002009C File Offset: 0x0001E29C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000200B9 File Offset: 0x0001E2B9
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000200CC File Offset: 0x0001E2CC
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000200ED File Offset: 0x0001E2ED
		[DebuggerNonUserCode]
		public string Message
		{
			get
			{
				return this.message_ ?? ManualValidationResult.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00020104 File Offset: 0x0001E304
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002011F File Offset: 0x0001E31F
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0002012C File Offset: 0x0001E32C
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x0002015D File Offset: 0x0001E35D
		[DebuggerNonUserCode]
		public int ValidationType
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int validationTypeDefaultValue;
				if (flag)
				{
					validationTypeDefaultValue = this.validationType_;
				}
				else
				{
					validationTypeDefaultValue = ManualValidationResult.ValidationTypeDefaultValue;
				}
				return validationTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.validationType_ = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00020178 File Offset: 0x0001E378
		[DebuggerNonUserCode]
		public bool HasValidationType
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00020195 File Offset: 0x0001E395
		[DebuggerNonUserCode]
		public void ClearValidationType()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000201A8 File Offset: 0x0001E3A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ManualValidationResult);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000201C8 File Offset: 0x0001E3C8
		[DebuggerNonUserCode]
		public bool Equals(ManualValidationResult other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Message != other.Message;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ValidationType != other.ValidationType;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00020274 File Offset: 0x0001E474
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num ^= this.Message.GetHashCode();
			}
			bool hasValidationType = this.HasValidationType;
			if (hasValidationType)
			{
				num ^= this.ValidationType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00020318 File Offset: 0x0001E518
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00020330 File Offset: 0x0001E530
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002033C File Offset: 0x0001E53C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Message);
			}
			bool hasValidationType = this.HasValidationType;
			if (hasValidationType)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ValidationType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000203F0 File Offset: 0x0001E5F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Message);
			}
			bool hasValidationType = this.HasValidationType;
			if (hasValidationType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ValidationType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00020498 File Offset: 0x0001E698
		[DebuggerNonUserCode]
		public void MergeFrom(ManualValidationResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				bool hasValidationType = other.HasValidationType;
				if (hasValidationType)
				{
					this.ValidationType = other.ValidationType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002052E File Offset: 0x0001E72E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002053C File Offset: 0x0001E73C
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
						this.SnoHandle = input.ReadInt32();
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ValidationType = input.ReadInt32();
				}
				else
				{
					this.Message = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000316 RID: 790
		private static readonly MessageParser<ManualValidationResult> _parser = new MessageParser<ManualValidationResult>(() => new ManualValidationResult());

		// Token: 0x04000317 RID: 791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000318 RID: 792
		private int _hasBits0;

		// Token: 0x04000319 RID: 793
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x0400031A RID: 794
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x0400031B RID: 795
		private int snoGroup_;

		// Token: 0x0400031C RID: 796
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x0400031D RID: 797
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400031E RID: 798
		private int snoHandle_;

		// Token: 0x0400031F RID: 799
		public const int MessageFieldNumber = 3;

		// Token: 0x04000320 RID: 800
		private static readonly string MessageDefaultValue = "";

		// Token: 0x04000321 RID: 801
		private string message_;

		// Token: 0x04000322 RID: 802
		public const int ValidationTypeFieldNumber = 4;

		// Token: 0x04000323 RID: 803
		private static readonly int ValidationTypeDefaultValue = 0;

		// Token: 0x04000324 RID: 804
		private int validationType_;
	}
}

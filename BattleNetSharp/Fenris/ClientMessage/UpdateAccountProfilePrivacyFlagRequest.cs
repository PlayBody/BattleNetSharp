using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000239 RID: 569
	public sealed class UpdateAccountProfilePrivacyFlagRequest : IMessage<UpdateAccountProfilePrivacyFlagRequest>, IMessage, IEquatable<UpdateAccountProfilePrivacyFlagRequest>, IDeepCloneable<UpdateAccountProfilePrivacyFlagRequest>, IBufferMessage
	{
		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x000F2EC4 File Offset: 0x000F10C4
		[DebuggerNonUserCode]
		public static MessageParser<UpdateAccountProfilePrivacyFlagRequest> Parser
		{
			get
			{
				return UpdateAccountProfilePrivacyFlagRequest._parser;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x000F2EDC File Offset: 0x000F10DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[41];
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x000F2F00 File Offset: 0x000F1100
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateAccountProfilePrivacyFlagRequest.Descriptor;
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000F2F17 File Offset: 0x000F1117
		[DebuggerNonUserCode]
		public UpdateAccountProfilePrivacyFlagRequest()
		{
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000F2F21 File Offset: 0x000F1121
		[DebuggerNonUserCode]
		public UpdateAccountProfilePrivacyFlagRequest(UpdateAccountProfilePrivacyFlagRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.privacyFlag_ = other.privacyFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000F2F54 File Offset: 0x000F1154
		[DebuggerNonUserCode]
		public UpdateAccountProfilePrivacyFlagRequest Clone()
		{
			return new UpdateAccountProfilePrivacyFlagRequest(this);
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x000F2F6C File Offset: 0x000F116C
		// (set) Token: 0x06003D89 RID: 15753 RVA: 0x000F2F9D File Offset: 0x000F119D
		[DebuggerNonUserCode]
		public bool PrivacyFlag
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool privacyFlagDefaultValue;
				if (flag)
				{
					privacyFlagDefaultValue = this.privacyFlag_;
				}
				else
				{
					privacyFlagDefaultValue = UpdateAccountProfilePrivacyFlagRequest.PrivacyFlagDefaultValue;
				}
				return privacyFlagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyFlag_ = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x000F2FB8 File Offset: 0x000F11B8
		[DebuggerNonUserCode]
		public bool HasPrivacyFlag
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x000F2FD5 File Offset: 0x000F11D5
		[DebuggerNonUserCode]
		public void ClearPrivacyFlag()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x000F2FE8 File Offset: 0x000F11E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateAccountProfilePrivacyFlagRequest);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x000F3008 File Offset: 0x000F1208
		[DebuggerNonUserCode]
		public bool Equals(UpdateAccountProfilePrivacyFlagRequest other)
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
					bool flag4 = this.PrivacyFlag != other.PrivacyFlag;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000F3060 File Offset: 0x000F1260
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				num ^= this.PrivacyFlag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x000F30B0 File Offset: 0x000F12B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x000F30C8 File Offset: 0x000F12C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000F30D4 File Offset: 0x000F12D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.PrivacyFlag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x000F3120 File Offset: 0x000F1320
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPrivacyFlag = this.HasPrivacyFlag;
			if (hasPrivacyFlag)
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

		// Token: 0x06003D93 RID: 15763 RVA: 0x000F3164 File Offset: 0x000F1364
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateAccountProfilePrivacyFlagRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPrivacyFlag = other.HasPrivacyFlag;
				if (hasPrivacyFlag)
				{
					this.PrivacyFlag = other.PrivacyFlag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x000F31AD File Offset: 0x000F13AD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x000F31B8 File Offset: 0x000F13B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PrivacyFlag = input.ReadBool();
				}
			}
		}

		// Token: 0x04001C43 RID: 7235
		private static readonly MessageParser<UpdateAccountProfilePrivacyFlagRequest> _parser = new MessageParser<UpdateAccountProfilePrivacyFlagRequest>(() => new UpdateAccountProfilePrivacyFlagRequest());

		// Token: 0x04001C44 RID: 7236
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C45 RID: 7237
		private int _hasBits0;

		// Token: 0x04001C46 RID: 7238
		public const int PrivacyFlagFieldNumber = 1;

		// Token: 0x04001C47 RID: 7239
		private static readonly bool PrivacyFlagDefaultValue = false;

		// Token: 0x04001C48 RID: 7240
		private bool privacyFlag_;
	}
}

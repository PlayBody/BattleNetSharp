using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000212 RID: 530
	public sealed class GenericResponse : IMessage<GenericResponse>, IMessage, IEquatable<GenericResponse>, IDeepCloneable<GenericResponse>, IBufferMessage
	{
		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x000E6978 File Offset: 0x000E4B78
		[DebuggerNonUserCode]
		public static MessageParser<GenericResponse> Parser
		{
			get
			{
				return GenericResponse._parser;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x000E6990 File Offset: 0x000E4B90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x000E69B4 File Offset: 0x000E4BB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenericResponse.Descriptor;
			}
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x000E69CB File Offset: 0x000E4BCB
		[DebuggerNonUserCode]
		public GenericResponse()
		{
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x000E69D5 File Offset: 0x000E4BD5
		[DebuggerNonUserCode]
		public GenericResponse(GenericResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x000E6A08 File Offset: 0x000E4C08
		[DebuggerNonUserCode]
		public GenericResponse Clone()
		{
			return new GenericResponse(this);
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x000E6A20 File Offset: 0x000E4C20
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x000E6A51 File Offset: 0x000E4C51
		[DebuggerNonUserCode]
		public uint ErrorCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errorCodeDefaultValue;
				if (flag)
				{
					errorCodeDefaultValue = this.errorCode_;
				}
				else
				{
					errorCodeDefaultValue = GenericResponse.ErrorCodeDefaultValue;
				}
				return errorCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errorCode_ = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x000E6A6C File Offset: 0x000E4C6C
		[DebuggerNonUserCode]
		public bool HasErrorCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x000E6A89 File Offset: 0x000E4C89
		[DebuggerNonUserCode]
		public void ClearErrorCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x000E6A9C File Offset: 0x000E4C9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenericResponse);
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x000E6ABC File Offset: 0x000E4CBC
		[DebuggerNonUserCode]
		public bool Equals(GenericResponse other)
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
					bool flag4 = this.ErrorCode != other.ErrorCode;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000E6B14 File Offset: 0x000E4D14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x000E6B64 File Offset: 0x000E4D64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x000E6B7C File Offset: 0x000E4D7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x000E6B88 File Offset: 0x000E4D88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x000E6BD4 File Offset: 0x000E4DD4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrorCode = this.HasErrorCode;
			if (hasErrorCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrorCode);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x000E6C24 File Offset: 0x000E4E24
		[DebuggerNonUserCode]
		public void MergeFrom(GenericResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrorCode = other.HasErrorCode;
				if (hasErrorCode)
				{
					this.ErrorCode = other.ErrorCode;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x000E6C6D File Offset: 0x000E4E6D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039CD RID: 14797 RVA: 0x000E6C78 File Offset: 0x000E4E78
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
					this.ErrorCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001ADA RID: 6874
		private static readonly MessageParser<GenericResponse> _parser = new MessageParser<GenericResponse>(() => new GenericResponse());

		// Token: 0x04001ADB RID: 6875
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ADC RID: 6876
		private int _hasBits0;

		// Token: 0x04001ADD RID: 6877
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04001ADE RID: 6878
		private static readonly uint ErrorCodeDefaultValue = 0U;

		// Token: 0x04001ADF RID: 6879
		private uint errorCode_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000623 RID: 1571
	public sealed class GenerateAuthTokenRequest : IMessage<GenerateAuthTokenRequest>, IMessage, IEquatable<GenerateAuthTokenRequest>, IDeepCloneable<GenerateAuthTokenRequest>, IBufferMessage
	{
		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x002390D4 File Offset: 0x002372D4
		[DebuggerNonUserCode]
		public static MessageParser<GenerateAuthTokenRequest> Parser
		{
			get
			{
				return GenerateAuthTokenRequest._parser;
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x060092CD RID: 37581 RVA: 0x002390EC File Offset: 0x002372EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x060092CE RID: 37582 RVA: 0x00239110 File Offset: 0x00237310
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateAuthTokenRequest.Descriptor;
			}
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x00239127 File Offset: 0x00237327
		[DebuggerNonUserCode]
		public GenerateAuthTokenRequest()
		{
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x00239131 File Offset: 0x00237331
		[DebuggerNonUserCode]
		public GenerateAuthTokenRequest(GenerateAuthTokenRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x00239164 File Offset: 0x00237364
		[DebuggerNonUserCode]
		public GenerateAuthTokenRequest Clone()
		{
			return new GenerateAuthTokenRequest(this);
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x0023917C File Offset: 0x0023737C
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x002391AD File Offset: 0x002373AD
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = GenerateAuthTokenRequest.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x002391C8 File Offset: 0x002373C8
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x002391E5 File Offset: 0x002373E5
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x002391F8 File Offset: 0x002373F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateAuthTokenRequest);
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x00239218 File Offset: 0x00237418
		[DebuggerNonUserCode]
		public bool Equals(GenerateAuthTokenRequest other)
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
					bool flag4 = this.TitleId != other.TitleId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x00239270 File Offset: 0x00237470
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x002392C0 File Offset: 0x002374C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x002392D8 File Offset: 0x002374D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x002392E4 File Offset: 0x002374E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x00239330 File Offset: 0x00237530
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x00239380 File Offset: 0x00237580
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateAuthTokenRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x002393C9 File Offset: 0x002375C9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x002393D4 File Offset: 0x002375D4
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
					this.TitleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400424C RID: 16972
		private static readonly MessageParser<GenerateAuthTokenRequest> _parser = new MessageParser<GenerateAuthTokenRequest>(() => new GenerateAuthTokenRequest());

		// Token: 0x0400424D RID: 16973
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400424E RID: 16974
		private int _hasBits0;

		// Token: 0x0400424F RID: 16975
		public const int TitleIdFieldNumber = 1;

		// Token: 0x04004250 RID: 16976
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x04004251 RID: 16977
		private uint titleId_;
	}
}

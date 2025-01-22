using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000562 RID: 1378
	public sealed class GetSessionStateResponse : IMessage<GetSessionStateResponse>, IMessage, IEquatable<GetSessionStateResponse>, IDeepCloneable<GetSessionStateResponse>, IBufferMessage
	{
		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x002048F0 File Offset: 0x00202AF0
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateResponse> Parser
		{
			get
			{
				return GetSessionStateResponse._parser;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x060084E0 RID: 34016 RVA: 0x00204908 File Offset: 0x00202B08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x0020492C File Offset: 0x00202B2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateResponse.Descriptor;
			}
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x00204943 File Offset: 0x00202B43
		[DebuggerNonUserCode]
		public GetSessionStateResponse()
		{
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x0020494D File Offset: 0x00202B4D
		[DebuggerNonUserCode]
		public GetSessionStateResponse(GetSessionStateResponse other)
			: this()
		{
			this.session_ = ((other.session_ != null) ? other.session_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x00204984 File Offset: 0x00202B84
		[DebuggerNonUserCode]
		public GetSessionStateResponse Clone()
		{
			return new GetSessionStateResponse(this);
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x060084E5 RID: 34021 RVA: 0x0020499C File Offset: 0x00202B9C
		// (set) Token: 0x060084E6 RID: 34022 RVA: 0x002049B4 File Offset: 0x00202BB4
		[DebuggerNonUserCode]
		public SessionState Session
		{
			get
			{
				return this.session_;
			}
			set
			{
				this.session_ = value;
			}
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x002049C0 File Offset: 0x00202BC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateResponse);
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x002049E0 File Offset: 0x00202BE0
		[DebuggerNonUserCode]
		public bool Equals(GetSessionStateResponse other)
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
					bool flag4 = !object.Equals(this.Session, other.Session);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x00204A3C File Offset: 0x00202C3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.session_ != null;
			if (flag)
			{
				num ^= this.Session.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x00204A8C File Offset: 0x00202C8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x00204AA4 File Offset: 0x00202CA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x00204AB0 File Offset: 0x00202CB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.session_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Session);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00204B00 File Offset: 0x00202D00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.session_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Session);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x00204B54 File Offset: 0x00202D54
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.session_ != null;
				if (flag2)
				{
					bool flag3 = this.session_ == null;
					if (flag3)
					{
						this.Session = new SessionState();
					}
					this.Session.MergeFrom(other.Session);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x00204BC0 File Offset: 0x00202DC0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x00204BCC File Offset: 0x00202DCC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.session_ == null;
					if (flag)
					{
						this.Session = new SessionState();
					}
					input.ReadMessage(this.Session);
				}
			}
		}

		// Token: 0x04003C32 RID: 15410
		private static readonly MessageParser<GetSessionStateResponse> _parser = new MessageParser<GetSessionStateResponse>(() => new GetSessionStateResponse());

		// Token: 0x04003C33 RID: 15411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C34 RID: 15412
		public const int SessionFieldNumber = 1;

		// Token: 0x04003C35 RID: 15413
		private SessionState session_;
	}
}

using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053A RID: 1338
	public sealed class GetSessionStateResponse : IMessage<GetSessionStateResponse>, IMessage, IEquatable<GetSessionStateResponse>, IDeepCloneable<GetSessionStateResponse>, IBufferMessage
	{
		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x06008183 RID: 33155 RVA: 0x001F80B8 File Offset: 0x001F62B8
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateResponse> Parser
		{
			get
			{
				return GetSessionStateResponse._parser;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x06008184 RID: 33156 RVA: 0x001F80D0 File Offset: 0x001F62D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x06008185 RID: 33157 RVA: 0x001F80F4 File Offset: 0x001F62F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateResponse.Descriptor;
			}
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x001F810B File Offset: 0x001F630B
		[DebuggerNonUserCode]
		public GetSessionStateResponse()
		{
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x001F8118 File Offset: 0x001F6318
		[DebuggerNonUserCode]
		public GetSessionStateResponse(GetSessionStateResponse other)
			: this()
		{
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.session_ = ((other.session_ != null) ? other.session_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x001F8178 File Offset: 0x001F6378
		[DebuggerNonUserCode]
		public GetSessionStateResponse Clone()
		{
			return new GetSessionStateResponse(this);
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x001F8190 File Offset: 0x001F6390
		// (set) Token: 0x0600818A RID: 33162 RVA: 0x001F81A8 File Offset: 0x001F63A8
		[Obsolete]
		[DebuggerNonUserCode]
		public GameAccountHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600818B RID: 33163 RVA: 0x001F81B4 File Offset: 0x001F63B4
		// (set) Token: 0x0600818C RID: 33164 RVA: 0x001F81CC File Offset: 0x001F63CC
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

		// Token: 0x0600818D RID: 33165 RVA: 0x001F81D8 File Offset: 0x001F63D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateResponse);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x001F81F8 File Offset: 0x001F63F8
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
					bool flag4 = !object.Equals(this.Handle, other.Handle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Session, other.Session);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x001F8270 File Offset: 0x001F6470
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool flag2 = this.session_ != null;
			if (flag2)
			{
				num ^= this.Session.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x001F82DC File Offset: 0x001F64DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x001F82F4 File Offset: 0x001F64F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x001F8300 File Offset: 0x001F6500
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			bool flag2 = this.session_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Session);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x001F8374 File Offset: 0x001F6574
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool flag2 = this.session_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Session);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x001F83E8 File Offset: 0x001F65E8
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.handle_ != null;
				if (flag2)
				{
					bool flag3 = this.handle_ == null;
					if (flag3)
					{
						this.Handle = new GameAccountHandle();
					}
					this.Handle.MergeFrom(other.Handle);
				}
				bool flag4 = other.session_ != null;
				if (flag4)
				{
					bool flag5 = this.session_ == null;
					if (flag5)
					{
						this.Session = new SessionState();
					}
					this.Session.MergeFrom(other.Session);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x001F8495 File Offset: 0x001F6695
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x001F84A0 File Offset: 0x001F66A0
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
					if (num3 != 18U)
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
				else
				{
					bool flag2 = this.handle_ == null;
					if (flag2)
					{
						this.Handle = new GameAccountHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x04003AB6 RID: 15030
		private static readonly MessageParser<GetSessionStateResponse> _parser = new MessageParser<GetSessionStateResponse>(() => new GetSessionStateResponse());

		// Token: 0x04003AB7 RID: 15031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB8 RID: 15032
		public const int HandleFieldNumber = 1;

		// Token: 0x04003AB9 RID: 15033
		private GameAccountHandle handle_;

		// Token: 0x04003ABA RID: 15034
		public const int SessionFieldNumber = 2;

		// Token: 0x04003ABB RID: 15035
		private SessionState session_;
	}
}

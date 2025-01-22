using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000531 RID: 1329
	public sealed class UpdateSessionRequest : IMessage<UpdateSessionRequest>, IMessage, IEquatable<UpdateSessionRequest>, IDeepCloneable<UpdateSessionRequest>, IBufferMessage
	{
		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x060080BB RID: 32955 RVA: 0x001F5990 File Offset: 0x001F3B90
		[DebuggerNonUserCode]
		public static MessageParser<UpdateSessionRequest> Parser
		{
			get
			{
				return UpdateSessionRequest._parser;
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x001F59A8 File Offset: 0x001F3BA8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x060080BD RID: 32957 RVA: 0x001F59CC File Offset: 0x001F3BCC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSessionRequest.Descriptor;
			}
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x001F59E3 File Offset: 0x001F3BE3
		[DebuggerNonUserCode]
		public UpdateSessionRequest()
		{
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x001F59F0 File Offset: 0x001F3BF0
		[DebuggerNonUserCode]
		public UpdateSessionRequest(UpdateSessionRequest other)
			: this()
		{
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.sessionId_ = other.sessionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x001F5A5C File Offset: 0x001F3C5C
		[DebuggerNonUserCode]
		public UpdateSessionRequest Clone()
		{
			return new UpdateSessionRequest(this);
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x060080C1 RID: 32961 RVA: 0x001F5A74 File Offset: 0x001F3C74
		// (set) Token: 0x060080C2 RID: 32962 RVA: 0x001F5A8C File Offset: 0x001F3C8C
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x060080C3 RID: 32963 RVA: 0x001F5A98 File Offset: 0x001F3C98
		// (set) Token: 0x060080C4 RID: 32964 RVA: 0x001F5AB0 File Offset: 0x001F3CB0
		[DebuggerNonUserCode]
		public SessionOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x060080C5 RID: 32965 RVA: 0x001F5ABC File Offset: 0x001F3CBC
		// (set) Token: 0x060080C6 RID: 32966 RVA: 0x001F5ADD File Offset: 0x001F3CDD
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? UpdateSessionRequest.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x060080C7 RID: 32967 RVA: 0x001F5AF4 File Offset: 0x001F3CF4
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x001F5B0F File Offset: 0x001F3D0F
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x001F5B1C File Offset: 0x001F3D1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSessionRequest);
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x001F5B3C File Offset: 0x001F3D3C
		[DebuggerNonUserCode]
		public bool Equals(UpdateSessionRequest other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionId != other.SessionId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x001F5BD0 File Offset: 0x001F3DD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x001F5C54 File Offset: 0x001F3E54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x001F5C6C File Offset: 0x001F3E6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x001F5C78 File Offset: 0x001F3E78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x001F5D10 File Offset: 0x001F3F10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x001F5DA0 File Offset: 0x001F3FA0
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateSessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SessionOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x001F5E68 File Offset: 0x001F4068
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x001F5E74 File Offset: 0x001F4074
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SessionId = input.ReadString();
						}
					}
					else
					{
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new SessionOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.identity_ == null;
					if (flag2)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x04003A73 RID: 14963
		private static readonly MessageParser<UpdateSessionRequest> _parser = new MessageParser<UpdateSessionRequest>(() => new UpdateSessionRequest());

		// Token: 0x04003A74 RID: 14964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A75 RID: 14965
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003A76 RID: 14966
		private Identity identity_;

		// Token: 0x04003A77 RID: 14967
		public const int OptionsFieldNumber = 2;

		// Token: 0x04003A78 RID: 14968
		private SessionOptions options_;

		// Token: 0x04003A79 RID: 14969
		public const int SessionIdFieldNumber = 3;

		// Token: 0x04003A7A RID: 14970
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003A7B RID: 14971
		private string sessionId_;
	}
}

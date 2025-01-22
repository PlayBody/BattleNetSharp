using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055B RID: 1371
	public sealed class CreateSessionResponse : IMessage<CreateSessionResponse>, IMessage, IEquatable<CreateSessionResponse>, IDeepCloneable<CreateSessionResponse>, IBufferMessage
	{
		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06008452 RID: 33874 RVA: 0x00202E80 File Offset: 0x00201080
		[DebuggerNonUserCode]
		public static MessageParser<CreateSessionResponse> Parser
		{
			get
			{
				return CreateSessionResponse._parser;
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06008453 RID: 33875 RVA: 0x00202E98 File Offset: 0x00201098
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06008454 RID: 33876 RVA: 0x00202EBC File Offset: 0x002010BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateSessionResponse.Descriptor;
			}
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x00202ED3 File Offset: 0x002010D3
		[DebuggerNonUserCode]
		public CreateSessionResponse()
		{
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x00202EE0 File Offset: 0x002010E0
		[DebuggerNonUserCode]
		public CreateSessionResponse(CreateSessionResponse other)
			: this()
		{
			this.sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
			this.variables_ = ((other.variables_ != null) ? other.variables_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x00202F40 File Offset: 0x00201140
		[DebuggerNonUserCode]
		public CreateSessionResponse Clone()
		{
			return new CreateSessionResponse(this);
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06008458 RID: 33880 RVA: 0x00202F58 File Offset: 0x00201158
		// (set) Token: 0x06008459 RID: 33881 RVA: 0x00202F70 File Offset: 0x00201170
		[DebuggerNonUserCode]
		public SessionId SessionId
		{
			get
			{
				return this.sessionId_;
			}
			set
			{
				this.sessionId_ = value;
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600845A RID: 33882 RVA: 0x00202F7C File Offset: 0x0020117C
		// (set) Token: 0x0600845B RID: 33883 RVA: 0x00202F94 File Offset: 0x00201194
		[DebuggerNonUserCode]
		public SessionVariables Variables
		{
			get
			{
				return this.variables_;
			}
			set
			{
				this.variables_ = value;
			}
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x00202FA0 File Offset: 0x002011A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateSessionResponse);
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x00202FC0 File Offset: 0x002011C0
		[DebuggerNonUserCode]
		public bool Equals(CreateSessionResponse other)
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
					bool flag4 = !object.Equals(this.SessionId, other.SessionId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Variables, other.Variables);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x00203038 File Offset: 0x00201238
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool flag2 = this.variables_ != null;
			if (flag2)
			{
				num ^= this.Variables.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x002030A4 File Offset: 0x002012A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x002030BC File Offset: 0x002012BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x002030C8 File Offset: 0x002012C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionId);
			}
			bool flag2 = this.variables_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Variables);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x0020313C File Offset: 0x0020133C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionId);
			}
			bool flag2 = this.variables_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Variables);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x002031B0 File Offset: 0x002013B0
		[DebuggerNonUserCode]
		public void MergeFrom(CreateSessionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionId_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionId_ == null;
					if (flag3)
					{
						this.SessionId = new SessionId();
					}
					this.SessionId.MergeFrom(other.SessionId);
				}
				bool flag4 = other.variables_ != null;
				if (flag4)
				{
					bool flag5 = this.variables_ == null;
					if (flag5)
					{
						this.Variables = new SessionVariables();
					}
					this.Variables.MergeFrom(other.Variables);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x0020325D File Offset: 0x0020145D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x00203268 File Offset: 0x00201468
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
						bool flag = this.variables_ == null;
						if (flag)
						{
							this.Variables = new SessionVariables();
						}
						input.ReadMessage(this.Variables);
					}
				}
				else
				{
					bool flag2 = this.sessionId_ == null;
					if (flag2)
					{
						this.SessionId = new SessionId();
					}
					input.ReadMessage(this.SessionId);
				}
			}
		}

		// Token: 0x04003C10 RID: 15376
		private static readonly MessageParser<CreateSessionResponse> _parser = new MessageParser<CreateSessionResponse>(() => new CreateSessionResponse());

		// Token: 0x04003C11 RID: 15377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C12 RID: 15378
		public const int SessionIdFieldNumber = 1;

		// Token: 0x04003C13 RID: 15379
		private SessionId sessionId_;

		// Token: 0x04003C14 RID: 15380
		public const int VariablesFieldNumber = 2;

		// Token: 0x04003C15 RID: 15381
		private SessionVariables variables_;
	}
}

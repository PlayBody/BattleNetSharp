using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055D RID: 1373
	public sealed class RestoreSessionResponse : IMessage<RestoreSessionResponse>, IMessage, IEquatable<RestoreSessionResponse>, IDeepCloneable<RestoreSessionResponse>, IBufferMessage
	{
		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06008482 RID: 33922 RVA: 0x00203A44 File Offset: 0x00201C44
		[DebuggerNonUserCode]
		public static MessageParser<RestoreSessionResponse> Parser
		{
			get
			{
				return RestoreSessionResponse._parser;
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06008483 RID: 33923 RVA: 0x00203A5C File Offset: 0x00201C5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x06008484 RID: 33924 RVA: 0x00203A80 File Offset: 0x00201C80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreSessionResponse.Descriptor;
			}
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x00203A97 File Offset: 0x00201C97
		[DebuggerNonUserCode]
		public RestoreSessionResponse()
		{
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x00203AA4 File Offset: 0x00201CA4
		[DebuggerNonUserCode]
		public RestoreSessionResponse(RestoreSessionResponse other)
			: this()
		{
			this.sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
			this.variables_ = ((other.variables_ != null) ? other.variables_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x00203B04 File Offset: 0x00201D04
		[DebuggerNonUserCode]
		public RestoreSessionResponse Clone()
		{
			return new RestoreSessionResponse(this);
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x00203B1C File Offset: 0x00201D1C
		// (set) Token: 0x06008489 RID: 33929 RVA: 0x00203B34 File Offset: 0x00201D34
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

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600848A RID: 33930 RVA: 0x00203B40 File Offset: 0x00201D40
		// (set) Token: 0x0600848B RID: 33931 RVA: 0x00203B58 File Offset: 0x00201D58
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

		// Token: 0x0600848C RID: 33932 RVA: 0x00203B64 File Offset: 0x00201D64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreSessionResponse);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x00203B84 File Offset: 0x00201D84
		[DebuggerNonUserCode]
		public bool Equals(RestoreSessionResponse other)
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

		// Token: 0x0600848E RID: 33934 RVA: 0x00203BFC File Offset: 0x00201DFC
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

		// Token: 0x0600848F RID: 33935 RVA: 0x00203C68 File Offset: 0x00201E68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x00203C80 File Offset: 0x00201E80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008491 RID: 33937 RVA: 0x00203C8C File Offset: 0x00201E8C
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

		// Token: 0x06008492 RID: 33938 RVA: 0x00203D00 File Offset: 0x00201F00
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

		// Token: 0x06008493 RID: 33939 RVA: 0x00203D74 File Offset: 0x00201F74
		[DebuggerNonUserCode]
		public void MergeFrom(RestoreSessionResponse other)
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

		// Token: 0x06008494 RID: 33940 RVA: 0x00203E21 File Offset: 0x00202021
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x00203E2C File Offset: 0x0020202C
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

		// Token: 0x04003C21 RID: 15393
		private static readonly MessageParser<RestoreSessionResponse> _parser = new MessageParser<RestoreSessionResponse>(() => new RestoreSessionResponse());

		// Token: 0x04003C22 RID: 15394
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C23 RID: 15395
		public const int SessionIdFieldNumber = 1;

		// Token: 0x04003C24 RID: 15396
		private SessionId sessionId_;

		// Token: 0x04003C25 RID: 15397
		public const int VariablesFieldNumber = 2;

		// Token: 0x04003C26 RID: 15398
		private SessionVariables variables_;
	}
}

using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053B RID: 1339
	public sealed class GetSignedSessionStateRequest : IMessage<GetSignedSessionStateRequest>, IMessage, IEquatable<GetSignedSessionStateRequest>, IDeepCloneable<GetSignedSessionStateRequest>, IBufferMessage
	{
		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x06008198 RID: 33176 RVA: 0x001F8564 File Offset: 0x001F6764
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedSessionStateRequest> Parser
		{
			get
			{
				return GetSignedSessionStateRequest._parser;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x001F857C File Offset: 0x001F677C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600819A RID: 33178 RVA: 0x001F85A0 File Offset: 0x001F67A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedSessionStateRequest.Descriptor;
			}
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x001F85B7 File Offset: 0x001F67B7
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest()
		{
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x001F85C1 File Offset: 0x001F67C1
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest(GetSignedSessionStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x001F85F8 File Offset: 0x001F67F8
		[DebuggerNonUserCode]
		public GetSignedSessionStateRequest Clone()
		{
			return new GetSignedSessionStateRequest(this);
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600819E RID: 33182 RVA: 0x001F8610 File Offset: 0x001F6810
		// (set) Token: 0x0600819F RID: 33183 RVA: 0x001F8628 File Offset: 0x001F6828
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x001F8634 File Offset: 0x001F6834
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedSessionStateRequest);
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x001F8654 File Offset: 0x001F6854
		[DebuggerNonUserCode]
		public bool Equals(GetSignedSessionStateRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x001F86B0 File Offset: 0x001F68B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x001F8700 File Offset: 0x001F6900
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x001F8718 File Offset: 0x001F6918
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x001F8724 File Offset: 0x001F6924
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x001F8774 File Offset: 0x001F6974
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x001F87C8 File Offset: 0x001F69C8
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedSessionStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x001F8834 File Offset: 0x001F6A34
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x001F8840 File Offset: 0x001F6A40
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
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003ABC RID: 15036
		private static readonly MessageParser<GetSignedSessionStateRequest> _parser = new MessageParser<GetSignedSessionStateRequest>(() => new GetSignedSessionStateRequest());

		// Token: 0x04003ABD RID: 15037
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ABE RID: 15038
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003ABF RID: 15039
		private GameAccountHandle agentId_;
	}
}

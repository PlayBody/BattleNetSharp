using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040E RID: 1038
	public sealed class GetFriendListRequest : IMessage<GetFriendListRequest>, IMessage, IEquatable<GetFriendListRequest>, IDeepCloneable<GetFriendListRequest>, IBufferMessage
	{
		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600668C RID: 26252 RVA: 0x0018C910 File Offset: 0x0018AB10
		[DebuggerNonUserCode]
		public static MessageParser<GetFriendListRequest> Parser
		{
			get
			{
				return GetFriendListRequest._parser;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x0018C928 File Offset: 0x0018AB28
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x0018C94C File Offset: 0x0018AB4C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendListRequest.Descriptor;
			}
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x0018C963 File Offset: 0x0018AB63
		[DebuggerNonUserCode]
		public GetFriendListRequest()
		{
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x0018C96D File Offset: 0x0018AB6D
		[DebuggerNonUserCode]
		public GetFriendListRequest(GetFriendListRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x0018C9A4 File Offset: 0x0018ABA4
		[DebuggerNonUserCode]
		public GetFriendListRequest Clone()
		{
			return new GetFriendListRequest(this);
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x0018C9BC File Offset: 0x0018ABBC
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x0018C9D4 File Offset: 0x0018ABD4
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x06006694 RID: 26260 RVA: 0x0018C9E0 File Offset: 0x0018ABE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendListRequest);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x0018CA00 File Offset: 0x0018AC00
		[DebuggerNonUserCode]
		public bool Equals(GetFriendListRequest other)
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

		// Token: 0x06006696 RID: 26262 RVA: 0x0018CA5C File Offset: 0x0018AC5C
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

		// Token: 0x06006697 RID: 26263 RVA: 0x0018CAAC File Offset: 0x0018ACAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x0018CAC4 File Offset: 0x0018ACC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0018CAD0 File Offset: 0x0018ACD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0018CB20 File Offset: 0x0018AD20
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

		// Token: 0x0600669B RID: 26267 RVA: 0x0018CB74 File Offset: 0x0018AD74
		[DebuggerNonUserCode]
		public void MergeFrom(GetFriendListRequest other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x0018CBE0 File Offset: 0x0018ADE0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0018CBEC File Offset: 0x0018ADEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002E8E RID: 11918
		private static readonly MessageParser<GetFriendListRequest> _parser = new MessageParser<GetFriendListRequest>(() => new GetFriendListRequest());

		// Token: 0x04002E8F RID: 11919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E90 RID: 11920
		public const int AgentIdFieldNumber = 2;

		// Token: 0x04002E91 RID: 11921
		private EntityId agentId_;
	}
}

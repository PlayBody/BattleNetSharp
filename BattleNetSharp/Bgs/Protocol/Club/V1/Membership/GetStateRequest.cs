using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051C RID: 1308
	public sealed class GetStateRequest : IMessage<GetStateRequest>, IMessage, IEquatable<GetStateRequest>, IDeepCloneable<GetStateRequest>, IBufferMessage
	{
		// Token: 0x17002852 RID: 10322
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x001EF768 File Offset: 0x001ED968
		[DebuggerNonUserCode]
		public static MessageParser<GetStateRequest> Parser
		{
			get
			{
				return GetStateRequest._parser;
			}
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x06007F33 RID: 32563 RVA: 0x001EF780 File Offset: 0x001ED980
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x06007F34 RID: 32564 RVA: 0x001EF7A4 File Offset: 0x001ED9A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateRequest.Descriptor;
			}
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x001EF7BB File Offset: 0x001ED9BB
		[DebuggerNonUserCode]
		public GetStateRequest()
		{
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x001EF7C8 File Offset: 0x001ED9C8
		[DebuggerNonUserCode]
		public GetStateRequest(GetStateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x001EF828 File Offset: 0x001EDA28
		[DebuggerNonUserCode]
		public GetStateRequest Clone()
		{
			return new GetStateRequest(this);
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x06007F38 RID: 32568 RVA: 0x001EF840 File Offset: 0x001EDA40
		// (set) Token: 0x06007F39 RID: 32569 RVA: 0x001EF858 File Offset: 0x001EDA58
		[DebuggerNonUserCode]
		public AccountId AgentId
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

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x06007F3A RID: 32570 RVA: 0x001EF864 File Offset: 0x001EDA64
		// (set) Token: 0x06007F3B RID: 32571 RVA: 0x001EF87C File Offset: 0x001EDA7C
		[DebuggerNonUserCode]
		public ClubMembershipGetStateOptions Options
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

		// Token: 0x06007F3C RID: 32572 RVA: 0x001EF888 File Offset: 0x001EDA88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateRequest);
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x001EF8A8 File Offset: 0x001EDAA8
		[DebuggerNonUserCode]
		public bool Equals(GetStateRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x001EF920 File Offset: 0x001EDB20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x001EF98C File Offset: 0x001EDB8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x001EF9A4 File Offset: 0x001EDBA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x001EF9B0 File Offset: 0x001EDBB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x001EFA24 File Offset: 0x001EDC24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x001EFA98 File Offset: 0x001EDC98
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateRequest other)
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
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new ClubMembershipGetStateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x001EFB45 File Offset: 0x001EDD45
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x001EFB50 File Offset: 0x001EDD50
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
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new ClubMembershipGetStateOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040039CA RID: 14794
		private static readonly MessageParser<GetStateRequest> _parser = new MessageParser<GetStateRequest>(() => new GetStateRequest());

		// Token: 0x040039CB RID: 14795
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039CC RID: 14796
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040039CD RID: 14797
		private AccountId agentId_;

		// Token: 0x040039CE RID: 14798
		public const int OptionsFieldNumber = 2;

		// Token: 0x040039CF RID: 14799
		private ClubMembershipGetStateOptions options_;
	}
}

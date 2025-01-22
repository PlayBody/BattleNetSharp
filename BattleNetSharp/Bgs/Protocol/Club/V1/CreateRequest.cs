using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049D RID: 1181
	public sealed class CreateRequest : IMessage<CreateRequest>, IMessage, IEquatable<CreateRequest>, IDeepCloneable<CreateRequest>, IBufferMessage
	{
		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x001C15B0 File Offset: 0x001BF7B0
		[DebuggerNonUserCode]
		public static MessageParser<CreateRequest> Parser
		{
			get
			{
				return CreateRequest._parser;
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x001C15C8 File Offset: 0x001BF7C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x001C15EC File Offset: 0x001BF7EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateRequest.Descriptor;
			}
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x001C1603 File Offset: 0x001BF803
		[DebuggerNonUserCode]
		public CreateRequest()
		{
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x001C1610 File Offset: 0x001BF810
		[DebuggerNonUserCode]
		public CreateRequest(CreateRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x001C1670 File Offset: 0x001BF870
		[DebuggerNonUserCode]
		public CreateRequest Clone()
		{
			return new CreateRequest(this);
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x001C1688 File Offset: 0x001BF888
		// (set) Token: 0x060072FF RID: 29439 RVA: 0x001C16A0 File Offset: 0x001BF8A0
		[DebuggerNonUserCode]
		public MemberId AgentId
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

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06007300 RID: 29440 RVA: 0x001C16AC File Offset: 0x001BF8AC
		// (set) Token: 0x06007301 RID: 29441 RVA: 0x001C16C4 File Offset: 0x001BF8C4
		[DebuggerNonUserCode]
		public ClubCreateOptions Options
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

		// Token: 0x06007302 RID: 29442 RVA: 0x001C16D0 File Offset: 0x001BF8D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateRequest);
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x001C16F0 File Offset: 0x001BF8F0
		[DebuggerNonUserCode]
		public bool Equals(CreateRequest other)
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

		// Token: 0x06007304 RID: 29444 RVA: 0x001C1768 File Offset: 0x001BF968
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

		// Token: 0x06007305 RID: 29445 RVA: 0x001C17D4 File Offset: 0x001BF9D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x001C17EC File Offset: 0x001BF9EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x001C17F8 File Offset: 0x001BF9F8
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

		// Token: 0x06007308 RID: 29448 RVA: 0x001C186C File Offset: 0x001BFA6C
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

		// Token: 0x06007309 RID: 29449 RVA: 0x001C18E0 File Offset: 0x001BFAE0
		[DebuggerNonUserCode]
		public void MergeFrom(CreateRequest other)
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
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new ClubCreateOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x001C198D File Offset: 0x001BFB8D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x001C1998 File Offset: 0x001BFB98
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
							this.Options = new ClubCreateOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x0400349C RID: 13468
		private static readonly MessageParser<CreateRequest> _parser = new MessageParser<CreateRequest>(() => new CreateRequest());

		// Token: 0x0400349D RID: 13469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400349E RID: 13470
		public const int AgentIdFieldNumber = 1;

		// Token: 0x0400349F RID: 13471
		private MemberId agentId_;

		// Token: 0x040034A0 RID: 13472
		public const int OptionsFieldNumber = 2;

		// Token: 0x040034A1 RID: 13473
		private ClubCreateOptions options_;
	}
}

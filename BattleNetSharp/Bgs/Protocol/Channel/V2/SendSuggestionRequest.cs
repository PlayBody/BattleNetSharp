using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000674 RID: 1652
	public sealed class SendSuggestionRequest : IMessage<SendSuggestionRequest>, IMessage, IEquatable<SendSuggestionRequest>, IDeepCloneable<SendSuggestionRequest>, IBufferMessage
	{
		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06009951 RID: 39249 RVA: 0x002521CC File Offset: 0x002503CC
		[DebuggerNonUserCode]
		public static MessageParser<SendSuggestionRequest> Parser
		{
			get
			{
				return SendSuggestionRequest._parser;
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x002521E4 File Offset: 0x002503E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06009953 RID: 39251 RVA: 0x00252208 File Offset: 0x00250408
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendSuggestionRequest.Descriptor;
			}
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x0025221F File Offset: 0x0025041F
		[DebuggerNonUserCode]
		public SendSuggestionRequest()
		{
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x0025222C File Offset: 0x0025042C
		[DebuggerNonUserCode]
		public SendSuggestionRequest(SendSuggestionRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x0025228C File Offset: 0x0025048C
		[DebuggerNonUserCode]
		public SendSuggestionRequest Clone()
		{
			return new SendSuggestionRequest(this);
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x06009957 RID: 39255 RVA: 0x002522A4 File Offset: 0x002504A4
		// (set) Token: 0x06009958 RID: 39256 RVA: 0x002522BC File Offset: 0x002504BC
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

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06009959 RID: 39257 RVA: 0x002522C8 File Offset: 0x002504C8
		// (set) Token: 0x0600995A RID: 39258 RVA: 0x002522E0 File Offset: 0x002504E0
		[DebuggerNonUserCode]
		public SendSuggestionOptions Options
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

		// Token: 0x0600995B RID: 39259 RVA: 0x002522EC File Offset: 0x002504EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendSuggestionRequest);
		}

		// Token: 0x0600995C RID: 39260 RVA: 0x0025230C File Offset: 0x0025050C
		[DebuggerNonUserCode]
		public bool Equals(SendSuggestionRequest other)
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

		// Token: 0x0600995D RID: 39261 RVA: 0x00252384 File Offset: 0x00250584
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

		// Token: 0x0600995E RID: 39262 RVA: 0x002523F0 File Offset: 0x002505F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00252408 File Offset: 0x00250608
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x00252414 File Offset: 0x00250614
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

		// Token: 0x06009961 RID: 39265 RVA: 0x00252488 File Offset: 0x00250688
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

		// Token: 0x06009962 RID: 39266 RVA: 0x002524FC File Offset: 0x002506FC
		[DebuggerNonUserCode]
		public void MergeFrom(SendSuggestionRequest other)
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
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new SendSuggestionOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x002525A9 File Offset: 0x002507A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x002525B4 File Offset: 0x002507B4
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
							this.Options = new SendSuggestionOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044F6 RID: 17654
		private static readonly MessageParser<SendSuggestionRequest> _parser = new MessageParser<SendSuggestionRequest>(() => new SendSuggestionRequest());

		// Token: 0x040044F7 RID: 17655
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044F8 RID: 17656
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040044F9 RID: 17657
		private GameAccountHandle agentId_;

		// Token: 0x040044FA RID: 17658
		public const int OptionsFieldNumber = 2;

		// Token: 0x040044FB RID: 17659
		private SendSuggestionOptions options_;
	}
}

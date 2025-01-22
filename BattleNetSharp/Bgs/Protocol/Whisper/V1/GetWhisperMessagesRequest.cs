using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AB RID: 939
	public sealed class GetWhisperMessagesRequest : IMessage<GetWhisperMessagesRequest>, IMessage, IEquatable<GetWhisperMessagesRequest>, IDeepCloneable<GetWhisperMessagesRequest>, IBufferMessage
	{
		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06005EAE RID: 24238 RVA: 0x0016E838 File Offset: 0x0016CA38
		[DebuggerNonUserCode]
		public static MessageParser<GetWhisperMessagesRequest> Parser
		{
			get
			{
				return GetWhisperMessagesRequest._parser;
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06005EAF RID: 24239 RVA: 0x0016E850 File Offset: 0x0016CA50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06005EB0 RID: 24240 RVA: 0x0016E874 File Offset: 0x0016CA74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWhisperMessagesRequest.Descriptor;
			}
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x0016E88B File Offset: 0x0016CA8B
		[DebuggerNonUserCode]
		public GetWhisperMessagesRequest()
		{
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x0016E898 File Offset: 0x0016CA98
		[DebuggerNonUserCode]
		public GetWhisperMessagesRequest(GetWhisperMessagesRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x0016E914 File Offset: 0x0016CB14
		[DebuggerNonUserCode]
		public GetWhisperMessagesRequest Clone()
		{
			return new GetWhisperMessagesRequest(this);
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06005EB4 RID: 24244 RVA: 0x0016E92C File Offset: 0x0016CB2C
		// (set) Token: 0x06005EB5 RID: 24245 RVA: 0x0016E944 File Offset: 0x0016CB44
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

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x0016E950 File Offset: 0x0016CB50
		// (set) Token: 0x06005EB7 RID: 24247 RVA: 0x0016E968 File Offset: 0x0016CB68
		[DebuggerNonUserCode]
		public AccountId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06005EB8 RID: 24248 RVA: 0x0016E974 File Offset: 0x0016CB74
		// (set) Token: 0x06005EB9 RID: 24249 RVA: 0x0016E98C File Offset: 0x0016CB8C
		[DebuggerNonUserCode]
		public GetEventOptions Options
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

		// Token: 0x06005EBA RID: 24250 RVA: 0x0016E998 File Offset: 0x0016CB98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWhisperMessagesRequest);
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x0016E9B8 File Offset: 0x0016CBB8
		[DebuggerNonUserCode]
		public bool Equals(GetWhisperMessagesRequest other)
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
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Options, other.Options);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x0016EA50 File Offset: 0x0016CC50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x0016EAD8 File Offset: 0x0016CCD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x0016EAF0 File Offset: 0x0016CCF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0016EAFC File Offset: 0x0016CCFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0016EB98 File Offset: 0x0016CD98
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this.options_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x0016EC2C File Offset: 0x0016CE2C
		[DebuggerNonUserCode]
		public void MergeFrom(GetWhisperMessagesRequest other)
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
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new AccountId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag6 = other.options_ != null;
				if (flag6)
				{
					bool flag7 = this.options_ == null;
					if (flag7)
					{
						this.Options = new GetEventOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x0016ED19 File Offset: 0x0016CF19
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x0016ED24 File Offset: 0x0016CF24
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
							bool flag = this.options_ == null;
							if (flag)
							{
								this.Options = new GetEventOptions();
							}
							input.ReadMessage(this.Options);
						}
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new AccountId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new AccountId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04002B41 RID: 11073
		private static readonly MessageParser<GetWhisperMessagesRequest> _parser = new MessageParser<GetWhisperMessagesRequest>(() => new GetWhisperMessagesRequest());

		// Token: 0x04002B42 RID: 11074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B43 RID: 11075
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04002B44 RID: 11076
		private AccountId agentId_;

		// Token: 0x04002B45 RID: 11077
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04002B46 RID: 11078
		private AccountId targetId_;

		// Token: 0x04002B47 RID: 11079
		public const int OptionsFieldNumber = 3;

		// Token: 0x04002B48 RID: 11080
		private GetEventOptions options_;
	}
}

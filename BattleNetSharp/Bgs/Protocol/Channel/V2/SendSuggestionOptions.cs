using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000699 RID: 1689
	public sealed class SendSuggestionOptions : IMessage<SendSuggestionOptions>, IMessage, IEquatable<SendSuggestionOptions>, IDeepCloneable<SendSuggestionOptions>, IBufferMessage
	{
		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06009CD1 RID: 40145 RVA: 0x00261BA8 File Offset: 0x0025FDA8
		[DebuggerNonUserCode]
		public static MessageParser<SendSuggestionOptions> Parser
		{
			get
			{
				return SendSuggestionOptions._parser;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x00261BC0 File Offset: 0x0025FDC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06009CD3 RID: 40147 RVA: 0x00261BE4 File Offset: 0x0025FDE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendSuggestionOptions.Descriptor;
			}
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x00261BFB File Offset: 0x0025FDFB
		[DebuggerNonUserCode]
		public SendSuggestionOptions()
		{
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x00261C08 File Offset: 0x0025FE08
		[DebuggerNonUserCode]
		public SendSuggestionOptions(SendSuggestionOptions other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.approvalId_ = ((other.approvalId_ != null) ? other.approvalId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x00261C84 File Offset: 0x0025FE84
		[DebuggerNonUserCode]
		public SendSuggestionOptions Clone()
		{
			return new SendSuggestionOptions(this);
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06009CD7 RID: 40151 RVA: 0x00261C9C File Offset: 0x0025FE9C
		// (set) Token: 0x06009CD8 RID: 40152 RVA: 0x00261CB4 File Offset: 0x0025FEB4
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06009CD9 RID: 40153 RVA: 0x00261CC0 File Offset: 0x0025FEC0
		// (set) Token: 0x06009CDA RID: 40154 RVA: 0x00261CD8 File Offset: 0x0025FED8
		[DebuggerNonUserCode]
		public GameAccountHandle TargetId
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

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06009CDB RID: 40155 RVA: 0x00261CE4 File Offset: 0x0025FEE4
		// (set) Token: 0x06009CDC RID: 40156 RVA: 0x00261CFC File Offset: 0x0025FEFC
		[DebuggerNonUserCode]
		public GameAccountHandle ApprovalId
		{
			get
			{
				return this.approvalId_;
			}
			set
			{
				this.approvalId_ = value;
			}
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x00261D08 File Offset: 0x0025FF08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendSuggestionOptions);
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x00261D28 File Offset: 0x0025FF28
		[DebuggerNonUserCode]
		public bool Equals(SendSuggestionOptions other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
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
							bool flag6 = !object.Equals(this.ApprovalId, other.ApprovalId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x00261DC0 File Offset: 0x0025FFC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				num ^= this.ApprovalId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00261E48 File Offset: 0x00260048
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x00261E60 File Offset: 0x00260060
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x00261E6C File Offset: 0x0026006C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ApprovalId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x00261F08 File Offset: 0x00260108
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool flag3 = this.approvalId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ApprovalId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x00261F9C File Offset: 0x0026019C
		[DebuggerNonUserCode]
		public void MergeFrom(SendSuggestionOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new GameAccountHandle();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool flag6 = other.approvalId_ != null;
				if (flag6)
				{
					bool flag7 = this.approvalId_ == null;
					if (flag7)
					{
						this.ApprovalId = new GameAccountHandle();
					}
					this.ApprovalId.MergeFrom(other.ApprovalId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x00262089 File Offset: 0x00260289
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x00262094 File Offset: 0x00260294
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
							bool flag = this.approvalId_ == null;
							if (flag)
							{
								this.ApprovalId = new GameAccountHandle();
							}
							input.ReadMessage(this.ApprovalId);
						}
					}
					else
					{
						bool flag2 = this.targetId_ == null;
						if (flag2)
						{
							this.TargetId = new GameAccountHandle();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x040046C9 RID: 18121
		private static readonly MessageParser<SendSuggestionOptions> _parser = new MessageParser<SendSuggestionOptions>(() => new SendSuggestionOptions());

		// Token: 0x040046CA RID: 18122
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046CB RID: 18123
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x040046CC RID: 18124
		private ChannelId channelId_;

		// Token: 0x040046CD RID: 18125
		public const int TargetIdFieldNumber = 2;

		// Token: 0x040046CE RID: 18126
		private GameAccountHandle targetId_;

		// Token: 0x040046CF RID: 18127
		public const int ApprovalIdFieldNumber = 3;

		// Token: 0x040046D0 RID: 18128
		private GameAccountHandle approvalId_;
	}
}

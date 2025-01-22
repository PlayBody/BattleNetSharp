using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003AF RID: 943
	public sealed class Whisper : IMessage<Whisper>, IMessage, IEquatable<Whisper>, IDeepCloneable<Whisper>, IBufferMessage
	{
		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06005EE3 RID: 24291 RVA: 0x0016F920 File Offset: 0x0016DB20
		[DebuggerNonUserCode]
		public static MessageParser<Whisper> Parser
		{
			get
			{
				return Whisper._parser;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06005EE4 RID: 24292 RVA: 0x0016F938 File Offset: 0x0016DB38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x0016F95C File Offset: 0x0016DB5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Whisper.Descriptor;
			}
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x0016F973 File Offset: 0x0016DB73
		[DebuggerNonUserCode]
		public Whisper()
		{
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x0016F988 File Offset: 0x0016DB88
		[DebuggerNonUserCode]
		public Whisper(Whisper other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.recipientId_ = ((other.recipientId_ != null) ? other.recipientId_.Clone() : null);
			this.content_ = other.content_;
			this.embed_ = other.embed_.Clone();
			this.creationTime_ = other.creationTime_;
			this.program_ = other.program_;
			this.messageId_ = ((other.messageId_ != null) ? other.messageId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x0016FA44 File Offset: 0x0016DC44
		[DebuggerNonUserCode]
		public Whisper Clone()
		{
			return new Whisper(this);
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x0016FA5C File Offset: 0x0016DC5C
		// (set) Token: 0x06005EEA RID: 24298 RVA: 0x0016FA74 File Offset: 0x0016DC74
		[DebuggerNonUserCode]
		public AccountId SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x0016FA80 File Offset: 0x0016DC80
		// (set) Token: 0x06005EEC RID: 24300 RVA: 0x0016FA98 File Offset: 0x0016DC98
		[DebuggerNonUserCode]
		public AccountId RecipientId
		{
			get
			{
				return this.recipientId_;
			}
			set
			{
				this.recipientId_ = value;
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x0016FAA4 File Offset: 0x0016DCA4
		// (set) Token: 0x06005EEE RID: 24302 RVA: 0x0016FAC5 File Offset: 0x0016DCC5
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? Whisper.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x0016FADC File Offset: 0x0016DCDC
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x0016FAF7 File Offset: 0x0016DCF7
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x0016FB04 File Offset: 0x0016DD04
		[DebuggerNonUserCode]
		public RepeatedField<EmbedInfo> Embed
		{
			get
			{
				return this.embed_;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06005EF2 RID: 24306 RVA: 0x0016FB1C File Offset: 0x0016DD1C
		// (set) Token: 0x06005EF3 RID: 24307 RVA: 0x0016FB4D File Offset: 0x0016DD4D
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Whisper.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06005EF4 RID: 24308 RVA: 0x0016FB68 File Offset: 0x0016DD68
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0016FB85 File Offset: 0x0016DD85
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x0016FB98 File Offset: 0x0016DD98
		// (set) Token: 0x06005EF7 RID: 24311 RVA: 0x0016FBC9 File Offset: 0x0016DDC9
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = Whisper.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.program_ = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06005EF8 RID: 24312 RVA: 0x0016FBE4 File Offset: 0x0016DDE4
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x0016FC01 File Offset: 0x0016DE01
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06005EFA RID: 24314 RVA: 0x0016FC14 File Offset: 0x0016DE14
		// (set) Token: 0x06005EFB RID: 24315 RVA: 0x0016FC2C File Offset: 0x0016DE2C
		[DebuggerNonUserCode]
		public MessageId MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x0016FC38 File Offset: 0x0016DE38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Whisper);
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0016FC58 File Offset: 0x0016DE58
		[DebuggerNonUserCode]
		public bool Equals(Whisper other)
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
					bool flag4 = !object.Equals(this.SenderId, other.SenderId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.RecipientId, other.RecipientId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Content != other.Content;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.embed_.Equals(other.embed_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CreationTime != other.CreationTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Program != other.Program;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = !object.Equals(this.MessageId, other.MessageId);
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0016FD6C File Offset: 0x0016DF6C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num ^= this.SenderId.GetHashCode();
			}
			bool flag2 = this.recipientId_ != null;
			if (flag2)
			{
				num ^= this.RecipientId.GetHashCode();
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			num ^= this.embed_.GetHashCode();
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag3 = this.messageId_ != null;
			if (flag3)
			{
				num ^= this.MessageId.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0016FE58 File Offset: 0x0016E058
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0016FE70 File Offset: 0x0016E070
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x0016FE7C File Offset: 0x0016E07C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.senderId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SenderId);
			}
			bool flag2 = this.recipientId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RecipientId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Content);
			}
			this.embed_.WriteTo(ref output, Whisper._repeated_embed_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(61);
				output.WriteFixed32(this.Program);
			}
			bool flag3 = this.messageId_ != null;
			if (flag3)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.MessageId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x0016FF94 File Offset: 0x0016E194
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderId);
			}
			bool flag2 = this.recipientId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RecipientId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			num += this.embed_.CalculateSize(Whisper._repeated_embed_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag3 = this.messageId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageId);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x00170088 File Offset: 0x0016E288
		[DebuggerNonUserCode]
		public void MergeFrom(Whisper other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.senderId_ != null;
				if (flag2)
				{
					bool flag3 = this.senderId_ == null;
					if (flag3)
					{
						this.SenderId = new AccountId();
					}
					this.SenderId.MergeFrom(other.SenderId);
				}
				bool flag4 = other.recipientId_ != null;
				if (flag4)
				{
					bool flag5 = this.recipientId_ == null;
					if (flag5)
					{
						this.RecipientId = new AccountId();
					}
					this.RecipientId.MergeFrom(other.RecipientId);
				}
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this.embed_.Add(other.embed_);
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool flag6 = other.messageId_ != null;
				if (flag6)
				{
					bool flag7 = this.messageId_ == null;
					if (flag7)
					{
						this.MessageId = new MessageId();
					}
					this.MessageId.MergeFrom(other.MessageId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x001701D8 File Offset: 0x0016E3D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x001701E4 File Offset: 0x0016E3E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0055;
							}
							this.Content = input.ReadString();
						}
						else
						{
							bool flag = this.recipientId_ == null;
							if (flag)
							{
								this.RecipientId = new AccountId();
							}
							input.ReadMessage(this.RecipientId);
						}
					}
					else
					{
						bool flag2 = this.senderId_ == null;
						if (flag2)
						{
							this.SenderId = new AccountId();
						}
						input.ReadMessage(this.SenderId);
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 34U)
					{
						if (num3 != 48U)
						{
							goto IL_0055;
						}
						this.CreationTime = input.ReadUInt64();
					}
					else
					{
						this.embed_.AddEntriesFrom(ref input, Whisper._repeated_embed_codec);
					}
				}
				else if (num3 != 61U)
				{
					if (num3 != 66U)
					{
						goto IL_0055;
					}
					bool flag3 = this.messageId_ == null;
					if (flag3)
					{
						this.MessageId = new MessageId();
					}
					input.ReadMessage(this.MessageId);
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
				continue;
				IL_0055:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B66 RID: 11110
		private static readonly MessageParser<Whisper> _parser = new MessageParser<Whisper>(() => new Whisper());

		// Token: 0x04002B67 RID: 11111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B68 RID: 11112
		private int _hasBits0;

		// Token: 0x04002B69 RID: 11113
		public const int SenderIdFieldNumber = 1;

		// Token: 0x04002B6A RID: 11114
		private AccountId senderId_;

		// Token: 0x04002B6B RID: 11115
		public const int RecipientIdFieldNumber = 2;

		// Token: 0x04002B6C RID: 11116
		private AccountId recipientId_;

		// Token: 0x04002B6D RID: 11117
		public const int ContentFieldNumber = 3;

		// Token: 0x04002B6E RID: 11118
		private static readonly string ContentDefaultValue = "";

		// Token: 0x04002B6F RID: 11119
		private string content_;

		// Token: 0x04002B70 RID: 11120
		public const int EmbedFieldNumber = 4;

		// Token: 0x04002B71 RID: 11121
		private static readonly FieldCodec<EmbedInfo> _repeated_embed_codec = FieldCodec.ForMessage<EmbedInfo>(34U, EmbedInfo.Parser);

		// Token: 0x04002B72 RID: 11122
		private readonly RepeatedField<EmbedInfo> embed_ = new RepeatedField<EmbedInfo>();

		// Token: 0x04002B73 RID: 11123
		public const int CreationTimeFieldNumber = 6;

		// Token: 0x04002B74 RID: 11124
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04002B75 RID: 11125
		private ulong creationTime_;

		// Token: 0x04002B76 RID: 11126
		public const int ProgramFieldNumber = 7;

		// Token: 0x04002B77 RID: 11127
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002B78 RID: 11128
		private uint program_;

		// Token: 0x04002B79 RID: 11129
		public const int MessageIdFieldNumber = 8;

		// Token: 0x04002B7A RID: 11130
		private MessageId messageId_;
	}
}

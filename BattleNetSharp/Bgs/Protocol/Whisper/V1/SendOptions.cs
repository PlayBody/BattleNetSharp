using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003B1 RID: 945
	public sealed class SendOptions : IMessage<SendOptions>, IMessage, IEquatable<SendOptions>, IDeepCloneable<SendOptions>, IBufferMessage
	{
		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x00170958 File Offset: 0x0016EB58
		[DebuggerNonUserCode]
		public static MessageParser<SendOptions> Parser
		{
			get
			{
				return SendOptions._parser;
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x00170970 File Offset: 0x0016EB70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x00170994 File Offset: 0x0016EB94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendOptions.Descriptor;
			}
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x001709AB File Offset: 0x0016EBAB
		[DebuggerNonUserCode]
		public SendOptions()
		{
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x001709B8 File Offset: 0x0016EBB8
		[DebuggerNonUserCode]
		public SendOptions(SendOptions other)
			: this()
		{
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x00170A08 File Offset: 0x0016EC08
		[DebuggerNonUserCode]
		public SendOptions Clone()
		{
			return new SendOptions(this);
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x00170A20 File Offset: 0x0016EC20
		// (set) Token: 0x06005F27 RID: 24359 RVA: 0x00170A38 File Offset: 0x0016EC38
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

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x00170A44 File Offset: 0x0016EC44
		// (set) Token: 0x06005F29 RID: 24361 RVA: 0x00170A65 File Offset: 0x0016EC65
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? SendOptions.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x00170A7C File Offset: 0x0016EC7C
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x00170A97 File Offset: 0x0016EC97
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x00170AA4 File Offset: 0x0016ECA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendOptions);
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x00170AC4 File Offset: 0x0016ECC4
		[DebuggerNonUserCode]
		public bool Equals(SendOptions other)
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
					bool flag4 = !object.Equals(this.TargetId, other.TargetId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Content != other.Content;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x00170B38 File Offset: 0x0016ED38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x00170BA0 File Offset: 0x0016EDA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x00170BB8 File Offset: 0x0016EDB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00170BC4 File Offset: 0x0016EDC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Content);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00170C38 File Offset: 0x0016EE38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00170CA8 File Offset: 0x0016EEA8
		[DebuggerNonUserCode]
		public void MergeFrom(SendOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.targetId_ != null;
				if (flag2)
				{
					bool flag3 = this.targetId_ == null;
					if (flag3)
					{
						this.TargetId = new AccountId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00170D2D File Offset: 0x0016EF2D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x00170D38 File Offset: 0x0016EF38
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
						this.Content = input.ReadString();
					}
				}
				else
				{
					bool flag = this.targetId_ == null;
					if (flag)
					{
						this.TargetId = new AccountId();
					}
					input.ReadMessage(this.TargetId);
				}
			}
		}

		// Token: 0x04002B84 RID: 11140
		private static readonly MessageParser<SendOptions> _parser = new MessageParser<SendOptions>(() => new SendOptions());

		// Token: 0x04002B85 RID: 11141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B86 RID: 11142
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04002B87 RID: 11143
		private AccountId targetId_;

		// Token: 0x04002B88 RID: 11144
		public const int ContentFieldNumber = 2;

		// Token: 0x04002B89 RID: 11145
		private static readonly string ContentDefaultValue = "";

		// Token: 0x04002B8A RID: 11146
		private string content_;
	}
}

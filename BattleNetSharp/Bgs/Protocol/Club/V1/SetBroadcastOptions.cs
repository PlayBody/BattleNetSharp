using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043D RID: 1085
	public sealed class SetBroadcastOptions : IMessage<SetBroadcastOptions>, IMessage, IEquatable<SetBroadcastOptions>, IDeepCloneable<SetBroadcastOptions>, IBufferMessage
	{
		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x0019C3A0 File Offset: 0x0019A5A0
		[DebuggerNonUserCode]
		public static MessageParser<SetBroadcastOptions> Parser
		{
			get
			{
				return SetBroadcastOptions._parser;
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x0019C3B8 File Offset: 0x0019A5B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x0019C3DC File Offset: 0x0019A5DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBroadcastOptions.Descriptor;
			}
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0019C3F3 File Offset: 0x0019A5F3
		[DebuggerNonUserCode]
		public SetBroadcastOptions()
		{
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x0019C3FD File Offset: 0x0019A5FD
		[DebuggerNonUserCode]
		public SetBroadcastOptions(SetBroadcastOptions other)
			: this()
		{
			this.content_ = other.content_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x0019C424 File Offset: 0x0019A624
		[DebuggerNonUserCode]
		public SetBroadcastOptions Clone()
		{
			return new SetBroadcastOptions(this);
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x0019C43C File Offset: 0x0019A63C
		// (set) Token: 0x06006A6C RID: 27244 RVA: 0x0019C45D File Offset: 0x0019A65D
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? SetBroadcastOptions.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x0019C474 File Offset: 0x0019A674
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0019C48F File Offset: 0x0019A68F
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0019C49C File Offset: 0x0019A69C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBroadcastOptions);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0019C4BC File Offset: 0x0019A6BC
		[DebuggerNonUserCode]
		public bool Equals(SetBroadcastOptions other)
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
					bool flag4 = this.Content != other.Content;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0019C514 File Offset: 0x0019A714
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0019C560 File Offset: 0x0019A760
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0019C578 File Offset: 0x0019A778
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0019C584 File Offset: 0x0019A784
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Content);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0019C5D0 File Offset: 0x0019A7D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x0019C620 File Offset: 0x0019A820
		[DebuggerNonUserCode]
		public void MergeFrom(SetBroadcastOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0019C669 File Offset: 0x0019A869
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0019C674 File Offset: 0x0019A874
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
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x04003072 RID: 12402
		private static readonly MessageParser<SetBroadcastOptions> _parser = new MessageParser<SetBroadcastOptions>(() => new SetBroadcastOptions());

		// Token: 0x04003073 RID: 12403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003074 RID: 12404
		public const int ContentFieldNumber = 1;

		// Token: 0x04003075 RID: 12405
		private static readonly string ContentDefaultValue = "";

		// Token: 0x04003076 RID: 12406
		private string content_;
	}
}

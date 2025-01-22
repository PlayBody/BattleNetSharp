using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000099 RID: 153
	public sealed class UITreeResponse : IMessage<UITreeResponse>, IMessage, IEquatable<UITreeResponse>, IDeepCloneable<UITreeResponse>, IBufferMessage
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00034E04 File Offset: 0x00033004
		[DebuggerNonUserCode]
		public static MessageParser<UITreeResponse> Parser
		{
			get
			{
				return UITreeResponse._parser;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00034E1C File Offset: 0x0003301C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[130];
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00034E44 File Offset: 0x00033044
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeResponse.Descriptor;
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00034E5B File Offset: 0x0003305B
		[DebuggerNonUserCode]
		public UITreeResponse()
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00034E65 File Offset: 0x00033065
		[DebuggerNonUserCode]
		public UITreeResponse(UITreeResponse other)
			: this()
		{
			this.rootNode_ = ((other.rootNode_ != null) ? other.rootNode_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00034E9C File Offset: 0x0003309C
		[DebuggerNonUserCode]
		public UITreeResponse Clone()
		{
			return new UITreeResponse(this);
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00034EB4 File Offset: 0x000330B4
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x00034ECC File Offset: 0x000330CC
		[DebuggerNonUserCode]
		public UITreeNode RootNode
		{
			get
			{
				return this.rootNode_;
			}
			set
			{
				this.rootNode_ = value;
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00034ED8 File Offset: 0x000330D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeResponse);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00034EF8 File Offset: 0x000330F8
		[DebuggerNonUserCode]
		public bool Equals(UITreeResponse other)
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
					bool flag4 = !object.Equals(this.RootNode, other.RootNode);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00034F54 File Offset: 0x00033154
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.rootNode_ != null;
			if (flag)
			{
				num ^= this.RootNode.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00034FA4 File Offset: 0x000331A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00034FBC File Offset: 0x000331BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00034FC8 File Offset: 0x000331C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.rootNode_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RootNode);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00035018 File Offset: 0x00033218
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.rootNode_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RootNode);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0003506C File Offset: 0x0003326C
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.rootNode_ != null;
				if (flag2)
				{
					bool flag3 = this.rootNode_ == null;
					if (flag3)
					{
						this.RootNode = new UITreeNode();
					}
					this.RootNode.MergeFrom(other.RootNode);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000350D8 File Offset: 0x000332D8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000350E4 File Offset: 0x000332E4
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
					bool flag = this.rootNode_ == null;
					if (flag)
					{
						this.RootNode = new UITreeNode();
					}
					input.ReadMessage(this.RootNode);
				}
			}
		}

		// Token: 0x040005A5 RID: 1445
		private static readonly MessageParser<UITreeResponse> _parser = new MessageParser<UITreeResponse>(() => new UITreeResponse());

		// Token: 0x040005A6 RID: 1446
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005A7 RID: 1447
		public const int RootNodeFieldNumber = 1;

		// Token: 0x040005A8 RID: 1448
		private UITreeNode rootNode_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000350 RID: 848
	public sealed class TitleIconContentHandle : IMessage<TitleIconContentHandle>, IMessage, IEquatable<TitleIconContentHandle>, IDeepCloneable<TitleIconContentHandle>, IBufferMessage
	{
		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x0600581B RID: 22555 RVA: 0x00154F38 File Offset: 0x00153138
		[DebuggerNonUserCode]
		public static MessageParser<TitleIconContentHandle> Parser
		{
			get
			{
				return TitleIconContentHandle._parser;
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x00154F50 File Offset: 0x00153150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentHandleTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600581D RID: 22557 RVA: 0x00154F74 File Offset: 0x00153174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TitleIconContentHandle.Descriptor;
			}
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00154F8B File Offset: 0x0015318B
		[DebuggerNonUserCode]
		public TitleIconContentHandle()
		{
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00154F98 File Offset: 0x00153198
		[DebuggerNonUserCode]
		public TitleIconContentHandle(TitleIconContentHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this.contentHandle_ = ((other.contentHandle_ != null) ? other.contentHandle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00154FF4 File Offset: 0x001531F4
		[DebuggerNonUserCode]
		public TitleIconContentHandle Clone()
		{
			return new TitleIconContentHandle(this);
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06005821 RID: 22561 RVA: 0x0015500C File Offset: 0x0015320C
		// (set) Token: 0x06005822 RID: 22562 RVA: 0x0015503D File Offset: 0x0015323D
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = TitleIconContentHandle.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x00155058 File Offset: 0x00153258
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x00155075 File Offset: 0x00153275
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06005825 RID: 22565 RVA: 0x00155088 File Offset: 0x00153288
		// (set) Token: 0x06005826 RID: 22566 RVA: 0x001550A0 File Offset: 0x001532A0
		[DebuggerNonUserCode]
		public ContentHandle ContentHandle
		{
			get
			{
				return this.contentHandle_;
			}
			set
			{
				this.contentHandle_ = value;
			}
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x001550AC File Offset: 0x001532AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TitleIconContentHandle);
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x001550CC File Offset: 0x001532CC
		[DebuggerNonUserCode]
		public bool Equals(TitleIconContentHandle other)
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
					bool flag4 = this.TitleId != other.TitleId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ContentHandle, other.ContentHandle);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00155140 File Offset: 0x00153340
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				num ^= this.ContentHandle.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x001551AC File Offset: 0x001533AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x001551C4 File Offset: 0x001533C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x001551D0 File Offset: 0x001533D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ContentHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x00155240 File Offset: 0x00153440
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ContentHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x001552B0 File Offset: 0x001534B0
		[DebuggerNonUserCode]
		public void MergeFrom(TitleIconContentHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				bool flag2 = other.contentHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.contentHandle_ == null;
					if (flag3)
					{
						this.ContentHandle = new ContentHandle();
					}
					this.ContentHandle.MergeFrom(other.ContentHandle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00155335 File Offset: 0x00153535
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00155340 File Offset: 0x00153540
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.contentHandle_ == null;
						if (flag)
						{
							this.ContentHandle = new ContentHandle();
						}
						input.ReadMessage(this.ContentHandle);
					}
				}
				else
				{
					this.TitleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400283A RID: 10298
		private static readonly MessageParser<TitleIconContentHandle> _parser = new MessageParser<TitleIconContentHandle>(() => new TitleIconContentHandle());

		// Token: 0x0400283B RID: 10299
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400283C RID: 10300
		private int _hasBits0;

		// Token: 0x0400283D RID: 10301
		public const int TitleIdFieldNumber = 1;

		// Token: 0x0400283E RID: 10302
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x0400283F RID: 10303
		private uint titleId_;

		// Token: 0x04002840 RID: 10304
		public const int ContentHandleFieldNumber = 2;

		// Token: 0x04002841 RID: 10305
		private ContentHandle contentHandle_;
	}
}

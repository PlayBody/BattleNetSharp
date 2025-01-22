using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043E RID: 1086
	public sealed class Broadcast : IMessage<Broadcast>, IMessage, IEquatable<Broadcast>, IDeepCloneable<Broadcast>, IBufferMessage
	{
		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06006A7A RID: 27258 RVA: 0x0019C6EC File Offset: 0x0019A8EC
		[DebuggerNonUserCode]
		public static MessageParser<Broadcast> Parser
		{
			get
			{
				return Broadcast._parser;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06006A7B RID: 27259 RVA: 0x0019C704 File Offset: 0x0019A904
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x0019C728 File Offset: 0x0019A928
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Broadcast.Descriptor;
			}
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x0019C73F File Offset: 0x0019A93F
		[DebuggerNonUserCode]
		public Broadcast()
		{
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x0019C74C File Offset: 0x0019A94C
		[DebuggerNonUserCode]
		public Broadcast(Broadcast other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.content_ = other.content_;
			this.creator_ = ((other.creator_ != null) ? other.creator_.Clone() : null);
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x0019C7B4 File Offset: 0x0019A9B4
		[DebuggerNonUserCode]
		public Broadcast Clone()
		{
			return new Broadcast(this);
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06006A80 RID: 27264 RVA: 0x0019C7CC File Offset: 0x0019A9CC
		// (set) Token: 0x06006A81 RID: 27265 RVA: 0x0019C7ED File Offset: 0x0019A9ED
		[DebuggerNonUserCode]
		public string Content
		{
			get
			{
				return this.content_ ?? Broadcast.ContentDefaultValue;
			}
			set
			{
				this.content_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x0019C804 File Offset: 0x0019AA04
		[DebuggerNonUserCode]
		public bool HasContent
		{
			get
			{
				return this.content_ != null;
			}
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x0019C81F File Offset: 0x0019AA1F
		[DebuggerNonUserCode]
		public void ClearContent()
		{
			this.content_ = null;
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x0019C82C File Offset: 0x0019AA2C
		// (set) Token: 0x06006A85 RID: 27269 RVA: 0x0019C844 File Offset: 0x0019AA44
		[DebuggerNonUserCode]
		public MemberDescription Creator
		{
			get
			{
				return this.creator_;
			}
			set
			{
				this.creator_ = value;
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x0019C850 File Offset: 0x0019AA50
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x0019C881 File Offset: 0x0019AA81
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
					creationTimeDefaultValue = Broadcast.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTime_ = value;
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x0019C89C File Offset: 0x0019AA9C
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x0019C8B9 File Offset: 0x0019AAB9
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0019C8CC File Offset: 0x0019AACC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Broadcast);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0019C8EC File Offset: 0x0019AAEC
		[DebuggerNonUserCode]
		public bool Equals(Broadcast other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Creator, other.Creator);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreationTime != other.CreationTime;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x0019C97C File Offset: 0x0019AB7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num ^= this.Content.GetHashCode();
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				num ^= this.Creator.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x0019CA04 File Offset: 0x0019AC04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x0019CA1C File Offset: 0x0019AC1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x0019CA28 File Offset: 0x0019AC28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Content);
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Creator);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x0019CABC File Offset: 0x0019ACBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContent = this.HasContent;
			if (hasContent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Content);
			}
			bool flag = this.creator_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Creator);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x0019CB4C File Offset: 0x0019AD4C
		[DebuggerNonUserCode]
		public void MergeFrom(Broadcast other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContent = other.HasContent;
				if (hasContent)
				{
					this.Content = other.Content;
				}
				bool flag2 = other.creator_ != null;
				if (flag2)
				{
					bool flag3 = this.creator_ == null;
					if (flag3)
					{
						this.Creator = new MemberDescription();
					}
					this.Creator.MergeFrom(other.Creator);
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x0019CBEF File Offset: 0x0019ADEF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x0019CBFC File Offset: 0x0019ADFC
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CreationTime = input.ReadUInt64();
						}
					}
					else
					{
						bool flag = this.creator_ == null;
						if (flag)
						{
							this.Creator = new MemberDescription();
						}
						input.ReadMessage(this.Creator);
					}
				}
				else
				{
					this.Content = input.ReadString();
				}
			}
		}

		// Token: 0x04003077 RID: 12407
		private static readonly MessageParser<Broadcast> _parser = new MessageParser<Broadcast>(() => new Broadcast());

		// Token: 0x04003078 RID: 12408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003079 RID: 12409
		private int _hasBits0;

		// Token: 0x0400307A RID: 12410
		public const int ContentFieldNumber = 1;

		// Token: 0x0400307B RID: 12411
		private static readonly string ContentDefaultValue = "";

		// Token: 0x0400307C RID: 12412
		private string content_;

		// Token: 0x0400307D RID: 12413
		public const int CreatorFieldNumber = 2;

		// Token: 0x0400307E RID: 12414
		private MemberDescription creator_;

		// Token: 0x0400307F RID: 12415
		public const int CreationTimeFieldNumber = 3;

		// Token: 0x04003080 RID: 12416
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04003081 RID: 12417
		private ulong creationTime_;
	}
}

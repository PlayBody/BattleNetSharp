using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B7 RID: 183
	public sealed class StoryboardEditorInstanceAttachmentRequest : IMessage<StoryboardEditorInstanceAttachmentRequest>, IMessage, IEquatable<StoryboardEditorInstanceAttachmentRequest>, IDeepCloneable<StoryboardEditorInstanceAttachmentRequest>, IBufferMessage
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003EC74 File Offset: 0x0003CE74
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardEditorInstanceAttachmentRequest> Parser
		{
			get
			{
				return StoryboardEditorInstanceAttachmentRequest._parser;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0003EC8C File Offset: 0x0003CE8C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[160];
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardEditorInstanceAttachmentRequest.Descriptor;
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0003ECCB File Offset: 0x0003CECB
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceAttachmentRequest()
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0003ECD8 File Offset: 0x0003CED8
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceAttachmentRequest(StoryboardEditorInstanceAttachmentRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.editorId_ = other.editorId_;
			this.listId_ = other.listId_;
			this.instanceIndex_ = other.instanceIndex_;
			this.isAttached_ = other.isAttached_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0003ED3C File Offset: 0x0003CF3C
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceAttachmentRequest Clone()
		{
			return new StoryboardEditorInstanceAttachmentRequest(this);
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0003ED54 File Offset: 0x0003CF54
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0003ED85 File Offset: 0x0003CF85
		[DebuggerNonUserCode]
		public int EditorId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int editorIdDefaultValue;
				if (flag)
				{
					editorIdDefaultValue = this.editorId_;
				}
				else
				{
					editorIdDefaultValue = StoryboardEditorInstanceAttachmentRequest.EditorIdDefaultValue;
				}
				return editorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.editorId_ = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0003EDA0 File Offset: 0x0003CFA0
		[DebuggerNonUserCode]
		public bool HasEditorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0003EDBD File Offset: 0x0003CFBD
		[DebuggerNonUserCode]
		public void ClearEditorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0003EDD0 File Offset: 0x0003CFD0
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0003EE01 File Offset: 0x0003D001
		[DebuggerNonUserCode]
		public int ListId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int listIdDefaultValue;
				if (flag)
				{
					listIdDefaultValue = this.listId_;
				}
				else
				{
					listIdDefaultValue = StoryboardEditorInstanceAttachmentRequest.ListIdDefaultValue;
				}
				return listIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.listId_ = value;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0003EE1C File Offset: 0x0003D01C
		[DebuggerNonUserCode]
		public bool HasListId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0003EE39 File Offset: 0x0003D039
		[DebuggerNonUserCode]
		public void ClearListId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0003EE4C File Offset: 0x0003D04C
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0003EE7D File Offset: 0x0003D07D
		[DebuggerNonUserCode]
		public int InstanceIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int instanceIndexDefaultValue;
				if (flag)
				{
					instanceIndexDefaultValue = this.instanceIndex_;
				}
				else
				{
					instanceIndexDefaultValue = StoryboardEditorInstanceAttachmentRequest.InstanceIndexDefaultValue;
				}
				return instanceIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.instanceIndex_ = value;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0003EE98 File Offset: 0x0003D098
		[DebuggerNonUserCode]
		public bool HasInstanceIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0003EEB5 File Offset: 0x0003D0B5
		[DebuggerNonUserCode]
		public void ClearInstanceIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0003EEC8 File Offset: 0x0003D0C8
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0003EEF9 File Offset: 0x0003D0F9
		[DebuggerNonUserCode]
		public bool IsAttached
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isAttachedDefaultValue;
				if (flag)
				{
					isAttachedDefaultValue = this.isAttached_;
				}
				else
				{
					isAttachedDefaultValue = StoryboardEditorInstanceAttachmentRequest.IsAttachedDefaultValue;
				}
				return isAttachedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isAttached_ = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0003EF14 File Offset: 0x0003D114
		[DebuggerNonUserCode]
		public bool HasIsAttached
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0003EF31 File Offset: 0x0003D131
		[DebuggerNonUserCode]
		public void ClearIsAttached()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0003EF44 File Offset: 0x0003D144
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardEditorInstanceAttachmentRequest);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0003EF64 File Offset: 0x0003D164
		[DebuggerNonUserCode]
		public bool Equals(StoryboardEditorInstanceAttachmentRequest other)
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
					bool flag4 = this.EditorId != other.EditorId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ListId != other.ListId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.InstanceIndex != other.InstanceIndex;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsAttached != other.IsAttached;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0003F010 File Offset: 0x0003D210
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEditorId = this.HasEditorId;
			if (hasEditorId)
			{
				num ^= this.EditorId.GetHashCode();
			}
			bool hasListId = this.HasListId;
			if (hasListId)
			{
				num ^= this.ListId.GetHashCode();
			}
			bool hasInstanceIndex = this.HasInstanceIndex;
			if (hasInstanceIndex)
			{
				num ^= this.InstanceIndex.GetHashCode();
			}
			bool hasIsAttached = this.HasIsAttached;
			if (hasIsAttached)
			{
				num ^= this.IsAttached.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0003F0B8 File Offset: 0x0003D2B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0003F0D0 File Offset: 0x0003D2D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0003F0DC File Offset: 0x0003D2DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEditorId = this.HasEditorId;
			if (hasEditorId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EditorId);
			}
			bool hasListId = this.HasListId;
			if (hasListId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ListId);
			}
			bool hasInstanceIndex = this.HasInstanceIndex;
			if (hasInstanceIndex)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstanceIndex);
			}
			bool hasIsAttached = this.HasIsAttached;
			if (hasIsAttached)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsAttached);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0003F190 File Offset: 0x0003D390
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEditorId = this.HasEditorId;
			if (hasEditorId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EditorId);
			}
			bool hasListId = this.HasListId;
			if (hasListId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ListId);
			}
			bool hasInstanceIndex = this.HasInstanceIndex;
			if (hasInstanceIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstanceIndex);
			}
			bool hasIsAttached = this.HasIsAttached;
			if (hasIsAttached)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0003F22C File Offset: 0x0003D42C
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardEditorInstanceAttachmentRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEditorId = other.HasEditorId;
				if (hasEditorId)
				{
					this.EditorId = other.EditorId;
				}
				bool hasListId = other.HasListId;
				if (hasListId)
				{
					this.ListId = other.ListId;
				}
				bool hasInstanceIndex = other.HasInstanceIndex;
				if (hasInstanceIndex)
				{
					this.InstanceIndex = other.InstanceIndex;
				}
				bool hasIsAttached = other.HasIsAttached;
				if (hasIsAttached)
				{
					this.IsAttached = other.IsAttached;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0003F2C2 File Offset: 0x0003D4C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0003F2D0 File Offset: 0x0003D4D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.ListId = input.ReadInt32();
					}
					else
					{
						this.EditorId = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.IsAttached = input.ReadBool();
				}
				else
				{
					this.InstanceIndex = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040006D9 RID: 1753
		private static readonly MessageParser<StoryboardEditorInstanceAttachmentRequest> _parser = new MessageParser<StoryboardEditorInstanceAttachmentRequest>(() => new StoryboardEditorInstanceAttachmentRequest());

		// Token: 0x040006DA RID: 1754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006DB RID: 1755
		private int _hasBits0;

		// Token: 0x040006DC RID: 1756
		public const int EditorIdFieldNumber = 1;

		// Token: 0x040006DD RID: 1757
		private static readonly int EditorIdDefaultValue = 0;

		// Token: 0x040006DE RID: 1758
		private int editorId_;

		// Token: 0x040006DF RID: 1759
		public const int ListIdFieldNumber = 2;

		// Token: 0x040006E0 RID: 1760
		private static readonly int ListIdDefaultValue = 0;

		// Token: 0x040006E1 RID: 1761
		private int listId_;

		// Token: 0x040006E2 RID: 1762
		public const int InstanceIndexFieldNumber = 3;

		// Token: 0x040006E3 RID: 1763
		private static readonly int InstanceIndexDefaultValue = 0;

		// Token: 0x040006E4 RID: 1764
		private int instanceIndex_;

		// Token: 0x040006E5 RID: 1765
		public const int IsAttachedFieldNumber = 4;

		// Token: 0x040006E6 RID: 1766
		private static readonly bool IsAttachedDefaultValue = false;

		// Token: 0x040006E7 RID: 1767
		private bool isAttached_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B5 RID: 181
	public sealed class StoryboardEditorStoryboardInstanceList : IMessage<StoryboardEditorStoryboardInstanceList>, IMessage, IEquatable<StoryboardEditorStoryboardInstanceList>, IDeepCloneable<StoryboardEditorStoryboardInstanceList>, IBufferMessage
	{
		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0003DE74 File Offset: 0x0003C074
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardEditorStoryboardInstanceList> Parser
		{
			get
			{
				return StoryboardEditorStoryboardInstanceList._parser;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0003DE8C File Offset: 0x0003C08C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[158];
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0003DEB4 File Offset: 0x0003C0B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardEditorStoryboardInstanceList.Descriptor;
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003DECB File Offset: 0x0003C0CB
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceList()
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceList(StoryboardEditorStoryboardInstanceList other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.editorId_ = other.editorId_;
			this.listId_ = other.listId_;
			this.instances_ = other.instances_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0003DF3C File Offset: 0x0003C13C
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceList Clone()
		{
			return new StoryboardEditorStoryboardInstanceList(this);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0003DF54 File Offset: 0x0003C154
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x0003DF85 File Offset: 0x0003C185
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
					editorIdDefaultValue = StoryboardEditorStoryboardInstanceList.EditorIdDefaultValue;
				}
				return editorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.editorId_ = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0003DFA0 File Offset: 0x0003C1A0
		[DebuggerNonUserCode]
		public bool HasEditorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0003DFBD File Offset: 0x0003C1BD
		[DebuggerNonUserCode]
		public void ClearEditorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0003E001 File Offset: 0x0003C201
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
					listIdDefaultValue = StoryboardEditorStoryboardInstanceList.ListIdDefaultValue;
				}
				return listIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.listId_ = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0003E01C File Offset: 0x0003C21C
		[DebuggerNonUserCode]
		public bool HasListId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0003E039 File Offset: 0x0003C239
		[DebuggerNonUserCode]
		public void ClearListId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0003E04C File Offset: 0x0003C24C
		[DebuggerNonUserCode]
		public RepeatedField<StoryboardInstance> Instances
		{
			get
			{
				return this.instances_;
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0003E064 File Offset: 0x0003C264
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardEditorStoryboardInstanceList);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0003E084 File Offset: 0x0003C284
		[DebuggerNonUserCode]
		public bool Equals(StoryboardEditorStoryboardInstanceList other)
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
							bool flag6 = !this.instances_.Equals(other.instances_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0003E114 File Offset: 0x0003C314
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
			num ^= this.instances_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0003E190 File Offset: 0x0003C390
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0003E1B4 File Offset: 0x0003C3B4
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
			this.instances_.WriteTo(ref output, StoryboardEditorStoryboardInstanceList._repeated_instances_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0003E234 File Offset: 0x0003C434
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
			num += this.instances_.CalculateSize(StoryboardEditorStoryboardInstanceList._repeated_instances_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0003E2B4 File Offset: 0x0003C4B4
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardEditorStoryboardInstanceList other)
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
				this.instances_.Add(other.instances_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0003E328 File Offset: 0x0003C528
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0003E334 File Offset: 0x0003C534
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.instances_.AddEntriesFrom(ref input, StoryboardEditorStoryboardInstanceList._repeated_instances_codec);
						}
					}
					else
					{
						this.ListId = input.ReadInt32();
					}
				}
				else
				{
					this.EditorId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040006BB RID: 1723
		private static readonly MessageParser<StoryboardEditorStoryboardInstanceList> _parser = new MessageParser<StoryboardEditorStoryboardInstanceList>(() => new StoryboardEditorStoryboardInstanceList());

		// Token: 0x040006BC RID: 1724
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006BD RID: 1725
		private int _hasBits0;

		// Token: 0x040006BE RID: 1726
		public const int EditorIdFieldNumber = 1;

		// Token: 0x040006BF RID: 1727
		private static readonly int EditorIdDefaultValue = 0;

		// Token: 0x040006C0 RID: 1728
		private int editorId_;

		// Token: 0x040006C1 RID: 1729
		public const int ListIdFieldNumber = 2;

		// Token: 0x040006C2 RID: 1730
		private static readonly int ListIdDefaultValue = 0;

		// Token: 0x040006C3 RID: 1731
		private int listId_;

		// Token: 0x040006C4 RID: 1732
		public const int InstancesFieldNumber = 3;

		// Token: 0x040006C5 RID: 1733
		private static readonly FieldCodec<StoryboardInstance> _repeated_instances_codec = FieldCodec.ForMessage<StoryboardInstance>(26U, StoryboardInstance.Parser);

		// Token: 0x040006C6 RID: 1734
		private readonly RepeatedField<StoryboardInstance> instances_ = new RepeatedField<StoryboardInstance>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B8 RID: 184
	public sealed class StoryboardEditorInstanceTimeChanged : IMessage<StoryboardEditorInstanceTimeChanged>, IMessage, IEquatable<StoryboardEditorInstanceTimeChanged>, IDeepCloneable<StoryboardEditorInstanceTimeChanged>, IBufferMessage
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardEditorInstanceTimeChanged> Parser
		{
			get
			{
				return StoryboardEditorInstanceTimeChanged._parser;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0003F3B8 File Offset: 0x0003D5B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[161];
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0003F3E0 File Offset: 0x0003D5E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardEditorInstanceTimeChanged.Descriptor;
			}
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0003F3F7 File Offset: 0x0003D5F7
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceTimeChanged()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0003F404 File Offset: 0x0003D604
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceTimeChanged(StoryboardEditorInstanceTimeChanged other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.editorId_ = other.editorId_;
			this.listId_ = other.listId_;
			this.instanceIndex_ = other.instanceIndex_;
			this.time_ = other.time_;
			this.isPlaying_ = other.isPlaying_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0003F474 File Offset: 0x0003D674
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceTimeChanged Clone()
		{
			return new StoryboardEditorInstanceTimeChanged(this);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0003F48C File Offset: 0x0003D68C
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0003F4BD File Offset: 0x0003D6BD
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
					editorIdDefaultValue = StoryboardEditorInstanceTimeChanged.EditorIdDefaultValue;
				}
				return editorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.editorId_ = value;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0003F4D8 File Offset: 0x0003D6D8
		[DebuggerNonUserCode]
		public bool HasEditorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0003F4F5 File Offset: 0x0003D6F5
		[DebuggerNonUserCode]
		public void ClearEditorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0003F508 File Offset: 0x0003D708
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x0003F539 File Offset: 0x0003D739
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
					listIdDefaultValue = StoryboardEditorInstanceTimeChanged.ListIdDefaultValue;
				}
				return listIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.listId_ = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0003F554 File Offset: 0x0003D754
		[DebuggerNonUserCode]
		public bool HasListId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0003F571 File Offset: 0x0003D771
		[DebuggerNonUserCode]
		public void ClearListId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0003F584 File Offset: 0x0003D784
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0003F5B5 File Offset: 0x0003D7B5
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
					instanceIndexDefaultValue = StoryboardEditorInstanceTimeChanged.InstanceIndexDefaultValue;
				}
				return instanceIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.instanceIndex_ = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
		[DebuggerNonUserCode]
		public bool HasInstanceIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0003F5ED File Offset: 0x0003D7ED
		[DebuggerNonUserCode]
		public void ClearInstanceIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0003F600 File Offset: 0x0003D800
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0003F631 File Offset: 0x0003D831
		[DebuggerNonUserCode]
		public float Time
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				float timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = StoryboardEditorInstanceTimeChanged.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.time_ = value;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0003F64C File Offset: 0x0003D84C
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0003F669 File Offset: 0x0003D869
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0003F67C File Offset: 0x0003D87C
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0003F6AE File Offset: 0x0003D8AE
		[DebuggerNonUserCode]
		public bool IsPlaying
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool isPlayingDefaultValue;
				if (flag)
				{
					isPlayingDefaultValue = this.isPlaying_;
				}
				else
				{
					isPlayingDefaultValue = StoryboardEditorInstanceTimeChanged.IsPlayingDefaultValue;
				}
				return isPlayingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isPlaying_ = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0003F6C8 File Offset: 0x0003D8C8
		[DebuggerNonUserCode]
		public bool HasIsPlaying
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0003F6E6 File Offset: 0x0003D8E6
		[DebuggerNonUserCode]
		public void ClearIsPlaying()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0003F6F8 File Offset: 0x0003D8F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardEditorInstanceTimeChanged);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0003F718 File Offset: 0x0003D918
		[DebuggerNonUserCode]
		public bool Equals(StoryboardEditorInstanceTimeChanged other)
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
								bool flag7 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Time, other.Time);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsPlaying != other.IsPlaying;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0003F7EC File Offset: 0x0003D9EC
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
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Time);
			}
			bool hasIsPlaying = this.HasIsPlaying;
			if (hasIsPlaying)
			{
				num ^= this.IsPlaying.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0003F8B4 File Offset: 0x0003DAB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0003F8CC File Offset: 0x0003DACC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0003F8D8 File Offset: 0x0003DAD8
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
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.Time);
			}
			bool hasIsPlaying = this.HasIsPlaying;
			if (hasIsPlaying)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsPlaying);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0003F9B0 File Offset: 0x0003DBB0
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
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 5;
			}
			bool hasIsPlaying = this.HasIsPlaying;
			if (hasIsPlaying)
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

		// Token: 0x0600115D RID: 4445 RVA: 0x0003FA60 File Offset: 0x0003DC60
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardEditorInstanceTimeChanged other)
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
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				bool hasIsPlaying = other.HasIsPlaying;
				if (hasIsPlaying)
				{
					this.IsPlaying = other.IsPlaying;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0003FB14 File Offset: 0x0003DD14
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0003FB20 File Offset: 0x0003DD20
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
							goto IL_0032;
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
					if (num3 != 37U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.IsPlaying = input.ReadBool();
					}
					else
					{
						this.Time = input.ReadFloat();
					}
				}
				else
				{
					this.InstanceIndex = input.ReadInt32();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040006E8 RID: 1768
		private static readonly MessageParser<StoryboardEditorInstanceTimeChanged> _parser = new MessageParser<StoryboardEditorInstanceTimeChanged>(() => new StoryboardEditorInstanceTimeChanged());

		// Token: 0x040006E9 RID: 1769
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006EA RID: 1770
		private int _hasBits0;

		// Token: 0x040006EB RID: 1771
		public const int EditorIdFieldNumber = 1;

		// Token: 0x040006EC RID: 1772
		private static readonly int EditorIdDefaultValue = 0;

		// Token: 0x040006ED RID: 1773
		private int editorId_;

		// Token: 0x040006EE RID: 1774
		public const int ListIdFieldNumber = 2;

		// Token: 0x040006EF RID: 1775
		private static readonly int ListIdDefaultValue = 0;

		// Token: 0x040006F0 RID: 1776
		private int listId_;

		// Token: 0x040006F1 RID: 1777
		public const int InstanceIndexFieldNumber = 3;

		// Token: 0x040006F2 RID: 1778
		private static readonly int InstanceIndexDefaultValue = 0;

		// Token: 0x040006F3 RID: 1779
		private int instanceIndex_;

		// Token: 0x040006F4 RID: 1780
		public const int TimeFieldNumber = 4;

		// Token: 0x040006F5 RID: 1781
		private static readonly float TimeDefaultValue = 0f;

		// Token: 0x040006F6 RID: 1782
		private float time_;

		// Token: 0x040006F7 RID: 1783
		public const int IsPlayingFieldNumber = 5;

		// Token: 0x040006F8 RID: 1784
		private static readonly bool IsPlayingDefaultValue = false;

		// Token: 0x040006F9 RID: 1785
		private bool isPlaying_;
	}
}

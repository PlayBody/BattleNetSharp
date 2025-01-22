using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B6 RID: 182
	public sealed class StoryboardEditorInstanceActionRequest : IMessage<StoryboardEditorInstanceActionRequest>, IMessage, IEquatable<StoryboardEditorInstanceActionRequest>, IDeepCloneable<StoryboardEditorInstanceActionRequest>, IBufferMessage
	{
		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardEditorInstanceActionRequest> Parser
		{
			get
			{
				return StoryboardEditorInstanceActionRequest._parser;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0003E408 File Offset: 0x0003C608
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[159];
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0003E430 File Offset: 0x0003C630
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardEditorInstanceActionRequest.Descriptor;
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0003E447 File Offset: 0x0003C647
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceActionRequest()
		{
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0003E454 File Offset: 0x0003C654
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceActionRequest(StoryboardEditorInstanceActionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.editorId_ = other.editorId_;
			this.listId_ = other.listId_;
			this.instanceIndex_ = other.instanceIndex_;
			this.requestType_ = other.requestType_;
			this.time_ = other.time_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceActionRequest Clone()
		{
			return new StoryboardEditorInstanceActionRequest(this);
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x0003E50D File Offset: 0x0003C70D
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
					editorIdDefaultValue = StoryboardEditorInstanceActionRequest.EditorIdDefaultValue;
				}
				return editorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.editorId_ = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0003E528 File Offset: 0x0003C728
		[DebuggerNonUserCode]
		public bool HasEditorId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0003E545 File Offset: 0x0003C745
		[DebuggerNonUserCode]
		public void ClearEditorId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0003E558 File Offset: 0x0003C758
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x0003E589 File Offset: 0x0003C789
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
					listIdDefaultValue = StoryboardEditorInstanceActionRequest.ListIdDefaultValue;
				}
				return listIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.listId_ = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		[DebuggerNonUserCode]
		public bool HasListId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0003E5C1 File Offset: 0x0003C7C1
		[DebuggerNonUserCode]
		public void ClearListId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0003E5D4 File Offset: 0x0003C7D4
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x0003E605 File Offset: 0x0003C805
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
					instanceIndexDefaultValue = StoryboardEditorInstanceActionRequest.InstanceIndexDefaultValue;
				}
				return instanceIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.instanceIndex_ = value;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0003E620 File Offset: 0x0003C820
		[DebuggerNonUserCode]
		public bool HasInstanceIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0003E63D File Offset: 0x0003C83D
		[DebuggerNonUserCode]
		public void ClearInstanceIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0003E650 File Offset: 0x0003C850
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0003E681 File Offset: 0x0003C881
		[DebuggerNonUserCode]
		public StoryboardEditorInstanceActionRequest.Types.RequestType RequestType
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				StoryboardEditorInstanceActionRequest.Types.RequestType requestTypeDefaultValue;
				if (flag)
				{
					requestTypeDefaultValue = this.requestType_;
				}
				else
				{
					requestTypeDefaultValue = StoryboardEditorInstanceActionRequest.RequestTypeDefaultValue;
				}
				return requestTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.requestType_ = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0003E69C File Offset: 0x0003C89C
		[DebuggerNonUserCode]
		public bool HasRequestType
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0003E6B9 File Offset: 0x0003C8B9
		[DebuggerNonUserCode]
		public void ClearRequestType()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0003E6CC File Offset: 0x0003C8CC
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x0003E6FE File Offset: 0x0003C8FE
		[DebuggerNonUserCode]
		public float Time
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				float timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = StoryboardEditorInstanceActionRequest.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.time_ = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0003E718 File Offset: 0x0003C918
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0003E736 File Offset: 0x0003C936
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0003E748 File Offset: 0x0003C948
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardEditorInstanceActionRequest);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0003E768 File Offset: 0x0003C968
		[DebuggerNonUserCode]
		public bool Equals(StoryboardEditorInstanceActionRequest other)
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
								bool flag7 = this.RequestType != other.RequestType;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Time, other.Time);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0003E83C File Offset: 0x0003CA3C
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
			bool hasRequestType = this.HasRequestType;
			if (hasRequestType)
			{
				num ^= this.RequestType.GetHashCode();
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Time);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0003E908 File Offset: 0x0003CB08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0003E920 File Offset: 0x0003CB20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0003E92C File Offset: 0x0003CB2C
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
			bool hasRequestType = this.HasRequestType;
			if (hasRequestType)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.RequestType);
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Time);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0003EA04 File Offset: 0x0003CC04
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
			bool hasRequestType = this.HasRequestType;
			if (hasRequestType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RequestType);
			}
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0003EAC0 File Offset: 0x0003CCC0
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardEditorInstanceActionRequest other)
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
				bool hasRequestType = other.HasRequestType;
				if (hasRequestType)
				{
					this.RequestType = other.RequestType;
				}
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0003EB74 File Offset: 0x0003CD74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0003EB80 File Offset: 0x0003CD80
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
					if (num3 != 32U)
					{
						if (num3 != 45U)
						{
							goto IL_0032;
						}
						this.Time = input.ReadFloat();
					}
					else
					{
						this.RequestType = (StoryboardEditorInstanceActionRequest.Types.RequestType)input.ReadEnum();
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

		// Token: 0x040006C7 RID: 1735
		private static readonly MessageParser<StoryboardEditorInstanceActionRequest> _parser = new MessageParser<StoryboardEditorInstanceActionRequest>(() => new StoryboardEditorInstanceActionRequest());

		// Token: 0x040006C8 RID: 1736
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006C9 RID: 1737
		private int _hasBits0;

		// Token: 0x040006CA RID: 1738
		public const int EditorIdFieldNumber = 1;

		// Token: 0x040006CB RID: 1739
		private static readonly int EditorIdDefaultValue = 0;

		// Token: 0x040006CC RID: 1740
		private int editorId_;

		// Token: 0x040006CD RID: 1741
		public const int ListIdFieldNumber = 2;

		// Token: 0x040006CE RID: 1742
		private static readonly int ListIdDefaultValue = 0;

		// Token: 0x040006CF RID: 1743
		private int listId_;

		// Token: 0x040006D0 RID: 1744
		public const int InstanceIndexFieldNumber = 3;

		// Token: 0x040006D1 RID: 1745
		private static readonly int InstanceIndexDefaultValue = 0;

		// Token: 0x040006D2 RID: 1746
		private int instanceIndex_;

		// Token: 0x040006D3 RID: 1747
		public const int RequestTypeFieldNumber = 4;

		// Token: 0x040006D4 RID: 1748
		private static readonly StoryboardEditorInstanceActionRequest.Types.RequestType RequestTypeDefaultValue = StoryboardEditorInstanceActionRequest.Types.RequestType.Play;

		// Token: 0x040006D5 RID: 1749
		private StoryboardEditorInstanceActionRequest.Types.RequestType requestType_;

		// Token: 0x040006D6 RID: 1750
		public const int TimeFieldNumber = 5;

		// Token: 0x040006D7 RID: 1751
		private static readonly float TimeDefaultValue = 0f;

		// Token: 0x040006D8 RID: 1752
		private float time_;

		// Token: 0x02000BCC RID: 3020
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001460 RID: 5216
			public enum RequestType
			{
				// Token: 0x0400A278 RID: 41592
				[OriginalName("PLAY")]
				Play = 1,
				// Token: 0x0400A279 RID: 41593
				[OriginalName("STOP")]
				Stop,
				// Token: 0x0400A27A RID: 41594
				[OriginalName("JUMP")]
				Jump
			}
		}
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000494 RID: 1172
	public sealed class ClubMemberRangeSet : IMessage<ClubMemberRangeSet>, IMessage, IEquatable<ClubMemberRangeSet>, IDeepCloneable<ClubMemberRangeSet>, IBufferMessage
	{
		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x001BD3D4 File Offset: 0x001BB5D4
		[DebuggerNonUserCode]
		public static MessageParser<ClubMemberRangeSet> Parser
		{
			get
			{
				return ClubMemberRangeSet._parser;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x06007249 RID: 29257 RVA: 0x001BD3EC File Offset: 0x001BB5EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600724A RID: 29258 RVA: 0x001BD410 File Offset: 0x001BB610
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMemberRangeSet.Descriptor;
			}
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x001BD427 File Offset: 0x001BB627
		[DebuggerNonUserCode]
		public ClubMemberRangeSet()
		{
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x001BD434 File Offset: 0x001BB634
		[DebuggerNonUserCode]
		public ClubMemberRangeSet(ClubMemberRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this.voice_ = ((other.voice_ != null) ? other.voice_.Clone() : null);
			this.streamSubscriptions_ = ((other.streamSubscriptions_ != null) ? other.streamSubscriptions_.Clone() : null);
			this.noteRange_ = ((other.noteRange_ != null) ? other.noteRange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x001BD4CC File Offset: 0x001BB6CC
		[DebuggerNonUserCode]
		public ClubMemberRangeSet Clone()
		{
			return new ClubMemberRangeSet(this);
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x001BD4E4 File Offset: 0x001BB6E4
		// (set) Token: 0x0600724F RID: 29263 RVA: 0x001BD4FC File Offset: 0x001BB6FC
		[DebuggerNonUserCode]
		public UnsignedIntRange Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x001BD508 File Offset: 0x001BB708
		// (set) Token: 0x06007251 RID: 29265 RVA: 0x001BD520 File Offset: 0x001BB720
		[DebuggerNonUserCode]
		public UnsignedIntRange Voice
		{
			get
			{
				return this.voice_;
			}
			set
			{
				this.voice_ = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x06007252 RID: 29266 RVA: 0x001BD52C File Offset: 0x001BB72C
		// (set) Token: 0x06007253 RID: 29267 RVA: 0x001BD544 File Offset: 0x001BB744
		[DebuggerNonUserCode]
		public UnsignedIntRange StreamSubscriptions
		{
			get
			{
				return this.streamSubscriptions_;
			}
			set
			{
				this.streamSubscriptions_ = value;
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x06007254 RID: 29268 RVA: 0x001BD550 File Offset: 0x001BB750
		// (set) Token: 0x06007255 RID: 29269 RVA: 0x001BD568 File Offset: 0x001BB768
		[DebuggerNonUserCode]
		public UnsignedIntRange NoteRange
		{
			get
			{
				return this.noteRange_;
			}
			set
			{
				this.noteRange_ = value;
			}
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x001BD574 File Offset: 0x001BB774
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMemberRangeSet);
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x001BD594 File Offset: 0x001BB794
		[DebuggerNonUserCode]
		public bool Equals(ClubMemberRangeSet other)
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
					bool flag4 = !object.Equals(this.Count, other.Count);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Voice, other.Voice);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.StreamSubscriptions, other.StreamSubscriptions);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.NoteRange, other.NoteRange);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x001BD650 File Offset: 0x001BB850
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.count_ != null;
			if (flag)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num ^= this.Voice.GetHashCode();
			}
			bool flag3 = this.streamSubscriptions_ != null;
			if (flag3)
			{
				num ^= this.StreamSubscriptions.GetHashCode();
			}
			bool flag4 = this.noteRange_ != null;
			if (flag4)
			{
				num ^= this.NoteRange.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007259 RID: 29273 RVA: 0x001BD6F4 File Offset: 0x001BB8F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600725A RID: 29274 RVA: 0x001BD70C File Offset: 0x001BB90C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x001BD718 File Offset: 0x001BB918
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.count_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Count);
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Voice);
			}
			bool flag3 = this.streamSubscriptions_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.StreamSubscriptions);
			}
			bool flag4 = this.noteRange_ != null;
			if (flag4)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.NoteRange);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x001BD7D8 File Offset: 0x001BB9D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.count_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Count);
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Voice);
			}
			bool flag3 = this.streamSubscriptions_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StreamSubscriptions);
			}
			bool flag4 = this.noteRange_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NoteRange);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x001BD88C File Offset: 0x001BBA8C
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMemberRangeSet other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.count_ != null;
				if (flag2)
				{
					bool flag3 = this.count_ == null;
					if (flag3)
					{
						this.Count = new UnsignedIntRange();
					}
					this.Count.MergeFrom(other.Count);
				}
				bool flag4 = other.voice_ != null;
				if (flag4)
				{
					bool flag5 = this.voice_ == null;
					if (flag5)
					{
						this.Voice = new UnsignedIntRange();
					}
					this.Voice.MergeFrom(other.Voice);
				}
				bool flag6 = other.streamSubscriptions_ != null;
				if (flag6)
				{
					bool flag7 = this.streamSubscriptions_ == null;
					if (flag7)
					{
						this.StreamSubscriptions = new UnsignedIntRange();
					}
					this.StreamSubscriptions.MergeFrom(other.StreamSubscriptions);
				}
				bool flag8 = other.noteRange_ != null;
				if (flag8)
				{
					bool flag9 = this.noteRange_ == null;
					if (flag9)
					{
						this.NoteRange = new UnsignedIntRange();
					}
					this.NoteRange.MergeFrom(other.NoteRange);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x001BD9B9 File Offset: 0x001BBBB9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x001BD9C4 File Offset: 0x001BBBC4
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
						if (num3 != 26U)
						{
							goto IL_002F;
						}
						bool flag = this.voice_ == null;
						if (flag)
						{
							this.Voice = new UnsignedIntRange();
						}
						input.ReadMessage(this.Voice);
					}
					else
					{
						bool flag2 = this.count_ == null;
						if (flag2)
						{
							this.Count = new UnsignedIntRange();
						}
						input.ReadMessage(this.Count);
					}
				}
				else if (num3 != 42U)
				{
					if (num3 != 58U)
					{
						goto IL_002F;
					}
					bool flag3 = this.noteRange_ == null;
					if (flag3)
					{
						this.NoteRange = new UnsignedIntRange();
					}
					input.ReadMessage(this.NoteRange);
				}
				else
				{
					bool flag4 = this.streamSubscriptions_ == null;
					if (flag4)
					{
						this.StreamSubscriptions = new UnsignedIntRange();
					}
					input.ReadMessage(this.StreamSubscriptions);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003465 RID: 13413
		private static readonly MessageParser<ClubMemberRangeSet> _parser = new MessageParser<ClubMemberRangeSet>(() => new ClubMemberRangeSet());

		// Token: 0x04003466 RID: 13414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003467 RID: 13415
		public const int CountFieldNumber = 1;

		// Token: 0x04003468 RID: 13416
		private UnsignedIntRange count_;

		// Token: 0x04003469 RID: 13417
		public const int VoiceFieldNumber = 3;

		// Token: 0x0400346A RID: 13418
		private UnsignedIntRange voice_;

		// Token: 0x0400346B RID: 13419
		public const int StreamSubscriptionsFieldNumber = 5;

		// Token: 0x0400346C RID: 13420
		private UnsignedIntRange streamSubscriptions_;

		// Token: 0x0400346D RID: 13421
		public const int NoteRangeFieldNumber = 7;

		// Token: 0x0400346E RID: 13422
		private UnsignedIntRange noteRange_;
	}
}

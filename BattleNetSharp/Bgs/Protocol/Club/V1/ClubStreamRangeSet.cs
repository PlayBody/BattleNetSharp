using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000495 RID: 1173
	public sealed class ClubStreamRangeSet : IMessage<ClubStreamRangeSet>, IMessage, IEquatable<ClubStreamRangeSet>, IDeepCloneable<ClubStreamRangeSet>, IBufferMessage
	{
		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06007261 RID: 29281 RVA: 0x001BDB00 File Offset: 0x001BBD00
		[DebuggerNonUserCode]
		public static MessageParser<ClubStreamRangeSet> Parser
		{
			get
			{
				return ClubStreamRangeSet._parser;
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x001BDB18 File Offset: 0x001BBD18
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x001BDB3C File Offset: 0x001BBD3C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubStreamRangeSet.Descriptor;
			}
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x001BDB53 File Offset: 0x001BBD53
		[DebuggerNonUserCode]
		public ClubStreamRangeSet()
		{
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x001BDB60 File Offset: 0x001BBD60
		[DebuggerNonUserCode]
		public ClubStreamRangeSet(ClubStreamRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this.nameRange_ = ((other.nameRange_ != null) ? other.nameRange_.Clone() : null);
			this.subjectRange_ = ((other.subjectRange_ != null) ? other.subjectRange_.Clone() : null);
			this.messageRange_ = ((other.messageRange_ != null) ? other.messageRange_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x001BDBF8 File Offset: 0x001BBDF8
		[DebuggerNonUserCode]
		public ClubStreamRangeSet Clone()
		{
			return new ClubStreamRangeSet(this);
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x001BDC10 File Offset: 0x001BBE10
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x001BDC28 File Offset: 0x001BBE28
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

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x001BDC34 File Offset: 0x001BBE34
		// (set) Token: 0x0600726A RID: 29290 RVA: 0x001BDC4C File Offset: 0x001BBE4C
		[DebuggerNonUserCode]
		public UnsignedIntRange NameRange
		{
			get
			{
				return this.nameRange_;
			}
			set
			{
				this.nameRange_ = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x001BDC58 File Offset: 0x001BBE58
		// (set) Token: 0x0600726C RID: 29292 RVA: 0x001BDC70 File Offset: 0x001BBE70
		[DebuggerNonUserCode]
		public UnsignedIntRange SubjectRange
		{
			get
			{
				return this.subjectRange_;
			}
			set
			{
				this.subjectRange_ = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x001BDC7C File Offset: 0x001BBE7C
		// (set) Token: 0x0600726E RID: 29294 RVA: 0x001BDC94 File Offset: 0x001BBE94
		[DebuggerNonUserCode]
		public UnsignedIntRange MessageRange
		{
			get
			{
				return this.messageRange_;
			}
			set
			{
				this.messageRange_ = value;
			}
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x001BDCA0 File Offset: 0x001BBEA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubStreamRangeSet);
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x001BDCC0 File Offset: 0x001BBEC0
		[DebuggerNonUserCode]
		public bool Equals(ClubStreamRangeSet other)
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
						bool flag5 = !object.Equals(this.NameRange, other.NameRange);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SubjectRange, other.SubjectRange);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.MessageRange, other.MessageRange);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x001BDD7C File Offset: 0x001BBF7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.count_ != null;
			if (flag)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag2 = this.nameRange_ != null;
			if (flag2)
			{
				num ^= this.NameRange.GetHashCode();
			}
			bool flag3 = this.subjectRange_ != null;
			if (flag3)
			{
				num ^= this.SubjectRange.GetHashCode();
			}
			bool flag4 = this.messageRange_ != null;
			if (flag4)
			{
				num ^= this.MessageRange.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x001BDE20 File Offset: 0x001BC020
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x001BDE38 File Offset: 0x001BC038
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x001BDE44 File Offset: 0x001BC044
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.count_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Count);
			}
			bool flag2 = this.nameRange_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NameRange);
			}
			bool flag3 = this.subjectRange_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SubjectRange);
			}
			bool flag4 = this.messageRange_ != null;
			if (flag4)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MessageRange);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x001BDF04 File Offset: 0x001BC104
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.count_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Count);
			}
			bool flag2 = this.nameRange_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NameRange);
			}
			bool flag3 = this.subjectRange_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubjectRange);
			}
			bool flag4 = this.messageRange_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MessageRange);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x001BDFB8 File Offset: 0x001BC1B8
		[DebuggerNonUserCode]
		public void MergeFrom(ClubStreamRangeSet other)
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
				bool flag4 = other.nameRange_ != null;
				if (flag4)
				{
					bool flag5 = this.nameRange_ == null;
					if (flag5)
					{
						this.NameRange = new UnsignedIntRange();
					}
					this.NameRange.MergeFrom(other.NameRange);
				}
				bool flag6 = other.subjectRange_ != null;
				if (flag6)
				{
					bool flag7 = this.subjectRange_ == null;
					if (flag7)
					{
						this.SubjectRange = new UnsignedIntRange();
					}
					this.SubjectRange.MergeFrom(other.SubjectRange);
				}
				bool flag8 = other.messageRange_ != null;
				if (flag8)
				{
					bool flag9 = this.messageRange_ == null;
					if (flag9)
					{
						this.MessageRange = new UnsignedIntRange();
					}
					this.MessageRange.MergeFrom(other.MessageRange);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x001BE0E5 File Offset: 0x001BC2E5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x001BE0F0 File Offset: 0x001BC2F0
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
						bool flag = this.nameRange_ == null;
						if (flag)
						{
							this.NameRange = new UnsignedIntRange();
						}
						input.ReadMessage(this.NameRange);
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
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						goto IL_002F;
					}
					bool flag3 = this.messageRange_ == null;
					if (flag3)
					{
						this.MessageRange = new UnsignedIntRange();
					}
					input.ReadMessage(this.MessageRange);
				}
				else
				{
					bool flag4 = this.subjectRange_ == null;
					if (flag4)
					{
						this.SubjectRange = new UnsignedIntRange();
					}
					input.ReadMessage(this.SubjectRange);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400346F RID: 13423
		private static readonly MessageParser<ClubStreamRangeSet> _parser = new MessageParser<ClubStreamRangeSet>(() => new ClubStreamRangeSet());

		// Token: 0x04003470 RID: 13424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003471 RID: 13425
		public const int CountFieldNumber = 1;

		// Token: 0x04003472 RID: 13426
		private UnsignedIntRange count_;

		// Token: 0x04003473 RID: 13427
		public const int NameRangeFieldNumber = 3;

		// Token: 0x04003474 RID: 13428
		private UnsignedIntRange nameRange_;

		// Token: 0x04003475 RID: 13429
		public const int SubjectRangeFieldNumber = 4;

		// Token: 0x04003476 RID: 13430
		private UnsignedIntRange subjectRange_;

		// Token: 0x04003477 RID: 13431
		public const int MessageRangeFieldNumber = 5;

		// Token: 0x04003478 RID: 13432
		private UnsignedIntRange messageRange_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000497 RID: 1175
	public sealed class ClubSuggestionRangeSet : IMessage<ClubSuggestionRangeSet>, IMessage, IEquatable<ClubSuggestionRangeSet>, IDeepCloneable<ClubSuggestionRangeSet>, IBufferMessage
	{
		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x001BE594 File Offset: 0x001BC794
		[DebuggerNonUserCode]
		public static MessageParser<ClubSuggestionRangeSet> Parser
		{
			get
			{
				return ClubSuggestionRangeSet._parser;
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x001BE5AC File Offset: 0x001BC7AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRangeSetReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x001BE5D0 File Offset: 0x001BC7D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSuggestionRangeSet.Descriptor;
			}
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x001BE5E7 File Offset: 0x001BC7E7
		[DebuggerNonUserCode]
		public ClubSuggestionRangeSet()
		{
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x001BE5F1 File Offset: 0x001BC7F1
		[DebuggerNonUserCode]
		public ClubSuggestionRangeSet(ClubSuggestionRangeSet other)
			: this()
		{
			this.count_ = ((other.count_ != null) ? other.count_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x001BE628 File Offset: 0x001BC828
		[DebuggerNonUserCode]
		public ClubSuggestionRangeSet Clone()
		{
			return new ClubSuggestionRangeSet(this);
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x001BE640 File Offset: 0x001BC840
		// (set) Token: 0x06007294 RID: 29332 RVA: 0x001BE658 File Offset: 0x001BC858
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

		// Token: 0x06007295 RID: 29333 RVA: 0x001BE664 File Offset: 0x001BC864
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSuggestionRangeSet);
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x001BE684 File Offset: 0x001BC884
		[DebuggerNonUserCode]
		public bool Equals(ClubSuggestionRangeSet other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x001BE6E0 File Offset: 0x001BC8E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.count_ != null;
			if (flag)
			{
				num ^= this.Count.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x001BE730 File Offset: 0x001BC930
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x001BE748 File Offset: 0x001BC948
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x001BE754 File Offset: 0x001BC954
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.count_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Count);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x001BE7A4 File Offset: 0x001BC9A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.count_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Count);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x001BE7F8 File Offset: 0x001BC9F8
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSuggestionRangeSet other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x001BE864 File Offset: 0x001BCA64
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x001BE870 File Offset: 0x001BCA70
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
					bool flag = this.count_ == null;
					if (flag)
					{
						this.Count = new UnsignedIntRange();
					}
					input.ReadMessage(this.Count);
				}
			}
		}

		// Token: 0x0400347D RID: 13437
		private static readonly MessageParser<ClubSuggestionRangeSet> _parser = new MessageParser<ClubSuggestionRangeSet>(() => new ClubSuggestionRangeSet());

		// Token: 0x0400347E RID: 13438
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400347F RID: 13439
		public const int CountFieldNumber = 1;

		// Token: 0x04003480 RID: 13440
		private UnsignedIntRange count_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E3 RID: 227
	public sealed class ActorsForAnimTree : IMessage<ActorsForAnimTree>, IMessage, IEquatable<ActorsForAnimTree>, IDeepCloneable<ActorsForAnimTree>, IBufferMessage
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000502E8 File Offset: 0x0004E4E8
		[DebuggerNonUserCode]
		public static MessageParser<ActorsForAnimTree> Parser
		{
			get
			{
				return ActorsForAnimTree._parser;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00050300 File Offset: 0x0004E500
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[204];
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00050328 File Offset: 0x0004E528
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorsForAnimTree.Descriptor;
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0005033F File Offset: 0x0004E53F
		[DebuggerNonUserCode]
		public ActorsForAnimTree()
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00050354 File Offset: 0x0004E554
		[DebuggerNonUserCode]
		public ActorsForAnimTree(ActorsForAnimTree other)
			: this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00050380 File Offset: 0x0004E580
		[DebuggerNonUserCode]
		public ActorsForAnimTree Clone()
		{
			return new ActorsForAnimTree(this);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x00050398 File Offset: 0x0004E598
		[DebuggerNonUserCode]
		public RepeatedField<ActorForAnimTreeData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000503B0 File Offset: 0x0004E5B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorsForAnimTree);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000503D0 File Offset: 0x0004E5D0
		[DebuggerNonUserCode]
		public bool Equals(ActorsForAnimTree other)
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
					bool flag4 = !this.data_.Equals(other.data_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0005042C File Offset: 0x0004E62C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0005046C File Offset: 0x0004E66C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00050484 File Offset: 0x0004E684
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00050490 File Offset: 0x0004E690
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ActorsForAnimTree._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000504CC File Offset: 0x0004E6CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(ActorsForAnimTree._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00050514 File Offset: 0x0004E714
		[DebuggerNonUserCode]
		public void MergeFrom(ActorsForAnimTree other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.data_.Add(other.data_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00050556 File Offset: 0x0004E756
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00050564 File Offset: 0x0004E764
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
					this.data_.AddEntriesFrom(ref input, ActorsForAnimTree._repeated_data_codec);
				}
			}
		}

		// Token: 0x040008F9 RID: 2297
		private static readonly MessageParser<ActorsForAnimTree> _parser = new MessageParser<ActorsForAnimTree>(() => new ActorsForAnimTree());

		// Token: 0x040008FA RID: 2298
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008FB RID: 2299
		public const int DataFieldNumber = 1;

		// Token: 0x040008FC RID: 2300
		private static readonly FieldCodec<ActorForAnimTreeData> _repeated_data_codec = FieldCodec.ForMessage<ActorForAnimTreeData>(10U, ActorForAnimTreeData.Parser);

		// Token: 0x040008FD RID: 2301
		private readonly RepeatedField<ActorForAnimTreeData> data_ = new RepeatedField<ActorForAnimTreeData>();
	}
}

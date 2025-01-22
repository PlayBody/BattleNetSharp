using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000471 RID: 1137
	public sealed class ClubPosition : IMessage<ClubPosition>, IMessage, IEquatable<ClubPosition>, IDeepCloneable<ClubPosition>, IBufferMessage
	{
		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x06006F29 RID: 28457 RVA: 0x001B0844 File Offset: 0x001AEA44
		[DebuggerNonUserCode]
		public static MessageParser<ClubPosition> Parser
		{
			get
			{
				return ClubPosition._parser;
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x001B085C File Offset: 0x001AEA5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06006F2B RID: 28459 RVA: 0x001B0880 File Offset: 0x001AEA80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubPosition.Descriptor;
			}
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x001B0897 File Offset: 0x001AEA97
		[DebuggerNonUserCode]
		public ClubPosition()
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x001B08AC File Offset: 0x001AEAAC
		[DebuggerNonUserCode]
		public ClubPosition(ClubPosition other)
			: this()
		{
			this.clubId_ = other.clubId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x001B08D8 File Offset: 0x001AEAD8
		[DebuggerNonUserCode]
		public ClubPosition Clone()
		{
			return new ClubPosition(this);
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x001B08F0 File Offset: 0x001AEAF0
		[DebuggerNonUserCode]
		public RepeatedField<ulong> ClubId
		{
			get
			{
				return this.clubId_;
			}
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x001B0908 File Offset: 0x001AEB08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubPosition);
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x001B0928 File Offset: 0x001AEB28
		[DebuggerNonUserCode]
		public bool Equals(ClubPosition other)
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
					bool flag4 = !this.clubId_.Equals(other.clubId_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x001B0984 File Offset: 0x001AEB84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.clubId_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x001B09C4 File Offset: 0x001AEBC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x001B09DC File Offset: 0x001AEBDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x001B09E8 File Offset: 0x001AEBE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.clubId_.WriteTo(ref output, ClubPosition._repeated_clubId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x001B0A24 File Offset: 0x001AEC24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.clubId_.CalculateSize(ClubPosition._repeated_clubId_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x001B0A6C File Offset: 0x001AEC6C
		[DebuggerNonUserCode]
		public void MergeFrom(ClubPosition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.clubId_.Add(other.clubId_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x001B0AAE File Offset: 0x001AECAE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x001B0ABC File Offset: 0x001AECBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.clubId_.AddEntriesFrom(ref input, ClubPosition._repeated_clubId_codec);
				}
			}
		}

		// Token: 0x0400330D RID: 13069
		private static readonly MessageParser<ClubPosition> _parser = new MessageParser<ClubPosition>(() => new ClubPosition());

		// Token: 0x0400330E RID: 13070
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400330F RID: 13071
		public const int ClubIdFieldNumber = 1;

		// Token: 0x04003310 RID: 13072
		private static readonly FieldCodec<ulong> _repeated_clubId_codec = FieldCodec.ForUInt64(10U);

		// Token: 0x04003311 RID: 13073
		private readonly RepeatedField<ulong> clubId_ = new RepeatedField<ulong>();
	}
}

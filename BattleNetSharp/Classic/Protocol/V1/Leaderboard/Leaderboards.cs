using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000763 RID: 1891
	public sealed class Leaderboards : IMessage<Leaderboards>, IMessage, IEquatable<Leaderboards>, IDeepCloneable<Leaderboards>, IBufferMessage
	{
		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600ADDA RID: 44506 RVA: 0x002A5624 File Offset: 0x002A3824
		[DebuggerNonUserCode]
		public static MessageParser<Leaderboards> Parser
		{
			get
			{
				return Leaderboards._parser;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600ADDB RID: 44507 RVA: 0x002A563C File Offset: 0x002A383C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600ADDC RID: 44508 RVA: 0x002A5660 File Offset: 0x002A3860
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Leaderboards.Descriptor;
			}
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x002A5677 File Offset: 0x002A3877
		[DebuggerNonUserCode]
		public Leaderboards()
		{
		}

		// Token: 0x0600ADDE RID: 44510 RVA: 0x002A568C File Offset: 0x002A388C
		[DebuggerNonUserCode]
		public Leaderboards(Leaderboards other)
			: this()
		{
			this.leaderboards_ = other.leaderboards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x002A56B8 File Offset: 0x002A38B8
		[DebuggerNonUserCode]
		public Leaderboards Clone()
		{
			return new Leaderboards(this);
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600ADE0 RID: 44512 RVA: 0x002A56D0 File Offset: 0x002A38D0
		[DebuggerNonUserCode]
		public RepeatedField<LeaderboardId> Leaderboards_
		{
			get
			{
				return this.leaderboards_;
			}
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x002A56E8 File Offset: 0x002A38E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Leaderboards);
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x002A5708 File Offset: 0x002A3908
		[DebuggerNonUserCode]
		public bool Equals(Leaderboards other)
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
					bool flag4 = !this.leaderboards_.Equals(other.leaderboards_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x002A5764 File Offset: 0x002A3964
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.leaderboards_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x002A57A4 File Offset: 0x002A39A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x002A57BC File Offset: 0x002A39BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x002A57C8 File Offset: 0x002A39C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.leaderboards_.WriteTo(ref output, Leaderboards._repeated_leaderboards_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x002A5804 File Offset: 0x002A3A04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.leaderboards_.CalculateSize(Leaderboards._repeated_leaderboards_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x002A584C File Offset: 0x002A3A4C
		[DebuggerNonUserCode]
		public void MergeFrom(Leaderboards other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.leaderboards_.Add(other.leaderboards_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x002A588E File Offset: 0x002A3A8E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x002A589C File Offset: 0x002A3A9C
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
					this.leaderboards_.AddEntriesFrom(ref input, Leaderboards._repeated_leaderboards_codec);
				}
			}
		}

		// Token: 0x04004E5A RID: 20058
		private static readonly MessageParser<Leaderboards> _parser = new MessageParser<Leaderboards>(() => new Leaderboards());

		// Token: 0x04004E5B RID: 20059
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E5C RID: 20060
		public const int Leaderboards_FieldNumber = 1;

		// Token: 0x04004E5D RID: 20061
		private static readonly FieldCodec<LeaderboardId> _repeated_leaderboards_codec = FieldCodec.ForMessage<LeaderboardId>(10U, LeaderboardId.Parser);

		// Token: 0x04004E5E RID: 20062
		private readonly RepeatedField<LeaderboardId> leaderboards_ = new RepeatedField<LeaderboardId>();
	}
}

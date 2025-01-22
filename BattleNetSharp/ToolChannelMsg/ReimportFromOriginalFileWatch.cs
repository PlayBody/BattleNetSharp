using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004E RID: 78
	public sealed class ReimportFromOriginalFileWatch : IMessage<ReimportFromOriginalFileWatch>, IMessage, IEquatable<ReimportFromOriginalFileWatch>, IDeepCloneable<ReimportFromOriginalFileWatch>, IBufferMessage
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001D40C File Offset: 0x0001B60C
		[DebuggerNonUserCode]
		public static MessageParser<ReimportFromOriginalFileWatch> Parser
		{
			get
			{
				return ReimportFromOriginalFileWatch._parser;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001D424 File Offset: 0x0001B624
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[55];
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001D448 File Offset: 0x0001B648
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReimportFromOriginalFileWatch.Descriptor;
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001D45F File Offset: 0x0001B65F
		[DebuggerNonUserCode]
		public ReimportFromOriginalFileWatch()
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001D474 File Offset: 0x0001B674
		[DebuggerNonUserCode]
		public ReimportFromOriginalFileWatch(ReimportFromOriginalFileWatch other)
			: this()
		{
			this.reimports_ = other.reimports_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001D4A0 File Offset: 0x0001B6A0
		[DebuggerNonUserCode]
		public ReimportFromOriginalFileWatch Clone()
		{
			return new ReimportFromOriginalFileWatch(this);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001D4B8 File Offset: 0x0001B6B8
		[DebuggerNonUserCode]
		public RepeatedField<OriginalFileWatch> Reimports
		{
			get
			{
				return this.reimports_;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReimportFromOriginalFileWatch);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		[DebuggerNonUserCode]
		public bool Equals(ReimportFromOriginalFileWatch other)
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
					bool flag4 = !this.reimports_.Equals(other.reimports_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001D54C File Offset: 0x0001B74C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.reimports_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001D58C File Offset: 0x0001B78C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.reimports_.WriteTo(ref output, ReimportFromOriginalFileWatch._repeated_reimports_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001D5EC File Offset: 0x0001B7EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.reimports_.CalculateSize(ReimportFromOriginalFileWatch._repeated_reimports_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001D634 File Offset: 0x0001B834
		[DebuggerNonUserCode]
		public void MergeFrom(ReimportFromOriginalFileWatch other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.reimports_.Add(other.reimports_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001D676 File Offset: 0x0001B876
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001D684 File Offset: 0x0001B884
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
					this.reimports_.AddEntriesFrom(ref input, ReimportFromOriginalFileWatch._repeated_reimports_codec);
				}
			}
		}

		// Token: 0x040002CA RID: 714
		private static readonly MessageParser<ReimportFromOriginalFileWatch> _parser = new MessageParser<ReimportFromOriginalFileWatch>(() => new ReimportFromOriginalFileWatch());

		// Token: 0x040002CB RID: 715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002CC RID: 716
		public const int ReimportsFieldNumber = 1;

		// Token: 0x040002CD RID: 717
		private static readonly FieldCodec<OriginalFileWatch> _repeated_reimports_codec = FieldCodec.ForMessage<OriginalFileWatch>(10U, OriginalFileWatch.Parser);

		// Token: 0x040002CE RID: 718
		private readonly RepeatedField<OriginalFileWatch> reimports_ = new RepeatedField<OriginalFileWatch>();
	}
}

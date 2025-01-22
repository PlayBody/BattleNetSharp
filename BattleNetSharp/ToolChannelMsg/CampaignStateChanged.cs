using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003B RID: 59
	public sealed class CampaignStateChanged : IMessage<CampaignStateChanged>, IMessage, IEquatable<CampaignStateChanged>, IDeepCloneable<CampaignStateChanged>, IBufferMessage
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x000165FC File Offset: 0x000147FC
		[DebuggerNonUserCode]
		public static MessageParser<CampaignStateChanged> Parser
		{
			get
			{
				return CampaignStateChanged._parser;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00016614 File Offset: 0x00014814
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[36];
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00016638 File Offset: 0x00014838
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CampaignStateChanged.Descriptor;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001664F File Offset: 0x0001484F
		[DebuggerNonUserCode]
		public CampaignStateChanged()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00016664 File Offset: 0x00014864
		[DebuggerNonUserCode]
		public CampaignStateChanged(CampaignStateChanged other)
			: this()
		{
			this.completedQuests_ = other.completedQuests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00016690 File Offset: 0x00014890
		[DebuggerNonUserCode]
		public CampaignStateChanged Clone()
		{
			return new CampaignStateChanged(this);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000166A8 File Offset: 0x000148A8
		[DebuggerNonUserCode]
		public RepeatedField<int> CompletedQuests
		{
			get
			{
				return this.completedQuests_;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000166C0 File Offset: 0x000148C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CampaignStateChanged);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000166E0 File Offset: 0x000148E0
		[DebuggerNonUserCode]
		public bool Equals(CampaignStateChanged other)
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
					bool flag4 = !this.completedQuests_.Equals(other.completedQuests_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001673C File Offset: 0x0001493C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.completedQuests_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001677C File Offset: 0x0001497C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00016794 File Offset: 0x00014994
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000167A0 File Offset: 0x000149A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.completedQuests_.WriteTo(ref output, CampaignStateChanged._repeated_completedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000167DC File Offset: 0x000149DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.completedQuests_.CalculateSize(CampaignStateChanged._repeated_completedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00016824 File Offset: 0x00014A24
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignStateChanged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.completedQuests_.Add(other.completedQuests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00016866 File Offset: 0x00014A66
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00016874 File Offset: 0x00014A74
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
					this.completedQuests_.AddEntriesFrom(ref input, CampaignStateChanged._repeated_completedQuests_codec);
				}
			}
		}

		// Token: 0x040001F0 RID: 496
		private static readonly MessageParser<CampaignStateChanged> _parser = new MessageParser<CampaignStateChanged>(() => new CampaignStateChanged());

		// Token: 0x040001F1 RID: 497
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001F2 RID: 498
		public const int CompletedQuestsFieldNumber = 1;

		// Token: 0x040001F3 RID: 499
		private static readonly FieldCodec<int> _repeated_completedQuests_codec = FieldCodec.ForInt32(8U);

		// Token: 0x040001F4 RID: 500
		private readonly RepeatedField<int> completedQuests_ = new RepeatedField<int>();
	}
}

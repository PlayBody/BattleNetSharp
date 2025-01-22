using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000039 RID: 57
	public sealed class CampaignSettings : IMessage<CampaignSettings>, IMessage, IEquatable<CampaignSettings>, IDeepCloneable<CampaignSettings>, IBufferMessage
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000156BC File Offset: 0x000138BC
		[DebuggerNonUserCode]
		public static MessageParser<CampaignSettings> Parser
		{
			get
			{
				return CampaignSettings._parser;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000156D4 File Offset: 0x000138D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x000156F8 File Offset: 0x000138F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CampaignSettings.Descriptor;
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001570F File Offset: 0x0001390F
		[DebuggerNonUserCode]
		public CampaignSettings()
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00015724 File Offset: 0x00013924
		[DebuggerNonUserCode]
		public CampaignSettings(CampaignSettings other)
			: this()
		{
			this.completedQuests_ = other.completedQuests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00015750 File Offset: 0x00013950
		[DebuggerNonUserCode]
		public CampaignSettings Clone()
		{
			return new CampaignSettings(this);
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00015768 File Offset: 0x00013968
		[DebuggerNonUserCode]
		public RepeatedField<int> CompletedQuests
		{
			get
			{
				return this.completedQuests_;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00015780 File Offset: 0x00013980
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CampaignSettings);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000157A0 File Offset: 0x000139A0
		[DebuggerNonUserCode]
		public bool Equals(CampaignSettings other)
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

		// Token: 0x0600044F RID: 1103 RVA: 0x000157FC File Offset: 0x000139FC
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

		// Token: 0x06000450 RID: 1104 RVA: 0x0001583C File Offset: 0x00013A3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00015854 File Offset: 0x00013A54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00015860 File Offset: 0x00013A60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.completedQuests_.WriteTo(ref output, CampaignSettings._repeated_completedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001589C File Offset: 0x00013A9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.completedQuests_.CalculateSize(CampaignSettings._repeated_completedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000158E4 File Offset: 0x00013AE4
		[DebuggerNonUserCode]
		public void MergeFrom(CampaignSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.completedQuests_.Add(other.completedQuests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00015926 File Offset: 0x00013B26
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00015934 File Offset: 0x00013B34
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
					this.completedQuests_.AddEntriesFrom(ref input, CampaignSettings._repeated_completedQuests_codec);
				}
			}
		}

		// Token: 0x040001D2 RID: 466
		private static readonly MessageParser<CampaignSettings> _parser = new MessageParser<CampaignSettings>(() => new CampaignSettings());

		// Token: 0x040001D3 RID: 467
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001D4 RID: 468
		public const int CompletedQuestsFieldNumber = 1;

		// Token: 0x040001D5 RID: 469
		private static readonly FieldCodec<int> _repeated_completedQuests_codec = FieldCodec.ForInt32(8U);

		// Token: 0x040001D6 RID: 470
		private readonly RepeatedField<int> completedQuests_ = new RepeatedField<int>();
	}
}

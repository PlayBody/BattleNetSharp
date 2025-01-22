using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073B RID: 1851
	public sealed class PlayScheduleRestriction : IMessage<PlayScheduleRestriction>, IMessage, IEquatable<PlayScheduleRestriction>, IDeepCloneable<PlayScheduleRestriction>, IBufferMessage
	{
		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x00294CC4 File Offset: 0x00292EC4
		[DebuggerNonUserCode]
		public static MessageParser<PlayScheduleRestriction> Parser
		{
			get
			{
				return PlayScheduleRestriction._parser;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x00294CDC File Offset: 0x00292EDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600A999 RID: 43417 RVA: 0x00294D00 File Offset: 0x00292F00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayScheduleRestriction.Descriptor;
			}
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x00294D17 File Offset: 0x00292F17
		[DebuggerNonUserCode]
		public PlayScheduleRestriction()
		{
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x00294D2C File Offset: 0x00292F2C
		[DebuggerNonUserCode]
		public PlayScheduleRestriction(PlayScheduleRestriction other)
			: this()
		{
			this.playSchedule_ = other.playSchedule_.Clone();
			this.timezone_ = other.timezone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A99C RID: 43420 RVA: 0x00294D64 File Offset: 0x00292F64
		[DebuggerNonUserCode]
		public PlayScheduleRestriction Clone()
		{
			return new PlayScheduleRestriction(this);
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600A99D RID: 43421 RVA: 0x00294D7C File Offset: 0x00292F7C
		[DebuggerNonUserCode]
		public RepeatedField<bool> PlaySchedule
		{
			get
			{
				return this.playSchedule_;
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x00294D94 File Offset: 0x00292F94
		// (set) Token: 0x0600A99F RID: 43423 RVA: 0x00294DB5 File Offset: 0x00292FB5
		[DebuggerNonUserCode]
		public string Timezone
		{
			get
			{
				return this.timezone_ ?? PlayScheduleRestriction.TimezoneDefaultValue;
			}
			set
			{
				this.timezone_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600A9A0 RID: 43424 RVA: 0x00294DCC File Offset: 0x00292FCC
		[DebuggerNonUserCode]
		public bool HasTimezone
		{
			get
			{
				return this.timezone_ != null;
			}
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00294DE7 File Offset: 0x00292FE7
		[DebuggerNonUserCode]
		public void ClearTimezone()
		{
			this.timezone_ = null;
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00294DF4 File Offset: 0x00292FF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayScheduleRestriction);
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x00294E14 File Offset: 0x00293014
		[DebuggerNonUserCode]
		public bool Equals(PlayScheduleRestriction other)
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
					bool flag4 = !this.playSchedule_.Equals(other.playSchedule_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Timezone != other.Timezone;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x00294E88 File Offset: 0x00293088
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playSchedule_.GetHashCode();
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num ^= this.Timezone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00294EE0 File Offset: 0x002930E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00294EF8 File Offset: 0x002930F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x00294F04 File Offset: 0x00293104
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playSchedule_.WriteTo(ref output, PlayScheduleRestriction._repeated_playSchedule_codec);
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Timezone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00294F64 File Offset: 0x00293164
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playSchedule_.CalculateSize(PlayScheduleRestriction._repeated_playSchedule_codec);
			bool hasTimezone = this.HasTimezone;
			if (hasTimezone)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Timezone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x00294FC8 File Offset: 0x002931C8
		[DebuggerNonUserCode]
		public void MergeFrom(PlayScheduleRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.playSchedule_.Add(other.playSchedule_);
				bool hasTimezone = other.HasTimezone;
				if (hasTimezone)
				{
					this.Timezone = other.Timezone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x00295023 File Offset: 0x00293223
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x00295030 File Offset: 0x00293230
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Timezone = input.ReadString();
					}
				}
				else
				{
					this.playSchedule_.AddEntriesFrom(ref input, PlayScheduleRestriction._repeated_playSchedule_codec);
				}
			}
		}

		// Token: 0x04004C44 RID: 19524
		private static readonly MessageParser<PlayScheduleRestriction> _parser = new MessageParser<PlayScheduleRestriction>(() => new PlayScheduleRestriction());

		// Token: 0x04004C45 RID: 19525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C46 RID: 19526
		public const int PlayScheduleFieldNumber = 1;

		// Token: 0x04004C47 RID: 19527
		private static readonly FieldCodec<bool> _repeated_playSchedule_codec = FieldCodec.ForBool(8U);

		// Token: 0x04004C48 RID: 19528
		private readonly RepeatedField<bool> playSchedule_ = new RepeatedField<bool>();

		// Token: 0x04004C49 RID: 19529
		public const int TimezoneFieldNumber = 2;

		// Token: 0x04004C4A RID: 19530
		private static readonly string TimezoneDefaultValue = "";

		// Token: 0x04004C4B RID: 19531
		private string timezone_;
	}
}

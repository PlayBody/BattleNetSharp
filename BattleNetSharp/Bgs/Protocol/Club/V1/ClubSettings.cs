using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000446 RID: 1094
	public sealed class ClubSettings : IMessage<ClubSettings>, IMessage, IEquatable<ClubSettings>, IDeepCloneable<ClubSettings>, IBufferMessage
	{
		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x001A36FC File Offset: 0x001A18FC
		[DebuggerNonUserCode]
		public static MessageParser<ClubSettings> Parser
		{
			get
			{
				return ClubSettings._parser;
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06006BF6 RID: 27638 RVA: 0x001A3714 File Offset: 0x001A1914
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x001A3738 File Offset: 0x001A1938
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSettings.Descriptor;
			}
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x001A374F File Offset: 0x001A194F
		[DebuggerNonUserCode]
		public ClubSettings()
		{
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x001A3770 File Offset: 0x001A1970
		[DebuggerNonUserCode]
		public ClubSettings(ClubSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.stream_ = other.stream_.Clone();
			this.streamNotificationFilterAll_ = other.streamNotificationFilterAll_;
			this.attribute_ = other.attribute_.Clone();
			this.pushNotificationFilterAll_ = other.pushNotificationFilterAll_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x001A37DC File Offset: 0x001A19DC
		[DebuggerNonUserCode]
		public ClubSettings Clone()
		{
			return new ClubSettings(this);
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x001A37F4 File Offset: 0x001A19F4
		[DebuggerNonUserCode]
		public RepeatedField<StreamSettings> Stream
		{
			get
			{
				return this.stream_;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06006BFC RID: 27644 RVA: 0x001A380C File Offset: 0x001A1A0C
		// (set) Token: 0x06006BFD RID: 27645 RVA: 0x001A383D File Offset: 0x001A1A3D
		[DebuggerNonUserCode]
		public bool StreamNotificationFilterAll
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool streamNotificationFilterAllDefaultValue;
				if (flag)
				{
					streamNotificationFilterAllDefaultValue = this.streamNotificationFilterAll_;
				}
				else
				{
					streamNotificationFilterAllDefaultValue = ClubSettings.StreamNotificationFilterAllDefaultValue;
				}
				return streamNotificationFilterAllDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamNotificationFilterAll_ = value;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x001A3858 File Offset: 0x001A1A58
		[DebuggerNonUserCode]
		public bool HasStreamNotificationFilterAll
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x001A3875 File Offset: 0x001A1A75
		[DebuggerNonUserCode]
		public void ClearStreamNotificationFilterAll()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06006C00 RID: 27648 RVA: 0x001A3888 File Offset: 0x001A1A88
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x001A38A0 File Offset: 0x001A1AA0
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x001A38D1 File Offset: 0x001A1AD1
		[DebuggerNonUserCode]
		public bool PushNotificationFilterAll
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool pushNotificationFilterAllDefaultValue;
				if (flag)
				{
					pushNotificationFilterAllDefaultValue = this.pushNotificationFilterAll_;
				}
				else
				{
					pushNotificationFilterAllDefaultValue = ClubSettings.PushNotificationFilterAllDefaultValue;
				}
				return pushNotificationFilterAllDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.pushNotificationFilterAll_ = value;
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x001A38EC File Offset: 0x001A1AEC
		[DebuggerNonUserCode]
		public bool HasPushNotificationFilterAll
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x001A3909 File Offset: 0x001A1B09
		[DebuggerNonUserCode]
		public void ClearPushNotificationFilterAll()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x001A391C File Offset: 0x001A1B1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSettings);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001A393C File Offset: 0x001A1B3C
		[DebuggerNonUserCode]
		public bool Equals(ClubSettings other)
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
					bool flag4 = !this.stream_.Equals(other.stream_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StreamNotificationFilterAll != other.StreamNotificationFilterAll;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.PushNotificationFilterAll != other.PushNotificationFilterAll;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001A39F0 File Offset: 0x001A1BF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stream_.GetHashCode();
			bool hasStreamNotificationFilterAll = this.HasStreamNotificationFilterAll;
			if (hasStreamNotificationFilterAll)
			{
				num ^= this.StreamNotificationFilterAll.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasPushNotificationFilterAll = this.HasPushNotificationFilterAll;
			if (hasPushNotificationFilterAll)
			{
				num ^= this.PushNotificationFilterAll.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001A3A78 File Offset: 0x001A1C78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x001A3A90 File Offset: 0x001A1C90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x001A3A9C File Offset: 0x001A1C9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stream_.WriteTo(ref output, ClubSettings._repeated_stream_codec);
			bool hasStreamNotificationFilterAll = this.HasStreamNotificationFilterAll;
			if (hasStreamNotificationFilterAll)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.StreamNotificationFilterAll);
			}
			this.attribute_.WriteTo(ref output, ClubSettings._repeated_attribute_codec);
			bool hasPushNotificationFilterAll = this.HasPushNotificationFilterAll;
			if (hasPushNotificationFilterAll)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PushNotificationFilterAll);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x001A3B30 File Offset: 0x001A1D30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stream_.CalculateSize(ClubSettings._repeated_stream_codec);
			bool hasStreamNotificationFilterAll = this.HasStreamNotificationFilterAll;
			if (hasStreamNotificationFilterAll)
			{
				num += 2;
			}
			num += this.attribute_.CalculateSize(ClubSettings._repeated_attribute_codec);
			bool hasPushNotificationFilterAll = this.HasPushNotificationFilterAll;
			if (hasPushNotificationFilterAll)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x001A3BAC File Offset: 0x001A1DAC
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.stream_.Add(other.stream_);
				bool hasStreamNotificationFilterAll = other.HasStreamNotificationFilterAll;
				if (hasStreamNotificationFilterAll)
				{
					this.StreamNotificationFilterAll = other.StreamNotificationFilterAll;
				}
				this.attribute_.Add(other.attribute_);
				bool hasPushNotificationFilterAll = other.HasPushNotificationFilterAll;
				if (hasPushNotificationFilterAll)
				{
					this.PushNotificationFilterAll = other.PushNotificationFilterAll;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x001A3C32 File Offset: 0x001A1E32
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x001A3C40 File Offset: 0x001A1E40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.StreamNotificationFilterAll = input.ReadBool();
					}
					else
					{
						this.stream_.AddEntriesFrom(ref input, ClubSettings._repeated_stream_codec);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.PushNotificationFilterAll = input.ReadBool();
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ClubSettings._repeated_attribute_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400316D RID: 12653
		private static readonly MessageParser<ClubSettings> _parser = new MessageParser<ClubSettings>(() => new ClubSettings());

		// Token: 0x0400316E RID: 12654
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400316F RID: 12655
		private int _hasBits0;

		// Token: 0x04003170 RID: 12656
		public const int StreamFieldNumber = 1;

		// Token: 0x04003171 RID: 12657
		private static readonly FieldCodec<StreamSettings> _repeated_stream_codec = FieldCodec.ForMessage<StreamSettings>(10U, StreamSettings.Parser);

		// Token: 0x04003172 RID: 12658
		private readonly RepeatedField<StreamSettings> stream_ = new RepeatedField<StreamSettings>();

		// Token: 0x04003173 RID: 12659
		public const int StreamNotificationFilterAllFieldNumber = 2;

		// Token: 0x04003174 RID: 12660
		private static readonly bool StreamNotificationFilterAllDefaultValue = false;

		// Token: 0x04003175 RID: 12661
		private bool streamNotificationFilterAll_;

		// Token: 0x04003176 RID: 12662
		public const int AttributeFieldNumber = 3;

		// Token: 0x04003177 RID: 12663
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003178 RID: 12664
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003179 RID: 12665
		public const int PushNotificationFilterAllFieldNumber = 4;

		// Token: 0x0400317A RID: 12666
		private static readonly bool PushNotificationFilterAllDefaultValue = false;

		// Token: 0x0400317B RID: 12667
		private bool pushNotificationFilterAll_;
	}
}

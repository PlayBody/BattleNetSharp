using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.TerrorZones
{
	// Token: 0x0200077E RID: 1918
	public sealed class TerrorZonesMessageRequest : IMessage<TerrorZonesMessageRequest>, IMessage, IEquatable<TerrorZonesMessageRequest>, IDeepCloneable<TerrorZonesMessageRequest>, IBufferMessage
	{
		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x002AE3F8 File Offset: 0x002AC5F8
		[DebuggerNonUserCode]
		public static MessageParser<TerrorZonesMessageRequest> Parser
		{
			get
			{
				return TerrorZonesMessageRequest._parser;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600B038 RID: 45112 RVA: 0x002AE410 File Offset: 0x002AC610
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TerrorZonesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x002AE434 File Offset: 0x002AC634
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TerrorZonesMessageRequest.Descriptor;
			}
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x002AE44B File Offset: 0x002AC64B
		[DebuggerNonUserCode]
		public TerrorZonesMessageRequest()
		{
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x002AE46C File Offset: 0x002AC66C
		[DebuggerNonUserCode]
		public TerrorZonesMessageRequest(TerrorZonesMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.timeLeft_ = other.timeLeft_;
			this.currArea_ = other.currArea_.Clone();
			this.nextArea_ = other.nextArea_.Clone();
			this.unk3_ = other.unk3_;
			this.unk4_ = other.unk4_;
			this.unk5_ = other.unk5_;
			this.unk6_ = other.unk6_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x002AE4FC File Offset: 0x002AC6FC
		[DebuggerNonUserCode]
		public TerrorZonesMessageRequest Clone()
		{
			return new TerrorZonesMessageRequest(this);
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600B03D RID: 45117 RVA: 0x002AE514 File Offset: 0x002AC714
		// (set) Token: 0x0600B03E RID: 45118 RVA: 0x002AE545 File Offset: 0x002AC745
		[DebuggerNonUserCode]
		public uint TimeLeft
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint timeLeftDefaultValue;
				if (flag)
				{
					timeLeftDefaultValue = this.timeLeft_;
				}
				else
				{
					timeLeftDefaultValue = TerrorZonesMessageRequest.TimeLeftDefaultValue;
				}
				return timeLeftDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timeLeft_ = value;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600B03F RID: 45119 RVA: 0x002AE560 File Offset: 0x002AC760
		[DebuggerNonUserCode]
		public bool HasTimeLeft
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x002AE57D File Offset: 0x002AC77D
		[DebuggerNonUserCode]
		public void ClearTimeLeft()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x002AE590 File Offset: 0x002AC790
		[DebuggerNonUserCode]
		public RepeatedField<uint> CurrArea
		{
			get
			{
				return this.currArea_;
			}
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600B042 RID: 45122 RVA: 0x002AE5A8 File Offset: 0x002AC7A8
		[DebuggerNonUserCode]
		public RepeatedField<uint> NextArea
		{
			get
			{
				return this.nextArea_;
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x002AE5C0 File Offset: 0x002AC7C0
		// (set) Token: 0x0600B044 RID: 45124 RVA: 0x002AE5F1 File Offset: 0x002AC7F1
		[DebuggerNonUserCode]
		public uint Unk3
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint unk3DefaultValue;
				if (flag)
				{
					unk3DefaultValue = this.unk3_;
				}
				else
				{
					unk3DefaultValue = TerrorZonesMessageRequest.Unk3DefaultValue;
				}
				return unk3DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unk3_ = value;
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600B045 RID: 45125 RVA: 0x002AE60C File Offset: 0x002AC80C
		[DebuggerNonUserCode]
		public bool HasUnk3
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x002AE629 File Offset: 0x002AC829
		[DebuggerNonUserCode]
		public void ClearUnk3()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600B047 RID: 45127 RVA: 0x002AE63C File Offset: 0x002AC83C
		// (set) Token: 0x0600B048 RID: 45128 RVA: 0x002AE66D File Offset: 0x002AC86D
		[DebuggerNonUserCode]
		public uint Unk4
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint unk4DefaultValue;
				if (flag)
				{
					unk4DefaultValue = this.unk4_;
				}
				else
				{
					unk4DefaultValue = TerrorZonesMessageRequest.Unk4DefaultValue;
				}
				return unk4DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.unk4_ = value;
			}
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x002AE688 File Offset: 0x002AC888
		[DebuggerNonUserCode]
		public bool HasUnk4
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x002AE6A5 File Offset: 0x002AC8A5
		[DebuggerNonUserCode]
		public void ClearUnk4()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x002AE6B8 File Offset: 0x002AC8B8
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x002AE6E9 File Offset: 0x002AC8E9
		[DebuggerNonUserCode]
		public uint Unk5
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint unk5DefaultValue;
				if (flag)
				{
					unk5DefaultValue = this.unk5_;
				}
				else
				{
					unk5DefaultValue = TerrorZonesMessageRequest.Unk5DefaultValue;
				}
				return unk5DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.unk5_ = value;
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x002AE704 File Offset: 0x002AC904
		[DebuggerNonUserCode]
		public bool HasUnk5
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600B04E RID: 45134 RVA: 0x002AE721 File Offset: 0x002AC921
		[DebuggerNonUserCode]
		public void ClearUnk5()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x002AE734 File Offset: 0x002AC934
		// (set) Token: 0x0600B050 RID: 45136 RVA: 0x002AE766 File Offset: 0x002AC966
		[DebuggerNonUserCode]
		public uint Unk6
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint unk6DefaultValue;
				if (flag)
				{
					unk6DefaultValue = this.unk6_;
				}
				else
				{
					unk6DefaultValue = TerrorZonesMessageRequest.Unk6DefaultValue;
				}
				return unk6DefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.unk6_ = value;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x002AE780 File Offset: 0x002AC980
		[DebuggerNonUserCode]
		public bool HasUnk6
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x002AE79E File Offset: 0x002AC99E
		[DebuggerNonUserCode]
		public void ClearUnk6()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x002AE7B0 File Offset: 0x002AC9B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TerrorZonesMessageRequest);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x002AE7D0 File Offset: 0x002AC9D0
		[DebuggerNonUserCode]
		public bool Equals(TerrorZonesMessageRequest other)
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
					bool flag4 = this.TimeLeft != other.TimeLeft;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.currArea_.Equals(other.currArea_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.nextArea_.Equals(other.nextArea_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Unk3 != other.Unk3;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Unk4 != other.Unk4;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Unk5 != other.Unk5;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.Unk6 != other.Unk6;
											flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x002AE8E0 File Offset: 0x002ACAE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTimeLeft = this.HasTimeLeft;
			if (hasTimeLeft)
			{
				num ^= this.TimeLeft.GetHashCode();
			}
			num ^= this.currArea_.GetHashCode();
			num ^= this.nextArea_.GetHashCode();
			bool hasUnk = this.HasUnk3;
			if (hasUnk)
			{
				num ^= this.Unk3.GetHashCode();
			}
			bool hasUnk2 = this.HasUnk4;
			if (hasUnk2)
			{
				num ^= this.Unk4.GetHashCode();
			}
			bool hasUnk3 = this.HasUnk5;
			if (hasUnk3)
			{
				num ^= this.Unk5.GetHashCode();
			}
			bool hasUnk4 = this.HasUnk6;
			if (hasUnk4)
			{
				num ^= this.Unk6.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x002AE9C0 File Offset: 0x002ACBC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x002AE9D8 File Offset: 0x002ACBD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x002AE9E4 File Offset: 0x002ACBE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTimeLeft = this.HasTimeLeft;
			if (hasTimeLeft)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TimeLeft);
			}
			this.currArea_.WriteTo(ref output, TerrorZonesMessageRequest._repeated_currArea_codec);
			this.nextArea_.WriteTo(ref output, TerrorZonesMessageRequest._repeated_nextArea_codec);
			bool hasUnk = this.HasUnk3;
			if (hasUnk)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Unk3);
			}
			bool hasUnk2 = this.HasUnk4;
			if (hasUnk2)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Unk4);
			}
			bool hasUnk3 = this.HasUnk5;
			if (hasUnk3)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Unk5);
			}
			bool hasUnk4 = this.HasUnk6;
			if (hasUnk4)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Unk6);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x002AEAE0 File Offset: 0x002ACCE0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTimeLeft = this.HasTimeLeft;
			if (hasTimeLeft)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimeLeft);
			}
			num += this.currArea_.CalculateSize(TerrorZonesMessageRequest._repeated_currArea_codec);
			num += this.nextArea_.CalculateSize(TerrorZonesMessageRequest._repeated_nextArea_codec);
			bool hasUnk = this.HasUnk3;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk3);
			}
			bool hasUnk2 = this.HasUnk4;
			if (hasUnk2)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk4);
			}
			bool hasUnk3 = this.HasUnk5;
			if (hasUnk3)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk5);
			}
			bool hasUnk4 = this.HasUnk6;
			if (hasUnk4)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Unk6);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x002AEBCC File Offset: 0x002ACDCC
		[DebuggerNonUserCode]
		public void MergeFrom(TerrorZonesMessageRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTimeLeft = other.HasTimeLeft;
				if (hasTimeLeft)
				{
					this.TimeLeft = other.TimeLeft;
				}
				this.currArea_.Add(other.currArea_);
				this.nextArea_.Add(other.nextArea_);
				bool hasUnk = other.HasUnk3;
				if (hasUnk)
				{
					this.Unk3 = other.Unk3;
				}
				bool hasUnk2 = other.HasUnk4;
				if (hasUnk2)
				{
					this.Unk4 = other.Unk4;
				}
				bool hasUnk3 = other.HasUnk5;
				if (hasUnk3)
				{
					this.Unk5 = other.Unk5;
				}
				bool hasUnk4 = other.HasUnk6;
				if (hasUnk4)
				{
					this.Unk6 = other.Unk6;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x002AECA4 File Offset: 0x002ACEA4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x002AECB0 File Offset: 0x002ACEB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 <= 16U)
					{
						if (num3 == 8U)
						{
							this.TimeLeft = input.ReadUInt32();
							continue;
						}
						if (num3 != 16U)
						{
							goto IL_005B;
						}
					}
					else if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							goto IL_005B;
						}
						goto IL_0094;
					}
					this.currArea_.AddEntriesFrom(ref input, TerrorZonesMessageRequest._repeated_currArea_codec);
				}
				else if (num3 <= 32U)
				{
					if (num3 == 26U)
					{
						goto IL_0094;
					}
					if (num3 != 32U)
					{
						goto IL_005B;
					}
					this.Unk3 = input.ReadUInt32();
				}
				else if (num3 != 40U)
				{
					if (num3 != 48U)
					{
						if (num3 != 56U)
						{
							goto IL_005B;
						}
						this.Unk6 = input.ReadUInt32();
					}
					else
					{
						this.Unk5 = input.ReadUInt32();
					}
				}
				else
				{
					this.Unk4 = input.ReadUInt32();
				}
				continue;
				IL_005B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_0094:
				this.nextArea_.AddEntriesFrom(ref input, TerrorZonesMessageRequest._repeated_nextArea_codec);
			}
		}

		// Token: 0x04004F78 RID: 20344
		private static readonly MessageParser<TerrorZonesMessageRequest> _parser = new MessageParser<TerrorZonesMessageRequest>(() => new TerrorZonesMessageRequest());

		// Token: 0x04004F79 RID: 20345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F7A RID: 20346
		private int _hasBits0;

		// Token: 0x04004F7B RID: 20347
		public const int TimeLeftFieldNumber = 1;

		// Token: 0x04004F7C RID: 20348
		private static readonly uint TimeLeftDefaultValue = 0U;

		// Token: 0x04004F7D RID: 20349
		private uint timeLeft_;

		// Token: 0x04004F7E RID: 20350
		public const int CurrAreaFieldNumber = 2;

		// Token: 0x04004F7F RID: 20351
		private static readonly FieldCodec<uint> _repeated_currArea_codec = FieldCodec.ForUInt32(16U);

		// Token: 0x04004F80 RID: 20352
		private readonly RepeatedField<uint> currArea_ = new RepeatedField<uint>();

		// Token: 0x04004F81 RID: 20353
		public const int NextAreaFieldNumber = 3;

		// Token: 0x04004F82 RID: 20354
		private static readonly FieldCodec<uint> _repeated_nextArea_codec = FieldCodec.ForUInt32(24U);

		// Token: 0x04004F83 RID: 20355
		private readonly RepeatedField<uint> nextArea_ = new RepeatedField<uint>();

		// Token: 0x04004F84 RID: 20356
		public const int Unk3FieldNumber = 4;

		// Token: 0x04004F85 RID: 20357
		private static readonly uint Unk3DefaultValue = 0U;

		// Token: 0x04004F86 RID: 20358
		private uint unk3_;

		// Token: 0x04004F87 RID: 20359
		public const int Unk4FieldNumber = 5;

		// Token: 0x04004F88 RID: 20360
		private static readonly uint Unk4DefaultValue = 0U;

		// Token: 0x04004F89 RID: 20361
		private uint unk4_;

		// Token: 0x04004F8A RID: 20362
		public const int Unk5FieldNumber = 6;

		// Token: 0x04004F8B RID: 20363
		private static readonly uint Unk5DefaultValue = 0U;

		// Token: 0x04004F8C RID: 20364
		private uint unk5_;

		// Token: 0x04004F8D RID: 20365
		public const int Unk6FieldNumber = 7;

		// Token: 0x04004F8E RID: 20366
		private static readonly uint Unk6DefaultValue = 0U;

		// Token: 0x04004F8F RID: 20367
		private uint unk6_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000534 RID: 1332
	public sealed class GetSessionCapacityResponse : IMessage<GetSessionCapacityResponse>, IMessage, IEquatable<GetSessionCapacityResponse>, IDeepCloneable<GetSessionCapacityResponse>, IBufferMessage
	{
		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x060080FC RID: 33020 RVA: 0x001F6620 File Offset: 0x001F4820
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionCapacityResponse> Parser
		{
			get
			{
				return GetSessionCapacityResponse._parser;
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x060080FD RID: 33021 RVA: 0x001F6638 File Offset: 0x001F4838
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x001F665C File Offset: 0x001F485C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionCapacityResponse.Descriptor;
			}
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x001F6673 File Offset: 0x001F4873
		[DebuggerNonUserCode]
		public GetSessionCapacityResponse()
		{
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x001F667D File Offset: 0x001F487D
		[DebuggerNonUserCode]
		public GetSessionCapacityResponse(GetSessionCapacityResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionsAvailable_ = other.sessionsAvailable_;
			this.timeFrameSeconds_ = other.timeFrameSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008101 RID: 33025 RVA: 0x001F66BC File Offset: 0x001F48BC
		[DebuggerNonUserCode]
		public GetSessionCapacityResponse Clone()
		{
			return new GetSessionCapacityResponse(this);
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x001F66D4 File Offset: 0x001F48D4
		// (set) Token: 0x06008103 RID: 33027 RVA: 0x001F6705 File Offset: 0x001F4905
		[DebuggerNonUserCode]
		public uint SessionsAvailable
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint sessionsAvailableDefaultValue;
				if (flag)
				{
					sessionsAvailableDefaultValue = this.sessionsAvailable_;
				}
				else
				{
					sessionsAvailableDefaultValue = GetSessionCapacityResponse.SessionsAvailableDefaultValue;
				}
				return sessionsAvailableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sessionsAvailable_ = value;
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x001F6720 File Offset: 0x001F4920
		[DebuggerNonUserCode]
		public bool HasSessionsAvailable
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x001F673D File Offset: 0x001F493D
		[DebuggerNonUserCode]
		public void ClearSessionsAvailable()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x06008106 RID: 33030 RVA: 0x001F6750 File Offset: 0x001F4950
		// (set) Token: 0x06008107 RID: 33031 RVA: 0x001F6781 File Offset: 0x001F4981
		[DebuggerNonUserCode]
		public uint TimeFrameSeconds
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint timeFrameSecondsDefaultValue;
				if (flag)
				{
					timeFrameSecondsDefaultValue = this.timeFrameSeconds_;
				}
				else
				{
					timeFrameSecondsDefaultValue = GetSessionCapacityResponse.TimeFrameSecondsDefaultValue;
				}
				return timeFrameSecondsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.timeFrameSeconds_ = value;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x001F679C File Offset: 0x001F499C
		[DebuggerNonUserCode]
		public bool HasTimeFrameSeconds
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x001F67B9 File Offset: 0x001F49B9
		[DebuggerNonUserCode]
		public void ClearTimeFrameSeconds()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x001F67CC File Offset: 0x001F49CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionCapacityResponse);
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x001F67EC File Offset: 0x001F49EC
		[DebuggerNonUserCode]
		public bool Equals(GetSessionCapacityResponse other)
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
					bool flag4 = this.SessionsAvailable != other.SessionsAvailable;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TimeFrameSeconds != other.TimeFrameSeconds;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x001F6860 File Offset: 0x001F4A60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionsAvailable = this.HasSessionsAvailable;
			if (hasSessionsAvailable)
			{
				num ^= this.SessionsAvailable.GetHashCode();
			}
			bool hasTimeFrameSeconds = this.HasTimeFrameSeconds;
			if (hasTimeFrameSeconds)
			{
				num ^= this.TimeFrameSeconds.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x001F68CC File Offset: 0x001F4ACC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x001F68E4 File Offset: 0x001F4AE4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x001F68F0 File Offset: 0x001F4AF0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionsAvailable = this.HasSessionsAvailable;
			if (hasSessionsAvailable)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SessionsAvailable);
			}
			bool hasTimeFrameSeconds = this.HasTimeFrameSeconds;
			if (hasTimeFrameSeconds)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TimeFrameSeconds);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x001F6960 File Offset: 0x001F4B60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionsAvailable = this.HasSessionsAvailable;
			if (hasSessionsAvailable)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SessionsAvailable);
			}
			bool hasTimeFrameSeconds = this.HasTimeFrameSeconds;
			if (hasTimeFrameSeconds)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimeFrameSeconds);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x001F69CC File Offset: 0x001F4BCC
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionCapacityResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionsAvailable = other.HasSessionsAvailable;
				if (hasSessionsAvailable)
				{
					this.SessionsAvailable = other.SessionsAvailable;
				}
				bool hasTimeFrameSeconds = other.HasTimeFrameSeconds;
				if (hasTimeFrameSeconds)
				{
					this.TimeFrameSeconds = other.TimeFrameSeconds;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x001F6A2E File Offset: 0x001F4C2E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x001F6A3C File Offset: 0x001F4C3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimeFrameSeconds = input.ReadUInt32();
					}
				}
				else
				{
					this.SessionsAvailable = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003A85 RID: 14981
		private static readonly MessageParser<GetSessionCapacityResponse> _parser = new MessageParser<GetSessionCapacityResponse>(() => new GetSessionCapacityResponse());

		// Token: 0x04003A86 RID: 14982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A87 RID: 14983
		private int _hasBits0;

		// Token: 0x04003A88 RID: 14984
		public const int SessionsAvailableFieldNumber = 1;

		// Token: 0x04003A89 RID: 14985
		private static readonly uint SessionsAvailableDefaultValue = 0U;

		// Token: 0x04003A8A RID: 14986
		private uint sessionsAvailable_;

		// Token: 0x04003A8B RID: 14987
		public const int TimeFrameSecondsFieldNumber = 2;

		// Token: 0x04003A8C RID: 14988
		private static readonly uint TimeFrameSecondsDefaultValue = 0U;

		// Token: 0x04003A8D RID: 14989
		private uint timeFrameSeconds_;
	}
}

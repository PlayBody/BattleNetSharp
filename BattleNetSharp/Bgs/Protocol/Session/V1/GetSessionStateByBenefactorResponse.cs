using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000536 RID: 1334
	public sealed class GetSessionStateByBenefactorResponse : IMessage<GetSessionStateByBenefactorResponse>, IMessage, IEquatable<GetSessionStateByBenefactorResponse>, IDeepCloneable<GetSessionStateByBenefactorResponse>, IBufferMessage
	{
		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x06008130 RID: 33072 RVA: 0x001F709C File Offset: 0x001F529C
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateByBenefactorResponse> Parser
		{
			get
			{
				return GetSessionStateByBenefactorResponse._parser;
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x001F70B4 File Offset: 0x001F52B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06008132 RID: 33074 RVA: 0x001F70D8 File Offset: 0x001F52D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateByBenefactorResponse.Descriptor;
			}
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x001F70EF File Offset: 0x001F52EF
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorResponse()
		{
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x001F7104 File Offset: 0x001F5304
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorResponse(GetSessionStateByBenefactorResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.benefactorHandle_ = ((other.benefactorHandle_ != null) ? other.benefactorHandle_.Clone() : null);
			this.session_ = other.session_.Clone();
			this.minutesRemaining_ = other.minutesRemaining_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x001F7170 File Offset: 0x001F5370
		[DebuggerNonUserCode]
		public GetSessionStateByBenefactorResponse Clone()
		{
			return new GetSessionStateByBenefactorResponse(this);
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x001F7188 File Offset: 0x001F5388
		// (set) Token: 0x06008137 RID: 33079 RVA: 0x001F71A0 File Offset: 0x001F53A0
		[Obsolete]
		[DebuggerNonUserCode]
		public GameAccountHandle BenefactorHandle
		{
			get
			{
				return this.benefactorHandle_;
			}
			set
			{
				this.benefactorHandle_ = value;
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x06008138 RID: 33080 RVA: 0x001F71AC File Offset: 0x001F53AC
		[DebuggerNonUserCode]
		public RepeatedField<SessionState> Session
		{
			get
			{
				return this.session_;
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x06008139 RID: 33081 RVA: 0x001F71C4 File Offset: 0x001F53C4
		// (set) Token: 0x0600813A RID: 33082 RVA: 0x001F71F5 File Offset: 0x001F53F5
		[DebuggerNonUserCode]
		public uint MinutesRemaining
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint minutesRemainingDefaultValue;
				if (flag)
				{
					minutesRemainingDefaultValue = this.minutesRemaining_;
				}
				else
				{
					minutesRemainingDefaultValue = GetSessionStateByBenefactorResponse.MinutesRemainingDefaultValue;
				}
				return minutesRemainingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.minutesRemaining_ = value;
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600813B RID: 33083 RVA: 0x001F7210 File Offset: 0x001F5410
		[DebuggerNonUserCode]
		public bool HasMinutesRemaining
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x001F722D File Offset: 0x001F542D
		[DebuggerNonUserCode]
		public void ClearMinutesRemaining()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x001F7240 File Offset: 0x001F5440
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateByBenefactorResponse);
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x001F7260 File Offset: 0x001F5460
		[DebuggerNonUserCode]
		public bool Equals(GetSessionStateByBenefactorResponse other)
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
					bool flag4 = !object.Equals(this.BenefactorHandle, other.BenefactorHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.session_.Equals(other.session_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MinutesRemaining != other.MinutesRemaining;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x001F72F4 File Offset: 0x001F54F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				num ^= this.BenefactorHandle.GetHashCode();
			}
			num ^= this.session_.GetHashCode();
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				num ^= this.MinutesRemaining.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x001F7370 File Offset: 0x001F5570
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x001F7388 File Offset: 0x001F5588
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x001F7394 File Offset: 0x001F5594
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BenefactorHandle);
			}
			this.session_.WriteTo(ref output, GetSessionStateByBenefactorResponse._repeated_session_codec);
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MinutesRemaining);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x001F7418 File Offset: 0x001F5618
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.benefactorHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BenefactorHandle);
			}
			num += this.session_.CalculateSize(GetSessionStateByBenefactorResponse._repeated_session_codec);
			bool hasMinutesRemaining = this.HasMinutesRemaining;
			if (hasMinutesRemaining)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MinutesRemaining);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x001F749C File Offset: 0x001F569C
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateByBenefactorResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.benefactorHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.benefactorHandle_ == null;
					if (flag3)
					{
						this.BenefactorHandle = new GameAccountHandle();
					}
					this.BenefactorHandle.MergeFrom(other.BenefactorHandle);
				}
				this.session_.Add(other.session_);
				bool hasMinutesRemaining = other.HasMinutesRemaining;
				if (hasMinutesRemaining)
				{
					this.MinutesRemaining = other.MinutesRemaining;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x001F7533 File Offset: 0x001F5733
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x001F7540 File Offset: 0x001F5740
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MinutesRemaining = input.ReadUInt32();
						}
					}
					else
					{
						this.session_.AddEntriesFrom(ref input, GetSessionStateByBenefactorResponse._repeated_session_codec);
					}
				}
				else
				{
					bool flag = this.benefactorHandle_ == null;
					if (flag)
					{
						this.BenefactorHandle = new GameAccountHandle();
					}
					input.ReadMessage(this.BenefactorHandle);
				}
			}
		}

		// Token: 0x04003A99 RID: 15001
		private static readonly MessageParser<GetSessionStateByBenefactorResponse> _parser = new MessageParser<GetSessionStateByBenefactorResponse>(() => new GetSessionStateByBenefactorResponse());

		// Token: 0x04003A9A RID: 15002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A9B RID: 15003
		private int _hasBits0;

		// Token: 0x04003A9C RID: 15004
		public const int BenefactorHandleFieldNumber = 1;

		// Token: 0x04003A9D RID: 15005
		private GameAccountHandle benefactorHandle_;

		// Token: 0x04003A9E RID: 15006
		public const int SessionFieldNumber = 2;

		// Token: 0x04003A9F RID: 15007
		private static readonly FieldCodec<SessionState> _repeated_session_codec = FieldCodec.ForMessage<SessionState>(18U, SessionState.Parser);

		// Token: 0x04003AA0 RID: 15008
		private readonly RepeatedField<SessionState> session_ = new RepeatedField<SessionState>();

		// Token: 0x04003AA1 RID: 15009
		public const int MinutesRemainingFieldNumber = 3;

		// Token: 0x04003AA2 RID: 15010
		private static readonly uint MinutesRemainingDefaultValue = 0U;

		// Token: 0x04003AA3 RID: 15011
		private uint minutesRemaining_;
	}
}

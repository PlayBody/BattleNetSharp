using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200024F RID: 591
	public sealed class CancelPartyReservation : IMessage<CancelPartyReservation>, IMessage, IEquatable<CancelPartyReservation>, IDeepCloneable<CancelPartyReservation>, IBufferMessage
	{
		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x000F8B40 File Offset: 0x000F6D40
		[DebuggerNonUserCode]
		public static MessageParser<CancelPartyReservation> Parser
		{
			get
			{
				return CancelPartyReservation._parser;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x000F8B58 File Offset: 0x000F6D58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[63];
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x000F8B7C File Offset: 0x000F6D7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelPartyReservation.Descriptor;
			}
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x000F8B93 File Offset: 0x000F6D93
		[DebuggerNonUserCode]
		public CancelPartyReservation()
		{
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x000F8B9D File Offset: 0x000F6D9D
		[DebuggerNonUserCode]
		public CancelPartyReservation(CancelPartyReservation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reservationToken_ = other.reservationToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x000F8BD0 File Offset: 0x000F6DD0
		[DebuggerNonUserCode]
		public CancelPartyReservation Clone()
		{
			return new CancelPartyReservation(this);
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06003F8A RID: 16266 RVA: 0x000F8BE8 File Offset: 0x000F6DE8
		// (set) Token: 0x06003F8B RID: 16267 RVA: 0x000F8C19 File Offset: 0x000F6E19
		[DebuggerNonUserCode]
		public ulong ReservationToken
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong reservationTokenDefaultValue;
				if (flag)
				{
					reservationTokenDefaultValue = this.reservationToken_;
				}
				else
				{
					reservationTokenDefaultValue = CancelPartyReservation.ReservationTokenDefaultValue;
				}
				return reservationTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reservationToken_ = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06003F8C RID: 16268 RVA: 0x000F8C34 File Offset: 0x000F6E34
		[DebuggerNonUserCode]
		public bool HasReservationToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x000F8C51 File Offset: 0x000F6E51
		[DebuggerNonUserCode]
		public void ClearReservationToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x000F8C64 File Offset: 0x000F6E64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelPartyReservation);
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x000F8C84 File Offset: 0x000F6E84
		[DebuggerNonUserCode]
		public bool Equals(CancelPartyReservation other)
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
					bool flag4 = this.ReservationToken != other.ReservationToken;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x000F8CDC File Offset: 0x000F6EDC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReservationToken = this.HasReservationToken;
			if (hasReservationToken)
			{
				num ^= this.ReservationToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x000F8D2C File Offset: 0x000F6F2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000F8D44 File Offset: 0x000F6F44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x000F8D50 File Offset: 0x000F6F50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReservationToken = this.HasReservationToken;
			if (hasReservationToken)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ReservationToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000F8D9C File Offset: 0x000F6F9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReservationToken = this.HasReservationToken;
			if (hasReservationToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ReservationToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x000F8DEC File Offset: 0x000F6FEC
		[DebuggerNonUserCode]
		public void MergeFrom(CancelPartyReservation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReservationToken = other.HasReservationToken;
				if (hasReservationToken)
				{
					this.ReservationToken = other.ReservationToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x000F8E35 File Offset: 0x000F7035
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x000F8E40 File Offset: 0x000F7040
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ReservationToken = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001CEB RID: 7403
		private static readonly MessageParser<CancelPartyReservation> _parser = new MessageParser<CancelPartyReservation>(() => new CancelPartyReservation());

		// Token: 0x04001CEC RID: 7404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CED RID: 7405
		private int _hasBits0;

		// Token: 0x04001CEE RID: 7406
		public const int ReservationTokenFieldNumber = 1;

		// Token: 0x04001CEF RID: 7407
		private static readonly ulong ReservationTokenDefaultValue = 0UL;

		// Token: 0x04001CF0 RID: 7408
		private ulong reservationToken_;
	}
}

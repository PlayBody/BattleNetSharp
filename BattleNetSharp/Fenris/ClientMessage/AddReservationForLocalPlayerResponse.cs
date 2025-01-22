using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000248 RID: 584
	public sealed class AddReservationForLocalPlayerResponse : IMessage<AddReservationForLocalPlayerResponse>, IMessage, IEquatable<AddReservationForLocalPlayerResponse>, IDeepCloneable<AddReservationForLocalPlayerResponse>, IBufferMessage
	{
		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x000F6BE8 File Offset: 0x000F4DE8
		[DebuggerNonUserCode]
		public static MessageParser<AddReservationForLocalPlayerResponse> Parser
		{
			get
			{
				return AddReservationForLocalPlayerResponse._parser;
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000F6C00 File Offset: 0x000F4E00
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[56];
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x000F6C24 File Offset: 0x000F4E24
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReservationForLocalPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x000F6C3B File Offset: 0x000F4E3B
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerResponse()
		{
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x000F6C45 File Offset: 0x000F4E45
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerResponse(AddReservationForLocalPlayerResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reservationToken_ = other.reservationToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x000F6C78 File Offset: 0x000F4E78
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerResponse Clone()
		{
			return new AddReservationForLocalPlayerResponse(this);
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x000F6C90 File Offset: 0x000F4E90
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x000F6CC1 File Offset: 0x000F4EC1
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
					reservationTokenDefaultValue = AddReservationForLocalPlayerResponse.ReservationTokenDefaultValue;
				}
				return reservationTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reservationToken_ = value;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x000F6CDC File Offset: 0x000F4EDC
		[DebuggerNonUserCode]
		public bool HasReservationToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000F6CF9 File Offset: 0x000F4EF9
		[DebuggerNonUserCode]
		public void ClearReservationToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000F6D0C File Offset: 0x000F4F0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReservationForLocalPlayerResponse);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x000F6D2C File Offset: 0x000F4F2C
		[DebuggerNonUserCode]
		public bool Equals(AddReservationForLocalPlayerResponse other)
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

		// Token: 0x06003EE5 RID: 16101 RVA: 0x000F6D84 File Offset: 0x000F4F84
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

		// Token: 0x06003EE6 RID: 16102 RVA: 0x000F6DD4 File Offset: 0x000F4FD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x000F6DEC File Offset: 0x000F4FEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x000F6DF8 File Offset: 0x000F4FF8
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

		// Token: 0x06003EE9 RID: 16105 RVA: 0x000F6E44 File Offset: 0x000F5044
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

		// Token: 0x06003EEA RID: 16106 RVA: 0x000F6E94 File Offset: 0x000F5094
		[DebuggerNonUserCode]
		public void MergeFrom(AddReservationForLocalPlayerResponse other)
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

		// Token: 0x06003EEB RID: 16107 RVA: 0x000F6EDD File Offset: 0x000F50DD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x000F6EE8 File Offset: 0x000F50E8
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

		// Token: 0x04001CAF RID: 7343
		private static readonly MessageParser<AddReservationForLocalPlayerResponse> _parser = new MessageParser<AddReservationForLocalPlayerResponse>(() => new AddReservationForLocalPlayerResponse());

		// Token: 0x04001CB0 RID: 7344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CB1 RID: 7345
		private int _hasBits0;

		// Token: 0x04001CB2 RID: 7346
		public const int ReservationTokenFieldNumber = 1;

		// Token: 0x04001CB3 RID: 7347
		private static readonly ulong ReservationTokenDefaultValue = 0UL;

		// Token: 0x04001CB4 RID: 7348
		private ulong reservationToken_;
	}
}

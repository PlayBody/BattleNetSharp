using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000247 RID: 583
	public sealed class AddReservationForLocalPlayerRequest : IMessage<AddReservationForLocalPlayerRequest>, IMessage, IEquatable<AddReservationForLocalPlayerRequest>, IDeepCloneable<AddReservationForLocalPlayerRequest>, IBufferMessage
	{
		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x000F69AC File Offset: 0x000F4BAC
		[DebuggerNonUserCode]
		public static MessageParser<AddReservationForLocalPlayerRequest> Parser
		{
			get
			{
				return AddReservationForLocalPlayerRequest._parser;
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x000F69C4 File Offset: 0x000F4BC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[55];
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x000F69E8 File Offset: 0x000F4BE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddReservationForLocalPlayerRequest.Descriptor;
			}
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x000F69FF File Offset: 0x000F4BFF
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerRequest()
		{
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x000F6A09 File Offset: 0x000F4C09
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerRequest(AddReservationForLocalPlayerRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x000F6A24 File Offset: 0x000F4C24
		[DebuggerNonUserCode]
		public AddReservationForLocalPlayerRequest Clone()
		{
			return new AddReservationForLocalPlayerRequest(this);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x000F6A3C File Offset: 0x000F4C3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddReservationForLocalPlayerRequest);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x000F6A5C File Offset: 0x000F4C5C
		[DebuggerNonUserCode]
		public bool Equals(AddReservationForLocalPlayerRequest other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x000F6A9C File Offset: 0x000F4C9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x000F6AD0 File Offset: 0x000F4CD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x000F6AE8 File Offset: 0x000F4CE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x000F6B20 File Offset: 0x000F4D20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x000F6B54 File Offset: 0x000F4D54
		[DebuggerNonUserCode]
		public void MergeFrom(AddReservationForLocalPlayerRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x000F6B84 File Offset: 0x000F4D84
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x000F6B90 File Offset: 0x000F4D90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CAD RID: 7341
		private static readonly MessageParser<AddReservationForLocalPlayerRequest> _parser = new MessageParser<AddReservationForLocalPlayerRequest>(() => new AddReservationForLocalPlayerRequest());

		// Token: 0x04001CAE RID: 7342
		private UnknownFieldSet _unknownFields;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GemTicket.GemTicket
{
	// Token: 0x02000788 RID: 1928
	public sealed class GemTicketRequest : IMessage<GemTicketRequest>, IMessage, IEquatable<GemTicketRequest>, IDeepCloneable<GemTicketRequest>, IBufferMessage
	{
		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600B0BC RID: 45244 RVA: 0x002B02E0 File Offset: 0x002AE4E0
		[DebuggerNonUserCode]
		public static MessageParser<GemTicketRequest> Parser
		{
			get
			{
				return GemTicketRequest._parser;
			}
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x002B02F8 File Offset: 0x002AE4F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GemTicketReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x002B031C File Offset: 0x002AE51C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GemTicketRequest.Descriptor;
			}
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x002B0333 File Offset: 0x002AE533
		[DebuggerNonUserCode]
		public GemTicketRequest()
		{
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x002B033D File Offset: 0x002AE53D
		[DebuggerNonUserCode]
		public GemTicketRequest(GemTicketRequest other)
			: this()
		{
			this.flags1_ = other.flags1_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x002B0364 File Offset: 0x002AE564
		[DebuggerNonUserCode]
		public GemTicketRequest Clone()
		{
			return new GemTicketRequest(this);
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600B0C2 RID: 45250 RVA: 0x002B037C File Offset: 0x002AE57C
		// (set) Token: 0x0600B0C3 RID: 45251 RVA: 0x002B039D File Offset: 0x002AE59D
		[DebuggerNonUserCode]
		public ByteString Flags1
		{
			get
			{
				return this.flags1_ ?? GemTicketRequest.Flags1DefaultValue;
			}
			set
			{
				this.flags1_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600B0C4 RID: 45252 RVA: 0x002B03B4 File Offset: 0x002AE5B4
		[DebuggerNonUserCode]
		public bool HasFlags1
		{
			get
			{
				return this.flags1_ != null;
			}
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x002B03D2 File Offset: 0x002AE5D2
		[DebuggerNonUserCode]
		public void ClearFlags1()
		{
			this.flags1_ = null;
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x002B03DC File Offset: 0x002AE5DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GemTicketRequest);
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x002B03FC File Offset: 0x002AE5FC
		[DebuggerNonUserCode]
		public bool Equals(GemTicketRequest other)
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
					bool flag4 = this.Flags1 != other.Flags1;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x002B0454 File Offset: 0x002AE654
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFlags = this.HasFlags1;
			if (hasFlags)
			{
				num ^= this.Flags1.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x002B04A0 File Offset: 0x002AE6A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x002B04B8 File Offset: 0x002AE6B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x002B04C4 File Offset: 0x002AE6C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFlags = this.HasFlags1;
			if (hasFlags)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Flags1);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x002B0510 File Offset: 0x002AE710
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFlags = this.HasFlags1;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Flags1);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0CD RID: 45261 RVA: 0x002B0560 File Offset: 0x002AE760
		[DebuggerNonUserCode]
		public void MergeFrom(GemTicketRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFlags = other.HasFlags1;
				if (hasFlags)
				{
					this.Flags1 = other.Flags1;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x002B05A9 File Offset: 0x002AE7A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x002B05B4 File Offset: 0x002AE7B4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Flags1 = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004FB6 RID: 20406
		private static readonly MessageParser<GemTicketRequest> _parser = new MessageParser<GemTicketRequest>(() => new GemTicketRequest());

		// Token: 0x04004FB7 RID: 20407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FB8 RID: 20408
		public const int Flags1FieldNumber = 1;

		// Token: 0x04004FB9 RID: 20409
		private static readonly ByteString Flags1DefaultValue = ByteString.Empty;

		// Token: 0x04004FBA RID: 20410
		private ByteString flags1_;
	}
}

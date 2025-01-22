using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GemTicket.GemTicket
{
	// Token: 0x02000789 RID: 1929
	public sealed class GemTicketResponse : IMessage<GemTicketResponse>, IMessage, IEquatable<GemTicketResponse>, IDeepCloneable<GemTicketResponse>, IBufferMessage
	{
		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600B0D1 RID: 45265 RVA: 0x002B062C File Offset: 0x002AE82C
		[DebuggerNonUserCode]
		public static MessageParser<GemTicketResponse> Parser
		{
			get
			{
				return GemTicketResponse._parser;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600B0D2 RID: 45266 RVA: 0x002B0644 File Offset: 0x002AE844
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GemTicketReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x002B0668 File Offset: 0x002AE868
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GemTicketResponse.Descriptor;
			}
		}

		// Token: 0x0600B0D4 RID: 45268 RVA: 0x002B067F File Offset: 0x002AE87F
		[DebuggerNonUserCode]
		public GemTicketResponse()
		{
		}

		// Token: 0x0600B0D5 RID: 45269 RVA: 0x002B0689 File Offset: 0x002AE889
		[DebuggerNonUserCode]
		public GemTicketResponse(GemTicketResponse other)
			: this()
		{
			this.magicNumber_ = other.magicNumber_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x002B06B0 File Offset: 0x002AE8B0
		[DebuggerNonUserCode]
		public GemTicketResponse Clone()
		{
			return new GemTicketResponse(this);
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600B0D7 RID: 45271 RVA: 0x002B06C8 File Offset: 0x002AE8C8
		// (set) Token: 0x0600B0D8 RID: 45272 RVA: 0x002B06E9 File Offset: 0x002AE8E9
		[DebuggerNonUserCode]
		public string MagicNumber
		{
			get
			{
				return this.magicNumber_ ?? GemTicketResponse.MagicNumberDefaultValue;
			}
			set
			{
				this.magicNumber_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x002B0700 File Offset: 0x002AE900
		[DebuggerNonUserCode]
		public bool HasMagicNumber
		{
			get
			{
				return this.magicNumber_ != null;
			}
		}

		// Token: 0x0600B0DA RID: 45274 RVA: 0x002B071B File Offset: 0x002AE91B
		[DebuggerNonUserCode]
		public void ClearMagicNumber()
		{
			this.magicNumber_ = null;
		}

		// Token: 0x0600B0DB RID: 45275 RVA: 0x002B0728 File Offset: 0x002AE928
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GemTicketResponse);
		}

		// Token: 0x0600B0DC RID: 45276 RVA: 0x002B0748 File Offset: 0x002AE948
		[DebuggerNonUserCode]
		public bool Equals(GemTicketResponse other)
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
					bool flag4 = this.MagicNumber != other.MagicNumber;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x002B07A0 File Offset: 0x002AE9A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMagicNumber = this.HasMagicNumber;
			if (hasMagicNumber)
			{
				num ^= this.MagicNumber.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x002B07EC File Offset: 0x002AE9EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x002B0804 File Offset: 0x002AEA04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x002B0810 File Offset: 0x002AEA10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMagicNumber = this.HasMagicNumber;
			if (hasMagicNumber)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MagicNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x002B085C File Offset: 0x002AEA5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMagicNumber = this.HasMagicNumber;
			if (hasMagicNumber)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MagicNumber);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x002B08AC File Offset: 0x002AEAAC
		[DebuggerNonUserCode]
		public void MergeFrom(GemTicketResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMagicNumber = other.HasMagicNumber;
				if (hasMagicNumber)
				{
					this.MagicNumber = other.MagicNumber;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x002B08F5 File Offset: 0x002AEAF5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x002B0900 File Offset: 0x002AEB00
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
					this.MagicNumber = input.ReadString();
				}
			}
		}

		// Token: 0x04004FBB RID: 20411
		private static readonly MessageParser<GemTicketResponse> _parser = new MessageParser<GemTicketResponse>(() => new GemTicketResponse());

		// Token: 0x04004FBC RID: 20412
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FBD RID: 20413
		public const int MagicNumberFieldNumber = 1;

		// Token: 0x04004FBE RID: 20414
		private static readonly string MagicNumberDefaultValue = "";

		// Token: 0x04004FBF RID: 20415
		private string magicNumber_;
	}
}

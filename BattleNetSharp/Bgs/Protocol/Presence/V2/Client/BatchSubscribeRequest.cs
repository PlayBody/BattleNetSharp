using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C3 RID: 1475
	public sealed class BatchSubscribeRequest : IMessage<BatchSubscribeRequest>, IMessage, IEquatable<BatchSubscribeRequest>, IDeepCloneable<BatchSubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x0021E834 File Offset: 0x0021CA34
		[DebuggerNonUserCode]
		public static MessageParser<BatchSubscribeRequest> Parser
		{
			get
			{
				return BatchSubscribeRequest._parser;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x0021E84C File Offset: 0x0021CA4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008BB7 RID: 35767 RVA: 0x0021E870 File Offset: 0x0021CA70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x0021E887 File Offset: 0x0021CA87
		[DebuggerNonUserCode]
		public BatchSubscribeRequest()
		{
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x0021E89C File Offset: 0x0021CA9C
		[DebuggerNonUserCode]
		public BatchSubscribeRequest(BatchSubscribeRequest other)
			: this()
		{
			this.accountIds_ = other.accountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x0021E8C8 File Offset: 0x0021CAC8
		[DebuggerNonUserCode]
		public BatchSubscribeRequest Clone()
		{
			return new BatchSubscribeRequest(this);
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008BBB RID: 35771 RVA: 0x0021E8E0 File Offset: 0x0021CAE0
		[DebuggerNonUserCode]
		public RepeatedField<ulong> AccountIds
		{
			get
			{
				return this.accountIds_;
			}
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x0021E8F8 File Offset: 0x0021CAF8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSubscribeRequest);
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x0021E918 File Offset: 0x0021CB18
		[DebuggerNonUserCode]
		public bool Equals(BatchSubscribeRequest other)
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
					bool flag4 = !this.accountIds_.Equals(other.accountIds_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x0021E974 File Offset: 0x0021CB74
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.accountIds_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x0021E9B4 File Offset: 0x0021CBB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x0021E9CC File Offset: 0x0021CBCC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x0021E9D8 File Offset: 0x0021CBD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.accountIds_.WriteTo(ref output, BatchSubscribeRequest._repeated_accountIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x0021EA14 File Offset: 0x0021CC14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.accountIds_.CalculateSize(BatchSubscribeRequest._repeated_accountIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x0021EA5C File Offset: 0x0021CC5C
		[DebuggerNonUserCode]
		public void MergeFrom(BatchSubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.accountIds_.Add(other.accountIds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x0021EA9E File Offset: 0x0021CC9E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x0021EAAC File Offset: 0x0021CCAC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.accountIds_.AddEntriesFrom(ref input, BatchSubscribeRequest._repeated_accountIds_codec);
				}
			}
		}

		// Token: 0x04003F38 RID: 16184
		private static readonly MessageParser<BatchSubscribeRequest> _parser = new MessageParser<BatchSubscribeRequest>(() => new BatchSubscribeRequest());

		// Token: 0x04003F39 RID: 16185
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F3A RID: 16186
		public const int AccountIdsFieldNumber = 1;

		// Token: 0x04003F3B RID: 16187
		private static readonly FieldCodec<ulong> _repeated_accountIds_codec = FieldCodec.ForUInt64(10U);

		// Token: 0x04003F3C RID: 16188
		private readonly RepeatedField<ulong> accountIds_ = new RepeatedField<ulong>();
	}
}

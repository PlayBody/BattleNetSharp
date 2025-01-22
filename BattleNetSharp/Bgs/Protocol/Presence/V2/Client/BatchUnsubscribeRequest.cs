using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C4 RID: 1476
	public sealed class BatchUnsubscribeRequest : IMessage<BatchUnsubscribeRequest>, IMessage, IEquatable<BatchUnsubscribeRequest>, IDeepCloneable<BatchUnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06008BC7 RID: 35783 RVA: 0x0021EB30 File Offset: 0x0021CD30
		[DebuggerNonUserCode]
		public static MessageParser<BatchUnsubscribeRequest> Parser
		{
			get
			{
				return BatchUnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x0021EB48 File Offset: 0x0021CD48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x0021EB6C File Offset: 0x0021CD6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchUnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x0021EB83 File Offset: 0x0021CD83
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest()
		{
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x0021EB98 File Offset: 0x0021CD98
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest(BatchUnsubscribeRequest other)
			: this()
		{
			this.accountIds_ = other.accountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x0021EBC4 File Offset: 0x0021CDC4
		[DebuggerNonUserCode]
		public BatchUnsubscribeRequest Clone()
		{
			return new BatchUnsubscribeRequest(this);
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06008BCD RID: 35789 RVA: 0x0021EBDC File Offset: 0x0021CDDC
		[DebuggerNonUserCode]
		public RepeatedField<ulong> AccountIds
		{
			get
			{
				return this.accountIds_;
			}
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x0021EBF4 File Offset: 0x0021CDF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchUnsubscribeRequest);
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x0021EC14 File Offset: 0x0021CE14
		[DebuggerNonUserCode]
		public bool Equals(BatchUnsubscribeRequest other)
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

		// Token: 0x06008BD0 RID: 35792 RVA: 0x0021EC70 File Offset: 0x0021CE70
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

		// Token: 0x06008BD1 RID: 35793 RVA: 0x0021ECB0 File Offset: 0x0021CEB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x0021ECC8 File Offset: 0x0021CEC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x0021ECD4 File Offset: 0x0021CED4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.accountIds_.WriteTo(ref output, BatchUnsubscribeRequest._repeated_accountIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x0021ED10 File Offset: 0x0021CF10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.accountIds_.CalculateSize(BatchUnsubscribeRequest._repeated_accountIds_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x0021ED58 File Offset: 0x0021CF58
		[DebuggerNonUserCode]
		public void MergeFrom(BatchUnsubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.accountIds_.Add(other.accountIds_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x0021ED9A File Offset: 0x0021CF9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x0021EDA8 File Offset: 0x0021CFA8
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
					this.accountIds_.AddEntriesFrom(ref input, BatchUnsubscribeRequest._repeated_accountIds_codec);
				}
			}
		}

		// Token: 0x04003F3D RID: 16189
		private static readonly MessageParser<BatchUnsubscribeRequest> _parser = new MessageParser<BatchUnsubscribeRequest>(() => new BatchUnsubscribeRequest());

		// Token: 0x04003F3E RID: 16190
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F3F RID: 16191
		public const int AccountIdsFieldNumber = 1;

		// Token: 0x04003F40 RID: 16192
		private static readonly FieldCodec<ulong> _repeated_accountIds_codec = FieldCodec.ForUInt64(10U);

		// Token: 0x04003F41 RID: 16193
		private readonly RepeatedField<ulong> accountIds_ = new RepeatedField<ulong>();
	}
}

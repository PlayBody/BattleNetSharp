using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000713 RID: 1811
	public sealed class SubscriptionUpdateRequest : IMessage<SubscriptionUpdateRequest>, IMessage, IEquatable<SubscriptionUpdateRequest>, IDeepCloneable<SubscriptionUpdateRequest>, IBufferMessage
	{
		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x00286BC4 File Offset: 0x00284DC4
		[DebuggerNonUserCode]
		public static MessageParser<SubscriptionUpdateRequest> Parser
		{
			get
			{
				return SubscriptionUpdateRequest._parser;
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x00286BDC File Offset: 0x00284DDC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A5FF RID: 42495 RVA: 0x00286C00 File Offset: 0x00284E00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriptionUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600A600 RID: 42496 RVA: 0x00286C17 File Offset: 0x00284E17
		[DebuggerNonUserCode]
		public SubscriptionUpdateRequest()
		{
		}

		// Token: 0x0600A601 RID: 42497 RVA: 0x00286C2C File Offset: 0x00284E2C
		[DebuggerNonUserCode]
		public SubscriptionUpdateRequest(SubscriptionUpdateRequest other)
			: this()
		{
			this.ref_ = other.ref_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A602 RID: 42498 RVA: 0x00286C58 File Offset: 0x00284E58
		[DebuggerNonUserCode]
		public SubscriptionUpdateRequest Clone()
		{
			return new SubscriptionUpdateRequest(this);
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A603 RID: 42499 RVA: 0x00286C70 File Offset: 0x00284E70
		[DebuggerNonUserCode]
		public RepeatedField<SubscriberReference> Ref
		{
			get
			{
				return this.ref_;
			}
		}

		// Token: 0x0600A604 RID: 42500 RVA: 0x00286C88 File Offset: 0x00284E88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriptionUpdateRequest);
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x00286CA8 File Offset: 0x00284EA8
		[DebuggerNonUserCode]
		public bool Equals(SubscriptionUpdateRequest other)
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
					bool flag4 = !this.ref_.Equals(other.ref_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x00286D04 File Offset: 0x00284F04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ref_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x00286D44 File Offset: 0x00284F44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x00286D5C File Offset: 0x00284F5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x00286D68 File Offset: 0x00284F68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ref_.WriteTo(ref output, SubscriptionUpdateRequest._repeated_ref_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x00286DA4 File Offset: 0x00284FA4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ref_.CalculateSize(SubscriptionUpdateRequest._repeated_ref_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x00286DEC File Offset: 0x00284FEC
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriptionUpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ref_.Add(other.ref_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x00286E2E File Offset: 0x0028502E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x00286E3C File Offset: 0x0028503C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ref_.AddEntriesFrom(ref input, SubscriptionUpdateRequest._repeated_ref_codec);
				}
			}
		}

		// Token: 0x04004A9F RID: 19103
		private static readonly MessageParser<SubscriptionUpdateRequest> _parser = new MessageParser<SubscriptionUpdateRequest>(() => new SubscriptionUpdateRequest());

		// Token: 0x04004AA0 RID: 19104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA1 RID: 19105
		public const int RefFieldNumber = 2;

		// Token: 0x04004AA2 RID: 19106
		private static readonly FieldCodec<SubscriberReference> _repeated_ref_codec = FieldCodec.ForMessage<SubscriberReference>(18U, SubscriberReference.Parser);

		// Token: 0x04004AA3 RID: 19107
		private readonly RepeatedField<SubscriberReference> ref_ = new RepeatedField<SubscriberReference>();
	}
}

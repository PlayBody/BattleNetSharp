using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000714 RID: 1812
	public sealed class SubscriptionUpdateResponse : IMessage<SubscriptionUpdateResponse>, IMessage, IEquatable<SubscriptionUpdateResponse>, IDeepCloneable<SubscriptionUpdateResponse>, IBufferMessage
	{
		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x00286EC0 File Offset: 0x002850C0
		[DebuggerNonUserCode]
		public static MessageParser<SubscriptionUpdateResponse> Parser
		{
			get
			{
				return SubscriptionUpdateResponse._parser;
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A610 RID: 42512 RVA: 0x00286ED8 File Offset: 0x002850D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x00286EFC File Offset: 0x002850FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriptionUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x00286F13 File Offset: 0x00285113
		[DebuggerNonUserCode]
		public SubscriptionUpdateResponse()
		{
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x00286F28 File Offset: 0x00285128
		[DebuggerNonUserCode]
		public SubscriptionUpdateResponse(SubscriptionUpdateResponse other)
			: this()
		{
			this.ref_ = other.ref_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x00286F54 File Offset: 0x00285154
		[DebuggerNonUserCode]
		public SubscriptionUpdateResponse Clone()
		{
			return new SubscriptionUpdateResponse(this);
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x00286F6C File Offset: 0x0028516C
		[DebuggerNonUserCode]
		public RepeatedField<SubscriberReference> Ref
		{
			get
			{
				return this.ref_;
			}
		}

		// Token: 0x0600A616 RID: 42518 RVA: 0x00286F84 File Offset: 0x00285184
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriptionUpdateResponse);
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x00286FA4 File Offset: 0x002851A4
		[DebuggerNonUserCode]
		public bool Equals(SubscriptionUpdateResponse other)
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

		// Token: 0x0600A618 RID: 42520 RVA: 0x00287000 File Offset: 0x00285200
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

		// Token: 0x0600A619 RID: 42521 RVA: 0x00287040 File Offset: 0x00285240
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x00287058 File Offset: 0x00285258
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x00287064 File Offset: 0x00285264
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ref_.WriteTo(ref output, SubscriptionUpdateResponse._repeated_ref_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x002870A0 File Offset: 0x002852A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ref_.CalculateSize(SubscriptionUpdateResponse._repeated_ref_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x002870E8 File Offset: 0x002852E8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriptionUpdateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ref_.Add(other.ref_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x0028712A File Offset: 0x0028532A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00287138 File Offset: 0x00285338
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
					this.ref_.AddEntriesFrom(ref input, SubscriptionUpdateResponse._repeated_ref_codec);
				}
			}
		}

		// Token: 0x04004AA4 RID: 19108
		private static readonly MessageParser<SubscriptionUpdateResponse> _parser = new MessageParser<SubscriptionUpdateResponse>(() => new SubscriptionUpdateResponse());

		// Token: 0x04004AA5 RID: 19109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AA6 RID: 19110
		public const int RefFieldNumber = 1;

		// Token: 0x04004AA7 RID: 19111
		private static readonly FieldCodec<SubscriberReference> _repeated_ref_codec = FieldCodec.ForMessage<SubscriberReference>(10U, SubscriberReference.Parser);

		// Token: 0x04004AA8 RID: 19112
		private readonly RepeatedField<SubscriberReference> ref_ = new RepeatedField<SubscriberReference>();
	}
}

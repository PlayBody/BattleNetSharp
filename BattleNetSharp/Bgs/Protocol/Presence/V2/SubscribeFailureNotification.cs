using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005B5 RID: 1461
	public sealed class SubscribeFailureNotification : IMessage<SubscribeFailureNotification>, IMessage, IEquatable<SubscribeFailureNotification>, IDeepCloneable<SubscribeFailureNotification>, IBufferMessage
	{
		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06008AC7 RID: 35527 RVA: 0x0021B0A8 File Offset: 0x002192A8
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeFailureNotification> Parser
		{
			get
			{
				return SubscribeFailureNotification._parser;
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x0021B0C0 File Offset: 0x002192C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x0021B0E4 File Offset: 0x002192E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeFailureNotification.Descriptor;
			}
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x0021B0FB File Offset: 0x002192FB
		[DebuggerNonUserCode]
		public SubscribeFailureNotification()
		{
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x0021B110 File Offset: 0x00219310
		[DebuggerNonUserCode]
		public SubscribeFailureNotification(SubscribeFailureNotification other)
			: this()
		{
			this.failures_ = other.failures_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x0021B13C File Offset: 0x0021933C
		[DebuggerNonUserCode]
		public SubscribeFailureNotification Clone()
		{
			return new SubscribeFailureNotification(this);
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06008ACD RID: 35533 RVA: 0x0021B154 File Offset: 0x00219354
		[DebuggerNonUserCode]
		public RepeatedField<SubscribeFailureResult> Failures
		{
			get
			{
				return this.failures_;
			}
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x0021B16C File Offset: 0x0021936C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeFailureNotification);
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x0021B18C File Offset: 0x0021938C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeFailureNotification other)
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
					bool flag4 = !this.failures_.Equals(other.failures_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x0021B1E8 File Offset: 0x002193E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.failures_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x0021B228 File Offset: 0x00219428
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x0021B240 File Offset: 0x00219440
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x0021B24C File Offset: 0x0021944C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.failures_.WriteTo(ref output, SubscribeFailureNotification._repeated_failures_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x0021B288 File Offset: 0x00219488
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.failures_.CalculateSize(SubscribeFailureNotification._repeated_failures_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x0021B2D0 File Offset: 0x002194D0
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeFailureNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.failures_.Add(other.failures_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x0021B312 File Offset: 0x00219512
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x0021B320 File Offset: 0x00219520
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
					this.failures_.AddEntriesFrom(ref input, SubscribeFailureNotification._repeated_failures_codec);
				}
			}
		}

		// Token: 0x04003ECD RID: 16077
		private static readonly MessageParser<SubscribeFailureNotification> _parser = new MessageParser<SubscribeFailureNotification>(() => new SubscribeFailureNotification());

		// Token: 0x04003ECE RID: 16078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003ECF RID: 16079
		public const int FailuresFieldNumber = 1;

		// Token: 0x04003ED0 RID: 16080
		private static readonly FieldCodec<SubscribeFailureResult> _repeated_failures_codec = FieldCodec.ForMessage<SubscribeFailureResult>(10U, SubscribeFailureResult.Parser);

		// Token: 0x04003ED1 RID: 16081
		private readonly RepeatedField<SubscribeFailureResult> failures_ = new RepeatedField<SubscribeFailureResult>();
	}
}

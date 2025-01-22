using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A8 RID: 1448
	public sealed class BatchSubscribeResponse : IMessage<BatchSubscribeResponse>, IMessage, IEquatable<BatchSubscribeResponse>, IDeepCloneable<BatchSubscribeResponse>, IBufferMessage
	{
		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x060089CE RID: 35278 RVA: 0x002175BC File Offset: 0x002157BC
		[DebuggerNonUserCode]
		public static MessageParser<BatchSubscribeResponse> Parser
		{
			get
			{
				return BatchSubscribeResponse._parser;
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x002175D4 File Offset: 0x002157D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x002175F8 File Offset: 0x002157F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSubscribeResponse.Descriptor;
			}
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x0021760F File Offset: 0x0021580F
		[DebuggerNonUserCode]
		public BatchSubscribeResponse()
		{
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x00217624 File Offset: 0x00215824
		[DebuggerNonUserCode]
		public BatchSubscribeResponse(BatchSubscribeResponse other)
			: this()
		{
			this.subscribeFailed_ = other.subscribeFailed_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x00217650 File Offset: 0x00215850
		[DebuggerNonUserCode]
		public BatchSubscribeResponse Clone()
		{
			return new BatchSubscribeResponse(this);
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x060089D4 RID: 35284 RVA: 0x00217668 File Offset: 0x00215868
		[DebuggerNonUserCode]
		public RepeatedField<SubscribeResult> SubscribeFailed
		{
			get
			{
				return this.subscribeFailed_;
			}
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x00217680 File Offset: 0x00215880
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSubscribeResponse);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x002176A0 File Offset: 0x002158A0
		[DebuggerNonUserCode]
		public bool Equals(BatchSubscribeResponse other)
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
					bool flag4 = !this.subscribeFailed_.Equals(other.subscribeFailed_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x002176FC File Offset: 0x002158FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.subscribeFailed_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x0021773C File Offset: 0x0021593C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x00217754 File Offset: 0x00215954
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00217760 File Offset: 0x00215960
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.subscribeFailed_.WriteTo(ref output, BatchSubscribeResponse._repeated_subscribeFailed_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x0021779C File Offset: 0x0021599C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.subscribeFailed_.CalculateSize(BatchSubscribeResponse._repeated_subscribeFailed_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x002177E4 File Offset: 0x002159E4
		[DebuggerNonUserCode]
		public void MergeFrom(BatchSubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.subscribeFailed_.Add(other.subscribeFailed_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x00217826 File Offset: 0x00215A26
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089DE RID: 35294 RVA: 0x00217834 File Offset: 0x00215A34
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
					this.subscribeFailed_.AddEntriesFrom(ref input, BatchSubscribeResponse._repeated_subscribeFailed_codec);
				}
			}
		}

		// Token: 0x04003E5A RID: 15962
		private static readonly MessageParser<BatchSubscribeResponse> _parser = new MessageParser<BatchSubscribeResponse>(() => new BatchSubscribeResponse());

		// Token: 0x04003E5B RID: 15963
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E5C RID: 15964
		public const int SubscribeFailedFieldNumber = 1;

		// Token: 0x04003E5D RID: 15965
		private static readonly FieldCodec<SubscribeResult> _repeated_subscribeFailed_codec = FieldCodec.ForMessage<SubscribeResult>(10U, SubscribeResult.Parser);

		// Token: 0x04003E5E RID: 15966
		private readonly RepeatedField<SubscribeResult> subscribeFailed_ = new RepeatedField<SubscribeResult>();
	}
}

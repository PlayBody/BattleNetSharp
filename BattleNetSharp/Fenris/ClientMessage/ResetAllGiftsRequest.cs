using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000217 RID: 535
	public sealed class ResetAllGiftsRequest : IMessage<ResetAllGiftsRequest>, IMessage, IEquatable<ResetAllGiftsRequest>, IDeepCloneable<ResetAllGiftsRequest>, IBufferMessage
	{
		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x000E7904 File Offset: 0x000E5B04
		[DebuggerNonUserCode]
		public static MessageParser<ResetAllGiftsRequest> Parser
		{
			get
			{
				return ResetAllGiftsRequest._parser;
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x000E791C File Offset: 0x000E5B1C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x000E7940 File Offset: 0x000E5B40
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetAllGiftsRequest.Descriptor;
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x000E7957 File Offset: 0x000E5B57
		[DebuggerNonUserCode]
		public ResetAllGiftsRequest()
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000E7961 File Offset: 0x000E5B61
		[DebuggerNonUserCode]
		public ResetAllGiftsRequest(ResetAllGiftsRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x000E797C File Offset: 0x000E5B7C
		[DebuggerNonUserCode]
		public ResetAllGiftsRequest Clone()
		{
			return new ResetAllGiftsRequest(this);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x000E7994 File Offset: 0x000E5B94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetAllGiftsRequest);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x000E79B4 File Offset: 0x000E5BB4
		[DebuggerNonUserCode]
		public bool Equals(ResetAllGiftsRequest other)
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

		// Token: 0x06003A22 RID: 14882 RVA: 0x000E79F4 File Offset: 0x000E5BF4
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

		// Token: 0x06003A23 RID: 14883 RVA: 0x000E7A28 File Offset: 0x000E5C28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x000E7A40 File Offset: 0x000E5C40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x000E7A4C File Offset: 0x000E5C4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x000E7A78 File Offset: 0x000E5C78
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

		// Token: 0x06003A27 RID: 14887 RVA: 0x000E7AAC File Offset: 0x000E5CAC
		[DebuggerNonUserCode]
		public void MergeFrom(ResetAllGiftsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x000E7ADC File Offset: 0x000E5CDC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x000E7AE8 File Offset: 0x000E5CE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001AF1 RID: 6897
		private static readonly MessageParser<ResetAllGiftsRequest> _parser = new MessageParser<ResetAllGiftsRequest>(() => new ResetAllGiftsRequest());

		// Token: 0x04001AF2 RID: 6898
		private UnknownFieldSet _unknownFields;
	}
}

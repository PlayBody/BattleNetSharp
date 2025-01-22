using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x020006FD RID: 1789
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x0028187C File Offset: 0x0027FA7C
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600A486 RID: 42118 RVA: 0x00281894 File Offset: 0x0027FA94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x002818B8 File Offset: 0x0027FAB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x002818CF File Offset: 0x0027FACF
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x002818D9 File Offset: 0x0027FAD9
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x002818F4 File Offset: 0x0027FAF4
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x0028190C File Offset: 0x0027FB0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x0028192C File Offset: 0x0027FB2C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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

		// Token: 0x0600A48D RID: 42125 RVA: 0x0028196C File Offset: 0x0027FB6C
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

		// Token: 0x0600A48E RID: 42126 RVA: 0x002819A0 File Offset: 0x0027FBA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x002819B8 File Offset: 0x0027FBB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x002819C4 File Offset: 0x0027FBC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x002819F0 File Offset: 0x0027FBF0
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

		// Token: 0x0600A492 RID: 42130 RVA: 0x00281A24 File Offset: 0x0027FC24
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x00281A54 File Offset: 0x0027FC54
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x00281A60 File Offset: 0x0027FC60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A25 RID: 18981
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04004A26 RID: 18982
		private UnknownFieldSet _unknownFields;
	}
}

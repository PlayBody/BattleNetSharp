using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000246 RID: 582
	public sealed class LeavePartyRequest : IMessage<LeavePartyRequest>, IMessage, IEquatable<LeavePartyRequest>, IDeepCloneable<LeavePartyRequest>, IBufferMessage
	{
		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x000F6770 File Offset: 0x000F4970
		[DebuggerNonUserCode]
		public static MessageParser<LeavePartyRequest> Parser
		{
			get
			{
				return LeavePartyRequest._parser;
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x000F6788 File Offset: 0x000F4988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[54];
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06003EB9 RID: 16057 RVA: 0x000F67AC File Offset: 0x000F49AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeavePartyRequest.Descriptor;
			}
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x000F67C3 File Offset: 0x000F49C3
		[DebuggerNonUserCode]
		public LeavePartyRequest()
		{
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x000F67CD File Offset: 0x000F49CD
		[DebuggerNonUserCode]
		public LeavePartyRequest(LeavePartyRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x000F67E8 File Offset: 0x000F49E8
		[DebuggerNonUserCode]
		public LeavePartyRequest Clone()
		{
			return new LeavePartyRequest(this);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x000F6800 File Offset: 0x000F4A00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeavePartyRequest);
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x000F6820 File Offset: 0x000F4A20
		[DebuggerNonUserCode]
		public bool Equals(LeavePartyRequest other)
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

		// Token: 0x06003EBF RID: 16063 RVA: 0x000F6860 File Offset: 0x000F4A60
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

		// Token: 0x06003EC0 RID: 16064 RVA: 0x000F6894 File Offset: 0x000F4A94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x000F68AC File Offset: 0x000F4AAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x000F68B8 File Offset: 0x000F4AB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x000F68E4 File Offset: 0x000F4AE4
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

		// Token: 0x06003EC4 RID: 16068 RVA: 0x000F6918 File Offset: 0x000F4B18
		[DebuggerNonUserCode]
		public void MergeFrom(LeavePartyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x000F6948 File Offset: 0x000F4B48
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x000F6954 File Offset: 0x000F4B54
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001CAB RID: 7339
		private static readonly MessageParser<LeavePartyRequest> _parser = new MessageParser<LeavePartyRequest>(() => new LeavePartyRequest());

		// Token: 0x04001CAC RID: 7340
		private UnknownFieldSet _unknownFields;
	}
}

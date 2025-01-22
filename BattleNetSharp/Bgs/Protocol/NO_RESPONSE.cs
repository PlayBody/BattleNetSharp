using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200038A RID: 906
	public sealed class NO_RESPONSE : IMessage<NO_RESPONSE>, IMessage, IEquatable<NO_RESPONSE>, IDeepCloneable<NO_RESPONSE>, IBufferMessage
	{
		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x001641EC File Offset: 0x001623EC
		[DebuggerNonUserCode]
		public static MessageParser<NO_RESPONSE> Parser
		{
			get
			{
				return NO_RESPONSE._parser;
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06005BF7 RID: 23543 RVA: 0x00164204 File Offset: 0x00162404
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x00164228 File Offset: 0x00162428
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NO_RESPONSE.Descriptor;
			}
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x0016423F File Offset: 0x0016243F
		[DebuggerNonUserCode]
		public NO_RESPONSE()
		{
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x00164249 File Offset: 0x00162449
		[DebuggerNonUserCode]
		public NO_RESPONSE(NO_RESPONSE other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x00164264 File Offset: 0x00162464
		[DebuggerNonUserCode]
		public NO_RESPONSE Clone()
		{
			return new NO_RESPONSE(this);
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x0016427C File Offset: 0x0016247C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NO_RESPONSE);
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x0016429C File Offset: 0x0016249C
		[DebuggerNonUserCode]
		public bool Equals(NO_RESPONSE other)
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

		// Token: 0x06005BFE RID: 23550 RVA: 0x001642DC File Offset: 0x001624DC
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

		// Token: 0x06005BFF RID: 23551 RVA: 0x00164310 File Offset: 0x00162510
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x00164328 File Offset: 0x00162528
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x00164334 File Offset: 0x00162534
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x00164360 File Offset: 0x00162560
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

		// Token: 0x06005C03 RID: 23555 RVA: 0x00164394 File Offset: 0x00162594
		[DebuggerNonUserCode]
		public void MergeFrom(NO_RESPONSE other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x001643C4 File Offset: 0x001625C4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x001643D0 File Offset: 0x001625D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A0C RID: 10764
		private static readonly MessageParser<NO_RESPONSE> _parser = new MessageParser<NO_RESPONSE>(() => new NO_RESPONSE());

		// Token: 0x04002A0D RID: 10765
		private UnknownFieldSet _unknownFields;
	}
}

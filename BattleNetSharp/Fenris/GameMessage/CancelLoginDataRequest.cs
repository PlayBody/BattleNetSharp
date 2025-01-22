using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001BE RID: 446
	public sealed class CancelLoginDataRequest : IMessage<CancelLoginDataRequest>, IMessage, IEquatable<CancelLoginDataRequest>, IDeepCloneable<CancelLoginDataRequest>, IBufferMessage
	{
		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000B8188 File Offset: 0x000B6388
		[DebuggerNonUserCode]
		public static MessageParser<CancelLoginDataRequest> Parser
		{
			get
			{
				return CancelLoginDataRequest._parser;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000B81A0 File Offset: 0x000B63A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000B81C4 File Offset: 0x000B63C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelLoginDataRequest.Descriptor;
			}
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000B81DB File Offset: 0x000B63DB
		[DebuggerNonUserCode]
		public CancelLoginDataRequest()
		{
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000B81E5 File Offset: 0x000B63E5
		[DebuggerNonUserCode]
		public CancelLoginDataRequest(CancelLoginDataRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x000B8200 File Offset: 0x000B6400
		[DebuggerNonUserCode]
		public CancelLoginDataRequest Clone()
		{
			return new CancelLoginDataRequest(this);
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000B8218 File Offset: 0x000B6418
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelLoginDataRequest);
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000B8238 File Offset: 0x000B6438
		[DebuggerNonUserCode]
		public bool Equals(CancelLoginDataRequest other)
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

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000B8278 File Offset: 0x000B6478
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

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000B82AC File Offset: 0x000B64AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000B82C4 File Offset: 0x000B64C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x000B82D0 File Offset: 0x000B64D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000B82FC File Offset: 0x000B64FC
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

		// Token: 0x06002EBA RID: 11962 RVA: 0x000B8330 File Offset: 0x000B6530
		[DebuggerNonUserCode]
		public void MergeFrom(CancelLoginDataRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x000B8360 File Offset: 0x000B6560
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000B836C File Offset: 0x000B656C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400150C RID: 5388
		private static readonly MessageParser<CancelLoginDataRequest> _parser = new MessageParser<CancelLoginDataRequest>(() => new CancelLoginDataRequest());

		// Token: 0x0400150D RID: 5389
		private UnknownFieldSet _unknownFields;
	}
}

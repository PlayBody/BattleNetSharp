using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028F RID: 655
	public sealed class UpdateSessionKey : IMessage<UpdateSessionKey>, IMessage, IEquatable<UpdateSessionKey>, IDeepCloneable<UpdateSessionKey>, IBufferMessage
	{
		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x0010B788 File Offset: 0x00109988
		[DebuggerNonUserCode]
		public static MessageParser<UpdateSessionKey> Parser
		{
			get
			{
				return UpdateSessionKey._parser;
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x0010B7A0 File Offset: 0x001099A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[127];
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x0010B7C4 File Offset: 0x001099C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSessionKey.Descriptor;
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0010B7DB File Offset: 0x001099DB
		[DebuggerNonUserCode]
		public UpdateSessionKey()
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x0010B7E5 File Offset: 0x001099E5
		[DebuggerNonUserCode]
		public UpdateSessionKey(UpdateSessionKey other)
			: this()
		{
			this.newSessionKey_ = other.newSessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x0010B80C File Offset: 0x00109A0C
		[DebuggerNonUserCode]
		public UpdateSessionKey Clone()
		{
			return new UpdateSessionKey(this);
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x0010B824 File Offset: 0x00109A24
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x0010B845 File Offset: 0x00109A45
		[DebuggerNonUserCode]
		public ByteString NewSessionKey
		{
			get
			{
				return this.newSessionKey_ ?? UpdateSessionKey.NewSessionKeyDefaultValue;
			}
			set
			{
				this.newSessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x0010B85C File Offset: 0x00109A5C
		[DebuggerNonUserCode]
		public bool HasNewSessionKey
		{
			get
			{
				return this.newSessionKey_ != null;
			}
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x0010B87A File Offset: 0x00109A7A
		[DebuggerNonUserCode]
		public void ClearNewSessionKey()
		{
			this.newSessionKey_ = null;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x0010B884 File Offset: 0x00109A84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSessionKey);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x0010B8A4 File Offset: 0x00109AA4
		[DebuggerNonUserCode]
		public bool Equals(UpdateSessionKey other)
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
					bool flag4 = this.NewSessionKey != other.NewSessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x0010B8FC File Offset: 0x00109AFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				num ^= this.NewSessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x0010B948 File Offset: 0x00109B48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x0010B960 File Offset: 0x00109B60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x0010B96C File Offset: 0x00109B6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.NewSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x0010B9B8 File Offset: 0x00109BB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNewSessionKey = this.HasNewSessionKey;
			if (hasNewSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.NewSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x0010BA08 File Offset: 0x00109C08
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateSessionKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNewSessionKey = other.HasNewSessionKey;
				if (hasNewSessionKey)
				{
					this.NewSessionKey = other.NewSessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x0010BA51 File Offset: 0x00109C51
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x0010BA5C File Offset: 0x00109C5C
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
					this.NewSessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001F1C RID: 7964
		private static readonly MessageParser<UpdateSessionKey> _parser = new MessageParser<UpdateSessionKey>(() => new UpdateSessionKey());

		// Token: 0x04001F1D RID: 7965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F1E RID: 7966
		public const int NewSessionKeyFieldNumber = 1;

		// Token: 0x04001F1F RID: 7967
		private static readonly ByteString NewSessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F20 RID: 7968
		private ByteString newSessionKey_;
	}
}

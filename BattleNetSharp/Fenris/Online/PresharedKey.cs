using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000141 RID: 321
	public sealed class PresharedKey : IMessage<PresharedKey>, IMessage, IEquatable<PresharedKey>, IDeepCloneable<PresharedKey>, IBufferMessage
	{
		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0008178C File Offset: 0x0007F98C
		[DebuggerNonUserCode]
		public static MessageParser<PresharedKey> Parser
		{
			get
			{
				return PresharedKey._parser;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x000817A4 File Offset: 0x0007F9A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000817C8 File Offset: 0x0007F9C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresharedKey.Descriptor;
			}
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000817DF File Offset: 0x0007F9DF
		[DebuggerNonUserCode]
		public PresharedKey()
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000817E9 File Offset: 0x0007F9E9
		[DebuggerNonUserCode]
		public PresharedKey(PresharedKey other)
			: this()
		{
			this.modulus_ = other.modulus_;
			this.exponent_ = other.exponent_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0008181C File Offset: 0x0007FA1C
		[DebuggerNonUserCode]
		public PresharedKey Clone()
		{
			return new PresharedKey(this);
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x00081834 File Offset: 0x0007FA34
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x00081855 File Offset: 0x0007FA55
		[DebuggerNonUserCode]
		public ByteString Modulus
		{
			get
			{
				return this.modulus_ ?? PresharedKey.ModulusDefaultValue;
			}
			set
			{
				this.modulus_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x0008186C File Offset: 0x0007FA6C
		[DebuggerNonUserCode]
		public bool HasModulus
		{
			get
			{
				return this.modulus_ != null;
			}
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0008188A File Offset: 0x0007FA8A
		[DebuggerNonUserCode]
		public void ClearModulus()
		{
			this.modulus_ = null;
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x00081894 File Offset: 0x0007FA94
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x000818B5 File Offset: 0x0007FAB5
		[DebuggerNonUserCode]
		public ByteString Exponent
		{
			get
			{
				return this.exponent_ ?? PresharedKey.ExponentDefaultValue;
			}
			set
			{
				this.exponent_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000818CC File Offset: 0x0007FACC
		[DebuggerNonUserCode]
		public bool HasExponent
		{
			get
			{
				return this.exponent_ != null;
			}
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000818EA File Offset: 0x0007FAEA
		[DebuggerNonUserCode]
		public void ClearExponent()
		{
			this.exponent_ = null;
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000818F4 File Offset: 0x0007FAF4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresharedKey);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00081914 File Offset: 0x0007FB14
		[DebuggerNonUserCode]
		public bool Equals(PresharedKey other)
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
					bool flag4 = this.Modulus != other.Modulus;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Exponent != other.Exponent;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00081988 File Offset: 0x0007FB88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasModulus = this.HasModulus;
			if (hasModulus)
			{
				num ^= this.Modulus.GetHashCode();
			}
			bool hasExponent = this.HasExponent;
			if (hasExponent)
			{
				num ^= this.Exponent.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000819EC File Offset: 0x0007FBEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00081A04 File Offset: 0x0007FC04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00081A10 File Offset: 0x0007FC10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasModulus = this.HasModulus;
			if (hasModulus)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Modulus);
			}
			bool hasExponent = this.HasExponent;
			if (hasExponent)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Exponent);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00081A80 File Offset: 0x0007FC80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasModulus = this.HasModulus;
			if (hasModulus)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Modulus);
			}
			bool hasExponent = this.HasExponent;
			if (hasExponent)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Exponent);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00081AEC File Offset: 0x0007FCEC
		[DebuggerNonUserCode]
		public void MergeFrom(PresharedKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasModulus = other.HasModulus;
				if (hasModulus)
				{
					this.Modulus = other.Modulus;
				}
				bool hasExponent = other.HasExponent;
				if (hasExponent)
				{
					this.Exponent = other.Exponent;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x00081B4E File Offset: 0x0007FD4E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00081B5C File Offset: 0x0007FD5C
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Exponent = input.ReadBytes();
					}
				}
				else
				{
					this.Modulus = input.ReadBytes();
				}
			}
		}

		// Token: 0x04000EA4 RID: 3748
		private static readonly MessageParser<PresharedKey> _parser = new MessageParser<PresharedKey>(() => new PresharedKey());

		// Token: 0x04000EA5 RID: 3749
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EA6 RID: 3750
		public const int ModulusFieldNumber = 1;

		// Token: 0x04000EA7 RID: 3751
		private static readonly ByteString ModulusDefaultValue = ByteString.Empty;

		// Token: 0x04000EA8 RID: 3752
		private ByteString modulus_;

		// Token: 0x04000EA9 RID: 3753
		public const int ExponentFieldNumber = 2;

		// Token: 0x04000EAA RID: 3754
		private static readonly ByteString ExponentDefaultValue = ByteString.Empty;

		// Token: 0x04000EAB RID: 3755
		private ByteString exponent_;
	}
}

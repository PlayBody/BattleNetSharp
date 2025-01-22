using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200036A RID: 874
	public sealed class MessageFieldRestriction : IMessage<MessageFieldRestriction>, IMessage, IEquatable<MessageFieldRestriction>, IDeepCloneable<MessageFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x0015C92C File Offset: 0x0015AB2C
		[DebuggerNonUserCode]
		public static MessageParser<MessageFieldRestriction> Parser
		{
			get
			{
				return MessageFieldRestriction._parser;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06005A0B RID: 23051 RVA: 0x0015C944 File Offset: 0x0015AB44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x0015C968 File Offset: 0x0015AB68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MessageFieldRestriction.Descriptor;
			}
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x0015C97F File Offset: 0x0015AB7F
		[DebuggerNonUserCode]
		public MessageFieldRestriction()
		{
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0015C989 File Offset: 0x0015AB89
		[DebuggerNonUserCode]
		public MessageFieldRestriction(MessageFieldRestriction other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.needed_ = other.needed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x0015C9BC File Offset: 0x0015ABBC
		[DebuggerNonUserCode]
		public MessageFieldRestriction Clone()
		{
			return new MessageFieldRestriction(this);
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x0015C9D4 File Offset: 0x0015ABD4
		// (set) Token: 0x06005A11 RID: 23057 RVA: 0x0015CA05 File Offset: 0x0015AC05
		[DebuggerNonUserCode]
		public bool Needed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool neededDefaultValue;
				if (flag)
				{
					neededDefaultValue = this.needed_;
				}
				else
				{
					neededDefaultValue = MessageFieldRestriction.NeededDefaultValue;
				}
				return neededDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.needed_ = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x0015CA20 File Offset: 0x0015AC20
		[DebuggerNonUserCode]
		public bool HasNeeded
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x0015CA3D File Offset: 0x0015AC3D
		[DebuggerNonUserCode]
		public void ClearNeeded()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x0015CA50 File Offset: 0x0015AC50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MessageFieldRestriction);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x0015CA70 File Offset: 0x0015AC70
		[DebuggerNonUserCode]
		public bool Equals(MessageFieldRestriction other)
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
					bool flag4 = this.Needed != other.Needed;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0015CAC8 File Offset: 0x0015ACC8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				num ^= this.Needed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0015CB18 File Offset: 0x0015AD18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x0015CB30 File Offset: 0x0015AD30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x0015CB3C File Offset: 0x0015AD3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Needed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x0015CB88 File Offset: 0x0015AD88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNeeded = this.HasNeeded;
			if (hasNeeded)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x0015CBCC File Offset: 0x0015ADCC
		[DebuggerNonUserCode]
		public void MergeFrom(MessageFieldRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNeeded = other.HasNeeded;
				if (hasNeeded)
				{
					this.Needed = other.Needed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x0015CC15 File Offset: 0x0015AE15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x0015CC20 File Offset: 0x0015AE20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Needed = input.ReadBool();
				}
			}
		}

		// Token: 0x04002903 RID: 10499
		private static readonly MessageParser<MessageFieldRestriction> _parser = new MessageParser<MessageFieldRestriction>(() => new MessageFieldRestriction());

		// Token: 0x04002904 RID: 10500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002905 RID: 10501
		private int _hasBits0;

		// Token: 0x04002906 RID: 10502
		public const int NeededFieldNumber = 1;

		// Token: 0x04002907 RID: 10503
		private static readonly bool NeededDefaultValue = false;

		// Token: 0x04002908 RID: 10504
		private bool needed_;
	}
}

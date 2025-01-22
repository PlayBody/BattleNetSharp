using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000293 RID: 659
	public sealed class PartyJoinFailed : IMessage<PartyJoinFailed>, IMessage, IEquatable<PartyJoinFailed>, IDeepCloneable<PartyJoinFailed>, IBufferMessage
	{
		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x0010C524 File Offset: 0x0010A724
		[DebuggerNonUserCode]
		public static MessageParser<PartyJoinFailed> Parser
		{
			get
			{
				return PartyJoinFailed._parser;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x0010C53C File Offset: 0x0010A73C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[131];
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x0010C564 File Offset: 0x0010A764
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyJoinFailed.Descriptor;
			}
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x0010C57B File Offset: 0x0010A77B
		[DebuggerNonUserCode]
		public PartyJoinFailed()
		{
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x0010C585 File Offset: 0x0010A785
		[DebuggerNonUserCode]
		public PartyJoinFailed(PartyJoinFailed other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x0010C5B8 File Offset: 0x0010A7B8
		[DebuggerNonUserCode]
		public PartyJoinFailed Clone()
		{
			return new PartyJoinFailed(this);
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x0010C5D0 File Offset: 0x0010A7D0
		// (set) Token: 0x060045F9 RID: 17913 RVA: 0x0010C601 File Offset: 0x0010A801
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = PartyJoinFailed.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x0010C61C File Offset: 0x0010A81C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x0010C639 File Offset: 0x0010A839
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x0010C64C File Offset: 0x0010A84C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyJoinFailed);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0010C66C File Offset: 0x0010A86C
		[DebuggerNonUserCode]
		public bool Equals(PartyJoinFailed other)
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
					bool flag4 = this.Reason != other.Reason;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x0010C6C4 File Offset: 0x0010A8C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x0010C714 File Offset: 0x0010A914
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x0010C72C File Offset: 0x0010A92C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x0010C738 File Offset: 0x0010A938
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x0010C784 File Offset: 0x0010A984
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0010C7D4 File Offset: 0x0010A9D4
		[DebuggerNonUserCode]
		public void MergeFrom(PartyJoinFailed other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0010C81D File Offset: 0x0010AA1D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0010C828 File Offset: 0x0010AA28
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
					this.Reason = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly MessageParser<PartyJoinFailed> _parser = new MessageParser<PartyJoinFailed>(() => new PartyJoinFailed());

		// Token: 0x04001F30 RID: 7984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F31 RID: 7985
		private int _hasBits0;

		// Token: 0x04001F32 RID: 7986
		public const int ReasonFieldNumber = 1;

		// Token: 0x04001F33 RID: 7987
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04001F34 RID: 7988
		private uint reason_;
	}
}

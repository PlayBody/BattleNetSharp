using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000262 RID: 610
	public sealed class PartyLockStateChanged : IMessage<PartyLockStateChanged>, IMessage, IEquatable<PartyLockStateChanged>, IDeepCloneable<PartyLockStateChanged>, IBufferMessage
	{
		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x000FF600 File Offset: 0x000FD800
		[DebuggerNonUserCode]
		public static MessageParser<PartyLockStateChanged> Parser
		{
			get
			{
				return PartyLockStateChanged._parser;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x000FF618 File Offset: 0x000FD818
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[82];
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x000FF63C File Offset: 0x000FD83C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyLockStateChanged.Descriptor;
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000FF653 File Offset: 0x000FD853
		[DebuggerNonUserCode]
		public PartyLockStateChanged()
		{
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x000FF65D File Offset: 0x000FD85D
		[DebuggerNonUserCode]
		public PartyLockStateChanged(PartyLockStateChanged other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.isLocked_ = other.isLocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x000FF69C File Offset: 0x000FD89C
		[DebuggerNonUserCode]
		public PartyLockStateChanged Clone()
		{
			return new PartyLockStateChanged(this);
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600418F RID: 16783 RVA: 0x000FF6B4 File Offset: 0x000FD8B4
		// (set) Token: 0x06004190 RID: 16784 RVA: 0x000FF6D5 File Offset: 0x000FD8D5
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyLockStateChanged.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x000FF6EC File Offset: 0x000FD8EC
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x000FF707 File Offset: 0x000FD907
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06004193 RID: 16787 RVA: 0x000FF714 File Offset: 0x000FD914
		// (set) Token: 0x06004194 RID: 16788 RVA: 0x000FF745 File Offset: 0x000FD945
		[DebuggerNonUserCode]
		public bool IsLocked
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool isLockedDefaultValue;
				if (flag)
				{
					isLockedDefaultValue = this.isLocked_;
				}
				else
				{
					isLockedDefaultValue = PartyLockStateChanged.IsLockedDefaultValue;
				}
				return isLockedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.isLocked_ = value;
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06004195 RID: 16789 RVA: 0x000FF760 File Offset: 0x000FD960
		[DebuggerNonUserCode]
		public bool HasIsLocked
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000FF77D File Offset: 0x000FD97D
		[DebuggerNonUserCode]
		public void ClearIsLocked()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x000FF790 File Offset: 0x000FD990
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyLockStateChanged);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x000FF7B0 File Offset: 0x000FD9B0
		[DebuggerNonUserCode]
		public bool Equals(PartyLockStateChanged other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IsLocked != other.IsLocked;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x000FF824 File Offset: 0x000FDA24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
			{
				num ^= this.IsLocked.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x000FF890 File Offset: 0x000FDA90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x000FF8A8 File Offset: 0x000FDAA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x000FF8B4 File Offset: 0x000FDAB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsLocked);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x000FF924 File Offset: 0x000FDB24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasIsLocked = this.HasIsLocked;
			if (hasIsLocked)
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

		// Token: 0x0600419E RID: 16798 RVA: 0x000FF984 File Offset: 0x000FDB84
		[DebuggerNonUserCode]
		public void MergeFrom(PartyLockStateChanged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasIsLocked = other.HasIsLocked;
				if (hasIsLocked)
				{
					this.IsLocked = other.IsLocked;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x000FF9E6 File Offset: 0x000FDBE6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x000FF9F4 File Offset: 0x000FDBF4
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsLocked = input.ReadBool();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DBB RID: 7611
		private static readonly MessageParser<PartyLockStateChanged> _parser = new MessageParser<PartyLockStateChanged>(() => new PartyLockStateChanged());

		// Token: 0x04001DBC RID: 7612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DBD RID: 7613
		private int _hasBits0;

		// Token: 0x04001DBE RID: 7614
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001DBF RID: 7615
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001DC0 RID: 7616
		private string partyId_;

		// Token: 0x04001DC1 RID: 7617
		public const int IsLockedFieldNumber = 2;

		// Token: 0x04001DC2 RID: 7618
		private static readonly bool IsLockedDefaultValue = false;

		// Token: 0x04001DC3 RID: 7619
		private bool isLocked_;
	}
}

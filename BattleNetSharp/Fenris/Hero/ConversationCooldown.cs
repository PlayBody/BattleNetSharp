using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200019E RID: 414
	public sealed class ConversationCooldown : IMessage<ConversationCooldown>, IMessage, IEquatable<ConversationCooldown>, IDeepCloneable<ConversationCooldown>, IBufferMessage
	{
		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000AC4B8 File Offset: 0x000AA6B8
		[DebuggerNonUserCode]
		public static MessageParser<ConversationCooldown> Parser
		{
			get
			{
				return ConversationCooldown._parser;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000AC4D0 File Offset: 0x000AA6D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConversationCooldown.Descriptor;
			}
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000AC50B File Offset: 0x000AA70B
		[DebuggerNonUserCode]
		public ConversationCooldown()
		{
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000AC515 File Offset: 0x000AA715
		[DebuggerNonUserCode]
		public ConversationCooldown(ConversationCooldown other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoConversation_ = other.snoConversation_;
			this.expirationTime_ = other.expirationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000AC554 File Offset: 0x000AA754
		[DebuggerNonUserCode]
		public ConversationCooldown Clone()
		{
			return new ConversationCooldown(this);
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000AC56C File Offset: 0x000AA76C
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x000AC59D File Offset: 0x000AA79D
		[DebuggerNonUserCode]
		public int SnoConversation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoConversationDefaultValue;
				if (flag)
				{
					snoConversationDefaultValue = this.snoConversation_;
				}
				else
				{
					snoConversationDefaultValue = ConversationCooldown.SnoConversationDefaultValue;
				}
				return snoConversationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoConversation_ = value;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000AC5B8 File Offset: 0x000AA7B8
		[DebuggerNonUserCode]
		public bool HasSnoConversation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000AC5D5 File Offset: 0x000AA7D5
		[DebuggerNonUserCode]
		public void ClearSnoConversation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000AC5E8 File Offset: 0x000AA7E8
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x000AC619 File Offset: 0x000AA819
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = ConversationCooldown.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x000AC634 File Offset: 0x000AA834
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000AC651 File Offset: 0x000AA851
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000AC664 File Offset: 0x000AA864
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConversationCooldown);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000AC684 File Offset: 0x000AA884
		[DebuggerNonUserCode]
		public bool Equals(ConversationCooldown other)
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
					bool flag4 = this.SnoConversation != other.SnoConversation;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ExpirationTime != other.ExpirationTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000AC6F8 File Offset: 0x000AA8F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				num ^= this.SnoConversation.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000AC768 File Offset: 0x000AA968
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000AC780 File Offset: 0x000AA980
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000AC78C File Offset: 0x000AA98C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoConversation);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000AC7FC File Offset: 0x000AA9FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoConversation = this.HasSnoConversation;
			if (hasSnoConversation)
			{
				num += 5;
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000AC85C File Offset: 0x000AAA5C
		[DebuggerNonUserCode]
		public void MergeFrom(ConversationCooldown other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoConversation = other.HasSnoConversation;
				if (hasSnoConversation)
				{
					this.SnoConversation = other.SnoConversation;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000AC8BE File Offset: 0x000AAABE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000AC8CC File Offset: 0x000AAACC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExpirationTime = input.ReadUInt64();
					}
				}
				else
				{
					this.SnoConversation = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040013CE RID: 5070
		private static readonly MessageParser<ConversationCooldown> _parser = new MessageParser<ConversationCooldown>(() => new ConversationCooldown());

		// Token: 0x040013CF RID: 5071
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013D0 RID: 5072
		private int _hasBits0;

		// Token: 0x040013D1 RID: 5073
		public const int SnoConversationFieldNumber = 1;

		// Token: 0x040013D2 RID: 5074
		private static readonly int SnoConversationDefaultValue = 0;

		// Token: 0x040013D3 RID: 5075
		private int snoConversation_;

		// Token: 0x040013D4 RID: 5076
		public const int ExpirationTimeFieldNumber = 2;

		// Token: 0x040013D5 RID: 5077
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x040013D6 RID: 5078
		private ulong expirationTime_;
	}
}

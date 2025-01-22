using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000731 RID: 1841
	public sealed class AccountLicense : IMessage<AccountLicense>, IMessage, IEquatable<AccountLicense>, IDeepCloneable<AccountLicense>, IBufferMessage
	{
		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600A84E RID: 43086 RVA: 0x00290298 File Offset: 0x0028E498
		[DebuggerNonUserCode]
		public static MessageParser<AccountLicense> Parser
		{
			get
			{
				return AccountLicense._parser;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600A84F RID: 43087 RVA: 0x002902B0 File Offset: 0x0028E4B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600A850 RID: 43088 RVA: 0x002902D4 File Offset: 0x0028E4D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccountLicense.Descriptor;
			}
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x002902EB File Offset: 0x0028E4EB
		[DebuggerNonUserCode]
		public AccountLicense()
		{
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x002902F5 File Offset: 0x0028E4F5
		[DebuggerNonUserCode]
		public AccountLicense(AccountLicense other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.expires_ = other.expires_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x00290334 File Offset: 0x0028E534
		[DebuggerNonUserCode]
		public AccountLicense Clone()
		{
			return new AccountLicense(this);
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600A854 RID: 43092 RVA: 0x0029034C File Offset: 0x0028E54C
		// (set) Token: 0x0600A855 RID: 43093 RVA: 0x0029037D File Offset: 0x0028E57D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = AccountLicense.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600A856 RID: 43094 RVA: 0x00290398 File Offset: 0x0028E598
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x002903B5 File Offset: 0x0028E5B5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600A858 RID: 43096 RVA: 0x002903C8 File Offset: 0x0028E5C8
		// (set) Token: 0x0600A859 RID: 43097 RVA: 0x002903F9 File Offset: 0x0028E5F9
		[DebuggerNonUserCode]
		public ulong Expires
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong expiresDefaultValue;
				if (flag)
				{
					expiresDefaultValue = this.expires_;
				}
				else
				{
					expiresDefaultValue = AccountLicense.ExpiresDefaultValue;
				}
				return expiresDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.expires_ = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600A85A RID: 43098 RVA: 0x00290414 File Offset: 0x0028E614
		[DebuggerNonUserCode]
		public bool HasExpires
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A85B RID: 43099 RVA: 0x00290431 File Offset: 0x0028E631
		[DebuggerNonUserCode]
		public void ClearExpires()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A85C RID: 43100 RVA: 0x00290444 File Offset: 0x0028E644
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccountLicense);
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x00290464 File Offset: 0x0028E664
		[DebuggerNonUserCode]
		public bool Equals(AccountLicense other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Expires != other.Expires;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x002904D8 File Offset: 0x0028E6D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasExpires = this.HasExpires;
			if (hasExpires)
			{
				num ^= this.Expires.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x00290548 File Offset: 0x0028E748
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x00290560 File Offset: 0x0028E760
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x0029056C File Offset: 0x0028E76C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasExpires = this.HasExpires;
			if (hasExpires)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Expires);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x002905DC File Offset: 0x0028E7DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasExpires = this.HasExpires;
			if (hasExpires)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Expires);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x00290648 File Offset: 0x0028E848
		[DebuggerNonUserCode]
		public void MergeFrom(AccountLicense other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasExpires = other.HasExpires;
				if (hasExpires)
				{
					this.Expires = other.Expires;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x002906AA File Offset: 0x0028E8AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x002906B8 File Offset: 0x0028E8B8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Expires = input.ReadUInt64();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004BA7 RID: 19367
		private static readonly MessageParser<AccountLicense> _parser = new MessageParser<AccountLicense>(() => new AccountLicense());

		// Token: 0x04004BA8 RID: 19368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BA9 RID: 19369
		private int _hasBits0;

		// Token: 0x04004BAA RID: 19370
		public const int IdFieldNumber = 1;

		// Token: 0x04004BAB RID: 19371
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04004BAC RID: 19372
		private uint id_;

		// Token: 0x04004BAD RID: 19373
		public const int ExpiresFieldNumber = 2;

		// Token: 0x04004BAE RID: 19374
		private static readonly ulong ExpiresDefaultValue = 0UL;

		// Token: 0x04004BAF RID: 19375
		private ulong expires_;
	}
}

using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000152 RID: 338
	public sealed class ClanUGCReset : IMessage<ClanUGCReset>, IMessage, IEquatable<ClanUGCReset>, IDeepCloneable<ClanUGCReset>, IBufferMessage
	{
		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x00087E40 File Offset: 0x00086040
		[DebuggerNonUserCode]
		public static MessageParser<ClanUGCReset> Parser
		{
			get
			{
				return ClanUGCReset._parser;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00087E58 File Offset: 0x00086058
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00087E7C File Offset: 0x0008607C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanUGCReset.Descriptor;
			}
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00087E93 File Offset: 0x00086093
		[DebuggerNonUserCode]
		public ClanUGCReset()
		{
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00087E9D File Offset: 0x0008609D
		[DebuggerNonUserCode]
		public ClanUGCReset(ClanUGCReset other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.contentType_ = other.contentType_;
			this.clanName_ = other.clanName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x00087EDC File Offset: 0x000860DC
		[DebuggerNonUserCode]
		public ClanUGCReset Clone()
		{
			return new ClanUGCReset(this);
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x00087EF4 File Offset: 0x000860F4
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x00087F25 File Offset: 0x00086125
		[DebuggerNonUserCode]
		public ClanContentType ContentType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ClanContentType contentTypeDefaultValue;
				if (flag)
				{
					contentTypeDefaultValue = this.contentType_;
				}
				else
				{
					contentTypeDefaultValue = ClanUGCReset.ContentTypeDefaultValue;
				}
				return contentTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.contentType_ = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x00087F40 File Offset: 0x00086140
		[DebuggerNonUserCode]
		public bool HasContentType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00087F5D File Offset: 0x0008615D
		[DebuggerNonUserCode]
		public void ClearContentType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x00087F70 File Offset: 0x00086170
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x00087F91 File Offset: 0x00086191
		[DebuggerNonUserCode]
		public string ClanName
		{
			get
			{
				return this.clanName_ ?? ClanUGCReset.ClanNameDefaultValue;
			}
			set
			{
				this.clanName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x00087FA8 File Offset: 0x000861A8
		[DebuggerNonUserCode]
		public bool HasClanName
		{
			get
			{
				return this.clanName_ != null;
			}
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x00087FC3 File Offset: 0x000861C3
		[DebuggerNonUserCode]
		public void ClearClanName()
		{
			this.clanName_ = null;
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00087FD0 File Offset: 0x000861D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanUGCReset);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00087FF0 File Offset: 0x000861F0
		[DebuggerNonUserCode]
		public bool Equals(ClanUGCReset other)
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
					bool flag4 = this.ContentType != other.ContentType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClanName != other.ClanName;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00088064 File Offset: 0x00086264
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContentType = this.HasContentType;
			if (hasContentType)
			{
				num ^= this.ContentType.GetHashCode();
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num ^= this.ClanName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000880D4 File Offset: 0x000862D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000880EC File Offset: 0x000862EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000880F8 File Offset: 0x000862F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContentType = this.HasContentType;
			if (hasContentType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ContentType);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClanName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00088168 File Offset: 0x00086368
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContentType = this.HasContentType;
			if (hasContentType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ContentType);
			}
			bool hasClanName = this.HasClanName;
			if (hasClanName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000881D4 File Offset: 0x000863D4
		[DebuggerNonUserCode]
		public void MergeFrom(ClanUGCReset other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContentType = other.HasContentType;
				if (hasContentType)
				{
					this.ContentType = other.ContentType;
				}
				bool hasClanName = other.HasClanName;
				if (hasClanName)
				{
					this.ClanName = other.ClanName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00088236 File Offset: 0x00086436
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00088244 File Offset: 0x00086444
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ClanName = input.ReadString();
					}
				}
				else
				{
					this.ContentType = (ClanContentType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000F62 RID: 3938
		private static readonly MessageParser<ClanUGCReset> _parser = new MessageParser<ClanUGCReset>(() => new ClanUGCReset());

		// Token: 0x04000F63 RID: 3939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F64 RID: 3940
		private int _hasBits0;

		// Token: 0x04000F65 RID: 3941
		public const int ContentTypeFieldNumber = 1;

		// Token: 0x04000F66 RID: 3942
		private static readonly ClanContentType ContentTypeDefaultValue = ClanContentType.InvalidType;

		// Token: 0x04000F67 RID: 3943
		private ClanContentType contentType_;

		// Token: 0x04000F68 RID: 3944
		public const int ClanNameFieldNumber = 2;

		// Token: 0x04000F69 RID: 3945
		private static readonly string ClanNameDefaultValue = "";

		// Token: 0x04000F6A RID: 3946
		private string clanName_;
	}
}

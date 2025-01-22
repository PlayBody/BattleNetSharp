using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000572 RID: 1394
	public sealed class SessionKey : IMessage<SessionKey>, IMessage, IEquatable<SessionKey>, IDeepCloneable<SessionKey>, IBufferMessage
	{
		// Token: 0x17002A51 RID: 10833
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x002097C8 File Offset: 0x002079C8
		[DebuggerNonUserCode]
		public static MessageParser<SessionKey> Parser
		{
			get
			{
				return SessionKey._parser;
			}
		}

		// Token: 0x17002A52 RID: 10834
		// (get) Token: 0x06008634 RID: 34356 RVA: 0x002097E0 File Offset: 0x002079E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002A53 RID: 10835
		// (get) Token: 0x06008635 RID: 34357 RVA: 0x00209804 File Offset: 0x00207A04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionKey.Descriptor;
			}
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x0020981B File Offset: 0x00207A1B
		[DebuggerNonUserCode]
		public SessionKey()
		{
		}

		// Token: 0x06008637 RID: 34359 RVA: 0x00209825 File Offset: 0x00207A25
		[DebuggerNonUserCode]
		public SessionKey(SessionKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = other.key_;
			this.expirationS_ = other.expirationS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x00209864 File Offset: 0x00207A64
		[DebuggerNonUserCode]
		public SessionKey Clone()
		{
			return new SessionKey(this);
		}

		// Token: 0x17002A54 RID: 10836
		// (get) Token: 0x06008639 RID: 34361 RVA: 0x0020987C File Offset: 0x00207A7C
		// (set) Token: 0x0600863A RID: 34362 RVA: 0x0020989D File Offset: 0x00207A9D
		[DebuggerNonUserCode]
		public ByteString Key
		{
			get
			{
				return this.key_ ?? SessionKey.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x002098B4 File Offset: 0x00207AB4
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600863C RID: 34364 RVA: 0x002098D2 File Offset: 0x00207AD2
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x17002A56 RID: 10838
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x002098DC File Offset: 0x00207ADC
		// (set) Token: 0x0600863E RID: 34366 RVA: 0x0020990D File Offset: 0x00207B0D
		[DebuggerNonUserCode]
		public ulong ExpirationS
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong expirationSDefaultValue;
				if (flag)
				{
					expirationSDefaultValue = this.expirationS_;
				}
				else
				{
					expirationSDefaultValue = SessionKey.ExpirationSDefaultValue;
				}
				return expirationSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.expirationS_ = value;
			}
		}

		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x00209928 File Offset: 0x00207B28
		[DebuggerNonUserCode]
		public bool HasExpirationS
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x00209945 File Offset: 0x00207B45
		[DebuggerNonUserCode]
		public void ClearExpirationS()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x00209958 File Offset: 0x00207B58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionKey);
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00209978 File Offset: 0x00207B78
		[DebuggerNonUserCode]
		public bool Equals(SessionKey other)
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
					bool flag4 = this.Key != other.Key;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ExpirationS != other.ExpirationS;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x002099EC File Offset: 0x00207BEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasExpirationS = this.HasExpirationS;
			if (hasExpirationS)
			{
				num ^= this.ExpirationS.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00209A58 File Offset: 0x00207C58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00209A70 File Offset: 0x00207C70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x00209A7C File Offset: 0x00207C7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Key);
			}
			bool hasExpirationS = this.HasExpirationS;
			if (hasExpirationS)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ExpirationS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x00209AEC File Offset: 0x00207CEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Key);
			}
			bool hasExpirationS = this.HasExpirationS;
			if (hasExpirationS)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x00209B58 File Offset: 0x00207D58
		[DebuggerNonUserCode]
		public void MergeFrom(SessionKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasExpirationS = other.HasExpirationS;
				if (hasExpirationS)
				{
					this.ExpirationS = other.ExpirationS;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x00209BBA File Offset: 0x00207DBA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00209BC8 File Offset: 0x00207DC8
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
						this.ExpirationS = input.ReadUInt64();
					}
				}
				else
				{
					this.Key = input.ReadBytes();
				}
			}
		}

		// Token: 0x04003CD8 RID: 15576
		private static readonly MessageParser<SessionKey> _parser = new MessageParser<SessionKey>(() => new SessionKey());

		// Token: 0x04003CD9 RID: 15577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CDA RID: 15578
		private int _hasBits0;

		// Token: 0x04003CDB RID: 15579
		public const int KeyFieldNumber = 1;

		// Token: 0x04003CDC RID: 15580
		private static readonly ByteString KeyDefaultValue = ByteString.Empty;

		// Token: 0x04003CDD RID: 15581
		private ByteString key_;

		// Token: 0x04003CDE RID: 15582
		public const int ExpirationSFieldNumber = 2;

		// Token: 0x04003CDF RID: 15583
		private static readonly ulong ExpirationSDefaultValue = 0UL;

		// Token: 0x04003CE0 RID: 15584
		private ulong expirationS_;
	}
}

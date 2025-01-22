using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000157 RID: 343
	public sealed class PlatformAccount : IMessage<PlatformAccount>, IMessage, IEquatable<PlatformAccount>, IDeepCloneable<PlatformAccount>, IBufferMessage
	{
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x00089D44 File Offset: 0x00087F44
		[DebuggerNonUserCode]
		public static MessageParser<PlatformAccount> Parser
		{
			get
			{
				return PlatformAccount._parser;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x00089D5C File Offset: 0x00087F5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineCommonReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x00089D80 File Offset: 0x00087F80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlatformAccount.Descriptor;
			}
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00089D97 File Offset: 0x00087F97
		[DebuggerNonUserCode]
		public PlatformAccount()
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00089DA1 File Offset: 0x00087FA1
		[DebuggerNonUserCode]
		public PlatformAccount(PlatformAccount other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.platform_ = other.platform_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00089DE0 File Offset: 0x00087FE0
		[DebuggerNonUserCode]
		public PlatformAccount Clone()
		{
			return new PlatformAccount(this);
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x00089DF8 File Offset: 0x00087FF8
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x00089E29 File Offset: 0x00088029
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = PlatformAccount.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x00089E44 File Offset: 0x00088044
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00089E61 File Offset: 0x00088061
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x00089E74 File Offset: 0x00088074
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00089EA5 File Offset: 0x000880A5
		[DebuggerNonUserCode]
		public uint Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = PlatformAccount.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.platform_ = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x00089EC0 File Offset: 0x000880C0
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00089EDD File Offset: 0x000880DD
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00089EF0 File Offset: 0x000880F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlatformAccount);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00089F10 File Offset: 0x00088110
		[DebuggerNonUserCode]
		public bool Equals(PlatformAccount other)
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
						bool flag5 = this.Platform != other.Platform;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00089F84 File Offset: 0x00088184
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00089FF4 File Offset: 0x000881F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0008A00C File Offset: 0x0008820C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0008A018 File Offset: 0x00088218
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Platform);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0008A088 File Offset: 0x00088288
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Platform);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0008A0F4 File Offset: 0x000882F4
		[DebuggerNonUserCode]
		public void MergeFrom(PlatformAccount other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0008A156 File Offset: 0x00088356
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0008A164 File Offset: 0x00088364
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
						this.Platform = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04000F9A RID: 3994
		private static readonly MessageParser<PlatformAccount> _parser = new MessageParser<PlatformAccount>(() => new PlatformAccount());

		// Token: 0x04000F9B RID: 3995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F9C RID: 3996
		private int _hasBits0;

		// Token: 0x04000F9D RID: 3997
		public const int IdFieldNumber = 1;

		// Token: 0x04000F9E RID: 3998
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04000F9F RID: 3999
		private ulong id_;

		// Token: 0x04000FA0 RID: 4000
		public const int PlatformFieldNumber = 2;

		// Token: 0x04000FA1 RID: 4001
		private static readonly uint PlatformDefaultValue = 0U;

		// Token: 0x04000FA2 RID: 4002
		private uint platform_;
	}
}

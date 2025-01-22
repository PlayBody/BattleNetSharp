using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A1 RID: 673
	public sealed class UnbanPlayer : IMessage<UnbanPlayer>, IMessage, IEquatable<UnbanPlayer>, IDeepCloneable<UnbanPlayer>, IBufferMessage
	{
		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x0010FAD4 File Offset: 0x0010DCD4
		[DebuggerNonUserCode]
		public static MessageParser<UnbanPlayer> Parser
		{
			get
			{
				return UnbanPlayer._parser;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x0010FAEC File Offset: 0x0010DCEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[145];
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x0010FB14 File Offset: 0x0010DD14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnbanPlayer.Descriptor;
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0010FB2B File Offset: 0x0010DD2B
		[DebuggerNonUserCode]
		public UnbanPlayer()
		{
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0010FB35 File Offset: 0x0010DD35
		[DebuggerNonUserCode]
		public UnbanPlayer(UnbanPlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0010FB74 File Offset: 0x0010DD74
		[DebuggerNonUserCode]
		public UnbanPlayer Clone()
		{
			return new UnbanPlayer(this);
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x0010FB8C File Offset: 0x0010DD8C
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x0010FBAD File Offset: 0x0010DDAD
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? UnbanPlayer.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x0600472B RID: 18219 RVA: 0x0010FBC4 File Offset: 0x0010DDC4
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0010FBDF File Offset: 0x0010DDDF
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x0600472D RID: 18221 RVA: 0x0010FBEC File Offset: 0x0010DDEC
		// (set) Token: 0x0600472E RID: 18222 RVA: 0x0010FC1D File Offset: 0x0010DE1D
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = UnbanPlayer.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x0010FC38 File Offset: 0x0010DE38
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0010FC55 File Offset: 0x0010DE55
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0010FC68 File Offset: 0x0010DE68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnbanPlayer);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0010FC88 File Offset: 0x0010DE88
		[DebuggerNonUserCode]
		public bool Equals(UnbanPlayer other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetGameAccountId != other.TargetGameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0010FCFC File Offset: 0x0010DEFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0010FD68 File Offset: 0x0010DF68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0010FD80 File Offset: 0x0010DF80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0010FD8C File Offset: 0x0010DF8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0010FDFC File Offset: 0x0010DFFC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0010FE68 File Offset: 0x0010E068
		[DebuggerNonUserCode]
		public void MergeFrom(UnbanPlayer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0010FECA File Offset: 0x0010E0CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0010FED8 File Offset: 0x0010E0D8
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
						this.TargetGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001F8A RID: 8074
		private static readonly MessageParser<UnbanPlayer> _parser = new MessageParser<UnbanPlayer>(() => new UnbanPlayer());

		// Token: 0x04001F8B RID: 8075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F8C RID: 8076
		private int _hasBits0;

		// Token: 0x04001F8D RID: 8077
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001F8E RID: 8078
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001F8F RID: 8079
		private string clanId_;

		// Token: 0x04001F90 RID: 8080
		public const int TargetGameAccountIdFieldNumber = 2;

		// Token: 0x04001F91 RID: 8081
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001F92 RID: 8082
		private uint targetGameAccountId_;
	}
}

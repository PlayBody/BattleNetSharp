using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026C RID: 620
	public sealed class DemoteClanMemberRequest : IMessage<DemoteClanMemberRequest>, IMessage, IEquatable<DemoteClanMemberRequest>, IDeepCloneable<DemoteClanMemberRequest>, IBufferMessage
	{
		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x00102588 File Offset: 0x00100788
		[DebuggerNonUserCode]
		public static MessageParser<DemoteClanMemberRequest> Parser
		{
			get
			{
				return DemoteClanMemberRequest._parser;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x001025A0 File Offset: 0x001007A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[92];
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x0600428A RID: 17034 RVA: 0x001025C4 File Offset: 0x001007C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DemoteClanMemberRequest.Descriptor;
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x001025DB File Offset: 0x001007DB
		[DebuggerNonUserCode]
		public DemoteClanMemberRequest()
		{
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x001025E5 File Offset: 0x001007E5
		[DebuggerNonUserCode]
		public DemoteClanMemberRequest(DemoteClanMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x00102624 File Offset: 0x00100824
		[DebuggerNonUserCode]
		public DemoteClanMemberRequest Clone()
		{
			return new DemoteClanMemberRequest(this);
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x0010263C File Offset: 0x0010083C
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x0010265D File Offset: 0x0010085D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? DemoteClanMemberRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x00102674 File Offset: 0x00100874
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004291 RID: 17041 RVA: 0x0010268F File Offset: 0x0010088F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x0010269C File Offset: 0x0010089C
		// (set) Token: 0x06004293 RID: 17043 RVA: 0x001026CD File Offset: 0x001008CD
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
					targetGameAccountIdDefaultValue = DemoteClanMemberRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x001026E8 File Offset: 0x001008E8
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004295 RID: 17045 RVA: 0x00102705 File Offset: 0x00100905
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x00102718 File Offset: 0x00100918
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DemoteClanMemberRequest);
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00102738 File Offset: 0x00100938
		[DebuggerNonUserCode]
		public bool Equals(DemoteClanMemberRequest other)
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

		// Token: 0x06004298 RID: 17048 RVA: 0x001027AC File Offset: 0x001009AC
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

		// Token: 0x06004299 RID: 17049 RVA: 0x00102818 File Offset: 0x00100A18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00102830 File Offset: 0x00100A30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x0010283C File Offset: 0x00100A3C
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

		// Token: 0x0600429C RID: 17052 RVA: 0x001028AC File Offset: 0x00100AAC
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

		// Token: 0x0600429D RID: 17053 RVA: 0x00102918 File Offset: 0x00100B18
		[DebuggerNonUserCode]
		public void MergeFrom(DemoteClanMemberRequest other)
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

		// Token: 0x0600429E RID: 17054 RVA: 0x0010297A File Offset: 0x00100B7A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x00102988 File Offset: 0x00100B88
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

		// Token: 0x04001E17 RID: 7703
		private static readonly MessageParser<DemoteClanMemberRequest> _parser = new MessageParser<DemoteClanMemberRequest>(() => new DemoteClanMemberRequest());

		// Token: 0x04001E18 RID: 7704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E19 RID: 7705
		private int _hasBits0;

		// Token: 0x04001E1A RID: 7706
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E1B RID: 7707
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E1C RID: 7708
		private string clanId_;

		// Token: 0x04001E1D RID: 7709
		public const int TargetGameAccountIdFieldNumber = 2;

		// Token: 0x04001E1E RID: 7710
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001E1F RID: 7711
		private uint targetGameAccountId_;
	}
}

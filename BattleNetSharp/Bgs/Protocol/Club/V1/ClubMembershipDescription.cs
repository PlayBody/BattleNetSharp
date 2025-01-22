using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046F RID: 1135
	public sealed class ClubMembershipDescription : IMessage<ClubMembershipDescription>, IMessage, IEquatable<ClubMembershipDescription>, IDeepCloneable<ClubMembershipDescription>, IBufferMessage
	{
		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x001AFD58 File Offset: 0x001ADF58
		[DebuggerNonUserCode]
		public static MessageParser<ClubMembershipDescription> Parser
		{
			get
			{
				return ClubMembershipDescription._parser;
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x001AFD70 File Offset: 0x001ADF70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001AFD94 File Offset: 0x001ADF94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMembershipDescription.Descriptor;
			}
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x001AFDAB File Offset: 0x001ADFAB
		[DebuggerNonUserCode]
		public ClubMembershipDescription()
		{
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x001AFDB8 File Offset: 0x001ADFB8
		[DebuggerNonUserCode]
		public ClubMembershipDescription(ClubMembershipDescription other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.club_ = ((other.club_ != null) ? other.club_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x001AFE18 File Offset: 0x001AE018
		[DebuggerNonUserCode]
		public ClubMembershipDescription Clone()
		{
			return new ClubMembershipDescription(this);
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x06006F03 RID: 28419 RVA: 0x001AFE30 File Offset: 0x001AE030
		// (set) Token: 0x06006F04 RID: 28420 RVA: 0x001AFE48 File Offset: 0x001AE048
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x06006F05 RID: 28421 RVA: 0x001AFE54 File Offset: 0x001AE054
		// (set) Token: 0x06006F06 RID: 28422 RVA: 0x001AFE6C File Offset: 0x001AE06C
		[DebuggerNonUserCode]
		public ClubDescription Club
		{
			get
			{
				return this.club_;
			}
			set
			{
				this.club_ = value;
			}
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x001AFE78 File Offset: 0x001AE078
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMembershipDescription);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x001AFE98 File Offset: 0x001AE098
		[DebuggerNonUserCode]
		public bool Equals(ClubMembershipDescription other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Club, other.Club);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x001AFF10 File Offset: 0x001AE110
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num ^= this.Club.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x001AFF7C File Offset: 0x001AE17C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x001AFF94 File Offset: 0x001AE194
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x001AFFA0 File Offset: 0x001AE1A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Club);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x001B0014 File Offset: 0x001AE214
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag2 = this.club_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Club);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x001B0088 File Offset: 0x001AE288
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMembershipDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool flag4 = other.club_ != null;
				if (flag4)
				{
					bool flag5 = this.club_ == null;
					if (flag5)
					{
						this.Club = new ClubDescription();
					}
					this.Club.MergeFrom(other.Club);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x001B0135 File Offset: 0x001AE335
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x001B0140 File Offset: 0x001AE340
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.club_ == null;
						if (flag)
						{
							this.Club = new ClubDescription();
						}
						input.ReadMessage(this.Club);
					}
				}
				else
				{
					bool flag2 = this.memberId_ == null;
					if (flag2)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040032FB RID: 13051
		private static readonly MessageParser<ClubMembershipDescription> _parser = new MessageParser<ClubMembershipDescription>(() => new ClubMembershipDescription());

		// Token: 0x040032FC RID: 13052
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032FD RID: 13053
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032FE RID: 13054
		private MemberId memberId_;

		// Token: 0x040032FF RID: 13055
		public const int ClubFieldNumber = 2;

		// Token: 0x04003300 RID: 13056
		private ClubDescription club_;
	}
}

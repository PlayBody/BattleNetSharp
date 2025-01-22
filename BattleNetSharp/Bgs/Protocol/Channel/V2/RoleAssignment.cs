using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000687 RID: 1671
	public sealed class RoleAssignment : IMessage<RoleAssignment>, IMessage, IEquatable<RoleAssignment>, IDeepCloneable<RoleAssignment>, IBufferMessage
	{
		// Token: 0x1700302F RID: 12335
		// (get) Token: 0x06009AF7 RID: 39671 RVA: 0x0025A894 File Offset: 0x00258A94
		[DebuggerNonUserCode]
		public static MessageParser<RoleAssignment> Parser
		{
			get
			{
				return RoleAssignment._parser;
			}
		}

		// Token: 0x17003030 RID: 12336
		// (get) Token: 0x06009AF8 RID: 39672 RVA: 0x0025A8AC File Offset: 0x00258AAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17003031 RID: 12337
		// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x0025A8D0 File Offset: 0x00258AD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleAssignment.Descriptor;
			}
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x0025A8E7 File Offset: 0x00258AE7
		[DebuggerNonUserCode]
		public RoleAssignment()
		{
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x0025A8FC File Offset: 0x00258AFC
		[DebuggerNonUserCode]
		public RoleAssignment(RoleAssignment other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x0025A950 File Offset: 0x00258B50
		[DebuggerNonUserCode]
		public RoleAssignment Clone()
		{
			return new RoleAssignment(this);
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x06009AFD RID: 39677 RVA: 0x0025A968 File Offset: 0x00258B68
		// (set) Token: 0x06009AFE RID: 39678 RVA: 0x0025A980 File Offset: 0x00258B80
		[DebuggerNonUserCode]
		public GameAccountHandle MemberId
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

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06009AFF RID: 39679 RVA: 0x0025A98C File Offset: 0x00258B8C
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x0025A9A4 File Offset: 0x00258BA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleAssignment);
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x0025A9C4 File Offset: 0x00258BC4
		[DebuggerNonUserCode]
		public bool Equals(RoleAssignment other)
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
						bool flag5 = !this.role_.Equals(other.role_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x0025AA3C File Offset: 0x00258C3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x0025AA98 File Offset: 0x00258C98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x0025AAB0 File Offset: 0x00258CB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x0025AABC File Offset: 0x00258CBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.role_.WriteTo(ref output, RoleAssignment._repeated_role_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x0025AB20 File Offset: 0x00258D20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.role_.CalculateSize(RoleAssignment._repeated_role_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0025AB84 File Offset: 0x00258D84
		[DebuggerNonUserCode]
		public void MergeFrom(RoleAssignment other)
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
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x0025AC02 File Offset: 0x00258E02
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0025AC10 File Offset: 0x00258E10
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
					if (num3 != 16U && num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, RoleAssignment._repeated_role_codec);
					}
				}
				else
				{
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new GameAccountHandle();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040045EB RID: 17899
		private static readonly MessageParser<RoleAssignment> _parser = new MessageParser<RoleAssignment>(() => new RoleAssignment());

		// Token: 0x040045EC RID: 17900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045ED RID: 17901
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040045EE RID: 17902
		private GameAccountHandle memberId_;

		// Token: 0x040045EF RID: 17903
		public const int RoleFieldNumber = 2;

		// Token: 0x040045F0 RID: 17904
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040045F1 RID: 17905
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}

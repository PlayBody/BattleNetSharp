using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000465 RID: 1125
	public sealed class RoleAssignment : IMessage<RoleAssignment>, IMessage, IEquatable<RoleAssignment>, IDeepCloneable<RoleAssignment>, IBufferMessage
	{
		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06006E28 RID: 28200 RVA: 0x001ACCB4 File Offset: 0x001AAEB4
		[DebuggerNonUserCode]
		public static MessageParser<RoleAssignment> Parser
		{
			get
			{
				return RoleAssignment._parser;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x001ACCCC File Offset: 0x001AAECC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06006E2A RID: 28202 RVA: 0x001ACCF0 File Offset: 0x001AAEF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleAssignment.Descriptor;
			}
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x001ACD07 File Offset: 0x001AAF07
		[DebuggerNonUserCode]
		public RoleAssignment()
		{
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x001ACD1C File Offset: 0x001AAF1C
		[DebuggerNonUserCode]
		public RoleAssignment(RoleAssignment other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x001ACD70 File Offset: 0x001AAF70
		[DebuggerNonUserCode]
		public RoleAssignment Clone()
		{
			return new RoleAssignment(this);
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06006E2E RID: 28206 RVA: 0x001ACD88 File Offset: 0x001AAF88
		// (set) Token: 0x06006E2F RID: 28207 RVA: 0x001ACDA0 File Offset: 0x001AAFA0
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

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x06006E30 RID: 28208 RVA: 0x001ACDAC File Offset: 0x001AAFAC
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x001ACDC4 File Offset: 0x001AAFC4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleAssignment);
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x001ACDE4 File Offset: 0x001AAFE4
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

		// Token: 0x06006E33 RID: 28211 RVA: 0x001ACE5C File Offset: 0x001AB05C
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

		// Token: 0x06006E34 RID: 28212 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x001ACED0 File Offset: 0x001AB0D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x001ACEDC File Offset: 0x001AB0DC
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

		// Token: 0x06006E37 RID: 28215 RVA: 0x001ACF40 File Offset: 0x001AB140
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

		// Token: 0x06006E38 RID: 28216 RVA: 0x001ACFA4 File Offset: 0x001AB1A4
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
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x001AD022 File Offset: 0x001AB222
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x001AD030 File Offset: 0x001AB230
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
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040032A8 RID: 12968
		private static readonly MessageParser<RoleAssignment> _parser = new MessageParser<RoleAssignment>(() => new RoleAssignment());

		// Token: 0x040032A9 RID: 12969
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032AA RID: 12970
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032AB RID: 12971
		private MemberId memberId_;

		// Token: 0x040032AC RID: 12972
		public const int RoleFieldNumber = 2;

		// Token: 0x040032AD RID: 12973
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040032AE RID: 12974
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}

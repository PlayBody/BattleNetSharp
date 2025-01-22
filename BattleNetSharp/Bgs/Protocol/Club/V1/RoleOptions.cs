using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000464 RID: 1124
	public sealed class RoleOptions : IMessage<RoleOptions>, IMessage, IEquatable<RoleOptions>, IDeepCloneable<RoleOptions>, IBufferMessage
	{
		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06006E14 RID: 28180 RVA: 0x001AC880 File Offset: 0x001AAA80
		[DebuggerNonUserCode]
		public static MessageParser<RoleOptions> Parser
		{
			get
			{
				return RoleOptions._parser;
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x001AC898 File Offset: 0x001AAA98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x001AC8BC File Offset: 0x001AAABC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleOptions.Descriptor;
			}
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x001AC8D3 File Offset: 0x001AAAD3
		[DebuggerNonUserCode]
		public RoleOptions()
		{
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x001AC8E8 File Offset: 0x001AAAE8
		[DebuggerNonUserCode]
		public RoleOptions(RoleOptions other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x001AC93C File Offset: 0x001AAB3C
		[DebuggerNonUserCode]
		public RoleOptions Clone()
		{
			return new RoleOptions(this);
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x001AC954 File Offset: 0x001AAB54
		// (set) Token: 0x06006E1B RID: 28187 RVA: 0x001AC96C File Offset: 0x001AAB6C
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

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x001AC978 File Offset: 0x001AAB78
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x001AC990 File Offset: 0x001AAB90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleOptions);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x001AC9B0 File Offset: 0x001AABB0
		[DebuggerNonUserCode]
		public bool Equals(RoleOptions other)
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

		// Token: 0x06006E1F RID: 28191 RVA: 0x001ACA28 File Offset: 0x001AAC28
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

		// Token: 0x06006E20 RID: 28192 RVA: 0x001ACA84 File Offset: 0x001AAC84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x001ACA9C File Offset: 0x001AAC9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x001ACAA8 File Offset: 0x001AACA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.role_.WriteTo(ref output, RoleOptions._repeated_role_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x001ACB0C File Offset: 0x001AAD0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.role_.CalculateSize(RoleOptions._repeated_role_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x001ACB70 File Offset: 0x001AAD70
		[DebuggerNonUserCode]
		public void MergeFrom(RoleOptions other)
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

		// Token: 0x06006E25 RID: 28197 RVA: 0x001ACBEE File Offset: 0x001AADEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x001ACBFC File Offset: 0x001AADFC
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
						this.role_.AddEntriesFrom(ref input, RoleOptions._repeated_role_codec);
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

		// Token: 0x040032A1 RID: 12961
		private static readonly MessageParser<RoleOptions> _parser = new MessageParser<RoleOptions>(() => new RoleOptions());

		// Token: 0x040032A2 RID: 12962
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032A3 RID: 12963
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032A4 RID: 12964
		private MemberId memberId_;

		// Token: 0x040032A5 RID: 12965
		public const int RoleFieldNumber = 2;

		// Token: 0x040032A6 RID: 12966
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040032A7 RID: 12967
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}

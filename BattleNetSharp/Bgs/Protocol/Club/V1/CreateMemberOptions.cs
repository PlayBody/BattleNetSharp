using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000462 RID: 1122
	public sealed class CreateMemberOptions : IMessage<CreateMemberOptions>, IMessage, IEquatable<CreateMemberOptions>, IDeepCloneable<CreateMemberOptions>, IBufferMessage
	{
		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x001ABE78 File Offset: 0x001AA078
		[DebuggerNonUserCode]
		public static MessageParser<CreateMemberOptions> Parser
		{
			get
			{
				return CreateMemberOptions._parser;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x001ABE90 File Offset: 0x001AA090
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x001ABEB4 File Offset: 0x001AA0B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateMemberOptions.Descriptor;
			}
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x001ABECB File Offset: 0x001AA0CB
		[DebuggerNonUserCode]
		public CreateMemberOptions()
		{
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x001ABEE0 File Offset: 0x001AA0E0
		[DebuggerNonUserCode]
		public CreateMemberOptions(CreateMemberOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.joinClubSource_ = other.joinClubSource_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x001ABF4C File Offset: 0x001AA14C
		[DebuggerNonUserCode]
		public CreateMemberOptions Clone()
		{
			return new CreateMemberOptions(this);
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x06006DEB RID: 28139 RVA: 0x001ABF64 File Offset: 0x001AA164
		// (set) Token: 0x06006DEC RID: 28140 RVA: 0x001ABF7C File Offset: 0x001AA17C
		[DebuggerNonUserCode]
		public MemberId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06006DED RID: 28141 RVA: 0x001ABF88 File Offset: 0x001AA188
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x001ABFA0 File Offset: 0x001AA1A0
		// (set) Token: 0x06006DEF RID: 28143 RVA: 0x001ABFD1 File Offset: 0x001AA1D1
		[DebuggerNonUserCode]
		public uint JoinClubSource
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint joinClubSourceDefaultValue;
				if (flag)
				{
					joinClubSourceDefaultValue = this.joinClubSource_;
				}
				else
				{
					joinClubSourceDefaultValue = CreateMemberOptions.JoinClubSourceDefaultValue;
				}
				return joinClubSourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.joinClubSource_ = value;
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x001ABFEC File Offset: 0x001AA1EC
		[DebuggerNonUserCode]
		public bool HasJoinClubSource
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x001AC009 File Offset: 0x001AA209
		[DebuggerNonUserCode]
		public void ClearJoinClubSource()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x001AC01C File Offset: 0x001AA21C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateMemberOptions);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x001AC03C File Offset: 0x001AA23C
		[DebuggerNonUserCode]
		public bool Equals(CreateMemberOptions other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.JoinClubSource != other.JoinClubSource;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x001AC0D0 File Offset: 0x001AA2D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num ^= this.JoinClubSource.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x001AC14C File Offset: 0x001AA34C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x001AC164 File Offset: 0x001AA364
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x001AC170 File Offset: 0x001AA370
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			this.attribute_.WriteTo(ref output, CreateMemberOptions._repeated_attribute_codec);
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.JoinClubSource);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x001AC1F4 File Offset: 0x001AA3F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			num += this.attribute_.CalculateSize(CreateMemberOptions._repeated_attribute_codec);
			bool hasJoinClubSource = this.HasJoinClubSource;
			if (hasJoinClubSource)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JoinClubSource);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x001AC278 File Offset: 0x001AA478
		[DebuggerNonUserCode]
		public void MergeFrom(CreateMemberOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new MemberId();
					}
					this.Id.MergeFrom(other.Id);
				}
				this.attribute_.Add(other.attribute_);
				bool hasJoinClubSource = other.HasJoinClubSource;
				if (hasJoinClubSource)
				{
					this.JoinClubSource = other.JoinClubSource;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x001AC30F File Offset: 0x001AA50F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x001AC31C File Offset: 0x001AA51C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.JoinClubSource = input.ReadUInt32();
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, CreateMemberOptions._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.id_ == null;
					if (flag)
					{
						this.Id = new MemberId();
					}
					input.ReadMessage(this.Id);
				}
			}
		}

		// Token: 0x0400328F RID: 12943
		private static readonly MessageParser<CreateMemberOptions> _parser = new MessageParser<CreateMemberOptions>(() => new CreateMemberOptions());

		// Token: 0x04003290 RID: 12944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003291 RID: 12945
		private int _hasBits0;

		// Token: 0x04003292 RID: 12946
		public const int IdFieldNumber = 1;

		// Token: 0x04003293 RID: 12947
		private MemberId id_;

		// Token: 0x04003294 RID: 12948
		public const int AttributeFieldNumber = 2;

		// Token: 0x04003295 RID: 12949
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003296 RID: 12950
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003297 RID: 12951
		public const int JoinClubSourceFieldNumber = 3;

		// Token: 0x04003298 RID: 12952
		private static readonly uint JoinClubSourceDefaultValue = 0U;

		// Token: 0x04003299 RID: 12953
		private uint joinClubSource_;
	}
}

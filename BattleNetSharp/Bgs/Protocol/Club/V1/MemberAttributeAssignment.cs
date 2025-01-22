using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000466 RID: 1126
	public sealed class MemberAttributeAssignment : IMessage<MemberAttributeAssignment>, IMessage, IEquatable<MemberAttributeAssignment>, IDeepCloneable<MemberAttributeAssignment>, IBufferMessage
	{
		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x001AD0E8 File Offset: 0x001AB2E8
		[DebuggerNonUserCode]
		public static MessageParser<MemberAttributeAssignment> Parser
		{
			get
			{
				return MemberAttributeAssignment._parser;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x001AD100 File Offset: 0x001AB300
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x001AD124 File Offset: 0x001AB324
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAttributeAssignment.Descriptor;
			}
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x001AD13B File Offset: 0x001AB33B
		[DebuggerNonUserCode]
		public MemberAttributeAssignment()
		{
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x001AD150 File Offset: 0x001AB350
		[DebuggerNonUserCode]
		public MemberAttributeAssignment(MemberAttributeAssignment other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x001AD1A4 File Offset: 0x001AB3A4
		[DebuggerNonUserCode]
		public MemberAttributeAssignment Clone()
		{
			return new MemberAttributeAssignment(this);
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06006E42 RID: 28226 RVA: 0x001AD1BC File Offset: 0x001AB3BC
		// (set) Token: 0x06006E43 RID: 28227 RVA: 0x001AD1D4 File Offset: 0x001AB3D4
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

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x001AD1E0 File Offset: 0x001AB3E0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x001AD1F8 File Offset: 0x001AB3F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAttributeAssignment);
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x001AD218 File Offset: 0x001AB418
		[DebuggerNonUserCode]
		public bool Equals(MemberAttributeAssignment other)
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
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x001AD290 File Offset: 0x001AB490
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x001AD2EC File Offset: 0x001AB4EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x001AD304 File Offset: 0x001AB504
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x001AD310 File Offset: 0x001AB510
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, MemberAttributeAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x001AD374 File Offset: 0x001AB574
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(MemberAttributeAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x001AD3D8 File Offset: 0x001AB5D8
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAttributeAssignment other)
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
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x001AD456 File Offset: 0x001AB656
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x001AD464 File Offset: 0x001AB664
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
						this.attribute_.AddEntriesFrom(ref input, MemberAttributeAssignment._repeated_attribute_codec);
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

		// Token: 0x040032AF RID: 12975
		private static readonly MessageParser<MemberAttributeAssignment> _parser = new MessageParser<MemberAttributeAssignment>(() => new MemberAttributeAssignment());

		// Token: 0x040032B0 RID: 12976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B1 RID: 12977
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032B2 RID: 12978
		private MemberId memberId_;

		// Token: 0x040032B3 RID: 12979
		public const int AttributeFieldNumber = 2;

		// Token: 0x040032B4 RID: 12980
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040032B5 RID: 12981
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

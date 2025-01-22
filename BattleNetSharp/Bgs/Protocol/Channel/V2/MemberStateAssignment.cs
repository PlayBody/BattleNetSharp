using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x020006A0 RID: 1696
	public sealed class MemberStateAssignment : IMessage<MemberStateAssignment>, IMessage, IEquatable<MemberStateAssignment>, IDeepCloneable<MemberStateAssignment>, IBufferMessage
	{
		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x00264238 File Offset: 0x00262438
		[DebuggerNonUserCode]
		public static MessageParser<MemberStateAssignment> Parser
		{
			get
			{
				return MemberStateAssignment._parser;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06009D6B RID: 40299 RVA: 0x00264250 File Offset: 0x00262450
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x00264274 File Offset: 0x00262474
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberStateAssignment.Descriptor;
			}
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x0026428B File Offset: 0x0026248B
		[DebuggerNonUserCode]
		public MemberStateAssignment()
		{
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x002642A0 File Offset: 0x002624A0
		[DebuggerNonUserCode]
		public MemberStateAssignment(MemberStateAssignment other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x002642F4 File Offset: 0x002624F4
		[DebuggerNonUserCode]
		public MemberStateAssignment Clone()
		{
			return new MemberStateAssignment(this);
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x0026430C File Offset: 0x0026250C
		// (set) Token: 0x06009D71 RID: 40305 RVA: 0x00264324 File Offset: 0x00262524
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

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x00264330 File Offset: 0x00262530
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x00264348 File Offset: 0x00262548
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberStateAssignment);
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x00264368 File Offset: 0x00262568
		[DebuggerNonUserCode]
		public bool Equals(MemberStateAssignment other)
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

		// Token: 0x06009D75 RID: 40309 RVA: 0x002643E0 File Offset: 0x002625E0
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

		// Token: 0x06009D76 RID: 40310 RVA: 0x0026443C File Offset: 0x0026263C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x00264454 File Offset: 0x00262654
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x00264460 File Offset: 0x00262660
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, MemberStateAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x002644C4 File Offset: 0x002626C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(MemberStateAssignment._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x00264528 File Offset: 0x00262728
		[DebuggerNonUserCode]
		public void MergeFrom(MemberStateAssignment other)
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
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x002645A6 File Offset: 0x002627A6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x002645B4 File Offset: 0x002627B4
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
						this.attribute_.AddEntriesFrom(ref input, MemberStateAssignment._repeated_attribute_codec);
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

		// Token: 0x0400470E RID: 18190
		private static readonly MessageParser<MemberStateAssignment> _parser = new MessageParser<MemberStateAssignment>(() => new MemberStateAssignment());

		// Token: 0x0400470F RID: 18191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004710 RID: 18192
		public const int MemberIdFieldNumber = 1;

		// Token: 0x04004711 RID: 18193
		private GameAccountHandle memberId_;

		// Token: 0x04004712 RID: 18194
		public const int AttributeFieldNumber = 2;

		// Token: 0x04004713 RID: 18195
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004714 RID: 18196
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

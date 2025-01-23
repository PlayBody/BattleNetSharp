using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000689 RID: 1673
	public sealed class CreateMemberOptions : IMessage<CreateMemberOptions>, IMessage, IEquatable<CreateMemberOptions>, IDeepCloneable<CreateMemberOptions>, IBufferMessage
	{
		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x0025B0FC File Offset: 0x002592FC
		[DebuggerNonUserCode]
		public static MessageParser<CreateMemberOptions> Parser
		{
			get
			{
				return CreateMemberOptions._parser;
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x0025B114 File Offset: 0x00259314
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x0025B138 File Offset: 0x00259338
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateMemberOptions.Descriptor;
			}
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0025B14F File Offset: 0x0025934F
		[DebuggerNonUserCode]
		public CreateMemberOptions()
		{
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x0025B164 File Offset: 0x00259364
		[DebuggerNonUserCode]
		public CreateMemberOptions(CreateMemberOptions other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x0025B1B8 File Offset: 0x002593B8
		[DebuggerNonUserCode]
		public CreateMemberOptions Clone()
		{
			return new CreateMemberOptions(this);
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x06009B25 RID: 39717 RVA: 0x0025B1D0 File Offset: 0x002593D0
		// (set) Token: 0x06009B26 RID: 39718 RVA: 0x0025B1E8 File Offset: 0x002593E8
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

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x0025B1F4 File Offset: 0x002593F4
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x0025B20C File Offset: 0x0025940C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateMemberOptions);
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0025B22C File Offset: 0x0025942C
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

		// Token: 0x06009B2A RID: 39722 RVA: 0x0025B2A4 File Offset: 0x002594A4
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

		// Token: 0x06009B2B RID: 39723 RVA: 0x0025B300 File Offset: 0x00259500
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x0025B318 File Offset: 0x00259518
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x0025B324 File Offset: 0x00259524
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, CreateMemberOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x0025B388 File Offset: 0x00259588
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(CreateMemberOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x0025B3EC File Offset: 0x002595EC
		[DebuggerNonUserCode]
		public void MergeFrom(CreateMemberOptions other)
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

		// Token: 0x06009B30 RID: 39728 RVA: 0x0025B46A File Offset: 0x0025966A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x0025B478 File Offset: 0x00259678
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, CreateMemberOptions._repeated_attribute_codec);
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

		// Token: 0x040045F9 RID: 17913
		private static readonly MessageParser<CreateMemberOptions> _parser = new MessageParser<CreateMemberOptions>(() => new CreateMemberOptions());

		// Token: 0x040045FA RID: 17914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045FB RID: 17915
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040045FC RID: 17916
		private GameAccountHandle memberId_;

		// Token: 0x040045FD RID: 17917
		public const int AttributeFieldNumber = 3;

		// Token: 0x040045FE RID: 17918
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040045FF RID: 17919
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}

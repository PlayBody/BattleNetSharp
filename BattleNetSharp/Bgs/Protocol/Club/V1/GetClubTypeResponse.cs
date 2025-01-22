using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A3 RID: 1187
	public sealed class GetClubTypeResponse : IMessage<GetClubTypeResponse>, IMessage, IEquatable<GetClubTypeResponse>, IDeepCloneable<GetClubTypeResponse>, IBufferMessage
	{
		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06007378 RID: 29560 RVA: 0x001C2F4C File Offset: 0x001C114C
		[DebuggerNonUserCode]
		public static MessageParser<GetClubTypeResponse> Parser
		{
			get
			{
				return GetClubTypeResponse._parser;
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x06007379 RID: 29561 RVA: 0x001C2F64 File Offset: 0x001C1164
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x001C2F88 File Offset: 0x001C1188
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClubTypeResponse.Descriptor;
			}
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x001C2F9F File Offset: 0x001C119F
		[DebuggerNonUserCode]
		public GetClubTypeResponse()
		{
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x001C2FC0 File Offset: 0x001C11C0
		[DebuggerNonUserCode]
		public GetClubTypeResponse(GetClubTypeResponse other)
			: this()
		{
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.roleSet_ = ((other.roleSet_ != null) ? other.roleSet_.Clone() : null);
			this.rangeSet_ = ((other.rangeSet_ != null) ? other.rangeSet_.Clone() : null);
			this.platformTagSet_ = other.platformTagSet_.Clone();
			this.customTagSet_ = other.customTagSet_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x001C305C File Offset: 0x001C125C
		[DebuggerNonUserCode]
		public GetClubTypeResponse Clone()
		{
			return new GetClubTypeResponse(this);
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x001C3074 File Offset: 0x001C1274
		// (set) Token: 0x0600737F RID: 29567 RVA: 0x001C308C File Offset: 0x001C128C
		[DebuggerNonUserCode]
		public UniqueClubType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x001C3098 File Offset: 0x001C1298
		// (set) Token: 0x06007381 RID: 29569 RVA: 0x001C30B0 File Offset: 0x001C12B0
		[DebuggerNonUserCode]
		public ClubRoleSet RoleSet
		{
			get
			{
				return this.roleSet_;
			}
			set
			{
				this.roleSet_ = value;
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x06007382 RID: 29570 RVA: 0x001C30BC File Offset: 0x001C12BC
		// (set) Token: 0x06007383 RID: 29571 RVA: 0x001C30D4 File Offset: 0x001C12D4
		[DebuggerNonUserCode]
		public ClubTypeRangeSet RangeSet
		{
			get
			{
				return this.rangeSet_;
			}
			set
			{
				this.rangeSet_ = value;
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x001C30E0 File Offset: 0x001C12E0
		[DebuggerNonUserCode]
		public RepeatedField<LocalizedTag> PlatformTagSet
		{
			get
			{
				return this.platformTagSet_;
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06007385 RID: 29573 RVA: 0x001C30F8 File Offset: 0x001C12F8
		[DebuggerNonUserCode]
		public RepeatedField<LocalizedTag> CustomTagSet
		{
			get
			{
				return this.customTagSet_;
			}
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x001C3110 File Offset: 0x001C1310
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClubTypeResponse);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x001C3130 File Offset: 0x001C1330
		[DebuggerNonUserCode]
		public bool Equals(GetClubTypeResponse other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.RoleSet, other.RoleSet);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.RangeSet, other.RangeSet);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.platformTagSet_.Equals(other.platformTagSet_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.customTagSet_.Equals(other.customTagSet_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x001C320C File Offset: 0x001C140C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag2 = this.roleSet_ != null;
			if (flag2)
			{
				num ^= this.RoleSet.GetHashCode();
			}
			bool flag3 = this.rangeSet_ != null;
			if (flag3)
			{
				num ^= this.RangeSet.GetHashCode();
			}
			num ^= this.platformTagSet_.GetHashCode();
			num ^= this.customTagSet_.GetHashCode();
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x001C32B0 File Offset: 0x001C14B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x001C32C8 File Offset: 0x001C14C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x001C32D4 File Offset: 0x001C14D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			bool flag2 = this.roleSet_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleSet);
			}
			bool flag3 = this.rangeSet_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RangeSet);
			}
			this.platformTagSet_.WriteTo(ref output, GetClubTypeResponse._repeated_platformTagSet_codec);
			this.customTagSet_.WriteTo(ref output, GetClubTypeResponse._repeated_customTagSet_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x001C3394 File Offset: 0x001C1594
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool flag2 = this.roleSet_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleSet);
			}
			bool flag3 = this.rangeSet_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RangeSet);
			}
			num += this.platformTagSet_.CalculateSize(GetClubTypeResponse._repeated_platformTagSet_codec);
			num += this.customTagSet_.CalculateSize(GetClubTypeResponse._repeated_customTagSet_codec);
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x001C3450 File Offset: 0x001C1650
		[DebuggerNonUserCode]
		public void MergeFrom(GetClubTypeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueClubType();
					}
					this.Type.MergeFrom(other.Type);
				}
				bool flag4 = other.roleSet_ != null;
				if (flag4)
				{
					bool flag5 = this.roleSet_ == null;
					if (flag5)
					{
						this.RoleSet = new ClubRoleSet();
					}
					this.RoleSet.MergeFrom(other.RoleSet);
				}
				bool flag6 = other.rangeSet_ != null;
				if (flag6)
				{
					bool flag7 = this.rangeSet_ == null;
					if (flag7)
					{
						this.RangeSet = new ClubTypeRangeSet();
					}
					this.RangeSet.MergeFrom(other.RangeSet);
				}
				this.platformTagSet_.Add(other.platformTagSet_);
				this.customTagSet_.Add(other.customTagSet_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x001C3561 File Offset: 0x001C1761
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x001C356C File Offset: 0x001C176C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						bool flag = this.roleSet_ == null;
						if (flag)
						{
							this.RoleSet = new ClubRoleSet();
						}
						input.ReadMessage(this.RoleSet);
					}
					else
					{
						bool flag2 = this.type_ == null;
						if (flag2)
						{
							this.Type = new UniqueClubType();
						}
						input.ReadMessage(this.Type);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						this.customTagSet_.AddEntriesFrom(ref input, GetClubTypeResponse._repeated_customTagSet_codec);
					}
					else
					{
						this.platformTagSet_.AddEntriesFrom(ref input, GetClubTypeResponse._repeated_platformTagSet_codec);
					}
				}
				else
				{
					bool flag3 = this.rangeSet_ == null;
					if (flag3)
					{
						this.RangeSet = new ClubTypeRangeSet();
					}
					input.ReadMessage(this.RangeSet);
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040034C2 RID: 13506
		private static readonly MessageParser<GetClubTypeResponse> _parser = new MessageParser<GetClubTypeResponse>(() => new GetClubTypeResponse());

		// Token: 0x040034C3 RID: 13507
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034C4 RID: 13508
		public const int TypeFieldNumber = 1;

		// Token: 0x040034C5 RID: 13509
		private UniqueClubType type_;

		// Token: 0x040034C6 RID: 13510
		public const int RoleSetFieldNumber = 2;

		// Token: 0x040034C7 RID: 13511
		private ClubRoleSet roleSet_;

		// Token: 0x040034C8 RID: 13512
		public const int RangeSetFieldNumber = 3;

		// Token: 0x040034C9 RID: 13513
		private ClubTypeRangeSet rangeSet_;

		// Token: 0x040034CA RID: 13514
		public const int PlatformTagSetFieldNumber = 4;

		// Token: 0x040034CB RID: 13515
		private static readonly FieldCodec<LocalizedTag> _repeated_platformTagSet_codec = FieldCodec.ForMessage<LocalizedTag>(34U, LocalizedTag.Parser);

		// Token: 0x040034CC RID: 13516
		private readonly RepeatedField<LocalizedTag> platformTagSet_ = new RepeatedField<LocalizedTag>();

		// Token: 0x040034CD RID: 13517
		public const int CustomTagSetFieldNumber = 5;

		// Token: 0x040034CE RID: 13518
		private static readonly FieldCodec<LocalizedTag> _repeated_customTagSet_codec = FieldCodec.ForMessage<LocalizedTag>(42U, LocalizedTag.Parser);

		// Token: 0x040034CF RID: 13519
		private readonly RepeatedField<LocalizedTag> customTagSet_ = new RepeatedField<LocalizedTag>();
	}
}

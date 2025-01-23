using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000458 RID: 1112
	public sealed class ClubSuggestion : IMessage<ClubSuggestion>, IMessage, IEquatable<ClubSuggestion>, IDeepCloneable<ClubSuggestion>, IBufferMessage
	{
		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x001A6AD0 File Offset: 0x001A4CD0
		[DebuggerNonUserCode]
		public static MessageParser<ClubSuggestion> Parser
		{
			get
			{
				return ClubSuggestion._parser;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x001A6AE8 File Offset: 0x001A4CE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubInvitationReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x001A6B0C File Offset: 0x001A4D0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSuggestion.Descriptor;
			}
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x001A6B23 File Offset: 0x001A4D23
		[DebuggerNonUserCode]
		public ClubSuggestion()
		{
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x001A6B38 File Offset: 0x001A4D38
		[DebuggerNonUserCode]
		public ClubSuggestion(ClubSuggestion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.clubId_ = other.clubId_;
			this.suggester_ = ((other.suggester_ != null) ? other.suggester_.Clone() : null);
			this.suggestee_ = ((other.suggestee_ != null) ? other.suggestee_.Clone() : null);
			this.slot_ = ((other.slot_ != null) ? other.slot_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.creationTime_ = other.creationTime_;
			this.expirationTime_ = other.expirationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CB6 RID: 27830 RVA: 0x001A6C00 File Offset: 0x001A4E00
		[DebuggerNonUserCode]
		public ClubSuggestion Clone()
		{
			return new ClubSuggestion(this);
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06006CB7 RID: 27831 RVA: 0x001A6C18 File Offset: 0x001A4E18
		// (set) Token: 0x06006CB8 RID: 27832 RVA: 0x001A6C49 File Offset: 0x001A4E49
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = ClubSuggestion.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x001A6C64 File Offset: 0x001A4E64
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x001A6C81 File Offset: 0x001A4E81
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06006CBB RID: 27835 RVA: 0x001A6C94 File Offset: 0x001A4E94
		// (set) Token: 0x06006CBC RID: 27836 RVA: 0x001A6CC5 File Offset: 0x001A4EC5
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = ClubSuggestion.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.clubId_ = value;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06006CBD RID: 27837 RVA: 0x001A6CE0 File Offset: 0x001A4EE0
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x001A6CFD File Offset: 0x001A4EFD
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x001A6D10 File Offset: 0x001A4F10
		// (set) Token: 0x06006CC0 RID: 27840 RVA: 0x001A6D28 File Offset: 0x001A4F28
		[DebuggerNonUserCode]
		public MemberDescription Suggester
		{
			get
			{
				return this.suggester_;
			}
			set
			{
				this.suggester_ = value;
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x001A6D34 File Offset: 0x001A4F34
		// (set) Token: 0x06006CC2 RID: 27842 RVA: 0x001A6D4C File Offset: 0x001A4F4C
		[DebuggerNonUserCode]
		public MemberDescription Suggestee
		{
			get
			{
				return this.suggestee_;
			}
			set
			{
				this.suggestee_ = value;
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x001A6D58 File Offset: 0x001A4F58
		// (set) Token: 0x06006CC4 RID: 27844 RVA: 0x001A6D70 File Offset: 0x001A4F70
		[DebuggerNonUserCode]
		public ClubSlot Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x001A6D7C File Offset: 0x001A4F7C
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06006CC6 RID: 27846 RVA: 0x001A6D94 File Offset: 0x001A4F94
		// (set) Token: 0x06006CC7 RID: 27847 RVA: 0x001A6DC5 File Offset: 0x001A4FC5
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = ClubSuggestion.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06006CC8 RID: 27848 RVA: 0x001A6DE0 File Offset: 0x001A4FE0
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x001A6DFD File Offset: 0x001A4FFD
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x001A6E10 File Offset: 0x001A5010
		// (set) Token: 0x06006CCB RID: 27851 RVA: 0x001A6E41 File Offset: 0x001A5041
		[DebuggerNonUserCode]
		public ulong ExpirationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong expirationTimeDefaultValue;
				if (flag)
				{
					expirationTimeDefaultValue = this.expirationTime_;
				}
				else
				{
					expirationTimeDefaultValue = ClubSuggestion.ExpirationTimeDefaultValue;
				}
				return expirationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.expirationTime_ = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06006CCC RID: 27852 RVA: 0x001A6E5C File Offset: 0x001A505C
		[DebuggerNonUserCode]
		public bool HasExpirationTime
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x001A6E79 File Offset: 0x001A5079
		[DebuggerNonUserCode]
		public void ClearExpirationTime()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x001A6E8C File Offset: 0x001A508C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSuggestion);
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x001A6EAC File Offset: 0x001A50AC
		[DebuggerNonUserCode]
		public bool Equals(ClubSuggestion other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Suggester, other.Suggester);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Suggestee, other.Suggestee);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Slot, other.Slot);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !this.attribute_.Equals(other.attribute_);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.CreationTime != other.CreationTime;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.ExpirationTime != other.ExpirationTime;
												flag2 = !flag11 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x001A6FE0 File Offset: 0x001A51E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag = this.suggester_ != null;
			if (flag)
			{
				num ^= this.Suggester.GetHashCode();
			}
			bool flag2 = this.suggestee_ != null;
			if (flag2)
			{
				num ^= this.Suggestee.GetHashCode();
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num ^= this.Slot.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num ^= this.ExpirationTime.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x001A70EC File Offset: 0x001A52EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x001A7104 File Offset: 0x001A5304
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x001A7110 File Offset: 0x001A5310
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Id);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool flag = this.suggester_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Suggester);
			}
			bool flag2 = this.suggestee_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Suggestee);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Slot);
			}
			this.attribute_.WriteTo(ref output, ClubSuggestion._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.ExpirationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x001A724C File Offset: 0x001A544C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 9;
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag = this.suggester_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggester);
			}
			bool flag2 = this.suggestee_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestee);
			}
			bool flag3 = this.slot_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Slot);
			}
			num += this.attribute_.CalculateSize(ClubSuggestion._repeated_attribute_codec);
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool hasExpirationTime = this.HasExpirationTime;
			if (hasExpirationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExpirationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x001A7360 File Offset: 0x001A5560
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSuggestion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool flag2 = other.suggester_ != null;
				if (flag2)
				{
					bool flag3 = this.suggester_ == null;
					if (flag3)
					{
						this.Suggester = new MemberDescription();
					}
					this.Suggester.MergeFrom(other.Suggester);
				}
				bool flag4 = other.suggestee_ != null;
				if (flag4)
				{
					bool flag5 = this.suggestee_ == null;
					if (flag5)
					{
						this.Suggestee = new MemberDescription();
					}
					this.Suggestee.MergeFrom(other.Suggestee);
				}
				bool flag6 = other.slot_ != null;
				if (flag6)
				{
					bool flag7 = this.slot_ == null;
					if (flag7)
					{
						this.Slot = new ClubSlot();
					}
					this.Slot.MergeFrom(other.Slot);
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				bool hasExpirationTime = other.HasExpirationTime;
				if (hasExpirationTime)
				{
					this.ExpirationTime = other.ExpirationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x001A74CB File Offset: 0x001A56CB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x001A74D8 File Offset: 0x001A56D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 9U)
						{
							if (num3 != 16U)
							{
								goto IL_0061;
							}
							this.ClubId = input.ReadUInt64();
						}
						else
						{
							this.Id = input.ReadFixed64();
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							goto IL_0061;
						}
						bool flag = this.suggestee_ == null;
						if (flag)
						{
							this.Suggestee = new MemberDescription();
						}
						input.ReadMessage(this.Suggestee);
					}
					else
					{
						bool flag2 = this.suggester_ == null;
						if (flag2)
						{
							this.Suggester = new MemberDescription();
						}
						input.ReadMessage(this.Suggester);
					}
				}
				else if (num3 <= 50U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0061;
						}
						this.attribute_.AddEntriesFrom(ref input, ClubSuggestion._repeated_attribute_codec);
					}
					else
					{
						bool flag3 = this.slot_ == null;
						if (flag3)
						{
							this.Slot = new ClubSlot();
						}
						input.ReadMessage(this.Slot);
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 64U)
					{
						goto IL_0061;
					}
					this.ExpirationTime = input.ReadUInt64();
				}
				else
				{
					this.CreationTime = input.ReadUInt64();
				}
				continue;
				IL_0061:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031EF RID: 12783
		private static readonly MessageParser<ClubSuggestion> _parser = new MessageParser<ClubSuggestion>(() => new ClubSuggestion());

		// Token: 0x040031F0 RID: 12784
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031F1 RID: 12785
		private int _hasBits0;

		// Token: 0x040031F2 RID: 12786
		public const int IdFieldNumber = 1;

		// Token: 0x040031F3 RID: 12787
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x040031F4 RID: 12788
		private ulong id_;

		// Token: 0x040031F5 RID: 12789
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040031F6 RID: 12790
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040031F7 RID: 12791
		private ulong clubId_;

		// Token: 0x040031F8 RID: 12792
		public const int SuggesterFieldNumber = 3;

		// Token: 0x040031F9 RID: 12793
		private MemberDescription suggester_;

		// Token: 0x040031FA RID: 12794
		public const int SuggesteeFieldNumber = 4;

		// Token: 0x040031FB RID: 12795
		private MemberDescription suggestee_;

		// Token: 0x040031FC RID: 12796
		public const int SlotFieldNumber = 5;

		// Token: 0x040031FD RID: 12797
		private ClubSlot slot_;

		// Token: 0x040031FE RID: 12798
		public const int AttributeFieldNumber = 6;

		// Token: 0x040031FF RID: 12799
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(50U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003200 RID: 12800
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003201 RID: 12801
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x04003202 RID: 12802
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x04003203 RID: 12803
		private ulong creationTime_;

		// Token: 0x04003204 RID: 12804
		public const int ExpirationTimeFieldNumber = 8;

		// Token: 0x04003205 RID: 12805
		private static readonly ulong ExpirationTimeDefaultValue = 0UL;

		// Token: 0x04003206 RID: 12806
		private ulong expirationTime_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CF RID: 1743
	public sealed class JoinChannelResponse : IMessage<JoinChannelResponse>, IMessage, IEquatable<JoinChannelResponse>, IDeepCloneable<JoinChannelResponse>, IBufferMessage
	{
		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x00272578 File Offset: 0x00270778
		[DebuggerNonUserCode]
		public static MessageParser<JoinChannelResponse> Parser
		{
			get
			{
				return JoinChannelResponse._parser;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600A0E4 RID: 41188 RVA: 0x00272590 File Offset: 0x00270790
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelOwnerServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A0E5 RID: 41189 RVA: 0x002725B4 File Offset: 0x002707B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinChannelResponse.Descriptor;
			}
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x002725CB File Offset: 0x002707CB
		[DebuggerNonUserCode]
		public JoinChannelResponse()
		{
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x002725D8 File Offset: 0x002707D8
		[DebuggerNonUserCode]
		public JoinChannelResponse(JoinChannelResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.objectId_ = other.objectId_;
			this.alreadyMember_ = other.alreadyMember_;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x00272640 File Offset: 0x00270840
		[DebuggerNonUserCode]
		public JoinChannelResponse Clone()
		{
			return new JoinChannelResponse(this);
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x00272658 File Offset: 0x00270858
		// (set) Token: 0x0600A0EA RID: 41194 RVA: 0x00272689 File Offset: 0x00270889
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = JoinChannelResponse.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x002726A4 File Offset: 0x002708A4
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x002726C1 File Offset: 0x002708C1
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x002726D4 File Offset: 0x002708D4
		// (set) Token: 0x0600A0EE RID: 41198 RVA: 0x00272705 File Offset: 0x00270905
		[DebuggerNonUserCode]
		public bool AlreadyMember
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool alreadyMemberDefaultValue;
				if (flag)
				{
					alreadyMemberDefaultValue = this.alreadyMember_;
				}
				else
				{
					alreadyMemberDefaultValue = JoinChannelResponse.AlreadyMemberDefaultValue;
				}
				return alreadyMemberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.alreadyMember_ = value;
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A0EF RID: 41199 RVA: 0x00272720 File Offset: 0x00270920
		[DebuggerNonUserCode]
		public bool HasAlreadyMember
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x0027273D File Offset: 0x0027093D
		[DebuggerNonUserCode]
		public void ClearAlreadyMember()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A0F1 RID: 41201 RVA: 0x00272750 File Offset: 0x00270950
		// (set) Token: 0x0600A0F2 RID: 41202 RVA: 0x00272768 File Offset: 0x00270968
		[DebuggerNonUserCode]
		public EntityId MemberId
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

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x00272774 File Offset: 0x00270974
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinChannelResponse);
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00272794 File Offset: 0x00270994
		[DebuggerNonUserCode]
		public bool Equals(JoinChannelResponse other)
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
					bool flag4 = this.ObjectId != other.ObjectId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AlreadyMember != other.AlreadyMember;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.MemberId, other.MemberId);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x00272824 File Offset: 0x00270A24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool hasAlreadyMember = this.HasAlreadyMember;
			if (hasAlreadyMember)
			{
				num ^= this.AlreadyMember.GetHashCode();
			}
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x002728B0 File Offset: 0x00270AB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x002728C8 File Offset: 0x00270AC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x002728D4 File Offset: 0x00270AD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ObjectId);
			}
			bool hasAlreadyMember = this.HasAlreadyMember;
			if (hasAlreadyMember)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.AlreadyMember);
			}
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MemberId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x00272968 File Offset: 0x00270B68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool hasAlreadyMember = this.HasAlreadyMember;
			if (hasAlreadyMember)
			{
				num += 2;
			}
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x002729EC File Offset: 0x00270BEC
		[DebuggerNonUserCode]
		public void MergeFrom(JoinChannelResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				bool hasAlreadyMember = other.HasAlreadyMember;
				if (hasAlreadyMember)
				{
					this.AlreadyMember = other.AlreadyMember;
				}
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new EntityId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x00272A8F File Offset: 0x00270C8F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x00272A9C File Offset: 0x00270C9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.memberId_ == null;
							if (flag)
							{
								this.MemberId = new EntityId();
							}
							input.ReadMessage(this.MemberId);
						}
					}
					else
					{
						this.AlreadyMember = input.ReadBool();
					}
				}
				else
				{
					this.ObjectId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004883 RID: 18563
		private static readonly MessageParser<JoinChannelResponse> _parser = new MessageParser<JoinChannelResponse>(() => new JoinChannelResponse());

		// Token: 0x04004884 RID: 18564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004885 RID: 18565
		private int _hasBits0;

		// Token: 0x04004886 RID: 18566
		public const int ObjectIdFieldNumber = 1;

		// Token: 0x04004887 RID: 18567
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04004888 RID: 18568
		private ulong objectId_;

		// Token: 0x04004889 RID: 18569
		public const int AlreadyMemberFieldNumber = 4;

		// Token: 0x0400488A RID: 18570
		private static readonly bool AlreadyMemberDefaultValue = false;

		// Token: 0x0400488B RID: 18571
		private bool alreadyMember_;

		// Token: 0x0400488C RID: 18572
		public const int MemberIdFieldNumber = 5;

		// Token: 0x0400488D RID: 18573
		private EntityId memberId_;
	}
}

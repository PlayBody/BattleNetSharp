using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200041C RID: 1052
	public sealed class FriendInvitation : IMessage<FriendInvitation>, IMessage, IEquatable<FriendInvitation>, IDeepCloneable<FriendInvitation>, IBufferMessage
	{
		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x00191C0C File Offset: 0x0018FE0C
		[DebuggerNonUserCode]
		public static MessageParser<FriendInvitation> Parser
		{
			get
			{
				return FriendInvitation._parser;
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x00191C24 File Offset: 0x0018FE24
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x00191C48 File Offset: 0x0018FE48
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendInvitation.Descriptor;
			}
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00191C5F File Offset: 0x0018FE5F
		[DebuggerNonUserCode]
		public FriendInvitation()
		{
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x00191C7F File Offset: 0x0018FE7F
		[DebuggerNonUserCode]
		public FriendInvitation(FriendInvitation other)
			: this()
		{
			this.role_ = other.role_.Clone();
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x00191CBC File Offset: 0x0018FEBC
		[DebuggerNonUserCode]
		public FriendInvitation Clone()
		{
			return new FriendInvitation(this);
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x00191CD4 File Offset: 0x0018FED4
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x060067C1 RID: 26561 RVA: 0x00191CEC File Offset: 0x0018FEEC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x00191D04 File Offset: 0x0018FF04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendInvitation);
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x00191D24 File Offset: 0x0018FF24
		[DebuggerNonUserCode]
		public bool Equals(FriendInvitation other)
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
					bool flag4 = !this.role_.Equals(other.role_);
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

		// Token: 0x060067C4 RID: 26564 RVA: 0x00191D9C File Offset: 0x0018FF9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.role_.GetHashCode();
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00191DEC File Offset: 0x0018FFEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00191E04 File Offset: 0x00190004
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00191E10 File Offset: 0x00190010
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.role_.WriteTo(ref output, FriendInvitation._repeated_role_codec);
			this.attribute_.WriteTo(ref output, FriendInvitation._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00191E60 File Offset: 0x00190060
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.role_.CalculateSize(FriendInvitation._repeated_role_codec);
			num += this.attribute_.CalculateSize(FriendInvitation._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00191EB8 File Offset: 0x001900B8
		[DebuggerNonUserCode]
		public void MergeFrom(FriendInvitation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.role_.Add(other.role_);
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00191F0C File Offset: 0x0019010C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x00191F18 File Offset: 0x00190118
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U && num3 != 18U)
				{
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, FriendInvitation._repeated_attribute_codec);
					}
				}
				else
				{
					this.role_.AddEntriesFrom(ref input, FriendInvitation._repeated_role_codec);
				}
			}
		}

		// Token: 0x04002F31 RID: 12081
		private static readonly MessageParser<FriendInvitation> _parser = new MessageParser<FriendInvitation>(() => new FriendInvitation());

		// Token: 0x04002F32 RID: 12082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F33 RID: 12083
		public const int RoleFieldNumber = 2;

		// Token: 0x04002F34 RID: 12084
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04002F35 RID: 12085
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();

		// Token: 0x04002F36 RID: 12086
		public const int AttributeFieldNumber = 3;

		// Token: 0x04002F37 RID: 12087
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04002F38 RID: 12088
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

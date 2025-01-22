using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A0 RID: 1184
	public sealed class GetDescriptionRequest : IMessage<GetDescriptionRequest>, IMessage, IEquatable<GetDescriptionRequest>, IDeepCloneable<GetDescriptionRequest>, IBufferMessage
	{
		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x001C2284 File Offset: 0x001C0484
		[DebuggerNonUserCode]
		public static MessageParser<GetDescriptionRequest> Parser
		{
			get
			{
				return GetDescriptionRequest._parser;
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x001C229C File Offset: 0x001C049C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x001C22C0 File Offset: 0x001C04C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDescriptionRequest.Descriptor;
			}
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x001C22D7 File Offset: 0x001C04D7
		[DebuggerNonUserCode]
		public GetDescriptionRequest()
		{
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x001C22E4 File Offset: 0x001C04E4
		[DebuggerNonUserCode]
		public GetDescriptionRequest(GetDescriptionRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x001C2340 File Offset: 0x001C0540
		[DebuggerNonUserCode]
		public GetDescriptionRequest Clone()
		{
			return new GetDescriptionRequest(this);
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x001C2358 File Offset: 0x001C0558
		// (set) Token: 0x06007340 RID: 29504 RVA: 0x001C2370 File Offset: 0x001C0570
		[DebuggerNonUserCode]
		public MemberId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x001C237C File Offset: 0x001C057C
		// (set) Token: 0x06007342 RID: 29506 RVA: 0x001C23AD File Offset: 0x001C05AD
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = GetDescriptionRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x001C23C8 File Offset: 0x001C05C8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x001C23E5 File Offset: 0x001C05E5
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x001C23F8 File Offset: 0x001C05F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDescriptionRequest);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x001C2418 File Offset: 0x001C0618
		[DebuggerNonUserCode]
		public bool Equals(GetDescriptionRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClubId != other.ClubId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x001C248C File Offset: 0x001C068C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x001C24F8 File Offset: 0x001C06F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x001C2510 File Offset: 0x001C0710
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x001C251C File Offset: 0x001C071C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.ClubId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x001C2590 File Offset: 0x001C0790
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x001C2600 File Offset: 0x001C0800
		[DebuggerNonUserCode]
		public void MergeFrom(GetDescriptionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x001C2685 File Offset: 0x001C0885
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x001C2690 File Offset: 0x001C0890
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040034B0 RID: 13488
		private static readonly MessageParser<GetDescriptionRequest> _parser = new MessageParser<GetDescriptionRequest>(() => new GetDescriptionRequest());

		// Token: 0x040034B1 RID: 13489
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B2 RID: 13490
		private int _hasBits0;

		// Token: 0x040034B3 RID: 13491
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034B4 RID: 13492
		private MemberId agentId_;

		// Token: 0x040034B5 RID: 13493
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034B6 RID: 13494
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034B7 RID: 13495
		private ulong clubId_;
	}
}

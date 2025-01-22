using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049F RID: 1183
	public sealed class DestroyRequest : IMessage<DestroyRequest>, IMessage, IEquatable<DestroyRequest>, IDeepCloneable<DestroyRequest>, IBufferMessage
	{
		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06007322 RID: 29474 RVA: 0x001C1DD0 File Offset: 0x001BFFD0
		[DebuggerNonUserCode]
		public static MessageParser<DestroyRequest> Parser
		{
			get
			{
				return DestroyRequest._parser;
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06007323 RID: 29475 RVA: 0x001C1DE8 File Offset: 0x001BFFE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06007324 RID: 29476 RVA: 0x001C1E0C File Offset: 0x001C000C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyRequest.Descriptor;
			}
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x001C1E23 File Offset: 0x001C0023
		[DebuggerNonUserCode]
		public DestroyRequest()
		{
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x001C1E30 File Offset: 0x001C0030
		[DebuggerNonUserCode]
		public DestroyRequest(DestroyRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x001C1E8C File Offset: 0x001C008C
		[DebuggerNonUserCode]
		public DestroyRequest Clone()
		{
			return new DestroyRequest(this);
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06007328 RID: 29480 RVA: 0x001C1EA4 File Offset: 0x001C00A4
		// (set) Token: 0x06007329 RID: 29481 RVA: 0x001C1EBC File Offset: 0x001C00BC
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

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x001C1EC8 File Offset: 0x001C00C8
		// (set) Token: 0x0600732B RID: 29483 RVA: 0x001C1EF9 File Offset: 0x001C00F9
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
					clubIdDefaultValue = DestroyRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x001C1F14 File Offset: 0x001C0114
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x001C1F31 File Offset: 0x001C0131
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x001C1F44 File Offset: 0x001C0144
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyRequest);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x001C1F64 File Offset: 0x001C0164
		[DebuggerNonUserCode]
		public bool Equals(DestroyRequest other)
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

		// Token: 0x06007330 RID: 29488 RVA: 0x001C1FD8 File Offset: 0x001C01D8
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

		// Token: 0x06007331 RID: 29489 RVA: 0x001C2044 File Offset: 0x001C0244
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x001C205C File Offset: 0x001C025C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x001C2068 File Offset: 0x001C0268
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

		// Token: 0x06007334 RID: 29492 RVA: 0x001C20DC File Offset: 0x001C02DC
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

		// Token: 0x06007335 RID: 29493 RVA: 0x001C214C File Offset: 0x001C034C
		[DebuggerNonUserCode]
		public void MergeFrom(DestroyRequest other)
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

		// Token: 0x06007336 RID: 29494 RVA: 0x001C21D1 File Offset: 0x001C03D1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x001C21DC File Offset: 0x001C03DC
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

		// Token: 0x040034A8 RID: 13480
		private static readonly MessageParser<DestroyRequest> _parser = new MessageParser<DestroyRequest>(() => new DestroyRequest());

		// Token: 0x040034A9 RID: 13481
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034AA RID: 13482
		private int _hasBits0;

		// Token: 0x040034AB RID: 13483
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040034AC RID: 13484
		private MemberId agentId_;

		// Token: 0x040034AD RID: 13485
		public const int ClubIdFieldNumber = 2;

		// Token: 0x040034AE RID: 13486
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034AF RID: 13487
		private ulong clubId_;
	}
}

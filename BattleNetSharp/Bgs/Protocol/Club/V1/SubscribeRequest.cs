using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049B RID: 1179
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x060072CA RID: 29386 RVA: 0x001C0C48 File Offset: 0x001BEE48
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x001C0C60 File Offset: 0x001BEE60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x001C0C84 File Offset: 0x001BEE84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x001C0C9B File Offset: 0x001BEE9B
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x001C0CA8 File Offset: 0x001BEEA8
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x001C0D04 File Offset: 0x001BEF04
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x060072D0 RID: 29392 RVA: 0x001C0D1C File Offset: 0x001BEF1C
		// (set) Token: 0x060072D1 RID: 29393 RVA: 0x001C0D34 File Offset: 0x001BEF34
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

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x001C0D40 File Offset: 0x001BEF40
		// (set) Token: 0x060072D3 RID: 29395 RVA: 0x001C0D71 File Offset: 0x001BEF71
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
					clubIdDefaultValue = SubscribeRequest.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x001C0D8C File Offset: 0x001BEF8C
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x001C0DA9 File Offset: 0x001BEFA9
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x001C0DBC File Offset: 0x001BEFBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x001C0DDC File Offset: 0x001BEFDC
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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

		// Token: 0x060072D8 RID: 29400 RVA: 0x001C0E50 File Offset: 0x001BF050
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

		// Token: 0x060072D9 RID: 29401 RVA: 0x001C0EBC File Offset: 0x001BF0BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x001C0ED4 File Offset: 0x001BF0D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x001C0EE0 File Offset: 0x001BF0E0
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

		// Token: 0x060072DC RID: 29404 RVA: 0x001C0F54 File Offset: 0x001BF154
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

		// Token: 0x060072DD RID: 29405 RVA: 0x001C0FC4 File Offset: 0x001BF1C4
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
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

		// Token: 0x060072DE RID: 29406 RVA: 0x001C1049 File Offset: 0x001BF249
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x001C1054 File Offset: 0x001BF254
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

		// Token: 0x0400348C RID: 13452
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x0400348D RID: 13453
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400348E RID: 13454
		private int _hasBits0;

		// Token: 0x0400348F RID: 13455
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003490 RID: 13456
		private MemberId agentId_;

		// Token: 0x04003491 RID: 13457
		public const int ClubIdFieldNumber = 2;

		// Token: 0x04003492 RID: 13458
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003493 RID: 13459
		private ulong clubId_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006D8 RID: 1752
	public sealed class RemoveMemberRequest : IMessage<RemoveMemberRequest>, IMessage, IEquatable<RemoveMemberRequest>, IDeepCloneable<RemoveMemberRequest>, IBufferMessage
	{
		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x00275088 File Offset: 0x00273288
		[DebuggerNonUserCode]
		public static MessageParser<RemoveMemberRequest> Parser
		{
			get
			{
				return RemoveMemberRequest._parser;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x002750A0 File Offset: 0x002732A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A187 RID: 41351 RVA: 0x002750C4 File Offset: 0x002732C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveMemberRequest.Descriptor;
			}
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x002750DB File Offset: 0x002732DB
		[DebuggerNonUserCode]
		public RemoveMemberRequest()
		{
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x002750E8 File Offset: 0x002732E8
		[DebuggerNonUserCode]
		public RemoveMemberRequest(RemoveMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x00275160 File Offset: 0x00273360
		[DebuggerNonUserCode]
		public RemoveMemberRequest Clone()
		{
			return new RemoveMemberRequest(this);
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x00275178 File Offset: 0x00273378
		// (set) Token: 0x0600A18C RID: 41356 RVA: 0x00275190 File Offset: 0x00273390
		[DebuggerNonUserCode]
		public EntityId AgentId
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

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x0027519C File Offset: 0x0027339C
		// (set) Token: 0x0600A18E RID: 41358 RVA: 0x002751B4 File Offset: 0x002733B4
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

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A18F RID: 41359 RVA: 0x002751C0 File Offset: 0x002733C0
		// (set) Token: 0x0600A190 RID: 41360 RVA: 0x002751F1 File Offset: 0x002733F1
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = RemoveMemberRequest.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A191 RID: 41361 RVA: 0x0027520C File Offset: 0x0027340C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x00275229 File Offset: 0x00273429
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x0027523C File Offset: 0x0027343C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveMemberRequest);
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x0027525C File Offset: 0x0027345C
		[DebuggerNonUserCode]
		public bool Equals(RemoveMemberRequest other)
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
						bool flag5 = !object.Equals(this.MemberId, other.MemberId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x002752F0 File Offset: 0x002734F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x00275378 File Offset: 0x00273578
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x00275390 File Offset: 0x00273590
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0027539C File Offset: 0x0027359C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Reason);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x00275434 File Offset: 0x00273634
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x002754C4 File Offset: 0x002736C4
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveMemberRequest other)
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
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new EntityId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x0027558C File Offset: 0x0027378C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x00275598 File Offset: 0x00273798
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadUInt32();
						}
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
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040048C6 RID: 18630
		private static readonly MessageParser<RemoveMemberRequest> _parser = new MessageParser<RemoveMemberRequest>(() => new RemoveMemberRequest());

		// Token: 0x040048C7 RID: 18631
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048C8 RID: 18632
		private int _hasBits0;

		// Token: 0x040048C9 RID: 18633
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048CA RID: 18634
		private EntityId agentId_;

		// Token: 0x040048CB RID: 18635
		public const int MemberIdFieldNumber = 2;

		// Token: 0x040048CC RID: 18636
		private EntityId memberId_;

		// Token: 0x040048CD RID: 18637
		public const int ReasonFieldNumber = 3;

		// Token: 0x040048CE RID: 18638
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x040048CF RID: 18639
		private uint reason_;
	}
}

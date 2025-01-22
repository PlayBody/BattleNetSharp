using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006DC RID: 1756
	public sealed class DissolveRequest : IMessage<DissolveRequest>, IMessage, IEquatable<DissolveRequest>, IDeepCloneable<DissolveRequest>, IBufferMessage
	{
		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x0027661C File Offset: 0x0027481C
		[DebuggerNonUserCode]
		public static MessageParser<DissolveRequest> Parser
		{
			get
			{
				return DissolveRequest._parser;
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x00276634 File Offset: 0x00274834
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x00276658 File Offset: 0x00274858
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveRequest.Descriptor;
			}
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x0027666F File Offset: 0x0027486F
		[DebuggerNonUserCode]
		public DissolveRequest()
		{
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x0027667C File Offset: 0x0027487C
		[DebuggerNonUserCode]
		public DissolveRequest(DissolveRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x002766D8 File Offset: 0x002748D8
		[DebuggerNonUserCode]
		public DissolveRequest Clone()
		{
			return new DissolveRequest(this);
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x002766F0 File Offset: 0x002748F0
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x00276708 File Offset: 0x00274908
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

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x00276714 File Offset: 0x00274914
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x00276745 File Offset: 0x00274945
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
					reasonDefaultValue = DissolveRequest.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x00276760 File Offset: 0x00274960
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x0027677D File Offset: 0x0027497D
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00276790 File Offset: 0x00274990
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveRequest);
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x002767B0 File Offset: 0x002749B0
		[DebuggerNonUserCode]
		public bool Equals(DissolveRequest other)
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
						bool flag5 = this.Reason != other.Reason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00276824 File Offset: 0x00274A24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x00276890 File Offset: 0x00274A90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x002768A8 File Offset: 0x00274AA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x002768B4 File Offset: 0x00274AB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00276928 File Offset: 0x00274B28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x00276998 File Offset: 0x00274B98
		[DebuggerNonUserCode]
		public void MergeFrom(DissolveRequest other)
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
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x00276A1D File Offset: 0x00274C1D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x00276A28 File Offset: 0x00274C28
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
						this.Reason = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.agentId_ == null;
					if (flag)
					{
						this.AgentId = new EntityId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040048EA RID: 18666
		private static readonly MessageParser<DissolveRequest> _parser = new MessageParser<DissolveRequest>(() => new DissolveRequest());

		// Token: 0x040048EB RID: 18667
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048EC RID: 18668
		private int _hasBits0;

		// Token: 0x040048ED RID: 18669
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040048EE RID: 18670
		private EntityId agentId_;

		// Token: 0x040048EF RID: 18671
		public const int ReasonFieldNumber = 2;

		// Token: 0x040048F0 RID: 18672
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x040048F1 RID: 18673
		private uint reason_;
	}
}

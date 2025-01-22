using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A5 RID: 1445
	public sealed class OwnershipRequest : IMessage<OwnershipRequest>, IMessage, IEquatable<OwnershipRequest>, IDeepCloneable<OwnershipRequest>, IBufferMessage
	{
		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x06008986 RID: 35206 RVA: 0x00216534 File Offset: 0x00214734
		[DebuggerNonUserCode]
		public static MessageParser<OwnershipRequest> Parser
		{
			get
			{
				return OwnershipRequest._parser;
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x0021654C File Offset: 0x0021474C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x06008988 RID: 35208 RVA: 0x00216570 File Offset: 0x00214770
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OwnershipRequest.Descriptor;
			}
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x00216587 File Offset: 0x00214787
		[DebuggerNonUserCode]
		public OwnershipRequest()
		{
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x00216594 File Offset: 0x00214794
		[DebuggerNonUserCode]
		public OwnershipRequest(OwnershipRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.releaseOwnership_ = other.releaseOwnership_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x002165F0 File Offset: 0x002147F0
		[DebuggerNonUserCode]
		public OwnershipRequest Clone()
		{
			return new OwnershipRequest(this);
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600898C RID: 35212 RVA: 0x00216608 File Offset: 0x00214808
		// (set) Token: 0x0600898D RID: 35213 RVA: 0x00216620 File Offset: 0x00214820
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x0021662C File Offset: 0x0021482C
		// (set) Token: 0x0600898F RID: 35215 RVA: 0x0021665D File Offset: 0x0021485D
		[DebuggerNonUserCode]
		public bool ReleaseOwnership
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool releaseOwnershipDefaultValue;
				if (flag)
				{
					releaseOwnershipDefaultValue = this.releaseOwnership_;
				}
				else
				{
					releaseOwnershipDefaultValue = OwnershipRequest.ReleaseOwnershipDefaultValue;
				}
				return releaseOwnershipDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.releaseOwnership_ = value;
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x00216678 File Offset: 0x00214878
		[DebuggerNonUserCode]
		public bool HasReleaseOwnership
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x00216695 File Offset: 0x00214895
		[DebuggerNonUserCode]
		public void ClearReleaseOwnership()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x002166A8 File Offset: 0x002148A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OwnershipRequest);
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x002166C8 File Offset: 0x002148C8
		[DebuggerNonUserCode]
		public bool Equals(OwnershipRequest other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ReleaseOwnership != other.ReleaseOwnership;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x0021673C File Offset: 0x0021493C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasReleaseOwnership = this.HasReleaseOwnership;
			if (hasReleaseOwnership)
			{
				num ^= this.ReleaseOwnership.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x002167A8 File Offset: 0x002149A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x002167C0 File Offset: 0x002149C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x002167CC File Offset: 0x002149CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			bool hasReleaseOwnership = this.HasReleaseOwnership;
			if (hasReleaseOwnership)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ReleaseOwnership);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x00216840 File Offset: 0x00214A40
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasReleaseOwnership = this.HasReleaseOwnership;
			if (hasReleaseOwnership)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x002168A4 File Offset: 0x00214AA4
		[DebuggerNonUserCode]
		public void MergeFrom(OwnershipRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasReleaseOwnership = other.HasReleaseOwnership;
				if (hasReleaseOwnership)
				{
					this.ReleaseOwnership = other.ReleaseOwnership;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x00216929 File Offset: 0x00214B29
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x00216934 File Offset: 0x00214B34
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
						this.ReleaseOwnership = input.ReadBool();
					}
				}
				else
				{
					bool flag = this.entityId_ == null;
					if (flag)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04003E39 RID: 15929
		private static readonly MessageParser<OwnershipRequest> _parser = new MessageParser<OwnershipRequest>(() => new OwnershipRequest());

		// Token: 0x04003E3A RID: 15930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E3B RID: 15931
		private int _hasBits0;

		// Token: 0x04003E3C RID: 15932
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E3D RID: 15933
		private EntityId entityId_;

		// Token: 0x04003E3E RID: 15934
		public const int ReleaseOwnershipFieldNumber = 2;

		// Token: 0x04003E3F RID: 15935
		private static readonly bool ReleaseOwnershipDefaultValue = false;

		// Token: 0x04003E40 RID: 15936
		private bool releaseOwnership_;
	}
}

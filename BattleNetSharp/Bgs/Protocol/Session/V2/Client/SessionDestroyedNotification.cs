using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000554 RID: 1364
	public sealed class SessionDestroyedNotification : IMessage<SessionDestroyedNotification>, IMessage, IEquatable<SessionDestroyedNotification>, IDeepCloneable<SessionDestroyedNotification>, IBufferMessage
	{
		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x060083D1 RID: 33745 RVA: 0x00200FEC File Offset: 0x001FF1EC
		[DebuggerNonUserCode]
		public static MessageParser<SessionDestroyedNotification> Parser
		{
			get
			{
				return SessionDestroyedNotification._parser;
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x00201004 File Offset: 0x001FF204
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionListenerReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060083D3 RID: 33747 RVA: 0x00201028 File Offset: 0x001FF228
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionDestroyedNotification.Descriptor;
			}
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0020103F File Offset: 0x001FF23F
		[DebuggerNonUserCode]
		public SessionDestroyedNotification()
		{
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x00201049 File Offset: 0x001FF249
		[DebuggerNonUserCode]
		public SessionDestroyedNotification(SessionDestroyedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.status_ = other.status_;
			this.statusDetails_ = other.statusDetails_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x00201088 File Offset: 0x001FF288
		[DebuggerNonUserCode]
		public SessionDestroyedNotification Clone()
		{
			return new SessionDestroyedNotification(this);
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060083D7 RID: 33751 RVA: 0x002010A0 File Offset: 0x001FF2A0
		// (set) Token: 0x060083D8 RID: 33752 RVA: 0x002010D1 File Offset: 0x001FF2D1
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = SessionDestroyedNotification.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060083D9 RID: 33753 RVA: 0x002010EC File Offset: 0x001FF2EC
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x00201109 File Offset: 0x001FF309
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060083DB RID: 33755 RVA: 0x0020111C File Offset: 0x001FF31C
		// (set) Token: 0x060083DC RID: 33756 RVA: 0x0020114D File Offset: 0x001FF34D
		[DebuggerNonUserCode]
		public uint StatusDetails
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint statusDetailsDefaultValue;
				if (flag)
				{
					statusDetailsDefaultValue = this.statusDetails_;
				}
				else
				{
					statusDetailsDefaultValue = SessionDestroyedNotification.StatusDetailsDefaultValue;
				}
				return statusDetailsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.statusDetails_ = value;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x060083DD RID: 33757 RVA: 0x00201168 File Offset: 0x001FF368
		[DebuggerNonUserCode]
		public bool HasStatusDetails
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x00201185 File Offset: 0x001FF385
		[DebuggerNonUserCode]
		public void ClearStatusDetails()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x00201198 File Offset: 0x001FF398
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionDestroyedNotification);
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x002011B8 File Offset: 0x001FF3B8
		[DebuggerNonUserCode]
		public bool Equals(SessionDestroyedNotification other)
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
					bool flag4 = this.Status != other.Status;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StatusDetails != other.StatusDetails;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0020122C File Offset: 0x001FF42C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool hasStatusDetails = this.HasStatusDetails;
			if (hasStatusDetails)
			{
				num ^= this.StatusDetails.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x00201298 File Offset: 0x001FF498
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x002012B0 File Offset: 0x001FF4B0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x002012BC File Offset: 0x001FF4BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Status);
			}
			bool hasStatusDetails = this.HasStatusDetails;
			if (hasStatusDetails)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.StatusDetails);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x0020132C File Offset: 0x001FF52C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool hasStatusDetails = this.HasStatusDetails;
			if (hasStatusDetails)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StatusDetails);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x00201398 File Offset: 0x001FF598
		[DebuggerNonUserCode]
		public void MergeFrom(SessionDestroyedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				bool hasStatusDetails = other.HasStatusDetails;
				if (hasStatusDetails)
				{
					this.StatusDetails = other.StatusDetails;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x002013FA File Offset: 0x001FF5FA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x00201408 File Offset: 0x001FF608
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StatusDetails = input.ReadUInt32();
					}
				}
				else
				{
					this.Status = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BD9 RID: 15321
		private static readonly MessageParser<SessionDestroyedNotification> _parser = new MessageParser<SessionDestroyedNotification>(() => new SessionDestroyedNotification());

		// Token: 0x04003BDA RID: 15322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BDB RID: 15323
		private int _hasBits0;

		// Token: 0x04003BDC RID: 15324
		public const int StatusFieldNumber = 1;

		// Token: 0x04003BDD RID: 15325
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04003BDE RID: 15326
		private uint status_;

		// Token: 0x04003BDF RID: 15327
		public const int StatusDetailsFieldNumber = 2;

		// Token: 0x04003BE0 RID: 15328
		private static readonly uint StatusDetailsDefaultValue = 0U;

		// Token: 0x04003BE1 RID: 15329
		private uint statusDetails_;
	}
}

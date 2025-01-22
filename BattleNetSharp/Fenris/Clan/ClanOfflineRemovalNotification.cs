using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002BE RID: 702
	public sealed class ClanOfflineRemovalNotification : IMessage<ClanOfflineRemovalNotification>, IMessage, IEquatable<ClanOfflineRemovalNotification>, IDeepCloneable<ClanOfflineRemovalNotification>, IBufferMessage
	{
		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x0011E970 File Offset: 0x0011CB70
		[DebuggerNonUserCode]
		public static MessageParser<ClanOfflineRemovalNotification> Parser
		{
			get
			{
				return ClanOfflineRemovalNotification._parser;
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004ACF RID: 19151 RVA: 0x0011E988 File Offset: 0x0011CB88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x0011E9AC File Offset: 0x0011CBAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanOfflineRemovalNotification.Descriptor;
			}
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x0011E9C3 File Offset: 0x0011CBC3
		[DebuggerNonUserCode]
		public ClanOfflineRemovalNotification()
		{
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x0011E9CD File Offset: 0x0011CBCD
		[DebuggerNonUserCode]
		public ClanOfflineRemovalNotification(ClanOfflineRemovalNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.reason_ = other.reason_;
			this.removalTime_ = other.removalTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0011EA0C File Offset: 0x0011CC0C
		[DebuggerNonUserCode]
		public ClanOfflineRemovalNotification Clone()
		{
			return new ClanOfflineRemovalNotification(this);
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x0011EA24 File Offset: 0x0011CC24
		// (set) Token: 0x06004AD5 RID: 19157 RVA: 0x0011EA55 File Offset: 0x0011CC55
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
					reasonDefaultValue = ClanOfflineRemovalNotification.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.reason_ = value;
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x0011EA70 File Offset: 0x0011CC70
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0011EA8D File Offset: 0x0011CC8D
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004AD8 RID: 19160 RVA: 0x0011EAA0 File Offset: 0x0011CCA0
		// (set) Token: 0x06004AD9 RID: 19161 RVA: 0x0011EAD1 File Offset: 0x0011CCD1
		[DebuggerNonUserCode]
		public ulong RemovalTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong removalTimeDefaultValue;
				if (flag)
				{
					removalTimeDefaultValue = this.removalTime_;
				}
				else
				{
					removalTimeDefaultValue = ClanOfflineRemovalNotification.RemovalTimeDefaultValue;
				}
				return removalTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.removalTime_ = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004ADA RID: 19162 RVA: 0x0011EAEC File Offset: 0x0011CCEC
		[DebuggerNonUserCode]
		public bool HasRemovalTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0011EB09 File Offset: 0x0011CD09
		[DebuggerNonUserCode]
		public void ClearRemovalTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0011EB1C File Offset: 0x0011CD1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanOfflineRemovalNotification);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0011EB3C File Offset: 0x0011CD3C
		[DebuggerNonUserCode]
		public bool Equals(ClanOfflineRemovalNotification other)
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
					bool flag4 = this.Reason != other.Reason;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RemovalTime != other.RemovalTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x0011EBB0 File Offset: 0x0011CDB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				num ^= this.RemovalTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0011EC20 File Offset: 0x0011CE20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0011EC38 File Offset: 0x0011CE38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0011EC44 File Offset: 0x0011CE44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Reason);
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.RemovalTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0011ECB4 File Offset: 0x0011CEB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool hasRemovalTime = this.HasRemovalTime;
			if (hasRemovalTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RemovalTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0011ED20 File Offset: 0x0011CF20
		[DebuggerNonUserCode]
		public void MergeFrom(ClanOfflineRemovalNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				bool hasRemovalTime = other.HasRemovalTime;
				if (hasRemovalTime)
				{
					this.RemovalTime = other.RemovalTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0011ED82 File Offset: 0x0011CF82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x0011ED90 File Offset: 0x0011CF90
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
						this.RemovalTime = input.ReadUInt64();
					}
				}
				else
				{
					this.Reason = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400216D RID: 8557
		private static readonly MessageParser<ClanOfflineRemovalNotification> _parser = new MessageParser<ClanOfflineRemovalNotification>(() => new ClanOfflineRemovalNotification());

		// Token: 0x0400216E RID: 8558
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400216F RID: 8559
		private int _hasBits0;

		// Token: 0x04002170 RID: 8560
		public const int ReasonFieldNumber = 1;

		// Token: 0x04002171 RID: 8561
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04002172 RID: 8562
		private uint reason_;

		// Token: 0x04002173 RID: 8563
		public const int RemovalTimeFieldNumber = 2;

		// Token: 0x04002174 RID: 8564
		private static readonly ulong RemovalTimeDefaultValue = 0UL;

		// Token: 0x04002175 RID: 8565
		private ulong removalTime_;
	}
}

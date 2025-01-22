using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E8 RID: 488
	public sealed class DebugCombatLogVulnerableEvent : IMessage<DebugCombatLogVulnerableEvent>, IMessage, IEquatable<DebugCombatLogVulnerableEvent>, IDeepCloneable<DebugCombatLogVulnerableEvent>, IBufferMessage
	{
		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000D1C84 File Offset: 0x000CFE84
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatLogVulnerableEvent> Parser
		{
			get
			{
				return DebugCombatLogVulnerableEvent._parser;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x000D1C9C File Offset: 0x000CFE9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[45];
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000D1CC0 File Offset: 0x000CFEC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatLogVulnerableEvent.Descriptor;
			}
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x000D1CD7 File Offset: 0x000CFED7
		[DebuggerNonUserCode]
		public DebugCombatLogVulnerableEvent()
		{
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000D1CE1 File Offset: 0x000CFEE1
		[DebuggerNonUserCode]
		public DebugCombatLogVulnerableEvent(DebugCombatLogVulnerableEvent other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.vulnerableApplied_ = other.vulnerableApplied_;
			this.vulnerableIsRefresh_ = other.vulnerableIsRefresh_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000D1D20 File Offset: 0x000CFF20
		[DebuggerNonUserCode]
		public DebugCombatLogVulnerableEvent Clone()
		{
			return new DebugCombatLogVulnerableEvent(this);
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000D1D38 File Offset: 0x000CFF38
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x000D1D69 File Offset: 0x000CFF69
		[DebuggerNonUserCode]
		public bool VulnerableApplied
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool vulnerableAppliedDefaultValue;
				if (flag)
				{
					vulnerableAppliedDefaultValue = this.vulnerableApplied_;
				}
				else
				{
					vulnerableAppliedDefaultValue = DebugCombatLogVulnerableEvent.VulnerableAppliedDefaultValue;
				}
				return vulnerableAppliedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.vulnerableApplied_ = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x000D1D84 File Offset: 0x000CFF84
		[DebuggerNonUserCode]
		public bool HasVulnerableApplied
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000D1DA1 File Offset: 0x000CFFA1
		[DebuggerNonUserCode]
		public void ClearVulnerableApplied()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x000D1DB4 File Offset: 0x000CFFB4
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x000D1DE5 File Offset: 0x000CFFE5
		[DebuggerNonUserCode]
		public bool VulnerableIsRefresh
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool vulnerableIsRefreshDefaultValue;
				if (flag)
				{
					vulnerableIsRefreshDefaultValue = this.vulnerableIsRefresh_;
				}
				else
				{
					vulnerableIsRefreshDefaultValue = DebugCombatLogVulnerableEvent.VulnerableIsRefreshDefaultValue;
				}
				return vulnerableIsRefreshDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.vulnerableIsRefresh_ = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x000D1E00 File Offset: 0x000D0000
		[DebuggerNonUserCode]
		public bool HasVulnerableIsRefresh
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000D1E1D File Offset: 0x000D001D
		[DebuggerNonUserCode]
		public void ClearVulnerableIsRefresh()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000D1E30 File Offset: 0x000D0030
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatLogVulnerableEvent);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000D1E50 File Offset: 0x000D0050
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatLogVulnerableEvent other)
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
					bool flag4 = this.VulnerableApplied != other.VulnerableApplied;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.VulnerableIsRefresh != other.VulnerableIsRefresh;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x000D1EC4 File Offset: 0x000D00C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVulnerableApplied = this.HasVulnerableApplied;
			if (hasVulnerableApplied)
			{
				num ^= this.VulnerableApplied.GetHashCode();
			}
			bool hasVulnerableIsRefresh = this.HasVulnerableIsRefresh;
			if (hasVulnerableIsRefresh)
			{
				num ^= this.VulnerableIsRefresh.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x000D1F30 File Offset: 0x000D0130
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000D1F48 File Offset: 0x000D0148
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000D1F54 File Offset: 0x000D0154
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVulnerableApplied = this.HasVulnerableApplied;
			if (hasVulnerableApplied)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.VulnerableApplied);
			}
			bool hasVulnerableIsRefresh = this.HasVulnerableIsRefresh;
			if (hasVulnerableIsRefresh)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.VulnerableIsRefresh);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000D1FC4 File Offset: 0x000D01C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVulnerableApplied = this.HasVulnerableApplied;
			if (hasVulnerableApplied)
			{
				num += 2;
			}
			bool hasVulnerableIsRefresh = this.HasVulnerableIsRefresh;
			if (hasVulnerableIsRefresh)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000D2018 File Offset: 0x000D0218
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatLogVulnerableEvent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVulnerableApplied = other.HasVulnerableApplied;
				if (hasVulnerableApplied)
				{
					this.VulnerableApplied = other.VulnerableApplied;
				}
				bool hasVulnerableIsRefresh = other.HasVulnerableIsRefresh;
				if (hasVulnerableIsRefresh)
				{
					this.VulnerableIsRefresh = other.VulnerableIsRefresh;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000D207A File Offset: 0x000D027A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x000D2088 File Offset: 0x000D0288
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
						this.VulnerableIsRefresh = input.ReadBool();
					}
				}
				else
				{
					this.VulnerableApplied = input.ReadBool();
				}
			}
		}

		// Token: 0x04001890 RID: 6288
		private static readonly MessageParser<DebugCombatLogVulnerableEvent> _parser = new MessageParser<DebugCombatLogVulnerableEvent>(() => new DebugCombatLogVulnerableEvent());

		// Token: 0x04001891 RID: 6289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001892 RID: 6290
		private int _hasBits0;

		// Token: 0x04001893 RID: 6291
		public const int VulnerableAppliedFieldNumber = 1;

		// Token: 0x04001894 RID: 6292
		private static readonly bool VulnerableAppliedDefaultValue = false;

		// Token: 0x04001895 RID: 6293
		private bool vulnerableApplied_;

		// Token: 0x04001896 RID: 6294
		public const int VulnerableIsRefreshFieldNumber = 2;

		// Token: 0x04001897 RID: 6295
		private static readonly bool VulnerableIsRefreshDefaultValue = false;

		// Token: 0x04001898 RID: 6296
		private bool vulnerableIsRefresh_;
	}
}

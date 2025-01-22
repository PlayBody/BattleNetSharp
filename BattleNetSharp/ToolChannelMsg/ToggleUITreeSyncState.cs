using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A3 RID: 163
	public sealed class ToggleUITreeSyncState : IMessage<ToggleUITreeSyncState>, IMessage, IEquatable<ToggleUITreeSyncState>, IDeepCloneable<ToggleUITreeSyncState>, IBufferMessage
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0003771C File Offset: 0x0003591C
		[DebuggerNonUserCode]
		public static MessageParser<ToggleUITreeSyncState> Parser
		{
			get
			{
				return ToggleUITreeSyncState._parser;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00037734 File Offset: 0x00035934
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[140];
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0003775C File Offset: 0x0003595C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToggleUITreeSyncState.Descriptor;
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00037773 File Offset: 0x00035973
		[DebuggerNonUserCode]
		public ToggleUITreeSyncState()
		{
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0003777D File Offset: 0x0003597D
		[DebuggerNonUserCode]
		public ToggleUITreeSyncState(ToggleUITreeSyncState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000377B0 File Offset: 0x000359B0
		[DebuggerNonUserCode]
		public ToggleUITreeSyncState Clone()
		{
			return new ToggleUITreeSyncState(this);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x000377C8 File Offset: 0x000359C8
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x000377F9 File Offset: 0x000359F9
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = ToggleUITreeSyncState.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00037814 File Offset: 0x00035A14
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00037831 File Offset: 0x00035A31
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00037844 File Offset: 0x00035A44
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToggleUITreeSyncState);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00037864 File Offset: 0x00035A64
		[DebuggerNonUserCode]
		public bool Equals(ToggleUITreeSyncState other)
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
					bool flag4 = this.Enabled != other.Enabled;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000378BC File Offset: 0x00035ABC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003790C File Offset: 0x00035B0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00037924 File Offset: 0x00035B24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00037930 File Offset: 0x00035B30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003797C File Offset: 0x00035B7C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
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

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000379C0 File Offset: 0x00035BC0
		[DebuggerNonUserCode]
		public void MergeFrom(ToggleUITreeSyncState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00037A09 File Offset: 0x00035C09
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00037A14 File Offset: 0x00035C14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x040005EE RID: 1518
		private static readonly MessageParser<ToggleUITreeSyncState> _parser = new MessageParser<ToggleUITreeSyncState>(() => new ToggleUITreeSyncState());

		// Token: 0x040005EF RID: 1519
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005F0 RID: 1520
		private int _hasBits0;

		// Token: 0x040005F1 RID: 1521
		public const int EnabledFieldNumber = 1;

		// Token: 0x040005F2 RID: 1522
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x040005F3 RID: 1523
		private bool enabled_;
	}
}

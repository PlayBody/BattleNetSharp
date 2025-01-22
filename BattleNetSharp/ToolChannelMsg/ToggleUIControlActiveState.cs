using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A1 RID: 161
	public sealed class ToggleUIControlActiveState : IMessage<ToggleUIControlActiveState>, IMessage, IEquatable<ToggleUIControlActiveState>, IDeepCloneable<ToggleUIControlActiveState>, IBufferMessage
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00036DBC File Offset: 0x00034FBC
		[DebuggerNonUserCode]
		public static MessageParser<ToggleUIControlActiveState> Parser
		{
			get
			{
				return ToggleUIControlActiveState._parser;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00036DD4 File Offset: 0x00034FD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[138];
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x00036DFC File Offset: 0x00034FFC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToggleUIControlActiveState.Descriptor;
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00036E13 File Offset: 0x00035013
		[DebuggerNonUserCode]
		public ToggleUIControlActiveState()
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00036E1D File Offset: 0x0003501D
		[DebuggerNonUserCode]
		public ToggleUIControlActiveState(ToggleUIControlActiveState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00036E50 File Offset: 0x00035050
		[DebuggerNonUserCode]
		public ToggleUIControlActiveState Clone()
		{
			return new ToggleUIControlActiveState(this);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00036E68 File Offset: 0x00035068
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00036E99 File Offset: 0x00035099
		[DebuggerNonUserCode]
		public ulong Hash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong hashDefaultValue;
				if (flag)
				{
					hashDefaultValue = this.hash_;
				}
				else
				{
					hashDefaultValue = ToggleUIControlActiveState.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00036EB4 File Offset: 0x000350B4
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00036ED1 File Offset: 0x000350D1
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00036EE4 File Offset: 0x000350E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToggleUIControlActiveState);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00036F04 File Offset: 0x00035104
		[DebuggerNonUserCode]
		public bool Equals(ToggleUIControlActiveState other)
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
					bool flag4 = this.Hash != other.Hash;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00036F5C File Offset: 0x0003515C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00036FAC File Offset: 0x000351AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00036FC4 File Offset: 0x000351C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00036FD0 File Offset: 0x000351D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003701C File Offset: 0x0003521C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003706C File Offset: 0x0003526C
		[DebuggerNonUserCode]
		public void MergeFrom(ToggleUIControlActiveState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000370B5 File Offset: 0x000352B5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000370C0 File Offset: 0x000352C0
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
					this.Hash = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040005DC RID: 1500
		private static readonly MessageParser<ToggleUIControlActiveState> _parser = new MessageParser<ToggleUIControlActiveState>(() => new ToggleUIControlActiveState());

		// Token: 0x040005DD RID: 1501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005DE RID: 1502
		private int _hasBits0;

		// Token: 0x040005DF RID: 1503
		public const int HashFieldNumber = 1;

		// Token: 0x040005E0 RID: 1504
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005E1 RID: 1505
		private ulong hash_;
	}
}

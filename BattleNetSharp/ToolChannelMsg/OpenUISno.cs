using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A4 RID: 164
	public sealed class OpenUISno : IMessage<OpenUISno>, IMessage, IEquatable<OpenUISno>, IDeepCloneable<OpenUISno>, IBufferMessage
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00037A88 File Offset: 0x00035C88
		[DebuggerNonUserCode]
		public static MessageParser<OpenUISno> Parser
		{
			get
			{
				return OpenUISno._parser;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00037AA0 File Offset: 0x00035CA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[141];
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00037AC8 File Offset: 0x00035CC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenUISno.Descriptor;
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00037ADF File Offset: 0x00035CDF
		[DebuggerNonUserCode]
		public OpenUISno()
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00037AE9 File Offset: 0x00035CE9
		[DebuggerNonUserCode]
		public OpenUISno(OpenUISno other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00037B1C File Offset: 0x00035D1C
		[DebuggerNonUserCode]
		public OpenUISno Clone()
		{
			return new OpenUISno(this);
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00037B34 File Offset: 0x00035D34
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00037B65 File Offset: 0x00035D65
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
					hashDefaultValue = OpenUISno.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00037B80 File Offset: 0x00035D80
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00037B9D File Offset: 0x00035D9D
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00037BB0 File Offset: 0x00035DB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenUISno);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00037BD0 File Offset: 0x00035DD0
		[DebuggerNonUserCode]
		public bool Equals(OpenUISno other)
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

		// Token: 0x06000F07 RID: 3847 RVA: 0x00037C28 File Offset: 0x00035E28
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

		// Token: 0x06000F08 RID: 3848 RVA: 0x00037C78 File Offset: 0x00035E78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00037C90 File Offset: 0x00035E90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00037C9C File Offset: 0x00035E9C
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

		// Token: 0x06000F0B RID: 3851 RVA: 0x00037CE8 File Offset: 0x00035EE8
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

		// Token: 0x06000F0C RID: 3852 RVA: 0x00037D38 File Offset: 0x00035F38
		[DebuggerNonUserCode]
		public void MergeFrom(OpenUISno other)
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

		// Token: 0x06000F0D RID: 3853 RVA: 0x00037D81 File Offset: 0x00035F81
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00037D8C File Offset: 0x00035F8C
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

		// Token: 0x040005F4 RID: 1524
		private static readonly MessageParser<OpenUISno> _parser = new MessageParser<OpenUISno>(() => new OpenUISno());

		// Token: 0x040005F5 RID: 1525
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005F6 RID: 1526
		private int _hasBits0;

		// Token: 0x040005F7 RID: 1527
		public const int HashFieldNumber = 1;

		// Token: 0x040005F8 RID: 1528
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x040005F9 RID: 1529
		private ulong hash_;
	}
}

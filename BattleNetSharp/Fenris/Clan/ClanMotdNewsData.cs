using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002BA RID: 698
	public sealed class ClanMotdNewsData : IMessage<ClanMotdNewsData>, IMessage, IEquatable<ClanMotdNewsData>, IDeepCloneable<ClanMotdNewsData>, IBufferMessage
	{
		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06004A5B RID: 19035 RVA: 0x0011CE8C File Offset: 0x0011B08C
		[DebuggerNonUserCode]
		public static MessageParser<ClanMotdNewsData> Parser
		{
			get
			{
				return ClanMotdNewsData._parser;
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x0011CEA4 File Offset: 0x0011B0A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06004A5D RID: 19037 RVA: 0x0011CEC8 File Offset: 0x0011B0C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanMotdNewsData.Descriptor;
			}
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x0011CEDF File Offset: 0x0011B0DF
		[DebuggerNonUserCode]
		public ClanMotdNewsData()
		{
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0011CEE9 File Offset: 0x0011B0E9
		[DebuggerNonUserCode]
		public ClanMotdNewsData(ClanMotdNewsData other)
			: this()
		{
			this.newMotd_ = other.newMotd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0011CF10 File Offset: 0x0011B110
		[DebuggerNonUserCode]
		public ClanMotdNewsData Clone()
		{
			return new ClanMotdNewsData(this);
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06004A61 RID: 19041 RVA: 0x0011CF28 File Offset: 0x0011B128
		// (set) Token: 0x06004A62 RID: 19042 RVA: 0x0011CF49 File Offset: 0x0011B149
		[DebuggerNonUserCode]
		public string NewMotd
		{
			get
			{
				return this.newMotd_ ?? ClanMotdNewsData.NewMotdDefaultValue;
			}
			set
			{
				this.newMotd_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x0011CF60 File Offset: 0x0011B160
		[DebuggerNonUserCode]
		public bool HasNewMotd
		{
			get
			{
				return this.newMotd_ != null;
			}
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0011CF7B File Offset: 0x0011B17B
		[DebuggerNonUserCode]
		public void ClearNewMotd()
		{
			this.newMotd_ = null;
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0011CF88 File Offset: 0x0011B188
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanMotdNewsData);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x0011CFA8 File Offset: 0x0011B1A8
		[DebuggerNonUserCode]
		public bool Equals(ClanMotdNewsData other)
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
					bool flag4 = this.NewMotd != other.NewMotd;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x0011D000 File Offset: 0x0011B200
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNewMotd = this.HasNewMotd;
			if (hasNewMotd)
			{
				num ^= this.NewMotd.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0011D04C File Offset: 0x0011B24C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0011D064 File Offset: 0x0011B264
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0011D070 File Offset: 0x0011B270
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNewMotd = this.HasNewMotd;
			if (hasNewMotd)
			{
				output.WriteRawTag(10);
				output.WriteString(this.NewMotd);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0011D0BC File Offset: 0x0011B2BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNewMotd = this.HasNewMotd;
			if (hasNewMotd)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NewMotd);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x0011D10C File Offset: 0x0011B30C
		[DebuggerNonUserCode]
		public void MergeFrom(ClanMotdNewsData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNewMotd = other.HasNewMotd;
				if (hasNewMotd)
				{
					this.NewMotd = other.NewMotd;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0011D155 File Offset: 0x0011B355
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x0011D160 File Offset: 0x0011B360
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NewMotd = input.ReadString();
				}
			}
		}

		// Token: 0x0400213B RID: 8507
		private static readonly MessageParser<ClanMotdNewsData> _parser = new MessageParser<ClanMotdNewsData>(() => new ClanMotdNewsData());

		// Token: 0x0400213C RID: 8508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400213D RID: 8509
		public const int NewMotdFieldNumber = 1;

		// Token: 0x0400213E RID: 8510
		private static readonly string NewMotdDefaultValue = "";

		// Token: 0x0400213F RID: 8511
		private string newMotd_;
	}
}

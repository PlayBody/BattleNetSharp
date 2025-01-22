using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Clan
{
	// Token: 0x020002B4 RID: 692
	public sealed class ClanBankTabs : IMessage<ClanBankTabs>, IMessage, IEquatable<ClanBankTabs>, IDeepCloneable<ClanBankTabs>, IBufferMessage
	{
		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x0011A564 File Offset: 0x00118764
		[DebuggerNonUserCode]
		public static MessageParser<ClanBankTabs> Parser
		{
			get
			{
				return ClanBankTabs._parser;
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x0011A57C File Offset: 0x0011877C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClanReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x060049A6 RID: 18854 RVA: 0x0011A5A0 File Offset: 0x001187A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanBankTabs.Descriptor;
			}
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x0011A5B7 File Offset: 0x001187B7
		[DebuggerNonUserCode]
		public ClanBankTabs()
		{
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x0011A5CC File Offset: 0x001187CC
		[DebuggerNonUserCode]
		public ClanBankTabs(ClanBankTabs other)
			: this()
		{
			this.tab_ = other.tab_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x0011A5F8 File Offset: 0x001187F8
		[DebuggerNonUserCode]
		public ClanBankTabs Clone()
		{
			return new ClanBankTabs(this);
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x060049AA RID: 18858 RVA: 0x0011A610 File Offset: 0x00118810
		[DebuggerNonUserCode]
		public RepeatedField<ClanBankTab> Tab
		{
			get
			{
				return this.tab_;
			}
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x0011A628 File Offset: 0x00118828
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanBankTabs);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x0011A648 File Offset: 0x00118848
		[DebuggerNonUserCode]
		public bool Equals(ClanBankTabs other)
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
					bool flag4 = !this.tab_.Equals(other.tab_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x0011A6A4 File Offset: 0x001188A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tab_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0011A6E4 File Offset: 0x001188E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x0011A6FC File Offset: 0x001188FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x0011A708 File Offset: 0x00118908
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tab_.WriteTo(ref output, ClanBankTabs._repeated_tab_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x0011A744 File Offset: 0x00118944
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tab_.CalculateSize(ClanBankTabs._repeated_tab_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x0011A78C File Offset: 0x0011898C
		[DebuggerNonUserCode]
		public void MergeFrom(ClanBankTabs other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.tab_.Add(other.tab_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x0011A7CE File Offset: 0x001189CE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x0011A7DC File Offset: 0x001189DC
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
					this.tab_.AddEntriesFrom(ref input, ClanBankTabs._repeated_tab_codec);
				}
			}
		}

		// Token: 0x040020E7 RID: 8423
		private static readonly MessageParser<ClanBankTabs> _parser = new MessageParser<ClanBankTabs>(() => new ClanBankTabs());

		// Token: 0x040020E8 RID: 8424
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E9 RID: 8425
		public const int TabFieldNumber = 1;

		// Token: 0x040020EA RID: 8426
		private static readonly FieldCodec<ClanBankTab> _repeated_tab_codec = FieldCodec.ForMessage<ClanBankTab>(10U, ClanBankTab.Parser);

		// Token: 0x040020EB RID: 8427
		private readonly RepeatedField<ClanBankTab> tab_ = new RepeatedField<ClanBankTab>();
	}
}

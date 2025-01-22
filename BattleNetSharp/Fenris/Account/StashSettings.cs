using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D6 RID: 726
	public sealed class StashSettings : IMessage<StashSettings>, IMessage, IEquatable<StashSettings>, IDeepCloneable<StashSettings>, IBufferMessage
	{
		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x00125D64 File Offset: 0x00123F64
		[DebuggerNonUserCode]
		public static MessageParser<StashSettings> Parser
		{
			get
			{
				return StashSettings._parser;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x00125D7C File Offset: 0x00123F7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x00125DA0 File Offset: 0x00123FA0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StashSettings.Descriptor;
			}
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x00125DB7 File Offset: 0x00123FB7
		[DebuggerNonUserCode]
		public StashSettings()
		{
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x00125DCC File Offset: 0x00123FCC
		[DebuggerNonUserCode]
		public StashSettings(StashSettings other)
			: this()
		{
			this.tabSetting_ = other.tabSetting_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00125DF8 File Offset: 0x00123FF8
		[DebuggerNonUserCode]
		public StashSettings Clone()
		{
			return new StashSettings(this);
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x00125E10 File Offset: 0x00124010
		[DebuggerNonUserCode]
		public RepeatedField<StashTabSetting> TabSetting
		{
			get
			{
				return this.tabSetting_;
			}
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x00125E28 File Offset: 0x00124028
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StashSettings);
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00125E48 File Offset: 0x00124048
		[DebuggerNonUserCode]
		public bool Equals(StashSettings other)
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
					bool flag4 = !this.tabSetting_.Equals(other.tabSetting_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00125EA4 File Offset: 0x001240A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tabSetting_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00125EE4 File Offset: 0x001240E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00125EFC File Offset: 0x001240FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00125F08 File Offset: 0x00124108
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tabSetting_.WriteTo(ref output, StashSettings._repeated_tabSetting_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00125F44 File Offset: 0x00124144
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tabSetting_.CalculateSize(StashSettings._repeated_tabSetting_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00125F8C File Offset: 0x0012418C
		[DebuggerNonUserCode]
		public void MergeFrom(StashSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.tabSetting_.Add(other.tabSetting_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00125FCE File Offset: 0x001241CE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00125FDC File Offset: 0x001241DC
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
					this.tabSetting_.AddEntriesFrom(ref input, StashSettings._repeated_tabSetting_codec);
				}
			}
		}

		// Token: 0x04002244 RID: 8772
		private static readonly MessageParser<StashSettings> _parser = new MessageParser<StashSettings>(() => new StashSettings());

		// Token: 0x04002245 RID: 8773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002246 RID: 8774
		public const int TabSettingFieldNumber = 1;

		// Token: 0x04002247 RID: 8775
		private static readonly FieldCodec<StashTabSetting> _repeated_tabSetting_codec = FieldCodec.ForMessage<StashTabSetting>(10U, StashTabSetting.Parser);

		// Token: 0x04002248 RID: 8776
		private readonly RepeatedField<StashTabSetting> tabSetting_ = new RepeatedField<StashTabSetting>();
	}
}

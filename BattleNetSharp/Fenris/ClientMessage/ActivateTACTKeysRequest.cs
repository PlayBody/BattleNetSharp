using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000215 RID: 533
	public sealed class ActivateTACTKeysRequest : IMessage<ActivateTACTKeysRequest>, IMessage, IEquatable<ActivateTACTKeysRequest>, IDeepCloneable<ActivateTACTKeysRequest>, IBufferMessage
	{
		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x000E7290 File Offset: 0x000E5490
		[DebuggerNonUserCode]
		public static MessageParser<ActivateTACTKeysRequest> Parser
		{
			get
			{
				return ActivateTACTKeysRequest._parser;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060039F4 RID: 14836 RVA: 0x000E72A8 File Offset: 0x000E54A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x000E72CC File Offset: 0x000E54CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateTACTKeysRequest.Descriptor;
			}
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x000E72E3 File Offset: 0x000E54E3
		[DebuggerNonUserCode]
		public ActivateTACTKeysRequest()
		{
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x000E72F8 File Offset: 0x000E54F8
		[DebuggerNonUserCode]
		public ActivateTACTKeysRequest(ActivateTACTKeysRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.activateAll_ = other.activateAll_;
			this.keyNames_ = other.keyNames_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x000E7348 File Offset: 0x000E5548
		[DebuggerNonUserCode]
		public ActivateTACTKeysRequest Clone()
		{
			return new ActivateTACTKeysRequest(this);
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x000E7360 File Offset: 0x000E5560
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x000E7391 File Offset: 0x000E5591
		[DebuggerNonUserCode]
		public bool ActivateAll
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool activateAllDefaultValue;
				if (flag)
				{
					activateAllDefaultValue = this.activateAll_;
				}
				else
				{
					activateAllDefaultValue = ActivateTACTKeysRequest.ActivateAllDefaultValue;
				}
				return activateAllDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.activateAll_ = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x000E73AC File Offset: 0x000E55AC
		[DebuggerNonUserCode]
		public bool HasActivateAll
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x000E73C9 File Offset: 0x000E55C9
		[DebuggerNonUserCode]
		public void ClearActivateAll()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x000E73DC File Offset: 0x000E55DC
		[DebuggerNonUserCode]
		public RepeatedField<string> KeyNames
		{
			get
			{
				return this.keyNames_;
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x000E73F4 File Offset: 0x000E55F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateTACTKeysRequest);
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x000E7414 File Offset: 0x000E5614
		[DebuggerNonUserCode]
		public bool Equals(ActivateTACTKeysRequest other)
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
					bool flag4 = this.ActivateAll != other.ActivateAll;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.keyNames_.Equals(other.keyNames_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x000E7488 File Offset: 0x000E5688
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasActivateAll = this.HasActivateAll;
			if (hasActivateAll)
			{
				num ^= this.ActivateAll.GetHashCode();
			}
			num ^= this.keyNames_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x000E74E8 File Offset: 0x000E56E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x000E7500 File Offset: 0x000E5700
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x000E750C File Offset: 0x000E570C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasActivateAll = this.HasActivateAll;
			if (hasActivateAll)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ActivateAll);
			}
			this.keyNames_.WriteTo(ref output, ActivateTACTKeysRequest._repeated_keyNames_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x000E756C File Offset: 0x000E576C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasActivateAll = this.HasActivateAll;
			if (hasActivateAll)
			{
				num += 2;
			}
			num += this.keyNames_.CalculateSize(ActivateTACTKeysRequest._repeated_keyNames_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x000E75C4 File Offset: 0x000E57C4
		[DebuggerNonUserCode]
		public void MergeFrom(ActivateTACTKeysRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasActivateAll = other.HasActivateAll;
				if (hasActivateAll)
				{
					this.ActivateAll = other.ActivateAll;
				}
				this.keyNames_.Add(other.keyNames_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x000E761F File Offset: 0x000E581F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x000E762C File Offset: 0x000E582C
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.keyNames_.AddEntriesFrom(ref input, ActivateTACTKeysRequest._repeated_keyNames_codec);
					}
				}
				else
				{
					this.ActivateAll = input.ReadBool();
				}
			}
		}

		// Token: 0x04001AE6 RID: 6886
		private static readonly MessageParser<ActivateTACTKeysRequest> _parser = new MessageParser<ActivateTACTKeysRequest>(() => new ActivateTACTKeysRequest());

		// Token: 0x04001AE7 RID: 6887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AE8 RID: 6888
		private int _hasBits0;

		// Token: 0x04001AE9 RID: 6889
		public const int ActivateAllFieldNumber = 1;

		// Token: 0x04001AEA RID: 6890
		private static readonly bool ActivateAllDefaultValue = false;

		// Token: 0x04001AEB RID: 6891
		private bool activateAll_;

		// Token: 0x04001AEC RID: 6892
		public const int KeyNamesFieldNumber = 2;

		// Token: 0x04001AED RID: 6893
		private static readonly FieldCodec<string> _repeated_keyNames_codec = FieldCodec.ForString(18U);

		// Token: 0x04001AEE RID: 6894
		private readonly RepeatedField<string> keyNames_ = new RepeatedField<string>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200078C RID: 1932
	public sealed class GameOption : IMessage<GameOption>, IMessage, IEquatable<GameOption>, IDeepCloneable<GameOption>, IBufferMessage
	{
		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600B0EE RID: 45294 RVA: 0x002B12D0 File Offset: 0x002AF4D0
		[DebuggerNonUserCode]
		public static MessageParser<GameOption> Parser
		{
			get
			{
				return GameOption._parser;
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600B0EF RID: 45295 RVA: 0x002B12E8 File Offset: 0x002AF4E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x002B130C File Offset: 0x002AF50C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameOption.Descriptor;
			}
		}

		// Token: 0x0600B0F1 RID: 45297 RVA: 0x002B1323 File Offset: 0x002AF523
		[DebuggerNonUserCode]
		public GameOption()
		{
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x002B132D File Offset: 0x002AF52D
		[DebuggerNonUserCode]
		public GameOption(GameOption other)
			: this()
		{
			this.option_ = other.option_;
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x002B1360 File Offset: 0x002AF560
		[DebuggerNonUserCode]
		public GameOption Clone()
		{
			return new GameOption(this);
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x002B1378 File Offset: 0x002AF578
		// (set) Token: 0x0600B0F5 RID: 45301 RVA: 0x002B1399 File Offset: 0x002AF599
		[DebuggerNonUserCode]
		public string Option
		{
			get
			{
				return this.option_ ?? GameOption.OptionDefaultValue;
			}
			set
			{
				this.option_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600B0F6 RID: 45302 RVA: 0x002B13B0 File Offset: 0x002AF5B0
		[DebuggerNonUserCode]
		public bool HasOption
		{
			get
			{
				return this.option_ != null;
			}
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x002B13CB File Offset: 0x002AF5CB
		[DebuggerNonUserCode]
		public void ClearOption()
		{
			this.option_ = null;
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600B0F8 RID: 45304 RVA: 0x002B13D8 File Offset: 0x002AF5D8
		// (set) Token: 0x0600B0F9 RID: 45305 RVA: 0x002B13F9 File Offset: 0x002AF5F9
		[DebuggerNonUserCode]
		public string Value
		{
			get
			{
				return this.value_ ?? GameOption.ValueDefaultValue;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x002B1410 File Offset: 0x002AF610
		[DebuggerNonUserCode]
		public bool HasValue
		{
			get
			{
				return this.value_ != null;
			}
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x002B142B File Offset: 0x002AF62B
		[DebuggerNonUserCode]
		public void ClearValue()
		{
			this.value_ = null;
		}

		// Token: 0x0600B0FC RID: 45308 RVA: 0x002B1438 File Offset: 0x002AF638
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameOption);
		}

		// Token: 0x0600B0FD RID: 45309 RVA: 0x002B1458 File Offset: 0x002AF658
		[DebuggerNonUserCode]
		public bool Equals(GameOption other)
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
					bool flag4 = this.Option != other.Option;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Value != other.Value;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B0FE RID: 45310 RVA: 0x002B14CC File Offset: 0x002AF6CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOption = this.HasOption;
			if (hasOption)
			{
				num ^= this.Option.GetHashCode();
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0FF RID: 45311 RVA: 0x002B1530 File Offset: 0x002AF730
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x002B1548 File Offset: 0x002AF748
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x002B1554 File Offset: 0x002AF754
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOption = this.HasOption;
			if (hasOption)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Option);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x002B15C4 File Offset: 0x002AF7C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOption = this.HasOption;
			if (hasOption)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Option);
			}
			bool hasValue = this.HasValue;
			if (hasValue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Value);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x002B1630 File Offset: 0x002AF830
		[DebuggerNonUserCode]
		public void MergeFrom(GameOption other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOption = other.HasOption;
				if (hasOption)
				{
					this.Option = other.Option;
				}
				bool hasValue = other.HasValue;
				if (hasValue)
				{
					this.Value = other.Value;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x002B1692 File Offset: 0x002AF892
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x002B16A0 File Offset: 0x002AF8A0
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadString();
					}
				}
				else
				{
					this.Option = input.ReadString();
				}
			}
		}

		// Token: 0x04004FC5 RID: 20421
		private static readonly MessageParser<GameOption> _parser = new MessageParser<GameOption>(() => new GameOption());

		// Token: 0x04004FC6 RID: 20422
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FC7 RID: 20423
		public const int OptionFieldNumber = 1;

		// Token: 0x04004FC8 RID: 20424
		private static readonly string OptionDefaultValue = "";

		// Token: 0x04004FC9 RID: 20425
		private string option_;

		// Token: 0x04004FCA RID: 20426
		public const int ValueFieldNumber = 2;

		// Token: 0x04004FCB RID: 20427
		private static readonly string ValueDefaultValue = "";

		// Token: 0x04004FCC RID: 20428
		private string value_;
	}
}

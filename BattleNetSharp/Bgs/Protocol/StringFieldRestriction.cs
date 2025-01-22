using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000368 RID: 872
	public sealed class StringFieldRestriction : IMessage<StringFieldRestriction>, IMessage, IEquatable<StringFieldRestriction>, IDeepCloneable<StringFieldRestriction>, IBufferMessage
	{
		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x0015C054 File Offset: 0x0015A254
		[DebuggerNonUserCode]
		public static MessageParser<StringFieldRestriction> Parser
		{
			get
			{
				return StringFieldRestriction._parser;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x0015C06C File Offset: 0x0015A26C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FieldOptionsReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060059DF RID: 23007 RVA: 0x0015C090 File Offset: 0x0015A290
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StringFieldRestriction.Descriptor;
			}
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x0015C0A7 File Offset: 0x0015A2A7
		[DebuggerNonUserCode]
		public StringFieldRestriction()
		{
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x0015C0BC File Offset: 0x0015A2BC
		[DebuggerNonUserCode]
		public StringFieldRestriction(StringFieldRestriction other)
			: this()
		{
			this.size_ = ((other.size_ != null) ? other.size_.Clone() : null);
			this.exclude_ = other.exclude_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x0015C110 File Offset: 0x0015A310
		[DebuggerNonUserCode]
		public StringFieldRestriction Clone()
		{
			return new StringFieldRestriction(this);
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060059E3 RID: 23011 RVA: 0x0015C128 File Offset: 0x0015A328
		// (set) Token: 0x060059E4 RID: 23012 RVA: 0x0015C140 File Offset: 0x0015A340
		[DebuggerNonUserCode]
		public UnsignedIntRange Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060059E5 RID: 23013 RVA: 0x0015C14C File Offset: 0x0015A34C
		[DebuggerNonUserCode]
		public RepeatedField<string> Exclude
		{
			get
			{
				return this.exclude_;
			}
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x0015C164 File Offset: 0x0015A364
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StringFieldRestriction);
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x0015C184 File Offset: 0x0015A384
		[DebuggerNonUserCode]
		public bool Equals(StringFieldRestriction other)
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
					bool flag4 = !object.Equals(this.Size, other.Size);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.exclude_.Equals(other.exclude_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0015C1FC File Offset: 0x0015A3FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.size_ != null;
			if (flag)
			{
				num ^= this.Size.GetHashCode();
			}
			num ^= this.exclude_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x0015C258 File Offset: 0x0015A458
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x0015C270 File Offset: 0x0015A470
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059EB RID: 23019 RVA: 0x0015C27C File Offset: 0x0015A47C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.size_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Size);
			}
			this.exclude_.WriteTo(ref output, StringFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059EC RID: 23020 RVA: 0x0015C2E0 File Offset: 0x0015A4E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.size_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Size);
			}
			num += this.exclude_.CalculateSize(StringFieldRestriction._repeated_exclude_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x0015C344 File Offset: 0x0015A544
		[DebuggerNonUserCode]
		public void MergeFrom(StringFieldRestriction other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.size_ != null;
				if (flag2)
				{
					bool flag3 = this.size_ == null;
					if (flag3)
					{
						this.Size = new UnsignedIntRange();
					}
					this.Size.MergeFrom(other.Size);
				}
				this.exclude_.Add(other.exclude_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x0015C3C2 File Offset: 0x0015A5C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x0015C3D0 File Offset: 0x0015A5D0
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
						this.exclude_.AddEntriesFrom(ref input, StringFieldRestriction._repeated_exclude_codec);
					}
				}
				else
				{
					bool flag = this.size_ == null;
					if (flag)
					{
						this.Size = new UnsignedIntRange();
					}
					input.ReadMessage(this.Size);
				}
			}
		}

		// Token: 0x040028F3 RID: 10483
		private static readonly MessageParser<StringFieldRestriction> _parser = new MessageParser<StringFieldRestriction>(() => new StringFieldRestriction());

		// Token: 0x040028F4 RID: 10484
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028F5 RID: 10485
		public const int SizeFieldNumber = 1;

		// Token: 0x040028F6 RID: 10486
		private UnsignedIntRange size_;

		// Token: 0x040028F7 RID: 10487
		public const int ExcludeFieldNumber = 2;

		// Token: 0x040028F8 RID: 10488
		private static readonly FieldCodec<string> _repeated_exclude_codec = FieldCodec.ForString(18U);

		// Token: 0x040028F9 RID: 10489
		private readonly RepeatedField<string> exclude_ = new RepeatedField<string>();
	}
}

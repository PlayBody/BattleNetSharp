using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200073D RID: 1853
	public sealed class OptIns : IMessage<OptIns>, IMessage, IEquatable<OptIns>, IDeepCloneable<OptIns>, IBufferMessage
	{
		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x00295BE0 File Offset: 0x00293DE0
		[DebuggerNonUserCode]
		public static MessageParser<OptIns> Parser
		{
			get
			{
				return OptIns._parser;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x00295BF8 File Offset: 0x00293DF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600A9D2 RID: 43474 RVA: 0x00295C1C File Offset: 0x00293E1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OptIns.Descriptor;
			}
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x00295C33 File Offset: 0x00293E33
		[DebuggerNonUserCode]
		public OptIns()
		{
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x00295C48 File Offset: 0x00293E48
		[DebuggerNonUserCode]
		public OptIns(OptIns other)
			: this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x00295C74 File Offset: 0x00293E74
		[DebuggerNonUserCode]
		public OptIns Clone()
		{
			return new OptIns(this);
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x00295C8C File Offset: 0x00293E8C
		[DebuggerNonUserCode]
		public RepeatedField<ulong> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x00295CA4 File Offset: 0x00293EA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OptIns);
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x00295CC4 File Offset: 0x00293EC4
		[DebuggerNonUserCode]
		public bool Equals(OptIns other)
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
					bool flag4 = !this.ids_.Equals(other.ids_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x00295D20 File Offset: 0x00293F20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x00295D60 File Offset: 0x00293F60
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x00295D78 File Offset: 0x00293F78
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x00295D84 File Offset: 0x00293F84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, OptIns._repeated_ids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x00295DC0 File Offset: 0x00293FC0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(OptIns._repeated_ids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x00295E08 File Offset: 0x00294008
		[DebuggerNonUserCode]
		public void MergeFrom(OptIns other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.ids_.Add(other.ids_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x00295E4A File Offset: 0x0029404A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x00295E58 File Offset: 0x00294058
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, OptIns._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04004C5F RID: 19551
		private static readonly MessageParser<OptIns> _parser = new MessageParser<OptIns>(() => new OptIns());

		// Token: 0x04004C60 RID: 19552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C61 RID: 19553
		public const int IdsFieldNumber = 1;

		// Token: 0x04004C62 RID: 19554
		private static readonly FieldCodec<ulong> _repeated_ids_codec = FieldCodec.ForUInt64(10U);

		// Token: 0x04004C63 RID: 19555
		private readonly RepeatedField<ulong> ids_ = new RepeatedField<ulong>();
	}
}

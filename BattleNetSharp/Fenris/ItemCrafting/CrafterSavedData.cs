using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ItemCrafting
{
	// Token: 0x02000174 RID: 372
	public sealed class CrafterSavedData : IMessage<CrafterSavedData>, IMessage, IEquatable<CrafterSavedData>, IDeepCloneable<CrafterSavedData>, IBufferMessage
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000964A8 File Offset: 0x000946A8
		[DebuggerNonUserCode]
		public static MessageParser<CrafterSavedData> Parser
		{
			get
			{
				return CrafterSavedData._parser;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000964C0 File Offset: 0x000946C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCraftingReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000964E4 File Offset: 0x000946E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrafterSavedData.Descriptor;
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000964FB File Offset: 0x000946FB
		[DebuggerNonUserCode]
		public CrafterSavedData()
		{
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00096510 File Offset: 0x00094710
		[DebuggerNonUserCode]
		public CrafterSavedData(CrafterSavedData other)
			: this()
		{
			this.crafterData_ = other.crafterData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0009653C File Offset: 0x0009473C
		[DebuggerNonUserCode]
		public CrafterSavedData Clone()
		{
			return new CrafterSavedData(this);
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x00096554 File Offset: 0x00094754
		[DebuggerNonUserCode]
		public RepeatedField<CrafterData> CrafterData
		{
			get
			{
				return this.crafterData_;
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0009656C File Offset: 0x0009476C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrafterSavedData);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0009658C File Offset: 0x0009478C
		[DebuggerNonUserCode]
		public bool Equals(CrafterSavedData other)
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
					bool flag4 = !this.crafterData_.Equals(other.crafterData_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x000965E8 File Offset: 0x000947E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.crafterData_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00096628 File Offset: 0x00094828
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00096640 File Offset: 0x00094840
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0009664C File Offset: 0x0009484C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.crafterData_.WriteTo(ref output, CrafterSavedData._repeated_crafterData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00096688 File Offset: 0x00094888
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.crafterData_.CalculateSize(CrafterSavedData._repeated_crafterData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x000966D0 File Offset: 0x000948D0
		[DebuggerNonUserCode]
		public void MergeFrom(CrafterSavedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.crafterData_.Add(other.crafterData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00096712 File Offset: 0x00094912
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00096720 File Offset: 0x00094920
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
					this.crafterData_.AddEntriesFrom(ref input, CrafterSavedData._repeated_crafterData_codec);
				}
			}
		}

		// Token: 0x0400111D RID: 4381
		private static readonly MessageParser<CrafterSavedData> _parser = new MessageParser<CrafterSavedData>(() => new CrafterSavedData());

		// Token: 0x0400111E RID: 4382
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400111F RID: 4383
		public const int CrafterDataFieldNumber = 1;

		// Token: 0x04001120 RID: 4384
		private static readonly FieldCodec<CrafterData> _repeated_crafterData_codec = FieldCodec.ForMessage<CrafterData>(10U, Fenris.ItemCrafting.CrafterData.Parser);

		// Token: 0x04001121 RID: 4385
		private readonly RepeatedField<CrafterData> crafterData_ = new RepeatedField<CrafterData>();
	}
}

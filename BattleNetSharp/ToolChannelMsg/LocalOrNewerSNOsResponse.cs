using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007C RID: 124
	public sealed class LocalOrNewerSNOsResponse : IMessage<LocalOrNewerSNOsResponse>, IMessage, IEquatable<LocalOrNewerSNOsResponse>, IDeepCloneable<LocalOrNewerSNOsResponse>, IBufferMessage
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002A0FC File Offset: 0x000282FC
		[DebuggerNonUserCode]
		public static MessageParser<LocalOrNewerSNOsResponse> Parser
		{
			get
			{
				return LocalOrNewerSNOsResponse._parser;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002A114 File Offset: 0x00028314
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[101];
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0002A138 File Offset: 0x00028338
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LocalOrNewerSNOsResponse.Descriptor;
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002A14F File Offset: 0x0002834F
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsResponse()
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0002A164 File Offset: 0x00028364
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsResponse(LocalOrNewerSNOsResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.list_ = other.list_.Clone();
			this.allShadersLocalOrNewer_ = other.allShadersLocalOrNewer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0002A1B4 File Offset: 0x000283B4
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsResponse Clone()
		{
			return new LocalOrNewerSNOsResponse(this);
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0002A1CC File Offset: 0x000283CC
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002A1E4 File Offset: 0x000283E4
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0002A215 File Offset: 0x00028415
		[DebuggerNonUserCode]
		public bool AllShadersLocalOrNewer
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool allShadersLocalOrNewerDefaultValue;
				if (flag)
				{
					allShadersLocalOrNewerDefaultValue = this.allShadersLocalOrNewer_;
				}
				else
				{
					allShadersLocalOrNewerDefaultValue = LocalOrNewerSNOsResponse.AllShadersLocalOrNewerDefaultValue;
				}
				return allShadersLocalOrNewerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.allShadersLocalOrNewer_ = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002A230 File Offset: 0x00028430
		[DebuggerNonUserCode]
		public bool HasAllShadersLocalOrNewer
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0002A24D File Offset: 0x0002844D
		[DebuggerNonUserCode]
		public void ClearAllShadersLocalOrNewer()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002A260 File Offset: 0x00028460
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LocalOrNewerSNOsResponse);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002A280 File Offset: 0x00028480
		[DebuggerNonUserCode]
		public bool Equals(LocalOrNewerSNOsResponse other)
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
					bool flag4 = !this.list_.Equals(other.list_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AllShadersLocalOrNewer != other.AllShadersLocalOrNewer;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002A2F4 File Offset: 0x000284F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool hasAllShadersLocalOrNewer = this.HasAllShadersLocalOrNewer;
			if (hasAllShadersLocalOrNewer)
			{
				num ^= this.AllShadersLocalOrNewer.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002A354 File Offset: 0x00028554
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0002A36C File Offset: 0x0002856C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002A378 File Offset: 0x00028578
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, LocalOrNewerSNOsResponse._repeated_list_codec);
			bool hasAllShadersLocalOrNewer = this.HasAllShadersLocalOrNewer;
			if (hasAllShadersLocalOrNewer)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AllShadersLocalOrNewer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002A3D8 File Offset: 0x000285D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(LocalOrNewerSNOsResponse._repeated_list_codec);
			bool hasAllShadersLocalOrNewer = this.HasAllShadersLocalOrNewer;
			if (hasAllShadersLocalOrNewer)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002A430 File Offset: 0x00028630
		[DebuggerNonUserCode]
		public void MergeFrom(LocalOrNewerSNOsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				bool hasAllShadersLocalOrNewer = other.HasAllShadersLocalOrNewer;
				if (hasAllShadersLocalOrNewer)
				{
					this.AllShadersLocalOrNewer = other.AllShadersLocalOrNewer;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002A48B File Offset: 0x0002868B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0002A498 File Offset: 0x00028698
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AllShadersLocalOrNewer = input.ReadBool();
					}
				}
				else
				{
					this.list_.AddEntriesFrom(ref input, LocalOrNewerSNOsResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x0400044C RID: 1100
		private static readonly MessageParser<LocalOrNewerSNOsResponse> _parser = new MessageParser<LocalOrNewerSNOsResponse>(() => new LocalOrNewerSNOsResponse());

		// Token: 0x0400044D RID: 1101
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400044E RID: 1102
		private int _hasBits0;

		// Token: 0x0400044F RID: 1103
		public const int ListFieldNumber = 1;

		// Token: 0x04000450 RID: 1104
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x04000451 RID: 1105
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();

		// Token: 0x04000452 RID: 1106
		public const int AllShadersLocalOrNewerFieldNumber = 2;

		// Token: 0x04000453 RID: 1107
		private static readonly bool AllShadersLocalOrNewerDefaultValue = false;

		// Token: 0x04000454 RID: 1108
		private bool allShadersLocalOrNewer_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000050 RID: 80
	public sealed class EnumerateActorsOfTypeResponse : IMessage<EnumerateActorsOfTypeResponse>, IMessage, IEquatable<EnumerateActorsOfTypeResponse>, IDeepCloneable<EnumerateActorsOfTypeResponse>, IBufferMessage
	{
		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateActorsOfTypeResponse> Parser
		{
			get
			{
				return EnumerateActorsOfTypeResponse._parser;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001DA94 File Offset: 0x0001BC94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[57];
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateActorsOfTypeResponse.Descriptor;
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001DACF File Offset: 0x0001BCCF
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeResponse()
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeResponse(EnumerateActorsOfTypeResponse other)
			: this()
		{
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001DB10 File Offset: 0x0001BD10
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeResponse Clone()
		{
			return new EnumerateActorsOfTypeResponse(this);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0001DB28 File Offset: 0x0001BD28
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001DB40 File Offset: 0x0001BD40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateActorsOfTypeResponse);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001DB60 File Offset: 0x0001BD60
		[DebuggerNonUserCode]
		public bool Equals(EnumerateActorsOfTypeResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001DBBC File Offset: 0x0001BDBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.list_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001DC14 File Offset: 0x0001BE14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001DC20 File Offset: 0x0001BE20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.list_.WriteTo(ref output, EnumerateActorsOfTypeResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001DC5C File Offset: 0x0001BE5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.list_.CalculateSize(EnumerateActorsOfTypeResponse._repeated_list_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateActorsOfTypeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.list_.Add(other.list_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001DCE6 File Offset: 0x0001BEE6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
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
					this.list_.AddEntriesFrom(ref input, EnumerateActorsOfTypeResponse._repeated_list_codec);
				}
			}
		}

		// Token: 0x040002D5 RID: 725
		private static readonly MessageParser<EnumerateActorsOfTypeResponse> _parser = new MessageParser<EnumerateActorsOfTypeResponse>(() => new EnumerateActorsOfTypeResponse());

		// Token: 0x040002D6 RID: 726
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002D7 RID: 727
		public const int ListFieldNumber = 1;

		// Token: 0x040002D8 RID: 728
		private static readonly FieldCodec<SNOName> _repeated_list_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x040002D9 RID: 729
		private readonly RepeatedField<SNOName> list_ = new RepeatedField<SNOName>();
	}
}

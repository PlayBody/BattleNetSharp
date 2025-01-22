using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000071 RID: 113
	public sealed class EditMarkerSetRequest : IMessage<EditMarkerSetRequest>, IMessage, IEquatable<EditMarkerSetRequest>, IDeepCloneable<EditMarkerSetRequest>, IBufferMessage
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00026C34 File Offset: 0x00024E34
		[DebuggerNonUserCode]
		public static MessageParser<EditMarkerSetRequest> Parser
		{
			get
			{
				return EditMarkerSetRequest._parser;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00026C4C File Offset: 0x00024E4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[90];
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x00026C70 File Offset: 0x00024E70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EditMarkerSetRequest.Descriptor;
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00026C87 File Offset: 0x00024E87
		[DebuggerNonUserCode]
		public EditMarkerSetRequest()
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00026C91 File Offset: 0x00024E91
		[DebuggerNonUserCode]
		public EditMarkerSetRequest(EditMarkerSetRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoMarkerset_ = other.snoMarkerset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00026CC4 File Offset: 0x00024EC4
		[DebuggerNonUserCode]
		public EditMarkerSetRequest Clone()
		{
			return new EditMarkerSetRequest(this);
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00026CDC File Offset: 0x00024EDC
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00026D0D File Offset: 0x00024F0D
		[DebuggerNonUserCode]
		public int SnoMarkerset
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoMarkersetDefaultValue;
				if (flag)
				{
					snoMarkersetDefaultValue = this.snoMarkerset_;
				}
				else
				{
					snoMarkersetDefaultValue = EditMarkerSetRequest.SnoMarkersetDefaultValue;
				}
				return snoMarkersetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoMarkerset_ = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00026D28 File Offset: 0x00024F28
		[DebuggerNonUserCode]
		public bool HasSnoMarkerset
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00026D45 File Offset: 0x00024F45
		[DebuggerNonUserCode]
		public void ClearSnoMarkerset()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00026D58 File Offset: 0x00024F58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EditMarkerSetRequest);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00026D78 File Offset: 0x00024F78
		[DebuggerNonUserCode]
		public bool Equals(EditMarkerSetRequest other)
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
					bool flag4 = this.SnoMarkerset != other.SnoMarkerset;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00026DD0 File Offset: 0x00024FD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num ^= this.SnoMarkerset.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00026E20 File Offset: 0x00025020
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00026E38 File Offset: 0x00025038
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00026E44 File Offset: 0x00025044
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoMarkerset);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00026E90 File Offset: 0x00025090
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoMarkerset);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00026EE0 File Offset: 0x000250E0
		[DebuggerNonUserCode]
		public void MergeFrom(EditMarkerSetRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoMarkerset = other.HasSnoMarkerset;
				if (hasSnoMarkerset)
				{
					this.SnoMarkerset = other.SnoMarkerset;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00026F29 File Offset: 0x00025129
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00026F34 File Offset: 0x00025134
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoMarkerset = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003E4 RID: 996
		private static readonly MessageParser<EditMarkerSetRequest> _parser = new MessageParser<EditMarkerSetRequest>(() => new EditMarkerSetRequest());

		// Token: 0x040003E5 RID: 997
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003E6 RID: 998
		private int _hasBits0;

		// Token: 0x040003E7 RID: 999
		public const int SnoMarkersetFieldNumber = 1;

		// Token: 0x040003E8 RID: 1000
		private static readonly int SnoMarkersetDefaultValue = 0;

		// Token: 0x040003E9 RID: 1001
		private int snoMarkerset_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000052 RID: 82
	public sealed class EnumerateActorsOfTypeWithLabelRequest : IMessage<EnumerateActorsOfTypeWithLabelRequest>, IMessage, IEquatable<EnumerateActorsOfTypeWithLabelRequest>, IDeepCloneable<EnumerateActorsOfTypeWithLabelRequest>, IBufferMessage
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001E204 File Offset: 0x0001C404
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateActorsOfTypeWithLabelRequest> Parser
		{
			get
			{
				return EnumerateActorsOfTypeWithLabelRequest._parser;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0001E21C File Offset: 0x0001C41C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[59];
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0001E240 File Offset: 0x0001C440
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateActorsOfTypeWithLabelRequest.Descriptor;
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001E257 File Offset: 0x0001C457
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelRequest()
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001E261 File Offset: 0x0001C461
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelRequest(EnumerateActorsOfTypeWithLabelRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.actortype_ = other.actortype_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001E294 File Offset: 0x0001C494
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeWithLabelRequest Clone()
		{
			return new EnumerateActorsOfTypeWithLabelRequest(this);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0001E2AC File Offset: 0x0001C4AC
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x0001E2DD File Offset: 0x0001C4DD
		[DebuggerNonUserCode]
		public int Actortype
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int actortypeDefaultValue;
				if (flag)
				{
					actortypeDefaultValue = this.actortype_;
				}
				else
				{
					actortypeDefaultValue = EnumerateActorsOfTypeWithLabelRequest.ActortypeDefaultValue;
				}
				return actortypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.actortype_ = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
		[DebuggerNonUserCode]
		public bool HasActortype
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001E315 File Offset: 0x0001C515
		[DebuggerNonUserCode]
		public void ClearActortype()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001E328 File Offset: 0x0001C528
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateActorsOfTypeWithLabelRequest);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001E348 File Offset: 0x0001C548
		[DebuggerNonUserCode]
		public bool Equals(EnumerateActorsOfTypeWithLabelRequest other)
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
					bool flag4 = this.Actortype != other.Actortype;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001E3A0 File Offset: 0x0001C5A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasActortype = this.HasActortype;
			if (hasActortype)
			{
				num ^= this.Actortype.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001E408 File Offset: 0x0001C608
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001E414 File Offset: 0x0001C614
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasActortype = this.HasActortype;
			if (hasActortype)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Actortype);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001E460 File Offset: 0x0001C660
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasActortype = this.HasActortype;
			if (hasActortype)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Actortype);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateActorsOfTypeWithLabelRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasActortype = other.HasActortype;
				if (hasActortype)
				{
					this.Actortype = other.Actortype;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001E4F9 File Offset: 0x0001C6F9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001E504 File Offset: 0x0001C704
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
					this.Actortype = input.ReadInt32();
				}
			}
		}

		// Token: 0x040002E1 RID: 737
		private static readonly MessageParser<EnumerateActorsOfTypeWithLabelRequest> _parser = new MessageParser<EnumerateActorsOfTypeWithLabelRequest>(() => new EnumerateActorsOfTypeWithLabelRequest());

		// Token: 0x040002E2 RID: 738
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002E3 RID: 739
		private int _hasBits0;

		// Token: 0x040002E4 RID: 740
		public const int ActortypeFieldNumber = 1;

		// Token: 0x040002E5 RID: 741
		private static readonly int ActortypeDefaultValue = 0;

		// Token: 0x040002E6 RID: 742
		private int actortype_;
	}
}

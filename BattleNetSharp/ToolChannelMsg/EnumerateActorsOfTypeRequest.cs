using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200004F RID: 79
	public sealed class EnumerateActorsOfTypeRequest : IMessage<EnumerateActorsOfTypeRequest>, IMessage, IEquatable<EnumerateActorsOfTypeRequest>, IDeepCloneable<EnumerateActorsOfTypeRequest>, IBufferMessage
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001D708 File Offset: 0x0001B908
		[DebuggerNonUserCode]
		public static MessageParser<EnumerateActorsOfTypeRequest> Parser
		{
			get
			{
				return EnumerateActorsOfTypeRequest._parser;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0001D720 File Offset: 0x0001B920
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[56];
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001D744 File Offset: 0x0001B944
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnumerateActorsOfTypeRequest.Descriptor;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001D75B File Offset: 0x0001B95B
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeRequest()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001D765 File Offset: 0x0001B965
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeRequest(EnumerateActorsOfTypeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.actortype_ = other.actortype_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001D798 File Offset: 0x0001B998
		[DebuggerNonUserCode]
		public EnumerateActorsOfTypeRequest Clone()
		{
			return new EnumerateActorsOfTypeRequest(this);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001D7B0 File Offset: 0x0001B9B0
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0001D7E1 File Offset: 0x0001B9E1
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
					actortypeDefaultValue = EnumerateActorsOfTypeRequest.ActortypeDefaultValue;
				}
				return actortypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.actortype_ = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001D7FC File Offset: 0x0001B9FC
		[DebuggerNonUserCode]
		public bool HasActortype
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001D819 File Offset: 0x0001BA19
		[DebuggerNonUserCode]
		public void ClearActortype()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001D82C File Offset: 0x0001BA2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnumerateActorsOfTypeRequest);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001D84C File Offset: 0x0001BA4C
		[DebuggerNonUserCode]
		public bool Equals(EnumerateActorsOfTypeRequest other)
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

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001D8A4 File Offset: 0x0001BAA4
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

		// Token: 0x060006BA RID: 1722 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001D90C File Offset: 0x0001BB0C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001D918 File Offset: 0x0001BB18
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

		// Token: 0x060006BD RID: 1725 RVA: 0x0001D964 File Offset: 0x0001BB64
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

		// Token: 0x060006BE RID: 1726 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		[DebuggerNonUserCode]
		public void MergeFrom(EnumerateActorsOfTypeRequest other)
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

		// Token: 0x060006BF RID: 1727 RVA: 0x0001D9FD File Offset: 0x0001BBFD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001DA08 File Offset: 0x0001BC08
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

		// Token: 0x040002CF RID: 719
		private static readonly MessageParser<EnumerateActorsOfTypeRequest> _parser = new MessageParser<EnumerateActorsOfTypeRequest>(() => new EnumerateActorsOfTypeRequest());

		// Token: 0x040002D0 RID: 720
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002D1 RID: 721
		private int _hasBits0;

		// Token: 0x040002D2 RID: 722
		public const int ActortypeFieldNumber = 1;

		// Token: 0x040002D3 RID: 723
		private static readonly int ActortypeDefaultValue = 0;

		// Token: 0x040002D4 RID: 724
		private int actortype_;
	}
}

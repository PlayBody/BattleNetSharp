using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007B RID: 123
	public sealed class LocalOrNewerSNOsRequest : IMessage<LocalOrNewerSNOsRequest>, IMessage, IEquatable<LocalOrNewerSNOsRequest>, IDeepCloneable<LocalOrNewerSNOsRequest>, IBufferMessage
	{
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00029D88 File Offset: 0x00027F88
		[DebuggerNonUserCode]
		public static MessageParser<LocalOrNewerSNOsRequest> Parser
		{
			get
			{
				return LocalOrNewerSNOsRequest._parser;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00029DA0 File Offset: 0x00027FA0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[100];
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00029DC4 File Offset: 0x00027FC4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LocalOrNewerSNOsRequest.Descriptor;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00029DDB File Offset: 0x00027FDB
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsRequest()
		{
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00029DE5 File Offset: 0x00027FE5
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsRequest(LocalOrNewerSNOsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.p4Revision_ = other.p4Revision_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00029E18 File Offset: 0x00028018
		[DebuggerNonUserCode]
		public LocalOrNewerSNOsRequest Clone()
		{
			return new LocalOrNewerSNOsRequest(this);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00029E30 File Offset: 0x00028030
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00029E61 File Offset: 0x00028061
		[DebuggerNonUserCode]
		public int P4Revision
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int p4RevisionDefaultValue;
				if (flag)
				{
					p4RevisionDefaultValue = this.p4Revision_;
				}
				else
				{
					p4RevisionDefaultValue = LocalOrNewerSNOsRequest.P4RevisionDefaultValue;
				}
				return p4RevisionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.p4Revision_ = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00029E7C File Offset: 0x0002807C
		[DebuggerNonUserCode]
		public bool HasP4Revision
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00029E99 File Offset: 0x00028099
		[DebuggerNonUserCode]
		public void ClearP4Revision()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00029EAC File Offset: 0x000280AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LocalOrNewerSNOsRequest);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00029ECC File Offset: 0x000280CC
		[DebuggerNonUserCode]
		public bool Equals(LocalOrNewerSNOsRequest other)
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
					bool flag4 = this.P4Revision != other.P4Revision;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00029F24 File Offset: 0x00028124
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasP4Revision = this.HasP4Revision;
			if (hasP4Revision)
			{
				num ^= this.P4Revision.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00029F74 File Offset: 0x00028174
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00029F8C File Offset: 0x0002818C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00029F98 File Offset: 0x00028198
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasP4Revision = this.HasP4Revision;
			if (hasP4Revision)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.P4Revision);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00029FE4 File Offset: 0x000281E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasP4Revision = this.HasP4Revision;
			if (hasP4Revision)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.P4Revision);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002A034 File Offset: 0x00028234
		[DebuggerNonUserCode]
		public void MergeFrom(LocalOrNewerSNOsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasP4Revision = other.HasP4Revision;
				if (hasP4Revision)
				{
					this.P4Revision = other.P4Revision;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002A07D File Offset: 0x0002827D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0002A088 File Offset: 0x00028288
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
					this.P4Revision = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000446 RID: 1094
		private static readonly MessageParser<LocalOrNewerSNOsRequest> _parser = new MessageParser<LocalOrNewerSNOsRequest>(() => new LocalOrNewerSNOsRequest());

		// Token: 0x04000447 RID: 1095
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000448 RID: 1096
		private int _hasBits0;

		// Token: 0x04000449 RID: 1097
		public const int P4RevisionFieldNumber = 1;

		// Token: 0x0400044A RID: 1098
		private static readonly int P4RevisionDefaultValue = 0;

		// Token: 0x0400044B RID: 1099
		private int p4Revision_;
	}
}

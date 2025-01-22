using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000284 RID: 644
	public sealed class RequeuedForInstance : IMessage<RequeuedForInstance>, IMessage, IEquatable<RequeuedForInstance>, IDeepCloneable<RequeuedForInstance>, IBufferMessage
	{
		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x00108CB8 File Offset: 0x00106EB8
		[DebuggerNonUserCode]
		public static MessageParser<RequeuedForInstance> Parser
		{
			get
			{
				return RequeuedForInstance._parser;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x00108CD0 File Offset: 0x00106ED0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[116];
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x00108CF4 File Offset: 0x00106EF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RequeuedForInstance.Descriptor;
			}
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00108D0B File Offset: 0x00106F0B
		[DebuggerNonUserCode]
		public RequeuedForInstance()
		{
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00108D15 File Offset: 0x00106F15
		[DebuggerNonUserCode]
		public RequeuedForInstance(RequeuedForInstance other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.subzoneType_ = other.subzoneType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00108D48 File Offset: 0x00106F48
		[DebuggerNonUserCode]
		public RequeuedForInstance Clone()
		{
			return new RequeuedForInstance(this);
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x00108D60 File Offset: 0x00106F60
		// (set) Token: 0x060044B7 RID: 17591 RVA: 0x00108D91 File Offset: 0x00106F91
		[DebuggerNonUserCode]
		public int SubzoneType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int subzoneTypeDefaultValue;
				if (flag)
				{
					subzoneTypeDefaultValue = this.subzoneType_;
				}
				else
				{
					subzoneTypeDefaultValue = RequeuedForInstance.SubzoneTypeDefaultValue;
				}
				return subzoneTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.subzoneType_ = value;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x00108DAC File Offset: 0x00106FAC
		[DebuggerNonUserCode]
		public bool HasSubzoneType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00108DC9 File Offset: 0x00106FC9
		[DebuggerNonUserCode]
		public void ClearSubzoneType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00108DDC File Offset: 0x00106FDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RequeuedForInstance);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00108DFC File Offset: 0x00106FFC
		[DebuggerNonUserCode]
		public bool Equals(RequeuedForInstance other)
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
					bool flag4 = this.SubzoneType != other.SubzoneType;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00108E54 File Offset: 0x00107054
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
			{
				num ^= this.SubzoneType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00108EA4 File Offset: 0x001070A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00108EBC File Offset: 0x001070BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00108EC8 File Offset: 0x001070C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SubzoneType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00108F14 File Offset: 0x00107114
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSubzoneType = this.HasSubzoneType;
			if (hasSubzoneType)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00108F58 File Offset: 0x00107158
		[DebuggerNonUserCode]
		public void MergeFrom(RequeuedForInstance other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSubzoneType = other.HasSubzoneType;
				if (hasSubzoneType)
				{
					this.SubzoneType = other.SubzoneType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00108FA1 File Offset: 0x001071A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00108FAC File Offset: 0x001071AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SubzoneType = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001ED3 RID: 7891
		private static readonly MessageParser<RequeuedForInstance> _parser = new MessageParser<RequeuedForInstance>(() => new RequeuedForInstance());

		// Token: 0x04001ED4 RID: 7892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ED5 RID: 7893
		private int _hasBits0;

		// Token: 0x04001ED6 RID: 7894
		public const int SubzoneTypeFieldNumber = 1;

		// Token: 0x04001ED7 RID: 7895
		private static readonly int SubzoneTypeDefaultValue = 0;

		// Token: 0x04001ED8 RID: 7896
		private int subzoneType_;
	}
}

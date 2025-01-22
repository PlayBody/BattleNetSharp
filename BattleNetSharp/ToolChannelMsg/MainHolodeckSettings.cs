using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000022 RID: 34
	public sealed class MainHolodeckSettings : IMessage<MainHolodeckSettings>, IMessage, IEquatable<MainHolodeckSettings>, IDeepCloneable<MainHolodeckSettings>, IBufferMessage
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		[DebuggerNonUserCode]
		public static MessageParser<MainHolodeckSettings> Parser
		{
			get
			{
				return MainHolodeckSettings._parser;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000CC10 File Offset: 0x0000AE10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainHolodeckSettings.Descriptor;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000CC27 File Offset: 0x0000AE27
		[DebuggerNonUserCode]
		public MainHolodeckSettings()
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000CC31 File Offset: 0x0000AE31
		[DebuggerNonUserCode]
		public MainHolodeckSettings(MainHolodeckSettings other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.holodeckId_ = other.holodeckId_;
			this.gridVisible_ = other.gridVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000CC70 File Offset: 0x0000AE70
		[DebuggerNonUserCode]
		public MainHolodeckSettings Clone()
		{
			return new MainHolodeckSettings(this);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000CC88 File Offset: 0x0000AE88
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000CCB9 File Offset: 0x0000AEB9
		[DebuggerNonUserCode]
		public int HolodeckId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int holodeckIdDefaultValue;
				if (flag)
				{
					holodeckIdDefaultValue = this.holodeckId_;
				}
				else
				{
					holodeckIdDefaultValue = MainHolodeckSettings.HolodeckIdDefaultValue;
				}
				return holodeckIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.holodeckId_ = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		[DebuggerNonUserCode]
		public bool HasHolodeckId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000CCF1 File Offset: 0x0000AEF1
		[DebuggerNonUserCode]
		public void ClearHolodeckId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000CD04 File Offset: 0x0000AF04
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000CD35 File Offset: 0x0000AF35
		[DebuggerNonUserCode]
		public bool GridVisible
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool gridVisibleDefaultValue;
				if (flag)
				{
					gridVisibleDefaultValue = this.gridVisible_;
				}
				else
				{
					gridVisibleDefaultValue = MainHolodeckSettings.GridVisibleDefaultValue;
				}
				return gridVisibleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.gridVisible_ = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[DebuggerNonUserCode]
		public bool HasGridVisible
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000CD6D File Offset: 0x0000AF6D
		[DebuggerNonUserCode]
		public void ClearGridVisible()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainHolodeckSettings);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		[DebuggerNonUserCode]
		public bool Equals(MainHolodeckSettings other)
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
					bool flag4 = this.HolodeckId != other.HolodeckId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GridVisible != other.GridVisible;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000CE14 File Offset: 0x0000B014
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num ^= this.HolodeckId.GetHashCode();
			}
			bool hasGridVisible = this.HasGridVisible;
			if (hasGridVisible)
			{
				num ^= this.GridVisible.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000CE84 File Offset: 0x0000B084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000CE9C File Offset: 0x0000B09C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HolodeckId);
			}
			bool hasGridVisible = this.HasGridVisible;
			if (hasGridVisible)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.GridVisible);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000CF18 File Offset: 0x0000B118
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHolodeckId = this.HasHolodeckId;
			if (hasHolodeckId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HolodeckId);
			}
			bool hasGridVisible = this.HasGridVisible;
			if (hasGridVisible)
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

		// Token: 0x060001C5 RID: 453 RVA: 0x0000CF78 File Offset: 0x0000B178
		[DebuggerNonUserCode]
		public void MergeFrom(MainHolodeckSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHolodeckId = other.HasHolodeckId;
				if (hasHolodeckId)
				{
					this.HolodeckId = other.HolodeckId;
				}
				bool hasGridVisible = other.HasGridVisible;
				if (hasGridVisible)
				{
					this.GridVisible = other.GridVisible;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000CFDA File Offset: 0x0000B1DA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GridVisible = input.ReadBool();
					}
				}
				else
				{
					this.HolodeckId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040000B8 RID: 184
		private static readonly MessageParser<MainHolodeckSettings> _parser = new MessageParser<MainHolodeckSettings>(() => new MainHolodeckSettings());

		// Token: 0x040000B9 RID: 185
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000BA RID: 186
		private int _hasBits0;

		// Token: 0x040000BB RID: 187
		public const int HolodeckIdFieldNumber = 1;

		// Token: 0x040000BC RID: 188
		private static readonly int HolodeckIdDefaultValue = 0;

		// Token: 0x040000BD RID: 189
		private int holodeckId_;

		// Token: 0x040000BE RID: 190
		public const int GridVisibleFieldNumber = 2;

		// Token: 0x040000BF RID: 191
		private static readonly bool GridVisibleDefaultValue = false;

		// Token: 0x040000C0 RID: 192
		private bool gridVisible_;
	}
}

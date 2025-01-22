using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000AD RID: 173
	public sealed class UIControlSelected : IMessage<UIControlSelected>, IMessage, IEquatable<UIControlSelected>, IDeepCloneable<UIControlSelected>, IBufferMessage
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x0003B55C File Offset: 0x0003975C
		[DebuggerNonUserCode]
		public static MessageParser<UIControlSelected> Parser
		{
			get
			{
				return UIControlSelected._parser;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0003B574 File Offset: 0x00039774
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[150];
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0003B59C File Offset: 0x0003979C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UIControlSelected.Descriptor;
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0003B5B3 File Offset: 0x000397B3
		[DebuggerNonUserCode]
		public UIControlSelected()
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0003B5C0 File Offset: 0x000397C0
		[DebuggerNonUserCode]
		public UIControlSelected(UIControlSelected other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.path_ = other.path_;
			this.uiSno_ = other.uiSno_;
			this.operation_ = other.operation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0003B618 File Offset: 0x00039818
		[DebuggerNonUserCode]
		public UIControlSelected Clone()
		{
			return new UIControlSelected(this);
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0003B630 File Offset: 0x00039830
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x0003B651 File Offset: 0x00039851
		[DebuggerNonUserCode]
		public string Path
		{
			get
			{
				return this.path_ ?? UIControlSelected.PathDefaultValue;
			}
			set
			{
				this.path_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0003B668 File Offset: 0x00039868
		[DebuggerNonUserCode]
		public bool HasPath
		{
			get
			{
				return this.path_ != null;
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0003B683 File Offset: 0x00039883
		[DebuggerNonUserCode]
		public void ClearPath()
		{
			this.path_ = null;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0003B690 File Offset: 0x00039890
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x0003B6C1 File Offset: 0x000398C1
		[DebuggerNonUserCode]
		public int UiSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int uiSnoDefaultValue;
				if (flag)
				{
					uiSnoDefaultValue = this.uiSno_;
				}
				else
				{
					uiSnoDefaultValue = UIControlSelected.UiSnoDefaultValue;
				}
				return uiSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.uiSno_ = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0003B6DC File Offset: 0x000398DC
		[DebuggerNonUserCode]
		public bool HasUiSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0003B6F9 File Offset: 0x000398F9
		[DebuggerNonUserCode]
		public void ClearUiSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0003B70C File Offset: 0x0003990C
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x0003B73D File Offset: 0x0003993D
		[DebuggerNonUserCode]
		public int Operation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int operationDefaultValue;
				if (flag)
				{
					operationDefaultValue = this.operation_;
				}
				else
				{
					operationDefaultValue = UIControlSelected.OperationDefaultValue;
				}
				return operationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.operation_ = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0003B758 File Offset: 0x00039958
		[DebuggerNonUserCode]
		public bool HasOperation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0003B775 File Offset: 0x00039975
		[DebuggerNonUserCode]
		public void ClearOperation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0003B788 File Offset: 0x00039988
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UIControlSelected);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0003B7A8 File Offset: 0x000399A8
		[DebuggerNonUserCode]
		public bool Equals(UIControlSelected other)
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
					bool flag4 = this.Path != other.Path;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UiSno != other.UiSno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Operation != other.Operation;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0003B834 File Offset: 0x00039A34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				num ^= this.Path.GetHashCode();
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num ^= this.UiSno.GetHashCode();
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num ^= this.Operation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0003B8D4 File Offset: 0x00039AD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Path);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UiSno);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Operation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0003B970 File Offset: 0x00039B70
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPath = this.HasPath;
			if (hasPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Path);
			}
			bool hasUiSno = this.HasUiSno;
			if (hasUiSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UiSno);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0003B9FC File Offset: 0x00039BFC
		[DebuggerNonUserCode]
		public void MergeFrom(UIControlSelected other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPath = other.HasPath;
				if (hasPath)
				{
					this.Path = other.Path;
				}
				bool hasUiSno = other.HasUiSno;
				if (hasUiSno)
				{
					this.UiSno = other.UiSno;
				}
				bool hasOperation = other.HasOperation;
				if (hasOperation)
				{
					this.Operation = other.Operation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0003BA77 File Offset: 0x00039C77
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0003BA84 File Offset: 0x00039C84
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Operation = input.ReadInt32();
						}
					}
					else
					{
						this.UiSno = input.ReadInt32();
					}
				}
				else
				{
					this.Path = input.ReadString();
				}
			}
		}

		// Token: 0x0400066C RID: 1644
		private static readonly MessageParser<UIControlSelected> _parser = new MessageParser<UIControlSelected>(() => new UIControlSelected());

		// Token: 0x0400066D RID: 1645
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400066E RID: 1646
		private int _hasBits0;

		// Token: 0x0400066F RID: 1647
		public const int PathFieldNumber = 1;

		// Token: 0x04000670 RID: 1648
		private static readonly string PathDefaultValue = "";

		// Token: 0x04000671 RID: 1649
		private string path_;

		// Token: 0x04000672 RID: 1650
		public const int UiSnoFieldNumber = 2;

		// Token: 0x04000673 RID: 1651
		private static readonly int UiSnoDefaultValue = 0;

		// Token: 0x04000674 RID: 1652
		private int uiSno_;

		// Token: 0x04000675 RID: 1653
		public const int OperationFieldNumber = 3;

		// Token: 0x04000676 RID: 1654
		private static readonly int OperationDefaultValue = 0;

		// Token: 0x04000677 RID: 1655
		private int operation_;
	}
}

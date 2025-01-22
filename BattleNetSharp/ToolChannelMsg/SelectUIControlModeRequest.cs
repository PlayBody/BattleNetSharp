using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009F RID: 159
	public sealed class SelectUIControlModeRequest : IMessage<SelectUIControlModeRequest>, IMessage, IEquatable<SelectUIControlModeRequest>, IDeepCloneable<SelectUIControlModeRequest>, IBufferMessage
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000366D8 File Offset: 0x000348D8
		[DebuggerNonUserCode]
		public static MessageParser<SelectUIControlModeRequest> Parser
		{
			get
			{
				return SelectUIControlModeRequest._parser;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000366F0 File Offset: 0x000348F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[136];
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00036718 File Offset: 0x00034918
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectUIControlModeRequest.Descriptor;
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0003672F File Offset: 0x0003492F
		[DebuggerNonUserCode]
		public SelectUIControlModeRequest()
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00036739 File Offset: 0x00034939
		[DebuggerNonUserCode]
		public SelectUIControlModeRequest(SelectUIControlModeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0003676C File Offset: 0x0003496C
		[DebuggerNonUserCode]
		public SelectUIControlModeRequest Clone()
		{
			return new SelectUIControlModeRequest(this);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00036784 File Offset: 0x00034984
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x000367B5 File Offset: 0x000349B5
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = SelectUIControlModeRequest.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000367D0 File Offset: 0x000349D0
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000367ED File Offset: 0x000349ED
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00036800 File Offset: 0x00034A00
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectUIControlModeRequest);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00036820 File Offset: 0x00034A20
		[DebuggerNonUserCode]
		public bool Equals(SelectUIControlModeRequest other)
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
					bool flag4 = this.Enabled != other.Enabled;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00036878 File Offset: 0x00034A78
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000368C8 File Offset: 0x00034AC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x000368E0 File Offset: 0x00034AE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000368EC File Offset: 0x00034AEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00036938 File Offset: 0x00034B38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
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

		// Token: 0x06000E9B RID: 3739 RVA: 0x0003697C File Offset: 0x00034B7C
		[DebuggerNonUserCode]
		public void MergeFrom(SelectUIControlModeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000369C5 File Offset: 0x00034BC5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000369D0 File Offset: 0x00034BD0
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
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x040005D0 RID: 1488
		private static readonly MessageParser<SelectUIControlModeRequest> _parser = new MessageParser<SelectUIControlModeRequest>(() => new SelectUIControlModeRequest());

		// Token: 0x040005D1 RID: 1489
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005D2 RID: 1490
		private int _hasBits0;

		// Token: 0x040005D3 RID: 1491
		public const int EnabledFieldNumber = 1;

		// Token: 0x040005D4 RID: 1492
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x040005D5 RID: 1493
		private bool enabled_;
	}
}

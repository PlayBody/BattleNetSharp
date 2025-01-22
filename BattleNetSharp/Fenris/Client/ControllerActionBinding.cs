using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000115 RID: 277
	public sealed class ControllerActionBinding : IMessage<ControllerActionBinding>, IMessage, IEquatable<ControllerActionBinding>, IDeepCloneable<ControllerActionBinding>, IBufferMessage
	{
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x0005E830 File Offset: 0x0005CA30
		[DebuggerNonUserCode]
		public static MessageParser<ControllerActionBinding> Parser
		{
			get
			{
				return ControllerActionBinding._parser;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0005E848 File Offset: 0x0005CA48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x0005E86C File Offset: 0x0005CA6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ControllerActionBinding.Descriptor;
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0005E883 File Offset: 0x0005CA83
		[DebuggerNonUserCode]
		public ControllerActionBinding()
		{
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0005E88D File Offset: 0x0005CA8D
		[DebuggerNonUserCode]
		public ControllerActionBinding(ControllerActionBinding other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.button_ = other.button_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0005E8C0 File Offset: 0x0005CAC0
		[DebuggerNonUserCode]
		public ControllerActionBinding Clone()
		{
			return new ControllerActionBinding(this);
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x0005E8D8 File Offset: 0x0005CAD8
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0005E909 File Offset: 0x0005CB09
		[DebuggerNonUserCode]
		public int Button
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int buttonDefaultValue;
				if (flag)
				{
					buttonDefaultValue = this.button_;
				}
				else
				{
					buttonDefaultValue = ControllerActionBinding.ButtonDefaultValue;
				}
				return buttonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.button_ = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0005E924 File Offset: 0x0005CB24
		[DebuggerNonUserCode]
		public bool HasButton
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0005E941 File Offset: 0x0005CB41
		[DebuggerNonUserCode]
		public void ClearButton()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0005E954 File Offset: 0x0005CB54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ControllerActionBinding);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0005E974 File Offset: 0x0005CB74
		[DebuggerNonUserCode]
		public bool Equals(ControllerActionBinding other)
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
					bool flag4 = this.Button != other.Button;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0005E9CC File Offset: 0x0005CBCC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasButton = this.HasButton;
			if (hasButton)
			{
				num ^= this.Button.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0005EA1C File Offset: 0x0005CC1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0005EA34 File Offset: 0x0005CC34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0005EA40 File Offset: 0x0005CC40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasButton = this.HasButton;
			if (hasButton)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Button);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0005EA8C File Offset: 0x0005CC8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasButton = this.HasButton;
			if (hasButton)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Button);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0005EADC File Offset: 0x0005CCDC
		[DebuggerNonUserCode]
		public void MergeFrom(ControllerActionBinding other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasButton = other.HasButton;
				if (hasButton)
				{
					this.Button = other.Button;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0005EB25 File Offset: 0x0005CD25
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0005EB30 File Offset: 0x0005CD30
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
					this.Button = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000A80 RID: 2688
		private static readonly MessageParser<ControllerActionBinding> _parser = new MessageParser<ControllerActionBinding>(() => new ControllerActionBinding());

		// Token: 0x04000A81 RID: 2689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A82 RID: 2690
		private int _hasBits0;

		// Token: 0x04000A83 RID: 2691
		public const int ButtonFieldNumber = 1;

		// Token: 0x04000A84 RID: 2692
		private static readonly int ButtonDefaultValue = -1;

		// Token: 0x04000A85 RID: 2693
		private int button_;
	}
}

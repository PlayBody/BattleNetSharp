using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C3 RID: 195
	public sealed class ReflectionProbesCaptured : IMessage<ReflectionProbesCaptured>, IMessage, IEquatable<ReflectionProbesCaptured>, IDeepCloneable<ReflectionProbesCaptured>, IBufferMessage
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000439B0 File Offset: 0x00041BB0
		[DebuggerNonUserCode]
		public static MessageParser<ReflectionProbesCaptured> Parser
		{
			get
			{
				return ReflectionProbesCaptured._parser;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000439C8 File Offset: 0x00041BC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[172];
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x000439F0 File Offset: 0x00041BF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReflectionProbesCaptured.Descriptor;
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00043A07 File Offset: 0x00041C07
		[DebuggerNonUserCode]
		public ReflectionProbesCaptured()
		{
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00043A11 File Offset: 0x00041C11
		[DebuggerNonUserCode]
		public ReflectionProbesCaptured(ReflectionProbesCaptured other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00043A44 File Offset: 0x00041C44
		[DebuggerNonUserCode]
		public ReflectionProbesCaptured Clone()
		{
			return new ReflectionProbesCaptured(this);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00043A5C File Offset: 0x00041C5C
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x00043A8D File Offset: 0x00041C8D
		[DebuggerNonUserCode]
		public bool Success
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool successDefaultValue;
				if (flag)
				{
					successDefaultValue = this.success_;
				}
				else
				{
					successDefaultValue = ReflectionProbesCaptured.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00043AA8 File Offset: 0x00041CA8
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00043AC5 File Offset: 0x00041CC5
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00043AD8 File Offset: 0x00041CD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReflectionProbesCaptured);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00043AF8 File Offset: 0x00041CF8
		[DebuggerNonUserCode]
		public bool Equals(ReflectionProbesCaptured other)
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
					bool flag4 = this.Success != other.Success;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00043B50 File Offset: 0x00041D50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num ^= this.Success.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00043BA0 File Offset: 0x00041DA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00043BB8 File Offset: 0x00041DB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00043BC4 File Offset: 0x00041DC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Success);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00043C10 File Offset: 0x00041E10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
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

		// Token: 0x06001283 RID: 4739 RVA: 0x00043C54 File Offset: 0x00041E54
		[DebuggerNonUserCode]
		public void MergeFrom(ReflectionProbesCaptured other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSuccess = other.HasSuccess;
				if (hasSuccess)
				{
					this.Success = other.Success;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00043C9D File Offset: 0x00041E9D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00043CA8 File Offset: 0x00041EA8
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
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x0400076D RID: 1901
		private static readonly MessageParser<ReflectionProbesCaptured> _parser = new MessageParser<ReflectionProbesCaptured>(() => new ReflectionProbesCaptured());

		// Token: 0x0400076E RID: 1902
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400076F RID: 1903
		private int _hasBits0;

		// Token: 0x04000770 RID: 1904
		public const int SuccessFieldNumber = 1;

		// Token: 0x04000771 RID: 1905
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x04000772 RID: 1906
		private bool success_;
	}
}

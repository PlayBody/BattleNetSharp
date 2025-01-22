using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000349 RID: 841
	public sealed class MemoryDetails : IMessage<MemoryDetails>, IMessage, IEquatable<MemoryDetails>, IDeepCloneable<MemoryDetails>, IBufferMessage
	{
		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06005781 RID: 22401 RVA: 0x00152C1C File Offset: 0x00150E1C
		[DebuggerNonUserCode]
		public static MessageParser<MemoryDetails> Parser
		{
			get
			{
				return MemoryDetails._parser;
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x00152C34 File Offset: 0x00150E34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsSystemMemoryReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06005783 RID: 22403 RVA: 0x00152C58 File Offset: 0x00150E58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemoryDetails.Descriptor;
			}
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x00152C6F File Offset: 0x00150E6F
		[DebuggerNonUserCode]
		public MemoryDetails()
		{
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x00152C79 File Offset: 0x00150E79
		[DebuggerNonUserCode]
		public MemoryDetails(MemoryDetails other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.totalMemoryGb_ = other.totalMemoryGb_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x00152CAC File Offset: 0x00150EAC
		[DebuggerNonUserCode]
		public MemoryDetails Clone()
		{
			return new MemoryDetails(this);
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x00152CC4 File Offset: 0x00150EC4
		// (set) Token: 0x06005788 RID: 22408 RVA: 0x00152CF5 File Offset: 0x00150EF5
		[DebuggerNonUserCode]
		public float TotalMemoryGb
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float totalMemoryGbDefaultValue;
				if (flag)
				{
					totalMemoryGbDefaultValue = this.totalMemoryGb_;
				}
				else
				{
					totalMemoryGbDefaultValue = MemoryDetails.TotalMemoryGbDefaultValue;
				}
				return totalMemoryGbDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.totalMemoryGb_ = value;
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x00152D10 File Offset: 0x00150F10
		[DebuggerNonUserCode]
		public bool HasTotalMemoryGb
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x00152D2D File Offset: 0x00150F2D
		[DebuggerNonUserCode]
		public void ClearTotalMemoryGb()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600578B RID: 22411 RVA: 0x00152D40 File Offset: 0x00150F40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemoryDetails);
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x00152D60 File Offset: 0x00150F60
		[DebuggerNonUserCode]
		public bool Equals(MemoryDetails other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.TotalMemoryGb, other.TotalMemoryGb);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00152DC0 File Offset: 0x00150FC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTotalMemoryGb = this.HasTotalMemoryGb;
			if (hasTotalMemoryGb)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.TotalMemoryGb);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x00152E10 File Offset: 0x00151010
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x00152E28 File Offset: 0x00151028
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x00152E34 File Offset: 0x00151034
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTotalMemoryGb = this.HasTotalMemoryGb;
			if (hasTotalMemoryGb)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.TotalMemoryGb);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x00152E80 File Offset: 0x00151080
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTotalMemoryGb = this.HasTotalMemoryGb;
			if (hasTotalMemoryGb)
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

		// Token: 0x06005792 RID: 22418 RVA: 0x00152EC4 File Offset: 0x001510C4
		[DebuggerNonUserCode]
		public void MergeFrom(MemoryDetails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTotalMemoryGb = other.HasTotalMemoryGb;
				if (hasTotalMemoryGb)
				{
					this.TotalMemoryGb = other.TotalMemoryGb;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00152F0D File Offset: 0x0015110D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00152F18 File Offset: 0x00151118
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
					this.TotalMemoryGb = input.ReadFloat();
				}
			}
		}

		// Token: 0x040027F6 RID: 10230
		private static readonly MessageParser<MemoryDetails> _parser = new MessageParser<MemoryDetails>(() => new MemoryDetails());

		// Token: 0x040027F7 RID: 10231
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F8 RID: 10232
		private int _hasBits0;

		// Token: 0x040027F9 RID: 10233
		public const int TotalMemoryGbFieldNumber = 1;

		// Token: 0x040027FA RID: 10234
		private static readonly float TotalMemoryGbDefaultValue = 0f;

		// Token: 0x040027FB RID: 10235
		private float totalMemoryGb_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CE RID: 206
	public sealed class ChangeManipulator : IMessage<ChangeManipulator>, IMessage, IEquatable<ChangeManipulator>, IDeepCloneable<ChangeManipulator>, IBufferMessage
	{
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00047CF8 File Offset: 0x00045EF8
		[DebuggerNonUserCode]
		public static MessageParser<ChangeManipulator> Parser
		{
			get
			{
				return ChangeManipulator._parser;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00047D10 File Offset: 0x00045F10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[183];
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00047D38 File Offset: 0x00045F38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeManipulator.Descriptor;
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00047D4F File Offset: 0x00045F4F
		[DebuggerNonUserCode]
		public ChangeManipulator()
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00047D5C File Offset: 0x00045F5C
		[DebuggerNonUserCode]
		public ChangeManipulator(ChangeManipulator other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.manipulator_ = other.manipulator_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00047DB4 File Offset: 0x00045FB4
		[DebuggerNonUserCode]
		public ChangeManipulator Clone()
		{
			return new ChangeManipulator(this);
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00047DCC File Offset: 0x00045FCC
		// (set) Token: 0x060013B4 RID: 5044 RVA: 0x00047DFD File Offset: 0x00045FFD
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = ChangeManipulator.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00047E18 File Offset: 0x00046018
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00047E35 File Offset: 0x00046035
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00047E48 File Offset: 0x00046048
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x00047E79 File Offset: 0x00046079
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = ChangeManipulator.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00047E94 File Offset: 0x00046094
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00047EB1 File Offset: 0x000460B1
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x00047EC4 File Offset: 0x000460C4
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x00047EF5 File Offset: 0x000460F5
		[DebuggerNonUserCode]
		public int Manipulator
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int manipulatorDefaultValue;
				if (flag)
				{
					manipulatorDefaultValue = this.manipulator_;
				}
				else
				{
					manipulatorDefaultValue = ChangeManipulator.ManipulatorDefaultValue;
				}
				return manipulatorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.manipulator_ = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00047F10 File Offset: 0x00046110
		[DebuggerNonUserCode]
		public bool HasManipulator
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00047F2D File Offset: 0x0004612D
		[DebuggerNonUserCode]
		public void ClearManipulator()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00047F40 File Offset: 0x00046140
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeManipulator);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00047F60 File Offset: 0x00046160
		[DebuggerNonUserCode]
		public bool Equals(ChangeManipulator other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Manipulator != other.Manipulator;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00047FEC File Offset: 0x000461EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasManipulator = this.HasManipulator;
			if (hasManipulator)
			{
				num ^= this.Manipulator.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00048078 File Offset: 0x00046278
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00048090 File Offset: 0x00046290
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0004809C File Offset: 0x0004629C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasManipulator = this.HasManipulator;
			if (hasManipulator)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Manipulator);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0004812C File Offset: 0x0004632C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasManipulator = this.HasManipulator;
			if (hasManipulator)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Manipulator);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x000481B8 File Offset: 0x000463B8
		[DebuggerNonUserCode]
		public void MergeFrom(ChangeManipulator other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasManipulator = other.HasManipulator;
				if (hasManipulator)
				{
					this.Manipulator = other.Manipulator;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00048233 File Offset: 0x00046433
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00048240 File Offset: 0x00046440
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Manipulator = input.ReadInt32();
						}
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else
				{
					this.SnoGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x040007F6 RID: 2038
		private static readonly MessageParser<ChangeManipulator> _parser = new MessageParser<ChangeManipulator>(() => new ChangeManipulator());

		// Token: 0x040007F7 RID: 2039
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007F8 RID: 2040
		private int _hasBits0;

		// Token: 0x040007F9 RID: 2041
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040007FA RID: 2042
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040007FB RID: 2043
		private int snoGroup_;

		// Token: 0x040007FC RID: 2044
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040007FD RID: 2045
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040007FE RID: 2046
		private int snoHandle_;

		// Token: 0x040007FF RID: 2047
		public const int ManipulatorFieldNumber = 3;

		// Token: 0x04000800 RID: 2048
		private static readonly int ManipulatorDefaultValue = 0;

		// Token: 0x04000801 RID: 2049
		private int manipulator_;
	}
}

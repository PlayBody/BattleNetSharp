using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A0 RID: 416
	public sealed class SavePointData_Proto : IMessage<SavePointData_Proto>, IMessage, IEquatable<SavePointData_Proto>, IDeepCloneable<SavePointData_Proto>, IBufferMessage
	{
		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000ACFA4 File Offset: 0x000AB1A4
		[DebuggerNonUserCode]
		public static MessageParser<SavePointData_Proto> Parser
		{
			get
			{
				return SavePointData_Proto._parser;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000ACFBC File Offset: 0x000AB1BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000ACFE0 File Offset: 0x000AB1E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavePointData_Proto.Descriptor;
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000ACFF7 File Offset: 0x000AB1F7
		[DebuggerNonUserCode]
		public SavePointData_Proto()
		{
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000AD004 File Offset: 0x000AB204
		[DebuggerNonUserCode]
		public SavePointData_Proto(SavePointData_Proto other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.savepointNumber_ = other.savepointNumber_;
			this.createsPortal_ = other.createsPortal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000AD05C File Offset: 0x000AB25C
		[DebuggerNonUserCode]
		public SavePointData_Proto Clone()
		{
			return new SavePointData_Proto(this);
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000AD074 File Offset: 0x000AB274
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x000AD0A5 File Offset: 0x000AB2A5
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = SavePointData_Proto.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000AD0DD File Offset: 0x000AB2DD
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000AD0F0 File Offset: 0x000AB2F0
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x000AD121 File Offset: 0x000AB321
		[DebuggerNonUserCode]
		public int SavepointNumber
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int savepointNumberDefaultValue;
				if (flag)
				{
					savepointNumberDefaultValue = this.savepointNumber_;
				}
				else
				{
					savepointNumberDefaultValue = SavePointData_Proto.SavepointNumberDefaultValue;
				}
				return savepointNumberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.savepointNumber_ = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x000AD13C File Offset: 0x000AB33C
		[DebuggerNonUserCode]
		public bool HasSavepointNumber
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000AD159 File Offset: 0x000AB359
		[DebuggerNonUserCode]
		public void ClearSavepointNumber()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x000AD16C File Offset: 0x000AB36C
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x000AD19D File Offset: 0x000AB39D
		[DebuggerNonUserCode]
		public uint CreatesPortal
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint createsPortalDefaultValue;
				if (flag)
				{
					createsPortalDefaultValue = this.createsPortal_;
				}
				else
				{
					createsPortalDefaultValue = SavePointData_Proto.CreatesPortalDefaultValue;
				}
				return createsPortalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.createsPortal_ = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000AD1B8 File Offset: 0x000AB3B8
		[DebuggerNonUserCode]
		public bool HasCreatesPortal
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000AD1D5 File Offset: 0x000AB3D5
		[DebuggerNonUserCode]
		public void ClearCreatesPortal()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavePointData_Proto);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000AD208 File Offset: 0x000AB408
		[DebuggerNonUserCode]
		public bool Equals(SavePointData_Proto other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SavepointNumber != other.SavepointNumber;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreatesPortal != other.CreatesPortal;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000AD294 File Offset: 0x000AB494
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasSavepointNumber = this.HasSavepointNumber;
			if (hasSavepointNumber)
			{
				num ^= this.SavepointNumber.GetHashCode();
			}
			bool hasCreatesPortal = this.HasCreatesPortal;
			if (hasCreatesPortal)
			{
				num ^= this.CreatesPortal.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000AD320 File Offset: 0x000AB520
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000AD338 File Offset: 0x000AB538
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000AD344 File Offset: 0x000AB544
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool hasSavepointNumber = this.HasSavepointNumber;
			if (hasSavepointNumber)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.SavepointNumber);
			}
			bool hasCreatesPortal = this.HasCreatesPortal;
			if (hasCreatesPortal)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CreatesPortal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000AD3D4 File Offset: 0x000AB5D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool hasSavepointNumber = this.HasSavepointNumber;
			if (hasSavepointNumber)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.SavepointNumber);
			}
			bool hasCreatesPortal = this.HasCreatesPortal;
			if (hasCreatesPortal)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreatesPortal);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000AD454 File Offset: 0x000AB654
		[DebuggerNonUserCode]
		public void MergeFrom(SavePointData_Proto other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasSavepointNumber = other.HasSavepointNumber;
				if (hasSavepointNumber)
				{
					this.SavepointNumber = other.SavepointNumber;
				}
				bool hasCreatesPortal = other.HasCreatesPortal;
				if (hasCreatesPortal)
				{
					this.CreatesPortal = other.CreatesPortal;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000AD4CF File Offset: 0x000AB6CF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000AD4DC File Offset: 0x000AB6DC
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CreatesPortal = input.ReadUInt32();
						}
					}
					else
					{
						this.SavepointNumber = input.ReadSInt32();
					}
				}
				else
				{
					this.SnoWorld = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x040013E6 RID: 5094
		private static readonly MessageParser<SavePointData_Proto> _parser = new MessageParser<SavePointData_Proto>(() => new SavePointData_Proto());

		// Token: 0x040013E7 RID: 5095
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013E8 RID: 5096
		private int _hasBits0;

		// Token: 0x040013E9 RID: 5097
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x040013EA RID: 5098
		private static readonly int SnoWorldDefaultValue = -1;

		// Token: 0x040013EB RID: 5099
		private int snoWorld_;

		// Token: 0x040013EC RID: 5100
		public const int SavepointNumberFieldNumber = 2;

		// Token: 0x040013ED RID: 5101
		private static readonly int SavepointNumberDefaultValue = -1;

		// Token: 0x040013EE RID: 5102
		private int savepointNumber_;

		// Token: 0x040013EF RID: 5103
		public const int CreatesPortalFieldNumber = 3;

		// Token: 0x040013F0 RID: 5104
		private static readonly uint CreatesPortalDefaultValue = 0U;

		// Token: 0x040013F1 RID: 5105
		private uint createsPortal_;
	}
}

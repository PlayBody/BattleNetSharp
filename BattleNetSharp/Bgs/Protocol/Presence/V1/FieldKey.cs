using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AD RID: 1453
	public sealed class FieldKey : IMessage<FieldKey>, IMessage, IEquatable<FieldKey>, IDeepCloneable<FieldKey>, IBufferMessage
	{
		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06008A1D RID: 35357 RVA: 0x00218BE0 File Offset: 0x00216DE0
		[DebuggerNonUserCode]
		public static MessageParser<FieldKey> Parser
		{
			get
			{
				return FieldKey._parser;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06008A1E RID: 35358 RVA: 0x00218BF8 File Offset: 0x00216DF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06008A1F RID: 35359 RVA: 0x00218C1C File Offset: 0x00216E1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldKey.Descriptor;
			}
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x00218C33 File Offset: 0x00216E33
		[DebuggerNonUserCode]
		public FieldKey()
		{
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x00218C40 File Offset: 0x00216E40
		[DebuggerNonUserCode]
		public FieldKey(FieldKey other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.group_ = other.group_;
			this.field_ = other.field_;
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x00218CA4 File Offset: 0x00216EA4
		[DebuggerNonUserCode]
		public FieldKey Clone()
		{
			return new FieldKey(this);
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008A23 RID: 35363 RVA: 0x00218CBC File Offset: 0x00216EBC
		// (set) Token: 0x06008A24 RID: 35364 RVA: 0x00218CED File Offset: 0x00216EED
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = FieldKey.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x06008A25 RID: 35365 RVA: 0x00218D08 File Offset: 0x00216F08
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x00218D25 File Offset: 0x00216F25
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06008A27 RID: 35367 RVA: 0x00218D38 File Offset: 0x00216F38
		// (set) Token: 0x06008A28 RID: 35368 RVA: 0x00218D69 File Offset: 0x00216F69
		[DebuggerNonUserCode]
		public uint Group
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint groupDefaultValue;
				if (flag)
				{
					groupDefaultValue = this.group_;
				}
				else
				{
					groupDefaultValue = FieldKey.GroupDefaultValue;
				}
				return groupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.group_ = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x06008A29 RID: 35369 RVA: 0x00218D84 File Offset: 0x00216F84
		[DebuggerNonUserCode]
		public bool HasGroup
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x00218DA1 File Offset: 0x00216FA1
		[DebuggerNonUserCode]
		public void ClearGroup()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06008A2B RID: 35371 RVA: 0x00218DB4 File Offset: 0x00216FB4
		// (set) Token: 0x06008A2C RID: 35372 RVA: 0x00218DE5 File Offset: 0x00216FE5
		[DebuggerNonUserCode]
		public uint Field
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint fieldDefaultValue;
				if (flag)
				{
					fieldDefaultValue = this.field_;
				}
				else
				{
					fieldDefaultValue = FieldKey.FieldDefaultValue;
				}
				return fieldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.field_ = value;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06008A2D RID: 35373 RVA: 0x00218E00 File Offset: 0x00217000
		[DebuggerNonUserCode]
		public bool HasField
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00218E1D File Offset: 0x0021701D
		[DebuggerNonUserCode]
		public void ClearField()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x06008A2F RID: 35375 RVA: 0x00218E30 File Offset: 0x00217030
		// (set) Token: 0x06008A30 RID: 35376 RVA: 0x00218E61 File Offset: 0x00217061
		[DebuggerNonUserCode]
		public ulong UniqueId
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong uniqueIdDefaultValue;
				if (flag)
				{
					uniqueIdDefaultValue = this.uniqueId_;
				}
				else
				{
					uniqueIdDefaultValue = FieldKey.UniqueIdDefaultValue;
				}
				return uniqueIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.uniqueId_ = value;
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x06008A31 RID: 35377 RVA: 0x00218E7C File Offset: 0x0021707C
		[DebuggerNonUserCode]
		public bool HasUniqueId
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x00218E99 File Offset: 0x00217099
		[DebuggerNonUserCode]
		public void ClearUniqueId()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x00218EAC File Offset: 0x002170AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldKey);
		}

		// Token: 0x06008A34 RID: 35380 RVA: 0x00218ECC File Offset: 0x002170CC
		[DebuggerNonUserCode]
		public bool Equals(FieldKey other)
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
					bool flag4 = this.Program != other.Program;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Group != other.Group;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Field != other.Field;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.UniqueId != other.UniqueId;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008A35 RID: 35381 RVA: 0x00218F78 File Offset: 0x00217178
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				num ^= this.Group.GetHashCode();
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				num ^= this.Field.GetHashCode();
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A36 RID: 35382 RVA: 0x00219020 File Offset: 0x00217220
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A37 RID: 35383 RVA: 0x00219038 File Offset: 0x00217238
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x00219044 File Offset: 0x00217244
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Program);
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Group);
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Field);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.UniqueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x002190F8 File Offset: 0x002172F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool hasGroup = this.HasGroup;
			if (hasGroup)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Group);
			}
			bool hasField = this.HasField;
			if (hasField)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Field);
			}
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.UniqueId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x002191A0 File Offset: 0x002173A0
		[DebuggerNonUserCode]
		public void MergeFrom(FieldKey other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasGroup = other.HasGroup;
				if (hasGroup)
				{
					this.Group = other.Group;
				}
				bool hasField = other.HasField;
				if (hasField)
				{
					this.Field = other.Field;
				}
				bool hasUniqueId = other.HasUniqueId;
				if (hasUniqueId)
				{
					this.UniqueId = other.UniqueId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x00219236 File Offset: 0x00217436
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x00219244 File Offset: 0x00217444
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.Group = input.ReadUInt32();
					}
					else
					{
						this.Program = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.UniqueId = input.ReadUInt64();
				}
				else
				{
					this.Field = input.ReadUInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003E8B RID: 16011
		private static readonly MessageParser<FieldKey> _parser = new MessageParser<FieldKey>(() => new FieldKey());

		// Token: 0x04003E8C RID: 16012
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E8D RID: 16013
		private int _hasBits0;

		// Token: 0x04003E8E RID: 16014
		public const int ProgramFieldNumber = 1;

		// Token: 0x04003E8F RID: 16015
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04003E90 RID: 16016
		private uint program_;

		// Token: 0x04003E91 RID: 16017
		public const int GroupFieldNumber = 2;

		// Token: 0x04003E92 RID: 16018
		private static readonly uint GroupDefaultValue = 0U;

		// Token: 0x04003E93 RID: 16019
		private uint group_;

		// Token: 0x04003E94 RID: 16020
		public const int FieldFieldNumber = 3;

		// Token: 0x04003E95 RID: 16021
		private static readonly uint FieldDefaultValue = 0U;

		// Token: 0x04003E96 RID: 16022
		private uint field_;

		// Token: 0x04003E97 RID: 16023
		public const int UniqueIdFieldNumber = 4;

		// Token: 0x04003E98 RID: 16024
		private static readonly ulong UniqueIdDefaultValue = 0UL;

		// Token: 0x04003E99 RID: 16025
		private ulong uniqueId_;
	}
}

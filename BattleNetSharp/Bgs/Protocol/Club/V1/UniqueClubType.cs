using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200050C RID: 1292
	public sealed class UniqueClubType : IMessage<UniqueClubType>, IMessage, IEquatable<UniqueClubType>, IDeepCloneable<UniqueClubType>, IBufferMessage
	{
		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x001EAFA4 File Offset: 0x001E91A4
		[DebuggerNonUserCode]
		public static MessageParser<UniqueClubType> Parser
		{
			get
			{
				return UniqueClubType._parser;
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x001EAFBC File Offset: 0x001E91BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubTypeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x06007E1C RID: 32284 RVA: 0x001EAFE0 File Offset: 0x001E91E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UniqueClubType.Descriptor;
			}
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x001EAFF7 File Offset: 0x001E91F7
		[DebuggerNonUserCode]
		public UniqueClubType()
		{
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x001EB001 File Offset: 0x001E9201
		[DebuggerNonUserCode]
		public UniqueClubType(UniqueClubType other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x001EB040 File Offset: 0x001E9240
		[DebuggerNonUserCode]
		public UniqueClubType Clone()
		{
			return new UniqueClubType(this);
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x06007E20 RID: 32288 RVA: 0x001EB058 File Offset: 0x001E9258
		// (set) Token: 0x06007E21 RID: 32289 RVA: 0x001EB089 File Offset: 0x001E9289
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
					programDefaultValue = UniqueClubType.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x001EB0A4 File Offset: 0x001E92A4
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007E23 RID: 32291 RVA: 0x001EB0C1 File Offset: 0x001E92C1
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x001EB0D4 File Offset: 0x001E92D4
		// (set) Token: 0x06007E25 RID: 32293 RVA: 0x001EB0F5 File Offset: 0x001E92F5
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? UniqueClubType.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x001EB10C File Offset: 0x001E930C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x001EB127 File Offset: 0x001E9327
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x001EB134 File Offset: 0x001E9334
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UniqueClubType);
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x001EB154 File Offset: 0x001E9354
		[DebuggerNonUserCode]
		public bool Equals(UniqueClubType other)
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
						bool flag5 = this.Name != other.Name;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x001EB1C8 File Offset: 0x001E93C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x001EB234 File Offset: 0x001E9434
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x001EB24C File Offset: 0x001E944C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x001EB258 File Offset: 0x001E9458
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Program);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x001EB2C8 File Offset: 0x001E94C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x001EB328 File Offset: 0x001E9528
		[DebuggerNonUserCode]
		public void MergeFrom(UniqueClubType other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x001EB38A File Offset: 0x001E958A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x001EB398 File Offset: 0x001E9598
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04003960 RID: 14688
		private static readonly MessageParser<UniqueClubType> _parser = new MessageParser<UniqueClubType>(() => new UniqueClubType());

		// Token: 0x04003961 RID: 14689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003962 RID: 14690
		private int _hasBits0;

		// Token: 0x04003963 RID: 14691
		public const int ProgramFieldNumber = 1;

		// Token: 0x04003964 RID: 14692
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04003965 RID: 14693
		private uint program_;

		// Token: 0x04003966 RID: 14694
		public const int NameFieldNumber = 2;

		// Token: 0x04003967 RID: 14695
		private static readonly string NameDefaultValue = "";

		// Token: 0x04003968 RID: 14696
		private string name_;
	}
}

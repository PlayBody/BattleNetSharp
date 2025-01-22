using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000735 RID: 1845
	public sealed class ProgramTag : IMessage<ProgramTag>, IMessage, IEquatable<ProgramTag>, IDeepCloneable<ProgramTag>, IBufferMessage
	{
		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x00291C70 File Offset: 0x0028FE70
		[DebuggerNonUserCode]
		public static MessageParser<ProgramTag> Parser
		{
			get
			{
				return ProgramTag._parser;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x00291C88 File Offset: 0x0028FE88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x00291CAC File Offset: 0x0028FEAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgramTag.Descriptor;
			}
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x00291CC3 File Offset: 0x0028FEC3
		[DebuggerNonUserCode]
		public ProgramTag()
		{
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x00291CD0 File Offset: 0x0028FED0
		[DebuggerNonUserCode]
		public ProgramTag(ProgramTag other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.tag_ = other.tag_;
			this.securityStatusTag_ = other.securityStatusTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00291D28 File Offset: 0x0028FF28
		[DebuggerNonUserCode]
		public ProgramTag Clone()
		{
			return new ProgramTag(this);
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x00291D40 File Offset: 0x0028FF40
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x00291D71 File Offset: 0x0028FF71
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
					programDefaultValue = ProgramTag.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x00291D8C File Offset: 0x0028FF8C
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A8CB RID: 43211 RVA: 0x00291DA9 File Offset: 0x0028FFA9
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x00291DBC File Offset: 0x0028FFBC
		// (set) Token: 0x0600A8CD RID: 43213 RVA: 0x00291DED File Offset: 0x0028FFED
		[DebuggerNonUserCode]
		public uint Tag
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint tagDefaultValue;
				if (flag)
				{
					tagDefaultValue = this.tag_;
				}
				else
				{
					tagDefaultValue = ProgramTag.TagDefaultValue;
				}
				return tagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.tag_ = value;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x00291E08 File Offset: 0x00290008
		[DebuggerNonUserCode]
		public bool HasTag
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x00291E25 File Offset: 0x00290025
		[DebuggerNonUserCode]
		public void ClearTag()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x00291E38 File Offset: 0x00290038
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x00291E69 File Offset: 0x00290069
		[DebuggerNonUserCode]
		public uint SecurityStatusTag
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint securityStatusTagDefaultValue;
				if (flag)
				{
					securityStatusTagDefaultValue = this.securityStatusTag_;
				}
				else
				{
					securityStatusTagDefaultValue = ProgramTag.SecurityStatusTagDefaultValue;
				}
				return securityStatusTagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.securityStatusTag_ = value;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x00291E84 File Offset: 0x00290084
		[DebuggerNonUserCode]
		public bool HasSecurityStatusTag
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x00291EA1 File Offset: 0x002900A1
		[DebuggerNonUserCode]
		public void ClearSecurityStatusTag()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x00291EB4 File Offset: 0x002900B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgramTag);
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x00291ED4 File Offset: 0x002900D4
		[DebuggerNonUserCode]
		public bool Equals(ProgramTag other)
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
						bool flag5 = this.Tag != other.Tag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SecurityStatusTag != other.SecurityStatusTag;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x00291F60 File Offset: 0x00290160
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num ^= this.Tag.GetHashCode();
			}
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
			{
				num ^= this.SecurityStatusTag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x00291FEC File Offset: 0x002901EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x00292004 File Offset: 0x00290204
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x00292010 File Offset: 0x00290210
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Program);
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Tag);
			}
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
			{
				output.WriteRawTag(101);
				output.WriteFixed32(this.SecurityStatusTag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x002920A0 File Offset: 0x002902A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasTag = this.HasTag;
			if (hasTag)
			{
				num += 5;
			}
			bool hasSecurityStatusTag = this.HasSecurityStatusTag;
			if (hasSecurityStatusTag)
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

		// Token: 0x0600A8DB RID: 43227 RVA: 0x00292108 File Offset: 0x00290308
		[DebuggerNonUserCode]
		public void MergeFrom(ProgramTag other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasTag = other.HasTag;
				if (hasTag)
				{
					this.Tag = other.Tag;
				}
				bool hasSecurityStatusTag = other.HasSecurityStatusTag;
				if (hasSecurityStatusTag)
				{
					this.SecurityStatusTag = other.SecurityStatusTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x00292183 File Offset: 0x00290383
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x00292190 File Offset: 0x00290390
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
					if (num3 != 21U)
					{
						if (num3 != 101U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SecurityStatusTag = input.ReadFixed32();
						}
					}
					else
					{
						this.Tag = input.ReadFixed32();
					}
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04004BD8 RID: 19416
		private static readonly MessageParser<ProgramTag> _parser = new MessageParser<ProgramTag>(() => new ProgramTag());

		// Token: 0x04004BD9 RID: 19417
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDA RID: 19418
		private int _hasBits0;

		// Token: 0x04004BDB RID: 19419
		public const int ProgramFieldNumber = 1;

		// Token: 0x04004BDC RID: 19420
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004BDD RID: 19421
		private uint program_;

		// Token: 0x04004BDE RID: 19422
		public const int TagFieldNumber = 2;

		// Token: 0x04004BDF RID: 19423
		private static readonly uint TagDefaultValue = 0U;

		// Token: 0x04004BE0 RID: 19424
		private uint tag_;

		// Token: 0x04004BE1 RID: 19425
		public const int SecurityStatusTagFieldNumber = 12;

		// Token: 0x04004BE2 RID: 19426
		private static readonly uint SecurityStatusTagDefaultValue = 0U;

		// Token: 0x04004BE3 RID: 19427
		private uint securityStatusTag_;
	}
}

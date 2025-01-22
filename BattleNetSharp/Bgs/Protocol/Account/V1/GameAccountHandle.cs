using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000732 RID: 1842
	public sealed class GameAccountHandle : IMessage<GameAccountHandle>, IMessage, IEquatable<GameAccountHandle>, IDeepCloneable<GameAccountHandle>, IBufferMessage
	{
		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600A867 RID: 43111 RVA: 0x00290748 File Offset: 0x0028E948
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountHandle> Parser
		{
			get
			{
				return GameAccountHandle._parser;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600A868 RID: 43112 RVA: 0x00290760 File Offset: 0x0028E960
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600A869 RID: 43113 RVA: 0x00290784 File Offset: 0x0028E984
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountHandle.Descriptor;
			}
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x0029079B File Offset: 0x0028E99B
		[DebuggerNonUserCode]
		public GameAccountHandle()
		{
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x002907A8 File Offset: 0x0028E9A8
		[DebuggerNonUserCode]
		public GameAccountHandle(GameAccountHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.program_ = other.program_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x00290800 File Offset: 0x0028EA00
		[DebuggerNonUserCode]
		public GameAccountHandle Clone()
		{
			return new GameAccountHandle(this);
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600A86D RID: 43117 RVA: 0x00290818 File Offset: 0x0028EA18
		// (set) Token: 0x0600A86E RID: 43118 RVA: 0x00290849 File Offset: 0x0028EA49
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = GameAccountHandle.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x00290864 File Offset: 0x0028EA64
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x00290881 File Offset: 0x0028EA81
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x00290894 File Offset: 0x0028EA94
		// (set) Token: 0x0600A872 RID: 43122 RVA: 0x002908C5 File Offset: 0x0028EAC5
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = GameAccountHandle.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.program_ = value;
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600A873 RID: 43123 RVA: 0x002908E0 File Offset: 0x0028EAE0
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A874 RID: 43124 RVA: 0x002908FD File Offset: 0x0028EAFD
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x00290910 File Offset: 0x0028EB10
		// (set) Token: 0x0600A876 RID: 43126 RVA: 0x00290941 File Offset: 0x0028EB41
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = GameAccountHandle.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.region_ = value;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x0029095C File Offset: 0x0028EB5C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A878 RID: 43128 RVA: 0x00290979 File Offset: 0x0028EB79
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x0029098C File Offset: 0x0028EB8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountHandle);
		}

		// Token: 0x0600A87A RID: 43130 RVA: 0x002909AC File Offset: 0x0028EBAC
		[DebuggerNonUserCode]
		public bool Equals(GameAccountHandle other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Region != other.Region;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A87B RID: 43131 RVA: 0x00290A38 File Offset: 0x0028EC38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A87C RID: 43132 RVA: 0x00290AC4 File Offset: 0x0028ECC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A87D RID: 43133 RVA: 0x00290ADC File Offset: 0x0028ECDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A87E RID: 43134 RVA: 0x00290AE8 File Offset: 0x0028ECE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Id);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x00290B78 File Offset: 0x0028ED78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x00290BEC File Offset: 0x0028EDEC
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x00290C67 File Offset: 0x0028EE67
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x00290C74 File Offset: 0x0028EE74
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Region = input.ReadUInt32();
						}
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.Id = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04004BB0 RID: 19376
		private static readonly MessageParser<GameAccountHandle> _parser = new MessageParser<GameAccountHandle>(() => new GameAccountHandle());

		// Token: 0x04004BB1 RID: 19377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB2 RID: 19378
		private int _hasBits0;

		// Token: 0x04004BB3 RID: 19379
		public const int IdFieldNumber = 1;

		// Token: 0x04004BB4 RID: 19380
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04004BB5 RID: 19381
		private uint id_;

		// Token: 0x04004BB6 RID: 19382
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004BB7 RID: 19383
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004BB8 RID: 19384
		private uint program_;

		// Token: 0x04004BB9 RID: 19385
		public const int RegionFieldNumber = 3;

		// Token: 0x04004BBA RID: 19386
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004BBB RID: 19387
		private uint region_;
	}
}

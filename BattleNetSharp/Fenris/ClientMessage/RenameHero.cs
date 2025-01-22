using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000225 RID: 549
	public sealed class RenameHero : IMessage<RenameHero>, IMessage, IEquatable<RenameHero>, IDeepCloneable<RenameHero>, IBufferMessage
	{
		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x000EDA3C File Offset: 0x000EBC3C
		[DebuggerNonUserCode]
		public static MessageParser<RenameHero> Parser
		{
			get
			{
				return RenameHero._parser;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x000EDA54 File Offset: 0x000EBC54
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x000EDA78 File Offset: 0x000EBC78
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenameHero.Descriptor;
			}
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x000EDA8F File Offset: 0x000EBC8F
		[DebuggerNonUserCode]
		public RenameHero()
		{
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x000EDA99 File Offset: 0x000EBC99
		[DebuggerNonUserCode]
		public RenameHero(RenameHero other)
			: this()
		{
			this.heroId_ = other.heroId_;
			this.heroName_ = other.heroName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x000EDACC File Offset: 0x000EBCCC
		[DebuggerNonUserCode]
		public RenameHero Clone()
		{
			return new RenameHero(this);
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x000EDAE4 File Offset: 0x000EBCE4
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x000EDB05 File Offset: 0x000EBD05
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? RenameHero.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x000EDB1C File Offset: 0x000EBD1C
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x000EDB37 File Offset: 0x000EBD37
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000EDB44 File Offset: 0x000EBD44
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x000EDB65 File Offset: 0x000EBD65
		[DebuggerNonUserCode]
		public string HeroName
		{
			get
			{
				return this.heroName_ ?? RenameHero.HeroNameDefaultValue;
			}
			set
			{
				this.heroName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x000EDB7C File Offset: 0x000EBD7C
		[DebuggerNonUserCode]
		public bool HasHeroName
		{
			get
			{
				return this.heroName_ != null;
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x000EDB97 File Offset: 0x000EBD97
		[DebuggerNonUserCode]
		public void ClearHeroName()
		{
			this.heroName_ = null;
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x000EDBA4 File Offset: 0x000EBDA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenameHero);
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x000EDBC4 File Offset: 0x000EBDC4
		[DebuggerNonUserCode]
		public bool Equals(RenameHero other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.HeroName != other.HeroName;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x000EDC38 File Offset: 0x000EBE38
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num ^= this.HeroName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x000EDC9C File Offset: 0x000EBE9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000EDCB4 File Offset: 0x000EBEB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x000EDCC0 File Offset: 0x000EBEC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.HeroName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x000EDD30 File Offset: 0x000EBF30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasHeroName = this.HasHeroName;
			if (hasHeroName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x000EDD9C File Offset: 0x000EBF9C
		[DebuggerNonUserCode]
		public void MergeFrom(RenameHero other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasHeroName = other.HasHeroName;
				if (hasHeroName)
				{
					this.HeroName = other.HeroName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x000EDDFE File Offset: 0x000EBFFE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x000EDE0C File Offset: 0x000EC00C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HeroName = input.ReadString();
					}
				}
				else
				{
					this.HeroId = input.ReadString();
				}
			}
		}

		// Token: 0x04001BB2 RID: 7090
		private static readonly MessageParser<RenameHero> _parser = new MessageParser<RenameHero>(() => new RenameHero());

		// Token: 0x04001BB3 RID: 7091
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BB4 RID: 7092
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001BB5 RID: 7093
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001BB6 RID: 7094
		private string heroId_;

		// Token: 0x04001BB7 RID: 7095
		public const int HeroNameFieldNumber = 2;

		// Token: 0x04001BB8 RID: 7096
		private static readonly string HeroNameDefaultValue = "";

		// Token: 0x04001BB9 RID: 7097
		private string heroName_;
	}
}

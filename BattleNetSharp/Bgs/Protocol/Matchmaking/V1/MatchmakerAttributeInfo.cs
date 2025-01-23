using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E3 RID: 995
	public sealed class MatchmakerAttributeInfo : IMessage<MatchmakerAttributeInfo>, IMessage, IEquatable<MatchmakerAttributeInfo>, IDeepCloneable<MatchmakerAttributeInfo>, IBufferMessage
	{
		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x0017F818 File Offset: 0x0017DA18
		[DebuggerNonUserCode]
		public static MessageParser<MatchmakerAttributeInfo> Parser
		{
			get
			{
				return MatchmakerAttributeInfo._parser;
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06006313 RID: 25363 RVA: 0x0017F830 File Offset: 0x0017DA30
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x0017F854 File Offset: 0x0017DA54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchmakerAttributeInfo.Descriptor;
			}
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x0017F86B File Offset: 0x0017DA6B
		[DebuggerNonUserCode]
		public MatchmakerAttributeInfo()
		{
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0017F880 File Offset: 0x0017DA80
		[DebuggerNonUserCode]
		public MatchmakerAttributeInfo(MatchmakerAttributeInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.program_ = other.program_;
			this.attribute_ = other.attribute_.Clone();
			this.isPrivate_ = other.isPrivate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x0017F8E8 File Offset: 0x0017DAE8
		[DebuggerNonUserCode]
		public MatchmakerAttributeInfo Clone()
		{
			return new MatchmakerAttributeInfo(this);
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006318 RID: 25368 RVA: 0x0017F900 File Offset: 0x0017DB00
		// (set) Token: 0x06006319 RID: 25369 RVA: 0x0017F921 File Offset: 0x0017DB21
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? MatchmakerAttributeInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x0017F938 File Offset: 0x0017DB38
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x0017F953 File Offset: 0x0017DB53
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600631C RID: 25372 RVA: 0x0017F960 File Offset: 0x0017DB60
		// (set) Token: 0x0600631D RID: 25373 RVA: 0x0017F991 File Offset: 0x0017DB91
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
					programDefaultValue = MatchmakerAttributeInfo.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600631E RID: 25374 RVA: 0x0017F9AC File Offset: 0x0017DBAC
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x0017F9C9 File Offset: 0x0017DBC9
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006320 RID: 25376 RVA: 0x0017F9DC File Offset: 0x0017DBDC
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06006321 RID: 25377 RVA: 0x0017F9F4 File Offset: 0x0017DBF4
		// (set) Token: 0x06006322 RID: 25378 RVA: 0x0017FA25 File Offset: 0x0017DC25
		[DebuggerNonUserCode]
		public bool IsPrivate
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isPrivateDefaultValue;
				if (flag)
				{
					isPrivateDefaultValue = this.isPrivate_;
				}
				else
				{
					isPrivateDefaultValue = MatchmakerAttributeInfo.IsPrivateDefaultValue;
				}
				return isPrivateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isPrivate_ = value;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06006323 RID: 25379 RVA: 0x0017FA40 File Offset: 0x0017DC40
		[DebuggerNonUserCode]
		public bool HasIsPrivate
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x0017FA5D File Offset: 0x0017DC5D
		[DebuggerNonUserCode]
		public void ClearIsPrivate()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x0017FA70 File Offset: 0x0017DC70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchmakerAttributeInfo);
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x0017FA90 File Offset: 0x0017DC90
		[DebuggerNonUserCode]
		public bool Equals(MatchmakerAttributeInfo other)
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
					bool flag4 = this.Name != other.Name;
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
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.IsPrivate != other.IsPrivate;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0017FB40 File Offset: 0x0017DD40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
			{
				num ^= this.IsPrivate.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x0017FBD8 File Offset: 0x0017DDD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x0017FBF0 File Offset: 0x0017DDF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x0017FBFC File Offset: 0x0017DDFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			this.attribute_.WriteTo(ref output, MatchmakerAttributeInfo._repeated_attribute_codec);
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsPrivate);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x0017FCA0 File Offset: 0x0017DEA0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			num += this.attribute_.CalculateSize(MatchmakerAttributeInfo._repeated_attribute_codec);
			bool hasIsPrivate = this.HasIsPrivate;
			if (hasIsPrivate)
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

		// Token: 0x0600632C RID: 25388 RVA: 0x0017FD28 File Offset: 0x0017DF28
		[DebuggerNonUserCode]
		public void MergeFrom(MatchmakerAttributeInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this.attribute_.Add(other.attribute_);
				bool hasIsPrivate = other.HasIsPrivate;
				if (hasIsPrivate)
				{
					this.IsPrivate = other.IsPrivate;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x0017FDB5 File Offset: 0x0017DFB5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0017FDC0 File Offset: 0x0017DFC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_002C;
						}
						this.Program = input.ReadFixed32();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_002C;
					}
					this.IsPrivate = input.ReadBool();
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, MatchmakerAttributeInfo._repeated_attribute_codec);
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002D3A RID: 11578
		private static readonly MessageParser<MatchmakerAttributeInfo> _parser = new MessageParser<MatchmakerAttributeInfo>(() => new MatchmakerAttributeInfo());

		// Token: 0x04002D3B RID: 11579
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D3C RID: 11580
		private int _hasBits0;

		// Token: 0x04002D3D RID: 11581
		public const int NameFieldNumber = 1;

		// Token: 0x04002D3E RID: 11582
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002D3F RID: 11583
		private string name_;

		// Token: 0x04002D40 RID: 11584
		public const int ProgramFieldNumber = 2;

		// Token: 0x04002D41 RID: 11585
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002D42 RID: 11586
		private uint program_;

		// Token: 0x04002D43 RID: 11587
		public const int AttributeFieldNumber = 3;

		// Token: 0x04002D44 RID: 11588
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(26U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002D45 RID: 11589
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04002D46 RID: 11590
		public const int IsPrivateFieldNumber = 4;

		// Token: 0x04002D47 RID: 11591
		private static readonly bool IsPrivateDefaultValue = false;

		// Token: 0x04002D48 RID: 11592
		private bool isPrivate_;
	}
}

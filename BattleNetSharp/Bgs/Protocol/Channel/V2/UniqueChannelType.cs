using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000686 RID: 1670
	public sealed class UniqueChannelType : IMessage<UniqueChannelType>, IMessage, IEquatable<UniqueChannelType>, IDeepCloneable<UniqueChannelType>, IBufferMessage
	{
		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x0025A40C File Offset: 0x0025860C
		[DebuggerNonUserCode]
		public static MessageParser<UniqueChannelType> Parser
		{
			get
			{
				return UniqueChannelType._parser;
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x0025A424 File Offset: 0x00258624
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x0025A448 File Offset: 0x00258648
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UniqueChannelType.Descriptor;
			}
		}

		// Token: 0x06009AE1 RID: 39649 RVA: 0x0025A45F File Offset: 0x0025865F
		[DebuggerNonUserCode]
		public UniqueChannelType()
		{
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x0025A469 File Offset: 0x00258669
		[DebuggerNonUserCode]
		public UniqueChannelType(UniqueChannelType other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.channelType_ = other.channelType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x0025A4A8 File Offset: 0x002586A8
		[DebuggerNonUserCode]
		public UniqueChannelType Clone()
		{
			return new UniqueChannelType(this);
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x0025A4C0 File Offset: 0x002586C0
		// (set) Token: 0x06009AE5 RID: 39653 RVA: 0x0025A4F1 File Offset: 0x002586F1
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
					programDefaultValue = UniqueChannelType.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x0025A50C File Offset: 0x0025870C
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x0025A529 File Offset: 0x00258729
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x06009AE8 RID: 39656 RVA: 0x0025A53C File Offset: 0x0025873C
		// (set) Token: 0x06009AE9 RID: 39657 RVA: 0x0025A55D File Offset: 0x0025875D
		[DebuggerNonUserCode]
		public string ChannelType
		{
			get
			{
				return this.channelType_ ?? UniqueChannelType.ChannelTypeDefaultValue;
			}
			set
			{
				this.channelType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x06009AEA RID: 39658 RVA: 0x0025A574 File Offset: 0x00258774
		[DebuggerNonUserCode]
		public bool HasChannelType
		{
			get
			{
				return this.channelType_ != null;
			}
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x0025A58F File Offset: 0x0025878F
		[DebuggerNonUserCode]
		public void ClearChannelType()
		{
			this.channelType_ = null;
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x0025A59C File Offset: 0x0025879C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UniqueChannelType);
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x0025A5BC File Offset: 0x002587BC
		[DebuggerNonUserCode]
		public bool Equals(UniqueChannelType other)
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
						bool flag5 = this.ChannelType != other.ChannelType;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x0025A630 File Offset: 0x00258830
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x0025A69C File Offset: 0x0025889C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x0025A6B4 File Offset: 0x002588B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AF1 RID: 39665 RVA: 0x0025A6C0 File Offset: 0x002588C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ChannelType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x0025A730 File Offset: 0x00258930
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x0025A790 File Offset: 0x00258990
		[DebuggerNonUserCode]
		public void MergeFrom(UniqueChannelType other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasChannelType = other.HasChannelType;
				if (hasChannelType)
				{
					this.ChannelType = other.ChannelType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x0025A7F2 File Offset: 0x002589F2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x0025A800 File Offset: 0x00258A00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 21U)
				{
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChannelType = input.ReadString();
					}
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x040045E2 RID: 17890
		private static readonly MessageParser<UniqueChannelType> _parser = new MessageParser<UniqueChannelType>(() => new UniqueChannelType());

		// Token: 0x040045E3 RID: 17891
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045E4 RID: 17892
		private int _hasBits0;

		// Token: 0x040045E5 RID: 17893
		public const int ProgramFieldNumber = 2;

		// Token: 0x040045E6 RID: 17894
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x040045E7 RID: 17895
		private uint program_;

		// Token: 0x040045E8 RID: 17896
		public const int ChannelTypeFieldNumber = 3;

		// Token: 0x040045E9 RID: 17897
		private static readonly string ChannelTypeDefaultValue = "";

		// Token: 0x040045EA RID: 17898
		private string channelType_;
	}
}

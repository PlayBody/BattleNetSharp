using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A9 RID: 1961
	public sealed class ReadCharacterResponse : IMessage<ReadCharacterResponse>, IMessage, IEquatable<ReadCharacterResponse>, IDeepCloneable<ReadCharacterResponse>, IBufferMessage
	{
		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B3FB RID: 46075 RVA: 0x002BC71C File Offset: 0x002BA91C
		[DebuggerNonUserCode]
		public static MessageParser<ReadCharacterResponse> Parser
		{
			get
			{
				return ReadCharacterResponse._parser;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x002BC734 File Offset: 0x002BA934
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600B3FD RID: 46077 RVA: 0x002BC758 File Offset: 0x002BA958
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadCharacterResponse.Descriptor;
			}
		}

		// Token: 0x0600B3FE RID: 46078 RVA: 0x002BC76F File Offset: 0x002BA96F
		[DebuggerNonUserCode]
		public ReadCharacterResponse()
		{
		}

		// Token: 0x0600B3FF RID: 46079 RVA: 0x002BC784 File Offset: 0x002BA984
		[DebuggerNonUserCode]
		public ReadCharacterResponse(ReadCharacterResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.maxNum_ = other.maxNum_;
			this.characters_ = other.characters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x002BC7D4 File Offset: 0x002BA9D4
		[DebuggerNonUserCode]
		public ReadCharacterResponse Clone()
		{
			return new ReadCharacterResponse(this);
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B401 RID: 46081 RVA: 0x002BC7EC File Offset: 0x002BA9EC
		// (set) Token: 0x0600B402 RID: 46082 RVA: 0x002BC81D File Offset: 0x002BAA1D
		[DebuggerNonUserCode]
		public uint MaxNum
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint maxNumDefaultValue;
				if (flag)
				{
					maxNumDefaultValue = this.maxNum_;
				}
				else
				{
					maxNumDefaultValue = ReadCharacterResponse.MaxNumDefaultValue;
				}
				return maxNumDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxNum_ = value;
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B403 RID: 46083 RVA: 0x002BC838 File Offset: 0x002BAA38
		[DebuggerNonUserCode]
		public bool HasMaxNum
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x002BC855 File Offset: 0x002BAA55
		[DebuggerNonUserCode]
		public void ClearMaxNum()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x002BC868 File Offset: 0x002BAA68
		[DebuggerNonUserCode]
		public RepeatedField<CharData> Characters
		{
			get
			{
				return this.characters_;
			}
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x002BC880 File Offset: 0x002BAA80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadCharacterResponse);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x002BC8A0 File Offset: 0x002BAAA0
		[DebuggerNonUserCode]
		public bool Equals(ReadCharacterResponse other)
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
					bool flag4 = this.MaxNum != other.MaxNum;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.characters_.Equals(other.characters_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x002BC914 File Offset: 0x002BAB14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMaxNum = this.HasMaxNum;
			if (hasMaxNum)
			{
				num ^= this.MaxNum.GetHashCode();
			}
			num ^= this.characters_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x002BC974 File Offset: 0x002BAB74
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x002BC98C File Offset: 0x002BAB8C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x002BC998 File Offset: 0x002BAB98
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMaxNum = this.HasMaxNum;
			if (hasMaxNum)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MaxNum);
			}
			this.characters_.WriteTo(ref output, ReadCharacterResponse._repeated_characters_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x002BC9F8 File Offset: 0x002BABF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMaxNum = this.HasMaxNum;
			if (hasMaxNum)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxNum);
			}
			num += this.characters_.CalculateSize(ReadCharacterResponse._repeated_characters_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x002BCA5C File Offset: 0x002BAC5C
		[DebuggerNonUserCode]
		public void MergeFrom(ReadCharacterResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMaxNum = other.HasMaxNum;
				if (hasMaxNum)
				{
					this.MaxNum = other.MaxNum;
				}
				this.characters_.Add(other.characters_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x002BCAB7 File Offset: 0x002BACB7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x002BCAC4 File Offset: 0x002BACC4
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.characters_.AddEntriesFrom(ref input, ReadCharacterResponse._repeated_characters_codec);
					}
				}
				else
				{
					this.MaxNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400515D RID: 20829
		private static readonly MessageParser<ReadCharacterResponse> _parser = new MessageParser<ReadCharacterResponse>(() => new ReadCharacterResponse());

		// Token: 0x0400515E RID: 20830
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400515F RID: 20831
		private int _hasBits0;

		// Token: 0x04005160 RID: 20832
		public const int MaxNumFieldNumber = 1;

		// Token: 0x04005161 RID: 20833
		private static readonly uint MaxNumDefaultValue = 0U;

		// Token: 0x04005162 RID: 20834
		private uint maxNum_;

		// Token: 0x04005163 RID: 20835
		public const int CharactersFieldNumber = 2;

		// Token: 0x04005164 RID: 20836
		private static readonly FieldCodec<CharData> _repeated_characters_codec = FieldCodec.ForMessage<CharData>(18U, CharData.Parser);

		// Token: 0x04005165 RID: 20837
		private readonly RepeatedField<CharData> characters_ = new RepeatedField<CharData>();
	}
}

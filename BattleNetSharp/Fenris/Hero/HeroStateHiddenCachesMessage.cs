using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000198 RID: 408
	public sealed class HeroStateHiddenCachesMessage : IMessage<HeroStateHiddenCachesMessage>, IMessage, IEquatable<HeroStateHiddenCachesMessage>, IDeepCloneable<HeroStateHiddenCachesMessage>, IBufferMessage
	{
		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000AA2B0 File Offset: 0x000A84B0
		[DebuggerNonUserCode]
		public static MessageParser<HeroStateHiddenCachesMessage> Parser
		{
			get
			{
				return HeroStateHiddenCachesMessage._parser;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000AA2C8 File Offset: 0x000A84C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000AA2EC File Offset: 0x000A84EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroStateHiddenCachesMessage.Descriptor;
			}
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000AA303 File Offset: 0x000A8503
		[DebuggerNonUserCode]
		public HeroStateHiddenCachesMessage()
		{
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000AA318 File Offset: 0x000A8518
		[DebuggerNonUserCode]
		public HeroStateHiddenCachesMessage(HeroStateHiddenCachesMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.foundHiddenCacheGbids_ = other.foundHiddenCacheGbids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000AA368 File Offset: 0x000A8568
		[DebuggerNonUserCode]
		public HeroStateHiddenCachesMessage Clone()
		{
			return new HeroStateHiddenCachesMessage(this);
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x000AA380 File Offset: 0x000A8580
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000AA3B1 File Offset: 0x000A85B1
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = HeroStateHiddenCachesMessage.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000AA3CC File Offset: 0x000A85CC
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000AA3E9 File Offset: 0x000A85E9
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000AA3FC File Offset: 0x000A85FC
		[DebuggerNonUserCode]
		public RepeatedField<int> FoundHiddenCacheGbids
		{
			get
			{
				return this.foundHiddenCacheGbids_;
			}
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000AA414 File Offset: 0x000A8614
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroStateHiddenCachesMessage);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000AA434 File Offset: 0x000A8634
		[DebuggerNonUserCode]
		public bool Equals(HeroStateHiddenCachesMessage other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.foundHiddenCacheGbids_.Equals(other.foundHiddenCacheGbids_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000AA4A8 File Offset: 0x000A86A8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			num ^= this.foundHiddenCacheGbids_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000AA508 File Offset: 0x000A8708
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000AA520 File Offset: 0x000A8720
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000AA52C File Offset: 0x000A872C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			this.foundHiddenCacheGbids_.WriteTo(ref output, HeroStateHiddenCachesMessage._repeated_foundHiddenCacheGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000AA58C File Offset: 0x000A878C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			num += this.foundHiddenCacheGbids_.CalculateSize(HeroStateHiddenCachesMessage._repeated_foundHiddenCacheGbids_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000AA5F0 File Offset: 0x000A87F0
		[DebuggerNonUserCode]
		public void MergeFrom(HeroStateHiddenCachesMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this.foundHiddenCacheGbids_.Add(other.foundHiddenCacheGbids_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000AA64B File Offset: 0x000A884B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000AA658 File Offset: 0x000A8858
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
					if (num3 != 18U && num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.foundHiddenCacheGbids_.AddEntriesFrom(ref input, HeroStateHiddenCachesMessage._repeated_foundHiddenCacheGbids_codec);
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001398 RID: 5016
		private static readonly MessageParser<HeroStateHiddenCachesMessage> _parser = new MessageParser<HeroStateHiddenCachesMessage>(() => new HeroStateHiddenCachesMessage());

		// Token: 0x04001399 RID: 5017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400139A RID: 5018
		private int _hasBits0;

		// Token: 0x0400139B RID: 5019
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x0400139C RID: 5020
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x0400139D RID: 5021
		private uint gameAccountId_;

		// Token: 0x0400139E RID: 5022
		public const int FoundHiddenCacheGbidsFieldNumber = 2;

		// Token: 0x0400139F RID: 5023
		private static readonly FieldCodec<int> _repeated_foundHiddenCacheGbids_codec = FieldCodec.ForSFixed32(21U);

		// Token: 0x040013A0 RID: 5024
		private readonly RepeatedField<int> foundHiddenCacheGbids_ = new RepeatedField<int>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000136 RID: 310
	public sealed class HeroProfileList : IMessage<HeroProfileList>, IMessage, IEquatable<HeroProfileList>, IDeepCloneable<HeroProfileList>, IBufferMessage
	{
		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00079494 File Offset: 0x00077694
		[DebuggerNonUserCode]
		public static MessageParser<HeroProfileList> Parser
		{
			get
			{
				return HeroProfileList._parser;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000794AC File Offset: 0x000776AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000794D0 File Offset: 0x000776D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroProfileList.Descriptor;
			}
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x000794E7 File Offset: 0x000776E7
		[DebuggerNonUserCode]
		public HeroProfileList()
		{
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x000794FC File Offset: 0x000776FC
		[DebuggerNonUserCode]
		public HeroProfileList(HeroProfileList other)
			: this()
		{
			this.heros_ = other.heros_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00079528 File Offset: 0x00077728
		[DebuggerNonUserCode]
		public HeroProfileList Clone()
		{
			return new HeroProfileList(this);
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00079540 File Offset: 0x00077740
		[DebuggerNonUserCode]
		public RepeatedField<HeroProfile> Heros
		{
			get
			{
				return this.heros_;
			}
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00079558 File Offset: 0x00077758
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroProfileList);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00079578 File Offset: 0x00077778
		[DebuggerNonUserCode]
		public bool Equals(HeroProfileList other)
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
					bool flag4 = !this.heros_.Equals(other.heros_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000795D4 File Offset: 0x000777D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.heros_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00079614 File Offset: 0x00077814
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0007962C File Offset: 0x0007782C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00079638 File Offset: 0x00077838
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.heros_.WriteTo(ref output, HeroProfileList._repeated_heros_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00079674 File Offset: 0x00077874
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.heros_.CalculateSize(HeroProfileList._repeated_heros_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x000796BC File Offset: 0x000778BC
		[DebuggerNonUserCode]
		public void MergeFrom(HeroProfileList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.heros_.Add(other.heros_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000796FE File Offset: 0x000778FE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0007970C File Offset: 0x0007790C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.heros_.AddEntriesFrom(ref input, HeroProfileList._repeated_heros_codec);
				}
			}
		}

		// Token: 0x04000DA8 RID: 3496
		private static readonly MessageParser<HeroProfileList> _parser = new MessageParser<HeroProfileList>(() => new HeroProfileList());

		// Token: 0x04000DA9 RID: 3497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000DAA RID: 3498
		public const int HerosFieldNumber = 1;

		// Token: 0x04000DAB RID: 3499
		private static readonly FieldCodec<HeroProfile> _repeated_heros_codec = FieldCodec.ForMessage<HeroProfile>(10U, HeroProfile.Parser);

		// Token: 0x04000DAC RID: 3500
		private readonly RepeatedField<HeroProfile> heros_ = new RepeatedField<HeroProfile>();
	}
}

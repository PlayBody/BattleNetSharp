using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006EC RID: 1772
	public sealed class MemberAccountInfo : IMessage<MemberAccountInfo>, IMessage, IEquatable<MemberAccountInfo>, IDeepCloneable<MemberAccountInfo>, IBufferMessage
	{
		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600A378 RID: 41848 RVA: 0x0027D9D8 File Offset: 0x0027BBD8
		[DebuggerNonUserCode]
		public static MessageParser<MemberAccountInfo> Parser
		{
			get
			{
				return MemberAccountInfo._parser;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600A379 RID: 41849 RVA: 0x0027D9F0 File Offset: 0x0027BBF0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600A37A RID: 41850 RVA: 0x0027DA14 File Offset: 0x0027BC14
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberAccountInfo.Descriptor;
			}
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x0027DA2B File Offset: 0x0027BC2B
		[DebuggerNonUserCode]
		public MemberAccountInfo()
		{
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x0027DA35 File Offset: 0x0027BC35
		[DebuggerNonUserCode]
		public MemberAccountInfo(MemberAccountInfo other)
			: this()
		{
			this.battleTag_ = other.battleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x0027DA5C File Offset: 0x0027BC5C
		[DebuggerNonUserCode]
		public MemberAccountInfo Clone()
		{
			return new MemberAccountInfo(this);
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600A37E RID: 41854 RVA: 0x0027DA74 File Offset: 0x0027BC74
		// (set) Token: 0x0600A37F RID: 41855 RVA: 0x0027DA95 File Offset: 0x0027BC95
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? MemberAccountInfo.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x0027DAAC File Offset: 0x0027BCAC
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x0027DAC7 File Offset: 0x0027BCC7
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x0027DAD4 File Offset: 0x0027BCD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberAccountInfo);
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x0027DAF4 File Offset: 0x0027BCF4
		[DebuggerNonUserCode]
		public bool Equals(MemberAccountInfo other)
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
					bool flag4 = this.BattleTag != other.BattleTag;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x0027DB4C File Offset: 0x0027BD4C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x0027DB98 File Offset: 0x0027BD98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0027DBB0 File Offset: 0x0027BDB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x0027DBBC File Offset: 0x0027BDBC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.BattleTag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x0027DC08 File Offset: 0x0027BE08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x0027DC58 File Offset: 0x0027BE58
		[DebuggerNonUserCode]
		public void MergeFrom(MemberAccountInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x0027DCA1 File Offset: 0x0027BEA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x0027DCAC File Offset: 0x0027BEAC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BattleTag = input.ReadString();
				}
			}
		}

		// Token: 0x040049BD RID: 18877
		private static readonly MessageParser<MemberAccountInfo> _parser = new MessageParser<MemberAccountInfo>(() => new MemberAccountInfo());

		// Token: 0x040049BE RID: 18878
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049BF RID: 18879
		public const int BattleTagFieldNumber = 3;

		// Token: 0x040049C0 RID: 18880
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x040049C1 RID: 18881
		private string battleTag_;
	}
}

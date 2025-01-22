using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000697 RID: 1687
	public sealed class MemberDescription : IMessage<MemberDescription>, IMessage, IEquatable<MemberDescription>, IDeepCloneable<MemberDescription>, IBufferMessage
	{
		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x06009C95 RID: 40085 RVA: 0x00260C1C File Offset: 0x0025EE1C
		[DebuggerNonUserCode]
		public static MessageParser<MemberDescription> Parser
		{
			get
			{
				return MemberDescription._parser;
			}
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x06009C96 RID: 40086 RVA: 0x00260C34 File Offset: 0x0025EE34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x06009C97 RID: 40087 RVA: 0x00260C58 File Offset: 0x0025EE58
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberDescription.Descriptor;
			}
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x00260C6F File Offset: 0x0025EE6F
		[DebuggerNonUserCode]
		public MemberDescription()
		{
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x00260C7C File Offset: 0x0025EE7C
		[DebuggerNonUserCode]
		public MemberDescription(MemberDescription other)
			: this()
		{
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x00260CCC File Offset: 0x0025EECC
		[DebuggerNonUserCode]
		public MemberDescription Clone()
		{
			return new MemberDescription(this);
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x06009C9B RID: 40091 RVA: 0x00260CE4 File Offset: 0x0025EEE4
		// (set) Token: 0x06009C9C RID: 40092 RVA: 0x00260CFC File Offset: 0x0025EEFC
		[DebuggerNonUserCode]
		public GameAccountHandle Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x06009C9D RID: 40093 RVA: 0x00260D08 File Offset: 0x0025EF08
		// (set) Token: 0x06009C9E RID: 40094 RVA: 0x00260D29 File Offset: 0x0025EF29
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? MemberDescription.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x06009C9F RID: 40095 RVA: 0x00260D40 File Offset: 0x0025EF40
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x00260D5B File Offset: 0x0025EF5B
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x00260D68 File Offset: 0x0025EF68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberDescription);
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x00260D88 File Offset: 0x0025EF88
		[DebuggerNonUserCode]
		public bool Equals(MemberDescription other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BattleTag != other.BattleTag;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x00260DFC File Offset: 0x0025EFFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x00260E64 File Offset: 0x0025F064
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x00260E7C File Offset: 0x0025F07C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x00260E88 File Offset: 0x0025F088
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x00260EFC File Offset: 0x0025F0FC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x00260F6C File Offset: 0x0025F16C
		[DebuggerNonUserCode]
		public void MergeFrom(MemberDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new GameAccountHandle();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x00260FF1 File Offset: 0x0025F1F1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x00260FFC File Offset: 0x0025F1FC
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
						this.BattleTag = input.ReadString();
					}
				}
				else
				{
					bool flag = this.id_ == null;
					if (flag)
					{
						this.Id = new GameAccountHandle();
					}
					input.ReadMessage(this.Id);
				}
			}
		}

		// Token: 0x040046AE RID: 18094
		private static readonly MessageParser<MemberDescription> _parser = new MessageParser<MemberDescription>(() => new MemberDescription());

		// Token: 0x040046AF RID: 18095
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B0 RID: 18096
		public const int IdFieldNumber = 1;

		// Token: 0x040046B1 RID: 18097
		private GameAccountHandle id_;

		// Token: 0x040046B2 RID: 18098
		public const int BattleTagFieldNumber = 2;

		// Token: 0x040046B3 RID: 18099
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x040046B4 RID: 18100
		private string battleTag_;
	}
}

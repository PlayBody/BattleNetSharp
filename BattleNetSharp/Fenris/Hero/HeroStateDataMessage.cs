using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000195 RID: 405
	public sealed class HeroStateDataMessage : IMessage<HeroStateDataMessage>, IMessage, IEquatable<HeroStateDataMessage>, IDeepCloneable<HeroStateDataMessage>, IBufferMessage
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000A8184 File Offset: 0x000A6384
		[DebuggerNonUserCode]
		public static MessageParser<HeroStateDataMessage> Parser
		{
			get
			{
				return HeroStateDataMessage._parser;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000A819C File Offset: 0x000A639C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x000A81C0 File Offset: 0x000A63C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeroStateDataMessage.Descriptor;
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000A81D7 File Offset: 0x000A63D7
		[DebuggerNonUserCode]
		public HeroStateDataMessage()
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000A81E4 File Offset: 0x000A63E4
		[DebuggerNonUserCode]
		public HeroStateDataMessage(HeroStateDataMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.heroStateData_ = ((other.heroStateData_ != null) ? other.heroStateData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000A8240 File Offset: 0x000A6440
		[DebuggerNonUserCode]
		public HeroStateDataMessage Clone()
		{
			return new HeroStateDataMessage(this);
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000A8258 File Offset: 0x000A6458
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x000A8289 File Offset: 0x000A6489
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
					gameAccountIdDefaultValue = HeroStateDataMessage.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000A82A4 File Offset: 0x000A64A4
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000A82C1 File Offset: 0x000A64C1
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000A82D4 File Offset: 0x000A64D4
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x000A82EC File Offset: 0x000A64EC
		[DebuggerNonUserCode]
		public HeroStateDataDef HeroStateData
		{
			get
			{
				return this.heroStateData_;
			}
			set
			{
				this.heroStateData_ = value;
			}
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000A82F8 File Offset: 0x000A64F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeroStateDataMessage);
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000A8318 File Offset: 0x000A6518
		[DebuggerNonUserCode]
		public bool Equals(HeroStateDataMessage other)
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
						bool flag5 = !object.Equals(this.HeroStateData, other.HeroStateData);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000A838C File Offset: 0x000A658C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this.heroStateData_ != null;
			if (flag)
			{
				num ^= this.HeroStateData.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000A83F8 File Offset: 0x000A65F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000A8410 File Offset: 0x000A6610
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000A841C File Offset: 0x000A661C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this.heroStateData_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HeroStateData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000A848C File Offset: 0x000A668C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this.heroStateData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroStateData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000A84FC File Offset: 0x000A66FC
		[DebuggerNonUserCode]
		public void MergeFrom(HeroStateDataMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool flag2 = other.heroStateData_ != null;
				if (flag2)
				{
					bool flag3 = this.heroStateData_ == null;
					if (flag3)
					{
						this.HeroStateData = new HeroStateDataDef();
					}
					this.HeroStateData.MergeFrom(other.HeroStateData);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000A8581 File Offset: 0x000A6781
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000A858C File Offset: 0x000A678C
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
						bool flag = this.heroStateData_ == null;
						if (flag)
						{
							this.HeroStateData = new HeroStateDataDef();
						}
						input.ReadMessage(this.HeroStateData);
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001350 RID: 4944
		private static readonly MessageParser<HeroStateDataMessage> _parser = new MessageParser<HeroStateDataMessage>(() => new HeroStateDataMessage());

		// Token: 0x04001351 RID: 4945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001352 RID: 4946
		private int _hasBits0;

		// Token: 0x04001353 RID: 4947
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001354 RID: 4948
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001355 RID: 4949
		private uint gameAccountId_;

		// Token: 0x04001356 RID: 4950
		public const int HeroStateDataFieldNumber = 2;

		// Token: 0x04001357 RID: 4951
		private HeroStateDataDef heroStateData_;
	}
}

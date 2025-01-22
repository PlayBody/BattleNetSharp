using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000234 RID: 564
	public sealed class GetAccountProfileRequest : IMessage<GetAccountProfileRequest>, IMessage, IEquatable<GetAccountProfileRequest>, IDeepCloneable<GetAccountProfileRequest>, IBufferMessage
	{
		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x000F1B40 File Offset: 0x000EFD40
		[DebuggerNonUserCode]
		public static MessageParser<GetAccountProfileRequest> Parser
		{
			get
			{
				return GetAccountProfileRequest._parser;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x000F1B58 File Offset: 0x000EFD58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[36];
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x000F1B7C File Offset: 0x000EFD7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountProfileRequest.Descriptor;
			}
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x000F1B93 File Offset: 0x000EFD93
		[DebuggerNonUserCode]
		public GetAccountProfileRequest()
		{
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x000F1B9D File Offset: 0x000EFD9D
		[DebuggerNonUserCode]
		public GetAccountProfileRequest(GetAccountProfileRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x000F1BDC File Offset: 0x000EFDDC
		[DebuggerNonUserCode]
		public GetAccountProfileRequest Clone()
		{
			return new GetAccountProfileRequest(this);
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x000F1BF4 File Offset: 0x000EFDF4
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x000F1C25 File Offset: 0x000EFE25
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
					gameAccountIdDefaultValue = GetAccountProfileRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x000F1C40 File Offset: 0x000EFE40
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x000F1C5D File Offset: 0x000EFE5D
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x000F1C70 File Offset: 0x000EFE70
		// (set) Token: 0x06003D20 RID: 15648 RVA: 0x000F1CA1 File Offset: 0x000EFEA1
		[DebuggerNonUserCode]
		public uint SeasonId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint seasonIdDefaultValue;
				if (flag)
				{
					seasonIdDefaultValue = this.seasonId_;
				}
				else
				{
					seasonIdDefaultValue = GetAccountProfileRequest.SeasonIdDefaultValue;
				}
				return seasonIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.seasonId_ = value;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x000F1CBC File Offset: 0x000EFEBC
		[DebuggerNonUserCode]
		public bool HasSeasonId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x000F1CD9 File Offset: 0x000EFED9
		[DebuggerNonUserCode]
		public void ClearSeasonId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x000F1CEC File Offset: 0x000EFEEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountProfileRequest);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x000F1D0C File Offset: 0x000EFF0C
		[DebuggerNonUserCode]
		public bool Equals(GetAccountProfileRequest other)
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
						bool flag5 = this.SeasonId != other.SeasonId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x000F1D80 File Offset: 0x000EFF80
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x000F1DEC File Offset: 0x000EFFEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x000F1E04 File Offset: 0x000F0004
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x000F1E10 File Offset: 0x000F0010
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SeasonId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x000F1E80 File Offset: 0x000F0080
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SeasonId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x000F1EEC File Offset: 0x000F00EC
		[DebuggerNonUserCode]
		public void MergeFrom(GetAccountProfileRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasSeasonId = other.HasSeasonId;
				if (hasSeasonId)
				{
					this.SeasonId = other.SeasonId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x000F1F4E File Offset: 0x000F014E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x000F1F5C File Offset: 0x000F015C
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SeasonId = input.ReadUInt32();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C23 RID: 7203
		private static readonly MessageParser<GetAccountProfileRequest> _parser = new MessageParser<GetAccountProfileRequest>(() => new GetAccountProfileRequest());

		// Token: 0x04001C24 RID: 7204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C25 RID: 7205
		private int _hasBits0;

		// Token: 0x04001C26 RID: 7206
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001C27 RID: 7207
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001C28 RID: 7208
		private uint gameAccountId_;

		// Token: 0x04001C29 RID: 7209
		public const int SeasonIdFieldNumber = 2;

		// Token: 0x04001C2A RID: 7210
		private static readonly uint SeasonIdDefaultValue = 0U;

		// Token: 0x04001C2B RID: 7211
		private uint seasonId_;
	}
}

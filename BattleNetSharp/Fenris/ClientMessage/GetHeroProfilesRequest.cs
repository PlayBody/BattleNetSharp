using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000236 RID: 566
	public sealed class GetHeroProfilesRequest : IMessage<GetHeroProfilesRequest>, IMessage, IEquatable<GetHeroProfilesRequest>, IDeepCloneable<GetHeroProfilesRequest>, IBufferMessage
	{
		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x000F2354 File Offset: 0x000F0554
		[DebuggerNonUserCode]
		public static MessageParser<GetHeroProfilesRequest> Parser
		{
			get
			{
				return GetHeroProfilesRequest._parser;
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06003D42 RID: 15682 RVA: 0x000F236C File Offset: 0x000F056C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[38];
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x000F2390 File Offset: 0x000F0590
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeroProfilesRequest.Descriptor;
			}
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x000F23A7 File Offset: 0x000F05A7
		[DebuggerNonUserCode]
		public GetHeroProfilesRequest()
		{
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x000F23B1 File Offset: 0x000F05B1
		[DebuggerNonUserCode]
		public GetHeroProfilesRequest(GetHeroProfilesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x000F23E4 File Offset: 0x000F05E4
		[DebuggerNonUserCode]
		public GetHeroProfilesRequest Clone()
		{
			return new GetHeroProfilesRequest(this);
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x000F23FC File Offset: 0x000F05FC
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x000F242D File Offset: 0x000F062D
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
					gameAccountIdDefaultValue = GetHeroProfilesRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x000F2448 File Offset: 0x000F0648
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x000F2465 File Offset: 0x000F0665
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x000F2478 File Offset: 0x000F0678
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeroProfilesRequest);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x000F2498 File Offset: 0x000F0698
		[DebuggerNonUserCode]
		public bool Equals(GetHeroProfilesRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x000F24F0 File Offset: 0x000F06F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x000F2540 File Offset: 0x000F0740
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x000F2558 File Offset: 0x000F0758
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x000F2564 File Offset: 0x000F0764
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x000F25B0 File Offset: 0x000F07B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x000F2600 File Offset: 0x000F0800
		[DebuggerNonUserCode]
		public void MergeFrom(GetHeroProfilesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x000F2649 File Offset: 0x000F0849
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x000F2654 File Offset: 0x000F0854
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C30 RID: 7216
		private static readonly MessageParser<GetHeroProfilesRequest> _parser = new MessageParser<GetHeroProfilesRequest>(() => new GetHeroProfilesRequest());

		// Token: 0x04001C31 RID: 7217
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C32 RID: 7218
		private int _hasBits0;

		// Token: 0x04001C33 RID: 7219
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001C34 RID: 7220
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001C35 RID: 7221
		private uint gameAccountId_;
	}
}

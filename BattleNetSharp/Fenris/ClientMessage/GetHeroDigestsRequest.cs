using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000232 RID: 562
	public sealed class GetHeroDigestsRequest : IMessage<GetHeroDigestsRequest>, IMessage, IEquatable<GetHeroDigestsRequest>, IDeepCloneable<GetHeroDigestsRequest>, IBufferMessage
	{
		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x06003CEE RID: 15598 RVA: 0x000F14D0 File Offset: 0x000EF6D0
		[DebuggerNonUserCode]
		public static MessageParser<GetHeroDigestsRequest> Parser
		{
			get
			{
				return GetHeroDigestsRequest._parser;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x000F14E8 File Offset: 0x000EF6E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x000F150C File Offset: 0x000EF70C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeroDigestsRequest.Descriptor;
			}
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x000F1523 File Offset: 0x000EF723
		[DebuggerNonUserCode]
		public GetHeroDigestsRequest()
		{
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x000F152D File Offset: 0x000EF72D
		[DebuggerNonUserCode]
		public GetHeroDigestsRequest(GetHeroDigestsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x000F1560 File Offset: 0x000EF760
		[DebuggerNonUserCode]
		public GetHeroDigestsRequest Clone()
		{
			return new GetHeroDigestsRequest(this);
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000F1578 File Offset: 0x000EF778
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x000F15A9 File Offset: 0x000EF7A9
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
					gameAccountIdDefaultValue = GetHeroDigestsRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x000F15C4 File Offset: 0x000EF7C4
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x000F15E1 File Offset: 0x000EF7E1
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x000F15F4 File Offset: 0x000EF7F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeroDigestsRequest);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x000F1614 File Offset: 0x000EF814
		[DebuggerNonUserCode]
		public bool Equals(GetHeroDigestsRequest other)
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

		// Token: 0x06003CFA RID: 15610 RVA: 0x000F166C File Offset: 0x000EF86C
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

		// Token: 0x06003CFB RID: 15611 RVA: 0x000F16BC File Offset: 0x000EF8BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x000F16D4 File Offset: 0x000EF8D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x000F16E0 File Offset: 0x000EF8E0
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

		// Token: 0x06003CFE RID: 15614 RVA: 0x000F172C File Offset: 0x000EF92C
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

		// Token: 0x06003CFF RID: 15615 RVA: 0x000F177C File Offset: 0x000EF97C
		[DebuggerNonUserCode]
		public void MergeFrom(GetHeroDigestsRequest other)
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

		// Token: 0x06003D00 RID: 15616 RVA: 0x000F17C5 File Offset: 0x000EF9C5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x000F17D0 File Offset: 0x000EF9D0
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

		// Token: 0x04001C18 RID: 7192
		private static readonly MessageParser<GetHeroDigestsRequest> _parser = new MessageParser<GetHeroDigestsRequest>(() => new GetHeroDigestsRequest());

		// Token: 0x04001C19 RID: 7193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C1A RID: 7194
		private int _hasBits0;

		// Token: 0x04001C1B RID: 7195
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001C1C RID: 7196
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001C1D RID: 7197
		private uint gameAccountId_;
	}
}

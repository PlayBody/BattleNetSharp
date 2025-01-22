using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000244 RID: 580
	public sealed class PromoteToPartyLeaderRequest : IMessage<PromoteToPartyLeaderRequest>, IMessage, IEquatable<PromoteToPartyLeaderRequest>, IDeepCloneable<PromoteToPartyLeaderRequest>, IBufferMessage
	{
		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x000F6088 File Offset: 0x000F4288
		[DebuggerNonUserCode]
		public static MessageParser<PromoteToPartyLeaderRequest> Parser
		{
			get
			{
				return PromoteToPartyLeaderRequest._parser;
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06003E8E RID: 16014 RVA: 0x000F60A0 File Offset: 0x000F42A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[52];
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x000F60C4 File Offset: 0x000F42C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteToPartyLeaderRequest.Descriptor;
			}
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x000F60DB File Offset: 0x000F42DB
		[DebuggerNonUserCode]
		public PromoteToPartyLeaderRequest()
		{
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x000F60E5 File Offset: 0x000F42E5
		[DebuggerNonUserCode]
		public PromoteToPartyLeaderRequest(PromoteToPartyLeaderRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x000F6118 File Offset: 0x000F4318
		[DebuggerNonUserCode]
		public PromoteToPartyLeaderRequest Clone()
		{
			return new PromoteToPartyLeaderRequest(this);
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x000F6130 File Offset: 0x000F4330
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x000F6161 File Offset: 0x000F4361
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
					gameAccountIdDefaultValue = PromoteToPartyLeaderRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x000F617C File Offset: 0x000F437C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x000F6199 File Offset: 0x000F4399
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x000F61AC File Offset: 0x000F43AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteToPartyLeaderRequest);
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x000F61CC File Offset: 0x000F43CC
		[DebuggerNonUserCode]
		public bool Equals(PromoteToPartyLeaderRequest other)
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

		// Token: 0x06003E99 RID: 16025 RVA: 0x000F6224 File Offset: 0x000F4424
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

		// Token: 0x06003E9A RID: 16026 RVA: 0x000F6274 File Offset: 0x000F4474
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x000F628C File Offset: 0x000F448C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x000F6298 File Offset: 0x000F4498
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

		// Token: 0x06003E9D RID: 16029 RVA: 0x000F62E4 File Offset: 0x000F44E4
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

		// Token: 0x06003E9E RID: 16030 RVA: 0x000F6334 File Offset: 0x000F4534
		[DebuggerNonUserCode]
		public void MergeFrom(PromoteToPartyLeaderRequest other)
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

		// Token: 0x06003E9F RID: 16031 RVA: 0x000F637D File Offset: 0x000F457D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x000F6388 File Offset: 0x000F4588
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

		// Token: 0x04001C9F RID: 7327
		private static readonly MessageParser<PromoteToPartyLeaderRequest> _parser = new MessageParser<PromoteToPartyLeaderRequest>(() => new PromoteToPartyLeaderRequest());

		// Token: 0x04001CA0 RID: 7328
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CA1 RID: 7329
		private int _hasBits0;

		// Token: 0x04001CA2 RID: 7330
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001CA3 RID: 7331
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001CA4 RID: 7332
		private uint gameAccountId_;
	}
}

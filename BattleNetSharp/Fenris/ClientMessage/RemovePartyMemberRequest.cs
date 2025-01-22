using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000245 RID: 581
	public sealed class RemovePartyMemberRequest : IMessage<RemovePartyMemberRequest>, IMessage, IEquatable<RemovePartyMemberRequest>, IDeepCloneable<RemovePartyMemberRequest>, IBufferMessage
	{
		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x000F63FC File Offset: 0x000F45FC
		[DebuggerNonUserCode]
		public static MessageParser<RemovePartyMemberRequest> Parser
		{
			get
			{
				return RemovePartyMemberRequest._parser;
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06003EA3 RID: 16035 RVA: 0x000F6414 File Offset: 0x000F4614
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[53];
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x000F6438 File Offset: 0x000F4638
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePartyMemberRequest.Descriptor;
			}
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x000F644F File Offset: 0x000F464F
		[DebuggerNonUserCode]
		public RemovePartyMemberRequest()
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x000F6459 File Offset: 0x000F4659
		[DebuggerNonUserCode]
		public RemovePartyMemberRequest(RemovePartyMemberRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x000F648C File Offset: 0x000F468C
		[DebuggerNonUserCode]
		public RemovePartyMemberRequest Clone()
		{
			return new RemovePartyMemberRequest(this);
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x000F64A4 File Offset: 0x000F46A4
		// (set) Token: 0x06003EA9 RID: 16041 RVA: 0x000F64D5 File Offset: 0x000F46D5
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
					gameAccountIdDefaultValue = RemovePartyMemberRequest.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x000F64F0 File Offset: 0x000F46F0
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x000F650D File Offset: 0x000F470D
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x000F6520 File Offset: 0x000F4720
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePartyMemberRequest);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x000F6540 File Offset: 0x000F4740
		[DebuggerNonUserCode]
		public bool Equals(RemovePartyMemberRequest other)
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

		// Token: 0x06003EAE RID: 16046 RVA: 0x000F6598 File Offset: 0x000F4798
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

		// Token: 0x06003EAF RID: 16047 RVA: 0x000F65E8 File Offset: 0x000F47E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x000F6600 File Offset: 0x000F4800
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x000F660C File Offset: 0x000F480C
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

		// Token: 0x06003EB2 RID: 16050 RVA: 0x000F6658 File Offset: 0x000F4858
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

		// Token: 0x06003EB3 RID: 16051 RVA: 0x000F66A8 File Offset: 0x000F48A8
		[DebuggerNonUserCode]
		public void MergeFrom(RemovePartyMemberRequest other)
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

		// Token: 0x06003EB4 RID: 16052 RVA: 0x000F66F1 File Offset: 0x000F48F1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x000F66FC File Offset: 0x000F48FC
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

		// Token: 0x04001CA5 RID: 7333
		private static readonly MessageParser<RemovePartyMemberRequest> _parser = new MessageParser<RemovePartyMemberRequest>(() => new RemovePartyMemberRequest());

		// Token: 0x04001CA6 RID: 7334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CA7 RID: 7335
		private int _hasBits0;

		// Token: 0x04001CA8 RID: 7336
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001CA9 RID: 7337
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04001CAA RID: 7338
		private uint gameAccountId_;
	}
}

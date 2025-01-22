using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022B RID: 555
	public sealed class SelectHeroResponse : IMessage<SelectHeroResponse>, IMessage, IEquatable<SelectHeroResponse>, IDeepCloneable<SelectHeroResponse>, IBufferMessage
	{
		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x000EF258 File Offset: 0x000ED458
		[DebuggerNonUserCode]
		public static MessageParser<SelectHeroResponse> Parser
		{
			get
			{
				return SelectHeroResponse._parser;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x000EF270 File Offset: 0x000ED470
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x000EF294 File Offset: 0x000ED494
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectHeroResponse.Descriptor;
			}
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x000EF2AB File Offset: 0x000ED4AB
		[DebuggerNonUserCode]
		public SelectHeroResponse()
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x000EF2B5 File Offset: 0x000ED4B5
		[DebuggerNonUserCode]
		public SelectHeroResponse(SelectHeroResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accountPartitionType_ = other.accountPartitionType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x000EF2E8 File Offset: 0x000ED4E8
		[DebuggerNonUserCode]
		public SelectHeroResponse Clone()
		{
			return new SelectHeroResponse(this);
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x000EF300 File Offset: 0x000ED500
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x000EF331 File Offset: 0x000ED531
		[DebuggerNonUserCode]
		public int AccountPartitionType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int accountPartitionTypeDefaultValue;
				if (flag)
				{
					accountPartitionTypeDefaultValue = this.accountPartitionType_;
				}
				else
				{
					accountPartitionTypeDefaultValue = SelectHeroResponse.AccountPartitionTypeDefaultValue;
				}
				return accountPartitionTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accountPartitionType_ = value;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x000EF34C File Offset: 0x000ED54C
		[DebuggerNonUserCode]
		public bool HasAccountPartitionType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x000EF369 File Offset: 0x000ED569
		[DebuggerNonUserCode]
		public void ClearAccountPartitionType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x000EF37C File Offset: 0x000ED57C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectHeroResponse);
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x000EF39C File Offset: 0x000ED59C
		[DebuggerNonUserCode]
		public bool Equals(SelectHeroResponse other)
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
					bool flag4 = this.AccountPartitionType != other.AccountPartitionType;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x000EF3F4 File Offset: 0x000ED5F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccountPartitionType = this.HasAccountPartitionType;
			if (hasAccountPartitionType)
			{
				num ^= this.AccountPartitionType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x000EF444 File Offset: 0x000ED644
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x000EF45C File Offset: 0x000ED65C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x000EF468 File Offset: 0x000ED668
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccountPartitionType = this.HasAccountPartitionType;
			if (hasAccountPartitionType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AccountPartitionType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x000EF4B4 File Offset: 0x000ED6B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccountPartitionType = this.HasAccountPartitionType;
			if (hasAccountPartitionType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AccountPartitionType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x000EF504 File Offset: 0x000ED704
		[DebuggerNonUserCode]
		public void MergeFrom(SelectHeroResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccountPartitionType = other.HasAccountPartitionType;
				if (hasAccountPartitionType)
				{
					this.AccountPartitionType = other.AccountPartitionType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x000EF54D File Offset: 0x000ED74D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x000EF558 File Offset: 0x000ED758
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
					this.AccountPartitionType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001BDC RID: 7132
		private static readonly MessageParser<SelectHeroResponse> _parser = new MessageParser<SelectHeroResponse>(() => new SelectHeroResponse());

		// Token: 0x04001BDD RID: 7133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BDE RID: 7134
		private int _hasBits0;

		// Token: 0x04001BDF RID: 7135
		public const int AccountPartitionTypeFieldNumber = 1;

		// Token: 0x04001BE0 RID: 7136
		private static readonly int AccountPartitionTypeDefaultValue = 0;

		// Token: 0x04001BE1 RID: 7137
		private int accountPartitionType_;
	}
}

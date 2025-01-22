using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200049E RID: 1182
	public sealed class CreateResponse : IMessage<CreateResponse>, IMessage, IEquatable<CreateResponse>, IDeepCloneable<CreateResponse>, IBufferMessage
	{
		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x001C1A5C File Offset: 0x001BFC5C
		[DebuggerNonUserCode]
		public static MessageParser<CreateResponse> Parser
		{
			get
			{
				return CreateResponse._parser;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x0600730E RID: 29454 RVA: 0x001C1A74 File Offset: 0x001BFC74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x001C1A98 File Offset: 0x001BFC98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateResponse.Descriptor;
			}
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x001C1AAF File Offset: 0x001BFCAF
		[DebuggerNonUserCode]
		public CreateResponse()
		{
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x001C1AB9 File Offset: 0x001BFCB9
		[DebuggerNonUserCode]
		public CreateResponse(CreateResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x001C1AEC File Offset: 0x001BFCEC
		[DebuggerNonUserCode]
		public CreateResponse Clone()
		{
			return new CreateResponse(this);
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x001C1B04 File Offset: 0x001BFD04
		// (set) Token: 0x06007314 RID: 29460 RVA: 0x001C1B35 File Offset: 0x001BFD35
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = CreateResponse.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x001C1B50 File Offset: 0x001BFD50
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x001C1B6D File Offset: 0x001BFD6D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x001C1B80 File Offset: 0x001BFD80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateResponse);
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x001C1BA0 File Offset: 0x001BFDA0
		[DebuggerNonUserCode]
		public bool Equals(CreateResponse other)
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
					bool flag4 = this.ClubId != other.ClubId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x001C1BF8 File Offset: 0x001BFDF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x001C1C48 File Offset: 0x001BFE48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x001C1C60 File Offset: 0x001BFE60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x001C1C6C File Offset: 0x001BFE6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x001C1CB8 File Offset: 0x001BFEB8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x001C1D08 File Offset: 0x001BFF08
		[DebuggerNonUserCode]
		public void MergeFrom(CreateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x001C1D51 File Offset: 0x001BFF51
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x001C1D5C File Offset: 0x001BFF5C
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
					this.ClubId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040034A2 RID: 13474
		private static readonly MessageParser<CreateResponse> _parser = new MessageParser<CreateResponse>(() => new CreateResponse());

		// Token: 0x040034A3 RID: 13475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034A4 RID: 13476
		private int _hasBits0;

		// Token: 0x040034A5 RID: 13477
		public const int ClubIdFieldNumber = 1;

		// Token: 0x040034A6 RID: 13478
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040034A7 RID: 13479
		private ulong clubId_;
	}
}

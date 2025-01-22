using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004D2 RID: 1234
	public sealed class CreateStreamResponse : IMessage<CreateStreamResponse>, IMessage, IEquatable<CreateStreamResponse>, IDeepCloneable<CreateStreamResponse>, IBufferMessage
	{
		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x001D2D70 File Offset: 0x001D0F70
		[DebuggerNonUserCode]
		public static MessageParser<CreateStreamResponse> Parser
		{
			get
			{
				return CreateStreamResponse._parser;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x001D2D88 File Offset: 0x001D0F88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[55];
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x001D2DAC File Offset: 0x001D0FAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateStreamResponse.Descriptor;
			}
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x001D2DC3 File Offset: 0x001D0FC3
		[DebuggerNonUserCode]
		public CreateStreamResponse()
		{
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x001D2DCD File Offset: 0x001D0FCD
		[DebuggerNonUserCode]
		public CreateStreamResponse(CreateStreamResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x001D2E0C File Offset: 0x001D100C
		[DebuggerNonUserCode]
		public CreateStreamResponse Clone()
		{
			return new CreateStreamResponse(this);
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x060077F6 RID: 30710 RVA: 0x001D2E24 File Offset: 0x001D1024
		// (set) Token: 0x060077F7 RID: 30711 RVA: 0x001D2E55 File Offset: 0x001D1055
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
					clubIdDefaultValue = CreateStreamResponse.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x001D2E70 File Offset: 0x001D1070
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x001D2E8D File Offset: 0x001D108D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x060077FA RID: 30714 RVA: 0x001D2EA0 File Offset: 0x001D10A0
		// (set) Token: 0x060077FB RID: 30715 RVA: 0x001D2ED1 File Offset: 0x001D10D1
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = CreateStreamResponse.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x060077FC RID: 30716 RVA: 0x001D2EEC File Offset: 0x001D10EC
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x001D2F09 File Offset: 0x001D1109
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x001D2F1C File Offset: 0x001D111C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateStreamResponse);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x001D2F3C File Offset: 0x001D113C
		[DebuggerNonUserCode]
		public bool Equals(CreateStreamResponse other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StreamId != other.StreamId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x001D2FB0 File Offset: 0x001D11B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x001D301C File Offset: 0x001D121C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x001D3034 File Offset: 0x001D1234
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x001D3040 File Offset: 0x001D1240
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StreamId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x001D30B0 File Offset: 0x001D12B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x001D311C File Offset: 0x001D131C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateStreamResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x001D317E File Offset: 0x001D137E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x001D318C File Offset: 0x001D138C
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
						this.StreamId = input.ReadUInt64();
					}
				}
				else
				{
					this.ClubId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x0400367C RID: 13948
		private static readonly MessageParser<CreateStreamResponse> _parser = new MessageParser<CreateStreamResponse>(() => new CreateStreamResponse());

		// Token: 0x0400367D RID: 13949
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400367E RID: 13950
		private int _hasBits0;

		// Token: 0x0400367F RID: 13951
		public const int ClubIdFieldNumber = 1;

		// Token: 0x04003680 RID: 13952
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003681 RID: 13953
		private ulong clubId_;

		// Token: 0x04003682 RID: 13954
		public const int StreamIdFieldNumber = 2;

		// Token: 0x04003683 RID: 13955
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003684 RID: 13956
		private ulong streamId_;
	}
}

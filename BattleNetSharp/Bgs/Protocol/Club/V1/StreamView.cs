using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FE RID: 1278
	public sealed class StreamView : IMessage<StreamView>, IMessage, IEquatable<StreamView>, IDeepCloneable<StreamView>, IBufferMessage
	{
		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06007D01 RID: 32001 RVA: 0x001E7178 File Offset: 0x001E5378
		[DebuggerNonUserCode]
		public static MessageParser<StreamView> Parser
		{
			get
			{
				return StreamView._parser;
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x06007D02 RID: 32002 RVA: 0x001E7190 File Offset: 0x001E5390
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x001E71B4 File Offset: 0x001E53B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamView.Descriptor;
			}
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x001E71CB File Offset: 0x001E53CB
		[DebuggerNonUserCode]
		public StreamView()
		{
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x001E71D8 File Offset: 0x001E53D8
		[DebuggerNonUserCode]
		public StreamView(StreamView other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.marker_ = ((other.marker_ != null) ? other.marker_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x001E7240 File Offset: 0x001E5440
		[DebuggerNonUserCode]
		public StreamView Clone()
		{
			return new StreamView(this);
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x001E7258 File Offset: 0x001E5458
		// (set) Token: 0x06007D08 RID: 32008 RVA: 0x001E7289 File Offset: 0x001E5489
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
					clubIdDefaultValue = StreamView.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x06007D09 RID: 32009 RVA: 0x001E72A4 File Offset: 0x001E54A4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x001E72C1 File Offset: 0x001E54C1
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x001E72D4 File Offset: 0x001E54D4
		// (set) Token: 0x06007D0C RID: 32012 RVA: 0x001E7305 File Offset: 0x001E5505
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
					streamIdDefaultValue = StreamView.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x001E7320 File Offset: 0x001E5520
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x001E733D File Offset: 0x001E553D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x001E7350 File Offset: 0x001E5550
		// (set) Token: 0x06007D10 RID: 32016 RVA: 0x001E7368 File Offset: 0x001E5568
		[DebuggerNonUserCode]
		public ViewMarker Marker
		{
			get
			{
				return this.marker_;
			}
			set
			{
				this.marker_ = value;
			}
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x001E7374 File Offset: 0x001E5574
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamView);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x001E7394 File Offset: 0x001E5594
		[DebuggerNonUserCode]
		public bool Equals(StreamView other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Marker, other.Marker);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x001E7424 File Offset: 0x001E5624
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
			bool flag = this.marker_ != null;
			if (flag)
			{
				num ^= this.Marker.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x001E74B0 File Offset: 0x001E56B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x001E74C8 File Offset: 0x001E56C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x001E74D4 File Offset: 0x001E56D4
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
			bool flag = this.marker_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Marker);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x001E7568 File Offset: 0x001E5768
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
			bool flag = this.marker_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Marker);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x001E75F8 File Offset: 0x001E57F8
		[DebuggerNonUserCode]
		public void MergeFrom(StreamView other)
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
				bool flag2 = other.marker_ != null;
				if (flag2)
				{
					bool flag3 = this.marker_ == null;
					if (flag3)
					{
						this.Marker = new ViewMarker();
					}
					this.Marker.MergeFrom(other.Marker);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x001E769B File Offset: 0x001E589B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x001E76A8 File Offset: 0x001E58A8
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.marker_ == null;
							if (flag)
							{
								this.Marker = new ViewMarker();
							}
							input.ReadMessage(this.Marker);
						}
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

		// Token: 0x040038DF RID: 14559
		private static readonly MessageParser<StreamView> _parser = new MessageParser<StreamView>(() => new StreamView());

		// Token: 0x040038E0 RID: 14560
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038E1 RID: 14561
		private int _hasBits0;

		// Token: 0x040038E2 RID: 14562
		public const int ClubIdFieldNumber = 1;

		// Token: 0x040038E3 RID: 14563
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040038E4 RID: 14564
		private ulong clubId_;

		// Token: 0x040038E5 RID: 14565
		public const int StreamIdFieldNumber = 2;

		// Token: 0x040038E6 RID: 14566
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x040038E7 RID: 14567
		private ulong streamId_;

		// Token: 0x040038E8 RID: 14568
		public const int MarkerFieldNumber = 3;

		// Token: 0x040038E9 RID: 14569
		private ViewMarker marker_;
	}
}

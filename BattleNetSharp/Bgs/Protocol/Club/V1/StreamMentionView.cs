using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000501 RID: 1281
	public sealed class StreamMentionView : IMessage<StreamMentionView>, IMessage, IEquatable<StreamMentionView>, IDeepCloneable<StreamMentionView>, IBufferMessage
	{
		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x001E80C8 File Offset: 0x001E62C8
		[DebuggerNonUserCode]
		public static MessageParser<StreamMentionView> Parser
		{
			get
			{
				return StreamMentionView._parser;
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x06007D4F RID: 32079 RVA: 0x001E80E0 File Offset: 0x001E62E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x06007D50 RID: 32080 RVA: 0x001E8104 File Offset: 0x001E6304
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMentionView.Descriptor;
			}
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x001E811B File Offset: 0x001E631B
		[DebuggerNonUserCode]
		public StreamMentionView()
		{
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x001E8128 File Offset: 0x001E6328
		[DebuggerNonUserCode]
		public StreamMentionView(StreamMentionView other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.streamId_ = other.streamId_;
			this.marker_ = ((other.marker_ != null) ? other.marker_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x001E8190 File Offset: 0x001E6390
		[DebuggerNonUserCode]
		public StreamMentionView Clone()
		{
			return new StreamMentionView(this);
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x06007D54 RID: 32084 RVA: 0x001E81A8 File Offset: 0x001E63A8
		// (set) Token: 0x06007D55 RID: 32085 RVA: 0x001E81D9 File Offset: 0x001E63D9
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
					clubIdDefaultValue = StreamMentionView.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x001E81F4 File Offset: 0x001E63F4
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x001E8211 File Offset: 0x001E6411
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x001E8224 File Offset: 0x001E6424
		// (set) Token: 0x06007D59 RID: 32089 RVA: 0x001E8255 File Offset: 0x001E6455
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
					streamIdDefaultValue = StreamMentionView.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.streamId_ = value;
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x001E8270 File Offset: 0x001E6470
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x001E828D File Offset: 0x001E648D
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x06007D5C RID: 32092 RVA: 0x001E82A0 File Offset: 0x001E64A0
		// (set) Token: 0x06007D5D RID: 32093 RVA: 0x001E82B8 File Offset: 0x001E64B8
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

		// Token: 0x06007D5E RID: 32094 RVA: 0x001E82C4 File Offset: 0x001E64C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMentionView);
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x001E82E4 File Offset: 0x001E64E4
		[DebuggerNonUserCode]
		public bool Equals(StreamMentionView other)
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

		// Token: 0x06007D60 RID: 32096 RVA: 0x001E8374 File Offset: 0x001E6574
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

		// Token: 0x06007D61 RID: 32097 RVA: 0x001E8400 File Offset: 0x001E6600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x001E8418 File Offset: 0x001E6618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x001E8424 File Offset: 0x001E6624
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

		// Token: 0x06007D64 RID: 32100 RVA: 0x001E84B8 File Offset: 0x001E66B8
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

		// Token: 0x06007D65 RID: 32101 RVA: 0x001E8548 File Offset: 0x001E6748
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMentionView other)
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

		// Token: 0x06007D66 RID: 32102 RVA: 0x001E85EB File Offset: 0x001E67EB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x001E85F8 File Offset: 0x001E67F8
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

		// Token: 0x040038FC RID: 14588
		private static readonly MessageParser<StreamMentionView> _parser = new MessageParser<StreamMentionView>(() => new StreamMentionView());

		// Token: 0x040038FD RID: 14589
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038FE RID: 14590
		private int _hasBits0;

		// Token: 0x040038FF RID: 14591
		public const int ClubIdFieldNumber = 1;

		// Token: 0x04003900 RID: 14592
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x04003901 RID: 14593
		private ulong clubId_;

		// Token: 0x04003902 RID: 14594
		public const int StreamIdFieldNumber = 2;

		// Token: 0x04003903 RID: 14595
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003904 RID: 14596
		private ulong streamId_;

		// Token: 0x04003905 RID: 14597
		public const int MarkerFieldNumber = 3;

		// Token: 0x04003906 RID: 14598
		private ViewMarker marker_;
	}
}

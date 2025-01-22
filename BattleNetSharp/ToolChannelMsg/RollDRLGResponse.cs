using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C7 RID: 199
	public sealed class RollDRLGResponse : IMessage<RollDRLGResponse>, IMessage, IEquatable<RollDRLGResponse>, IDeepCloneable<RollDRLGResponse>, IBufferMessage
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00044EEC File Offset: 0x000430EC
		[DebuggerNonUserCode]
		public static MessageParser<RollDRLGResponse> Parser
		{
			get
			{
				return RollDRLGResponse._parser;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00044F04 File Offset: 0x00043104
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[176];
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00044F2C File Offset: 0x0004312C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollDRLGResponse.Descriptor;
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00044F43 File Offset: 0x00043143
		[DebuggerNonUserCode]
		public RollDRLGResponse()
		{
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00044F58 File Offset: 0x00043158
		[DebuggerNonUserCode]
		public RollDRLGResponse(RollDRLGResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.result_ = other.result_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00044FA8 File Offset: 0x000431A8
		[DebuggerNonUserCode]
		public RollDRLGResponse Clone()
		{
			return new RollDRLGResponse(this);
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00044FC0 File Offset: 0x000431C0
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00044FF1 File Offset: 0x000431F1
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = RollDRLGResponse.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0004500C File Offset: 0x0004320C
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00045029 File Offset: 0x00043229
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0004503C File Offset: 0x0004323C
		[DebuggerNonUserCode]
		public RepeatedField<RollDRLGResponse.Types.SeedResult> Result
		{
			get
			{
				return this.result_;
			}
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00045054 File Offset: 0x00043254
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollDRLGResponse);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00045074 File Offset: 0x00043274
		[DebuggerNonUserCode]
		public bool Equals(RollDRLGResponse other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.result_.Equals(other.result_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000450E8 File Offset: 0x000432E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			num ^= this.result_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00045148 File Offset: 0x00043348
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00045160 File Offset: 0x00043360
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0004516C File Offset: 0x0004336C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoWorld);
			}
			this.result_.WriteTo(ref output, RollDRLGResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000451CC File Offset: 0x000433CC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			num += this.result_.CalculateSize(RollDRLGResponse._repeated_result_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00045230 File Offset: 0x00043430
		[DebuggerNonUserCode]
		public void MergeFrom(RollDRLGResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				this.result_.Add(other.result_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0004528B File Offset: 0x0004348B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00045298 File Offset: 0x00043498
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.result_.AddEntriesFrom(ref input, RollDRLGResponse._repeated_result_codec);
					}
				}
				else
				{
					this.SnoWorld = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000799 RID: 1945
		private static readonly MessageParser<RollDRLGResponse> _parser = new MessageParser<RollDRLGResponse>(() => new RollDRLGResponse());

		// Token: 0x0400079A RID: 1946
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400079B RID: 1947
		private int _hasBits0;

		// Token: 0x0400079C RID: 1948
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x0400079D RID: 1949
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x0400079E RID: 1950
		private int snoWorld_;

		// Token: 0x0400079F RID: 1951
		public const int ResultFieldNumber = 2;

		// Token: 0x040007A0 RID: 1952
		private static readonly FieldCodec<RollDRLGResponse.Types.SeedResult> _repeated_result_codec = FieldCodec.ForMessage<RollDRLGResponse.Types.SeedResult>(18U, RollDRLGResponse.Types.SeedResult.Parser);

		// Token: 0x040007A1 RID: 1953
		private readonly RepeatedField<RollDRLGResponse.Types.SeedResult> result_ = new RepeatedField<RollDRLGResponse.Types.SeedResult>();

		// Token: 0x02000BE3 RID: 3043
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200146E RID: 5230
			public sealed class DRLGTile : IMessage<RollDRLGResponse.Types.DRLGTile>, IMessage, IEquatable<RollDRLGResponse.Types.DRLGTile>, IDeepCloneable<RollDRLGResponse.Types.DRLGTile>, IBufferMessage
			{
				// Token: 0x17003A35 RID: 14901
				// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x004D2C50 File Offset: 0x004D0E50
				[DebuggerNonUserCode]
				public static MessageParser<RollDRLGResponse.Types.DRLGTile> Parser
				{
					get
					{
						return RollDRLGResponse.Types.DRLGTile._parser;
					}
				}

				// Token: 0x17003A36 RID: 14902
				// (get) Token: 0x0600E500 RID: 58624 RVA: 0x004D2C68 File Offset: 0x004D0E68
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return RollDRLGResponse.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A37 RID: 14903
				// (get) Token: 0x0600E501 RID: 58625 RVA: 0x004D2C8C File Offset: 0x004D0E8C
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return RollDRLGResponse.Types.DRLGTile.Descriptor;
					}
				}

				// Token: 0x0600E502 RID: 58626 RVA: 0x004D2CA3 File Offset: 0x004D0EA3
				[DebuggerNonUserCode]
				public DRLGTile()
				{
				}

				// Token: 0x0600E503 RID: 58627 RVA: 0x004D2CB0 File Offset: 0x004D0EB0
				[DebuggerNonUserCode]
				public DRLGTile(RollDRLGResponse.Types.DRLGTile other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
					this.heightOffset_ = other.heightOffset_;
					this.createOrder_ = other.createOrder_;
					this.nodeId_ = other.nodeId_;
					this.tileType_ = other.tileType_;
					this.distanceFromStart_ = other.distanceFromStart_;
					this.snoScene_ = other.snoScene_;
					this.snoLevelArea_ = other.snoLevelArea_;
					this.sceneThumbnailOffsetX_ = other.sceneThumbnailOffsetX_;
					this.sceneThumbnailOffsetY_ = other.sceneThumbnailOffsetY_;
					this.sceneThumbnailBoundsX_ = other.sceneThumbnailBoundsX_;
					this.sceneThumbnailBoundsY_ = other.sceneThumbnailBoundsY_;
					this.flags_ = other.flags_;
					this.batchId_ = other.batchId_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E504 RID: 58628 RVA: 0x004D2D9C File Offset: 0x004D0F9C
				[DebuggerNonUserCode]
				public RollDRLGResponse.Types.DRLGTile Clone()
				{
					return new RollDRLGResponse.Types.DRLGTile(this);
				}

				// Token: 0x17003A38 RID: 14904
				// (get) Token: 0x0600E505 RID: 58629 RVA: 0x004D2DB4 File Offset: 0x004D0FB4
				// (set) Token: 0x0600E506 RID: 58630 RVA: 0x004D2DCC File Offset: 0x004D0FCC
				[DebuggerNonUserCode]
				public Vector2 Pos
				{
					get
					{
						return this.pos_;
					}
					set
					{
						this.pos_ = value;
					}
				}

				// Token: 0x17003A39 RID: 14905
				// (get) Token: 0x0600E507 RID: 58631 RVA: 0x004D2DD8 File Offset: 0x004D0FD8
				// (set) Token: 0x0600E508 RID: 58632 RVA: 0x004D2E09 File Offset: 0x004D1009
				[DebuggerNonUserCode]
				public float HeightOffset
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						float heightOffsetDefaultValue;
						if (flag)
						{
							heightOffsetDefaultValue = this.heightOffset_;
						}
						else
						{
							heightOffsetDefaultValue = RollDRLGResponse.Types.DRLGTile.HeightOffsetDefaultValue;
						}
						return heightOffsetDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.heightOffset_ = value;
					}
				}

				// Token: 0x17003A3A RID: 14906
				// (get) Token: 0x0600E509 RID: 58633 RVA: 0x004D2E24 File Offset: 0x004D1024
				[DebuggerNonUserCode]
				public bool HasHeightOffset
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E50A RID: 58634 RVA: 0x004D2E41 File Offset: 0x004D1041
				[DebuggerNonUserCode]
				public void ClearHeightOffset()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A3B RID: 14907
				// (get) Token: 0x0600E50B RID: 58635 RVA: 0x004D2E54 File Offset: 0x004D1054
				// (set) Token: 0x0600E50C RID: 58636 RVA: 0x004D2E85 File Offset: 0x004D1085
				[DebuggerNonUserCode]
				public int CreateOrder
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int createOrderDefaultValue;
						if (flag)
						{
							createOrderDefaultValue = this.createOrder_;
						}
						else
						{
							createOrderDefaultValue = RollDRLGResponse.Types.DRLGTile.CreateOrderDefaultValue;
						}
						return createOrderDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.createOrder_ = value;
					}
				}

				// Token: 0x17003A3C RID: 14908
				// (get) Token: 0x0600E50D RID: 58637 RVA: 0x004D2EA0 File Offset: 0x004D10A0
				[DebuggerNonUserCode]
				public bool HasCreateOrder
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E50E RID: 58638 RVA: 0x004D2EBD File Offset: 0x004D10BD
				[DebuggerNonUserCode]
				public void ClearCreateOrder()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A3D RID: 14909
				// (get) Token: 0x0600E50F RID: 58639 RVA: 0x004D2ED0 File Offset: 0x004D10D0
				// (set) Token: 0x0600E510 RID: 58640 RVA: 0x004D2F01 File Offset: 0x004D1101
				[DebuggerNonUserCode]
				public uint NodeId
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						uint nodeIdDefaultValue;
						if (flag)
						{
							nodeIdDefaultValue = this.nodeId_;
						}
						else
						{
							nodeIdDefaultValue = RollDRLGResponse.Types.DRLGTile.NodeIdDefaultValue;
						}
						return nodeIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.nodeId_ = value;
					}
				}

				// Token: 0x17003A3E RID: 14910
				// (get) Token: 0x0600E511 RID: 58641 RVA: 0x004D2F1C File Offset: 0x004D111C
				[DebuggerNonUserCode]
				public bool HasNodeId
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E512 RID: 58642 RVA: 0x004D2F39 File Offset: 0x004D1139
				[DebuggerNonUserCode]
				public void ClearNodeId()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003A3F RID: 14911
				// (get) Token: 0x0600E513 RID: 58643 RVA: 0x004D2F4C File Offset: 0x004D114C
				// (set) Token: 0x0600E514 RID: 58644 RVA: 0x004D2F7D File Offset: 0x004D117D
				[DebuggerNonUserCode]
				public int TileType
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						int tileTypeDefaultValue;
						if (flag)
						{
							tileTypeDefaultValue = this.tileType_;
						}
						else
						{
							tileTypeDefaultValue = RollDRLGResponse.Types.DRLGTile.TileTypeDefaultValue;
						}
						return tileTypeDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.tileType_ = value;
					}
				}

				// Token: 0x17003A40 RID: 14912
				// (get) Token: 0x0600E515 RID: 58645 RVA: 0x004D2F98 File Offset: 0x004D1198
				[DebuggerNonUserCode]
				public bool HasTileType
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E516 RID: 58646 RVA: 0x004D2FB5 File Offset: 0x004D11B5
				[DebuggerNonUserCode]
				public void ClearTileType()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x17003A41 RID: 14913
				// (get) Token: 0x0600E517 RID: 58647 RVA: 0x004D2FC8 File Offset: 0x004D11C8
				// (set) Token: 0x0600E518 RID: 58648 RVA: 0x004D2FFA File Offset: 0x004D11FA
				[DebuggerNonUserCode]
				public int DistanceFromStart
				{
					get
					{
						bool flag = (this._hasBits0 & 16) != 0;
						int distanceFromStartDefaultValue;
						if (flag)
						{
							distanceFromStartDefaultValue = this.distanceFromStart_;
						}
						else
						{
							distanceFromStartDefaultValue = RollDRLGResponse.Types.DRLGTile.DistanceFromStartDefaultValue;
						}
						return distanceFromStartDefaultValue;
					}
					set
					{
						this._hasBits0 |= 16;
						this.distanceFromStart_ = value;
					}
				}

				// Token: 0x17003A42 RID: 14914
				// (get) Token: 0x0600E519 RID: 58649 RVA: 0x004D3014 File Offset: 0x004D1214
				[DebuggerNonUserCode]
				public bool HasDistanceFromStart
				{
					get
					{
						return (this._hasBits0 & 16) != 0;
					}
				}

				// Token: 0x0600E51A RID: 58650 RVA: 0x004D3032 File Offset: 0x004D1232
				[DebuggerNonUserCode]
				public void ClearDistanceFromStart()
				{
					this._hasBits0 &= -17;
				}

				// Token: 0x17003A43 RID: 14915
				// (get) Token: 0x0600E51B RID: 58651 RVA: 0x004D3044 File Offset: 0x004D1244
				// (set) Token: 0x0600E51C RID: 58652 RVA: 0x004D3076 File Offset: 0x004D1276
				[DebuggerNonUserCode]
				public int SnoScene
				{
					get
					{
						bool flag = (this._hasBits0 & 32) != 0;
						int snoSceneDefaultValue;
						if (flag)
						{
							snoSceneDefaultValue = this.snoScene_;
						}
						else
						{
							snoSceneDefaultValue = RollDRLGResponse.Types.DRLGTile.SnoSceneDefaultValue;
						}
						return snoSceneDefaultValue;
					}
					set
					{
						this._hasBits0 |= 32;
						this.snoScene_ = value;
					}
				}

				// Token: 0x17003A44 RID: 14916
				// (get) Token: 0x0600E51D RID: 58653 RVA: 0x004D3090 File Offset: 0x004D1290
				[DebuggerNonUserCode]
				public bool HasSnoScene
				{
					get
					{
						return (this._hasBits0 & 32) != 0;
					}
				}

				// Token: 0x0600E51E RID: 58654 RVA: 0x004D30AE File Offset: 0x004D12AE
				[DebuggerNonUserCode]
				public void ClearSnoScene()
				{
					this._hasBits0 &= -33;
				}

				// Token: 0x17003A45 RID: 14917
				// (get) Token: 0x0600E51F RID: 58655 RVA: 0x004D30C0 File Offset: 0x004D12C0
				// (set) Token: 0x0600E520 RID: 58656 RVA: 0x004D30F2 File Offset: 0x004D12F2
				[DebuggerNonUserCode]
				public int SnoLevelArea
				{
					get
					{
						bool flag = (this._hasBits0 & 64) != 0;
						int snoLevelAreaDefaultValue;
						if (flag)
						{
							snoLevelAreaDefaultValue = this.snoLevelArea_;
						}
						else
						{
							snoLevelAreaDefaultValue = RollDRLGResponse.Types.DRLGTile.SnoLevelAreaDefaultValue;
						}
						return snoLevelAreaDefaultValue;
					}
					set
					{
						this._hasBits0 |= 64;
						this.snoLevelArea_ = value;
					}
				}

				// Token: 0x17003A46 RID: 14918
				// (get) Token: 0x0600E521 RID: 58657 RVA: 0x004D310C File Offset: 0x004D130C
				[DebuggerNonUserCode]
				public bool HasSnoLevelArea
				{
					get
					{
						return (this._hasBits0 & 64) != 0;
					}
				}

				// Token: 0x0600E522 RID: 58658 RVA: 0x004D312A File Offset: 0x004D132A
				[DebuggerNonUserCode]
				public void ClearSnoLevelArea()
				{
					this._hasBits0 &= -65;
				}

				// Token: 0x17003A47 RID: 14919
				// (get) Token: 0x0600E523 RID: 58659 RVA: 0x004D313C File Offset: 0x004D133C
				// (set) Token: 0x0600E524 RID: 58660 RVA: 0x004D3171 File Offset: 0x004D1371
				[DebuggerNonUserCode]
				public int SceneThumbnailOffsetX
				{
					get
					{
						bool flag = (this._hasBits0 & 128) != 0;
						int sceneThumbnailOffsetXDefaultValue;
						if (flag)
						{
							sceneThumbnailOffsetXDefaultValue = this.sceneThumbnailOffsetX_;
						}
						else
						{
							sceneThumbnailOffsetXDefaultValue = RollDRLGResponse.Types.DRLGTile.SceneThumbnailOffsetXDefaultValue;
						}
						return sceneThumbnailOffsetXDefaultValue;
					}
					set
					{
						this._hasBits0 |= 128;
						this.sceneThumbnailOffsetX_ = value;
					}
				}

				// Token: 0x17003A48 RID: 14920
				// (get) Token: 0x0600E525 RID: 58661 RVA: 0x004D3190 File Offset: 0x004D1390
				[DebuggerNonUserCode]
				public bool HasSceneThumbnailOffsetX
				{
					get
					{
						return (this._hasBits0 & 128) != 0;
					}
				}

				// Token: 0x0600E526 RID: 58662 RVA: 0x004D31B1 File Offset: 0x004D13B1
				[DebuggerNonUserCode]
				public void ClearSceneThumbnailOffsetX()
				{
					this._hasBits0 &= -129;
				}

				// Token: 0x17003A49 RID: 14921
				// (get) Token: 0x0600E527 RID: 58663 RVA: 0x004D31C8 File Offset: 0x004D13C8
				// (set) Token: 0x0600E528 RID: 58664 RVA: 0x004D31FD File Offset: 0x004D13FD
				[DebuggerNonUserCode]
				public int SceneThumbnailOffsetY
				{
					get
					{
						bool flag = (this._hasBits0 & 256) != 0;
						int sceneThumbnailOffsetYDefaultValue;
						if (flag)
						{
							sceneThumbnailOffsetYDefaultValue = this.sceneThumbnailOffsetY_;
						}
						else
						{
							sceneThumbnailOffsetYDefaultValue = RollDRLGResponse.Types.DRLGTile.SceneThumbnailOffsetYDefaultValue;
						}
						return sceneThumbnailOffsetYDefaultValue;
					}
					set
					{
						this._hasBits0 |= 256;
						this.sceneThumbnailOffsetY_ = value;
					}
				}

				// Token: 0x17003A4A RID: 14922
				// (get) Token: 0x0600E529 RID: 58665 RVA: 0x004D321C File Offset: 0x004D141C
				[DebuggerNonUserCode]
				public bool HasSceneThumbnailOffsetY
				{
					get
					{
						return (this._hasBits0 & 256) != 0;
					}
				}

				// Token: 0x0600E52A RID: 58666 RVA: 0x004D323D File Offset: 0x004D143D
				[DebuggerNonUserCode]
				public void ClearSceneThumbnailOffsetY()
				{
					this._hasBits0 &= -257;
				}

				// Token: 0x17003A4B RID: 14923
				// (get) Token: 0x0600E52B RID: 58667 RVA: 0x004D3254 File Offset: 0x004D1454
				// (set) Token: 0x0600E52C RID: 58668 RVA: 0x004D3289 File Offset: 0x004D1489
				[DebuggerNonUserCode]
				public int SceneThumbnailBoundsX
				{
					get
					{
						bool flag = (this._hasBits0 & 512) != 0;
						int sceneThumbnailBoundsXDefaultValue;
						if (flag)
						{
							sceneThumbnailBoundsXDefaultValue = this.sceneThumbnailBoundsX_;
						}
						else
						{
							sceneThumbnailBoundsXDefaultValue = RollDRLGResponse.Types.DRLGTile.SceneThumbnailBoundsXDefaultValue;
						}
						return sceneThumbnailBoundsXDefaultValue;
					}
					set
					{
						this._hasBits0 |= 512;
						this.sceneThumbnailBoundsX_ = value;
					}
				}

				// Token: 0x17003A4C RID: 14924
				// (get) Token: 0x0600E52D RID: 58669 RVA: 0x004D32A8 File Offset: 0x004D14A8
				[DebuggerNonUserCode]
				public bool HasSceneThumbnailBoundsX
				{
					get
					{
						return (this._hasBits0 & 512) != 0;
					}
				}

				// Token: 0x0600E52E RID: 58670 RVA: 0x004D32C9 File Offset: 0x004D14C9
				[DebuggerNonUserCode]
				public void ClearSceneThumbnailBoundsX()
				{
					this._hasBits0 &= -513;
				}

				// Token: 0x17003A4D RID: 14925
				// (get) Token: 0x0600E52F RID: 58671 RVA: 0x004D32E0 File Offset: 0x004D14E0
				// (set) Token: 0x0600E530 RID: 58672 RVA: 0x004D3315 File Offset: 0x004D1515
				[DebuggerNonUserCode]
				public int SceneThumbnailBoundsY
				{
					get
					{
						bool flag = (this._hasBits0 & 1024) != 0;
						int sceneThumbnailBoundsYDefaultValue;
						if (flag)
						{
							sceneThumbnailBoundsYDefaultValue = this.sceneThumbnailBoundsY_;
						}
						else
						{
							sceneThumbnailBoundsYDefaultValue = RollDRLGResponse.Types.DRLGTile.SceneThumbnailBoundsYDefaultValue;
						}
						return sceneThumbnailBoundsYDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1024;
						this.sceneThumbnailBoundsY_ = value;
					}
				}

				// Token: 0x17003A4E RID: 14926
				// (get) Token: 0x0600E531 RID: 58673 RVA: 0x004D3334 File Offset: 0x004D1534
				[DebuggerNonUserCode]
				public bool HasSceneThumbnailBoundsY
				{
					get
					{
						return (this._hasBits0 & 1024) != 0;
					}
				}

				// Token: 0x0600E532 RID: 58674 RVA: 0x004D3355 File Offset: 0x004D1555
				[DebuggerNonUserCode]
				public void ClearSceneThumbnailBoundsY()
				{
					this._hasBits0 &= -1025;
				}

				// Token: 0x17003A4F RID: 14927
				// (get) Token: 0x0600E533 RID: 58675 RVA: 0x004D336C File Offset: 0x004D156C
				// (set) Token: 0x0600E534 RID: 58676 RVA: 0x004D33A1 File Offset: 0x004D15A1
				[DebuggerNonUserCode]
				public uint Flags
				{
					get
					{
						bool flag = (this._hasBits0 & 2048) != 0;
						uint flagsDefaultValue;
						if (flag)
						{
							flagsDefaultValue = this.flags_;
						}
						else
						{
							flagsDefaultValue = RollDRLGResponse.Types.DRLGTile.FlagsDefaultValue;
						}
						return flagsDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2048;
						this.flags_ = value;
					}
				}

				// Token: 0x17003A50 RID: 14928
				// (get) Token: 0x0600E535 RID: 58677 RVA: 0x004D33C0 File Offset: 0x004D15C0
				[DebuggerNonUserCode]
				public bool HasFlags
				{
					get
					{
						return (this._hasBits0 & 2048) != 0;
					}
				}

				// Token: 0x0600E536 RID: 58678 RVA: 0x004D33E1 File Offset: 0x004D15E1
				[DebuggerNonUserCode]
				public void ClearFlags()
				{
					this._hasBits0 &= -2049;
				}

				// Token: 0x17003A51 RID: 14929
				// (get) Token: 0x0600E537 RID: 58679 RVA: 0x004D33F8 File Offset: 0x004D15F8
				// (set) Token: 0x0600E538 RID: 58680 RVA: 0x004D342D File Offset: 0x004D162D
				[DebuggerNonUserCode]
				public int BatchId
				{
					get
					{
						bool flag = (this._hasBits0 & 4096) != 0;
						int batchIdDefaultValue;
						if (flag)
						{
							batchIdDefaultValue = this.batchId_;
						}
						else
						{
							batchIdDefaultValue = RollDRLGResponse.Types.DRLGTile.BatchIdDefaultValue;
						}
						return batchIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4096;
						this.batchId_ = value;
					}
				}

				// Token: 0x17003A52 RID: 14930
				// (get) Token: 0x0600E539 RID: 58681 RVA: 0x004D344C File Offset: 0x004D164C
				[DebuggerNonUserCode]
				public bool HasBatchId
				{
					get
					{
						return (this._hasBits0 & 4096) != 0;
					}
				}

				// Token: 0x0600E53A RID: 58682 RVA: 0x004D346D File Offset: 0x004D166D
				[DebuggerNonUserCode]
				public void ClearBatchId()
				{
					this._hasBits0 &= -4097;
				}

				// Token: 0x0600E53B RID: 58683 RVA: 0x004D3484 File Offset: 0x004D1684
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as RollDRLGResponse.Types.DRLGTile);
				}

				// Token: 0x0600E53C RID: 58684 RVA: 0x004D34A4 File Offset: 0x004D16A4
				[DebuggerNonUserCode]
				public bool Equals(RollDRLGResponse.Types.DRLGTile other)
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
							bool flag4 = !object.Equals(this.Pos, other.Pos);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.HeightOffset, other.HeightOffset);
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.CreateOrder != other.CreateOrder;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.NodeId != other.NodeId;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.TileType != other.TileType;
											if (flag8)
											{
												flag2 = false;
											}
											else
											{
												bool flag9 = this.DistanceFromStart != other.DistanceFromStart;
												if (flag9)
												{
													flag2 = false;
												}
												else
												{
													bool flag10 = this.SnoScene != other.SnoScene;
													if (flag10)
													{
														flag2 = false;
													}
													else
													{
														bool flag11 = this.SnoLevelArea != other.SnoLevelArea;
														if (flag11)
														{
															flag2 = false;
														}
														else
														{
															bool flag12 = this.SceneThumbnailOffsetX != other.SceneThumbnailOffsetX;
															if (flag12)
															{
																flag2 = false;
															}
															else
															{
																bool flag13 = this.SceneThumbnailOffsetY != other.SceneThumbnailOffsetY;
																if (flag13)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag14 = this.SceneThumbnailBoundsX != other.SceneThumbnailBoundsX;
																	if (flag14)
																	{
																		flag2 = false;
																	}
																	else
																	{
																		bool flag15 = this.SceneThumbnailBoundsY != other.SceneThumbnailBoundsY;
																		if (flag15)
																		{
																			flag2 = false;
																		}
																		else
																		{
																			bool flag16 = this.Flags != other.Flags;
																			if (flag16)
																			{
																				flag2 = false;
																			}
																			else
																			{
																				bool flag17 = this.BatchId != other.BatchId;
																				flag2 = !flag17 && object.Equals(this._unknownFields, other._unknownFields);
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E53D RID: 58685 RVA: 0x004D3688 File Offset: 0x004D1888
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool flag = this.pos_ != null;
					if (flag)
					{
						num ^= this.Pos.GetHashCode();
					}
					bool hasHeightOffset = this.HasHeightOffset;
					if (hasHeightOffset)
					{
						num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.HeightOffset);
					}
					bool hasCreateOrder = this.HasCreateOrder;
					if (hasCreateOrder)
					{
						num ^= this.CreateOrder.GetHashCode();
					}
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						num ^= this.NodeId.GetHashCode();
					}
					bool hasTileType = this.HasTileType;
					if (hasTileType)
					{
						num ^= this.TileType.GetHashCode();
					}
					bool hasDistanceFromStart = this.HasDistanceFromStart;
					if (hasDistanceFromStart)
					{
						num ^= this.DistanceFromStart.GetHashCode();
					}
					bool hasSnoScene = this.HasSnoScene;
					if (hasSnoScene)
					{
						num ^= this.SnoScene.GetHashCode();
					}
					bool hasSnoLevelArea = this.HasSnoLevelArea;
					if (hasSnoLevelArea)
					{
						num ^= this.SnoLevelArea.GetHashCode();
					}
					bool hasSceneThumbnailOffsetX = this.HasSceneThumbnailOffsetX;
					if (hasSceneThumbnailOffsetX)
					{
						num ^= this.SceneThumbnailOffsetX.GetHashCode();
					}
					bool hasSceneThumbnailOffsetY = this.HasSceneThumbnailOffsetY;
					if (hasSceneThumbnailOffsetY)
					{
						num ^= this.SceneThumbnailOffsetY.GetHashCode();
					}
					bool hasSceneThumbnailBoundsX = this.HasSceneThumbnailBoundsX;
					if (hasSceneThumbnailBoundsX)
					{
						num ^= this.SceneThumbnailBoundsX.GetHashCode();
					}
					bool hasSceneThumbnailBoundsY = this.HasSceneThumbnailBoundsY;
					if (hasSceneThumbnailBoundsY)
					{
						num ^= this.SceneThumbnailBoundsY.GetHashCode();
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						num ^= this.Flags.GetHashCode();
					}
					bool hasBatchId = this.HasBatchId;
					if (hasBatchId)
					{
						num ^= this.BatchId.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E53E RID: 58686 RVA: 0x004D385C File Offset: 0x004D1A5C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E53F RID: 58687 RVA: 0x004D3874 File Offset: 0x004D1A74
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E540 RID: 58688 RVA: 0x004D3880 File Offset: 0x004D1A80
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool flag = this.pos_ != null;
					if (flag)
					{
						output.WriteRawTag(10);
						output.WriteMessage(this.Pos);
					}
					bool hasHeightOffset = this.HasHeightOffset;
					if (hasHeightOffset)
					{
						output.WriteRawTag(21);
						output.WriteFloat(this.HeightOffset);
					}
					bool hasCreateOrder = this.HasCreateOrder;
					if (hasCreateOrder)
					{
						output.WriteRawTag(24);
						output.WriteInt32(this.CreateOrder);
					}
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						output.WriteRawTag(32);
						output.WriteUInt32(this.NodeId);
					}
					bool hasTileType = this.HasTileType;
					if (hasTileType)
					{
						output.WriteRawTag(40);
						output.WriteInt32(this.TileType);
					}
					bool hasDistanceFromStart = this.HasDistanceFromStart;
					if (hasDistanceFromStart)
					{
						output.WriteRawTag(48);
						output.WriteInt32(this.DistanceFromStart);
					}
					bool hasSnoScene = this.HasSnoScene;
					if (hasSnoScene)
					{
						output.WriteRawTag(56);
						output.WriteInt32(this.SnoScene);
					}
					bool hasSnoLevelArea = this.HasSnoLevelArea;
					if (hasSnoLevelArea)
					{
						output.WriteRawTag(64);
						output.WriteInt32(this.SnoLevelArea);
					}
					bool hasSceneThumbnailOffsetX = this.HasSceneThumbnailOffsetX;
					if (hasSceneThumbnailOffsetX)
					{
						output.WriteRawTag(72);
						output.WriteInt32(this.SceneThumbnailOffsetX);
					}
					bool hasSceneThumbnailOffsetY = this.HasSceneThumbnailOffsetY;
					if (hasSceneThumbnailOffsetY)
					{
						output.WriteRawTag(80);
						output.WriteInt32(this.SceneThumbnailOffsetY);
					}
					bool hasSceneThumbnailBoundsX = this.HasSceneThumbnailBoundsX;
					if (hasSceneThumbnailBoundsX)
					{
						output.WriteRawTag(88);
						output.WriteInt32(this.SceneThumbnailBoundsX);
					}
					bool hasSceneThumbnailBoundsY = this.HasSceneThumbnailBoundsY;
					if (hasSceneThumbnailBoundsY)
					{
						output.WriteRawTag(96);
						output.WriteInt32(this.SceneThumbnailBoundsY);
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						output.WriteRawTag(104);
						output.WriteUInt32(this.Flags);
					}
					bool hasBatchId = this.HasBatchId;
					if (hasBatchId)
					{
						output.WriteRawTag(112);
						output.WriteInt32(this.BatchId);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E541 RID: 58689 RVA: 0x004D3AA0 File Offset: 0x004D1CA0
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool flag = this.pos_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
					}
					bool hasHeightOffset = this.HasHeightOffset;
					if (hasHeightOffset)
					{
						num += 5;
					}
					bool hasCreateOrder = this.HasCreateOrder;
					if (hasCreateOrder)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.CreateOrder);
					}
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.NodeId);
					}
					bool hasTileType = this.HasTileType;
					if (hasTileType)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.TileType);
					}
					bool hasDistanceFromStart = this.HasDistanceFromStart;
					if (hasDistanceFromStart)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.DistanceFromStart);
					}
					bool hasSnoScene = this.HasSnoScene;
					if (hasSnoScene)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoScene);
					}
					bool hasSnoLevelArea = this.HasSnoLevelArea;
					if (hasSnoLevelArea)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoLevelArea);
					}
					bool hasSceneThumbnailOffsetX = this.HasSceneThumbnailOffsetX;
					if (hasSceneThumbnailOffsetX)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneThumbnailOffsetX);
					}
					bool hasSceneThumbnailOffsetY = this.HasSceneThumbnailOffsetY;
					if (hasSceneThumbnailOffsetY)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneThumbnailOffsetY);
					}
					bool hasSceneThumbnailBoundsX = this.HasSceneThumbnailBoundsX;
					if (hasSceneThumbnailBoundsX)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneThumbnailBoundsX);
					}
					bool hasSceneThumbnailBoundsY = this.HasSceneThumbnailBoundsY;
					if (hasSceneThumbnailBoundsY)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneThumbnailBoundsY);
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
					}
					bool hasBatchId = this.HasBatchId;
					if (hasBatchId)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.BatchId);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E542 RID: 58690 RVA: 0x004D3C6C File Offset: 0x004D1E6C
				[DebuggerNonUserCode]
				public void MergeFrom(RollDRLGResponse.Types.DRLGTile other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool flag2 = other.pos_ != null;
						if (flag2)
						{
							bool flag3 = this.pos_ == null;
							if (flag3)
							{
								this.Pos = new Vector2();
							}
							this.Pos.MergeFrom(other.Pos);
						}
						bool hasHeightOffset = other.HasHeightOffset;
						if (hasHeightOffset)
						{
							this.HeightOffset = other.HeightOffset;
						}
						bool hasCreateOrder = other.HasCreateOrder;
						if (hasCreateOrder)
						{
							this.CreateOrder = other.CreateOrder;
						}
						bool hasNodeId = other.HasNodeId;
						if (hasNodeId)
						{
							this.NodeId = other.NodeId;
						}
						bool hasTileType = other.HasTileType;
						if (hasTileType)
						{
							this.TileType = other.TileType;
						}
						bool hasDistanceFromStart = other.HasDistanceFromStart;
						if (hasDistanceFromStart)
						{
							this.DistanceFromStart = other.DistanceFromStart;
						}
						bool hasSnoScene = other.HasSnoScene;
						if (hasSnoScene)
						{
							this.SnoScene = other.SnoScene;
						}
						bool hasSnoLevelArea = other.HasSnoLevelArea;
						if (hasSnoLevelArea)
						{
							this.SnoLevelArea = other.SnoLevelArea;
						}
						bool hasSceneThumbnailOffsetX = other.HasSceneThumbnailOffsetX;
						if (hasSceneThumbnailOffsetX)
						{
							this.SceneThumbnailOffsetX = other.SceneThumbnailOffsetX;
						}
						bool hasSceneThumbnailOffsetY = other.HasSceneThumbnailOffsetY;
						if (hasSceneThumbnailOffsetY)
						{
							this.SceneThumbnailOffsetY = other.SceneThumbnailOffsetY;
						}
						bool hasSceneThumbnailBoundsX = other.HasSceneThumbnailBoundsX;
						if (hasSceneThumbnailBoundsX)
						{
							this.SceneThumbnailBoundsX = other.SceneThumbnailBoundsX;
						}
						bool hasSceneThumbnailBoundsY = other.HasSceneThumbnailBoundsY;
						if (hasSceneThumbnailBoundsY)
						{
							this.SceneThumbnailBoundsY = other.SceneThumbnailBoundsY;
						}
						bool hasFlags = other.HasFlags;
						if (hasFlags)
						{
							this.Flags = other.Flags;
						}
						bool hasBatchId = other.HasBatchId;
						if (hasBatchId)
						{
							this.BatchId = other.BatchId;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E543 RID: 58691 RVA: 0x004D3E38 File Offset: 0x004D2038
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E544 RID: 58692 RVA: 0x004D3E44 File Offset: 0x004D2044
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 56U)
						{
							if (num3 <= 24U)
							{
								if (num3 != 10U)
								{
									if (num3 != 21U)
									{
										if (num3 != 24U)
										{
											goto IL_00B0;
										}
										this.CreateOrder = input.ReadInt32();
									}
									else
									{
										this.HeightOffset = input.ReadFloat();
									}
								}
								else
								{
									bool flag = this.pos_ == null;
									if (flag)
									{
										this.Pos = new Vector2();
									}
									input.ReadMessage(this.Pos);
								}
							}
							else if (num3 <= 40U)
							{
								if (num3 != 32U)
								{
									if (num3 != 40U)
									{
										goto IL_00B0;
									}
									this.TileType = input.ReadInt32();
								}
								else
								{
									this.NodeId = input.ReadUInt32();
								}
							}
							else if (num3 != 48U)
							{
								if (num3 != 56U)
								{
									goto IL_00B0;
								}
								this.SnoScene = input.ReadInt32();
							}
							else
							{
								this.DistanceFromStart = input.ReadInt32();
							}
						}
						else if (num3 <= 80U)
						{
							if (num3 != 64U)
							{
								if (num3 != 72U)
								{
									if (num3 != 80U)
									{
										goto IL_00B0;
									}
									this.SceneThumbnailOffsetY = input.ReadInt32();
								}
								else
								{
									this.SceneThumbnailOffsetX = input.ReadInt32();
								}
							}
							else
							{
								this.SnoLevelArea = input.ReadInt32();
							}
						}
						else if (num3 <= 96U)
						{
							if (num3 != 88U)
							{
								if (num3 != 96U)
								{
									goto IL_00B0;
								}
								this.SceneThumbnailBoundsY = input.ReadInt32();
							}
							else
							{
								this.SceneThumbnailBoundsX = input.ReadInt32();
							}
						}
						else if (num3 != 104U)
						{
							if (num3 != 112U)
							{
								goto IL_00B0;
							}
							this.BatchId = input.ReadInt32();
						}
						else
						{
							this.Flags = input.ReadUInt32();
						}
						continue;
						IL_00B0:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A302 RID: 41730
				private static readonly MessageParser<RollDRLGResponse.Types.DRLGTile> _parser = new MessageParser<RollDRLGResponse.Types.DRLGTile>(() => new RollDRLGResponse.Types.DRLGTile());

				// Token: 0x0400A303 RID: 41731
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A304 RID: 41732
				private int _hasBits0;

				// Token: 0x0400A305 RID: 41733
				public const int PosFieldNumber = 1;

				// Token: 0x0400A306 RID: 41734
				private Vector2 pos_;

				// Token: 0x0400A307 RID: 41735
				public const int HeightOffsetFieldNumber = 2;

				// Token: 0x0400A308 RID: 41736
				private static readonly float HeightOffsetDefaultValue = 0f;

				// Token: 0x0400A309 RID: 41737
				private float heightOffset_;

				// Token: 0x0400A30A RID: 41738
				public const int CreateOrderFieldNumber = 3;

				// Token: 0x0400A30B RID: 41739
				private static readonly int CreateOrderDefaultValue = 0;

				// Token: 0x0400A30C RID: 41740
				private int createOrder_;

				// Token: 0x0400A30D RID: 41741
				public const int NodeIdFieldNumber = 4;

				// Token: 0x0400A30E RID: 41742
				private static readonly uint NodeIdDefaultValue = 0U;

				// Token: 0x0400A30F RID: 41743
				private uint nodeId_;

				// Token: 0x0400A310 RID: 41744
				public const int TileTypeFieldNumber = 5;

				// Token: 0x0400A311 RID: 41745
				private static readonly int TileTypeDefaultValue = 0;

				// Token: 0x0400A312 RID: 41746
				private int tileType_;

				// Token: 0x0400A313 RID: 41747
				public const int DistanceFromStartFieldNumber = 6;

				// Token: 0x0400A314 RID: 41748
				private static readonly int DistanceFromStartDefaultValue = 0;

				// Token: 0x0400A315 RID: 41749
				private int distanceFromStart_;

				// Token: 0x0400A316 RID: 41750
				public const int SnoSceneFieldNumber = 7;

				// Token: 0x0400A317 RID: 41751
				private static readonly int SnoSceneDefaultValue = 0;

				// Token: 0x0400A318 RID: 41752
				private int snoScene_;

				// Token: 0x0400A319 RID: 41753
				public const int SnoLevelAreaFieldNumber = 8;

				// Token: 0x0400A31A RID: 41754
				private static readonly int SnoLevelAreaDefaultValue = 0;

				// Token: 0x0400A31B RID: 41755
				private int snoLevelArea_;

				// Token: 0x0400A31C RID: 41756
				public const int SceneThumbnailOffsetXFieldNumber = 9;

				// Token: 0x0400A31D RID: 41757
				private static readonly int SceneThumbnailOffsetXDefaultValue = 0;

				// Token: 0x0400A31E RID: 41758
				private int sceneThumbnailOffsetX_;

				// Token: 0x0400A31F RID: 41759
				public const int SceneThumbnailOffsetYFieldNumber = 10;

				// Token: 0x0400A320 RID: 41760
				private static readonly int SceneThumbnailOffsetYDefaultValue = 0;

				// Token: 0x0400A321 RID: 41761
				private int sceneThumbnailOffsetY_;

				// Token: 0x0400A322 RID: 41762
				public const int SceneThumbnailBoundsXFieldNumber = 11;

				// Token: 0x0400A323 RID: 41763
				private static readonly int SceneThumbnailBoundsXDefaultValue = 0;

				// Token: 0x0400A324 RID: 41764
				private int sceneThumbnailBoundsX_;

				// Token: 0x0400A325 RID: 41765
				public const int SceneThumbnailBoundsYFieldNumber = 12;

				// Token: 0x0400A326 RID: 41766
				private static readonly int SceneThumbnailBoundsYDefaultValue = 0;

				// Token: 0x0400A327 RID: 41767
				private int sceneThumbnailBoundsY_;

				// Token: 0x0400A328 RID: 41768
				public const int FlagsFieldNumber = 13;

				// Token: 0x0400A329 RID: 41769
				private static readonly uint FlagsDefaultValue = 0U;

				// Token: 0x0400A32A RID: 41770
				private uint flags_;

				// Token: 0x0400A32B RID: 41771
				public const int BatchIdFieldNumber = 14;

				// Token: 0x0400A32C RID: 41772
				private static readonly int BatchIdDefaultValue = 0;

				// Token: 0x0400A32D RID: 41773
				private int batchId_;
			}

			// Token: 0x0200146F RID: 5231
			public sealed class ErrorLogEntry : IMessage<RollDRLGResponse.Types.ErrorLogEntry>, IMessage, IEquatable<RollDRLGResponse.Types.ErrorLogEntry>, IDeepCloneable<RollDRLGResponse.Types.ErrorLogEntry>, IBufferMessage
			{
				// Token: 0x17003A53 RID: 14931
				// (get) Token: 0x0600E546 RID: 58694 RVA: 0x004D40B8 File Offset: 0x004D22B8
				[DebuggerNonUserCode]
				public static MessageParser<RollDRLGResponse.Types.ErrorLogEntry> Parser
				{
					get
					{
						return RollDRLGResponse.Types.ErrorLogEntry._parser;
					}
				}

				// Token: 0x17003A54 RID: 14932
				// (get) Token: 0x0600E547 RID: 58695 RVA: 0x004D40D0 File Offset: 0x004D22D0
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return RollDRLGResponse.Descriptor.NestedTypes[1];
					}
				}

				// Token: 0x17003A55 RID: 14933
				// (get) Token: 0x0600E548 RID: 58696 RVA: 0x004D40F4 File Offset: 0x004D22F4
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return RollDRLGResponse.Types.ErrorLogEntry.Descriptor;
					}
				}

				// Token: 0x0600E549 RID: 58697 RVA: 0x004D410B File Offset: 0x004D230B
				[DebuggerNonUserCode]
				public ErrorLogEntry()
				{
				}

				// Token: 0x0600E54A RID: 58698 RVA: 0x004D4115 File Offset: 0x004D2315
				[DebuggerNonUserCode]
				public ErrorLogEntry(RollDRLGResponse.Types.ErrorLogEntry other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.nodeId_ = other.nodeId_;
					this.errorMessage_ = other.errorMessage_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E54B RID: 58699 RVA: 0x004D4154 File Offset: 0x004D2354
				[DebuggerNonUserCode]
				public RollDRLGResponse.Types.ErrorLogEntry Clone()
				{
					return new RollDRLGResponse.Types.ErrorLogEntry(this);
				}

				// Token: 0x17003A56 RID: 14934
				// (get) Token: 0x0600E54C RID: 58700 RVA: 0x004D416C File Offset: 0x004D236C
				// (set) Token: 0x0600E54D RID: 58701 RVA: 0x004D419D File Offset: 0x004D239D
				[DebuggerNonUserCode]
				public uint NodeId
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint nodeIdDefaultValue;
						if (flag)
						{
							nodeIdDefaultValue = this.nodeId_;
						}
						else
						{
							nodeIdDefaultValue = RollDRLGResponse.Types.ErrorLogEntry.NodeIdDefaultValue;
						}
						return nodeIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.nodeId_ = value;
					}
				}

				// Token: 0x17003A57 RID: 14935
				// (get) Token: 0x0600E54E RID: 58702 RVA: 0x004D41B8 File Offset: 0x004D23B8
				[DebuggerNonUserCode]
				public bool HasNodeId
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E54F RID: 58703 RVA: 0x004D41D5 File Offset: 0x004D23D5
				[DebuggerNonUserCode]
				public void ClearNodeId()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A58 RID: 14936
				// (get) Token: 0x0600E550 RID: 58704 RVA: 0x004D41E8 File Offset: 0x004D23E8
				// (set) Token: 0x0600E551 RID: 58705 RVA: 0x004D4209 File Offset: 0x004D2409
				[DebuggerNonUserCode]
				public string ErrorMessage
				{
					get
					{
						return this.errorMessage_ ?? RollDRLGResponse.Types.ErrorLogEntry.ErrorMessageDefaultValue;
					}
					set
					{
						this.errorMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x17003A59 RID: 14937
				// (get) Token: 0x0600E552 RID: 58706 RVA: 0x004D4220 File Offset: 0x004D2420
				[DebuggerNonUserCode]
				public bool HasErrorMessage
				{
					get
					{
						return this.errorMessage_ != null;
					}
				}

				// Token: 0x0600E553 RID: 58707 RVA: 0x004D423B File Offset: 0x004D243B
				[DebuggerNonUserCode]
				public void ClearErrorMessage()
				{
					this.errorMessage_ = null;
				}

				// Token: 0x0600E554 RID: 58708 RVA: 0x004D4248 File Offset: 0x004D2448
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as RollDRLGResponse.Types.ErrorLogEntry);
				}

				// Token: 0x0600E555 RID: 58709 RVA: 0x004D4268 File Offset: 0x004D2468
				[DebuggerNonUserCode]
				public bool Equals(RollDRLGResponse.Types.ErrorLogEntry other)
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
							bool flag4 = this.NodeId != other.NodeId;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.ErrorMessage != other.ErrorMessage;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E556 RID: 58710 RVA: 0x004D42DC File Offset: 0x004D24DC
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						num ^= this.NodeId.GetHashCode();
					}
					bool hasErrorMessage = this.HasErrorMessage;
					if (hasErrorMessage)
					{
						num ^= this.ErrorMessage.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E557 RID: 58711 RVA: 0x004D4348 File Offset: 0x004D2548
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E558 RID: 58712 RVA: 0x004D4360 File Offset: 0x004D2560
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E559 RID: 58713 RVA: 0x004D436C File Offset: 0x004D256C
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						output.WriteRawTag(8);
						output.WriteUInt32(this.NodeId);
					}
					bool hasErrorMessage = this.HasErrorMessage;
					if (hasErrorMessage)
					{
						output.WriteRawTag(18);
						output.WriteString(this.ErrorMessage);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E55A RID: 58714 RVA: 0x004D43DC File Offset: 0x004D25DC
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasNodeId = this.HasNodeId;
					if (hasNodeId)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.NodeId);
					}
					bool hasErrorMessage = this.HasErrorMessage;
					if (hasErrorMessage)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorMessage);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E55B RID: 58715 RVA: 0x004D4448 File Offset: 0x004D2648
				[DebuggerNonUserCode]
				public void MergeFrom(RollDRLGResponse.Types.ErrorLogEntry other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasNodeId = other.HasNodeId;
						if (hasNodeId)
						{
							this.NodeId = other.NodeId;
						}
						bool hasErrorMessage = other.HasErrorMessage;
						if (hasErrorMessage)
						{
							this.ErrorMessage = other.ErrorMessage;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E55C RID: 58716 RVA: 0x004D44AA File Offset: 0x004D26AA
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E55D RID: 58717 RVA: 0x004D44B8 File Offset: 0x004D26B8
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
							if (num3 != 18U)
							{
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
							else
							{
								this.ErrorMessage = input.ReadString();
							}
						}
						else
						{
							this.NodeId = input.ReadUInt32();
						}
					}
				}

				// Token: 0x0400A32E RID: 41774
				private static readonly MessageParser<RollDRLGResponse.Types.ErrorLogEntry> _parser = new MessageParser<RollDRLGResponse.Types.ErrorLogEntry>(() => new RollDRLGResponse.Types.ErrorLogEntry());

				// Token: 0x0400A32F RID: 41775
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A330 RID: 41776
				private int _hasBits0;

				// Token: 0x0400A331 RID: 41777
				public const int NodeIdFieldNumber = 1;

				// Token: 0x0400A332 RID: 41778
				private static readonly uint NodeIdDefaultValue = 0U;

				// Token: 0x0400A333 RID: 41779
				private uint nodeId_;

				// Token: 0x0400A334 RID: 41780
				public const int ErrorMessageFieldNumber = 2;

				// Token: 0x0400A335 RID: 41781
				private static readonly string ErrorMessageDefaultValue = "";

				// Token: 0x0400A336 RID: 41782
				private string errorMessage_;
			}

			// Token: 0x02001470 RID: 5232
			public sealed class SeedResult : IMessage<RollDRLGResponse.Types.SeedResult>, IMessage, IEquatable<RollDRLGResponse.Types.SeedResult>, IDeepCloneable<RollDRLGResponse.Types.SeedResult>, IBufferMessage
			{
				// Token: 0x17003A5A RID: 14938
				// (get) Token: 0x0600E55F RID: 58719 RVA: 0x004D454C File Offset: 0x004D274C
				[DebuggerNonUserCode]
				public static MessageParser<RollDRLGResponse.Types.SeedResult> Parser
				{
					get
					{
						return RollDRLGResponse.Types.SeedResult._parser;
					}
				}

				// Token: 0x17003A5B RID: 14939
				// (get) Token: 0x0600E560 RID: 58720 RVA: 0x004D4564 File Offset: 0x004D2764
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return RollDRLGResponse.Descriptor.NestedTypes[2];
					}
				}

				// Token: 0x17003A5C RID: 14940
				// (get) Token: 0x0600E561 RID: 58721 RVA: 0x004D4588 File Offset: 0x004D2788
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return RollDRLGResponse.Types.SeedResult.Descriptor;
					}
				}

				// Token: 0x0600E562 RID: 58722 RVA: 0x004D459F File Offset: 0x004D279F
				[DebuggerNonUserCode]
				public SeedResult()
				{
				}

				// Token: 0x0600E563 RID: 58723 RVA: 0x004D45CC File Offset: 0x004D27CC
				[DebuggerNonUserCode]
				public SeedResult(RollDRLGResponse.Types.SeedResult other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.seed_ = other.seed_;
					this.success_ = other.success_;
					this.tiles_ = other.tiles_.Clone();
					this.errors_ = other.errors_.Clone();
					this.dungeonStates_ = other.dungeonStates_.Clone();
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E564 RID: 58724 RVA: 0x004D464C File Offset: 0x004D284C
				[DebuggerNonUserCode]
				public RollDRLGResponse.Types.SeedResult Clone()
				{
					return new RollDRLGResponse.Types.SeedResult(this);
				}

				// Token: 0x17003A5D RID: 14941
				// (get) Token: 0x0600E565 RID: 58725 RVA: 0x004D4664 File Offset: 0x004D2864
				// (set) Token: 0x0600E566 RID: 58726 RVA: 0x004D4695 File Offset: 0x004D2895
				[DebuggerNonUserCode]
				public int Seed
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int seedDefaultValue;
						if (flag)
						{
							seedDefaultValue = this.seed_;
						}
						else
						{
							seedDefaultValue = RollDRLGResponse.Types.SeedResult.SeedDefaultValue;
						}
						return seedDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.seed_ = value;
					}
				}

				// Token: 0x17003A5E RID: 14942
				// (get) Token: 0x0600E567 RID: 58727 RVA: 0x004D46B0 File Offset: 0x004D28B0
				[DebuggerNonUserCode]
				public bool HasSeed
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E568 RID: 58728 RVA: 0x004D46CD File Offset: 0x004D28CD
				[DebuggerNonUserCode]
				public void ClearSeed()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A5F RID: 14943
				// (get) Token: 0x0600E569 RID: 58729 RVA: 0x004D46E0 File Offset: 0x004D28E0
				// (set) Token: 0x0600E56A RID: 58730 RVA: 0x004D4711 File Offset: 0x004D2911
				[DebuggerNonUserCode]
				public bool Success
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						bool successDefaultValue;
						if (flag)
						{
							successDefaultValue = this.success_;
						}
						else
						{
							successDefaultValue = RollDRLGResponse.Types.SeedResult.SuccessDefaultValue;
						}
						return successDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.success_ = value;
					}
				}

				// Token: 0x17003A60 RID: 14944
				// (get) Token: 0x0600E56B RID: 58731 RVA: 0x004D472C File Offset: 0x004D292C
				[DebuggerNonUserCode]
				public bool HasSuccess
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E56C RID: 58732 RVA: 0x004D4749 File Offset: 0x004D2949
				[DebuggerNonUserCode]
				public void ClearSuccess()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A61 RID: 14945
				// (get) Token: 0x0600E56D RID: 58733 RVA: 0x004D475C File Offset: 0x004D295C
				[DebuggerNonUserCode]
				public RepeatedField<RollDRLGResponse.Types.DRLGTile> Tiles
				{
					get
					{
						return this.tiles_;
					}
				}

				// Token: 0x17003A62 RID: 14946
				// (get) Token: 0x0600E56E RID: 58734 RVA: 0x004D4774 File Offset: 0x004D2974
				[DebuggerNonUserCode]
				public RepeatedField<RollDRLGResponse.Types.ErrorLogEntry> Errors
				{
					get
					{
						return this.errors_;
					}
				}

				// Token: 0x17003A63 RID: 14947
				// (get) Token: 0x0600E56F RID: 58735 RVA: 0x004D478C File Offset: 0x004D298C
				[DebuggerNonUserCode]
				public RepeatedField<uint> DungeonStates
				{
					get
					{
						return this.dungeonStates_;
					}
				}

				// Token: 0x0600E570 RID: 58736 RVA: 0x004D47A4 File Offset: 0x004D29A4
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as RollDRLGResponse.Types.SeedResult);
				}

				// Token: 0x0600E571 RID: 58737 RVA: 0x004D47C4 File Offset: 0x004D29C4
				[DebuggerNonUserCode]
				public bool Equals(RollDRLGResponse.Types.SeedResult other)
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
							bool flag4 = this.Seed != other.Seed;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Success != other.Success;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = !this.tiles_.Equals(other.tiles_);
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = !this.errors_.Equals(other.errors_);
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = !this.dungeonStates_.Equals(other.dungeonStates_);
											flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E572 RID: 58738 RVA: 0x004D4898 File Offset: 0x004D2A98
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasSeed = this.HasSeed;
					if (hasSeed)
					{
						num ^= this.Seed.GetHashCode();
					}
					bool hasSuccess = this.HasSuccess;
					if (hasSuccess)
					{
						num ^= this.Success.GetHashCode();
					}
					num ^= this.tiles_.GetHashCode();
					num ^= this.errors_.GetHashCode();
					num ^= this.dungeonStates_.GetHashCode();
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E573 RID: 58739 RVA: 0x004D4930 File Offset: 0x004D2B30
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E574 RID: 58740 RVA: 0x004D4948 File Offset: 0x004D2B48
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E575 RID: 58741 RVA: 0x004D4954 File Offset: 0x004D2B54
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasSeed = this.HasSeed;
					if (hasSeed)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.Seed);
					}
					bool hasSuccess = this.HasSuccess;
					if (hasSuccess)
					{
						output.WriteRawTag(16);
						output.WriteBool(this.Success);
					}
					this.tiles_.WriteTo(ref output, RollDRLGResponse.Types.SeedResult._repeated_tiles_codec);
					this.errors_.WriteTo(ref output, RollDRLGResponse.Types.SeedResult._repeated_errors_codec);
					this.dungeonStates_.WriteTo(ref output, RollDRLGResponse.Types.SeedResult._repeated_dungeonStates_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E576 RID: 58742 RVA: 0x004D49F8 File Offset: 0x004D2BF8
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasSeed = this.HasSeed;
					if (hasSeed)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.Seed);
					}
					bool hasSuccess = this.HasSuccess;
					if (hasSuccess)
					{
						num += 2;
					}
					num += this.tiles_.CalculateSize(RollDRLGResponse.Types.SeedResult._repeated_tiles_codec);
					num += this.errors_.CalculateSize(RollDRLGResponse.Types.SeedResult._repeated_errors_codec);
					num += this.dungeonStates_.CalculateSize(RollDRLGResponse.Types.SeedResult._repeated_dungeonStates_codec);
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E577 RID: 58743 RVA: 0x004D4A94 File Offset: 0x004D2C94
				[DebuggerNonUserCode]
				public void MergeFrom(RollDRLGResponse.Types.SeedResult other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasSeed = other.HasSeed;
						if (hasSeed)
						{
							this.Seed = other.Seed;
						}
						bool hasSuccess = other.HasSuccess;
						if (hasSuccess)
						{
							this.Success = other.Success;
						}
						this.tiles_.Add(other.tiles_);
						this.errors_.Add(other.errors_);
						this.dungeonStates_.Add(other.dungeonStates_);
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E578 RID: 58744 RVA: 0x004D4B2C File Offset: 0x004D2D2C
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E579 RID: 58745 RVA: 0x004D4B38 File Offset: 0x004D2D38
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 26U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 26U)
									{
										goto IL_0039;
									}
									this.tiles_.AddEntriesFrom(ref input, RollDRLGResponse.Types.SeedResult._repeated_tiles_codec);
								}
								else
								{
									this.Success = input.ReadBool();
								}
							}
							else
							{
								this.Seed = input.ReadInt32();
							}
						}
						else if (num3 != 34U)
						{
							if (num3 != 40U && num3 != 42U)
							{
								goto IL_0039;
							}
							this.dungeonStates_.AddEntriesFrom(ref input, RollDRLGResponse.Types.SeedResult._repeated_dungeonStates_codec);
						}
						else
						{
							this.errors_.AddEntriesFrom(ref input, RollDRLGResponse.Types.SeedResult._repeated_errors_codec);
						}
						continue;
						IL_0039:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A337 RID: 41783
				private static readonly MessageParser<RollDRLGResponse.Types.SeedResult> _parser = new MessageParser<RollDRLGResponse.Types.SeedResult>(() => new RollDRLGResponse.Types.SeedResult());

				// Token: 0x0400A338 RID: 41784
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A339 RID: 41785
				private int _hasBits0;

				// Token: 0x0400A33A RID: 41786
				public const int SeedFieldNumber = 1;

				// Token: 0x0400A33B RID: 41787
				private static readonly int SeedDefaultValue = 0;

				// Token: 0x0400A33C RID: 41788
				private int seed_;

				// Token: 0x0400A33D RID: 41789
				public const int SuccessFieldNumber = 2;

				// Token: 0x0400A33E RID: 41790
				private static readonly bool SuccessDefaultValue = false;

				// Token: 0x0400A33F RID: 41791
				private bool success_;

				// Token: 0x0400A340 RID: 41792
				public const int TilesFieldNumber = 3;

				// Token: 0x0400A341 RID: 41793
				private static readonly FieldCodec<RollDRLGResponse.Types.DRLGTile> _repeated_tiles_codec = FieldCodec.ForMessage<RollDRLGResponse.Types.DRLGTile>(26U, RollDRLGResponse.Types.DRLGTile.Parser);

				// Token: 0x0400A342 RID: 41794
				private readonly RepeatedField<RollDRLGResponse.Types.DRLGTile> tiles_ = new RepeatedField<RollDRLGResponse.Types.DRLGTile>();

				// Token: 0x0400A343 RID: 41795
				public const int ErrorsFieldNumber = 4;

				// Token: 0x0400A344 RID: 41796
				private static readonly FieldCodec<RollDRLGResponse.Types.ErrorLogEntry> _repeated_errors_codec = FieldCodec.ForMessage<RollDRLGResponse.Types.ErrorLogEntry>(34U, RollDRLGResponse.Types.ErrorLogEntry.Parser);

				// Token: 0x0400A345 RID: 41797
				private readonly RepeatedField<RollDRLGResponse.Types.ErrorLogEntry> errors_ = new RepeatedField<RollDRLGResponse.Types.ErrorLogEntry>();

				// Token: 0x0400A346 RID: 41798
				public const int DungeonStatesFieldNumber = 5;

				// Token: 0x0400A347 RID: 41799
				private static readonly FieldCodec<uint> _repeated_dungeonStates_codec = FieldCodec.ForUInt32(40U);

				// Token: 0x0400A348 RID: 41800
				private readonly RepeatedField<uint> dungeonStates_ = new RepeatedField<uint>();
			}
		}
	}
}

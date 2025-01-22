using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E8 RID: 232
	public sealed class PlantMarkersSceneResult : IMessage<PlantMarkersSceneResult>, IMessage, IEquatable<PlantMarkersSceneResult>, IDeepCloneable<PlantMarkersSceneResult>, IBufferMessage
	{
		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000519F0 File Offset: 0x0004FBF0
		[DebuggerNonUserCode]
		public static MessageParser<PlantMarkersSceneResult> Parser
		{
			get
			{
				return PlantMarkersSceneResult._parser;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00051A08 File Offset: 0x0004FC08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[209];
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00051A30 File Offset: 0x0004FC30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlantMarkersSceneResult.Descriptor;
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00051A47 File Offset: 0x0004FC47
		[DebuggerNonUserCode]
		public PlantMarkersSceneResult()
		{
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00051A5C File Offset: 0x0004FC5C
		[DebuggerNonUserCode]
		public PlantMarkersSceneResult(PlantMarkersSceneResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sceneIndex_ = other.sceneIndex_;
			this.snoMarkerset_ = other.snoMarkerset_;
			this.points_ = other.points_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00051AB8 File Offset: 0x0004FCB8
		[DebuggerNonUserCode]
		public PlantMarkersSceneResult Clone()
		{
			return new PlantMarkersSceneResult(this);
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00051AD0 File Offset: 0x0004FCD0
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00051B01 File Offset: 0x0004FD01
		[DebuggerNonUserCode]
		public int SceneIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int sceneIndexDefaultValue;
				if (flag)
				{
					sceneIndexDefaultValue = this.sceneIndex_;
				}
				else
				{
					sceneIndexDefaultValue = PlantMarkersSceneResult.SceneIndexDefaultValue;
				}
				return sceneIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sceneIndex_ = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00051B1C File Offset: 0x0004FD1C
		[DebuggerNonUserCode]
		public bool HasSceneIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00051B39 File Offset: 0x0004FD39
		[DebuggerNonUserCode]
		public void ClearSceneIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00051B4C File Offset: 0x0004FD4C
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x00051B7D File Offset: 0x0004FD7D
		[DebuggerNonUserCode]
		public int SnoMarkerset
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoMarkersetDefaultValue;
				if (flag)
				{
					snoMarkersetDefaultValue = this.snoMarkerset_;
				}
				else
				{
					snoMarkersetDefaultValue = PlantMarkersSceneResult.SnoMarkersetDefaultValue;
				}
				return snoMarkersetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoMarkerset_ = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x00051B98 File Offset: 0x0004FD98
		[DebuggerNonUserCode]
		public bool HasSnoMarkerset
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00051BB5 File Offset: 0x0004FDB5
		[DebuggerNonUserCode]
		public void ClearSnoMarkerset()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00051BC8 File Offset: 0x0004FDC8
		[DebuggerNonUserCode]
		public RepeatedField<Vector3> Points
		{
			get
			{
				return this.points_;
			}
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00051BE0 File Offset: 0x0004FDE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlantMarkersSceneResult);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00051C00 File Offset: 0x0004FE00
		[DebuggerNonUserCode]
		public bool Equals(PlantMarkersSceneResult other)
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
					bool flag4 = this.SceneIndex != other.SceneIndex;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoMarkerset != other.SnoMarkerset;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.points_.Equals(other.points_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00051C90 File Offset: 0x0004FE90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSceneIndex = this.HasSceneIndex;
			if (hasSceneIndex)
			{
				num ^= this.SceneIndex.GetHashCode();
			}
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num ^= this.SnoMarkerset.GetHashCode();
			}
			num ^= this.points_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00051D0C File Offset: 0x0004FF0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00051D24 File Offset: 0x0004FF24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00051D30 File Offset: 0x0004FF30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSceneIndex = this.HasSceneIndex;
			if (hasSceneIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SceneIndex);
			}
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoMarkerset);
			}
			this.points_.WriteTo(ref output, PlantMarkersSceneResult._repeated_points_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00051DB0 File Offset: 0x0004FFB0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSceneIndex = this.HasSceneIndex;
			if (hasSceneIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneIndex);
			}
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoMarkerset);
			}
			num += this.points_.CalculateSize(PlantMarkersSceneResult._repeated_points_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00051E30 File Offset: 0x00050030
		[DebuggerNonUserCode]
		public void MergeFrom(PlantMarkersSceneResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSceneIndex = other.HasSceneIndex;
				if (hasSceneIndex)
				{
					this.SceneIndex = other.SceneIndex;
				}
				bool hasSnoMarkerset = other.HasSnoMarkerset;
				if (hasSnoMarkerset)
				{
					this.SnoMarkerset = other.SnoMarkerset;
				}
				this.points_.Add(other.points_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00051EA4 File Offset: 0x000500A4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00051EB0 File Offset: 0x000500B0
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
							this.points_.AddEntriesFrom(ref input, PlantMarkersSceneResult._repeated_points_codec);
						}
					}
					else
					{
						this.SnoMarkerset = input.ReadInt32();
					}
				}
				else
				{
					this.SceneIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000927 RID: 2343
		private static readonly MessageParser<PlantMarkersSceneResult> _parser = new MessageParser<PlantMarkersSceneResult>(() => new PlantMarkersSceneResult());

		// Token: 0x04000928 RID: 2344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000929 RID: 2345
		private int _hasBits0;

		// Token: 0x0400092A RID: 2346
		public const int SceneIndexFieldNumber = 1;

		// Token: 0x0400092B RID: 2347
		private static readonly int SceneIndexDefaultValue = 0;

		// Token: 0x0400092C RID: 2348
		private int sceneIndex_;

		// Token: 0x0400092D RID: 2349
		public const int SnoMarkersetFieldNumber = 2;

		// Token: 0x0400092E RID: 2350
		private static readonly int SnoMarkersetDefaultValue = 0;

		// Token: 0x0400092F RID: 2351
		private int snoMarkerset_;

		// Token: 0x04000930 RID: 2352
		public const int PointsFieldNumber = 3;

		// Token: 0x04000931 RID: 2353
		private static readonly FieldCodec<Vector3> _repeated_points_codec = FieldCodec.ForMessage<Vector3>(26U, Vector3.Parser);

		// Token: 0x04000932 RID: 2354
		private readonly RepeatedField<Vector3> points_ = new RepeatedField<Vector3>();
	}
}

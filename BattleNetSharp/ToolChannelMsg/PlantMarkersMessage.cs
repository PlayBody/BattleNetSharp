using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E7 RID: 231
	public sealed class PlantMarkersMessage : IMessage<PlantMarkersMessage>, IMessage, IEquatable<PlantMarkersMessage>, IDeepCloneable<PlantMarkersMessage>, IBufferMessage
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00051248 File Offset: 0x0004F448
		[DebuggerNonUserCode]
		public static MessageParser<PlantMarkersMessage> Parser
		{
			get
			{
				return PlantMarkersMessage._parser;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x00051260 File Offset: 0x0004F460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[208];
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00051288 File Offset: 0x0004F488
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlantMarkersMessage.Descriptor;
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0005129F File Offset: 0x0004F49F
		[DebuggerNonUserCode]
		public PlantMarkersMessage()
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000512C0 File Offset: 0x0004F4C0
		[DebuggerNonUserCode]
		public PlantMarkersMessage(PlantMarkersMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoMarkerset_ = other.snoMarkerset_.Clone();
			this.density_ = other.density_;
			this.sceneIndex_ = other.sceneIndex_.Clone();
			this.fillType_ = other.fillType_;
			this.sceneBoundaryBuffer_ = other.sceneBoundaryBuffer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00051338 File Offset: 0x0004F538
		[DebuggerNonUserCode]
		public PlantMarkersMessage Clone()
		{
			return new PlantMarkersMessage(this);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x00051350 File Offset: 0x0004F550
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoMarkerset
		{
			get
			{
				return this.snoMarkerset_;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00051368 File Offset: 0x0004F568
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00051399 File Offset: 0x0004F599
		[DebuggerNonUserCode]
		public float Density
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float densityDefaultValue;
				if (flag)
				{
					densityDefaultValue = this.density_;
				}
				else
				{
					densityDefaultValue = PlantMarkersMessage.DensityDefaultValue;
				}
				return densityDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.density_ = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x000513B4 File Offset: 0x0004F5B4
		[DebuggerNonUserCode]
		public bool HasDensity
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000513D1 File Offset: 0x0004F5D1
		[DebuggerNonUserCode]
		public void ClearDensity()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x000513E4 File Offset: 0x0004F5E4
		[DebuggerNonUserCode]
		public RepeatedField<int> SceneIndex
		{
			get
			{
				return this.sceneIndex_;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x000513FC File Offset: 0x0004F5FC
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x0005142D File Offset: 0x0004F62D
		[DebuggerNonUserCode]
		public int FillType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int fillTypeDefaultValue;
				if (flag)
				{
					fillTypeDefaultValue = this.fillType_;
				}
				else
				{
					fillTypeDefaultValue = PlantMarkersMessage.FillTypeDefaultValue;
				}
				return fillTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fillType_ = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00051448 File Offset: 0x0004F648
		[DebuggerNonUserCode]
		public bool HasFillType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00051465 File Offset: 0x0004F665
		[DebuggerNonUserCode]
		public void ClearFillType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00051478 File Offset: 0x0004F678
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x000514A9 File Offset: 0x0004F6A9
		[DebuggerNonUserCode]
		public float SceneBoundaryBuffer
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float sceneBoundaryBufferDefaultValue;
				if (flag)
				{
					sceneBoundaryBufferDefaultValue = this.sceneBoundaryBuffer_;
				}
				else
				{
					sceneBoundaryBufferDefaultValue = PlantMarkersMessage.SceneBoundaryBufferDefaultValue;
				}
				return sceneBoundaryBufferDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.sceneBoundaryBuffer_ = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000514C4 File Offset: 0x0004F6C4
		[DebuggerNonUserCode]
		public bool HasSceneBoundaryBuffer
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000514E1 File Offset: 0x0004F6E1
		[DebuggerNonUserCode]
		public void ClearSceneBoundaryBuffer()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000514F4 File Offset: 0x0004F6F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlantMarkersMessage);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00051514 File Offset: 0x0004F714
		[DebuggerNonUserCode]
		public bool Equals(PlantMarkersMessage other)
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
					bool flag4 = !this.snoMarkerset_.Equals(other.snoMarkerset_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Density, other.Density);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.sceneIndex_.Equals(other.sceneIndex_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FillType != other.FillType;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SceneBoundaryBuffer, other.SceneBoundaryBuffer);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000515F8 File Offset: 0x0004F7F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoMarkerset_.GetHashCode();
			bool hasDensity = this.HasDensity;
			if (hasDensity)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Density);
			}
			num ^= this.sceneIndex_.GetHashCode();
			bool hasFillType = this.HasFillType;
			if (hasFillType)
			{
				num ^= this.FillType.GetHashCode();
			}
			bool hasSceneBoundaryBuffer = this.HasSceneBoundaryBuffer;
			if (hasSceneBoundaryBuffer)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SceneBoundaryBuffer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000516A4 File Offset: 0x0004F8A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000516BC File Offset: 0x0004F8BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000516C8 File Offset: 0x0004F8C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoMarkerset_.WriteTo(ref output, PlantMarkersMessage._repeated_snoMarkerset_codec);
			bool hasDensity = this.HasDensity;
			if (hasDensity)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Density);
			}
			this.sceneIndex_.WriteTo(ref output, PlantMarkersMessage._repeated_sceneIndex_codec);
			bool hasFillType = this.HasFillType;
			if (hasFillType)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FillType);
			}
			bool hasSceneBoundaryBuffer = this.HasSceneBoundaryBuffer;
			if (hasSceneBoundaryBuffer)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.SceneBoundaryBuffer);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0005177C File Offset: 0x0004F97C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoMarkerset_.CalculateSize(PlantMarkersMessage._repeated_snoMarkerset_codec);
			bool hasDensity = this.HasDensity;
			if (hasDensity)
			{
				num += 5;
			}
			num += this.sceneIndex_.CalculateSize(PlantMarkersMessage._repeated_sceneIndex_codec);
			bool hasFillType = this.HasFillType;
			if (hasFillType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FillType);
			}
			bool hasSceneBoundaryBuffer = this.HasSceneBoundaryBuffer;
			if (hasSceneBoundaryBuffer)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00051814 File Offset: 0x0004FA14
		[DebuggerNonUserCode]
		public void MergeFrom(PlantMarkersMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoMarkerset_.Add(other.snoMarkerset_);
				bool hasDensity = other.HasDensity;
				if (hasDensity)
				{
					this.Density = other.Density;
				}
				this.sceneIndex_.Add(other.sceneIndex_);
				bool hasFillType = other.HasFillType;
				if (hasFillType)
				{
					this.FillType = other.FillType;
				}
				bool hasSceneBoundaryBuffer = other.HasSceneBoundaryBuffer;
				if (hasSceneBoundaryBuffer)
				{
					this.SceneBoundaryBuffer = other.SceneBoundaryBuffer;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000518B6 File Offset: 0x0004FAB6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000518C4 File Offset: 0x0004FAC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 21U)
				{
					if (num3 != 8U && num3 != 10U)
					{
						if (num3 != 21U)
						{
							goto IL_0045;
						}
						this.Density = input.ReadFloat();
					}
					else
					{
						this.snoMarkerset_.AddEntriesFrom(ref input, PlantMarkersMessage._repeated_snoMarkerset_codec);
					}
				}
				else if (num3 <= 26U)
				{
					if (num3 != 24U && num3 != 26U)
					{
						goto IL_0045;
					}
					this.sceneIndex_.AddEntriesFrom(ref input, PlantMarkersMessage._repeated_sceneIndex_codec);
				}
				else if (num3 != 32U)
				{
					if (num3 != 45U)
					{
						goto IL_0045;
					}
					this.SceneBoundaryBuffer = input.ReadFloat();
				}
				else
				{
					this.FillType = input.ReadInt32();
				}
				continue;
				IL_0045:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000915 RID: 2325
		private static readonly MessageParser<PlantMarkersMessage> _parser = new MessageParser<PlantMarkersMessage>(() => new PlantMarkersMessage());

		// Token: 0x04000916 RID: 2326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000917 RID: 2327
		private int _hasBits0;

		// Token: 0x04000918 RID: 2328
		public const int SnoMarkersetFieldNumber = 1;

		// Token: 0x04000919 RID: 2329
		private static readonly FieldCodec<int> _repeated_snoMarkerset_codec = FieldCodec.ForInt32(8U);

		// Token: 0x0400091A RID: 2330
		private readonly RepeatedField<int> snoMarkerset_ = new RepeatedField<int>();

		// Token: 0x0400091B RID: 2331
		public const int DensityFieldNumber = 2;

		// Token: 0x0400091C RID: 2332
		private static readonly float DensityDefaultValue = 0f;

		// Token: 0x0400091D RID: 2333
		private float density_;

		// Token: 0x0400091E RID: 2334
		public const int SceneIndexFieldNumber = 3;

		// Token: 0x0400091F RID: 2335
		private static readonly FieldCodec<int> _repeated_sceneIndex_codec = FieldCodec.ForInt32(24U);

		// Token: 0x04000920 RID: 2336
		private readonly RepeatedField<int> sceneIndex_ = new RepeatedField<int>();

		// Token: 0x04000921 RID: 2337
		public const int FillTypeFieldNumber = 4;

		// Token: 0x04000922 RID: 2338
		private static readonly int FillTypeDefaultValue = 0;

		// Token: 0x04000923 RID: 2339
		private int fillType_;

		// Token: 0x04000924 RID: 2340
		public const int SceneBoundaryBufferFieldNumber = 5;

		// Token: 0x04000925 RID: 2341
		private static readonly float SceneBoundaryBufferDefaultValue = 0f;

		// Token: 0x04000926 RID: 2342
		private float sceneBoundaryBuffer_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E4 RID: 228
	public sealed class AnimChannelData : IMessage<AnimChannelData>, IMessage, IEquatable<AnimChannelData>, IDeepCloneable<AnimChannelData>, IBufferMessage
	{
		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x000505E8 File Offset: 0x0004E7E8
		[DebuggerNonUserCode]
		public static MessageParser<AnimChannelData> Parser
		{
			get
			{
				return AnimChannelData._parser;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x00050600 File Offset: 0x0004E800
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[205];
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00050628 File Offset: 0x0004E828
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimChannelData.Descriptor;
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0005063F File Offset: 0x0004E83F
		[DebuggerNonUserCode]
		public AnimChannelData()
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x0005064C File Offset: 0x0004E84C
		[DebuggerNonUserCode]
		public AnimChannelData(AnimChannelData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.animPlaying_ = other.animPlaying_;
			this.currentBlendFactor_ = other.currentBlendFactor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000506A4 File Offset: 0x0004E8A4
		[DebuggerNonUserCode]
		public AnimChannelData Clone()
		{
			return new AnimChannelData(this);
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x000506BC File Offset: 0x0004E8BC
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x000506ED File Offset: 0x0004E8ED
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = AnimChannelData.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00050708 File Offset: 0x0004E908
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00050725 File Offset: 0x0004E925
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00050738 File Offset: 0x0004E938
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x00050769 File Offset: 0x0004E969
		[DebuggerNonUserCode]
		public bool AnimPlaying
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool animPlayingDefaultValue;
				if (flag)
				{
					animPlayingDefaultValue = this.animPlaying_;
				}
				else
				{
					animPlayingDefaultValue = AnimChannelData.AnimPlayingDefaultValue;
				}
				return animPlayingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.animPlaying_ = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00050784 File Offset: 0x0004E984
		[DebuggerNonUserCode]
		public bool HasAnimPlaying
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000507A1 File Offset: 0x0004E9A1
		[DebuggerNonUserCode]
		public void ClearAnimPlaying()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x000507B4 File Offset: 0x0004E9B4
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x000507E5 File Offset: 0x0004E9E5
		[DebuggerNonUserCode]
		public float CurrentBlendFactor
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				float currentBlendFactorDefaultValue;
				if (flag)
				{
					currentBlendFactorDefaultValue = this.currentBlendFactor_;
				}
				else
				{
					currentBlendFactorDefaultValue = AnimChannelData.CurrentBlendFactorDefaultValue;
				}
				return currentBlendFactorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.currentBlendFactor_ = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00050800 File Offset: 0x0004EA00
		[DebuggerNonUserCode]
		public bool HasCurrentBlendFactor
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0005081D File Offset: 0x0004EA1D
		[DebuggerNonUserCode]
		public void ClearCurrentBlendFactor()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00050830 File Offset: 0x0004EA30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimChannelData);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00050850 File Offset: 0x0004EA50
		[DebuggerNonUserCode]
		public bool Equals(AnimChannelData other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AnimPlaying != other.AnimPlaying;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CurrentBlendFactor, other.CurrentBlendFactor);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000508E4 File Offset: 0x0004EAE4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasAnimPlaying = this.HasAnimPlaying;
			if (hasAnimPlaying)
			{
				num ^= this.AnimPlaying.GetHashCode();
			}
			bool hasCurrentBlendFactor = this.HasCurrentBlendFactor;
			if (hasCurrentBlendFactor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CurrentBlendFactor);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00050970 File Offset: 0x0004EB70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00050988 File Offset: 0x0004EB88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00050994 File Offset: 0x0004EB94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasAnimPlaying = this.HasAnimPlaying;
			if (hasAnimPlaying)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AnimPlaying);
			}
			bool hasCurrentBlendFactor = this.HasCurrentBlendFactor;
			if (hasCurrentBlendFactor)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.CurrentBlendFactor);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00050A24 File Offset: 0x0004EC24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasAnimPlaying = this.HasAnimPlaying;
			if (hasAnimPlaying)
			{
				num += 2;
			}
			bool hasCurrentBlendFactor = this.HasCurrentBlendFactor;
			if (hasCurrentBlendFactor)
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

		// Token: 0x06001632 RID: 5682 RVA: 0x00050A98 File Offset: 0x0004EC98
		[DebuggerNonUserCode]
		public void MergeFrom(AnimChannelData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasAnimPlaying = other.HasAnimPlaying;
				if (hasAnimPlaying)
				{
					this.AnimPlaying = other.AnimPlaying;
				}
				bool hasCurrentBlendFactor = other.HasCurrentBlendFactor;
				if (hasCurrentBlendFactor)
				{
					this.CurrentBlendFactor = other.CurrentBlendFactor;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00050B13 File Offset: 0x0004ED13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00050B20 File Offset: 0x0004ED20
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
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrentBlendFactor = input.ReadFloat();
						}
					}
					else
					{
						this.AnimPlaying = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040008FE RID: 2302
		private static readonly MessageParser<AnimChannelData> _parser = new MessageParser<AnimChannelData>(() => new AnimChannelData());

		// Token: 0x040008FF RID: 2303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000900 RID: 2304
		private int _hasBits0;

		// Token: 0x04000901 RID: 2305
		public const int IdFieldNumber = 1;

		// Token: 0x04000902 RID: 2306
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000903 RID: 2307
		private uint id_;

		// Token: 0x04000904 RID: 2308
		public const int AnimPlayingFieldNumber = 2;

		// Token: 0x04000905 RID: 2309
		private static readonly bool AnimPlayingDefaultValue = false;

		// Token: 0x04000906 RID: 2310
		private bool animPlaying_;

		// Token: 0x04000907 RID: 2311
		public const int CurrentBlendFactorFieldNumber = 3;

		// Token: 0x04000908 RID: 2312
		private static readonly float CurrentBlendFactorDefaultValue = 0f;

		// Token: 0x04000909 RID: 2313
		private float currentBlendFactor_;
	}
}

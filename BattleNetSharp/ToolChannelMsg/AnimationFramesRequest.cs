using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CF RID: 207
	public sealed class AnimationFramesRequest : IMessage<AnimationFramesRequest>, IMessage, IEquatable<AnimationFramesRequest>, IDeepCloneable<AnimationFramesRequest>, IBufferMessage
	{
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000482EC File Offset: 0x000464EC
		[DebuggerNonUserCode]
		public static MessageParser<AnimationFramesRequest> Parser
		{
			get
			{
				return AnimationFramesRequest._parser;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00048304 File Offset: 0x00046504
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[184];
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0004832C File Offset: 0x0004652C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationFramesRequest.Descriptor;
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00048343 File Offset: 0x00046543
		[DebuggerNonUserCode]
		public AnimationFramesRequest()
		{
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00048350 File Offset: 0x00046550
		[DebuggerNonUserCode]
		public AnimationFramesRequest(AnimationFramesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoAnimation_ = other.snoAnimation_;
			this.permutation_ = other.permutation_;
			this.boneName_ = other.boneName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000483A8 File Offset: 0x000465A8
		[DebuggerNonUserCode]
		public AnimationFramesRequest Clone()
		{
			return new AnimationFramesRequest(this);
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000483C0 File Offset: 0x000465C0
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x000483F1 File Offset: 0x000465F1
		[DebuggerNonUserCode]
		public int SnoAnimation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoAnimationDefaultValue;
				if (flag)
				{
					snoAnimationDefaultValue = this.snoAnimation_;
				}
				else
				{
					snoAnimationDefaultValue = AnimationFramesRequest.SnoAnimationDefaultValue;
				}
				return snoAnimationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoAnimation_ = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0004840C File Offset: 0x0004660C
		[DebuggerNonUserCode]
		public bool HasSnoAnimation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00048429 File Offset: 0x00046629
		[DebuggerNonUserCode]
		public void ClearSnoAnimation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0004843C File Offset: 0x0004663C
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0004846D File Offset: 0x0004666D
		[DebuggerNonUserCode]
		public int Permutation
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int permutationDefaultValue;
				if (flag)
				{
					permutationDefaultValue = this.permutation_;
				}
				else
				{
					permutationDefaultValue = AnimationFramesRequest.PermutationDefaultValue;
				}
				return permutationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.permutation_ = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00048488 File Offset: 0x00046688
		[DebuggerNonUserCode]
		public bool HasPermutation
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000484A5 File Offset: 0x000466A5
		[DebuggerNonUserCode]
		public void ClearPermutation()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000484B8 File Offset: 0x000466B8
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000484D9 File Offset: 0x000466D9
		[DebuggerNonUserCode]
		public string BoneName
		{
			get
			{
				return this.boneName_ ?? AnimationFramesRequest.BoneNameDefaultValue;
			}
			set
			{
				this.boneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000484F0 File Offset: 0x000466F0
		[DebuggerNonUserCode]
		public bool HasBoneName
		{
			get
			{
				return this.boneName_ != null;
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0004850B File Offset: 0x0004670B
		[DebuggerNonUserCode]
		public void ClearBoneName()
		{
			this.boneName_ = null;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00048518 File Offset: 0x00046718
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationFramesRequest);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00048538 File Offset: 0x00046738
		[DebuggerNonUserCode]
		public bool Equals(AnimationFramesRequest other)
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
					bool flag4 = this.SnoAnimation != other.SnoAnimation;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Permutation != other.Permutation;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.BoneName != other.BoneName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000485C4 File Offset: 0x000467C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoAnimation = this.HasSnoAnimation;
			if (hasSnoAnimation)
			{
				num ^= this.SnoAnimation.GetHashCode();
			}
			bool hasPermutation = this.HasPermutation;
			if (hasPermutation)
			{
				num ^= this.Permutation.GetHashCode();
			}
			bool hasBoneName = this.HasBoneName;
			if (hasBoneName)
			{
				num ^= this.BoneName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0004864C File Offset: 0x0004684C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00048664 File Offset: 0x00046864
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00048670 File Offset: 0x00046870
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoAnimation = this.HasSnoAnimation;
			if (hasSnoAnimation)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoAnimation);
			}
			bool hasPermutation = this.HasPermutation;
			if (hasPermutation)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Permutation);
			}
			bool hasBoneName = this.HasBoneName;
			if (hasBoneName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.BoneName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00048700 File Offset: 0x00046900
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoAnimation = this.HasSnoAnimation;
			if (hasSnoAnimation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoAnimation);
			}
			bool hasPermutation = this.HasPermutation;
			if (hasPermutation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Permutation);
			}
			bool hasBoneName = this.HasBoneName;
			if (hasBoneName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BoneName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0004878C File Offset: 0x0004698C
		[DebuggerNonUserCode]
		public void MergeFrom(AnimationFramesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoAnimation = other.HasSnoAnimation;
				if (hasSnoAnimation)
				{
					this.SnoAnimation = other.SnoAnimation;
				}
				bool hasPermutation = other.HasPermutation;
				if (hasPermutation)
				{
					this.Permutation = other.Permutation;
				}
				bool hasBoneName = other.HasBoneName;
				if (hasBoneName)
				{
					this.BoneName = other.BoneName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00048807 File Offset: 0x00046A07
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00048814 File Offset: 0x00046A14
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
							this.BoneName = input.ReadString();
						}
					}
					else
					{
						this.Permutation = input.ReadInt32();
					}
				}
				else
				{
					this.SnoAnimation = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000802 RID: 2050
		private static readonly MessageParser<AnimationFramesRequest> _parser = new MessageParser<AnimationFramesRequest>(() => new AnimationFramesRequest());

		// Token: 0x04000803 RID: 2051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000804 RID: 2052
		private int _hasBits0;

		// Token: 0x04000805 RID: 2053
		public const int SnoAnimationFieldNumber = 1;

		// Token: 0x04000806 RID: 2054
		private static readonly int SnoAnimationDefaultValue = 0;

		// Token: 0x04000807 RID: 2055
		private int snoAnimation_;

		// Token: 0x04000808 RID: 2056
		public const int PermutationFieldNumber = 2;

		// Token: 0x04000809 RID: 2057
		private static readonly int PermutationDefaultValue = 0;

		// Token: 0x0400080A RID: 2058
		private int permutation_;

		// Token: 0x0400080B RID: 2059
		public const int BoneNameFieldNumber = 3;

		// Token: 0x0400080C RID: 2060
		private static readonly string BoneNameDefaultValue = "";

		// Token: 0x0400080D RID: 2061
		private string boneName_;
	}
}

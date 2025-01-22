using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006F RID: 111
	public sealed class PlayQuestRequest : IMessage<PlayQuestRequest>, IMessage, IEquatable<PlayQuestRequest>, IDeepCloneable<PlayQuestRequest>, IBufferMessage
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00026414 File Offset: 0x00024614
		[DebuggerNonUserCode]
		public static MessageParser<PlayQuestRequest> Parser
		{
			get
			{
				return PlayQuestRequest._parser;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002642C File Offset: 0x0002462C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[88];
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00026450 File Offset: 0x00024650
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayQuestRequest.Descriptor;
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00026467 File Offset: 0x00024667
		[DebuggerNonUserCode]
		public PlayQuestRequest()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00026471 File Offset: 0x00024671
		[DebuggerNonUserCode]
		public PlayQuestRequest(PlayQuestRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoQuest_ = other.snoQuest_;
			this.snoSubzone_ = other.snoSubzone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000264B0 File Offset: 0x000246B0
		[DebuggerNonUserCode]
		public PlayQuestRequest Clone()
		{
			return new PlayQuestRequest(this);
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000264C8 File Offset: 0x000246C8
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000264F9 File Offset: 0x000246F9
		[DebuggerNonUserCode]
		public int SnoQuest
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoQuestDefaultValue;
				if (flag)
				{
					snoQuestDefaultValue = this.snoQuest_;
				}
				else
				{
					snoQuestDefaultValue = PlayQuestRequest.SnoQuestDefaultValue;
				}
				return snoQuestDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoQuest_ = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00026514 File Offset: 0x00024714
		[DebuggerNonUserCode]
		public bool HasSnoQuest
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00026531 File Offset: 0x00024731
		[DebuggerNonUserCode]
		public void ClearSnoQuest()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00026544 File Offset: 0x00024744
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00026575 File Offset: 0x00024775
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = PlayQuestRequest.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00026590 File Offset: 0x00024790
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000265AD File Offset: 0x000247AD
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000265C0 File Offset: 0x000247C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayQuestRequest);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000265E0 File Offset: 0x000247E0
		[DebuggerNonUserCode]
		public bool Equals(PlayQuestRequest other)
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
					bool flag4 = this.SnoQuest != other.SnoQuest;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoSubzone != other.SnoSubzone;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00026654 File Offset: 0x00024854
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num ^= this.SnoQuest.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000266C0 File Offset: 0x000248C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000266D8 File Offset: 0x000248D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000266E4 File Offset: 0x000248E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoQuest);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00026754 File Offset: 0x00024954
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoQuest = this.HasSnoQuest;
			if (hasSnoQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoQuest);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000267C0 File Offset: 0x000249C0
		[DebuggerNonUserCode]
		public void MergeFrom(PlayQuestRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoQuest = other.HasSnoQuest;
				if (hasSnoQuest)
				{
					this.SnoQuest = other.SnoQuest;
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00026822 File Offset: 0x00024A22
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00026830 File Offset: 0x00024A30
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
						this.SnoSubzone = input.ReadInt32();
					}
				}
				else
				{
					this.SnoQuest = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003D5 RID: 981
		private static readonly MessageParser<PlayQuestRequest> _parser = new MessageParser<PlayQuestRequest>(() => new PlayQuestRequest());

		// Token: 0x040003D6 RID: 982
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003D7 RID: 983
		private int _hasBits0;

		// Token: 0x040003D8 RID: 984
		public const int SnoQuestFieldNumber = 1;

		// Token: 0x040003D9 RID: 985
		private static readonly int SnoQuestDefaultValue = 0;

		// Token: 0x040003DA RID: 986
		private int snoQuest_;

		// Token: 0x040003DB RID: 987
		public const int SnoSubzoneFieldNumber = 2;

		// Token: 0x040003DC RID: 988
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x040003DD RID: 989
		private int snoSubzone_;
	}
}

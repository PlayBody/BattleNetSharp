using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006B RID: 107
	public sealed class DiffSnoRequest : IMessage<DiffSnoRequest>, IMessage, IEquatable<DiffSnoRequest>, IDeepCloneable<DiffSnoRequest>, IBufferMessage
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00025028 File Offset: 0x00023228
		[DebuggerNonUserCode]
		public static MessageParser<DiffSnoRequest> Parser
		{
			get
			{
				return DiffSnoRequest._parser;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00025040 File Offset: 0x00023240
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[84];
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00025064 File Offset: 0x00023264
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DiffSnoRequest.Descriptor;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0002507B File Offset: 0x0002327B
		[DebuggerNonUserCode]
		public DiffSnoRequest()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00025088 File Offset: 0x00023288
		[DebuggerNonUserCode]
		public DiffSnoRequest(DiffSnoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.changelistID1_ = other.changelistID1_;
			this.changelistID2_ = other.changelistID2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000250EC File Offset: 0x000232EC
		[DebuggerNonUserCode]
		public DiffSnoRequest Clone()
		{
			return new DiffSnoRequest(this);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00025104 File Offset: 0x00023304
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00025135 File Offset: 0x00023335
		[DebuggerNonUserCode]
		public int SnoGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoGroupDefaultValue;
				if (flag)
				{
					snoGroupDefaultValue = this.snoGroup_;
				}
				else
				{
					snoGroupDefaultValue = DiffSnoRequest.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00025150 File Offset: 0x00023350
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0002516D File Offset: 0x0002336D
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00025180 File Offset: 0x00023380
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000251B1 File Offset: 0x000233B1
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = DiffSnoRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x000251CC File Offset: 0x000233CC
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000251E9 File Offset: 0x000233E9
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000251FC File Offset: 0x000233FC
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0002522D File Offset: 0x0002342D
		[DebuggerNonUserCode]
		public int ChangelistID1
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int changelistID1DefaultValue;
				if (flag)
				{
					changelistID1DefaultValue = this.changelistID1_;
				}
				else
				{
					changelistID1DefaultValue = DiffSnoRequest.ChangelistID1DefaultValue;
				}
				return changelistID1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.changelistID1_ = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00025248 File Offset: 0x00023448
		[DebuggerNonUserCode]
		public bool HasChangelistID1
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00025265 File Offset: 0x00023465
		[DebuggerNonUserCode]
		public void ClearChangelistID1()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00025278 File Offset: 0x00023478
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000252A9 File Offset: 0x000234A9
		[DebuggerNonUserCode]
		public int ChangelistID2
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int changelistID2DefaultValue;
				if (flag)
				{
					changelistID2DefaultValue = this.changelistID2_;
				}
				else
				{
					changelistID2DefaultValue = DiffSnoRequest.ChangelistID2DefaultValue;
				}
				return changelistID2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.changelistID2_ = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000252C4 File Offset: 0x000234C4
		[DebuggerNonUserCode]
		public bool HasChangelistID2
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000252E1 File Offset: 0x000234E1
		[DebuggerNonUserCode]
		public void ClearChangelistID2()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000252F4 File Offset: 0x000234F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DiffSnoRequest);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00025314 File Offset: 0x00023514
		[DebuggerNonUserCode]
		public bool Equals(DiffSnoRequest other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ChangelistID1 != other.ChangelistID1;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ChangelistID2 != other.ChangelistID2;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000253C0 File Offset: 0x000235C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num ^= this.SnoGroup.GetHashCode();
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasChangelistID = this.HasChangelistID1;
			if (hasChangelistID)
			{
				num ^= this.ChangelistID1.GetHashCode();
			}
			bool hasChangelistID2 = this.HasChangelistID2;
			if (hasChangelistID2)
			{
				num ^= this.ChangelistID2.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00025468 File Offset: 0x00023668
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00025480 File Offset: 0x00023680
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0002548C File Offset: 0x0002368C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasChangelistID = this.HasChangelistID1;
			if (hasChangelistID)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChangelistID1);
			}
			bool hasChangelistID2 = this.HasChangelistID2;
			if (hasChangelistID2)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChangelistID2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00025540 File Offset: 0x00023740
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasChangelistID = this.HasChangelistID1;
			if (hasChangelistID)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangelistID1);
			}
			bool hasChangelistID2 = this.HasChangelistID2;
			if (hasChangelistID2)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangelistID2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000255E8 File Offset: 0x000237E8
		[DebuggerNonUserCode]
		public void MergeFrom(DiffSnoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoGroup = other.HasSnoGroup;
				if (hasSnoGroup)
				{
					this.SnoGroup = other.SnoGroup;
				}
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasChangelistID = other.HasChangelistID1;
				if (hasChangelistID)
				{
					this.ChangelistID1 = other.ChangelistID1;
				}
				bool hasChangelistID2 = other.HasChangelistID2;
				if (hasChangelistID2)
				{
					this.ChangelistID2 = other.ChangelistID2;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002567E File Offset: 0x0002387E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002568C File Offset: 0x0002388C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.SnoHandle = input.ReadInt32();
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.ChangelistID2 = input.ReadInt32();
				}
				else
				{
					this.ChangelistID1 = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040003B0 RID: 944
		private static readonly MessageParser<DiffSnoRequest> _parser = new MessageParser<DiffSnoRequest>(() => new DiffSnoRequest());

		// Token: 0x040003B1 RID: 945
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003B2 RID: 946
		private int _hasBits0;

		// Token: 0x040003B3 RID: 947
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040003B4 RID: 948
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040003B5 RID: 949
		private int snoGroup_;

		// Token: 0x040003B6 RID: 950
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040003B7 RID: 951
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040003B8 RID: 952
		private int snoHandle_;

		// Token: 0x040003B9 RID: 953
		public const int ChangelistID1FieldNumber = 3;

		// Token: 0x040003BA RID: 954
		private static readonly int ChangelistID1DefaultValue = 0;

		// Token: 0x040003BB RID: 955
		private int changelistID1_;

		// Token: 0x040003BC RID: 956
		public const int ChangelistID2FieldNumber = 4;

		// Token: 0x040003BD RID: 957
		private static readonly int ChangelistID2DefaultValue = 0;

		// Token: 0x040003BE RID: 958
		private int changelistID2_;
	}
}

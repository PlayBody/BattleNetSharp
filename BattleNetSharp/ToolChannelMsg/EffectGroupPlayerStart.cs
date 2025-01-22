using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F2 RID: 242
	public sealed class EffectGroupPlayerStart : IMessage<EffectGroupPlayerStart>, IMessage, IEquatable<EffectGroupPlayerStart>, IDeepCloneable<EffectGroupPlayerStart>, IBufferMessage
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0005457C File Offset: 0x0005277C
		[DebuggerNonUserCode]
		public static MessageParser<EffectGroupPlayerStart> Parser
		{
			get
			{
				return EffectGroupPlayerStart._parser;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x00054594 File Offset: 0x00052794
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[219];
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000545BC File Offset: 0x000527BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectGroupPlayerStart.Descriptor;
			}
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000545D3 File Offset: 0x000527D3
		[DebuggerNonUserCode]
		public EffectGroupPlayerStart()
		{
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000545E0 File Offset: 0x000527E0
		[DebuggerNonUserCode]
		public EffectGroupPlayerStart(EffectGroupPlayerStart other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoEffectGroupHandle_ = other.snoEffectGroupHandle_;
			this.startTime_ = other.startTime_;
			this.takeControlOfCamera_ = other.takeControlOfCamera_;
			this.scrubbing_ = other.scrubbing_;
			this.ticksPerSec_ = other.ticksPerSec_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00054650 File Offset: 0x00052850
		[DebuggerNonUserCode]
		public EffectGroupPlayerStart Clone()
		{
			return new EffectGroupPlayerStart(this);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00054668 File Offset: 0x00052868
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x00054699 File Offset: 0x00052899
		[DebuggerNonUserCode]
		public int SnoEffectGroupHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoEffectGroupHandleDefaultValue;
				if (flag)
				{
					snoEffectGroupHandleDefaultValue = this.snoEffectGroupHandle_;
				}
				else
				{
					snoEffectGroupHandleDefaultValue = EffectGroupPlayerStart.SnoEffectGroupHandleDefaultValue;
				}
				return snoEffectGroupHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoEffectGroupHandle_ = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x000546B4 File Offset: 0x000528B4
		[DebuggerNonUserCode]
		public bool HasSnoEffectGroupHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000546D1 File Offset: 0x000528D1
		[DebuggerNonUserCode]
		public void ClearSnoEffectGroupHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000546E4 File Offset: 0x000528E4
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x00054715 File Offset: 0x00052915
		[DebuggerNonUserCode]
		public float StartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float startTimeDefaultValue;
				if (flag)
				{
					startTimeDefaultValue = this.startTime_;
				}
				else
				{
					startTimeDefaultValue = EffectGroupPlayerStart.StartTimeDefaultValue;
				}
				return startTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.startTime_ = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00054730 File Offset: 0x00052930
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0005474D File Offset: 0x0005294D
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00054760 File Offset: 0x00052960
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x00054791 File Offset: 0x00052991
		[DebuggerNonUserCode]
		public bool TakeControlOfCamera
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool takeControlOfCameraDefaultValue;
				if (flag)
				{
					takeControlOfCameraDefaultValue = this.takeControlOfCamera_;
				}
				else
				{
					takeControlOfCameraDefaultValue = EffectGroupPlayerStart.TakeControlOfCameraDefaultValue;
				}
				return takeControlOfCameraDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.takeControlOfCamera_ = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000547AC File Offset: 0x000529AC
		[DebuggerNonUserCode]
		public bool HasTakeControlOfCamera
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000547C9 File Offset: 0x000529C9
		[DebuggerNonUserCode]
		public void ClearTakeControlOfCamera()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x000547DC File Offset: 0x000529DC
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x0005480D File Offset: 0x00052A0D
		[DebuggerNonUserCode]
		public bool Scrubbing
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool scrubbingDefaultValue;
				if (flag)
				{
					scrubbingDefaultValue = this.scrubbing_;
				}
				else
				{
					scrubbingDefaultValue = EffectGroupPlayerStart.ScrubbingDefaultValue;
				}
				return scrubbingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.scrubbing_ = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00054828 File Offset: 0x00052A28
		[DebuggerNonUserCode]
		public bool HasScrubbing
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00054845 File Offset: 0x00052A45
		[DebuggerNonUserCode]
		public void ClearScrubbing()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x00054858 File Offset: 0x00052A58
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0005488A File Offset: 0x00052A8A
		[DebuggerNonUserCode]
		public int TicksPerSec
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				int ticksPerSecDefaultValue;
				if (flag)
				{
					ticksPerSecDefaultValue = this.ticksPerSec_;
				}
				else
				{
					ticksPerSecDefaultValue = EffectGroupPlayerStart.TicksPerSecDefaultValue;
				}
				return ticksPerSecDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.ticksPerSec_ = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x000548A4 File Offset: 0x00052AA4
		[DebuggerNonUserCode]
		public bool HasTicksPerSec
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000548C2 File Offset: 0x00052AC2
		[DebuggerNonUserCode]
		public void ClearTicksPerSec()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000548D4 File Offset: 0x00052AD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectGroupPlayerStart);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000548F4 File Offset: 0x00052AF4
		[DebuggerNonUserCode]
		public bool Equals(EffectGroupPlayerStart other)
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
					bool flag4 = this.SnoEffectGroupHandle != other.SnoEffectGroupHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTime, other.StartTime);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TakeControlOfCamera != other.TakeControlOfCamera;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Scrubbing != other.Scrubbing;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.TicksPerSec != other.TicksPerSec;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000549C8 File Offset: 0x00052BC8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoEffectGroupHandle = this.HasSnoEffectGroupHandle;
			if (hasSnoEffectGroupHandle)
			{
				num ^= this.SnoEffectGroupHandle.GetHashCode();
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartTime);
			}
			bool hasTakeControlOfCamera = this.HasTakeControlOfCamera;
			if (hasTakeControlOfCamera)
			{
				num ^= this.TakeControlOfCamera.GetHashCode();
			}
			bool hasScrubbing = this.HasScrubbing;
			if (hasScrubbing)
			{
				num ^= this.Scrubbing.GetHashCode();
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				num ^= this.TicksPerSec.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00054A90 File Offset: 0x00052C90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00054AA8 File Offset: 0x00052CA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00054AB4 File Offset: 0x00052CB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoEffectGroupHandle = this.HasSnoEffectGroupHandle;
			if (hasSnoEffectGroupHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoEffectGroupHandle);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.StartTime);
			}
			bool hasTakeControlOfCamera = this.HasTakeControlOfCamera;
			if (hasTakeControlOfCamera)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.TakeControlOfCamera);
			}
			bool hasScrubbing = this.HasScrubbing;
			if (hasScrubbing)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Scrubbing);
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TicksPerSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00054B8C File Offset: 0x00052D8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoEffectGroupHandle = this.HasSnoEffectGroupHandle;
			if (hasSnoEffectGroupHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoEffectGroupHandle);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num += 5;
			}
			bool hasTakeControlOfCamera = this.HasTakeControlOfCamera;
			if (hasTakeControlOfCamera)
			{
				num += 2;
			}
			bool hasScrubbing = this.HasScrubbing;
			if (hasScrubbing)
			{
				num += 2;
			}
			bool hasTicksPerSec = this.HasTicksPerSec;
			if (hasTicksPerSec)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TicksPerSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00054C30 File Offset: 0x00052E30
		[DebuggerNonUserCode]
		public void MergeFrom(EffectGroupPlayerStart other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoEffectGroupHandle = other.HasSnoEffectGroupHandle;
				if (hasSnoEffectGroupHandle)
				{
					this.SnoEffectGroupHandle = other.SnoEffectGroupHandle;
				}
				bool hasStartTime = other.HasStartTime;
				if (hasStartTime)
				{
					this.StartTime = other.StartTime;
				}
				bool hasTakeControlOfCamera = other.HasTakeControlOfCamera;
				if (hasTakeControlOfCamera)
				{
					this.TakeControlOfCamera = other.TakeControlOfCamera;
				}
				bool hasScrubbing = other.HasScrubbing;
				if (hasScrubbing)
				{
					this.Scrubbing = other.Scrubbing;
				}
				bool hasTicksPerSec = other.HasTicksPerSec;
				if (hasTicksPerSec)
				{
					this.TicksPerSec = other.TicksPerSec;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00054CE4 File Offset: 0x00052EE4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00054CF0 File Offset: 0x00052EF0
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
					if (num3 != 8U)
					{
						if (num3 != 21U)
						{
							goto IL_0032;
						}
						this.StartTime = input.ReadFloat();
					}
					else
					{
						this.SnoEffectGroupHandle = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0032;
						}
						this.TicksPerSec = input.ReadInt32();
					}
					else
					{
						this.Scrubbing = input.ReadBool();
					}
				}
				else
				{
					this.TakeControlOfCamera = input.ReadBool();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000976 RID: 2422
		private static readonly MessageParser<EffectGroupPlayerStart> _parser = new MessageParser<EffectGroupPlayerStart>(() => new EffectGroupPlayerStart());

		// Token: 0x04000977 RID: 2423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000978 RID: 2424
		private int _hasBits0;

		// Token: 0x04000979 RID: 2425
		public const int SnoEffectGroupHandleFieldNumber = 1;

		// Token: 0x0400097A RID: 2426
		private static readonly int SnoEffectGroupHandleDefaultValue = 0;

		// Token: 0x0400097B RID: 2427
		private int snoEffectGroupHandle_;

		// Token: 0x0400097C RID: 2428
		public const int StartTimeFieldNumber = 2;

		// Token: 0x0400097D RID: 2429
		private static readonly float StartTimeDefaultValue = 0f;

		// Token: 0x0400097E RID: 2430
		private float startTime_;

		// Token: 0x0400097F RID: 2431
		public const int TakeControlOfCameraFieldNumber = 3;

		// Token: 0x04000980 RID: 2432
		private static readonly bool TakeControlOfCameraDefaultValue = false;

		// Token: 0x04000981 RID: 2433
		private bool takeControlOfCamera_;

		// Token: 0x04000982 RID: 2434
		public const int ScrubbingFieldNumber = 4;

		// Token: 0x04000983 RID: 2435
		private static readonly bool ScrubbingDefaultValue = false;

		// Token: 0x04000984 RID: 2436
		private bool scrubbing_;

		// Token: 0x04000985 RID: 2437
		public const int TicksPerSecFieldNumber = 5;

		// Token: 0x04000986 RID: 2438
		private static readonly int TicksPerSecDefaultValue = 0;

		// Token: 0x04000987 RID: 2439
		private int ticksPerSec_;
	}
}

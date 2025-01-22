using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V2.Client
{
	// Token: 0x02000629 RID: 1577
	public sealed class LogonQueueState : IMessage<LogonQueueState>, IMessage, IEquatable<LogonQueueState>, IDeepCloneable<LogonQueueState>, IBufferMessage
	{
		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600934B RID: 37707 RVA: 0x0023AD94 File Offset: 0x00238F94
		[DebuggerNonUserCode]
		public static MessageParser<LogonQueueState> Parser
		{
			get
			{
				return LogonQueueState._parser;
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600934C RID: 37708 RVA: 0x0023ADAC File Offset: 0x00238FAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600934D RID: 37709 RVA: 0x0023ADD0 File Offset: 0x00238FD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonQueueState.Descriptor;
			}
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x0023ADE7 File Offset: 0x00238FE7
		[DebuggerNonUserCode]
		public LogonQueueState()
		{
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x0023ADF4 File Offset: 0x00238FF4
		[DebuggerNonUserCode]
		public LogonQueueState(LogonQueueState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.position_ = other.position_;
			this.estimatedQueueExitTimeS_ = other.estimatedQueueExitTimeS_;
			this.exitTimeDeviationS_ = other.exitTimeDeviationS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x0023AE4C File Offset: 0x0023904C
		[DebuggerNonUserCode]
		public LogonQueueState Clone()
		{
			return new LogonQueueState(this);
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x06009351 RID: 37713 RVA: 0x0023AE64 File Offset: 0x00239064
		// (set) Token: 0x06009352 RID: 37714 RVA: 0x0023AE95 File Offset: 0x00239095
		[DebuggerNonUserCode]
		public uint Position
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = LogonQueueState.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.position_ = value;
			}
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x06009353 RID: 37715 RVA: 0x0023AEB0 File Offset: 0x002390B0
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x0023AECD File Offset: 0x002390CD
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x0023AEE0 File Offset: 0x002390E0
		// (set) Token: 0x06009356 RID: 37718 RVA: 0x0023AF11 File Offset: 0x00239111
		[DebuggerNonUserCode]
		public ulong EstimatedQueueExitTimeS
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong estimatedQueueExitTimeSDefaultValue;
				if (flag)
				{
					estimatedQueueExitTimeSDefaultValue = this.estimatedQueueExitTimeS_;
				}
				else
				{
					estimatedQueueExitTimeSDefaultValue = LogonQueueState.EstimatedQueueExitTimeSDefaultValue;
				}
				return estimatedQueueExitTimeSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.estimatedQueueExitTimeS_ = value;
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x06009357 RID: 37719 RVA: 0x0023AF2C File Offset: 0x0023912C
		[DebuggerNonUserCode]
		public bool HasEstimatedQueueExitTimeS
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x0023AF49 File Offset: 0x00239149
		[DebuggerNonUserCode]
		public void ClearEstimatedQueueExitTimeS()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x0023AF5C File Offset: 0x0023915C
		// (set) Token: 0x0600935A RID: 37722 RVA: 0x0023AF8D File Offset: 0x0023918D
		[DebuggerNonUserCode]
		public ulong ExitTimeDeviationS
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong exitTimeDeviationSDefaultValue;
				if (flag)
				{
					exitTimeDeviationSDefaultValue = this.exitTimeDeviationS_;
				}
				else
				{
					exitTimeDeviationSDefaultValue = LogonQueueState.ExitTimeDeviationSDefaultValue;
				}
				return exitTimeDeviationSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.exitTimeDeviationS_ = value;
			}
		}

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600935B RID: 37723 RVA: 0x0023AFA8 File Offset: 0x002391A8
		[DebuggerNonUserCode]
		public bool HasExitTimeDeviationS
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x0023AFC5 File Offset: 0x002391C5
		[DebuggerNonUserCode]
		public void ClearExitTimeDeviationS()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x0023AFD8 File Offset: 0x002391D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonQueueState);
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x0023AFF8 File Offset: 0x002391F8
		[DebuggerNonUserCode]
		public bool Equals(LogonQueueState other)
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
					bool flag4 = this.Position != other.Position;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EstimatedQueueExitTimeS != other.EstimatedQueueExitTimeS;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ExitTimeDeviationS != other.ExitTimeDeviationS;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x0023B084 File Offset: 0x00239284
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool hasEstimatedQueueExitTimeS = this.HasEstimatedQueueExitTimeS;
			if (hasEstimatedQueueExitTimeS)
			{
				num ^= this.EstimatedQueueExitTimeS.GetHashCode();
			}
			bool hasExitTimeDeviationS = this.HasExitTimeDeviationS;
			if (hasExitTimeDeviationS)
			{
				num ^= this.ExitTimeDeviationS.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009360 RID: 37728 RVA: 0x0023B110 File Offset: 0x00239310
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009361 RID: 37729 RVA: 0x0023B128 File Offset: 0x00239328
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x0023B134 File Offset: 0x00239334
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Position);
			}
			bool hasEstimatedQueueExitTimeS = this.HasEstimatedQueueExitTimeS;
			if (hasEstimatedQueueExitTimeS)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.EstimatedQueueExitTimeS);
			}
			bool hasExitTimeDeviationS = this.HasExitTimeDeviationS;
			if (hasExitTimeDeviationS)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ExitTimeDeviationS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x0023B1C4 File Offset: 0x002393C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Position);
			}
			bool hasEstimatedQueueExitTimeS = this.HasEstimatedQueueExitTimeS;
			if (hasEstimatedQueueExitTimeS)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EstimatedQueueExitTimeS);
			}
			bool hasExitTimeDeviationS = this.HasExitTimeDeviationS;
			if (hasExitTimeDeviationS)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ExitTimeDeviationS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x0023B250 File Offset: 0x00239450
		[DebuggerNonUserCode]
		public void MergeFrom(LogonQueueState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				bool hasEstimatedQueueExitTimeS = other.HasEstimatedQueueExitTimeS;
				if (hasEstimatedQueueExitTimeS)
				{
					this.EstimatedQueueExitTimeS = other.EstimatedQueueExitTimeS;
				}
				bool hasExitTimeDeviationS = other.HasExitTimeDeviationS;
				if (hasExitTimeDeviationS)
				{
					this.ExitTimeDeviationS = other.ExitTimeDeviationS;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x0023B2CB File Offset: 0x002394CB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x0023B2D8 File Offset: 0x002394D8
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ExitTimeDeviationS = input.ReadUInt64();
						}
					}
					else
					{
						this.EstimatedQueueExitTimeS = input.ReadUInt64();
					}
				}
				else
				{
					this.Position = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004285 RID: 17029
		private static readonly MessageParser<LogonQueueState> _parser = new MessageParser<LogonQueueState>(() => new LogonQueueState());

		// Token: 0x04004286 RID: 17030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004287 RID: 17031
		private int _hasBits0;

		// Token: 0x04004288 RID: 17032
		public const int PositionFieldNumber = 1;

		// Token: 0x04004289 RID: 17033
		private static readonly uint PositionDefaultValue = 0U;

		// Token: 0x0400428A RID: 17034
		private uint position_;

		// Token: 0x0400428B RID: 17035
		public const int EstimatedQueueExitTimeSFieldNumber = 2;

		// Token: 0x0400428C RID: 17036
		private static readonly ulong EstimatedQueueExitTimeSDefaultValue = 0UL;

		// Token: 0x0400428D RID: 17037
		private ulong estimatedQueueExitTimeS_;

		// Token: 0x0400428E RID: 17038
		public const int ExitTimeDeviationSFieldNumber = 3;

		// Token: 0x0400428F RID: 17039
		private static readonly ulong ExitTimeDeviationSDefaultValue = 0UL;

		// Token: 0x04004290 RID: 17040
		private ulong exitTimeDeviationS_;
	}
}

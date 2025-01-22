using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DD RID: 221
	public sealed class UpdateWaypointsProgress : IMessage<UpdateWaypointsProgress>, IMessage, IEquatable<UpdateWaypointsProgress>, IDeepCloneable<UpdateWaypointsProgress>, IBufferMessage
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0004E850 File Offset: 0x0004CA50
		[DebuggerNonUserCode]
		public static MessageParser<UpdateWaypointsProgress> Parser
		{
			get
			{
				return UpdateWaypointsProgress._parser;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0004E868 File Offset: 0x0004CA68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[198];
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0004E890 File Offset: 0x0004CA90
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateWaypointsProgress.Descriptor;
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0004E8A7 File Offset: 0x0004CAA7
		[DebuggerNonUserCode]
		public UpdateWaypointsProgress()
		{
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0004E8B4 File Offset: 0x0004CAB4
		[DebuggerNonUserCode]
		public UpdateWaypointsProgress(UpdateWaypointsProgress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.finished_ = other.finished_;
			this.current_ = other.current_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0004E90C File Offset: 0x0004CB0C
		[DebuggerNonUserCode]
		public UpdateWaypointsProgress Clone()
		{
			return new UpdateWaypointsProgress(this);
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0004E924 File Offset: 0x0004CB24
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0004E955 File Offset: 0x0004CB55
		[DebuggerNonUserCode]
		public bool Finished
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool finishedDefaultValue;
				if (flag)
				{
					finishedDefaultValue = this.finished_;
				}
				else
				{
					finishedDefaultValue = UpdateWaypointsProgress.FinishedDefaultValue;
				}
				return finishedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.finished_ = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0004E970 File Offset: 0x0004CB70
		[DebuggerNonUserCode]
		public bool HasFinished
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0004E98D File Offset: 0x0004CB8D
		[DebuggerNonUserCode]
		public void ClearFinished()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0004E9A0 File Offset: 0x0004CBA0
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0004E9C1 File Offset: 0x0004CBC1
		[DebuggerNonUserCode]
		public string Current
		{
			get
			{
				return this.current_ ?? UpdateWaypointsProgress.CurrentDefaultValue;
			}
			set
			{
				this.current_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0004E9D8 File Offset: 0x0004CBD8
		[DebuggerNonUserCode]
		public bool HasCurrent
		{
			get
			{
				return this.current_ != null;
			}
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0004E9F3 File Offset: 0x0004CBF3
		[DebuggerNonUserCode]
		public void ClearCurrent()
		{
			this.current_ = null;
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0004EA00 File Offset: 0x0004CC00
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x0004EA31 File Offset: 0x0004CC31
		[DebuggerNonUserCode]
		public float Progress
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				float progressDefaultValue;
				if (flag)
				{
					progressDefaultValue = this.progress_;
				}
				else
				{
					progressDefaultValue = UpdateWaypointsProgress.ProgressDefaultValue;
				}
				return progressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.progress_ = value;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0004EA4C File Offset: 0x0004CC4C
		[DebuggerNonUserCode]
		public bool HasProgress
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0004EA69 File Offset: 0x0004CC69
		[DebuggerNonUserCode]
		public void ClearProgress()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0004EA7C File Offset: 0x0004CC7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateWaypointsProgress);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0004EA9C File Offset: 0x0004CC9C
		[DebuggerNonUserCode]
		public bool Equals(UpdateWaypointsProgress other)
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
					bool flag4 = this.Finished != other.Finished;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Current != other.Current;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Progress, other.Progress);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0004EB30 File Offset: 0x0004CD30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFinished = this.HasFinished;
			if (hasFinished)
			{
				num ^= this.Finished.GetHashCode();
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				num ^= this.Current.GetHashCode();
			}
			bool hasProgress = this.HasProgress;
			if (hasProgress)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Progress);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFinished = this.HasFinished;
			if (hasFinished)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Finished);
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Current);
			}
			bool hasProgress = this.HasProgress;
			if (hasProgress)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.Progress);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0004EC6C File Offset: 0x0004CE6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFinished = this.HasFinished;
			if (hasFinished)
			{
				num += 2;
			}
			bool hasCurrent = this.HasCurrent;
			if (hasCurrent)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Current);
			}
			bool hasProgress = this.HasProgress;
			if (hasProgress)
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

		// Token: 0x0600158E RID: 5518 RVA: 0x0004ECE0 File Offset: 0x0004CEE0
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateWaypointsProgress other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFinished = other.HasFinished;
				if (hasFinished)
				{
					this.Finished = other.Finished;
				}
				bool hasCurrent = other.HasCurrent;
				if (hasCurrent)
				{
					this.Current = other.Current;
				}
				bool hasProgress = other.HasProgress;
				if (hasProgress)
				{
					this.Progress = other.Progress;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0004ED5B File Offset: 0x0004CF5B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0004ED68 File Offset: 0x0004CF68
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
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Progress = input.ReadFloat();
						}
					}
					else
					{
						this.Current = input.ReadString();
					}
				}
				else
				{
					this.Finished = input.ReadBool();
				}
			}
		}

		// Token: 0x040008C6 RID: 2246
		private static readonly MessageParser<UpdateWaypointsProgress> _parser = new MessageParser<UpdateWaypointsProgress>(() => new UpdateWaypointsProgress());

		// Token: 0x040008C7 RID: 2247
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008C8 RID: 2248
		private int _hasBits0;

		// Token: 0x040008C9 RID: 2249
		public const int FinishedFieldNumber = 1;

		// Token: 0x040008CA RID: 2250
		private static readonly bool FinishedDefaultValue = false;

		// Token: 0x040008CB RID: 2251
		private bool finished_;

		// Token: 0x040008CC RID: 2252
		public const int CurrentFieldNumber = 2;

		// Token: 0x040008CD RID: 2253
		private static readonly string CurrentDefaultValue = "";

		// Token: 0x040008CE RID: 2254
		private string current_;

		// Token: 0x040008CF RID: 2255
		public const int ProgressFieldNumber = 3;

		// Token: 0x040008D0 RID: 2256
		private static readonly float ProgressDefaultValue = 0f;

		// Token: 0x040008D1 RID: 2257
		private float progress_;
	}
}

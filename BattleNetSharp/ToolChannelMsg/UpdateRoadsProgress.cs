using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DF RID: 223
	public sealed class UpdateRoadsProgress : IMessage<UpdateRoadsProgress>, IMessage, IEquatable<UpdateRoadsProgress>, IDeepCloneable<UpdateRoadsProgress>, IBufferMessage
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x0004F188 File Offset: 0x0004D388
		[DebuggerNonUserCode]
		public static MessageParser<UpdateRoadsProgress> Parser
		{
			get
			{
				return UpdateRoadsProgress._parser;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[200];
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0004F1C8 File Offset: 0x0004D3C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRoadsProgress.Descriptor;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0004F1DF File Offset: 0x0004D3DF
		[DebuggerNonUserCode]
		public UpdateRoadsProgress()
		{
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0004F1EC File Offset: 0x0004D3EC
		[DebuggerNonUserCode]
		public UpdateRoadsProgress(UpdateRoadsProgress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.finished_ = other.finished_;
			this.current_ = other.current_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0004F244 File Offset: 0x0004D444
		[DebuggerNonUserCode]
		public UpdateRoadsProgress Clone()
		{
			return new UpdateRoadsProgress(this);
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0004F25C File Offset: 0x0004D45C
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0004F28D File Offset: 0x0004D48D
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
					finishedDefaultValue = UpdateRoadsProgress.FinishedDefaultValue;
				}
				return finishedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.finished_ = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0004F2A8 File Offset: 0x0004D4A8
		[DebuggerNonUserCode]
		public bool HasFinished
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0004F2C5 File Offset: 0x0004D4C5
		[DebuggerNonUserCode]
		public void ClearFinished()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0004F2D8 File Offset: 0x0004D4D8
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x0004F2F9 File Offset: 0x0004D4F9
		[DebuggerNonUserCode]
		public string Current
		{
			get
			{
				return this.current_ ?? UpdateRoadsProgress.CurrentDefaultValue;
			}
			set
			{
				this.current_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0004F310 File Offset: 0x0004D510
		[DebuggerNonUserCode]
		public bool HasCurrent
		{
			get
			{
				return this.current_ != null;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0004F32B File Offset: 0x0004D52B
		[DebuggerNonUserCode]
		public void ClearCurrent()
		{
			this.current_ = null;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0004F338 File Offset: 0x0004D538
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0004F369 File Offset: 0x0004D569
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
					progressDefaultValue = UpdateRoadsProgress.ProgressDefaultValue;
				}
				return progressDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.progress_ = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0004F384 File Offset: 0x0004D584
		[DebuggerNonUserCode]
		public bool HasProgress
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0004F3A1 File Offset: 0x0004D5A1
		[DebuggerNonUserCode]
		public void ClearProgress()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRoadsProgress);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
		[DebuggerNonUserCode]
		public bool Equals(UpdateRoadsProgress other)
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

		// Token: 0x060015BB RID: 5563 RVA: 0x0004F468 File Offset: 0x0004D668
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

		// Token: 0x060015BC RID: 5564 RVA: 0x0004F4F0 File Offset: 0x0004D6F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0004F508 File Offset: 0x0004D708
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0004F514 File Offset: 0x0004D714
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

		// Token: 0x060015BF RID: 5567 RVA: 0x0004F5A4 File Offset: 0x0004D7A4
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

		// Token: 0x060015C0 RID: 5568 RVA: 0x0004F618 File Offset: 0x0004D818
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateRoadsProgress other)
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

		// Token: 0x060015C1 RID: 5569 RVA: 0x0004F693 File Offset: 0x0004D893
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0004F6A0 File Offset: 0x0004D8A0
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

		// Token: 0x040008D8 RID: 2264
		private static readonly MessageParser<UpdateRoadsProgress> _parser = new MessageParser<UpdateRoadsProgress>(() => new UpdateRoadsProgress());

		// Token: 0x040008D9 RID: 2265
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008DA RID: 2266
		private int _hasBits0;

		// Token: 0x040008DB RID: 2267
		public const int FinishedFieldNumber = 1;

		// Token: 0x040008DC RID: 2268
		private static readonly bool FinishedDefaultValue = false;

		// Token: 0x040008DD RID: 2269
		private bool finished_;

		// Token: 0x040008DE RID: 2270
		public const int CurrentFieldNumber = 2;

		// Token: 0x040008DF RID: 2271
		private static readonly string CurrentDefaultValue = "";

		// Token: 0x040008E0 RID: 2272
		private string current_;

		// Token: 0x040008E1 RID: 2273
		public const int ProgressFieldNumber = 3;

		// Token: 0x040008E2 RID: 2274
		private static readonly float ProgressDefaultValue = 0f;

		// Token: 0x040008E3 RID: 2275
		private float progress_;
	}
}

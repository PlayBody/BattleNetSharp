using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001EE RID: 494
	public sealed class DebugTrackedCheckpointMessage : IMessage<DebugTrackedCheckpointMessage>, IMessage, IEquatable<DebugTrackedCheckpointMessage>, IDeepCloneable<DebugTrackedCheckpointMessage>, IBufferMessage
	{
		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000D531C File Offset: 0x000D351C
		[DebuggerNonUserCode]
		public static MessageParser<DebugTrackedCheckpointMessage> Parser
		{
			get
			{
				return DebugTrackedCheckpointMessage._parser;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000D5334 File Offset: 0x000D3534
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[51];
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x000D5358 File Offset: 0x000D3558
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugTrackedCheckpointMessage.Descriptor;
			}
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x000D536F File Offset: 0x000D356F
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointMessage()
		{
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x000D5384 File Offset: 0x000D3584
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointMessage(DebugTrackedCheckpointMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.currentWorldSno_ = other.currentWorldSno_;
			this.trackedCheckpoints_ = other.trackedCheckpoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x000D53D4 File Offset: 0x000D35D4
		[DebuggerNonUserCode]
		public DebugTrackedCheckpointMessage Clone()
		{
			return new DebugTrackedCheckpointMessage(this);
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x000D53EC File Offset: 0x000D35EC
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x000D541D File Offset: 0x000D361D
		[DebuggerNonUserCode]
		public int CurrentWorldSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int currentWorldSnoDefaultValue;
				if (flag)
				{
					currentWorldSnoDefaultValue = this.currentWorldSno_;
				}
				else
				{
					currentWorldSnoDefaultValue = DebugTrackedCheckpointMessage.CurrentWorldSnoDefaultValue;
				}
				return currentWorldSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.currentWorldSno_ = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x000D5438 File Offset: 0x000D3638
		[DebuggerNonUserCode]
		public bool HasCurrentWorldSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000D5455 File Offset: 0x000D3655
		[DebuggerNonUserCode]
		public void ClearCurrentWorldSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x000D5468 File Offset: 0x000D3668
		[DebuggerNonUserCode]
		public RepeatedField<DebugTrackedCheckpointData> TrackedCheckpoints
		{
			get
			{
				return this.trackedCheckpoints_;
			}
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x000D5480 File Offset: 0x000D3680
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugTrackedCheckpointMessage);
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x000D54A0 File Offset: 0x000D36A0
		[DebuggerNonUserCode]
		public bool Equals(DebugTrackedCheckpointMessage other)
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
					bool flag4 = this.CurrentWorldSno != other.CurrentWorldSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.trackedCheckpoints_.Equals(other.trackedCheckpoints_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x000D5514 File Offset: 0x000D3714
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCurrentWorldSno = this.HasCurrentWorldSno;
			if (hasCurrentWorldSno)
			{
				num ^= this.CurrentWorldSno.GetHashCode();
			}
			num ^= this.trackedCheckpoints_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x000D5574 File Offset: 0x000D3774
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x000D558C File Offset: 0x000D378C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x000D5598 File Offset: 0x000D3798
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCurrentWorldSno = this.HasCurrentWorldSno;
			if (hasCurrentWorldSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrentWorldSno);
			}
			this.trackedCheckpoints_.WriteTo(ref output, DebugTrackedCheckpointMessage._repeated_trackedCheckpoints_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x000D55F8 File Offset: 0x000D37F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCurrentWorldSno = this.HasCurrentWorldSno;
			if (hasCurrentWorldSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentWorldSno);
			}
			num += this.trackedCheckpoints_.CalculateSize(DebugTrackedCheckpointMessage._repeated_trackedCheckpoints_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x000D565C File Offset: 0x000D385C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugTrackedCheckpointMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCurrentWorldSno = other.HasCurrentWorldSno;
				if (hasCurrentWorldSno)
				{
					this.CurrentWorldSno = other.CurrentWorldSno;
				}
				this.trackedCheckpoints_.Add(other.trackedCheckpoints_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x000D56B7 File Offset: 0x000D38B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x000D56C4 File Offset: 0x000D38C4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.trackedCheckpoints_.AddEntriesFrom(ref input, DebugTrackedCheckpointMessage._repeated_trackedCheckpoints_codec);
					}
				}
				else
				{
					this.CurrentWorldSno = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001900 RID: 6400
		private static readonly MessageParser<DebugTrackedCheckpointMessage> _parser = new MessageParser<DebugTrackedCheckpointMessage>(() => new DebugTrackedCheckpointMessage());

		// Token: 0x04001901 RID: 6401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001902 RID: 6402
		private int _hasBits0;

		// Token: 0x04001903 RID: 6403
		public const int CurrentWorldSnoFieldNumber = 1;

		// Token: 0x04001904 RID: 6404
		private static readonly int CurrentWorldSnoDefaultValue = 0;

		// Token: 0x04001905 RID: 6405
		private int currentWorldSno_;

		// Token: 0x04001906 RID: 6406
		public const int TrackedCheckpointsFieldNumber = 2;

		// Token: 0x04001907 RID: 6407
		private static readonly FieldCodec<DebugTrackedCheckpointData> _repeated_trackedCheckpoints_codec = FieldCodec.ForMessage<DebugTrackedCheckpointData>(18U, DebugTrackedCheckpointData.Parser);

		// Token: 0x04001908 RID: 6408
		private readonly RepeatedField<DebugTrackedCheckpointData> trackedCheckpoints_ = new RepeatedField<DebugTrackedCheckpointData>();
	}
}

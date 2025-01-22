using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000764 RID: 1892
	public sealed class Season : IMessage<Season>, IMessage, IEquatable<Season>, IDeepCloneable<Season>, IBufferMessage
	{
		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600ADEC RID: 44524 RVA: 0x002A5920 File Offset: 0x002A3B20
		[DebuggerNonUserCode]
		public static MessageParser<Season> Parser
		{
			get
			{
				return Season._parser;
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600ADED RID: 44525 RVA: 0x002A5938 File Offset: 0x002A3B38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600ADEE RID: 44526 RVA: 0x002A595C File Offset: 0x002A3B5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Season.Descriptor;
			}
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x002A5973 File Offset: 0x002A3B73
		[DebuggerNonUserCode]
		public Season()
		{
		}

		// Token: 0x0600ADF0 RID: 44528 RVA: 0x002A5980 File Offset: 0x002A3B80
		[DebuggerNonUserCode]
		public Season(Season other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.num_ = other.num_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADF1 RID: 44529 RVA: 0x002A59E4 File Offset: 0x002A3BE4
		[DebuggerNonUserCode]
		public Season Clone()
		{
			return new Season(this);
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600ADF2 RID: 44530 RVA: 0x002A59FC File Offset: 0x002A3BFC
		// (set) Token: 0x0600ADF3 RID: 44531 RVA: 0x002A5A2D File Offset: 0x002A3C2D
		[DebuggerNonUserCode]
		public int Num
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int numDefaultValue;
				if (flag)
				{
					numDefaultValue = this.num_;
				}
				else
				{
					numDefaultValue = Season.NumDefaultValue;
				}
				return numDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.num_ = value;
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600ADF4 RID: 44532 RVA: 0x002A5A48 File Offset: 0x002A3C48
		[DebuggerNonUserCode]
		public bool HasNum
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ADF5 RID: 44533 RVA: 0x002A5A65 File Offset: 0x002A3C65
		[DebuggerNonUserCode]
		public void ClearNum()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600ADF6 RID: 44534 RVA: 0x002A5A78 File Offset: 0x002A3C78
		// (set) Token: 0x0600ADF7 RID: 44535 RVA: 0x002A5AA9 File Offset: 0x002A3CA9
		[DebuggerNonUserCode]
		public int StartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int startTimeDefaultValue;
				if (flag)
				{
					startTimeDefaultValue = this.startTime_;
				}
				else
				{
					startTimeDefaultValue = Season.StartTimeDefaultValue;
				}
				return startTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.startTime_ = value;
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600ADF8 RID: 44536 RVA: 0x002A5AC4 File Offset: 0x002A3CC4
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600ADF9 RID: 44537 RVA: 0x002A5AE1 File Offset: 0x002A3CE1
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600ADFA RID: 44538 RVA: 0x002A5AF4 File Offset: 0x002A3CF4
		// (set) Token: 0x0600ADFB RID: 44539 RVA: 0x002A5B25 File Offset: 0x002A3D25
		[DebuggerNonUserCode]
		public int EndTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int endTimeDefaultValue;
				if (flag)
				{
					endTimeDefaultValue = this.endTime_;
				}
				else
				{
					endTimeDefaultValue = Season.EndTimeDefaultValue;
				}
				return endTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.endTime_ = value;
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600ADFC RID: 44540 RVA: 0x002A5B40 File Offset: 0x002A3D40
		[DebuggerNonUserCode]
		public bool HasEndTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600ADFD RID: 44541 RVA: 0x002A5B5D File Offset: 0x002A3D5D
		[DebuggerNonUserCode]
		public void ClearEndTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600ADFE RID: 44542 RVA: 0x002A5B70 File Offset: 0x002A3D70
		// (set) Token: 0x0600ADFF RID: 44543 RVA: 0x002A5B91 File Offset: 0x002A3D91
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Season.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600AE00 RID: 44544 RVA: 0x002A5BA8 File Offset: 0x002A3DA8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600AE01 RID: 44545 RVA: 0x002A5BC3 File Offset: 0x002A3DC3
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x002A5BD0 File Offset: 0x002A3DD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Season);
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x002A5BF0 File Offset: 0x002A3DF0
		[DebuggerNonUserCode]
		public bool Equals(Season other)
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
					bool flag4 = this.Num != other.Num;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StartTime != other.StartTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EndTime != other.EndTime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Name != other.Name;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x002A5C9C File Offset: 0x002A3E9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNum = this.HasNum;
			if (hasNum)
			{
				num ^= this.Num.GetHashCode();
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num ^= this.StartTime.GetHashCode();
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				num ^= this.EndTime.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE05 RID: 44549 RVA: 0x002A5D40 File Offset: 0x002A3F40
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x002A5D58 File Offset: 0x002A3F58
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE07 RID: 44551 RVA: 0x002A5D64 File Offset: 0x002A3F64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNum = this.HasNum;
			if (hasNum)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Num);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartTime);
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EndTime);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE08 RID: 44552 RVA: 0x002A5E18 File Offset: 0x002A4018
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNum = this.HasNum;
			if (hasNum)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartTime);
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndTime);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE09 RID: 44553 RVA: 0x002A5EC0 File Offset: 0x002A40C0
		[DebuggerNonUserCode]
		public void MergeFrom(Season other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNum = other.HasNum;
				if (hasNum)
				{
					this.Num = other.Num;
				}
				bool hasStartTime = other.HasStartTime;
				if (hasStartTime)
				{
					this.StartTime = other.StartTime;
				}
				bool hasEndTime = other.HasEndTime;
				if (hasEndTime)
				{
					this.EndTime = other.EndTime;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x002A5F56 File Offset: 0x002A4156
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x002A5F64 File Offset: 0x002A4164
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
						this.StartTime = input.ReadInt32();
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.Name = input.ReadString();
				}
				else
				{
					this.EndTime = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E5F RID: 20063
		private static readonly MessageParser<Season> _parser = new MessageParser<Season>(() => new Season());

		// Token: 0x04004E60 RID: 20064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E61 RID: 20065
		private int _hasBits0;

		// Token: 0x04004E62 RID: 20066
		public const int NumFieldNumber = 1;

		// Token: 0x04004E63 RID: 20067
		private static readonly int NumDefaultValue = 0;

		// Token: 0x04004E64 RID: 20068
		private int num_;

		// Token: 0x04004E65 RID: 20069
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04004E66 RID: 20070
		private static readonly int StartTimeDefaultValue = 0;

		// Token: 0x04004E67 RID: 20071
		private int startTime_;

		// Token: 0x04004E68 RID: 20072
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04004E69 RID: 20073
		private static readonly int EndTimeDefaultValue = 0;

		// Token: 0x04004E6A RID: 20074
		private int endTime_;

		// Token: 0x04004E6B RID: 20075
		public const int NameFieldNumber = 4;

		// Token: 0x04004E6C RID: 20076
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004E6D RID: 20077
		private string name_;
	}
}

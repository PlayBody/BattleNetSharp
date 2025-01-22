using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Leaderboard
{
	// Token: 0x02000761 RID: 1889
	public sealed class ServerTime : IMessage<ServerTime>, IMessage, IEquatable<ServerTime>, IDeepCloneable<ServerTime>, IBufferMessage
	{
		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600ADAC RID: 44460 RVA: 0x002A4E1C File Offset: 0x002A301C
		[DebuggerNonUserCode]
		public static MessageParser<ServerTime> Parser
		{
			get
			{
				return ServerTime._parser;
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600ADAD RID: 44461 RVA: 0x002A4E34 File Offset: 0x002A3034
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaderboardReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x002A4E58 File Offset: 0x002A3058
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerTime.Descriptor;
			}
		}

		// Token: 0x0600ADAF RID: 44463 RVA: 0x002A4E6F File Offset: 0x002A306F
		[DebuggerNonUserCode]
		public ServerTime()
		{
		}

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x002A4E79 File Offset: 0x002A3079
		[DebuggerNonUserCode]
		public ServerTime(ServerTime other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.time_ = other.time_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x002A4EAC File Offset: 0x002A30AC
		[DebuggerNonUserCode]
		public ServerTime Clone()
		{
			return new ServerTime(this);
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x002A4EC4 File Offset: 0x002A30C4
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x002A4EF5 File Offset: 0x002A30F5
		[DebuggerNonUserCode]
		public int Time
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int timeDefaultValue;
				if (flag)
				{
					timeDefaultValue = this.time_;
				}
				else
				{
					timeDefaultValue = ServerTime.TimeDefaultValue;
				}
				return timeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.time_ = value;
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x002A4F10 File Offset: 0x002A3110
		[DebuggerNonUserCode]
		public bool HasTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x002A4F2D File Offset: 0x002A312D
		[DebuggerNonUserCode]
		public void ClearTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x002A4F40 File Offset: 0x002A3140
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerTime);
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x002A4F60 File Offset: 0x002A3160
		[DebuggerNonUserCode]
		public bool Equals(ServerTime other)
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
					bool flag4 = this.Time != other.Time;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x002A4FB8 File Offset: 0x002A31B8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num ^= this.Time.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x002A5008 File Offset: 0x002A3208
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x002A5020 File Offset: 0x002A3220
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x002A502C File Offset: 0x002A322C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Time);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x002A5078 File Offset: 0x002A3278
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTime = this.HasTime;
			if (hasTime)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Time);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x002A50C8 File Offset: 0x002A32C8
		[DebuggerNonUserCode]
		public void MergeFrom(ServerTime other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTime = other.HasTime;
				if (hasTime)
				{
					this.Time = other.Time;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x002A5111 File Offset: 0x002A3311
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x002A511C File Offset: 0x002A331C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Time = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E4B RID: 20043
		private static readonly MessageParser<ServerTime> _parser = new MessageParser<ServerTime>(() => new ServerTime());

		// Token: 0x04004E4C RID: 20044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E4D RID: 20045
		private int _hasBits0;

		// Token: 0x04004E4E RID: 20046
		public const int TimeFieldNumber = 1;

		// Token: 0x04004E4F RID: 20047
		private static readonly int TimeDefaultValue = 0;

		// Token: 0x04004E50 RID: 20048
		private int time_;
	}
}

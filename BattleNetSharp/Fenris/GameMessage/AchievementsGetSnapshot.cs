using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DA RID: 474
	public sealed class AchievementsGetSnapshot : IMessage<AchievementsGetSnapshot>, IMessage, IEquatable<AchievementsGetSnapshot>, IDeepCloneable<AchievementsGetSnapshot>, IBufferMessage
	{
		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000CB4AC File Offset: 0x000C96AC
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsGetSnapshot> Parser
		{
			get
			{
				return AchievementsGetSnapshot._parser;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000CB4C4 File Offset: 0x000C96C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06003346 RID: 13126 RVA: 0x000CB4E8 File Offset: 0x000C96E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementsGetSnapshot.Descriptor;
			}
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000CB4FF File Offset: 0x000C96FF
		[DebuggerNonUserCode]
		public AchievementsGetSnapshot()
		{
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000CB50C File Offset: 0x000C970C
		[DebuggerNonUserCode]
		public AchievementsGetSnapshot(AchievementsGetSnapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.debugCompleteSnapshot_ = other.debugCompleteSnapshot_;
			this.serverTimeStamp_ = other.serverTimeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000CB564 File Offset: 0x000C9764
		[DebuggerNonUserCode]
		public AchievementsGetSnapshot Clone()
		{
			return new AchievementsGetSnapshot(this);
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x000CB57C File Offset: 0x000C977C
		// (set) Token: 0x0600334B RID: 13131 RVA: 0x000CB5AD File Offset: 0x000C97AD
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = AchievementsGetSnapshot.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x000CB5C8 File Offset: 0x000C97C8
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000CB5E5 File Offset: 0x000C97E5
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600334E RID: 13134 RVA: 0x000CB5F8 File Offset: 0x000C97F8
		// (set) Token: 0x0600334F RID: 13135 RVA: 0x000CB629 File Offset: 0x000C9829
		[DebuggerNonUserCode]
		public bool DebugCompleteSnapshot
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool debugCompleteSnapshotDefaultValue;
				if (flag)
				{
					debugCompleteSnapshotDefaultValue = this.debugCompleteSnapshot_;
				}
				else
				{
					debugCompleteSnapshotDefaultValue = AchievementsGetSnapshot.DebugCompleteSnapshotDefaultValue;
				}
				return debugCompleteSnapshotDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.debugCompleteSnapshot_ = value;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x000CB644 File Offset: 0x000C9844
		[DebuggerNonUserCode]
		public bool HasDebugCompleteSnapshot
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000CB661 File Offset: 0x000C9861
		[DebuggerNonUserCode]
		public void ClearDebugCompleteSnapshot()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x000CB674 File Offset: 0x000C9874
		// (set) Token: 0x06003353 RID: 13139 RVA: 0x000CB6A5 File Offset: 0x000C98A5
		[DebuggerNonUserCode]
		public long ServerTimeStamp
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				long serverTimeStampDefaultValue;
				if (flag)
				{
					serverTimeStampDefaultValue = this.serverTimeStamp_;
				}
				else
				{
					serverTimeStampDefaultValue = AchievementsGetSnapshot.ServerTimeStampDefaultValue;
				}
				return serverTimeStampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.serverTimeStamp_ = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x000CB6C0 File Offset: 0x000C98C0
		[DebuggerNonUserCode]
		public bool HasServerTimeStamp
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000CB6DD File Offset: 0x000C98DD
		[DebuggerNonUserCode]
		public void ClearServerTimeStamp()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000CB6F0 File Offset: 0x000C98F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementsGetSnapshot);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000CB710 File Offset: 0x000C9910
		[DebuggerNonUserCode]
		public bool Equals(AchievementsGetSnapshot other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DebugCompleteSnapshot != other.DebugCompleteSnapshot;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ServerTimeStamp != other.ServerTimeStamp;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000CB79C File Offset: 0x000C999C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasDebugCompleteSnapshot = this.HasDebugCompleteSnapshot;
			if (hasDebugCompleteSnapshot)
			{
				num ^= this.DebugCompleteSnapshot.GetHashCode();
			}
			bool hasServerTimeStamp = this.HasServerTimeStamp;
			if (hasServerTimeStamp)
			{
				num ^= this.ServerTimeStamp.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000CB828 File Offset: 0x000C9A28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000CB840 File Offset: 0x000C9A40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000CB84C File Offset: 0x000C9A4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasDebugCompleteSnapshot = this.HasDebugCompleteSnapshot;
			if (hasDebugCompleteSnapshot)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DebugCompleteSnapshot);
			}
			bool hasServerTimeStamp = this.HasServerTimeStamp;
			if (hasServerTimeStamp)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ServerTimeStamp);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasDebugCompleteSnapshot = this.HasDebugCompleteSnapshot;
			if (hasDebugCompleteSnapshot)
			{
				num += 2;
			}
			bool hasServerTimeStamp = this.HasServerTimeStamp;
			if (hasServerTimeStamp)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ServerTimeStamp);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000CB95C File Offset: 0x000C9B5C
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementsGetSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasDebugCompleteSnapshot = other.HasDebugCompleteSnapshot;
				if (hasDebugCompleteSnapshot)
				{
					this.DebugCompleteSnapshot = other.DebugCompleteSnapshot;
				}
				bool hasServerTimeStamp = other.HasServerTimeStamp;
				if (hasServerTimeStamp)
				{
					this.ServerTimeStamp = other.ServerTimeStamp;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000CB9D7 File Offset: 0x000C9BD7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000CB9E4 File Offset: 0x000C9BE4
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
							this.ServerTimeStamp = input.ReadInt64();
						}
					}
					else
					{
						this.DebugCompleteSnapshot = input.ReadBool();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017B3 RID: 6067
		private static readonly MessageParser<AchievementsGetSnapshot> _parser = new MessageParser<AchievementsGetSnapshot>(() => new AchievementsGetSnapshot());

		// Token: 0x040017B4 RID: 6068
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017B5 RID: 6069
		private int _hasBits0;

		// Token: 0x040017B6 RID: 6070
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040017B7 RID: 6071
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040017B8 RID: 6072
		private uint gameAccountId_;

		// Token: 0x040017B9 RID: 6073
		public const int DebugCompleteSnapshotFieldNumber = 2;

		// Token: 0x040017BA RID: 6074
		private static readonly bool DebugCompleteSnapshotDefaultValue = false;

		// Token: 0x040017BB RID: 6075
		private bool debugCompleteSnapshot_;

		// Token: 0x040017BC RID: 6076
		public const int ServerTimeStampFieldNumber = 3;

		// Token: 0x040017BD RID: 6077
		private static readonly long ServerTimeStampDefaultValue = 0L;

		// Token: 0x040017BE RID: 6078
		private long serverTimeStamp_;
	}
}

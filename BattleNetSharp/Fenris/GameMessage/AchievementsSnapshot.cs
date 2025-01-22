using System;
using System.Diagnostics;
using Fenris.Achievements;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DD RID: 477
	public sealed class AchievementsSnapshot : IMessage<AchievementsSnapshot>, IMessage, IEquatable<AchievementsSnapshot>, IDeepCloneable<AchievementsSnapshot>, IBufferMessage
	{
		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x000CC100 File Offset: 0x000CA300
		[DebuggerNonUserCode]
		public static MessageParser<AchievementsSnapshot> Parser
		{
			get
			{
				return AchievementsSnapshot._parser;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x000CC118 File Offset: 0x000CA318
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[34];
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x000CC13C File Offset: 0x000CA33C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementsSnapshot.Descriptor;
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x000CC153 File Offset: 0x000CA353
		[DebuggerNonUserCode]
		public AchievementsSnapshot()
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000CC160 File Offset: 0x000CA360
		[DebuggerNonUserCode]
		public AchievementsSnapshot(AchievementsSnapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000CC1BC File Offset: 0x000CA3BC
		[DebuggerNonUserCode]
		public AchievementsSnapshot Clone()
		{
			return new AchievementsSnapshot(this);
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x000CC1D4 File Offset: 0x000CA3D4
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x000CC205 File Offset: 0x000CA405
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
					gameAccountIdDefaultValue = AchievementsSnapshot.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000CC220 File Offset: 0x000CA420
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000CC23D File Offset: 0x000CA43D
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x000CC250 File Offset: 0x000CA450
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x000CC268 File Offset: 0x000CA468
		[DebuggerNonUserCode]
		public Snapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x000CC274 File Offset: 0x000CA474
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementsSnapshot);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000CC294 File Offset: 0x000CA494
		[DebuggerNonUserCode]
		public bool Equals(AchievementsSnapshot other)
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
						bool flag5 = !object.Equals(this.Snapshot, other.Snapshot);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000CC308 File Offset: 0x000CA508
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000CC374 File Offset: 0x000CA574
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000CC38C File Offset: 0x000CA58C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000CC398 File Offset: 0x000CA598
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000CC408 File Offset: 0x000CA608
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000CC478 File Offset: 0x000CA678
		[DebuggerNonUserCode]
		public void MergeFrom(AchievementsSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool flag2 = other.snapshot_ != null;
				if (flag2)
				{
					bool flag3 = this.snapshot_ == null;
					if (flag3)
					{
						this.Snapshot = new Snapshot();
					}
					this.Snapshot.MergeFrom(other.Snapshot);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000CC4FD File Offset: 0x000CA6FD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000CC508 File Offset: 0x000CA708
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
						bool flag = this.snapshot_ == null;
						if (flag)
						{
							this.Snapshot = new Snapshot();
						}
						input.ReadMessage(this.Snapshot);
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017CA RID: 6090
		private static readonly MessageParser<AchievementsSnapshot> _parser = new MessageParser<AchievementsSnapshot>(() => new AchievementsSnapshot());

		// Token: 0x040017CB RID: 6091
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017CC RID: 6092
		private int _hasBits0;

		// Token: 0x040017CD RID: 6093
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040017CE RID: 6094
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040017CF RID: 6095
		private uint gameAccountId_;

		// Token: 0x040017D0 RID: 6096
		public const int SnapshotFieldNumber = 2;

		// Token: 0x040017D1 RID: 6097
		private Snapshot snapshot_;
	}
}

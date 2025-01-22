using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D6 RID: 470
	public sealed class AIStateDebugSnapshotRetreat : IMessage<AIStateDebugSnapshotRetreat>, IMessage, IEquatable<AIStateDebugSnapshotRetreat>, IDeepCloneable<AIStateDebugSnapshotRetreat>, IBufferMessage
	{
		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x000C8B20 File Offset: 0x000C6D20
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugSnapshotRetreat> Parser
		{
			get
			{
				return AIStateDebugSnapshotRetreat._parser;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x000C8B38 File Offset: 0x000C6D38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[27];
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000C8B5C File Offset: 0x000C6D5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugSnapshotRetreat.Descriptor;
			}
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000C8B73 File Offset: 0x000C6D73
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotRetreat()
		{
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000C8B80 File Offset: 0x000C6D80
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotRetreat(AIStateDebugSnapshotRetreat other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.retreatRadius_ = other.retreatRadius_;
			this.tetherTypeName_ = other.tetherTypeName_;
			this.retreating_ = other.retreating_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000C8BD8 File Offset: 0x000C6DD8
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotRetreat Clone()
		{
			return new AIStateDebugSnapshotRetreat(this);
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x000C8C21 File Offset: 0x000C6E21
		[DebuggerNonUserCode]
		public float RetreatRadius
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float retreatRadiusDefaultValue;
				if (flag)
				{
					retreatRadiusDefaultValue = this.retreatRadius_;
				}
				else
				{
					retreatRadiusDefaultValue = AIStateDebugSnapshotRetreat.RetreatRadiusDefaultValue;
				}
				return retreatRadiusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.retreatRadius_ = value;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000C8C3C File Offset: 0x000C6E3C
		[DebuggerNonUserCode]
		public bool HasRetreatRadius
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000C8C59 File Offset: 0x000C6E59
		[DebuggerNonUserCode]
		public void ClearRetreatRadius()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000C8C6C File Offset: 0x000C6E6C
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x000C8C8D File Offset: 0x000C6E8D
		[DebuggerNonUserCode]
		public string TetherTypeName
		{
			get
			{
				return this.tetherTypeName_ ?? AIStateDebugSnapshotRetreat.TetherTypeNameDefaultValue;
			}
			set
			{
				this.tetherTypeName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000C8CA4 File Offset: 0x000C6EA4
		[DebuggerNonUserCode]
		public bool HasTetherTypeName
		{
			get
			{
				return this.tetherTypeName_ != null;
			}
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000C8CBF File Offset: 0x000C6EBF
		[DebuggerNonUserCode]
		public void ClearTetherTypeName()
		{
			this.tetherTypeName_ = null;
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000C8CCC File Offset: 0x000C6ECC
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x000C8CFD File Offset: 0x000C6EFD
		[DebuggerNonUserCode]
		public bool Retreating
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool retreatingDefaultValue;
				if (flag)
				{
					retreatingDefaultValue = this.retreating_;
				}
				else
				{
					retreatingDefaultValue = AIStateDebugSnapshotRetreat.RetreatingDefaultValue;
				}
				return retreatingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.retreating_ = value;
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000C8D18 File Offset: 0x000C6F18
		[DebuggerNonUserCode]
		public bool HasRetreating
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000C8D35 File Offset: 0x000C6F35
		[DebuggerNonUserCode]
		public void ClearRetreating()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000C8D48 File Offset: 0x000C6F48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugSnapshotRetreat);
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000C8D68 File Offset: 0x000C6F68
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugSnapshotRetreat other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.RetreatRadius, other.RetreatRadius);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TetherTypeName != other.TetherTypeName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Retreating != other.Retreating;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000C8DFC File Offset: 0x000C6FFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRetreatRadius = this.HasRetreatRadius;
			if (hasRetreatRadius)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.RetreatRadius);
			}
			bool hasTetherTypeName = this.HasTetherTypeName;
			if (hasTetherTypeName)
			{
				num ^= this.TetherTypeName.GetHashCode();
			}
			bool hasRetreating = this.HasRetreating;
			if (hasRetreating)
			{
				num ^= this.Retreating.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000C8E84 File Offset: 0x000C7084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000C8E9C File Offset: 0x000C709C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000C8EA8 File Offset: 0x000C70A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRetreatRadius = this.HasRetreatRadius;
			if (hasRetreatRadius)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.RetreatRadius);
			}
			bool hasTetherTypeName = this.HasTetherTypeName;
			if (hasTetherTypeName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TetherTypeName);
			}
			bool hasRetreating = this.HasRetreating;
			if (hasRetreating)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Retreating);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000C8F38 File Offset: 0x000C7138
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRetreatRadius = this.HasRetreatRadius;
			if (hasRetreatRadius)
			{
				num += 5;
			}
			bool hasTetherTypeName = this.HasTetherTypeName;
			if (hasTetherTypeName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TetherTypeName);
			}
			bool hasRetreating = this.HasRetreating;
			if (hasRetreating)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000C8FAC File Offset: 0x000C71AC
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugSnapshotRetreat other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRetreatRadius = other.HasRetreatRadius;
				if (hasRetreatRadius)
				{
					this.RetreatRadius = other.RetreatRadius;
				}
				bool hasTetherTypeName = other.HasTetherTypeName;
				if (hasTetherTypeName)
				{
					this.TetherTypeName = other.TetherTypeName;
				}
				bool hasRetreating = other.HasRetreating;
				if (hasRetreating)
				{
					this.Retreating = other.Retreating;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000C9027 File Offset: 0x000C7227
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000C9034 File Offset: 0x000C7234
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retreating = input.ReadBool();
						}
					}
					else
					{
						this.TetherTypeName = input.ReadString();
					}
				}
				else
				{
					this.RetreatRadius = input.ReadFloat();
				}
			}
		}

		// Token: 0x04001755 RID: 5973
		private static readonly MessageParser<AIStateDebugSnapshotRetreat> _parser = new MessageParser<AIStateDebugSnapshotRetreat>(() => new AIStateDebugSnapshotRetreat());

		// Token: 0x04001756 RID: 5974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001757 RID: 5975
		private int _hasBits0;

		// Token: 0x04001758 RID: 5976
		public const int RetreatRadiusFieldNumber = 1;

		// Token: 0x04001759 RID: 5977
		private static readonly float RetreatRadiusDefaultValue = 0f;

		// Token: 0x0400175A RID: 5978
		private float retreatRadius_;

		// Token: 0x0400175B RID: 5979
		public const int TetherTypeNameFieldNumber = 2;

		// Token: 0x0400175C RID: 5980
		private static readonly string TetherTypeNameDefaultValue = "";

		// Token: 0x0400175D RID: 5981
		private string tetherTypeName_;

		// Token: 0x0400175E RID: 5982
		public const int RetreatingFieldNumber = 3;

		// Token: 0x0400175F RID: 5983
		private static readonly bool RetreatingDefaultValue = false;

		// Token: 0x04001760 RID: 5984
		private bool retreating_;
	}
}

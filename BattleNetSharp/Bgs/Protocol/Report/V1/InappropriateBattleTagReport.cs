using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057D RID: 1405
	public sealed class InappropriateBattleTagReport : IMessage<InappropriateBattleTagReport>, IMessage, IEquatable<InappropriateBattleTagReport>, IDeepCloneable<InappropriateBattleTagReport>, IBufferMessage
	{
		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600870A RID: 34570 RVA: 0x0020CF20 File Offset: 0x0020B120
		[DebuggerNonUserCode]
		public static MessageParser<InappropriateBattleTagReport> Parser
		{
			get
			{
				return InappropriateBattleTagReport._parser;
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600870B RID: 34571 RVA: 0x0020CF38 File Offset: 0x0020B138
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600870C RID: 34572 RVA: 0x0020CF5C File Offset: 0x0020B15C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InappropriateBattleTagReport.Descriptor;
			}
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x0020CF73 File Offset: 0x0020B173
		[DebuggerNonUserCode]
		public InappropriateBattleTagReport()
		{
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x0020CF80 File Offset: 0x0020B180
		[DebuggerNonUserCode]
		public InappropriateBattleTagReport(InappropriateBattleTagReport other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.battleTag_ = other.battleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x0020CFD0 File Offset: 0x0020B1D0
		[DebuggerNonUserCode]
		public InappropriateBattleTagReport Clone()
		{
			return new InappropriateBattleTagReport(this);
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x06008710 RID: 34576 RVA: 0x0020CFE8 File Offset: 0x0020B1E8
		// (set) Token: 0x06008711 RID: 34577 RVA: 0x0020D000 File Offset: 0x0020B200
		[DebuggerNonUserCode]
		public GameAccountHandle Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06008712 RID: 34578 RVA: 0x0020D00C File Offset: 0x0020B20C
		// (set) Token: 0x06008713 RID: 34579 RVA: 0x0020D02D File Offset: 0x0020B22D
		[DebuggerNonUserCode]
		public string BattleTag
		{
			get
			{
				return this.battleTag_ ?? InappropriateBattleTagReport.BattleTagDefaultValue;
			}
			set
			{
				this.battleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06008714 RID: 34580 RVA: 0x0020D044 File Offset: 0x0020B244
		[DebuggerNonUserCode]
		public bool HasBattleTag
		{
			get
			{
				return this.battleTag_ != null;
			}
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x0020D05F File Offset: 0x0020B25F
		[DebuggerNonUserCode]
		public void ClearBattleTag()
		{
			this.battleTag_ = null;
		}

		// Token: 0x06008716 RID: 34582 RVA: 0x0020D06C File Offset: 0x0020B26C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InappropriateBattleTagReport);
		}

		// Token: 0x06008717 RID: 34583 RVA: 0x0020D08C File Offset: 0x0020B28C
		[DebuggerNonUserCode]
		public bool Equals(InappropriateBattleTagReport other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BattleTag != other.BattleTag;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008718 RID: 34584 RVA: 0x0020D100 File Offset: 0x0020B300
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num ^= this.BattleTag.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x0020D168 File Offset: 0x0020B368
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600871A RID: 34586 RVA: 0x0020D180 File Offset: 0x0020B380
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600871B RID: 34587 RVA: 0x0020D18C File Offset: 0x0020B38C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600871C RID: 34588 RVA: 0x0020D200 File Offset: 0x0020B400
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasBattleTag = this.HasBattleTag;
			if (hasBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.BattleTag);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600871D RID: 34589 RVA: 0x0020D270 File Offset: 0x0020B470
		[DebuggerNonUserCode]
		public void MergeFrom(InappropriateBattleTagReport other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new GameAccountHandle();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool hasBattleTag = other.HasBattleTag;
				if (hasBattleTag)
				{
					this.BattleTag = other.BattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600871E RID: 34590 RVA: 0x0020D2F5 File Offset: 0x0020B4F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600871F RID: 34591 RVA: 0x0020D300 File Offset: 0x0020B500
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BattleTag = input.ReadString();
					}
				}
				else
				{
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new GameAccountHandle();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003D2A RID: 15658
		private static readonly MessageParser<InappropriateBattleTagReport> _parser = new MessageParser<InappropriateBattleTagReport>(() => new InappropriateBattleTagReport());

		// Token: 0x04003D2B RID: 15659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D2C RID: 15660
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D2D RID: 15661
		private GameAccountHandle target_;

		// Token: 0x04003D2E RID: 15662
		public const int BattleTagFieldNumber = 2;

		// Token: 0x04003D2F RID: 15663
		private static readonly string BattleTagDefaultValue = "";

		// Token: 0x04003D30 RID: 15664
		private string battleTag_;
	}
}

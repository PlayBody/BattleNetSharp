using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D3 RID: 467
	public sealed class AIStateDebugSnapshotEntryCondition : IMessage<AIStateDebugSnapshotEntryCondition>, IMessage, IEquatable<AIStateDebugSnapshotEntryCondition>, IDeepCloneable<AIStateDebugSnapshotEntryCondition>, IBufferMessage
	{
		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x000C6130 File Offset: 0x000C4330
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugSnapshotEntryCondition> Parser
		{
			get
			{
				return AIStateDebugSnapshotEntryCondition._parser;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000C6148 File Offset: 0x000C4348
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06003211 RID: 12817 RVA: 0x000C616C File Offset: 0x000C436C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugSnapshotEntryCondition.Descriptor;
			}
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000C6183 File Offset: 0x000C4383
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntryCondition()
		{
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000C6190 File Offset: 0x000C4390
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntryCondition(AIStateDebugSnapshotEntryCondition other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.evaluated_ = other.evaluated_;
			this.failed_ = other.failed_;
			this.result_ = other.result_;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000C6200 File Offset: 0x000C4400
		[DebuggerNonUserCode]
		public AIStateDebugSnapshotEntryCondition Clone()
		{
			return new AIStateDebugSnapshotEntryCondition(this);
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x000C6218 File Offset: 0x000C4418
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x000C6239 File Offset: 0x000C4439
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? AIStateDebugSnapshotEntryCondition.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000C6250 File Offset: 0x000C4450
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000C626B File Offset: 0x000C446B
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x000C6278 File Offset: 0x000C4478
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x000C62A9 File Offset: 0x000C44A9
		[DebuggerNonUserCode]
		public bool Evaluated
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool evaluatedDefaultValue;
				if (flag)
				{
					evaluatedDefaultValue = this.evaluated_;
				}
				else
				{
					evaluatedDefaultValue = AIStateDebugSnapshotEntryCondition.EvaluatedDefaultValue;
				}
				return evaluatedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.evaluated_ = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000C62C4 File Offset: 0x000C44C4
		[DebuggerNonUserCode]
		public bool HasEvaluated
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000C62E1 File Offset: 0x000C44E1
		[DebuggerNonUserCode]
		public void ClearEvaluated()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x000C62F4 File Offset: 0x000C44F4
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x000C6325 File Offset: 0x000C4525
		[DebuggerNonUserCode]
		public bool Failed
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool failedDefaultValue;
				if (flag)
				{
					failedDefaultValue = this.failed_;
				}
				else
				{
					failedDefaultValue = AIStateDebugSnapshotEntryCondition.FailedDefaultValue;
				}
				return failedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.failed_ = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000C6340 File Offset: 0x000C4540
		[DebuggerNonUserCode]
		public bool HasFailed
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x000C635D File Offset: 0x000C455D
		[DebuggerNonUserCode]
		public void ClearFailed()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000C6370 File Offset: 0x000C4570
		// (set) Token: 0x06003222 RID: 12834 RVA: 0x000C63A1 File Offset: 0x000C45A1
		[DebuggerNonUserCode]
		public int Result
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int resultDefaultValue;
				if (flag)
				{
					resultDefaultValue = this.result_;
				}
				else
				{
					resultDefaultValue = AIStateDebugSnapshotEntryCondition.ResultDefaultValue;
				}
				return resultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.result_ = value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000C63BC File Offset: 0x000C45BC
		[DebuggerNonUserCode]
		public bool HasResult
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000C63D9 File Offset: 0x000C45D9
		[DebuggerNonUserCode]
		public void ClearResult()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06003225 RID: 12837 RVA: 0x000C63EC File Offset: 0x000C45EC
		// (set) Token: 0x06003226 RID: 12838 RVA: 0x000C641D File Offset: 0x000C461D
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = AIStateDebugSnapshotEntryCondition.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.enabled_ = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x000C6438 File Offset: 0x000C4638
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000C6455 File Offset: 0x000C4655
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000C6468 File Offset: 0x000C4668
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugSnapshotEntryCondition);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000C6488 File Offset: 0x000C4688
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugSnapshotEntryCondition other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Evaluated != other.Evaluated;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Failed != other.Failed;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Result != other.Result;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Enabled != other.Enabled;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000C6554 File Offset: 0x000C4754
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				num ^= this.Evaluated.GetHashCode();
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				num ^= this.Failed.GetHashCode();
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num ^= this.Result.GetHashCode();
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000C6618 File Offset: 0x000C4818
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000C6630 File Offset: 0x000C4830
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000C663C File Offset: 0x000C483C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Evaluated);
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Failed);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Result);
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000C6714 File Offset: 0x000C4914
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasEvaluated = this.HasEvaluated;
			if (hasEvaluated)
			{
				num += 2;
			}
			bool hasFailed = this.HasFailed;
			if (hasFailed)
			{
				num += 2;
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Result);
			}
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
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

		// Token: 0x06003230 RID: 12848 RVA: 0x000C67B8 File Offset: 0x000C49B8
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugSnapshotEntryCondition other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasEvaluated = other.HasEvaluated;
				if (hasEvaluated)
				{
					this.Evaluated = other.Evaluated;
				}
				bool hasFailed = other.HasFailed;
				if (hasFailed)
				{
					this.Failed = other.Failed;
				}
				bool hasResult = other.HasResult;
				if (hasResult)
				{
					this.Result = other.Result;
				}
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000C686C File Offset: 0x000C4A6C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x000C6878 File Offset: 0x000C4A78
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
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.Evaluated = input.ReadBool();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.Enabled = input.ReadBool();
					}
					else
					{
						this.Result = input.ReadInt32();
					}
				}
				else
				{
					this.Failed = input.ReadBool();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040016F7 RID: 5879
		private static readonly MessageParser<AIStateDebugSnapshotEntryCondition> _parser = new MessageParser<AIStateDebugSnapshotEntryCondition>(() => new AIStateDebugSnapshotEntryCondition());

		// Token: 0x040016F8 RID: 5880
		private UnknownFieldSet _unknownFields;

		// Token: 0x040016F9 RID: 5881
		private int _hasBits0;

		// Token: 0x040016FA RID: 5882
		public const int NameFieldNumber = 1;

		// Token: 0x040016FB RID: 5883
		private static readonly string NameDefaultValue = "";

		// Token: 0x040016FC RID: 5884
		private string name_;

		// Token: 0x040016FD RID: 5885
		public const int EvaluatedFieldNumber = 2;

		// Token: 0x040016FE RID: 5886
		private static readonly bool EvaluatedDefaultValue = false;

		// Token: 0x040016FF RID: 5887
		private bool evaluated_;

		// Token: 0x04001700 RID: 5888
		public const int FailedFieldNumber = 3;

		// Token: 0x04001701 RID: 5889
		private static readonly bool FailedDefaultValue = false;

		// Token: 0x04001702 RID: 5890
		private bool failed_;

		// Token: 0x04001703 RID: 5891
		public const int ResultFieldNumber = 4;

		// Token: 0x04001704 RID: 5892
		private static readonly int ResultDefaultValue = 0;

		// Token: 0x04001705 RID: 5893
		private int result_;

		// Token: 0x04001706 RID: 5894
		public const int EnabledFieldNumber = 5;

		// Token: 0x04001707 RID: 5895
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x04001708 RID: 5896
		private bool enabled_;
	}
}

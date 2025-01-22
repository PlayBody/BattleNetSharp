using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000329 RID: 809
	public sealed class HirelingState : IMessage<HirelingState>, IMessage, IEquatable<HirelingState>, IDeepCloneable<HirelingState>, IBufferMessage
	{
		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600549B RID: 21659 RVA: 0x00146FE0 File Offset: 0x001451E0
		[DebuggerNonUserCode]
		public static MessageParser<HirelingState> Parser
		{
			get
			{
				return HirelingState._parser;
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x00146FF8 File Offset: 0x001451F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonHirelingStateReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x0600549D RID: 21661 RVA: 0x0014701C File Offset: 0x0014521C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HirelingState.Descriptor;
			}
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00147033 File Offset: 0x00145233
		[DebuggerNonUserCode]
		public HirelingState()
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00147048 File Offset: 0x00145248
		[DebuggerNonUserCode]
		public HirelingState(HirelingState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.className_ = other.className_;
			this.stats_ = other.stats_.Clone();
			this.inventoryState_ = ((other.inventoryState_ != null) ? other.inventoryState_.Clone() : null);
			this.skillState_ = ((other.skillState_ != null) ? other.skillState_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x001470DC File Offset: 0x001452DC
		[DebuggerNonUserCode]
		public HirelingState Clone()
		{
			return new HirelingState(this);
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x001470F4 File Offset: 0x001452F4
		// (set) Token: 0x060054A2 RID: 21666 RVA: 0x00147125 File Offset: 0x00145325
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = HirelingState.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060054A3 RID: 21667 RVA: 0x00147140 File Offset: 0x00145340
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x0014715D File Offset: 0x0014535D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060054A5 RID: 21669 RVA: 0x00147170 File Offset: 0x00145370
		// (set) Token: 0x060054A6 RID: 21670 RVA: 0x00147191 File Offset: 0x00145391
		[DebuggerNonUserCode]
		public string ClassName
		{
			get
			{
				return this.className_ ?? HirelingState.ClassNameDefaultValue;
			}
			set
			{
				this.className_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060054A7 RID: 21671 RVA: 0x001471A8 File Offset: 0x001453A8
		[DebuggerNonUserCode]
		public bool HasClassName
		{
			get
			{
				return this.className_ != null;
			}
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x001471C3 File Offset: 0x001453C3
		[DebuggerNonUserCode]
		public void ClearClassName()
		{
			this.className_ = null;
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x001471D0 File Offset: 0x001453D0
		[DebuggerNonUserCode]
		public RepeatedField<StatEntry> Stats
		{
			get
			{
				return this.stats_;
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x001471E8 File Offset: 0x001453E8
		// (set) Token: 0x060054AB RID: 21675 RVA: 0x00147200 File Offset: 0x00145400
		[DebuggerNonUserCode]
		public InventoryState InventoryState
		{
			get
			{
				return this.inventoryState_;
			}
			set
			{
				this.inventoryState_ = value;
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x0014720C File Offset: 0x0014540C
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x00147224 File Offset: 0x00145424
		[DebuggerNonUserCode]
		public SkillState SkillState
		{
			get
			{
				return this.skillState_;
			}
			set
			{
				this.skillState_ = value;
			}
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00147230 File Offset: 0x00145430
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HirelingState);
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00147250 File Offset: 0x00145450
		[DebuggerNonUserCode]
		public bool Equals(HirelingState other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClassName != other.ClassName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.stats_.Equals(other.stats_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.InventoryState, other.InventoryState);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.SkillState, other.SkillState);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00147324 File Offset: 0x00145524
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasClassName = this.HasClassName;
			if (hasClassName)
			{
				num ^= this.ClassName.GetHashCode();
			}
			num ^= this.stats_.GetHashCode();
			bool flag = this.inventoryState_ != null;
			if (flag)
			{
				num ^= this.InventoryState.GetHashCode();
			}
			bool flag2 = this.skillState_ != null;
			if (flag2)
			{
				num ^= this.SkillState.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x001473D8 File Offset: 0x001455D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x001473F0 File Offset: 0x001455F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x001473FC File Offset: 0x001455FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasClassName = this.HasClassName;
			if (hasClassName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClassName);
			}
			this.stats_.WriteTo(ref output, HirelingState._repeated_stats_codec);
			bool flag = this.inventoryState_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.InventoryState);
			}
			bool flag2 = this.skillState_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SkillState);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x001474C8 File Offset: 0x001456C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasClassName = this.HasClassName;
			if (hasClassName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClassName);
			}
			num += this.stats_.CalculateSize(HirelingState._repeated_stats_codec);
			bool flag = this.inventoryState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InventoryState);
			}
			bool flag2 = this.skillState_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillState);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x0014758C File Offset: 0x0014578C
		[DebuggerNonUserCode]
		public void MergeFrom(HirelingState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasClassName = other.HasClassName;
				if (hasClassName)
				{
					this.ClassName = other.ClassName;
				}
				this.stats_.Add(other.stats_);
				bool flag2 = other.inventoryState_ != null;
				if (flag2)
				{
					bool flag3 = this.inventoryState_ == null;
					if (flag3)
					{
						this.InventoryState = new InventoryState();
					}
					this.InventoryState.MergeFrom(other.InventoryState);
				}
				bool flag4 = other.skillState_ != null;
				if (flag4)
				{
					bool flag5 = this.skillState_ == null;
					if (flag5)
					{
						this.SkillState = new SkillState();
					}
					this.SkillState.MergeFrom(other.SkillState);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00147681 File Offset: 0x00145881
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0014768C File Offset: 0x0014588C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0032;
						}
						this.ClassName = input.ReadString();
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						bool flag = this.skillState_ == null;
						if (flag)
						{
							this.SkillState = new SkillState();
						}
						input.ReadMessage(this.SkillState);
					}
					else
					{
						bool flag2 = this.inventoryState_ == null;
						if (flag2)
						{
							this.InventoryState = new InventoryState();
						}
						input.ReadMessage(this.InventoryState);
					}
				}
				else
				{
					this.stats_.AddEntriesFrom(ref input, HirelingState._repeated_stats_codec);
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002670 RID: 9840
		private static readonly MessageParser<HirelingState> _parser = new MessageParser<HirelingState>(() => new HirelingState());

		// Token: 0x04002671 RID: 9841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002672 RID: 9842
		private int _hasBits0;

		// Token: 0x04002673 RID: 9843
		public const int IdFieldNumber = 1;

		// Token: 0x04002674 RID: 9844
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002675 RID: 9845
		private uint id_;

		// Token: 0x04002676 RID: 9846
		public const int ClassNameFieldNumber = 2;

		// Token: 0x04002677 RID: 9847
		private static readonly string ClassNameDefaultValue = "";

		// Token: 0x04002678 RID: 9848
		private string className_;

		// Token: 0x04002679 RID: 9849
		public const int StatsFieldNumber = 3;

		// Token: 0x0400267A RID: 9850
		private static readonly FieldCodec<StatEntry> _repeated_stats_codec = FieldCodec.ForMessage<StatEntry>(26U, StatEntry.Parser);

		// Token: 0x0400267B RID: 9851
		private readonly RepeatedField<StatEntry> stats_ = new RepeatedField<StatEntry>();

		// Token: 0x0400267C RID: 9852
		public const int InventoryStateFieldNumber = 4;

		// Token: 0x0400267D RID: 9853
		private InventoryState inventoryState_;

		// Token: 0x0400267E RID: 9854
		public const int SkillStateFieldNumber = 5;

		// Token: 0x0400267F RID: 9855
		private SkillState skillState_;
	}
}

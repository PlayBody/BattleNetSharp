using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C8 RID: 200
	public sealed class NPCGenerateLook : IMessage<NPCGenerateLook>, IMessage, IEquatable<NPCGenerateLook>, IDeepCloneable<NPCGenerateLook>, IBufferMessage
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00045338 File Offset: 0x00043538
		[DebuggerNonUserCode]
		public static MessageParser<NPCGenerateLook> Parser
		{
			get
			{
				return NPCGenerateLook._parser;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00045350 File Offset: 0x00043550
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[177];
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00045378 File Offset: 0x00043578
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NPCGenerateLook.Descriptor;
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0004538F File Offset: 0x0004358F
		[DebuggerNonUserCode]
		public NPCGenerateLook()
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00045399 File Offset: 0x00043599
		[DebuggerNonUserCode]
		public NPCGenerateLook(NPCGenerateLook other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoActor_ = other.snoActor_;
			this.randomize_ = other.randomize_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000453D8 File Offset: 0x000435D8
		[DebuggerNonUserCode]
		public NPCGenerateLook Clone()
		{
			return new NPCGenerateLook(this);
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000453F0 File Offset: 0x000435F0
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00045421 File Offset: 0x00043621
		[DebuggerNonUserCode]
		public int SnoActor
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoActorDefaultValue;
				if (flag)
				{
					snoActorDefaultValue = this.snoActor_;
				}
				else
				{
					snoActorDefaultValue = NPCGenerateLook.SnoActorDefaultValue;
				}
				return snoActorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoActor_ = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0004543C File Offset: 0x0004363C
		[DebuggerNonUserCode]
		public bool HasSnoActor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00045459 File Offset: 0x00043659
		[DebuggerNonUserCode]
		public void ClearSnoActor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0004546C File Offset: 0x0004366C
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0004549D File Offset: 0x0004369D
		[DebuggerNonUserCode]
		public bool Randomize
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool randomizeDefaultValue;
				if (flag)
				{
					randomizeDefaultValue = this.randomize_;
				}
				else
				{
					randomizeDefaultValue = NPCGenerateLook.RandomizeDefaultValue;
				}
				return randomizeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.randomize_ = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000454B8 File Offset: 0x000436B8
		[DebuggerNonUserCode]
		public bool HasRandomize
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000454D5 File Offset: 0x000436D5
		[DebuggerNonUserCode]
		public void ClearRandomize()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000454E8 File Offset: 0x000436E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NPCGenerateLook);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00045508 File Offset: 0x00043708
		[DebuggerNonUserCode]
		public bool Equals(NPCGenerateLook other)
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
					bool flag4 = this.SnoActor != other.SnoActor;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Randomize != other.Randomize;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0004557C File Offset: 0x0004377C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoActor = this.HasSnoActor;
			if (hasSnoActor)
			{
				num ^= this.SnoActor.GetHashCode();
			}
			bool hasRandomize = this.HasRandomize;
			if (hasRandomize)
			{
				num ^= this.Randomize.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000455EC File Offset: 0x000437EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00045604 File Offset: 0x00043804
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00045610 File Offset: 0x00043810
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoActor = this.HasSnoActor;
			if (hasSnoActor)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoActor);
			}
			bool hasRandomize = this.HasRandomize;
			if (hasRandomize)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Randomize);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00045680 File Offset: 0x00043880
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoActor = this.HasSnoActor;
			if (hasSnoActor)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoActor);
			}
			bool hasRandomize = this.HasRandomize;
			if (hasRandomize)
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

		// Token: 0x06001304 RID: 4868 RVA: 0x000456E0 File Offset: 0x000438E0
		[DebuggerNonUserCode]
		public void MergeFrom(NPCGenerateLook other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoActor = other.HasSnoActor;
				if (hasSnoActor)
				{
					this.SnoActor = other.SnoActor;
				}
				bool hasRandomize = other.HasRandomize;
				if (hasRandomize)
				{
					this.Randomize = other.Randomize;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00045742 File Offset: 0x00043942
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00045750 File Offset: 0x00043950
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Randomize = input.ReadBool();
					}
				}
				else
				{
					this.SnoActor = input.ReadInt32();
				}
			}
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly MessageParser<NPCGenerateLook> _parser = new MessageParser<NPCGenerateLook>(() => new NPCGenerateLook());

		// Token: 0x040007A3 RID: 1955
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007A4 RID: 1956
		private int _hasBits0;

		// Token: 0x040007A5 RID: 1957
		public const int SnoActorFieldNumber = 1;

		// Token: 0x040007A6 RID: 1958
		private static readonly int SnoActorDefaultValue = 0;

		// Token: 0x040007A7 RID: 1959
		private int snoActor_;

		// Token: 0x040007A8 RID: 1960
		public const int RandomizeFieldNumber = 2;

		// Token: 0x040007A9 RID: 1961
		private static readonly bool RandomizeDefaultValue = false;

		// Token: 0x040007AA RID: 1962
		private bool randomize_;
	}
}

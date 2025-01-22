using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D9 RID: 473
	public sealed class AIStateDebugRealTimeSnapshot : IMessage<AIStateDebugRealTimeSnapshot>, IMessage, IEquatable<AIStateDebugRealTimeSnapshot>, IDeepCloneable<AIStateDebugRealTimeSnapshot>, IBufferMessage
	{
		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06003329 RID: 13097 RVA: 0x000CAEC0 File Offset: 0x000C90C0
		[DebuggerNonUserCode]
		public static MessageParser<AIStateDebugRealTimeSnapshot> Parser
		{
			get
			{
				return AIStateDebugRealTimeSnapshot._parser;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x0600332A RID: 13098 RVA: 0x000CAED8 File Offset: 0x000C90D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000CAEFC File Offset: 0x000C90FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIStateDebugRealTimeSnapshot.Descriptor;
			}
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x000CAF13 File Offset: 0x000C9113
		[DebuggerNonUserCode]
		public AIStateDebugRealTimeSnapshot()
		{
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x000CAF20 File Offset: 0x000C9120
		[DebuggerNonUserCode]
		public AIStateDebugRealTimeSnapshot(AIStateDebugRealTimeSnapshot other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ann_ = other.ann_;
			this.commandFrame_ = other.commandFrame_;
			this.variableSnapshot_ = ((other.variableSnapshot_ != null) ? other.variableSnapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x000CAF88 File Offset: 0x000C9188
		[DebuggerNonUserCode]
		public AIStateDebugRealTimeSnapshot Clone()
		{
			return new AIStateDebugRealTimeSnapshot(this);
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x0600332F RID: 13103 RVA: 0x000CAFA0 File Offset: 0x000C91A0
		// (set) Token: 0x06003330 RID: 13104 RVA: 0x000CAFD1 File Offset: 0x000C91D1
		[DebuggerNonUserCode]
		public uint Ann
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint annDefaultValue;
				if (flag)
				{
					annDefaultValue = this.ann_;
				}
				else
				{
					annDefaultValue = AIStateDebugRealTimeSnapshot.AnnDefaultValue;
				}
				return annDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.ann_ = value;
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06003331 RID: 13105 RVA: 0x000CAFEC File Offset: 0x000C91EC
		[DebuggerNonUserCode]
		public bool HasAnn
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000CB009 File Offset: 0x000C9209
		[DebuggerNonUserCode]
		public void ClearAnn()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x000CB01C File Offset: 0x000C921C
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x000CB04D File Offset: 0x000C924D
		[DebuggerNonUserCode]
		public uint CommandFrame
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint commandFrameDefaultValue;
				if (flag)
				{
					commandFrameDefaultValue = this.commandFrame_;
				}
				else
				{
					commandFrameDefaultValue = AIStateDebugRealTimeSnapshot.CommandFrameDefaultValue;
				}
				return commandFrameDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.commandFrame_ = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x000CB068 File Offset: 0x000C9268
		[DebuggerNonUserCode]
		public bool HasCommandFrame
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000CB085 File Offset: 0x000C9285
		[DebuggerNonUserCode]
		public void ClearCommandFrame()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003337 RID: 13111 RVA: 0x000CB098 File Offset: 0x000C9298
		// (set) Token: 0x06003338 RID: 13112 RVA: 0x000CB0B0 File Offset: 0x000C92B0
		[DebuggerNonUserCode]
		public AIVariableDebugSnapshot VariableSnapshot
		{
			get
			{
				return this.variableSnapshot_;
			}
			set
			{
				this.variableSnapshot_ = value;
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000CB0BC File Offset: 0x000C92BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIStateDebugRealTimeSnapshot);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000CB0DC File Offset: 0x000C92DC
		[DebuggerNonUserCode]
		public bool Equals(AIStateDebugRealTimeSnapshot other)
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
					bool flag4 = this.Ann != other.Ann;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CommandFrame != other.CommandFrame;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.VariableSnapshot, other.VariableSnapshot);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000CB16C File Offset: 0x000C936C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num ^= this.Ann.GetHashCode();
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num ^= this.CommandFrame.GetHashCode();
			}
			bool flag = this.variableSnapshot_ != null;
			if (flag)
			{
				num ^= this.VariableSnapshot.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000CB1F8 File Offset: 0x000C93F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000CB210 File Offset: 0x000C9410
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000CB21C File Offset: 0x000C941C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Ann);
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CommandFrame);
			}
			bool flag = this.variableSnapshot_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.VariableSnapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000CB2B0 File Offset: 0x000C94B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAnn = this.HasAnn;
			if (hasAnn)
			{
				num += 5;
			}
			bool hasCommandFrame = this.HasCommandFrame;
			if (hasCommandFrame)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CommandFrame);
			}
			bool flag = this.variableSnapshot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VariableSnapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000CB334 File Offset: 0x000C9534
		[DebuggerNonUserCode]
		public void MergeFrom(AIStateDebugRealTimeSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAnn = other.HasAnn;
				if (hasAnn)
				{
					this.Ann = other.Ann;
				}
				bool hasCommandFrame = other.HasCommandFrame;
				if (hasCommandFrame)
				{
					this.CommandFrame = other.CommandFrame;
				}
				bool flag2 = other.variableSnapshot_ != null;
				if (flag2)
				{
					bool flag3 = this.variableSnapshot_ == null;
					if (flag3)
					{
						this.VariableSnapshot = new AIVariableDebugSnapshot();
					}
					this.VariableSnapshot.MergeFrom(other.VariableSnapshot);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000CB3D7 File Offset: 0x000C95D7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000CB3E4 File Offset: 0x000C95E4
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
					if (num3 != 16U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.variableSnapshot_ == null;
							if (flag)
							{
								this.VariableSnapshot = new AIVariableDebugSnapshot();
							}
							input.ReadMessage(this.VariableSnapshot);
						}
					}
					else
					{
						this.CommandFrame = input.ReadUInt32();
					}
				}
				else
				{
					this.Ann = input.ReadFixed32();
				}
			}
		}

		// Token: 0x040017A8 RID: 6056
		private static readonly MessageParser<AIStateDebugRealTimeSnapshot> _parser = new MessageParser<AIStateDebugRealTimeSnapshot>(() => new AIStateDebugRealTimeSnapshot());

		// Token: 0x040017A9 RID: 6057
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017AA RID: 6058
		private int _hasBits0;

		// Token: 0x040017AB RID: 6059
		public const int AnnFieldNumber = 1;

		// Token: 0x040017AC RID: 6060
		private static readonly uint AnnDefaultValue = 0U;

		// Token: 0x040017AD RID: 6061
		private uint ann_;

		// Token: 0x040017AE RID: 6062
		public const int CommandFrameFieldNumber = 2;

		// Token: 0x040017AF RID: 6063
		private static readonly uint CommandFrameDefaultValue = 0U;

		// Token: 0x040017B0 RID: 6064
		private uint commandFrame_;

		// Token: 0x040017B1 RID: 6065
		public const int VariableSnapshotFieldNumber = 3;

		// Token: 0x040017B2 RID: 6066
		private AIVariableDebugSnapshot variableSnapshot_;
	}
}

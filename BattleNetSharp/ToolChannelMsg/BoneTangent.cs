using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000D0 RID: 208
	public sealed class BoneTangent : IMessage<BoneTangent>, IMessage, IEquatable<BoneTangent>, IDeepCloneable<BoneTangent>, IBufferMessage
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x000488C4 File Offset: 0x00046AC4
		[DebuggerNonUserCode]
		public static MessageParser<BoneTangent> Parser
		{
			get
			{
				return BoneTangent._parser;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000488DC File Offset: 0x00046ADC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[185];
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00048904 File Offset: 0x00046B04
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneTangent.Descriptor;
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0004891B File Offset: 0x00046B1B
		[DebuggerNonUserCode]
		public BoneTangent()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00048928 File Offset: 0x00046B28
		[DebuggerNonUserCode]
		public BoneTangent(BoneTangent other)
			: this()
		{
			this.negXAxis_ = ((other.negXAxis_ != null) ? other.negXAxis_.Clone() : null);
			this.posXAxis_ = ((other.posXAxis_ != null) ? other.posXAxis_.Clone() : null);
			this.negYAxis_ = ((other.negYAxis_ != null) ? other.negYAxis_.Clone() : null);
			this.posYAxis_ = ((other.posYAxis_ != null) ? other.posYAxis_.Clone() : null);
			this.negZAxis_ = ((other.negZAxis_ != null) ? other.negZAxis_.Clone() : null);
			this.posZAxis_ = ((other.posZAxis_ != null) ? other.posZAxis_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000489F8 File Offset: 0x00046BF8
		[DebuggerNonUserCode]
		public BoneTangent Clone()
		{
			return new BoneTangent(this);
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00048A10 File Offset: 0x00046C10
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x00048A28 File Offset: 0x00046C28
		[DebuggerNonUserCode]
		public Vector2 NegXAxis
		{
			get
			{
				return this.negXAxis_;
			}
			set
			{
				this.negXAxis_ = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00048A34 File Offset: 0x00046C34
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x00048A4C File Offset: 0x00046C4C
		[DebuggerNonUserCode]
		public Vector2 PosXAxis
		{
			get
			{
				return this.posXAxis_;
			}
			set
			{
				this.posXAxis_ = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00048A58 File Offset: 0x00046C58
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x00048A70 File Offset: 0x00046C70
		[DebuggerNonUserCode]
		public Vector2 NegYAxis
		{
			get
			{
				return this.negYAxis_;
			}
			set
			{
				this.negYAxis_ = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00048A7C File Offset: 0x00046C7C
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x00048A94 File Offset: 0x00046C94
		[DebuggerNonUserCode]
		public Vector2 PosYAxis
		{
			get
			{
				return this.posYAxis_;
			}
			set
			{
				this.posYAxis_ = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00048AA0 File Offset: 0x00046CA0
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00048AB8 File Offset: 0x00046CB8
		[DebuggerNonUserCode]
		public Vector2 NegZAxis
		{
			get
			{
				return this.negZAxis_;
			}
			set
			{
				this.negZAxis_ = value;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00048AC4 File Offset: 0x00046CC4
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00048ADC File Offset: 0x00046CDC
		[DebuggerNonUserCode]
		public Vector2 PosZAxis
		{
			get
			{
				return this.posZAxis_;
			}
			set
			{
				this.posZAxis_ = value;
			}
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00048AE8 File Offset: 0x00046CE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneTangent);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00048B08 File Offset: 0x00046D08
		[DebuggerNonUserCode]
		public bool Equals(BoneTangent other)
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
					bool flag4 = !object.Equals(this.NegXAxis, other.NegXAxis);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.PosXAxis, other.PosXAxis);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.NegYAxis, other.NegYAxis);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.PosYAxis, other.PosYAxis);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.NegZAxis, other.NegZAxis);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.PosZAxis, other.PosZAxis);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00048C04 File Offset: 0x00046E04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.negXAxis_ != null;
			if (flag)
			{
				num ^= this.NegXAxis.GetHashCode();
			}
			bool flag2 = this.posXAxis_ != null;
			if (flag2)
			{
				num ^= this.PosXAxis.GetHashCode();
			}
			bool flag3 = this.negYAxis_ != null;
			if (flag3)
			{
				num ^= this.NegYAxis.GetHashCode();
			}
			bool flag4 = this.posYAxis_ != null;
			if (flag4)
			{
				num ^= this.PosYAxis.GetHashCode();
			}
			bool flag5 = this.negZAxis_ != null;
			if (flag5)
			{
				num ^= this.NegZAxis.GetHashCode();
			}
			bool flag6 = this.posZAxis_ != null;
			if (flag6)
			{
				num ^= this.PosZAxis.GetHashCode();
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00048CE4 File Offset: 0x00046EE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00048CFC File Offset: 0x00046EFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00048D08 File Offset: 0x00046F08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.negXAxis_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NegXAxis);
			}
			bool flag2 = this.posXAxis_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PosXAxis);
			}
			bool flag3 = this.negYAxis_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NegYAxis);
			}
			bool flag4 = this.posYAxis_ != null;
			if (flag4)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PosYAxis);
			}
			bool flag5 = this.negZAxis_ != null;
			if (flag5)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NegZAxis);
			}
			bool flag6 = this.posZAxis_ != null;
			if (flag6)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PosZAxis);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00048E18 File Offset: 0x00047018
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.negXAxis_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NegXAxis);
			}
			bool flag2 = this.posXAxis_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosXAxis);
			}
			bool flag3 = this.negYAxis_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NegYAxis);
			}
			bool flag4 = this.posYAxis_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosYAxis);
			}
			bool flag5 = this.negZAxis_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NegZAxis);
			}
			bool flag6 = this.posZAxis_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PosZAxis);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00048F10 File Offset: 0x00047110
		[DebuggerNonUserCode]
		public void MergeFrom(BoneTangent other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.negXAxis_ != null;
				if (flag2)
				{
					bool flag3 = this.negXAxis_ == null;
					if (flag3)
					{
						this.NegXAxis = new Vector2();
					}
					this.NegXAxis.MergeFrom(other.NegXAxis);
				}
				bool flag4 = other.posXAxis_ != null;
				if (flag4)
				{
					bool flag5 = this.posXAxis_ == null;
					if (flag5)
					{
						this.PosXAxis = new Vector2();
					}
					this.PosXAxis.MergeFrom(other.PosXAxis);
				}
				bool flag6 = other.negYAxis_ != null;
				if (flag6)
				{
					bool flag7 = this.negYAxis_ == null;
					if (flag7)
					{
						this.NegYAxis = new Vector2();
					}
					this.NegYAxis.MergeFrom(other.NegYAxis);
				}
				bool flag8 = other.posYAxis_ != null;
				if (flag8)
				{
					bool flag9 = this.posYAxis_ == null;
					if (flag9)
					{
						this.PosYAxis = new Vector2();
					}
					this.PosYAxis.MergeFrom(other.PosYAxis);
				}
				bool flag10 = other.negZAxis_ != null;
				if (flag10)
				{
					bool flag11 = this.negZAxis_ == null;
					if (flag11)
					{
						this.NegZAxis = new Vector2();
					}
					this.NegZAxis.MergeFrom(other.NegZAxis);
				}
				bool flag12 = other.posZAxis_ != null;
				if (flag12)
				{
					bool flag13 = this.posZAxis_ == null;
					if (flag13)
					{
						this.PosZAxis = new Vector2();
					}
					this.PosZAxis.MergeFrom(other.PosZAxis);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000490BD File Offset: 0x000472BD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000490C8 File Offset: 0x000472C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0046;
							}
							bool flag = this.negYAxis_ == null;
							if (flag)
							{
								this.NegYAxis = new Vector2();
							}
							input.ReadMessage(this.NegYAxis);
						}
						else
						{
							bool flag2 = this.posXAxis_ == null;
							if (flag2)
							{
								this.PosXAxis = new Vector2();
							}
							input.ReadMessage(this.PosXAxis);
						}
					}
					else
					{
						bool flag3 = this.negXAxis_ == null;
						if (flag3)
						{
							this.NegXAxis = new Vector2();
						}
						input.ReadMessage(this.NegXAxis);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						if (num3 != 50U)
						{
							goto IL_0046;
						}
						bool flag4 = this.posZAxis_ == null;
						if (flag4)
						{
							this.PosZAxis = new Vector2();
						}
						input.ReadMessage(this.PosZAxis);
					}
					else
					{
						bool flag5 = this.negZAxis_ == null;
						if (flag5)
						{
							this.NegZAxis = new Vector2();
						}
						input.ReadMessage(this.NegZAxis);
					}
				}
				else
				{
					bool flag6 = this.posYAxis_ == null;
					if (flag6)
					{
						this.PosYAxis = new Vector2();
					}
					input.ReadMessage(this.PosYAxis);
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400080E RID: 2062
		private static readonly MessageParser<BoneTangent> _parser = new MessageParser<BoneTangent>(() => new BoneTangent());

		// Token: 0x0400080F RID: 2063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000810 RID: 2064
		public const int NegXAxisFieldNumber = 1;

		// Token: 0x04000811 RID: 2065
		private Vector2 negXAxis_;

		// Token: 0x04000812 RID: 2066
		public const int PosXAxisFieldNumber = 2;

		// Token: 0x04000813 RID: 2067
		private Vector2 posXAxis_;

		// Token: 0x04000814 RID: 2068
		public const int NegYAxisFieldNumber = 3;

		// Token: 0x04000815 RID: 2069
		private Vector2 negYAxis_;

		// Token: 0x04000816 RID: 2070
		public const int PosYAxisFieldNumber = 4;

		// Token: 0x04000817 RID: 2071
		private Vector2 posYAxis_;

		// Token: 0x04000818 RID: 2072
		public const int NegZAxisFieldNumber = 5;

		// Token: 0x04000819 RID: 2073
		private Vector2 negZAxis_;

		// Token: 0x0400081A RID: 2074
		public const int PosZAxisFieldNumber = 6;

		// Token: 0x0400081B RID: 2075
		private Vector2 posZAxis_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B9 RID: 185
	public sealed class PRTransform : IMessage<PRTransform>, IMessage, IEquatable<PRTransform>, IDeepCloneable<PRTransform>, IBufferMessage
	{
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0003FC14 File Offset: 0x0003DE14
		[DebuggerNonUserCode]
		public static MessageParser<PRTransform> Parser
		{
			get
			{
				return PRTransform._parser;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0003FC2C File Offset: 0x0003DE2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[162];
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0003FC54 File Offset: 0x0003DE54
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PRTransform.Descriptor;
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0003FC6B File Offset: 0x0003DE6B
		[DebuggerNonUserCode]
		public PRTransform()
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0003FC78 File Offset: 0x0003DE78
		[DebuggerNonUserCode]
		public PRTransform(PRTransform other)
			: this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.q_ = ((other.q_ != null) ? other.q_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0003FCD8 File Offset: 0x0003DED8
		[DebuggerNonUserCode]
		public PRTransform Clone()
		{
			return new PRTransform(this);
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0003FCF0 File Offset: 0x0003DEF0
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x0003FD08 File Offset: 0x0003DF08
		[DebuggerNonUserCode]
		public Vector3 Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0003FD14 File Offset: 0x0003DF14
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0003FD2C File Offset: 0x0003DF2C
		[DebuggerNonUserCode]
		public Quaternion Q
		{
			get
			{
				return this.q_;
			}
			set
			{
				this.q_ = value;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0003FD38 File Offset: 0x0003DF38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PRTransform);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0003FD58 File Offset: 0x0003DF58
		[DebuggerNonUserCode]
		public bool Equals(PRTransform other)
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
					bool flag4 = !object.Equals(this.Pos, other.Pos);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Q, other.Q);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0003FDD0 File Offset: 0x0003DFD0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.pos_ != null;
			if (flag)
			{
				num ^= this.Pos.GetHashCode();
			}
			bool flag2 = this.q_ != null;
			if (flag2)
			{
				num ^= this.Q.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0003FE3C File Offset: 0x0003E03C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0003FE54 File Offset: 0x0003E054
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0003FE60 File Offset: 0x0003E060
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.pos_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			bool flag2 = this.q_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Q);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.pos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			bool flag2 = this.q_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Q);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0003FF48 File Offset: 0x0003E148
		[DebuggerNonUserCode]
		public void MergeFrom(PRTransform other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.pos_ != null;
				if (flag2)
				{
					bool flag3 = this.pos_ == null;
					if (flag3)
					{
						this.Pos = new Vector3();
					}
					this.Pos.MergeFrom(other.Pos);
				}
				bool flag4 = other.q_ != null;
				if (flag4)
				{
					bool flag5 = this.q_ == null;
					if (flag5)
					{
						this.Q = new Quaternion();
					}
					this.Q.MergeFrom(other.Q);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0003FFF5 File Offset: 0x0003E1F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00040000 File Offset: 0x0003E200
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
						bool flag = this.q_ == null;
						if (flag)
						{
							this.Q = new Quaternion();
						}
						input.ReadMessage(this.Q);
					}
				}
				else
				{
					bool flag2 = this.pos_ == null;
					if (flag2)
					{
						this.Pos = new Vector3();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x040006FA RID: 1786
		private static readonly MessageParser<PRTransform> _parser = new MessageParser<PRTransform>(() => new PRTransform());

		// Token: 0x040006FB RID: 1787
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006FC RID: 1788
		public const int PosFieldNumber = 1;

		// Token: 0x040006FD RID: 1789
		private Vector3 pos_;

		// Token: 0x040006FE RID: 1790
		public const int QFieldNumber = 2;

		// Token: 0x040006FF RID: 1791
		private Quaternion q_;
	}
}

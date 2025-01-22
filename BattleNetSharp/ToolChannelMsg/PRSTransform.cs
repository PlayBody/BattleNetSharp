using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BA RID: 186
	public sealed class PRSTransform : IMessage<PRSTransform>, IMessage, IEquatable<PRSTransform>, IDeepCloneable<PRSTransform>, IBufferMessage
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x000400C4 File Offset: 0x0003E2C4
		[DebuggerNonUserCode]
		public static MessageParser<PRSTransform> Parser
		{
			get
			{
				return PRSTransform._parser;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000400DC File Offset: 0x0003E2DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[163];
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x00040104 File Offset: 0x0003E304
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PRSTransform.Descriptor;
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0004011B File Offset: 0x0003E31B
		[DebuggerNonUserCode]
		public PRSTransform()
		{
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00040128 File Offset: 0x0003E328
		[DebuggerNonUserCode]
		public PRSTransform(PRSTransform other)
			: this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.q_ = ((other.q_ != null) ? other.q_.Clone() : null);
			this.scale_ = ((other.scale_ != null) ? other.scale_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000401A4 File Offset: 0x0003E3A4
		[DebuggerNonUserCode]
		public PRSTransform Clone()
		{
			return new PRSTransform(this);
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x000401BC File Offset: 0x0003E3BC
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x000401D4 File Offset: 0x0003E3D4
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

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x000401E0 File Offset: 0x0003E3E0
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x000401F8 File Offset: 0x0003E3F8
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00040204 File Offset: 0x0003E404
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0004021C File Offset: 0x0003E41C
		[DebuggerNonUserCode]
		public Vector3 Scale
		{
			get
			{
				return this.scale_;
			}
			set
			{
				this.scale_ = value;
			}
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00040228 File Offset: 0x0003E428
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PRSTransform);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00040248 File Offset: 0x0003E448
		[DebuggerNonUserCode]
		public bool Equals(PRSTransform other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Scale, other.Scale);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000402E0 File Offset: 0x0003E4E0
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
			bool flag3 = this.scale_ != null;
			if (flag3)
			{
				num ^= this.Scale.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00040368 File Offset: 0x0003E568
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00040380 File Offset: 0x0003E580
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0004038C File Offset: 0x0003E58C
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
			bool flag3 = this.scale_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Scale);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00040428 File Offset: 0x0003E628
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
			bool flag3 = this.scale_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scale);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000404BC File Offset: 0x0003E6BC
		[DebuggerNonUserCode]
		public void MergeFrom(PRSTransform other)
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
				bool flag6 = other.scale_ != null;
				if (flag6)
				{
					bool flag7 = this.scale_ == null;
					if (flag7)
					{
						this.Scale = new Vector3();
					}
					this.Scale.MergeFrom(other.Scale);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000405A9 File Offset: 0x0003E7A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000405B4 File Offset: 0x0003E7B4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.scale_ == null;
							if (flag)
							{
								this.Scale = new Vector3();
							}
							input.ReadMessage(this.Scale);
						}
					}
					else
					{
						bool flag2 = this.q_ == null;
						if (flag2)
						{
							this.Q = new Quaternion();
						}
						input.ReadMessage(this.Q);
					}
				}
				else
				{
					bool flag3 = this.pos_ == null;
					if (flag3)
					{
						this.Pos = new Vector3();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04000700 RID: 1792
		private static readonly MessageParser<PRSTransform> _parser = new MessageParser<PRSTransform>(() => new PRSTransform());

		// Token: 0x04000701 RID: 1793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000702 RID: 1794
		public const int PosFieldNumber = 1;

		// Token: 0x04000703 RID: 1795
		private Vector3 pos_;

		// Token: 0x04000704 RID: 1796
		public const int QFieldNumber = 2;

		// Token: 0x04000705 RID: 1797
		private Quaternion q_;

		// Token: 0x04000706 RID: 1798
		public const int ScaleFieldNumber = 3;

		// Token: 0x04000707 RID: 1799
		private Vector3 scale_;
	}
}

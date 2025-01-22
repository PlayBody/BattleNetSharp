using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A7 RID: 167
	public sealed class ServerBrowserWorldPlace : IMessage<ServerBrowserWorldPlace>, IMessage, IEquatable<ServerBrowserWorldPlace>, IDeepCloneable<ServerBrowserWorldPlace>, IBufferMessage
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000383B8 File Offset: 0x000365B8
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserWorldPlace> Parser
		{
			get
			{
				return ServerBrowserWorldPlace._parser;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000383D0 File Offset: 0x000365D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[144];
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000383F8 File Offset: 0x000365F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserWorldPlace.Descriptor;
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0003840F File Offset: 0x0003660F
		[DebuggerNonUserCode]
		public ServerBrowserWorldPlace()
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0003841C File Offset: 0x0003661C
		[DebuggerNonUserCode]
		public ServerBrowserWorldPlace(ServerBrowserWorldPlace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00038478 File Offset: 0x00036678
		[DebuggerNonUserCode]
		public ServerBrowserWorldPlace Clone()
		{
			return new ServerBrowserWorldPlace(this);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00038490 File Offset: 0x00036690
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x000384C1 File Offset: 0x000366C1
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = ServerBrowserWorldPlace.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000384DC File Offset: 0x000366DC
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000384F9 File Offset: 0x000366F9
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0003850C File Offset: 0x0003670C
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00038524 File Offset: 0x00036724
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

		// Token: 0x06000F42 RID: 3906 RVA: 0x00038530 File Offset: 0x00036730
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserWorldPlace);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00038550 File Offset: 0x00036750
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserWorldPlace other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Pos, other.Pos);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000385C4 File Offset: 0x000367C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num ^= this.Pos.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00038630 File Offset: 0x00036830
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00038648 File Offset: 0x00036848
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00038654 File Offset: 0x00036854
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoWorld);
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000386C8 File Offset: 0x000368C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 5;
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0003872C File Offset: 0x0003692C
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserWorldPlace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000387B1 File Offset: 0x000369B1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000387BC File Offset: 0x000369BC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.pos_ == null;
						if (flag)
						{
							this.Pos = new Vector3();
						}
						input.ReadMessage(this.Pos);
					}
				}
				else
				{
					this.SnoWorld = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04000602 RID: 1538
		private static readonly MessageParser<ServerBrowserWorldPlace> _parser = new MessageParser<ServerBrowserWorldPlace>(() => new ServerBrowserWorldPlace());

		// Token: 0x04000603 RID: 1539
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000604 RID: 1540
		private int _hasBits0;

		// Token: 0x04000605 RID: 1541
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04000606 RID: 1542
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04000607 RID: 1543
		private int snoWorld_;

		// Token: 0x04000608 RID: 1544
		public const int PosFieldNumber = 2;

		// Token: 0x04000609 RID: 1545
		private Vector3 pos_;
	}
}

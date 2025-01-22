using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A9 RID: 169
	public sealed class ServerBrowserWorldData : IMessage<ServerBrowserWorldData>, IMessage, IEquatable<ServerBrowserWorldData>, IDeepCloneable<ServerBrowserWorldData>, IBufferMessage
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000395AC File Offset: 0x000377AC
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserWorldData> Parser
		{
			get
			{
				return ServerBrowserWorldData._parser;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x000395C4 File Offset: 0x000377C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[146];
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x000395EC File Offset: 0x000377EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserWorldData.Descriptor;
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00039603 File Offset: 0x00037803
		[DebuggerNonUserCode]
		public ServerBrowserWorldData()
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00039610 File Offset: 0x00037810
		[DebuggerNonUserCode]
		public ServerBrowserWorldData(ServerBrowserWorldData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.sno_ = other.sno_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00039668 File Offset: 0x00037868
		[DebuggerNonUserCode]
		public ServerBrowserWorldData Clone()
		{
			return new ServerBrowserWorldData(this);
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00039680 File Offset: 0x00037880
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x000396A1 File Offset: 0x000378A1
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ServerBrowserWorldData.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x000396B8 File Offset: 0x000378B8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000396D3 File Offset: 0x000378D3
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x000396E0 File Offset: 0x000378E0
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00039711 File Offset: 0x00037911
		[DebuggerNonUserCode]
		public uint Sno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint snoDefaultValue;
				if (flag)
				{
					snoDefaultValue = this.sno_;
				}
				else
				{
					snoDefaultValue = ServerBrowserWorldData.SnoDefaultValue;
				}
				return snoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno_ = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0003972C File Offset: 0x0003792C
		[DebuggerNonUserCode]
		public bool HasSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00039749 File Offset: 0x00037949
		[DebuggerNonUserCode]
		public void ClearSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0003975C File Offset: 0x0003795C
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0003978D File Offset: 0x0003798D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = ServerBrowserWorldData.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x000397A8 File Offset: 0x000379A8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000397C5 File Offset: 0x000379C5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000397D8 File Offset: 0x000379D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserWorldData);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000397F8 File Offset: 0x000379F8
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserWorldData other)
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
						bool flag5 = this.Sno != other.Sno;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Id != other.Id;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00039884 File Offset: 0x00037A84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num ^= this.Sno.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0003990C File Offset: 0x00037B0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00039924 File Offset: 0x00037B24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00039930 File Offset: 0x00037B30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Sno);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000399C0 File Offset: 0x00037BC0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Sno);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00039A4C File Offset: 0x00037C4C
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserWorldData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasSno = other.HasSno;
				if (hasSno)
				{
					this.Sno = other.Sno;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00039AC7 File Offset: 0x00037CC7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00039AD4 File Offset: 0x00037CD4
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else
					{
						this.Sno = input.ReadUInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04000627 RID: 1575
		private static readonly MessageParser<ServerBrowserWorldData> _parser = new MessageParser<ServerBrowserWorldData>(() => new ServerBrowserWorldData());

		// Token: 0x04000628 RID: 1576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000629 RID: 1577
		private int _hasBits0;

		// Token: 0x0400062A RID: 1578
		public const int NameFieldNumber = 1;

		// Token: 0x0400062B RID: 1579
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400062C RID: 1580
		private string name_;

		// Token: 0x0400062D RID: 1581
		public const int SnoFieldNumber = 2;

		// Token: 0x0400062E RID: 1582
		private static readonly uint SnoDefaultValue = 0U;

		// Token: 0x0400062F RID: 1583
		private uint sno_;

		// Token: 0x04000630 RID: 1584
		public const int IdFieldNumber = 3;

		// Token: 0x04000631 RID: 1585
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000632 RID: 1586
		private uint id_;
	}
}

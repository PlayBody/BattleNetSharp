using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007E RID: 126
	public sealed class LookInfo : IMessage<LookInfo>, IMessage, IEquatable<LookInfo>, IDeepCloneable<LookInfo>, IBufferMessage
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002A8AC File Offset: 0x00028AAC
		[DebuggerNonUserCode]
		public static MessageParser<LookInfo> Parser
		{
			get
			{
				return LookInfo._parser;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0002A8C4 File Offset: 0x00028AC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[103];
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LookInfo.Descriptor;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002A8FF File Offset: 0x00028AFF
		[DebuggerNonUserCode]
		public LookInfo()
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002A90C File Offset: 0x00028B0C
		[DebuggerNonUserCode]
		public LookInfo(LookInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.vertices_ = other.vertices_;
			this.triangles_ = other.triangles_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002A964 File Offset: 0x00028B64
		[DebuggerNonUserCode]
		public LookInfo Clone()
		{
			return new LookInfo(this);
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002A97C File Offset: 0x00028B7C
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0002A99D File Offset: 0x00028B9D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? LookInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0002A9B4 File Offset: 0x00028BB4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002A9CF File Offset: 0x00028BCF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0002A9DC File Offset: 0x00028BDC
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0002AA0D File Offset: 0x00028C0D
		[DebuggerNonUserCode]
		public int Vertices
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int verticesDefaultValue;
				if (flag)
				{
					verticesDefaultValue = this.vertices_;
				}
				else
				{
					verticesDefaultValue = LookInfo.VerticesDefaultValue;
				}
				return verticesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.vertices_ = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002AA28 File Offset: 0x00028C28
		[DebuggerNonUserCode]
		public bool HasVertices
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002AA45 File Offset: 0x00028C45
		[DebuggerNonUserCode]
		public void ClearVertices()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002AA58 File Offset: 0x00028C58
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0002AA89 File Offset: 0x00028C89
		[DebuggerNonUserCode]
		public int Triangles
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int trianglesDefaultValue;
				if (flag)
				{
					trianglesDefaultValue = this.triangles_;
				}
				else
				{
					trianglesDefaultValue = LookInfo.TrianglesDefaultValue;
				}
				return trianglesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.triangles_ = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002AAA4 File Offset: 0x00028CA4
		[DebuggerNonUserCode]
		public bool HasTriangles
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002AAC1 File Offset: 0x00028CC1
		[DebuggerNonUserCode]
		public void ClearTriangles()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002AAD4 File Offset: 0x00028CD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LookInfo);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		[DebuggerNonUserCode]
		public bool Equals(LookInfo other)
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
						bool flag5 = this.Vertices != other.Vertices;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Triangles != other.Triangles;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002AB80 File Offset: 0x00028D80
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasVertices = this.HasVertices;
			if (hasVertices)
			{
				num ^= this.Vertices.GetHashCode();
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				num ^= this.Triangles.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002AC08 File Offset: 0x00028E08
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002AC20 File Offset: 0x00028E20
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002AC2C File Offset: 0x00028E2C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasVertices = this.HasVertices;
			if (hasVertices)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Vertices);
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Triangles);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0002ACBC File Offset: 0x00028EBC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasVertices = this.HasVertices;
			if (hasVertices)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Vertices);
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Triangles);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0002AD48 File Offset: 0x00028F48
		[DebuggerNonUserCode]
		public void MergeFrom(LookInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasVertices = other.HasVertices;
				if (hasVertices)
				{
					this.Vertices = other.Vertices;
				}
				bool hasTriangles = other.HasTriangles;
				if (hasTriangles)
				{
					this.Triangles = other.Triangles;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002ADC3 File Offset: 0x00028FC3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0002ADD0 File Offset: 0x00028FD0
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
							this.Triangles = input.ReadInt32();
						}
					}
					else
					{
						this.Vertices = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400045B RID: 1115
		private static readonly MessageParser<LookInfo> _parser = new MessageParser<LookInfo>(() => new LookInfo());

		// Token: 0x0400045C RID: 1116
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400045D RID: 1117
		private int _hasBits0;

		// Token: 0x0400045E RID: 1118
		public const int NameFieldNumber = 1;

		// Token: 0x0400045F RID: 1119
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000460 RID: 1120
		private string name_;

		// Token: 0x04000461 RID: 1121
		public const int VerticesFieldNumber = 2;

		// Token: 0x04000462 RID: 1122
		private static readonly int VerticesDefaultValue = 0;

		// Token: 0x04000463 RID: 1123
		private int vertices_;

		// Token: 0x04000464 RID: 1124
		public const int TrianglesFieldNumber = 3;

		// Token: 0x04000465 RID: 1125
		private static readonly int TrianglesDefaultValue = 0;

		// Token: 0x04000466 RID: 1126
		private int triangles_;
	}
}

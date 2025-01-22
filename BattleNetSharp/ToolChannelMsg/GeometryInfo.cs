using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007F RID: 127
	public sealed class GeometryInfo : IMessage<GeometryInfo>, IMessage, IEquatable<GeometryInfo>, IDeepCloneable<GeometryInfo>, IBufferMessage
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0002AE80 File Offset: 0x00029080
		[DebuggerNonUserCode]
		public static MessageParser<GeometryInfo> Parser
		{
			get
			{
				return GeometryInfo._parser;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0002AE98 File Offset: 0x00029098
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[104];
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0002AEBC File Offset: 0x000290BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GeometryInfo.Descriptor;
			}
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002AED3 File Offset: 0x000290D3
		[DebuggerNonUserCode]
		public GeometryInfo()
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0002AEE0 File Offset: 0x000290E0
		[DebuggerNonUserCode]
		public GeometryInfo(GeometryInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.vertices_ = other.vertices_;
			this.indices_ = other.indices_;
			this.triangles_ = other.triangles_;
			this.degenerateTriangles_ = other.degenerateTriangles_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0002AF50 File Offset: 0x00029150
		[DebuggerNonUserCode]
		public GeometryInfo Clone()
		{
			return new GeometryInfo(this);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0002AF68 File Offset: 0x00029168
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0002AF89 File Offset: 0x00029189
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? GeometryInfo.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0002AFA0 File Offset: 0x000291A0
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002AFBB File Offset: 0x000291BB
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0002AFC8 File Offset: 0x000291C8
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0002AFF9 File Offset: 0x000291F9
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
					verticesDefaultValue = GeometryInfo.VerticesDefaultValue;
				}
				return verticesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.vertices_ = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0002B014 File Offset: 0x00029214
		[DebuggerNonUserCode]
		public bool HasVertices
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002B031 File Offset: 0x00029231
		[DebuggerNonUserCode]
		public void ClearVertices()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0002B044 File Offset: 0x00029244
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0002B075 File Offset: 0x00029275
		[DebuggerNonUserCode]
		public int Indices
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int indicesDefaultValue;
				if (flag)
				{
					indicesDefaultValue = this.indices_;
				}
				else
				{
					indicesDefaultValue = GeometryInfo.IndicesDefaultValue;
				}
				return indicesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.indices_ = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0002B090 File Offset: 0x00029290
		[DebuggerNonUserCode]
		public bool HasIndices
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0002B0AD File Offset: 0x000292AD
		[DebuggerNonUserCode]
		public void ClearIndices()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0002B0C0 File Offset: 0x000292C0
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0002B0F1 File Offset: 0x000292F1
		[DebuggerNonUserCode]
		public int Triangles
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int trianglesDefaultValue;
				if (flag)
				{
					trianglesDefaultValue = this.triangles_;
				}
				else
				{
					trianglesDefaultValue = GeometryInfo.TrianglesDefaultValue;
				}
				return trianglesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.triangles_ = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0002B10C File Offset: 0x0002930C
		[DebuggerNonUserCode]
		public bool HasTriangles
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002B129 File Offset: 0x00029329
		[DebuggerNonUserCode]
		public void ClearTriangles()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0002B13C File Offset: 0x0002933C
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0002B16D File Offset: 0x0002936D
		[DebuggerNonUserCode]
		public int DegenerateTriangles
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int degenerateTrianglesDefaultValue;
				if (flag)
				{
					degenerateTrianglesDefaultValue = this.degenerateTriangles_;
				}
				else
				{
					degenerateTrianglesDefaultValue = GeometryInfo.DegenerateTrianglesDefaultValue;
				}
				return degenerateTrianglesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.degenerateTriangles_ = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0002B188 File Offset: 0x00029388
		[DebuggerNonUserCode]
		public bool HasDegenerateTriangles
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0002B1A5 File Offset: 0x000293A5
		[DebuggerNonUserCode]
		public void ClearDegenerateTriangles()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0002B1B8 File Offset: 0x000293B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GeometryInfo);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002B1D8 File Offset: 0x000293D8
		[DebuggerNonUserCode]
		public bool Equals(GeometryInfo other)
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
							bool flag6 = this.Indices != other.Indices;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Triangles != other.Triangles;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.DegenerateTriangles != other.DegenerateTriangles;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002B2A4 File Offset: 0x000294A4
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
			bool hasIndices = this.HasIndices;
			if (hasIndices)
			{
				num ^= this.Indices.GetHashCode();
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				num ^= this.Triangles.GetHashCode();
			}
			bool hasDegenerateTriangles = this.HasDegenerateTriangles;
			if (hasDegenerateTriangles)
			{
				num ^= this.DegenerateTriangles.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002B364 File Offset: 0x00029564
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002B37C File Offset: 0x0002957C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0002B388 File Offset: 0x00029588
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
			bool hasIndices = this.HasIndices;
			if (hasIndices)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Indices);
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Triangles);
			}
			bool hasDegenerateTriangles = this.HasDegenerateTriangles;
			if (hasDegenerateTriangles)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DegenerateTriangles);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002B460 File Offset: 0x00029660
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
			bool hasIndices = this.HasIndices;
			if (hasIndices)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Indices);
			}
			bool hasTriangles = this.HasTriangles;
			if (hasTriangles)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Triangles);
			}
			bool hasDegenerateTriangles = this.HasDegenerateTriangles;
			if (hasDegenerateTriangles)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DegenerateTriangles);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002B528 File Offset: 0x00029728
		[DebuggerNonUserCode]
		public void MergeFrom(GeometryInfo other)
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
				bool hasIndices = other.HasIndices;
				if (hasIndices)
				{
					this.Indices = other.Indices;
				}
				bool hasTriangles = other.HasTriangles;
				if (hasTriangles)
				{
					this.Triangles = other.Triangles;
				}
				bool hasDegenerateTriangles = other.HasDegenerateTriangles;
				if (hasDegenerateTriangles)
				{
					this.DegenerateTriangles = other.DegenerateTriangles;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002B5DC File Offset: 0x000297DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002B5E8 File Offset: 0x000297E8
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
						this.Vertices = input.ReadInt32();
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
						this.DegenerateTriangles = input.ReadInt32();
					}
					else
					{
						this.Triangles = input.ReadInt32();
					}
				}
				else
				{
					this.Indices = input.ReadInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000467 RID: 1127
		private static readonly MessageParser<GeometryInfo> _parser = new MessageParser<GeometryInfo>(() => new GeometryInfo());

		// Token: 0x04000468 RID: 1128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000469 RID: 1129
		private int _hasBits0;

		// Token: 0x0400046A RID: 1130
		public const int NameFieldNumber = 1;

		// Token: 0x0400046B RID: 1131
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400046C RID: 1132
		private string name_;

		// Token: 0x0400046D RID: 1133
		public const int VerticesFieldNumber = 2;

		// Token: 0x0400046E RID: 1134
		private static readonly int VerticesDefaultValue = 0;

		// Token: 0x0400046F RID: 1135
		private int vertices_;

		// Token: 0x04000470 RID: 1136
		public const int IndicesFieldNumber = 3;

		// Token: 0x04000471 RID: 1137
		private static readonly int IndicesDefaultValue = 0;

		// Token: 0x04000472 RID: 1138
		private int indices_;

		// Token: 0x04000473 RID: 1139
		public const int TrianglesFieldNumber = 4;

		// Token: 0x04000474 RID: 1140
		private static readonly int TrianglesDefaultValue = 0;

		// Token: 0x04000475 RID: 1141
		private int triangles_;

		// Token: 0x04000476 RID: 1142
		public const int DegenerateTrianglesFieldNumber = 5;

		// Token: 0x04000477 RID: 1143
		private static readonly int DegenerateTrianglesDefaultValue = 0;

		// Token: 0x04000478 RID: 1144
		private int degenerateTriangles_;
	}
}

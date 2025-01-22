using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F0 RID: 240
	public sealed class MeshData : IMessage<MeshData>, IMessage, IEquatable<MeshData>, IDeepCloneable<MeshData>, IBufferMessage
	{
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00053EBC File Offset: 0x000520BC
		[DebuggerNonUserCode]
		public static MessageParser<MeshData> Parser
		{
			get
			{
				return MeshData._parser;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00053ED4 File Offset: 0x000520D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[217];
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00053EFC File Offset: 0x000520FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MeshData.Descriptor;
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00053F13 File Offset: 0x00052113
		[DebuggerNonUserCode]
		public MeshData()
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00053F33 File Offset: 0x00052133
		[DebuggerNonUserCode]
		public MeshData(MeshData other)
			: this()
		{
			this.indexList_ = other.indexList_.Clone();
			this.vertList_ = other.vertList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00053F70 File Offset: 0x00052170
		[DebuggerNonUserCode]
		public MeshData Clone()
		{
			return new MeshData(this);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00053F88 File Offset: 0x00052188
		[DebuggerNonUserCode]
		public RepeatedField<int> IndexList
		{
			get
			{
				return this.indexList_;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00053FA0 File Offset: 0x000521A0
		[DebuggerNonUserCode]
		public RepeatedField<Vector3> VertList
		{
			get
			{
				return this.vertList_;
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00053FB8 File Offset: 0x000521B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MeshData);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00053FD8 File Offset: 0x000521D8
		[DebuggerNonUserCode]
		public bool Equals(MeshData other)
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
					bool flag4 = !this.indexList_.Equals(other.indexList_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.vertList_.Equals(other.vertList_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00054050 File Offset: 0x00052250
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.indexList_.GetHashCode();
			num ^= this.vertList_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x000540A0 File Offset: 0x000522A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000540B8 File Offset: 0x000522B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x000540C4 File Offset: 0x000522C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.indexList_.WriteTo(ref output, MeshData._repeated_indexList_codec);
			this.vertList_.WriteTo(ref output, MeshData._repeated_vertList_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00054114 File Offset: 0x00052314
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.indexList_.CalculateSize(MeshData._repeated_indexList_codec);
			num += this.vertList_.CalculateSize(MeshData._repeated_vertList_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0005416C File Offset: 0x0005236C
		[DebuggerNonUserCode]
		public void MergeFrom(MeshData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.indexList_.Add(other.indexList_);
				this.vertList_.Add(other.vertList_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x000541C0 File Offset: 0x000523C0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000541CC File Offset: 0x000523CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.vertList_.AddEntriesFrom(ref input, MeshData._repeated_vertList_codec);
					}
				}
				else
				{
					this.indexList_.AddEntriesFrom(ref input, MeshData._repeated_indexList_codec);
				}
			}
		}

		// Token: 0x04000969 RID: 2409
		private static readonly MessageParser<MeshData> _parser = new MessageParser<MeshData>(() => new MeshData());

		// Token: 0x0400096A RID: 2410
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400096B RID: 2411
		public const int IndexListFieldNumber = 1;

		// Token: 0x0400096C RID: 2412
		private static readonly FieldCodec<int> _repeated_indexList_codec = FieldCodec.ForInt32(8U);

		// Token: 0x0400096D RID: 2413
		private readonly RepeatedField<int> indexList_ = new RepeatedField<int>();

		// Token: 0x0400096E RID: 2414
		public const int VertListFieldNumber = 2;

		// Token: 0x0400096F RID: 2415
		private static readonly FieldCodec<Vector3> _repeated_vertList_codec = FieldCodec.ForMessage<Vector3>(18U, Vector3.Parser);

		// Token: 0x04000970 RID: 2416
		private readonly RepeatedField<Vector3> vertList_ = new RepeatedField<Vector3>();
	}
}

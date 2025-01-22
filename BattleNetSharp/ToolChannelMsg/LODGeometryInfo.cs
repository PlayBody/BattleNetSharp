using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000080 RID: 128
	public sealed class LODGeometryInfo : IMessage<LODGeometryInfo>, IMessage, IEquatable<LODGeometryInfo>, IDeepCloneable<LODGeometryInfo>, IBufferMessage
	{
		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002B6E0 File Offset: 0x000298E0
		[DebuggerNonUserCode]
		public static MessageParser<LODGeometryInfo> Parser
		{
			get
			{
				return LODGeometryInfo._parser;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0002B6F8 File Offset: 0x000298F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[105];
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0002B71C File Offset: 0x0002991C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LODGeometryInfo.Descriptor;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002B733 File Offset: 0x00029933
		[DebuggerNonUserCode]
		public LODGeometryInfo()
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002B754 File Offset: 0x00029954
		[DebuggerNonUserCode]
		public LODGeometryInfo(LODGeometryInfo other)
			: this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.subObjects_ = other.subObjects_.Clone();
			this.lookInfos_ = other.lookInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002B7B8 File Offset: 0x000299B8
		[DebuggerNonUserCode]
		public LODGeometryInfo Clone()
		{
			return new LODGeometryInfo(this);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002B7D0 File Offset: 0x000299D0
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0002B7E8 File Offset: 0x000299E8
		[DebuggerNonUserCode]
		public GeometryInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002B7F4 File Offset: 0x000299F4
		[DebuggerNonUserCode]
		public RepeatedField<GeometryInfo> SubObjects
		{
			get
			{
				return this.subObjects_;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0002B80C File Offset: 0x00029A0C
		[DebuggerNonUserCode]
		public RepeatedField<LookInfo> LookInfos
		{
			get
			{
				return this.lookInfos_;
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002B824 File Offset: 0x00029A24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LODGeometryInfo);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002B844 File Offset: 0x00029A44
		[DebuggerNonUserCode]
		public bool Equals(LODGeometryInfo other)
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
					bool flag4 = !object.Equals(this.Info, other.Info);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.subObjects_.Equals(other.subObjects_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.lookInfos_.Equals(other.lookInfos_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002B8DC File Offset: 0x00029ADC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.info_ != null;
			if (flag)
			{
				num ^= this.Info.GetHashCode();
			}
			num ^= this.subObjects_.GetHashCode();
			num ^= this.lookInfos_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002B948 File Offset: 0x00029B48
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002B960 File Offset: 0x00029B60
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002B96C File Offset: 0x00029B6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.info_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			this.subObjects_.WriteTo(ref output, LODGeometryInfo._repeated_subObjects_codec);
			this.lookInfos_.WriteTo(ref output, LODGeometryInfo._repeated_lookInfos_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.info_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			num += this.subObjects_.CalculateSize(LODGeometryInfo._repeated_subObjects_codec);
			num += this.lookInfos_.CalculateSize(LODGeometryInfo._repeated_lookInfos_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002BA58 File Offset: 0x00029C58
		[DebuggerNonUserCode]
		public void MergeFrom(LODGeometryInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.info_ != null;
				if (flag2)
				{
					bool flag3 = this.info_ == null;
					if (flag3)
					{
						this.Info = new GeometryInfo();
					}
					this.Info.MergeFrom(other.Info);
				}
				this.subObjects_.Add(other.subObjects_);
				this.lookInfos_.Add(other.lookInfos_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002BAF4 File Offset: 0x00029CF4
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
							this.lookInfos_.AddEntriesFrom(ref input, LODGeometryInfo._repeated_lookInfos_codec);
						}
					}
					else
					{
						this.subObjects_.AddEntriesFrom(ref input, LODGeometryInfo._repeated_subObjects_codec);
					}
				}
				else
				{
					bool flag = this.info_ == null;
					if (flag)
					{
						this.Info = new GeometryInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04000479 RID: 1145
		private static readonly MessageParser<LODGeometryInfo> _parser = new MessageParser<LODGeometryInfo>(() => new LODGeometryInfo());

		// Token: 0x0400047A RID: 1146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400047B RID: 1147
		public const int InfoFieldNumber = 1;

		// Token: 0x0400047C RID: 1148
		private GeometryInfo info_;

		// Token: 0x0400047D RID: 1149
		public const int SubObjectsFieldNumber = 2;

		// Token: 0x0400047E RID: 1150
		private static readonly FieldCodec<GeometryInfo> _repeated_subObjects_codec = FieldCodec.ForMessage<GeometryInfo>(18U, GeometryInfo.Parser);

		// Token: 0x0400047F RID: 1151
		private readonly RepeatedField<GeometryInfo> subObjects_ = new RepeatedField<GeometryInfo>();

		// Token: 0x04000480 RID: 1152
		public const int LookInfosFieldNumber = 3;

		// Token: 0x04000481 RID: 1153
		private static readonly FieldCodec<LookInfo> _repeated_lookInfos_codec = FieldCodec.ForMessage<LookInfo>(26U, LookInfo.Parser);

		// Token: 0x04000482 RID: 1154
		private readonly RepeatedField<LookInfo> lookInfos_ = new RepeatedField<LookInfo>();
	}
}

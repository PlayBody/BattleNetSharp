using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F1 RID: 241
	public sealed class AppearanceMeshData : IMessage<AppearanceMeshData>, IMessage, IEquatable<AppearanceMeshData>, IDeepCloneable<AppearanceMeshData>, IBufferMessage
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x0005427C File Offset: 0x0005247C
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceMeshData> Parser
		{
			get
			{
				return AppearanceMeshData._parser;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00054294 File Offset: 0x00052494
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[218];
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000542BC File Offset: 0x000524BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceMeshData.Descriptor;
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000542D3 File Offset: 0x000524D3
		[DebuggerNonUserCode]
		public AppearanceMeshData()
		{
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000542E8 File Offset: 0x000524E8
		[DebuggerNonUserCode]
		public AppearanceMeshData(AppearanceMeshData other)
			: this()
		{
			this.meshDataList_ = other.meshDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00054314 File Offset: 0x00052514
		[DebuggerNonUserCode]
		public AppearanceMeshData Clone()
		{
			return new AppearanceMeshData(this);
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0005432C File Offset: 0x0005252C
		[DebuggerNonUserCode]
		public RepeatedField<MeshData> MeshDataList
		{
			get
			{
				return this.meshDataList_;
			}
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00054344 File Offset: 0x00052544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceMeshData);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00054364 File Offset: 0x00052564
		[DebuggerNonUserCode]
		public bool Equals(AppearanceMeshData other)
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
					bool flag4 = !this.meshDataList_.Equals(other.meshDataList_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000543C0 File Offset: 0x000525C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.meshDataList_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00054400 File Offset: 0x00052600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x00054418 File Offset: 0x00052618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00054424 File Offset: 0x00052624
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.meshDataList_.WriteTo(ref output, AppearanceMeshData._repeated_meshDataList_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00054460 File Offset: 0x00052660
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.meshDataList_.CalculateSize(AppearanceMeshData._repeated_meshDataList_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000544A8 File Offset: 0x000526A8
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceMeshData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.meshDataList_.Add(other.meshDataList_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000544EA File Offset: 0x000526EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000544F8 File Offset: 0x000526F8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.meshDataList_.AddEntriesFrom(ref input, AppearanceMeshData._repeated_meshDataList_codec);
				}
			}
		}

		// Token: 0x04000971 RID: 2417
		private static readonly MessageParser<AppearanceMeshData> _parser = new MessageParser<AppearanceMeshData>(() => new AppearanceMeshData());

		// Token: 0x04000972 RID: 2418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000973 RID: 2419
		public const int MeshDataListFieldNumber = 1;

		// Token: 0x04000974 RID: 2420
		private static readonly FieldCodec<MeshData> _repeated_meshDataList_codec = FieldCodec.ForMessage<MeshData>(10U, MeshData.Parser);

		// Token: 0x04000975 RID: 2421
		private readonly RepeatedField<MeshData> meshDataList_ = new RepeatedField<MeshData>();
	}
}

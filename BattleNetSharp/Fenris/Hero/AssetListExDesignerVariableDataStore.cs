using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001B2 RID: 434
	public sealed class AssetListExDesignerVariableDataStore : IMessage<AssetListExDesignerVariableDataStore>, IMessage, IEquatable<AssetListExDesignerVariableDataStore>, IDeepCloneable<AssetListExDesignerVariableDataStore>, IBufferMessage
	{
		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000B3008 File Offset: 0x000B1208
		[DebuggerNonUserCode]
		public static MessageParser<AssetListExDesignerVariableDataStore> Parser
		{
			get
			{
				return AssetListExDesignerVariableDataStore._parser;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000B3020 File Offset: 0x000B1220
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000B3044 File Offset: 0x000B1244
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssetListExDesignerVariableDataStore.Descriptor;
			}
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x000B305B File Offset: 0x000B125B
		[DebuggerNonUserCode]
		public AssetListExDesignerVariableDataStore()
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000B307C File Offset: 0x000B127C
		[DebuggerNonUserCode]
		public AssetListExDesignerVariableDataStore(AssetListExDesignerVariableDataStore other)
			: this()
		{
			this.assetList_ = ((other.assetList_ != null) ? other.assetList_.Clone() : null);
			this.packedDatas_ = other.packedDatas_.Clone();
			this.looseDatas_ = other.looseDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000B30E0 File Offset: 0x000B12E0
		[DebuggerNonUserCode]
		public AssetListExDesignerVariableDataStore Clone()
		{
			return new AssetListExDesignerVariableDataStore(this);
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000B30F8 File Offset: 0x000B12F8
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x000B3110 File Offset: 0x000B1310
		[DebuggerNonUserCode]
		public AssetListDataStore AssetList
		{
			get
			{
				return this.assetList_;
			}
			set
			{
				this.assetList_ = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000B311C File Offset: 0x000B131C
		[DebuggerNonUserCode]
		public RepeatedField<DesignerVariableDataStore> PackedDatas
		{
			get
			{
				return this.packedDatas_;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x000B3134 File Offset: 0x000B1334
		[DebuggerNonUserCode]
		public RepeatedField<DesignerVariableDataStore> LooseDatas
		{
			get
			{
				return this.looseDatas_;
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000B314C File Offset: 0x000B134C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssetListExDesignerVariableDataStore);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000B316C File Offset: 0x000B136C
		[DebuggerNonUserCode]
		public bool Equals(AssetListExDesignerVariableDataStore other)
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
					bool flag4 = !object.Equals(this.AssetList, other.AssetList);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.packedDatas_.Equals(other.packedDatas_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.looseDatas_.Equals(other.looseDatas_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000B3204 File Offset: 0x000B1404
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.assetList_ != null;
			if (flag)
			{
				num ^= this.AssetList.GetHashCode();
			}
			num ^= this.packedDatas_.GetHashCode();
			num ^= this.looseDatas_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000B3270 File Offset: 0x000B1470
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000B3288 File Offset: 0x000B1488
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x000B3294 File Offset: 0x000B1494
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.assetList_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AssetList);
			}
			this.packedDatas_.WriteTo(ref output, AssetListExDesignerVariableDataStore._repeated_packedDatas_codec);
			this.looseDatas_.WriteTo(ref output, AssetListExDesignerVariableDataStore._repeated_looseDatas_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x000B3308 File Offset: 0x000B1508
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.assetList_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AssetList);
			}
			num += this.packedDatas_.CalculateSize(AssetListExDesignerVariableDataStore._repeated_packedDatas_codec);
			num += this.looseDatas_.CalculateSize(AssetListExDesignerVariableDataStore._repeated_looseDatas_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x000B3380 File Offset: 0x000B1580
		[DebuggerNonUserCode]
		public void MergeFrom(AssetListExDesignerVariableDataStore other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.assetList_ != null;
				if (flag2)
				{
					bool flag3 = this.assetList_ == null;
					if (flag3)
					{
						this.AssetList = new AssetListDataStore();
					}
					this.AssetList.MergeFrom(other.AssetList);
				}
				this.packedDatas_.Add(other.packedDatas_);
				this.looseDatas_.Add(other.looseDatas_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x000B3410 File Offset: 0x000B1610
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x000B341C File Offset: 0x000B161C
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
							this.looseDatas_.AddEntriesFrom(ref input, AssetListExDesignerVariableDataStore._repeated_looseDatas_codec);
						}
					}
					else
					{
						this.packedDatas_.AddEntriesFrom(ref input, AssetListExDesignerVariableDataStore._repeated_packedDatas_codec);
					}
				}
				else
				{
					bool flag = this.assetList_ == null;
					if (flag)
					{
						this.AssetList = new AssetListDataStore();
					}
					input.ReadMessage(this.AssetList);
				}
			}
		}

		// Token: 0x040014A4 RID: 5284
		private static readonly MessageParser<AssetListExDesignerVariableDataStore> _parser = new MessageParser<AssetListExDesignerVariableDataStore>(() => new AssetListExDesignerVariableDataStore());

		// Token: 0x040014A5 RID: 5285
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014A6 RID: 5286
		public const int AssetListFieldNumber = 1;

		// Token: 0x040014A7 RID: 5287
		private AssetListDataStore assetList_;

		// Token: 0x040014A8 RID: 5288
		public const int PackedDatasFieldNumber = 2;

		// Token: 0x040014A9 RID: 5289
		private static readonly FieldCodec<DesignerVariableDataStore> _repeated_packedDatas_codec = FieldCodec.ForMessage<DesignerVariableDataStore>(18U, DesignerVariableDataStore.Parser);

		// Token: 0x040014AA RID: 5290
		private readonly RepeatedField<DesignerVariableDataStore> packedDatas_ = new RepeatedField<DesignerVariableDataStore>();

		// Token: 0x040014AB RID: 5291
		public const int LooseDatasFieldNumber = 3;

		// Token: 0x040014AC RID: 5292
		private static readonly FieldCodec<DesignerVariableDataStore> _repeated_looseDatas_codec = FieldCodec.ForMessage<DesignerVariableDataStore>(26U, DesignerVariableDataStore.Parser);

		// Token: 0x040014AD RID: 5293
		private readonly RepeatedField<DesignerVariableDataStore> looseDatas_ = new RepeatedField<DesignerVariableDataStore>();
	}
}

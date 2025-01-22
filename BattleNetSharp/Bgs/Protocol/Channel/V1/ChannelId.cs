using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006B6 RID: 1718
	public sealed class ChannelId : IMessage<ChannelId>, IMessage, IEquatable<ChannelId>, IDeepCloneable<ChannelId>, IBufferMessage
	{
		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x06009EE4 RID: 40676 RVA: 0x0026A5B8 File Offset: 0x002687B8
		[DebuggerNonUserCode]
		public static MessageParser<ChannelId> Parser
		{
			get
			{
				return ChannelId._parser;
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x0026A5D0 File Offset: 0x002687D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelIdReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x0026A5F4 File Offset: 0x002687F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelId.Descriptor;
			}
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x0026A60B File Offset: 0x0026880B
		[DebuggerNonUserCode]
		public ChannelId()
		{
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x0026A618 File Offset: 0x00268818
		[DebuggerNonUserCode]
		public ChannelId(ChannelId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.id_ = other.id_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x0026A68C File Offset: 0x0026888C
		[DebuggerNonUserCode]
		public ChannelId Clone()
		{
			return new ChannelId(this);
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x06009EEA RID: 40682 RVA: 0x0026A6A4 File Offset: 0x002688A4
		// (set) Token: 0x06009EEB RID: 40683 RVA: 0x0026A6D5 File Offset: 0x002688D5
		[DebuggerNonUserCode]
		public uint Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = ChannelId.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x0026A6F0 File Offset: 0x002688F0
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x0026A70D File Offset: 0x0026890D
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x0026A720 File Offset: 0x00268920
		// (set) Token: 0x06009EEF RID: 40687 RVA: 0x0026A738 File Offset: 0x00268938
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x06009EF0 RID: 40688 RVA: 0x0026A744 File Offset: 0x00268944
		// (set) Token: 0x06009EF1 RID: 40689 RVA: 0x0026A775 File Offset: 0x00268975
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
					idDefaultValue = ChannelId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x0026A790 File Offset: 0x00268990
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x0026A7AD File Offset: 0x002689AD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x06009EF4 RID: 40692 RVA: 0x0026A7C0 File Offset: 0x002689C0
		// (set) Token: 0x06009EF5 RID: 40693 RVA: 0x0026A7F1 File Offset: 0x002689F1
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = ChannelId.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.region_ = value;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x06009EF6 RID: 40694 RVA: 0x0026A80C File Offset: 0x00268A0C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x0026A829 File Offset: 0x00268A29
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x0026A83C File Offset: 0x00268A3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelId);
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x0026A85C File Offset: 0x00268A5C
		[DebuggerNonUserCode]
		public bool Equals(ChannelId other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Host, other.Host);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Id != other.Id;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Region != other.Region;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x0026A90C File Offset: 0x00268B0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x0026A9B4 File Offset: 0x00268BB4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x0026A9CC File Offset: 0x00268BCC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x0026A9D8 File Offset: 0x00268BD8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Type);
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Host);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Id);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Region);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009EFE RID: 40702 RVA: 0x0026AA90 File Offset: 0x00268C90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009EFF RID: 40703 RVA: 0x0026AB30 File Offset: 0x00268D30
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x0026ABEE File Offset: 0x00268DEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x0026ABFC File Offset: 0x00268DFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_002B;
						}
						bool flag = this.host_ == null;
						if (flag)
						{
							this.Host = new ProcessId();
						}
						input.ReadMessage(this.Host);
					}
					else
					{
						this.Type = input.ReadUInt32();
					}
				}
				else if (num3 != 29U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.Region = input.ReadUInt32();
				}
				else
				{
					this.Id = input.ReadFixed32();
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047AE RID: 18350
		private static readonly MessageParser<ChannelId> _parser = new MessageParser<ChannelId>(() => new ChannelId());

		// Token: 0x040047AF RID: 18351
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047B0 RID: 18352
		private int _hasBits0;

		// Token: 0x040047B1 RID: 18353
		public const int TypeFieldNumber = 1;

		// Token: 0x040047B2 RID: 18354
		private static readonly uint TypeDefaultValue = 0U;

		// Token: 0x040047B3 RID: 18355
		private uint type_;

		// Token: 0x040047B4 RID: 18356
		public const int HostFieldNumber = 2;

		// Token: 0x040047B5 RID: 18357
		private ProcessId host_;

		// Token: 0x040047B6 RID: 18358
		public const int IdFieldNumber = 3;

		// Token: 0x040047B7 RID: 18359
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x040047B8 RID: 18360
		private uint id_;

		// Token: 0x040047B9 RID: 18361
		public const int RegionFieldNumber = 4;

		// Token: 0x040047BA RID: 18362
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x040047BB RID: 18363
		private uint region_;
	}
}

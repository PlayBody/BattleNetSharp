using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000716 RID: 1814
	public sealed class GetAccountStateRequest : IMessage<GetAccountStateRequest>, IMessage, IEquatable<GetAccountStateRequest>, IDeepCloneable<GetAccountStateRequest>, IBufferMessage
	{
		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A63A RID: 42554 RVA: 0x00287650 File Offset: 0x00285850
		[DebuggerNonUserCode]
		public static MessageParser<GetAccountStateRequest> Parser
		{
			get
			{
				return GetAccountStateRequest._parser;
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x00287668 File Offset: 0x00285868
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x0028768C File Offset: 0x0028588C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAccountStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x002876A3 File Offset: 0x002858A3
		[DebuggerNonUserCode]
		public GetAccountStateRequest()
		{
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x002876B0 File Offset: 0x002858B0
		[DebuggerNonUserCode]
		public GetAccountStateRequest(GetAccountStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.program_ = other.program_;
			this.region_ = other.region_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.tags_ = ((other.tags_ != null) ? other.tags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x00287750 File Offset: 0x00285950
		[DebuggerNonUserCode]
		public GetAccountStateRequest Clone()
		{
			return new GetAccountStateRequest(this);
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A640 RID: 42560 RVA: 0x00287768 File Offset: 0x00285968
		// (set) Token: 0x0600A641 RID: 42561 RVA: 0x00287780 File Offset: 0x00285980
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A642 RID: 42562 RVA: 0x0028778C File Offset: 0x0028598C
		// (set) Token: 0x0600A643 RID: 42563 RVA: 0x002877BD File Offset: 0x002859BD
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = GetAccountStateRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x002877D8 File Offset: 0x002859D8
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x002877F5 File Offset: 0x002859F5
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A646 RID: 42566 RVA: 0x00287808 File Offset: 0x00285A08
		// (set) Token: 0x0600A647 RID: 42567 RVA: 0x00287839 File Offset: 0x00285A39
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = GetAccountStateRequest.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.region_ = value;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A648 RID: 42568 RVA: 0x00287854 File Offset: 0x00285A54
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x00287871 File Offset: 0x00285A71
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x00287884 File Offset: 0x00285A84
		// (set) Token: 0x0600A64B RID: 42571 RVA: 0x0028789C File Offset: 0x00285A9C
		[DebuggerNonUserCode]
		public AccountFieldOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x002878A8 File Offset: 0x00285AA8
		// (set) Token: 0x0600A64D RID: 42573 RVA: 0x002878C0 File Offset: 0x00285AC0
		[DebuggerNonUserCode]
		public AccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x002878CC File Offset: 0x00285ACC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAccountStateRequest);
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x002878EC File Offset: 0x00285AEC
		[DebuggerNonUserCode]
		public bool Equals(GetAccountStateRequest other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Region != other.Region;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Options, other.Options);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Tags, other.Tags);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x002879C0 File Offset: 0x00285BC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this.tags_ != null;
			if (flag3)
			{
				num ^= this.Tags.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x00287A84 File Offset: 0x00285C84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x00287A9C File Offset: 0x00285C9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x00287AA8 File Offset: 0x00285CA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Program);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Region);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this.tags_ != null;
			if (flag3)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Tags);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x00287B8C File Offset: 0x00285D8C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this.tags_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x00287C5C File Offset: 0x00285E5C
		[DebuggerNonUserCode]
		public void MergeFrom(GetAccountStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new AccountFieldOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool flag6 = other.tags_ != null;
				if (flag6)
				{
					bool flag7 = this.tags_ == null;
					if (flag7)
					{
						this.Tags = new AccountFieldTags();
					}
					this.Tags.MergeFrom(other.Tags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x00287D7F File Offset: 0x00285F7F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x00287D8C File Offset: 0x00285F8C
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
							goto IL_0036;
						}
						this.Program = input.ReadUInt32();
					}
					else
					{
						bool flag = this.entityId_ == null;
						if (flag)
						{
							this.EntityId = new EntityId();
						}
						input.ReadMessage(this.EntityId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_0036;
						}
						bool flag2 = this.tags_ == null;
						if (flag2)
						{
							this.Tags = new AccountFieldTags();
						}
						input.ReadMessage(this.Tags);
					}
					else
					{
						bool flag3 = this.options_ == null;
						if (flag3)
						{
							this.Options = new AccountFieldOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					this.Region = input.ReadUInt32();
				}
				continue;
				IL_0036:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AB2 RID: 19122
		private static readonly MessageParser<GetAccountStateRequest> _parser = new MessageParser<GetAccountStateRequest>(() => new GetAccountStateRequest());

		// Token: 0x04004AB3 RID: 19123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AB4 RID: 19124
		private int _hasBits0;

		// Token: 0x04004AB5 RID: 19125
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004AB6 RID: 19126
		private EntityId entityId_;

		// Token: 0x04004AB7 RID: 19127
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004AB8 RID: 19128
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004AB9 RID: 19129
		private uint program_;

		// Token: 0x04004ABA RID: 19130
		public const int RegionFieldNumber = 3;

		// Token: 0x04004ABB RID: 19131
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004ABC RID: 19132
		private uint region_;

		// Token: 0x04004ABD RID: 19133
		public const int OptionsFieldNumber = 10;

		// Token: 0x04004ABE RID: 19134
		private AccountFieldOptions options_;

		// Token: 0x04004ABF RID: 19135
		public const int TagsFieldNumber = 11;

		// Token: 0x04004AC0 RID: 19136
		private AccountFieldTags tags_;
	}
}

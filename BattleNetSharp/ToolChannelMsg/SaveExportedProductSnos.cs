using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000100 RID: 256
	public sealed class SaveExportedProductSnos : IMessage<SaveExportedProductSnos>, IMessage, IEquatable<SaveExportedProductSnos>, IDeepCloneable<SaveExportedProductSnos>, IBufferMessage
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000575A8 File Offset: 0x000557A8
		[DebuggerNonUserCode]
		public static MessageParser<SaveExportedProductSnos> Parser
		{
			get
			{
				return SaveExportedProductSnos._parser;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x000575C0 File Offset: 0x000557C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[233];
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000575E8 File Offset: 0x000557E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SaveExportedProductSnos.Descriptor;
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000575FF File Offset: 0x000557FF
		[DebuggerNonUserCode]
		public SaveExportedProductSnos()
		{
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00057614 File Offset: 0x00055814
		[DebuggerNonUserCode]
		public SaveExportedProductSnos(SaveExportedProductSnos other)
			: this()
		{
			this.entries_ = other.entries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00057640 File Offset: 0x00055840
		[DebuggerNonUserCode]
		public SaveExportedProductSnos Clone()
		{
			return new SaveExportedProductSnos(this);
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00057658 File Offset: 0x00055858
		[DebuggerNonUserCode]
		public RepeatedField<SaveExportedProductSnos.Types.ExportedProductSno> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00057670 File Offset: 0x00055870
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SaveExportedProductSnos);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00057690 File Offset: 0x00055890
		[DebuggerNonUserCode]
		public bool Equals(SaveExportedProductSnos other)
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
					bool flag4 = !this.entries_.Equals(other.entries_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000576EC File Offset: 0x000558EC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0005772C File Offset: 0x0005592C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00057744 File Offset: 0x00055944
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00057750 File Offset: 0x00055950
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entries_.WriteTo(ref output, SaveExportedProductSnos._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0005778C File Offset: 0x0005598C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entries_.CalculateSize(SaveExportedProductSnos._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000577D4 File Offset: 0x000559D4
		[DebuggerNonUserCode]
		public void MergeFrom(SaveExportedProductSnos other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.entries_.Add(other.entries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00057816 File Offset: 0x00055A16
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00057824 File Offset: 0x00055A24
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
					this.entries_.AddEntriesFrom(ref input, SaveExportedProductSnos._repeated_entries_codec);
				}
			}
		}

		// Token: 0x040009C4 RID: 2500
		private static readonly MessageParser<SaveExportedProductSnos> _parser = new MessageParser<SaveExportedProductSnos>(() => new SaveExportedProductSnos());

		// Token: 0x040009C5 RID: 2501
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009C6 RID: 2502
		public const int EntriesFieldNumber = 1;

		// Token: 0x040009C7 RID: 2503
		private static readonly FieldCodec<SaveExportedProductSnos.Types.ExportedProductSno> _repeated_entries_codec = FieldCodec.ForMessage<SaveExportedProductSnos.Types.ExportedProductSno>(10U, SaveExportedProductSnos.Types.ExportedProductSno.Parser);

		// Token: 0x040009C8 RID: 2504
		private readonly RepeatedField<SaveExportedProductSnos.Types.ExportedProductSno> entries_ = new RepeatedField<SaveExportedProductSnos.Types.ExportedProductSno>();

		// Token: 0x02000C1D RID: 3101
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001471 RID: 5233
			public sealed class ExportedProductSno : IMessage<SaveExportedProductSnos.Types.ExportedProductSno>, IMessage, IEquatable<SaveExportedProductSnos.Types.ExportedProductSno>, IDeepCloneable<SaveExportedProductSnos.Types.ExportedProductSno>, IBufferMessage
			{
				// Token: 0x17003A64 RID: 14948
				// (get) Token: 0x0600E57B RID: 58747 RVA: 0x004D4C68 File Offset: 0x004D2E68
				[DebuggerNonUserCode]
				public static MessageParser<SaveExportedProductSnos.Types.ExportedProductSno> Parser
				{
					get
					{
						return SaveExportedProductSnos.Types.ExportedProductSno._parser;
					}
				}

				// Token: 0x17003A65 RID: 14949
				// (get) Token: 0x0600E57C RID: 58748 RVA: 0x004D4C80 File Offset: 0x004D2E80
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return SaveExportedProductSnos.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003A66 RID: 14950
				// (get) Token: 0x0600E57D RID: 58749 RVA: 0x004D4CA4 File Offset: 0x004D2EA4
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return SaveExportedProductSnos.Types.ExportedProductSno.Descriptor;
					}
				}

				// Token: 0x0600E57E RID: 58750 RVA: 0x004D4CBB File Offset: 0x004D2EBB
				[DebuggerNonUserCode]
				public ExportedProductSno()
				{
				}

				// Token: 0x0600E57F RID: 58751 RVA: 0x004D4CC8 File Offset: 0x004D2EC8
				[DebuggerNonUserCode]
				public ExportedProductSno(SaveExportedProductSnos.Types.ExportedProductSno other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.snoHandle_ = other.snoHandle_;
					this.bnetLicenseId_ = other.bnetLicenseId_;
					this.bnetProductId_ = other.bnetProductId_;
					this.bnetImageId_ = other.bnetImageId_;
					this.bnetImageHash_ = other.bnetImageHash_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E580 RID: 58752 RVA: 0x004D4D38 File Offset: 0x004D2F38
				[DebuggerNonUserCode]
				public SaveExportedProductSnos.Types.ExportedProductSno Clone()
				{
					return new SaveExportedProductSnos.Types.ExportedProductSno(this);
				}

				// Token: 0x17003A67 RID: 14951
				// (get) Token: 0x0600E581 RID: 58753 RVA: 0x004D4D50 File Offset: 0x004D2F50
				// (set) Token: 0x0600E582 RID: 58754 RVA: 0x004D4D81 File Offset: 0x004D2F81
				[DebuggerNonUserCode]
				public int SnoHandle
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int snoHandleDefaultValue;
						if (flag)
						{
							snoHandleDefaultValue = this.snoHandle_;
						}
						else
						{
							snoHandleDefaultValue = SaveExportedProductSnos.Types.ExportedProductSno.SnoHandleDefaultValue;
						}
						return snoHandleDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.snoHandle_ = value;
					}
				}

				// Token: 0x17003A68 RID: 14952
				// (get) Token: 0x0600E583 RID: 58755 RVA: 0x004D4D9C File Offset: 0x004D2F9C
				[DebuggerNonUserCode]
				public bool HasSnoHandle
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E584 RID: 58756 RVA: 0x004D4DB9 File Offset: 0x004D2FB9
				[DebuggerNonUserCode]
				public void ClearSnoHandle()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003A69 RID: 14953
				// (get) Token: 0x0600E585 RID: 58757 RVA: 0x004D4DCC File Offset: 0x004D2FCC
				// (set) Token: 0x0600E586 RID: 58758 RVA: 0x004D4DFD File Offset: 0x004D2FFD
				[DebuggerNonUserCode]
				public int BnetLicenseId
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int bnetLicenseIdDefaultValue;
						if (flag)
						{
							bnetLicenseIdDefaultValue = this.bnetLicenseId_;
						}
						else
						{
							bnetLicenseIdDefaultValue = SaveExportedProductSnos.Types.ExportedProductSno.BnetLicenseIdDefaultValue;
						}
						return bnetLicenseIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.bnetLicenseId_ = value;
					}
				}

				// Token: 0x17003A6A RID: 14954
				// (get) Token: 0x0600E587 RID: 58759 RVA: 0x004D4E18 File Offset: 0x004D3018
				[DebuggerNonUserCode]
				public bool HasBnetLicenseId
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E588 RID: 58760 RVA: 0x004D4E35 File Offset: 0x004D3035
				[DebuggerNonUserCode]
				public void ClearBnetLicenseId()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003A6B RID: 14955
				// (get) Token: 0x0600E589 RID: 58761 RVA: 0x004D4E48 File Offset: 0x004D3048
				// (set) Token: 0x0600E58A RID: 58762 RVA: 0x004D4E79 File Offset: 0x004D3079
				[DebuggerNonUserCode]
				public int BnetProductId
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						int bnetProductIdDefaultValue;
						if (flag)
						{
							bnetProductIdDefaultValue = this.bnetProductId_;
						}
						else
						{
							bnetProductIdDefaultValue = SaveExportedProductSnos.Types.ExportedProductSno.BnetProductIdDefaultValue;
						}
						return bnetProductIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.bnetProductId_ = value;
					}
				}

				// Token: 0x17003A6C RID: 14956
				// (get) Token: 0x0600E58B RID: 58763 RVA: 0x004D4E94 File Offset: 0x004D3094
				[DebuggerNonUserCode]
				public bool HasBnetProductId
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E58C RID: 58764 RVA: 0x004D4EB1 File Offset: 0x004D30B1
				[DebuggerNonUserCode]
				public void ClearBnetProductId()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003A6D RID: 14957
				// (get) Token: 0x0600E58D RID: 58765 RVA: 0x004D4EC4 File Offset: 0x004D30C4
				// (set) Token: 0x0600E58E RID: 58766 RVA: 0x004D4EF5 File Offset: 0x004D30F5
				[DebuggerNonUserCode]
				public int BnetImageId
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						int bnetImageIdDefaultValue;
						if (flag)
						{
							bnetImageIdDefaultValue = this.bnetImageId_;
						}
						else
						{
							bnetImageIdDefaultValue = SaveExportedProductSnos.Types.ExportedProductSno.BnetImageIdDefaultValue;
						}
						return bnetImageIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.bnetImageId_ = value;
					}
				}

				// Token: 0x17003A6E RID: 14958
				// (get) Token: 0x0600E58F RID: 58767 RVA: 0x004D4F10 File Offset: 0x004D3110
				[DebuggerNonUserCode]
				public bool HasBnetImageId
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E590 RID: 58768 RVA: 0x004D4F2D File Offset: 0x004D312D
				[DebuggerNonUserCode]
				public void ClearBnetImageId()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x17003A6F RID: 14959
				// (get) Token: 0x0600E591 RID: 58769 RVA: 0x004D4F40 File Offset: 0x004D3140
				// (set) Token: 0x0600E592 RID: 58770 RVA: 0x004D4F72 File Offset: 0x004D3172
				[DebuggerNonUserCode]
				public ulong BnetImageHash
				{
					get
					{
						bool flag = (this._hasBits0 & 16) != 0;
						ulong bnetImageHashDefaultValue;
						if (flag)
						{
							bnetImageHashDefaultValue = this.bnetImageHash_;
						}
						else
						{
							bnetImageHashDefaultValue = SaveExportedProductSnos.Types.ExportedProductSno.BnetImageHashDefaultValue;
						}
						return bnetImageHashDefaultValue;
					}
					set
					{
						this._hasBits0 |= 16;
						this.bnetImageHash_ = value;
					}
				}

				// Token: 0x17003A70 RID: 14960
				// (get) Token: 0x0600E593 RID: 58771 RVA: 0x004D4F8C File Offset: 0x004D318C
				[DebuggerNonUserCode]
				public bool HasBnetImageHash
				{
					get
					{
						return (this._hasBits0 & 16) != 0;
					}
				}

				// Token: 0x0600E594 RID: 58772 RVA: 0x004D4FAA File Offset: 0x004D31AA
				[DebuggerNonUserCode]
				public void ClearBnetImageHash()
				{
					this._hasBits0 &= -17;
				}

				// Token: 0x0600E595 RID: 58773 RVA: 0x004D4FBC File Offset: 0x004D31BC
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as SaveExportedProductSnos.Types.ExportedProductSno);
				}

				// Token: 0x0600E596 RID: 58774 RVA: 0x004D4FDC File Offset: 0x004D31DC
				[DebuggerNonUserCode]
				public bool Equals(SaveExportedProductSnos.Types.ExportedProductSno other)
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
							bool flag4 = this.SnoHandle != other.SnoHandle;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.BnetLicenseId != other.BnetLicenseId;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.BnetProductId != other.BnetProductId;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.BnetImageId != other.BnetImageId;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.BnetImageHash != other.BnetImageHash;
											flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E597 RID: 58775 RVA: 0x004D50A8 File Offset: 0x004D32A8
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						num ^= this.SnoHandle.GetHashCode();
					}
					bool hasBnetLicenseId = this.HasBnetLicenseId;
					if (hasBnetLicenseId)
					{
						num ^= this.BnetLicenseId.GetHashCode();
					}
					bool hasBnetProductId = this.HasBnetProductId;
					if (hasBnetProductId)
					{
						num ^= this.BnetProductId.GetHashCode();
					}
					bool hasBnetImageId = this.HasBnetImageId;
					if (hasBnetImageId)
					{
						num ^= this.BnetImageId.GetHashCode();
					}
					bool hasBnetImageHash = this.HasBnetImageHash;
					if (hasBnetImageHash)
					{
						num ^= this.BnetImageHash.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E598 RID: 58776 RVA: 0x004D516C File Offset: 0x004D336C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E599 RID: 58777 RVA: 0x004D5184 File Offset: 0x004D3384
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E59A RID: 58778 RVA: 0x004D5190 File Offset: 0x004D3390
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						output.WriteRawTag(8);
						output.WriteInt32(this.SnoHandle);
					}
					bool hasBnetLicenseId = this.HasBnetLicenseId;
					if (hasBnetLicenseId)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.BnetLicenseId);
					}
					bool hasBnetProductId = this.HasBnetProductId;
					if (hasBnetProductId)
					{
						output.WriteRawTag(24);
						output.WriteInt32(this.BnetProductId);
					}
					bool hasBnetImageId = this.HasBnetImageId;
					if (hasBnetImageId)
					{
						output.WriteRawTag(32);
						output.WriteInt32(this.BnetImageId);
					}
					bool hasBnetImageHash = this.HasBnetImageHash;
					if (hasBnetImageHash)
					{
						output.WriteRawTag(40);
						output.WriteUInt64(this.BnetImageHash);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E59B RID: 58779 RVA: 0x004D5268 File Offset: 0x004D3468
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
					}
					bool hasBnetLicenseId = this.HasBnetLicenseId;
					if (hasBnetLicenseId)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.BnetLicenseId);
					}
					bool hasBnetProductId = this.HasBnetProductId;
					if (hasBnetProductId)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.BnetProductId);
					}
					bool hasBnetImageId = this.HasBnetImageId;
					if (hasBnetImageId)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.BnetImageId);
					}
					bool hasBnetImageHash = this.HasBnetImageHash;
					if (hasBnetImageHash)
					{
						num += 1 + CodedOutputStream.ComputeUInt64Size(this.BnetImageHash);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E59C RID: 58780 RVA: 0x004D5330 File Offset: 0x004D3530
				[DebuggerNonUserCode]
				public void MergeFrom(SaveExportedProductSnos.Types.ExportedProductSno other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasSnoHandle = other.HasSnoHandle;
						if (hasSnoHandle)
						{
							this.SnoHandle = other.SnoHandle;
						}
						bool hasBnetLicenseId = other.HasBnetLicenseId;
						if (hasBnetLicenseId)
						{
							this.BnetLicenseId = other.BnetLicenseId;
						}
						bool hasBnetProductId = other.HasBnetProductId;
						if (hasBnetProductId)
						{
							this.BnetProductId = other.BnetProductId;
						}
						bool hasBnetImageId = other.HasBnetImageId;
						if (hasBnetImageId)
						{
							this.BnetImageId = other.BnetImageId;
						}
						bool hasBnetImageHash = other.HasBnetImageHash;
						if (hasBnetImageHash)
						{
							this.BnetImageHash = other.BnetImageHash;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E59D RID: 58781 RVA: 0x004D53E4 File Offset: 0x004D35E4
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E59E RID: 58782 RVA: 0x004D53F0 File Offset: 0x004D35F0
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
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									goto IL_0032;
								}
								this.BnetLicenseId = input.ReadInt32();
							}
							else
							{
								this.SnoHandle = input.ReadInt32();
							}
						}
						else if (num3 != 24U)
						{
							if (num3 != 32U)
							{
								if (num3 != 40U)
								{
									goto IL_0032;
								}
								this.BnetImageHash = input.ReadUInt64();
							}
							else
							{
								this.BnetImageId = input.ReadInt32();
							}
						}
						else
						{
							this.BnetProductId = input.ReadInt32();
						}
						continue;
						IL_0032:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A349 RID: 41801
				private static readonly MessageParser<SaveExportedProductSnos.Types.ExportedProductSno> _parser = new MessageParser<SaveExportedProductSnos.Types.ExportedProductSno>(() => new SaveExportedProductSnos.Types.ExportedProductSno());

				// Token: 0x0400A34A RID: 41802
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A34B RID: 41803
				private int _hasBits0;

				// Token: 0x0400A34C RID: 41804
				public const int SnoHandleFieldNumber = 1;

				// Token: 0x0400A34D RID: 41805
				private static readonly int SnoHandleDefaultValue = 0;

				// Token: 0x0400A34E RID: 41806
				private int snoHandle_;

				// Token: 0x0400A34F RID: 41807
				public const int BnetLicenseIdFieldNumber = 2;

				// Token: 0x0400A350 RID: 41808
				private static readonly int BnetLicenseIdDefaultValue = 0;

				// Token: 0x0400A351 RID: 41809
				private int bnetLicenseId_;

				// Token: 0x0400A352 RID: 41810
				public const int BnetProductIdFieldNumber = 3;

				// Token: 0x0400A353 RID: 41811
				private static readonly int BnetProductIdDefaultValue = 0;

				// Token: 0x0400A354 RID: 41812
				private int bnetProductId_;

				// Token: 0x0400A355 RID: 41813
				public const int BnetImageIdFieldNumber = 4;

				// Token: 0x0400A356 RID: 41814
				private static readonly int BnetImageIdDefaultValue = 0;

				// Token: 0x0400A357 RID: 41815
				private int bnetImageId_;

				// Token: 0x0400A358 RID: 41816
				public const int BnetImageHashFieldNumber = 5;

				// Token: 0x0400A359 RID: 41817
				private static readonly ulong BnetImageHashDefaultValue = 0UL;

				// Token: 0x0400A35A RID: 41818
				private ulong bnetImageHash_;
			}
		}
	}
}

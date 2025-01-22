using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BB RID: 187
	public sealed class ExportToObjFileRequest : IMessage<ExportToObjFileRequest>, IMessage, IEquatable<ExportToObjFileRequest>, IDeepCloneable<ExportToObjFileRequest>, IBufferMessage
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000406B0 File Offset: 0x0003E8B0
		[DebuggerNonUserCode]
		public static MessageParser<ExportToObjFileRequest> Parser
		{
			get
			{
				return ExportToObjFileRequest._parser;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000406C8 File Offset: 0x0003E8C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[164];
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000406F0 File Offset: 0x0003E8F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExportToObjFileRequest.Descriptor;
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00040707 File Offset: 0x0003E907
		[DebuggerNonUserCode]
		public ExportToObjFileRequest()
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0004071C File Offset: 0x0003E91C
		[DebuggerNonUserCode]
		public ExportToObjFileRequest(ExportToObjFileRequest other)
			: this()
		{
			this.filename_ = other.filename_;
			this.entries_ = other.entries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00040754 File Offset: 0x0003E954
		[DebuggerNonUserCode]
		public ExportToObjFileRequest Clone()
		{
			return new ExportToObjFileRequest(this);
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0004076C File Offset: 0x0003E96C
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0004078D File Offset: 0x0003E98D
		[DebuggerNonUserCode]
		public string Filename
		{
			get
			{
				return this.filename_ ?? ExportToObjFileRequest.FilenameDefaultValue;
			}
			set
			{
				this.filename_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000407A4 File Offset: 0x0003E9A4
		[DebuggerNonUserCode]
		public bool HasFilename
		{
			get
			{
				return this.filename_ != null;
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000407BF File Offset: 0x0003E9BF
		[DebuggerNonUserCode]
		public void ClearFilename()
		{
			this.filename_ = null;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x000407CC File Offset: 0x0003E9CC
		[DebuggerNonUserCode]
		public RepeatedField<ExportToObjFileRequest.Types.ObjExportEntry> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000407E4 File Offset: 0x0003E9E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExportToObjFileRequest);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00040804 File Offset: 0x0003EA04
		[DebuggerNonUserCode]
		public bool Equals(ExportToObjFileRequest other)
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
					bool flag4 = this.Filename != other.Filename;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.entries_.Equals(other.entries_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00040878 File Offset: 0x0003EA78
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFilename = this.HasFilename;
			if (hasFilename)
			{
				num ^= this.Filename.GetHashCode();
			}
			num ^= this.entries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x000408D0 File Offset: 0x0003EAD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000408E8 File Offset: 0x0003EAE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000408F4 File Offset: 0x0003EAF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFilename = this.HasFilename;
			if (hasFilename)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Filename);
			}
			this.entries_.WriteTo(ref output, ExportToObjFileRequest._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00040954 File Offset: 0x0003EB54
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFilename = this.HasFilename;
			if (hasFilename)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Filename);
			}
			num += this.entries_.CalculateSize(ExportToObjFileRequest._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000409B8 File Offset: 0x0003EBB8
		[DebuggerNonUserCode]
		public void MergeFrom(ExportToObjFileRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFilename = other.HasFilename;
				if (hasFilename)
				{
					this.Filename = other.Filename;
				}
				this.entries_.Add(other.entries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00040A13 File Offset: 0x0003EC13
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00040A20 File Offset: 0x0003EC20
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entries_.AddEntriesFrom(ref input, ExportToObjFileRequest._repeated_entries_codec);
					}
				}
				else
				{
					this.Filename = input.ReadString();
				}
			}
		}

		// Token: 0x04000708 RID: 1800
		private static readonly MessageParser<ExportToObjFileRequest> _parser = new MessageParser<ExportToObjFileRequest>(() => new ExportToObjFileRequest());

		// Token: 0x04000709 RID: 1801
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400070A RID: 1802
		public const int FilenameFieldNumber = 1;

		// Token: 0x0400070B RID: 1803
		private static readonly string FilenameDefaultValue = "";

		// Token: 0x0400070C RID: 1804
		private string filename_;

		// Token: 0x0400070D RID: 1805
		public const int EntriesFieldNumber = 2;

		// Token: 0x0400070E RID: 1806
		private static readonly FieldCodec<ExportToObjFileRequest.Types.ObjExportEntry> _repeated_entries_codec = FieldCodec.ForMessage<ExportToObjFileRequest.Types.ObjExportEntry>(18U, ExportToObjFileRequest.Types.ObjExportEntry.Parser);

		// Token: 0x0400070F RID: 1807
		private readonly RepeatedField<ExportToObjFileRequest.Types.ObjExportEntry> entries_ = new RepeatedField<ExportToObjFileRequest.Types.ObjExportEntry>();

		// Token: 0x02000BD2 RID: 3026
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001461 RID: 5217
			public sealed class ObjExportEntry : IMessage<ExportToObjFileRequest.Types.ObjExportEntry>, IMessage, IEquatable<ExportToObjFileRequest.Types.ObjExportEntry>, IDeepCloneable<ExportToObjFileRequest.Types.ObjExportEntry>, IBufferMessage
			{
				// Token: 0x170039DA RID: 14810
				// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x004CEA10 File Offset: 0x004CCC10
				[DebuggerNonUserCode]
				public static MessageParser<ExportToObjFileRequest.Types.ObjExportEntry> Parser
				{
					get
					{
						return ExportToObjFileRequest.Types.ObjExportEntry._parser;
					}
				}

				// Token: 0x170039DB RID: 14811
				// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x004CEA28 File Offset: 0x004CCC28
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return ExportToObjFileRequest.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x170039DC RID: 14812
				// (get) Token: 0x0600E3D1 RID: 58321 RVA: 0x004CEA4C File Offset: 0x004CCC4C
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return ExportToObjFileRequest.Types.ObjExportEntry.Descriptor;
					}
				}

				// Token: 0x0600E3D2 RID: 58322 RVA: 0x004CEA63 File Offset: 0x004CCC63
				[DebuggerNonUserCode]
				public ObjExportEntry()
				{
				}

				// Token: 0x0600E3D3 RID: 58323 RVA: 0x004CEA70 File Offset: 0x004CCC70
				[DebuggerNonUserCode]
				public ObjExportEntry(ExportToObjFileRequest.Types.ObjExportEntry other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
					this.snoGroup_ = other.snoGroup_;
					this.snoHandle_ = other.snoHandle_;
					this.markerName_ = other.markerName_;
					this.markerId_ = other.markerId_;
					this.hasOcean_ = other.hasOcean_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E3D4 RID: 58324 RVA: 0x004CEAFC File Offset: 0x004CCCFC
				[DebuggerNonUserCode]
				public ExportToObjFileRequest.Types.ObjExportEntry Clone()
				{
					return new ExportToObjFileRequest.Types.ObjExportEntry(this);
				}

				// Token: 0x170039DD RID: 14813
				// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x004CEB14 File Offset: 0x004CCD14
				// (set) Token: 0x0600E3D6 RID: 58326 RVA: 0x004CEB2C File Offset: 0x004CCD2C
				[DebuggerNonUserCode]
				public PRSTransform Transform
				{
					get
					{
						return this.transform_;
					}
					set
					{
						this.transform_ = value;
					}
				}

				// Token: 0x170039DE RID: 14814
				// (get) Token: 0x0600E3D7 RID: 58327 RVA: 0x004CEB38 File Offset: 0x004CCD38
				// (set) Token: 0x0600E3D8 RID: 58328 RVA: 0x004CEB69 File Offset: 0x004CCD69
				[DebuggerNonUserCode]
				public int SnoGroup
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						int snoGroupDefaultValue;
						if (flag)
						{
							snoGroupDefaultValue = this.snoGroup_;
						}
						else
						{
							snoGroupDefaultValue = ExportToObjFileRequest.Types.ObjExportEntry.SnoGroupDefaultValue;
						}
						return snoGroupDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.snoGroup_ = value;
					}
				}

				// Token: 0x170039DF RID: 14815
				// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x004CEB84 File Offset: 0x004CCD84
				[DebuggerNonUserCode]
				public bool HasSnoGroup
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E3DA RID: 58330 RVA: 0x004CEBA1 File Offset: 0x004CCDA1
				[DebuggerNonUserCode]
				public void ClearSnoGroup()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x170039E0 RID: 14816
				// (get) Token: 0x0600E3DB RID: 58331 RVA: 0x004CEBB4 File Offset: 0x004CCDB4
				// (set) Token: 0x0600E3DC RID: 58332 RVA: 0x004CEBE5 File Offset: 0x004CCDE5
				[DebuggerNonUserCode]
				public int SnoHandle
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int snoHandleDefaultValue;
						if (flag)
						{
							snoHandleDefaultValue = this.snoHandle_;
						}
						else
						{
							snoHandleDefaultValue = ExportToObjFileRequest.Types.ObjExportEntry.SnoHandleDefaultValue;
						}
						return snoHandleDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.snoHandle_ = value;
					}
				}

				// Token: 0x170039E1 RID: 14817
				// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x004CEC00 File Offset: 0x004CCE00
				[DebuggerNonUserCode]
				public bool HasSnoHandle
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E3DE RID: 58334 RVA: 0x004CEC1D File Offset: 0x004CCE1D
				[DebuggerNonUserCode]
				public void ClearSnoHandle()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x170039E2 RID: 14818
				// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x004CEC30 File Offset: 0x004CCE30
				// (set) Token: 0x0600E3E0 RID: 58336 RVA: 0x004CEC51 File Offset: 0x004CCE51
				[DebuggerNonUserCode]
				public string MarkerName
				{
					get
					{
						return this.markerName_ ?? ExportToObjFileRequest.Types.ObjExportEntry.MarkerNameDefaultValue;
					}
					set
					{
						this.markerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x170039E3 RID: 14819
				// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x004CEC68 File Offset: 0x004CCE68
				[DebuggerNonUserCode]
				public bool HasMarkerName
				{
					get
					{
						return this.markerName_ != null;
					}
				}

				// Token: 0x0600E3E2 RID: 58338 RVA: 0x004CEC83 File Offset: 0x004CCE83
				[DebuggerNonUserCode]
				public void ClearMarkerName()
				{
					this.markerName_ = null;
				}

				// Token: 0x170039E4 RID: 14820
				// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x004CEC90 File Offset: 0x004CCE90
				// (set) Token: 0x0600E3E4 RID: 58340 RVA: 0x004CECC1 File Offset: 0x004CCEC1
				[DebuggerNonUserCode]
				public int MarkerId
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						int markerIdDefaultValue;
						if (flag)
						{
							markerIdDefaultValue = this.markerId_;
						}
						else
						{
							markerIdDefaultValue = ExportToObjFileRequest.Types.ObjExportEntry.MarkerIdDefaultValue;
						}
						return markerIdDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.markerId_ = value;
					}
				}

				// Token: 0x170039E5 RID: 14821
				// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x004CECDC File Offset: 0x004CCEDC
				[DebuggerNonUserCode]
				public bool HasMarkerId
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E3E6 RID: 58342 RVA: 0x004CECF9 File Offset: 0x004CCEF9
				[DebuggerNonUserCode]
				public void ClearMarkerId()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x170039E6 RID: 14822
				// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x004CED0C File Offset: 0x004CCF0C
				// (set) Token: 0x0600E3E8 RID: 58344 RVA: 0x004CED3D File Offset: 0x004CCF3D
				[DebuggerNonUserCode]
				public bool HasOcean
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						bool hasOceanDefaultValue;
						if (flag)
						{
							hasOceanDefaultValue = this.hasOcean_;
						}
						else
						{
							hasOceanDefaultValue = ExportToObjFileRequest.Types.ObjExportEntry.HasOceanDefaultValue;
						}
						return hasOceanDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.hasOcean_ = value;
					}
				}

				// Token: 0x170039E7 RID: 14823
				// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x004CED58 File Offset: 0x004CCF58
				[DebuggerNonUserCode]
				public bool HasHasOcean
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E3EA RID: 58346 RVA: 0x004CED75 File Offset: 0x004CCF75
				[DebuggerNonUserCode]
				public void ClearHasOcean()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x0600E3EB RID: 58347 RVA: 0x004CED88 File Offset: 0x004CCF88
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as ExportToObjFileRequest.Types.ObjExportEntry);
				}

				// Token: 0x0600E3EC RID: 58348 RVA: 0x004CEDA8 File Offset: 0x004CCFA8
				[DebuggerNonUserCode]
				public bool Equals(ExportToObjFileRequest.Types.ObjExportEntry other)
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
							bool flag4 = !object.Equals(this.Transform, other.Transform);
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.SnoGroup != other.SnoGroup;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.SnoHandle != other.SnoHandle;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.MarkerName != other.MarkerName;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.MarkerId != other.MarkerId;
											if (flag8)
											{
												flag2 = false;
											}
											else
											{
												bool flag9 = this.HasOcean != other.HasOcean;
												flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
											}
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E3ED RID: 58349 RVA: 0x004CEE94 File Offset: 0x004CD094
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool flag = this.transform_ != null;
					if (flag)
					{
						num ^= this.Transform.GetHashCode();
					}
					bool hasSnoGroup = this.HasSnoGroup;
					if (hasSnoGroup)
					{
						num ^= this.SnoGroup.GetHashCode();
					}
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						num ^= this.SnoHandle.GetHashCode();
					}
					bool hasMarkerName = this.HasMarkerName;
					if (hasMarkerName)
					{
						num ^= this.MarkerName.GetHashCode();
					}
					bool hasMarkerId = this.HasMarkerId;
					if (hasMarkerId)
					{
						num ^= this.MarkerId.GetHashCode();
					}
					bool hasHasOcean = this.HasHasOcean;
					if (hasHasOcean)
					{
						num ^= this.HasOcean.GetHashCode();
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E3EE RID: 58350 RVA: 0x004CEF74 File Offset: 0x004CD174
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E3EF RID: 58351 RVA: 0x004CEF8C File Offset: 0x004CD18C
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E3F0 RID: 58352 RVA: 0x004CEF98 File Offset: 0x004CD198
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool flag = this.transform_ != null;
					if (flag)
					{
						output.WriteRawTag(10);
						output.WriteMessage(this.Transform);
					}
					bool hasSnoGroup = this.HasSnoGroup;
					if (hasSnoGroup)
					{
						output.WriteRawTag(16);
						output.WriteInt32(this.SnoGroup);
					}
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						output.WriteRawTag(24);
						output.WriteInt32(this.SnoHandle);
					}
					bool hasMarkerName = this.HasMarkerName;
					if (hasMarkerName)
					{
						output.WriteRawTag(34);
						output.WriteString(this.MarkerName);
					}
					bool hasMarkerId = this.HasMarkerId;
					if (hasMarkerId)
					{
						output.WriteRawTag(40);
						output.WriteInt32(this.MarkerId);
					}
					bool hasHasOcean = this.HasHasOcean;
					if (hasHasOcean)
					{
						output.WriteRawTag(48);
						output.WriteBool(this.HasOcean);
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E3F1 RID: 58353 RVA: 0x004CF098 File Offset: 0x004CD298
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool flag = this.transform_ != null;
					if (flag)
					{
						num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
					}
					bool hasSnoGroup = this.HasSnoGroup;
					if (hasSnoGroup)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoGroup);
					}
					bool hasSnoHandle = this.HasSnoHandle;
					if (hasSnoHandle)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
					}
					bool hasMarkerName = this.HasMarkerName;
					if (hasMarkerName)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.MarkerName);
					}
					bool hasMarkerId = this.HasMarkerId;
					if (hasMarkerId)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkerId);
					}
					bool hasHasOcean = this.HasHasOcean;
					if (hasHasOcean)
					{
						num += 2;
					}
					bool flag2 = this._unknownFields != null;
					if (flag2)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E3F2 RID: 58354 RVA: 0x004CF174 File Offset: 0x004CD374
				[DebuggerNonUserCode]
				public void MergeFrom(ExportToObjFileRequest.Types.ObjExportEntry other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool flag2 = other.transform_ != null;
						if (flag2)
						{
							bool flag3 = this.transform_ == null;
							if (flag3)
							{
								this.Transform = new PRSTransform();
							}
							this.Transform.MergeFrom(other.Transform);
						}
						bool hasSnoGroup = other.HasSnoGroup;
						if (hasSnoGroup)
						{
							this.SnoGroup = other.SnoGroup;
						}
						bool hasSnoHandle = other.HasSnoHandle;
						if (hasSnoHandle)
						{
							this.SnoHandle = other.SnoHandle;
						}
						bool hasMarkerName = other.HasMarkerName;
						if (hasMarkerName)
						{
							this.MarkerName = other.MarkerName;
						}
						bool hasMarkerId = other.HasMarkerId;
						if (hasMarkerId)
						{
							this.MarkerId = other.MarkerId;
						}
						bool hasHasOcean = other.HasHasOcean;
						if (hasHasOcean)
						{
							this.HasOcean = other.HasOcean;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E3F3 RID: 58355 RVA: 0x004CF268 File Offset: 0x004CD468
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E3F4 RID: 58356 RVA: 0x004CF274 File Offset: 0x004CD474
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 24U)
						{
							if (num3 != 10U)
							{
								if (num3 != 16U)
								{
									if (num3 != 24U)
									{
										goto IL_003D;
									}
									this.SnoHandle = input.ReadInt32();
								}
								else
								{
									this.SnoGroup = input.ReadInt32();
								}
							}
							else
							{
								bool flag = this.transform_ == null;
								if (flag)
								{
									this.Transform = new PRSTransform();
								}
								input.ReadMessage(this.Transform);
							}
						}
						else if (num3 != 34U)
						{
							if (num3 != 40U)
							{
								if (num3 != 48U)
								{
									goto IL_003D;
								}
								this.HasOcean = input.ReadBool();
							}
							else
							{
								this.MarkerId = input.ReadInt32();
							}
						}
						else
						{
							this.MarkerName = input.ReadString();
						}
						continue;
						IL_003D:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A27B RID: 41595
				private static readonly MessageParser<ExportToObjFileRequest.Types.ObjExportEntry> _parser = new MessageParser<ExportToObjFileRequest.Types.ObjExportEntry>(() => new ExportToObjFileRequest.Types.ObjExportEntry());

				// Token: 0x0400A27C RID: 41596
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A27D RID: 41597
				private int _hasBits0;

				// Token: 0x0400A27E RID: 41598
				public const int TransformFieldNumber = 1;

				// Token: 0x0400A27F RID: 41599
				private PRSTransform transform_;

				// Token: 0x0400A280 RID: 41600
				public const int SnoGroupFieldNumber = 2;

				// Token: 0x0400A281 RID: 41601
				private static readonly int SnoGroupDefaultValue = 0;

				// Token: 0x0400A282 RID: 41602
				private int snoGroup_;

				// Token: 0x0400A283 RID: 41603
				public const int SnoHandleFieldNumber = 3;

				// Token: 0x0400A284 RID: 41604
				private static readonly int SnoHandleDefaultValue = 0;

				// Token: 0x0400A285 RID: 41605
				private int snoHandle_;

				// Token: 0x0400A286 RID: 41606
				public const int MarkerNameFieldNumber = 4;

				// Token: 0x0400A287 RID: 41607
				private static readonly string MarkerNameDefaultValue = "";

				// Token: 0x0400A288 RID: 41608
				private string markerName_;

				// Token: 0x0400A289 RID: 41609
				public const int MarkerIdFieldNumber = 5;

				// Token: 0x0400A28A RID: 41610
				private static readonly int MarkerIdDefaultValue = 0;

				// Token: 0x0400A28B RID: 41611
				private int markerId_;

				// Token: 0x0400A28C RID: 41612
				public const int HasOceanFieldNumber = 6;

				// Token: 0x0400A28D RID: 41613
				private static readonly bool HasOceanDefaultValue = false;

				// Token: 0x0400A28E RID: 41614
				private bool hasOcean_;
			}
		}
	}
}

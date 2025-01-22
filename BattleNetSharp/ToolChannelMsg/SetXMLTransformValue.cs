using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CB RID: 203
	public sealed class SetXMLTransformValue : IMessage<SetXMLTransformValue>, IMessage, IEquatable<SetXMLTransformValue>, IDeepCloneable<SetXMLTransformValue>, IBufferMessage
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00046B34 File Offset: 0x00044D34
		[DebuggerNonUserCode]
		public static MessageParser<SetXMLTransformValue> Parser
		{
			get
			{
				return SetXMLTransformValue._parser;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x00046B4C File Offset: 0x00044D4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[180];
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00046B74 File Offset: 0x00044D74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetXMLTransformValue.Descriptor;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00046B8B File Offset: 0x00044D8B
		[DebuggerNonUserCode]
		public SetXMLTransformValue()
		{
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00046B98 File Offset: 0x00044D98
		[DebuggerNonUserCode]
		public SetXMLTransformValue(SetXMLTransformValue other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this.xmlPath_ = other.xmlPath_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.orientation_ = ((other.orientation_ != null) ? other.orientation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00046C28 File Offset: 0x00044E28
		[DebuggerNonUserCode]
		public SetXMLTransformValue Clone()
		{
			return new SetXMLTransformValue(this);
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00046C40 File Offset: 0x00044E40
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00046C71 File Offset: 0x00044E71
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
					snoGroupDefaultValue = SetXMLTransformValue.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00046C8C File Offset: 0x00044E8C
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00046CA9 File Offset: 0x00044EA9
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x00046CBC File Offset: 0x00044EBC
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x00046CED File Offset: 0x00044EED
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
					snoHandleDefaultValue = SetXMLTransformValue.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00046D08 File Offset: 0x00044F08
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00046D25 File Offset: 0x00044F25
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00046D38 File Offset: 0x00044F38
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x00046D59 File Offset: 0x00044F59
		[DebuggerNonUserCode]
		public string XmlPath
		{
			get
			{
				return this.xmlPath_ ?? SetXMLTransformValue.XmlPathDefaultValue;
			}
			set
			{
				this.xmlPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00046D70 File Offset: 0x00044F70
		[DebuggerNonUserCode]
		public bool HasXmlPath
		{
			get
			{
				return this.xmlPath_ != null;
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00046D8B File Offset: 0x00044F8B
		[DebuggerNonUserCode]
		public void ClearXmlPath()
		{
			this.xmlPath_ = null;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00046D98 File Offset: 0x00044F98
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00046DB0 File Offset: 0x00044FB0
		[DebuggerNonUserCode]
		public Vector3 Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00046DBC File Offset: 0x00044FBC
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00046DD4 File Offset: 0x00044FD4
		[DebuggerNonUserCode]
		public Quaternion Orientation
		{
			get
			{
				return this.orientation_;
			}
			set
			{
				this.orientation_ = value;
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00046DE0 File Offset: 0x00044FE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetXMLTransformValue);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00046E00 File Offset: 0x00045000
		[DebuggerNonUserCode]
		public bool Equals(SetXMLTransformValue other)
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
					bool flag4 = this.SnoGroup != other.SnoGroup;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoHandle != other.SnoHandle;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.XmlPath != other.XmlPath;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Location, other.Location);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.Orientation, other.Orientation);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00046ED4 File Offset: 0x000450D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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
			bool hasXmlPath = this.HasXmlPath;
			if (hasXmlPath)
			{
				num ^= this.XmlPath.GetHashCode();
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num ^= this.Location.GetHashCode();
			}
			bool flag2 = this.orientation_ != null;
			if (flag2)
			{
				num ^= this.Orientation.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00046F94 File Offset: 0x00045194
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00046FAC File Offset: 0x000451AC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00046FB8 File Offset: 0x000451B8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoGroup = this.HasSnoGroup;
			if (hasSnoGroup)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoGroup);
			}
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasXmlPath = this.HasXmlPath;
			if (hasXmlPath)
			{
				output.WriteRawTag(26);
				output.WriteString(this.XmlPath);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			bool flag2 = this.orientation_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Orientation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00047098 File Offset: 0x00045298
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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
			bool hasXmlPath = this.HasXmlPath;
			if (hasXmlPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XmlPath);
			}
			bool flag = this.location_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			bool flag2 = this.orientation_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Orientation);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00047164 File Offset: 0x00045364
		[DebuggerNonUserCode]
		public void MergeFrom(SetXMLTransformValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
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
				bool hasXmlPath = other.HasXmlPath;
				if (hasXmlPath)
				{
					this.XmlPath = other.XmlPath;
				}
				bool flag2 = other.location_ != null;
				if (flag2)
				{
					bool flag3 = this.location_ == null;
					if (flag3)
					{
						this.Location = new Vector3();
					}
					this.Location.MergeFrom(other.Location);
				}
				bool flag4 = other.orientation_ != null;
				if (flag4)
				{
					bool flag5 = this.orientation_ == null;
					if (flag5)
					{
						this.Orientation = new Quaternion();
					}
					this.Orientation.MergeFrom(other.Orientation);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00047262 File Offset: 0x00045462
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00047270 File Offset: 0x00045470
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
						this.SnoHandle = input.ReadInt32();
					}
					else
					{
						this.SnoGroup = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_0032;
						}
						bool flag = this.orientation_ == null;
						if (flag)
						{
							this.Orientation = new Quaternion();
						}
						input.ReadMessage(this.Orientation);
					}
					else
					{
						bool flag2 = this.location_ == null;
						if (flag2)
						{
							this.Location = new Vector3();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.XmlPath = input.ReadString();
				}
				continue;
				IL_0032:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly MessageParser<SetXMLTransformValue> _parser = new MessageParser<SetXMLTransformValue>(() => new SetXMLTransformValue());

		// Token: 0x040007D5 RID: 2005
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007D6 RID: 2006
		private int _hasBits0;

		// Token: 0x040007D7 RID: 2007
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040007D8 RID: 2008
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040007D9 RID: 2009
		private int snoGroup_;

		// Token: 0x040007DA RID: 2010
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040007DB RID: 2011
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040007DC RID: 2012
		private int snoHandle_;

		// Token: 0x040007DD RID: 2013
		public const int XmlPathFieldNumber = 3;

		// Token: 0x040007DE RID: 2014
		private static readonly string XmlPathDefaultValue = "";

		// Token: 0x040007DF RID: 2015
		private string xmlPath_;

		// Token: 0x040007E0 RID: 2016
		public const int LocationFieldNumber = 4;

		// Token: 0x040007E1 RID: 2017
		private Vector3 location_;

		// Token: 0x040007E2 RID: 2018
		public const int OrientationFieldNumber = 5;

		// Token: 0x040007E3 RID: 2019
		private Quaternion orientation_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006A RID: 106
	public sealed class OpenSNORequest : IMessage<OpenSNORequest>, IMessage, IEquatable<OpenSNORequest>, IDeepCloneable<OpenSNORequest>, IBufferMessage
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00024B7C File Offset: 0x00022D7C
		[DebuggerNonUserCode]
		public static MessageParser<OpenSNORequest> Parser
		{
			get
			{
				return OpenSNORequest._parser;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00024B94 File Offset: 0x00022D94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[83];
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00024BB8 File Offset: 0x00022DB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSNORequest.Descriptor;
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00024BCF File Offset: 0x00022DCF
		[DebuggerNonUserCode]
		public OpenSNORequest()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00024BD9 File Offset: 0x00022DD9
		[DebuggerNonUserCode]
		public OpenSNORequest(OpenSNORequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoGroup_ = other.snoGroup_;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00024C18 File Offset: 0x00022E18
		[DebuggerNonUserCode]
		public OpenSNORequest Clone()
		{
			return new OpenSNORequest(this);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00024C30 File Offset: 0x00022E30
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00024C61 File Offset: 0x00022E61
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
					snoGroupDefaultValue = OpenSNORequest.SnoGroupDefaultValue;
				}
				return snoGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoGroup_ = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00024C7C File Offset: 0x00022E7C
		[DebuggerNonUserCode]
		public bool HasSnoGroup
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00024C99 File Offset: 0x00022E99
		[DebuggerNonUserCode]
		public void ClearSnoGroup()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00024CAC File Offset: 0x00022EAC
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00024CDD File Offset: 0x00022EDD
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
					snoHandleDefaultValue = OpenSNORequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00024CF8 File Offset: 0x00022EF8
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00024D15 File Offset: 0x00022F15
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00024D28 File Offset: 0x00022F28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSNORequest);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00024D48 File Offset: 0x00022F48
		[DebuggerNonUserCode]
		public bool Equals(OpenSNORequest other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00024DBC File Offset: 0x00022FBC
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00024E28 File Offset: 0x00023028
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00024E40 File Offset: 0x00023040
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00024E4C File Offset: 0x0002304C
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00024EBC File Offset: 0x000230BC
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
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00024F28 File Offset: 0x00023128
		[DebuggerNonUserCode]
		public void MergeFrom(OpenSNORequest other)
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00024F8A File Offset: 0x0002318A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00024F98 File Offset: 0x00023198
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SnoHandle = input.ReadInt32();
					}
				}
				else
				{
					this.SnoGroup = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003A7 RID: 935
		private static readonly MessageParser<OpenSNORequest> _parser = new MessageParser<OpenSNORequest>(() => new OpenSNORequest());

		// Token: 0x040003A8 RID: 936
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003A9 RID: 937
		private int _hasBits0;

		// Token: 0x040003AA RID: 938
		public const int SnoGroupFieldNumber = 1;

		// Token: 0x040003AB RID: 939
		private static readonly int SnoGroupDefaultValue = 0;

		// Token: 0x040003AC RID: 940
		private int snoGroup_;

		// Token: 0x040003AD RID: 941
		public const int SnoHandleFieldNumber = 2;

		// Token: 0x040003AE RID: 942
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040003AF RID: 943
		private int snoHandle_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000ED RID: 237
	public sealed class AppearanceMeshDataRequest : IMessage<AppearanceMeshDataRequest>, IMessage, IEquatable<AppearanceMeshDataRequest>, IDeepCloneable<AppearanceMeshDataRequest>, IBufferMessage
	{
		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0005331C File Offset: 0x0005151C
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceMeshDataRequest> Parser
		{
			get
			{
				return AppearanceMeshDataRequest._parser;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00053334 File Offset: 0x00051534
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[214];
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0005335C File Offset: 0x0005155C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceMeshDataRequest.Descriptor;
			}
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00053373 File Offset: 0x00051573
		[DebuggerNonUserCode]
		public AppearanceMeshDataRequest()
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0005337D File Offset: 0x0005157D
		[DebuggerNonUserCode]
		public AppearanceMeshDataRequest(AppearanceMeshDataRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.xobjSource_ = other.xobjSource_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x000533BC File Offset: 0x000515BC
		[DebuggerNonUserCode]
		public AppearanceMeshDataRequest Clone()
		{
			return new AppearanceMeshDataRequest(this);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000533D4 File Offset: 0x000515D4
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x00053405 File Offset: 0x00051605
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
					snoHandleDefaultValue = AppearanceMeshDataRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00053420 File Offset: 0x00051620
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0005343D File Offset: 0x0005163D
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00053450 File Offset: 0x00051650
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00053481 File Offset: 0x00051681
		[DebuggerNonUserCode]
		public int XobjSource
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int xobjSourceDefaultValue;
				if (flag)
				{
					xobjSourceDefaultValue = this.xobjSource_;
				}
				else
				{
					xobjSourceDefaultValue = AppearanceMeshDataRequest.XobjSourceDefaultValue;
				}
				return xobjSourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.xobjSource_ = value;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0005349C File Offset: 0x0005169C
		[DebuggerNonUserCode]
		public bool HasXobjSource
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000534B9 File Offset: 0x000516B9
		[DebuggerNonUserCode]
		public void ClearXobjSource()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x000534CC File Offset: 0x000516CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceMeshDataRequest);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000534EC File Offset: 0x000516EC
		[DebuggerNonUserCode]
		public bool Equals(AppearanceMeshDataRequest other)
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
						bool flag5 = this.XobjSource != other.XobjSource;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00053560 File Offset: 0x00051760
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasXobjSource = this.HasXobjSource;
			if (hasXobjSource)
			{
				num ^= this.XobjSource.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000535CC File Offset: 0x000517CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000535E4 File Offset: 0x000517E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000535F0 File Offset: 0x000517F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasXobjSource = this.HasXobjSource;
			if (hasXobjSource)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.XobjSource);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00053660 File Offset: 0x00051860
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasXobjSource = this.HasXobjSource;
			if (hasXobjSource)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.XobjSource);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000536CC File Offset: 0x000518CC
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceMeshDataRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasXobjSource = other.HasXobjSource;
				if (hasXobjSource)
				{
					this.XobjSource = other.XobjSource;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0005372E File Offset: 0x0005192E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0005373C File Offset: 0x0005193C
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
						this.XobjSource = input.ReadInt32();
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000955 RID: 2389
		private static readonly MessageParser<AppearanceMeshDataRequest> _parser = new MessageParser<AppearanceMeshDataRequest>(() => new AppearanceMeshDataRequest());

		// Token: 0x04000956 RID: 2390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000957 RID: 2391
		private int _hasBits0;

		// Token: 0x04000958 RID: 2392
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000959 RID: 2393
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400095A RID: 2394
		private int snoHandle_;

		// Token: 0x0400095B RID: 2395
		public const int XobjSourceFieldNumber = 2;

		// Token: 0x0400095C RID: 2396
		private static readonly int XobjSourceDefaultValue = 0;

		// Token: 0x0400095D RID: 2397
		private int xobjSource_;
	}
}

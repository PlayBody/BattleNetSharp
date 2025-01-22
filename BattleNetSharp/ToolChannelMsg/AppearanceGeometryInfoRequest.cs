using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200007D RID: 125
	public sealed class AppearanceGeometryInfoRequest : IMessage<AppearanceGeometryInfoRequest>, IMessage, IEquatable<AppearanceGeometryInfoRequest>, IDeepCloneable<AppearanceGeometryInfoRequest>, IBufferMessage
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0002A538 File Offset: 0x00028738
		[DebuggerNonUserCode]
		public static MessageParser<AppearanceGeometryInfoRequest> Parser
		{
			get
			{
				return AppearanceGeometryInfoRequest._parser;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0002A550 File Offset: 0x00028750
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[102];
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0002A574 File Offset: 0x00028774
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppearanceGeometryInfoRequest.Descriptor;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0002A58B File Offset: 0x0002878B
		[DebuggerNonUserCode]
		public AppearanceGeometryInfoRequest()
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0002A595 File Offset: 0x00028795
		[DebuggerNonUserCode]
		public AppearanceGeometryInfoRequest(AppearanceGeometryInfoRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002A5C8 File Offset: 0x000287C8
		[DebuggerNonUserCode]
		public AppearanceGeometryInfoRequest Clone()
		{
			return new AppearanceGeometryInfoRequest(this);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0002A5E0 File Offset: 0x000287E0
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0002A611 File Offset: 0x00028811
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
					snoHandleDefaultValue = AppearanceGeometryInfoRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0002A62C File Offset: 0x0002882C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002A649 File Offset: 0x00028849
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002A65C File Offset: 0x0002885C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppearanceGeometryInfoRequest);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002A67C File Offset: 0x0002887C
		[DebuggerNonUserCode]
		public bool Equals(AppearanceGeometryInfoRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002A6D4 File Offset: 0x000288D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002A724 File Offset: 0x00028924
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002A73C File Offset: 0x0002893C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002A748 File Offset: 0x00028948
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002A794 File Offset: 0x00028994
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06000B00 RID: 2816 RVA: 0x0002A7E4 File Offset: 0x000289E4
		[DebuggerNonUserCode]
		public void MergeFrom(AppearanceGeometryInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0002A82D File Offset: 0x00028A2D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002A838 File Offset: 0x00028A38
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly MessageParser<AppearanceGeometryInfoRequest> _parser = new MessageParser<AppearanceGeometryInfoRequest>(() => new AppearanceGeometryInfoRequest());

		// Token: 0x04000456 RID: 1110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000457 RID: 1111
		private int _hasBits0;

		// Token: 0x04000458 RID: 1112
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000459 RID: 1113
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400045A RID: 1114
		private int snoHandle_;
	}
}

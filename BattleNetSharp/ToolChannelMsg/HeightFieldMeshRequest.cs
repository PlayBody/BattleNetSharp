using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000EE RID: 238
	public sealed class HeightFieldMeshRequest : IMessage<HeightFieldMeshRequest>, IMessage, IEquatable<HeightFieldMeshRequest>, IDeepCloneable<HeightFieldMeshRequest>, IBufferMessage
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x000537CC File Offset: 0x000519CC
		[DebuggerNonUserCode]
		public static MessageParser<HeightFieldMeshRequest> Parser
		{
			get
			{
				return HeightFieldMeshRequest._parser;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x000537E4 File Offset: 0x000519E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[215];
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0005380C File Offset: 0x00051A0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeightFieldMeshRequest.Descriptor;
			}
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00053823 File Offset: 0x00051A23
		[DebuggerNonUserCode]
		public HeightFieldMeshRequest()
		{
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0005382D File Offset: 0x00051A2D
		[DebuggerNonUserCode]
		public HeightFieldMeshRequest(HeightFieldMeshRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoMarkerset_ = other.snoMarkerset_;
			this.markerId_ = other.markerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0005386C File Offset: 0x00051A6C
		[DebuggerNonUserCode]
		public HeightFieldMeshRequest Clone()
		{
			return new HeightFieldMeshRequest(this);
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00053884 File Offset: 0x00051A84
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x000538B5 File Offset: 0x00051AB5
		[DebuggerNonUserCode]
		public int SnoMarkerset
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoMarkersetDefaultValue;
				if (flag)
				{
					snoMarkersetDefaultValue = this.snoMarkerset_;
				}
				else
				{
					snoMarkersetDefaultValue = HeightFieldMeshRequest.SnoMarkersetDefaultValue;
				}
				return snoMarkersetDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoMarkerset_ = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000538D0 File Offset: 0x00051AD0
		[DebuggerNonUserCode]
		public bool HasSnoMarkerset
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000538ED File Offset: 0x00051AED
		[DebuggerNonUserCode]
		public void ClearSnoMarkerset()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x00053900 File Offset: 0x00051B00
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x00053931 File Offset: 0x00051B31
		[DebuggerNonUserCode]
		public int MarkerId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int markerIdDefaultValue;
				if (flag)
				{
					markerIdDefaultValue = this.markerId_;
				}
				else
				{
					markerIdDefaultValue = HeightFieldMeshRequest.MarkerIdDefaultValue;
				}
				return markerIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.markerId_ = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0005394C File Offset: 0x00051B4C
		[DebuggerNonUserCode]
		public bool HasMarkerId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00053969 File Offset: 0x00051B69
		[DebuggerNonUserCode]
		public void ClearMarkerId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0005397C File Offset: 0x00051B7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeightFieldMeshRequest);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0005399C File Offset: 0x00051B9C
		[DebuggerNonUserCode]
		public bool Equals(HeightFieldMeshRequest other)
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
					bool flag4 = this.SnoMarkerset != other.SnoMarkerset;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MarkerId != other.MarkerId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00053A10 File Offset: 0x00051C10
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num ^= this.SnoMarkerset.GetHashCode();
			}
			bool hasMarkerId = this.HasMarkerId;
			if (hasMarkerId)
			{
				num ^= this.MarkerId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00053A7C File Offset: 0x00051C7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00053A94 File Offset: 0x00051C94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00053AA0 File Offset: 0x00051CA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoMarkerset);
			}
			bool hasMarkerId = this.HasMarkerId;
			if (hasMarkerId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MarkerId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00053B10 File Offset: 0x00051D10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoMarkerset = this.HasSnoMarkerset;
			if (hasSnoMarkerset)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoMarkerset);
			}
			bool hasMarkerId = this.HasMarkerId;
			if (hasMarkerId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkerId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00053B7C File Offset: 0x00051D7C
		[DebuggerNonUserCode]
		public void MergeFrom(HeightFieldMeshRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoMarkerset = other.HasSnoMarkerset;
				if (hasSnoMarkerset)
				{
					this.SnoMarkerset = other.SnoMarkerset;
				}
				bool hasMarkerId = other.HasMarkerId;
				if (hasMarkerId)
				{
					this.MarkerId = other.MarkerId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00053BDE File Offset: 0x00051DDE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00053BEC File Offset: 0x00051DEC
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
						this.MarkerId = input.ReadInt32();
					}
				}
				else
				{
					this.SnoMarkerset = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400095E RID: 2398
		private static readonly MessageParser<HeightFieldMeshRequest> _parser = new MessageParser<HeightFieldMeshRequest>(() => new HeightFieldMeshRequest());

		// Token: 0x0400095F RID: 2399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000960 RID: 2400
		private int _hasBits0;

		// Token: 0x04000961 RID: 2401
		public const int SnoMarkersetFieldNumber = 1;

		// Token: 0x04000962 RID: 2402
		private static readonly int SnoMarkersetDefaultValue = 0;

		// Token: 0x04000963 RID: 2403
		private int snoMarkerset_;

		// Token: 0x04000964 RID: 2404
		public const int MarkerIdFieldNumber = 2;

		// Token: 0x04000965 RID: 2405
		private static readonly int MarkerIdDefaultValue = 0;

		// Token: 0x04000966 RID: 2406
		private int markerId_;
	}
}

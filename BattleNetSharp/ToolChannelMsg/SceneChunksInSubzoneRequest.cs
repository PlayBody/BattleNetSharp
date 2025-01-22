using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000C4 RID: 196
	public sealed class SceneChunksInSubzoneRequest : IMessage<SceneChunksInSubzoneRequest>, IMessage, IEquatable<SceneChunksInSubzoneRequest>, IDeepCloneable<SceneChunksInSubzoneRequest>, IBufferMessage
	{
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00043D1C File Offset: 0x00041F1C
		[DebuggerNonUserCode]
		public static MessageParser<SceneChunksInSubzoneRequest> Parser
		{
			get
			{
				return SceneChunksInSubzoneRequest._parser;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00043D34 File Offset: 0x00041F34
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[173];
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00043D5C File Offset: 0x00041F5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneChunksInSubzoneRequest.Descriptor;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00043D73 File Offset: 0x00041F73
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneRequest()
		{
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00043D7D File Offset: 0x00041F7D
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneRequest(SceneChunksInSubzoneRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.snoSubzone_ = other.snoSubzone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00043DBC File Offset: 0x00041FBC
		[DebuggerNonUserCode]
		public SceneChunksInSubzoneRequest Clone()
		{
			return new SceneChunksInSubzoneRequest(this);
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00043DD4 File Offset: 0x00041FD4
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00043E05 File Offset: 0x00042005
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = SceneChunksInSubzoneRequest.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x00043E20 File Offset: 0x00042020
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00043E3D File Offset: 0x0004203D
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00043E50 File Offset: 0x00042050
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00043E81 File Offset: 0x00042081
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = SceneChunksInSubzoneRequest.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00043E9C File Offset: 0x0004209C
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00043EB9 File Offset: 0x000420B9
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00043ECC File Offset: 0x000420CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneChunksInSubzoneRequest);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00043EEC File Offset: 0x000420EC
		[DebuggerNonUserCode]
		public bool Equals(SceneChunksInSubzoneRequest other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoSubzone != other.SnoSubzone;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00043F60 File Offset: 0x00042160
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00043FCC File Offset: 0x000421CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00043FE4 File Offset: 0x000421E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00043FF0 File Offset: 0x000421F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoWorld);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00044060 File Offset: 0x00042260
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000440CC File Offset: 0x000422CC
		[DebuggerNonUserCode]
		public void MergeFrom(SceneChunksInSubzoneRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0004412E File Offset: 0x0004232E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0004413C File Offset: 0x0004233C
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
						this.SnoSubzone = input.ReadInt32();
					}
				}
				else
				{
					this.SnoWorld = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000773 RID: 1907
		private static readonly MessageParser<SceneChunksInSubzoneRequest> _parser = new MessageParser<SceneChunksInSubzoneRequest>(() => new SceneChunksInSubzoneRequest());

		// Token: 0x04000774 RID: 1908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000775 RID: 1909
		private int _hasBits0;

		// Token: 0x04000776 RID: 1910
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04000777 RID: 1911
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04000778 RID: 1912
		private int snoWorld_;

		// Token: 0x04000779 RID: 1913
		public const int SnoSubzoneFieldNumber = 2;

		// Token: 0x0400077A RID: 1914
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x0400077B RID: 1915
		private int snoSubzone_;
	}
}

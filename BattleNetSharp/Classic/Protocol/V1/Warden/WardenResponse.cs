using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Warden
{
	// Token: 0x02000756 RID: 1878
	public sealed class WardenResponse : IMessage<WardenResponse>, IMessage, IEquatable<WardenResponse>, IDeepCloneable<WardenResponse>, IBufferMessage
	{
		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x002A1DF8 File Offset: 0x0029FFF8
		[DebuggerNonUserCode]
		public static MessageParser<WardenResponse> Parser
		{
			get
			{
				return WardenResponse._parser;
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600ACFC RID: 44284 RVA: 0x002A1E10 File Offset: 0x002A0010
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WardenReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x002A1E34 File Offset: 0x002A0034
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WardenResponse.Descriptor;
			}
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x002A1E4B File Offset: 0x002A004B
		[DebuggerNonUserCode]
		public WardenResponse()
		{
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x002A1E55 File Offset: 0x002A0055
		[DebuggerNonUserCode]
		public WardenResponse(WardenResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x002A1E7C File Offset: 0x002A007C
		[DebuggerNonUserCode]
		public WardenResponse Clone()
		{
			return new WardenResponse(this);
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x002A1E94 File Offset: 0x002A0094
		// (set) Token: 0x0600AD02 RID: 44290 RVA: 0x002A1EB5 File Offset: 0x002A00B5
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? WardenResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x002A1ECC File Offset: 0x002A00CC
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x002A1EEA File Offset: 0x002A00EA
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x002A1EF4 File Offset: 0x002A00F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WardenResponse);
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x002A1F14 File Offset: 0x002A0114
		[DebuggerNonUserCode]
		public bool Equals(WardenResponse other)
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
					bool flag4 = this.Data != other.Data;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x002A1F6C File Offset: 0x002A016C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x002A1FB8 File Offset: 0x002A01B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x002A1FD0 File Offset: 0x002A01D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x002A1FDC File Offset: 0x002A01DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x002A2028 File Offset: 0x002A0228
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x002A2078 File Offset: 0x002A0278
		[DebuggerNonUserCode]
		public void MergeFrom(WardenResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x002A20C1 File Offset: 0x002A02C1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x002A20CC File Offset: 0x002A02CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004DE9 RID: 19945
		private static readonly MessageParser<WardenResponse> _parser = new MessageParser<WardenResponse>(() => new WardenResponse());

		// Token: 0x04004DEA RID: 19946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DEB RID: 19947
		public const int DataFieldNumber = 3;

		// Token: 0x04004DEC RID: 19948
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04004DED RID: 19949
		private ByteString data_;
	}
}

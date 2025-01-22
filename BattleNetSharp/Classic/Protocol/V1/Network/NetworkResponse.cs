using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Network
{
	// Token: 0x0200075A RID: 1882
	public sealed class NetworkResponse : IMessage<NetworkResponse>, IMessage, IEquatable<NetworkResponse>, IDeepCloneable<NetworkResponse>, IBufferMessage
	{
		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600AD45 RID: 44357 RVA: 0x002A2F70 File Offset: 0x002A1170
		[DebuggerNonUserCode]
		public static MessageParser<NetworkResponse> Parser
		{
			get
			{
				return NetworkResponse._parser;
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600AD46 RID: 44358 RVA: 0x002A2F88 File Offset: 0x002A1188
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NetworkReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600AD47 RID: 44359 RVA: 0x002A2FAC File Offset: 0x002A11AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetworkResponse.Descriptor;
			}
		}

		// Token: 0x0600AD48 RID: 44360 RVA: 0x002A2FC3 File Offset: 0x002A11C3
		[DebuggerNonUserCode]
		public NetworkResponse()
		{
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x002A2FCD File Offset: 0x002A11CD
		[DebuggerNonUserCode]
		public NetworkResponse(NetworkResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD4A RID: 44362 RVA: 0x002A2FF4 File Offset: 0x002A11F4
		[DebuggerNonUserCode]
		public NetworkResponse Clone()
		{
			return new NetworkResponse(this);
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x002A300C File Offset: 0x002A120C
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x002A302D File Offset: 0x002A122D
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? NetworkResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x002A3044 File Offset: 0x002A1244
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x002A3062 File Offset: 0x002A1262
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x002A306C File Offset: 0x002A126C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetworkResponse);
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x002A308C File Offset: 0x002A128C
		[DebuggerNonUserCode]
		public bool Equals(NetworkResponse other)
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

		// Token: 0x0600AD51 RID: 44369 RVA: 0x002A30E4 File Offset: 0x002A12E4
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

		// Token: 0x0600AD52 RID: 44370 RVA: 0x002A3130 File Offset: 0x002A1330
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x002A3148 File Offset: 0x002A1348
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD54 RID: 44372 RVA: 0x002A3154 File Offset: 0x002A1354
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

		// Token: 0x0600AD55 RID: 44373 RVA: 0x002A31A0 File Offset: 0x002A13A0
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

		// Token: 0x0600AD56 RID: 44374 RVA: 0x002A31F0 File Offset: 0x002A13F0
		[DebuggerNonUserCode]
		public void MergeFrom(NetworkResponse other)
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

		// Token: 0x0600AD57 RID: 44375 RVA: 0x002A3239 File Offset: 0x002A1439
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD58 RID: 44376 RVA: 0x002A3244 File Offset: 0x002A1444
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

		// Token: 0x04004E0D RID: 19981
		private static readonly MessageParser<NetworkResponse> _parser = new MessageParser<NetworkResponse>(() => new NetworkResponse());

		// Token: 0x04004E0E RID: 19982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E0F RID: 19983
		public const int DataFieldNumber = 3;

		// Token: 0x04004E10 RID: 19984
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04004E11 RID: 19985
		private ByteString data_;
	}
}

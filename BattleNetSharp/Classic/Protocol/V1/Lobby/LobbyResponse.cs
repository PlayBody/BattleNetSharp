using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.Lobby
{
	// Token: 0x0200075E RID: 1886
	public sealed class LobbyResponse : IMessage<LobbyResponse>, IMessage, IEquatable<LobbyResponse>, IDeepCloneable<LobbyResponse>, IBufferMessage
	{
		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600AD8F RID: 44431 RVA: 0x002A420C File Offset: 0x002A240C
		[DebuggerNonUserCode]
		public static MessageParser<LobbyResponse> Parser
		{
			get
			{
				return LobbyResponse._parser;
			}
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x002A4224 File Offset: 0x002A2424
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600AD91 RID: 44433 RVA: 0x002A4248 File Offset: 0x002A2448
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyResponse.Descriptor;
			}
		}

		// Token: 0x0600AD92 RID: 44434 RVA: 0x002A425F File Offset: 0x002A245F
		[DebuggerNonUserCode]
		public LobbyResponse()
		{
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x002A4269 File Offset: 0x002A2469
		[DebuggerNonUserCode]
		public LobbyResponse(LobbyResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x002A4290 File Offset: 0x002A2490
		[DebuggerNonUserCode]
		public LobbyResponse Clone()
		{
			return new LobbyResponse(this);
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600AD95 RID: 44437 RVA: 0x002A42A8 File Offset: 0x002A24A8
		// (set) Token: 0x0600AD96 RID: 44438 RVA: 0x002A42C9 File Offset: 0x002A24C9
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? LobbyResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600AD97 RID: 44439 RVA: 0x002A42E0 File Offset: 0x002A24E0
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x002A42FE File Offset: 0x002A24FE
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x002A4308 File Offset: 0x002A2508
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyResponse);
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x002A4328 File Offset: 0x002A2528
		[DebuggerNonUserCode]
		public bool Equals(LobbyResponse other)
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

		// Token: 0x0600AD9B RID: 44443 RVA: 0x002A4380 File Offset: 0x002A2580
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

		// Token: 0x0600AD9C RID: 44444 RVA: 0x002A43CC File Offset: 0x002A25CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x002A43E4 File Offset: 0x002A25E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x002A43F0 File Offset: 0x002A25F0
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

		// Token: 0x0600AD9F RID: 44447 RVA: 0x002A443C File Offset: 0x002A263C
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

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x002A448C File Offset: 0x002A268C
		[DebuggerNonUserCode]
		public void MergeFrom(LobbyResponse other)
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

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x002A44D5 File Offset: 0x002A26D5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x002A44E0 File Offset: 0x002A26E0
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

		// Token: 0x04004E31 RID: 20017
		private static readonly MessageParser<LobbyResponse> _parser = new MessageParser<LobbyResponse>(() => new LobbyResponse());

		// Token: 0x04004E32 RID: 20018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E33 RID: 20019
		public const int DataFieldNumber = 3;

		// Token: 0x04004E34 RID: 20020
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04004E35 RID: 20021
		private ByteString data_;
	}
}

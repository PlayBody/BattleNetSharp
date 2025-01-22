using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000799 RID: 1945
	public sealed class GameMgmtResponse : IMessage<GameMgmtResponse>, IMessage, IEquatable<GameMgmtResponse>, IDeepCloneable<GameMgmtResponse>, IBufferMessage
	{
		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x002B8938 File Offset: 0x002B6B38
		[DebuggerNonUserCode]
		public static MessageParser<GameMgmtResponse> Parser
		{
			get
			{
				return GameMgmtResponse._parser;
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600B2E7 RID: 45799 RVA: 0x002B8950 File Offset: 0x002B6B50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x002B8974 File Offset: 0x002B6B74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMgmtResponse.Descriptor;
			}
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x002B898B File Offset: 0x002B6B8B
		[DebuggerNonUserCode]
		public GameMgmtResponse()
		{
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x002B8995 File Offset: 0x002B6B95
		[DebuggerNonUserCode]
		public GameMgmtResponse(GameMgmtResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x002B89BC File Offset: 0x002B6BBC
		[DebuggerNonUserCode]
		public GameMgmtResponse Clone()
		{
			return new GameMgmtResponse(this);
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600B2EC RID: 45804 RVA: 0x002B89D4 File Offset: 0x002B6BD4
		// (set) Token: 0x0600B2ED RID: 45805 RVA: 0x002B89F5 File Offset: 0x002B6BF5
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? GameMgmtResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x002B8A0C File Offset: 0x002B6C0C
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x002B8A2A File Offset: 0x002B6C2A
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x002B8A34 File Offset: 0x002B6C34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMgmtResponse);
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x002B8A54 File Offset: 0x002B6C54
		[DebuggerNonUserCode]
		public bool Equals(GameMgmtResponse other)
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

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x002B8AAC File Offset: 0x002B6CAC
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

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x002B8AF8 File Offset: 0x002B6CF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x002B8B10 File Offset: 0x002B6D10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x002B8B1C File Offset: 0x002B6D1C
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

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x002B8B68 File Offset: 0x002B6D68
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

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x002B8BB8 File Offset: 0x002B6DB8
		[DebuggerNonUserCode]
		public void MergeFrom(GameMgmtResponse other)
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

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x002B8C01 File Offset: 0x002B6E01
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x002B8C0C File Offset: 0x002B6E0C
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

		// Token: 0x040050CD RID: 20685
		private static readonly MessageParser<GameMgmtResponse> _parser = new MessageParser<GameMgmtResponse>(() => new GameMgmtResponse());

		// Token: 0x040050CE RID: 20686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050CF RID: 20687
		public const int DataFieldNumber = 3;

		// Token: 0x040050D0 RID: 20688
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x040050D1 RID: 20689
		private ByteString data_;
	}
}

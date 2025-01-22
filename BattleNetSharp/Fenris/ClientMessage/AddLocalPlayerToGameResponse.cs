using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023F RID: 575
	public sealed class AddLocalPlayerToGameResponse : IMessage<AddLocalPlayerToGameResponse>, IMessage, IEquatable<AddLocalPlayerToGameResponse>, IDeepCloneable<AddLocalPlayerToGameResponse>, IBufferMessage
	{
		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x000F4948 File Offset: 0x000F2B48
		[DebuggerNonUserCode]
		public static MessageParser<AddLocalPlayerToGameResponse> Parser
		{
			get
			{
				return AddLocalPlayerToGameResponse._parser;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06003E13 RID: 15891 RVA: 0x000F4960 File Offset: 0x000F2B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[47];
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x000F4984 File Offset: 0x000F2B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddLocalPlayerToGameResponse.Descriptor;
			}
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x000F499B File Offset: 0x000F2B9B
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameResponse()
		{
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x000F49A8 File Offset: 0x000F2BA8
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameResponse(AddLocalPlayerToGameResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errCode_ = other.errCode_;
			this.connectionInfo_ = ((other.connectionInfo_ != null) ? other.connectionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x000F4A04 File Offset: 0x000F2C04
		[DebuggerNonUserCode]
		public AddLocalPlayerToGameResponse Clone()
		{
			return new AddLocalPlayerToGameResponse(this);
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x000F4A1C File Offset: 0x000F2C1C
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x000F4A4D File Offset: 0x000F2C4D
		[DebuggerNonUserCode]
		public uint ErrCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errCodeDefaultValue;
				if (flag)
				{
					errCodeDefaultValue = this.errCode_;
				}
				else
				{
					errCodeDefaultValue = AddLocalPlayerToGameResponse.ErrCodeDefaultValue;
				}
				return errCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errCode_ = value;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x000F4A68 File Offset: 0x000F2C68
		[DebuggerNonUserCode]
		public bool HasErrCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x000F4A85 File Offset: 0x000F2C85
		[DebuggerNonUserCode]
		public void ClearErrCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x000F4A98 File Offset: 0x000F2C98
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x000F4AB0 File Offset: 0x000F2CB0
		[DebuggerNonUserCode]
		public ConnectionInfo ConnectionInfo
		{
			get
			{
				return this.connectionInfo_;
			}
			set
			{
				this.connectionInfo_ = value;
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x000F4ABC File Offset: 0x000F2CBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddLocalPlayerToGameResponse);
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x000F4ADC File Offset: 0x000F2CDC
		[DebuggerNonUserCode]
		public bool Equals(AddLocalPlayerToGameResponse other)
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
					bool flag4 = this.ErrCode != other.ErrCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ConnectionInfo, other.ConnectionInfo);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x000F4B50 File Offset: 0x000F2D50
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				num ^= this.ConnectionInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x000F4BBC File Offset: 0x000F2DBC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x000F4BD4 File Offset: 0x000F2DD4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x000F4BE0 File Offset: 0x000F2DE0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrCode);
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ConnectionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x000F4C50 File Offset: 0x000F2E50
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrCode);
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x000F4CC0 File Offset: 0x000F2EC0
		[DebuggerNonUserCode]
		public void MergeFrom(AddLocalPlayerToGameResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrCode = other.HasErrCode;
				if (hasErrCode)
				{
					this.ErrCode = other.ErrCode;
				}
				bool flag2 = other.connectionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.connectionInfo_ == null;
					if (flag3)
					{
						this.ConnectionInfo = new ConnectionInfo();
					}
					this.ConnectionInfo.MergeFrom(other.ConnectionInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x000F4D45 File Offset: 0x000F2F45
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x000F4D50 File Offset: 0x000F2F50
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.connectionInfo_ == null;
						if (flag)
						{
							this.ConnectionInfo = new ConnectionInfo();
						}
						input.ReadMessage(this.ConnectionInfo);
					}
				}
				else
				{
					this.ErrCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C73 RID: 7283
		private static readonly MessageParser<AddLocalPlayerToGameResponse> _parser = new MessageParser<AddLocalPlayerToGameResponse>(() => new AddLocalPlayerToGameResponse());

		// Token: 0x04001C74 RID: 7284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C75 RID: 7285
		private int _hasBits0;

		// Token: 0x04001C76 RID: 7286
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04001C77 RID: 7287
		private static readonly uint ErrCodeDefaultValue = 0U;

		// Token: 0x04001C78 RID: 7288
		private uint errCode_;

		// Token: 0x04001C79 RID: 7289
		public const int ConnectionInfoFieldNumber = 2;

		// Token: 0x04001C7A RID: 7290
		private ConnectionInfo connectionInfo_;
	}
}

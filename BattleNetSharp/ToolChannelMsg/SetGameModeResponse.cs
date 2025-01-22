using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003C RID: 60
	public sealed class SetGameModeResponse : IMessage<SetGameModeResponse>, IMessage, IEquatable<SetGameModeResponse>, IDeepCloneable<SetGameModeResponse>, IBufferMessage
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000168F8 File Offset: 0x00014AF8
		[DebuggerNonUserCode]
		public static MessageParser<SetGameModeResponse> Parser
		{
			get
			{
				return SetGameModeResponse._parser;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00016910 File Offset: 0x00014B10
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[37];
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00016934 File Offset: 0x00014B34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGameModeResponse.Descriptor;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001694B File Offset: 0x00014B4B
		[DebuggerNonUserCode]
		public SetGameModeResponse()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00016955 File Offset: 0x00014B55
		[DebuggerNonUserCode]
		public SetGameModeResponse(SetGameModeResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00016988 File Offset: 0x00014B88
		[DebuggerNonUserCode]
		public SetGameModeResponse Clone()
		{
			return new SetGameModeResponse(this);
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000169A0 File Offset: 0x00014BA0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000169D1 File Offset: 0x00014BD1
		[DebuggerNonUserCode]
		public bool Success
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool successDefaultValue;
				if (flag)
				{
					successDefaultValue = this.success_;
				}
				else
				{
					successDefaultValue = SetGameModeResponse.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000169EC File Offset: 0x00014BEC
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00016A09 File Offset: 0x00014C09
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00016A1C File Offset: 0x00014C1C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGameModeResponse);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00016A3C File Offset: 0x00014C3C
		[DebuggerNonUserCode]
		public bool Equals(SetGameModeResponse other)
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
					bool flag4 = this.Success != other.Success;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00016A94 File Offset: 0x00014C94
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num ^= this.Success.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00016AE4 File Offset: 0x00014CE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00016AFC File Offset: 0x00014CFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00016B08 File Offset: 0x00014D08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Success);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00016B54 File Offset: 0x00014D54
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00016B98 File Offset: 0x00014D98
		[DebuggerNonUserCode]
		public void MergeFrom(SetGameModeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSuccess = other.HasSuccess;
				if (hasSuccess)
				{
					this.Success = other.Success;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00016BE1 File Offset: 0x00014DE1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00016BEC File Offset: 0x00014DEC
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
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly MessageParser<SetGameModeResponse> _parser = new MessageParser<SetGameModeResponse>(() => new SetGameModeResponse());

		// Token: 0x040001F6 RID: 502
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001F7 RID: 503
		private int _hasBits0;

		// Token: 0x040001F8 RID: 504
		public const int SuccessFieldNumber = 1;

		// Token: 0x040001F9 RID: 505
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x040001FA RID: 506
		private bool success_;
	}
}

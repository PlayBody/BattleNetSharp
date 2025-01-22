using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200053F RID: 1343
	public sealed class GetGameSessionInfoRequest : IMessage<GetGameSessionInfoRequest>, IMessage, IEquatable<GetGameSessionInfoRequest>, IDeepCloneable<GetGameSessionInfoRequest>, IBufferMessage
	{
		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x060081EA RID: 33258 RVA: 0x001F92B0 File Offset: 0x001F74B0
		[DebuggerNonUserCode]
		public static MessageParser<GetGameSessionInfoRequest> Parser
		{
			get
			{
				return GetGameSessionInfoRequest._parser;
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x060081EB RID: 33259 RVA: 0x001F92C8 File Offset: 0x001F74C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x060081EC RID: 33260 RVA: 0x001F92EC File Offset: 0x001F74EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoRequest.Descriptor;
			}
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x001F9303 File Offset: 0x001F7503
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest()
		{
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x001F930D File Offset: 0x001F750D
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest(GetGameSessionInfoRequest other)
			: this()
		{
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x001F9344 File Offset: 0x001F7544
		[DebuggerNonUserCode]
		public GetGameSessionInfoRequest Clone()
		{
			return new GetGameSessionInfoRequest(this);
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x001F935C File Offset: 0x001F755C
		// (set) Token: 0x060081F1 RID: 33265 RVA: 0x001F9374 File Offset: 0x001F7574
		[DebuggerNonUserCode]
		public GameAccountHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x001F9380 File Offset: 0x001F7580
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoRequest);
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x001F93A0 File Offset: 0x001F75A0
		[DebuggerNonUserCode]
		public bool Equals(GetGameSessionInfoRequest other)
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
					bool flag4 = !object.Equals(this.Handle, other.Handle);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x001F93FC File Offset: 0x001F75FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x001F944C File Offset: 0x001F764C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x001F9464 File Offset: 0x001F7664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x001F9470 File Offset: 0x001F7670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x001F94C0 File Offset: 0x001F76C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x001F9514 File Offset: 0x001F7714
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameSessionInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.handle_ != null;
				if (flag2)
				{
					bool flag3 = this.handle_ == null;
					if (flag3)
					{
						this.Handle = new GameAccountHandle();
					}
					this.Handle.MergeFrom(other.Handle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x001F9580 File Offset: 0x001F7780
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x001F958C File Offset: 0x001F778C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.handle_ == null;
					if (flag)
					{
						this.Handle = new GameAccountHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x04003ACF RID: 15055
		private static readonly MessageParser<GetGameSessionInfoRequest> _parser = new MessageParser<GetGameSessionInfoRequest>(() => new GetGameSessionInfoRequest());

		// Token: 0x04003AD0 RID: 15056
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AD1 RID: 15057
		public const int HandleFieldNumber = 1;

		// Token: 0x04003AD2 RID: 15058
		private GameAccountHandle handle_;
	}
}

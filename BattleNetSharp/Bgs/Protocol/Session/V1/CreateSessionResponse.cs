using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000530 RID: 1328
	public sealed class CreateSessionResponse : IMessage<CreateSessionResponse>, IMessage, IEquatable<CreateSessionResponse>, IDeepCloneable<CreateSessionResponse>, IBufferMessage
	{
		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060080A2 RID: 32930 RVA: 0x001F54FC File Offset: 0x001F36FC
		[DebuggerNonUserCode]
		public static MessageParser<CreateSessionResponse> Parser
		{
			get
			{
				return CreateSessionResponse._parser;
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x001F5514 File Offset: 0x001F3714
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x001F5538 File Offset: 0x001F3738
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateSessionResponse.Descriptor;
			}
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x001F554F File Offset: 0x001F374F
		[DebuggerNonUserCode]
		public CreateSessionResponse()
		{
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x001F5559 File Offset: 0x001F3759
		[DebuggerNonUserCode]
		public CreateSessionResponse(CreateSessionResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sessionId_ = other.sessionId_;
			this.timeoutS_ = other.timeoutS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x001F5598 File Offset: 0x001F3798
		[DebuggerNonUserCode]
		public CreateSessionResponse Clone()
		{
			return new CreateSessionResponse(this);
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x001F55B0 File Offset: 0x001F37B0
		// (set) Token: 0x060080A9 RID: 32937 RVA: 0x001F55D1 File Offset: 0x001F37D1
		[DebuggerNonUserCode]
		public string SessionId
		{
			get
			{
				return this.sessionId_ ?? CreateSessionResponse.SessionIdDefaultValue;
			}
			set
			{
				this.sessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060080AA RID: 32938 RVA: 0x001F55E8 File Offset: 0x001F37E8
		[DebuggerNonUserCode]
		public bool HasSessionId
		{
			get
			{
				return this.sessionId_ != null;
			}
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x001F5603 File Offset: 0x001F3803
		[DebuggerNonUserCode]
		public void ClearSessionId()
		{
			this.sessionId_ = null;
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x060080AC RID: 32940 RVA: 0x001F5610 File Offset: 0x001F3810
		// (set) Token: 0x060080AD RID: 32941 RVA: 0x001F5641 File Offset: 0x001F3841
		[DebuggerNonUserCode]
		public uint TimeoutS
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint timeoutSDefaultValue;
				if (flag)
				{
					timeoutSDefaultValue = this.timeoutS_;
				}
				else
				{
					timeoutSDefaultValue = CreateSessionResponse.TimeoutSDefaultValue;
				}
				return timeoutSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timeoutS_ = value;
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x060080AE RID: 32942 RVA: 0x001F565C File Offset: 0x001F385C
		[DebuggerNonUserCode]
		public bool HasTimeoutS
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x001F5679 File Offset: 0x001F3879
		[DebuggerNonUserCode]
		public void ClearTimeoutS()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x001F568C File Offset: 0x001F388C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateSessionResponse);
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x001F56AC File Offset: 0x001F38AC
		[DebuggerNonUserCode]
		public bool Equals(CreateSessionResponse other)
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
					bool flag4 = this.SessionId != other.SessionId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TimeoutS != other.TimeoutS;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x001F5720 File Offset: 0x001F3920
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num ^= this.SessionId.GetHashCode();
			}
			bool hasTimeoutS = this.HasTimeoutS;
			if (hasTimeoutS)
			{
				num ^= this.TimeoutS.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x001F578C File Offset: 0x001F398C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x001F57A4 File Offset: 0x001F39A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x001F57B0 File Offset: 0x001F39B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SessionId);
			}
			bool hasTimeoutS = this.HasTimeoutS;
			if (hasTimeoutS)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TimeoutS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x001F5820 File Offset: 0x001F3A20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSessionId = this.HasSessionId;
			if (hasSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionId);
			}
			bool hasTimeoutS = this.HasTimeoutS;
			if (hasTimeoutS)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimeoutS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x001F588C File Offset: 0x001F3A8C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateSessionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSessionId = other.HasSessionId;
				if (hasSessionId)
				{
					this.SessionId = other.SessionId;
				}
				bool hasTimeoutS = other.HasTimeoutS;
				if (hasTimeoutS)
				{
					this.TimeoutS = other.TimeoutS;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x001F58EE File Offset: 0x001F3AEE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x001F58FC File Offset: 0x001F3AFC
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TimeoutS = input.ReadUInt32();
					}
				}
				else
				{
					this.SessionId = input.ReadString();
				}
			}
		}

		// Token: 0x04003A6A RID: 14954
		private static readonly MessageParser<CreateSessionResponse> _parser = new MessageParser<CreateSessionResponse>(() => new CreateSessionResponse());

		// Token: 0x04003A6B RID: 14955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A6C RID: 14956
		private int _hasBits0;

		// Token: 0x04003A6D RID: 14957
		public const int SessionIdFieldNumber = 1;

		// Token: 0x04003A6E RID: 14958
		private static readonly string SessionIdDefaultValue = "";

		// Token: 0x04003A6F RID: 14959
		private string sessionId_;

		// Token: 0x04003A70 RID: 14960
		public const int TimeoutSFieldNumber = 2;

		// Token: 0x04003A71 RID: 14961
		private static readonly uint TimeoutSDefaultValue = 0U;

		// Token: 0x04003A72 RID: 14962
		private uint timeoutS_;
	}
}

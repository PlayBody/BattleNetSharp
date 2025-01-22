using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071F RID: 1823
	public sealed class GetGameSessionInfoResponse : IMessage<GetGameSessionInfoResponse>, IMessage, IEquatable<GetGameSessionInfoResponse>, IDeepCloneable<GetGameSessionInfoResponse>, IBufferMessage
	{
		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600A710 RID: 42768 RVA: 0x0028A5E0 File Offset: 0x002887E0
		[DebuggerNonUserCode]
		public static MessageParser<GetGameSessionInfoResponse> Parser
		{
			get
			{
				return GetGameSessionInfoResponse._parser;
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600A711 RID: 42769 RVA: 0x0028A5F8 File Offset: 0x002887F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600A712 RID: 42770 RVA: 0x0028A61C File Offset: 0x0028881C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x0028A633 File Offset: 0x00288833
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse()
		{
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x0028A63D File Offset: 0x0028883D
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse(GetGameSessionInfoResponse other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x0028A674 File Offset: 0x00288874
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse Clone()
		{
			return new GetGameSessionInfoResponse(this);
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600A716 RID: 42774 RVA: 0x0028A68C File Offset: 0x0028888C
		// (set) Token: 0x0600A717 RID: 42775 RVA: 0x0028A6A4 File Offset: 0x002888A4
		[DebuggerNonUserCode]
		public GameSessionInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x0028A6B0 File Offset: 0x002888B0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoResponse);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x0028A6D0 File Offset: 0x002888D0
		[DebuggerNonUserCode]
		public bool Equals(GetGameSessionInfoResponse other)
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
					bool flag4 = !object.Equals(this.SessionInfo, other.SessionInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x0028A72C File Offset: 0x0028892C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num ^= this.SessionInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x0028A77C File Offset: 0x0028897C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x0028A794 File Offset: 0x00288994
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x0028A7A0 File Offset: 0x002889A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x0028A7F0 File Offset: 0x002889F0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x0028A844 File Offset: 0x00288A44
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameSessionInfoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionInfo_ == null;
					if (flag3)
					{
						this.SessionInfo = new GameSessionInfo();
					}
					this.SessionInfo.MergeFrom(other.SessionInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x0028A8B0 File Offset: 0x00288AB0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x0028A8BC File Offset: 0x00288ABC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.sessionInfo_ == null;
					if (flag)
					{
						this.SessionInfo = new GameSessionInfo();
					}
					input.ReadMessage(this.SessionInfo);
				}
			}
		}

		// Token: 0x04004AFD RID: 19197
		private static readonly MessageParser<GetGameSessionInfoResponse> _parser = new MessageParser<GetGameSessionInfoResponse>(() => new GetGameSessionInfoResponse());

		// Token: 0x04004AFE RID: 19198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AFF RID: 19199
		public const int SessionInfoFieldNumber = 2;

		// Token: 0x04004B00 RID: 19200
		private GameSessionInfo sessionInfo_;
	}
}

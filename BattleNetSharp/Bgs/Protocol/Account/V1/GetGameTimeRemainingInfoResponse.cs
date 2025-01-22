using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000721 RID: 1825
	public sealed class GetGameTimeRemainingInfoResponse : IMessage<GetGameTimeRemainingInfoResponse>, IMessage, IEquatable<GetGameTimeRemainingInfoResponse>, IDeepCloneable<GetGameTimeRemainingInfoResponse>, IBufferMessage
	{
		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600A73C RID: 42812 RVA: 0x0028AF10 File Offset: 0x00289110
		[DebuggerNonUserCode]
		public static MessageParser<GetGameTimeRemainingInfoResponse> Parser
		{
			get
			{
				return GetGameTimeRemainingInfoResponse._parser;
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x0028AF28 File Offset: 0x00289128
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x0028AF4C File Offset: 0x0028914C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameTimeRemainingInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x0028AF63 File Offset: 0x00289163
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoResponse()
		{
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x0028AF6D File Offset: 0x0028916D
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoResponse(GetGameTimeRemainingInfoResponse other)
			: this()
		{
			this.gameTimeRemainingInfo_ = ((other.gameTimeRemainingInfo_ != null) ? other.gameTimeRemainingInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x0028AFA4 File Offset: 0x002891A4
		[DebuggerNonUserCode]
		public GetGameTimeRemainingInfoResponse Clone()
		{
			return new GetGameTimeRemainingInfoResponse(this);
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x0028AFBC File Offset: 0x002891BC
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x0028AFD4 File Offset: 0x002891D4
		[DebuggerNonUserCode]
		public GameTimeRemainingInfo GameTimeRemainingInfo
		{
			get
			{
				return this.gameTimeRemainingInfo_;
			}
			set
			{
				this.gameTimeRemainingInfo_ = value;
			}
		}

		// Token: 0x0600A744 RID: 42820 RVA: 0x0028AFE0 File Offset: 0x002891E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameTimeRemainingInfoResponse);
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x0028B000 File Offset: 0x00289200
		[DebuggerNonUserCode]
		public bool Equals(GetGameTimeRemainingInfoResponse other)
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
					bool flag4 = !object.Equals(this.GameTimeRemainingInfo, other.GameTimeRemainingInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x0028B05C File Offset: 0x0028925C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameTimeRemainingInfo_ != null;
			if (flag)
			{
				num ^= this.GameTimeRemainingInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x0028B0AC File Offset: 0x002892AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x0028B0C4 File Offset: 0x002892C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x0028B0D0 File Offset: 0x002892D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameTimeRemainingInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameTimeRemainingInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x0028B120 File Offset: 0x00289320
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameTimeRemainingInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameTimeRemainingInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x0028B174 File Offset: 0x00289374
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameTimeRemainingInfoResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameTimeRemainingInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.gameTimeRemainingInfo_ == null;
					if (flag3)
					{
						this.GameTimeRemainingInfo = new GameTimeRemainingInfo();
					}
					this.GameTimeRemainingInfo.MergeFrom(other.GameTimeRemainingInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x0028B1E0 File Offset: 0x002893E0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x0028B1EC File Offset: 0x002893EC
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
					bool flag = this.gameTimeRemainingInfo_ == null;
					if (flag)
					{
						this.GameTimeRemainingInfo = new GameTimeRemainingInfo();
					}
					input.ReadMessage(this.GameTimeRemainingInfo);
				}
			}
		}

		// Token: 0x04004B0A RID: 19210
		private static readonly MessageParser<GetGameTimeRemainingInfoResponse> _parser = new MessageParser<GetGameTimeRemainingInfoResponse>(() => new GetGameTimeRemainingInfoResponse());

		// Token: 0x04004B0B RID: 19211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B0C RID: 19212
		public const int GameTimeRemainingInfoFieldNumber = 1;

		// Token: 0x04004B0D RID: 19213
		private GameTimeRemainingInfo gameTimeRemainingInfo_;
	}
}

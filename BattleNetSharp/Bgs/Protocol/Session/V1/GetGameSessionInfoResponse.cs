using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000540 RID: 1344
	public sealed class GetGameSessionInfoResponse : IMessage<GetGameSessionInfoResponse>, IMessage, IEquatable<GetGameSessionInfoResponse>, IDeepCloneable<GetGameSessionInfoResponse>, IBufferMessage
	{
		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x060081FD RID: 33277 RVA: 0x001F9618 File Offset: 0x001F7818
		[DebuggerNonUserCode]
		public static MessageParser<GetGameSessionInfoResponse> Parser
		{
			get
			{
				return GetGameSessionInfoResponse._parser;
			}
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x001F9630 File Offset: 0x001F7830
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x060081FF RID: 33279 RVA: 0x001F9654 File Offset: 0x001F7854
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameSessionInfoResponse.Descriptor;
			}
		}

		// Token: 0x06008200 RID: 33280 RVA: 0x001F966B File Offset: 0x001F786B
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse()
		{
		}

		// Token: 0x06008201 RID: 33281 RVA: 0x001F9675 File Offset: 0x001F7875
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse(GetGameSessionInfoResponse other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008202 RID: 33282 RVA: 0x001F96AC File Offset: 0x001F78AC
		[DebuggerNonUserCode]
		public GetGameSessionInfoResponse Clone()
		{
			return new GetGameSessionInfoResponse(this);
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x001F96C4 File Offset: 0x001F78C4
		// (set) Token: 0x06008204 RID: 33284 RVA: 0x001F96DC File Offset: 0x001F78DC
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

		// Token: 0x06008205 RID: 33285 RVA: 0x001F96E8 File Offset: 0x001F78E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameSessionInfoResponse);
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x001F9708 File Offset: 0x001F7908
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

		// Token: 0x06008207 RID: 33287 RVA: 0x001F9764 File Offset: 0x001F7964
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

		// Token: 0x06008208 RID: 33288 RVA: 0x001F97B4 File Offset: 0x001F79B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x001F97CC File Offset: 0x001F79CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x001F97D8 File Offset: 0x001F79D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x001F9828 File Offset: 0x001F7A28
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

		// Token: 0x0600820C RID: 33292 RVA: 0x001F987C File Offset: 0x001F7A7C
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

		// Token: 0x0600820D RID: 33293 RVA: 0x001F98E8 File Offset: 0x001F7AE8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x001F98F4 File Offset: 0x001F7AF4
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
					bool flag = this.sessionInfo_ == null;
					if (flag)
					{
						this.SessionInfo = new GameSessionInfo();
					}
					input.ReadMessage(this.SessionInfo);
				}
			}
		}

		// Token: 0x04003AD3 RID: 15059
		private static readonly MessageParser<GetGameSessionInfoResponse> _parser = new MessageParser<GetGameSessionInfoResponse>(() => new GetGameSessionInfoResponse());

		// Token: 0x04003AD4 RID: 15060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AD5 RID: 15061
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x04003AD6 RID: 15062
		private GameSessionInfo sessionInfo_;
	}
}

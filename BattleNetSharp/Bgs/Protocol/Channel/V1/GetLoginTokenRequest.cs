using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F1 RID: 1777
	public sealed class GetLoginTokenRequest : IMessage<GetLoginTokenRequest>, IMessage, IEquatable<GetLoginTokenRequest>, IDeepCloneable<GetLoginTokenRequest>, IBufferMessage
	{
		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x0027EFF4 File Offset: 0x0027D1F4
		[DebuggerNonUserCode]
		public static MessageParser<GetLoginTokenRequest> Parser
		{
			get
			{
				return GetLoginTokenRequest._parser;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x0027F00C File Offset: 0x0027D20C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x0027F030 File Offset: 0x0027D230
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLoginTokenRequest.Descriptor;
			}
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x0027F047 File Offset: 0x0027D247
		[DebuggerNonUserCode]
		public GetLoginTokenRequest()
		{
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x0027F051 File Offset: 0x0027D251
		[DebuggerNonUserCode]
		public GetLoginTokenRequest(GetLoginTokenRequest other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x0027F088 File Offset: 0x0027D288
		[DebuggerNonUserCode]
		public GetLoginTokenRequest Clone()
		{
			return new GetLoginTokenRequest(this);
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A3DA RID: 41946 RVA: 0x0027F0A0 File Offset: 0x0027D2A0
		// (set) Token: 0x0600A3DB RID: 41947 RVA: 0x0027F0B8 File Offset: 0x0027D2B8
		[DebuggerNonUserCode]
		public GameAccountHandle MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x0027F0C4 File Offset: 0x0027D2C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLoginTokenRequest);
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x0027F0E4 File Offset: 0x0027D2E4
		[DebuggerNonUserCode]
		public bool Equals(GetLoginTokenRequest other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x0027F140 File Offset: 0x0027D340
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x0027F190 File Offset: 0x0027D390
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x0027F1A8 File Offset: 0x0027D3A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x0027F1B4 File Offset: 0x0027D3B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MemberId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x0027F204 File Offset: 0x0027D404
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x0027F258 File Offset: 0x0027D458
		[DebuggerNonUserCode]
		public void MergeFrom(GetLoginTokenRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x0027F2C4 File Offset: 0x0027D4C4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x0027F2D0 File Offset: 0x0027D4D0
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
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new GameAccountHandle();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040049DF RID: 18911
		private static readonly MessageParser<GetLoginTokenRequest> _parser = new MessageParser<GetLoginTokenRequest>(() => new GetLoginTokenRequest());

		// Token: 0x040049E0 RID: 18912
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E1 RID: 18913
		public const int MemberIdFieldNumber = 3;

		// Token: 0x040049E2 RID: 18914
		private GameAccountHandle memberId_;
	}
}

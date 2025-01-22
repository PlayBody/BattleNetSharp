using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F3 RID: 1779
	public sealed class GetJoinTokenRequest : IMessage<GetJoinTokenRequest>, IMessage, IEquatable<GetJoinTokenRequest>, IDeepCloneable<GetJoinTokenRequest>, IBufferMessage
	{
		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A3FA RID: 41978 RVA: 0x0027F6C4 File Offset: 0x0027D8C4
		[DebuggerNonUserCode]
		public static MessageParser<GetJoinTokenRequest> Parser
		{
			get
			{
				return GetJoinTokenRequest._parser;
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A3FB RID: 41979 RVA: 0x0027F6DC File Offset: 0x0027D8DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelVoiceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x0027F700 File Offset: 0x0027D900
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJoinTokenRequest.Descriptor;
			}
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x0027F717 File Offset: 0x0027D917
		[DebuggerNonUserCode]
		public GetJoinTokenRequest()
		{
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x0027F724 File Offset: 0x0027D924
		[DebuggerNonUserCode]
		public GetJoinTokenRequest(GetJoinTokenRequest other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x0027F784 File Offset: 0x0027D984
		[DebuggerNonUserCode]
		public GetJoinTokenRequest Clone()
		{
			return new GetJoinTokenRequest(this);
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A400 RID: 41984 RVA: 0x0027F79C File Offset: 0x0027D99C
		// (set) Token: 0x0600A401 RID: 41985 RVA: 0x0027F7B4 File Offset: 0x0027D9B4
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A402 RID: 41986 RVA: 0x0027F7C0 File Offset: 0x0027D9C0
		// (set) Token: 0x0600A403 RID: 41987 RVA: 0x0027F7D8 File Offset: 0x0027D9D8
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

		// Token: 0x0600A404 RID: 41988 RVA: 0x0027F7E4 File Offset: 0x0027D9E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJoinTokenRequest);
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x0027F804 File Offset: 0x0027DA04
		[DebuggerNonUserCode]
		public bool Equals(GetJoinTokenRequest other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.MemberId, other.MemberId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x0027F87C File Offset: 0x0027DA7C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x0027F8E8 File Offset: 0x0027DAE8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x0027F900 File Offset: 0x0027DB00
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x0027F90C File Offset: 0x0027DB0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.MemberId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x0027F980 File Offset: 0x0027DB80
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.memberId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x0027F9F4 File Offset: 0x0027DBF4
		[DebuggerNonUserCode]
		public void MergeFrom(GetJoinTokenRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.memberId_ != null;
				if (flag4)
				{
					bool flag5 = this.memberId_ == null;
					if (flag5)
					{
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x0027FAA1 File Offset: 0x0027DCA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x0027FAAC File Offset: 0x0027DCAC
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
					if (num3 != 34U)
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
				else
				{
					bool flag2 = this.channelId_ == null;
					if (flag2)
					{
						this.ChannelId = new ChannelId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x040049E7 RID: 18919
		private static readonly MessageParser<GetJoinTokenRequest> _parser = new MessageParser<GetJoinTokenRequest>(() => new GetJoinTokenRequest());

		// Token: 0x040049E8 RID: 18920
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E9 RID: 18921
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040049EA RID: 18922
		private ChannelId channelId_;

		// Token: 0x040049EB RID: 18923
		public const int MemberIdFieldNumber = 4;

		// Token: 0x040049EC RID: 18924
		private GameAccountHandle memberId_;
	}
}

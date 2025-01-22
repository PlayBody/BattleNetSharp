using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040F RID: 1039
	public sealed class GetFriendListResponse : IMessage<GetFriendListResponse>, IMessage, IEquatable<GetFriendListResponse>, IDeepCloneable<GetFriendListResponse>, IBufferMessage
	{
		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600669F RID: 26271 RVA: 0x0018CC78 File Offset: 0x0018AE78
		[DebuggerNonUserCode]
		public static MessageParser<GetFriendListResponse> Parser
		{
			get
			{
				return GetFriendListResponse._parser;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x060066A0 RID: 26272 RVA: 0x0018CC90 File Offset: 0x0018AE90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x060066A1 RID: 26273 RVA: 0x0018CCB4 File Offset: 0x0018AEB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendListResponse.Descriptor;
			}
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x0018CCCB File Offset: 0x0018AECB
		[DebuggerNonUserCode]
		public GetFriendListResponse()
		{
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x0018CCE0 File Offset: 0x0018AEE0
		[DebuggerNonUserCode]
		public GetFriendListResponse(GetFriendListResponse other)
			: this()
		{
			this.friends_ = other.friends_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066A4 RID: 26276 RVA: 0x0018CD0C File Offset: 0x0018AF0C
		[DebuggerNonUserCode]
		public GetFriendListResponse Clone()
		{
			return new GetFriendListResponse(this);
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0018CD24 File Offset: 0x0018AF24
		[DebuggerNonUserCode]
		public RepeatedField<Friend> Friends
		{
			get
			{
				return this.friends_;
			}
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x0018CD3C File Offset: 0x0018AF3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendListResponse);
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x0018CD5C File Offset: 0x0018AF5C
		[DebuggerNonUserCode]
		public bool Equals(GetFriendListResponse other)
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
					bool flag4 = !this.friends_.Equals(other.friends_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x0018CDB8 File Offset: 0x0018AFB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.friends_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x0018CDF8 File Offset: 0x0018AFF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x0018CE10 File Offset: 0x0018B010
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x0018CE1C File Offset: 0x0018B01C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friends_.WriteTo(ref output, GetFriendListResponse._repeated_friends_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x0018CE58 File Offset: 0x0018B058
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.friends_.CalculateSize(GetFriendListResponse._repeated_friends_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x0018CEA0 File Offset: 0x0018B0A0
		[DebuggerNonUserCode]
		public void MergeFrom(GetFriendListResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.friends_.Add(other.friends_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x0018CEE2 File Offset: 0x0018B0E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0018CEF0 File Offset: 0x0018B0F0
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
					this.friends_.AddEntriesFrom(ref input, GetFriendListResponse._repeated_friends_codec);
				}
			}
		}

		// Token: 0x04002E92 RID: 11922
		private static readonly MessageParser<GetFriendListResponse> _parser = new MessageParser<GetFriendListResponse>(() => new GetFriendListResponse());

		// Token: 0x04002E93 RID: 11923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E94 RID: 11924
		public const int FriendsFieldNumber = 1;

		// Token: 0x04002E95 RID: 11925
		private static readonly FieldCodec<Friend> _repeated_friends_codec = FieldCodec.ForMessage<Friend>(10U, Friend.Parser);

		// Token: 0x04002E96 RID: 11926
		private readonly RepeatedField<Friend> friends_ = new RepeatedField<Friend>();
	}
}

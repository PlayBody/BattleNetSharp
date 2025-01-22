using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Friends.V1
{
	// Token: 0x0200040C RID: 1036
	public sealed class ViewFriendsResponse : IMessage<ViewFriendsResponse>, IMessage, IEquatable<ViewFriendsResponse>, IDeepCloneable<ViewFriendsResponse>, IBufferMessage
	{
		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x0018C0A4 File Offset: 0x0018A2A4
		[DebuggerNonUserCode]
		public static MessageParser<ViewFriendsResponse> Parser
		{
			get
			{
				return ViewFriendsResponse._parser;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06006665 RID: 26213 RVA: 0x0018C0BC File Offset: 0x0018A2BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendsServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x0018C0E0 File Offset: 0x0018A2E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ViewFriendsResponse.Descriptor;
			}
		}

		// Token: 0x06006667 RID: 26215 RVA: 0x0018C0F7 File Offset: 0x0018A2F7
		[DebuggerNonUserCode]
		public ViewFriendsResponse()
		{
		}

		// Token: 0x06006668 RID: 26216 RVA: 0x0018C10C File Offset: 0x0018A30C
		[DebuggerNonUserCode]
		public ViewFriendsResponse(ViewFriendsResponse other)
			: this()
		{
			this.friends_ = other.friends_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006669 RID: 26217 RVA: 0x0018C138 File Offset: 0x0018A338
		[DebuggerNonUserCode]
		public ViewFriendsResponse Clone()
		{
			return new ViewFriendsResponse(this);
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600666A RID: 26218 RVA: 0x0018C150 File Offset: 0x0018A350
		[DebuggerNonUserCode]
		public RepeatedField<FriendOfFriend> Friends
		{
			get
			{
				return this.friends_;
			}
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x0018C168 File Offset: 0x0018A368
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ViewFriendsResponse);
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x0018C188 File Offset: 0x0018A388
		[DebuggerNonUserCode]
		public bool Equals(ViewFriendsResponse other)
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

		// Token: 0x0600666D RID: 26221 RVA: 0x0018C1E4 File Offset: 0x0018A3E4
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

		// Token: 0x0600666E RID: 26222 RVA: 0x0018C224 File Offset: 0x0018A424
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x0018C23C File Offset: 0x0018A43C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x0018C248 File Offset: 0x0018A448
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.friends_.WriteTo(ref output, ViewFriendsResponse._repeated_friends_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x0018C284 File Offset: 0x0018A484
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.friends_.CalculateSize(ViewFriendsResponse._repeated_friends_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x0018C2CC File Offset: 0x0018A4CC
		[DebuggerNonUserCode]
		public void MergeFrom(ViewFriendsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.friends_.Add(other.friends_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x0018C30E File Offset: 0x0018A50E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x0018C31C File Offset: 0x0018A51C
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
					this.friends_.AddEntriesFrom(ref input, ViewFriendsResponse._repeated_friends_codec);
				}
			}
		}

		// Token: 0x04002E80 RID: 11904
		private static readonly MessageParser<ViewFriendsResponse> _parser = new MessageParser<ViewFriendsResponse>(() => new ViewFriendsResponse());

		// Token: 0x04002E81 RID: 11905
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E82 RID: 11906
		public const int FriendsFieldNumber = 1;

		// Token: 0x04002E83 RID: 11907
		private static readonly FieldCodec<FriendOfFriend> _repeated_friends_codec = FieldCodec.ForMessage<FriendOfFriend>(10U, FriendOfFriend.Parser);

		// Token: 0x04002E84 RID: 11908
		private readonly RepeatedField<FriendOfFriend> friends_ = new RepeatedField<FriendOfFriend>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Sns.V1
{
	// Token: 0x020003D1 RID: 977
	public sealed class FacebookBnetFriendListNotificationResponse : IMessage<FacebookBnetFriendListNotificationResponse>, IMessage, IEquatable<FacebookBnetFriendListNotificationResponse>, IDeepCloneable<FacebookBnetFriendListNotificationResponse>, IBufferMessage
	{
		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x0017A224 File Offset: 0x00178424
		[DebuggerNonUserCode]
		public static MessageParser<FacebookBnetFriendListNotificationResponse> Parser
		{
			get
			{
				return FacebookBnetFriendListNotificationResponse._parser;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x0017A23C File Offset: 0x0017843C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SocialNetworkServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x0017A260 File Offset: 0x00178460
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FacebookBnetFriendListNotificationResponse.Descriptor;
			}
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x0017A277 File Offset: 0x00178477
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotificationResponse()
		{
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0017A281 File Offset: 0x00178481
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotificationResponse(FacebookBnetFriendListNotificationResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.continue_ = other.continue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x0017A2B4 File Offset: 0x001784B4
		[DebuggerNonUserCode]
		public FacebookBnetFriendListNotificationResponse Clone()
		{
			return new FacebookBnetFriendListNotificationResponse(this);
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x060061C6 RID: 25030 RVA: 0x0017A2CC File Offset: 0x001784CC
		// (set) Token: 0x060061C7 RID: 25031 RVA: 0x0017A2FD File Offset: 0x001784FD
		[DebuggerNonUserCode]
		public bool Continue
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool continueDefaultValue;
				if (flag)
				{
					continueDefaultValue = this.continue_;
				}
				else
				{
					continueDefaultValue = FacebookBnetFriendListNotificationResponse.ContinueDefaultValue;
				}
				return continueDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continue_ = value;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x060061C8 RID: 25032 RVA: 0x0017A318 File Offset: 0x00178518
		[DebuggerNonUserCode]
		public bool HasContinue
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x0017A335 File Offset: 0x00178535
		[DebuggerNonUserCode]
		public void ClearContinue()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x0017A348 File Offset: 0x00178548
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FacebookBnetFriendListNotificationResponse);
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x0017A368 File Offset: 0x00178568
		[DebuggerNonUserCode]
		public bool Equals(FacebookBnetFriendListNotificationResponse other)
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
					bool flag4 = this.Continue != other.Continue;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x0017A3C0 File Offset: 0x001785C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContinue = this.HasContinue;
			if (hasContinue)
			{
				num ^= this.Continue.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x0017A410 File Offset: 0x00178610
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x0017A428 File Offset: 0x00178628
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x0017A434 File Offset: 0x00178634
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContinue = this.HasContinue;
			if (hasContinue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x0017A480 File Offset: 0x00178680
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContinue = this.HasContinue;
			if (hasContinue)
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

		// Token: 0x060061D1 RID: 25041 RVA: 0x0017A4C4 File Offset: 0x001786C4
		[DebuggerNonUserCode]
		public void MergeFrom(FacebookBnetFriendListNotificationResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContinue = other.HasContinue;
				if (hasContinue)
				{
					this.Continue = other.Continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x0017A50D File Offset: 0x0017870D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x0017A518 File Offset: 0x00178718
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
					this.Continue = input.ReadBool();
				}
			}
		}

		// Token: 0x04002C92 RID: 11410
		private static readonly MessageParser<FacebookBnetFriendListNotificationResponse> _parser = new MessageParser<FacebookBnetFriendListNotificationResponse>(() => new FacebookBnetFriendListNotificationResponse());

		// Token: 0x04002C93 RID: 11411
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C94 RID: 11412
		private int _hasBits0;

		// Token: 0x04002C95 RID: 11413
		public const int ContinueFieldNumber = 1;

		// Token: 0x04002C96 RID: 11414
		private static readonly bool ContinueDefaultValue = true;

		// Token: 0x04002C97 RID: 11415
		private bool continue_;
	}
}

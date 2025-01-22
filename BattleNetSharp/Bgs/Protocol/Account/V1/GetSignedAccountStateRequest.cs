using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000718 RID: 1816
	public sealed class GetSignedAccountStateRequest : IMessage<GetSignedAccountStateRequest>, IMessage, IEquatable<GetSignedAccountStateRequest>, IDeepCloneable<GetSignedAccountStateRequest>, IBufferMessage
	{
		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x00288374 File Offset: 0x00286574
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedAccountStateRequest> Parser
		{
			get
			{
				return GetSignedAccountStateRequest._parser;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x0028838C File Offset: 0x0028658C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x002883B0 File Offset: 0x002865B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedAccountStateRequest.Descriptor;
			}
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x002883C7 File Offset: 0x002865C7
		[DebuggerNonUserCode]
		public GetSignedAccountStateRequest()
		{
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x002883D1 File Offset: 0x002865D1
		[DebuggerNonUserCode]
		public GetSignedAccountStateRequest(GetSignedAccountStateRequest other)
			: this()
		{
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A673 RID: 42611 RVA: 0x00288408 File Offset: 0x00286608
		[DebuggerNonUserCode]
		public GetSignedAccountStateRequest Clone()
		{
			return new GetSignedAccountStateRequest(this);
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x00288420 File Offset: 0x00286620
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x00288438 File Offset: 0x00286638
		[DebuggerNonUserCode]
		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x00288444 File Offset: 0x00286644
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedAccountStateRequest);
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x00288464 File Offset: 0x00286664
		[DebuggerNonUserCode]
		public bool Equals(GetSignedAccountStateRequest other)
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
					bool flag4 = !object.Equals(this.Account, other.Account);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x002884C0 File Offset: 0x002866C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.account_ != null;
			if (flag)
			{
				num ^= this.Account.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x00288510 File Offset: 0x00286710
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x00288528 File Offset: 0x00286728
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x00288534 File Offset: 0x00286734
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.account_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Account);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x00288584 File Offset: 0x00286784
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.account_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x002885D8 File Offset: 0x002867D8
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedAccountStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.account_ != null;
				if (flag2)
				{
					bool flag3 = this.account_ == null;
					if (flag3)
					{
						this.Account = new AccountId();
					}
					this.Account.MergeFrom(other.Account);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x00288644 File Offset: 0x00286844
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x00288650 File Offset: 0x00286850
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
					bool flag = this.account_ == null;
					if (flag)
					{
						this.Account = new AccountId();
					}
					input.ReadMessage(this.Account);
				}
			}
		}

		// Token: 0x04004AC7 RID: 19143
		private static readonly MessageParser<GetSignedAccountStateRequest> _parser = new MessageParser<GetSignedAccountStateRequest>(() => new GetSignedAccountStateRequest());

		// Token: 0x04004AC8 RID: 19144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AC9 RID: 19145
		public const int AccountFieldNumber = 1;

		// Token: 0x04004ACA RID: 19146
		private AccountId account_;
	}
}

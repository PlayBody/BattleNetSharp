using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000710 RID: 1808
	public sealed class ResolveAccountRequest : IMessage<ResolveAccountRequest>, IMessage, IEquatable<ResolveAccountRequest>, IDeepCloneable<ResolveAccountRequest>, IBufferMessage
	{
		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A5B8 RID: 42424 RVA: 0x00285DC8 File Offset: 0x00283FC8
		[DebuggerNonUserCode]
		public static MessageParser<ResolveAccountRequest> Parser
		{
			get
			{
				return ResolveAccountRequest._parser;
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x00285DE0 File Offset: 0x00283FE0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A5BA RID: 42426 RVA: 0x00285E04 File Offset: 0x00284004
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResolveAccountRequest.Descriptor;
			}
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x00285E1B File Offset: 0x0028401B
		[DebuggerNonUserCode]
		public ResolveAccountRequest()
		{
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x00285E28 File Offset: 0x00284028
		[DebuggerNonUserCode]
		public ResolveAccountRequest(ResolveAccountRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.ref_ = ((other.ref_ != null) ? other.ref_.Clone() : null);
			this.fetchId_ = other.fetchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x00285E84 File Offset: 0x00284084
		[DebuggerNonUserCode]
		public ResolveAccountRequest Clone()
		{
			return new ResolveAccountRequest(this);
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A5BE RID: 42430 RVA: 0x00285E9C File Offset: 0x0028409C
		// (set) Token: 0x0600A5BF RID: 42431 RVA: 0x00285EB4 File Offset: 0x002840B4
		[DebuggerNonUserCode]
		public AccountReference Ref
		{
			get
			{
				return this.ref_;
			}
			set
			{
				this.ref_ = value;
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x00285EC0 File Offset: 0x002840C0
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x00285EF1 File Offset: 0x002840F1
		[DebuggerNonUserCode]
		public bool FetchId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool fetchIdDefaultValue;
				if (flag)
				{
					fetchIdDefaultValue = this.fetchId_;
				}
				else
				{
					fetchIdDefaultValue = ResolveAccountRequest.FetchIdDefaultValue;
				}
				return fetchIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fetchId_ = value;
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A5C2 RID: 42434 RVA: 0x00285F0C File Offset: 0x0028410C
		[DebuggerNonUserCode]
		public bool HasFetchId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x00285F29 File Offset: 0x00284129
		[DebuggerNonUserCode]
		public void ClearFetchId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x00285F3C File Offset: 0x0028413C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResolveAccountRequest);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x00285F5C File Offset: 0x0028415C
		[DebuggerNonUserCode]
		public bool Equals(ResolveAccountRequest other)
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
					bool flag4 = !object.Equals(this.Ref, other.Ref);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FetchId != other.FetchId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x00285FD0 File Offset: 0x002841D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.ref_ != null;
			if (flag)
			{
				num ^= this.Ref.GetHashCode();
			}
			bool hasFetchId = this.HasFetchId;
			if (hasFetchId)
			{
				num ^= this.FetchId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x0028603C File Offset: 0x0028423C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x00286054 File Offset: 0x00284254
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x00286060 File Offset: 0x00284260
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.ref_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Ref);
			}
			bool hasFetchId = this.HasFetchId;
			if (hasFetchId)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.FetchId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x002860D4 File Offset: 0x002842D4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.ref_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Ref);
			}
			bool hasFetchId = this.HasFetchId;
			if (hasFetchId)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x00286138 File Offset: 0x00284338
		[DebuggerNonUserCode]
		public void MergeFrom(ResolveAccountRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.ref_ != null;
				if (flag2)
				{
					bool flag3 = this.ref_ == null;
					if (flag3)
					{
						this.Ref = new AccountReference();
					}
					this.Ref.MergeFrom(other.Ref);
				}
				bool hasFetchId = other.HasFetchId;
				if (hasFetchId)
				{
					this.FetchId = other.FetchId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x002861BD File Offset: 0x002843BD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x002861C8 File Offset: 0x002843C8
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
					if (num3 != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FetchId = input.ReadBool();
					}
				}
				else
				{
					bool flag = this.ref_ == null;
					if (flag)
					{
						this.Ref = new AccountReference();
					}
					input.ReadMessage(this.Ref);
				}
			}
		}

		// Token: 0x04004A88 RID: 19080
		private static readonly MessageParser<ResolveAccountRequest> _parser = new MessageParser<ResolveAccountRequest>(() => new ResolveAccountRequest());

		// Token: 0x04004A89 RID: 19081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A8A RID: 19082
		private int _hasBits0;

		// Token: 0x04004A8B RID: 19083
		public const int RefFieldNumber = 1;

		// Token: 0x04004A8C RID: 19084
		private AccountReference ref_;

		// Token: 0x04004A8D RID: 19085
		public const int FetchIdFieldNumber = 12;

		// Token: 0x04004A8E RID: 19086
		private static readonly bool FetchIdDefaultValue = false;

		// Token: 0x04004A8F RID: 19087
		private bool fetchId_;
	}
}

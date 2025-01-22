using System;
using System.Diagnostics;
using Fenris.Search;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027C RID: 636
	public sealed class FindClansRequest : IMessage<FindClansRequest>, IMessage, IEquatable<FindClansRequest>, IDeepCloneable<FindClansRequest>, IBufferMessage
	{
		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x001067E4 File Offset: 0x001049E4
		[DebuggerNonUserCode]
		public static MessageParser<FindClansRequest> Parser
		{
			get
			{
				return FindClansRequest._parser;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x001067FC File Offset: 0x001049FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[108];
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00106820 File Offset: 0x00104A20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FindClansRequest.Descriptor;
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00106837 File Offset: 0x00104A37
		[DebuggerNonUserCode]
		public FindClansRequest()
		{
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00106844 File Offset: 0x00104A44
		[DebuggerNonUserCode]
		public FindClansRequest(FindClansRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientSearchToken_ = other.clientSearchToken_;
			this.params_ = ((other.params_ != null) ? other.params_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x001068A0 File Offset: 0x00104AA0
		[DebuggerNonUserCode]
		public FindClansRequest Clone()
		{
			return new FindClansRequest(this);
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x001068B8 File Offset: 0x00104AB8
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x001068E9 File Offset: 0x00104AE9
		[DebuggerNonUserCode]
		public ulong ClientSearchToken
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clientSearchTokenDefaultValue;
				if (flag)
				{
					clientSearchTokenDefaultValue = this.clientSearchToken_;
				}
				else
				{
					clientSearchTokenDefaultValue = FindClansRequest.ClientSearchTokenDefaultValue;
				}
				return clientSearchTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clientSearchToken_ = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x00106904 File Offset: 0x00104B04
		[DebuggerNonUserCode]
		public bool HasClientSearchToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x00106921 File Offset: 0x00104B21
		[DebuggerNonUserCode]
		public void ClearClientSearchToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x00106934 File Offset: 0x00104B34
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x0010694C File Offset: 0x00104B4C
		[DebuggerNonUserCode]
		public FindClansParams Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = value;
			}
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x00106958 File Offset: 0x00104B58
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FindClansRequest);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00106978 File Offset: 0x00104B78
		[DebuggerNonUserCode]
		public bool Equals(FindClansRequest other)
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
					bool flag4 = this.ClientSearchToken != other.ClientSearchToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Params, other.Params);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x001069EC File Offset: 0x00104BEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				num ^= this.ClientSearchToken.GetHashCode();
			}
			bool flag = this.params_ != null;
			if (flag)
			{
				num ^= this.Params.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00106A58 File Offset: 0x00104C58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00106A70 File Offset: 0x00104C70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x00106A7C File Offset: 0x00104C7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClientSearchToken);
			}
			bool flag = this.params_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Params);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x00106AEC File Offset: 0x00104CEC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientSearchToken = this.HasClientSearchToken;
			if (hasClientSearchToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClientSearchToken);
			}
			bool flag = this.params_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Params);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00106B5C File Offset: 0x00104D5C
		[DebuggerNonUserCode]
		public void MergeFrom(FindClansRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientSearchToken = other.HasClientSearchToken;
				if (hasClientSearchToken)
				{
					this.ClientSearchToken = other.ClientSearchToken;
				}
				bool flag2 = other.params_ != null;
				if (flag2)
				{
					bool flag3 = this.params_ == null;
					if (flag3)
					{
						this.Params = new FindClansParams();
					}
					this.Params.MergeFrom(other.Params);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x00106BE1 File Offset: 0x00104DE1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x00106BEC File Offset: 0x00104DEC
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.params_ == null;
						if (flag)
						{
							this.Params = new FindClansParams();
						}
						input.ReadMessage(this.Params);
					}
				}
				else
				{
					this.ClientSearchToken = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001E8B RID: 7819
		private static readonly MessageParser<FindClansRequest> _parser = new MessageParser<FindClansRequest>(() => new FindClansRequest());

		// Token: 0x04001E8C RID: 7820
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E8D RID: 7821
		private int _hasBits0;

		// Token: 0x04001E8E RID: 7822
		public const int ClientSearchTokenFieldNumber = 1;

		// Token: 0x04001E8F RID: 7823
		private static readonly ulong ClientSearchTokenDefaultValue = 0UL;

		// Token: 0x04001E90 RID: 7824
		private ulong clientSearchToken_;

		// Token: 0x04001E91 RID: 7825
		public const int ParamsFieldNumber = 2;

		// Token: 0x04001E92 RID: 7826
		private FindClansParams params_;
	}
}

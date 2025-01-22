using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000266 RID: 614
	public sealed class LeaveClanRequest : IMessage<LeaveClanRequest>, IMessage, IEquatable<LeaveClanRequest>, IDeepCloneable<LeaveClanRequest>, IBufferMessage
	{
		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00100B6C File Offset: 0x000FED6C
		[DebuggerNonUserCode]
		public static MessageParser<LeaveClanRequest> Parser
		{
			get
			{
				return LeaveClanRequest._parser;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00100B84 File Offset: 0x000FED84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[86];
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x00100BA8 File Offset: 0x000FEDA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveClanRequest.Descriptor;
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00100BBF File Offset: 0x000FEDBF
		[DebuggerNonUserCode]
		public LeaveClanRequest()
		{
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00100BC9 File Offset: 0x000FEDC9
		[DebuggerNonUserCode]
		public LeaveClanRequest(LeaveClanRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00100BF0 File Offset: 0x000FEDF0
		[DebuggerNonUserCode]
		public LeaveClanRequest Clone()
		{
			return new LeaveClanRequest(this);
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060041FC RID: 16892 RVA: 0x00100C08 File Offset: 0x000FEE08
		// (set) Token: 0x060041FD RID: 16893 RVA: 0x00100C29 File Offset: 0x000FEE29
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? LeaveClanRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x00100C40 File Offset: 0x000FEE40
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x00100C5B File Offset: 0x000FEE5B
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x00100C68 File Offset: 0x000FEE68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveClanRequest);
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x00100C88 File Offset: 0x000FEE88
		[DebuggerNonUserCode]
		public bool Equals(LeaveClanRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00100CE0 File Offset: 0x000FEEE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00100D2C File Offset: 0x000FEF2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00100D44 File Offset: 0x000FEF44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x00100D50 File Offset: 0x000FEF50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x00100D9C File Offset: 0x000FEF9C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00100DEC File Offset: 0x000FEFEC
		[DebuggerNonUserCode]
		public void MergeFrom(LeaveClanRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x00100E35 File Offset: 0x000FF035
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00100E40 File Offset: 0x000FF040
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
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DE6 RID: 7654
		private static readonly MessageParser<LeaveClanRequest> _parser = new MessageParser<LeaveClanRequest>(() => new LeaveClanRequest());

		// Token: 0x04001DE7 RID: 7655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DE8 RID: 7656
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001DE9 RID: 7657
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001DEA RID: 7658
		private string clanId_;
	}
}

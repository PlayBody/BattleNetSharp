using System;
using System.Diagnostics;
using Fenris.License;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000297 RID: 663
	public sealed class RefreshLicensesResponse : IMessage<RefreshLicensesResponse>, IMessage, IEquatable<RefreshLicensesResponse>, IDeepCloneable<RefreshLicensesResponse>, IBufferMessage
	{
		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x0010D23C File Offset: 0x0010B43C
		[DebuggerNonUserCode]
		public static MessageParser<RefreshLicensesResponse> Parser
		{
			get
			{
				return RefreshLicensesResponse._parser;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x0010D254 File Offset: 0x0010B454
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[135];
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x0010D27C File Offset: 0x0010B47C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshLicensesResponse.Descriptor;
			}
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x0010D293 File Offset: 0x0010B493
		[DebuggerNonUserCode]
		public RefreshLicensesResponse()
		{
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x0010D29D File Offset: 0x0010B49D
		[DebuggerNonUserCode]
		public RefreshLicensesResponse(RefreshLicensesResponse other)
			: this()
		{
			this.licenses_ = ((other.licenses_ != null) ? other.licenses_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x0010D2D4 File Offset: 0x0010B4D4
		[DebuggerNonUserCode]
		public RefreshLicensesResponse Clone()
		{
			return new RefreshLicensesResponse(this);
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x0010D2EC File Offset: 0x0010B4EC
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x0010D304 File Offset: 0x0010B504
		[DebuggerNonUserCode]
		public PlayerLicenses Licenses
		{
			get
			{
				return this.licenses_;
			}
			set
			{
				this.licenses_ = value;
			}
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x0010D310 File Offset: 0x0010B510
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshLicensesResponse);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x0010D330 File Offset: 0x0010B530
		[DebuggerNonUserCode]
		public bool Equals(RefreshLicensesResponse other)
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
					bool flag4 = !object.Equals(this.Licenses, other.Licenses);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0010D38C File Offset: 0x0010B58C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.licenses_ != null;
			if (flag)
			{
				num ^= this.Licenses.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x0010D3DC File Offset: 0x0010B5DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x0010D3F4 File Offset: 0x0010B5F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x0010D400 File Offset: 0x0010B600
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.licenses_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Licenses);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x0010D450 File Offset: 0x0010B650
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.licenses_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Licenses);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x0010D4A4 File Offset: 0x0010B6A4
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshLicensesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.licenses_ != null;
				if (flag2)
				{
					bool flag3 = this.licenses_ == null;
					if (flag3)
					{
						this.Licenses = new PlayerLicenses();
					}
					this.Licenses.MergeFrom(other.Licenses);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x0010D510 File Offset: 0x0010B710
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x0010D51C File Offset: 0x0010B71C
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
					bool flag = this.licenses_ == null;
					if (flag)
					{
						this.Licenses = new PlayerLicenses();
					}
					input.ReadMessage(this.Licenses);
				}
			}
		}

		// Token: 0x04001F44 RID: 8004
		private static readonly MessageParser<RefreshLicensesResponse> _parser = new MessageParser<RefreshLicensesResponse>(() => new RefreshLicensesResponse());

		// Token: 0x04001F45 RID: 8005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F46 RID: 8006
		public const int LicensesFieldNumber = 1;

		// Token: 0x04001F47 RID: 8007
		private PlayerLicenses licenses_;
	}
}

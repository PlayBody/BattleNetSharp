using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005C0 RID: 1472
	public sealed class PresenceOnlineGameAccountFieldValue : IMessage<PresenceOnlineGameAccountFieldValue>, IMessage, IEquatable<PresenceOnlineGameAccountFieldValue>, IDeepCloneable<PresenceOnlineGameAccountFieldValue>, IBufferMessage
	{
		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06008B88 RID: 35720 RVA: 0x0021DE98 File Offset: 0x0021C098
		[DebuggerNonUserCode]
		public static MessageParser<PresenceOnlineGameAccountFieldValue> Parser
		{
			get
			{
				return PresenceOnlineGameAccountFieldValue._parser;
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x0021DEB0 File Offset: 0x0021C0B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x06008B8A RID: 35722 RVA: 0x0021DED4 File Offset: 0x0021C0D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceOnlineGameAccountFieldValue.Descriptor;
			}
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x0021DEEB File Offset: 0x0021C0EB
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccountFieldValue()
		{
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x0021DF00 File Offset: 0x0021C100
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccountFieldValue(PresenceOnlineGameAccountFieldValue other)
			: this()
		{
			this.onlineGameAccounts_ = other.onlineGameAccounts_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x0021DF2C File Offset: 0x0021C12C
		[DebuggerNonUserCode]
		public PresenceOnlineGameAccountFieldValue Clone()
		{
			return new PresenceOnlineGameAccountFieldValue(this);
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x06008B8E RID: 35726 RVA: 0x0021DF44 File Offset: 0x0021C144
		[DebuggerNonUserCode]
		public RepeatedField<PresenceOnlineGameAccount> OnlineGameAccounts
		{
			get
			{
				return this.onlineGameAccounts_;
			}
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x0021DF5C File Offset: 0x0021C15C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceOnlineGameAccountFieldValue);
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x0021DF7C File Offset: 0x0021C17C
		[DebuggerNonUserCode]
		public bool Equals(PresenceOnlineGameAccountFieldValue other)
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
					bool flag4 = !this.onlineGameAccounts_.Equals(other.onlineGameAccounts_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x0021DFD8 File Offset: 0x0021C1D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.onlineGameAccounts_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x0021E018 File Offset: 0x0021C218
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x0021E030 File Offset: 0x0021C230
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x0021E03C File Offset: 0x0021C23C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.onlineGameAccounts_.WriteTo(ref output, PresenceOnlineGameAccountFieldValue._repeated_onlineGameAccounts_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x0021E078 File Offset: 0x0021C278
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.onlineGameAccounts_.CalculateSize(PresenceOnlineGameAccountFieldValue._repeated_onlineGameAccounts_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x0021E0C0 File Offset: 0x0021C2C0
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceOnlineGameAccountFieldValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.onlineGameAccounts_.Add(other.onlineGameAccounts_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x0021E102 File Offset: 0x0021C302
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x0021E110 File Offset: 0x0021C310
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
					this.onlineGameAccounts_.AddEntriesFrom(ref input, PresenceOnlineGameAccountFieldValue._repeated_onlineGameAccounts_codec);
				}
			}
		}

		// Token: 0x04003F2A RID: 16170
		private static readonly MessageParser<PresenceOnlineGameAccountFieldValue> _parser = new MessageParser<PresenceOnlineGameAccountFieldValue>(() => new PresenceOnlineGameAccountFieldValue());

		// Token: 0x04003F2B RID: 16171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F2C RID: 16172
		public const int OnlineGameAccountsFieldNumber = 1;

		// Token: 0x04003F2D RID: 16173
		private static readonly FieldCodec<PresenceOnlineGameAccount> _repeated_onlineGameAccounts_codec = FieldCodec.ForMessage<PresenceOnlineGameAccount>(10U, PresenceOnlineGameAccount.Parser);

		// Token: 0x04003F2E RID: 16174
		private readonly RepeatedField<PresenceOnlineGameAccount> onlineGameAccounts_ = new RepeatedField<PresenceOnlineGameAccount>();
	}
}

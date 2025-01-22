using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200028D RID: 653
	public sealed class RefreshSessionKeyRequest : IMessage<RefreshSessionKeyRequest>, IMessage, IEquatable<RefreshSessionKeyRequest>, IDeepCloneable<RefreshSessionKeyRequest>, IBufferMessage
	{
		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x0010B0F0 File Offset: 0x001092F0
		[DebuggerNonUserCode]
		public static MessageParser<RefreshSessionKeyRequest> Parser
		{
			get
			{
				return RefreshSessionKeyRequest._parser;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x0010B108 File Offset: 0x00109308
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[125];
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x0010B12C File Offset: 0x0010932C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RefreshSessionKeyRequest.Descriptor;
			}
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x0010B143 File Offset: 0x00109343
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest()
		{
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x0010B14D File Offset: 0x0010934D
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest(RefreshSessionKeyRequest other)
			: this()
		{
			this.oldSessionKey_ = other.oldSessionKey_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x0010B174 File Offset: 0x00109374
		[DebuggerNonUserCode]
		public RefreshSessionKeyRequest Clone()
		{
			return new RefreshSessionKeyRequest(this);
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x0010B18C File Offset: 0x0010938C
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x0010B1AD File Offset: 0x001093AD
		[DebuggerNonUserCode]
		public ByteString OldSessionKey
		{
			get
			{
				return this.oldSessionKey_ ?? RefreshSessionKeyRequest.OldSessionKeyDefaultValue;
			}
			set
			{
				this.oldSessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x0010B1C4 File Offset: 0x001093C4
		[DebuggerNonUserCode]
		public bool HasOldSessionKey
		{
			get
			{
				return this.oldSessionKey_ != null;
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x0010B1E2 File Offset: 0x001093E2
		[DebuggerNonUserCode]
		public void ClearOldSessionKey()
		{
			this.oldSessionKey_ = null;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x0010B1EC File Offset: 0x001093EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RefreshSessionKeyRequest);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x0010B20C File Offset: 0x0010940C
		[DebuggerNonUserCode]
		public bool Equals(RefreshSessionKeyRequest other)
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
					bool flag4 = this.OldSessionKey != other.OldSessionKey;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x0010B264 File Offset: 0x00109464
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasOldSessionKey = this.HasOldSessionKey;
			if (hasOldSessionKey)
			{
				num ^= this.OldSessionKey.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x0010B2B0 File Offset: 0x001094B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x0010B2C8 File Offset: 0x001094C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x0010B2D4 File Offset: 0x001094D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasOldSessionKey = this.HasOldSessionKey;
			if (hasOldSessionKey)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.OldSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x0010B320 File Offset: 0x00109520
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasOldSessionKey = this.HasOldSessionKey;
			if (hasOldSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.OldSessionKey);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x0010B370 File Offset: 0x00109570
		[DebuggerNonUserCode]
		public void MergeFrom(RefreshSessionKeyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasOldSessionKey = other.HasOldSessionKey;
				if (hasOldSessionKey)
				{
					this.OldSessionKey = other.OldSessionKey;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x0010B3B9 File Offset: 0x001095B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x0010B3C4 File Offset: 0x001095C4
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
					this.OldSessionKey = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001F12 RID: 7954
		private static readonly MessageParser<RefreshSessionKeyRequest> _parser = new MessageParser<RefreshSessionKeyRequest>(() => new RefreshSessionKeyRequest());

		// Token: 0x04001F13 RID: 7955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F14 RID: 7956
		public const int OldSessionKeyFieldNumber = 1;

		// Token: 0x04001F15 RID: 7957
		private static readonly ByteString OldSessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04001F16 RID: 7958
		private ByteString oldSessionKey_;
	}
}

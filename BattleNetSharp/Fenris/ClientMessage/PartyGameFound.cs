using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000256 RID: 598
	public sealed class PartyGameFound : IMessage<PartyGameFound>, IMessage, IEquatable<PartyGameFound>, IDeepCloneable<PartyGameFound>, IBufferMessage
	{
		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x000FBCE0 File Offset: 0x000F9EE0
		[DebuggerNonUserCode]
		public static MessageParser<PartyGameFound> Parser
		{
			get
			{
				return PartyGameFound._parser;
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x000FBCF8 File Offset: 0x000F9EF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[70];
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x000FBD1C File Offset: 0x000F9F1C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyGameFound.Descriptor;
			}
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x000FBD33 File Offset: 0x000F9F33
		[DebuggerNonUserCode]
		public PartyGameFound()
		{
		}

		// Token: 0x06004069 RID: 16489 RVA: 0x000FBD40 File Offset: 0x000F9F40
		[DebuggerNonUserCode]
		public PartyGameFound(PartyGameFound other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.errCode_ = other.errCode_;
			this.connectionInfo_ = ((other.connectionInfo_ != null) ? other.connectionInfo_.Clone() : null);
			this.entryKey_ = ((other.entryKey_ != null) ? other.entryKey_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x000FBDB8 File Offset: 0x000F9FB8
		[DebuggerNonUserCode]
		public PartyGameFound Clone()
		{
			return new PartyGameFound(this);
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x000FBDD0 File Offset: 0x000F9FD0
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x000FBE01 File Offset: 0x000FA001
		[DebuggerNonUserCode]
		public uint ErrCode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint errCodeDefaultValue;
				if (flag)
				{
					errCodeDefaultValue = this.errCode_;
				}
				else
				{
					errCodeDefaultValue = PartyGameFound.ErrCodeDefaultValue;
				}
				return errCodeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.errCode_ = value;
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x000FBE1C File Offset: 0x000FA01C
		[DebuggerNonUserCode]
		public bool HasErrCode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x000FBE39 File Offset: 0x000FA039
		[DebuggerNonUserCode]
		public void ClearErrCode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x000FBE4C File Offset: 0x000FA04C
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x000FBE64 File Offset: 0x000FA064
		[DebuggerNonUserCode]
		public ConnectionInfo ConnectionInfo
		{
			get
			{
				return this.connectionInfo_;
			}
			set
			{
				this.connectionInfo_ = value;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06004071 RID: 16497 RVA: 0x000FBE70 File Offset: 0x000FA070
		// (set) Token: 0x06004072 RID: 16498 RVA: 0x000FBE88 File Offset: 0x000FA088
		[DebuggerNonUserCode]
		public QueueEntryKey EntryKey
		{
			get
			{
				return this.entryKey_;
			}
			set
			{
				this.entryKey_ = value;
			}
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x000FBE94 File Offset: 0x000FA094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyGameFound);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x000FBEB4 File Offset: 0x000FA0B4
		[DebuggerNonUserCode]
		public bool Equals(PartyGameFound other)
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
					bool flag4 = this.ErrCode != other.ErrCode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ConnectionInfo, other.ConnectionInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.EntryKey, other.EntryKey);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004075 RID: 16501 RVA: 0x000FBF48 File Offset: 0x000FA148
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				num ^= this.ConnectionInfo.GetHashCode();
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				num ^= this.EntryKey.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x000FBFD4 File Offset: 0x000FA1D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x000FBFEC File Offset: 0x000FA1EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x000FBFF8 File Offset: 0x000FA1F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ErrCode);
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ConnectionInfo);
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EntryKey);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x000FC090 File Offset: 0x000FA290
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasErrCode = this.HasErrCode;
			if (hasErrCode)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ErrCode);
			}
			bool flag = this.connectionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectionInfo);
			}
			bool flag2 = this.entryKey_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntryKey);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x000FC120 File Offset: 0x000FA320
		[DebuggerNonUserCode]
		public void MergeFrom(PartyGameFound other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasErrCode = other.HasErrCode;
				if (hasErrCode)
				{
					this.ErrCode = other.ErrCode;
				}
				bool flag2 = other.connectionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.connectionInfo_ == null;
					if (flag3)
					{
						this.ConnectionInfo = new ConnectionInfo();
					}
					this.ConnectionInfo.MergeFrom(other.ConnectionInfo);
				}
				bool flag4 = other.entryKey_ != null;
				if (flag4)
				{
					bool flag5 = this.entryKey_ == null;
					if (flag5)
					{
						this.EntryKey = new QueueEntryKey();
					}
					this.EntryKey.MergeFrom(other.EntryKey);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x000FC1E8 File Offset: 0x000FA3E8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x000FC1F4 File Offset: 0x000FA3F4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.entryKey_ == null;
							if (flag)
							{
								this.EntryKey = new QueueEntryKey();
							}
							input.ReadMessage(this.EntryKey);
						}
					}
					else
					{
						bool flag2 = this.connectionInfo_ == null;
						if (flag2)
						{
							this.ConnectionInfo = new ConnectionInfo();
						}
						input.ReadMessage(this.ConnectionInfo);
					}
				}
				else
				{
					this.ErrCode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D51 RID: 7505
		private static readonly MessageParser<PartyGameFound> _parser = new MessageParser<PartyGameFound>(() => new PartyGameFound());

		// Token: 0x04001D52 RID: 7506
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D53 RID: 7507
		private int _hasBits0;

		// Token: 0x04001D54 RID: 7508
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04001D55 RID: 7509
		private static readonly uint ErrCodeDefaultValue = 0U;

		// Token: 0x04001D56 RID: 7510
		private uint errCode_;

		// Token: 0x04001D57 RID: 7511
		public const int ConnectionInfoFieldNumber = 2;

		// Token: 0x04001D58 RID: 7512
		private ConnectionInfo connectionInfo_;

		// Token: 0x04001D59 RID: 7513
		public const int EntryKeyFieldNumber = 3;

		// Token: 0x04001D5A RID: 7514
		private QueueEntryKey entryKey_;
	}
}

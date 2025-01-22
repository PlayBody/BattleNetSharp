using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000287 RID: 647
	public sealed class QueueInviteResponse : IMessage<QueueInviteResponse>, IMessage, IEquatable<QueueInviteResponse>, IDeepCloneable<QueueInviteResponse>, IBufferMessage
	{
		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x0010982C File Offset: 0x00107A2C
		[DebuggerNonUserCode]
		public static MessageParser<QueueInviteResponse> Parser
		{
			get
			{
				return QueueInviteResponse._parser;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x00109844 File Offset: 0x00107A44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[119];
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x00109868 File Offset: 0x00107A68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueueInviteResponse.Descriptor;
			}
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x0010987F File Offset: 0x00107A7F
		[DebuggerNonUserCode]
		public QueueInviteResponse()
		{
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00109894 File Offset: 0x00107A94
		[DebuggerNonUserCode]
		public QueueInviteResponse(QueueInviteResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_.Clone();
			this.accept_ = other.accept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x001098E4 File Offset: 0x00107AE4
		[DebuggerNonUserCode]
		public QueueInviteResponse Clone()
		{
			return new QueueInviteResponse(this);
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x001098FC File Offset: 0x00107AFC
		[DebuggerNonUserCode]
		public RepeatedField<uint> GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x00109914 File Offset: 0x00107B14
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x00109945 File Offset: 0x00107B45
		[DebuggerNonUserCode]
		public bool Accept
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool acceptDefaultValue;
				if (flag)
				{
					acceptDefaultValue = this.accept_;
				}
				else
				{
					acceptDefaultValue = QueueInviteResponse.AcceptDefaultValue;
				}
				return acceptDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accept_ = value;
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x00109960 File Offset: 0x00107B60
		[DebuggerNonUserCode]
		public bool HasAccept
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x0010997D File Offset: 0x00107B7D
		[DebuggerNonUserCode]
		public void ClearAccept()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00109990 File Offset: 0x00107B90
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueueInviteResponse);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x001099B0 File Offset: 0x00107BB0
		[DebuggerNonUserCode]
		public bool Equals(QueueInviteResponse other)
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
					bool flag4 = !this.gameAccountId_.Equals(other.gameAccountId_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Accept != other.Accept;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00109A24 File Offset: 0x00107C24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gameAccountId_.GetHashCode();
			bool hasAccept = this.HasAccept;
			if (hasAccept)
			{
				num ^= this.Accept.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00109A84 File Offset: 0x00107C84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00109A9C File Offset: 0x00107C9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00109AA8 File Offset: 0x00107CA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gameAccountId_.WriteTo(ref output, QueueInviteResponse._repeated_gameAccountId_codec);
			bool hasAccept = this.HasAccept;
			if (hasAccept)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Accept);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00109B08 File Offset: 0x00107D08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gameAccountId_.CalculateSize(QueueInviteResponse._repeated_gameAccountId_codec);
			bool hasAccept = this.HasAccept;
			if (hasAccept)
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

		// Token: 0x06004505 RID: 17669 RVA: 0x00109B60 File Offset: 0x00107D60
		[DebuggerNonUserCode]
		public void MergeFrom(QueueInviteResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gameAccountId_.Add(other.gameAccountId_);
				bool hasAccept = other.HasAccept;
				if (hasAccept)
				{
					this.Accept = other.Accept;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00109BBB File Offset: 0x00107DBB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00109BC8 File Offset: 0x00107DC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Accept = input.ReadBool();
					}
				}
				else
				{
					this.gameAccountId_.AddEntriesFrom(ref input, QueueInviteResponse._repeated_gameAccountId_codec);
				}
			}
		}

		// Token: 0x04001EE8 RID: 7912
		private static readonly MessageParser<QueueInviteResponse> _parser = new MessageParser<QueueInviteResponse>(() => new QueueInviteResponse());

		// Token: 0x04001EE9 RID: 7913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EEA RID: 7914
		private int _hasBits0;

		// Token: 0x04001EEB RID: 7915
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x04001EEC RID: 7916
		private static readonly FieldCodec<uint> _repeated_gameAccountId_codec = FieldCodec.ForUInt32(8U);

		// Token: 0x04001EED RID: 7917
		private readonly RepeatedField<uint> gameAccountId_ = new RepeatedField<uint>();

		// Token: 0x04001EEE RID: 7918
		public const int AcceptFieldNumber = 2;

		// Token: 0x04001EEF RID: 7919
		private static readonly bool AcceptDefaultValue = false;

		// Token: 0x04001EF0 RID: 7920
		private bool accept_;
	}
}

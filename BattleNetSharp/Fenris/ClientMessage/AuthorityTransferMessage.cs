using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A7 RID: 679
	public sealed class AuthorityTransferMessage : IMessage<AuthorityTransferMessage>, IMessage, IEquatable<AuthorityTransferMessage>, IDeepCloneable<AuthorityTransferMessage>, IBufferMessage
	{
		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x0011133C File Offset: 0x0010F53C
		[DebuggerNonUserCode]
		public static MessageParser<AuthorityTransferMessage> Parser
		{
			get
			{
				return AuthorityTransferMessage._parser;
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x00111354 File Offset: 0x0010F554
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[151];
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x0011137C File Offset: 0x0010F57C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthorityTransferMessage.Descriptor;
			}
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x00111393 File Offset: 0x0010F593
		[DebuggerNonUserCode]
		public AuthorityTransferMessage()
		{
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x001113A0 File Offset: 0x0010F5A0
		[DebuggerNonUserCode]
		public AuthorityTransferMessage(AuthorityTransferMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.gameHeartbeatTime_ = other.gameHeartbeatTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x001113FC File Offset: 0x0010F5FC
		[DebuggerNonUserCode]
		public AuthorityTransferMessage Clone()
		{
			return new AuthorityTransferMessage(this);
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x00111414 File Offset: 0x0010F614
		// (set) Token: 0x060047B5 RID: 18357 RVA: 0x0011142C File Offset: 0x0010F62C
		[DebuggerNonUserCode]
		public GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x060047B6 RID: 18358 RVA: 0x00111438 File Offset: 0x0010F638
		// (set) Token: 0x060047B7 RID: 18359 RVA: 0x00111469 File Offset: 0x0010F669
		[DebuggerNonUserCode]
		public uint GameHeartbeatTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameHeartbeatTimeDefaultValue;
				if (flag)
				{
					gameHeartbeatTimeDefaultValue = this.gameHeartbeatTime_;
				}
				else
				{
					gameHeartbeatTimeDefaultValue = AuthorityTransferMessage.GameHeartbeatTimeDefaultValue;
				}
				return gameHeartbeatTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameHeartbeatTime_ = value;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x00111484 File Offset: 0x0010F684
		[DebuggerNonUserCode]
		public bool HasGameHeartbeatTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x001114A1 File Offset: 0x0010F6A1
		[DebuggerNonUserCode]
		public void ClearGameHeartbeatTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x001114B4 File Offset: 0x0010F6B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthorityTransferMessage);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x001114D4 File Offset: 0x0010F6D4
		[DebuggerNonUserCode]
		public bool Equals(AuthorityTransferMessage other)
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
					bool flag4 = !object.Equals(this.GameHandle, other.GameHandle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameHeartbeatTime != other.GameHeartbeatTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x00111548 File Offset: 0x0010F748
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasGameHeartbeatTime = this.HasGameHeartbeatTime;
			if (hasGameHeartbeatTime)
			{
				num ^= this.GameHeartbeatTime.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x001115B4 File Offset: 0x0010F7B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x001115CC File Offset: 0x0010F7CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x001115D8 File Offset: 0x0010F7D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			bool hasGameHeartbeatTime = this.HasGameHeartbeatTime;
			if (hasGameHeartbeatTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GameHeartbeatTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0011164C File Offset: 0x0010F84C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool hasGameHeartbeatTime = this.HasGameHeartbeatTime;
			if (hasGameHeartbeatTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameHeartbeatTime);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x001116BC File Offset: 0x0010F8BC
		[DebuggerNonUserCode]
		public void MergeFrom(AuthorityTransferMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.gameHandle_ == null;
					if (flag3)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				bool hasGameHeartbeatTime = other.HasGameHeartbeatTime;
				if (hasGameHeartbeatTime)
				{
					this.GameHeartbeatTime = other.GameHeartbeatTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x00111741 File Offset: 0x0010F941
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0011174C File Offset: 0x0010F94C
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameHeartbeatTime = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.gameHandle_ == null;
					if (flag)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
			}
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly MessageParser<AuthorityTransferMessage> _parser = new MessageParser<AuthorityTransferMessage>(() => new AuthorityTransferMessage());

		// Token: 0x04001FB7 RID: 8119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB8 RID: 8120
		private int _hasBits0;

		// Token: 0x04001FB9 RID: 8121
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04001FBA RID: 8122
		private GameHandle gameHandle_;

		// Token: 0x04001FBB RID: 8123
		public const int GameHeartbeatTimeFieldNumber = 2;

		// Token: 0x04001FBC RID: 8124
		private static readonly uint GameHeartbeatTimeDefaultValue = 0U;

		// Token: 0x04001FBD RID: 8125
		private uint gameHeartbeatTime_;
	}
}

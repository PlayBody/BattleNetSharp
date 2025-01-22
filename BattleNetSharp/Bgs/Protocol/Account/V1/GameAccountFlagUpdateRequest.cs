using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000712 RID: 1810
	public sealed class GameAccountFlagUpdateRequest : IMessage<GameAccountFlagUpdateRequest>, IMessage, IEquatable<GameAccountFlagUpdateRequest>, IDeepCloneable<GameAccountFlagUpdateRequest>, IBufferMessage
	{
		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002865D8 File Offset: 0x002847D8
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountFlagUpdateRequest> Parser
		{
			get
			{
				return GameAccountFlagUpdateRequest._parser;
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x002865F0 File Offset: 0x002847F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x00286614 File Offset: 0x00284814
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountFlagUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x0028662B File Offset: 0x0028482B
		[DebuggerNonUserCode]
		public GameAccountFlagUpdateRequest()
		{
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x00286638 File Offset: 0x00284838
		[DebuggerNonUserCode]
		public GameAccountFlagUpdateRequest(GameAccountFlagUpdateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccount_ = ((other.gameAccount_ != null) ? other.gameAccount_.Clone() : null);
			this.flag_ = other.flag_;
			this.active_ = other.active_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x002866A0 File Offset: 0x002848A0
		[DebuggerNonUserCode]
		public GameAccountFlagUpdateRequest Clone()
		{
			return new GameAccountFlagUpdateRequest(this);
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x002866B8 File Offset: 0x002848B8
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x002866D0 File Offset: 0x002848D0
		[DebuggerNonUserCode]
		public GameAccountHandle GameAccount
		{
			get
			{
				return this.gameAccount_;
			}
			set
			{
				this.gameAccount_ = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x002866DC File Offset: 0x002848DC
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x0028670D File Offset: 0x0028490D
		[DebuggerNonUserCode]
		public ulong Flag
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong flagDefaultValue;
				if (flag)
				{
					flagDefaultValue = this.flag_;
				}
				else
				{
					flagDefaultValue = GameAccountFlagUpdateRequest.FlagDefaultValue;
				}
				return flagDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.flag_ = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x00286728 File Offset: 0x00284928
		[DebuggerNonUserCode]
		public bool HasFlag
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x00286745 File Offset: 0x00284945
		[DebuggerNonUserCode]
		public void ClearFlag()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x00286758 File Offset: 0x00284958
		// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x00286789 File Offset: 0x00284989
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = GameAccountFlagUpdateRequest.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.active_ = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x002867A4 File Offset: 0x002849A4
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x002867C1 File Offset: 0x002849C1
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x002867D4 File Offset: 0x002849D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountFlagUpdateRequest);
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x002867F4 File Offset: 0x002849F4
		[DebuggerNonUserCode]
		public bool Equals(GameAccountFlagUpdateRequest other)
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
					bool flag4 = !object.Equals(this.GameAccount, other.GameAccount);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Flag != other.Flag;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Active != other.Active;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x00286884 File Offset: 0x00284A84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num ^= this.GameAccount.GetHashCode();
			}
			bool hasFlag = this.HasFlag;
			if (hasFlag)
			{
				num ^= this.Flag.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x00286910 File Offset: 0x00284B10
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x00286928 File Offset: 0x00284B28
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x00286934 File Offset: 0x00284B34
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccount);
			}
			bool hasFlag = this.HasFlag;
			if (hasFlag)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Flag);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Active);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x002869C8 File Offset: 0x00284BC8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccount_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccount);
			}
			bool hasFlag = this.HasFlag;
			if (hasFlag)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Flag);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
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

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x00286A4C File Offset: 0x00284C4C
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountFlagUpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccount_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccount_ == null;
					if (flag3)
					{
						this.GameAccount = new GameAccountHandle();
					}
					this.GameAccount.MergeFrom(other.GameAccount);
				}
				bool hasFlag = other.HasFlag;
				if (hasFlag)
				{
					this.Flag = other.Flag;
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A5FA RID: 42490 RVA: 0x00286AEF File Offset: 0x00284CEF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x00286AFC File Offset: 0x00284CFC
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Active = input.ReadBool();
						}
					}
					else
					{
						this.Flag = input.ReadUInt64();
					}
				}
				else
				{
					bool flag = this.gameAccount_ == null;
					if (flag)
					{
						this.GameAccount = new GameAccountHandle();
					}
					input.ReadMessage(this.GameAccount);
				}
			}
		}

		// Token: 0x04004A94 RID: 19092
		private static readonly MessageParser<GameAccountFlagUpdateRequest> _parser = new MessageParser<GameAccountFlagUpdateRequest>(() => new GameAccountFlagUpdateRequest());

		// Token: 0x04004A95 RID: 19093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A96 RID: 19094
		private int _hasBits0;

		// Token: 0x04004A97 RID: 19095
		public const int GameAccountFieldNumber = 1;

		// Token: 0x04004A98 RID: 19096
		private GameAccountHandle gameAccount_;

		// Token: 0x04004A99 RID: 19097
		public const int FlagFieldNumber = 2;

		// Token: 0x04004A9A RID: 19098
		private static readonly ulong FlagDefaultValue = 0UL;

		// Token: 0x04004A9B RID: 19099
		private ulong flag_;

		// Token: 0x04004A9C RID: 19100
		public const int ActiveFieldNumber = 3;

		// Token: 0x04004A9D RID: 19101
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x04004A9E RID: 19102
		private bool active_;
	}
}

using System;
using System.Diagnostics;
using Fenris.Online;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000258 RID: 600
	public sealed class PartyGameQuestStateChanged : IMessage<PartyGameQuestStateChanged>, IMessage, IEquatable<PartyGameQuestStateChanged>, IDeepCloneable<PartyGameQuestStateChanged>, IBufferMessage
	{
		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x000FC8A4 File Offset: 0x000FAAA4
		[DebuggerNonUserCode]
		public static MessageParser<PartyGameQuestStateChanged> Parser
		{
			get
			{
				return PartyGameQuestStateChanged._parser;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600409A RID: 16538 RVA: 0x000FC8BC File Offset: 0x000FAABC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[72];
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x000FC8E0 File Offset: 0x000FAAE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyGameQuestStateChanged.Descriptor;
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x000FC8F7 File Offset: 0x000FAAF7
		[DebuggerNonUserCode]
		public PartyGameQuestStateChanged()
		{
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x000FC904 File Offset: 0x000FAB04
		[DebuggerNonUserCode]
		public PartyGameQuestStateChanged(PartyGameQuestStateChanged other)
			: this()
		{
			this.partyId_ = other.partyId_;
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this.gameQuestState_ = other.gameQuestState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x000FC960 File Offset: 0x000FAB60
		[DebuggerNonUserCode]
		public PartyGameQuestStateChanged Clone()
		{
			return new PartyGameQuestStateChanged(this);
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x000FC978 File Offset: 0x000FAB78
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x000FC999 File Offset: 0x000FAB99
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? PartyGameQuestStateChanged.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x000FC9B0 File Offset: 0x000FABB0
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x000FC9CB File Offset: 0x000FABCB
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x000FC9D8 File Offset: 0x000FABD8
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x000FC9F0 File Offset: 0x000FABF0
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

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x000FC9FC File Offset: 0x000FABFC
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x000FCA1D File Offset: 0x000FAC1D
		[DebuggerNonUserCode]
		public ByteString GameQuestState
		{
			get
			{
				return this.gameQuestState_ ?? PartyGameQuestStateChanged.GameQuestStateDefaultValue;
			}
			set
			{
				this.gameQuestState_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x000FCA34 File Offset: 0x000FAC34
		[DebuggerNonUserCode]
		public bool HasGameQuestState
		{
			get
			{
				return this.gameQuestState_ != null;
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x000FCA52 File Offset: 0x000FAC52
		[DebuggerNonUserCode]
		public void ClearGameQuestState()
		{
			this.gameQuestState_ = null;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x000FCA5C File Offset: 0x000FAC5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyGameQuestStateChanged);
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000FCA7C File Offset: 0x000FAC7C
		[DebuggerNonUserCode]
		public bool Equals(PartyGameQuestStateChanged other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameHandle, other.GameHandle);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameQuestState != other.GameQuestState;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000FCB0C File Offset: 0x000FAD0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool hasGameQuestState = this.HasGameQuestState;
			if (hasGameQuestState)
			{
				num ^= this.GameQuestState.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000FCB90 File Offset: 0x000FAD90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x000FCBA8 File Offset: 0x000FADA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x000FCBB4 File Offset: 0x000FADB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameHandle);
			}
			bool hasGameQuestState = this.HasGameQuestState;
			if (hasGameQuestState)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.GameQuestState);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x000FCC48 File Offset: 0x000FAE48
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool hasGameQuestState = this.HasGameQuestState;
			if (hasGameQuestState)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.GameQuestState);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x000FCCD8 File Offset: 0x000FAED8
		[DebuggerNonUserCode]
		public void MergeFrom(PartyGameQuestStateChanged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
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
				bool hasGameQuestState = other.HasGameQuestState;
				if (hasGameQuestState)
				{
					this.GameQuestState = other.GameQuestState;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x000FCD7B File Offset: 0x000FAF7B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x000FCD88 File Offset: 0x000FAF88
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GameQuestState = input.ReadBytes();
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
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001D66 RID: 7526
		private static readonly MessageParser<PartyGameQuestStateChanged> _parser = new MessageParser<PartyGameQuestStateChanged>(() => new PartyGameQuestStateChanged());

		// Token: 0x04001D67 RID: 7527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D68 RID: 7528
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001D69 RID: 7529
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001D6A RID: 7530
		private string partyId_;

		// Token: 0x04001D6B RID: 7531
		public const int GameHandleFieldNumber = 2;

		// Token: 0x04001D6C RID: 7532
		private GameHandle gameHandle_;

		// Token: 0x04001D6D RID: 7533
		public const int GameQuestStateFieldNumber = 3;

		// Token: 0x04001D6E RID: 7534
		private static readonly ByteString GameQuestStateDefaultValue = ByteString.Empty;

		// Token: 0x04001D6F RID: 7535
		private ByteString gameQuestState_;
	}
}

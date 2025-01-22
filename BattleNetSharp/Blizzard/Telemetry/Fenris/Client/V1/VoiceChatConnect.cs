using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031F RID: 799
	public sealed class VoiceChatConnect : IMessage<VoiceChatConnect>, IMessage, IEquatable<VoiceChatConnect>, IDeepCloneable<VoiceChatConnect>, IBufferMessage
	{
		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x00142C50 File Offset: 0x00140E50
		[DebuggerNonUserCode]
		public static MessageParser<VoiceChatConnect> Parser
		{
			get
			{
				return VoiceChatConnect._parser;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06005399 RID: 21401 RVA: 0x00142C68 File Offset: 0x00140E68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VoiceChatConnectReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x00142C8C File Offset: 0x00140E8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VoiceChatConnect.Descriptor;
			}
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00142CA3 File Offset: 0x00140EA3
		[DebuggerNonUserCode]
		public VoiceChatConnect()
		{
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00142CB0 File Offset: 0x00140EB0
		[DebuggerNonUserCode]
		public VoiceChatConnect(VoiceChatConnect other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameAccountId_ = other.gameAccountId_;
			this.bnetAccountId_ = other.bnetAccountId_;
			this.isConnected_ = other.isConnected_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00142D08 File Offset: 0x00140F08
		[DebuggerNonUserCode]
		public VoiceChatConnect Clone()
		{
			return new VoiceChatConnect(this);
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x00142D20 File Offset: 0x00140F20
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x00142D51 File Offset: 0x00140F51
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = VoiceChatConnect.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x00142D6C File Offset: 0x00140F6C
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00142D89 File Offset: 0x00140F89
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x00142D9C File Offset: 0x00140F9C
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x00142DCD File Offset: 0x00140FCD
		[DebuggerNonUserCode]
		public uint BnetAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint bnetAccountIdDefaultValue;
				if (flag)
				{
					bnetAccountIdDefaultValue = this.bnetAccountId_;
				}
				else
				{
					bnetAccountIdDefaultValue = VoiceChatConnect.BnetAccountIdDefaultValue;
				}
				return bnetAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.bnetAccountId_ = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x00142DE8 File Offset: 0x00140FE8
		[DebuggerNonUserCode]
		public bool HasBnetAccountId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x00142E05 File Offset: 0x00141005
		[DebuggerNonUserCode]
		public void ClearBnetAccountId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x00142E18 File Offset: 0x00141018
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x00142E49 File Offset: 0x00141049
		[DebuggerNonUserCode]
		public bool IsConnected
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isConnectedDefaultValue;
				if (flag)
				{
					isConnectedDefaultValue = this.isConnected_;
				}
				else
				{
					isConnectedDefaultValue = VoiceChatConnect.IsConnectedDefaultValue;
				}
				return isConnectedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isConnected_ = value;
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00142E64 File Offset: 0x00141064
		[DebuggerNonUserCode]
		public bool HasIsConnected
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x00142E81 File Offset: 0x00141081
		[DebuggerNonUserCode]
		public void ClearIsConnected()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00142E94 File Offset: 0x00141094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VoiceChatConnect);
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00142EB4 File Offset: 0x001410B4
		[DebuggerNonUserCode]
		public bool Equals(VoiceChatConnect other)
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
					bool flag4 = this.GameAccountId != other.GameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.BnetAccountId != other.BnetAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsConnected != other.IsConnected;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00142F40 File Offset: 0x00141140
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num ^= this.BnetAccountId.GetHashCode();
			}
			bool hasIsConnected = this.HasIsConnected;
			if (hasIsConnected)
			{
				num ^= this.IsConnected.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00142FCC File Offset: 0x001411CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x00142FE4 File Offset: 0x001411E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00142FF0 File Offset: 0x001411F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BnetAccountId);
			}
			bool hasIsConnected = this.HasIsConnected;
			if (hasIsConnected)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsConnected);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00143080 File Offset: 0x00141280
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasBnetAccountId = this.HasBnetAccountId;
			if (hasBnetAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BnetAccountId);
			}
			bool hasIsConnected = this.HasIsConnected;
			if (hasIsConnected)
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

		// Token: 0x060053B1 RID: 21425 RVA: 0x00143100 File Offset: 0x00141300
		[DebuggerNonUserCode]
		public void MergeFrom(VoiceChatConnect other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasBnetAccountId = other.HasBnetAccountId;
				if (hasBnetAccountId)
				{
					this.BnetAccountId = other.BnetAccountId;
				}
				bool hasIsConnected = other.HasIsConnected;
				if (hasIsConnected)
				{
					this.IsConnected = other.IsConnected;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0014317B File Offset: 0x0014137B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00143188 File Offset: 0x00141388
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsConnected = input.ReadBool();
						}
					}
					else
					{
						this.BnetAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040025E7 RID: 9703
		private static readonly MessageParser<VoiceChatConnect> _parser = new MessageParser<VoiceChatConnect>(() => new VoiceChatConnect());

		// Token: 0x040025E8 RID: 9704
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025E9 RID: 9705
		private int _hasBits0;

		// Token: 0x040025EA RID: 9706
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040025EB RID: 9707
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x040025EC RID: 9708
		private uint gameAccountId_;

		// Token: 0x040025ED RID: 9709
		public const int BnetAccountIdFieldNumber = 2;

		// Token: 0x040025EE RID: 9710
		private static readonly uint BnetAccountIdDefaultValue = 0U;

		// Token: 0x040025EF RID: 9711
		private uint bnetAccountId_;

		// Token: 0x040025F0 RID: 9712
		public const int IsConnectedFieldNumber = 3;

		// Token: 0x040025F1 RID: 9713
		private static readonly bool IsConnectedDefaultValue = false;

		// Token: 0x040025F2 RID: 9714
		private bool isConnected_;
	}
}

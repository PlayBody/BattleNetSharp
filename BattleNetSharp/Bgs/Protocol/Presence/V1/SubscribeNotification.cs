using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x0200059B RID: 1435
	public sealed class SubscribeNotification : IMessage<SubscribeNotification>, IMessage, IEquatable<SubscribeNotification>, IDeepCloneable<SubscribeNotification>, IBufferMessage
	{
		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x002135FC File Offset: 0x002117FC
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeNotification> Parser
		{
			get
			{
				return SubscribeNotification._parser;
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x060088CE RID: 35022 RVA: 0x00213614 File Offset: 0x00211814
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x00213638 File Offset: 0x00211838
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeNotification.Descriptor;
			}
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0021364F File Offset: 0x0021184F
		[DebuggerNonUserCode]
		public SubscribeNotification()
		{
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x00213664 File Offset: 0x00211864
		[DebuggerNonUserCode]
		public SubscribeNotification(SubscribeNotification other)
			: this()
		{
			this.subscriberId_ = ((other.subscriberId_ != null) ? other.subscriberId_.Clone() : null);
			this.state_ = other.state_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x002136B8 File Offset: 0x002118B8
		[DebuggerNonUserCode]
		public SubscribeNotification Clone()
		{
			return new SubscribeNotification(this);
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x002136D0 File Offset: 0x002118D0
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x002136E8 File Offset: 0x002118E8
		[DebuggerNonUserCode]
		public AccountId SubscriberId
		{
			get
			{
				return this.subscriberId_;
			}
			set
			{
				this.subscriberId_ = value;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x002136F4 File Offset: 0x002118F4
		[DebuggerNonUserCode]
		public RepeatedField<PresenceState> State
		{
			get
			{
				return this.state_;
			}
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x0021370C File Offset: 0x0021190C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeNotification);
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x0021372C File Offset: 0x0021192C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeNotification other)
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
					bool flag4 = !object.Equals(this.SubscriberId, other.SubscriberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.state_.Equals(other.state_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x002137A4 File Offset: 0x002119A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num ^= this.SubscriberId.GetHashCode();
			}
			num ^= this.state_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00213800 File Offset: 0x00211A00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x00213818 File Offset: 0x00211A18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00213824 File Offset: 0x00211A24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SubscriberId);
			}
			this.state_.WriteTo(ref output, SubscribeNotification._repeated_state_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00213888 File Offset: 0x00211A88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.subscriberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SubscriberId);
			}
			num += this.state_.CalculateSize(SubscribeNotification._repeated_state_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x002138EC File Offset: 0x00211AEC
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.subscriberId_ != null;
				if (flag2)
				{
					bool flag3 = this.subscriberId_ == null;
					if (flag3)
					{
						this.SubscriberId = new AccountId();
					}
					this.SubscriberId.MergeFrom(other.SubscriberId);
				}
				this.state_.Add(other.state_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0021396A File Offset: 0x00211B6A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x00213978 File Offset: 0x00211B78
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.state_.AddEntriesFrom(ref input, SubscribeNotification._repeated_state_codec);
					}
				}
				else
				{
					bool flag = this.subscriberId_ == null;
					if (flag)
					{
						this.SubscriberId = new AccountId();
					}
					input.ReadMessage(this.SubscriberId);
				}
			}
		}

		// Token: 0x04003DEB RID: 15851
		private static readonly MessageParser<SubscribeNotification> _parser = new MessageParser<SubscribeNotification>(() => new SubscribeNotification());

		// Token: 0x04003DEC RID: 15852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DED RID: 15853
		public const int SubscriberIdFieldNumber = 1;

		// Token: 0x04003DEE RID: 15854
		private AccountId subscriberId_;

		// Token: 0x04003DEF RID: 15855
		public const int StateFieldNumber = 2;

		// Token: 0x04003DF0 RID: 15856
		private static readonly FieldCodec<PresenceState> _repeated_state_codec = FieldCodec.ForMessage<PresenceState>(18U, PresenceState.Parser);

		// Token: 0x04003DF1 RID: 15857
		private readonly RepeatedField<PresenceState> state_ = new RepeatedField<PresenceState>();
	}
}

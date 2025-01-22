using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003B0 RID: 944
	public sealed class WhisperView : IMessage<WhisperView>, IMessage, IEquatable<WhisperView>, IDeepCloneable<WhisperView>, IBufferMessage
	{
		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06005F07 RID: 24327 RVA: 0x00170390 File Offset: 0x0016E590
		[DebuggerNonUserCode]
		public static MessageParser<WhisperView> Parser
		{
			get
			{
				return WhisperView._parser;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06005F08 RID: 24328 RVA: 0x001703A8 File Offset: 0x0016E5A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001703CC File Offset: 0x0016E5CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WhisperView.Descriptor;
			}
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x001703E3 File Offset: 0x0016E5E3
		[DebuggerNonUserCode]
		public WhisperView()
		{
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x001703F0 File Offset: 0x0016E5F0
		[DebuggerNonUserCode]
		public WhisperView(WhisperView other)
			: this()
		{
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.viewMarker_ = ((other.viewMarker_ != null) ? other.viewMarker_.Clone() : null);
			this.senderBattleTag_ = other.senderBattleTag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0017045C File Offset: 0x0016E65C
		[DebuggerNonUserCode]
		public WhisperView Clone()
		{
			return new WhisperView(this);
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x00170474 File Offset: 0x0016E674
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x0017048C File Offset: 0x0016E68C
		[DebuggerNonUserCode]
		public AccountId SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x00170498 File Offset: 0x0016E698
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x001704B0 File Offset: 0x0016E6B0
		[DebuggerNonUserCode]
		public ViewMarker ViewMarker
		{
			get
			{
				return this.viewMarker_;
			}
			set
			{
				this.viewMarker_ = value;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001704BC File Offset: 0x0016E6BC
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x001704DD File Offset: 0x0016E6DD
		[DebuggerNonUserCode]
		public string SenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ ?? WhisperView.SenderBattleTagDefaultValue;
			}
			set
			{
				this.senderBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x001704F4 File Offset: 0x0016E6F4
		[DebuggerNonUserCode]
		public bool HasSenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ != null;
			}
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0017050F File Offset: 0x0016E70F
		[DebuggerNonUserCode]
		public void ClearSenderBattleTag()
		{
			this.senderBattleTag_ = null;
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0017051C File Offset: 0x0016E71C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WhisperView);
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x0017053C File Offset: 0x0016E73C
		[DebuggerNonUserCode]
		public bool Equals(WhisperView other)
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
					bool flag4 = !object.Equals(this.SenderId, other.SenderId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ViewMarker, other.ViewMarker);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SenderBattleTag != other.SenderBattleTag;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x001705D0 File Offset: 0x0016E7D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num ^= this.SenderId.GetHashCode();
			}
			bool flag2 = this.viewMarker_ != null;
			if (flag2)
			{
				num ^= this.ViewMarker.GetHashCode();
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num ^= this.SenderBattleTag.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x00170654 File Offset: 0x0016E854
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0017066C File Offset: 0x0016E86C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x00170678 File Offset: 0x0016E878
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.senderId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SenderId);
			}
			bool flag2 = this.viewMarker_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ViewMarker);
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				output.WriteRawTag(26);
				output.WriteString(this.SenderBattleTag);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x00170710 File Offset: 0x0016E910
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderId);
			}
			bool flag2 = this.viewMarker_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ViewMarker);
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderBattleTag);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x001707A0 File Offset: 0x0016E9A0
		[DebuggerNonUserCode]
		public void MergeFrom(WhisperView other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.senderId_ != null;
				if (flag2)
				{
					bool flag3 = this.senderId_ == null;
					if (flag3)
					{
						this.SenderId = new AccountId();
					}
					this.SenderId.MergeFrom(other.SenderId);
				}
				bool flag4 = other.viewMarker_ != null;
				if (flag4)
				{
					bool flag5 = this.viewMarker_ == null;
					if (flag5)
					{
						this.ViewMarker = new ViewMarker();
					}
					this.ViewMarker.MergeFrom(other.ViewMarker);
				}
				bool hasSenderBattleTag = other.HasSenderBattleTag;
				if (hasSenderBattleTag)
				{
					this.SenderBattleTag = other.SenderBattleTag;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x00170868 File Offset: 0x0016EA68
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x00170874 File Offset: 0x0016EA74
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
							this.SenderBattleTag = input.ReadString();
						}
					}
					else
					{
						bool flag = this.viewMarker_ == null;
						if (flag)
						{
							this.ViewMarker = new ViewMarker();
						}
						input.ReadMessage(this.ViewMarker);
					}
				}
				else
				{
					bool flag2 = this.senderId_ == null;
					if (flag2)
					{
						this.SenderId = new AccountId();
					}
					input.ReadMessage(this.SenderId);
				}
			}
		}

		// Token: 0x04002B7B RID: 11131
		private static readonly MessageParser<WhisperView> _parser = new MessageParser<WhisperView>(() => new WhisperView());

		// Token: 0x04002B7C RID: 11132
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B7D RID: 11133
		public const int SenderIdFieldNumber = 1;

		// Token: 0x04002B7E RID: 11134
		private AccountId senderId_;

		// Token: 0x04002B7F RID: 11135
		public const int ViewMarkerFieldNumber = 2;

		// Token: 0x04002B80 RID: 11136
		private ViewMarker viewMarker_;

		// Token: 0x04002B81 RID: 11137
		public const int SenderBattleTagFieldNumber = 3;

		// Token: 0x04002B82 RID: 11138
		private static readonly string SenderBattleTagDefaultValue = "";

		// Token: 0x04002B83 RID: 11139
		private string senderBattleTag_;
	}
}

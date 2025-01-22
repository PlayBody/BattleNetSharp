using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001BB RID: 443
	public sealed class TutorialMessage : IMessage<TutorialMessage>, IMessage, IEquatable<TutorialMessage>, IDeepCloneable<TutorialMessage>, IBufferMessage
	{
		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x000B7394 File Offset: 0x000B5594
		[DebuggerNonUserCode]
		public static MessageParser<TutorialMessage> Parser
		{
			get
			{
				return TutorialMessage._parser;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x000B73AC File Offset: 0x000B55AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000B73D0 File Offset: 0x000B55D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TutorialMessage.Descriptor;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000B73E7 File Offset: 0x000B55E7
		[DebuggerNonUserCode]
		public TutorialMessage()
		{
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000B73F4 File Offset: 0x000B55F4
		[DebuggerNonUserCode]
		public TutorialMessage(TutorialMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.tutorialSno_ = other.tutorialSno_;
			this.uiAnchorName_ = other.uiAnchorName_;
			this.actorId_ = other.actorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000B744C File Offset: 0x000B564C
		[DebuggerNonUserCode]
		public TutorialMessage Clone()
		{
			return new TutorialMessage(this);
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000B7464 File Offset: 0x000B5664
		// (set) Token: 0x06002E69 RID: 11881 RVA: 0x000B7495 File Offset: 0x000B5695
		[DebuggerNonUserCode]
		public uint TutorialSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint tutorialSnoDefaultValue;
				if (flag)
				{
					tutorialSnoDefaultValue = this.tutorialSno_;
				}
				else
				{
					tutorialSnoDefaultValue = TutorialMessage.TutorialSnoDefaultValue;
				}
				return tutorialSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.tutorialSno_ = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000B74B0 File Offset: 0x000B56B0
		[DebuggerNonUserCode]
		public bool HasTutorialSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000B74CD File Offset: 0x000B56CD
		[DebuggerNonUserCode]
		public void ClearTutorialSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x000B74E0 File Offset: 0x000B56E0
		// (set) Token: 0x06002E6D RID: 11885 RVA: 0x000B7501 File Offset: 0x000B5701
		[DebuggerNonUserCode]
		public string UiAnchorName
		{
			get
			{
				return this.uiAnchorName_ ?? TutorialMessage.UiAnchorNameDefaultValue;
			}
			set
			{
				this.uiAnchorName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000B7518 File Offset: 0x000B5718
		[DebuggerNonUserCode]
		public bool HasUiAnchorName
		{
			get
			{
				return this.uiAnchorName_ != null;
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000B7533 File Offset: 0x000B5733
		[DebuggerNonUserCode]
		public void ClearUiAnchorName()
		{
			this.uiAnchorName_ = null;
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000B7540 File Offset: 0x000B5740
		// (set) Token: 0x06002E71 RID: 11889 RVA: 0x000B7571 File Offset: 0x000B5771
		[DebuggerNonUserCode]
		public int ActorId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int actorIdDefaultValue;
				if (flag)
				{
					actorIdDefaultValue = this.actorId_;
				}
				else
				{
					actorIdDefaultValue = TutorialMessage.ActorIdDefaultValue;
				}
				return actorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.actorId_ = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000B758C File Offset: 0x000B578C
		[DebuggerNonUserCode]
		public bool HasActorId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000B75A9 File Offset: 0x000B57A9
		[DebuggerNonUserCode]
		public void ClearActorId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000B75BC File Offset: 0x000B57BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TutorialMessage);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000B75DC File Offset: 0x000B57DC
		[DebuggerNonUserCode]
		public bool Equals(TutorialMessage other)
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
					bool flag4 = this.TutorialSno != other.TutorialSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UiAnchorName != other.UiAnchorName;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ActorId != other.ActorId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000B7668 File Offset: 0x000B5868
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTutorialSno = this.HasTutorialSno;
			if (hasTutorialSno)
			{
				num ^= this.TutorialSno.GetHashCode();
			}
			bool hasUiAnchorName = this.HasUiAnchorName;
			if (hasUiAnchorName)
			{
				num ^= this.UiAnchorName.GetHashCode();
			}
			bool hasActorId = this.HasActorId;
			if (hasActorId)
			{
				num ^= this.ActorId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000B76F0 File Offset: 0x000B58F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000B7708 File Offset: 0x000B5908
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000B7714 File Offset: 0x000B5914
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTutorialSno = this.HasTutorialSno;
			if (hasTutorialSno)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TutorialSno);
			}
			bool hasUiAnchorName = this.HasUiAnchorName;
			if (hasUiAnchorName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.UiAnchorName);
			}
			bool hasActorId = this.HasActorId;
			if (hasActorId)
			{
				output.WriteRawTag(24);
				output.WriteSInt32(this.ActorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000B77A4 File Offset: 0x000B59A4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTutorialSno = this.HasTutorialSno;
			if (hasTutorialSno)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TutorialSno);
			}
			bool hasUiAnchorName = this.HasUiAnchorName;
			if (hasUiAnchorName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UiAnchorName);
			}
			bool hasActorId = this.HasActorId;
			if (hasActorId)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ActorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000B7830 File Offset: 0x000B5A30
		[DebuggerNonUserCode]
		public void MergeFrom(TutorialMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTutorialSno = other.HasTutorialSno;
				if (hasTutorialSno)
				{
					this.TutorialSno = other.TutorialSno;
				}
				bool hasUiAnchorName = other.HasUiAnchorName;
				if (hasUiAnchorName)
				{
					this.UiAnchorName = other.UiAnchorName;
				}
				bool hasActorId = other.HasActorId;
				if (hasActorId)
				{
					this.ActorId = other.ActorId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000B78AB File Offset: 0x000B5AAB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000B78B8 File Offset: 0x000B5AB8
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActorId = input.ReadSInt32();
						}
					}
					else
					{
						this.UiAnchorName = input.ReadString();
					}
				}
				else
				{
					this.TutorialSno = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly MessageParser<TutorialMessage> _parser = new MessageParser<TutorialMessage>(() => new TutorialMessage());

		// Token: 0x040014F2 RID: 5362
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014F3 RID: 5363
		private int _hasBits0;

		// Token: 0x040014F4 RID: 5364
		public const int TutorialSnoFieldNumber = 1;

		// Token: 0x040014F5 RID: 5365
		private static readonly uint TutorialSnoDefaultValue = 0U;

		// Token: 0x040014F6 RID: 5366
		private uint tutorialSno_;

		// Token: 0x040014F7 RID: 5367
		public const int UiAnchorNameFieldNumber = 2;

		// Token: 0x040014F8 RID: 5368
		private static readonly string UiAnchorNameDefaultValue = "";

		// Token: 0x040014F9 RID: 5369
		private string uiAnchorName_;

		// Token: 0x040014FA RID: 5370
		public const int ActorIdFieldNumber = 3;

		// Token: 0x040014FB RID: 5371
		private static readonly int ActorIdDefaultValue = -1;

		// Token: 0x040014FC RID: 5372
		private int actorId_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006C9 RID: 1737
	public sealed class InvitationSuggestion : IMessage<InvitationSuggestion>, IMessage, IEquatable<InvitationSuggestion>, IDeepCloneable<InvitationSuggestion>, IBufferMessage
	{
		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600A05C RID: 41052 RVA: 0x00270180 File Offset: 0x0026E380
		[DebuggerNonUserCode]
		public static MessageParser<InvitationSuggestion> Parser
		{
			get
			{
				return InvitationSuggestion._parser;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x00270198 File Offset: 0x0026E398
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600A05E RID: 41054 RVA: 0x002701BC File Offset: 0x0026E3BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvitationSuggestion.Descriptor;
			}
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x002701D3 File Offset: 0x0026E3D3
		[DebuggerNonUserCode]
		public InvitationSuggestion()
		{
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x002701E0 File Offset: 0x0026E3E0
		[DebuggerNonUserCode]
		public InvitationSuggestion(InvitationSuggestion other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.suggesterId_ = ((other.suggesterId_ != null) ? other.suggesterId_.Clone() : null);
			this.suggesteeId_ = ((other.suggesteeId_ != null) ? other.suggesteeId_.Clone() : null);
			this.suggesterName_ = other.suggesterName_;
			this.suggesteeName_ = other.suggesteeName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x00270274 File Offset: 0x0026E474
		[DebuggerNonUserCode]
		public InvitationSuggestion Clone()
		{
			return new InvitationSuggestion(this);
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600A062 RID: 41058 RVA: 0x0027028C File Offset: 0x0026E48C
		// (set) Token: 0x0600A063 RID: 41059 RVA: 0x002702A4 File Offset: 0x0026E4A4
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600A064 RID: 41060 RVA: 0x002702B0 File Offset: 0x0026E4B0
		// (set) Token: 0x0600A065 RID: 41061 RVA: 0x002702C8 File Offset: 0x0026E4C8
		[DebuggerNonUserCode]
		public EntityId SuggesterId
		{
			get
			{
				return this.suggesterId_;
			}
			set
			{
				this.suggesterId_ = value;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x002702D4 File Offset: 0x0026E4D4
		// (set) Token: 0x0600A067 RID: 41063 RVA: 0x002702EC File Offset: 0x0026E4EC
		[DebuggerNonUserCode]
		public EntityId SuggesteeId
		{
			get
			{
				return this.suggesteeId_;
			}
			set
			{
				this.suggesteeId_ = value;
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x002702F8 File Offset: 0x0026E4F8
		// (set) Token: 0x0600A069 RID: 41065 RVA: 0x00270319 File Offset: 0x0026E519
		[DebuggerNonUserCode]
		public string SuggesterName
		{
			get
			{
				return this.suggesterName_ ?? InvitationSuggestion.SuggesterNameDefaultValue;
			}
			set
			{
				this.suggesterName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600A06A RID: 41066 RVA: 0x00270330 File Offset: 0x0026E530
		[DebuggerNonUserCode]
		public bool HasSuggesterName
		{
			get
			{
				return this.suggesterName_ != null;
			}
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x0027034B File Offset: 0x0026E54B
		[DebuggerNonUserCode]
		public void ClearSuggesterName()
		{
			this.suggesterName_ = null;
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x00270358 File Offset: 0x0026E558
		// (set) Token: 0x0600A06D RID: 41069 RVA: 0x00270379 File Offset: 0x0026E579
		[DebuggerNonUserCode]
		public string SuggesteeName
		{
			get
			{
				return this.suggesteeName_ ?? InvitationSuggestion.SuggesteeNameDefaultValue;
			}
			set
			{
				this.suggesteeName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A06E RID: 41070 RVA: 0x00270390 File Offset: 0x0026E590
		[DebuggerNonUserCode]
		public bool HasSuggesteeName
		{
			get
			{
				return this.suggesteeName_ != null;
			}
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x002703AB File Offset: 0x0026E5AB
		[DebuggerNonUserCode]
		public void ClearSuggesteeName()
		{
			this.suggesteeName_ = null;
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x002703B8 File Offset: 0x0026E5B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvitationSuggestion);
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x002703D8 File Offset: 0x0026E5D8
		[DebuggerNonUserCode]
		public bool Equals(InvitationSuggestion other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SuggesterId, other.SuggesterId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.SuggesteeId, other.SuggesteeId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SuggesterName != other.SuggesterName;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.SuggesteeName != other.SuggesteeName;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x002704AC File Offset: 0x0026E6AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.suggesterId_ != null;
			if (flag2)
			{
				num ^= this.SuggesterId.GetHashCode();
			}
			bool flag3 = this.suggesteeId_ != null;
			if (flag3)
			{
				num ^= this.SuggesteeId.GetHashCode();
			}
			bool hasSuggesterName = this.HasSuggesterName;
			if (hasSuggesterName)
			{
				num ^= this.SuggesterName.GetHashCode();
			}
			bool hasSuggesteeName = this.HasSuggesteeName;
			if (hasSuggesteeName)
			{
				num ^= this.SuggesteeName.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x00270568 File Offset: 0x0026E768
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x00270580 File Offset: 0x0026E780
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x0027058C File Offset: 0x0026E78C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.suggesterId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SuggesterId);
			}
			bool flag3 = this.suggesteeId_ != null;
			if (flag3)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SuggesteeId);
			}
			bool hasSuggesterName = this.HasSuggesterName;
			if (hasSuggesterName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.SuggesterName);
			}
			bool hasSuggesteeName = this.HasSuggesteeName;
			if (hasSuggesteeName)
			{
				output.WriteRawTag(42);
				output.WriteString(this.SuggesteeName);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x00270670 File Offset: 0x0026E870
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.suggesterId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SuggesterId);
			}
			bool flag3 = this.suggesteeId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SuggesteeId);
			}
			bool hasSuggesterName = this.HasSuggesterName;
			if (hasSuggesterName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SuggesterName);
			}
			bool hasSuggesteeName = this.HasSuggesteeName;
			if (hasSuggesteeName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SuggesteeName);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x00270740 File Offset: 0x0026E940
		[DebuggerNonUserCode]
		public void MergeFrom(InvitationSuggestion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.suggesterId_ != null;
				if (flag4)
				{
					bool flag5 = this.suggesterId_ == null;
					if (flag5)
					{
						this.SuggesterId = new EntityId();
					}
					this.SuggesterId.MergeFrom(other.SuggesterId);
				}
				bool flag6 = other.suggesteeId_ != null;
				if (flag6)
				{
					bool flag7 = this.suggesteeId_ == null;
					if (flag7)
					{
						this.SuggesteeId = new EntityId();
					}
					this.SuggesteeId.MergeFrom(other.SuggesteeId);
				}
				bool hasSuggesterName = other.HasSuggesterName;
				if (hasSuggesterName)
				{
					this.SuggesterName = other.SuggesterName;
				}
				bool hasSuggesteeName = other.HasSuggesteeName;
				if (hasSuggesteeName)
				{
					this.SuggesteeName = other.SuggesteeName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x00270863 File Offset: 0x0026EA63
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x00270870 File Offset: 0x0026EA70
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						bool flag = this.suggesterId_ == null;
						if (flag)
						{
							this.SuggesterId = new EntityId();
						}
						input.ReadMessage(this.SuggesterId);
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new EntityId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						if (num3 != 42U)
						{
							goto IL_003C;
						}
						this.SuggesteeName = input.ReadString();
					}
					else
					{
						this.SuggesterName = input.ReadString();
					}
				}
				else
				{
					bool flag3 = this.suggesteeId_ == null;
					if (flag3)
					{
						this.SuggesteeId = new EntityId();
					}
					input.ReadMessage(this.SuggesteeId);
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400484C RID: 18508
		private static readonly MessageParser<InvitationSuggestion> _parser = new MessageParser<InvitationSuggestion>(() => new InvitationSuggestion());

		// Token: 0x0400484D RID: 18509
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400484E RID: 18510
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x0400484F RID: 18511
		private EntityId channelId_;

		// Token: 0x04004850 RID: 18512
		public const int SuggesterIdFieldNumber = 2;

		// Token: 0x04004851 RID: 18513
		private EntityId suggesterId_;

		// Token: 0x04004852 RID: 18514
		public const int SuggesteeIdFieldNumber = 3;

		// Token: 0x04004853 RID: 18515
		private EntityId suggesteeId_;

		// Token: 0x04004854 RID: 18516
		public const int SuggesterNameFieldNumber = 4;

		// Token: 0x04004855 RID: 18517
		private static readonly string SuggesterNameDefaultValue = "";

		// Token: 0x04004856 RID: 18518
		private string suggesterName_;

		// Token: 0x04004857 RID: 18519
		public const int SuggesteeNameFieldNumber = 5;

		// Token: 0x04004858 RID: 18520
		private static readonly string SuggesteeNameDefaultValue = "";

		// Token: 0x04004859 RID: 18521
		private string suggesteeName_;
	}
}

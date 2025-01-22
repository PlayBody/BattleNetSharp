using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069A RID: 1690
	public sealed class Suggestion : IMessage<Suggestion>, IMessage, IEquatable<Suggestion>, IDeepCloneable<Suggestion>, IBufferMessage
	{
		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x00262190 File Offset: 0x00260390
		[DebuggerNonUserCode]
		public static MessageParser<Suggestion> Parser
		{
			get
			{
				return Suggestion._parser;
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06009CE9 RID: 40169 RVA: 0x002621A8 File Offset: 0x002603A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x002621CC File Offset: 0x002603CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Suggestion.Descriptor;
			}
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x002621E3 File Offset: 0x002603E3
		[DebuggerNonUserCode]
		public Suggestion()
		{
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x002621F0 File Offset: 0x002603F0
		[DebuggerNonUserCode]
		public Suggestion(Suggestion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.suggester_ = ((other.suggester_ != null) ? other.suggester_.Clone() : null);
			this.suggestee_ = ((other.suggestee_ != null) ? other.suggestee_.Clone() : null);
			this.creationTime_ = other.creationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CED RID: 40173 RVA: 0x00262284 File Offset: 0x00260484
		[DebuggerNonUserCode]
		public Suggestion Clone()
		{
			return new Suggestion(this);
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06009CEE RID: 40174 RVA: 0x0026229C File Offset: 0x0026049C
		// (set) Token: 0x06009CEF RID: 40175 RVA: 0x002622B4 File Offset: 0x002604B4
		[DebuggerNonUserCode]
		public ChannelId ChannelId
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

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x002622C0 File Offset: 0x002604C0
		// (set) Token: 0x06009CF1 RID: 40177 RVA: 0x002622D8 File Offset: 0x002604D8
		[DebuggerNonUserCode]
		public MemberDescription Suggester
		{
			get
			{
				return this.suggester_;
			}
			set
			{
				this.suggester_ = value;
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06009CF2 RID: 40178 RVA: 0x002622E4 File Offset: 0x002604E4
		// (set) Token: 0x06009CF3 RID: 40179 RVA: 0x002622FC File Offset: 0x002604FC
		[DebuggerNonUserCode]
		public MemberDescription Suggestee
		{
			get
			{
				return this.suggestee_;
			}
			set
			{
				this.suggestee_ = value;
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x00262308 File Offset: 0x00260508
		// (set) Token: 0x06009CF5 RID: 40181 RVA: 0x00262339 File Offset: 0x00260539
		[DebuggerNonUserCode]
		public ulong CreationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeDefaultValue;
				if (flag)
				{
					creationTimeDefaultValue = this.creationTime_;
				}
				else
				{
					creationTimeDefaultValue = Suggestion.CreationTimeDefaultValue;
				}
				return creationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTime_ = value;
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x00262354 File Offset: 0x00260554
		[DebuggerNonUserCode]
		public bool HasCreationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009CF7 RID: 40183 RVA: 0x00262371 File Offset: 0x00260571
		[DebuggerNonUserCode]
		public void ClearCreationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x00262384 File Offset: 0x00260584
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Suggestion);
		}

		// Token: 0x06009CF9 RID: 40185 RVA: 0x002623A4 File Offset: 0x002605A4
		[DebuggerNonUserCode]
		public bool Equals(Suggestion other)
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
						bool flag5 = !object.Equals(this.Suggester, other.Suggester);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Suggestee, other.Suggestee);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.CreationTime != other.CreationTime;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009CFA RID: 40186 RVA: 0x0026245C File Offset: 0x0026065C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag2 = this.suggester_ != null;
			if (flag2)
			{
				num ^= this.Suggester.GetHashCode();
			}
			bool flag3 = this.suggestee_ != null;
			if (flag3)
			{
				num ^= this.Suggestee.GetHashCode();
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num ^= this.CreationTime.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x00262504 File Offset: 0x00260704
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CFC RID: 40188 RVA: 0x0026251C File Offset: 0x0026071C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x00262528 File Offset: 0x00260728
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag2 = this.suggester_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Suggester);
			}
			bool flag3 = this.suggestee_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Suggestee);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.CreationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CFE RID: 40190 RVA: 0x002625E8 File Offset: 0x002607E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag2 = this.suggester_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggester);
			}
			bool flag3 = this.suggestee_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestee);
			}
			bool hasCreationTime = this.HasCreationTime;
			if (hasCreationTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CFF RID: 40191 RVA: 0x0026269C File Offset: 0x0026089C
		[DebuggerNonUserCode]
		public void MergeFrom(Suggestion other)
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
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool flag4 = other.suggester_ != null;
				if (flag4)
				{
					bool flag5 = this.suggester_ == null;
					if (flag5)
					{
						this.Suggester = new MemberDescription();
					}
					this.Suggester.MergeFrom(other.Suggester);
				}
				bool flag6 = other.suggestee_ != null;
				if (flag6)
				{
					bool flag7 = this.suggestee_ == null;
					if (flag7)
					{
						this.Suggestee = new MemberDescription();
					}
					this.Suggestee.MergeFrom(other.Suggestee);
				}
				bool hasCreationTime = other.HasCreationTime;
				if (hasCreationTime)
				{
					this.CreationTime = other.CreationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D00 RID: 40192 RVA: 0x002627A4 File Offset: 0x002609A4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x002627B0 File Offset: 0x002609B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							goto IL_002F;
						}
						bool flag = this.suggester_ == null;
						if (flag)
						{
							this.Suggester = new MemberDescription();
						}
						input.ReadMessage(this.Suggester);
					}
					else
					{
						bool flag2 = this.channelId_ == null;
						if (flag2)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 56U)
					{
						goto IL_002F;
					}
					this.CreationTime = input.ReadUInt64();
				}
				else
				{
					bool flag3 = this.suggestee_ == null;
					if (flag3)
					{
						this.Suggestee = new MemberDescription();
					}
					input.ReadMessage(this.Suggestee);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046D1 RID: 18129
		private static readonly MessageParser<Suggestion> _parser = new MessageParser<Suggestion>(() => new Suggestion());

		// Token: 0x040046D2 RID: 18130
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046D3 RID: 18131
		private int _hasBits0;

		// Token: 0x040046D4 RID: 18132
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x040046D5 RID: 18133
		private ChannelId channelId_;

		// Token: 0x040046D6 RID: 18134
		public const int SuggesterFieldNumber = 3;

		// Token: 0x040046D7 RID: 18135
		private MemberDescription suggester_;

		// Token: 0x040046D8 RID: 18136
		public const int SuggesteeFieldNumber = 4;

		// Token: 0x040046D9 RID: 18137
		private MemberDescription suggestee_;

		// Token: 0x040046DA RID: 18138
		public const int CreationTimeFieldNumber = 7;

		// Token: 0x040046DB RID: 18139
		private static readonly ulong CreationTimeDefaultValue = 0UL;

		// Token: 0x040046DC RID: 18140
		private ulong creationTime_;
	}
}

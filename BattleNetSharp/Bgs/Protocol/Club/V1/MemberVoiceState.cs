using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000461 RID: 1121
	public sealed class MemberVoiceState : IMessage<MemberVoiceState>, IMessage, IEquatable<MemberVoiceState>, IDeepCloneable<MemberVoiceState>, IBufferMessage
	{
		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06006DC0 RID: 28096 RVA: 0x001AB624 File Offset: 0x001A9824
		[DebuggerNonUserCode]
		public static MessageParser<MemberVoiceState> Parser
		{
			get
			{
				return MemberVoiceState._parser;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x001AB63C File Offset: 0x001A983C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06006DC2 RID: 28098 RVA: 0x001AB660 File Offset: 0x001A9860
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberVoiceState.Descriptor;
			}
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x001AB677 File Offset: 0x001A9877
		[DebuggerNonUserCode]
		public MemberVoiceState()
		{
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x001AB684 File Offset: 0x001A9884
		[DebuggerNonUserCode]
		public MemberVoiceState(MemberVoiceState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.streamId_ = other.streamId_;
			this.joined_ = other.joined_;
			this.microphone_ = other.microphone_;
			this.active_ = other.active_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x001AB6F4 File Offset: 0x001A98F4
		[DebuggerNonUserCode]
		public MemberVoiceState Clone()
		{
			return new MemberVoiceState(this);
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06006DC6 RID: 28102 RVA: 0x001AB70C File Offset: 0x001A990C
		// (set) Token: 0x06006DC7 RID: 28103 RVA: 0x001AB72D File Offset: 0x001A992D
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? MemberVoiceState.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06006DC8 RID: 28104 RVA: 0x001AB744 File Offset: 0x001A9944
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x001AB75F File Offset: 0x001A995F
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x001AB76C File Offset: 0x001A996C
		// (set) Token: 0x06006DCB RID: 28107 RVA: 0x001AB79D File Offset: 0x001A999D
		[DebuggerNonUserCode]
		public ulong StreamId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong streamIdDefaultValue;
				if (flag)
				{
					streamIdDefaultValue = this.streamId_;
				}
				else
				{
					streamIdDefaultValue = MemberVoiceState.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06006DCC RID: 28108 RVA: 0x001AB7B8 File Offset: 0x001A99B8
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x001AB7D5 File Offset: 0x001A99D5
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06006DCE RID: 28110 RVA: 0x001AB7E8 File Offset: 0x001A99E8
		// (set) Token: 0x06006DCF RID: 28111 RVA: 0x001AB819 File Offset: 0x001A9A19
		[DebuggerNonUserCode]
		public bool Joined
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool joinedDefaultValue;
				if (flag)
				{
					joinedDefaultValue = this.joined_;
				}
				else
				{
					joinedDefaultValue = MemberVoiceState.JoinedDefaultValue;
				}
				return joinedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.joined_ = value;
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06006DD0 RID: 28112 RVA: 0x001AB834 File Offset: 0x001A9A34
		[DebuggerNonUserCode]
		public bool HasJoined
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x001AB851 File Offset: 0x001A9A51
		[DebuggerNonUserCode]
		public void ClearJoined()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x001AB864 File Offset: 0x001A9A64
		// (set) Token: 0x06006DD3 RID: 28115 RVA: 0x001AB895 File Offset: 0x001A9A95
		[DebuggerNonUserCode]
		public VoiceMicrophoneState Microphone
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				VoiceMicrophoneState microphoneDefaultValue;
				if (flag)
				{
					microphoneDefaultValue = this.microphone_;
				}
				else
				{
					microphoneDefaultValue = MemberVoiceState.MicrophoneDefaultValue;
				}
				return microphoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.microphone_ = value;
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06006DD4 RID: 28116 RVA: 0x001AB8B0 File Offset: 0x001A9AB0
		[DebuggerNonUserCode]
		public bool HasMicrophone
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x001AB8CD File Offset: 0x001A9ACD
		[DebuggerNonUserCode]
		public void ClearMicrophone()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06006DD6 RID: 28118 RVA: 0x001AB8E0 File Offset: 0x001A9AE0
		// (set) Token: 0x06006DD7 RID: 28119 RVA: 0x001AB911 File Offset: 0x001A9B11
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = MemberVoiceState.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.active_ = value;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x06006DD8 RID: 28120 RVA: 0x001AB92C File Offset: 0x001A9B2C
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x001AB949 File Offset: 0x001A9B49
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x001AB95C File Offset: 0x001A9B5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberVoiceState);
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x001AB97C File Offset: 0x001A9B7C
		[DebuggerNonUserCode]
		public bool Equals(MemberVoiceState other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StreamId != other.StreamId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Joined != other.Joined;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Microphone != other.Microphone;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Active != other.Active;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x001ABA48 File Offset: 0x001A9C48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num ^= this.StreamId.GetHashCode();
			}
			bool hasJoined = this.HasJoined;
			if (hasJoined)
			{
				num ^= this.Joined.GetHashCode();
			}
			bool hasMicrophone = this.HasMicrophone;
			if (hasMicrophone)
			{
				num ^= this.Microphone.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x001ABB14 File Offset: 0x001A9D14
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x001ABB2C File Offset: 0x001A9D2C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x001ABB38 File Offset: 0x001A9D38
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.StreamId);
			}
			bool hasJoined = this.HasJoined;
			if (hasJoined)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Joined);
			}
			bool hasMicrophone = this.HasMicrophone;
			if (hasMicrophone)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Microphone);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Active);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x001ABC10 File Offset: 0x001A9E10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StreamId);
			}
			bool hasJoined = this.HasJoined;
			if (hasJoined)
			{
				num += 2;
			}
			bool hasMicrophone = this.HasMicrophone;
			if (hasMicrophone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Microphone);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
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

		// Token: 0x06006DE1 RID: 28129 RVA: 0x001ABCC0 File Offset: 0x001A9EC0
		[DebuggerNonUserCode]
		public void MergeFrom(MemberVoiceState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasStreamId = other.HasStreamId;
				if (hasStreamId)
				{
					this.StreamId = other.StreamId;
				}
				bool hasJoined = other.HasJoined;
				if (hasJoined)
				{
					this.Joined = other.Joined;
				}
				bool hasMicrophone = other.HasMicrophone;
				if (hasMicrophone)
				{
					this.Microphone = other.Microphone;
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x001ABD74 File Offset: 0x001A9F74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x001ABD80 File Offset: 0x001A9F80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_0033;
						}
						this.StreamId = input.ReadUInt64();
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.Active = input.ReadBool();
					}
					else
					{
						this.Microphone = (VoiceMicrophoneState)input.ReadEnum();
					}
				}
				else
				{
					this.Joined = input.ReadBool();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400327D RID: 12925
		private static readonly MessageParser<MemberVoiceState> _parser = new MessageParser<MemberVoiceState>(() => new MemberVoiceState());

		// Token: 0x0400327E RID: 12926
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400327F RID: 12927
		private int _hasBits0;

		// Token: 0x04003280 RID: 12928
		public const int IdFieldNumber = 1;

		// Token: 0x04003281 RID: 12929
		private static readonly string IdDefaultValue = "";

		// Token: 0x04003282 RID: 12930
		private string id_;

		// Token: 0x04003283 RID: 12931
		public const int StreamIdFieldNumber = 2;

		// Token: 0x04003284 RID: 12932
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003285 RID: 12933
		private ulong streamId_;

		// Token: 0x04003286 RID: 12934
		public const int JoinedFieldNumber = 3;

		// Token: 0x04003287 RID: 12935
		private static readonly bool JoinedDefaultValue = false;

		// Token: 0x04003288 RID: 12936
		private bool joined_;

		// Token: 0x04003289 RID: 12937
		public const int MicrophoneFieldNumber = 4;

		// Token: 0x0400328A RID: 12938
		private static readonly VoiceMicrophoneState MicrophoneDefaultValue = VoiceMicrophoneState.MicrophoneStateNormal;

		// Token: 0x0400328B RID: 12939
		private VoiceMicrophoneState microphone_;

		// Token: 0x0400328C RID: 12940
		public const int ActiveFieldNumber = 5;

		// Token: 0x0400328D RID: 12941
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x0400328E RID: 12942
		private bool active_;
	}
}

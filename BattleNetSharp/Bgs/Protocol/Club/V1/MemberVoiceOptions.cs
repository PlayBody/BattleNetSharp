using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000460 RID: 1120
	public sealed class MemberVoiceOptions : IMessage<MemberVoiceOptions>, IMessage, IEquatable<MemberVoiceOptions>, IDeepCloneable<MemberVoiceOptions>, IBufferMessage
	{
		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x001AAEFC File Offset: 0x001A90FC
		[DebuggerNonUserCode]
		public static MessageParser<MemberVoiceOptions> Parser
		{
			get
			{
				return MemberVoiceOptions._parser;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x06006DA0 RID: 28064 RVA: 0x001AAF14 File Offset: 0x001A9114
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06006DA1 RID: 28065 RVA: 0x001AAF38 File Offset: 0x001A9138
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberVoiceOptions.Descriptor;
			}
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001AAF4F File Offset: 0x001A914F
		[DebuggerNonUserCode]
		public MemberVoiceOptions()
		{
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x001AAF5C File Offset: 0x001A915C
		[DebuggerNonUserCode]
		public MemberVoiceOptions(MemberVoiceOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.streamId_ = other.streamId_;
			this.joined_ = other.joined_;
			this.microphone_ = other.microphone_;
			this.active_ = other.active_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x001AAFC0 File Offset: 0x001A91C0
		[DebuggerNonUserCode]
		public MemberVoiceOptions Clone()
		{
			return new MemberVoiceOptions(this);
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x001AAFD8 File Offset: 0x001A91D8
		// (set) Token: 0x06006DA6 RID: 28070 RVA: 0x001AB009 File Offset: 0x001A9209
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
					streamIdDefaultValue = MemberVoiceOptions.StreamIdDefaultValue;
				}
				return streamIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.streamId_ = value;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x001AB024 File Offset: 0x001A9224
		[DebuggerNonUserCode]
		public bool HasStreamId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x001AB041 File Offset: 0x001A9241
		[DebuggerNonUserCode]
		public void ClearStreamId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x001AB054 File Offset: 0x001A9254
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x001AB085 File Offset: 0x001A9285
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
					joinedDefaultValue = MemberVoiceOptions.JoinedDefaultValue;
				}
				return joinedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.joined_ = value;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x001AB0A0 File Offset: 0x001A92A0
		[DebuggerNonUserCode]
		public bool HasJoined
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x001AB0BD File Offset: 0x001A92BD
		[DebuggerNonUserCode]
		public void ClearJoined()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x001AB0D0 File Offset: 0x001A92D0
		// (set) Token: 0x06006DAE RID: 28078 RVA: 0x001AB101 File Offset: 0x001A9301
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
					microphoneDefaultValue = MemberVoiceOptions.MicrophoneDefaultValue;
				}
				return microphoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.microphone_ = value;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x06006DAF RID: 28079 RVA: 0x001AB11C File Offset: 0x001A931C
		[DebuggerNonUserCode]
		public bool HasMicrophone
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x001AB139 File Offset: 0x001A9339
		[DebuggerNonUserCode]
		public void ClearMicrophone()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x06006DB1 RID: 28081 RVA: 0x001AB14C File Offset: 0x001A934C
		// (set) Token: 0x06006DB2 RID: 28082 RVA: 0x001AB17D File Offset: 0x001A937D
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
					activeDefaultValue = MemberVoiceOptions.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.active_ = value;
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x001AB198 File Offset: 0x001A9398
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x001AB1B5 File Offset: 0x001A93B5
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x001AB1C8 File Offset: 0x001A93C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberVoiceOptions);
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x001AB1E8 File Offset: 0x001A93E8
		[DebuggerNonUserCode]
		public bool Equals(MemberVoiceOptions other)
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
					bool flag4 = this.StreamId != other.StreamId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Joined != other.Joined;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Microphone != other.Microphone;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Active != other.Active;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x001AB294 File Offset: 0x001A9494
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06006DB8 RID: 28088 RVA: 0x001AB344 File Offset: 0x001A9544
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x001AB35C File Offset: 0x001A955C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x001AB368 File Offset: 0x001A9568
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStreamId = this.HasStreamId;
			if (hasStreamId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.StreamId);
			}
			bool hasJoined = this.HasJoined;
			if (hasJoined)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Joined);
			}
			bool hasMicrophone = this.HasMicrophone;
			if (hasMicrophone)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Microphone);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Active);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x001AB41C File Offset: 0x001A961C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06006DBC RID: 28092 RVA: 0x001AB4AC File Offset: 0x001A96AC
		[DebuggerNonUserCode]
		public void MergeFrom(MemberVoiceOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
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

		// Token: 0x06006DBD RID: 28093 RVA: 0x001AB542 File Offset: 0x001A9742
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x001AB550 File Offset: 0x001A9750
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
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.Joined = input.ReadBool();
					}
					else
					{
						this.StreamId = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.Active = input.ReadBool();
				}
				else
				{
					this.Microphone = (VoiceMicrophoneState)input.ReadEnum();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400326E RID: 12910
		private static readonly MessageParser<MemberVoiceOptions> _parser = new MessageParser<MemberVoiceOptions>(() => new MemberVoiceOptions());

		// Token: 0x0400326F RID: 12911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003270 RID: 12912
		private int _hasBits0;

		// Token: 0x04003271 RID: 12913
		public const int StreamIdFieldNumber = 1;

		// Token: 0x04003272 RID: 12914
		private static readonly ulong StreamIdDefaultValue = 0UL;

		// Token: 0x04003273 RID: 12915
		private ulong streamId_;

		// Token: 0x04003274 RID: 12916
		public const int JoinedFieldNumber = 2;

		// Token: 0x04003275 RID: 12917
		private static readonly bool JoinedDefaultValue = false;

		// Token: 0x04003276 RID: 12918
		private bool joined_;

		// Token: 0x04003277 RID: 12919
		public const int MicrophoneFieldNumber = 3;

		// Token: 0x04003278 RID: 12920
		private static readonly VoiceMicrophoneState MicrophoneDefaultValue = VoiceMicrophoneState.MicrophoneStateNormal;

		// Token: 0x04003279 RID: 12921
		private VoiceMicrophoneState microphone_;

		// Token: 0x0400327A RID: 12922
		public const int ActiveFieldNumber = 4;

		// Token: 0x0400327B RID: 12923
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x0400327C RID: 12924
		private bool active_;
	}
}

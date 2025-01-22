using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000319 RID: 793
	public sealed class StoreSessionInfo : IMessage<StoreSessionInfo>, IMessage, IEquatable<StoreSessionInfo>, IDeepCloneable<StoreSessionInfo>, IBufferMessage
	{
		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x00141318 File Offset: 0x0013F518
		[DebuggerNonUserCode]
		public static MessageParser<StoreSessionInfo> Parser
		{
			get
			{
				return StoreSessionInfo._parser;
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x00141330 File Offset: 0x0013F530
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreSessionInfoReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x00141354 File Offset: 0x0013F554
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreSessionInfo.Descriptor;
			}
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x0014136B File Offset: 0x0013F56B
		[DebuggerNonUserCode]
		public StoreSessionInfo()
		{
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00141380 File Offset: 0x0013F580
		[DebuggerNonUserCode]
		public StoreSessionInfo(StoreSessionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.storeSessionGuid_ = other.storeSessionGuid_;
			this.gameSessionId_ = other.gameSessionId_;
			this.sessionDuration_ = other.sessionDuration_;
			this.testingGroup_ = other.testingGroup_;
			this.experiments_ = other.experiments_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x001413F4 File Offset: 0x0013F5F4
		[DebuggerNonUserCode]
		public StoreSessionInfo Clone()
		{
			return new StoreSessionInfo(this);
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x0014140C File Offset: 0x0013F60C
		// (set) Token: 0x06005338 RID: 21304 RVA: 0x0014142D File Offset: 0x0013F62D
		[DebuggerNonUserCode]
		public string StoreSessionGuid
		{
			get
			{
				return this.storeSessionGuid_ ?? StoreSessionInfo.StoreSessionGuidDefaultValue;
			}
			set
			{
				this.storeSessionGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x00141444 File Offset: 0x0013F644
		[DebuggerNonUserCode]
		public bool HasStoreSessionGuid
		{
			get
			{
				return this.storeSessionGuid_ != null;
			}
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x0014145F File Offset: 0x0013F65F
		[DebuggerNonUserCode]
		public void ClearStoreSessionGuid()
		{
			this.storeSessionGuid_ = null;
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x0014146C File Offset: 0x0013F66C
		// (set) Token: 0x0600533C RID: 21308 RVA: 0x0014148D File Offset: 0x0013F68D
		[DebuggerNonUserCode]
		public string GameSessionId
		{
			get
			{
				return this.gameSessionId_ ?? StoreSessionInfo.GameSessionIdDefaultValue;
			}
			set
			{
				this.gameSessionId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x001414A4 File Offset: 0x0013F6A4
		[DebuggerNonUserCode]
		public bool HasGameSessionId
		{
			get
			{
				return this.gameSessionId_ != null;
			}
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x001414BF File Offset: 0x0013F6BF
		[DebuggerNonUserCode]
		public void ClearGameSessionId()
		{
			this.gameSessionId_ = null;
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x0600533F RID: 21311 RVA: 0x001414CC File Offset: 0x0013F6CC
		// (set) Token: 0x06005340 RID: 21312 RVA: 0x001414FD File Offset: 0x0013F6FD
		[DebuggerNonUserCode]
		public uint SessionDuration
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint sessionDurationDefaultValue;
				if (flag)
				{
					sessionDurationDefaultValue = this.sessionDuration_;
				}
				else
				{
					sessionDurationDefaultValue = StoreSessionInfo.SessionDurationDefaultValue;
				}
				return sessionDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sessionDuration_ = value;
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06005341 RID: 21313 RVA: 0x00141518 File Offset: 0x0013F718
		[DebuggerNonUserCode]
		public bool HasSessionDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00141535 File Offset: 0x0013F735
		[DebuggerNonUserCode]
		public void ClearSessionDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x00141548 File Offset: 0x0013F748
		// (set) Token: 0x06005344 RID: 21316 RVA: 0x00141579 File Offset: 0x0013F779
		[DebuggerNonUserCode]
		public uint TestingGroup
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint testingGroupDefaultValue;
				if (flag)
				{
					testingGroupDefaultValue = this.testingGroup_;
				}
				else
				{
					testingGroupDefaultValue = StoreSessionInfo.TestingGroupDefaultValue;
				}
				return testingGroupDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.testingGroup_ = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x00141594 File Offset: 0x0013F794
		[DebuggerNonUserCode]
		public bool HasTestingGroup
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x001415B1 File Offset: 0x0013F7B1
		[DebuggerNonUserCode]
		public void ClearTestingGroup()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x001415C4 File Offset: 0x0013F7C4
		[DebuggerNonUserCode]
		public RepeatedField<StoreTestingInfo> Experiments
		{
			get
			{
				return this.experiments_;
			}
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x001415DC File Offset: 0x0013F7DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreSessionInfo);
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x001415FC File Offset: 0x0013F7FC
		[DebuggerNonUserCode]
		public bool Equals(StoreSessionInfo other)
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
					bool flag4 = this.StoreSessionGuid != other.StoreSessionGuid;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.GameSessionId != other.GameSessionId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionDuration != other.SessionDuration;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.TestingGroup != other.TestingGroup;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !this.experiments_.Equals(other.experiments_);
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x001416CC File Offset: 0x0013F8CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasStoreSessionGuid = this.HasStoreSessionGuid;
			if (hasStoreSessionGuid)
			{
				num ^= this.StoreSessionGuid.GetHashCode();
			}
			bool hasGameSessionId = this.HasGameSessionId;
			if (hasGameSessionId)
			{
				num ^= this.GameSessionId.GetHashCode();
			}
			bool hasSessionDuration = this.HasSessionDuration;
			if (hasSessionDuration)
			{
				num ^= this.SessionDuration.GetHashCode();
			}
			bool hasTestingGroup = this.HasTestingGroup;
			if (hasTestingGroup)
			{
				num ^= this.TestingGroup.GetHashCode();
			}
			num ^= this.experiments_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x0014177C File Offset: 0x0013F97C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00141794 File Offset: 0x0013F994
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x001417A0 File Offset: 0x0013F9A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasStoreSessionGuid = this.HasStoreSessionGuid;
			if (hasStoreSessionGuid)
			{
				output.WriteRawTag(10);
				output.WriteString(this.StoreSessionGuid);
			}
			bool hasGameSessionId = this.HasGameSessionId;
			if (hasGameSessionId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.GameSessionId);
			}
			bool hasSessionDuration = this.HasSessionDuration;
			if (hasSessionDuration)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.SessionDuration);
			}
			bool hasTestingGroup = this.HasTestingGroup;
			if (hasTestingGroup)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.TestingGroup);
			}
			this.experiments_.WriteTo(ref output, StoreSessionInfo._repeated_experiments_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00141868 File Offset: 0x0013FA68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasStoreSessionGuid = this.HasStoreSessionGuid;
			if (hasStoreSessionGuid)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StoreSessionGuid);
			}
			bool hasGameSessionId = this.HasGameSessionId;
			if (hasGameSessionId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameSessionId);
			}
			bool hasSessionDuration = this.HasSessionDuration;
			if (hasSessionDuration)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SessionDuration);
			}
			bool hasTestingGroup = this.HasTestingGroup;
			if (hasTestingGroup)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TestingGroup);
			}
			num += this.experiments_.CalculateSize(StoreSessionInfo._repeated_experiments_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x00141924 File Offset: 0x0013FB24
		[DebuggerNonUserCode]
		public void MergeFrom(StoreSessionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasStoreSessionGuid = other.HasStoreSessionGuid;
				if (hasStoreSessionGuid)
				{
					this.StoreSessionGuid = other.StoreSessionGuid;
				}
				bool hasGameSessionId = other.HasGameSessionId;
				if (hasGameSessionId)
				{
					this.GameSessionId = other.GameSessionId;
				}
				bool hasSessionDuration = other.HasSessionDuration;
				if (hasSessionDuration)
				{
					this.SessionDuration = other.SessionDuration;
				}
				bool hasTestingGroup = other.HasTestingGroup;
				if (hasTestingGroup)
				{
					this.TestingGroup = other.TestingGroup;
				}
				this.experiments_.Add(other.experiments_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x001419CF File Offset: 0x0013FBCF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x001419DC File Offset: 0x0013FBDC
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
							goto IL_0033;
						}
						this.GameSessionId = input.ReadString();
					}
					else
					{
						this.StoreSessionGuid = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						if (num3 != 42U)
						{
							goto IL_0033;
						}
						this.experiments_.AddEntriesFrom(ref input, StoreSessionInfo._repeated_experiments_codec);
					}
					else
					{
						this.TestingGroup = input.ReadUInt32();
					}
				}
				else
				{
					this.SessionDuration = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025B4 RID: 9652
		private static readonly MessageParser<StoreSessionInfo> _parser = new MessageParser<StoreSessionInfo>(() => new StoreSessionInfo());

		// Token: 0x040025B5 RID: 9653
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025B6 RID: 9654
		private int _hasBits0;

		// Token: 0x040025B7 RID: 9655
		public const int StoreSessionGuidFieldNumber = 1;

		// Token: 0x040025B8 RID: 9656
		private static readonly string StoreSessionGuidDefaultValue = "";

		// Token: 0x040025B9 RID: 9657
		private string storeSessionGuid_;

		// Token: 0x040025BA RID: 9658
		public const int GameSessionIdFieldNumber = 2;

		// Token: 0x040025BB RID: 9659
		private static readonly string GameSessionIdDefaultValue = "";

		// Token: 0x040025BC RID: 9660
		private string gameSessionId_;

		// Token: 0x040025BD RID: 9661
		public const int SessionDurationFieldNumber = 3;

		// Token: 0x040025BE RID: 9662
		private static readonly uint SessionDurationDefaultValue = 0U;

		// Token: 0x040025BF RID: 9663
		private uint sessionDuration_;

		// Token: 0x040025C0 RID: 9664
		public const int TestingGroupFieldNumber = 4;

		// Token: 0x040025C1 RID: 9665
		private static readonly uint TestingGroupDefaultValue = 0U;

		// Token: 0x040025C2 RID: 9666
		private uint testingGroup_;

		// Token: 0x040025C3 RID: 9667
		public const int ExperimentsFieldNumber = 5;

		// Token: 0x040025C4 RID: 9668
		private static readonly FieldCodec<StoreTestingInfo> _repeated_experiments_codec = FieldCodec.ForMessage<StoreTestingInfo>(42U, StoreTestingInfo.Parser);

		// Token: 0x040025C5 RID: 9669
		private readonly RepeatedField<StoreTestingInfo> experiments_ = new RepeatedField<StoreTestingInfo>();
	}
}

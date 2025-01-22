using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D2 RID: 722
	public sealed class Digest : IMessage<Digest>, IMessage, IEquatable<Digest>, IDeepCloneable<Digest>, IBufferMessage
	{
		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x00124248 File Offset: 0x00122448
		[DebuggerNonUserCode]
		public static MessageParser<Digest> Parser
		{
			get
			{
				return Digest._parser;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x00124260 File Offset: 0x00122460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x00124284 File Offset: 0x00122484
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Digest.Descriptor;
			}
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x0012429B File Offset: 0x0012249B
		[DebuggerNonUserCode]
		public Digest()
		{
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001242A8 File Offset: 0x001224A8
		[DebuggerNonUserCode]
		public Digest(Digest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.lastPlayedHeroId_ = other.lastPlayedHeroId_;
			this.flags_ = other.flags_;
			this.seasonId_ = other.seasonId_;
			this.emblem_ = other.emblem_;
			this.secondsPlayed_ = other.secondsPlayed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00124324 File Offset: 0x00122524
		[DebuggerNonUserCode]
		public Digest Clone()
		{
			return new Digest(this);
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x0012433C File Offset: 0x0012253C
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x0012436D File Offset: 0x0012256D
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = Digest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x00124388 File Offset: 0x00122588
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x001243A5 File Offset: 0x001225A5
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x001243B8 File Offset: 0x001225B8
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x001243D9 File Offset: 0x001225D9
		[DebuggerNonUserCode]
		public ByteString LastPlayedHeroId
		{
			get
			{
				return this.lastPlayedHeroId_ ?? Digest.LastPlayedHeroIdDefaultValue;
			}
			set
			{
				this.lastPlayedHeroId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x001243F0 File Offset: 0x001225F0
		[DebuggerNonUserCode]
		public bool HasLastPlayedHeroId
		{
			get
			{
				return this.lastPlayedHeroId_ != null;
			}
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x0012440E File Offset: 0x0012260E
		[DebuggerNonUserCode]
		public void ClearLastPlayedHeroId()
		{
			this.lastPlayedHeroId_ = null;
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x00124418 File Offset: 0x00122618
		// (set) Token: 0x06004C63 RID: 19555 RVA: 0x00124449 File Offset: 0x00122649
		[DebuggerNonUserCode]
		public uint Flags
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint flagsDefaultValue;
				if (flag)
				{
					flagsDefaultValue = this.flags_;
				}
				else
				{
					flagsDefaultValue = Digest.FlagsDefaultValue;
				}
				return flagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.flags_ = value;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x00124464 File Offset: 0x00122664
		[DebuggerNonUserCode]
		public bool HasFlags
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00124481 File Offset: 0x00122681
		[DebuggerNonUserCode]
		public void ClearFlags()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x00124494 File Offset: 0x00122694
		// (set) Token: 0x06004C67 RID: 19559 RVA: 0x001244C5 File Offset: 0x001226C5
		[DebuggerNonUserCode]
		public uint SeasonId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint seasonIdDefaultValue;
				if (flag)
				{
					seasonIdDefaultValue = this.seasonId_;
				}
				else
				{
					seasonIdDefaultValue = Digest.SeasonIdDefaultValue;
				}
				return seasonIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.seasonId_ = value;
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x001244E0 File Offset: 0x001226E0
		[DebuggerNonUserCode]
		public bool HasSeasonId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001244FD File Offset: 0x001226FD
		[DebuggerNonUserCode]
		public void ClearSeasonId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06004C6A RID: 19562 RVA: 0x00124510 File Offset: 0x00122710
		// (set) Token: 0x06004C6B RID: 19563 RVA: 0x00124541 File Offset: 0x00122741
		[DebuggerNonUserCode]
		public int Emblem
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int emblemDefaultValue;
				if (flag)
				{
					emblemDefaultValue = this.emblem_;
				}
				else
				{
					emblemDefaultValue = Digest.EmblemDefaultValue;
				}
				return emblemDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.emblem_ = value;
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x0012455C File Offset: 0x0012275C
		[DebuggerNonUserCode]
		public bool HasEmblem
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00124579 File Offset: 0x00122779
		[DebuggerNonUserCode]
		public void ClearEmblem()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x0012458C File Offset: 0x0012278C
		// (set) Token: 0x06004C6F RID: 19567 RVA: 0x001245BE File Offset: 0x001227BE
		[DebuggerNonUserCode]
		public uint SecondsPlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				uint secondsPlayedDefaultValue;
				if (flag)
				{
					secondsPlayedDefaultValue = this.secondsPlayed_;
				}
				else
				{
					secondsPlayedDefaultValue = Digest.SecondsPlayedDefaultValue;
				}
				return secondsPlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.secondsPlayed_ = value;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x001245D8 File Offset: 0x001227D8
		[DebuggerNonUserCode]
		public bool HasSecondsPlayed
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x001245F6 File Offset: 0x001227F6
		[DebuggerNonUserCode]
		public void ClearSecondsPlayed()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00124608 File Offset: 0x00122808
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Digest);
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00124628 File Offset: 0x00122828
		[DebuggerNonUserCode]
		public bool Equals(Digest other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LastPlayedHeroId != other.LastPlayedHeroId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Flags != other.Flags;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SeasonId != other.SeasonId;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Emblem != other.Emblem;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.SecondsPlayed != other.SecondsPlayed;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00124714 File Offset: 0x00122914
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool hasLastPlayedHeroId = this.HasLastPlayedHeroId;
			if (hasLastPlayedHeroId)
			{
				num ^= this.LastPlayedHeroId.GetHashCode();
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num ^= this.Flags.GetHashCode();
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			bool hasEmblem = this.HasEmblem;
			if (hasEmblem)
			{
				num ^= this.Emblem.GetHashCode();
			}
			bool hasSecondsPlayed = this.HasSecondsPlayed;
			if (hasSecondsPlayed)
			{
				num ^= this.SecondsPlayed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x001247F4 File Offset: 0x001229F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x0012480C File Offset: 0x00122A0C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00124818 File Offset: 0x00122A18
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			bool hasLastPlayedHeroId = this.HasLastPlayedHeroId;
			if (hasLastPlayedHeroId)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.LastPlayedHeroId);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Flags);
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SeasonId);
			}
			bool hasEmblem = this.HasEmblem;
			if (hasEmblem)
			{
				output.WriteRawTag(53);
				output.WriteSFixed32(this.Emblem);
			}
			bool hasSecondsPlayed = this.HasSecondsPlayed;
			if (hasSecondsPlayed)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.SecondsPlayed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00124914 File Offset: 0x00122B14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool hasLastPlayedHeroId = this.HasLastPlayedHeroId;
			if (hasLastPlayedHeroId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.LastPlayedHeroId);
			}
			bool hasFlags = this.HasFlags;
			if (hasFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
			}
			bool hasSeasonId = this.HasSeasonId;
			if (hasSeasonId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SeasonId);
			}
			bool hasEmblem = this.HasEmblem;
			if (hasEmblem)
			{
				num += 5;
			}
			bool hasSecondsPlayed = this.HasSecondsPlayed;
			if (hasSecondsPlayed)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SecondsPlayed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x001249EC File Offset: 0x00122BEC
		[DebuggerNonUserCode]
		public void MergeFrom(Digest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool hasLastPlayedHeroId = other.HasLastPlayedHeroId;
				if (hasLastPlayedHeroId)
				{
					this.LastPlayedHeroId = other.LastPlayedHeroId;
				}
				bool hasFlags = other.HasFlags;
				if (hasFlags)
				{
					this.Flags = other.Flags;
				}
				bool hasSeasonId = other.HasSeasonId;
				if (hasSeasonId)
				{
					this.SeasonId = other.SeasonId;
				}
				bool hasEmblem = other.HasEmblem;
				if (hasEmblem)
				{
					this.Emblem = other.Emblem;
				}
				bool hasSecondsPlayed = other.HasSecondsPlayed;
				if (hasSecondsPlayed)
				{
					this.SecondsPlayed = other.SecondsPlayed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00124ABB File Offset: 0x00122CBB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00124AC8 File Offset: 0x00122CC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0039;
							}
							this.Flags = input.ReadUInt32();
						}
						else
						{
							this.LastPlayedHeroId = input.ReadBytes();
						}
					}
					else
					{
						this.Version = input.ReadUInt32();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 53U)
					{
						if (num3 != 56U)
						{
							goto IL_0039;
						}
						this.SecondsPlayed = input.ReadUInt32();
					}
					else
					{
						this.Emblem = input.ReadSFixed32();
					}
				}
				else
				{
					this.SeasonId = input.ReadUInt32();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400220B RID: 8715
		private static readonly MessageParser<Digest> _parser = new MessageParser<Digest>(() => new Digest());

		// Token: 0x0400220C RID: 8716
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400220D RID: 8717
		private int _hasBits0;

		// Token: 0x0400220E RID: 8718
		public const int VersionFieldNumber = 1;

		// Token: 0x0400220F RID: 8719
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04002210 RID: 8720
		private uint version_;

		// Token: 0x04002211 RID: 8721
		public const int LastPlayedHeroIdFieldNumber = 2;

		// Token: 0x04002212 RID: 8722
		private static readonly ByteString LastPlayedHeroIdDefaultValue = ByteString.Empty;

		// Token: 0x04002213 RID: 8723
		private ByteString lastPlayedHeroId_;

		// Token: 0x04002214 RID: 8724
		public const int FlagsFieldNumber = 3;

		// Token: 0x04002215 RID: 8725
		private static readonly uint FlagsDefaultValue = 0U;

		// Token: 0x04002216 RID: 8726
		private uint flags_;

		// Token: 0x04002217 RID: 8727
		public const int SeasonIdFieldNumber = 4;

		// Token: 0x04002218 RID: 8728
		private static readonly uint SeasonIdDefaultValue = 0U;

		// Token: 0x04002219 RID: 8729
		private uint seasonId_;

		// Token: 0x0400221A RID: 8730
		public const int EmblemFieldNumber = 6;

		// Token: 0x0400221B RID: 8731
		private static readonly int EmblemDefaultValue = -1;

		// Token: 0x0400221C RID: 8732
		private int emblem_;

		// Token: 0x0400221D RID: 8733
		public const int SecondsPlayedFieldNumber = 7;

		// Token: 0x0400221E RID: 8734
		private static readonly uint SecondsPlayedDefaultValue = 0U;

		// Token: 0x0400221F RID: 8735
		private uint secondsPlayed_;
	}
}

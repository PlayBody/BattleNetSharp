using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.UserManager.V1
{
	// Token: 0x020003C1 RID: 961
	public sealed class RecentPlayer : IMessage<RecentPlayer>, IMessage, IEquatable<RecentPlayer>, IDeepCloneable<RecentPlayer>, IBufferMessage
	{
		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06006038 RID: 24632 RVA: 0x00175044 File Offset: 0x00173244
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayer> Parser
		{
			get
			{
				return RecentPlayer._parser;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x0017505C File Offset: 0x0017325C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UserManagerTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600603A RID: 24634 RVA: 0x00175080 File Offset: 0x00173280
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayer.Descriptor;
			}
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00175097 File Offset: 0x00173297
		[DebuggerNonUserCode]
		public RecentPlayer()
		{
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x001750AC File Offset: 0x001732AC
		[DebuggerNonUserCode]
		public RecentPlayer(RecentPlayer other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.program_ = other.program_;
			this.timestampPlayed_ = other.timestampPlayed_;
			this.attributes_ = other.attributes_.Clone();
			this.id_ = other.id_;
			this.counter_ = other.counter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x0017513C File Offset: 0x0017333C
		[DebuggerNonUserCode]
		public RecentPlayer Clone()
		{
			return new RecentPlayer(this);
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600603E RID: 24638 RVA: 0x00175154 File Offset: 0x00173354
		// (set) Token: 0x0600603F RID: 24639 RVA: 0x0017516C File Offset: 0x0017336C
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x00175178 File Offset: 0x00173378
		// (set) Token: 0x06006041 RID: 24641 RVA: 0x00175199 File Offset: 0x00173399
		[DebuggerNonUserCode]
		public string Program
		{
			get
			{
				return this.program_ ?? RecentPlayer.ProgramDefaultValue;
			}
			set
			{
				this.program_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06006042 RID: 24642 RVA: 0x001751B0 File Offset: 0x001733B0
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return this.program_ != null;
			}
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x001751CB File Offset: 0x001733CB
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this.program_ = null;
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x001751D8 File Offset: 0x001733D8
		// (set) Token: 0x06006045 RID: 24645 RVA: 0x00175209 File Offset: 0x00173409
		[DebuggerNonUserCode]
		public ulong TimestampPlayed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong timestampPlayedDefaultValue;
				if (flag)
				{
					timestampPlayedDefaultValue = this.timestampPlayed_;
				}
				else
				{
					timestampPlayedDefaultValue = RecentPlayer.TimestampPlayedDefaultValue;
				}
				return timestampPlayedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.timestampPlayed_ = value;
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06006046 RID: 24646 RVA: 0x00175224 File Offset: 0x00173424
		[DebuggerNonUserCode]
		public bool HasTimestampPlayed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00175241 File Offset: 0x00173441
		[DebuggerNonUserCode]
		public void ClearTimestampPlayed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06006048 RID: 24648 RVA: 0x00175254 File Offset: 0x00173454
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x0017526C File Offset: 0x0017346C
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x0017529D File Offset: 0x0017349D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = RecentPlayer.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x001752B8 File Offset: 0x001734B8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x001752D5 File Offset: 0x001734D5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600604D RID: 24653 RVA: 0x001752E8 File Offset: 0x001734E8
		// (set) Token: 0x0600604E RID: 24654 RVA: 0x00175319 File Offset: 0x00173519
		[DebuggerNonUserCode]
		public uint Counter
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint counterDefaultValue;
				if (flag)
				{
					counterDefaultValue = this.counter_;
				}
				else
				{
					counterDefaultValue = RecentPlayer.CounterDefaultValue;
				}
				return counterDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.counter_ = value;
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x00175334 File Offset: 0x00173534
		[DebuggerNonUserCode]
		public bool HasCounter
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00175351 File Offset: 0x00173551
		[DebuggerNonUserCode]
		public void ClearCounter()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x00175364 File Offset: 0x00173564
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayer);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00175384 File Offset: 0x00173584
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayer other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TimestampPlayed != other.TimestampPlayed;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attributes_.Equals(other.attributes_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Id != other.Id;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Counter != other.Counter;
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

		// Token: 0x06006053 RID: 24659 RVA: 0x00175474 File Offset: 0x00173674
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasTimestampPlayed = this.HasTimestampPlayed;
			if (hasTimestampPlayed)
			{
				num ^= this.TimestampPlayed.GetHashCode();
			}
			num ^= this.attributes_.GetHashCode();
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				num ^= this.Counter.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00175544 File Offset: 0x00173744
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x0017555C File Offset: 0x0017375C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00175568 File Offset: 0x00173768
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Program);
			}
			bool hasTimestampPlayed = this.HasTimestampPlayed;
			if (hasTimestampPlayed)
			{
				output.WriteRawTag(25);
				output.WriteFixed64(this.TimestampPlayed);
			}
			this.attributes_.WriteTo(ref output, RecentPlayer._repeated_attributes_codec);
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.Id);
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				output.WriteRawTag(53);
				output.WriteFixed32(this.Counter);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00175658 File Offset: 0x00173858
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Program);
			}
			bool hasTimestampPlayed = this.HasTimestampPlayed;
			if (hasTimestampPlayed)
			{
				num += 9;
			}
			num += this.attributes_.CalculateSize(RecentPlayer._repeated_attributes_codec);
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool hasCounter = this.HasCounter;
			if (hasCounter)
			{
				num += 5;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00175714 File Offset: 0x00173914
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasTimestampPlayed = other.HasTimestampPlayed;
				if (hasTimestampPlayed)
				{
					this.TimestampPlayed = other.TimestampPlayed;
				}
				this.attributes_.Add(other.attributes_);
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasCounter = other.HasCounter;
				if (hasCounter)
				{
					this.Counter = other.Counter;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x001757FF File Offset: 0x001739FF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x0017580C File Offset: 0x00173A0C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 25U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 25U)
							{
								goto IL_0040;
							}
							this.TimestampPlayed = input.ReadFixed64();
						}
						else
						{
							this.Program = input.ReadString();
						}
					}
					else
					{
						bool flag = this.entityId_ == null;
						if (flag)
						{
							this.EntityId = new EntityId();
						}
						input.ReadMessage(this.EntityId);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 45U)
					{
						if (num3 != 53U)
						{
							goto IL_0040;
						}
						this.Counter = input.ReadFixed32();
					}
					else
					{
						this.Id = input.ReadFixed32();
					}
				}
				else
				{
					this.attributes_.AddEntriesFrom(ref input, RecentPlayer._repeated_attributes_codec);
				}
				continue;
				IL_0040:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BFF RID: 11263
		private static readonly MessageParser<RecentPlayer> _parser = new MessageParser<RecentPlayer>(() => new RecentPlayer());

		// Token: 0x04002C00 RID: 11264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C01 RID: 11265
		private int _hasBits0;

		// Token: 0x04002C02 RID: 11266
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04002C03 RID: 11267
		private EntityId entityId_;

		// Token: 0x04002C04 RID: 11268
		public const int ProgramFieldNumber = 2;

		// Token: 0x04002C05 RID: 11269
		private static readonly string ProgramDefaultValue = "";

		// Token: 0x04002C06 RID: 11270
		private string program_;

		// Token: 0x04002C07 RID: 11271
		public const int TimestampPlayedFieldNumber = 3;

		// Token: 0x04002C08 RID: 11272
		private static readonly ulong TimestampPlayedDefaultValue = 0UL;

		// Token: 0x04002C09 RID: 11273
		private ulong timestampPlayed_;

		// Token: 0x04002C0A RID: 11274
		public const int AttributesFieldNumber = 4;

		// Token: 0x04002C0B RID: 11275
		private static readonly FieldCodec<Attribute> _repeated_attributes_codec = FieldCodec.ForMessage<Attribute>(34U, Attribute.Parser);

		// Token: 0x04002C0C RID: 11276
		private readonly RepeatedField<Attribute> attributes_ = new RepeatedField<Attribute>();

		// Token: 0x04002C0D RID: 11277
		public const int IdFieldNumber = 5;

		// Token: 0x04002C0E RID: 11278
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002C0F RID: 11279
		private uint id_;

		// Token: 0x04002C10 RID: 11280
		public const int CounterFieldNumber = 6;

		// Token: 0x04002C11 RID: 11281
		private static readonly uint CounterDefaultValue = 0U;

		// Token: 0x04002C12 RID: 11282
		private uint counter_;
	}
}

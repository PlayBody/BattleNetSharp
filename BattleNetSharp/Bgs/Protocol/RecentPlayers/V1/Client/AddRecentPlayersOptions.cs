using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063C RID: 1596
	public sealed class AddRecentPlayersOptions : IMessage<AddRecentPlayersOptions>, IMessage, IEquatable<AddRecentPlayersOptions>, IDeepCloneable<AddRecentPlayersOptions>, IBufferMessage
	{
		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x0023F0CC File Offset: 0x0023D2CC
		[DebuggerNonUserCode]
		public static MessageParser<AddRecentPlayersOptions> Parser
		{
			get
			{
				return AddRecentPlayersOptions._parser;
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x06009480 RID: 38016 RVA: 0x0023F0E4 File Offset: 0x0023D2E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x0023F108 File Offset: 0x0023D308
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRecentPlayersOptions.Descriptor;
			}
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x0023F11F File Offset: 0x0023D31F
		[DebuggerNonUserCode]
		public AddRecentPlayersOptions()
		{
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x0023F134 File Offset: 0x0023D334
		[DebuggerNonUserCode]
		public AddRecentPlayersOptions(AddRecentPlayersOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.recentPlayer_ = other.recentPlayer_.Clone();
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x0023F184 File Offset: 0x0023D384
		[DebuggerNonUserCode]
		public AddRecentPlayersOptions Clone()
		{
			return new AddRecentPlayersOptions(this);
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x0023F19C File Offset: 0x0023D39C
		[DebuggerNonUserCode]
		public RepeatedField<RecentPlayerOptions> RecentPlayer
		{
			get
			{
				return this.recentPlayer_;
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06009486 RID: 38022 RVA: 0x0023F1B4 File Offset: 0x0023D3B4
		// (set) Token: 0x06009487 RID: 38023 RVA: 0x0023F1E5 File Offset: 0x0023D3E5
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = AddRecentPlayersOptions.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x06009488 RID: 38024 RVA: 0x0023F200 File Offset: 0x0023D400
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x0023F21D File Offset: 0x0023D41D
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x0023F230 File Offset: 0x0023D430
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRecentPlayersOptions);
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x0023F250 File Offset: 0x0023D450
		[DebuggerNonUserCode]
		public bool Equals(AddRecentPlayersOptions other)
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
					bool flag4 = !this.recentPlayer_.Equals(other.recentPlayer_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x0023F2C4 File Offset: 0x0023D4C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recentPlayer_.GetHashCode();
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x0023F324 File Offset: 0x0023D524
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x0023F33C File Offset: 0x0023D53C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x0023F348 File Offset: 0x0023D548
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recentPlayer_.WriteTo(ref output, AddRecentPlayersOptions._repeated_recentPlayer_codec);
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x0023F3A8 File Offset: 0x0023D5A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recentPlayer_.CalculateSize(AddRecentPlayersOptions._repeated_recentPlayer_codec);
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x0023F400 File Offset: 0x0023D600
		[DebuggerNonUserCode]
		public void MergeFrom(AddRecentPlayersOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.recentPlayer_.Add(other.recentPlayer_);
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0023F45B File Offset: 0x0023D65B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x0023F468 File Offset: 0x0023D668
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 29U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.recentPlayer_.AddEntriesFrom(ref input, AddRecentPlayersOptions._repeated_recentPlayer_codec);
				}
			}
		}

		// Token: 0x040042EB RID: 17131
		private static readonly MessageParser<AddRecentPlayersOptions> _parser = new MessageParser<AddRecentPlayersOptions>(() => new AddRecentPlayersOptions());

		// Token: 0x040042EC RID: 17132
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042ED RID: 17133
		private int _hasBits0;

		// Token: 0x040042EE RID: 17134
		public const int RecentPlayerFieldNumber = 2;

		// Token: 0x040042EF RID: 17135
		private static readonly FieldCodec<RecentPlayerOptions> _repeated_recentPlayer_codec = FieldCodec.ForMessage<RecentPlayerOptions>(18U, RecentPlayerOptions.Parser);

		// Token: 0x040042F0 RID: 17136
		private readonly RepeatedField<RecentPlayerOptions> recentPlayer_ = new RepeatedField<RecentPlayerOptions>();

		// Token: 0x040042F1 RID: 17137
		public const int ProgramFieldNumber = 3;

		// Token: 0x040042F2 RID: 17138
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x040042F3 RID: 17139
		private uint program_;
	}
}

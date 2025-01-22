using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200002B RID: 43
	public sealed class ConsoleCommandList : IMessage<ConsoleCommandList>, IMessage, IEquatable<ConsoleCommandList>, IDeepCloneable<ConsoleCommandList>, IBufferMessage
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[DebuggerNonUserCode]
		public static MessageParser<ConsoleCommandList> Parser
		{
			get
			{
				return ConsoleCommandList._parser;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsoleCommandList.Descriptor;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000FE03 File Offset: 0x0000E003
		[DebuggerNonUserCode]
		public ConsoleCommandList()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000FE18 File Offset: 0x0000E018
		[DebuggerNonUserCode]
		public ConsoleCommandList(ConsoleCommandList other)
			: this()
		{
			this.entries_ = other.entries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000FE44 File Offset: 0x0000E044
		[DebuggerNonUserCode]
		public ConsoleCommandList Clone()
		{
			return new ConsoleCommandList(this);
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000FE5C File Offset: 0x0000E05C
		[DebuggerNonUserCode]
		public RepeatedField<ConsoleCommandList.Types.ConsoleCommandEntry> Entries
		{
			get
			{
				return this.entries_;
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000FE74 File Offset: 0x0000E074
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsoleCommandList);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000FE94 File Offset: 0x0000E094
		[DebuggerNonUserCode]
		public bool Equals(ConsoleCommandList other)
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
					bool flag4 = !this.entries_.Equals(other.entries_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entries_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000FF30 File Offset: 0x0000E130
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000FF48 File Offset: 0x0000E148
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000FF54 File Offset: 0x0000E154
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entries_.WriteTo(ref output, ConsoleCommandList._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000FF90 File Offset: 0x0000E190
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entries_.CalculateSize(ConsoleCommandList._repeated_entries_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[DebuggerNonUserCode]
		public void MergeFrom(ConsoleCommandList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.entries_.Add(other.entries_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0001001A File Offset: 0x0000E21A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00010028 File Offset: 0x0000E228
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entries_.AddEntriesFrom(ref input, ConsoleCommandList._repeated_entries_codec);
				}
			}
		}

		// Token: 0x0400011B RID: 283
		private static readonly MessageParser<ConsoleCommandList> _parser = new MessageParser<ConsoleCommandList>(() => new ConsoleCommandList());

		// Token: 0x0400011C RID: 284
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400011D RID: 285
		public const int EntriesFieldNumber = 1;

		// Token: 0x0400011E RID: 286
		private static readonly FieldCodec<ConsoleCommandList.Types.ConsoleCommandEntry> _repeated_entries_codec = FieldCodec.ForMessage<ConsoleCommandList.Types.ConsoleCommandEntry>(10U, ConsoleCommandList.Types.ConsoleCommandEntry.Parser);

		// Token: 0x0400011F RID: 287
		private readonly RepeatedField<ConsoleCommandList.Types.ConsoleCommandEntry> entries_ = new RepeatedField<ConsoleCommandList.Types.ConsoleCommandEntry>();

		// Token: 0x02000B40 RID: 2880
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200145F RID: 5215
			public sealed class ConsoleCommandEntry : IMessage<ConsoleCommandList.Types.ConsoleCommandEntry>, IMessage, IEquatable<ConsoleCommandList.Types.ConsoleCommandEntry>, IDeepCloneable<ConsoleCommandList.Types.ConsoleCommandEntry>, IBufferMessage
			{
				// Token: 0x170039D3 RID: 14803
				// (get) Token: 0x0600E3B6 RID: 58294 RVA: 0x004CE57C File Offset: 0x004CC77C
				[DebuggerNonUserCode]
				public static MessageParser<ConsoleCommandList.Types.ConsoleCommandEntry> Parser
				{
					get
					{
						return ConsoleCommandList.Types.ConsoleCommandEntry._parser;
					}
				}

				// Token: 0x170039D4 RID: 14804
				// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x004CE594 File Offset: 0x004CC794
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return ConsoleCommandList.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x170039D5 RID: 14805
				// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x004CE5B8 File Offset: 0x004CC7B8
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return ConsoleCommandList.Types.ConsoleCommandEntry.Descriptor;
					}
				}

				// Token: 0x0600E3B9 RID: 58297 RVA: 0x004CE5CF File Offset: 0x004CC7CF
				[DebuggerNonUserCode]
				public ConsoleCommandEntry()
				{
				}

				// Token: 0x0600E3BA RID: 58298 RVA: 0x004CE5D9 File Offset: 0x004CC7D9
				[DebuggerNonUserCode]
				public ConsoleCommandEntry(ConsoleCommandList.Types.ConsoleCommandEntry other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.command_ = other.command_;
					this.flags_ = other.flags_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E3BB RID: 58299 RVA: 0x004CE618 File Offset: 0x004CC818
				[DebuggerNonUserCode]
				public ConsoleCommandList.Types.ConsoleCommandEntry Clone()
				{
					return new ConsoleCommandList.Types.ConsoleCommandEntry(this);
				}

				// Token: 0x170039D6 RID: 14806
				// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x004CE630 File Offset: 0x004CC830
				// (set) Token: 0x0600E3BD RID: 58301 RVA: 0x004CE651 File Offset: 0x004CC851
				[DebuggerNonUserCode]
				public string Command
				{
					get
					{
						return this.command_ ?? ConsoleCommandList.Types.ConsoleCommandEntry.CommandDefaultValue;
					}
					set
					{
						this.command_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x170039D7 RID: 14807
				// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x004CE668 File Offset: 0x004CC868
				[DebuggerNonUserCode]
				public bool HasCommand
				{
					get
					{
						return this.command_ != null;
					}
				}

				// Token: 0x0600E3BF RID: 58303 RVA: 0x004CE683 File Offset: 0x004CC883
				[DebuggerNonUserCode]
				public void ClearCommand()
				{
					this.command_ = null;
				}

				// Token: 0x170039D8 RID: 14808
				// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x004CE690 File Offset: 0x004CC890
				// (set) Token: 0x0600E3C1 RID: 58305 RVA: 0x004CE6C1 File Offset: 0x004CC8C1
				[DebuggerNonUserCode]
				public uint Flags
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						uint flagsDefaultValue;
						if (flag)
						{
							flagsDefaultValue = this.flags_;
						}
						else
						{
							flagsDefaultValue = ConsoleCommandList.Types.ConsoleCommandEntry.FlagsDefaultValue;
						}
						return flagsDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.flags_ = value;
					}
				}

				// Token: 0x170039D9 RID: 14809
				// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x004CE6DC File Offset: 0x004CC8DC
				[DebuggerNonUserCode]
				public bool HasFlags
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E3C3 RID: 58307 RVA: 0x004CE6F9 File Offset: 0x004CC8F9
				[DebuggerNonUserCode]
				public void ClearFlags()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x0600E3C4 RID: 58308 RVA: 0x004CE70C File Offset: 0x004CC90C
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as ConsoleCommandList.Types.ConsoleCommandEntry);
				}

				// Token: 0x0600E3C5 RID: 58309 RVA: 0x004CE72C File Offset: 0x004CC92C
				[DebuggerNonUserCode]
				public bool Equals(ConsoleCommandList.Types.ConsoleCommandEntry other)
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
							bool flag4 = this.Command != other.Command;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.Flags != other.Flags;
								flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E3C6 RID: 58310 RVA: 0x004CE7A0 File Offset: 0x004CC9A0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasCommand = this.HasCommand;
					if (hasCommand)
					{
						num ^= this.Command.GetHashCode();
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						num ^= this.Flags.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E3C7 RID: 58311 RVA: 0x004CE80C File Offset: 0x004CCA0C
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E3C8 RID: 58312 RVA: 0x004CE824 File Offset: 0x004CCA24
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E3C9 RID: 58313 RVA: 0x004CE830 File Offset: 0x004CCA30
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasCommand = this.HasCommand;
					if (hasCommand)
					{
						output.WriteRawTag(10);
						output.WriteString(this.Command);
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						output.WriteRawTag(16);
						output.WriteUInt32(this.Flags);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E3CA RID: 58314 RVA: 0x004CE8A0 File Offset: 0x004CCAA0
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasCommand = this.HasCommand;
					if (hasCommand)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.Command);
					}
					bool hasFlags = this.HasFlags;
					if (hasFlags)
					{
						num += 1 + CodedOutputStream.ComputeUInt32Size(this.Flags);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E3CB RID: 58315 RVA: 0x004CE90C File Offset: 0x004CCB0C
				[DebuggerNonUserCode]
				public void MergeFrom(ConsoleCommandList.Types.ConsoleCommandEntry other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasCommand = other.HasCommand;
						if (hasCommand)
						{
							this.Command = other.Command;
						}
						bool hasFlags = other.HasFlags;
						if (hasFlags)
						{
							this.Flags = other.Flags;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E3CC RID: 58316 RVA: 0x004CE96E File Offset: 0x004CCB6E
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E3CD RID: 58317 RVA: 0x004CE97C File Offset: 0x004CCB7C
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
							if (num3 != 16U)
							{
								this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
							}
							else
							{
								this.Flags = input.ReadUInt32();
							}
						}
						else
						{
							this.Command = input.ReadString();
						}
					}
				}

				// Token: 0x0400A26E RID: 41582
				private static readonly MessageParser<ConsoleCommandList.Types.ConsoleCommandEntry> _parser = new MessageParser<ConsoleCommandList.Types.ConsoleCommandEntry>(() => new ConsoleCommandList.Types.ConsoleCommandEntry());

				// Token: 0x0400A26F RID: 41583
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A270 RID: 41584
				private int _hasBits0;

				// Token: 0x0400A271 RID: 41585
				public const int CommandFieldNumber = 1;

				// Token: 0x0400A272 RID: 41586
				private static readonly string CommandDefaultValue = "";

				// Token: 0x0400A273 RID: 41587
				private string command_;

				// Token: 0x0400A274 RID: 41588
				public const int FlagsFieldNumber = 2;

				// Token: 0x0400A275 RID: 41589
				private static readonly uint FlagsDefaultValue = 0U;

				// Token: 0x0400A276 RID: 41590
				private uint flags_;
			}
		}
	}
}

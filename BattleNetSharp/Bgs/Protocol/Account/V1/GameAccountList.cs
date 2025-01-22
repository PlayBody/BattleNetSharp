using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074A RID: 1866
	public sealed class GameAccountList : IMessage<GameAccountList>, IMessage, IEquatable<GameAccountList>, IDeepCloneable<GameAccountList>, IBufferMessage
	{
		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600ABBE RID: 43966 RVA: 0x0029D174 File Offset: 0x0029B374
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountList> Parser
		{
			get
			{
				return GameAccountList._parser;
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600ABBF RID: 43967 RVA: 0x0029D18C File Offset: 0x0029B38C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[26];
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600ABC0 RID: 43968 RVA: 0x0029D1B0 File Offset: 0x0029B3B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountList.Descriptor;
			}
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x0029D1C7 File Offset: 0x0029B3C7
		[DebuggerNonUserCode]
		public GameAccountList()
		{
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0029D1DC File Offset: 0x0029B3DC
		[DebuggerNonUserCode]
		public GameAccountList(GameAccountList other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.region_ = other.region_;
			this.handle_ = other.handle_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x0029D22C File Offset: 0x0029B42C
		[DebuggerNonUserCode]
		public GameAccountList Clone()
		{
			return new GameAccountList(this);
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x0029D244 File Offset: 0x0029B444
		// (set) Token: 0x0600ABC5 RID: 43973 RVA: 0x0029D275 File Offset: 0x0029B475
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = GameAccountList.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.region_ = value;
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x0029D290 File Offset: 0x0029B490
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x0029D2AD File Offset: 0x0029B4AD
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x0029D2C0 File Offset: 0x0029B4C0
		[DebuggerNonUserCode]
		public RepeatedField<GameAccountHandle> Handle
		{
			get
			{
				return this.handle_;
			}
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x0029D2D8 File Offset: 0x0029B4D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountList);
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x0029D2F8 File Offset: 0x0029B4F8
		[DebuggerNonUserCode]
		public bool Equals(GameAccountList other)
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
					bool flag4 = this.Region != other.Region;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.handle_.Equals(other.handle_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x0029D36C File Offset: 0x0029B56C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			num ^= this.handle_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x0029D3CC File Offset: 0x0029B5CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x0029D3E4 File Offset: 0x0029B5E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x0029D3F0 File Offset: 0x0029B5F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Region);
			}
			this.handle_.WriteTo(ref output, GameAccountList._repeated_handle_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x0029D450 File Offset: 0x0029B650
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			num += this.handle_.CalculateSize(GameAccountList._repeated_handle_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x0029D4B4 File Offset: 0x0029B6B4
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this.handle_.Add(other.handle_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x0029D50F File Offset: 0x0029B70F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x0029D51C File Offset: 0x0029B71C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.handle_.AddEntriesFrom(ref input, GameAccountList._repeated_handle_codec);
					}
				}
				else
				{
					this.Region = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D5D RID: 19805
		private static readonly MessageParser<GameAccountList> _parser = new MessageParser<GameAccountList>(() => new GameAccountList());

		// Token: 0x04004D5E RID: 19806
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D5F RID: 19807
		private int _hasBits0;

		// Token: 0x04004D60 RID: 19808
		public const int RegionFieldNumber = 3;

		// Token: 0x04004D61 RID: 19809
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004D62 RID: 19810
		private uint region_;

		// Token: 0x04004D63 RID: 19811
		public const int HandleFieldNumber = 4;

		// Token: 0x04004D64 RID: 19812
		private static readonly FieldCodec<GameAccountHandle> _repeated_handle_codec = FieldCodec.ForMessage<GameAccountHandle>(34U, GameAccountHandle.Parser);

		// Token: 0x04004D65 RID: 19813
		private readonly RepeatedField<GameAccountHandle> handle_ = new RepeatedField<GameAccountHandle>();
	}
}

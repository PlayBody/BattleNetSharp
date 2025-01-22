using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006E RID: 110
	public sealed class PlayWorldRequest : IMessage<PlayWorldRequest>, IMessage, IEquatable<PlayWorldRequest>, IDeepCloneable<PlayWorldRequest>, IBufferMessage
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00025E1C File Offset: 0x0002401C
		[DebuggerNonUserCode]
		public static MessageParser<PlayWorldRequest> Parser
		{
			get
			{
				return PlayWorldRequest._parser;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00025E34 File Offset: 0x00024034
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[87];
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00025E58 File Offset: 0x00024058
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayWorldRequest.Descriptor;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00025E6F File Offset: 0x0002406F
		[DebuggerNonUserCode]
		public PlayWorldRequest()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00025E7C File Offset: 0x0002407C
		[DebuggerNonUserCode]
		public PlayWorldRequest(PlayWorldRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.seed_ = other.seed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00025EE4 File Offset: 0x000240E4
		[DebuggerNonUserCode]
		public PlayWorldRequest Clone()
		{
			return new PlayWorldRequest(this);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00025EFC File Offset: 0x000240FC
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00025F2D File Offset: 0x0002412D
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = PlayWorldRequest.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00025F48 File Offset: 0x00024148
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00025F65 File Offset: 0x00024165
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00025F78 File Offset: 0x00024178
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00025F90 File Offset: 0x00024190
		[DebuggerNonUserCode]
		public Vector3 Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00025F9C File Offset: 0x0002419C
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00025FCD File Offset: 0x000241CD
		[DebuggerNonUserCode]
		public int Seed
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int seedDefaultValue;
				if (flag)
				{
					seedDefaultValue = this.seed_;
				}
				else
				{
					seedDefaultValue = PlayWorldRequest.SeedDefaultValue;
				}
				return seedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.seed_ = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00025FE8 File Offset: 0x000241E8
		[DebuggerNonUserCode]
		public bool HasSeed
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00026005 File Offset: 0x00024205
		[DebuggerNonUserCode]
		public void ClearSeed()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00026018 File Offset: 0x00024218
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayWorldRequest);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00026038 File Offset: 0x00024238
		[DebuggerNonUserCode]
		public bool Equals(PlayWorldRequest other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Pos, other.Pos);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Seed != other.Seed;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000260C8 File Offset: 0x000242C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num ^= this.Pos.GetHashCode();
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num ^= this.Seed.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00026154 File Offset: 0x00024354
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002616C File Offset: 0x0002436C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00026178 File Offset: 0x00024378
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoWorld);
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Seed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002620C File Offset: 0x0002440C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool flag = this.pos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seed);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002629C File Offset: 0x0002449C
		[DebuggerNonUserCode]
		public void MergeFrom(PlayWorldRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool flag2 = other.pos_ != null;
				if (flag2)
				{
					bool flag3 = this.pos_ == null;
					if (flag3)
					{
						this.Pos = new Vector3();
					}
					this.Pos.MergeFrom(other.Pos);
				}
				bool hasSeed = other.HasSeed;
				if (hasSeed)
				{
					this.Seed = other.Seed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002633F File Offset: 0x0002453F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002634C File Offset: 0x0002454C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Seed = input.ReadInt32();
						}
					}
					else
					{
						bool flag = this.pos_ == null;
						if (flag)
						{
							this.Pos = new Vector3();
						}
						input.ReadMessage(this.Pos);
					}
				}
				else
				{
					this.SnoWorld = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003CA RID: 970
		private static readonly MessageParser<PlayWorldRequest> _parser = new MessageParser<PlayWorldRequest>(() => new PlayWorldRequest());

		// Token: 0x040003CB RID: 971
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003CC RID: 972
		private int _hasBits0;

		// Token: 0x040003CD RID: 973
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x040003CE RID: 974
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x040003CF RID: 975
		private int snoWorld_;

		// Token: 0x040003D0 RID: 976
		public const int PosFieldNumber = 2;

		// Token: 0x040003D1 RID: 977
		private Vector3 pos_;

		// Token: 0x040003D2 RID: 978
		public const int SeedFieldNumber = 3;

		// Token: 0x040003D3 RID: 979
		private static readonly int SeedDefaultValue = 0;

		// Token: 0x040003D4 RID: 980
		private int seed_;
	}
}

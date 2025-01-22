using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003EC RID: 1004
	public sealed class MatchmakerHandle : IMessage<MatchmakerHandle>, IMessage, IEquatable<MatchmakerHandle>, IDeepCloneable<MatchmakerHandle>, IBufferMessage
	{
		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x060063D1 RID: 25553 RVA: 0x00181E04 File Offset: 0x00180004
		[DebuggerNonUserCode]
		public static MessageParser<MatchmakerHandle> Parser
		{
			get
			{
				return MatchmakerHandle._parser;
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x00181E1C File Offset: 0x0018001C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x060063D3 RID: 25555 RVA: 0x00181E40 File Offset: 0x00180040
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchmakerHandle.Descriptor;
			}
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x00181E57 File Offset: 0x00180057
		[DebuggerNonUserCode]
		public MatchmakerHandle()
		{
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x00181E64 File Offset: 0x00180064
		[DebuggerNonUserCode]
		public MatchmakerHandle(MatchmakerHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.addr_ = ((other.addr_ != null) ? other.addr_.Clone() : null);
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x00181EC0 File Offset: 0x001800C0
		[DebuggerNonUserCode]
		public MatchmakerHandle Clone()
		{
			return new MatchmakerHandle(this);
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x060063D7 RID: 25559 RVA: 0x00181ED8 File Offset: 0x001800D8
		// (set) Token: 0x060063D8 RID: 25560 RVA: 0x00181EF0 File Offset: 0x001800F0
		[DebuggerNonUserCode]
		public HostProxyPair Addr
		{
			get
			{
				return this.addr_;
			}
			set
			{
				this.addr_ = value;
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x060063D9 RID: 25561 RVA: 0x00181EFC File Offset: 0x001800FC
		// (set) Token: 0x060063DA RID: 25562 RVA: 0x00181F2D File Offset: 0x0018012D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = MatchmakerHandle.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x060063DB RID: 25563 RVA: 0x00181F48 File Offset: 0x00180148
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x00181F65 File Offset: 0x00180165
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00181F78 File Offset: 0x00180178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchmakerHandle);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00181F98 File Offset: 0x00180198
		[DebuggerNonUserCode]
		public bool Equals(MatchmakerHandle other)
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
					bool flag4 = !object.Equals(this.Addr, other.Addr);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x0018200C File Offset: 0x0018020C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.addr_ != null;
			if (flag)
			{
				num ^= this.Addr.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00182078 File Offset: 0x00180278
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x00182090 File Offset: 0x00180290
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x0018209C File Offset: 0x0018029C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.addr_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Addr);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Id);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00182110 File Offset: 0x00180310
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.addr_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Addr);
			}
			bool hasId = this.HasId;
			if (hasId)
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

		// Token: 0x060063E4 RID: 25572 RVA: 0x00182174 File Offset: 0x00180374
		[DebuggerNonUserCode]
		public void MergeFrom(MatchmakerHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.addr_ != null;
				if (flag2)
				{
					bool flag3 = this.addr_ == null;
					if (flag3)
					{
						this.Addr = new HostProxyPair();
					}
					this.Addr.MergeFrom(other.Addr);
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x001821F9 File Offset: 0x001803F9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00182204 File Offset: 0x00180404
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
					if (num3 != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadFixed32();
					}
				}
				else
				{
					bool flag = this.addr_ == null;
					if (flag)
					{
						this.Addr = new HostProxyPair();
					}
					input.ReadMessage(this.Addr);
				}
			}
		}

		// Token: 0x04002D7C RID: 11644
		private static readonly MessageParser<MatchmakerHandle> _parser = new MessageParser<MatchmakerHandle>(() => new MatchmakerHandle());

		// Token: 0x04002D7D RID: 11645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D7E RID: 11646
		private int _hasBits0;

		// Token: 0x04002D7F RID: 11647
		public const int AddrFieldNumber = 1;

		// Token: 0x04002D80 RID: 11648
		private HostProxyPair addr_;

		// Token: 0x04002D81 RID: 11649
		public const int IdFieldNumber = 2;

		// Token: 0x04002D82 RID: 11650
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002D83 RID: 11651
		private uint id_;
	}
}

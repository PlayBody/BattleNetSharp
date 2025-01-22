using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x0200076F RID: 1903
	public sealed class Entity : IMessage<Entity>, IMessage, IEquatable<Entity>, IDeepCloneable<Entity>, IBufferMessage
	{
		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600AEAC RID: 44716 RVA: 0x002A8524 File Offset: 0x002A6724
		[DebuggerNonUserCode]
		public static MessageParser<Entity> Parser
		{
			get
			{
				return Entity._parser;
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x002A853C File Offset: 0x002A673C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600AEAE RID: 44718 RVA: 0x002A8560 File Offset: 0x002A6760
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Entity.Descriptor;
			}
		}

		// Token: 0x0600AEAF RID: 44719 RVA: 0x002A8577 File Offset: 0x002A6777
		[DebuggerNonUserCode]
		public Entity()
		{
		}

		// Token: 0x0600AEB0 RID: 44720 RVA: 0x002A8584 File Offset: 0x002A6784
		[DebuggerNonUserCode]
		public Entity(Entity other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.accoundIdHigh_ = other.accoundIdHigh_;
			this.accoundIdLow_ = other.accoundIdLow_;
			this.gameAccountIdHigh_ = other.gameAccountIdHigh_;
			this.gameAccountIdLow_ = other.gameAccountIdLow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEB1 RID: 44721 RVA: 0x002A85E8 File Offset: 0x002A67E8
		[DebuggerNonUserCode]
		public Entity Clone()
		{
			return new Entity(this);
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x002A8600 File Offset: 0x002A6800
		// (set) Token: 0x0600AEB3 RID: 44723 RVA: 0x002A8631 File Offset: 0x002A6831
		[DebuggerNonUserCode]
		public ulong AccoundIdHigh
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong accoundIdHighDefaultValue;
				if (flag)
				{
					accoundIdHighDefaultValue = this.accoundIdHigh_;
				}
				else
				{
					accoundIdHighDefaultValue = Entity.AccoundIdHighDefaultValue;
				}
				return accoundIdHighDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accoundIdHigh_ = value;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600AEB4 RID: 44724 RVA: 0x002A864C File Offset: 0x002A684C
		[DebuggerNonUserCode]
		public bool HasAccoundIdHigh
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x002A8669 File Offset: 0x002A6869
		[DebuggerNonUserCode]
		public void ClearAccoundIdHigh()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600AEB6 RID: 44726 RVA: 0x002A867C File Offset: 0x002A687C
		// (set) Token: 0x0600AEB7 RID: 44727 RVA: 0x002A86AD File Offset: 0x002A68AD
		[DebuggerNonUserCode]
		public ulong AccoundIdLow
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong accoundIdLowDefaultValue;
				if (flag)
				{
					accoundIdLowDefaultValue = this.accoundIdLow_;
				}
				else
				{
					accoundIdLowDefaultValue = Entity.AccoundIdLowDefaultValue;
				}
				return accoundIdLowDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.accoundIdLow_ = value;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x002A86C8 File Offset: 0x002A68C8
		[DebuggerNonUserCode]
		public bool HasAccoundIdLow
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x002A86E5 File Offset: 0x002A68E5
		[DebuggerNonUserCode]
		public void ClearAccoundIdLow()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x002A86F8 File Offset: 0x002A68F8
		// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x002A8729 File Offset: 0x002A6929
		[DebuggerNonUserCode]
		public ulong GameAccountIdHigh
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong gameAccountIdHighDefaultValue;
				if (flag)
				{
					gameAccountIdHighDefaultValue = this.gameAccountIdHigh_;
				}
				else
				{
					gameAccountIdHighDefaultValue = Entity.GameAccountIdHighDefaultValue;
				}
				return gameAccountIdHighDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameAccountIdHigh_ = value;
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x002A8744 File Offset: 0x002A6944
		[DebuggerNonUserCode]
		public bool HasGameAccountIdHigh
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x002A8761 File Offset: 0x002A6961
		[DebuggerNonUserCode]
		public void ClearGameAccountIdHigh()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x002A8774 File Offset: 0x002A6974
		// (set) Token: 0x0600AEBF RID: 44735 RVA: 0x002A87A5 File Offset: 0x002A69A5
		[DebuggerNonUserCode]
		public ulong GameAccountIdLow
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				ulong gameAccountIdLowDefaultValue;
				if (flag)
				{
					gameAccountIdLowDefaultValue = this.gameAccountIdLow_;
				}
				else
				{
					gameAccountIdLowDefaultValue = Entity.GameAccountIdLowDefaultValue;
				}
				return gameAccountIdLowDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.gameAccountIdLow_ = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x002A87C0 File Offset: 0x002A69C0
		[DebuggerNonUserCode]
		public bool HasGameAccountIdLow
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x002A87DD File Offset: 0x002A69DD
		[DebuggerNonUserCode]
		public void ClearGameAccountIdLow()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x002A87F0 File Offset: 0x002A69F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Entity);
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002A8810 File Offset: 0x002A6A10
		[DebuggerNonUserCode]
		public bool Equals(Entity other)
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
					bool flag4 = this.AccoundIdHigh != other.AccoundIdHigh;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AccoundIdLow != other.AccoundIdLow;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameAccountIdHigh != other.GameAccountIdHigh;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.GameAccountIdLow != other.GameAccountIdLow;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x002A88BC File Offset: 0x002A6ABC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAccoundIdHigh = this.HasAccoundIdHigh;
			if (hasAccoundIdHigh)
			{
				num ^= this.AccoundIdHigh.GetHashCode();
			}
			bool hasAccoundIdLow = this.HasAccoundIdLow;
			if (hasAccoundIdLow)
			{
				num ^= this.AccoundIdLow.GetHashCode();
			}
			bool hasGameAccountIdHigh = this.HasGameAccountIdHigh;
			if (hasGameAccountIdHigh)
			{
				num ^= this.GameAccountIdHigh.GetHashCode();
			}
			bool hasGameAccountIdLow = this.HasGameAccountIdLow;
			if (hasGameAccountIdLow)
			{
				num ^= this.GameAccountIdLow.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x002A8964 File Offset: 0x002A6B64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x002A897C File Offset: 0x002A6B7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x002A8988 File Offset: 0x002A6B88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAccoundIdHigh = this.HasAccoundIdHigh;
			if (hasAccoundIdHigh)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.AccoundIdHigh);
			}
			bool hasAccoundIdLow = this.HasAccoundIdLow;
			if (hasAccoundIdLow)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.AccoundIdLow);
			}
			bool hasGameAccountIdHigh = this.HasGameAccountIdHigh;
			if (hasGameAccountIdHigh)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.GameAccountIdHigh);
			}
			bool hasGameAccountIdLow = this.HasGameAccountIdLow;
			if (hasGameAccountIdLow)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.GameAccountIdLow);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x002A8A3C File Offset: 0x002A6C3C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAccoundIdHigh = this.HasAccoundIdHigh;
			if (hasAccoundIdHigh)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccoundIdHigh);
			}
			bool hasAccoundIdLow = this.HasAccoundIdLow;
			if (hasAccoundIdLow)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.AccoundIdLow);
			}
			bool hasGameAccountIdHigh = this.HasGameAccountIdHigh;
			if (hasGameAccountIdHigh)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameAccountIdHigh);
			}
			bool hasGameAccountIdLow = this.HasGameAccountIdLow;
			if (hasGameAccountIdLow)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GameAccountIdLow);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x002A8AE4 File Offset: 0x002A6CE4
		[DebuggerNonUserCode]
		public void MergeFrom(Entity other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAccoundIdHigh = other.HasAccoundIdHigh;
				if (hasAccoundIdHigh)
				{
					this.AccoundIdHigh = other.AccoundIdHigh;
				}
				bool hasAccoundIdLow = other.HasAccoundIdLow;
				if (hasAccoundIdLow)
				{
					this.AccoundIdLow = other.AccoundIdLow;
				}
				bool hasGameAccountIdHigh = other.HasGameAccountIdHigh;
				if (hasGameAccountIdHigh)
				{
					this.GameAccountIdHigh = other.GameAccountIdHigh;
				}
				bool hasGameAccountIdLow = other.HasGameAccountIdLow;
				if (hasGameAccountIdLow)
				{
					this.GameAccountIdLow = other.GameAccountIdLow;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x002A8B7A File Offset: 0x002A6D7A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x002A8B88 File Offset: 0x002A6D88
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
						this.AccoundIdLow = input.ReadUInt64();
					}
					else
					{
						this.AccoundIdHigh = input.ReadUInt64();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.GameAccountIdLow = input.ReadUInt64();
				}
				else
				{
					this.GameAccountIdHigh = input.ReadUInt64();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EAF RID: 20143
		private static readonly MessageParser<Entity> _parser = new MessageParser<Entity>(() => new Entity());

		// Token: 0x04004EB0 RID: 20144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB1 RID: 20145
		private int _hasBits0;

		// Token: 0x04004EB2 RID: 20146
		public const int AccoundIdHighFieldNumber = 1;

		// Token: 0x04004EB3 RID: 20147
		private static readonly ulong AccoundIdHighDefaultValue = 0UL;

		// Token: 0x04004EB4 RID: 20148
		private ulong accoundIdHigh_;

		// Token: 0x04004EB5 RID: 20149
		public const int AccoundIdLowFieldNumber = 2;

		// Token: 0x04004EB6 RID: 20150
		private static readonly ulong AccoundIdLowDefaultValue = 0UL;

		// Token: 0x04004EB7 RID: 20151
		private ulong accoundIdLow_;

		// Token: 0x04004EB8 RID: 20152
		public const int GameAccountIdHighFieldNumber = 3;

		// Token: 0x04004EB9 RID: 20153
		private static readonly ulong GameAccountIdHighDefaultValue = 0UL;

		// Token: 0x04004EBA RID: 20154
		private ulong gameAccountIdHigh_;

		// Token: 0x04004EBB RID: 20155
		public const int GameAccountIdLowFieldNumber = 4;

		// Token: 0x04004EBC RID: 20156
		private static readonly ulong GameAccountIdLowDefaultValue = 0UL;

		// Token: 0x04004EBD RID: 20157
		private ulong gameAccountIdLow_;
	}
}

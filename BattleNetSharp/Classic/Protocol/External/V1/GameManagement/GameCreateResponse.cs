using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200078F RID: 1935
	public sealed class GameCreateResponse : IMessage<GameCreateResponse>, IMessage, IEquatable<GameCreateResponse>, IDeepCloneable<GameCreateResponse>, IBufferMessage
	{
		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600B163 RID: 45411 RVA: 0x002B2E54 File Offset: 0x002B1054
		[DebuggerNonUserCode]
		public static MessageParser<GameCreateResponse> Parser
		{
			get
			{
				return GameCreateResponse._parser;
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600B164 RID: 45412 RVA: 0x002B2E6C File Offset: 0x002B106C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600B165 RID: 45413 RVA: 0x002B2E90 File Offset: 0x002B1090
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCreateResponse.Descriptor;
			}
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x002B2EA7 File Offset: 0x002B10A7
		[DebuggerNonUserCode]
		public GameCreateResponse()
		{
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x002B2EB1 File Offset: 0x002B10B1
		[DebuggerNonUserCode]
		public GameCreateResponse(GameCreateResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.maxPlayers_ = other.maxPlayers_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x002B2EF0 File Offset: 0x002B10F0
		[DebuggerNonUserCode]
		public GameCreateResponse Clone()
		{
			return new GameCreateResponse(this);
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600B169 RID: 45417 RVA: 0x002B2F08 File Offset: 0x002B1108
		// (set) Token: 0x0600B16A RID: 45418 RVA: 0x002B2F39 File Offset: 0x002B1139
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
					idDefaultValue = GameCreateResponse.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600B16B RID: 45419 RVA: 0x002B2F54 File Offset: 0x002B1154
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x002B2F71 File Offset: 0x002B1171
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600B16D RID: 45421 RVA: 0x002B2F84 File Offset: 0x002B1184
		// (set) Token: 0x0600B16E RID: 45422 RVA: 0x002B2FB5 File Offset: 0x002B11B5
		[DebuggerNonUserCode]
		public uint MaxPlayers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint maxPlayersDefaultValue;
				if (flag)
				{
					maxPlayersDefaultValue = this.maxPlayers_;
				}
				else
				{
					maxPlayersDefaultValue = GameCreateResponse.MaxPlayersDefaultValue;
				}
				return maxPlayersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.maxPlayers_ = value;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600B16F RID: 45423 RVA: 0x002B2FD0 File Offset: 0x002B11D0
		[DebuggerNonUserCode]
		public bool HasMaxPlayers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x002B2FED File Offset: 0x002B11ED
		[DebuggerNonUserCode]
		public void ClearMaxPlayers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x002B3000 File Offset: 0x002B1200
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCreateResponse);
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x002B3020 File Offset: 0x002B1220
		[DebuggerNonUserCode]
		public bool Equals(GameCreateResponse other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxPlayers != other.MaxPlayers;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x002B3094 File Offset: 0x002B1294
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num ^= this.MaxPlayers.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x002B3100 File Offset: 0x002B1300
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x002B3118 File Offset: 0x002B1318
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x002B3124 File Offset: 0x002B1324
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxPlayers);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x002B3194 File Offset: 0x002B1394
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasMaxPlayers = this.HasMaxPlayers;
			if (hasMaxPlayers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxPlayers);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x002B3200 File Offset: 0x002B1400
		[DebuggerNonUserCode]
		public void MergeFrom(GameCreateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasMaxPlayers = other.HasMaxPlayers;
				if (hasMaxPlayers)
				{
					this.MaxPlayers = other.MaxPlayers;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x002B3262 File Offset: 0x002B1462
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x002B3270 File Offset: 0x002B1470
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxPlayers = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005003 RID: 20483
		private static readonly MessageParser<GameCreateResponse> _parser = new MessageParser<GameCreateResponse>(() => new GameCreateResponse());

		// Token: 0x04005004 RID: 20484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005005 RID: 20485
		private int _hasBits0;

		// Token: 0x04005006 RID: 20486
		public const int IdFieldNumber = 1;

		// Token: 0x04005007 RID: 20487
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04005008 RID: 20488
		private uint id_;

		// Token: 0x04005009 RID: 20489
		public const int MaxPlayersFieldNumber = 2;

		// Token: 0x0400500A RID: 20490
		private static readonly uint MaxPlayersDefaultValue = 0U;

		// Token: 0x0400500B RID: 20491
		private uint maxPlayers_;
	}
}

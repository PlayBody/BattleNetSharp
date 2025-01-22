using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V2
{
	// Token: 0x0200070E RID: 1806
	public sealed class GameAccountHandle : IMessage<GameAccountHandle>, IMessage, IEquatable<GameAccountHandle>, IDeepCloneable<GameAccountHandle>, IBufferMessage
	{
		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A599 RID: 42393 RVA: 0x00284D38 File Offset: 0x00282F38
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountHandle> Parser
		{
			get
			{
				return GameAccountHandle._parser;
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A59A RID: 42394 RVA: 0x00284D50 File Offset: 0x00282F50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameAccountHandleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A59B RID: 42395 RVA: 0x00284D74 File Offset: 0x00282F74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountHandle.Descriptor;
			}
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x00284D8B File Offset: 0x00282F8B
		[DebuggerNonUserCode]
		public GameAccountHandle()
		{
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x00284D98 File Offset: 0x00282F98
		[DebuggerNonUserCode]
		public GameAccountHandle(GameAccountHandle other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.titleId_ = other.titleId_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x00284DF0 File Offset: 0x00282FF0
		[DebuggerNonUserCode]
		public GameAccountHandle Clone()
		{
			return new GameAccountHandle(this);
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A59F RID: 42399 RVA: 0x00284E08 File Offset: 0x00283008
		// (set) Token: 0x0600A5A0 RID: 42400 RVA: 0x00284E39 File Offset: 0x00283039
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = GameAccountHandle.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A5A1 RID: 42401 RVA: 0x00284E54 File Offset: 0x00283054
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x00284E71 File Offset: 0x00283071
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A5A3 RID: 42403 RVA: 0x00284E84 File Offset: 0x00283084
		// (set) Token: 0x0600A5A4 RID: 42404 RVA: 0x00284EB5 File Offset: 0x002830B5
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = GameAccountHandle.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.titleId_ = value;
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A5A5 RID: 42405 RVA: 0x00284ED0 File Offset: 0x002830D0
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x00284EED File Offset: 0x002830ED
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A5A7 RID: 42407 RVA: 0x00284F00 File Offset: 0x00283100
		// (set) Token: 0x0600A5A8 RID: 42408 RVA: 0x00284F31 File Offset: 0x00283131
		[DebuggerNonUserCode]
		public uint Region
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint regionDefaultValue;
				if (flag)
				{
					regionDefaultValue = this.region_;
				}
				else
				{
					regionDefaultValue = GameAccountHandle.RegionDefaultValue;
				}
				return regionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.region_ = value;
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x00284F4C File Offset: 0x0028314C
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x00284F69 File Offset: 0x00283169
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x00284F7C File Offset: 0x0028317C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountHandle);
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x00284F9C File Offset: 0x0028319C
		[DebuggerNonUserCode]
		public bool Equals(GameAccountHandle other)
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
						bool flag5 = this.TitleId != other.TitleId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Region != other.Region;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x00285028 File Offset: 0x00283228
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x002850B4 File Offset: 0x002832B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x002850CC File Offset: 0x002832CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x002850D8 File Offset: 0x002832D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TitleId);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x00285168 File Offset: 0x00283368
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x002851F4 File Offset: 0x002833F4
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountHandle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x0028526F File Offset: 0x0028346F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x0028527C File Offset: 0x0028347C
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Region = input.ReadUInt32();
						}
					}
					else
					{
						this.TitleId = input.ReadUInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A7B RID: 19067
		private static readonly MessageParser<GameAccountHandle> _parser = new MessageParser<GameAccountHandle>(() => new GameAccountHandle());

		// Token: 0x04004A7C RID: 19068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A7D RID: 19069
		private int _hasBits0;

		// Token: 0x04004A7E RID: 19070
		public const int IdFieldNumber = 1;

		// Token: 0x04004A7F RID: 19071
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04004A80 RID: 19072
		private ulong id_;

		// Token: 0x04004A81 RID: 19073
		public const int TitleIdFieldNumber = 2;

		// Token: 0x04004A82 RID: 19074
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x04004A83 RID: 19075
		private uint titleId_;

		// Token: 0x04004A84 RID: 19076
		public const int RegionFieldNumber = 3;

		// Token: 0x04004A85 RID: 19077
		private static readonly uint RegionDefaultValue = 0U;

		// Token: 0x04004A86 RID: 19078
		private uint region_;
	}
}

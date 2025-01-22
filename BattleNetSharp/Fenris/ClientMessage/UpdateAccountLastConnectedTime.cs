using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x020002A3 RID: 675
	public sealed class UpdateAccountLastConnectedTime : IMessage<UpdateAccountLastConnectedTime>, IMessage, IEquatable<UpdateAccountLastConnectedTime>, IDeepCloneable<UpdateAccountLastConnectedTime>, IBufferMessage
	{
		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x001102BC File Offset: 0x0010E4BC
		[DebuggerNonUserCode]
		public static MessageParser<UpdateAccountLastConnectedTime> Parser
		{
			get
			{
				return UpdateAccountLastConnectedTime._parser;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x001102D4 File Offset: 0x0010E4D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[147];
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x001102FC File Offset: 0x0010E4FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateAccountLastConnectedTime.Descriptor;
			}
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00110313 File Offset: 0x0010E513
		[DebuggerNonUserCode]
		public UpdateAccountLastConnectedTime()
		{
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0011031D File Offset: 0x0010E51D
		[DebuggerNonUserCode]
		public UpdateAccountLastConnectedTime(UpdateAccountLastConnectedTime other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this.lastConnectedTime_ = other.lastConnectedTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x0011035C File Offset: 0x0010E55C
		[DebuggerNonUserCode]
		public UpdateAccountLastConnectedTime Clone()
		{
			return new UpdateAccountLastConnectedTime(this);
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x00110374 File Offset: 0x0010E574
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x001103A5 File Offset: 0x0010E5A5
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = UpdateAccountLastConnectedTime.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001103C0 File Offset: 0x0010E5C0
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x001103DD File Offset: 0x0010E5DD
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x001103F0 File Offset: 0x0010E5F0
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x00110421 File Offset: 0x0010E621
		[DebuggerNonUserCode]
		public ulong LastConnectedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong lastConnectedTimeDefaultValue;
				if (flag)
				{
					lastConnectedTimeDefaultValue = this.lastConnectedTime_;
				}
				else
				{
					lastConnectedTimeDefaultValue = UpdateAccountLastConnectedTime.LastConnectedTimeDefaultValue;
				}
				return lastConnectedTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.lastConnectedTime_ = value;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x0011043C File Offset: 0x0010E63C
		[DebuggerNonUserCode]
		public bool HasLastConnectedTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x00110459 File Offset: 0x0010E659
		[DebuggerNonUserCode]
		public void ClearLastConnectedTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x0011046C File Offset: 0x0010E66C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateAccountLastConnectedTime);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x0011048C File Offset: 0x0010E68C
		[DebuggerNonUserCode]
		public bool Equals(UpdateAccountLastConnectedTime other)
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
					bool flag4 = this.TargetGameAccountId != other.TargetGameAccountId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LastConnectedTime != other.LastConnectedTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x00110500 File Offset: 0x0010E700
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				num ^= this.LastConnectedTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00110570 File Offset: 0x0010E770
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x00110588 File Offset: 0x0010E788
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00110594 File Offset: 0x0010E794
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.LastConnectedTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x00110604 File Offset: 0x0010E804
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool hasLastConnectedTime = this.HasLastConnectedTime;
			if (hasLastConnectedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastConnectedTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x00110670 File Offset: 0x0010E870
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateAccountLastConnectedTime other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				bool hasLastConnectedTime = other.HasLastConnectedTime;
				if (hasLastConnectedTime)
				{
					this.LastConnectedTime = other.LastConnectedTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x001106D2 File Offset: 0x0010E8D2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x001106E0 File Offset: 0x0010E8E0
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
						this.LastConnectedTime = input.ReadUInt64();
					}
				}
				else
				{
					this.TargetGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F98 RID: 8088
		private static readonly MessageParser<UpdateAccountLastConnectedTime> _parser = new MessageParser<UpdateAccountLastConnectedTime>(() => new UpdateAccountLastConnectedTime());

		// Token: 0x04001F99 RID: 8089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F9A RID: 8090
		private int _hasBits0;

		// Token: 0x04001F9B RID: 8091
		public const int TargetGameAccountIdFieldNumber = 1;

		// Token: 0x04001F9C RID: 8092
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001F9D RID: 8093
		private uint targetGameAccountId_;

		// Token: 0x04001F9E RID: 8094
		public const int LastConnectedTimeFieldNumber = 2;

		// Token: 0x04001F9F RID: 8095
		private static readonly ulong LastConnectedTimeDefaultValue = 0UL;

		// Token: 0x04001FA0 RID: 8096
		private ulong lastConnectedTime_;
	}
}

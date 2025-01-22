using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E9 RID: 1769
	public sealed class ChannelDescription : IMessage<ChannelDescription>, IMessage, IEquatable<ChannelDescription>, IDeepCloneable<ChannelDescription>, IBufferMessage
	{
		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A310 RID: 41744 RVA: 0x0027C064 File Offset: 0x0027A264
		[DebuggerNonUserCode]
		public static MessageParser<ChannelDescription> Parser
		{
			get
			{
				return ChannelDescription._parser;
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A311 RID: 41745 RVA: 0x0027C07C File Offset: 0x0027A27C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A312 RID: 41746 RVA: 0x0027C0A0 File Offset: 0x0027A2A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelDescription.Descriptor;
			}
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x0027C0B7 File Offset: 0x0027A2B7
		[DebuggerNonUserCode]
		public ChannelDescription()
		{
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x0027C0C4 File Offset: 0x0027A2C4
		[DebuggerNonUserCode]
		public ChannelDescription(ChannelDescription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.currentMembers_ = other.currentMembers_;
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x0027C13C File Offset: 0x0027A33C
		[DebuggerNonUserCode]
		public ChannelDescription Clone()
		{
			return new ChannelDescription(this);
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A316 RID: 41750 RVA: 0x0027C154 File Offset: 0x0027A354
		// (set) Token: 0x0600A317 RID: 41751 RVA: 0x0027C16C File Offset: 0x0027A36C
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A318 RID: 41752 RVA: 0x0027C178 File Offset: 0x0027A378
		// (set) Token: 0x0600A319 RID: 41753 RVA: 0x0027C1A9 File Offset: 0x0027A3A9
		[DebuggerNonUserCode]
		public uint CurrentMembers
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint currentMembersDefaultValue;
				if (flag)
				{
					currentMembersDefaultValue = this.currentMembers_;
				}
				else
				{
					currentMembersDefaultValue = ChannelDescription.CurrentMembersDefaultValue;
				}
				return currentMembersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.currentMembers_ = value;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A31A RID: 41754 RVA: 0x0027C1C4 File Offset: 0x0027A3C4
		[DebuggerNonUserCode]
		public bool HasCurrentMembers
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x0027C1E1 File Offset: 0x0027A3E1
		[DebuggerNonUserCode]
		public void ClearCurrentMembers()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A31C RID: 41756 RVA: 0x0027C1F4 File Offset: 0x0027A3F4
		// (set) Token: 0x0600A31D RID: 41757 RVA: 0x0027C20C File Offset: 0x0027A40C
		[DebuggerNonUserCode]
		public ChannelState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x0027C218 File Offset: 0x0027A418
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelDescription);
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x0027C238 File Offset: 0x0027A438
		[DebuggerNonUserCode]
		public bool Equals(ChannelDescription other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.CurrentMembers != other.CurrentMembers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.State, other.State);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x0027C2CC File Offset: 0x0027A4CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasCurrentMembers = this.HasCurrentMembers;
			if (hasCurrentMembers)
			{
				num ^= this.CurrentMembers.GetHashCode();
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x0027C358 File Offset: 0x0027A558
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x0027C370 File Offset: 0x0027A570
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x0027C37C File Offset: 0x0027A57C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool hasCurrentMembers = this.HasCurrentMembers;
			if (hasCurrentMembers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.CurrentMembers);
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.State);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x0027C414 File Offset: 0x0027A614
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasCurrentMembers = this.HasCurrentMembers;
			if (hasCurrentMembers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentMembers);
			}
			bool flag2 = this.state_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x0027C4A4 File Offset: 0x0027A6A4
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasCurrentMembers = other.HasCurrentMembers;
				if (hasCurrentMembers)
				{
					this.CurrentMembers = other.CurrentMembers;
				}
				bool flag4 = other.state_ != null;
				if (flag4)
				{
					bool flag5 = this.state_ == null;
					if (flag5)
					{
						this.State = new ChannelState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x0027C56C File Offset: 0x0027A76C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x0027C578 File Offset: 0x0027A778
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.state_ == null;
							if (flag)
							{
								this.State = new ChannelState();
							}
							input.ReadMessage(this.State);
						}
					}
					else
					{
						this.CurrentMembers = input.ReadUInt32();
					}
				}
				else
				{
					bool flag2 = this.channelId_ == null;
					if (flag2)
					{
						this.ChannelId = new EntityId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x0400498A RID: 18826
		private static readonly MessageParser<ChannelDescription> _parser = new MessageParser<ChannelDescription>(() => new ChannelDescription());

		// Token: 0x0400498B RID: 18827
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400498C RID: 18828
		private int _hasBits0;

		// Token: 0x0400498D RID: 18829
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x0400498E RID: 18830
		private EntityId channelId_;

		// Token: 0x0400498F RID: 18831
		public const int CurrentMembersFieldNumber = 2;

		// Token: 0x04004990 RID: 18832
		private static readonly uint CurrentMembersDefaultValue = 0U;

		// Token: 0x04004991 RID: 18833
		private uint currentMembers_;

		// Token: 0x04004992 RID: 18834
		public const int StateFieldNumber = 3;

		// Token: 0x04004993 RID: 18835
		private ChannelState state_;
	}
}

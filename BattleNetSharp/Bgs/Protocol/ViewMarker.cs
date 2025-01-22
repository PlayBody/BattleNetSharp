using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x0200035E RID: 862
	public sealed class ViewMarker : IMessage<ViewMarker>, IMessage, IEquatable<ViewMarker>, IDeepCloneable<ViewMarker>, IBufferMessage
	{
		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06005918 RID: 22808 RVA: 0x001586F0 File Offset: 0x001568F0
		[DebuggerNonUserCode]
		public static MessageParser<ViewMarker> Parser
		{
			get
			{
				return ViewMarker._parser;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06005919 RID: 22809 RVA: 0x00158708 File Offset: 0x00156908
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EventViewTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x0600591A RID: 22810 RVA: 0x0015872C File Offset: 0x0015692C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ViewMarker.Descriptor;
			}
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00158743 File Offset: 0x00156943
		[DebuggerNonUserCode]
		public ViewMarker()
		{
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x0015874D File Offset: 0x0015694D
		[DebuggerNonUserCode]
		public ViewMarker(ViewMarker other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.lastReadTime_ = other.lastReadTime_;
			this.lastMessageTime_ = other.lastMessageTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x0015878C File Offset: 0x0015698C
		[DebuggerNonUserCode]
		public ViewMarker Clone()
		{
			return new ViewMarker(this);
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x001587A4 File Offset: 0x001569A4
		// (set) Token: 0x0600591F RID: 22815 RVA: 0x001587D5 File Offset: 0x001569D5
		[DebuggerNonUserCode]
		public ulong LastReadTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong lastReadTimeDefaultValue;
				if (flag)
				{
					lastReadTimeDefaultValue = this.lastReadTime_;
				}
				else
				{
					lastReadTimeDefaultValue = ViewMarker.LastReadTimeDefaultValue;
				}
				return lastReadTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.lastReadTime_ = value;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x001587F0 File Offset: 0x001569F0
		[DebuggerNonUserCode]
		public bool HasLastReadTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x0015880D File Offset: 0x00156A0D
		[DebuggerNonUserCode]
		public void ClearLastReadTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x00158820 File Offset: 0x00156A20
		// (set) Token: 0x06005923 RID: 22819 RVA: 0x00158851 File Offset: 0x00156A51
		[DebuggerNonUserCode]
		public ulong LastMessageTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong lastMessageTimeDefaultValue;
				if (flag)
				{
					lastMessageTimeDefaultValue = this.lastMessageTime_;
				}
				else
				{
					lastMessageTimeDefaultValue = ViewMarker.LastMessageTimeDefaultValue;
				}
				return lastMessageTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.lastMessageTime_ = value;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x0015886C File Offset: 0x00156A6C
		[DebuggerNonUserCode]
		public bool HasLastMessageTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00158889 File Offset: 0x00156A89
		[DebuggerNonUserCode]
		public void ClearLastMessageTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x0015889C File Offset: 0x00156A9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ViewMarker);
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x001588BC File Offset: 0x00156ABC
		[DebuggerNonUserCode]
		public bool Equals(ViewMarker other)
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
					bool flag4 = this.LastReadTime != other.LastReadTime;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LastMessageTime != other.LastMessageTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00158930 File Offset: 0x00156B30
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLastReadTime = this.HasLastReadTime;
			if (hasLastReadTime)
			{
				num ^= this.LastReadTime.GetHashCode();
			}
			bool hasLastMessageTime = this.HasLastMessageTime;
			if (hasLastMessageTime)
			{
				num ^= this.LastMessageTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x0015899C File Offset: 0x00156B9C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x001589B4 File Offset: 0x00156BB4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x001589C0 File Offset: 0x00156BC0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLastReadTime = this.HasLastReadTime;
			if (hasLastReadTime)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.LastReadTime);
			}
			bool hasLastMessageTime = this.HasLastMessageTime;
			if (hasLastMessageTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.LastMessageTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00158A30 File Offset: 0x00156C30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLastReadTime = this.HasLastReadTime;
			if (hasLastReadTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastReadTime);
			}
			bool hasLastMessageTime = this.HasLastMessageTime;
			if (hasLastMessageTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastMessageTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x00158A9C File Offset: 0x00156C9C
		[DebuggerNonUserCode]
		public void MergeFrom(ViewMarker other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLastReadTime = other.HasLastReadTime;
				if (hasLastReadTime)
				{
					this.LastReadTime = other.LastReadTime;
				}
				bool hasLastMessageTime = other.HasLastMessageTime;
				if (hasLastMessageTime)
				{
					this.LastMessageTime = other.LastMessageTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00158AFE File Offset: 0x00156CFE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00158B0C File Offset: 0x00156D0C
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
						this.LastMessageTime = input.ReadUInt64();
					}
				}
				else
				{
					this.LastReadTime = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040028A1 RID: 10401
		private static readonly MessageParser<ViewMarker> _parser = new MessageParser<ViewMarker>(() => new ViewMarker());

		// Token: 0x040028A2 RID: 10402
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A3 RID: 10403
		private int _hasBits0;

		// Token: 0x040028A4 RID: 10404
		public const int LastReadTimeFieldNumber = 1;

		// Token: 0x040028A5 RID: 10405
		private static readonly ulong LastReadTimeDefaultValue = 0UL;

		// Token: 0x040028A6 RID: 10406
		private ulong lastReadTime_;

		// Token: 0x040028A7 RID: 10407
		public const int LastMessageTimeFieldNumber = 2;

		// Token: 0x040028A8 RID: 10408
		private static readonly ulong LastMessageTimeDefaultValue = 0UL;

		// Token: 0x040028A9 RID: 10409
		private ulong lastMessageTime_;
	}
}

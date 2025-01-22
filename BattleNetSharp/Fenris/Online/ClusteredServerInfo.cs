using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000150 RID: 336
	public sealed class ClusteredServerInfo : IMessage<ClusteredServerInfo>, IMessage, IEquatable<ClusteredServerInfo>, IDeepCloneable<ClusteredServerInfo>, IBufferMessage
	{
		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00087484 File Offset: 0x00085684
		[DebuggerNonUserCode]
		public static MessageParser<ClusteredServerInfo> Parser
		{
			get
			{
				return ClusteredServerInfo._parser;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0008749C File Offset: 0x0008569C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000874C0 File Offset: 0x000856C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClusteredServerInfo.Descriptor;
			}
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000874D7 File Offset: 0x000856D7
		[DebuggerNonUserCode]
		public ClusteredServerInfo()
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000874E4 File Offset: 0x000856E4
		[DebuggerNonUserCode]
		public ClusteredServerInfo(ClusteredServerInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.guid_ = other.guid_;
			this.epochTime_ = other.epochTime_;
			this.messageQueue_ = other.messageQueue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0008753C File Offset: 0x0008573C
		[DebuggerNonUserCode]
		public ClusteredServerInfo Clone()
		{
			return new ClusteredServerInfo(this);
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00087554 File Offset: 0x00085754
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00087585 File Offset: 0x00085785
		[DebuggerNonUserCode]
		public ulong Guid
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong guidDefaultValue;
				if (flag)
				{
					guidDefaultValue = this.guid_;
				}
				else
				{
					guidDefaultValue = ClusteredServerInfo.GuidDefaultValue;
				}
				return guidDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.guid_ = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000875A0 File Offset: 0x000857A0
		[DebuggerNonUserCode]
		public bool HasGuid
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000875BD File Offset: 0x000857BD
		[DebuggerNonUserCode]
		public void ClearGuid()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000875D0 File Offset: 0x000857D0
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00087601 File Offset: 0x00085801
		[DebuggerNonUserCode]
		public ulong EpochTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong epochTimeDefaultValue;
				if (flag)
				{
					epochTimeDefaultValue = this.epochTime_;
				}
				else
				{
					epochTimeDefaultValue = ClusteredServerInfo.EpochTimeDefaultValue;
				}
				return epochTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.epochTime_ = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0008761C File Offset: 0x0008581C
		[DebuggerNonUserCode]
		public bool HasEpochTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00087639 File Offset: 0x00085839
		[DebuggerNonUserCode]
		public void ClearEpochTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0008764C File Offset: 0x0008584C
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0008766D File Offset: 0x0008586D
		[DebuggerNonUserCode]
		public string MessageQueue
		{
			get
			{
				return this.messageQueue_ ?? ClusteredServerInfo.MessageQueueDefaultValue;
			}
			set
			{
				this.messageQueue_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00087684 File Offset: 0x00085884
		[DebuggerNonUserCode]
		public bool HasMessageQueue
		{
			get
			{
				return this.messageQueue_ != null;
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0008769F File Offset: 0x0008589F
		[DebuggerNonUserCode]
		public void ClearMessageQueue()
		{
			this.messageQueue_ = null;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x000876AC File Offset: 0x000858AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClusteredServerInfo);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x000876CC File Offset: 0x000858CC
		[DebuggerNonUserCode]
		public bool Equals(ClusteredServerInfo other)
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
					bool flag4 = this.Guid != other.Guid;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EpochTime != other.EpochTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MessageQueue != other.MessageQueue;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00087758 File Offset: 0x00085958
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGuid = this.HasGuid;
			if (hasGuid)
			{
				num ^= this.Guid.GetHashCode();
			}
			bool hasEpochTime = this.HasEpochTime;
			if (hasEpochTime)
			{
				num ^= this.EpochTime.GetHashCode();
			}
			bool hasMessageQueue = this.HasMessageQueue;
			if (hasMessageQueue)
			{
				num ^= this.MessageQueue.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000877E0 File Offset: 0x000859E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000877F8 File Offset: 0x000859F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00087804 File Offset: 0x00085A04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGuid = this.HasGuid;
			if (hasGuid)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Guid);
			}
			bool hasEpochTime = this.HasEpochTime;
			if (hasEpochTime)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(this.EpochTime);
			}
			bool hasMessageQueue = this.HasMessageQueue;
			if (hasMessageQueue)
			{
				output.WriteRawTag(26);
				output.WriteString(this.MessageQueue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00087894 File Offset: 0x00085A94
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGuid = this.HasGuid;
			if (hasGuid)
			{
				num += 9;
			}
			bool hasEpochTime = this.HasEpochTime;
			if (hasEpochTime)
			{
				num += 9;
			}
			bool hasMessageQueue = this.HasMessageQueue;
			if (hasMessageQueue)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MessageQueue);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00087908 File Offset: 0x00085B08
		[DebuggerNonUserCode]
		public void MergeFrom(ClusteredServerInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGuid = other.HasGuid;
				if (hasGuid)
				{
					this.Guid = other.Guid;
				}
				bool hasEpochTime = other.HasEpochTime;
				if (hasEpochTime)
				{
					this.EpochTime = other.EpochTime;
				}
				bool hasMessageQueue = other.HasMessageQueue;
				if (hasMessageQueue)
				{
					this.MessageQueue = other.MessageQueue;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00087983 File Offset: 0x00085B83
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00087990 File Offset: 0x00085B90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 9U)
				{
					if (num3 != 17U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MessageQueue = input.ReadString();
						}
					}
					else
					{
						this.EpochTime = input.ReadFixed64();
					}
				}
				else
				{
					this.Guid = input.ReadFixed64();
				}
			}
		}

		// Token: 0x04000F51 RID: 3921
		private static readonly MessageParser<ClusteredServerInfo> _parser = new MessageParser<ClusteredServerInfo>(() => new ClusteredServerInfo());

		// Token: 0x04000F52 RID: 3922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F53 RID: 3923
		private int _hasBits0;

		// Token: 0x04000F54 RID: 3924
		public const int GuidFieldNumber = 1;

		// Token: 0x04000F55 RID: 3925
		private static readonly ulong GuidDefaultValue = 0UL;

		// Token: 0x04000F56 RID: 3926
		private ulong guid_;

		// Token: 0x04000F57 RID: 3927
		public const int EpochTimeFieldNumber = 2;

		// Token: 0x04000F58 RID: 3928
		private static readonly ulong EpochTimeDefaultValue = 0UL;

		// Token: 0x04000F59 RID: 3929
		private ulong epochTime_;

		// Token: 0x04000F5A RID: 3930
		public const int MessageQueueFieldNumber = 3;

		// Token: 0x04000F5B RID: 3931
		private static readonly string MessageQueueDefaultValue = "";

		// Token: 0x04000F5C RID: 3932
		private string messageQueue_;
	}
}

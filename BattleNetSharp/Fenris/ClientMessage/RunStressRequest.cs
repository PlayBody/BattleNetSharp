using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000275 RID: 629
	public sealed class RunStressRequest : IMessage<RunStressRequest>, IMessage, IEquatable<RunStressRequest>, IDeepCloneable<RunStressRequest>, IBufferMessage
	{
		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x00104AEC File Offset: 0x00102CEC
		[DebuggerNonUserCode]
		public static MessageParser<RunStressRequest> Parser
		{
			get
			{
				return RunStressRequest._parser;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x00104B04 File Offset: 0x00102D04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[101];
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x00104B28 File Offset: 0x00102D28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunStressRequest.Descriptor;
			}
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00104B3F File Offset: 0x00102D3F
		[DebuggerNonUserCode]
		public RunStressRequest()
		{
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x00104B49 File Offset: 0x00102D49
		[DebuggerNonUserCode]
		public RunStressRequest(RunStressRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.messageCount_ = other.messageCount_;
			this.stressType_ = other.stressType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x00104B88 File Offset: 0x00102D88
		[DebuggerNonUserCode]
		public RunStressRequest Clone()
		{
			return new RunStressRequest(this);
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x00104BA0 File Offset: 0x00102DA0
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x00104BD1 File Offset: 0x00102DD1
		[DebuggerNonUserCode]
		public uint MessageCount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint messageCountDefaultValue;
				if (flag)
				{
					messageCountDefaultValue = this.messageCount_;
				}
				else
				{
					messageCountDefaultValue = RunStressRequest.MessageCountDefaultValue;
				}
				return messageCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.messageCount_ = value;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x00104BEC File Offset: 0x00102DEC
		[DebuggerNonUserCode]
		public bool HasMessageCount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00104C09 File Offset: 0x00102E09
		[DebuggerNonUserCode]
		public void ClearMessageCount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x00104C1C File Offset: 0x00102E1C
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x00104C4D File Offset: 0x00102E4D
		[DebuggerNonUserCode]
		public RunStressRequest.Types.StressType StressType
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				RunStressRequest.Types.StressType stressTypeDefaultValue;
				if (flag)
				{
					stressTypeDefaultValue = this.stressType_;
				}
				else
				{
					stressTypeDefaultValue = RunStressRequest.StressTypeDefaultValue;
				}
				return stressTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.stressType_ = value;
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00104C68 File Offset: 0x00102E68
		[DebuggerNonUserCode]
		public bool HasStressType
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00104C85 File Offset: 0x00102E85
		[DebuggerNonUserCode]
		public void ClearStressType()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00104C98 File Offset: 0x00102E98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunStressRequest);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x00104CB8 File Offset: 0x00102EB8
		[DebuggerNonUserCode]
		public bool Equals(RunStressRequest other)
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
					bool flag4 = this.MessageCount != other.MessageCount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.StressType != other.StressType;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x00104D2C File Offset: 0x00102F2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMessageCount = this.HasMessageCount;
			if (hasMessageCount)
			{
				num ^= this.MessageCount.GetHashCode();
			}
			bool hasStressType = this.HasStressType;
			if (hasStressType)
			{
				num ^= this.StressType.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004368 RID: 17256 RVA: 0x00104DA0 File Offset: 0x00102FA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x00104DB8 File Offset: 0x00102FB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x00104DC4 File Offset: 0x00102FC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMessageCount = this.HasMessageCount;
			if (hasMessageCount)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MessageCount);
			}
			bool hasStressType = this.HasStressType;
			if (hasStressType)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.StressType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x00104E34 File Offset: 0x00103034
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMessageCount = this.HasMessageCount;
			if (hasMessageCount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MessageCount);
			}
			bool hasStressType = this.HasStressType;
			if (hasStressType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.StressType);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x00104EA0 File Offset: 0x001030A0
		[DebuggerNonUserCode]
		public void MergeFrom(RunStressRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMessageCount = other.HasMessageCount;
				if (hasMessageCount)
				{
					this.MessageCount = other.MessageCount;
				}
				bool hasStressType = other.HasStressType;
				if (hasStressType)
				{
					this.StressType = other.StressType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00104F02 File Offset: 0x00103102
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00104F10 File Offset: 0x00103110
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
						this.StressType = (RunStressRequest.Types.StressType)input.ReadEnum();
					}
				}
				else
				{
					this.MessageCount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001E56 RID: 7766
		private static readonly MessageParser<RunStressRequest> _parser = new MessageParser<RunStressRequest>(() => new RunStressRequest());

		// Token: 0x04001E57 RID: 7767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E58 RID: 7768
		private int _hasBits0;

		// Token: 0x04001E59 RID: 7769
		public const int MessageCountFieldNumber = 1;

		// Token: 0x04001E5A RID: 7770
		private static readonly uint MessageCountDefaultValue = 0U;

		// Token: 0x04001E5B RID: 7771
		private uint messageCount_;

		// Token: 0x04001E5C RID: 7772
		public const int StressTypeFieldNumber = 2;

		// Token: 0x04001E5D RID: 7773
		private static readonly RunStressRequest.Types.StressType StressTypeDefaultValue = RunStressRequest.Types.StressType.Rabbit;

		// Token: 0x04001E5E RID: 7774
		private RunStressRequest.Types.StressType stressType_;

		// Token: 0x02000D8B RID: 3467
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001482 RID: 5250
			public enum StressType
			{
				// Token: 0x0400A41E RID: 42014
				[OriginalName("STRESS_TYPE_RABBIT")]
				Rabbit,
				// Token: 0x0400A41F RID: 42015
				[OriginalName("STRESS_TYPE_CASSANDRA")]
				Cassandra
			}
		}
	}
}

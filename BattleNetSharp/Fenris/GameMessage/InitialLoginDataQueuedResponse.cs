using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001BD RID: 445
	public sealed class InitialLoginDataQueuedResponse : IMessage<InitialLoginDataQueuedResponse>, IMessage, IEquatable<InitialLoginDataQueuedResponse>, IDeepCloneable<InitialLoginDataQueuedResponse>, IBufferMessage
	{
		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000B7CDC File Offset: 0x000B5EDC
		[DebuggerNonUserCode]
		public static MessageParser<InitialLoginDataQueuedResponse> Parser
		{
			get
			{
				return InitialLoginDataQueuedResponse._parser;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x000B7CF4 File Offset: 0x000B5EF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000B7D18 File Offset: 0x000B5F18
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitialLoginDataQueuedResponse.Descriptor;
			}
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000B7D2F File Offset: 0x000B5F2F
		[DebuggerNonUserCode]
		public InitialLoginDataQueuedResponse()
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000B7D39 File Offset: 0x000B5F39
		[DebuggerNonUserCode]
		public InitialLoginDataQueuedResponse(InitialLoginDataQueuedResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.serviceId_ = other.serviceId_;
			this.timeoutTickInterval_ = other.timeoutTickInterval_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000B7D78 File Offset: 0x000B5F78
		[DebuggerNonUserCode]
		public InitialLoginDataQueuedResponse Clone()
		{
			return new InitialLoginDataQueuedResponse(this);
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000B7D90 File Offset: 0x000B5F90
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x000B7DC1 File Offset: 0x000B5FC1
		[DebuggerNonUserCode]
		public uint ServiceId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint serviceIdDefaultValue;
				if (flag)
				{
					serviceIdDefaultValue = this.serviceId_;
				}
				else
				{
					serviceIdDefaultValue = InitialLoginDataQueuedResponse.ServiceIdDefaultValue;
				}
				return serviceIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.serviceId_ = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002E9C RID: 11932 RVA: 0x000B7DDC File Offset: 0x000B5FDC
		[DebuggerNonUserCode]
		public bool HasServiceId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000B7DF9 File Offset: 0x000B5FF9
		[DebuggerNonUserCode]
		public void ClearServiceId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000B7E0C File Offset: 0x000B600C
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x000B7E3D File Offset: 0x000B603D
		[DebuggerNonUserCode]
		public uint TimeoutTickInterval
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint timeoutTickIntervalDefaultValue;
				if (flag)
				{
					timeoutTickIntervalDefaultValue = this.timeoutTickInterval_;
				}
				else
				{
					timeoutTickIntervalDefaultValue = InitialLoginDataQueuedResponse.TimeoutTickIntervalDefaultValue;
				}
				return timeoutTickIntervalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.timeoutTickInterval_ = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000B7E58 File Offset: 0x000B6058
		[DebuggerNonUserCode]
		public bool HasTimeoutTickInterval
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000B7E75 File Offset: 0x000B6075
		[DebuggerNonUserCode]
		public void ClearTimeoutTickInterval()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000B7E88 File Offset: 0x000B6088
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitialLoginDataQueuedResponse);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000B7EA8 File Offset: 0x000B60A8
		[DebuggerNonUserCode]
		public bool Equals(InitialLoginDataQueuedResponse other)
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
					bool flag4 = this.ServiceId != other.ServiceId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TimeoutTickInterval != other.TimeoutTickInterval;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000B7F1C File Offset: 0x000B611C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				num ^= this.ServiceId.GetHashCode();
			}
			bool hasTimeoutTickInterval = this.HasTimeoutTickInterval;
			if (hasTimeoutTickInterval)
			{
				num ^= this.TimeoutTickInterval.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000B7F88 File Offset: 0x000B6188
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000B7FA0 File Offset: 0x000B61A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000B7FAC File Offset: 0x000B61AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ServiceId);
			}
			bool hasTimeoutTickInterval = this.HasTimeoutTickInterval;
			if (hasTimeoutTickInterval)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TimeoutTickInterval);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000B801C File Offset: 0x000B621C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasServiceId = this.HasServiceId;
			if (hasServiceId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceId);
			}
			bool hasTimeoutTickInterval = this.HasTimeoutTickInterval;
			if (hasTimeoutTickInterval)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TimeoutTickInterval);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000B8088 File Offset: 0x000B6288
		[DebuggerNonUserCode]
		public void MergeFrom(InitialLoginDataQueuedResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasServiceId = other.HasServiceId;
				if (hasServiceId)
				{
					this.ServiceId = other.ServiceId;
				}
				bool hasTimeoutTickInterval = other.HasTimeoutTickInterval;
				if (hasTimeoutTickInterval)
				{
					this.TimeoutTickInterval = other.TimeoutTickInterval;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000B80EA File Offset: 0x000B62EA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000B80F8 File Offset: 0x000B62F8
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
						this.TimeoutTickInterval = input.ReadUInt32();
					}
				}
				else
				{
					this.ServiceId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001503 RID: 5379
		private static readonly MessageParser<InitialLoginDataQueuedResponse> _parser = new MessageParser<InitialLoginDataQueuedResponse>(() => new InitialLoginDataQueuedResponse());

		// Token: 0x04001504 RID: 5380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001505 RID: 5381
		private int _hasBits0;

		// Token: 0x04001506 RID: 5382
		public const int ServiceIdFieldNumber = 1;

		// Token: 0x04001507 RID: 5383
		private static readonly uint ServiceIdDefaultValue = 0U;

		// Token: 0x04001508 RID: 5384
		private uint serviceId_;

		// Token: 0x04001509 RID: 5385
		public const int TimeoutTickIntervalFieldNumber = 2;

		// Token: 0x0400150A RID: 5386
		private static readonly uint TimeoutTickIntervalDefaultValue = 0U;

		// Token: 0x0400150B RID: 5387
		private uint timeoutTickInterval_;
	}
}

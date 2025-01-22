using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060D RID: 1549
	public sealed class LogonQueueUpdateRequest : IMessage<LogonQueueUpdateRequest>, IMessage, IEquatable<LogonQueueUpdateRequest>, IDeepCloneable<LogonQueueUpdateRequest>, IBufferMessage
	{
		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x00232DA8 File Offset: 0x00230FA8
		[DebuggerNonUserCode]
		public static MessageParser<LogonQueueUpdateRequest> Parser
		{
			get
			{
				return LogonQueueUpdateRequest._parser;
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x06009113 RID: 37139 RVA: 0x00232DC0 File Offset: 0x00230FC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x06009114 RID: 37140 RVA: 0x00232DE4 File Offset: 0x00230FE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogonQueueUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x00232DFB File Offset: 0x00230FFB
		[DebuggerNonUserCode]
		public LogonQueueUpdateRequest()
		{
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x00232E08 File Offset: 0x00231008
		[DebuggerNonUserCode]
		public LogonQueueUpdateRequest(LogonQueueUpdateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.position_ = other.position_;
			this.estimatedTime_ = other.estimatedTime_;
			this.etaDeviationInSec_ = other.etaDeviationInSec_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x00232E60 File Offset: 0x00231060
		[DebuggerNonUserCode]
		public LogonQueueUpdateRequest Clone()
		{
			return new LogonQueueUpdateRequest(this);
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x06009118 RID: 37144 RVA: 0x00232E78 File Offset: 0x00231078
		// (set) Token: 0x06009119 RID: 37145 RVA: 0x00232EA9 File Offset: 0x002310A9
		[DebuggerNonUserCode]
		public uint Position
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint positionDefaultValue;
				if (flag)
				{
					positionDefaultValue = this.position_;
				}
				else
				{
					positionDefaultValue = LogonQueueUpdateRequest.PositionDefaultValue;
				}
				return positionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.position_ = value;
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x00232EC4 File Offset: 0x002310C4
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600911B RID: 37147 RVA: 0x00232EE1 File Offset: 0x002310E1
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600911C RID: 37148 RVA: 0x00232EF4 File Offset: 0x002310F4
		// (set) Token: 0x0600911D RID: 37149 RVA: 0x00232F25 File Offset: 0x00231125
		[DebuggerNonUserCode]
		public ulong EstimatedTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong estimatedTimeDefaultValue;
				if (flag)
				{
					estimatedTimeDefaultValue = this.estimatedTime_;
				}
				else
				{
					estimatedTimeDefaultValue = LogonQueueUpdateRequest.EstimatedTimeDefaultValue;
				}
				return estimatedTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.estimatedTime_ = value;
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600911E RID: 37150 RVA: 0x00232F40 File Offset: 0x00231140
		[DebuggerNonUserCode]
		public bool HasEstimatedTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x00232F5D File Offset: 0x0023115D
		[DebuggerNonUserCode]
		public void ClearEstimatedTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x00232F70 File Offset: 0x00231170
		// (set) Token: 0x06009121 RID: 37153 RVA: 0x00232FA1 File Offset: 0x002311A1
		[DebuggerNonUserCode]
		public ulong EtaDeviationInSec
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong etaDeviationInSecDefaultValue;
				if (flag)
				{
					etaDeviationInSecDefaultValue = this.etaDeviationInSec_;
				}
				else
				{
					etaDeviationInSecDefaultValue = LogonQueueUpdateRequest.EtaDeviationInSecDefaultValue;
				}
				return etaDeviationInSecDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.etaDeviationInSec_ = value;
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x06009122 RID: 37154 RVA: 0x00232FBC File Offset: 0x002311BC
		[DebuggerNonUserCode]
		public bool HasEtaDeviationInSec
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x00232FD9 File Offset: 0x002311D9
		[DebuggerNonUserCode]
		public void ClearEtaDeviationInSec()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06009124 RID: 37156 RVA: 0x00232FEC File Offset: 0x002311EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogonQueueUpdateRequest);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x0023300C File Offset: 0x0023120C
		[DebuggerNonUserCode]
		public bool Equals(LogonQueueUpdateRequest other)
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
					bool flag4 = this.Position != other.Position;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EstimatedTime != other.EstimatedTime;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EtaDeviationInSec != other.EtaDeviationInSec;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x00233098 File Offset: 0x00231298
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool hasEstimatedTime = this.HasEstimatedTime;
			if (hasEstimatedTime)
			{
				num ^= this.EstimatedTime.GetHashCode();
			}
			bool hasEtaDeviationInSec = this.HasEtaDeviationInSec;
			if (hasEtaDeviationInSec)
			{
				num ^= this.EtaDeviationInSec.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x00233124 File Offset: 0x00231324
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x0023313C File Offset: 0x0023133C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009129 RID: 37161 RVA: 0x00233148 File Offset: 0x00231348
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Position);
			}
			bool hasEstimatedTime = this.HasEstimatedTime;
			if (hasEstimatedTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.EstimatedTime);
			}
			bool hasEtaDeviationInSec = this.HasEtaDeviationInSec;
			if (hasEtaDeviationInSec)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.EtaDeviationInSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x002331D8 File Offset: 0x002313D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Position);
			}
			bool hasEstimatedTime = this.HasEstimatedTime;
			if (hasEstimatedTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EstimatedTime);
			}
			bool hasEtaDeviationInSec = this.HasEtaDeviationInSec;
			if (hasEtaDeviationInSec)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EtaDeviationInSec);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600912B RID: 37163 RVA: 0x00233264 File Offset: 0x00231464
		[DebuggerNonUserCode]
		public void MergeFrom(LogonQueueUpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				bool hasEstimatedTime = other.HasEstimatedTime;
				if (hasEstimatedTime)
				{
					this.EstimatedTime = other.EstimatedTime;
				}
				bool hasEtaDeviationInSec = other.HasEtaDeviationInSec;
				if (hasEtaDeviationInSec)
				{
					this.EtaDeviationInSec = other.EtaDeviationInSec;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600912C RID: 37164 RVA: 0x002332DF File Offset: 0x002314DF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600912D RID: 37165 RVA: 0x002332EC File Offset: 0x002314EC
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
							this.EtaDeviationInSec = input.ReadUInt64();
						}
					}
					else
					{
						this.EstimatedTime = input.ReadUInt64();
					}
				}
				else
				{
					this.Position = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004183 RID: 16771
		private static readonly MessageParser<LogonQueueUpdateRequest> _parser = new MessageParser<LogonQueueUpdateRequest>(() => new LogonQueueUpdateRequest());

		// Token: 0x04004184 RID: 16772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004185 RID: 16773
		private int _hasBits0;

		// Token: 0x04004186 RID: 16774
		public const int PositionFieldNumber = 1;

		// Token: 0x04004187 RID: 16775
		private static readonly uint PositionDefaultValue = 0U;

		// Token: 0x04004188 RID: 16776
		private uint position_;

		// Token: 0x04004189 RID: 16777
		public const int EstimatedTimeFieldNumber = 2;

		// Token: 0x0400418A RID: 16778
		private static readonly ulong EstimatedTimeDefaultValue = 0UL;

		// Token: 0x0400418B RID: 16779
		private ulong estimatedTime_;

		// Token: 0x0400418C RID: 16780
		public const int EtaDeviationInSecFieldNumber = 3;

		// Token: 0x0400418D RID: 16781
		private static readonly ulong EtaDeviationInSecDefaultValue = 0UL;

		// Token: 0x0400418E RID: 16782
		private ulong etaDeviationInSec_;
	}
}

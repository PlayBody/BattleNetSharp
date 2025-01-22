using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000598 RID: 1432
	public sealed class SubscribeResult : IMessage<SubscribeResult>, IMessage, IEquatable<SubscribeResult>, IDeepCloneable<SubscribeResult>, IBufferMessage
	{
		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600889C RID: 34972 RVA: 0x00212A6C File Offset: 0x00210C6C
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResult> Parser
		{
			get
			{
				return SubscribeResult._parser;
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x00212A84 File Offset: 0x00210C84
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600889E RID: 34974 RVA: 0x00212AA8 File Offset: 0x00210CA8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResult.Descriptor;
			}
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x00212ABF File Offset: 0x00210CBF
		[DebuggerNonUserCode]
		public SubscribeResult()
		{
		}

		// Token: 0x060088A0 RID: 34976 RVA: 0x00212ACC File Offset: 0x00210CCC
		[DebuggerNonUserCode]
		public SubscribeResult(SubscribeResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x00212B28 File Offset: 0x00210D28
		[DebuggerNonUserCode]
		public SubscribeResult Clone()
		{
			return new SubscribeResult(this);
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x060088A2 RID: 34978 RVA: 0x00212B40 File Offset: 0x00210D40
		// (set) Token: 0x060088A3 RID: 34979 RVA: 0x00212B58 File Offset: 0x00210D58
		[DebuggerNonUserCode]
		public Target Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x060088A4 RID: 34980 RVA: 0x00212B64 File Offset: 0x00210D64
		// (set) Token: 0x060088A5 RID: 34981 RVA: 0x00212B95 File Offset: 0x00210D95
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = SubscribeResult.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x060088A6 RID: 34982 RVA: 0x00212BB0 File Offset: 0x00210DB0
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x00212BCD File Offset: 0x00210DCD
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x00212BE0 File Offset: 0x00210DE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResult);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x00212C00 File Offset: 0x00210E00
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResult other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Status != other.Status;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x00212C74 File Offset: 0x00210E74
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x00212CE0 File Offset: 0x00210EE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x00212CF8 File Offset: 0x00210EF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x00212D04 File Offset: 0x00210F04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Status);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x00212D78 File Offset: 0x00210F78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x00212DE8 File Offset: 0x00210FE8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new Target();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x00212E6D File Offset: 0x0021106D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x00212E78 File Offset: 0x00211078
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new Target();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003DD7 RID: 15831
		private static readonly MessageParser<SubscribeResult> _parser = new MessageParser<SubscribeResult>(() => new SubscribeResult());

		// Token: 0x04003DD8 RID: 15832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DD9 RID: 15833
		private int _hasBits0;

		// Token: 0x04003DDA RID: 15834
		public const int TargetFieldNumber = 1;

		// Token: 0x04003DDB RID: 15835
		private Target target_;

		// Token: 0x04003DDC RID: 15836
		public const int StatusFieldNumber = 2;

		// Token: 0x04003DDD RID: 15837
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x04003DDE RID: 15838
		private uint status_;
	}
}

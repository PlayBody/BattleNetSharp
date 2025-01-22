using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200027E RID: 638
	public sealed class ClanDethroneRequest : IMessage<ClanDethroneRequest>, IMessage, IEquatable<ClanDethroneRequest>, IDeepCloneable<ClanDethroneRequest>, IBufferMessage
	{
		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x00106F90 File Offset: 0x00105190
		[DebuggerNonUserCode]
		public static MessageParser<ClanDethroneRequest> Parser
		{
			get
			{
				return ClanDethroneRequest._parser;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x00106FA8 File Offset: 0x001051A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[110];
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600441A RID: 17434 RVA: 0x00106FCC File Offset: 0x001051CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanDethroneRequest.Descriptor;
			}
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00106FE3 File Offset: 0x001051E3
		[DebuggerNonUserCode]
		public ClanDethroneRequest()
		{
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00106FED File Offset: 0x001051ED
		[DebuggerNonUserCode]
		public ClanDethroneRequest(ClanDethroneRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x0010702C File Offset: 0x0010522C
		[DebuggerNonUserCode]
		public ClanDethroneRequest Clone()
		{
			return new ClanDethroneRequest(this);
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x0600441E RID: 17438 RVA: 0x00107044 File Offset: 0x00105244
		// (set) Token: 0x0600441F RID: 17439 RVA: 0x00107065 File Offset: 0x00105265
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ClanDethroneRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06004420 RID: 17440 RVA: 0x0010707C File Offset: 0x0010527C
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x00107097 File Offset: 0x00105297
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x001070A4 File Offset: 0x001052A4
		// (set) Token: 0x06004423 RID: 17443 RVA: 0x001070D5 File Offset: 0x001052D5
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
					targetGameAccountIdDefaultValue = ClanDethroneRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x001070F0 File Offset: 0x001052F0
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x0010710D File Offset: 0x0010530D
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00107120 File Offset: 0x00105320
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanDethroneRequest);
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00107140 File Offset: 0x00105340
		[DebuggerNonUserCode]
		public bool Equals(ClanDethroneRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.TargetGameAccountId != other.TargetGameAccountId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x001071B4 File Offset: 0x001053B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00107220 File Offset: 0x00105420
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x00107238 File Offset: 0x00105438
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x00107244 File Offset: 0x00105444
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x001072B4 File Offset: 0x001054B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00107320 File Offset: 0x00105520
		[DebuggerNonUserCode]
		public void MergeFrom(ClanDethroneRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00107382 File Offset: 0x00105582
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00107390 File Offset: 0x00105590
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
						this.TargetGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E98 RID: 7832
		private static readonly MessageParser<ClanDethroneRequest> _parser = new MessageParser<ClanDethroneRequest>(() => new ClanDethroneRequest());

		// Token: 0x04001E99 RID: 7833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E9A RID: 7834
		private int _hasBits0;

		// Token: 0x04001E9B RID: 7835
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E9C RID: 7836
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E9D RID: 7837
		private string clanId_;

		// Token: 0x04001E9E RID: 7838
		public const int TargetGameAccountIdFieldNumber = 2;

		// Token: 0x04001E9F RID: 7839
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001EA0 RID: 7840
		private uint targetGameAccountId_;
	}
}

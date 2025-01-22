using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000749 RID: 1865
	public sealed class CAIS : IMessage<CAIS>, IMessage, IEquatable<CAIS>, IDeepCloneable<CAIS>, IBufferMessage
	{
		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600ABA1 RID: 43937 RVA: 0x0029CB84 File Offset: 0x0029AD84
		[DebuggerNonUserCode]
		public static MessageParser<CAIS> Parser
		{
			get
			{
				return CAIS._parser;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x0029CB9C File Offset: 0x0029AD9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600ABA3 RID: 43939 RVA: 0x0029CBC0 File Offset: 0x0029ADC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CAIS.Descriptor;
			}
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x0029CBD7 File Offset: 0x0029ADD7
		[DebuggerNonUserCode]
		public CAIS()
		{
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x0029CBE4 File Offset: 0x0029ADE4
		[DebuggerNonUserCode]
		public CAIS(CAIS other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.playedMinutes_ = other.playedMinutes_;
			this.restedMinutes_ = other.restedMinutes_;
			this.lastHeardTime_ = other.lastHeardTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x0029CC3C File Offset: 0x0029AE3C
		[DebuggerNonUserCode]
		public CAIS Clone()
		{
			return new CAIS(this);
		}

		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600ABA7 RID: 43943 RVA: 0x0029CC54 File Offset: 0x0029AE54
		// (set) Token: 0x0600ABA8 RID: 43944 RVA: 0x0029CC85 File Offset: 0x0029AE85
		[DebuggerNonUserCode]
		public uint PlayedMinutes
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint playedMinutesDefaultValue;
				if (flag)
				{
					playedMinutesDefaultValue = this.playedMinutes_;
				}
				else
				{
					playedMinutesDefaultValue = CAIS.PlayedMinutesDefaultValue;
				}
				return playedMinutesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.playedMinutes_ = value;
			}
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x0029CCA0 File Offset: 0x0029AEA0
		[DebuggerNonUserCode]
		public bool HasPlayedMinutes
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x0029CCBD File Offset: 0x0029AEBD
		[DebuggerNonUserCode]
		public void ClearPlayedMinutes()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600ABAB RID: 43947 RVA: 0x0029CCD0 File Offset: 0x0029AED0
		// (set) Token: 0x0600ABAC RID: 43948 RVA: 0x0029CD01 File Offset: 0x0029AF01
		[DebuggerNonUserCode]
		public uint RestedMinutes
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint restedMinutesDefaultValue;
				if (flag)
				{
					restedMinutesDefaultValue = this.restedMinutes_;
				}
				else
				{
					restedMinutesDefaultValue = CAIS.RestedMinutesDefaultValue;
				}
				return restedMinutesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.restedMinutes_ = value;
			}
		}

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600ABAD RID: 43949 RVA: 0x0029CD1C File Offset: 0x0029AF1C
		[DebuggerNonUserCode]
		public bool HasRestedMinutes
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x0029CD39 File Offset: 0x0029AF39
		[DebuggerNonUserCode]
		public void ClearRestedMinutes()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600ABAF RID: 43951 RVA: 0x0029CD4C File Offset: 0x0029AF4C
		// (set) Token: 0x0600ABB0 RID: 43952 RVA: 0x0029CD7D File Offset: 0x0029AF7D
		[DebuggerNonUserCode]
		public ulong LastHeardTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong lastHeardTimeDefaultValue;
				if (flag)
				{
					lastHeardTimeDefaultValue = this.lastHeardTime_;
				}
				else
				{
					lastHeardTimeDefaultValue = CAIS.LastHeardTimeDefaultValue;
				}
				return lastHeardTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.lastHeardTime_ = value;
			}
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x0029CD98 File Offset: 0x0029AF98
		[DebuggerNonUserCode]
		public bool HasLastHeardTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0029CDB5 File Offset: 0x0029AFB5
		[DebuggerNonUserCode]
		public void ClearLastHeardTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x0029CDC8 File Offset: 0x0029AFC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CAIS);
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x0029CDE8 File Offset: 0x0029AFE8
		[DebuggerNonUserCode]
		public bool Equals(CAIS other)
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
					bool flag4 = this.PlayedMinutes != other.PlayedMinutes;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RestedMinutes != other.RestedMinutes;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.LastHeardTime != other.LastHeardTime;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x0029CE74 File Offset: 0x0029B074
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPlayedMinutes = this.HasPlayedMinutes;
			if (hasPlayedMinutes)
			{
				num ^= this.PlayedMinutes.GetHashCode();
			}
			bool hasRestedMinutes = this.HasRestedMinutes;
			if (hasRestedMinutes)
			{
				num ^= this.RestedMinutes.GetHashCode();
			}
			bool hasLastHeardTime = this.HasLastHeardTime;
			if (hasLastHeardTime)
			{
				num ^= this.LastHeardTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x0029CF00 File Offset: 0x0029B100
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x0029CF18 File Offset: 0x0029B118
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x0029CF24 File Offset: 0x0029B124
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPlayedMinutes = this.HasPlayedMinutes;
			if (hasPlayedMinutes)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PlayedMinutes);
			}
			bool hasRestedMinutes = this.HasRestedMinutes;
			if (hasRestedMinutes)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RestedMinutes);
			}
			bool hasLastHeardTime = this.HasLastHeardTime;
			if (hasLastHeardTime)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.LastHeardTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x0029CFB4 File Offset: 0x0029B1B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPlayedMinutes = this.HasPlayedMinutes;
			if (hasPlayedMinutes)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayedMinutes);
			}
			bool hasRestedMinutes = this.HasRestedMinutes;
			if (hasRestedMinutes)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RestedMinutes);
			}
			bool hasLastHeardTime = this.HasLastHeardTime;
			if (hasLastHeardTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.LastHeardTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x0029D040 File Offset: 0x0029B240
		[DebuggerNonUserCode]
		public void MergeFrom(CAIS other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPlayedMinutes = other.HasPlayedMinutes;
				if (hasPlayedMinutes)
				{
					this.PlayedMinutes = other.PlayedMinutes;
				}
				bool hasRestedMinutes = other.HasRestedMinutes;
				if (hasRestedMinutes)
				{
					this.RestedMinutes = other.RestedMinutes;
				}
				bool hasLastHeardTime = other.HasLastHeardTime;
				if (hasLastHeardTime)
				{
					this.LastHeardTime = other.LastHeardTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600ABBB RID: 43963 RVA: 0x0029D0BB File Offset: 0x0029B2BB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABBC RID: 43964 RVA: 0x0029D0C8 File Offset: 0x0029B2C8
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
							this.LastHeardTime = input.ReadUInt64();
						}
					}
					else
					{
						this.RestedMinutes = input.ReadUInt32();
					}
				}
				else
				{
					this.PlayedMinutes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004D51 RID: 19793
		private static readonly MessageParser<CAIS> _parser = new MessageParser<CAIS>(() => new CAIS());

		// Token: 0x04004D52 RID: 19794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D53 RID: 19795
		private int _hasBits0;

		// Token: 0x04004D54 RID: 19796
		public const int PlayedMinutesFieldNumber = 1;

		// Token: 0x04004D55 RID: 19797
		private static readonly uint PlayedMinutesDefaultValue = 0U;

		// Token: 0x04004D56 RID: 19798
		private uint playedMinutes_;

		// Token: 0x04004D57 RID: 19799
		public const int RestedMinutesFieldNumber = 2;

		// Token: 0x04004D58 RID: 19800
		private static readonly uint RestedMinutesDefaultValue = 0U;

		// Token: 0x04004D59 RID: 19801
		private uint restedMinutes_;

		// Token: 0x04004D5A RID: 19802
		public const int LastHeardTimeFieldNumber = 3;

		// Token: 0x04004D5B RID: 19803
		private static readonly ulong LastHeardTimeDefaultValue = 0UL;

		// Token: 0x04004D5C RID: 19804
		private ulong lastHeardTime_;
	}
}

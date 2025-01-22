using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000571 RID: 1393
	public sealed class SessionVariables : IMessage<SessionVariables>, IMessage, IEquatable<SessionVariables>, IDeepCloneable<SessionVariables>, IBufferMessage
	{
		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x06008616 RID: 34326 RVA: 0x002091D8 File Offset: 0x002073D8
		[DebuggerNonUserCode]
		public static MessageParser<SessionVariables> Parser
		{
			get
			{
				return SessionVariables._parser;
			}
		}

		// Token: 0x17002A49 RID: 10825
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x002091F0 File Offset: 0x002073F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002A4A RID: 10826
		// (get) Token: 0x06008618 RID: 34328 RVA: 0x00209214 File Offset: 0x00207414
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionVariables.Descriptor;
			}
		}

		// Token: 0x06008619 RID: 34329 RVA: 0x0020922B File Offset: 0x0020742B
		[DebuggerNonUserCode]
		public SessionVariables()
		{
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x00209238 File Offset: 0x00207438
		[DebuggerNonUserCode]
		public SessionVariables(SessionVariables other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.creationTimeoutS_ = other.creationTimeoutS_;
			this.recommendedMarkAliveIntervalS_ = other.recommendedMarkAliveIntervalS_;
			this.maxMarkAliveIntervalS_ = other.maxMarkAliveIntervalS_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x00209290 File Offset: 0x00207490
		[DebuggerNonUserCode]
		public SessionVariables Clone()
		{
			return new SessionVariables(this);
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600861C RID: 34332 RVA: 0x002092A8 File Offset: 0x002074A8
		// (set) Token: 0x0600861D RID: 34333 RVA: 0x002092D9 File Offset: 0x002074D9
		[DebuggerNonUserCode]
		public uint CreationTimeoutS
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint creationTimeoutSDefaultValue;
				if (flag)
				{
					creationTimeoutSDefaultValue = this.creationTimeoutS_;
				}
				else
				{
					creationTimeoutSDefaultValue = SessionVariables.CreationTimeoutSDefaultValue;
				}
				return creationTimeoutSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTimeoutS_ = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600861E RID: 34334 RVA: 0x002092F4 File Offset: 0x002074F4
		[DebuggerNonUserCode]
		public bool HasCreationTimeoutS
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x00209311 File Offset: 0x00207511
		[DebuggerNonUserCode]
		public void ClearCreationTimeoutS()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06008620 RID: 34336 RVA: 0x00209324 File Offset: 0x00207524
		// (set) Token: 0x06008621 RID: 34337 RVA: 0x00209355 File Offset: 0x00207555
		[DebuggerNonUserCode]
		public uint RecommendedMarkAliveIntervalS
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint recommendedMarkAliveIntervalSDefaultValue;
				if (flag)
				{
					recommendedMarkAliveIntervalSDefaultValue = this.recommendedMarkAliveIntervalS_;
				}
				else
				{
					recommendedMarkAliveIntervalSDefaultValue = SessionVariables.RecommendedMarkAliveIntervalSDefaultValue;
				}
				return recommendedMarkAliveIntervalSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.recommendedMarkAliveIntervalS_ = value;
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x00209370 File Offset: 0x00207570
		[DebuggerNonUserCode]
		public bool HasRecommendedMarkAliveIntervalS
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06008623 RID: 34339 RVA: 0x0020938D File Offset: 0x0020758D
		[DebuggerNonUserCode]
		public void ClearRecommendedMarkAliveIntervalS()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002A4F RID: 10831
		// (get) Token: 0x06008624 RID: 34340 RVA: 0x002093A0 File Offset: 0x002075A0
		// (set) Token: 0x06008625 RID: 34341 RVA: 0x002093D1 File Offset: 0x002075D1
		[DebuggerNonUserCode]
		public uint MaxMarkAliveIntervalS
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint maxMarkAliveIntervalSDefaultValue;
				if (flag)
				{
					maxMarkAliveIntervalSDefaultValue = this.maxMarkAliveIntervalS_;
				}
				else
				{
					maxMarkAliveIntervalSDefaultValue = SessionVariables.MaxMarkAliveIntervalSDefaultValue;
				}
				return maxMarkAliveIntervalSDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.maxMarkAliveIntervalS_ = value;
			}
		}

		// Token: 0x17002A50 RID: 10832
		// (get) Token: 0x06008626 RID: 34342 RVA: 0x002093EC File Offset: 0x002075EC
		[DebuggerNonUserCode]
		public bool HasMaxMarkAliveIntervalS
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x00209409 File Offset: 0x00207609
		[DebuggerNonUserCode]
		public void ClearMaxMarkAliveIntervalS()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x0020941C File Offset: 0x0020761C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionVariables);
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x0020943C File Offset: 0x0020763C
		[DebuggerNonUserCode]
		public bool Equals(SessionVariables other)
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
					bool flag4 = this.CreationTimeoutS != other.CreationTimeoutS;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RecommendedMarkAliveIntervalS != other.RecommendedMarkAliveIntervalS;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.MaxMarkAliveIntervalS != other.MaxMarkAliveIntervalS;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x002094C8 File Offset: 0x002076C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCreationTimeoutS = this.HasCreationTimeoutS;
			if (hasCreationTimeoutS)
			{
				num ^= this.CreationTimeoutS.GetHashCode();
			}
			bool hasRecommendedMarkAliveIntervalS = this.HasRecommendedMarkAliveIntervalS;
			if (hasRecommendedMarkAliveIntervalS)
			{
				num ^= this.RecommendedMarkAliveIntervalS.GetHashCode();
			}
			bool hasMaxMarkAliveIntervalS = this.HasMaxMarkAliveIntervalS;
			if (hasMaxMarkAliveIntervalS)
			{
				num ^= this.MaxMarkAliveIntervalS.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x00209554 File Offset: 0x00207754
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x0020956C File Offset: 0x0020776C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x00209578 File Offset: 0x00207778
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCreationTimeoutS = this.HasCreationTimeoutS;
			if (hasCreationTimeoutS)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CreationTimeoutS);
			}
			bool hasRecommendedMarkAliveIntervalS = this.HasRecommendedMarkAliveIntervalS;
			if (hasRecommendedMarkAliveIntervalS)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.RecommendedMarkAliveIntervalS);
			}
			bool hasMaxMarkAliveIntervalS = this.HasMaxMarkAliveIntervalS;
			if (hasMaxMarkAliveIntervalS)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxMarkAliveIntervalS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x00209608 File Offset: 0x00207808
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCreationTimeoutS = this.HasCreationTimeoutS;
			if (hasCreationTimeoutS)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CreationTimeoutS);
			}
			bool hasRecommendedMarkAliveIntervalS = this.HasRecommendedMarkAliveIntervalS;
			if (hasRecommendedMarkAliveIntervalS)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RecommendedMarkAliveIntervalS);
			}
			bool hasMaxMarkAliveIntervalS = this.HasMaxMarkAliveIntervalS;
			if (hasMaxMarkAliveIntervalS)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxMarkAliveIntervalS);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x00209694 File Offset: 0x00207894
		[DebuggerNonUserCode]
		public void MergeFrom(SessionVariables other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCreationTimeoutS = other.HasCreationTimeoutS;
				if (hasCreationTimeoutS)
				{
					this.CreationTimeoutS = other.CreationTimeoutS;
				}
				bool hasRecommendedMarkAliveIntervalS = other.HasRecommendedMarkAliveIntervalS;
				if (hasRecommendedMarkAliveIntervalS)
				{
					this.RecommendedMarkAliveIntervalS = other.RecommendedMarkAliveIntervalS;
				}
				bool hasMaxMarkAliveIntervalS = other.HasMaxMarkAliveIntervalS;
				if (hasMaxMarkAliveIntervalS)
				{
					this.MaxMarkAliveIntervalS = other.MaxMarkAliveIntervalS;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x0020970F File Offset: 0x0020790F
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x0020971C File Offset: 0x0020791C
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
							this.MaxMarkAliveIntervalS = input.ReadUInt32();
						}
					}
					else
					{
						this.RecommendedMarkAliveIntervalS = input.ReadUInt32();
					}
				}
				else
				{
					this.CreationTimeoutS = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003CCC RID: 15564
		private static readonly MessageParser<SessionVariables> _parser = new MessageParser<SessionVariables>(() => new SessionVariables());

		// Token: 0x04003CCD RID: 15565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CCE RID: 15566
		private int _hasBits0;

		// Token: 0x04003CCF RID: 15567
		public const int CreationTimeoutSFieldNumber = 1;

		// Token: 0x04003CD0 RID: 15568
		private static readonly uint CreationTimeoutSDefaultValue = 0U;

		// Token: 0x04003CD1 RID: 15569
		private uint creationTimeoutS_;

		// Token: 0x04003CD2 RID: 15570
		public const int RecommendedMarkAliveIntervalSFieldNumber = 2;

		// Token: 0x04003CD3 RID: 15571
		private static readonly uint RecommendedMarkAliveIntervalSDefaultValue = 0U;

		// Token: 0x04003CD4 RID: 15572
		private uint recommendedMarkAliveIntervalS_;

		// Token: 0x04003CD5 RID: 15573
		public const int MaxMarkAliveIntervalSFieldNumber = 3;

		// Token: 0x04003CD6 RID: 15574
		private static readonly uint MaxMarkAliveIntervalSDefaultValue = 0U;

		// Token: 0x04003CD7 RID: 15575
		private uint maxMarkAliveIntervalS_;
	}
}

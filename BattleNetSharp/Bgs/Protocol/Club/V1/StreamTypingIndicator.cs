using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000504 RID: 1284
	public sealed class StreamTypingIndicator : IMessage<StreamTypingIndicator>, IMessage, IEquatable<StreamTypingIndicator>, IDeepCloneable<StreamTypingIndicator>, IBufferMessage
	{
		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x06007DB1 RID: 32177 RVA: 0x001E98FC File Offset: 0x001E7AFC
		[DebuggerNonUserCode]
		public static MessageParser<StreamTypingIndicator> Parser
		{
			get
			{
				return StreamTypingIndicator._parser;
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x001E9914 File Offset: 0x001E7B14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x001E9938 File Offset: 0x001E7B38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamTypingIndicator.Descriptor;
			}
		}

		// Token: 0x06007DB4 RID: 32180 RVA: 0x001E994F File Offset: 0x001E7B4F
		[DebuggerNonUserCode]
		public StreamTypingIndicator()
		{
		}

		// Token: 0x06007DB5 RID: 32181 RVA: 0x001E995C File Offset: 0x001E7B5C
		[DebuggerNonUserCode]
		public StreamTypingIndicator(StreamTypingIndicator other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.authorId_ = ((other.authorId_ != null) ? other.authorId_.Clone() : null);
			this.indicator_ = other.indicator_;
			this.epoch_ = other.epoch_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x001E99C4 File Offset: 0x001E7BC4
		[DebuggerNonUserCode]
		public StreamTypingIndicator Clone()
		{
			return new StreamTypingIndicator(this);
		}

		// Token: 0x170027EE RID: 10222
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x001E99DC File Offset: 0x001E7BDC
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x001E99F4 File Offset: 0x001E7BF4
		[DebuggerNonUserCode]
		public MemberId AuthorId
		{
			get
			{
				return this.authorId_;
			}
			set
			{
				this.authorId_ = value;
			}
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x001E9A00 File Offset: 0x001E7C00
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x001E9A31 File Offset: 0x001E7C31
		[DebuggerNonUserCode]
		public TypingIndicator Indicator
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				TypingIndicator indicatorDefaultValue;
				if (flag)
				{
					indicatorDefaultValue = this.indicator_;
				}
				else
				{
					indicatorDefaultValue = StreamTypingIndicator.IndicatorDefaultValue;
				}
				return indicatorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.indicator_ = value;
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x001E9A4C File Offset: 0x001E7C4C
		[DebuggerNonUserCode]
		public bool HasIndicator
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x001E9A69 File Offset: 0x001E7C69
		[DebuggerNonUserCode]
		public void ClearIndicator()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x06007DBD RID: 32189 RVA: 0x001E9A7C File Offset: 0x001E7C7C
		// (set) Token: 0x06007DBE RID: 32190 RVA: 0x001E9AAD File Offset: 0x001E7CAD
		[DebuggerNonUserCode]
		public ulong Epoch
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong epochDefaultValue;
				if (flag)
				{
					epochDefaultValue = this.epoch_;
				}
				else
				{
					epochDefaultValue = StreamTypingIndicator.EpochDefaultValue;
				}
				return epochDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.epoch_ = value;
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x06007DBF RID: 32191 RVA: 0x001E9AC8 File Offset: 0x001E7CC8
		[DebuggerNonUserCode]
		public bool HasEpoch
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x001E9AE5 File Offset: 0x001E7CE5
		[DebuggerNonUserCode]
		public void ClearEpoch()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x001E9AF8 File Offset: 0x001E7CF8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamTypingIndicator);
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x001E9B18 File Offset: 0x001E7D18
		[DebuggerNonUserCode]
		public bool Equals(StreamTypingIndicator other)
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
					bool flag4 = !object.Equals(this.AuthorId, other.AuthorId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Indicator != other.Indicator;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Epoch != other.Epoch;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x001E9BA8 File Offset: 0x001E7DA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.authorId_ != null;
			if (flag)
			{
				num ^= this.AuthorId.GetHashCode();
			}
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				num ^= this.Indicator.GetHashCode();
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num ^= this.Epoch.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x001E9C38 File Offset: 0x001E7E38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x001E9C50 File Offset: 0x001E7E50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x001E9C5C File Offset: 0x001E7E5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.authorId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AuthorId);
			}
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Indicator);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.Epoch);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x001E9CF0 File Offset: 0x001E7EF0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.authorId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AuthorId);
			}
			bool hasIndicator = this.HasIndicator;
			if (hasIndicator)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Indicator);
			}
			bool hasEpoch = this.HasEpoch;
			if (hasEpoch)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Epoch);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x001E9D80 File Offset: 0x001E7F80
		[DebuggerNonUserCode]
		public void MergeFrom(StreamTypingIndicator other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.authorId_ != null;
				if (flag2)
				{
					bool flag3 = this.authorId_ == null;
					if (flag3)
					{
						this.AuthorId = new MemberId();
					}
					this.AuthorId.MergeFrom(other.AuthorId);
				}
				bool hasIndicator = other.HasIndicator;
				if (hasIndicator)
				{
					this.Indicator = other.Indicator;
				}
				bool hasEpoch = other.HasEpoch;
				if (hasEpoch)
				{
					this.Epoch = other.Epoch;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x001E9E23 File Offset: 0x001E8023
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x001E9E30 File Offset: 0x001E8030
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Epoch = input.ReadUInt64();
						}
					}
					else
					{
						this.Indicator = (TypingIndicator)input.ReadEnum();
					}
				}
				else
				{
					bool flag = this.authorId_ == null;
					if (flag)
					{
						this.AuthorId = new MemberId();
					}
					input.ReadMessage(this.AuthorId);
				}
			}
		}

		// Token: 0x0400392F RID: 14639
		private static readonly MessageParser<StreamTypingIndicator> _parser = new MessageParser<StreamTypingIndicator>(() => new StreamTypingIndicator());

		// Token: 0x04003930 RID: 14640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003931 RID: 14641
		private int _hasBits0;

		// Token: 0x04003932 RID: 14642
		public const int AuthorIdFieldNumber = 1;

		// Token: 0x04003933 RID: 14643
		private MemberId authorId_;

		// Token: 0x04003934 RID: 14644
		public const int IndicatorFieldNumber = 2;

		// Token: 0x04003935 RID: 14645
		private static readonly TypingIndicator IndicatorDefaultValue = TypingIndicator.TypingStart;

		// Token: 0x04003936 RID: 14646
		private TypingIndicator indicator_;

		// Token: 0x04003937 RID: 14647
		public const int EpochFieldNumber = 3;

		// Token: 0x04003938 RID: 14648
		private static readonly ulong EpochDefaultValue = 0UL;

		// Token: 0x04003939 RID: 14649
		private ulong epoch_;
	}
}

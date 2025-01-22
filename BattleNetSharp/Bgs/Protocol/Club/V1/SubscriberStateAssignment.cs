using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000468 RID: 1128
	public sealed class SubscriberStateAssignment : IMessage<SubscriberStateAssignment>, IMessage, IEquatable<SubscriberStateAssignment>, IDeepCloneable<SubscriberStateAssignment>, IBufferMessage
	{
		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x001AD884 File Offset: 0x001ABA84
		[DebuggerNonUserCode]
		public static MessageParser<SubscriberStateAssignment> Parser
		{
			get
			{
				return SubscriberStateAssignment._parser;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x001AD89C File Offset: 0x001ABA9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x001AD8C0 File Offset: 0x001ABAC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberStateAssignment.Descriptor;
			}
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x001AD8D7 File Offset: 0x001ABAD7
		[DebuggerNonUserCode]
		public SubscriberStateAssignment()
		{
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x001AD8E4 File Offset: 0x001ABAE4
		[DebuggerNonUserCode]
		public SubscriberStateAssignment(SubscriberStateAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.active_ = other.active_;
			this.voice_ = ((other.voice_ != null) ? other.voice_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x001AD95C File Offset: 0x001ABB5C
		[DebuggerNonUserCode]
		public SubscriberStateAssignment Clone()
		{
			return new SubscriberStateAssignment(this);
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x001AD974 File Offset: 0x001ABB74
		// (set) Token: 0x06006E6A RID: 28266 RVA: 0x001AD98C File Offset: 0x001ABB8C
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x06006E6B RID: 28267 RVA: 0x001AD998 File Offset: 0x001ABB98
		// (set) Token: 0x06006E6C RID: 28268 RVA: 0x001AD9C9 File Offset: 0x001ABBC9
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = SubscriberStateAssignment.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.active_ = value;
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x06006E6D RID: 28269 RVA: 0x001AD9E4 File Offset: 0x001ABBE4
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x001ADA01 File Offset: 0x001ABC01
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x001ADA14 File Offset: 0x001ABC14
		// (set) Token: 0x06006E70 RID: 28272 RVA: 0x001ADA2C File Offset: 0x001ABC2C
		[DebuggerNonUserCode]
		public MemberVoiceState Voice
		{
			get
			{
				return this.voice_;
			}
			set
			{
				this.voice_ = value;
			}
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x001ADA38 File Offset: 0x001ABC38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberStateAssignment);
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x001ADA58 File Offset: 0x001ABC58
		[DebuggerNonUserCode]
		public bool Equals(SubscriberStateAssignment other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Active != other.Active;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Voice, other.Voice);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x001ADAEC File Offset: 0x001ABCEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num ^= this.Voice.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x001ADB78 File Offset: 0x001ABD78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x001ADB90 File Offset: 0x001ABD90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x001ADB9C File Offset: 0x001ABD9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Active);
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Voice);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x001ADC34 File Offset: 0x001ABE34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num += 2;
			}
			bool flag2 = this.voice_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Voice);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x001ADCB8 File Offset: 0x001ABEB8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriberStateAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				bool flag4 = other.voice_ != null;
				if (flag4)
				{
					bool flag5 = this.voice_ == null;
					if (flag5)
					{
						this.Voice = new MemberVoiceState();
					}
					this.Voice.MergeFrom(other.Voice);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x001ADD80 File Offset: 0x001ABF80
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x001ADD8C File Offset: 0x001ABF8C
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.voice_ == null;
							if (flag)
							{
								this.Voice = new MemberVoiceState();
							}
							input.ReadMessage(this.Voice);
						}
					}
					else
					{
						this.Active = input.ReadBool();
					}
				}
				else
				{
					bool flag2 = this.memberId_ == null;
					if (flag2)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040032BA RID: 12986
		private static readonly MessageParser<SubscriberStateAssignment> _parser = new MessageParser<SubscriberStateAssignment>(() => new SubscriberStateAssignment());

		// Token: 0x040032BB RID: 12987
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032BC RID: 12988
		private int _hasBits0;

		// Token: 0x040032BD RID: 12989
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040032BE RID: 12990
		private MemberId memberId_;

		// Token: 0x040032BF RID: 12991
		public const int ActiveFieldNumber = 2;

		// Token: 0x040032C0 RID: 12992
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x040032C1 RID: 12993
		private bool active_;

		// Token: 0x040032C2 RID: 12994
		public const int VoiceFieldNumber = 3;

		// Token: 0x040032C3 RID: 12995
		private MemberVoiceState voice_;
	}
}

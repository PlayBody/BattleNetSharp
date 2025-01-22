using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Challenge.V1
{
	// Token: 0x02000526 RID: 1318
	public sealed class ChallengeExternalResult : IMessage<ChallengeExternalResult>, IMessage, IEquatable<ChallengeExternalResult>, IDeepCloneable<ChallengeExternalResult>, IBufferMessage
	{
		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x06007FEA RID: 32746 RVA: 0x001F2188 File Offset: 0x001F0388
		[DebuggerNonUserCode]
		public static MessageParser<ChallengeExternalResult> Parser
		{
			get
			{
				return ChallengeExternalResult._parser;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x06007FEB RID: 32747 RVA: 0x001F21A0 File Offset: 0x001F03A0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x06007FEC RID: 32748 RVA: 0x001F21C4 File Offset: 0x001F03C4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeExternalResult.Descriptor;
			}
		}

		// Token: 0x06007FED RID: 32749 RVA: 0x001F21DB File Offset: 0x001F03DB
		[DebuggerNonUserCode]
		public ChallengeExternalResult()
		{
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x001F21E5 File Offset: 0x001F03E5
		[DebuggerNonUserCode]
		public ChallengeExternalResult(ChallengeExternalResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requestToken_ = other.requestToken_;
			this.passed_ = other.passed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x001F2224 File Offset: 0x001F0424
		[DebuggerNonUserCode]
		public ChallengeExternalResult Clone()
		{
			return new ChallengeExternalResult(this);
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x06007FF0 RID: 32752 RVA: 0x001F223C File Offset: 0x001F043C
		// (set) Token: 0x06007FF1 RID: 32753 RVA: 0x001F225D File Offset: 0x001F045D
		[DebuggerNonUserCode]
		public string RequestToken
		{
			get
			{
				return this.requestToken_ ?? ChallengeExternalResult.RequestTokenDefaultValue;
			}
			set
			{
				this.requestToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x06007FF2 RID: 32754 RVA: 0x001F2274 File Offset: 0x001F0474
		[DebuggerNonUserCode]
		public bool HasRequestToken
		{
			get
			{
				return this.requestToken_ != null;
			}
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x001F228F File Offset: 0x001F048F
		[DebuggerNonUserCode]
		public void ClearRequestToken()
		{
			this.requestToken_ = null;
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x06007FF4 RID: 32756 RVA: 0x001F229C File Offset: 0x001F049C
		// (set) Token: 0x06007FF5 RID: 32757 RVA: 0x001F22CD File Offset: 0x001F04CD
		[DebuggerNonUserCode]
		public bool Passed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool passedDefaultValue;
				if (flag)
				{
					passedDefaultValue = this.passed_;
				}
				else
				{
					passedDefaultValue = ChallengeExternalResult.PassedDefaultValue;
				}
				return passedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.passed_ = value;
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x06007FF6 RID: 32758 RVA: 0x001F22E8 File Offset: 0x001F04E8
		[DebuggerNonUserCode]
		public bool HasPassed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007FF7 RID: 32759 RVA: 0x001F2305 File Offset: 0x001F0505
		[DebuggerNonUserCode]
		public void ClearPassed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007FF8 RID: 32760 RVA: 0x001F2318 File Offset: 0x001F0518
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeExternalResult);
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x001F2338 File Offset: 0x001F0538
		[DebuggerNonUserCode]
		public bool Equals(ChallengeExternalResult other)
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
					bool flag4 = this.RequestToken != other.RequestToken;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Passed != other.Passed;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x001F23AC File Offset: 0x001F05AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num ^= this.RequestToken.GetHashCode();
			}
			bool hasPassed = this.HasPassed;
			if (hasPassed)
			{
				num ^= this.Passed.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x001F2418 File Offset: 0x001F0618
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x001F2430 File Offset: 0x001F0630
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x001F243C File Offset: 0x001F063C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.RequestToken);
			}
			bool hasPassed = this.HasPassed;
			if (hasPassed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Passed);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x001F24AC File Offset: 0x001F06AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequestToken = this.HasRequestToken;
			if (hasRequestToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RequestToken);
			}
			bool hasPassed = this.HasPassed;
			if (hasPassed)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007FFF RID: 32767 RVA: 0x001F250C File Offset: 0x001F070C
		[DebuggerNonUserCode]
		public void MergeFrom(ChallengeExternalResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequestToken = other.HasRequestToken;
				if (hasRequestToken)
				{
					this.RequestToken = other.RequestToken;
				}
				bool hasPassed = other.HasPassed;
				if (hasPassed)
				{
					this.Passed = other.Passed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008000 RID: 32768 RVA: 0x001F256E File Offset: 0x001F076E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008001 RID: 32769 RVA: 0x001F257C File Offset: 0x001F077C
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
						this.Passed = input.ReadBool();
					}
				}
				else
				{
					this.RequestToken = input.ReadString();
				}
			}
		}

		// Token: 0x04003A17 RID: 14871
		private static readonly MessageParser<ChallengeExternalResult> _parser = new MessageParser<ChallengeExternalResult>(() => new ChallengeExternalResult());

		// Token: 0x04003A18 RID: 14872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A19 RID: 14873
		private int _hasBits0;

		// Token: 0x04003A1A RID: 14874
		public const int RequestTokenFieldNumber = 1;

		// Token: 0x04003A1B RID: 14875
		private static readonly string RequestTokenDefaultValue = "";

		// Token: 0x04003A1C RID: 14876
		private string requestToken_;

		// Token: 0x04003A1D RID: 14877
		public const int PassedFieldNumber = 2;

		// Token: 0x04003A1E RID: 14878
		private static readonly bool PassedDefaultValue = true;

		// Token: 0x04003A1F RID: 14879
		private bool passed_;
	}
}

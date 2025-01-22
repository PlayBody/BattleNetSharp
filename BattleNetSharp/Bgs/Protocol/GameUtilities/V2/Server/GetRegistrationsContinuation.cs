using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005FC RID: 1532
	public sealed class GetRegistrationsContinuation : IMessage<GetRegistrationsContinuation>, IMessage, IEquatable<GetRegistrationsContinuation>, IDeepCloneable<GetRegistrationsContinuation>, IBufferMessage
	{
		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x06008F86 RID: 36742 RVA: 0x0022D190 File Offset: 0x0022B390
		[DebuggerNonUserCode]
		public static MessageParser<GetRegistrationsContinuation> Parser
		{
			get
			{
				return GetRegistrationsContinuation._parser;
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06008F87 RID: 36743 RVA: 0x0022D1A8 File Offset: 0x0022B3A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06008F88 RID: 36744 RVA: 0x0022D1CC File Offset: 0x0022B3CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRegistrationsContinuation.Descriptor;
			}
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0022D1E3 File Offset: 0x0022B3E3
		[DebuggerNonUserCode]
		public GetRegistrationsContinuation()
		{
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0022D1ED File Offset: 0x0022B3ED
		[DebuggerNonUserCode]
		public GetRegistrationsContinuation(GetRegistrationsContinuation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.token_ = other.token_;
			this.position_ = other.position_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0022D22C File Offset: 0x0022B42C
		[DebuggerNonUserCode]
		public GetRegistrationsContinuation Clone()
		{
			return new GetRegistrationsContinuation(this);
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06008F8C RID: 36748 RVA: 0x0022D244 File Offset: 0x0022B444
		// (set) Token: 0x06008F8D RID: 36749 RVA: 0x0022D275 File Offset: 0x0022B475
		[DebuggerNonUserCode]
		public ulong Token
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong tokenDefaultValue;
				if (flag)
				{
					tokenDefaultValue = this.token_;
				}
				else
				{
					tokenDefaultValue = GetRegistrationsContinuation.TokenDefaultValue;
				}
				return tokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.token_ = value;
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x06008F8E RID: 36750 RVA: 0x0022D290 File Offset: 0x0022B490
		[DebuggerNonUserCode]
		public bool HasToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0022D2AD File Offset: 0x0022B4AD
		[DebuggerNonUserCode]
		public void ClearToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x0022D2C0 File Offset: 0x0022B4C0
		// (set) Token: 0x06008F91 RID: 36753 RVA: 0x0022D2E1 File Offset: 0x0022B4E1
		[DebuggerNonUserCode]
		public string Position
		{
			get
			{
				return this.position_ ?? GetRegistrationsContinuation.PositionDefaultValue;
			}
			set
			{
				this.position_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x0022D2F8 File Offset: 0x0022B4F8
		[DebuggerNonUserCode]
		public bool HasPosition
		{
			get
			{
				return this.position_ != null;
			}
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x0022D313 File Offset: 0x0022B513
		[DebuggerNonUserCode]
		public void ClearPosition()
		{
			this.position_ = null;
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x0022D320 File Offset: 0x0022B520
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRegistrationsContinuation);
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x0022D340 File Offset: 0x0022B540
		[DebuggerNonUserCode]
		public bool Equals(GetRegistrationsContinuation other)
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
					bool flag4 = this.Token != other.Token;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Position != other.Position;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x0022D3B4 File Offset: 0x0022B5B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num ^= this.Token.GetHashCode();
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num ^= this.Position.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0022D420 File Offset: 0x0022B620
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0022D438 File Offset: 0x0022B638
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x0022D444 File Offset: 0x0022B644
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Token);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Position);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x0022D4B4 File Offset: 0x0022B6B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasToken = this.HasToken;
			if (hasToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Token);
			}
			bool hasPosition = this.HasPosition;
			if (hasPosition)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Position);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x0022D520 File Offset: 0x0022B720
		[DebuggerNonUserCode]
		public void MergeFrom(GetRegistrationsContinuation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasToken = other.HasToken;
				if (hasToken)
				{
					this.Token = other.Token;
				}
				bool hasPosition = other.HasPosition;
				if (hasPosition)
				{
					this.Position = other.Position;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0022D582 File Offset: 0x0022B782
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x0022D590 File Offset: 0x0022B790
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Position = input.ReadString();
					}
				}
				else
				{
					this.Token = input.ReadUInt64();
				}
			}
		}

		// Token: 0x040040D8 RID: 16600
		private static readonly MessageParser<GetRegistrationsContinuation> _parser = new MessageParser<GetRegistrationsContinuation>(() => new GetRegistrationsContinuation());

		// Token: 0x040040D9 RID: 16601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040DA RID: 16602
		private int _hasBits0;

		// Token: 0x040040DB RID: 16603
		public const int TokenFieldNumber = 1;

		// Token: 0x040040DC RID: 16604
		private static readonly ulong TokenDefaultValue = 0UL;

		// Token: 0x040040DD RID: 16605
		private ulong token_;

		// Token: 0x040040DE RID: 16606
		public const int PositionFieldNumber = 2;

		// Token: 0x040040DF RID: 16607
		private static readonly string PositionDefaultValue = "";

		// Token: 0x040040E0 RID: 16608
		private string position_;
	}
}

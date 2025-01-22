using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001BC RID: 444
	public sealed class InitialLoginDataRequest : IMessage<InitialLoginDataRequest>, IMessage, IEquatable<InitialLoginDataRequest>, IDeepCloneable<InitialLoginDataRequest>, IBufferMessage
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000B7968 File Offset: 0x000B5B68
		[DebuggerNonUserCode]
		public static MessageParser<InitialLoginDataRequest> Parser
		{
			get
			{
				return InitialLoginDataRequest._parser;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x000B7980 File Offset: 0x000B5B80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000B79A4 File Offset: 0x000B5BA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InitialLoginDataRequest.Descriptor;
			}
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000B79BB File Offset: 0x000B5BBB
		[DebuggerNonUserCode]
		public InitialLoginDataRequest()
		{
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000B79C5 File Offset: 0x000B5BC5
		[DebuggerNonUserCode]
		public InitialLoginDataRequest(InitialLoginDataRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.countryIdFourcc_ = other.countryIdFourcc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000B79F8 File Offset: 0x000B5BF8
		[DebuggerNonUserCode]
		public InitialLoginDataRequest Clone()
		{
			return new InitialLoginDataRequest(this);
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000B7A10 File Offset: 0x000B5C10
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x000B7A41 File Offset: 0x000B5C41
		[DebuggerNonUserCode]
		public uint CountryIdFourcc
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint countryIdFourccDefaultValue;
				if (flag)
				{
					countryIdFourccDefaultValue = this.countryIdFourcc_;
				}
				else
				{
					countryIdFourccDefaultValue = InitialLoginDataRequest.CountryIdFourccDefaultValue;
				}
				return countryIdFourccDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.countryIdFourcc_ = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x000B7A5C File Offset: 0x000B5C5C
		[DebuggerNonUserCode]
		public bool HasCountryIdFourcc
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000B7A79 File Offset: 0x000B5C79
		[DebuggerNonUserCode]
		public void ClearCountryIdFourcc()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000B7A8C File Offset: 0x000B5C8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as InitialLoginDataRequest);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000B7AAC File Offset: 0x000B5CAC
		[DebuggerNonUserCode]
		public bool Equals(InitialLoginDataRequest other)
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
					bool flag4 = this.CountryIdFourcc != other.CountryIdFourcc;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000B7B04 File Offset: 0x000B5D04
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCountryIdFourcc = this.HasCountryIdFourcc;
			if (hasCountryIdFourcc)
			{
				num ^= this.CountryIdFourcc.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000B7B54 File Offset: 0x000B5D54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000B7B6C File Offset: 0x000B5D6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000B7B78 File Offset: 0x000B5D78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCountryIdFourcc = this.HasCountryIdFourcc;
			if (hasCountryIdFourcc)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.CountryIdFourcc);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000B7BC4 File Offset: 0x000B5DC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCountryIdFourcc = this.HasCountryIdFourcc;
			if (hasCountryIdFourcc)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CountryIdFourcc);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000B7C14 File Offset: 0x000B5E14
		[DebuggerNonUserCode]
		public void MergeFrom(InitialLoginDataRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCountryIdFourcc = other.HasCountryIdFourcc;
				if (hasCountryIdFourcc)
				{
					this.CountryIdFourcc = other.CountryIdFourcc;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000B7C5D File Offset: 0x000B5E5D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000B7C68 File Offset: 0x000B5E68
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CountryIdFourcc = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040014FD RID: 5373
		private static readonly MessageParser<InitialLoginDataRequest> _parser = new MessageParser<InitialLoginDataRequest>(() => new InitialLoginDataRequest());

		// Token: 0x040014FE RID: 5374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040014FF RID: 5375
		private int _hasBits0;

		// Token: 0x04001500 RID: 5376
		public const int CountryIdFourccFieldNumber = 1;

		// Token: 0x04001501 RID: 5377
		private static readonly uint CountryIdFourccDefaultValue = 0U;

		// Token: 0x04001502 RID: 5378
		private uint countryIdFourcc_;
	}
}

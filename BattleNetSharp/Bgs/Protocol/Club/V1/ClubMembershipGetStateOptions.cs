using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046E RID: 1134
	public sealed class ClubMembershipGetStateOptions : IMessage<ClubMembershipGetStateOptions>, IMessage, IEquatable<ClubMembershipGetStateOptions>, IDeepCloneable<ClubMembershipGetStateOptions>, IBufferMessage
	{
		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06006EEB RID: 28395 RVA: 0x001AFA5C File Offset: 0x001ADC5C
		[DebuggerNonUserCode]
		public static MessageParser<ClubMembershipGetStateOptions> Parser
		{
			get
			{
				return ClubMembershipGetStateOptions._parser;
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06006EEC RID: 28396 RVA: 0x001AFA74 File Offset: 0x001ADC74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x001AFA98 File Offset: 0x001ADC98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMembershipGetStateOptions.Descriptor;
			}
		}

		// Token: 0x06006EEE RID: 28398 RVA: 0x001AFAAF File Offset: 0x001ADCAF
		[DebuggerNonUserCode]
		public ClubMembershipGetStateOptions()
		{
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x001AFAC4 File Offset: 0x001ADCC4
		[DebuggerNonUserCode]
		public ClubMembershipGetStateOptions(ClubMembershipGetStateOptions other)
			: this()
		{
			this.filter_ = other.filter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x001AFAF0 File Offset: 0x001ADCF0
		[DebuggerNonUserCode]
		public ClubMembershipGetStateOptions Clone()
		{
			return new ClubMembershipGetStateOptions(this);
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06006EF1 RID: 28401 RVA: 0x001AFB08 File Offset: 0x001ADD08
		[DebuggerNonUserCode]
		public RepeatedField<ClubMembershipFilter> Filter
		{
			get
			{
				return this.filter_;
			}
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x001AFB20 File Offset: 0x001ADD20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMembershipGetStateOptions);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x001AFB40 File Offset: 0x001ADD40
		[DebuggerNonUserCode]
		public bool Equals(ClubMembershipGetStateOptions other)
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
					bool flag4 = !this.filter_.Equals(other.filter_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x001AFB9C File Offset: 0x001ADD9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.filter_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EF5 RID: 28405 RVA: 0x001AFBDC File Offset: 0x001ADDDC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006EF6 RID: 28406 RVA: 0x001AFBF4 File Offset: 0x001ADDF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x001AFC00 File Offset: 0x001ADE00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.filter_.WriteTo(ref output, ClubMembershipGetStateOptions._repeated_filter_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x001AFC3C File Offset: 0x001ADE3C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.filter_.CalculateSize(ClubMembershipGetStateOptions._repeated_filter_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x001AFC84 File Offset: 0x001ADE84
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMembershipGetStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.filter_.Add(other.filter_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x001AFCC6 File Offset: 0x001ADEC6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x001AFCD4 File Offset: 0x001ADED4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.filter_.AddEntriesFrom(ref input, ClubMembershipGetStateOptions._repeated_filter_codec);
				}
			}
		}

		// Token: 0x040032F6 RID: 13046
		private static readonly MessageParser<ClubMembershipGetStateOptions> _parser = new MessageParser<ClubMembershipGetStateOptions>(() => new ClubMembershipGetStateOptions());

		// Token: 0x040032F7 RID: 13047
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032F8 RID: 13048
		public const int FilterFieldNumber = 1;

		// Token: 0x040032F9 RID: 13049
		private static readonly FieldCodec<ClubMembershipFilter> _repeated_filter_codec = FieldCodec.ForMessage<ClubMembershipFilter>(10U, ClubMembershipFilter.Parser);

		// Token: 0x040032FA RID: 13050
		private readonly RepeatedField<ClubMembershipFilter> filter_ = new RepeatedField<ClubMembershipFilter>();
	}
}

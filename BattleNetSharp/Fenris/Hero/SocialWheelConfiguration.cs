using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001AE RID: 430
	public sealed class SocialWheelConfiguration : IMessage<SocialWheelConfiguration>, IMessage, IEquatable<SocialWheelConfiguration>, IDeepCloneable<SocialWheelConfiguration>, IBufferMessage
	{
		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000B1BEC File Offset: 0x000AFDEC
		[DebuggerNonUserCode]
		public static MessageParser<SocialWheelConfiguration> Parser
		{
			get
			{
				return SocialWheelConfiguration._parser;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000B1C04 File Offset: 0x000AFE04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000B1C28 File Offset: 0x000AFE28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SocialWheelConfiguration.Descriptor;
			}
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000B1C3F File Offset: 0x000AFE3F
		[DebuggerNonUserCode]
		public SocialWheelConfiguration()
		{
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000B1C54 File Offset: 0x000AFE54
		[DebuggerNonUserCode]
		public SocialWheelConfiguration(SocialWheelConfiguration other)
			: this()
		{
			this.wheelOverrides_ = other.wheelOverrides_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000B1C80 File Offset: 0x000AFE80
		[DebuggerNonUserCode]
		public SocialWheelConfiguration Clone()
		{
			return new SocialWheelConfiguration(this);
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x000B1C98 File Offset: 0x000AFE98
		[DebuggerNonUserCode]
		public RepeatedField<SocialWheelOverride> WheelOverrides
		{
			get
			{
				return this.wheelOverrides_;
			}
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x000B1CB0 File Offset: 0x000AFEB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SocialWheelConfiguration);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000B1CD0 File Offset: 0x000AFED0
		[DebuggerNonUserCode]
		public bool Equals(SocialWheelConfiguration other)
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
					bool flag4 = !this.wheelOverrides_.Equals(other.wheelOverrides_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000B1D2C File Offset: 0x000AFF2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.wheelOverrides_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000B1D6C File Offset: 0x000AFF6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000B1D84 File Offset: 0x000AFF84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000B1D90 File Offset: 0x000AFF90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.wheelOverrides_.WriteTo(ref output, SocialWheelConfiguration._repeated_wheelOverrides_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000B1DCC File Offset: 0x000AFFCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.wheelOverrides_.CalculateSize(SocialWheelConfiguration._repeated_wheelOverrides_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000B1E14 File Offset: 0x000B0014
		[DebuggerNonUserCode]
		public void MergeFrom(SocialWheelConfiguration other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.wheelOverrides_.Add(other.wheelOverrides_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000B1E56 File Offset: 0x000B0056
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000B1E64 File Offset: 0x000B0064
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
					this.wheelOverrides_.AddEntriesFrom(ref input, SocialWheelConfiguration._repeated_wheelOverrides_codec);
				}
			}
		}

		// Token: 0x0400147B RID: 5243
		private static readonly MessageParser<SocialWheelConfiguration> _parser = new MessageParser<SocialWheelConfiguration>(() => new SocialWheelConfiguration());

		// Token: 0x0400147C RID: 5244
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400147D RID: 5245
		public const int WheelOverridesFieldNumber = 1;

		// Token: 0x0400147E RID: 5246
		private static readonly FieldCodec<SocialWheelOverride> _repeated_wheelOverrides_codec = FieldCodec.ForMessage<SocialWheelOverride>(10U, SocialWheelOverride.Parser);

		// Token: 0x0400147F RID: 5247
		private readonly RepeatedField<SocialWheelOverride> wheelOverrides_ = new RepeatedField<SocialWheelOverride>();
	}
}

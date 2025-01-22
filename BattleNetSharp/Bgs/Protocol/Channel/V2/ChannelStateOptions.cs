using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069D RID: 1693
	public sealed class ChannelStateOptions : IMessage<ChannelStateOptions>, IMessage, IEquatable<ChannelStateOptions>, IDeepCloneable<ChannelStateOptions>, IBufferMessage
	{
		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009D26 RID: 40230 RVA: 0x00263454 File Offset: 0x00261654
		[DebuggerNonUserCode]
		public static MessageParser<ChannelStateOptions> Parser
		{
			get
			{
				return ChannelStateOptions._parser;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x0026346C File Offset: 0x0026166C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009D28 RID: 40232 RVA: 0x00263490 File Offset: 0x00261690
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelStateOptions.Descriptor;
			}
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x002634A7 File Offset: 0x002616A7
		[DebuggerNonUserCode]
		public ChannelStateOptions()
		{
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x002634BC File Offset: 0x002616BC
		[DebuggerNonUserCode]
		public ChannelStateOptions(ChannelStateOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.privacyLevel_ = other.privacyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x0026350C File Offset: 0x0026170C
		[DebuggerNonUserCode]
		public ChannelStateOptions Clone()
		{
			return new ChannelStateOptions(this);
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009D2C RID: 40236 RVA: 0x00263524 File Offset: 0x00261724
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x0026353C File Offset: 0x0026173C
		// (set) Token: 0x06009D2E RID: 40238 RVA: 0x0026356D File Offset: 0x0026176D
		[DebuggerNonUserCode]
		public PrivacyLevel PrivacyLevel
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				PrivacyLevel privacyLevelDefaultValue;
				if (flag)
				{
					privacyLevelDefaultValue = this.privacyLevel_;
				}
				else
				{
					privacyLevelDefaultValue = ChannelStateOptions.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x00263588 File Offset: 0x00261788
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x002635A5 File Offset: 0x002617A5
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x002635B8 File Offset: 0x002617B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelStateOptions);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x002635D8 File Offset: 0x002617D8
		[DebuggerNonUserCode]
		public bool Equals(ChannelStateOptions other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PrivacyLevel != other.PrivacyLevel;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x0026364C File Offset: 0x0026184C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num ^= this.PrivacyLevel.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x002636B0 File Offset: 0x002618B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x002636C8 File Offset: 0x002618C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x002636D4 File Offset: 0x002618D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ChannelStateOptions._repeated_attribute_codec);
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x00263734 File Offset: 0x00261934
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ChannelStateOptions._repeated_attribute_codec);
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PrivacyLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x00263798 File Offset: 0x00261998
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x002637F3 File Offset: 0x002619F3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x00263800 File Offset: 0x00261A00
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
						this.PrivacyLevel = (PrivacyLevel)input.ReadEnum();
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ChannelStateOptions._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x040046F2 RID: 18162
		private static readonly MessageParser<ChannelStateOptions> _parser = new MessageParser<ChannelStateOptions>(() => new ChannelStateOptions());

		// Token: 0x040046F3 RID: 18163
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046F4 RID: 18164
		private int _hasBits0;

		// Token: 0x040046F5 RID: 18165
		public const int AttributeFieldNumber = 1;

		// Token: 0x040046F6 RID: 18166
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x040046F7 RID: 18167
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x040046F8 RID: 18168
		public const int PrivacyLevelFieldNumber = 2;

		// Token: 0x040046F9 RID: 18169
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x040046FA RID: 18170
		private PrivacyLevel privacyLevel_;
	}
}

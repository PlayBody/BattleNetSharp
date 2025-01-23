using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069E RID: 1694
	public sealed class ChannelStateAssignment : IMessage<ChannelStateAssignment>, IMessage, IEquatable<ChannelStateAssignment>, IDeepCloneable<ChannelStateAssignment>, IBufferMessage
	{
		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009D3C RID: 40252 RVA: 0x002638A0 File Offset: 0x00261AA0
		[DebuggerNonUserCode]
		public static MessageParser<ChannelStateAssignment> Parser
		{
			get
			{
				return ChannelStateAssignment._parser;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x002638B8 File Offset: 0x00261AB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009D3E RID: 40254 RVA: 0x002638DC File Offset: 0x00261ADC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelStateAssignment.Descriptor;
			}
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x002638F3 File Offset: 0x00261AF3
		[DebuggerNonUserCode]
		public ChannelStateAssignment()
		{
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x00263908 File Offset: 0x00261B08
		[DebuggerNonUserCode]
		public ChannelStateAssignment(ChannelStateAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.attribute_ = other.attribute_.Clone();
			this.privacyLevel_ = other.privacyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x00263964 File Offset: 0x00261B64
		[DebuggerNonUserCode]
		public ChannelStateAssignment Clone()
		{
			return new ChannelStateAssignment(this);
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06009D42 RID: 40258 RVA: 0x0026397C File Offset: 0x00261B7C
		// (set) Token: 0x06009D43 RID: 40259 RVA: 0x0026399D File Offset: 0x00261B9D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? ChannelStateAssignment.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06009D44 RID: 40260 RVA: 0x002639B4 File Offset: 0x00261BB4
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x002639CF File Offset: 0x00261BCF
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06009D46 RID: 40262 RVA: 0x002639DC File Offset: 0x00261BDC
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06009D47 RID: 40263 RVA: 0x002639F4 File Offset: 0x00261BF4
		// (set) Token: 0x06009D48 RID: 40264 RVA: 0x00263A25 File Offset: 0x00261C25
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
					privacyLevelDefaultValue = ChannelStateAssignment.PrivacyLevelDefaultValue;
				}
				return privacyLevelDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privacyLevel_ = value;
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06009D49 RID: 40265 RVA: 0x00263A40 File Offset: 0x00261C40
		[DebuggerNonUserCode]
		public bool HasPrivacyLevel
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x00263A5D File Offset: 0x00261C5D
		[DebuggerNonUserCode]
		public void ClearPrivacyLevel()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x00263A70 File Offset: 0x00261C70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelStateAssignment);
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x00263A90 File Offset: 0x00261C90
		[DebuggerNonUserCode]
		public bool Equals(ChannelStateAssignment other)
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
					bool flag4 = this.Name != other.Name;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PrivacyLevel != other.PrivacyLevel;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x00263B20 File Offset: 0x00261D20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
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

		// Token: 0x06009D4E RID: 40270 RVA: 0x00263BA0 File Offset: 0x00261DA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x00263BB8 File Offset: 0x00261DB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x00263BC4 File Offset: 0x00261DC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			this.attribute_.WriteTo(ref output, ChannelStateAssignment._repeated_attribute_codec);
			bool hasPrivacyLevel = this.HasPrivacyLevel;
			if (hasPrivacyLevel)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.PrivacyLevel);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x00263C44 File Offset: 0x00261E44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.attribute_.CalculateSize(ChannelStateAssignment._repeated_attribute_codec);
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

		// Token: 0x06009D52 RID: 40274 RVA: 0x00263CC4 File Offset: 0x00261EC4
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelStateAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this.attribute_.Add(other.attribute_);
				bool hasPrivacyLevel = other.HasPrivacyLevel;
				if (hasPrivacyLevel)
				{
					this.PrivacyLevel = other.PrivacyLevel;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x00263D38 File Offset: 0x00261F38
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x00263D44 File Offset: 0x00261F44
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
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
						this.attribute_.AddEntriesFrom(ref input, ChannelStateAssignment._repeated_attribute_codec);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x040046FB RID: 18171
		private static readonly MessageParser<ChannelStateAssignment> _parser = new MessageParser<ChannelStateAssignment>(() => new ChannelStateAssignment());

		// Token: 0x040046FC RID: 18172
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046FD RID: 18173
		private int _hasBits0;

		// Token: 0x040046FE RID: 18174
		public const int NameFieldNumber = 1;

		// Token: 0x040046FF RID: 18175
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004700 RID: 18176
		private string name_;

		// Token: 0x04004701 RID: 18177
		public const int AttributeFieldNumber = 2;

		// Token: 0x04004702 RID: 18178
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04004703 RID: 18179
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04004704 RID: 18180
		public const int PrivacyLevelFieldNumber = 3;

		// Token: 0x04004705 RID: 18181
		private static readonly PrivacyLevel PrivacyLevelDefaultValue = PrivacyLevel.Open;

		// Token: 0x04004706 RID: 18182
		private PrivacyLevel privacyLevel_;
	}
}

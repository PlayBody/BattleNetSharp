using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005EF RID: 1519
	public sealed class PlayerVariables : IMessage<PlayerVariables>, IMessage, IEquatable<PlayerVariables>, IDeepCloneable<PlayerVariables>, IBufferMessage
	{
		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x00229E64 File Offset: 0x00228064
		[DebuggerNonUserCode]
		public static MessageParser<PlayerVariables> Parser
		{
			get
			{
				return PlayerVariables._parser;
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x06008EA2 RID: 36514 RVA: 0x00229E7C File Offset: 0x0022807C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x00229EA0 File Offset: 0x002280A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVariables.Descriptor;
			}
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00229EB7 File Offset: 0x002280B7
		[DebuggerNonUserCode]
		public PlayerVariables()
		{
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00229ECC File Offset: 0x002280CC
		[DebuggerNonUserCode]
		public PlayerVariables(PlayerVariables other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.rating_ = other.rating_;
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x00229F38 File Offset: 0x00228138
		[DebuggerNonUserCode]
		public PlayerVariables Clone()
		{
			return new PlayerVariables(this);
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x00229F50 File Offset: 0x00228150
		// (set) Token: 0x06008EA8 RID: 36520 RVA: 0x00229F68 File Offset: 0x00228168
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x06008EA9 RID: 36521 RVA: 0x00229F74 File Offset: 0x00228174
		// (set) Token: 0x06008EAA RID: 36522 RVA: 0x00229FA5 File Offset: 0x002281A5
		[DebuggerNonUserCode]
		public double Rating
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				double ratingDefaultValue;
				if (flag)
				{
					ratingDefaultValue = this.rating_;
				}
				else
				{
					ratingDefaultValue = PlayerVariables.RatingDefaultValue;
				}
				return ratingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.rating_ = value;
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x00229FC0 File Offset: 0x002281C0
		[DebuggerNonUserCode]
		public bool HasRating
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00229FDD File Offset: 0x002281DD
		[DebuggerNonUserCode]
		public void ClearRating()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x00229FF0 File Offset: 0x002281F0
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x0022A008 File Offset: 0x00228208
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVariables);
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x0022A028 File Offset: 0x00228228
		[DebuggerNonUserCode]
		public bool Equals(PlayerVariables other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Rating, other.Rating);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.attribute_.Equals(other.attribute_);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0022A0C4 File Offset: 0x002282C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasRating = this.HasRating;
			if (hasRating)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Rating);
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0022A140 File Offset: 0x00228340
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0022A158 File Offset: 0x00228358
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0022A164 File Offset: 0x00228364
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasRating = this.HasRating;
			if (hasRating)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.Rating);
			}
			this.attribute_.WriteTo(ref output, PlayerVariables._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x0022A1E8 File Offset: 0x002283E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasRating = this.HasRating;
			if (hasRating)
			{
				num += 9;
			}
			num += this.attribute_.CalculateSize(PlayerVariables._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0022A260 File Offset: 0x00228460
		[DebuggerNonUserCode]
		public void MergeFrom(PlayerVariables other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasRating = other.HasRating;
				if (hasRating)
				{
					this.Rating = other.Rating;
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0022A2F7 File Offset: 0x002284F7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0022A304 File Offset: 0x00228504
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
					if (num3 != 17U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, PlayerVariables._repeated_attribute_codec);
						}
					}
					else
					{
						this.Rating = input.ReadDouble();
					}
				}
				else
				{
					bool flag = this.identity_ == null;
					if (flag)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x04004075 RID: 16501
		private static readonly MessageParser<PlayerVariables> _parser = new MessageParser<PlayerVariables>(() => new PlayerVariables());

		// Token: 0x04004076 RID: 16502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004077 RID: 16503
		private int _hasBits0;

		// Token: 0x04004078 RID: 16504
		public const int IdentityFieldNumber = 1;

		// Token: 0x04004079 RID: 16505
		private Identity identity_;

		// Token: 0x0400407A RID: 16506
		public const int RatingFieldNumber = 2;

		// Token: 0x0400407B RID: 16507
		private static readonly double RatingDefaultValue = 0.0;

		// Token: 0x0400407C RID: 16508
		private double rating_;

		// Token: 0x0400407D RID: 16509
		public const int AttributeFieldNumber = 3;

		// Token: 0x0400407E RID: 16510
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(26U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x0400407F RID: 16511
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

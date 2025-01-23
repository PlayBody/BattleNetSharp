using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E8 RID: 1000
	public sealed class GameCreationProperties : IMessage<GameCreationProperties>, IMessage, IEquatable<GameCreationProperties>, IDeepCloneable<GameCreationProperties>, IBufferMessage
	{
		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x00180CB8 File Offset: 0x0017EEB8
		[DebuggerNonUserCode]
		public static MessageParser<GameCreationProperties> Parser
		{
			get
			{
				return GameCreationProperties._parser;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x00180CD0 File Offset: 0x0017EED0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x00180CF4 File Offset: 0x0017EEF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameCreationProperties.Descriptor;
			}
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00180D0B File Offset: 0x0017EF0B
		[DebuggerNonUserCode]
		public GameCreationProperties()
		{
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x00180D20 File Offset: 0x0017EF20
		[DebuggerNonUserCode]
		public GameCreationProperties(GameCreationProperties other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00180D4C File Offset: 0x0017EF4C
		[DebuggerNonUserCode]
		public GameCreationProperties Clone()
		{
			return new GameCreationProperties(this);
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x00180D64 File Offset: 0x0017EF64
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00180D7C File Offset: 0x0017EF7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameCreationProperties);
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x00180D9C File Offset: 0x0017EF9C
		[DebuggerNonUserCode]
		public bool Equals(GameCreationProperties other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00180DF8 File Offset: 0x0017EFF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00180E38 File Offset: 0x0017F038
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x00180E50 File Offset: 0x0017F050
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00180E5C File Offset: 0x0017F05C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, GameCreationProperties._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00180E98 File Offset: 0x0017F098
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(GameCreationProperties._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00180EE0 File Offset: 0x0017F0E0
		[DebuggerNonUserCode]
		public void MergeFrom(GameCreationProperties other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00180F22 File Offset: 0x0017F122
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00180F30 File Offset: 0x0017F130
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
					this.attribute_.AddEntriesFrom(ref input, GameCreationProperties._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x04002D61 RID: 11617
		private static readonly MessageParser<GameCreationProperties> _parser = new MessageParser<GameCreationProperties>(() => new GameCreationProperties());

		// Token: 0x04002D62 RID: 11618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D63 RID: 11619
		public const int AttributeFieldNumber = 1;

		// Token: 0x04002D64 RID: 11620
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002D65 RID: 11621
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}

using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E5 RID: 997
	public sealed class GameMatchmakerFilter : IMessage<GameMatchmakerFilter>, IMessage, IEquatable<GameMatchmakerFilter>, IDeepCloneable<GameMatchmakerFilter>, IBufferMessage
	{
		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x00180220 File Offset: 0x0017E420
		[DebuggerNonUserCode]
		public static MessageParser<GameMatchmakerFilter> Parser
		{
			get
			{
				return GameMatchmakerFilter._parser;
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x00180238 File Offset: 0x0017E438
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006347 RID: 25415 RVA: 0x0018025C File Offset: 0x0017E45C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMatchmakerFilter.Descriptor;
			}
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00180273 File Offset: 0x0017E473
		[DebuggerNonUserCode]
		public GameMatchmakerFilter()
		{
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x00180288 File Offset: 0x0017E488
		[DebuggerNonUserCode]
		public GameMatchmakerFilter(GameMatchmakerFilter other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x001802B4 File Offset: 0x0017E4B4
		[DebuggerNonUserCode]
		public GameMatchmakerFilter Clone()
		{
			return new GameMatchmakerFilter(this);
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x001802CC File Offset: 0x0017E4CC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x001802E4 File Offset: 0x0017E4E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMatchmakerFilter);
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x00180304 File Offset: 0x0017E504
		[DebuggerNonUserCode]
		public bool Equals(GameMatchmakerFilter other)
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

		// Token: 0x0600634E RID: 25422 RVA: 0x00180360 File Offset: 0x0017E560
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

		// Token: 0x0600634F RID: 25423 RVA: 0x001803A0 File Offset: 0x0017E5A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x001803B8 File Offset: 0x0017E5B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x001803C4 File Offset: 0x0017E5C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, GameMatchmakerFilter._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x00180400 File Offset: 0x0017E600
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(GameMatchmakerFilter._repeated_attribute_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00180448 File Offset: 0x0017E648
		[DebuggerNonUserCode]
		public void MergeFrom(GameMatchmakerFilter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x0018048A File Offset: 0x0017E68A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x00180498 File Offset: 0x0017E698
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
					this.attribute_.AddEntriesFrom(ref input, GameMatchmakerFilter._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x04002D4F RID: 11599
		private static readonly MessageParser<GameMatchmakerFilter> _parser = new MessageParser<GameMatchmakerFilter>(() => new GameMatchmakerFilter());

		// Token: 0x04002D50 RID: 11600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D51 RID: 11601
		public const int AttributeFieldNumber = 1;

		// Token: 0x04002D52 RID: 11602
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04002D53 RID: 11603
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

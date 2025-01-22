using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006E7 RID: 1767
	public sealed class Message : IExtendableMessage<Message>, IMessage<Message>, IMessage, IEquatable<Message>, IDeepCloneable<Message>, IBufferMessage
	{
		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x0027AFEC File Offset: 0x002791EC
		private ExtensionSet<Message> _Extensions
		{
			get
			{
				return this._extensions;
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x0027B004 File Offset: 0x00279204
		[DebuggerNonUserCode]
		public static MessageParser<Message> Parser
		{
			get
			{
				return Message._parser;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A2C9 RID: 41673 RVA: 0x0027B01C File Offset: 0x0027921C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x0027B040 File Offset: 0x00279240
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Message.Descriptor;
			}
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x0027B057 File Offset: 0x00279257
		[DebuggerNonUserCode]
		public Message()
		{
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x0027B06C File Offset: 0x0027926C
		[DebuggerNonUserCode]
		public Message(Message other)
			: this()
		{
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
			this._extensions = ExtensionSet.Clone<Message>(other._extensions);
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0027B0AC File Offset: 0x002792AC
		[DebuggerNonUserCode]
		public Message Clone()
		{
			return new Message(this);
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x0027B0C4 File Offset: 0x002792C4
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x0027B0DC File Offset: 0x002792DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Message);
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x0027B0FC File Offset: 0x002792FC
		[DebuggerNonUserCode]
		public bool Equals(Message other)
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
						bool flag5 = !object.Equals(this._extensions, other._extensions);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x0027B174 File Offset: 0x00279374
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool flag = this._extensions != null;
			if (flag)
			{
				num ^= this._extensions.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x0027B1D4 File Offset: 0x002793D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x0027B1EC File Offset: 0x002793EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x0027B1F8 File Offset: 0x002793F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, Message._repeated_attribute_codec);
			bool flag = this._extensions != null;
			if (flag)
			{
				this._extensions.WriteTo(ref output);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x0027B250 File Offset: 0x00279450
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(Message._repeated_attribute_codec);
			bool flag = this._extensions != null;
			if (flag)
			{
				num += this._extensions.CalculateSize();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x0027B2B4 File Offset: 0x002794B4
		[DebuggerNonUserCode]
		public void MergeFrom(Message other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				ExtensionSet.MergeFrom<Message>(ref this._extensions, other._extensions);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x0027B308 File Offset: 0x00279508
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x0027B314 File Offset: 0x00279514
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
					bool flag = !ExtensionSet.TryMergeFieldFrom<Message>(ref this._extensions, ref input);
					if (flag)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, Message._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x0027B380 File Offset: 0x00279580
		public TValue GetExtension<TValue>(Extension<Message, TValue> extension)
		{
			return ExtensionSet.Get<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x0027B3A0 File Offset: 0x002795A0
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<Message, TValue> extension)
		{
			return ExtensionSet.Get<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x0027B3C0 File Offset: 0x002795C0
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<Message, TValue> extension)
		{
			return ExtensionSet.GetOrInitialize<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x0027B3DE File Offset: 0x002795DE
		public void SetExtension<TValue>(Extension<Message, TValue> extension, TValue value)
		{
			ExtensionSet.Set<Message, TValue>(ref this._extensions, extension, value);
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x0027B3F0 File Offset: 0x002795F0
		public bool HasExtension<TValue>(Extension<Message, TValue> extension)
		{
			return ExtensionSet.Has<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x0027B40E File Offset: 0x0027960E
		public void ClearExtension<TValue>(Extension<Message, TValue> extension)
		{
			ExtensionSet.Clear<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x0027B41E File Offset: 0x0027961E
		public void ClearExtension<TValue>(RepeatedExtension<Message, TValue> extension)
		{
			ExtensionSet.Clear<Message, TValue>(ref this._extensions, extension);
		}

		// Token: 0x0400496A RID: 18794
		private static readonly MessageParser<Message> _parser = new MessageParser<Message>(() => new Message());

		// Token: 0x0400496B RID: 18795
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400496C RID: 18796
		private ExtensionSet<Message> _extensions;

		// Token: 0x0400496D RID: 18797
		public const int AttributeFieldNumber = 1;

		// Token: 0x0400496E RID: 18798
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x0400496F RID: 18799
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200016C RID: 364
	public sealed class Mails : IMessage<Mails>, IMessage, IEquatable<Mails>, IDeepCloneable<Mails>, IBufferMessage
	{
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00093ED4 File Offset: 0x000920D4
		[DebuggerNonUserCode]
		public static MessageParser<Mails> Parser
		{
			get
			{
				return Mails._parser;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00093EEC File Offset: 0x000920EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00093F10 File Offset: 0x00092110
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Mails.Descriptor;
			}
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00093F27 File Offset: 0x00092127
		[DebuggerNonUserCode]
		public Mails()
		{
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00093F3C File Offset: 0x0009213C
		[DebuggerNonUserCode]
		public Mails(Mails other)
			: this()
		{
			this.mails_ = other.mails_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00093F68 File Offset: 0x00092168
		[DebuggerNonUserCode]
		public Mails Clone()
		{
			return new Mails(this);
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x00093F80 File Offset: 0x00092180
		[DebuggerNonUserCode]
		public RepeatedField<Mail> Mails_
		{
			get
			{
				return this.mails_;
			}
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00093F98 File Offset: 0x00092198
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Mails);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00093FB8 File Offset: 0x000921B8
		[DebuggerNonUserCode]
		public bool Equals(Mails other)
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
					bool flag4 = !this.mails_.Equals(other.mails_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00094014 File Offset: 0x00092214
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mails_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00094054 File Offset: 0x00092254
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0009406C File Offset: 0x0009226C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00094078 File Offset: 0x00092278
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mails_.WriteTo(ref output, Mails._repeated_mails_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x000940B4 File Offset: 0x000922B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mails_.CalculateSize(Mails._repeated_mails_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000940FC File Offset: 0x000922FC
		[DebuggerNonUserCode]
		public void MergeFrom(Mails other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.mails_.Add(other.mails_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x0009413E File Offset: 0x0009233E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0009414C File Offset: 0x0009234C
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
					this.mails_.AddEntriesFrom(ref input, Mails._repeated_mails_codec);
				}
			}
		}

		// Token: 0x040010D4 RID: 4308
		private static readonly MessageParser<Mails> _parser = new MessageParser<Mails>(() => new Mails());

		// Token: 0x040010D5 RID: 4309
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010D6 RID: 4310
		public const int Mails_FieldNumber = 1;

		// Token: 0x040010D7 RID: 4311
		private static readonly FieldCodec<Mail> _repeated_mails_codec = FieldCodec.ForMessage<Mail>(10U, Mail.Parser);

		// Token: 0x040010D8 RID: 4312
		private readonly RepeatedField<Mail> mails_ = new RepeatedField<Mail>();
	}
}

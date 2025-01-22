using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FA RID: 1274
	public sealed class ClubStreamMessageContainer : IMessage<ClubStreamMessageContainer>, IMessage, IEquatable<ClubStreamMessageContainer>, IDeepCloneable<ClubStreamMessageContainer>, IBufferMessage
	{
		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06007C8A RID: 31882 RVA: 0x001E5104 File Offset: 0x001E3304
		[DebuggerNonUserCode]
		public static MessageParser<ClubStreamMessageContainer> Parser
		{
			get
			{
				return ClubStreamMessageContainer._parser;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x001E511C File Offset: 0x001E331C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x001E5140 File Offset: 0x001E3340
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubStreamMessageContainer.Descriptor;
			}
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x001E5157 File Offset: 0x001E3357
		[DebuggerNonUserCode]
		public ClubStreamMessageContainer()
		{
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x001E516C File Offset: 0x001E336C
		[DebuggerNonUserCode]
		public ClubStreamMessageContainer(ClubStreamMessageContainer other)
			: this()
		{
			this.message_ = other.message_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x001E5198 File Offset: 0x001E3398
		[DebuggerNonUserCode]
		public ClubStreamMessageContainer Clone()
		{
			return new ClubStreamMessageContainer(this);
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x001E51B0 File Offset: 0x001E33B0
		[DebuggerNonUserCode]
		public RepeatedField<StreamMessage> Message
		{
			get
			{
				return this.message_;
			}
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x001E51C8 File Offset: 0x001E33C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubStreamMessageContainer);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x001E51E8 File Offset: 0x001E33E8
		[DebuggerNonUserCode]
		public bool Equals(ClubStreamMessageContainer other)
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
					bool flag4 = !this.message_.Equals(other.message_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x001E5244 File Offset: 0x001E3444
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.message_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x001E5284 File Offset: 0x001E3484
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x001E529C File Offset: 0x001E349C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x001E52A8 File Offset: 0x001E34A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.message_.WriteTo(ref output, ClubStreamMessageContainer._repeated_message_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x001E52E4 File Offset: 0x001E34E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.message_.CalculateSize(ClubStreamMessageContainer._repeated_message_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x001E532C File Offset: 0x001E352C
		[DebuggerNonUserCode]
		public void MergeFrom(ClubStreamMessageContainer other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.message_.Add(other.message_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x001E536E File Offset: 0x001E356E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x001E537C File Offset: 0x001E357C
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
					this.message_.AddEntriesFrom(ref input, ClubStreamMessageContainer._repeated_message_codec);
				}
			}
		}

		// Token: 0x040038A2 RID: 14498
		private static readonly MessageParser<ClubStreamMessageContainer> _parser = new MessageParser<ClubStreamMessageContainer>(() => new ClubStreamMessageContainer());

		// Token: 0x040038A3 RID: 14499
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038A4 RID: 14500
		public const int MessageFieldNumber = 1;

		// Token: 0x040038A5 RID: 14501
		private static readonly FieldCodec<StreamMessage> _repeated_message_codec = FieldCodec.ForMessage<StreamMessage>(10U, StreamMessage.Parser);

		// Token: 0x040038A6 RID: 14502
		private readonly RepeatedField<StreamMessage> message_ = new RepeatedField<StreamMessage>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x0200058D RID: 1421
	public sealed class PublicationReceivedNotification : IMessage<PublicationReceivedNotification>, IMessage, IEquatable<PublicationReceivedNotification>, IDeepCloneable<PublicationReceivedNotification>, IBufferMessage
	{
		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x00210C50 File Offset: 0x0020EE50
		[DebuggerNonUserCode]
		public static MessageParser<PublicationReceivedNotification> Parser
		{
			get
			{
				return PublicationReceivedNotification._parser;
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x06008804 RID: 34820 RVA: 0x00210C68 File Offset: 0x0020EE68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationListenerReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008805 RID: 34821 RVA: 0x00210C8C File Offset: 0x0020EE8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicationReceivedNotification.Descriptor;
			}
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x00210CA3 File Offset: 0x0020EEA3
		[DebuggerNonUserCode]
		public PublicationReceivedNotification()
		{
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x00210CB8 File Offset: 0x0020EEB8
		[DebuggerNonUserCode]
		public PublicationReceivedNotification(PublicationReceivedNotification other)
			: this()
		{
			this.articles_ = other.articles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x00210CE4 File Offset: 0x0020EEE4
		[DebuggerNonUserCode]
		public PublicationReceivedNotification Clone()
		{
			return new PublicationReceivedNotification(this);
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008809 RID: 34825 RVA: 0x00210CFC File Offset: 0x0020EEFC
		[DebuggerNonUserCode]
		public RepeatedField<Article> Articles
		{
			get
			{
				return this.articles_;
			}
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x00210D14 File Offset: 0x0020EF14
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicationReceivedNotification);
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x00210D34 File Offset: 0x0020EF34
		[DebuggerNonUserCode]
		public bool Equals(PublicationReceivedNotification other)
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
					bool flag4 = !this.articles_.Equals(other.articles_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x00210D90 File Offset: 0x0020EF90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.articles_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600880D RID: 34829 RVA: 0x00210DD0 File Offset: 0x0020EFD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00210DE8 File Offset: 0x0020EFE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x00210DF4 File Offset: 0x0020EFF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.articles_.WriteTo(ref output, PublicationReceivedNotification._repeated_articles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x00210E30 File Offset: 0x0020F030
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.articles_.CalculateSize(PublicationReceivedNotification._repeated_articles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008811 RID: 34833 RVA: 0x00210E78 File Offset: 0x0020F078
		[DebuggerNonUserCode]
		public void MergeFrom(PublicationReceivedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.articles_.Add(other.articles_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x00210EBA File Offset: 0x0020F0BA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x00210EC8 File Offset: 0x0020F0C8
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
					this.articles_.AddEntriesFrom(ref input, PublicationReceivedNotification._repeated_articles_codec);
				}
			}
		}

		// Token: 0x04003DA4 RID: 15780
		private static readonly MessageParser<PublicationReceivedNotification> _parser = new MessageParser<PublicationReceivedNotification>(() => new PublicationReceivedNotification());

		// Token: 0x04003DA5 RID: 15781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA6 RID: 15782
		public const int ArticlesFieldNumber = 1;

		// Token: 0x04003DA7 RID: 15783
		private static readonly FieldCodec<Article> _repeated_articles_codec = FieldCodec.ForMessage<Article>(10U, Article.Parser);

		// Token: 0x04003DA8 RID: 15784
		private readonly RepeatedField<Article> articles_ = new RepeatedField<Article>();
	}
}

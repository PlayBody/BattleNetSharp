using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000664 RID: 1636
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x060097E2 RID: 38882 RVA: 0x0024C9CC File Offset: 0x0024ABCC
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x060097E3 RID: 38883 RVA: 0x0024C9E4 File Offset: 0x0024ABE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x060097E4 RID: 38884 RVA: 0x0024CA08 File Offset: 0x0024AC08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0024CA1F File Offset: 0x0024AC1F
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x0024CA29 File Offset: 0x0024AC29
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.channel_ = ((other.channel_ != null) ? other.channel_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x0024CA60 File Offset: 0x0024AC60
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x060097E8 RID: 38888 RVA: 0x0024CA78 File Offset: 0x0024AC78
		// (set) Token: 0x060097E9 RID: 38889 RVA: 0x0024CA90 File Offset: 0x0024AC90
		[DebuggerNonUserCode]
		public Channel Channel
		{
			get
			{
				return this.channel_;
			}
			set
			{
				this.channel_ = value;
			}
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x0024CA9C File Offset: 0x0024AC9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x0024CABC File Offset: 0x0024ACBC
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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
					bool flag4 = !object.Equals(this.Channel, other.Channel);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x0024CB18 File Offset: 0x0024AD18
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channel_ != null;
			if (flag)
			{
				num ^= this.Channel.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x0024CB68 File Offset: 0x0024AD68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x0024CB80 File Offset: 0x0024AD80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x0024CB8C File Offset: 0x0024AD8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channel_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Channel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x0024CBDC File Offset: 0x0024ADDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channel_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Channel);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x0024CC30 File Offset: 0x0024AE30
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channel_ != null;
				if (flag2)
				{
					bool flag3 = this.channel_ == null;
					if (flag3)
					{
						this.Channel = new Channel();
					}
					this.Channel.MergeFrom(other.Channel);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x0024CC9C File Offset: 0x0024AE9C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x0024CCA8 File Offset: 0x0024AEA8
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
					bool flag = this.channel_ == null;
					if (flag)
					{
						this.Channel = new Channel();
					}
					input.ReadMessage(this.Channel);
				}
			}
		}

		// Token: 0x04004475 RID: 17525
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04004476 RID: 17526
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004477 RID: 17527
		public const int ChannelFieldNumber = 1;

		// Token: 0x04004478 RID: 17528
		private Channel channel_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DB RID: 1243
	public sealed class CreateMessageResponse : IMessage<CreateMessageResponse>, IMessage, IEquatable<CreateMessageResponse>, IDeepCloneable<CreateMessageResponse>, IBufferMessage
	{
		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x060078DD RID: 30941 RVA: 0x001D6228 File Offset: 0x001D4428
		[DebuggerNonUserCode]
		public static MessageParser<CreateMessageResponse> Parser
		{
			get
			{
				return CreateMessageResponse._parser;
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x001D6240 File Offset: 0x001D4440
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[64];
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x001D6264 File Offset: 0x001D4464
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateMessageResponse.Descriptor;
			}
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x001D627B File Offset: 0x001D447B
		[DebuggerNonUserCode]
		public CreateMessageResponse()
		{
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x001D6285 File Offset: 0x001D4485
		[DebuggerNonUserCode]
		public CreateMessageResponse(CreateMessageResponse other)
			: this()
		{
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x001D62BC File Offset: 0x001D44BC
		[DebuggerNonUserCode]
		public CreateMessageResponse Clone()
		{
			return new CreateMessageResponse(this);
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x060078E3 RID: 30947 RVA: 0x001D62D4 File Offset: 0x001D44D4
		// (set) Token: 0x060078E4 RID: 30948 RVA: 0x001D62EC File Offset: 0x001D44EC
		[DebuggerNonUserCode]
		public StreamMessage Message
		{
			get
			{
				return this.message_;
			}
			set
			{
				this.message_ = value;
			}
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x001D62F8 File Offset: 0x001D44F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateMessageResponse);
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x001D6318 File Offset: 0x001D4518
		[DebuggerNonUserCode]
		public bool Equals(CreateMessageResponse other)
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
					bool flag4 = !object.Equals(this.Message, other.Message);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x001D6374 File Offset: 0x001D4574
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.message_ != null;
			if (flag)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x001D63C4 File Offset: 0x001D45C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x001D63DC File Offset: 0x001D45DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x001D63E8 File Offset: 0x001D45E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.message_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x001D6438 File Offset: 0x001D4638
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.message_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x001D648C File Offset: 0x001D468C
		[DebuggerNonUserCode]
		public void MergeFrom(CreateMessageResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.message_ != null;
				if (flag2)
				{
					bool flag3 = this.message_ == null;
					if (flag3)
					{
						this.Message = new StreamMessage();
					}
					this.Message.MergeFrom(other.Message);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x001D64F8 File Offset: 0x001D46F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x001D6504 File Offset: 0x001D4704
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
					bool flag = this.message_ == null;
					if (flag)
					{
						this.Message = new StreamMessage();
					}
					input.ReadMessage(this.Message);
				}
			}
		}

		// Token: 0x040036DE RID: 14046
		private static readonly MessageParser<CreateMessageResponse> _parser = new MessageParser<CreateMessageResponse>(() => new CreateMessageResponse());

		// Token: 0x040036DF RID: 14047
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E0 RID: 14048
		public const int MessageFieldNumber = 1;

		// Token: 0x040036E1 RID: 14049
		private StreamMessage message_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DF RID: 1247
	public sealed class EditMessageResponse : IMessage<EditMessageResponse>, IMessage, IEquatable<EditMessageResponse>, IDeepCloneable<EditMessageResponse>, IBufferMessage
	{
		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x001D78B0 File Offset: 0x001D5AB0
		[DebuggerNonUserCode]
		public static MessageParser<EditMessageResponse> Parser
		{
			get
			{
				return EditMessageResponse._parser;
			}
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x06007940 RID: 31040 RVA: 0x001D78C8 File Offset: 0x001D5AC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[68];
			}
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x001D78EC File Offset: 0x001D5AEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EditMessageResponse.Descriptor;
			}
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x001D7903 File Offset: 0x001D5B03
		[DebuggerNonUserCode]
		public EditMessageResponse()
		{
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x001D790D File Offset: 0x001D5B0D
		[DebuggerNonUserCode]
		public EditMessageResponse(EditMessageResponse other)
			: this()
		{
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x001D7944 File Offset: 0x001D5B44
		[DebuggerNonUserCode]
		public EditMessageResponse Clone()
		{
			return new EditMessageResponse(this);
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x001D795C File Offset: 0x001D5B5C
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x001D7974 File Offset: 0x001D5B74
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

		// Token: 0x06007947 RID: 31047 RVA: 0x001D7980 File Offset: 0x001D5B80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EditMessageResponse);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x001D79A0 File Offset: 0x001D5BA0
		[DebuggerNonUserCode]
		public bool Equals(EditMessageResponse other)
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

		// Token: 0x06007949 RID: 31049 RVA: 0x001D79FC File Offset: 0x001D5BFC
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

		// Token: 0x0600794A RID: 31050 RVA: 0x001D7A4C File Offset: 0x001D5C4C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x001D7A64 File Offset: 0x001D5C64
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x001D7A70 File Offset: 0x001D5C70
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

		// Token: 0x0600794D RID: 31053 RVA: 0x001D7AC0 File Offset: 0x001D5CC0
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

		// Token: 0x0600794E RID: 31054 RVA: 0x001D7B14 File Offset: 0x001D5D14
		[DebuggerNonUserCode]
		public void MergeFrom(EditMessageResponse other)
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

		// Token: 0x0600794F RID: 31055 RVA: 0x001D7B80 File Offset: 0x001D5D80
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x001D7B8C File Offset: 0x001D5D8C
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

		// Token: 0x04003702 RID: 14082
		private static readonly MessageParser<EditMessageResponse> _parser = new MessageParser<EditMessageResponse>(() => new EditMessageResponse());

		// Token: 0x04003703 RID: 14083
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003704 RID: 14084
		public const int MessageFieldNumber = 1;

		// Token: 0x04003705 RID: 14085
		private StreamMessage message_;
	}
}

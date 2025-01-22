using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004DD RID: 1245
	public sealed class DestroyMessageResponse : IMessage<DestroyMessageResponse>, IMessage, IEquatable<DestroyMessageResponse>, IDeepCloneable<DestroyMessageResponse>, IBufferMessage
	{
		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600790D RID: 30989 RVA: 0x001D6CCC File Offset: 0x001D4ECC
		[DebuggerNonUserCode]
		public static MessageParser<DestroyMessageResponse> Parser
		{
			get
			{
				return DestroyMessageResponse._parser;
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x001D6CE4 File Offset: 0x001D4EE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[66];
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600790F RID: 30991 RVA: 0x001D6D08 File Offset: 0x001D4F08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyMessageResponse.Descriptor;
			}
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x001D6D1F File Offset: 0x001D4F1F
		[DebuggerNonUserCode]
		public DestroyMessageResponse()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x001D6D29 File Offset: 0x001D4F29
		[DebuggerNonUserCode]
		public DestroyMessageResponse(DestroyMessageResponse other)
			: this()
		{
			this.message_ = ((other.message_ != null) ? other.message_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x001D6D60 File Offset: 0x001D4F60
		[DebuggerNonUserCode]
		public DestroyMessageResponse Clone()
		{
			return new DestroyMessageResponse(this);
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x001D6D78 File Offset: 0x001D4F78
		// (set) Token: 0x06007914 RID: 30996 RVA: 0x001D6D90 File Offset: 0x001D4F90
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

		// Token: 0x06007915 RID: 30997 RVA: 0x001D6D9C File Offset: 0x001D4F9C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyMessageResponse);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x001D6DBC File Offset: 0x001D4FBC
		[DebuggerNonUserCode]
		public bool Equals(DestroyMessageResponse other)
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

		// Token: 0x06007917 RID: 30999 RVA: 0x001D6E18 File Offset: 0x001D5018
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

		// Token: 0x06007918 RID: 31000 RVA: 0x001D6E68 File Offset: 0x001D5068
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007919 RID: 31001 RVA: 0x001D6E80 File Offset: 0x001D5080
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x001D6E8C File Offset: 0x001D508C
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

		// Token: 0x0600791B RID: 31003 RVA: 0x001D6EDC File Offset: 0x001D50DC
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

		// Token: 0x0600791C RID: 31004 RVA: 0x001D6F30 File Offset: 0x001D5130
		[DebuggerNonUserCode]
		public void MergeFrom(DestroyMessageResponse other)
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

		// Token: 0x0600791D RID: 31005 RVA: 0x001D6F9C File Offset: 0x001D519C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x001D6FA8 File Offset: 0x001D51A8
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

		// Token: 0x040036EF RID: 14063
		private static readonly MessageParser<DestroyMessageResponse> _parser = new MessageParser<DestroyMessageResponse>(() => new DestroyMessageResponse());

		// Token: 0x040036F0 RID: 14064
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F1 RID: 14065
		public const int MessageFieldNumber = 1;

		// Token: 0x040036F2 RID: 14066
		private StreamMessage message_;
	}
}

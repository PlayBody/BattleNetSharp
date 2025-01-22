using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000BE RID: 190
	public sealed class QuestChangeListResponse : IMessage<QuestChangeListResponse>, IMessage, IEquatable<QuestChangeListResponse>, IDeepCloneable<QuestChangeListResponse>, IBufferMessage
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00041E18 File Offset: 0x00040018
		[DebuggerNonUserCode]
		public static MessageParser<QuestChangeListResponse> Parser
		{
			get
			{
				return QuestChangeListResponse._parser;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00041E30 File Offset: 0x00040030
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[167];
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00041E58 File Offset: 0x00040058
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestChangeListResponse.Descriptor;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00041E6F File Offset: 0x0004006F
		[DebuggerNonUserCode]
		public QuestChangeListResponse()
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00041E79 File Offset: 0x00040079
		[DebuggerNonUserCode]
		public QuestChangeListResponse(QuestChangeListResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.responseType_ = other.responseType_;
			this.message_ = other.message_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00041EB8 File Offset: 0x000400B8
		[DebuggerNonUserCode]
		public QuestChangeListResponse Clone()
		{
			return new QuestChangeListResponse(this);
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00041ED0 File Offset: 0x000400D0
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00041F01 File Offset: 0x00040101
		[DebuggerNonUserCode]
		public QuestChangeListResponse.Types.ResponseType ResponseType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				QuestChangeListResponse.Types.ResponseType responseTypeDefaultValue;
				if (flag)
				{
					responseTypeDefaultValue = this.responseType_;
				}
				else
				{
					responseTypeDefaultValue = QuestChangeListResponse.ResponseTypeDefaultValue;
				}
				return responseTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.responseType_ = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00041F1C File Offset: 0x0004011C
		[DebuggerNonUserCode]
		public bool HasResponseType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00041F39 File Offset: 0x00040139
		[DebuggerNonUserCode]
		public void ClearResponseType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00041F4C File Offset: 0x0004014C
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00041F6D File Offset: 0x0004016D
		[DebuggerNonUserCode]
		public string Message
		{
			get
			{
				return this.message_ ?? QuestChangeListResponse.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00041F84 File Offset: 0x00040184
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00041F9F File Offset: 0x0004019F
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00041FAC File Offset: 0x000401AC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestChangeListResponse);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00041FCC File Offset: 0x000401CC
		[DebuggerNonUserCode]
		public bool Equals(QuestChangeListResponse other)
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
					bool flag4 = this.ResponseType != other.ResponseType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Message != other.Message;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00042040 File Offset: 0x00040240
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasResponseType = this.HasResponseType;
			if (hasResponseType)
			{
				num ^= this.ResponseType.GetHashCode();
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000420B0 File Offset: 0x000402B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x000420C8 File Offset: 0x000402C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000420D4 File Offset: 0x000402D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasResponseType = this.HasResponseType;
			if (hasResponseType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ResponseType);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00042144 File Offset: 0x00040344
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasResponseType = this.HasResponseType;
			if (hasResponseType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ResponseType);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x000421B0 File Offset: 0x000403B0
		[DebuggerNonUserCode]
		public void MergeFrom(QuestChangeListResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasResponseType = other.HasResponseType;
				if (hasResponseType)
				{
					this.ResponseType = other.ResponseType;
				}
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00042212 File Offset: 0x00040412
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00042220 File Offset: 0x00040420
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Message = input.ReadString();
					}
				}
				else
				{
					this.ResponseType = (QuestChangeListResponse.Types.ResponseType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000736 RID: 1846
		private static readonly MessageParser<QuestChangeListResponse> _parser = new MessageParser<QuestChangeListResponse>(() => new QuestChangeListResponse());

		// Token: 0x04000737 RID: 1847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000738 RID: 1848
		private int _hasBits0;

		// Token: 0x04000739 RID: 1849
		public const int ResponseTypeFieldNumber = 1;

		// Token: 0x0400073A RID: 1850
		private static readonly QuestChangeListResponse.Types.ResponseType ResponseTypeDefaultValue = QuestChangeListResponse.Types.ResponseType.Ok;

		// Token: 0x0400073B RID: 1851
		private QuestChangeListResponse.Types.ResponseType responseType_;

		// Token: 0x0400073C RID: 1852
		public const int MessageFieldNumber = 2;

		// Token: 0x0400073D RID: 1853
		private static readonly string MessageDefaultValue = "";

		// Token: 0x0400073E RID: 1854
		private string message_;

		// Token: 0x02000BD7 RID: 3031
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001467 RID: 5223
			public enum ResponseType
			{
				// Token: 0x0400A2B6 RID: 41654
				[OriginalName("OK")]
				Ok = 1,
				// Token: 0x0400A2B7 RID: 41655
				[OriginalName("WARNING")]
				Warning,
				// Token: 0x0400A2B8 RID: 41656
				[OriginalName("CRITICAL")]
				Critical
			}
		}
	}
}

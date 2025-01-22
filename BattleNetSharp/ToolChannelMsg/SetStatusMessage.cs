using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000034 RID: 52
	public sealed class SetStatusMessage : IMessage<SetStatusMessage>, IMessage, IEquatable<SetStatusMessage>, IDeepCloneable<SetStatusMessage>, IBufferMessage
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00012D30 File Offset: 0x00010F30
		[DebuggerNonUserCode]
		public static MessageParser<SetStatusMessage> Parser
		{
			get
			{
				return SetStatusMessage._parser;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00012D48 File Offset: 0x00010F48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[29];
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00012D6C File Offset: 0x00010F6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetStatusMessage.Descriptor;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00012D83 File Offset: 0x00010F83
		[DebuggerNonUserCode]
		public SetStatusMessage()
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00012D8D File Offset: 0x00010F8D
		[DebuggerNonUserCode]
		public SetStatusMessage(SetStatusMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.message_ = other.message_;
			this.infiniteDuration_ = other.infiniteDuration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00012DCC File Offset: 0x00010FCC
		[DebuggerNonUserCode]
		public SetStatusMessage Clone()
		{
			return new SetStatusMessage(this);
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00012DE4 File Offset: 0x00010FE4
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00012E05 File Offset: 0x00011005
		[DebuggerNonUserCode]
		public string Message
		{
			get
			{
				return this.message_ ?? SetStatusMessage.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00012E1C File Offset: 0x0001101C
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00012E37 File Offset: 0x00011037
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00012E44 File Offset: 0x00011044
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00012E75 File Offset: 0x00011075
		[DebuggerNonUserCode]
		public bool InfiniteDuration
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool infiniteDurationDefaultValue;
				if (flag)
				{
					infiniteDurationDefaultValue = this.infiniteDuration_;
				}
				else
				{
					infiniteDurationDefaultValue = SetStatusMessage.InfiniteDurationDefaultValue;
				}
				return infiniteDurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.infiniteDuration_ = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00012E90 File Offset: 0x00011090
		[DebuggerNonUserCode]
		public bool HasInfiniteDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00012EAD File Offset: 0x000110AD
		[DebuggerNonUserCode]
		public void ClearInfiniteDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00012EC0 File Offset: 0x000110C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetStatusMessage);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00012EE0 File Offset: 0x000110E0
		[DebuggerNonUserCode]
		public bool Equals(SetStatusMessage other)
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
					bool flag4 = this.Message != other.Message;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.InfiniteDuration != other.InfiniteDuration;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00012F54 File Offset: 0x00011154
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num ^= this.Message.GetHashCode();
			}
			bool hasInfiniteDuration = this.HasInfiniteDuration;
			if (hasInfiniteDuration)
			{
				num ^= this.InfiniteDuration.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00012FC0 File Offset: 0x000111C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00012FD8 File Offset: 0x000111D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00012FE4 File Offset: 0x000111E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Message);
			}
			bool hasInfiniteDuration = this.HasInfiniteDuration;
			if (hasInfiniteDuration)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.InfiniteDuration);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00013054 File Offset: 0x00011254
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Message);
			}
			bool hasInfiniteDuration = this.HasInfiniteDuration;
			if (hasInfiniteDuration)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000130B4 File Offset: 0x000112B4
		[DebuggerNonUserCode]
		public void MergeFrom(SetStatusMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				bool hasInfiniteDuration = other.HasInfiniteDuration;
				if (hasInfiniteDuration)
				{
					this.InfiniteDuration = other.InfiniteDuration;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00013116 File Offset: 0x00011316
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00013124 File Offset: 0x00011324
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InfiniteDuration = input.ReadBool();
					}
				}
				else
				{
					this.Message = input.ReadString();
				}
			}
		}

		// Token: 0x0400017B RID: 379
		private static readonly MessageParser<SetStatusMessage> _parser = new MessageParser<SetStatusMessage>(() => new SetStatusMessage());

		// Token: 0x0400017C RID: 380
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400017D RID: 381
		private int _hasBits0;

		// Token: 0x0400017E RID: 382
		public const int MessageFieldNumber = 1;

		// Token: 0x0400017F RID: 383
		private static readonly string MessageDefaultValue = "";

		// Token: 0x04000180 RID: 384
		private string message_;

		// Token: 0x04000181 RID: 385
		public const int InfiniteDurationFieldNumber = 2;

		// Token: 0x04000182 RID: 386
		private static readonly bool InfiniteDurationDefaultValue = false;

		// Token: 0x04000183 RID: 387
		private bool infiniteDuration_;
	}
}

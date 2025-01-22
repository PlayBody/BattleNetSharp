using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000605 RID: 1541
	public sealed class ModuleLoadRequest : IMessage<ModuleLoadRequest>, IMessage, IEquatable<ModuleLoadRequest>, IDeepCloneable<ModuleLoadRequest>, IBufferMessage
	{
		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x0022F440 File Offset: 0x0022D640
		[DebuggerNonUserCode]
		public static MessageParser<ModuleLoadRequest> Parser
		{
			get
			{
				return ModuleLoadRequest._parser;
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600900D RID: 36877 RVA: 0x0022F458 File Offset: 0x0022D658
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x0022F47C File Offset: 0x0022D67C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleLoadRequest.Descriptor;
			}
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0022F493 File Offset: 0x0022D693
		[DebuggerNonUserCode]
		public ModuleLoadRequest()
		{
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0022F4A0 File Offset: 0x0022D6A0
		[DebuggerNonUserCode]
		public ModuleLoadRequest(ModuleLoadRequest other)
			: this()
		{
			this.moduleHandle_ = ((other.moduleHandle_ != null) ? other.moduleHandle_.Clone() : null);
			this.message_ = other.message_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0022F4F0 File Offset: 0x0022D6F0
		[DebuggerNonUserCode]
		public ModuleLoadRequest Clone()
		{
			return new ModuleLoadRequest(this);
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x0022F508 File Offset: 0x0022D708
		// (set) Token: 0x06009013 RID: 36883 RVA: 0x0022F520 File Offset: 0x0022D720
		[DebuggerNonUserCode]
		public ContentHandle ModuleHandle
		{
			get
			{
				return this.moduleHandle_;
			}
			set
			{
				this.moduleHandle_ = value;
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x06009014 RID: 36884 RVA: 0x0022F52C File Offset: 0x0022D72C
		// (set) Token: 0x06009015 RID: 36885 RVA: 0x0022F54D File Offset: 0x0022D74D
		[DebuggerNonUserCode]
		public ByteString Message
		{
			get
			{
				return this.message_ ?? ModuleLoadRequest.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x06009016 RID: 36886 RVA: 0x0022F564 File Offset: 0x0022D764
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0022F582 File Offset: 0x0022D782
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x0022F58C File Offset: 0x0022D78C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleLoadRequest);
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0022F5AC File Offset: 0x0022D7AC
		[DebuggerNonUserCode]
		public bool Equals(ModuleLoadRequest other)
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
					bool flag4 = !object.Equals(this.ModuleHandle, other.ModuleHandle);
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

		// Token: 0x0600901A RID: 36890 RVA: 0x0022F620 File Offset: 0x0022D820
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.moduleHandle_ != null;
			if (flag)
			{
				num ^= this.ModuleHandle.GetHashCode();
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
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

		// Token: 0x0600901B RID: 36891 RVA: 0x0022F688 File Offset: 0x0022D888
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0022F6A0 File Offset: 0x0022D8A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0022F6AC File Offset: 0x0022D8AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.moduleHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ModuleHandle);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0022F720 File Offset: 0x0022D920
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.moduleHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModuleHandle);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0022F790 File Offset: 0x0022D990
		[DebuggerNonUserCode]
		public void MergeFrom(ModuleLoadRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.moduleHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.moduleHandle_ == null;
					if (flag3)
					{
						this.ModuleHandle = new ContentHandle();
					}
					this.ModuleHandle.MergeFrom(other.ModuleHandle);
				}
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0022F815 File Offset: 0x0022DA15
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0022F820 File Offset: 0x0022DA20
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Message = input.ReadBytes();
					}
				}
				else
				{
					bool flag = this.moduleHandle_ == null;
					if (flag)
					{
						this.ModuleHandle = new ContentHandle();
					}
					input.ReadMessage(this.ModuleHandle);
				}
			}
		}

		// Token: 0x04004109 RID: 16649
		private static readonly MessageParser<ModuleLoadRequest> _parser = new MessageParser<ModuleLoadRequest>(() => new ModuleLoadRequest());

		// Token: 0x0400410A RID: 16650
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400410B RID: 16651
		public const int ModuleHandleFieldNumber = 1;

		// Token: 0x0400410C RID: 16652
		private ContentHandle moduleHandle_;

		// Token: 0x0400410D RID: 16653
		public const int MessageFieldNumber = 2;

		// Token: 0x0400410E RID: 16654
		private static readonly ByteString MessageDefaultValue = ByteString.Empty;

		// Token: 0x0400410F RID: 16655
		private ByteString message_;
	}
}

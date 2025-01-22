using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000607 RID: 1543
	public sealed class ModuleMessageRequest : IMessage<ModuleMessageRequest>, IMessage, IEquatable<ModuleMessageRequest>, IDeepCloneable<ModuleMessageRequest>, IBufferMessage
	{
		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x0022FD7C File Offset: 0x0022DF7C
		[DebuggerNonUserCode]
		public static MessageParser<ModuleMessageRequest> Parser
		{
			get
			{
				return ModuleMessageRequest._parser;
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600903D RID: 36925 RVA: 0x0022FD94 File Offset: 0x0022DF94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x0022FDB8 File Offset: 0x0022DFB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleMessageRequest.Descriptor;
			}
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x0022FDCF File Offset: 0x0022DFCF
		[DebuggerNonUserCode]
		public ModuleMessageRequest()
		{
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x0022FDD9 File Offset: 0x0022DFD9
		[DebuggerNonUserCode]
		public ModuleMessageRequest(ModuleMessageRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.moduleId_ = other.moduleId_;
			this.message_ = other.message_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0022FE18 File Offset: 0x0022E018
		[DebuggerNonUserCode]
		public ModuleMessageRequest Clone()
		{
			return new ModuleMessageRequest(this);
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x06009042 RID: 36930 RVA: 0x0022FE30 File Offset: 0x0022E030
		// (set) Token: 0x06009043 RID: 36931 RVA: 0x0022FE61 File Offset: 0x0022E061
		[DebuggerNonUserCode]
		public int ModuleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int moduleIdDefaultValue;
				if (flag)
				{
					moduleIdDefaultValue = this.moduleId_;
				}
				else
				{
					moduleIdDefaultValue = ModuleMessageRequest.ModuleIdDefaultValue;
				}
				return moduleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.moduleId_ = value;
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x06009044 RID: 36932 RVA: 0x0022FE7C File Offset: 0x0022E07C
		[DebuggerNonUserCode]
		public bool HasModuleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0022FE99 File Offset: 0x0022E099
		[DebuggerNonUserCode]
		public void ClearModuleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x06009046 RID: 36934 RVA: 0x0022FEAC File Offset: 0x0022E0AC
		// (set) Token: 0x06009047 RID: 36935 RVA: 0x0022FECD File Offset: 0x0022E0CD
		[DebuggerNonUserCode]
		public ByteString Message
		{
			get
			{
				return this.message_ ?? ModuleMessageRequest.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x0022FEE4 File Offset: 0x0022E0E4
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x0022FF02 File Offset: 0x0022E102
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x0022FF0C File Offset: 0x0022E10C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleMessageRequest);
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x0022FF2C File Offset: 0x0022E12C
		[DebuggerNonUserCode]
		public bool Equals(ModuleMessageRequest other)
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
					bool flag4 = this.ModuleId != other.ModuleId;
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

		// Token: 0x0600904C RID: 36940 RVA: 0x0022FFA0 File Offset: 0x0022E1A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				num ^= this.ModuleId.GetHashCode();
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

		// Token: 0x0600904D RID: 36941 RVA: 0x0023000C File Offset: 0x0022E20C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x00230024 File Offset: 0x0022E224
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x00230030 File Offset: 0x0022E230
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ModuleId);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x002300A0 File Offset: 0x0022E2A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModuleId);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x0023010C File Offset: 0x0022E30C
		[DebuggerNonUserCode]
		public void MergeFrom(ModuleMessageRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasModuleId = other.HasModuleId;
				if (hasModuleId)
				{
					this.ModuleId = other.ModuleId;
				}
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x0023016E File Offset: 0x0022E36E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x0023017C File Offset: 0x0022E37C
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
						this.Message = input.ReadBytes();
					}
				}
				else
				{
					this.ModuleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004119 RID: 16665
		private static readonly MessageParser<ModuleMessageRequest> _parser = new MessageParser<ModuleMessageRequest>(() => new ModuleMessageRequest());

		// Token: 0x0400411A RID: 16666
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400411B RID: 16667
		private int _hasBits0;

		// Token: 0x0400411C RID: 16668
		public const int ModuleIdFieldNumber = 1;

		// Token: 0x0400411D RID: 16669
		private static readonly int ModuleIdDefaultValue = 0;

		// Token: 0x0400411E RID: 16670
		private int moduleId_;

		// Token: 0x0400411F RID: 16671
		public const int MessageFieldNumber = 2;

		// Token: 0x04004120 RID: 16672
		private static readonly ByteString MessageDefaultValue = ByteString.Empty;

		// Token: 0x04004121 RID: 16673
		private ByteString message_;
	}
}

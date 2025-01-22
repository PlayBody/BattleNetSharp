using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000606 RID: 1542
	public sealed class ModuleNotification : IMessage<ModuleNotification>, IMessage, IEquatable<ModuleNotification>, IDeepCloneable<ModuleNotification>, IBufferMessage
	{
		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x06009023 RID: 36899 RVA: 0x0022F8CC File Offset: 0x0022DACC
		[DebuggerNonUserCode]
		public static MessageParser<ModuleNotification> Parser
		{
			get
			{
				return ModuleNotification._parser;
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x0022F8E4 File Offset: 0x0022DAE4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x06009025 RID: 36901 RVA: 0x0022F908 File Offset: 0x0022DB08
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModuleNotification.Descriptor;
			}
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0022F91F File Offset: 0x0022DB1F
		[DebuggerNonUserCode]
		public ModuleNotification()
		{
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0022F929 File Offset: 0x0022DB29
		[DebuggerNonUserCode]
		public ModuleNotification(ModuleNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.moduleId_ = other.moduleId_;
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0022F968 File Offset: 0x0022DB68
		[DebuggerNonUserCode]
		public ModuleNotification Clone()
		{
			return new ModuleNotification(this);
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x06009029 RID: 36905 RVA: 0x0022F980 File Offset: 0x0022DB80
		// (set) Token: 0x0600902A RID: 36906 RVA: 0x0022F9B1 File Offset: 0x0022DBB1
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
					moduleIdDefaultValue = ModuleNotification.ModuleIdDefaultValue;
				}
				return moduleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.moduleId_ = value;
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600902B RID: 36907 RVA: 0x0022F9CC File Offset: 0x0022DBCC
		[DebuggerNonUserCode]
		public bool HasModuleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0022F9E9 File Offset: 0x0022DBE9
		[DebuggerNonUserCode]
		public void ClearModuleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600902D RID: 36909 RVA: 0x0022F9FC File Offset: 0x0022DBFC
		// (set) Token: 0x0600902E RID: 36910 RVA: 0x0022FA2D File Offset: 0x0022DC2D
		[DebuggerNonUserCode]
		public uint Result
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint resultDefaultValue;
				if (flag)
				{
					resultDefaultValue = this.result_;
				}
				else
				{
					resultDefaultValue = ModuleNotification.ResultDefaultValue;
				}
				return resultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.result_ = value;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600902F RID: 36911 RVA: 0x0022FA48 File Offset: 0x0022DC48
		[DebuggerNonUserCode]
		public bool HasResult
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x0022FA65 File Offset: 0x0022DC65
		[DebuggerNonUserCode]
		public void ClearResult()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x0022FA78 File Offset: 0x0022DC78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModuleNotification);
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x0022FA98 File Offset: 0x0022DC98
		[DebuggerNonUserCode]
		public bool Equals(ModuleNotification other)
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
						bool flag5 = this.Result != other.Result;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x0022FB0C File Offset: 0x0022DD0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				num ^= this.ModuleId.GetHashCode();
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num ^= this.Result.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x0022FB7C File Offset: 0x0022DD7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x0022FB94 File Offset: 0x0022DD94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x0022FBA0 File Offset: 0x0022DDA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ModuleId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Result);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x0022FC10 File Offset: 0x0022DE10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasModuleId = this.HasModuleId;
			if (hasModuleId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ModuleId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0022FC7C File Offset: 0x0022DE7C
		[DebuggerNonUserCode]
		public void MergeFrom(ModuleNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasModuleId = other.HasModuleId;
				if (hasModuleId)
				{
					this.ModuleId = other.ModuleId;
				}
				bool hasResult = other.HasResult;
				if (hasResult)
				{
					this.Result = other.Result;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0022FCDE File Offset: 0x0022DEDE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x0022FCEC File Offset: 0x0022DEEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					if (num3 != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Result = input.ReadUInt32();
					}
				}
				else
				{
					this.ModuleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004110 RID: 16656
		private static readonly MessageParser<ModuleNotification> _parser = new MessageParser<ModuleNotification>(() => new ModuleNotification());

		// Token: 0x04004111 RID: 16657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004112 RID: 16658
		private int _hasBits0;

		// Token: 0x04004113 RID: 16659
		public const int ModuleIdFieldNumber = 2;

		// Token: 0x04004114 RID: 16660
		private static readonly int ModuleIdDefaultValue = 0;

		// Token: 0x04004115 RID: 16661
		private int moduleId_;

		// Token: 0x04004116 RID: 16662
		public const int ResultFieldNumber = 3;

		// Token: 0x04004117 RID: 16663
		private static readonly uint ResultDefaultValue = 0U;

		// Token: 0x04004118 RID: 16664
		private uint result_;
	}
}

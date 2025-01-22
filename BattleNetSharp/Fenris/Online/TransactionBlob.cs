using System;
using System.Diagnostics;
using Fenris.AccountMigration;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000151 RID: 337
	public sealed class TransactionBlob : IMessage<TransactionBlob>, IMessage, IEquatable<TransactionBlob>, IDeepCloneable<TransactionBlob>, IBufferMessage
	{
		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00087A44 File Offset: 0x00085C44
		[DebuggerNonUserCode]
		public static MessageParser<TransactionBlob> Parser
		{
			get
			{
				return TransactionBlob._parser;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x00087A5C File Offset: 0x00085C5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[18];
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00087A80 File Offset: 0x00085C80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransactionBlob.Descriptor;
			}
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00087A97 File Offset: 0x00085C97
		[DebuggerNonUserCode]
		public TransactionBlob()
		{
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00087AA8 File Offset: 0x00085CA8
		[DebuggerNonUserCode]
		public TransactionBlob(TransactionBlob other)
			: this()
		{
			TransactionBlob.MessageOneofCase messageCase = other.MessageCase;
			TransactionBlob.MessageOneofCase messageOneofCase = messageCase;
			if (messageOneofCase == TransactionBlob.MessageOneofCase.AccountMigration)
			{
				this.AccountMigration = other.AccountMigration.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00087AF4 File Offset: 0x00085CF4
		[DebuggerNonUserCode]
		public TransactionBlob Clone()
		{
			return new TransactionBlob(this);
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00087B0C File Offset: 0x00085D0C
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x00087B35 File Offset: 0x00085D35
		[DebuggerNonUserCode]
		public MigrationData AccountMigration
		{
			get
			{
				return (this.messageCase_ == TransactionBlob.MessageOneofCase.AccountMigration) ? ((MigrationData)this.message_) : null;
			}
			set
			{
				this.message_ = value;
				this.messageCase_ = ((value == null) ? TransactionBlob.MessageOneofCase.None : TransactionBlob.MessageOneofCase.AccountMigration);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00087B4C File Offset: 0x00085D4C
		[DebuggerNonUserCode]
		public TransactionBlob.MessageOneofCase MessageCase
		{
			get
			{
				return this.messageCase_;
			}
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00087B64 File Offset: 0x00085D64
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.messageCase_ = TransactionBlob.MessageOneofCase.None;
			this.message_ = null;
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00087B78 File Offset: 0x00085D78
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransactionBlob);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00087B98 File Offset: 0x00085D98
		[DebuggerNonUserCode]
		public bool Equals(TransactionBlob other)
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
					bool flag4 = !object.Equals(this.AccountMigration, other.AccountMigration);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MessageCase != other.MessageCase;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00087C0C File Offset: 0x00085E0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.messageCase_ == TransactionBlob.MessageOneofCase.AccountMigration;
			if (flag)
			{
				num ^= this.AccountMigration.GetHashCode();
			}
			num ^= (int)this.messageCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00087C64 File Offset: 0x00085E64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00087C7C File Offset: 0x00085E7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00087C88 File Offset: 0x00085E88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.messageCase_ == TransactionBlob.MessageOneofCase.AccountMigration;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AccountMigration);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00087CD8 File Offset: 0x00085ED8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.messageCase_ == TransactionBlob.MessageOneofCase.AccountMigration;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountMigration);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00087D2C File Offset: 0x00085F2C
		[DebuggerNonUserCode]
		public void MergeFrom(TransactionBlob other)
		{
			bool flag = other == null;
			if (!flag)
			{
				TransactionBlob.MessageOneofCase messageCase = other.MessageCase;
				TransactionBlob.MessageOneofCase messageOneofCase = messageCase;
				if (messageOneofCase == TransactionBlob.MessageOneofCase.AccountMigration)
				{
					bool flag2 = this.AccountMigration == null;
					if (flag2)
					{
						this.AccountMigration = new MigrationData();
					}
					this.AccountMigration.MergeFrom(other.AccountMigration);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00087D9A File Offset: 0x00085F9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00087DA8 File Offset: 0x00085FA8
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
					MigrationData migrationData = new MigrationData();
					bool flag = this.messageCase_ == TransactionBlob.MessageOneofCase.AccountMigration;
					if (flag)
					{
						migrationData.MergeFrom(this.AccountMigration);
					}
					input.ReadMessage(migrationData);
					this.AccountMigration = migrationData;
				}
			}
		}

		// Token: 0x04000F5D RID: 3933
		private static readonly MessageParser<TransactionBlob> _parser = new MessageParser<TransactionBlob>(() => new TransactionBlob());

		// Token: 0x04000F5E RID: 3934
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F5F RID: 3935
		public const int AccountMigrationFieldNumber = 1;

		// Token: 0x04000F60 RID: 3936
		private object message_;

		// Token: 0x04000F61 RID: 3937
		private TransactionBlob.MessageOneofCase messageCase_ = TransactionBlob.MessageOneofCase.None;

		// Token: 0x02000C6F RID: 3183
		public enum MessageOneofCase
		{
			// Token: 0x040093CD RID: 37837
			None,
			// Token: 0x040093CE RID: 37838
			AccountMigration
		}
	}
}

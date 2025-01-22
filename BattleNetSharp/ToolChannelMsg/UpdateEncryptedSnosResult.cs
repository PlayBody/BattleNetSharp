using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FF RID: 255
	public sealed class UpdateEncryptedSnosResult : IMessage<UpdateEncryptedSnosResult>, IMessage, IEquatable<UpdateEncryptedSnosResult>, IDeepCloneable<UpdateEncryptedSnosResult>, IBufferMessage
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0005723C File Offset: 0x0005543C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateEncryptedSnosResult> Parser
		{
			get
			{
				return UpdateEncryptedSnosResult._parser;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00057254 File Offset: 0x00055454
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[232];
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0005727C File Offset: 0x0005547C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEncryptedSnosResult.Descriptor;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00057293 File Offset: 0x00055493
		[DebuggerNonUserCode]
		public UpdateEncryptedSnosResult()
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0005729D File Offset: 0x0005549D
		[DebuggerNonUserCode]
		public UpdateEncryptedSnosResult(UpdateEncryptedSnosResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000572D0 File Offset: 0x000554D0
		[DebuggerNonUserCode]
		public UpdateEncryptedSnosResult Clone()
		{
			return new UpdateEncryptedSnosResult(this);
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000572E8 File Offset: 0x000554E8
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x00057319 File Offset: 0x00055519
		[DebuggerNonUserCode]
		public bool Success
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool successDefaultValue;
				if (flag)
				{
					successDefaultValue = this.success_;
				}
				else
				{
					successDefaultValue = UpdateEncryptedSnosResult.SuccessDefaultValue;
				}
				return successDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.success_ = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00057334 File Offset: 0x00055534
		[DebuggerNonUserCode]
		public bool HasSuccess
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00057351 File Offset: 0x00055551
		[DebuggerNonUserCode]
		public void ClearSuccess()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00057364 File Offset: 0x00055564
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEncryptedSnosResult);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00057384 File Offset: 0x00055584
		[DebuggerNonUserCode]
		public bool Equals(UpdateEncryptedSnosResult other)
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
					bool flag4 = this.Success != other.Success;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x000573DC File Offset: 0x000555DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				num ^= this.Success.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0005742C File Offset: 0x0005562C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00057444 File Offset: 0x00055644
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00057450 File Offset: 0x00055650
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Success);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0005749C File Offset: 0x0005569C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSuccess = this.HasSuccess;
			if (hasSuccess)
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

		// Token: 0x06001878 RID: 6264 RVA: 0x000574E0 File Offset: 0x000556E0
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateEncryptedSnosResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSuccess = other.HasSuccess;
				if (hasSuccess)
				{
					this.Success = other.Success;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00057529 File Offset: 0x00055729
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00057534 File Offset: 0x00055734
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x040009BE RID: 2494
		private static readonly MessageParser<UpdateEncryptedSnosResult> _parser = new MessageParser<UpdateEncryptedSnosResult>(() => new UpdateEncryptedSnosResult());

		// Token: 0x040009BF RID: 2495
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009C0 RID: 2496
		private int _hasBits0;

		// Token: 0x040009C1 RID: 2497
		public const int SuccessFieldNumber = 1;

		// Token: 0x040009C2 RID: 2498
		private static readonly bool SuccessDefaultValue = false;

		// Token: 0x040009C3 RID: 2499
		private bool success_;
	}
}

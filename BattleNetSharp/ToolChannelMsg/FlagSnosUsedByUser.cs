using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200008E RID: 142
	public sealed class FlagSnosUsedByUser : IMessage<FlagSnosUsedByUser>, IMessage, IEquatable<FlagSnosUsedByUser>, IDeepCloneable<FlagSnosUsedByUser>, IBufferMessage
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000311C8 File Offset: 0x0002F3C8
		[DebuggerNonUserCode]
		public static MessageParser<FlagSnosUsedByUser> Parser
		{
			get
			{
				return FlagSnosUsedByUser._parser;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000311E0 File Offset: 0x0002F3E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[119];
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00031204 File Offset: 0x0002F404
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagSnosUsedByUser.Descriptor;
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0003121B File Offset: 0x0002F41B
		[DebuggerNonUserCode]
		public FlagSnosUsedByUser()
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00031230 File Offset: 0x0002F430
		[DebuggerNonUserCode]
		public FlagSnosUsedByUser(FlagSnosUsedByUser other)
			: this()
		{
			this.sno_ = other.sno_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0003125C File Offset: 0x0002F45C
		[DebuggerNonUserCode]
		public FlagSnosUsedByUser Clone()
		{
			return new FlagSnosUsedByUser(this);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00031274 File Offset: 0x0002F474
		[DebuggerNonUserCode]
		public RepeatedField<SNOName> Sno
		{
			get
			{
				return this.sno_;
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0003128C File Offset: 0x0002F48C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagSnosUsedByUser);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000312AC File Offset: 0x0002F4AC
		[DebuggerNonUserCode]
		public bool Equals(FlagSnosUsedByUser other)
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
					bool flag4 = !this.sno_.Equals(other.sno_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00031308 File Offset: 0x0002F508
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sno_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00031348 File Offset: 0x0002F548
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00031360 File Offset: 0x0002F560
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0003136C File Offset: 0x0002F56C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sno_.WriteTo(ref output, FlagSnosUsedByUser._repeated_sno_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000313A8 File Offset: 0x0002F5A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sno_.CalculateSize(FlagSnosUsedByUser._repeated_sno_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000313F0 File Offset: 0x0002F5F0
		[DebuggerNonUserCode]
		public void MergeFrom(FlagSnosUsedByUser other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.sno_.Add(other.sno_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00031432 File Offset: 0x0002F632
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00031440 File Offset: 0x0002F640
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
					this.sno_.AddEntriesFrom(ref input, FlagSnosUsedByUser._repeated_sno_codec);
				}
			}
		}

		// Token: 0x04000532 RID: 1330
		private static readonly MessageParser<FlagSnosUsedByUser> _parser = new MessageParser<FlagSnosUsedByUser>(() => new FlagSnosUsedByUser());

		// Token: 0x04000533 RID: 1331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000534 RID: 1332
		public const int SnoFieldNumber = 1;

		// Token: 0x04000535 RID: 1333
		private static readonly FieldCodec<SNOName> _repeated_sno_codec = FieldCodec.ForMessage<SNOName>(10U, SNOName.Parser);

		// Token: 0x04000536 RID: 1334
		private readonly RepeatedField<SNOName> sno_ = new RepeatedField<SNOName>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030A RID: 778
	public sealed class LocaleUpdated : IMessage<LocaleUpdated>, IMessage, IEquatable<LocaleUpdated>, IDeepCloneable<LocaleUpdated>, IBufferMessage
	{
		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x0013E480 File Offset: 0x0013C680
		[DebuggerNonUserCode]
		public static MessageParser<LocaleUpdated> Parser
		{
			get
			{
				return LocaleUpdated._parser;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005260 RID: 21088 RVA: 0x0013E498 File Offset: 0x0013C698
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LocaleUpdatedReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x0013E4BC File Offset: 0x0013C6BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LocaleUpdated.Descriptor;
			}
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x0013E4D3 File Offset: 0x0013C6D3
		[DebuggerNonUserCode]
		public LocaleUpdated()
		{
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0013E4DD File Offset: 0x0013C6DD
		[DebuggerNonUserCode]
		public LocaleUpdated(LocaleUpdated other)
			: this()
		{
			this.localeInfo_ = ((other.localeInfo_ != null) ? other.localeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x0013E514 File Offset: 0x0013C714
		[DebuggerNonUserCode]
		public LocaleUpdated Clone()
		{
			return new LocaleUpdated(this);
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x0013E52C File Offset: 0x0013C72C
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x0013E544 File Offset: 0x0013C744
		[DebuggerNonUserCode]
		public LocaleInfo LocaleInfo
		{
			get
			{
				return this.localeInfo_;
			}
			set
			{
				this.localeInfo_ = value;
			}
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x0013E550 File Offset: 0x0013C750
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LocaleUpdated);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0013E570 File Offset: 0x0013C770
		[DebuggerNonUserCode]
		public bool Equals(LocaleUpdated other)
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
					bool flag4 = !object.Equals(this.LocaleInfo, other.LocaleInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0013E5CC File Offset: 0x0013C7CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				num ^= this.LocaleInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0013E61C File Offset: 0x0013C81C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0013E634 File Offset: 0x0013C834
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0013E640 File Offset: 0x0013C840
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.LocaleInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0013E690 File Offset: 0x0013C890
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.localeInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LocaleInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x0013E6E4 File Offset: 0x0013C8E4
		[DebuggerNonUserCode]
		public void MergeFrom(LocaleUpdated other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.localeInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.localeInfo_ == null;
					if (flag3)
					{
						this.LocaleInfo = new LocaleInfo();
					}
					this.LocaleInfo.MergeFrom(other.LocaleInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0013E750 File Offset: 0x0013C950
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0013E75C File Offset: 0x0013C95C
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
					bool flag = this.localeInfo_ == null;
					if (flag)
					{
						this.LocaleInfo = new LocaleInfo();
					}
					input.ReadMessage(this.LocaleInfo);
				}
			}
		}

		// Token: 0x04002569 RID: 9577
		private static readonly MessageParser<LocaleUpdated> _parser = new MessageParser<LocaleUpdated>(() => new LocaleUpdated());

		// Token: 0x0400256A RID: 9578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400256B RID: 9579
		public const int LocaleInfoFieldNumber = 1;

		// Token: 0x0400256C RID: 9580
		private LocaleInfo localeInfo_;
	}
}

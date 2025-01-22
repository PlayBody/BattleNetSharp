using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000745 RID: 1861
	public sealed class RAFInfo : IMessage<RAFInfo>, IMessage, IEquatable<RAFInfo>, IDeepCloneable<RAFInfo>, IBufferMessage
	{
		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x0029B1AC File Offset: 0x002993AC
		[DebuggerNonUserCode]
		public static MessageParser<RAFInfo> Parser
		{
			get
			{
				return RAFInfo._parser;
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600AB2C RID: 43820 RVA: 0x0029B1C4 File Offset: 0x002993C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x0029B1E8 File Offset: 0x002993E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RAFInfo.Descriptor;
			}
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x0029B1FF File Offset: 0x002993FF
		[DebuggerNonUserCode]
		public RAFInfo()
		{
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x0029B209 File Offset: 0x00299409
		[DebuggerNonUserCode]
		public RAFInfo(RAFInfo other)
			: this()
		{
			this.rafInfo_ = other.rafInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x0029B230 File Offset: 0x00299430
		[DebuggerNonUserCode]
		public RAFInfo Clone()
		{
			return new RAFInfo(this);
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x0029B248 File Offset: 0x00299448
		// (set) Token: 0x0600AB32 RID: 43826 RVA: 0x0029B269 File Offset: 0x00299469
		[DebuggerNonUserCode]
		public ByteString RafInfo
		{
			get
			{
				return this.rafInfo_ ?? RAFInfo.RafInfoDefaultValue;
			}
			set
			{
				this.rafInfo_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x0029B280 File Offset: 0x00299480
		[DebuggerNonUserCode]
		public bool HasRafInfo
		{
			get
			{
				return this.rafInfo_ != null;
			}
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x0029B29E File Offset: 0x0029949E
		[DebuggerNonUserCode]
		public void ClearRafInfo()
		{
			this.rafInfo_ = null;
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x0029B2A8 File Offset: 0x002994A8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RAFInfo);
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x0029B2C8 File Offset: 0x002994C8
		[DebuggerNonUserCode]
		public bool Equals(RAFInfo other)
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
					bool flag4 = this.RafInfo != other.RafInfo;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x0029B320 File Offset: 0x00299520
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRafInfo = this.HasRafInfo;
			if (hasRafInfo)
			{
				num ^= this.RafInfo.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x0029B36C File Offset: 0x0029956C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x0029B384 File Offset: 0x00299584
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB3A RID: 43834 RVA: 0x0029B390 File Offset: 0x00299590
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRafInfo = this.HasRafInfo;
			if (hasRafInfo)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.RafInfo);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x0029B3DC File Offset: 0x002995DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRafInfo = this.HasRafInfo;
			if (hasRafInfo)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.RafInfo);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x0029B42C File Offset: 0x0029962C
		[DebuggerNonUserCode]
		public void MergeFrom(RAFInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRafInfo = other.HasRafInfo;
				if (hasRafInfo)
				{
					this.RafInfo = other.RafInfo;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x0029B475 File Offset: 0x00299675
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x0029B480 File Offset: 0x00299680
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
					this.RafInfo = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004D20 RID: 19744
		private static readonly MessageParser<RAFInfo> _parser = new MessageParser<RAFInfo>(() => new RAFInfo());

		// Token: 0x04004D21 RID: 19745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D22 RID: 19746
		public const int RafInfoFieldNumber = 1;

		// Token: 0x04004D23 RID: 19747
		private static readonly ByteString RafInfoDefaultValue = ByteString.Empty;

		// Token: 0x04004D24 RID: 19748
		private ByteString rafInfo_;
	}
}

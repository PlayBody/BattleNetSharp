using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000269 RID: 617
	public sealed class ApplyToClanRequest : IMessage<ApplyToClanRequest>, IMessage, IEquatable<ApplyToClanRequest>, IDeepCloneable<ApplyToClanRequest>, IBufferMessage
	{
		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x0600423D RID: 16957 RVA: 0x001017D4 File Offset: 0x000FF9D4
		[DebuggerNonUserCode]
		public static MessageParser<ApplyToClanRequest> Parser
		{
			get
			{
				return ApplyToClanRequest._parser;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x001017EC File Offset: 0x000FF9EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[89];
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600423F RID: 16959 RVA: 0x00101810 File Offset: 0x000FFA10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyToClanRequest.Descriptor;
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00101827 File Offset: 0x000FFA27
		[DebuggerNonUserCode]
		public ApplyToClanRequest()
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00101831 File Offset: 0x000FFA31
		[DebuggerNonUserCode]
		public ApplyToClanRequest(ApplyToClanRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00101858 File Offset: 0x000FFA58
		[DebuggerNonUserCode]
		public ApplyToClanRequest Clone()
		{
			return new ApplyToClanRequest(this);
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06004243 RID: 16963 RVA: 0x00101870 File Offset: 0x000FFA70
		// (set) Token: 0x06004244 RID: 16964 RVA: 0x00101891 File Offset: 0x000FFA91
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? ApplyToClanRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06004245 RID: 16965 RVA: 0x001018A8 File Offset: 0x000FFAA8
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x001018C3 File Offset: 0x000FFAC3
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x001018D0 File Offset: 0x000FFAD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyToClanRequest);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x001018F0 File Offset: 0x000FFAF0
		[DebuggerNonUserCode]
		public bool Equals(ApplyToClanRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00101948 File Offset: 0x000FFB48
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00101994 File Offset: 0x000FFB94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x001019AC File Offset: 0x000FFBAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x001019B8 File Offset: 0x000FFBB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x00101A04 File Offset: 0x000FFC04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x00101A54 File Offset: 0x000FFC54
		[DebuggerNonUserCode]
		public void MergeFrom(ApplyToClanRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x00101A9D File Offset: 0x000FFC9D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x00101AA8 File Offset: 0x000FFCA8
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
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DFD RID: 7677
		private static readonly MessageParser<ApplyToClanRequest> _parser = new MessageParser<ApplyToClanRequest>(() => new ApplyToClanRequest());

		// Token: 0x04001DFE RID: 7678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DFF RID: 7679
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E00 RID: 7680
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E01 RID: 7681
		private string clanId_;
	}
}

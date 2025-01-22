using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026F RID: 623
	public sealed class GetClanProfileRequest : IMessage<GetClanProfileRequest>, IMessage, IEquatable<GetClanProfileRequest>, IDeepCloneable<GetClanProfileRequest>, IBufferMessage
	{
		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x00103470 File Offset: 0x00101670
		[DebuggerNonUserCode]
		public static MessageParser<GetClanProfileRequest> Parser
		{
			get
			{
				return GetClanProfileRequest._parser;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x00103488 File Offset: 0x00101688
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[95];
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x001034AC File Offset: 0x001016AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClanProfileRequest.Descriptor;
			}
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x001034C3 File Offset: 0x001016C3
		[DebuggerNonUserCode]
		public GetClanProfileRequest()
		{
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x001034CD File Offset: 0x001016CD
		[DebuggerNonUserCode]
		public GetClanProfileRequest(GetClanProfileRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x001034F4 File Offset: 0x001016F4
		[DebuggerNonUserCode]
		public GetClanProfileRequest Clone()
		{
			return new GetClanProfileRequest(this);
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x0010350C File Offset: 0x0010170C
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x0010352D File Offset: 0x0010172D
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? GetClanProfileRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x00103544 File Offset: 0x00101744
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x0010355F File Offset: 0x0010175F
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x0010356C File Offset: 0x0010176C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClanProfileRequest);
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x0010358C File Offset: 0x0010178C
		[DebuggerNonUserCode]
		public bool Equals(GetClanProfileRequest other)
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

		// Token: 0x060042E1 RID: 17121 RVA: 0x001035E4 File Offset: 0x001017E4
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

		// Token: 0x060042E2 RID: 17122 RVA: 0x00103630 File Offset: 0x00101830
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00103648 File Offset: 0x00101848
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00103654 File Offset: 0x00101854
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

		// Token: 0x060042E5 RID: 17125 RVA: 0x001036A0 File Offset: 0x001018A0
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

		// Token: 0x060042E6 RID: 17126 RVA: 0x001036F0 File Offset: 0x001018F0
		[DebuggerNonUserCode]
		public void MergeFrom(GetClanProfileRequest other)
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

		// Token: 0x060042E7 RID: 17127 RVA: 0x00103739 File Offset: 0x00101939
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00103744 File Offset: 0x00101944
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

		// Token: 0x04001E33 RID: 7731
		private static readonly MessageParser<GetClanProfileRequest> _parser = new MessageParser<GetClanProfileRequest>(() => new GetClanProfileRequest());

		// Token: 0x04001E34 RID: 7732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E35 RID: 7733
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E36 RID: 7734
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E37 RID: 7735
		private string clanId_;
	}
}

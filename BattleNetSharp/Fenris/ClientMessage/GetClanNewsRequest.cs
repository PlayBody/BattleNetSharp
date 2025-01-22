using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000271 RID: 625
	public sealed class GetClanNewsRequest : IMessage<GetClanNewsRequest>, IMessage, IEquatable<GetClanNewsRequest>, IDeepCloneable<GetClanNewsRequest>, IBufferMessage
	{
		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x060042FD RID: 17149 RVA: 0x00103B24 File Offset: 0x00101D24
		[DebuggerNonUserCode]
		public static MessageParser<GetClanNewsRequest> Parser
		{
			get
			{
				return GetClanNewsRequest._parser;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x00103B3C File Offset: 0x00101D3C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[97];
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x00103B60 File Offset: 0x00101D60
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClanNewsRequest.Descriptor;
			}
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00103B77 File Offset: 0x00101D77
		[DebuggerNonUserCode]
		public GetClanNewsRequest()
		{
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00103B81 File Offset: 0x00101D81
		[DebuggerNonUserCode]
		public GetClanNewsRequest(GetClanNewsRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00103BA8 File Offset: 0x00101DA8
		[DebuggerNonUserCode]
		public GetClanNewsRequest Clone()
		{
			return new GetClanNewsRequest(this);
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x00103BC0 File Offset: 0x00101DC0
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x00103BE1 File Offset: 0x00101DE1
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? GetClanNewsRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x00103BF8 File Offset: 0x00101DF8
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00103C13 File Offset: 0x00101E13
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00103C20 File Offset: 0x00101E20
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClanNewsRequest);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00103C40 File Offset: 0x00101E40
		[DebuggerNonUserCode]
		public bool Equals(GetClanNewsRequest other)
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

		// Token: 0x06004309 RID: 17161 RVA: 0x00103C98 File Offset: 0x00101E98
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

		// Token: 0x0600430A RID: 17162 RVA: 0x00103CE4 File Offset: 0x00101EE4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00103CFC File Offset: 0x00101EFC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00103D08 File Offset: 0x00101F08
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

		// Token: 0x0600430D RID: 17165 RVA: 0x00103D54 File Offset: 0x00101F54
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

		// Token: 0x0600430E RID: 17166 RVA: 0x00103DA4 File Offset: 0x00101FA4
		[DebuggerNonUserCode]
		public void MergeFrom(GetClanNewsRequest other)
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

		// Token: 0x0600430F RID: 17167 RVA: 0x00103DED File Offset: 0x00101FED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00103DF8 File Offset: 0x00101FF8
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

		// Token: 0x04001E3C RID: 7740
		private static readonly MessageParser<GetClanNewsRequest> _parser = new MessageParser<GetClanNewsRequest>(() => new GetClanNewsRequest());

		// Token: 0x04001E3D RID: 7741
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E3E RID: 7742
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E3F RID: 7743
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E40 RID: 7744
		private string clanId_;
	}
}

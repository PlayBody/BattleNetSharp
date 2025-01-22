using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000270 RID: 624
	public sealed class GetClanProfileResponse : IMessage<GetClanProfileResponse>, IMessage, IEquatable<GetClanProfileResponse>, IDeepCloneable<GetClanProfileResponse>, IBufferMessage
	{
		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x001037BC File Offset: 0x001019BC
		[DebuggerNonUserCode]
		public static MessageParser<GetClanProfileResponse> Parser
		{
			get
			{
				return GetClanProfileResponse._parser;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x001037D4 File Offset: 0x001019D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[96];
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x001037F8 File Offset: 0x001019F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClanProfileResponse.Descriptor;
			}
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x0010380F File Offset: 0x00101A0F
		[DebuggerNonUserCode]
		public GetClanProfileResponse()
		{
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x00103819 File Offset: 0x00101A19
		[DebuggerNonUserCode]
		public GetClanProfileResponse(GetClanProfileResponse other)
			: this()
		{
			this.summary_ = ((other.summary_ != null) ? other.summary_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00103850 File Offset: 0x00101A50
		[DebuggerNonUserCode]
		public GetClanProfileResponse Clone()
		{
			return new GetClanProfileResponse(this);
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x00103868 File Offset: 0x00101A68
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00103880 File Offset: 0x00101A80
		[DebuggerNonUserCode]
		public ClanProfile Summary
		{
			get
			{
				return this.summary_;
			}
			set
			{
				this.summary_ = value;
			}
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x0010388C File Offset: 0x00101A8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClanProfileResponse);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x001038AC File Offset: 0x00101AAC
		[DebuggerNonUserCode]
		public bool Equals(GetClanProfileResponse other)
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
					bool flag4 = !object.Equals(this.Summary, other.Summary);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00103908 File Offset: 0x00101B08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.summary_ != null;
			if (flag)
			{
				num ^= this.Summary.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00103958 File Offset: 0x00101B58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00103970 File Offset: 0x00101B70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x0010397C File Offset: 0x00101B7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.summary_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Summary);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x001039CC File Offset: 0x00101BCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.summary_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Summary);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00103A20 File Offset: 0x00101C20
		[DebuggerNonUserCode]
		public void MergeFrom(GetClanProfileResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.summary_ != null;
				if (flag2)
				{
					bool flag3 = this.summary_ == null;
					if (flag3)
					{
						this.Summary = new ClanProfile();
					}
					this.Summary.MergeFrom(other.Summary);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00103A8C File Offset: 0x00101C8C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00103A98 File Offset: 0x00101C98
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
					bool flag = this.summary_ == null;
					if (flag)
					{
						this.Summary = new ClanProfile();
					}
					input.ReadMessage(this.Summary);
				}
			}
		}

		// Token: 0x04001E38 RID: 7736
		private static readonly MessageParser<GetClanProfileResponse> _parser = new MessageParser<GetClanProfileResponse>(() => new GetClanProfileResponse());

		// Token: 0x04001E39 RID: 7737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E3A RID: 7738
		public const int SummaryFieldNumber = 1;

		// Token: 0x04001E3B RID: 7739
		private ClanProfile summary_;
	}
}

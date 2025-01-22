using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026A RID: 618
	public sealed class RespondToClanApplicationRequest : IMessage<RespondToClanApplicationRequest>, IMessage, IEquatable<RespondToClanApplicationRequest>, IDeepCloneable<RespondToClanApplicationRequest>, IBufferMessage
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06004252 RID: 16978 RVA: 0x00101B20 File Offset: 0x000FFD20
		[DebuggerNonUserCode]
		public static MessageParser<RespondToClanApplicationRequest> Parser
		{
			get
			{
				return RespondToClanApplicationRequest._parser;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x00101B38 File Offset: 0x000FFD38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[90];
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06004254 RID: 16980 RVA: 0x00101B5C File Offset: 0x000FFD5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RespondToClanApplicationRequest.Descriptor;
			}
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x00101B73 File Offset: 0x000FFD73
		[DebuggerNonUserCode]
		public RespondToClanApplicationRequest()
		{
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x00101B80 File Offset: 0x000FFD80
		[DebuggerNonUserCode]
		public RespondToClanApplicationRequest(RespondToClanApplicationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.applicantGameAccountId_ = other.applicantGameAccountId_;
			this.response_ = other.response_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x00101BD8 File Offset: 0x000FFDD8
		[DebuggerNonUserCode]
		public RespondToClanApplicationRequest Clone()
		{
			return new RespondToClanApplicationRequest(this);
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x00101BF0 File Offset: 0x000FFDF0
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x00101C11 File Offset: 0x000FFE11
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? RespondToClanApplicationRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x00101C28 File Offset: 0x000FFE28
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x00101C43 File Offset: 0x000FFE43
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x00101C50 File Offset: 0x000FFE50
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x00101C81 File Offset: 0x000FFE81
		[DebuggerNonUserCode]
		public uint ApplicantGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint applicantGameAccountIdDefaultValue;
				if (flag)
				{
					applicantGameAccountIdDefaultValue = this.applicantGameAccountId_;
				}
				else
				{
					applicantGameAccountIdDefaultValue = RespondToClanApplicationRequest.ApplicantGameAccountIdDefaultValue;
				}
				return applicantGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.applicantGameAccountId_ = value;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x00101C9C File Offset: 0x000FFE9C
		[DebuggerNonUserCode]
		public bool HasApplicantGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00101CB9 File Offset: 0x000FFEB9
		[DebuggerNonUserCode]
		public void ClearApplicantGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x00101CCC File Offset: 0x000FFECC
		// (set) Token: 0x06004261 RID: 16993 RVA: 0x00101CFD File Offset: 0x000FFEFD
		[DebuggerNonUserCode]
		public uint Response
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint responseDefaultValue;
				if (flag)
				{
					responseDefaultValue = this.response_;
				}
				else
				{
					responseDefaultValue = RespondToClanApplicationRequest.ResponseDefaultValue;
				}
				return responseDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.response_ = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x00101D18 File Offset: 0x000FFF18
		[DebuggerNonUserCode]
		public bool HasResponse
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x00101D35 File Offset: 0x000FFF35
		[DebuggerNonUserCode]
		public void ClearResponse()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x00101D48 File Offset: 0x000FFF48
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RespondToClanApplicationRequest);
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x00101D68 File Offset: 0x000FFF68
		[DebuggerNonUserCode]
		public bool Equals(RespondToClanApplicationRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ApplicantGameAccountId != other.ApplicantGameAccountId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Response != other.Response;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x00101DF4 File Offset: 0x000FFFF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasApplicantGameAccountId = this.HasApplicantGameAccountId;
			if (hasApplicantGameAccountId)
			{
				num ^= this.ApplicantGameAccountId.GetHashCode();
			}
			bool hasResponse = this.HasResponse;
			if (hasResponse)
			{
				num ^= this.Response.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00101E7C File Offset: 0x0010007C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x00101E94 File Offset: 0x00100094
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x00101EA0 File Offset: 0x001000A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasApplicantGameAccountId = this.HasApplicantGameAccountId;
			if (hasApplicantGameAccountId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ApplicantGameAccountId);
			}
			bool hasResponse = this.HasResponse;
			if (hasResponse)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Response);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00101F30 File Offset: 0x00100130
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasApplicantGameAccountId = this.HasApplicantGameAccountId;
			if (hasApplicantGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ApplicantGameAccountId);
			}
			bool hasResponse = this.HasResponse;
			if (hasResponse)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Response);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x00101FBC File Offset: 0x001001BC
		[DebuggerNonUserCode]
		public void MergeFrom(RespondToClanApplicationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasApplicantGameAccountId = other.HasApplicantGameAccountId;
				if (hasApplicantGameAccountId)
				{
					this.ApplicantGameAccountId = other.ApplicantGameAccountId;
				}
				bool hasResponse = other.HasResponse;
				if (hasResponse)
				{
					this.Response = other.Response;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x00102037 File Offset: 0x00100237
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x00102044 File Offset: 0x00100244
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Response = input.ReadUInt32();
						}
					}
					else
					{
						this.ApplicantGameAccountId = input.ReadUInt32();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E02 RID: 7682
		private static readonly MessageParser<RespondToClanApplicationRequest> _parser = new MessageParser<RespondToClanApplicationRequest>(() => new RespondToClanApplicationRequest());

		// Token: 0x04001E03 RID: 7683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E04 RID: 7684
		private int _hasBits0;

		// Token: 0x04001E05 RID: 7685
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E06 RID: 7686
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E07 RID: 7687
		private string clanId_;

		// Token: 0x04001E08 RID: 7688
		public const int ApplicantGameAccountIdFieldNumber = 2;

		// Token: 0x04001E09 RID: 7689
		private static readonly uint ApplicantGameAccountIdDefaultValue = 0U;

		// Token: 0x04001E0A RID: 7690
		private uint applicantGameAccountId_;

		// Token: 0x04001E0B RID: 7691
		public const int ResponseFieldNumber = 3;

		// Token: 0x04001E0C RID: 7692
		private static readonly uint ResponseDefaultValue = 0U;

		// Token: 0x04001E0D RID: 7693
		private uint response_;
	}
}

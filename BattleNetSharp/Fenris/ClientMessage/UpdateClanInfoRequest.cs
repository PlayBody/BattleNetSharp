using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200026E RID: 622
	public sealed class UpdateClanInfoRequest : IMessage<UpdateClanInfoRequest>, IMessage, IEquatable<UpdateClanInfoRequest>, IDeepCloneable<UpdateClanInfoRequest>, IBufferMessage
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x00102FE4 File Offset: 0x001011E4
		[DebuggerNonUserCode]
		public static MessageParser<UpdateClanInfoRequest> Parser
		{
			get
			{
				return UpdateClanInfoRequest._parser;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x00102FFC File Offset: 0x001011FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[94];
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x00103020 File Offset: 0x00101220
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateClanInfoRequest.Descriptor;
			}
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00103037 File Offset: 0x00101237
		[DebuggerNonUserCode]
		public UpdateClanInfoRequest()
		{
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00103044 File Offset: 0x00101244
		[DebuggerNonUserCode]
		public UpdateClanInfoRequest(UpdateClanInfoRequest other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this.clanInfo_ = ((other.clanInfo_ != null) ? other.clanInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x00103094 File Offset: 0x00101294
		[DebuggerNonUserCode]
		public UpdateClanInfoRequest Clone()
		{
			return new UpdateClanInfoRequest(this);
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x001030AC File Offset: 0x001012AC
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x001030CD File Offset: 0x001012CD
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? UpdateClanInfoRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x001030E4 File Offset: 0x001012E4
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x001030FF File Offset: 0x001012FF
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x0010310C File Offset: 0x0010130C
		// (set) Token: 0x060042C9 RID: 17097 RVA: 0x00103124 File Offset: 0x00101324
		[DebuggerNonUserCode]
		public ClanInfo ClanInfo
		{
			get
			{
				return this.clanInfo_;
			}
			set
			{
				this.clanInfo_ = value;
			}
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00103130 File Offset: 0x00101330
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateClanInfoRequest);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00103150 File Offset: 0x00101350
		[DebuggerNonUserCode]
		public bool Equals(UpdateClanInfoRequest other)
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
						bool flag5 = !object.Equals(this.ClanInfo, other.ClanInfo);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x001031C4 File Offset: 0x001013C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this.clanInfo_ != null;
			if (flag)
			{
				num ^= this.ClanInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0010322C File Offset: 0x0010142C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00103244 File Offset: 0x00101444
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00103250 File Offset: 0x00101450
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this.clanInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ClanInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x001032C4 File Offset: 0x001014C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this.clanInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClanInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00103334 File Offset: 0x00101534
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateClanInfoRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool flag2 = other.clanInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.clanInfo_ == null;
					if (flag3)
					{
						this.ClanInfo = new ClanInfo();
					}
					this.ClanInfo.MergeFrom(other.ClanInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x001033B9 File Offset: 0x001015B9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x001033C4 File Offset: 0x001015C4
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.clanInfo_ == null;
						if (flag)
						{
							this.ClanInfo = new ClanInfo();
						}
						input.ReadMessage(this.ClanInfo);
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E2C RID: 7724
		private static readonly MessageParser<UpdateClanInfoRequest> _parser = new MessageParser<UpdateClanInfoRequest>(() => new UpdateClanInfoRequest());

		// Token: 0x04001E2D RID: 7725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E2E RID: 7726
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E2F RID: 7727
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E30 RID: 7728
		private string clanId_;

		// Token: 0x04001E31 RID: 7729
		public const int ClanInfoFieldNumber = 2;

		// Token: 0x04001E32 RID: 7730
		private ClanInfo clanInfo_;
	}
}

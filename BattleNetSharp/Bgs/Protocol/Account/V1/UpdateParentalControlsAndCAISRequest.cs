using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000726 RID: 1830
	public sealed class UpdateParentalControlsAndCAISRequest : IMessage<UpdateParentalControlsAndCAISRequest>, IMessage, IEquatable<UpdateParentalControlsAndCAISRequest>, IDeepCloneable<UpdateParentalControlsAndCAISRequest>, IBufferMessage
	{
		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600A79F RID: 42911 RVA: 0x0028C1B0 File Offset: 0x0028A3B0
		[DebuggerNonUserCode]
		public static MessageParser<UpdateParentalControlsAndCAISRequest> Parser
		{
			get
			{
				return UpdateParentalControlsAndCAISRequest._parser;
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600A7A0 RID: 42912 RVA: 0x0028C1C8 File Offset: 0x0028A3C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[22];
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x0028C1EC File Offset: 0x0028A3EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateParentalControlsAndCAISRequest.Descriptor;
			}
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x0028C203 File Offset: 0x0028A403
		[DebuggerNonUserCode]
		public UpdateParentalControlsAndCAISRequest()
		{
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x0028C210 File Offset: 0x0028A410
		[DebuggerNonUserCode]
		public UpdateParentalControlsAndCAISRequest(UpdateParentalControlsAndCAISRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.account_ = ((other.account_ != null) ? other.account_.Clone() : null);
			this.parentalControlInfo_ = ((other.parentalControlInfo_ != null) ? other.parentalControlInfo_.Clone() : null);
			this.caisId_ = other.caisId_;
			this.sessionStartTime_ = other.sessionStartTime_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x0028C2AC File Offset: 0x0028A4AC
		[DebuggerNonUserCode]
		public UpdateParentalControlsAndCAISRequest Clone()
		{
			return new UpdateParentalControlsAndCAISRequest(this);
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x0028C2C4 File Offset: 0x0028A4C4
		// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x0028C2DC File Offset: 0x0028A4DC
		[DebuggerNonUserCode]
		public AccountId Account
		{
			get
			{
				return this.account_;
			}
			set
			{
				this.account_ = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x0028C2E8 File Offset: 0x0028A4E8
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x0028C300 File Offset: 0x0028A500
		[DebuggerNonUserCode]
		public ParentalControlInfo ParentalControlInfo
		{
			get
			{
				return this.parentalControlInfo_;
			}
			set
			{
				this.parentalControlInfo_ = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x0028C30C File Offset: 0x0028A50C
		// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x0028C32D File Offset: 0x0028A52D
		[DebuggerNonUserCode]
		public string CaisId
		{
			get
			{
				return this.caisId_ ?? UpdateParentalControlsAndCAISRequest.CaisIdDefaultValue;
			}
			set
			{
				this.caisId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x0028C344 File Offset: 0x0028A544
		[DebuggerNonUserCode]
		public bool HasCaisId
		{
			get
			{
				return this.caisId_ != null;
			}
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x0028C35F File Offset: 0x0028A55F
		[DebuggerNonUserCode]
		public void ClearCaisId()
		{
			this.caisId_ = null;
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x0028C36C File Offset: 0x0028A56C
		// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x0028C39D File Offset: 0x0028A59D
		[DebuggerNonUserCode]
		public ulong SessionStartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong sessionStartTimeDefaultValue;
				if (flag)
				{
					sessionStartTimeDefaultValue = this.sessionStartTime_;
				}
				else
				{
					sessionStartTimeDefaultValue = UpdateParentalControlsAndCAISRequest.SessionStartTimeDefaultValue;
				}
				return sessionStartTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sessionStartTime_ = value;
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x0028C3B8 File Offset: 0x0028A5B8
		[DebuggerNonUserCode]
		public bool HasSessionStartTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0028C3D5 File Offset: 0x0028A5D5
		[DebuggerNonUserCode]
		public void ClearSessionStartTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x0028C3E8 File Offset: 0x0028A5E8
		// (set) Token: 0x0600A7B2 RID: 42930 RVA: 0x0028C419 File Offset: 0x0028A619
		[DebuggerNonUserCode]
		public ulong StartTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong startTimeDefaultValue;
				if (flag)
				{
					startTimeDefaultValue = this.startTime_;
				}
				else
				{
					startTimeDefaultValue = UpdateParentalControlsAndCAISRequest.StartTimeDefaultValue;
				}
				return startTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.startTime_ = value;
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A7B3 RID: 42931 RVA: 0x0028C434 File Offset: 0x0028A634
		[DebuggerNonUserCode]
		public bool HasStartTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x0028C451 File Offset: 0x0028A651
		[DebuggerNonUserCode]
		public void ClearStartTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A7B5 RID: 42933 RVA: 0x0028C464 File Offset: 0x0028A664
		// (set) Token: 0x0600A7B6 RID: 42934 RVA: 0x0028C495 File Offset: 0x0028A695
		[DebuggerNonUserCode]
		public ulong EndTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong endTimeDefaultValue;
				if (flag)
				{
					endTimeDefaultValue = this.endTime_;
				}
				else
				{
					endTimeDefaultValue = UpdateParentalControlsAndCAISRequest.EndTimeDefaultValue;
				}
				return endTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.endTime_ = value;
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A7B7 RID: 42935 RVA: 0x0028C4B0 File Offset: 0x0028A6B0
		[DebuggerNonUserCode]
		public bool HasEndTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x0028C4CD File Offset: 0x0028A6CD
		[DebuggerNonUserCode]
		public void ClearEndTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x0028C4E0 File Offset: 0x0028A6E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateParentalControlsAndCAISRequest);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x0028C500 File Offset: 0x0028A700
		[DebuggerNonUserCode]
		public bool Equals(UpdateParentalControlsAndCAISRequest other)
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
					bool flag4 = !object.Equals(this.Account, other.Account);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ParentalControlInfo, other.ParentalControlInfo);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CaisId != other.CaisId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SessionStartTime != other.SessionStartTime;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.StartTime != other.StartTime;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.EndTime != other.EndTime;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x0028C5F0 File Offset: 0x0028A7F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.account_ != null;
			if (flag)
			{
				num ^= this.Account.GetHashCode();
			}
			bool flag2 = this.parentalControlInfo_ != null;
			if (flag2)
			{
				num ^= this.ParentalControlInfo.GetHashCode();
			}
			bool hasCaisId = this.HasCaisId;
			if (hasCaisId)
			{
				num ^= this.CaisId.GetHashCode();
			}
			bool hasSessionStartTime = this.HasSessionStartTime;
			if (hasSessionStartTime)
			{
				num ^= this.SessionStartTime.GetHashCode();
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num ^= this.StartTime.GetHashCode();
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				num ^= this.EndTime.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x0028C6D0 File Offset: 0x0028A8D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x0028C6E8 File Offset: 0x0028A8E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x0028C6F4 File Offset: 0x0028A8F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.account_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Account);
			}
			bool flag2 = this.parentalControlInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ParentalControlInfo);
			}
			bool hasCaisId = this.HasCaisId;
			if (hasCaisId)
			{
				output.WriteRawTag(26);
				output.WriteString(this.CaisId);
			}
			bool hasSessionStartTime = this.HasSessionStartTime;
			if (hasSessionStartTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.SessionStartTime);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(this.StartTime);
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				output.WriteRawTag(48);
				output.WriteUInt64(this.EndTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x0028C7F8 File Offset: 0x0028A9F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.account_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Account);
			}
			bool flag2 = this.parentalControlInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParentalControlInfo);
			}
			bool hasCaisId = this.HasCaisId;
			if (hasCaisId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CaisId);
			}
			bool hasSessionStartTime = this.HasSessionStartTime;
			if (hasSessionStartTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SessionStartTime);
			}
			bool hasStartTime = this.HasStartTime;
			if (hasStartTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.StartTime);
			}
			bool hasEndTime = this.HasEndTime;
			if (hasEndTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EndTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x0028C8E4 File Offset: 0x0028AAE4
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateParentalControlsAndCAISRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.account_ != null;
				if (flag2)
				{
					bool flag3 = this.account_ == null;
					if (flag3)
					{
						this.Account = new AccountId();
					}
					this.Account.MergeFrom(other.Account);
				}
				bool flag4 = other.parentalControlInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.parentalControlInfo_ == null;
					if (flag5)
					{
						this.ParentalControlInfo = new ParentalControlInfo();
					}
					this.ParentalControlInfo.MergeFrom(other.ParentalControlInfo);
				}
				bool hasCaisId = other.HasCaisId;
				if (hasCaisId)
				{
					this.CaisId = other.CaisId;
				}
				bool hasSessionStartTime = other.HasSessionStartTime;
				if (hasSessionStartTime)
				{
					this.SessionStartTime = other.SessionStartTime;
				}
				bool hasStartTime = other.HasStartTime;
				if (hasStartTime)
				{
					this.StartTime = other.StartTime;
				}
				bool hasEndTime = other.HasEndTime;
				if (hasEndTime)
				{
					this.EndTime = other.EndTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x0028C9FD File Offset: 0x0028ABFD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x0028CA08 File Offset: 0x0028AC08
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0046;
							}
							this.CaisId = input.ReadString();
						}
						else
						{
							bool flag = this.parentalControlInfo_ == null;
							if (flag)
							{
								this.ParentalControlInfo = new ParentalControlInfo();
							}
							input.ReadMessage(this.ParentalControlInfo);
						}
					}
					else
					{
						bool flag2 = this.account_ == null;
						if (flag2)
						{
							this.Account = new AccountId();
						}
						input.ReadMessage(this.Account);
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						if (num3 != 48U)
						{
							goto IL_0046;
						}
						this.EndTime = input.ReadUInt64();
					}
					else
					{
						this.StartTime = input.ReadUInt64();
					}
				}
				else
				{
					this.SessionStartTime = input.ReadUInt64();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B26 RID: 19238
		private static readonly MessageParser<UpdateParentalControlsAndCAISRequest> _parser = new MessageParser<UpdateParentalControlsAndCAISRequest>(() => new UpdateParentalControlsAndCAISRequest());

		// Token: 0x04004B27 RID: 19239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B28 RID: 19240
		private int _hasBits0;

		// Token: 0x04004B29 RID: 19241
		public const int AccountFieldNumber = 1;

		// Token: 0x04004B2A RID: 19242
		private AccountId account_;

		// Token: 0x04004B2B RID: 19243
		public const int ParentalControlInfoFieldNumber = 2;

		// Token: 0x04004B2C RID: 19244
		private ParentalControlInfo parentalControlInfo_;

		// Token: 0x04004B2D RID: 19245
		public const int CaisIdFieldNumber = 3;

		// Token: 0x04004B2E RID: 19246
		private static readonly string CaisIdDefaultValue = "";

		// Token: 0x04004B2F RID: 19247
		private string caisId_;

		// Token: 0x04004B30 RID: 19248
		public const int SessionStartTimeFieldNumber = 4;

		// Token: 0x04004B31 RID: 19249
		private static readonly ulong SessionStartTimeDefaultValue = 0UL;

		// Token: 0x04004B32 RID: 19250
		private ulong sessionStartTime_;

		// Token: 0x04004B33 RID: 19251
		public const int StartTimeFieldNumber = 5;

		// Token: 0x04004B34 RID: 19252
		private static readonly ulong StartTimeDefaultValue = 0UL;

		// Token: 0x04004B35 RID: 19253
		private ulong startTime_;

		// Token: 0x04004B36 RID: 19254
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04004B37 RID: 19255
		private static readonly ulong EndTimeDefaultValue = 0UL;

		// Token: 0x04004B38 RID: 19256
		private ulong endTime_;
	}
}

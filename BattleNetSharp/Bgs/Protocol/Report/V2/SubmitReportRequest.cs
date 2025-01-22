using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000582 RID: 1410
	public sealed class SubmitReportRequest : IMessage<SubmitReportRequest>, IMessage, IEquatable<SubmitReportRequest>, IDeepCloneable<SubmitReportRequest>, IBufferMessage
	{
		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600876B RID: 34667 RVA: 0x0020E4E4 File Offset: 0x0020C6E4
		[DebuggerNonUserCode]
		public static MessageParser<SubmitReportRequest> Parser
		{
			get
			{
				return SubmitReportRequest._parser;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600876C RID: 34668 RVA: 0x0020E4FC File Offset: 0x0020C6FC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0600876D RID: 34669 RVA: 0x0020E520 File Offset: 0x0020C720
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitReportRequest.Descriptor;
			}
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x0020E537 File Offset: 0x0020C737
		[DebuggerNonUserCode]
		public SubmitReportRequest()
		{
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x0020E548 File Offset: 0x0020C748
		[DebuggerNonUserCode]
		public SubmitReportRequest(SubmitReportRequest other)
			: this()
		{
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.userDescription_ = other.userDescription_;
			SubmitReportRequest.TypeOneofCase typeCase = other.TypeCase;
			SubmitReportRequest.TypeOneofCase typeOneofCase = typeCase;
			if (typeOneofCase != SubmitReportRequest.TypeOneofCase.UserOptions)
			{
				if (typeOneofCase != SubmitReportRequest.TypeOneofCase.ClubOptions)
				{
					if (typeOneofCase == SubmitReportRequest.TypeOneofCase.EntityOptions)
					{
						this.EntityOptions = other.EntityOptions.Clone();
					}
				}
				else
				{
					this.ClubOptions = other.ClubOptions.Clone();
				}
			}
			else
			{
				this.UserOptions = other.UserOptions.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x0020E5F0 File Offset: 0x0020C7F0
		[DebuggerNonUserCode]
		public SubmitReportRequest Clone()
		{
			return new SubmitReportRequest(this);
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x06008771 RID: 34673 RVA: 0x0020E608 File Offset: 0x0020C808
		// (set) Token: 0x06008772 RID: 34674 RVA: 0x0020E620 File Offset: 0x0020C820
		[DebuggerNonUserCode]
		public AccountId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x06008773 RID: 34675 RVA: 0x0020E62C File Offset: 0x0020C82C
		// (set) Token: 0x06008774 RID: 34676 RVA: 0x0020E64D File Offset: 0x0020C84D
		[DebuggerNonUserCode]
		public string UserDescription
		{
			get
			{
				return this.userDescription_ ?? SubmitReportRequest.UserDescriptionDefaultValue;
			}
			set
			{
				this.userDescription_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x06008775 RID: 34677 RVA: 0x0020E664 File Offset: 0x0020C864
		[DebuggerNonUserCode]
		public bool HasUserDescription
		{
			get
			{
				return this.userDescription_ != null;
			}
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x0020E67F File Offset: 0x0020C87F
		[DebuggerNonUserCode]
		public void ClearUserDescription()
		{
			this.userDescription_ = null;
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06008777 RID: 34679 RVA: 0x0020E68C File Offset: 0x0020C88C
		// (set) Token: 0x06008778 RID: 34680 RVA: 0x0020E6B6 File Offset: 0x0020C8B6
		[DebuggerNonUserCode]
		public UserOptions UserOptions
		{
			get
			{
				return (this.typeCase_ == SubmitReportRequest.TypeOneofCase.UserOptions) ? ((UserOptions)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? SubmitReportRequest.TypeOneofCase.None : SubmitReportRequest.TypeOneofCase.UserOptions);
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06008779 RID: 34681 RVA: 0x0020E6D0 File Offset: 0x0020C8D0
		// (set) Token: 0x0600877A RID: 34682 RVA: 0x0020E6FA File Offset: 0x0020C8FA
		[DebuggerNonUserCode]
		public ClubOptions ClubOptions
		{
			get
			{
				return (this.typeCase_ == SubmitReportRequest.TypeOneofCase.ClubOptions) ? ((ClubOptions)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? SubmitReportRequest.TypeOneofCase.None : SubmitReportRequest.TypeOneofCase.ClubOptions);
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x0020E714 File Offset: 0x0020C914
		// (set) Token: 0x0600877C RID: 34684 RVA: 0x0020E73E File Offset: 0x0020C93E
		[DebuggerNonUserCode]
		public EntityOptions EntityOptions
		{
			get
			{
				return (this.typeCase_ == SubmitReportRequest.TypeOneofCase.EntityOptions) ? ((EntityOptions)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? SubmitReportRequest.TypeOneofCase.None : SubmitReportRequest.TypeOneofCase.EntityOptions);
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x0020E758 File Offset: 0x0020C958
		[DebuggerNonUserCode]
		public SubmitReportRequest.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x0020E770 File Offset: 0x0020C970
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = SubmitReportRequest.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x0020E784 File Offset: 0x0020C984
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitReportRequest);
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x0020E7A4 File Offset: 0x0020C9A4
		[DebuggerNonUserCode]
		public bool Equals(SubmitReportRequest other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.UserDescription != other.UserDescription;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.UserOptions, other.UserOptions);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.ClubOptions, other.ClubOptions);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.EntityOptions, other.EntityOptions);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.TypeCase != other.TypeCase;
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

		// Token: 0x06008781 RID: 34689 RVA: 0x0020E89C File Offset: 0x0020CA9C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				num ^= this.UserDescription.GetHashCode();
			}
			bool flag2 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.UserOptions;
			if (flag2)
			{
				num ^= this.UserOptions.GetHashCode();
			}
			bool flag3 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.ClubOptions;
			if (flag3)
			{
				num ^= this.ClubOptions.GetHashCode();
			}
			bool flag4 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.EntityOptions;
			if (flag4)
			{
				num ^= this.EntityOptions.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x0020E968 File Offset: 0x0020CB68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x0020E980 File Offset: 0x0020CB80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x0020E98C File Offset: 0x0020CB8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				output.WriteRawTag(18);
				output.WriteString(this.UserDescription);
			}
			bool flag2 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.UserOptions;
			if (flag2)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.UserOptions);
			}
			bool flag3 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.ClubOptions;
			if (flag3)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ClubOptions);
			}
			bool flag4 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.EntityOptions;
			if (flag4)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.EntityOptions);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x0020EA78 File Offset: 0x0020CC78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasUserDescription = this.HasUserDescription;
			if (hasUserDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UserDescription);
			}
			bool flag2 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.UserOptions;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UserOptions);
			}
			bool flag3 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.ClubOptions;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClubOptions);
			}
			bool flag4 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.EntityOptions;
			if (flag4)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityOptions);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x0020EB50 File Offset: 0x0020CD50
		[DebuggerNonUserCode]
		public void MergeFrom(SubmitReportRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new AccountId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasUserDescription = other.HasUserDescription;
				if (hasUserDescription)
				{
					this.UserDescription = other.UserDescription;
				}
				SubmitReportRequest.TypeOneofCase typeCase = other.TypeCase;
				SubmitReportRequest.TypeOneofCase typeOneofCase = typeCase;
				if (typeOneofCase != SubmitReportRequest.TypeOneofCase.UserOptions)
				{
					if (typeOneofCase != SubmitReportRequest.TypeOneofCase.ClubOptions)
					{
						if (typeOneofCase == SubmitReportRequest.TypeOneofCase.EntityOptions)
						{
							bool flag4 = this.EntityOptions == null;
							if (flag4)
							{
								this.EntityOptions = new EntityOptions();
							}
							this.EntityOptions.MergeFrom(other.EntityOptions);
						}
					}
					else
					{
						bool flag5 = this.ClubOptions == null;
						if (flag5)
						{
							this.ClubOptions = new ClubOptions();
						}
						this.ClubOptions.MergeFrom(other.ClubOptions);
					}
				}
				else
				{
					bool flag6 = this.UserOptions == null;
					if (flag6)
					{
						this.UserOptions = new UserOptions();
					}
					this.UserOptions.MergeFrom(other.UserOptions);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x0020EC92 File Offset: 0x0020CE92
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x0020ECA0 File Offset: 0x0020CEA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_003C;
						}
						this.UserDescription = input.ReadString();
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new AccountId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else if (num3 != 82U)
				{
					if (num3 != 90U)
					{
						if (num3 != 162U)
						{
							goto IL_003C;
						}
						EntityOptions entityOptions = new EntityOptions();
						bool flag2 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.EntityOptions;
						if (flag2)
						{
							entityOptions.MergeFrom(this.EntityOptions);
						}
						input.ReadMessage(entityOptions);
						this.EntityOptions = entityOptions;
					}
					else
					{
						ClubOptions clubOptions = new ClubOptions();
						bool flag3 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.ClubOptions;
						if (flag3)
						{
							clubOptions.MergeFrom(this.ClubOptions);
						}
						input.ReadMessage(clubOptions);
						this.ClubOptions = clubOptions;
					}
				}
				else
				{
					UserOptions userOptions = new UserOptions();
					bool flag4 = this.typeCase_ == SubmitReportRequest.TypeOneofCase.UserOptions;
					if (flag4)
					{
						userOptions.MergeFrom(this.UserOptions);
					}
					input.ReadMessage(userOptions);
					this.UserOptions = userOptions;
				}
				continue;
				IL_003C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D4D RID: 15693
		private static readonly MessageParser<SubmitReportRequest> _parser = new MessageParser<SubmitReportRequest>(() => new SubmitReportRequest());

		// Token: 0x04003D4E RID: 15694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D4F RID: 15695
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003D50 RID: 15696
		private AccountId agentId_;

		// Token: 0x04003D51 RID: 15697
		public const int UserDescriptionFieldNumber = 2;

		// Token: 0x04003D52 RID: 15698
		private static readonly string UserDescriptionDefaultValue = "";

		// Token: 0x04003D53 RID: 15699
		private string userDescription_;

		// Token: 0x04003D54 RID: 15700
		public const int UserOptionsFieldNumber = 10;

		// Token: 0x04003D55 RID: 15701
		public const int ClubOptionsFieldNumber = 11;

		// Token: 0x04003D56 RID: 15702
		public const int EntityOptionsFieldNumber = 20;

		// Token: 0x04003D57 RID: 15703
		private object type_;

		// Token: 0x04003D58 RID: 15704
		private SubmitReportRequest.TypeOneofCase typeCase_ = SubmitReportRequest.TypeOneofCase.None;

		// Token: 0x02001058 RID: 4184
		public enum TypeOneofCase
		{
			// Token: 0x040097AC RID: 38828
			None,
			// Token: 0x040097AD RID: 38829
			UserOptions = 10,
			// Token: 0x040097AE RID: 38830
			ClubOptions,
			// Token: 0x040097AF RID: 38831
			EntityOptions = 20
		}
	}
}

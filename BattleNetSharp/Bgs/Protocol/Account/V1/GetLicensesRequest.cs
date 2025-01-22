using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071C RID: 1820
	public sealed class GetLicensesRequest : IMessage<GetLicensesRequest>, IMessage, IEquatable<GetLicensesRequest>, IDeepCloneable<GetLicensesRequest>, IBufferMessage
	{
		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A6C4 RID: 42692 RVA: 0x00289600 File Offset: 0x00287800
		[DebuggerNonUserCode]
		public static MessageParser<GetLicensesRequest> Parser
		{
			get
			{
				return GetLicensesRequest._parser;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A6C5 RID: 42693 RVA: 0x00289618 File Offset: 0x00287818
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A6C6 RID: 42694 RVA: 0x0028963C File Offset: 0x0028783C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLicensesRequest.Descriptor;
			}
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x00289653 File Offset: 0x00287853
		[DebuggerNonUserCode]
		public GetLicensesRequest()
		{
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x00289660 File Offset: 0x00287860
		[DebuggerNonUserCode]
		public GetLicensesRequest(GetLicensesRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.fetchAccountLicenses_ = other.fetchAccountLicenses_;
			this.fetchGameAccountLicenses_ = other.fetchGameAccountLicenses_;
			this.fetchDynamicAccountLicenses_ = other.fetchDynamicAccountLicenses_;
			this.program_ = other.program_;
			this.excludeUnknownProgram_ = other.excludeUnknownProgram_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x002896EC File Offset: 0x002878EC
		[DebuggerNonUserCode]
		public GetLicensesRequest Clone()
		{
			return new GetLicensesRequest(this);
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A6CA RID: 42698 RVA: 0x00289704 File Offset: 0x00287904
		// (set) Token: 0x0600A6CB RID: 42699 RVA: 0x0028971C File Offset: 0x0028791C
		[DebuggerNonUserCode]
		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A6CC RID: 42700 RVA: 0x00289728 File Offset: 0x00287928
		// (set) Token: 0x0600A6CD RID: 42701 RVA: 0x00289759 File Offset: 0x00287959
		[DebuggerNonUserCode]
		public bool FetchAccountLicenses
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool fetchAccountLicensesDefaultValue;
				if (flag)
				{
					fetchAccountLicensesDefaultValue = this.fetchAccountLicenses_;
				}
				else
				{
					fetchAccountLicensesDefaultValue = GetLicensesRequest.FetchAccountLicensesDefaultValue;
				}
				return fetchAccountLicensesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.fetchAccountLicenses_ = value;
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x00289774 File Offset: 0x00287974
		[DebuggerNonUserCode]
		public bool HasFetchAccountLicenses
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x00289791 File Offset: 0x00287991
		[DebuggerNonUserCode]
		public void ClearFetchAccountLicenses()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600A6D0 RID: 42704 RVA: 0x002897A4 File Offset: 0x002879A4
		// (set) Token: 0x0600A6D1 RID: 42705 RVA: 0x002897D5 File Offset: 0x002879D5
		[DebuggerNonUserCode]
		public bool FetchGameAccountLicenses
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool fetchGameAccountLicensesDefaultValue;
				if (flag)
				{
					fetchGameAccountLicensesDefaultValue = this.fetchGameAccountLicenses_;
				}
				else
				{
					fetchGameAccountLicensesDefaultValue = GetLicensesRequest.FetchGameAccountLicensesDefaultValue;
				}
				return fetchGameAccountLicensesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.fetchGameAccountLicenses_ = value;
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x002897F0 File Offset: 0x002879F0
		[DebuggerNonUserCode]
		public bool HasFetchGameAccountLicenses
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x0028980D File Offset: 0x00287A0D
		[DebuggerNonUserCode]
		public void ClearFetchGameAccountLicenses()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x00289820 File Offset: 0x00287A20
		// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x00289851 File Offset: 0x00287A51
		[DebuggerNonUserCode]
		public bool FetchDynamicAccountLicenses
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool fetchDynamicAccountLicensesDefaultValue;
				if (flag)
				{
					fetchDynamicAccountLicensesDefaultValue = this.fetchDynamicAccountLicenses_;
				}
				else
				{
					fetchDynamicAccountLicensesDefaultValue = GetLicensesRequest.FetchDynamicAccountLicensesDefaultValue;
				}
				return fetchDynamicAccountLicensesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.fetchDynamicAccountLicenses_ = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600A6D6 RID: 42710 RVA: 0x0028986C File Offset: 0x00287A6C
		[DebuggerNonUserCode]
		public bool HasFetchDynamicAccountLicenses
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x00289889 File Offset: 0x00287A89
		[DebuggerNonUserCode]
		public void ClearFetchDynamicAccountLicenses()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600A6D8 RID: 42712 RVA: 0x0028989C File Offset: 0x00287A9C
		// (set) Token: 0x0600A6D9 RID: 42713 RVA: 0x002898CD File Offset: 0x00287ACD
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = GetLicensesRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.program_ = value;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x002898E8 File Offset: 0x00287AE8
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x00289905 File Offset: 0x00287B05
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x00289918 File Offset: 0x00287B18
		// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x0028994A File Offset: 0x00287B4A
		[DebuggerNonUserCode]
		public bool ExcludeUnknownProgram
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool excludeUnknownProgramDefaultValue;
				if (flag)
				{
					excludeUnknownProgramDefaultValue = this.excludeUnknownProgram_;
				}
				else
				{
					excludeUnknownProgramDefaultValue = GetLicensesRequest.ExcludeUnknownProgramDefaultValue;
				}
				return excludeUnknownProgramDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.excludeUnknownProgram_ = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x00289964 File Offset: 0x00287B64
		[DebuggerNonUserCode]
		public bool HasExcludeUnknownProgram
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x00289982 File Offset: 0x00287B82
		[DebuggerNonUserCode]
		public void ClearExcludeUnknownProgram()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x00289994 File Offset: 0x00287B94
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLicensesRequest);
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x002899B4 File Offset: 0x00287BB4
		[DebuggerNonUserCode]
		public bool Equals(GetLicensesRequest other)
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
					bool flag4 = !object.Equals(this.TargetId, other.TargetId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.FetchAccountLicenses != other.FetchAccountLicenses;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FetchGameAccountLicenses != other.FetchGameAccountLicenses;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.FetchDynamicAccountLicenses != other.FetchDynamicAccountLicenses;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Program != other.Program;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.ExcludeUnknownProgram != other.ExcludeUnknownProgram;
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

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x00289AA0 File Offset: 0x00287CA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool hasFetchAccountLicenses = this.HasFetchAccountLicenses;
			if (hasFetchAccountLicenses)
			{
				num ^= this.FetchAccountLicenses.GetHashCode();
			}
			bool hasFetchGameAccountLicenses = this.HasFetchGameAccountLicenses;
			if (hasFetchGameAccountLicenses)
			{
				num ^= this.FetchGameAccountLicenses.GetHashCode();
			}
			bool hasFetchDynamicAccountLicenses = this.HasFetchDynamicAccountLicenses;
			if (hasFetchDynamicAccountLicenses)
			{
				num ^= this.FetchDynamicAccountLicenses.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasExcludeUnknownProgram = this.HasExcludeUnknownProgram;
			if (hasExcludeUnknownProgram)
			{
				num ^= this.ExcludeUnknownProgram.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x00289B84 File Offset: 0x00287D84
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x00289B9C File Offset: 0x00287D9C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x00289BA8 File Offset: 0x00287DA8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetId);
			}
			bool hasFetchAccountLicenses = this.HasFetchAccountLicenses;
			if (hasFetchAccountLicenses)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.FetchAccountLicenses);
			}
			bool hasFetchGameAccountLicenses = this.HasFetchGameAccountLicenses;
			if (hasFetchGameAccountLicenses)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FetchGameAccountLicenses);
			}
			bool hasFetchDynamicAccountLicenses = this.HasFetchDynamicAccountLicenses;
			if (hasFetchDynamicAccountLicenses)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.FetchDynamicAccountLicenses);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.Program);
			}
			bool hasExcludeUnknownProgram = this.HasExcludeUnknownProgram;
			if (hasExcludeUnknownProgram)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.ExcludeUnknownProgram);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x00289CA8 File Offset: 0x00287EA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool hasFetchAccountLicenses = this.HasFetchAccountLicenses;
			if (hasFetchAccountLicenses)
			{
				num += 2;
			}
			bool hasFetchGameAccountLicenses = this.HasFetchGameAccountLicenses;
			if (hasFetchGameAccountLicenses)
			{
				num += 2;
			}
			bool hasFetchDynamicAccountLicenses = this.HasFetchDynamicAccountLicenses;
			if (hasFetchDynamicAccountLicenses)
			{
				num += 2;
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasExcludeUnknownProgram = this.HasExcludeUnknownProgram;
			if (hasExcludeUnknownProgram)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x00289D54 File Offset: 0x00287F54
		[DebuggerNonUserCode]
		public void MergeFrom(GetLicensesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.targetId_ != null;
				if (flag2)
				{
					bool flag3 = this.targetId_ == null;
					if (flag3)
					{
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasFetchAccountLicenses = other.HasFetchAccountLicenses;
				if (hasFetchAccountLicenses)
				{
					this.FetchAccountLicenses = other.FetchAccountLicenses;
				}
				bool hasFetchGameAccountLicenses = other.HasFetchGameAccountLicenses;
				if (hasFetchGameAccountLicenses)
				{
					this.FetchGameAccountLicenses = other.FetchGameAccountLicenses;
				}
				bool hasFetchDynamicAccountLicenses = other.HasFetchDynamicAccountLicenses;
				if (hasFetchDynamicAccountLicenses)
				{
					this.FetchDynamicAccountLicenses = other.FetchDynamicAccountLicenses;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasExcludeUnknownProgram = other.HasExcludeUnknownProgram;
				if (hasExcludeUnknownProgram)
				{
					this.ExcludeUnknownProgram = other.ExcludeUnknownProgram;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x00289E48 File Offset: 0x00288048
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x00289E54 File Offset: 0x00288054
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							if (num3 != 24U)
							{
								goto IL_003D;
							}
							this.FetchGameAccountLicenses = input.ReadBool();
						}
						else
						{
							this.FetchAccountLicenses = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new EntityId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 45U)
					{
						if (num3 != 48U)
						{
							goto IL_003D;
						}
						this.ExcludeUnknownProgram = input.ReadBool();
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.FetchDynamicAccountLicenses = input.ReadBool();
				}
				continue;
				IL_003D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004AE0 RID: 19168
		private static readonly MessageParser<GetLicensesRequest> _parser = new MessageParser<GetLicensesRequest>(() => new GetLicensesRequest());

		// Token: 0x04004AE1 RID: 19169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE2 RID: 19170
		private int _hasBits0;

		// Token: 0x04004AE3 RID: 19171
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04004AE4 RID: 19172
		private EntityId targetId_;

		// Token: 0x04004AE5 RID: 19173
		public const int FetchAccountLicensesFieldNumber = 2;

		// Token: 0x04004AE6 RID: 19174
		private static readonly bool FetchAccountLicensesDefaultValue = false;

		// Token: 0x04004AE7 RID: 19175
		private bool fetchAccountLicenses_;

		// Token: 0x04004AE8 RID: 19176
		public const int FetchGameAccountLicensesFieldNumber = 3;

		// Token: 0x04004AE9 RID: 19177
		private static readonly bool FetchGameAccountLicensesDefaultValue = false;

		// Token: 0x04004AEA RID: 19178
		private bool fetchGameAccountLicenses_;

		// Token: 0x04004AEB RID: 19179
		public const int FetchDynamicAccountLicensesFieldNumber = 4;

		// Token: 0x04004AEC RID: 19180
		private static readonly bool FetchDynamicAccountLicensesDefaultValue = false;

		// Token: 0x04004AED RID: 19181
		private bool fetchDynamicAccountLicenses_;

		// Token: 0x04004AEE RID: 19182
		public const int ProgramFieldNumber = 5;

		// Token: 0x04004AEF RID: 19183
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004AF0 RID: 19184
		private uint program_;

		// Token: 0x04004AF1 RID: 19185
		public const int ExcludeUnknownProgramFieldNumber = 6;

		// Token: 0x04004AF2 RID: 19186
		private static readonly bool ExcludeUnknownProgramDefaultValue = false;

		// Token: 0x04004AF3 RID: 19187
		private bool excludeUnknownProgram_;
	}
}

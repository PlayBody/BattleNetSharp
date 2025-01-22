using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000575 RID: 1397
	public sealed class SubmitReportRequest : IMessage<SubmitReportRequest>, IMessage, IEquatable<SubmitReportRequest>, IDeepCloneable<SubmitReportRequest>, IBufferMessage
	{
		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x06008665 RID: 34405 RVA: 0x0020A268 File Offset: 0x00208468
		[DebuggerNonUserCode]
		public static MessageParser<SubmitReportRequest> Parser
		{
			get
			{
				return SubmitReportRequest._parser;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x0020A280 File Offset: 0x00208480
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x0020A2A4 File Offset: 0x002084A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitReportRequest.Descriptor;
			}
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x0020A2BB File Offset: 0x002084BB
		[DebuggerNonUserCode]
		public SubmitReportRequest()
		{
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x0020A2C8 File Offset: 0x002084C8
		[DebuggerNonUserCode]
		public SubmitReportRequest(SubmitReportRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.reportType_ = ((other.reportType_ != null) ? other.reportType_.Clone() : null);
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x0020A340 File Offset: 0x00208540
		[DebuggerNonUserCode]
		public SubmitReportRequest Clone()
		{
			return new SubmitReportRequest(this);
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x0020A358 File Offset: 0x00208558
		// (set) Token: 0x0600866C RID: 34412 RVA: 0x0020A370 File Offset: 0x00208570
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x0020A37C File Offset: 0x0020857C
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x0020A394 File Offset: 0x00208594
		[DebuggerNonUserCode]
		public ReportType ReportType
		{
			get
			{
				return this.reportType_;
			}
			set
			{
				this.reportType_ = value;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600866F RID: 34415 RVA: 0x0020A3A0 File Offset: 0x002085A0
		// (set) Token: 0x06008670 RID: 34416 RVA: 0x0020A3D1 File Offset: 0x002085D1
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = SubmitReportRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x06008671 RID: 34417 RVA: 0x0020A3EC File Offset: 0x002085EC
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x0020A409 File Offset: 0x00208609
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x0020A41C File Offset: 0x0020861C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitReportRequest);
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x0020A43C File Offset: 0x0020863C
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
						bool flag5 = !object.Equals(this.ReportType, other.ReportType);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Program != other.Program;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x0020A4D0 File Offset: 0x002086D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.reportType_ != null;
			if (flag2)
			{
				num ^= this.ReportType.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x0020A558 File Offset: 0x00208758
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x0020A570 File Offset: 0x00208770
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x0020A57C File Offset: 0x0020877C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.reportType_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ReportType);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Program);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x0020A614 File Offset: 0x00208814
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.reportType_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReportType);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x0020A6A4 File Offset: 0x002088A4
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.reportType_ != null;
				if (flag4)
				{
					bool flag5 = this.reportType_ == null;
					if (flag5)
					{
						this.ReportType = new ReportType();
					}
					this.ReportType.MergeFrom(other.ReportType);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x0020A76C File Offset: 0x0020896C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x0020A778 File Offset: 0x00208978
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Program = input.ReadUInt32();
						}
					}
					else
					{
						bool flag = this.reportType_ == null;
						if (flag)
						{
							this.ReportType = new ReportType();
						}
						input.ReadMessage(this.ReportType);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x04003CEA RID: 15594
		private static readonly MessageParser<SubmitReportRequest> _parser = new MessageParser<SubmitReportRequest>(() => new SubmitReportRequest());

		// Token: 0x04003CEB RID: 15595
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CEC RID: 15596
		private int _hasBits0;

		// Token: 0x04003CED RID: 15597
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04003CEE RID: 15598
		private GameAccountHandle agentId_;

		// Token: 0x04003CEF RID: 15599
		public const int ReportTypeFieldNumber = 2;

		// Token: 0x04003CF0 RID: 15600
		private ReportType reportType_;

		// Token: 0x04003CF1 RID: 15601
		public const int ProgramFieldNumber = 3;

		// Token: 0x04003CF2 RID: 15602
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04003CF3 RID: 15603
		private uint program_;
	}
}

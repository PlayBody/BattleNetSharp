using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x02000574 RID: 1396
	public sealed class SendReportRequest : IMessage<SendReportRequest>, IMessage, IEquatable<SendReportRequest>, IDeepCloneable<SendReportRequest>, IBufferMessage
	{
		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600864E RID: 34382 RVA: 0x00209DB4 File Offset: 0x00207FB4
		[DebuggerNonUserCode]
		public static MessageParser<SendReportRequest> Parser
		{
			get
			{
				return SendReportRequest._parser;
			}
		}

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600864F RID: 34383 RVA: 0x00209DCC File Offset: 0x00207FCC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00209DF0 File Offset: 0x00207FF0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SendReportRequest.Descriptor;
			}
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00209E07 File Offset: 0x00208007
		[DebuggerNonUserCode]
		public SendReportRequest()
		{
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x00209E14 File Offset: 0x00208014
		[DebuggerNonUserCode]
		public SendReportRequest(SendReportRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.report_ = ((other.report_ != null) ? other.report_.Clone() : null);
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00209E70 File Offset: 0x00208070
		[DebuggerNonUserCode]
		public SendReportRequest Clone()
		{
			return new SendReportRequest(this);
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x00209E88 File Offset: 0x00208088
		// (set) Token: 0x06008655 RID: 34389 RVA: 0x00209EA0 File Offset: 0x002080A0
		[DebuggerNonUserCode]
		public Report Report
		{
			get
			{
				return this.report_;
			}
			set
			{
				this.report_ = value;
			}
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x00209EAC File Offset: 0x002080AC
		// (set) Token: 0x06008657 RID: 34391 RVA: 0x00209EDD File Offset: 0x002080DD
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
					programDefaultValue = SendReportRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x00209EF8 File Offset: 0x002080F8
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x00209F15 File Offset: 0x00208115
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00209F28 File Offset: 0x00208128
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SendReportRequest);
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00209F48 File Offset: 0x00208148
		[DebuggerNonUserCode]
		public bool Equals(SendReportRequest other)
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
					bool flag4 = !object.Equals(this.Report, other.Report);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x00209FBC File Offset: 0x002081BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.report_ != null;
			if (flag)
			{
				num ^= this.Report.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x0020A028 File Offset: 0x00208228
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x0020A040 File Offset: 0x00208240
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x0020A04C File Offset: 0x0020824C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.report_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Report);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x0020A0C0 File Offset: 0x002082C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.report_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Report);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x0020A130 File Offset: 0x00208330
		[DebuggerNonUserCode]
		public void MergeFrom(SendReportRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.report_ != null;
				if (flag2)
				{
					bool flag3 = this.report_ == null;
					if (flag3)
					{
						this.Report = new Report();
					}
					this.Report.MergeFrom(other.Report);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x0020A1B5 File Offset: 0x002083B5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x0020A1C0 File Offset: 0x002083C0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Program = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.report_ == null;
					if (flag)
					{
						this.Report = new Report();
					}
					input.ReadMessage(this.Report);
				}
			}
		}

		// Token: 0x04003CE2 RID: 15586
		private static readonly MessageParser<SendReportRequest> _parser = new MessageParser<SendReportRequest>(() => new SendReportRequest());

		// Token: 0x04003CE3 RID: 15587
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CE4 RID: 15588
		private int _hasBits0;

		// Token: 0x04003CE5 RID: 15589
		public const int ReportFieldNumber = 1;

		// Token: 0x04003CE6 RID: 15590
		private Report report_;

		// Token: 0x04003CE7 RID: 15591
		public const int ProgramFieldNumber = 2;

		// Token: 0x04003CE8 RID: 15592
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04003CE9 RID: 15593
		private uint program_;
	}
}

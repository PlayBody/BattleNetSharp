using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057E RID: 1406
	public sealed class HackingReport : IMessage<HackingReport>, IMessage, IEquatable<HackingReport>, IDeepCloneable<HackingReport>, IBufferMessage
	{
		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x0020D3AC File Offset: 0x0020B5AC
		[DebuggerNonUserCode]
		public static MessageParser<HackingReport> Parser
		{
			get
			{
				return HackingReport._parser;
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x06008722 RID: 34594 RVA: 0x0020D3C4 File Offset: 0x0020B5C4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06008723 RID: 34595 RVA: 0x0020D3E8 File Offset: 0x0020B5E8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HackingReport.Descriptor;
			}
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x0020D3FF File Offset: 0x0020B5FF
		[DebuggerNonUserCode]
		public HackingReport()
		{
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x0020D409 File Offset: 0x0020B609
		[DebuggerNonUserCode]
		public HackingReport(HackingReport other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x0020D440 File Offset: 0x0020B640
		[DebuggerNonUserCode]
		public HackingReport Clone()
		{
			return new HackingReport(this);
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x06008727 RID: 34599 RVA: 0x0020D458 File Offset: 0x0020B658
		// (set) Token: 0x06008728 RID: 34600 RVA: 0x0020D470 File Offset: 0x0020B670
		[DebuggerNonUserCode]
		public GameAccountHandle Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x06008729 RID: 34601 RVA: 0x0020D47C File Offset: 0x0020B67C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HackingReport);
		}

		// Token: 0x0600872A RID: 34602 RVA: 0x0020D49C File Offset: 0x0020B69C
		[DebuggerNonUserCode]
		public bool Equals(HackingReport other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600872B RID: 34603 RVA: 0x0020D4F8 File Offset: 0x0020B6F8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x0020D548 File Offset: 0x0020B748
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x0020D560 File Offset: 0x0020B760
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x0020D56C File Offset: 0x0020B76C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x0020D5BC File Offset: 0x0020B7BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x0020D610 File Offset: 0x0020B810
		[DebuggerNonUserCode]
		public void MergeFrom(HackingReport other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new GameAccountHandle();
					}
					this.Target.MergeFrom(other.Target);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x0020D67C File Offset: 0x0020B87C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x0020D688 File Offset: 0x0020B888
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
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new GameAccountHandle();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003D31 RID: 15665
		private static readonly MessageParser<HackingReport> _parser = new MessageParser<HackingReport>(() => new HackingReport());

		// Token: 0x04003D32 RID: 15666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D33 RID: 15667
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D34 RID: 15668
		private GameAccountHandle target_;
	}
}

using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057F RID: 1407
	public sealed class BottingReport : IMessage<BottingReport>, IMessage, IEquatable<BottingReport>, IDeepCloneable<BottingReport>, IBufferMessage
	{
		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x0020D714 File Offset: 0x0020B914
		[DebuggerNonUserCode]
		public static MessageParser<BottingReport> Parser
		{
			get
			{
				return BottingReport._parser;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x06008735 RID: 34613 RVA: 0x0020D72C File Offset: 0x0020B92C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x0020D750 File Offset: 0x0020B950
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BottingReport.Descriptor;
			}
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x0020D767 File Offset: 0x0020B967
		[DebuggerNonUserCode]
		public BottingReport()
		{
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x0020D771 File Offset: 0x0020B971
		[DebuggerNonUserCode]
		public BottingReport(BottingReport other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008739 RID: 34617 RVA: 0x0020D7A8 File Offset: 0x0020B9A8
		[DebuggerNonUserCode]
		public BottingReport Clone()
		{
			return new BottingReport(this);
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x0020D7C0 File Offset: 0x0020B9C0
		// (set) Token: 0x0600873B RID: 34619 RVA: 0x0020D7D8 File Offset: 0x0020B9D8
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

		// Token: 0x0600873C RID: 34620 RVA: 0x0020D7E4 File Offset: 0x0020B9E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BottingReport);
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x0020D804 File Offset: 0x0020BA04
		[DebuggerNonUserCode]
		public bool Equals(BottingReport other)
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

		// Token: 0x0600873E RID: 34622 RVA: 0x0020D860 File Offset: 0x0020BA60
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

		// Token: 0x0600873F RID: 34623 RVA: 0x0020D8B0 File Offset: 0x0020BAB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x0020D8C8 File Offset: 0x0020BAC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x0020D8D4 File Offset: 0x0020BAD4
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

		// Token: 0x06008742 RID: 34626 RVA: 0x0020D924 File Offset: 0x0020BB24
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

		// Token: 0x06008743 RID: 34627 RVA: 0x0020D978 File Offset: 0x0020BB78
		[DebuggerNonUserCode]
		public void MergeFrom(BottingReport other)
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

		// Token: 0x06008744 RID: 34628 RVA: 0x0020D9E4 File Offset: 0x0020BBE4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x0020D9F0 File Offset: 0x0020BBF0
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

		// Token: 0x04003D35 RID: 15669
		private static readonly MessageParser<BottingReport> _parser = new MessageParser<BottingReport>(() => new BottingReport());

		// Token: 0x04003D36 RID: 15670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D37 RID: 15671
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D38 RID: 15672
		private GameAccountHandle target_;
	}
}

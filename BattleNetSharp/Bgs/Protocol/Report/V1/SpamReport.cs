using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V1
{
	// Token: 0x0200057A RID: 1402
	public sealed class SpamReport : IMessage<SpamReport>, IMessage, IEquatable<SpamReport>, IDeepCloneable<SpamReport>, IBufferMessage
	{
		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x0020C14C File Offset: 0x0020A34C
		[DebuggerNonUserCode]
		public static MessageParser<SpamReport> Parser
		{
			get
			{
				return SpamReport._parser;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x060086C6 RID: 34502 RVA: 0x0020C164 File Offset: 0x0020A364
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x060086C7 RID: 34503 RVA: 0x0020C188 File Offset: 0x0020A388
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpamReport.Descriptor;
			}
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x0020C19F File Offset: 0x0020A39F
		[DebuggerNonUserCode]
		public SpamReport()
		{
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x0020C1AC File Offset: 0x0020A3AC
		[DebuggerNonUserCode]
		public SpamReport(SpamReport other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.source_ = other.source_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x0020C208 File Offset: 0x0020A408
		[DebuggerNonUserCode]
		public SpamReport Clone()
		{
			return new SpamReport(this);
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x0020C220 File Offset: 0x0020A420
		// (set) Token: 0x060086CC RID: 34508 RVA: 0x0020C238 File Offset: 0x0020A438
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

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x0020C244 File Offset: 0x0020A444
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x0020C275 File Offset: 0x0020A475
		[DebuggerNonUserCode]
		public SpamReport.Types.SpamSource Source
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				SpamReport.Types.SpamSource sourceDefaultValue;
				if (flag)
				{
					sourceDefaultValue = this.source_;
				}
				else
				{
					sourceDefaultValue = SpamReport.SourceDefaultValue;
				}
				return sourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.source_ = value;
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x0020C290 File Offset: 0x0020A490
		[DebuggerNonUserCode]
		public bool HasSource
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x0020C2AD File Offset: 0x0020A4AD
		[DebuggerNonUserCode]
		public void ClearSource()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x0020C2C0 File Offset: 0x0020A4C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpamReport);
		}

		// Token: 0x060086D2 RID: 34514 RVA: 0x0020C2E0 File Offset: 0x0020A4E0
		[DebuggerNonUserCode]
		public bool Equals(SpamReport other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Source != other.Source;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x0020C354 File Offset: 0x0020A554
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num ^= this.Source.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x0020C3C8 File Offset: 0x0020A5C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x0020C3E0 File Offset: 0x0020A5E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x0020C3EC File Offset: 0x0020A5EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Source);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x0020C460 File Offset: 0x0020A660
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x0020C4D0 File Offset: 0x0020A6D0
		[DebuggerNonUserCode]
		public void MergeFrom(SpamReport other)
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
				bool hasSource = other.HasSource;
				if (hasSource)
				{
					this.Source = other.Source;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x0020C555 File Offset: 0x0020A755
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x0020C560 File Offset: 0x0020A760
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
						this.Source = (SpamReport.Types.SpamSource)input.ReadEnum();
					}
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

		// Token: 0x04003D14 RID: 15636
		private static readonly MessageParser<SpamReport> _parser = new MessageParser<SpamReport>(() => new SpamReport());

		// Token: 0x04003D15 RID: 15637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D16 RID: 15638
		private int _hasBits0;

		// Token: 0x04003D17 RID: 15639
		public const int TargetFieldNumber = 1;

		// Token: 0x04003D18 RID: 15640
		private GameAccountHandle target_;

		// Token: 0x04003D19 RID: 15641
		public const int SourceFieldNumber = 2;

		// Token: 0x04003D1A RID: 15642
		private static readonly SpamReport.Types.SpamSource SourceDefaultValue = SpamReport.Types.SpamSource.Other;

		// Token: 0x04003D1B RID: 15643
		private SpamReport.Types.SpamSource source_;

		// Token: 0x02001050 RID: 4176
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02001496 RID: 5270
			public enum SpamSource
			{
				// Token: 0x0400A4F5 RID: 42229
				[OriginalName("OTHER")]
				Other = 1,
				// Token: 0x0400A4F6 RID: 42230
				[OriginalName("FRIEND_INVITATION")]
				FriendInvitation,
				// Token: 0x0400A4F7 RID: 42231
				[OriginalName("WHISPER")]
				Whisper,
				// Token: 0x0400A4F8 RID: 42232
				[OriginalName("CHAT")]
				Chat
			}
		}
	}
}

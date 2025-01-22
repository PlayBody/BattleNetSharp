using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Report.V2
{
	// Token: 0x02000589 RID: 1417
	public sealed class UserOptions : IMessage<UserOptions>, IMessage, IEquatable<UserOptions>, IDeepCloneable<UserOptions>, IBufferMessage
	{
		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x060087A7 RID: 34727 RVA: 0x0020F65C File Offset: 0x0020D85C
		[DebuggerNonUserCode]
		public static MessageParser<UserOptions> Parser
		{
			get
			{
				return UserOptions._parser;
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x060087A8 RID: 34728 RVA: 0x0020F674 File Offset: 0x0020D874
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x060087A9 RID: 34729 RVA: 0x0020F698 File Offset: 0x0020D898
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UserOptions.Descriptor;
			}
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x0020F6AF File Offset: 0x0020D8AF
		[DebuggerNonUserCode]
		public UserOptions()
		{
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x0020F6BC File Offset: 0x0020D8BC
		[DebuggerNonUserCode]
		public UserOptions(UserOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.type_ = other.type_;
			this.source_ = other.source_;
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x0020F740 File Offset: 0x0020D940
		[DebuggerNonUserCode]
		public UserOptions Clone()
		{
			return new UserOptions(this);
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x060087AD RID: 34733 RVA: 0x0020F758 File Offset: 0x0020D958
		// (set) Token: 0x060087AE RID: 34734 RVA: 0x0020F770 File Offset: 0x0020D970
		[DebuggerNonUserCode]
		public AccountId TargetId
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

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x060087AF RID: 34735 RVA: 0x0020F77C File Offset: 0x0020D97C
		// (set) Token: 0x060087B0 RID: 34736 RVA: 0x0020F7AD File Offset: 0x0020D9AD
		[DebuggerNonUserCode]
		public IssueType Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				IssueType typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = UserOptions.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x060087B1 RID: 34737 RVA: 0x0020F7C8 File Offset: 0x0020D9C8
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x0020F7E5 File Offset: 0x0020D9E5
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x060087B3 RID: 34739 RVA: 0x0020F7F8 File Offset: 0x0020D9F8
		// (set) Token: 0x060087B4 RID: 34740 RVA: 0x0020F829 File Offset: 0x0020DA29
		[DebuggerNonUserCode]
		public UserSource Source
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				UserSource sourceDefaultValue;
				if (flag)
				{
					sourceDefaultValue = this.source_;
				}
				else
				{
					sourceDefaultValue = UserOptions.SourceDefaultValue;
				}
				return sourceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.source_ = value;
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x060087B5 RID: 34741 RVA: 0x0020F844 File Offset: 0x0020DA44
		[DebuggerNonUserCode]
		public bool HasSource
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x0020F861 File Offset: 0x0020DA61
		[DebuggerNonUserCode]
		public void ClearSource()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x060087B7 RID: 34743 RVA: 0x0020F874 File Offset: 0x0020DA74
		// (set) Token: 0x060087B8 RID: 34744 RVA: 0x0020F88C File Offset: 0x0020DA8C
		[DebuggerNonUserCode]
		public ReportItem Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x060087B9 RID: 34745 RVA: 0x0020F898 File Offset: 0x0020DA98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UserOptions);
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x0020F8B8 File Offset: 0x0020DAB8
		[DebuggerNonUserCode]
		public bool Equals(UserOptions other)
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
						bool flag5 = this.Type != other.Type;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Source != other.Source;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Item, other.Item);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x0020F96C File Offset: 0x0020DB6C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num ^= this.Source.GetHashCode();
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				num ^= this.Item.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087BC RID: 34748 RVA: 0x0020FA20 File Offset: 0x0020DC20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060087BD RID: 34749 RVA: 0x0020FA38 File Offset: 0x0020DC38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087BE RID: 34750 RVA: 0x0020FA44 File Offset: 0x0020DC44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetId);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Source);
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Item);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087BF RID: 34751 RVA: 0x0020FB00 File Offset: 0x0020DD00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			bool hasSource = this.HasSource;
			if (hasSource)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Source);
			}
			bool flag2 = this.item_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087C0 RID: 34752 RVA: 0x0020FBB0 File Offset: 0x0020DDB0
		[DebuggerNonUserCode]
		public void MergeFrom(UserOptions other)
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
						this.TargetId = new AccountId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasSource = other.HasSource;
				if (hasSource)
				{
					this.Source = other.Source;
				}
				bool flag4 = other.item_ != null;
				if (flag4)
				{
					bool flag5 = this.item_ == null;
					if (flag5)
					{
						this.Item = new ReportItem();
					}
					this.Item.MergeFrom(other.Item);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x0020FC93 File Offset: 0x0020DE93
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x0020FCA0 File Offset: 0x0020DEA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002C;
						}
						this.Type = (IssueType)input.ReadEnum();
					}
					else
					{
						bool flag = this.targetId_ == null;
						if (flag)
						{
							this.TargetId = new AccountId();
						}
						input.ReadMessage(this.TargetId);
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_002C;
					}
					bool flag2 = this.item_ == null;
					if (flag2)
					{
						this.Item = new ReportItem();
					}
					input.ReadMessage(this.Item);
				}
				else
				{
					this.Source = (UserSource)input.ReadEnum();
				}
				continue;
				IL_002C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D7A RID: 15738
		private static readonly MessageParser<UserOptions> _parser = new MessageParser<UserOptions>(() => new UserOptions());

		// Token: 0x04003D7B RID: 15739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7C RID: 15740
		private int _hasBits0;

		// Token: 0x04003D7D RID: 15741
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04003D7E RID: 15742
		private AccountId targetId_;

		// Token: 0x04003D7F RID: 15743
		public const int TypeFieldNumber = 2;

		// Token: 0x04003D80 RID: 15744
		private static readonly IssueType TypeDefaultValue = IssueType.Spam;

		// Token: 0x04003D81 RID: 15745
		private IssueType type_;

		// Token: 0x04003D82 RID: 15746
		public const int SourceFieldNumber = 3;

		// Token: 0x04003D83 RID: 15747
		private static readonly UserSource SourceDefaultValue = UserSource.Other;

		// Token: 0x04003D84 RID: 15748
		private UserSource source_;

		// Token: 0x04003D85 RID: 15749
		public const int ItemFieldNumber = 4;

		// Token: 0x04003D86 RID: 15750
		private ReportItem item_;
	}
}

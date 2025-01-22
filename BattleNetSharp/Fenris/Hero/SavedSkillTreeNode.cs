using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000180 RID: 384
	public sealed class SavedSkillTreeNode : IMessage<SavedSkillTreeNode>, IMessage, IEquatable<SavedSkillTreeNode>, IDeepCloneable<SavedSkillTreeNode>, IBufferMessage
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x0009D750 File Offset: 0x0009B950
		[DebuggerNonUserCode]
		public static MessageParser<SavedSkillTreeNode> Parser
		{
			get
			{
				return SavedSkillTreeNode._parser;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x0009D768 File Offset: 0x0009B968
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x0009D78C File Offset: 0x0009B98C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedSkillTreeNode.Descriptor;
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0009D7A3 File Offset: 0x0009B9A3
		[DebuggerNonUserCode]
		public SavedSkillTreeNode()
		{
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0009D7AD File Offset: 0x0009B9AD
		[DebuggerNonUserCode]
		public SavedSkillTreeNode(SavedSkillTreeNode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.nodeId_ = other.nodeId_;
			this.rank_ = other.rank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x0009D7EC File Offset: 0x0009B9EC
		[DebuggerNonUserCode]
		public SavedSkillTreeNode Clone()
		{
			return new SavedSkillTreeNode(this);
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x0009D804 File Offset: 0x0009BA04
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0009D835 File Offset: 0x0009BA35
		[DebuggerNonUserCode]
		public uint NodeId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint nodeIdDefaultValue;
				if (flag)
				{
					nodeIdDefaultValue = this.nodeId_;
				}
				else
				{
					nodeIdDefaultValue = SavedSkillTreeNode.NodeIdDefaultValue;
				}
				return nodeIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.nodeId_ = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x0009D850 File Offset: 0x0009BA50
		[DebuggerNonUserCode]
		public bool HasNodeId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x0009D86D File Offset: 0x0009BA6D
		[DebuggerNonUserCode]
		public void ClearNodeId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x0009D880 File Offset: 0x0009BA80
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x0009D8B1 File Offset: 0x0009BAB1
		[DebuggerNonUserCode]
		public uint Rank
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint rankDefaultValue;
				if (flag)
				{
					rankDefaultValue = this.rank_;
				}
				else
				{
					rankDefaultValue = SavedSkillTreeNode.RankDefaultValue;
				}
				return rankDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.rank_ = value;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600284E RID: 10318 RVA: 0x0009D8CC File Offset: 0x0009BACC
		[DebuggerNonUserCode]
		public bool HasRank
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0009D8E9 File Offset: 0x0009BAE9
		[DebuggerNonUserCode]
		public void ClearRank()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0009D8FC File Offset: 0x0009BAFC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedSkillTreeNode);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0009D91C File Offset: 0x0009BB1C
		[DebuggerNonUserCode]
		public bool Equals(SavedSkillTreeNode other)
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
					bool flag4 = this.NodeId != other.NodeId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Rank != other.Rank;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0009D990 File Offset: 0x0009BB90
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				num ^= this.NodeId.GetHashCode();
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				num ^= this.Rank.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0009D9FC File Offset: 0x0009BBFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x0009DA14 File Offset: 0x0009BC14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0009DA20 File Offset: 0x0009BC20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NodeId);
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Rank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0009DA90 File Offset: 0x0009BC90
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNodeId = this.HasNodeId;
			if (hasNodeId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NodeId);
			}
			bool hasRank = this.HasRank;
			if (hasRank)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0009DAFC File Offset: 0x0009BCFC
		[DebuggerNonUserCode]
		public void MergeFrom(SavedSkillTreeNode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNodeId = other.HasNodeId;
				if (hasNodeId)
				{
					this.NodeId = other.NodeId;
				}
				bool hasRank = other.HasRank;
				if (hasRank)
				{
					this.Rank = other.Rank;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0009DB5E File Offset: 0x0009BD5E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0009DB6C File Offset: 0x0009BD6C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Rank = input.ReadUInt32();
					}
				}
				else
				{
					this.NodeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040011EC RID: 4588
		private static readonly MessageParser<SavedSkillTreeNode> _parser = new MessageParser<SavedSkillTreeNode>(() => new SavedSkillTreeNode());

		// Token: 0x040011ED RID: 4589
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011EE RID: 4590
		private int _hasBits0;

		// Token: 0x040011EF RID: 4591
		public const int NodeIdFieldNumber = 1;

		// Token: 0x040011F0 RID: 4592
		private static readonly uint NodeIdDefaultValue = uint.MaxValue;

		// Token: 0x040011F1 RID: 4593
		private uint nodeId_;

		// Token: 0x040011F2 RID: 4594
		public const int RankFieldNumber = 2;

		// Token: 0x040011F3 RID: 4595
		private static readonly uint RankDefaultValue = 0U;

		// Token: 0x040011F4 RID: 4596
		private uint rank_;
	}
}

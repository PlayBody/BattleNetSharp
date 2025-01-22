using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200009A RID: 154
	public sealed class UITreeOperation : IMessage<UITreeOperation>, IMessage, IEquatable<UITreeOperation>, IDeepCloneable<UITreeOperation>, IBufferMessage
	{
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00035170 File Offset: 0x00033370
		[DebuggerNonUserCode]
		public static MessageParser<UITreeOperation> Parser
		{
			get
			{
				return UITreeOperation._parser;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00035188 File Offset: 0x00033388
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[131];
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000351B0 File Offset: 0x000333B0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeOperation.Descriptor;
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000351C7 File Offset: 0x000333C7
		[DebuggerNonUserCode]
		public UITreeOperation()
		{
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000351D4 File Offset: 0x000333D4
		[DebuggerNonUserCode]
		public UITreeOperation(UITreeOperation other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.addedNode_ = ((other.addedNode_ != null) ? other.addedNode_.Clone() : null);
			this.parentHash_ = other.parentHash_;
			this.deletedHash_ = other.deletedHash_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00035248 File Offset: 0x00033448
		[DebuggerNonUserCode]
		public UITreeOperation Clone()
		{
			return new UITreeOperation(this);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00035260 File Offset: 0x00033460
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x00035291 File Offset: 0x00033491
		[DebuggerNonUserCode]
		public UITreeOperationType Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				UITreeOperationType typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = UITreeOperation.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000352AC File Offset: 0x000334AC
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x000352C9 File Offset: 0x000334C9
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000352DC File Offset: 0x000334DC
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000352F4 File Offset: 0x000334F4
		[DebuggerNonUserCode]
		public UITreeNode AddedNode
		{
			get
			{
				return this.addedNode_;
			}
			set
			{
				this.addedNode_ = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00035300 File Offset: 0x00033500
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00035331 File Offset: 0x00033531
		[DebuggerNonUserCode]
		public ulong ParentHash
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong parentHashDefaultValue;
				if (flag)
				{
					parentHashDefaultValue = this.parentHash_;
				}
				else
				{
					parentHashDefaultValue = UITreeOperation.ParentHashDefaultValue;
				}
				return parentHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.parentHash_ = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0003534C File Offset: 0x0003354C
		[DebuggerNonUserCode]
		public bool HasParentHash
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00035369 File Offset: 0x00033569
		[DebuggerNonUserCode]
		public void ClearParentHash()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0003537C File Offset: 0x0003357C
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000353AD File Offset: 0x000335AD
		[DebuggerNonUserCode]
		public ulong DeletedHash
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong deletedHashDefaultValue;
				if (flag)
				{
					deletedHashDefaultValue = this.deletedHash_;
				}
				else
				{
					deletedHashDefaultValue = UITreeOperation.DeletedHashDefaultValue;
				}
				return deletedHashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.deletedHash_ = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000353C8 File Offset: 0x000335C8
		[DebuggerNonUserCode]
		public bool HasDeletedHash
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000353E5 File Offset: 0x000335E5
		[DebuggerNonUserCode]
		public void ClearDeletedHash()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000353F8 File Offset: 0x000335F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeOperation);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00035418 File Offset: 0x00033618
		[DebuggerNonUserCode]
		public bool Equals(UITreeOperation other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AddedNode, other.AddedNode);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ParentHash != other.ParentHash;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.DeletedHash != other.DeletedHash;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000354C8 File Offset: 0x000336C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag = this.addedNode_ != null;
			if (flag)
			{
				num ^= this.AddedNode.GetHashCode();
			}
			bool hasParentHash = this.HasParentHash;
			if (hasParentHash)
			{
				num ^= this.ParentHash.GetHashCode();
			}
			bool hasDeletedHash = this.HasDeletedHash;
			if (hasDeletedHash)
			{
				num ^= this.DeletedHash.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00035578 File Offset: 0x00033778
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00035590 File Offset: 0x00033790
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0003559C File Offset: 0x0003379C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			bool flag = this.addedNode_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AddedNode);
			}
			bool hasParentHash = this.HasParentHash;
			if (hasParentHash)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ParentHash);
			}
			bool hasDeletedHash = this.HasDeletedHash;
			if (hasDeletedHash)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.DeletedHash);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00035654 File Offset: 0x00033854
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			bool flag = this.addedNode_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddedNode);
			}
			bool hasParentHash = this.HasParentHash;
			if (hasParentHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ParentHash);
			}
			bool hasDeletedHash = this.HasDeletedHash;
			if (hasDeletedHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.DeletedHash);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00035700 File Offset: 0x00033900
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeOperation other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool flag2 = other.addedNode_ != null;
				if (flag2)
				{
					bool flag3 = this.addedNode_ == null;
					if (flag3)
					{
						this.AddedNode = new UITreeNode();
					}
					this.AddedNode.MergeFrom(other.AddedNode);
				}
				bool hasParentHash = other.HasParentHash;
				if (hasParentHash)
				{
					this.ParentHash = other.ParentHash;
				}
				bool hasDeletedHash = other.HasDeletedHash;
				if (hasDeletedHash)
				{
					this.DeletedHash = other.DeletedHash;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000357BE File Offset: 0x000339BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000357CC File Offset: 0x000339CC
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
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_002B;
						}
						bool flag = this.addedNode_ == null;
						if (flag)
						{
							this.AddedNode = new UITreeNode();
						}
						input.ReadMessage(this.AddedNode);
					}
					else
					{
						this.Type = (UITreeOperationType)input.ReadEnum();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_002B;
					}
					this.DeletedHash = input.ReadUInt64();
				}
				else
				{
					this.ParentHash = input.ReadUInt64();
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly MessageParser<UITreeOperation> _parser = new MessageParser<UITreeOperation>(() => new UITreeOperation());

		// Token: 0x040005AA RID: 1450
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005AB RID: 1451
		private int _hasBits0;

		// Token: 0x040005AC RID: 1452
		public const int TypeFieldNumber = 1;

		// Token: 0x040005AD RID: 1453
		private static readonly UITreeOperationType TypeDefaultValue = UITreeOperationType.UitreeoperationAdd;

		// Token: 0x040005AE RID: 1454
		private UITreeOperationType type_;

		// Token: 0x040005AF RID: 1455
		public const int AddedNodeFieldNumber = 2;

		// Token: 0x040005B0 RID: 1456
		private UITreeNode addedNode_;

		// Token: 0x040005B1 RID: 1457
		public const int ParentHashFieldNumber = 3;

		// Token: 0x040005B2 RID: 1458
		private static readonly ulong ParentHashDefaultValue = 0UL;

		// Token: 0x040005B3 RID: 1459
		private ulong parentHash_;

		// Token: 0x040005B4 RID: 1460
		public const int DeletedHashFieldNumber = 4;

		// Token: 0x040005B5 RID: 1461
		private static readonly ulong DeletedHashDefaultValue = 0UL;

		// Token: 0x040005B6 RID: 1462
		private ulong deletedHash_;
	}
}

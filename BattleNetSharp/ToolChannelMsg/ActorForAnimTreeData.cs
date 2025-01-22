using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E2 RID: 226
	public sealed class ActorForAnimTreeData : IMessage<ActorForAnimTreeData>, IMessage, IEquatable<ActorForAnimTreeData>, IDeepCloneable<ActorForAnimTreeData>, IBufferMessage
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x0004FE38 File Offset: 0x0004E038
		[DebuggerNonUserCode]
		public static MessageParser<ActorForAnimTreeData> Parser
		{
			get
			{
				return ActorForAnimTreeData._parser;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0004FE50 File Offset: 0x0004E050
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[203];
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0004FE78 File Offset: 0x0004E078
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActorForAnimTreeData.Descriptor;
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0004FE8F File Offset: 0x0004E08F
		[DebuggerNonUserCode]
		public ActorForAnimTreeData()
		{
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0004FE99 File Offset: 0x0004E099
		[DebuggerNonUserCode]
		public ActorForAnimTreeData(ActorForAnimTreeData other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.ractorId_ = other.ractorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		[DebuggerNonUserCode]
		public ActorForAnimTreeData Clone()
		{
			return new ActorForAnimTreeData(this);
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x0004FEF0 File Offset: 0x0004E0F0
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0004FF21 File Offset: 0x0004E121
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = ActorForAnimTreeData.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0004FF3C File Offset: 0x0004E13C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0004FF59 File Offset: 0x0004E159
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0004FF6C File Offset: 0x0004E16C
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0004FF9D File Offset: 0x0004E19D
		[DebuggerNonUserCode]
		public int RactorId
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int ractorIdDefaultValue;
				if (flag)
				{
					ractorIdDefaultValue = this.ractorId_;
				}
				else
				{
					ractorIdDefaultValue = ActorForAnimTreeData.RactorIdDefaultValue;
				}
				return ractorIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.ractorId_ = value;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0004FFB8 File Offset: 0x0004E1B8
		[DebuggerNonUserCode]
		public bool HasRactorId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x0004FFD5 File Offset: 0x0004E1D5
		[DebuggerNonUserCode]
		public void ClearRactorId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0004FFE8 File Offset: 0x0004E1E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActorForAnimTreeData);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00050008 File Offset: 0x0004E208
		[DebuggerNonUserCode]
		public bool Equals(ActorForAnimTreeData other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.RactorId != other.RactorId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0005007C File Offset: 0x0004E27C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				num ^= this.RactorId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000500E8 File Offset: 0x0004E2E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00050100 File Offset: 0x0004E300
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0005010C File Offset: 0x0004E30C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RactorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0005017C File Offset: 0x0004E37C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasRactorId = this.HasRactorId;
			if (hasRactorId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RactorId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000501E8 File Offset: 0x0004E3E8
		[DebuggerNonUserCode]
		public void MergeFrom(ActorForAnimTreeData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasRactorId = other.HasRactorId;
				if (hasRactorId)
				{
					this.RactorId = other.RactorId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0005024A File Offset: 0x0004E44A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00050258 File Offset: 0x0004E458
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
						this.RactorId = input.ReadInt32();
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040008F0 RID: 2288
		private static readonly MessageParser<ActorForAnimTreeData> _parser = new MessageParser<ActorForAnimTreeData>(() => new ActorForAnimTreeData());

		// Token: 0x040008F1 RID: 2289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008F2 RID: 2290
		private int _hasBits0;

		// Token: 0x040008F3 RID: 2291
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x040008F4 RID: 2292
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x040008F5 RID: 2293
		private int snoHandle_;

		// Token: 0x040008F6 RID: 2294
		public const int RactorIdFieldNumber = 2;

		// Token: 0x040008F7 RID: 2295
		private static readonly int RactorIdDefaultValue = 0;

		// Token: 0x040008F8 RID: 2296
		private int ractorId_;
	}
}

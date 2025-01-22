using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E1 RID: 225
	public sealed class RequestActorsForAnimTree : IMessage<RequestActorsForAnimTree>, IMessage, IEquatable<RequestActorsForAnimTree>, IDeepCloneable<RequestActorsForAnimTree>, IBufferMessage
	{
		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0004FAC0 File Offset: 0x0004DCC0
		[DebuggerNonUserCode]
		public static MessageParser<RequestActorsForAnimTree> Parser
		{
			get
			{
				return RequestActorsForAnimTree._parser;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[202];
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0004FB00 File Offset: 0x0004DD00
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RequestActorsForAnimTree.Descriptor;
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0004FB17 File Offset: 0x0004DD17
		[DebuggerNonUserCode]
		public RequestActorsForAnimTree()
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0004FB21 File Offset: 0x0004DD21
		[DebuggerNonUserCode]
		public RequestActorsForAnimTree(RequestActorsForAnimTree other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.animTreeHandle_ = other.animTreeHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0004FB54 File Offset: 0x0004DD54
		[DebuggerNonUserCode]
		public RequestActorsForAnimTree Clone()
		{
			return new RequestActorsForAnimTree(this);
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x0004FB6C File Offset: 0x0004DD6C
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0004FB9D File Offset: 0x0004DD9D
		[DebuggerNonUserCode]
		public int AnimTreeHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int animTreeHandleDefaultValue;
				if (flag)
				{
					animTreeHandleDefaultValue = this.animTreeHandle_;
				}
				else
				{
					animTreeHandleDefaultValue = RequestActorsForAnimTree.AnimTreeHandleDefaultValue;
				}
				return animTreeHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.animTreeHandle_ = value;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
		[DebuggerNonUserCode]
		public bool HasAnimTreeHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0004FBD5 File Offset: 0x0004DDD5
		[DebuggerNonUserCode]
		public void ClearAnimTreeHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0004FBE8 File Offset: 0x0004DDE8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RequestActorsForAnimTree);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0004FC08 File Offset: 0x0004DE08
		[DebuggerNonUserCode]
		public bool Equals(RequestActorsForAnimTree other)
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
					bool flag4 = this.AnimTreeHandle != other.AnimTreeHandle;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0004FC60 File Offset: 0x0004DE60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAnimTreeHandle = this.HasAnimTreeHandle;
			if (hasAnimTreeHandle)
			{
				num ^= this.AnimTreeHandle.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0004FCB0 File Offset: 0x0004DEB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0004FCC8 File Offset: 0x0004DEC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0004FCD4 File Offset: 0x0004DED4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAnimTreeHandle = this.HasAnimTreeHandle;
			if (hasAnimTreeHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AnimTreeHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0004FD20 File Offset: 0x0004DF20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAnimTreeHandle = this.HasAnimTreeHandle;
			if (hasAnimTreeHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnimTreeHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0004FD70 File Offset: 0x0004DF70
		[DebuggerNonUserCode]
		public void MergeFrom(RequestActorsForAnimTree other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAnimTreeHandle = other.HasAnimTreeHandle;
				if (hasAnimTreeHandle)
				{
					this.AnimTreeHandle = other.AnimTreeHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0004FDB9 File Offset: 0x0004DFB9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0004FDC4 File Offset: 0x0004DFC4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AnimTreeHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x040008EA RID: 2282
		private static readonly MessageParser<RequestActorsForAnimTree> _parser = new MessageParser<RequestActorsForAnimTree>(() => new RequestActorsForAnimTree());

		// Token: 0x040008EB RID: 2283
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008EC RID: 2284
		private int _hasBits0;

		// Token: 0x040008ED RID: 2285
		public const int AnimTreeHandleFieldNumber = 1;

		// Token: 0x040008EE RID: 2286
		private static readonly int AnimTreeHandleDefaultValue = 0;

		// Token: 0x040008EF RID: 2287
		private int animTreeHandle_;
	}
}

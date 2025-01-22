using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E0 RID: 224
	public sealed class UpdateRoadsCanceled : IMessage<UpdateRoadsCanceled>, IMessage, IEquatable<UpdateRoadsCanceled>, IDeepCloneable<UpdateRoadsCanceled>, IBufferMessage
	{
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0004F754 File Offset: 0x0004D954
		[DebuggerNonUserCode]
		public static MessageParser<UpdateRoadsCanceled> Parser
		{
			get
			{
				return UpdateRoadsCanceled._parser;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0004F76C File Offset: 0x0004D96C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[201];
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0004F794 File Offset: 0x0004D994
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRoadsCanceled.Descriptor;
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0004F7AB File Offset: 0x0004D9AB
		[DebuggerNonUserCode]
		public UpdateRoadsCanceled()
		{
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0004F7B5 File Offset: 0x0004D9B5
		[DebuggerNonUserCode]
		public UpdateRoadsCanceled(UpdateRoadsCanceled other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.canceled_ = other.canceled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0004F7E8 File Offset: 0x0004D9E8
		[DebuggerNonUserCode]
		public UpdateRoadsCanceled Clone()
		{
			return new UpdateRoadsCanceled(this);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0004F800 File Offset: 0x0004DA00
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0004F831 File Offset: 0x0004DA31
		[DebuggerNonUserCode]
		public bool Canceled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool canceledDefaultValue;
				if (flag)
				{
					canceledDefaultValue = this.canceled_;
				}
				else
				{
					canceledDefaultValue = UpdateRoadsCanceled.CanceledDefaultValue;
				}
				return canceledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.canceled_ = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x0004F84C File Offset: 0x0004DA4C
		[DebuggerNonUserCode]
		public bool HasCanceled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0004F869 File Offset: 0x0004DA69
		[DebuggerNonUserCode]
		public void ClearCanceled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0004F87C File Offset: 0x0004DA7C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRoadsCanceled);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0004F89C File Offset: 0x0004DA9C
		[DebuggerNonUserCode]
		public bool Equals(UpdateRoadsCanceled other)
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
					bool flag4 = this.Canceled != other.Canceled;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
			{
				num ^= this.Canceled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0004F944 File Offset: 0x0004DB44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0004F95C File Offset: 0x0004DB5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0004F968 File Offset: 0x0004DB68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Canceled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateRoadsCanceled other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCanceled = other.HasCanceled;
				if (hasCanceled)
				{
					this.Canceled = other.Canceled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0004FA41 File Offset: 0x0004DC41
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0004FA4C File Offset: 0x0004DC4C
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
					this.Canceled = input.ReadBool();
				}
			}
		}

		// Token: 0x040008E4 RID: 2276
		private static readonly MessageParser<UpdateRoadsCanceled> _parser = new MessageParser<UpdateRoadsCanceled>(() => new UpdateRoadsCanceled());

		// Token: 0x040008E5 RID: 2277
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008E6 RID: 2278
		private int _hasBits0;

		// Token: 0x040008E7 RID: 2279
		public const int CanceledFieldNumber = 1;

		// Token: 0x040008E8 RID: 2280
		private static readonly bool CanceledDefaultValue = false;

		// Token: 0x040008E9 RID: 2281
		private bool canceled_;
	}
}

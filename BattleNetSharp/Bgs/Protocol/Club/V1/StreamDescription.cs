using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F7 RID: 1271
	public sealed class StreamDescription : IMessage<StreamDescription>, IMessage, IEquatable<StreamDescription>, IDeepCloneable<StreamDescription>, IBufferMessage
	{
		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06007C3F RID: 31807 RVA: 0x001E41A0 File Offset: 0x001E23A0
		[DebuggerNonUserCode]
		public static MessageParser<StreamDescription> Parser
		{
			get
			{
				return StreamDescription._parser;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x06007C40 RID: 31808 RVA: 0x001E41B8 File Offset: 0x001E23B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x001E41DC File Offset: 0x001E23DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamDescription.Descriptor;
			}
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x001E41F3 File Offset: 0x001E23F3
		[DebuggerNonUserCode]
		public StreamDescription()
		{
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x001E41FD File Offset: 0x001E23FD
		[DebuggerNonUserCode]
		public StreamDescription(StreamDescription other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x001E423C File Offset: 0x001E243C
		[DebuggerNonUserCode]
		public StreamDescription Clone()
		{
			return new StreamDescription(this);
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06007C45 RID: 31813 RVA: 0x001E4254 File Offset: 0x001E2454
		// (set) Token: 0x06007C46 RID: 31814 RVA: 0x001E4285 File Offset: 0x001E2485
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = StreamDescription.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06007C47 RID: 31815 RVA: 0x001E42A0 File Offset: 0x001E24A0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x001E42BD File Offset: 0x001E24BD
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06007C49 RID: 31817 RVA: 0x001E42D0 File Offset: 0x001E24D0
		// (set) Token: 0x06007C4A RID: 31818 RVA: 0x001E42F1 File Offset: 0x001E24F1
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? StreamDescription.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06007C4B RID: 31819 RVA: 0x001E4308 File Offset: 0x001E2508
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x001E4323 File Offset: 0x001E2523
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06007C4D RID: 31821 RVA: 0x001E4330 File Offset: 0x001E2530
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamDescription);
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x001E4350 File Offset: 0x001E2550
		[DebuggerNonUserCode]
		public bool Equals(StreamDescription other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Name != other.Name;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x001E43C4 File Offset: 0x001E25C4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x001E4430 File Offset: 0x001E2630
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x001E4448 File Offset: 0x001E2648
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x001E4454 File Offset: 0x001E2654
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x001E44C4 File Offset: 0x001E26C4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x001E4530 File Offset: 0x001E2730
		[DebuggerNonUserCode]
		public void MergeFrom(StreamDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x001E4592 File Offset: 0x001E2792
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x001E45A0 File Offset: 0x001E27A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					if (num3 != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003883 RID: 14467
		private static readonly MessageParser<StreamDescription> _parser = new MessageParser<StreamDescription>(() => new StreamDescription());

		// Token: 0x04003884 RID: 14468
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003885 RID: 14469
		private int _hasBits0;

		// Token: 0x04003886 RID: 14470
		public const int IdFieldNumber = 2;

		// Token: 0x04003887 RID: 14471
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04003888 RID: 14472
		private ulong id_;

		// Token: 0x04003889 RID: 14473
		public const int NameFieldNumber = 4;

		// Token: 0x0400388A RID: 14474
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400388B RID: 14475
		private string name_;
	}
}

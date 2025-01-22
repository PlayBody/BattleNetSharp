using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000326 RID: 806
	public sealed class Level : IMessage<Level>, IMessage, IEquatable<Level>, IDeepCloneable<Level>, IBufferMessage
	{
		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x00145944 File Offset: 0x00143B44
		[DebuggerNonUserCode]
		public static MessageParser<Level> Parser
		{
			get
			{
				return Level._parser;
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x0014595C File Offset: 0x00143B5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonGameContextReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x00145980 File Offset: 0x00143B80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Level.Descriptor;
			}
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00145997 File Offset: 0x00143B97
		[DebuggerNonUserCode]
		public Level()
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x001459A1 File Offset: 0x00143BA1
		[DebuggerNonUserCode]
		public Level(Level other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x001459E0 File Offset: 0x00143BE0
		[DebuggerNonUserCode]
		public Level Clone()
		{
			return new Level(this);
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x001459F8 File Offset: 0x00143BF8
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x00145A29 File Offset: 0x00143C29
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = Level.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x00145A44 File Offset: 0x00143C44
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00145A61 File Offset: 0x00143C61
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x00145A74 File Offset: 0x00143C74
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x00145A95 File Offset: 0x00143C95
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Level.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x00145AAC File Offset: 0x00143CAC
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00145AC7 File Offset: 0x00143CC7
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x00145AD4 File Offset: 0x00143CD4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Level);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00145AF4 File Offset: 0x00143CF4
		[DebuggerNonUserCode]
		public bool Equals(Level other)
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

		// Token: 0x06005451 RID: 21585 RVA: 0x00145B68 File Offset: 0x00143D68
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

		// Token: 0x06005452 RID: 21586 RVA: 0x00145BD4 File Offset: 0x00143DD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00145BEC File Offset: 0x00143DEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00145BF8 File Offset: 0x00143DF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00145C68 File Offset: 0x00143E68
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
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

		// Token: 0x06005456 RID: 21590 RVA: 0x00145CD4 File Offset: 0x00143ED4
		[DebuggerNonUserCode]
		public void MergeFrom(Level other)
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

		// Token: 0x06005457 RID: 21591 RVA: 0x00145D36 File Offset: 0x00143F36
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00145D44 File Offset: 0x00143F44
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
					if (num3 != 18U)
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
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002640 RID: 9792
		private static readonly MessageParser<Level> _parser = new MessageParser<Level>(() => new Level());

		// Token: 0x04002641 RID: 9793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002642 RID: 9794
		private int _hasBits0;

		// Token: 0x04002643 RID: 9795
		public const int IdFieldNumber = 1;

		// Token: 0x04002644 RID: 9796
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002645 RID: 9797
		private uint id_;

		// Token: 0x04002646 RID: 9798
		public const int NameFieldNumber = 2;

		// Token: 0x04002647 RID: 9799
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002648 RID: 9800
		private string name_;
	}
}

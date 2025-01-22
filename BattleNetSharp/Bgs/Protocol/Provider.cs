using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000353 RID: 851
	public sealed class Provider : IMessage<Provider>, IMessage, IEquatable<Provider>, IDeepCloneable<Provider>, IBufferMessage
	{
		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06005851 RID: 22609 RVA: 0x00155B58 File Offset: 0x00153D58
		[DebuggerNonUserCode]
		public static MessageParser<Provider> Parser
		{
			get
			{
				return Provider._parser;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x00155B70 File Offset: 0x00153D70
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EmbedTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x00155B94 File Offset: 0x00153D94
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Provider.Descriptor;
			}
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00155BAB File Offset: 0x00153DAB
		[DebuggerNonUserCode]
		public Provider()
		{
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00155BB5 File Offset: 0x00153DB5
		[DebuggerNonUserCode]
		public Provider(Provider other)
			: this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00155BDC File Offset: 0x00153DDC
		[DebuggerNonUserCode]
		public Provider Clone()
		{
			return new Provider(this);
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06005857 RID: 22615 RVA: 0x00155BF4 File Offset: 0x00153DF4
		// (set) Token: 0x06005858 RID: 22616 RVA: 0x00155C15 File Offset: 0x00153E15
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Provider.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06005859 RID: 22617 RVA: 0x00155C2C File Offset: 0x00153E2C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x00155C47 File Offset: 0x00153E47
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x00155C54 File Offset: 0x00153E54
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Provider);
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x00155C74 File Offset: 0x00153E74
		[DebuggerNonUserCode]
		public bool Equals(Provider other)
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
					bool flag4 = this.Name != other.Name;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x00155CCC File Offset: 0x00153ECC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600585E RID: 22622 RVA: 0x00155D18 File Offset: 0x00153F18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x00155D30 File Offset: 0x00153F30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00155D3C File Offset: 0x00153F3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00155D88 File Offset: 0x00153F88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06005862 RID: 22626 RVA: 0x00155DD8 File Offset: 0x00153FD8
		[DebuggerNonUserCode]
		public void MergeFrom(Provider other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x00155E21 File Offset: 0x00154021
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x00155E2C File Offset: 0x0015402C
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400284F RID: 10319
		private static readonly MessageParser<Provider> _parser = new MessageParser<Provider>(() => new Provider());

		// Token: 0x04002850 RID: 10320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002851 RID: 10321
		public const int NameFieldNumber = 1;

		// Token: 0x04002852 RID: 10322
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002853 RID: 10323
		private string name_;
	}
}

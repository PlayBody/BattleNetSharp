using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014C RID: 332
	public sealed class AttributeList : IMessage<AttributeList>, IMessage, IEquatable<AttributeList>, IDeepCloneable<AttributeList>, IBufferMessage
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0008618C File Offset: 0x0008438C
		[DebuggerNonUserCode]
		public static MessageParser<AttributeList> Parser
		{
			get
			{
				return AttributeList._parser;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x000861A4 File Offset: 0x000843A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000861C8 File Offset: 0x000843C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeList.Descriptor;
			}
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000861DF File Offset: 0x000843DF
		[DebuggerNonUserCode]
		public AttributeList()
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x000861F4 File Offset: 0x000843F4
		[DebuggerNonUserCode]
		public AttributeList(AttributeList other)
			: this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00086220 File Offset: 0x00084420
		[DebuggerNonUserCode]
		public AttributeList Clone()
		{
			return new AttributeList(this);
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00086238 File Offset: 0x00084438
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00086250 File Offset: 0x00084450
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeList);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00086270 File Offset: 0x00084470
		[DebuggerNonUserCode]
		public bool Equals(AttributeList other)
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
					bool flag4 = !this.attributes_.Equals(other.attributes_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000862CC File Offset: 0x000844CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0008630C File Offset: 0x0008450C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00086324 File Offset: 0x00084524
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00086330 File Offset: 0x00084530
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, AttributeList._repeated_attributes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0008636C File Offset: 0x0008456C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(AttributeList._repeated_attributes_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000863B4 File Offset: 0x000845B4
		[DebuggerNonUserCode]
		public void MergeFrom(AttributeList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attributes_.Add(other.attributes_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000863F6 File Offset: 0x000845F6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00086404 File Offset: 0x00084604
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
					this.attributes_.AddEntriesFrom(ref input, AttributeList._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x04000F2D RID: 3885
		private static readonly MessageParser<AttributeList> _parser = new MessageParser<AttributeList>(() => new AttributeList());

		// Token: 0x04000F2E RID: 3886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F2F RID: 3887
		public const int AttributesFieldNumber = 1;

		// Token: 0x04000F30 RID: 3888
		private static readonly FieldCodec<Attribute> _repeated_attributes_codec = FieldCodec.ForMessage<Attribute>(10U, Attribute.Parser);

		// Token: 0x04000F31 RID: 3889
		private readonly RepeatedField<Attribute> attributes_ = new RepeatedField<Attribute>();
	}
}

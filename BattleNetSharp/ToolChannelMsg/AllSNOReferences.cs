using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000075 RID: 117
	public sealed class AllSNOReferences : IMessage<AllSNOReferences>, IMessage, IEquatable<AllSNOReferences>, IDeepCloneable<AllSNOReferences>, IBufferMessage
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00028530 File Offset: 0x00026730
		[DebuggerNonUserCode]
		public static MessageParser<AllSNOReferences> Parser
		{
			get
			{
				return AllSNOReferences._parser;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00028548 File Offset: 0x00026748
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[94];
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0002856C File Offset: 0x0002676C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AllSNOReferences.Descriptor;
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00028583 File Offset: 0x00026783
		[DebuggerNonUserCode]
		public AllSNOReferences()
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00028598 File Offset: 0x00026798
		[DebuggerNonUserCode]
		public AllSNOReferences(AllSNOReferences other)
			: this()
		{
			this.references_ = other.references_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000285C4 File Offset: 0x000267C4
		[DebuggerNonUserCode]
		public AllSNOReferences Clone()
		{
			return new AllSNOReferences(this);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000285DC File Offset: 0x000267DC
		[DebuggerNonUserCode]
		public RepeatedField<SNOReference> References
		{
			get
			{
				return this.references_;
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000285F4 File Offset: 0x000267F4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AllSNOReferences);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00028614 File Offset: 0x00026814
		[DebuggerNonUserCode]
		public bool Equals(AllSNOReferences other)
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
					bool flag4 = !this.references_.Equals(other.references_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00028670 File Offset: 0x00026870
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.references_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000286B0 File Offset: 0x000268B0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000286C8 File Offset: 0x000268C8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000286D4 File Offset: 0x000268D4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.references_.WriteTo(ref output, AllSNOReferences._repeated_references_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00028710 File Offset: 0x00026910
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.references_.CalculateSize(AllSNOReferences._repeated_references_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00028758 File Offset: 0x00026958
		[DebuggerNonUserCode]
		public void MergeFrom(AllSNOReferences other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.references_.Add(other.references_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002879A File Offset: 0x0002699A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000287A8 File Offset: 0x000269A8
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
					this.references_.AddEntriesFrom(ref input, AllSNOReferences._repeated_references_codec);
				}
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly MessageParser<AllSNOReferences> _parser = new MessageParser<AllSNOReferences>(() => new AllSNOReferences());

		// Token: 0x04000418 RID: 1048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000419 RID: 1049
		public const int ReferencesFieldNumber = 1;

		// Token: 0x0400041A RID: 1050
		private static readonly FieldCodec<SNOReference> _repeated_references_codec = FieldCodec.ForMessage<SNOReference>(10U, SNOReference.Parser);

		// Token: 0x0400041B RID: 1051
		private readonly RepeatedField<SNOReference> references_ = new RepeatedField<SNOReference>();
	}
}

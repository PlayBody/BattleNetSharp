using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000201 RID: 513
	public sealed class TooltipList : IMessage<TooltipList>, IMessage, IEquatable<TooltipList>, IDeepCloneable<TooltipList>, IBufferMessage
	{
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x000DF2B0 File Offset: 0x000DD4B0
		[DebuggerNonUserCode]
		public static MessageParser<TooltipList> Parser
		{
			get
			{
				return TooltipList._parser;
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x000DF2C8 File Offset: 0x000DD4C8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x000DF2EC File Offset: 0x000DD4EC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TooltipList.Descriptor;
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x000DF303 File Offset: 0x000DD503
		[DebuggerNonUserCode]
		public TooltipList()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x000DF318 File Offset: 0x000DD518
		[DebuggerNonUserCode]
		public TooltipList(TooltipList other)
			: this()
		{
			this.tooltips_ = other.tooltips_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x000DF344 File Offset: 0x000DD544
		[DebuggerNonUserCode]
		public TooltipList Clone()
		{
			return new TooltipList(this);
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x000DF35C File Offset: 0x000DD55C
		[DebuggerNonUserCode]
		public RepeatedField<ToolTip> Tooltips
		{
			get
			{
				return this.tooltips_;
			}
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x000DF374 File Offset: 0x000DD574
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TooltipList);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x000DF394 File Offset: 0x000DD594
		[DebuggerNonUserCode]
		public bool Equals(TooltipList other)
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
					bool flag4 = !this.tooltips_.Equals(other.tooltips_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tooltips_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x000DF430 File Offset: 0x000DD630
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x000DF448 File Offset: 0x000DD648
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x000DF454 File Offset: 0x000DD654
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tooltips_.WriteTo(ref output, TooltipList._repeated_tooltips_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x000DF490 File Offset: 0x000DD690
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tooltips_.CalculateSize(TooltipList._repeated_tooltips_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x000DF4D8 File Offset: 0x000DD6D8
		[DebuggerNonUserCode]
		public void MergeFrom(TooltipList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.tooltips_.Add(other.tooltips_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x000DF51A File Offset: 0x000DD71A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000DF528 File Offset: 0x000DD728
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
					this.tooltips_.AddEntriesFrom(ref input, TooltipList._repeated_tooltips_codec);
				}
			}
		}

		// Token: 0x04001A53 RID: 6739
		private static readonly MessageParser<TooltipList> _parser = new MessageParser<TooltipList>(() => new TooltipList());

		// Token: 0x04001A54 RID: 6740
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A55 RID: 6741
		public const int TooltipsFieldNumber = 1;

		// Token: 0x04001A56 RID: 6742
		private static readonly FieldCodec<ToolTip> _repeated_tooltips_codec = FieldCodec.ForMessage<ToolTip>(10U, ToolTip.Parser);

		// Token: 0x04001A57 RID: 6743
		private readonly RepeatedField<ToolTip> tooltips_ = new RepeatedField<ToolTip>();
	}
}

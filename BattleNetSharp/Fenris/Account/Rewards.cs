using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D7 RID: 727
	public sealed class Rewards : IMessage<Rewards>, IMessage, IEquatable<Rewards>, IDeepCloneable<Rewards>, IBufferMessage
	{
		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x00126060 File Offset: 0x00124260
		[DebuggerNonUserCode]
		public static MessageParser<Rewards> Parser
		{
			get
			{
				return Rewards._parser;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x00126078 File Offset: 0x00124278
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x0012609C File Offset: 0x0012429C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Rewards.Descriptor;
			}
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x001260B3 File Offset: 0x001242B3
		[DebuggerNonUserCode]
		public Rewards()
		{
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x001260C8 File Offset: 0x001242C8
		[DebuggerNonUserCode]
		public Rewards(Rewards other)
			: this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x001260F4 File Offset: 0x001242F4
		[DebuggerNonUserCode]
		public Rewards Clone()
		{
			return new Rewards(this);
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x0012610C File Offset: 0x0012430C
		[DebuggerNonUserCode]
		public RepeatedField<int> Rewards_
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00126124 File Offset: 0x00124324
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Rewards);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00126144 File Offset: 0x00124344
		[DebuggerNonUserCode]
		public bool Equals(Rewards other)
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
					bool flag4 = !this.rewards_.Equals(other.rewards_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x001261A0 File Offset: 0x001243A0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewards_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x001261E0 File Offset: 0x001243E0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x001261F8 File Offset: 0x001243F8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00126204 File Offset: 0x00124404
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, Rewards._repeated_rewards_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00126240 File Offset: 0x00124440
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(Rewards._repeated_rewards_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00126288 File Offset: 0x00124488
		[DebuggerNonUserCode]
		public void MergeFrom(Rewards other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.rewards_.Add(other.rewards_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x001262CA File Offset: 0x001244CA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001262D8 File Offset: 0x001244D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U && num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewards_.AddEntriesFrom(ref input, Rewards._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x04002249 RID: 8777
		private static readonly MessageParser<Rewards> _parser = new MessageParser<Rewards>(() => new Rewards());

		// Token: 0x0400224A RID: 8778
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400224B RID: 8779
		public const int Rewards_FieldNumber = 1;

		// Token: 0x0400224C RID: 8780
		private static readonly FieldCodec<int> _repeated_rewards_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x0400224D RID: 8781
		private readonly RepeatedField<int> rewards_ = new RepeatedField<int>();
	}
}

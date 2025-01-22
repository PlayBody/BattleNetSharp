using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E5 RID: 229
	public sealed class AnimTreeForActorData : IMessage<AnimTreeForActorData>, IMessage, IEquatable<AnimTreeForActorData>, IDeepCloneable<AnimTreeForActorData>, IBufferMessage
	{
		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00050BD0 File Offset: 0x0004EDD0
		[DebuggerNonUserCode]
		public static MessageParser<AnimTreeForActorData> Parser
		{
			get
			{
				return AnimTreeForActorData._parser;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00050BE8 File Offset: 0x0004EDE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[206];
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00050C10 File Offset: 0x0004EE10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimTreeForActorData.Descriptor;
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00050C27 File Offset: 0x0004EE27
		[DebuggerNonUserCode]
		public AnimTreeForActorData()
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00050C3C File Offset: 0x0004EE3C
		[DebuggerNonUserCode]
		public AnimTreeForActorData(AnimTreeForActorData other)
			: this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00050C68 File Offset: 0x0004EE68
		[DebuggerNonUserCode]
		public AnimTreeForActorData Clone()
		{
			return new AnimTreeForActorData(this);
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00050C80 File Offset: 0x0004EE80
		[DebuggerNonUserCode]
		public RepeatedField<AnimChannelData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00050C98 File Offset: 0x0004EE98
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimTreeForActorData);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00050CB8 File Offset: 0x0004EEB8
		[DebuggerNonUserCode]
		public bool Equals(AnimTreeForActorData other)
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
					bool flag4 = !this.data_.Equals(other.data_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00050D14 File Offset: 0x0004EF14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00050D54 File Offset: 0x0004EF54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00050D6C File Offset: 0x0004EF6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00050D78 File Offset: 0x0004EF78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, AnimTreeForActorData._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(AnimTreeForActorData._repeated_data_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00050DFC File Offset: 0x0004EFFC
		[DebuggerNonUserCode]
		public void MergeFrom(AnimTreeForActorData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.data_.Add(other.data_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00050E3E File Offset: 0x0004F03E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00050E4C File Offset: 0x0004F04C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, AnimTreeForActorData._repeated_data_codec);
				}
			}
		}

		// Token: 0x0400090A RID: 2314
		private static readonly MessageParser<AnimTreeForActorData> _parser = new MessageParser<AnimTreeForActorData>(() => new AnimTreeForActorData());

		// Token: 0x0400090B RID: 2315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400090C RID: 2316
		public const int DataFieldNumber = 2;

		// Token: 0x0400090D RID: 2317
		private static readonly FieldCodec<AnimChannelData> _repeated_data_codec = FieldCodec.ForMessage<AnimChannelData>(18U, AnimChannelData.Parser);

		// Token: 0x0400090E RID: 2318
		private readonly RepeatedField<AnimChannelData> data_ = new RepeatedField<AnimChannelData>();
	}
}

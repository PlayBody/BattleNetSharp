using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200046D RID: 1133
	public sealed class ClubMembershipSubscribeOptions : IMessage<ClubMembershipSubscribeOptions>, IMessage, IEquatable<ClubMembershipSubscribeOptions>, IDeepCloneable<ClubMembershipSubscribeOptions>, IBufferMessage
	{
		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x001AF760 File Offset: 0x001AD960
		[DebuggerNonUserCode]
		public static MessageParser<ClubMembershipSubscribeOptions> Parser
		{
			get
			{
				return ClubMembershipSubscribeOptions._parser;
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x001AF778 File Offset: 0x001AD978
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x001AF79C File Offset: 0x001AD99C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubMembershipSubscribeOptions.Descriptor;
			}
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x001AF7B3 File Offset: 0x001AD9B3
		[DebuggerNonUserCode]
		public ClubMembershipSubscribeOptions()
		{
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x001AF7C8 File Offset: 0x001AD9C8
		[DebuggerNonUserCode]
		public ClubMembershipSubscribeOptions(ClubMembershipSubscribeOptions other)
			: this()
		{
			this.filter_ = other.filter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x001AF7F4 File Offset: 0x001AD9F4
		[DebuggerNonUserCode]
		public ClubMembershipSubscribeOptions Clone()
		{
			return new ClubMembershipSubscribeOptions(this);
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x001AF80C File Offset: 0x001ADA0C
		[DebuggerNonUserCode]
		public RepeatedField<ClubMembershipFilter> Filter
		{
			get
			{
				return this.filter_;
			}
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x001AF824 File Offset: 0x001ADA24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubMembershipSubscribeOptions);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x001AF844 File Offset: 0x001ADA44
		[DebuggerNonUserCode]
		public bool Equals(ClubMembershipSubscribeOptions other)
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
					bool flag4 = !this.filter_.Equals(other.filter_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x001AF8A0 File Offset: 0x001ADAA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.filter_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x001AF8E0 File Offset: 0x001ADAE0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x001AF8F8 File Offset: 0x001ADAF8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x001AF904 File Offset: 0x001ADB04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.filter_.WriteTo(ref output, ClubMembershipSubscribeOptions._repeated_filter_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x001AF940 File Offset: 0x001ADB40
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.filter_.CalculateSize(ClubMembershipSubscribeOptions._repeated_filter_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x001AF988 File Offset: 0x001ADB88
		[DebuggerNonUserCode]
		public void MergeFrom(ClubMembershipSubscribeOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.filter_.Add(other.filter_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x001AF9CA File Offset: 0x001ADBCA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x001AF9D8 File Offset: 0x001ADBD8
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
					this.filter_.AddEntriesFrom(ref input, ClubMembershipSubscribeOptions._repeated_filter_codec);
				}
			}
		}

		// Token: 0x040032F1 RID: 13041
		private static readonly MessageParser<ClubMembershipSubscribeOptions> _parser = new MessageParser<ClubMembershipSubscribeOptions>(() => new ClubMembershipSubscribeOptions());

		// Token: 0x040032F2 RID: 13042
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032F3 RID: 13043
		public const int FilterFieldNumber = 1;

		// Token: 0x040032F4 RID: 13044
		private static readonly FieldCodec<ClubMembershipFilter> _repeated_filter_codec = FieldCodec.ForMessage<ClubMembershipFilter>(10U, ClubMembershipFilter.Parser);

		// Token: 0x040032F5 RID: 13045
		private readonly RepeatedField<ClubMembershipFilter> filter_ = new RepeatedField<ClubMembershipFilter>();
	}
}

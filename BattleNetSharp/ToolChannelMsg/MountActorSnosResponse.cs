using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FA RID: 250
	public sealed class MountActorSnosResponse : IMessage<MountActorSnosResponse>, IMessage, IEquatable<MountActorSnosResponse>, IDeepCloneable<MountActorSnosResponse>, IBufferMessage
	{
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00056248 File Offset: 0x00054448
		[DebuggerNonUserCode]
		public static MessageParser<MountActorSnosResponse> Parser
		{
			get
			{
				return MountActorSnosResponse._parser;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00056260 File Offset: 0x00054460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[227];
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00056288 File Offset: 0x00054488
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MountActorSnosResponse.Descriptor;
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0005629F File Offset: 0x0005449F
		[DebuggerNonUserCode]
		public MountActorSnosResponse()
		{
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000562B4 File Offset: 0x000544B4
		[DebuggerNonUserCode]
		public MountActorSnosResponse(MountActorSnosResponse other)
			: this()
		{
			this.mountActorSnoHandles_ = other.mountActorSnoHandles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000562E0 File Offset: 0x000544E0
		[DebuggerNonUserCode]
		public MountActorSnosResponse Clone()
		{
			return new MountActorSnosResponse(this);
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x000562F8 File Offset: 0x000544F8
		[DebuggerNonUserCode]
		public RepeatedField<int> MountActorSnoHandles
		{
			get
			{
				return this.mountActorSnoHandles_;
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00056310 File Offset: 0x00054510
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MountActorSnosResponse);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00056330 File Offset: 0x00054530
		[DebuggerNonUserCode]
		public bool Equals(MountActorSnosResponse other)
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
					bool flag4 = !this.mountActorSnoHandles_.Equals(other.mountActorSnoHandles_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0005638C File Offset: 0x0005458C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mountActorSnoHandles_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000563CC File Offset: 0x000545CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000563E4 File Offset: 0x000545E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000563F0 File Offset: 0x000545F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mountActorSnoHandles_.WriteTo(ref output, MountActorSnosResponse._repeated_mountActorSnoHandles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0005642C File Offset: 0x0005462C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mountActorSnoHandles_.CalculateSize(MountActorSnosResponse._repeated_mountActorSnoHandles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00056474 File Offset: 0x00054674
		[DebuggerNonUserCode]
		public void MergeFrom(MountActorSnosResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.mountActorSnoHandles_.Add(other.mountActorSnoHandles_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000564B6 File Offset: 0x000546B6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000564C4 File Offset: 0x000546C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mountActorSnoHandles_.AddEntriesFrom(ref input, MountActorSnosResponse._repeated_mountActorSnoHandles_codec);
				}
			}
		}

		// Token: 0x040009A4 RID: 2468
		private static readonly MessageParser<MountActorSnosResponse> _parser = new MessageParser<MountActorSnosResponse>(() => new MountActorSnosResponse());

		// Token: 0x040009A5 RID: 2469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009A6 RID: 2470
		public const int MountActorSnoHandlesFieldNumber = 1;

		// Token: 0x040009A7 RID: 2471
		private static readonly FieldCodec<int> _repeated_mountActorSnoHandles_codec = FieldCodec.ForInt32(8U);

		// Token: 0x040009A8 RID: 2472
		private readonly RepeatedField<int> mountActorSnoHandles_ = new RepeatedField<int>();
	}
}

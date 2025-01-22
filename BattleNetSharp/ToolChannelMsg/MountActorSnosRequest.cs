using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000F9 RID: 249
	public sealed class MountActorSnosRequest : IMessage<MountActorSnosRequest>, IMessage, IEquatable<MountActorSnosRequest>, IDeepCloneable<MountActorSnosRequest>, IBufferMessage
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00056008 File Offset: 0x00054208
		[DebuggerNonUserCode]
		public static MessageParser<MountActorSnosRequest> Parser
		{
			get
			{
				return MountActorSnosRequest._parser;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00056020 File Offset: 0x00054220
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[226];
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00056048 File Offset: 0x00054248
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MountActorSnosRequest.Descriptor;
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0005605F File Offset: 0x0005425F
		[DebuggerNonUserCode]
		public MountActorSnosRequest()
		{
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00056069 File Offset: 0x00054269
		[DebuggerNonUserCode]
		public MountActorSnosRequest(MountActorSnosRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00056084 File Offset: 0x00054284
		[DebuggerNonUserCode]
		public MountActorSnosRequest Clone()
		{
			return new MountActorSnosRequest(this);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0005609C File Offset: 0x0005429C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MountActorSnosRequest);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000560BC File Offset: 0x000542BC
		[DebuggerNonUserCode]
		public bool Equals(MountActorSnosRequest other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000560FC File Offset: 0x000542FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x00056130 File Offset: 0x00054330
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00056148 File Offset: 0x00054348
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00056154 File Offset: 0x00054354
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00056180 File Offset: 0x00054380
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000561B4 File Offset: 0x000543B4
		[DebuggerNonUserCode]
		public void MergeFrom(MountActorSnosRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000561E4 File Offset: 0x000543E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000561F0 File Offset: 0x000543F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040009A2 RID: 2466
		private static readonly MessageParser<MountActorSnosRequest> _parser = new MessageParser<MountActorSnosRequest>(() => new MountActorSnosRequest());

		// Token: 0x040009A3 RID: 2467
		private UnknownFieldSet _unknownFields;
	}
}

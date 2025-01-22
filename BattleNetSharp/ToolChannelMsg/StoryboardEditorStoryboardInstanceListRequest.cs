using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000B3 RID: 179
	public sealed class StoryboardEditorStoryboardInstanceListRequest : IMessage<StoryboardEditorStoryboardInstanceListRequest>, IMessage, IEquatable<StoryboardEditorStoryboardInstanceListRequest>, IDeepCloneable<StoryboardEditorStoryboardInstanceListRequest>, IBufferMessage
	{
		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0003D79C File Offset: 0x0003B99C
		[DebuggerNonUserCode]
		public static MessageParser<StoryboardEditorStoryboardInstanceListRequest> Parser
		{
			get
			{
				return StoryboardEditorStoryboardInstanceListRequest._parser;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[156];
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryboardEditorStoryboardInstanceListRequest.Descriptor;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0003D7F3 File Offset: 0x0003B9F3
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceListRequest()
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0003D7FD File Offset: 0x0003B9FD
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceListRequest(StoryboardEditorStoryboardInstanceListRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0003D818 File Offset: 0x0003BA18
		[DebuggerNonUserCode]
		public StoryboardEditorStoryboardInstanceListRequest Clone()
		{
			return new StoryboardEditorStoryboardInstanceListRequest(this);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0003D830 File Offset: 0x0003BA30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryboardEditorStoryboardInstanceListRequest);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0003D850 File Offset: 0x0003BA50
		[DebuggerNonUserCode]
		public bool Equals(StoryboardEditorStoryboardInstanceListRequest other)
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

		// Token: 0x060010BA RID: 4282 RVA: 0x0003D890 File Offset: 0x0003BA90
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

		// Token: 0x060010BB RID: 4283 RVA: 0x0003D8C4 File Offset: 0x0003BAC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0003D8DC File Offset: 0x0003BADC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0003D8E8 File Offset: 0x0003BAE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0003D914 File Offset: 0x0003BB14
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

		// Token: 0x060010BF RID: 4287 RVA: 0x0003D948 File Offset: 0x0003BB48
		[DebuggerNonUserCode]
		public void MergeFrom(StoryboardEditorStoryboardInstanceListRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0003D978 File Offset: 0x0003BB78
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0003D984 File Offset: 0x0003BB84
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040006B0 RID: 1712
		private static readonly MessageParser<StoryboardEditorStoryboardInstanceListRequest> _parser = new MessageParser<StoryboardEditorStoryboardInstanceListRequest>(() => new StoryboardEditorStoryboardInstanceListRequest());

		// Token: 0x040006B1 RID: 1713
		private UnknownFieldSet _unknownFields;
	}
}

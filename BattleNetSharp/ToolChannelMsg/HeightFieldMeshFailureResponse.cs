using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000EF RID: 239
	public sealed class HeightFieldMeshFailureResponse : IMessage<HeightFieldMeshFailureResponse>, IMessage, IEquatable<HeightFieldMeshFailureResponse>, IDeepCloneable<HeightFieldMeshFailureResponse>, IBufferMessage
	{
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00053C7C File Offset: 0x00051E7C
		[DebuggerNonUserCode]
		public static MessageParser<HeightFieldMeshFailureResponse> Parser
		{
			get
			{
				return HeightFieldMeshFailureResponse._parser;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00053C94 File Offset: 0x00051E94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[216];
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00053CBC File Offset: 0x00051EBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeightFieldMeshFailureResponse.Descriptor;
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00053CD3 File Offset: 0x00051ED3
		[DebuggerNonUserCode]
		public HeightFieldMeshFailureResponse()
		{
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00053CDD File Offset: 0x00051EDD
		[DebuggerNonUserCode]
		public HeightFieldMeshFailureResponse(HeightFieldMeshFailureResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00053CF8 File Offset: 0x00051EF8
		[DebuggerNonUserCode]
		public HeightFieldMeshFailureResponse Clone()
		{
			return new HeightFieldMeshFailureResponse(this);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00053D10 File Offset: 0x00051F10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeightFieldMeshFailureResponse);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00053D30 File Offset: 0x00051F30
		[DebuggerNonUserCode]
		public bool Equals(HeightFieldMeshFailureResponse other)
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

		// Token: 0x0600172D RID: 5933 RVA: 0x00053D70 File Offset: 0x00051F70
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

		// Token: 0x0600172E RID: 5934 RVA: 0x00053DA4 File Offset: 0x00051FA4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00053DBC File Offset: 0x00051FBC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00053DC8 File Offset: 0x00051FC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00053DF4 File Offset: 0x00051FF4
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

		// Token: 0x06001732 RID: 5938 RVA: 0x00053E28 File Offset: 0x00052028
		[DebuggerNonUserCode]
		public void MergeFrom(HeightFieldMeshFailureResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00053E58 File Offset: 0x00052058
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00053E64 File Offset: 0x00052064
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000967 RID: 2407
		private static readonly MessageParser<HeightFieldMeshFailureResponse> _parser = new MessageParser<HeightFieldMeshFailureResponse>(() => new HeightFieldMeshFailureResponse());

		// Token: 0x04000968 RID: 2408
		private UnknownFieldSet _unknownFields;
	}
}

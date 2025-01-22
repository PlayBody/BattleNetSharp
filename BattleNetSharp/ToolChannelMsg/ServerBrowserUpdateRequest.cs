using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000A5 RID: 165
	public sealed class ServerBrowserUpdateRequest : IMessage<ServerBrowserUpdateRequest>, IMessage, IEquatable<ServerBrowserUpdateRequest>, IDeepCloneable<ServerBrowserUpdateRequest>, IBufferMessage
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00037E00 File Offset: 0x00036000
		[DebuggerNonUserCode]
		public static MessageParser<ServerBrowserUpdateRequest> Parser
		{
			get
			{
				return ServerBrowserUpdateRequest._parser;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00037E18 File Offset: 0x00036018
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[142];
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00037E40 File Offset: 0x00036040
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerBrowserUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00037E57 File Offset: 0x00036057
		[DebuggerNonUserCode]
		public ServerBrowserUpdateRequest()
		{
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00037E61 File Offset: 0x00036061
		[DebuggerNonUserCode]
		public ServerBrowserUpdateRequest(ServerBrowserUpdateRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00037E7C File Offset: 0x0003607C
		[DebuggerNonUserCode]
		public ServerBrowserUpdateRequest Clone()
		{
			return new ServerBrowserUpdateRequest(this);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00037E94 File Offset: 0x00036094
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerBrowserUpdateRequest);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00037EB4 File Offset: 0x000360B4
		[DebuggerNonUserCode]
		public bool Equals(ServerBrowserUpdateRequest other)
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

		// Token: 0x06000F18 RID: 3864 RVA: 0x00037EF4 File Offset: 0x000360F4
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

		// Token: 0x06000F19 RID: 3865 RVA: 0x00037F28 File Offset: 0x00036128
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00037F40 File Offset: 0x00036140
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00037F4C File Offset: 0x0003614C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00037F78 File Offset: 0x00036178
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

		// Token: 0x06000F1D RID: 3869 RVA: 0x00037FAC File Offset: 0x000361AC
		[DebuggerNonUserCode]
		public void MergeFrom(ServerBrowserUpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00037FDC File Offset: 0x000361DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00037FE8 File Offset: 0x000361E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040005FA RID: 1530
		private static readonly MessageParser<ServerBrowserUpdateRequest> _parser = new MessageParser<ServerBrowserUpdateRequest>(() => new ServerBrowserUpdateRequest());

		// Token: 0x040005FB RID: 1531
		private UnknownFieldSet _unknownFields;
	}
}

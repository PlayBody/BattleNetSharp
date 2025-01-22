using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000636 RID: 1590
	public sealed class GetStateRequest : IMessage<GetStateRequest>, IMessage, IEquatable<GetStateRequest>, IDeepCloneable<GetStateRequest>, IBufferMessage
	{
		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600942D RID: 37933 RVA: 0x0023DE60 File Offset: 0x0023C060
		[DebuggerNonUserCode]
		public static MessageParser<GetStateRequest> Parser
		{
			get
			{
				return GetStateRequest._parser;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x0023DE78 File Offset: 0x0023C078
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600942F RID: 37935 RVA: 0x0023DE9C File Offset: 0x0023C09C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateRequest.Descriptor;
			}
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x0023DEB3 File Offset: 0x0023C0B3
		[DebuggerNonUserCode]
		public GetStateRequest()
		{
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x0023DEBD File Offset: 0x0023C0BD
		[DebuggerNonUserCode]
		public GetStateRequest(GetStateRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x0023DED8 File Offset: 0x0023C0D8
		[DebuggerNonUserCode]
		public GetStateRequest Clone()
		{
			return new GetStateRequest(this);
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x0023DEF0 File Offset: 0x0023C0F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateRequest);
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x0023DF10 File Offset: 0x0023C110
		[DebuggerNonUserCode]
		public bool Equals(GetStateRequest other)
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

		// Token: 0x06009435 RID: 37941 RVA: 0x0023DF50 File Offset: 0x0023C150
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

		// Token: 0x06009436 RID: 37942 RVA: 0x0023DF84 File Offset: 0x0023C184
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x0023DF9C File Offset: 0x0023C19C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x0023DFA8 File Offset: 0x0023C1A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x0023DFD4 File Offset: 0x0023C1D4
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

		// Token: 0x0600943A RID: 37946 RVA: 0x0023E008 File Offset: 0x0023C208
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x0023E038 File Offset: 0x0023C238
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x0023E044 File Offset: 0x0023C244
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042CE RID: 17102
		private static readonly MessageParser<GetStateRequest> _parser = new MessageParser<GetStateRequest>(() => new GetStateRequest());

		// Token: 0x040042CF RID: 17103
		private UnknownFieldSet _unknownFields;
	}
}

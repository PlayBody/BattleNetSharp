using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000633 RID: 1587
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x060093F8 RID: 37880 RVA: 0x0023D680 File Offset: 0x0023B880
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x060093F9 RID: 37881 RVA: 0x0023D698 File Offset: 0x0023B898
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x0023D6BC File Offset: 0x0023B8BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x0023D6D3 File Offset: 0x0023B8D3
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x0023D6DD File Offset: 0x0023B8DD
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x0023D6F8 File Offset: 0x0023B8F8
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x0023D710 File Offset: 0x0023B910
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x0023D730 File Offset: 0x0023B930
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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

		// Token: 0x06009400 RID: 37888 RVA: 0x0023D770 File Offset: 0x0023B970
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

		// Token: 0x06009401 RID: 37889 RVA: 0x0023D7A4 File Offset: 0x0023B9A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x0023D7BC File Offset: 0x0023B9BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x0023D7C8 File Offset: 0x0023B9C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x0023D7F4 File Offset: 0x0023B9F4
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

		// Token: 0x06009405 RID: 37893 RVA: 0x0023D828 File Offset: 0x0023BA28
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x0023D858 File Offset: 0x0023BA58
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x0023D864 File Offset: 0x0023BA64
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042C6 RID: 17094
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x040042C7 RID: 17095
		private UnknownFieldSet _unknownFields;
	}
}

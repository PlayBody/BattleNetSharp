using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025B RID: 603
	public sealed class PartyVoteRejected : IMessage<PartyVoteRejected>, IMessage, IEquatable<PartyVoteRejected>, IDeepCloneable<PartyVoteRejected>, IBufferMessage
	{
		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x000FD9AC File Offset: 0x000FBBAC
		[DebuggerNonUserCode]
		public static MessageParser<PartyVoteRejected> Parser
		{
			get
			{
				return PartyVoteRejected._parser;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x000FD9C4 File Offset: 0x000FBBC4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[75];
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x000FD9E8 File Offset: 0x000FBBE8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyVoteRejected.Descriptor;
			}
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x000FD9FF File Offset: 0x000FBBFF
		[DebuggerNonUserCode]
		public PartyVoteRejected()
		{
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x000FDA09 File Offset: 0x000FBC09
		[DebuggerNonUserCode]
		public PartyVoteRejected(PartyVoteRejected other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x000FDA24 File Offset: 0x000FBC24
		[DebuggerNonUserCode]
		public PartyVoteRejected Clone()
		{
			return new PartyVoteRejected(this);
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x000FDA3C File Offset: 0x000FBC3C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyVoteRejected);
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x000FDA5C File Offset: 0x000FBC5C
		[DebuggerNonUserCode]
		public bool Equals(PartyVoteRejected other)
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

		// Token: 0x060040F1 RID: 16625 RVA: 0x000FDA9C File Offset: 0x000FBC9C
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

		// Token: 0x060040F2 RID: 16626 RVA: 0x000FDAD0 File Offset: 0x000FBCD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x000FDAE8 File Offset: 0x000FBCE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x000FDAF4 File Offset: 0x000FBCF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x000FDB20 File Offset: 0x000FBD20
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

		// Token: 0x060040F6 RID: 16630 RVA: 0x000FDB54 File Offset: 0x000FBD54
		[DebuggerNonUserCode]
		public void MergeFrom(PartyVoteRejected other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x000FDB84 File Offset: 0x000FBD84
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x000FDB90 File Offset: 0x000FBD90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D87 RID: 7559
		private static readonly MessageParser<PartyVoteRejected> _parser = new MessageParser<PartyVoteRejected>(() => new PartyVoteRejected());

		// Token: 0x04001D88 RID: 7560
		private UnknownFieldSet _unknownFields;
	}
}

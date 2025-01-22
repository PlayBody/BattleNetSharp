using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C6 RID: 1478
	public sealed class QueryResponse : IMessage<QueryResponse>, IMessage, IEquatable<QueryResponse>, IDeepCloneable<QueryResponse>, IBufferMessage
	{
		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x0021F500 File Offset: 0x0021D700
		[DebuggerNonUserCode]
		public static MessageParser<QueryResponse> Parser
		{
			get
			{
				return QueryResponse._parser;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x0021F518 File Offset: 0x0021D718
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x0021F53C File Offset: 0x0021D73C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryResponse.Descriptor;
			}
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x0021F553 File Offset: 0x0021D753
		[DebuggerNonUserCode]
		public QueryResponse()
		{
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x0021F568 File Offset: 0x0021D768
		[DebuggerNonUserCode]
		public QueryResponse(QueryResponse other)
			: this()
		{
			this.states_ = other.states_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x0021F594 File Offset: 0x0021D794
		[DebuggerNonUserCode]
		public QueryResponse Clone()
		{
			return new QueryResponse(this);
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x0021F5AC File Offset: 0x0021D7AC
		[DebuggerNonUserCode]
		public RepeatedField<PresenceFieldState> States
		{
			get
			{
				return this.states_;
			}
		}

		// Token: 0x06008BFE RID: 35838 RVA: 0x0021F5C4 File Offset: 0x0021D7C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryResponse);
		}

		// Token: 0x06008BFF RID: 35839 RVA: 0x0021F5E4 File Offset: 0x0021D7E4
		[DebuggerNonUserCode]
		public bool Equals(QueryResponse other)
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
					bool flag4 = !this.states_.Equals(other.states_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x0021F640 File Offset: 0x0021D840
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.states_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x0021F680 File Offset: 0x0021D880
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x0021F698 File Offset: 0x0021D898
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x0021F6A4 File Offset: 0x0021D8A4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.states_.WriteTo(ref output, QueryResponse._repeated_states_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x0021F6E0 File Offset: 0x0021D8E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.states_.CalculateSize(QueryResponse._repeated_states_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x0021F728 File Offset: 0x0021D928
		[DebuggerNonUserCode]
		public void MergeFrom(QueryResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.states_.Add(other.states_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x0021F76A File Offset: 0x0021D96A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x0021F778 File Offset: 0x0021D978
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
					this.states_.AddEntriesFrom(ref input, QueryResponse._repeated_states_codec);
				}
			}
		}

		// Token: 0x04003F51 RID: 16209
		private static readonly MessageParser<QueryResponse> _parser = new MessageParser<QueryResponse>(() => new QueryResponse());

		// Token: 0x04003F52 RID: 16210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F53 RID: 16211
		public const int StatesFieldNumber = 1;

		// Token: 0x04003F54 RID: 16212
		private static readonly FieldCodec<PresenceFieldState> _repeated_states_codec = FieldCodec.ForMessage<PresenceFieldState>(10U, PresenceFieldState.Parser);

		// Token: 0x04003F55 RID: 16213
		private readonly RepeatedField<PresenceFieldState> states_ = new RepeatedField<PresenceFieldState>();
	}
}

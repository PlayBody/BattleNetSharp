using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A4 RID: 1444
	public sealed class QueryResponse : IMessage<QueryResponse>, IMessage, IEquatable<QueryResponse>, IDeepCloneable<QueryResponse>, IBufferMessage
	{
		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x00216238 File Offset: 0x00214438
		[DebuggerNonUserCode]
		public static MessageParser<QueryResponse> Parser
		{
			get
			{
				return QueryResponse._parser;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008975 RID: 35189 RVA: 0x00216250 File Offset: 0x00214450
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06008976 RID: 35190 RVA: 0x00216274 File Offset: 0x00214474
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QueryResponse.Descriptor;
			}
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x0021628B File Offset: 0x0021448B
		[DebuggerNonUserCode]
		public QueryResponse()
		{
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x002162A0 File Offset: 0x002144A0
		[DebuggerNonUserCode]
		public QueryResponse(QueryResponse other)
			: this()
		{
			this.field_ = other.field_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x002162CC File Offset: 0x002144CC
		[DebuggerNonUserCode]
		public QueryResponse Clone()
		{
			return new QueryResponse(this);
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600897A RID: 35194 RVA: 0x002162E4 File Offset: 0x002144E4
		[DebuggerNonUserCode]
		public RepeatedField<Field> Field
		{
			get
			{
				return this.field_;
			}
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x002162FC File Offset: 0x002144FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QueryResponse);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0021631C File Offset: 0x0021451C
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
					bool flag4 = !this.field_.Equals(other.field_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x00216378 File Offset: 0x00214578
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.field_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x002163B8 File Offset: 0x002145B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x002163D0 File Offset: 0x002145D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x002163DC File Offset: 0x002145DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.field_.WriteTo(ref output, QueryResponse._repeated_field_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00216418 File Offset: 0x00214618
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.field_.CalculateSize(QueryResponse._repeated_field_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00216460 File Offset: 0x00214660
		[DebuggerNonUserCode]
		public void MergeFrom(QueryResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.field_.Add(other.field_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x002164A2 File Offset: 0x002146A2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x002164B0 File Offset: 0x002146B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.field_.AddEntriesFrom(ref input, QueryResponse._repeated_field_codec);
				}
			}
		}

		// Token: 0x04003E34 RID: 15924
		private static readonly MessageParser<QueryResponse> _parser = new MessageParser<QueryResponse>(() => new QueryResponse());

		// Token: 0x04003E35 RID: 15925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E36 RID: 15926
		public const int FieldFieldNumber = 2;

		// Token: 0x04003E37 RID: 15927
		private static readonly FieldCodec<Field> _repeated_field_codec = FieldCodec.ForMessage<Field>(18U, Bgs.Protocol.Presence.V1.Field.Parser);

		// Token: 0x04003E38 RID: 15928
		private readonly RepeatedField<Field> field_ = new RepeatedField<Field>();
	}
}

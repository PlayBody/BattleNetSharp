using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004BE RID: 1214
	public sealed class GetSuggestionResponse : IMessage<GetSuggestionResponse>, IMessage, IEquatable<GetSuggestionResponse>, IDeepCloneable<GetSuggestionResponse>, IBufferMessage
	{
		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600761B RID: 30235 RVA: 0x001CC934 File Offset: 0x001CAB34
		[DebuggerNonUserCode]
		public static MessageParser<GetSuggestionResponse> Parser
		{
			get
			{
				return GetSuggestionResponse._parser;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x0600761C RID: 30236 RVA: 0x001CC94C File Offset: 0x001CAB4C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[35];
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600761D RID: 30237 RVA: 0x001CC970 File Offset: 0x001CAB70
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSuggestionResponse.Descriptor;
			}
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x001CC987 File Offset: 0x001CAB87
		[DebuggerNonUserCode]
		public GetSuggestionResponse()
		{
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x001CC991 File Offset: 0x001CAB91
		[DebuggerNonUserCode]
		public GetSuggestionResponse(GetSuggestionResponse other)
			: this()
		{
			this.suggestion_ = ((other.suggestion_ != null) ? other.suggestion_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x001CC9C8 File Offset: 0x001CABC8
		[DebuggerNonUserCode]
		public GetSuggestionResponse Clone()
		{
			return new GetSuggestionResponse(this);
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06007621 RID: 30241 RVA: 0x001CC9E0 File Offset: 0x001CABE0
		// (set) Token: 0x06007622 RID: 30242 RVA: 0x001CC9F8 File Offset: 0x001CABF8
		[DebuggerNonUserCode]
		public ClubSuggestion Suggestion
		{
			get
			{
				return this.suggestion_;
			}
			set
			{
				this.suggestion_ = value;
			}
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x001CCA04 File Offset: 0x001CAC04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSuggestionResponse);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x001CCA24 File Offset: 0x001CAC24
		[DebuggerNonUserCode]
		public bool Equals(GetSuggestionResponse other)
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
					bool flag4 = !object.Equals(this.Suggestion, other.Suggestion);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x001CCA80 File Offset: 0x001CAC80
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				num ^= this.Suggestion.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x001CCAD0 File Offset: 0x001CACD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x001CCAE8 File Offset: 0x001CACE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x001CCAF4 File Offset: 0x001CACF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Suggestion);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x001CCB44 File Offset: 0x001CAD44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.suggestion_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Suggestion);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x001CCB98 File Offset: 0x001CAD98
		[DebuggerNonUserCode]
		public void MergeFrom(GetSuggestionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.suggestion_ != null;
				if (flag2)
				{
					bool flag3 = this.suggestion_ == null;
					if (flag3)
					{
						this.Suggestion = new ClubSuggestion();
					}
					this.Suggestion.MergeFrom(other.Suggestion);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x001CCC04 File Offset: 0x001CAE04
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x001CCC10 File Offset: 0x001CAE10
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
					bool flag = this.suggestion_ == null;
					if (flag)
					{
						this.Suggestion = new ClubSuggestion();
					}
					input.ReadMessage(this.Suggestion);
				}
			}
		}

		// Token: 0x040035CF RID: 13775
		private static readonly MessageParser<GetSuggestionResponse> _parser = new MessageParser<GetSuggestionResponse>(() => new GetSuggestionResponse());

		// Token: 0x040035D0 RID: 13776
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035D1 RID: 13777
		public const int SuggestionFieldNumber = 1;

		// Token: 0x040035D2 RID: 13778
		private ClubSuggestion suggestion_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E6 RID: 1510
	public sealed class GetPlayerVariablesResponse : IMessage<GetPlayerVariablesResponse>, IMessage, IEquatable<GetPlayerVariablesResponse>, IDeepCloneable<GetPlayerVariablesResponse>, IBufferMessage
	{
		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06008E02 RID: 36354 RVA: 0x00227948 File Offset: 0x00225B48
		[DebuggerNonUserCode]
		public static MessageParser<GetPlayerVariablesResponse> Parser
		{
			get
			{
				return GetPlayerVariablesResponse._parser;
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06008E03 RID: 36355 RVA: 0x00227960 File Offset: 0x00225B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06008E04 RID: 36356 RVA: 0x00227984 File Offset: 0x00225B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerVariablesResponse.Descriptor;
			}
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x0022799B File Offset: 0x00225B9B
		[DebuggerNonUserCode]
		public GetPlayerVariablesResponse()
		{
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x002279B0 File Offset: 0x00225BB0
		[DebuggerNonUserCode]
		public GetPlayerVariablesResponse(GetPlayerVariablesResponse other)
			: this()
		{
			this.playerVariables_ = other.playerVariables_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x002279DC File Offset: 0x00225BDC
		[DebuggerNonUserCode]
		public GetPlayerVariablesResponse Clone()
		{
			return new GetPlayerVariablesResponse(this);
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x06008E08 RID: 36360 RVA: 0x002279F4 File Offset: 0x00225BF4
		[DebuggerNonUserCode]
		public RepeatedField<PlayerVariables> PlayerVariables
		{
			get
			{
				return this.playerVariables_;
			}
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x00227A0C File Offset: 0x00225C0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerVariablesResponse);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x00227A2C File Offset: 0x00225C2C
		[DebuggerNonUserCode]
		public bool Equals(GetPlayerVariablesResponse other)
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
					bool flag4 = !this.playerVariables_.Equals(other.playerVariables_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00227A88 File Offset: 0x00225C88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerVariables_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x00227AC8 File Offset: 0x00225CC8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x00227AE0 File Offset: 0x00225CE0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x00227AEC File Offset: 0x00225CEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerVariables_.WriteTo(ref output, GetPlayerVariablesResponse._repeated_playerVariables_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00227B28 File Offset: 0x00225D28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerVariables_.CalculateSize(GetPlayerVariablesResponse._repeated_playerVariables_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x00227B70 File Offset: 0x00225D70
		[DebuggerNonUserCode]
		public void MergeFrom(GetPlayerVariablesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.playerVariables_.Add(other.playerVariables_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00227BB2 File Offset: 0x00225DB2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x00227BC0 File Offset: 0x00225DC0
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
					this.playerVariables_.AddEntriesFrom(ref input, GetPlayerVariablesResponse._repeated_playerVariables_codec);
				}
			}
		}

		// Token: 0x0400402D RID: 16429
		private static readonly MessageParser<GetPlayerVariablesResponse> _parser = new MessageParser<GetPlayerVariablesResponse>(() => new GetPlayerVariablesResponse());

		// Token: 0x0400402E RID: 16430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400402F RID: 16431
		public const int PlayerVariablesFieldNumber = 1;

		// Token: 0x04004030 RID: 16432
		private static readonly FieldCodec<PlayerVariables> _repeated_playerVariables_codec = FieldCodec.ForMessage<PlayerVariables>(10U, Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser);

		// Token: 0x04004031 RID: 16433
		private readonly RepeatedField<PlayerVariables> playerVariables_ = new RepeatedField<PlayerVariables>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E5 RID: 1509
	public sealed class GetPlayerVariablesRequest : IMessage<GetPlayerVariablesRequest>, IMessage, IEquatable<GetPlayerVariablesRequest>, IDeepCloneable<GetPlayerVariablesRequest>, IBufferMessage
	{
		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x00227514 File Offset: 0x00225714
		[DebuggerNonUserCode]
		public static MessageParser<GetPlayerVariablesRequest> Parser
		{
			get
			{
				return GetPlayerVariablesRequest._parser;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x0022752C File Offset: 0x0022572C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x00227550 File Offset: 0x00225750
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerVariablesRequest.Descriptor;
			}
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00227567 File Offset: 0x00225767
		[DebuggerNonUserCode]
		public GetPlayerVariablesRequest()
		{
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0022757C File Offset: 0x0022577C
		[DebuggerNonUserCode]
		public GetPlayerVariablesRequest(GetPlayerVariablesRequest other)
			: this()
		{
			this.playerVariables_ = other.playerVariables_.Clone();
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x002275D0 File Offset: 0x002257D0
		[DebuggerNonUserCode]
		public GetPlayerVariablesRequest Clone()
		{
			return new GetPlayerVariablesRequest(this);
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x002275E8 File Offset: 0x002257E8
		[DebuggerNonUserCode]
		public RepeatedField<PlayerVariables> PlayerVariables
		{
			get
			{
				return this.playerVariables_;
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x00227600 File Offset: 0x00225800
		// (set) Token: 0x06008DF6 RID: 36342 RVA: 0x00227618 File Offset: 0x00225818
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00227624 File Offset: 0x00225824
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerVariablesRequest);
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x00227644 File Offset: 0x00225844
		[DebuggerNonUserCode]
		public bool Equals(GetPlayerVariablesRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Host, other.Host);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x002276BC File Offset: 0x002258BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerVariables_.GetHashCode();
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00227718 File Offset: 0x00225918
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00227730 File Offset: 0x00225930
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x0022773C File Offset: 0x0022593C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerVariables_.WriteTo(ref output, GetPlayerVariablesRequest._repeated_playerVariables_codec);
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x002277A0 File Offset: 0x002259A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerVariables_.CalculateSize(GetPlayerVariablesRequest._repeated_playerVariables_codec);
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00227804 File Offset: 0x00225A04
		[DebuggerNonUserCode]
		public void MergeFrom(GetPlayerVariablesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.playerVariables_.Add(other.playerVariables_);
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00227882 File Offset: 0x00225A82
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00227890 File Offset: 0x00225A90
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.host_ == null;
						if (flag)
						{
							this.Host = new ProcessId();
						}
						input.ReadMessage(this.Host);
					}
				}
				else
				{
					this.playerVariables_.AddEntriesFrom(ref input, GetPlayerVariablesRequest._repeated_playerVariables_codec);
				}
			}
		}

		// Token: 0x04004026 RID: 16422
		private static readonly MessageParser<GetPlayerVariablesRequest> _parser = new MessageParser<GetPlayerVariablesRequest>(() => new GetPlayerVariablesRequest());

		// Token: 0x04004027 RID: 16423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004028 RID: 16424
		public const int PlayerVariablesFieldNumber = 1;

		// Token: 0x04004029 RID: 16425
		private static readonly FieldCodec<PlayerVariables> _repeated_playerVariables_codec = FieldCodec.ForMessage<PlayerVariables>(10U, Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser);

		// Token: 0x0400402A RID: 16426
		private readonly RepeatedField<PlayerVariables> playerVariables_ = new RepeatedField<PlayerVariables>();

		// Token: 0x0400402B RID: 16427
		public const int HostFieldNumber = 2;

		// Token: 0x0400402C RID: 16428
		private ProcessId host_;
	}
}

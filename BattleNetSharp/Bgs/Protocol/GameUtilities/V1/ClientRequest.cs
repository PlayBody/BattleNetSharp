using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E0 RID: 1504
	public sealed class ClientRequest : IMessage<ClientRequest>, IMessage, IEquatable<ClientRequest>, IDeepCloneable<ClientRequest>, IBufferMessage
	{
		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x06008D7B RID: 36219 RVA: 0x00225948 File Offset: 0x00223B48
		[DebuggerNonUserCode]
		public static MessageParser<ClientRequest> Parser
		{
			get
			{
				return ClientRequest._parser;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x00225960 File Offset: 0x00223B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x06008D7D RID: 36221 RVA: 0x00225984 File Offset: 0x00223B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientRequest.Descriptor;
			}
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x0022599B File Offset: 0x00223B9B
		[DebuggerNonUserCode]
		public ClientRequest()
		{
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x002259B0 File Offset: 0x00223BB0
		[DebuggerNonUserCode]
		public ClientRequest(ClientRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.accountId_ = ((other.accountId_ != null) ? other.accountId_.Clone() : null);
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this.program_ = other.program_;
			this.clientInfo_ = ((other.clientInfo_ != null) ? other.clientInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x00225A70 File Offset: 0x00223C70
		[DebuggerNonUserCode]
		public ClientRequest Clone()
		{
			return new ClientRequest(this);
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x06008D81 RID: 36225 RVA: 0x00225A88 File Offset: 0x00223C88
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x06008D82 RID: 36226 RVA: 0x00225AA0 File Offset: 0x00223CA0
		// (set) Token: 0x06008D83 RID: 36227 RVA: 0x00225AB8 File Offset: 0x00223CB8
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

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x00225AC4 File Offset: 0x00223CC4
		// (set) Token: 0x06008D85 RID: 36229 RVA: 0x00225ADC File Offset: 0x00223CDC
		[DebuggerNonUserCode]
		public EntityId AccountId
		{
			get
			{
				return this.accountId_;
			}
			set
			{
				this.accountId_ = value;
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x06008D86 RID: 36230 RVA: 0x00225AE8 File Offset: 0x00223CE8
		// (set) Token: 0x06008D87 RID: 36231 RVA: 0x00225B00 File Offset: 0x00223D00
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x00225B0C File Offset: 0x00223D0C
		// (set) Token: 0x06008D89 RID: 36233 RVA: 0x00225B3D File Offset: 0x00223D3D
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ClientRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x06008D8A RID: 36234 RVA: 0x00225B58 File Offset: 0x00223D58
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x00225B75 File Offset: 0x00223D75
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x06008D8C RID: 36236 RVA: 0x00225B88 File Offset: 0x00223D88
		// (set) Token: 0x06008D8D RID: 36237 RVA: 0x00225BA0 File Offset: 0x00223DA0
		[DebuggerNonUserCode]
		public ClientInfo ClientInfo
		{
			get
			{
				return this.clientInfo_;
			}
			set
			{
				this.clientInfo_ = value;
			}
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x00225BAC File Offset: 0x00223DAC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientRequest);
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00225BCC File Offset: 0x00223DCC
		[DebuggerNonUserCode]
		public bool Equals(ClientRequest other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Host, other.Host);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.AccountId, other.AccountId);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.GameAccountId, other.GameAccountId);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Program != other.Program;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.ClientInfo, other.ClientInfo);
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x00225CC4 File Offset: 0x00223EC4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num ^= this.AccountId.GetHashCode();
			}
			bool flag3 = this.gameAccountId_ != null;
			if (flag3)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag4 = this.clientInfo_ != null;
			if (flag4)
			{
				num ^= this.ClientInfo.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x00225D94 File Offset: 0x00223F94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x00225DAC File Offset: 0x00223FAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x00225DB8 File Offset: 0x00223FB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ClientRequest._repeated_attribute_codec);
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Host);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AccountId);
			}
			bool flag3 = this.gameAccountId_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GameAccountId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.Program);
			}
			bool flag4 = this.clientInfo_ != null;
			if (flag4)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ClientInfo);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x00225EB0 File Offset: 0x002240B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ClientRequest._repeated_attribute_codec);
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag2 = this.accountId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AccountId);
			}
			bool flag3 = this.gameAccountId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag4 = this.clientInfo_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientInfo);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x00225F8C File Offset: 0x0022418C
		[DebuggerNonUserCode]
		public void MergeFrom(ClientRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
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
				bool flag4 = other.accountId_ != null;
				if (flag4)
				{
					bool flag5 = this.accountId_ == null;
					if (flag5)
					{
						this.AccountId = new EntityId();
					}
					this.AccountId.MergeFrom(other.AccountId);
				}
				bool flag6 = other.gameAccountId_ != null;
				if (flag6)
				{
					bool flag7 = this.gameAccountId_ == null;
					if (flag7)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool flag8 = other.clientInfo_ != null;
				if (flag8)
				{
					bool flag9 = this.clientInfo_ == null;
					if (flag9)
					{
						this.ClientInfo = new ClientInfo();
					}
					this.ClientInfo.MergeFrom(other.ClientInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x002260E6 File Offset: 0x002242E6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x002260F4 File Offset: 0x002242F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 26U)
							{
								goto IL_0043;
							}
							bool flag = this.accountId_ == null;
							if (flag)
							{
								this.AccountId = new EntityId();
							}
							input.ReadMessage(this.AccountId);
						}
						else
						{
							bool flag2 = this.host_ == null;
							if (flag2)
							{
								this.Host = new ProcessId();
							}
							input.ReadMessage(this.Host);
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, ClientRequest._repeated_attribute_codec);
					}
				}
				else if (num3 != 34U)
				{
					if (num3 != 45U)
					{
						if (num3 != 50U)
						{
							goto IL_0043;
						}
						bool flag3 = this.clientInfo_ == null;
						if (flag3)
						{
							this.ClientInfo = new ClientInfo();
						}
						input.ReadMessage(this.ClientInfo);
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					bool flag4 = this.gameAccountId_ == null;
					if (flag4)
					{
						this.GameAccountId = new EntityId();
					}
					input.ReadMessage(this.GameAccountId);
				}
				continue;
				IL_0043:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003FF6 RID: 16374
		private static readonly MessageParser<ClientRequest> _parser = new MessageParser<ClientRequest>(() => new ClientRequest());

		// Token: 0x04003FF7 RID: 16375
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FF8 RID: 16376
		private int _hasBits0;

		// Token: 0x04003FF9 RID: 16377
		public const int AttributeFieldNumber = 1;

		// Token: 0x04003FFA RID: 16378
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04003FFB RID: 16379
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003FFC RID: 16380
		public const int HostFieldNumber = 2;

		// Token: 0x04003FFD RID: 16381
		private ProcessId host_;

		// Token: 0x04003FFE RID: 16382
		public const int AccountIdFieldNumber = 3;

		// Token: 0x04003FFF RID: 16383
		private EntityId accountId_;

		// Token: 0x04004000 RID: 16384
		public const int GameAccountIdFieldNumber = 4;

		// Token: 0x04004001 RID: 16385
		private EntityId gameAccountId_;

		// Token: 0x04004002 RID: 16386
		public const int ProgramFieldNumber = 5;

		// Token: 0x04004003 RID: 16387
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004004 RID: 16388
		private uint program_;

		// Token: 0x04004005 RID: 16389
		public const int ClientInfoFieldNumber = 6;

		// Token: 0x04004006 RID: 16390
		private ClientInfo clientInfo_;
	}
}

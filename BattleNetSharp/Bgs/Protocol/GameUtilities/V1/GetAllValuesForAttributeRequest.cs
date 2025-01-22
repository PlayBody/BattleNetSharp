using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005EB RID: 1515
	public sealed class GetAllValuesForAttributeRequest : IMessage<GetAllValuesForAttributeRequest>, IMessage, IEquatable<GetAllValuesForAttributeRequest>, IDeepCloneable<GetAllValuesForAttributeRequest>, IBufferMessage
	{
		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x06008E6C RID: 36460 RVA: 0x00228EA4 File Offset: 0x002270A4
		[DebuggerNonUserCode]
		public static MessageParser<GetAllValuesForAttributeRequest> Parser
		{
			get
			{
				return GetAllValuesForAttributeRequest._parser;
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x00228EBC File Offset: 0x002270BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x06008E6E RID: 36462 RVA: 0x00228EE0 File Offset: 0x002270E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllValuesForAttributeRequest.Descriptor;
			}
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x00228EF7 File Offset: 0x002270F7
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest()
		{
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x00228F04 File Offset: 0x00227104
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest(GetAllValuesForAttributeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attributeKey_ = other.attributeKey_;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E71 RID: 36465 RVA: 0x00228F6C File Offset: 0x0022716C
		[DebuggerNonUserCode]
		public GetAllValuesForAttributeRequest Clone()
		{
			return new GetAllValuesForAttributeRequest(this);
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x06008E72 RID: 36466 RVA: 0x00228F84 File Offset: 0x00227184
		// (set) Token: 0x06008E73 RID: 36467 RVA: 0x00228FA5 File Offset: 0x002271A5
		[DebuggerNonUserCode]
		public string AttributeKey
		{
			get
			{
				return this.attributeKey_ ?? GetAllValuesForAttributeRequest.AttributeKeyDefaultValue;
			}
			set
			{
				this.attributeKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x06008E74 RID: 36468 RVA: 0x00228FBC File Offset: 0x002271BC
		[DebuggerNonUserCode]
		public bool HasAttributeKey
		{
			get
			{
				return this.attributeKey_ != null;
			}
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x00228FD7 File Offset: 0x002271D7
		[DebuggerNonUserCode]
		public void ClearAttributeKey()
		{
			this.attributeKey_ = null;
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x06008E76 RID: 36470 RVA: 0x00228FE4 File Offset: 0x002271E4
		// (set) Token: 0x06008E77 RID: 36471 RVA: 0x00228FFC File Offset: 0x002271FC
		[DebuggerNonUserCode]
		public EntityId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x06008E78 RID: 36472 RVA: 0x00229008 File Offset: 0x00227208
		// (set) Token: 0x06008E79 RID: 36473 RVA: 0x00229039 File Offset: 0x00227239
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
					programDefaultValue = GetAllValuesForAttributeRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x06008E7A RID: 36474 RVA: 0x00229054 File Offset: 0x00227254
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x00229071 File Offset: 0x00227271
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00229084 File Offset: 0x00227284
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllValuesForAttributeRequest);
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x002290A4 File Offset: 0x002272A4
		[DebuggerNonUserCode]
		public bool Equals(GetAllValuesForAttributeRequest other)
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
					bool flag4 = this.AttributeKey != other.AttributeKey;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AgentId, other.AgentId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Program != other.Program;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00229134 File Offset: 0x00227334
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				num ^= this.AttributeKey.GetHashCode();
			}
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x002291BC File Offset: 0x002273BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x002291D4 File Offset: 0x002273D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x002291E0 File Offset: 0x002273E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AttributeKey);
			}
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(45);
				output.WriteFixed32(this.Program);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x00229274 File Offset: 0x00227474
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAttributeKey = this.HasAttributeKey;
			if (hasAttributeKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttributeKey);
			}
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x002292F8 File Offset: 0x002274F8
		[DebuggerNonUserCode]
		public void MergeFrom(GetAllValuesForAttributeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAttributeKey = other.HasAttributeKey;
				if (hasAttributeKey)
				{
					this.AttributeKey = other.AttributeKey;
				}
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new EntityId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x0022939B File Offset: 0x0022759B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x002293A8 File Offset: 0x002275A8
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
						if (num3 != 45U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Program = input.ReadFixed32();
						}
					}
					else
					{
						bool flag = this.agentId_ == null;
						if (flag)
						{
							this.AgentId = new EntityId();
						}
						input.ReadMessage(this.AgentId);
					}
				}
				else
				{
					this.AttributeKey = input.ReadString();
				}
			}
		}

		// Token: 0x0400404C RID: 16460
		private static readonly MessageParser<GetAllValuesForAttributeRequest> _parser = new MessageParser<GetAllValuesForAttributeRequest>(() => new GetAllValuesForAttributeRequest());

		// Token: 0x0400404D RID: 16461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400404E RID: 16462
		private int _hasBits0;

		// Token: 0x0400404F RID: 16463
		public const int AttributeKeyFieldNumber = 1;

		// Token: 0x04004050 RID: 16464
		private static readonly string AttributeKeyDefaultValue = "";

		// Token: 0x04004051 RID: 16465
		private string attributeKey_;

		// Token: 0x04004052 RID: 16466
		public const int AgentIdFieldNumber = 2;

		// Token: 0x04004053 RID: 16467
		private EntityId agentId_;

		// Token: 0x04004054 RID: 16468
		public const int ProgramFieldNumber = 5;

		// Token: 0x04004055 RID: 16469
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004056 RID: 16470
		private uint program_;
	}
}

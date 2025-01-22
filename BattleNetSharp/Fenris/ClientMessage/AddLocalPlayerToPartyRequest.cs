using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023D RID: 573
	public sealed class AddLocalPlayerToPartyRequest : IMessage<AddLocalPlayerToPartyRequest>, IMessage, IEquatable<AddLocalPlayerToPartyRequest>, IDeepCloneable<AddLocalPlayerToPartyRequest>, IBufferMessage
	{
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06003DE4 RID: 15844 RVA: 0x000F4168 File Offset: 0x000F2368
		[DebuggerNonUserCode]
		public static MessageParser<AddLocalPlayerToPartyRequest> Parser
		{
			get
			{
				return AddLocalPlayerToPartyRequest._parser;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06003DE5 RID: 15845 RVA: 0x000F4180 File Offset: 0x000F2380
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[45];
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x000F41A4 File Offset: 0x000F23A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddLocalPlayerToPartyRequest.Descriptor;
			}
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000F41BB File Offset: 0x000F23BB
		[DebuggerNonUserCode]
		public AddLocalPlayerToPartyRequest()
		{
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000F41C5 File Offset: 0x000F23C5
		[DebuggerNonUserCode]
		public AddLocalPlayerToPartyRequest(AddLocalPlayerToPartyRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.partyId_ = other.partyId_;
			this.partyToken_ = other.partyToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000F4204 File Offset: 0x000F2404
		[DebuggerNonUserCode]
		public AddLocalPlayerToPartyRequest Clone()
		{
			return new AddLocalPlayerToPartyRequest(this);
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x000F421C File Offset: 0x000F241C
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x000F423D File Offset: 0x000F243D
		[DebuggerNonUserCode]
		public string PartyId
		{
			get
			{
				return this.partyId_ ?? AddLocalPlayerToPartyRequest.PartyIdDefaultValue;
			}
			set
			{
				this.partyId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x000F4254 File Offset: 0x000F2454
		[DebuggerNonUserCode]
		public bool HasPartyId
		{
			get
			{
				return this.partyId_ != null;
			}
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x000F426F File Offset: 0x000F246F
		[DebuggerNonUserCode]
		public void ClearPartyId()
		{
			this.partyId_ = null;
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06003DEE RID: 15854 RVA: 0x000F427C File Offset: 0x000F247C
		// (set) Token: 0x06003DEF RID: 15855 RVA: 0x000F42AD File Offset: 0x000F24AD
		[DebuggerNonUserCode]
		public ulong PartyToken
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong partyTokenDefaultValue;
				if (flag)
				{
					partyTokenDefaultValue = this.partyToken_;
				}
				else
				{
					partyTokenDefaultValue = AddLocalPlayerToPartyRequest.PartyTokenDefaultValue;
				}
				return partyTokenDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.partyToken_ = value;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06003DF0 RID: 15856 RVA: 0x000F42C8 File Offset: 0x000F24C8
		[DebuggerNonUserCode]
		public bool HasPartyToken
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000F42E5 File Offset: 0x000F24E5
		[DebuggerNonUserCode]
		public void ClearPartyToken()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000F42F8 File Offset: 0x000F24F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddLocalPlayerToPartyRequest);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x000F4318 File Offset: 0x000F2518
		[DebuggerNonUserCode]
		public bool Equals(AddLocalPlayerToPartyRequest other)
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
					bool flag4 = this.PartyId != other.PartyId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PartyToken != other.PartyToken;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000F438C File Offset: 0x000F258C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num ^= this.PartyId.GetHashCode();
			}
			bool hasPartyToken = this.HasPartyToken;
			if (hasPartyToken)
			{
				num ^= this.PartyToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000F43F8 File Offset: 0x000F25F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x000F4410 File Offset: 0x000F2610
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000F441C File Offset: 0x000F261C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PartyId);
			}
			bool hasPartyToken = this.HasPartyToken;
			if (hasPartyToken)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.PartyToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x000F448C File Offset: 0x000F268C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasPartyId = this.HasPartyId;
			if (hasPartyId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PartyId);
			}
			bool hasPartyToken = this.HasPartyToken;
			if (hasPartyToken)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.PartyToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x000F44F8 File Offset: 0x000F26F8
		[DebuggerNonUserCode]
		public void MergeFrom(AddLocalPlayerToPartyRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasPartyId = other.HasPartyId;
				if (hasPartyId)
				{
					this.PartyId = other.PartyId;
				}
				bool hasPartyToken = other.HasPartyToken;
				if (hasPartyToken)
				{
					this.PartyToken = other.PartyToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x000F455A File Offset: 0x000F275A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000F4568 File Offset: 0x000F2768
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PartyToken = input.ReadUInt64();
					}
				}
				else
				{
					this.PartyId = input.ReadString();
				}
			}
		}

		// Token: 0x04001C65 RID: 7269
		private static readonly MessageParser<AddLocalPlayerToPartyRequest> _parser = new MessageParser<AddLocalPlayerToPartyRequest>(() => new AddLocalPlayerToPartyRequest());

		// Token: 0x04001C66 RID: 7270
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C67 RID: 7271
		private int _hasBits0;

		// Token: 0x04001C68 RID: 7272
		public const int PartyIdFieldNumber = 1;

		// Token: 0x04001C69 RID: 7273
		private static readonly string PartyIdDefaultValue = "";

		// Token: 0x04001C6A RID: 7274
		private string partyId_;

		// Token: 0x04001C6B RID: 7275
		public const int PartyTokenFieldNumber = 2;

		// Token: 0x04001C6C RID: 7276
		private static readonly ulong PartyTokenDefaultValue = 0UL;

		// Token: 0x04001C6D RID: 7277
		private ulong partyToken_;
	}
}

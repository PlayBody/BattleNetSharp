using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000724 RID: 1828
	public sealed class GetAuthorizedDataRequest : IMessage<GetAuthorizedDataRequest>, IMessage, IEquatable<GetAuthorizedDataRequest>, IDeepCloneable<GetAuthorizedDataRequest>, IBufferMessage
	{
		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600A775 RID: 42869 RVA: 0x0028B948 File Offset: 0x00289B48
		[DebuggerNonUserCode]
		public static MessageParser<GetAuthorizedDataRequest> Parser
		{
			get
			{
				return GetAuthorizedDataRequest._parser;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x0028B960 File Offset: 0x00289B60
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x0028B984 File Offset: 0x00289B84
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAuthorizedDataRequest.Descriptor;
			}
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x0028B99B File Offset: 0x00289B9B
		[DebuggerNonUserCode]
		public GetAuthorizedDataRequest()
		{
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x0028B9B0 File Offset: 0x00289BB0
		[DebuggerNonUserCode]
		public GetAuthorizedDataRequest(GetAuthorizedDataRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.tag_ = other.tag_.Clone();
			this.privilegedNetwork_ = other.privilegedNetwork_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x0028BA1C File Offset: 0x00289C1C
		[DebuggerNonUserCode]
		public GetAuthorizedDataRequest Clone()
		{
			return new GetAuthorizedDataRequest(this);
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600A77B RID: 42875 RVA: 0x0028BA34 File Offset: 0x00289C34
		// (set) Token: 0x0600A77C RID: 42876 RVA: 0x0028BA4C File Offset: 0x00289C4C
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x0028BA58 File Offset: 0x00289C58
		[DebuggerNonUserCode]
		public RepeatedField<string> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x0028BA70 File Offset: 0x00289C70
		// (set) Token: 0x0600A77F RID: 42879 RVA: 0x0028BAA1 File Offset: 0x00289CA1
		[DebuggerNonUserCode]
		public bool PrivilegedNetwork
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool privilegedNetworkDefaultValue;
				if (flag)
				{
					privilegedNetworkDefaultValue = this.privilegedNetwork_;
				}
				else
				{
					privilegedNetworkDefaultValue = GetAuthorizedDataRequest.PrivilegedNetworkDefaultValue;
				}
				return privilegedNetworkDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.privilegedNetwork_ = value;
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600A780 RID: 42880 RVA: 0x0028BABC File Offset: 0x00289CBC
		[DebuggerNonUserCode]
		public bool HasPrivilegedNetwork
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x0028BAD9 File Offset: 0x00289CD9
		[DebuggerNonUserCode]
		public void ClearPrivilegedNetwork()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x0028BAEC File Offset: 0x00289CEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAuthorizedDataRequest);
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x0028BB0C File Offset: 0x00289D0C
		[DebuggerNonUserCode]
		public bool Equals(GetAuthorizedDataRequest other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.tag_.Equals(other.tag_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.PrivilegedNetwork != other.PrivilegedNetwork;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x0028BBA0 File Offset: 0x00289DA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.tag_.GetHashCode();
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
			{
				num ^= this.PrivilegedNetwork.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0028BC1C File Offset: 0x00289E1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x0028BC34 File Offset: 0x00289E34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x0028BC40 File Offset: 0x00289E40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			this.tag_.WriteTo(ref output, GetAuthorizedDataRequest._repeated_tag_codec);
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.PrivilegedNetwork);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x0028BCC4 File Offset: 0x00289EC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			num += this.tag_.CalculateSize(GetAuthorizedDataRequest._repeated_tag_codec);
			bool hasPrivilegedNetwork = this.HasPrivilegedNetwork;
			if (hasPrivilegedNetwork)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x0028BD3C File Offset: 0x00289F3C
		[DebuggerNonUserCode]
		public void MergeFrom(GetAuthorizedDataRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				this.tag_.Add(other.tag_);
				bool hasPrivilegedNetwork = other.HasPrivilegedNetwork;
				if (hasPrivilegedNetwork)
				{
					this.PrivilegedNetwork = other.PrivilegedNetwork;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x0028BDD3 File Offset: 0x00289FD3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x0028BDE0 File Offset: 0x00289FE0
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PrivilegedNetwork = input.ReadBool();
						}
					}
					else
					{
						this.tag_.AddEntriesFrom(ref input, GetAuthorizedDataRequest._repeated_tag_codec);
					}
				}
				else
				{
					bool flag = this.entityId_ == null;
					if (flag)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04004B16 RID: 19222
		private static readonly MessageParser<GetAuthorizedDataRequest> _parser = new MessageParser<GetAuthorizedDataRequest>(() => new GetAuthorizedDataRequest());

		// Token: 0x04004B17 RID: 19223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B18 RID: 19224
		private int _hasBits0;

		// Token: 0x04004B19 RID: 19225
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04004B1A RID: 19226
		private EntityId entityId_;

		// Token: 0x04004B1B RID: 19227
		public const int TagFieldNumber = 2;

		// Token: 0x04004B1C RID: 19228
		private static readonly FieldCodec<string> _repeated_tag_codec = FieldCodec.ForString(18U);

		// Token: 0x04004B1D RID: 19229
		private readonly RepeatedField<string> tag_ = new RepeatedField<string>();

		// Token: 0x04004B1E RID: 19230
		public const int PrivilegedNetworkFieldNumber = 3;

		// Token: 0x04004B1F RID: 19231
		private static readonly bool PrivilegedNetworkDefaultValue = false;

		// Token: 0x04004B20 RID: 19232
		private bool privilegedNetwork_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006BF RID: 1727
	public sealed class ListChannelCountRequest : IMessage<ListChannelCountRequest>, IMessage, IEquatable<ListChannelCountRequest>, IDeepCloneable<ListChannelCountRequest>, IBufferMessage
	{
		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x06009FA4 RID: 40868 RVA: 0x0026D2A8 File Offset: 0x0026B4A8
		[DebuggerNonUserCode]
		public static MessageParser<ListChannelCountRequest> Parser
		{
			get
			{
				return ListChannelCountRequest._parser;
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x0026D2C0 File Offset: 0x0026B4C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationServiceReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x06009FA6 RID: 40870 RVA: 0x0026D2E4 File Offset: 0x0026B4E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListChannelCountRequest.Descriptor;
			}
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x0026D2FB File Offset: 0x0026B4FB
		[DebuggerNonUserCode]
		public ListChannelCountRequest()
		{
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x0026D308 File Offset: 0x0026B508
		[DebuggerNonUserCode]
		public ListChannelCountRequest(ListChannelCountRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.serviceType_ = other.serviceType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x0026D364 File Offset: 0x0026B564
		[DebuggerNonUserCode]
		public ListChannelCountRequest Clone()
		{
			return new ListChannelCountRequest(this);
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x06009FAA RID: 40874 RVA: 0x0026D37C File Offset: 0x0026B57C
		// (set) Token: 0x06009FAB RID: 40875 RVA: 0x0026D394 File Offset: 0x0026B594
		[DebuggerNonUserCode]
		public EntityId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x06009FAC RID: 40876 RVA: 0x0026D3A0 File Offset: 0x0026B5A0
		// (set) Token: 0x06009FAD RID: 40877 RVA: 0x0026D3D1 File Offset: 0x0026B5D1
		[DebuggerNonUserCode]
		public uint ServiceType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint serviceTypeDefaultValue;
				if (flag)
				{
					serviceTypeDefaultValue = this.serviceType_;
				}
				else
				{
					serviceTypeDefaultValue = ListChannelCountRequest.ServiceTypeDefaultValue;
				}
				return serviceTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.serviceType_ = value;
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x06009FAE RID: 40878 RVA: 0x0026D3EC File Offset: 0x0026B5EC
		[DebuggerNonUserCode]
		public bool HasServiceType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x0026D409 File Offset: 0x0026B609
		[DebuggerNonUserCode]
		public void ClearServiceType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x0026D41C File Offset: 0x0026B61C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListChannelCountRequest);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x0026D43C File Offset: 0x0026B63C
		[DebuggerNonUserCode]
		public bool Equals(ListChannelCountRequest other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ServiceType != other.ServiceType;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x0026D4B0 File Offset: 0x0026B6B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				num ^= this.ServiceType.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x0026D51C File Offset: 0x0026B71C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x0026D534 File Offset: 0x0026B734
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x0026D540 File Offset: 0x0026B740
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ServiceType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x0026D5B4 File Offset: 0x0026B7B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasServiceType = this.HasServiceType;
			if (hasServiceType)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ServiceType);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x0026D624 File Offset: 0x0026B824
		[DebuggerNonUserCode]
		public void MergeFrom(ListChannelCountRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new EntityId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasServiceType = other.HasServiceType;
				if (hasServiceType)
				{
					this.ServiceType = other.ServiceType;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x0026D6A9 File Offset: 0x0026B8A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x0026D6B4 File Offset: 0x0026B8B4
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
						this.ServiceType = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new EntityId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x040047F2 RID: 18418
		private static readonly MessageParser<ListChannelCountRequest> _parser = new MessageParser<ListChannelCountRequest>(() => new ListChannelCountRequest());

		// Token: 0x040047F3 RID: 18419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047F4 RID: 18420
		private int _hasBits0;

		// Token: 0x040047F5 RID: 18421
		public const int MemberIdFieldNumber = 1;

		// Token: 0x040047F6 RID: 18422
		private EntityId memberId_;

		// Token: 0x040047F7 RID: 18423
		public const int ServiceTypeFieldNumber = 2;

		// Token: 0x040047F8 RID: 18424
		private static readonly uint ServiceTypeDefaultValue = 0U;

		// Token: 0x040047F9 RID: 18425
		private uint serviceType_;
	}
}

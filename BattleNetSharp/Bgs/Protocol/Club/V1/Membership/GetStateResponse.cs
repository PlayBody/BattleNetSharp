using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1.Membership
{
	// Token: 0x0200051D RID: 1309
	public sealed class GetStateResponse : IMessage<GetStateResponse>, IMessage, IEquatable<GetStateResponse>, IDeepCloneable<GetStateResponse>, IBufferMessage
	{
		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x06007F47 RID: 32583 RVA: 0x001EFC14 File Offset: 0x001EDE14
		[DebuggerNonUserCode]
		public static MessageParser<GetStateResponse> Parser
		{
			get
			{
				return GetStateResponse._parser;
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x06007F48 RID: 32584 RVA: 0x001EFC2C File Offset: 0x001EDE2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x06007F49 RID: 32585 RVA: 0x001EFC50 File Offset: 0x001EDE50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateResponse.Descriptor;
			}
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x001EFC67 File Offset: 0x001EDE67
		[DebuggerNonUserCode]
		public GetStateResponse()
		{
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x001EFC71 File Offset: 0x001EDE71
		[DebuggerNonUserCode]
		public GetStateResponse(GetStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x001EFCA8 File Offset: 0x001EDEA8
		[DebuggerNonUserCode]
		public GetStateResponse Clone()
		{
			return new GetStateResponse(this);
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x001EFCC0 File Offset: 0x001EDEC0
		// (set) Token: 0x06007F4E RID: 32590 RVA: 0x001EFCD8 File Offset: 0x001EDED8
		[DebuggerNonUserCode]
		public ClubMembershipState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x001EFCE4 File Offset: 0x001EDEE4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateResponse);
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x001EFD04 File Offset: 0x001EDF04
		[DebuggerNonUserCode]
		public bool Equals(GetStateResponse other)
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
					bool flag4 = !object.Equals(this.State, other.State);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x001EFD60 File Offset: 0x001EDF60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x001EFDB0 File Offset: 0x001EDFB0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x001EFDC8 File Offset: 0x001EDFC8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x001EFDD4 File Offset: 0x001EDFD4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x001EFE24 File Offset: 0x001EE024
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x001EFE78 File Offset: 0x001EE078
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new ClubMembershipState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x001EFEE4 File Offset: 0x001EE0E4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x001EFEF0 File Offset: 0x001EE0F0
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
					bool flag = this.state_ == null;
					if (flag)
					{
						this.State = new ClubMembershipState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x040039D0 RID: 14800
		private static readonly MessageParser<GetStateResponse> _parser = new MessageParser<GetStateResponse>(() => new GetStateResponse());

		// Token: 0x040039D1 RID: 14801
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D2 RID: 14802
		public const int StateFieldNumber = 1;

		// Token: 0x040039D3 RID: 14803
		private ClubMembershipState state_;
	}
}

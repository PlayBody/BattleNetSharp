using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000242 RID: 578
	public sealed class RevokeInviteRequest : IMessage<RevokeInviteRequest>, IMessage, IEquatable<RevokeInviteRequest>, IDeepCloneable<RevokeInviteRequest>, IBufferMessage
	{
		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x000F5600 File Offset: 0x000F3800
		[DebuggerNonUserCode]
		public static MessageParser<RevokeInviteRequest> Parser
		{
			get
			{
				return RevokeInviteRequest._parser;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x000F5618 File Offset: 0x000F3818
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[50];
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x000F563C File Offset: 0x000F383C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RevokeInviteRequest.Descriptor;
			}
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x000F5653 File Offset: 0x000F3853
		[DebuggerNonUserCode]
		public RevokeInviteRequest()
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x000F565D File Offset: 0x000F385D
		[DebuggerNonUserCode]
		public RevokeInviteRequest(RevokeInviteRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.inviteId_ = other.inviteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x000F5690 File Offset: 0x000F3890
		[DebuggerNonUserCode]
		public RevokeInviteRequest Clone()
		{
			return new RevokeInviteRequest(this);
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x000F56A8 File Offset: 0x000F38A8
		// (set) Token: 0x06003E5E RID: 15966 RVA: 0x000F56D9 File Offset: 0x000F38D9
		[DebuggerNonUserCode]
		public ulong InviteId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong inviteIdDefaultValue;
				if (flag)
				{
					inviteIdDefaultValue = this.inviteId_;
				}
				else
				{
					inviteIdDefaultValue = RevokeInviteRequest.InviteIdDefaultValue;
				}
				return inviteIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.inviteId_ = value;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06003E5F RID: 15967 RVA: 0x000F56F4 File Offset: 0x000F38F4
		[DebuggerNonUserCode]
		public bool HasInviteId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x000F5711 File Offset: 0x000F3911
		[DebuggerNonUserCode]
		public void ClearInviteId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x000F5724 File Offset: 0x000F3924
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RevokeInviteRequest);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x000F5744 File Offset: 0x000F3944
		[DebuggerNonUserCode]
		public bool Equals(RevokeInviteRequest other)
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
					bool flag4 = this.InviteId != other.InviteId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x000F579C File Offset: 0x000F399C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num ^= this.InviteId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x000F57EC File Offset: 0x000F39EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x000F5804 File Offset: 0x000F3A04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x000F5810 File Offset: 0x000F3A10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.InviteId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x000F585C File Offset: 0x000F3A5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInviteId = this.HasInviteId;
			if (hasInviteId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.InviteId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x000F58AC File Offset: 0x000F3AAC
		[DebuggerNonUserCode]
		public void MergeFrom(RevokeInviteRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInviteId = other.HasInviteId;
				if (hasInviteId)
				{
					this.InviteId = other.InviteId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x000F58F5 File Offset: 0x000F3AF5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x000F5900 File Offset: 0x000F3B00
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InviteId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001C8A RID: 7306
		private static readonly MessageParser<RevokeInviteRequest> _parser = new MessageParser<RevokeInviteRequest>(() => new RevokeInviteRequest());

		// Token: 0x04001C8B RID: 7307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C8C RID: 7308
		private int _hasBits0;

		// Token: 0x04001C8D RID: 7309
		public const int InviteIdFieldNumber = 1;

		// Token: 0x04001C8E RID: 7310
		private static readonly ulong InviteIdDefaultValue = 0UL;

		// Token: 0x04001C8F RID: 7311
		private ulong inviteId_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004F4 RID: 1268
	public sealed class StreamAccess : IMessage<StreamAccess>, IMessage, IEquatable<StreamAccess>, IDeepCloneable<StreamAccess>, IBufferMessage
	{
		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x001E2B14 File Offset: 0x001E0D14
		[DebuggerNonUserCode]
		public static MessageParser<StreamAccess> Parser
		{
			get
			{
				return StreamAccess._parser;
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x06007BE2 RID: 31714 RVA: 0x001E2B2C File Offset: 0x001E0D2C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x001E2B50 File Offset: 0x001E0D50
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamAccess.Descriptor;
			}
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x001E2B67 File Offset: 0x001E0D67
		[DebuggerNonUserCode]
		public StreamAccess()
		{
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x001E2B7C File Offset: 0x001E0D7C
		[DebuggerNonUserCode]
		public StreamAccess(StreamAccess other)
			: this()
		{
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x001E2BA8 File Offset: 0x001E0DA8
		[DebuggerNonUserCode]
		public StreamAccess Clone()
		{
			return new StreamAccess(this);
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x001E2BC0 File Offset: 0x001E0DC0
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x001E2BD8 File Offset: 0x001E0DD8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamAccess);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x001E2BF8 File Offset: 0x001E0DF8
		[DebuggerNonUserCode]
		public bool Equals(StreamAccess other)
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
					bool flag4 = !this.role_.Equals(other.role_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x001E2C54 File Offset: 0x001E0E54
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.role_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x001E2C94 File Offset: 0x001E0E94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x001E2CAC File Offset: 0x001E0EAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x001E2CB8 File Offset: 0x001E0EB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.role_.WriteTo(ref output, StreamAccess._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x001E2CF4 File Offset: 0x001E0EF4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.role_.CalculateSize(StreamAccess._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x001E2D3C File Offset: 0x001E0F3C
		[DebuggerNonUserCode]
		public void MergeFrom(StreamAccess other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x001E2D7E File Offset: 0x001E0F7E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x001E2D8C File Offset: 0x001E0F8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U && num3 != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.role_.AddEntriesFrom(ref input, StreamAccess._repeated_role_codec);
				}
			}
		}

		// Token: 0x04003853 RID: 14419
		private static readonly MessageParser<StreamAccess> _parser = new MessageParser<StreamAccess>(() => new StreamAccess());

		// Token: 0x04003854 RID: 14420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003855 RID: 14421
		public const int RoleFieldNumber = 1;

		// Token: 0x04003856 RID: 14422
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003857 RID: 14423
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}

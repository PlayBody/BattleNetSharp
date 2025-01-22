using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000390 RID: 912
	public sealed class FanoutTarget : IMessage<FanoutTarget>, IMessage, IEquatable<FanoutTarget>, IDeepCloneable<FanoutTarget>, IBufferMessage
	{
		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06005C80 RID: 23680 RVA: 0x00165B94 File Offset: 0x00163D94
		[DebuggerNonUserCode]
		public static MessageParser<FanoutTarget> Parser
		{
			get
			{
				return FanoutTarget._parser;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06005C81 RID: 23681 RVA: 0x00165BAC File Offset: 0x00163DAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RpcTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x00165BD0 File Offset: 0x00163DD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FanoutTarget.Descriptor;
			}
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00165BE7 File Offset: 0x00163DE7
		[DebuggerNonUserCode]
		public FanoutTarget()
		{
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00165BF4 File Offset: 0x00163DF4
		[DebuggerNonUserCode]
		public FanoutTarget(FanoutTarget other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clientId_ = other.clientId_;
			this.key_ = other.key_;
			this.objectId_ = other.objectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00165C4C File Offset: 0x00163E4C
		[DebuggerNonUserCode]
		public FanoutTarget Clone()
		{
			return new FanoutTarget(this);
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x00165C64 File Offset: 0x00163E64
		// (set) Token: 0x06005C87 RID: 23687 RVA: 0x00165C85 File Offset: 0x00163E85
		[DebuggerNonUserCode]
		public string ClientId
		{
			get
			{
				return this.clientId_ ?? FanoutTarget.ClientIdDefaultValue;
			}
			set
			{
				this.clientId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x00165C9C File Offset: 0x00163E9C
		[DebuggerNonUserCode]
		public bool HasClientId
		{
			get
			{
				return this.clientId_ != null;
			}
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00165CB7 File Offset: 0x00163EB7
		[DebuggerNonUserCode]
		public void ClearClientId()
		{
			this.clientId_ = null;
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x00165CC4 File Offset: 0x00163EC4
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x00165CE5 File Offset: 0x00163EE5
		[DebuggerNonUserCode]
		public ByteString Key
		{
			get
			{
				return this.key_ ?? FanoutTarget.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x00165CFC File Offset: 0x00163EFC
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00165D1A File Offset: 0x00163F1A
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x00165D24 File Offset: 0x00163F24
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x00165D55 File Offset: 0x00163F55
		[DebuggerNonUserCode]
		public ulong ObjectId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong objectIdDefaultValue;
				if (flag)
				{
					objectIdDefaultValue = this.objectId_;
				}
				else
				{
					objectIdDefaultValue = FanoutTarget.ObjectIdDefaultValue;
				}
				return objectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.objectId_ = value;
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06005C90 RID: 23696 RVA: 0x00165D70 File Offset: 0x00163F70
		[DebuggerNonUserCode]
		public bool HasObjectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00165D8D File Offset: 0x00163F8D
		[DebuggerNonUserCode]
		public void ClearObjectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00165DA0 File Offset: 0x00163FA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FanoutTarget);
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00165DC0 File Offset: 0x00163FC0
		[DebuggerNonUserCode]
		public bool Equals(FanoutTarget other)
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
					bool flag4 = this.ClientId != other.ClientId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Key != other.Key;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ObjectId != other.ObjectId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00165E4C File Offset: 0x0016404C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num ^= this.ClientId.GetHashCode();
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num ^= this.ObjectId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00165ED0 File Offset: 0x001640D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00165EE8 File Offset: 0x001640E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00165EF4 File Offset: 0x001640F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClientId);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Key);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ObjectId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x00165F84 File Offset: 0x00164184
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClientId = this.HasClientId;
			if (hasClientId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientId);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Key);
			}
			bool hasObjectId = this.HasObjectId;
			if (hasObjectId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ObjectId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00166010 File Offset: 0x00164210
		[DebuggerNonUserCode]
		public void MergeFrom(FanoutTarget other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClientId = other.HasClientId;
				if (hasClientId)
				{
					this.ClientId = other.ClientId;
				}
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasObjectId = other.HasObjectId;
				if (hasObjectId)
				{
					this.ObjectId = other.ObjectId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x0016608B File Offset: 0x0016428B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00166098 File Offset: 0x00164298
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
							this.ObjectId = input.ReadUInt64();
						}
					}
					else
					{
						this.Key = input.ReadBytes();
					}
				}
				else
				{
					this.ClientId = input.ReadString();
				}
			}
		}

		// Token: 0x04002A38 RID: 10808
		private static readonly MessageParser<FanoutTarget> _parser = new MessageParser<FanoutTarget>(() => new FanoutTarget());

		// Token: 0x04002A39 RID: 10809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A3A RID: 10810
		private int _hasBits0;

		// Token: 0x04002A3B RID: 10811
		public const int ClientIdFieldNumber = 1;

		// Token: 0x04002A3C RID: 10812
		private static readonly string ClientIdDefaultValue = "";

		// Token: 0x04002A3D RID: 10813
		private string clientId_;

		// Token: 0x04002A3E RID: 10814
		public const int KeyFieldNumber = 2;

		// Token: 0x04002A3F RID: 10815
		private static readonly ByteString KeyDefaultValue = ByteString.Empty;

		// Token: 0x04002A40 RID: 10816
		private ByteString key_;

		// Token: 0x04002A41 RID: 10817
		public const int ObjectIdFieldNumber = 3;

		// Token: 0x04002A42 RID: 10818
		private static readonly ulong ObjectIdDefaultValue = 0UL;

		// Token: 0x04002A43 RID: 10819
		private ulong objectId_;
	}
}

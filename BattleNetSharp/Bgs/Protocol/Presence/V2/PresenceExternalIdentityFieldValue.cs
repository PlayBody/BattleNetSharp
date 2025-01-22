using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005C1 RID: 1473
	public sealed class PresenceExternalIdentityFieldValue : IMessage<PresenceExternalIdentityFieldValue>, IMessage, IEquatable<PresenceExternalIdentityFieldValue>, IDeepCloneable<PresenceExternalIdentityFieldValue>, IBufferMessage
	{
		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06008B9A RID: 35738 RVA: 0x0021E194 File Offset: 0x0021C394
		[DebuggerNonUserCode]
		public static MessageParser<PresenceExternalIdentityFieldValue> Parser
		{
			get
			{
				return PresenceExternalIdentityFieldValue._parser;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008B9B RID: 35739 RVA: 0x0021E1AC File Offset: 0x0021C3AC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008B9C RID: 35740 RVA: 0x0021E1D0 File Offset: 0x0021C3D0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceExternalIdentityFieldValue.Descriptor;
			}
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x0021E1E7 File Offset: 0x0021C3E7
		[DebuggerNonUserCode]
		public PresenceExternalIdentityFieldValue()
		{
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x0021E1F1 File Offset: 0x0021C3F1
		[DebuggerNonUserCode]
		public PresenceExternalIdentityFieldValue(PresenceExternalIdentityFieldValue other)
			: this()
		{
			this.uniqueId_ = other.uniqueId_;
			this.displayId_ = other.displayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x0021E224 File Offset: 0x0021C424
		[DebuggerNonUserCode]
		public PresenceExternalIdentityFieldValue Clone()
		{
			return new PresenceExternalIdentityFieldValue(this);
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008BA0 RID: 35744 RVA: 0x0021E23C File Offset: 0x0021C43C
		// (set) Token: 0x06008BA1 RID: 35745 RVA: 0x0021E25D File Offset: 0x0021C45D
		[DebuggerNonUserCode]
		public string UniqueId
		{
			get
			{
				return this.uniqueId_ ?? PresenceExternalIdentityFieldValue.UniqueIdDefaultValue;
			}
			set
			{
				this.uniqueId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06008BA2 RID: 35746 RVA: 0x0021E274 File Offset: 0x0021C474
		[DebuggerNonUserCode]
		public bool HasUniqueId
		{
			get
			{
				return this.uniqueId_ != null;
			}
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x0021E28F File Offset: 0x0021C48F
		[DebuggerNonUserCode]
		public void ClearUniqueId()
		{
			this.uniqueId_ = null;
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008BA4 RID: 35748 RVA: 0x0021E29C File Offset: 0x0021C49C
		// (set) Token: 0x06008BA5 RID: 35749 RVA: 0x0021E2BD File Offset: 0x0021C4BD
		[DebuggerNonUserCode]
		public string DisplayId
		{
			get
			{
				return this.displayId_ ?? PresenceExternalIdentityFieldValue.DisplayIdDefaultValue;
			}
			set
			{
				this.displayId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06008BA6 RID: 35750 RVA: 0x0021E2D4 File Offset: 0x0021C4D4
		[DebuggerNonUserCode]
		public bool HasDisplayId
		{
			get
			{
				return this.displayId_ != null;
			}
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x0021E2EF File Offset: 0x0021C4EF
		[DebuggerNonUserCode]
		public void ClearDisplayId()
		{
			this.displayId_ = null;
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x0021E2FC File Offset: 0x0021C4FC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceExternalIdentityFieldValue);
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x0021E31C File Offset: 0x0021C51C
		[DebuggerNonUserCode]
		public bool Equals(PresenceExternalIdentityFieldValue other)
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
					bool flag4 = this.UniqueId != other.UniqueId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DisplayId != other.DisplayId;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x0021E390 File Offset: 0x0021C590
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			bool hasDisplayId = this.HasDisplayId;
			if (hasDisplayId)
			{
				num ^= this.DisplayId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x0021E3F4 File Offset: 0x0021C5F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x0021E40C File Offset: 0x0021C60C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BAD RID: 35757 RVA: 0x0021E418 File Offset: 0x0021C618
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.UniqueId);
			}
			bool hasDisplayId = this.HasDisplayId;
			if (hasDisplayId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.DisplayId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BAE RID: 35758 RVA: 0x0021E488 File Offset: 0x0021C688
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUniqueId = this.HasUniqueId;
			if (hasUniqueId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.UniqueId);
			}
			bool hasDisplayId = this.HasDisplayId;
			if (hasDisplayId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x0021E4F4 File Offset: 0x0021C6F4
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceExternalIdentityFieldValue other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUniqueId = other.HasUniqueId;
				if (hasUniqueId)
				{
					this.UniqueId = other.UniqueId;
				}
				bool hasDisplayId = other.HasDisplayId;
				if (hasDisplayId)
				{
					this.DisplayId = other.DisplayId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x0021E556 File Offset: 0x0021C756
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x0021E564 File Offset: 0x0021C764
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
						this.DisplayId = input.ReadString();
					}
				}
				else
				{
					this.UniqueId = input.ReadString();
				}
			}
		}

		// Token: 0x04003F2F RID: 16175
		private static readonly MessageParser<PresenceExternalIdentityFieldValue> _parser = new MessageParser<PresenceExternalIdentityFieldValue>(() => new PresenceExternalIdentityFieldValue());

		// Token: 0x04003F30 RID: 16176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F31 RID: 16177
		public const int UniqueIdFieldNumber = 1;

		// Token: 0x04003F32 RID: 16178
		private static readonly string UniqueIdDefaultValue = "";

		// Token: 0x04003F33 RID: 16179
		private string uniqueId_;

		// Token: 0x04003F34 RID: 16180
		public const int DisplayIdFieldNumber = 2;

		// Token: 0x04003F35 RID: 16181
		private static readonly string DisplayIdDefaultValue = "";

		// Token: 0x04003F36 RID: 16182
		private string displayId_;
	}
}

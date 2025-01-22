using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005D0 RID: 1488
	public sealed class Target : IMessage<Target>, IMessage, IEquatable<Target>, IDeepCloneable<Target>, IBufferMessage
	{
		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06008C6C RID: 35948 RVA: 0x00221284 File Offset: 0x0021F484
		[DebuggerNonUserCode]
		public static MessageParser<Target> Parser
		{
			get
			{
				return Target._parser;
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06008C6D RID: 35949 RVA: 0x0022129C File Offset: 0x0021F49C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x06008C6E RID: 35950 RVA: 0x002212C0 File Offset: 0x0021F4C0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Target.Descriptor;
			}
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x002212D7 File Offset: 0x0021F4D7
		[DebuggerNonUserCode]
		public Target()
		{
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x002212E4 File Offset: 0x0021F4E4
		[DebuggerNonUserCode]
		public Target(Target other)
			: this()
		{
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x00221334 File Offset: 0x0021F534
		[DebuggerNonUserCode]
		public Target Clone()
		{
			return new Target(this);
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x0022134C File Offset: 0x0021F54C
		// (set) Token: 0x06008C73 RID: 35955 RVA: 0x00221364 File Offset: 0x0021F564
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06008C74 RID: 35956 RVA: 0x00221370 File Offset: 0x0021F570
		// (set) Token: 0x06008C75 RID: 35957 RVA: 0x00221391 File Offset: 0x0021F591
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? Target.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06008C76 RID: 35958 RVA: 0x002213A8 File Offset: 0x0021F5A8
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x002213C3 File Offset: 0x0021F5C3
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x002213D0 File Offset: 0x0021F5D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Target);
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x002213F0 File Offset: 0x0021F5F0
		[DebuggerNonUserCode]
		public bool Equals(Target other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Type != other.Type;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x00221464 File Offset: 0x0021F664
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x002214CC File Offset: 0x0021F6CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x002214E4 File Offset: 0x0021F6E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x002214F0 File Offset: 0x0021F6F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Type);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x00221564 File Offset: 0x0021F764
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x002215D4 File Offset: 0x0021F7D4
		[DebuggerNonUserCode]
		public void MergeFrom(Target other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x00221659 File Offset: 0x0021F859
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00221664 File Offset: 0x0021F864
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
						this.Type = input.ReadString();
					}
				}
				else
				{
					bool flag = this.identity_ == null;
					if (flag)
					{
						this.Identity = new Identity();
					}
					input.ReadMessage(this.Identity);
				}
			}
		}

		// Token: 0x04003F85 RID: 16261
		private static readonly MessageParser<Target> _parser = new MessageParser<Target>(() => new Target());

		// Token: 0x04003F86 RID: 16262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F87 RID: 16263
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003F88 RID: 16264
		private Identity identity_;

		// Token: 0x04003F89 RID: 16265
		public const int TypeFieldNumber = 2;

		// Token: 0x04003F8A RID: 16266
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04003F8B RID: 16267
		private string type_;
	}
}

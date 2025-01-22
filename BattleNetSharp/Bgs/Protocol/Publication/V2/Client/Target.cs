using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000595 RID: 1429
	public sealed class Target : IMessage<Target>, IMessage, IEquatable<Target>, IDeepCloneable<Target>, IBufferMessage
	{
		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600885D RID: 34909 RVA: 0x00212054 File Offset: 0x00210254
		[DebuggerNonUserCode]
		public static MessageParser<Target> Parser
		{
			get
			{
				return Target._parser;
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x0021206C File Offset: 0x0021026C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600885F RID: 34911 RVA: 0x00212090 File Offset: 0x00210290
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Target.Descriptor;
			}
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x002120A7 File Offset: 0x002102A7
		[DebuggerNonUserCode]
		public Target()
		{
		}

		// Token: 0x06008861 RID: 34913 RVA: 0x002120B1 File Offset: 0x002102B1
		[DebuggerNonUserCode]
		public Target(Target other)
			: this()
		{
			this.topicName_ = other.topicName_;
			this.identity_ = other.identity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x002120E4 File Offset: 0x002102E4
		[DebuggerNonUserCode]
		public Target Clone()
		{
			return new Target(this);
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06008863 RID: 34915 RVA: 0x002120FC File Offset: 0x002102FC
		// (set) Token: 0x06008864 RID: 34916 RVA: 0x0021211D File Offset: 0x0021031D
		[DebuggerNonUserCode]
		public string TopicName
		{
			get
			{
				return this.topicName_ ?? Target.TopicNameDefaultValue;
			}
			set
			{
				this.topicName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06008865 RID: 34917 RVA: 0x00212134 File Offset: 0x00210334
		[DebuggerNonUserCode]
		public bool HasTopicName
		{
			get
			{
				return this.topicName_ != null;
			}
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x0021214F File Offset: 0x0021034F
		[DebuggerNonUserCode]
		public void ClearTopicName()
		{
			this.topicName_ = null;
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06008867 RID: 34919 RVA: 0x0021215C File Offset: 0x0021035C
		// (set) Token: 0x06008868 RID: 34920 RVA: 0x0021217D File Offset: 0x0021037D
		[DebuggerNonUserCode]
		public string Identity
		{
			get
			{
				return this.identity_ ?? Target.IdentityDefaultValue;
			}
			set
			{
				this.identity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06008869 RID: 34921 RVA: 0x00212194 File Offset: 0x00210394
		[DebuggerNonUserCode]
		public bool HasIdentity
		{
			get
			{
				return this.identity_ != null;
			}
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x002121AF File Offset: 0x002103AF
		[DebuggerNonUserCode]
		public void ClearIdentity()
		{
			this.identity_ = null;
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x002121BC File Offset: 0x002103BC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Target);
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x002121DC File Offset: 0x002103DC
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
					bool flag4 = this.TopicName != other.TopicName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Identity != other.Identity;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x00212250 File Offset: 0x00210450
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTopicName = this.HasTopicName;
			if (hasTopicName)
			{
				num ^= this.TopicName.GetHashCode();
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x002122B4 File Offset: 0x002104B4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x002122CC File Offset: 0x002104CC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x002122D8 File Offset: 0x002104D8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTopicName = this.HasTopicName;
			if (hasTopicName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TopicName);
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Identity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x00212348 File Offset: 0x00210548
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTopicName = this.HasTopicName;
			if (hasTopicName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TopicName);
			}
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Identity);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x002123B4 File Offset: 0x002105B4
		[DebuggerNonUserCode]
		public void MergeFrom(Target other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTopicName = other.HasTopicName;
				if (hasTopicName)
				{
					this.TopicName = other.TopicName;
				}
				bool hasIdentity = other.HasIdentity;
				if (hasIdentity)
				{
					this.Identity = other.Identity;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x00212416 File Offset: 0x00210616
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x00212424 File Offset: 0x00210624
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
						this.Identity = input.ReadString();
					}
				}
				else
				{
					this.TopicName = input.ReadString();
				}
			}
		}

		// Token: 0x04003DC7 RID: 15815
		private static readonly MessageParser<Target> _parser = new MessageParser<Target>(() => new Target());

		// Token: 0x04003DC8 RID: 15816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DC9 RID: 15817
		public const int TopicNameFieldNumber = 1;

		// Token: 0x04003DCA RID: 15818
		private static readonly string TopicNameDefaultValue = "";

		// Token: 0x04003DCB RID: 15819
		private string topicName_;

		// Token: 0x04003DCC RID: 15820
		public const int IdentityFieldNumber = 2;

		// Token: 0x04003DCD RID: 15821
		private static readonly string IdentityDefaultValue = "";

		// Token: 0x04003DCE RID: 15822
		private string identity_;
	}
}

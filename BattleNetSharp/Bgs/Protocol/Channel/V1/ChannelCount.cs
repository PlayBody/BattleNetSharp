using System;
using System.Diagnostics;
using System.Text;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006CA RID: 1738
	public sealed class ChannelCount : IMessage<ChannelCount>, IMessage, IEquatable<ChannelCount>, IDeepCloneable<ChannelCount>, IBufferMessage
	{
		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A07B RID: 41083 RVA: 0x002709BC File Offset: 0x0026EBBC
		[DebuggerNonUserCode]
		public static MessageParser<ChannelCount> Parser
		{
			get
			{
				return ChannelCount._parser;
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A07C RID: 41084 RVA: 0x002709D4 File Offset: 0x0026EBD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelInvitationTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x002709F8 File Offset: 0x0026EBF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelCount.Descriptor;
			}
		}

		// Token: 0x0600A07E RID: 41086 RVA: 0x00270A0F File Offset: 0x0026EC0F
		[DebuggerNonUserCode]
		public ChannelCount()
		{
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x00270A1C File Offset: 0x0026EC1C
		[DebuggerNonUserCode]
		public ChannelCount(ChannelCount other)
			: this()
		{
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.channelType_ = other.channelType_;
			this.channelName_ = other.channelName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x00270A78 File Offset: 0x0026EC78
		[DebuggerNonUserCode]
		public ChannelCount Clone()
		{
			return new ChannelCount(this);
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x00270A90 File Offset: 0x0026EC90
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x00270AA8 File Offset: 0x0026ECA8
		[DebuggerNonUserCode]
		public EntityId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A083 RID: 41091 RVA: 0x00270AB4 File Offset: 0x0026ECB4
		// (set) Token: 0x0600A084 RID: 41092 RVA: 0x00270AD5 File Offset: 0x0026ECD5
		[DebuggerNonUserCode]
		public string ChannelType
		{
			get
			{
				return this.channelType_ ?? ChannelCount.ChannelTypeDefaultValue;
			}
			set
			{
				this.channelType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A085 RID: 41093 RVA: 0x00270AEC File Offset: 0x0026ECEC
		[DebuggerNonUserCode]
		public bool HasChannelType
		{
			get
			{
				return this.channelType_ != null;
			}
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x00270B07 File Offset: 0x0026ED07
		[DebuggerNonUserCode]
		public void ClearChannelType()
		{
			this.channelType_ = null;
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x00270B14 File Offset: 0x0026ED14
		// (set) Token: 0x0600A088 RID: 41096 RVA: 0x00270B35 File Offset: 0x0026ED35
		[DebuggerNonUserCode]
		public string ChannelName
		{
			get
			{
				return this.channelName_ ?? ChannelCount.ChannelNameDefaultValue;
			}
			set
			{
				this.channelName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A089 RID: 41097 RVA: 0x00270B4C File Offset: 0x0026ED4C
		[DebuggerNonUserCode]
		public bool HasChannelName
		{
			get
			{
				return this.channelName_ != null;
			}
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x00270B67 File Offset: 0x0026ED67
		[DebuggerNonUserCode]
		public void ClearChannelName()
		{
			this.channelName_ = null;
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x00270B74 File Offset: 0x0026ED74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelCount);
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x00270B94 File Offset: 0x0026ED94
		[DebuggerNonUserCode]
		public bool Equals(ChannelCount other)
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
					bool flag4 = !object.Equals(this.ChannelId, other.ChannelId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ChannelType != other.ChannelType;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ChannelName != other.ChannelName;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x00270C24 File Offset: 0x0026EE24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num ^= this.ChannelType.GetHashCode();
			}
			bool hasChannelName = this.HasChannelName;
			if (hasChannelName)
			{
				num ^= this.ChannelName.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00270CA8 File Offset: 0x0026EEA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00270CC0 File Offset: 0x0026EEC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x00270CCC File Offset: 0x0026EECC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.channelId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChannelId);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ChannelType);
			}
			bool hasChannelName = this.HasChannelName;
			if (hasChannelName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ChannelName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x00270D60 File Offset: 0x0026EF60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.channelId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasChannelType = this.HasChannelType;
			if (hasChannelType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelType);
			}
			bool hasChannelName = this.HasChannelName;
			if (hasChannelName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ChannelName);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x00270DF0 File Offset: 0x0026EFF0
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelCount other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.channelId_ != null;
				if (flag2)
				{
					bool flag3 = this.channelId_ == null;
					if (flag3)
					{
						this.ChannelId = new EntityId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasChannelType = other.HasChannelType;
				if (hasChannelType)
				{
					this.ChannelType = other.ChannelType;
				}
				bool hasChannelName = other.HasChannelName;
				if (hasChannelName)
				{
					this.ChannelName = other.ChannelName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x00270E93 File Offset: 0x0026F093
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x00270EA0 File Offset: 0x0026F0A0
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ChannelName = input.ReadString();
						}
					}
					else
					{
						this.ChannelType = input.ReadString();
					}
				}
				else
				{
					bool flag = this.channelId_ == null;
					if (flag)
					{
						this.ChannelId = new EntityId();
					}
					input.ReadMessage(this.ChannelId);
				}
			}
		}

		// Token: 0x0400485A RID: 18522
		private static readonly MessageParser<ChannelCount> _parser = new MessageParser<ChannelCount>(() => new ChannelCount());

		// Token: 0x0400485B RID: 18523
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400485C RID: 18524
		public const int ChannelIdFieldNumber = 1;

		// Token: 0x0400485D RID: 18525
		private EntityId channelId_;

		// Token: 0x0400485E RID: 18526
		public const int ChannelTypeFieldNumber = 2;

		// Token: 0x0400485F RID: 18527
		private static readonly string ChannelTypeDefaultValue = Encoding.UTF8.GetString(Convert.FromBase64String("ZGVmYXVsdA=="), 0, 7);

		// Token: 0x04004860 RID: 18528
		private string channelType_;

		// Token: 0x04004861 RID: 18529
		public const int ChannelNameFieldNumber = 3;

		// Token: 0x04004862 RID: 18530
		private static readonly string ChannelNameDefaultValue = "";

		// Token: 0x04004863 RID: 18531
		private string channelName_;
	}
}

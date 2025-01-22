using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005CC RID: 1484
	public sealed class PublishRequest : IMessage<PublishRequest>, IMessage, IEquatable<PublishRequest>, IDeepCloneable<PublishRequest>, IBufferMessage
	{
		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x00220708 File Offset: 0x0021E908
		[DebuggerNonUserCode]
		public static MessageParser<PublishRequest> Parser
		{
			get
			{
				return PublishRequest._parser;
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x00220720 File Offset: 0x0021E920
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00220744 File Offset: 0x0021E944
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublishRequest.Descriptor;
			}
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x0022075B File Offset: 0x0021E95B
		[DebuggerNonUserCode]
		public PublishRequest()
		{
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00220768 File Offset: 0x0021E968
		[DebuggerNonUserCode]
		public PublishRequest(PublishRequest other)
			: this()
		{
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.notification_ = ((other.notification_ != null) ? other.notification_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x002207C8 File Offset: 0x0021E9C8
		[DebuggerNonUserCode]
		public PublishRequest Clone()
		{
			return new PublishRequest(this);
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06008C4F RID: 35919 RVA: 0x002207E0 File Offset: 0x0021E9E0
		// (set) Token: 0x06008C50 RID: 35920 RVA: 0x002207F8 File Offset: 0x0021E9F8
		[DebuggerNonUserCode]
		public Target Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00220804 File Offset: 0x0021EA04
		// (set) Token: 0x06008C52 RID: 35922 RVA: 0x0022081C File Offset: 0x0021EA1C
		[DebuggerNonUserCode]
		public Notification Notification
		{
			get
			{
				return this.notification_;
			}
			set
			{
				this.notification_ = value;
			}
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x00220828 File Offset: 0x0021EA28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublishRequest);
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x00220848 File Offset: 0x0021EA48
		[DebuggerNonUserCode]
		public bool Equals(PublishRequest other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Notification, other.Notification);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x002208C0 File Offset: 0x0021EAC0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			bool flag2 = this.notification_ != null;
			if (flag2)
			{
				num ^= this.Notification.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x0022092C File Offset: 0x0021EB2C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00220944 File Offset: 0x0021EB44
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00220950 File Offset: 0x0021EB50
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			bool flag2 = this.notification_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Notification);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x002209C4 File Offset: 0x0021EBC4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			bool flag2 = this.notification_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Notification);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00220A38 File Offset: 0x0021EC38
		[DebuggerNonUserCode]
		public void MergeFrom(PublishRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new Target();
					}
					this.Target.MergeFrom(other.Target);
				}
				bool flag4 = other.notification_ != null;
				if (flag4)
				{
					bool flag5 = this.notification_ == null;
					if (flag5)
					{
						this.Notification = new Notification();
					}
					this.Notification.MergeFrom(other.Notification);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00220AE5 File Offset: 0x0021ECE5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x00220AF0 File Offset: 0x0021ECF0
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
						bool flag = this.notification_ == null;
						if (flag)
						{
							this.Notification = new Notification();
						}
						input.ReadMessage(this.Notification);
					}
				}
				else
				{
					bool flag2 = this.target_ == null;
					if (flag2)
					{
						this.Target = new Target();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003F70 RID: 16240
		private static readonly MessageParser<PublishRequest> _parser = new MessageParser<PublishRequest>(() => new PublishRequest());

		// Token: 0x04003F71 RID: 16241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F72 RID: 16242
		public const int TargetFieldNumber = 1;

		// Token: 0x04003F73 RID: 16243
		private Target target_;

		// Token: 0x04003F74 RID: 16244
		public const int NotificationFieldNumber = 2;

		// Token: 0x04003F75 RID: 16245
		private Notification notification_;
	}
}

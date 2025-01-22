using System;
using System.Diagnostics;
using Fenris.Account;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.AccountMigration
{
	// Token: 0x020002CE RID: 718
	public sealed class WriteDataV2 : IMessage<WriteDataV2>, IMessage, IEquatable<WriteDataV2>, IDeepCloneable<WriteDataV2>, IBufferMessage
	{
		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x0012336C File Offset: 0x0012156C
		[DebuggerNonUserCode]
		public static MessageParser<WriteDataV2> Parser
		{
			get
			{
				return WriteDataV2._parser;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x00123384 File Offset: 0x00121584
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountMigrationReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x001233A8 File Offset: 0x001215A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WriteDataV2.Descriptor;
			}
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x001233BF File Offset: 0x001215BF
		[DebuggerNonUserCode]
		public WriteDataV2()
		{
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x001233CC File Offset: 0x001215CC
		[DebuggerNonUserCode]
		public WriteDataV2(WriteDataV2 other)
			: this()
		{
			this.writeSavedDefinition_ = ((other.writeSavedDefinition_ != null) ? other.writeSavedDefinition_.Clone() : null);
			this.writeAccountProfile_ = ((other.writeAccountProfile_ != null) ? other.writeAccountProfile_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0012342C File Offset: 0x0012162C
		[DebuggerNonUserCode]
		public WriteDataV2 Clone()
		{
			return new WriteDataV2(this);
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00123444 File Offset: 0x00121644
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x0012345C File Offset: 0x0012165C
		[DebuggerNonUserCode]
		public SavedDefinition WriteSavedDefinition
		{
			get
			{
				return this.writeSavedDefinition_;
			}
			set
			{
				this.writeSavedDefinition_ = value;
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x00123468 File Offset: 0x00121668
		// (set) Token: 0x06004C2D RID: 19501 RVA: 0x00123480 File Offset: 0x00121680
		[DebuggerNonUserCode]
		public AccountProfile WriteAccountProfile
		{
			get
			{
				return this.writeAccountProfile_;
			}
			set
			{
				this.writeAccountProfile_ = value;
			}
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x0012348C File Offset: 0x0012168C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WriteDataV2);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x001234AC File Offset: 0x001216AC
		[DebuggerNonUserCode]
		public bool Equals(WriteDataV2 other)
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
					bool flag4 = !object.Equals(this.WriteSavedDefinition, other.WriteSavedDefinition);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.WriteAccountProfile, other.WriteAccountProfile);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00123524 File Offset: 0x00121724
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.writeSavedDefinition_ != null;
			if (flag)
			{
				num ^= this.WriteSavedDefinition.GetHashCode();
			}
			bool flag2 = this.writeAccountProfile_ != null;
			if (flag2)
			{
				num ^= this.WriteAccountProfile.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00123590 File Offset: 0x00121790
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x001235A8 File Offset: 0x001217A8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x001235B4 File Offset: 0x001217B4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.writeSavedDefinition_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.WriteSavedDefinition);
			}
			bool flag2 = this.writeAccountProfile_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WriteAccountProfile);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00123628 File Offset: 0x00121828
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.writeSavedDefinition_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WriteSavedDefinition);
			}
			bool flag2 = this.writeAccountProfile_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WriteAccountProfile);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x0012369C File Offset: 0x0012189C
		[DebuggerNonUserCode]
		public void MergeFrom(WriteDataV2 other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.writeSavedDefinition_ != null;
				if (flag2)
				{
					bool flag3 = this.writeSavedDefinition_ == null;
					if (flag3)
					{
						this.WriteSavedDefinition = new SavedDefinition();
					}
					this.WriteSavedDefinition.MergeFrom(other.WriteSavedDefinition);
				}
				bool flag4 = other.writeAccountProfile_ != null;
				if (flag4)
				{
					bool flag5 = this.writeAccountProfile_ == null;
					if (flag5)
					{
						this.WriteAccountProfile = new AccountProfile();
					}
					this.WriteAccountProfile.MergeFrom(other.WriteAccountProfile);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00123749 File Offset: 0x00121949
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00123754 File Offset: 0x00121954
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
						bool flag = this.writeAccountProfile_ == null;
						if (flag)
						{
							this.WriteAccountProfile = new AccountProfile();
						}
						input.ReadMessage(this.WriteAccountProfile);
					}
				}
				else
				{
					bool flag2 = this.writeSavedDefinition_ == null;
					if (flag2)
					{
						this.WriteSavedDefinition = new SavedDefinition();
					}
					input.ReadMessage(this.WriteSavedDefinition);
				}
			}
		}

		// Token: 0x040021F8 RID: 8696
		private static readonly MessageParser<WriteDataV2> _parser = new MessageParser<WriteDataV2>(() => new WriteDataV2());

		// Token: 0x040021F9 RID: 8697
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021FA RID: 8698
		public const int WriteSavedDefinitionFieldNumber = 1;

		// Token: 0x040021FB RID: 8699
		private SavedDefinition writeSavedDefinition_;

		// Token: 0x040021FC RID: 8700
		public const int WriteAccountProfileFieldNumber = 2;

		// Token: 0x040021FD RID: 8701
		private AccountProfile writeAccountProfile_;
	}
}

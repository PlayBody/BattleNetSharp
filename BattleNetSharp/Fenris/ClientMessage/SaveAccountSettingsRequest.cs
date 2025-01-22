using System;
using System.Diagnostics;
using Fenris.Client;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022F RID: 559
	public sealed class SaveAccountSettingsRequest : IMessage<SaveAccountSettingsRequest>, IMessage, IEquatable<SaveAccountSettingsRequest>, IDeepCloneable<SaveAccountSettingsRequest>, IBufferMessage
	{
		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x000F0AD0 File Offset: 0x000EECD0
		[DebuggerNonUserCode]
		public static MessageParser<SaveAccountSettingsRequest> Parser
		{
			get
			{
				return SaveAccountSettingsRequest._parser;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x000F0AE8 File Offset: 0x000EECE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x000F0B0C File Offset: 0x000EED0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SaveAccountSettingsRequest.Descriptor;
			}
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x000F0B23 File Offset: 0x000EED23
		[DebuggerNonUserCode]
		public SaveAccountSettingsRequest()
		{
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x000F0B2D File Offset: 0x000EED2D
		[DebuggerNonUserCode]
		public SaveAccountSettingsRequest(SaveAccountSettingsRequest other)
			: this()
		{
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x000F0B64 File Offset: 0x000EED64
		[DebuggerNonUserCode]
		public SaveAccountSettingsRequest Clone()
		{
			return new SaveAccountSettingsRequest(this);
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x000F0B7C File Offset: 0x000EED7C
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x000F0B94 File Offset: 0x000EED94
		[DebuggerNonUserCode]
		public GameAccountSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x000F0BA0 File Offset: 0x000EEDA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SaveAccountSettingsRequest);
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x000F0BC0 File Offset: 0x000EEDC0
		[DebuggerNonUserCode]
		public bool Equals(SaveAccountSettingsRequest other)
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
					bool flag4 = !object.Equals(this.Settings, other.Settings);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x000F0C1C File Offset: 0x000EEE1C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.settings_ != null;
			if (flag)
			{
				num ^= this.Settings.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x000F0C6C File Offset: 0x000EEE6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x000F0C84 File Offset: 0x000EEE84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x000F0C90 File Offset: 0x000EEE90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.settings_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Settings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x000F0CE0 File Offset: 0x000EEEE0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.settings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x000F0D34 File Offset: 0x000EEF34
		[DebuggerNonUserCode]
		public void MergeFrom(SaveAccountSettingsRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.settings_ != null;
				if (flag2)
				{
					bool flag3 = this.settings_ == null;
					if (flag3)
					{
						this.Settings = new GameAccountSettings();
					}
					this.Settings.MergeFrom(other.Settings);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x000F0DA0 File Offset: 0x000EEFA0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x000F0DAC File Offset: 0x000EEFAC
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
					bool flag = this.settings_ == null;
					if (flag)
					{
						this.Settings = new GameAccountSettings();
					}
					input.ReadMessage(this.Settings);
				}
			}
		}

		// Token: 0x04001C0A RID: 7178
		private static readonly MessageParser<SaveAccountSettingsRequest> _parser = new MessageParser<SaveAccountSettingsRequest>(() => new SaveAccountSettingsRequest());

		// Token: 0x04001C0B RID: 7179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C0C RID: 7180
		public const int SettingsFieldNumber = 1;

		// Token: 0x04001C0D RID: 7181
		private GameAccountSettings settings_;
	}
}

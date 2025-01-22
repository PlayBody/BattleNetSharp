using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x0200033D RID: 829
	public sealed class GlobalGameCreationSettings : IMessage<GlobalGameCreationSettings>, IMessage, IEquatable<GlobalGameCreationSettings>, IDeepCloneable<GlobalGameCreationSettings>, IBufferMessage
	{
		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x0014DE90 File Offset: 0x0014C090
		[DebuggerNonUserCode]
		public static MessageParser<GlobalGameCreationSettings> Parser
		{
			get
			{
				return GlobalGameCreationSettings._parser;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06005658 RID: 22104 RVA: 0x0014DEA8 File Offset: 0x0014C0A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsGameGlobalCreationReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x0014DECC File Offset: 0x0014C0CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GlobalGameCreationSettings.Descriptor;
			}
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x0014DEE3 File Offset: 0x0014C0E3
		[DebuggerNonUserCode]
		public GlobalGameCreationSettings()
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x0014DEED File Offset: 0x0014C0ED
		[DebuggerNonUserCode]
		public GlobalGameCreationSettings(GlobalGameCreationSettings other)
			: this()
		{
			this.itemDropSpacing_ = other.itemDropSpacing_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x0014DF14 File Offset: 0x0014C114
		[DebuggerNonUserCode]
		public GlobalGameCreationSettings Clone()
		{
			return new GlobalGameCreationSettings(this);
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x0014DF2C File Offset: 0x0014C12C
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x0014DF4D File Offset: 0x0014C14D
		[DebuggerNonUserCode]
		public string ItemDropSpacing
		{
			get
			{
				return this.itemDropSpacing_ ?? GlobalGameCreationSettings.ItemDropSpacingDefaultValue;
			}
			set
			{
				this.itemDropSpacing_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x0014DF64 File Offset: 0x0014C164
		[DebuggerNonUserCode]
		public bool HasItemDropSpacing
		{
			get
			{
				return this.itemDropSpacing_ != null;
			}
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x0014DF7F File Offset: 0x0014C17F
		[DebuggerNonUserCode]
		public void ClearItemDropSpacing()
		{
			this.itemDropSpacing_ = null;
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x0014DF8C File Offset: 0x0014C18C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GlobalGameCreationSettings);
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x0014DFAC File Offset: 0x0014C1AC
		[DebuggerNonUserCode]
		public bool Equals(GlobalGameCreationSettings other)
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
					bool flag4 = this.ItemDropSpacing != other.ItemDropSpacing;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x0014E004 File Offset: 0x0014C204
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				num ^= this.ItemDropSpacing.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x0014E050 File Offset: 0x0014C250
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x0014E068 File Offset: 0x0014C268
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x0014E074 File Offset: 0x0014C274
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ItemDropSpacing);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0014E0C0 File Offset: 0x0014C2C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasItemDropSpacing = this.HasItemDropSpacing;
			if (hasItemDropSpacing)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ItemDropSpacing);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0014E110 File Offset: 0x0014C310
		[DebuggerNonUserCode]
		public void MergeFrom(GlobalGameCreationSettings other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasItemDropSpacing = other.HasItemDropSpacing;
				if (hasItemDropSpacing)
				{
					this.ItemDropSpacing = other.ItemDropSpacing;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0014E159 File Offset: 0x0014C359
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0014E164 File Offset: 0x0014C364
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
					this.ItemDropSpacing = input.ReadString();
				}
			}
		}

		// Token: 0x04002755 RID: 10069
		private static readonly MessageParser<GlobalGameCreationSettings> _parser = new MessageParser<GlobalGameCreationSettings>(() => new GlobalGameCreationSettings());

		// Token: 0x04002756 RID: 10070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002757 RID: 10071
		public const int ItemDropSpacingFieldNumber = 1;

		// Token: 0x04002758 RID: 10072
		private static readonly string ItemDropSpacingDefaultValue = "";

		// Token: 0x04002759 RID: 10073
		private string itemDropSpacing_;
	}
}

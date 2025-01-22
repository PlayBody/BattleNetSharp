using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000273 RID: 627
	public sealed class ClanChatMessage : IMessage<ClanChatMessage>, IMessage, IEquatable<ClanChatMessage>, IDeepCloneable<ClanChatMessage>, IBufferMessage
	{
		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x001041D8 File Offset: 0x001023D8
		[DebuggerNonUserCode]
		public static MessageParser<ClanChatMessage> Parser
		{
			get
			{
				return ClanChatMessage._parser;
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x001041F0 File Offset: 0x001023F0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[99];
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x00104214 File Offset: 0x00102414
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanChatMessage.Descriptor;
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0010422B File Offset: 0x0010242B
		[DebuggerNonUserCode]
		public ClanChatMessage()
		{
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x00104238 File Offset: 0x00102438
		[DebuggerNonUserCode]
		public ClanChatMessage(ClanChatMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.text_ = other.text_;
			this.platform_ = other.platform_;
			this.crosschatEnabled_ = other.crosschatEnabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x00104290 File Offset: 0x00102490
		[DebuggerNonUserCode]
		public ClanChatMessage Clone()
		{
			return new ClanChatMessage(this);
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x001042A8 File Offset: 0x001024A8
		// (set) Token: 0x0600432C RID: 17196 RVA: 0x001042C9 File Offset: 0x001024C9
		[DebuggerNonUserCode]
		public string Text
		{
			get
			{
				return this.text_ ?? ClanChatMessage.TextDefaultValue;
			}
			set
			{
				this.text_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x001042E0 File Offset: 0x001024E0
		[DebuggerNonUserCode]
		public bool HasText
		{
			get
			{
				return this.text_ != null;
			}
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x001042FB File Offset: 0x001024FB
		[DebuggerNonUserCode]
		public void ClearText()
		{
			this.text_ = null;
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x00104308 File Offset: 0x00102508
		// (set) Token: 0x06004330 RID: 17200 RVA: 0x00104339 File Offset: 0x00102539
		[DebuggerNonUserCode]
		public uint Platform
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint platformDefaultValue;
				if (flag)
				{
					platformDefaultValue = this.platform_;
				}
				else
				{
					platformDefaultValue = ClanChatMessage.PlatformDefaultValue;
				}
				return platformDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.platform_ = value;
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x00104354 File Offset: 0x00102554
		[DebuggerNonUserCode]
		public bool HasPlatform
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x00104371 File Offset: 0x00102571
		[DebuggerNonUserCode]
		public void ClearPlatform()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x00104384 File Offset: 0x00102584
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x001043B5 File Offset: 0x001025B5
		[DebuggerNonUserCode]
		public bool CrosschatEnabled
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool crosschatEnabledDefaultValue;
				if (flag)
				{
					crosschatEnabledDefaultValue = this.crosschatEnabled_;
				}
				else
				{
					crosschatEnabledDefaultValue = ClanChatMessage.CrosschatEnabledDefaultValue;
				}
				return crosschatEnabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.crosschatEnabled_ = value;
			}
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x001043D0 File Offset: 0x001025D0
		[DebuggerNonUserCode]
		public bool HasCrosschatEnabled
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x001043ED File Offset: 0x001025ED
		[DebuggerNonUserCode]
		public void ClearCrosschatEnabled()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00104400 File Offset: 0x00102600
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanChatMessage);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00104420 File Offset: 0x00102620
		[DebuggerNonUserCode]
		public bool Equals(ClanChatMessage other)
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
					bool flag4 = this.Text != other.Text;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Platform != other.Platform;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CrosschatEnabled != other.CrosschatEnabled;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x001044AC File Offset: 0x001026AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasText = this.HasText;
			if (hasText)
			{
				num ^= this.Text.GetHashCode();
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num ^= this.Platform.GetHashCode();
			}
			bool hasCrosschatEnabled = this.HasCrosschatEnabled;
			if (hasCrosschatEnabled)
			{
				num ^= this.CrosschatEnabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00104534 File Offset: 0x00102734
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x0010454C File Offset: 0x0010274C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00104558 File Offset: 0x00102758
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasText = this.HasText;
			if (hasText)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Text);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Platform);
			}
			bool hasCrosschatEnabled = this.HasCrosschatEnabled;
			if (hasCrosschatEnabled)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CrosschatEnabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x001045E8 File Offset: 0x001027E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasText = this.HasText;
			if (hasText)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Text);
			}
			bool hasPlatform = this.HasPlatform;
			if (hasPlatform)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Platform);
			}
			bool hasCrosschatEnabled = this.HasCrosschatEnabled;
			if (hasCrosschatEnabled)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00104668 File Offset: 0x00102868
		[DebuggerNonUserCode]
		public void MergeFrom(ClanChatMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasText = other.HasText;
				if (hasText)
				{
					this.Text = other.Text;
				}
				bool hasPlatform = other.HasPlatform;
				if (hasPlatform)
				{
					this.Platform = other.Platform;
				}
				bool hasCrosschatEnabled = other.HasCrosschatEnabled;
				if (hasCrosschatEnabled)
				{
					this.CrosschatEnabled = other.CrosschatEnabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x001046E3 File Offset: 0x001028E3
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x001046F0 File Offset: 0x001028F0
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
					if (num3 != 16U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CrosschatEnabled = input.ReadBool();
						}
					}
					else
					{
						this.Platform = input.ReadUInt32();
					}
				}
				else
				{
					this.Text = input.ReadString();
				}
			}
		}

		// Token: 0x04001E45 RID: 7749
		private static readonly MessageParser<ClanChatMessage> _parser = new MessageParser<ClanChatMessage>(() => new ClanChatMessage());

		// Token: 0x04001E46 RID: 7750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E47 RID: 7751
		private int _hasBits0;

		// Token: 0x04001E48 RID: 7752
		public const int TextFieldNumber = 1;

		// Token: 0x04001E49 RID: 7753
		private static readonly string TextDefaultValue = "";

		// Token: 0x04001E4A RID: 7754
		private string text_;

		// Token: 0x04001E4B RID: 7755
		public const int PlatformFieldNumber = 2;

		// Token: 0x04001E4C RID: 7756
		private static readonly uint PlatformDefaultValue = 0U;

		// Token: 0x04001E4D RID: 7757
		private uint platform_;

		// Token: 0x04001E4E RID: 7758
		public const int CrosschatEnabledFieldNumber = 3;

		// Token: 0x04001E4F RID: 7759
		private static readonly bool CrosschatEnabledDefaultValue = false;

		// Token: 0x04001E50 RID: 7760
		private bool crosschatEnabled_;
	}
}

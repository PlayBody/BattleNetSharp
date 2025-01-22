using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GenericResource
{
	// Token: 0x02000783 RID: 1923
	public sealed class Data : IMessage<Data>, IMessage, IEquatable<Data>, IDeepCloneable<Data>, IBufferMessage
	{
		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x002AF2FC File Offset: 0x002AD4FC
		[DebuggerNonUserCode]
		public static MessageParser<Data> Parser
		{
			get
			{
				return Data._parser;
			}
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x002AF314 File Offset: 0x002AD514
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GenericResourceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600B070 RID: 45168 RVA: 0x002AF338 File Offset: 0x002AD538
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Data.Descriptor;
			}
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x002AF34F File Offset: 0x002AD54F
		[DebuggerNonUserCode]
		public Data()
		{
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x002AF359 File Offset: 0x002AD559
		[DebuggerNonUserCode]
		public Data(Data other)
			: this()
		{
			this.lang_ = other.lang_;
			this.key_ = other.key_;
			this.message_ = other.message_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x002AF398 File Offset: 0x002AD598
		[DebuggerNonUserCode]
		public Data Clone()
		{
			return new Data(this);
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600B074 RID: 45172 RVA: 0x002AF3B0 File Offset: 0x002AD5B0
		// (set) Token: 0x0600B075 RID: 45173 RVA: 0x002AF3D1 File Offset: 0x002AD5D1
		[DebuggerNonUserCode]
		public string Lang
		{
			get
			{
				return this.lang_ ?? Data.LangDefaultValue;
			}
			set
			{
				this.lang_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600B076 RID: 45174 RVA: 0x002AF3E8 File Offset: 0x002AD5E8
		[DebuggerNonUserCode]
		public bool HasLang
		{
			get
			{
				return this.lang_ != null;
			}
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x002AF403 File Offset: 0x002AD603
		[DebuggerNonUserCode]
		public void ClearLang()
		{
			this.lang_ = null;
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600B078 RID: 45176 RVA: 0x002AF410 File Offset: 0x002AD610
		// (set) Token: 0x0600B079 RID: 45177 RVA: 0x002AF431 File Offset: 0x002AD631
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? Data.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600B07A RID: 45178 RVA: 0x002AF448 File Offset: 0x002AD648
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x002AF463 File Offset: 0x002AD663
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600B07C RID: 45180 RVA: 0x002AF470 File Offset: 0x002AD670
		// (set) Token: 0x0600B07D RID: 45181 RVA: 0x002AF491 File Offset: 0x002AD691
		[DebuggerNonUserCode]
		public string Message
		{
			get
			{
				return this.message_ ?? Data.MessageDefaultValue;
			}
			set
			{
				this.message_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x002AF4A8 File Offset: 0x002AD6A8
		[DebuggerNonUserCode]
		public bool HasMessage
		{
			get
			{
				return this.message_ != null;
			}
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x002AF4C3 File Offset: 0x002AD6C3
		[DebuggerNonUserCode]
		public void ClearMessage()
		{
			this.message_ = null;
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x002AF4D0 File Offset: 0x002AD6D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Data);
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x002AF4F0 File Offset: 0x002AD6F0
		[DebuggerNonUserCode]
		public bool Equals(Data other)
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
					bool flag4 = this.Lang != other.Lang;
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
							bool flag6 = this.Message != other.Message;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x002AF57C File Offset: 0x002AD77C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasLang = this.HasLang;
			if (hasLang)
			{
				num ^= this.Lang.GetHashCode();
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num ^= this.Message.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B083 RID: 45187 RVA: 0x002AF5FC File Offset: 0x002AD7FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B084 RID: 45188 RVA: 0x002AF614 File Offset: 0x002AD814
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x002AF620 File Offset: 0x002AD820
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasLang = this.HasLang;
			if (hasLang)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Lang);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Key);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x002AF6B0 File Offset: 0x002AD8B0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasLang = this.HasLang;
			if (hasLang)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Lang);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			bool hasMessage = this.HasMessage;
			if (hasMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Message);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x002AF73C File Offset: 0x002AD93C
		[DebuggerNonUserCode]
		public void MergeFrom(Data other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasLang = other.HasLang;
				if (hasLang)
				{
					this.Lang = other.Lang;
				}
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasMessage = other.HasMessage;
				if (hasMessage)
				{
					this.Message = other.Message;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x002AF7B7 File Offset: 0x002AD9B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x002AF7C4 File Offset: 0x002AD9C4
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
							this.Message = input.ReadString();
						}
					}
					else
					{
						this.Key = input.ReadString();
					}
				}
				else
				{
					this.Lang = input.ReadString();
				}
			}
		}

		// Token: 0x04004F99 RID: 20377
		private static readonly MessageParser<Data> _parser = new MessageParser<Data>(() => new Data());

		// Token: 0x04004F9A RID: 20378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F9B RID: 20379
		public const int LangFieldNumber = 1;

		// Token: 0x04004F9C RID: 20380
		private static readonly string LangDefaultValue = "";

		// Token: 0x04004F9D RID: 20381
		private string lang_;

		// Token: 0x04004F9E RID: 20382
		public const int KeyFieldNumber = 2;

		// Token: 0x04004F9F RID: 20383
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004FA0 RID: 20384
		private string key_;

		// Token: 0x04004FA1 RID: 20385
		public const int MessageFieldNumber = 3;

		// Token: 0x04004FA2 RID: 20386
		private static readonly string MessageDefaultValue = "";

		// Token: 0x04004FA3 RID: 20387
		private string message_;
	}
}

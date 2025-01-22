using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A4 RID: 420
	public sealed class NameText : IMessage<NameText>, IMessage, IEquatable<NameText>, IDeepCloneable<NameText>, IBufferMessage
	{
		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002C50 RID: 11344 RVA: 0x000AE248 File Offset: 0x000AC448
		[DebuggerNonUserCode]
		public static MessageParser<NameText> Parser
		{
			get
			{
				return NameText._parser;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000AE260 File Offset: 0x000AC460
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x000AE284 File Offset: 0x000AC484
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NameText.Descriptor;
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000AE29B File Offset: 0x000AC49B
		[DebuggerNonUserCode]
		public NameText()
		{
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000AE2A5 File Offset: 0x000AC4A5
		[DebuggerNonUserCode]
		public NameText(NameText other)
			: this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000AE2CC File Offset: 0x000AC4CC
		[DebuggerNonUserCode]
		public NameText Clone()
		{
			return new NameText(this);
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000AE2E4 File Offset: 0x000AC4E4
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x000AE305 File Offset: 0x000AC505
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? NameText.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000AE31C File Offset: 0x000AC51C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000AE337 File Offset: 0x000AC537
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000AE344 File Offset: 0x000AC544
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as NameText);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000AE364 File Offset: 0x000AC564
		[DebuggerNonUserCode]
		public bool Equals(NameText other)
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
					bool flag4 = this.Name != other.Name;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000AE3BC File Offset: 0x000AC5BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000AE408 File Offset: 0x000AC608
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000AE420 File Offset: 0x000AC620
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000AE42C File Offset: 0x000AC62C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000AE478 File Offset: 0x000AC678
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000AE4C8 File Offset: 0x000AC6C8
		[DebuggerNonUserCode]
		public void MergeFrom(NameText other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000AE511 File Offset: 0x000AC711
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x000AE51C File Offset: 0x000AC71C
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x0400140A RID: 5130
		private static readonly MessageParser<NameText> _parser = new MessageParser<NameText>(() => new NameText());

		// Token: 0x0400140B RID: 5131
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400140C RID: 5132
		public const int NameFieldNumber = 1;

		// Token: 0x0400140D RID: 5133
		private static readonly string NameDefaultValue = "";

		// Token: 0x0400140E RID: 5134
		private string name_;
	}
}

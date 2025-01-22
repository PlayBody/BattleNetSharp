using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F0 RID: 496
	public sealed class DebugDumpHeroMessage : IMessage<DebugDumpHeroMessage>, IMessage, IEquatable<DebugDumpHeroMessage>, IDeepCloneable<DebugDumpHeroMessage>, IBufferMessage
	{
		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000D61E8 File Offset: 0x000D43E8
		[DebuggerNonUserCode]
		public static MessageParser<DebugDumpHeroMessage> Parser
		{
			get
			{
				return DebugDumpHeroMessage._parser;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x000D6200 File Offset: 0x000D4400
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[53];
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x000D6224 File Offset: 0x000D4424
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugDumpHeroMessage.Descriptor;
			}
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x000D623B File Offset: 0x000D443B
		[DebuggerNonUserCode]
		public DebugDumpHeroMessage()
		{
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x000D6248 File Offset: 0x000D4448
		[DebuggerNonUserCode]
		public DebugDumpHeroMessage(DebugDumpHeroMessage other)
			: this()
		{
			this.name_ = other.name_;
			this.heroData_ = ((other.heroData_ != null) ? other.heroData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x000D6298 File Offset: 0x000D4498
		[DebuggerNonUserCode]
		public DebugDumpHeroMessage Clone()
		{
			return new DebugDumpHeroMessage(this);
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x000D62B0 File Offset: 0x000D44B0
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x000D62D1 File Offset: 0x000D44D1
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? DebugDumpHeroMessage.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x000D62E8 File Offset: 0x000D44E8
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000D6303 File Offset: 0x000D4503
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x000D6310 File Offset: 0x000D4510
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x000D6328 File Offset: 0x000D4528
		[DebuggerNonUserCode]
		public SavedDefinition HeroData
		{
			get
			{
				return this.heroData_;
			}
			set
			{
				this.heroData_ = value;
			}
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x000D6334 File Offset: 0x000D4534
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugDumpHeroMessage);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x000D6354 File Offset: 0x000D4554
		[DebuggerNonUserCode]
		public bool Equals(DebugDumpHeroMessage other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.HeroData, other.HeroData);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x000D63C8 File Offset: 0x000D45C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this.heroData_ != null;
			if (flag)
			{
				num ^= this.HeroData.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000D6430 File Offset: 0x000D4630
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x000D6448 File Offset: 0x000D4648
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000D6454 File Offset: 0x000D4654
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool flag = this.heroData_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.HeroData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x000D64C8 File Offset: 0x000D46C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this.heroData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroData);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x000D6538 File Offset: 0x000D4738
		[DebuggerNonUserCode]
		public void MergeFrom(DebugDumpHeroMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool flag2 = other.heroData_ != null;
				if (flag2)
				{
					bool flag3 = this.heroData_ == null;
					if (flag3)
					{
						this.HeroData = new SavedDefinition();
					}
					this.HeroData.MergeFrom(other.HeroData);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x000D65BD File Offset: 0x000D47BD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x000D65C8 File Offset: 0x000D47C8
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
						bool flag = this.heroData_ == null;
						if (flag)
						{
							this.HeroData = new SavedDefinition();
						}
						input.ReadMessage(this.HeroData);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04001921 RID: 6433
		private static readonly MessageParser<DebugDumpHeroMessage> _parser = new MessageParser<DebugDumpHeroMessage>(() => new DebugDumpHeroMessage());

		// Token: 0x04001922 RID: 6434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001923 RID: 6435
		public const int NameFieldNumber = 1;

		// Token: 0x04001924 RID: 6436
		private static readonly string NameDefaultValue = "";

		// Token: 0x04001925 RID: 6437
		private string name_;

		// Token: 0x04001926 RID: 6438
		public const int HeroDataFieldNumber = 2;

		// Token: 0x04001927 RID: 6439
		private SavedDefinition heroData_;
	}
}

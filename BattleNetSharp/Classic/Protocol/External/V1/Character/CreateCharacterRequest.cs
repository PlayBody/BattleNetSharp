using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A5 RID: 1957
	public sealed class CreateCharacterRequest : IMessage<CreateCharacterRequest>, IMessage, IEquatable<CreateCharacterRequest>, IDeepCloneable<CreateCharacterRequest>, IBufferMessage
	{
		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B38F RID: 45967 RVA: 0x002BB24C File Offset: 0x002B944C
		[DebuggerNonUserCode]
		public static MessageParser<CreateCharacterRequest> Parser
		{
			get
			{
				return CreateCharacterRequest._parser;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B390 RID: 45968 RVA: 0x002BB264 File Offset: 0x002B9464
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B391 RID: 45969 RVA: 0x002BB288 File Offset: 0x002B9488
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateCharacterRequest.Descriptor;
			}
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x002BB29F File Offset: 0x002B949F
		[DebuggerNonUserCode]
		public CreateCharacterRequest()
		{
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x002BB2AC File Offset: 0x002B94AC
		[DebuggerNonUserCode]
		public CreateCharacterRequest(CreateCharacterRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.name_ = other.name_;
			this.class_ = other.class_;
			this.flagsHcLadder_ = other.flagsHcLadder_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x002BB304 File Offset: 0x002B9504
		[DebuggerNonUserCode]
		public CreateCharacterRequest Clone()
		{
			return new CreateCharacterRequest(this);
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B395 RID: 45973 RVA: 0x002BB31C File Offset: 0x002B951C
		// (set) Token: 0x0600B396 RID: 45974 RVA: 0x002BB33D File Offset: 0x002B953D
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? CreateCharacterRequest.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x002BB354 File Offset: 0x002B9554
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x002BB36F File Offset: 0x002B956F
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B399 RID: 45977 RVA: 0x002BB37C File Offset: 0x002B957C
		// (set) Token: 0x0600B39A RID: 45978 RVA: 0x002BB3AD File Offset: 0x002B95AD
		[DebuggerNonUserCode]
		public int Class
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int classDefaultValue;
				if (flag)
				{
					classDefaultValue = this.class_;
				}
				else
				{
					classDefaultValue = CreateCharacterRequest.ClassDefaultValue;
				}
				return classDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.class_ = value;
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x002BB3C8 File Offset: 0x002B95C8
		[DebuggerNonUserCode]
		public bool HasClass
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x002BB3E5 File Offset: 0x002B95E5
		[DebuggerNonUserCode]
		public void ClearClass()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x002BB3F8 File Offset: 0x002B95F8
		// (set) Token: 0x0600B39E RID: 45982 RVA: 0x002BB429 File Offset: 0x002B9629
		[DebuggerNonUserCode]
		public int FlagsHcLadder
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int flagsHcLadderDefaultValue;
				if (flag)
				{
					flagsHcLadderDefaultValue = this.flagsHcLadder_;
				}
				else
				{
					flagsHcLadderDefaultValue = CreateCharacterRequest.FlagsHcLadderDefaultValue;
				}
				return flagsHcLadderDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.flagsHcLadder_ = value;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B39F RID: 45983 RVA: 0x002BB444 File Offset: 0x002B9644
		[DebuggerNonUserCode]
		public bool HasFlagsHcLadder
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x002BB461 File Offset: 0x002B9661
		[DebuggerNonUserCode]
		public void ClearFlagsHcLadder()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x002BB474 File Offset: 0x002B9674
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateCharacterRequest);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x002BB494 File Offset: 0x002B9694
		[DebuggerNonUserCode]
		public bool Equals(CreateCharacterRequest other)
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
						bool flag5 = this.Class != other.Class;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.FlagsHcLadder != other.FlagsHcLadder;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x002BB520 File Offset: 0x002B9720
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num ^= this.Class.GetHashCode();
			}
			bool hasFlagsHcLadder = this.HasFlagsHcLadder;
			if (hasFlagsHcLadder)
			{
				num ^= this.FlagsHcLadder.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x002BB5A8 File Offset: 0x002B97A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x002BB5C0 File Offset: 0x002B97C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x002BB5CC File Offset: 0x002B97CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Class);
			}
			bool hasFlagsHcLadder = this.HasFlagsHcLadder;
			if (hasFlagsHcLadder)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FlagsHcLadder);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x002BB65C File Offset: 0x002B985C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasClass = this.HasClass;
			if (hasClass)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Class);
			}
			bool hasFlagsHcLadder = this.HasFlagsHcLadder;
			if (hasFlagsHcLadder)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlagsHcLadder);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x002BB6E8 File Offset: 0x002B98E8
		[DebuggerNonUserCode]
		public void MergeFrom(CreateCharacterRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasClass = other.HasClass;
				if (hasClass)
				{
					this.Class = other.Class;
				}
				bool hasFlagsHcLadder = other.HasFlagsHcLadder;
				if (hasFlagsHcLadder)
				{
					this.FlagsHcLadder = other.FlagsHcLadder;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x002BB763 File Offset: 0x002B9963
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x002BB770 File Offset: 0x002B9970
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
							this.FlagsHcLadder = input.ReadInt32();
						}
					}
					else
					{
						this.Class = input.ReadInt32();
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04005133 RID: 20787
		private static readonly MessageParser<CreateCharacterRequest> _parser = new MessageParser<CreateCharacterRequest>(() => new CreateCharacterRequest());

		// Token: 0x04005134 RID: 20788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005135 RID: 20789
		private int _hasBits0;

		// Token: 0x04005136 RID: 20790
		public const int NameFieldNumber = 1;

		// Token: 0x04005137 RID: 20791
		private static readonly string NameDefaultValue = "";

		// Token: 0x04005138 RID: 20792
		private string name_;

		// Token: 0x04005139 RID: 20793
		public const int ClassFieldNumber = 2;

		// Token: 0x0400513A RID: 20794
		private static readonly int ClassDefaultValue = 0;

		// Token: 0x0400513B RID: 20795
		private int class_;

		// Token: 0x0400513C RID: 20796
		public const int FlagsHcLadderFieldNumber = 3;

		// Token: 0x0400513D RID: 20797
		private static readonly int FlagsHcLadderDefaultValue = 0;

		// Token: 0x0400513E RID: 20798
		private int flagsHcLadder_;
	}
}

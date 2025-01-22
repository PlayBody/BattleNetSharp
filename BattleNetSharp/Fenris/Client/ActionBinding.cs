using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Client
{
	// Token: 0x02000114 RID: 276
	public sealed class ActionBinding : IMessage<ActionBinding>, IMessage, IEquatable<ActionBinding>, IDeepCloneable<ActionBinding>, IBufferMessage
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0005E0FC File Offset: 0x0005C2FC
		[DebuggerNonUserCode]
		public static MessageParser<ActionBinding> Parser
		{
			get
			{
				return ActionBinding._parser;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0005E114 File Offset: 0x0005C314
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0005E138 File Offset: 0x0005C338
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionBinding.Descriptor;
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0005E14F File Offset: 0x0005C34F
		[DebuggerNonUserCode]
		public ActionBinding()
		{
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0005E15C File Offset: 0x0005C35C
		[DebuggerNonUserCode]
		public ActionBinding(ActionBinding other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key1_ = other.key1_;
			this.keyModifierFlags1_ = other.keyModifierFlags1_;
			this.key2_ = other.key2_;
			this.keyModifierFlags2_ = other.keyModifierFlags2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0005E1C0 File Offset: 0x0005C3C0
		[DebuggerNonUserCode]
		public ActionBinding Clone()
		{
			return new ActionBinding(this);
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0005E1D8 File Offset: 0x0005C3D8
		// (set) Token: 0x06001A27 RID: 6695 RVA: 0x0005E209 File Offset: 0x0005C409
		[DebuggerNonUserCode]
		public int Key1
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int key1DefaultValue;
				if (flag)
				{
					key1DefaultValue = this.key1_;
				}
				else
				{
					key1DefaultValue = ActionBinding.Key1DefaultValue;
				}
				return key1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.key1_ = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0005E224 File Offset: 0x0005C424
		[DebuggerNonUserCode]
		public bool HasKey1
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0005E241 File Offset: 0x0005C441
		[DebuggerNonUserCode]
		public void ClearKey1()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x0005E254 File Offset: 0x0005C454
		// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0005E285 File Offset: 0x0005C485
		[DebuggerNonUserCode]
		public uint KeyModifierFlags1
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint keyModifierFlags1DefaultValue;
				if (flag)
				{
					keyModifierFlags1DefaultValue = this.keyModifierFlags1_;
				}
				else
				{
					keyModifierFlags1DefaultValue = ActionBinding.KeyModifierFlags1DefaultValue;
				}
				return keyModifierFlags1DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.keyModifierFlags1_ = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x0005E2A0 File Offset: 0x0005C4A0
		[DebuggerNonUserCode]
		public bool HasKeyModifierFlags1
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0005E2BD File Offset: 0x0005C4BD
		[DebuggerNonUserCode]
		public void ClearKeyModifierFlags1()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0005E2D0 File Offset: 0x0005C4D0
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0005E301 File Offset: 0x0005C501
		[DebuggerNonUserCode]
		public int Key2
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int key2DefaultValue;
				if (flag)
				{
					key2DefaultValue = this.key2_;
				}
				else
				{
					key2DefaultValue = ActionBinding.Key2DefaultValue;
				}
				return key2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.key2_ = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0005E31C File Offset: 0x0005C51C
		[DebuggerNonUserCode]
		public bool HasKey2
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0005E339 File Offset: 0x0005C539
		[DebuggerNonUserCode]
		public void ClearKey2()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x0005E34C File Offset: 0x0005C54C
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0005E37D File Offset: 0x0005C57D
		[DebuggerNonUserCode]
		public uint KeyModifierFlags2
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				uint keyModifierFlags2DefaultValue;
				if (flag)
				{
					keyModifierFlags2DefaultValue = this.keyModifierFlags2_;
				}
				else
				{
					keyModifierFlags2DefaultValue = ActionBinding.KeyModifierFlags2DefaultValue;
				}
				return keyModifierFlags2DefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.keyModifierFlags2_ = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0005E398 File Offset: 0x0005C598
		[DebuggerNonUserCode]
		public bool HasKeyModifierFlags2
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0005E3B5 File Offset: 0x0005C5B5
		[DebuggerNonUserCode]
		public void ClearKeyModifierFlags2()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0005E3C8 File Offset: 0x0005C5C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionBinding);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
		[DebuggerNonUserCode]
		public bool Equals(ActionBinding other)
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
					bool flag4 = this.Key1 != other.Key1;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.KeyModifierFlags1 != other.KeyModifierFlags1;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Key2 != other.Key2;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.KeyModifierFlags2 != other.KeyModifierFlags2;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0005E494 File Offset: 0x0005C694
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey1;
			if (hasKey)
			{
				num ^= this.Key1.GetHashCode();
			}
			bool hasKeyModifierFlags = this.HasKeyModifierFlags1;
			if (hasKeyModifierFlags)
			{
				num ^= this.KeyModifierFlags1.GetHashCode();
			}
			bool hasKey2 = this.HasKey2;
			if (hasKey2)
			{
				num ^= this.Key2.GetHashCode();
			}
			bool hasKeyModifierFlags2 = this.HasKeyModifierFlags2;
			if (hasKeyModifierFlags2)
			{
				num ^= this.KeyModifierFlags2.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0005E53C File Offset: 0x0005C73C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0005E554 File Offset: 0x0005C754
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0005E560 File Offset: 0x0005C760
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey1;
			if (hasKey)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key1);
			}
			bool hasKeyModifierFlags = this.HasKeyModifierFlags1;
			if (hasKeyModifierFlags)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.KeyModifierFlags1);
			}
			bool hasKey2 = this.HasKey2;
			if (hasKey2)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Key2);
			}
			bool hasKeyModifierFlags2 = this.HasKeyModifierFlags2;
			if (hasKeyModifierFlags2)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.KeyModifierFlags2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0005E614 File Offset: 0x0005C814
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey1;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key1);
			}
			bool hasKeyModifierFlags = this.HasKeyModifierFlags1;
			if (hasKeyModifierFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KeyModifierFlags1);
			}
			bool hasKey2 = this.HasKey2;
			if (hasKey2)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key2);
			}
			bool hasKeyModifierFlags2 = this.HasKeyModifierFlags2;
			if (hasKeyModifierFlags2)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KeyModifierFlags2);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0005E6BC File Offset: 0x0005C8BC
		[DebuggerNonUserCode]
		public void MergeFrom(ActionBinding other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey1;
				if (hasKey)
				{
					this.Key1 = other.Key1;
				}
				bool hasKeyModifierFlags = other.HasKeyModifierFlags1;
				if (hasKeyModifierFlags)
				{
					this.KeyModifierFlags1 = other.KeyModifierFlags1;
				}
				bool hasKey2 = other.HasKey2;
				if (hasKey2)
				{
					this.Key2 = other.Key2;
				}
				bool hasKeyModifierFlags2 = other.HasKeyModifierFlags2;
				if (hasKeyModifierFlags2)
				{
					this.KeyModifierFlags2 = other.KeyModifierFlags2;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0005E752 File Offset: 0x0005C952
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0005E760 File Offset: 0x0005C960
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.KeyModifierFlags1 = input.ReadUInt32();
					}
					else
					{
						this.Key1 = input.ReadInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.KeyModifierFlags2 = input.ReadUInt32();
				}
				else
				{
					this.Key2 = input.ReadInt32();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A71 RID: 2673
		private static readonly MessageParser<ActionBinding> _parser = new MessageParser<ActionBinding>(() => new ActionBinding());

		// Token: 0x04000A72 RID: 2674
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A73 RID: 2675
		private int _hasBits0;

		// Token: 0x04000A74 RID: 2676
		public const int Key1FieldNumber = 1;

		// Token: 0x04000A75 RID: 2677
		private static readonly int Key1DefaultValue = -1;

		// Token: 0x04000A76 RID: 2678
		private int key1_;

		// Token: 0x04000A77 RID: 2679
		public const int KeyModifierFlags1FieldNumber = 2;

		// Token: 0x04000A78 RID: 2680
		private static readonly uint KeyModifierFlags1DefaultValue = 0U;

		// Token: 0x04000A79 RID: 2681
		private uint keyModifierFlags1_;

		// Token: 0x04000A7A RID: 2682
		public const int Key2FieldNumber = 3;

		// Token: 0x04000A7B RID: 2683
		private static readonly int Key2DefaultValue = -1;

		// Token: 0x04000A7C RID: 2684
		private int key2_;

		// Token: 0x04000A7D RID: 2685
		public const int KeyModifierFlags2FieldNumber = 4;

		// Token: 0x04000A7E RID: 2686
		private static readonly uint KeyModifierFlags2DefaultValue = 0U;

		// Token: 0x04000A7F RID: 2687
		private uint keyModifierFlags2_;
	}
}

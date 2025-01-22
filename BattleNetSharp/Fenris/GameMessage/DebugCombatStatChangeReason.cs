using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001DF RID: 479
	public sealed class DebugCombatStatChangeReason : IMessage<DebugCombatStatChangeReason>, IMessage, IEquatable<DebugCombatStatChangeReason>, IDeepCloneable<DebugCombatStatChangeReason>, IBufferMessage
	{
		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000CD48C File Offset: 0x000CB68C
		[DebuggerNonUserCode]
		public static MessageParser<DebugCombatStatChangeReason> Parser
		{
			get
			{
				return DebugCombatStatChangeReason._parser;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x000CD4A4 File Offset: 0x000CB6A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[36];
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x000CD4C8 File Offset: 0x000CB6C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugCombatStatChangeReason.Descriptor;
			}
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000CD4DF File Offset: 0x000CB6DF
		[DebuggerNonUserCode]
		public DebugCombatStatChangeReason()
		{
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000CD4EC File Offset: 0x000CB6EC
		[DebuggerNonUserCode]
		public DebugCombatStatChangeReason(DebugCombatStatChangeReason other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.type_ = other.type_;
			this.attribKey_ = other.attribKey_;
			this.description_ = other.description_;
			this.scriptPower_ = other.scriptPower_;
			this.scriptCallback_ = other.scriptCallback_;
			this.combatStat_ = other.combatStat_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000CD568 File Offset: 0x000CB768
		[DebuggerNonUserCode]
		public DebugCombatStatChangeReason Clone()
		{
			return new DebugCombatStatChangeReason(this);
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x000CD580 File Offset: 0x000CB780
		// (set) Token: 0x060033DF RID: 13279 RVA: 0x000CD5B1 File Offset: 0x000CB7B1
		[DebuggerNonUserCode]
		public int Type
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int typeDefaultValue;
				if (flag)
				{
					typeDefaultValue = this.type_;
				}
				else
				{
					typeDefaultValue = DebugCombatStatChangeReason.TypeDefaultValue;
				}
				return typeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.type_ = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x060033E0 RID: 13280 RVA: 0x000CD5CC File Offset: 0x000CB7CC
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000CD5E9 File Offset: 0x000CB7E9
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x000CD5FC File Offset: 0x000CB7FC
		// (set) Token: 0x060033E3 RID: 13283 RVA: 0x000CD62D File Offset: 0x000CB82D
		[DebuggerNonUserCode]
		public long AttribKey
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				long attribKeyDefaultValue;
				if (flag)
				{
					attribKeyDefaultValue = this.attribKey_;
				}
				else
				{
					attribKeyDefaultValue = DebugCombatStatChangeReason.AttribKeyDefaultValue;
				}
				return attribKeyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.attribKey_ = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x000CD648 File Offset: 0x000CB848
		[DebuggerNonUserCode]
		public bool HasAttribKey
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000CD665 File Offset: 0x000CB865
		[DebuggerNonUserCode]
		public void ClearAttribKey()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x000CD678 File Offset: 0x000CB878
		// (set) Token: 0x060033E7 RID: 13287 RVA: 0x000CD699 File Offset: 0x000CB899
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? DebugCombatStatChangeReason.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x000CD6B0 File Offset: 0x000CB8B0
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000CD6CB File Offset: 0x000CB8CB
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x000CD6D8 File Offset: 0x000CB8D8
		// (set) Token: 0x060033EB RID: 13291 RVA: 0x000CD709 File Offset: 0x000CB909
		[DebuggerNonUserCode]
		public int ScriptPower
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int scriptPowerDefaultValue;
				if (flag)
				{
					scriptPowerDefaultValue = this.scriptPower_;
				}
				else
				{
					scriptPowerDefaultValue = DebugCombatStatChangeReason.ScriptPowerDefaultValue;
				}
				return scriptPowerDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.scriptPower_ = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x000CD724 File Offset: 0x000CB924
		[DebuggerNonUserCode]
		public bool HasScriptPower
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000CD741 File Offset: 0x000CB941
		[DebuggerNonUserCode]
		public void ClearScriptPower()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x000CD754 File Offset: 0x000CB954
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x000CD775 File Offset: 0x000CB975
		[DebuggerNonUserCode]
		public string ScriptCallback
		{
			get
			{
				return this.scriptCallback_ ?? DebugCombatStatChangeReason.ScriptCallbackDefaultValue;
			}
			set
			{
				this.scriptCallback_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x000CD78C File Offset: 0x000CB98C
		[DebuggerNonUserCode]
		public bool HasScriptCallback
		{
			get
			{
				return this.scriptCallback_ != null;
			}
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000CD7A7 File Offset: 0x000CB9A7
		[DebuggerNonUserCode]
		public void ClearScriptCallback()
		{
			this.scriptCallback_ = null;
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x060033F2 RID: 13298 RVA: 0x000CD7B4 File Offset: 0x000CB9B4
		// (set) Token: 0x060033F3 RID: 13299 RVA: 0x000CD7E5 File Offset: 0x000CB9E5
		[DebuggerNonUserCode]
		public int CombatStat
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				int combatStatDefaultValue;
				if (flag)
				{
					combatStatDefaultValue = this.combatStat_;
				}
				else
				{
					combatStatDefaultValue = DebugCombatStatChangeReason.CombatStatDefaultValue;
				}
				return combatStatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.combatStat_ = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x000CD800 File Offset: 0x000CBA00
		[DebuggerNonUserCode]
		public bool HasCombatStat
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000CD81D File Offset: 0x000CBA1D
		[DebuggerNonUserCode]
		public void ClearCombatStat()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000CD830 File Offset: 0x000CBA30
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugCombatStatChangeReason);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000CD850 File Offset: 0x000CBA50
		[DebuggerNonUserCode]
		public bool Equals(DebugCombatStatChangeReason other)
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
					bool flag4 = this.Type != other.Type;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.AttribKey != other.AttribKey;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Description != other.Description;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ScriptPower != other.ScriptPower;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ScriptCallback != other.ScriptCallback;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.CombatStat != other.CombatStat;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000CD93C File Offset: 0x000CBB3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			bool hasAttribKey = this.HasAttribKey;
			if (hasAttribKey)
			{
				num ^= this.AttribKey.GetHashCode();
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool hasScriptPower = this.HasScriptPower;
			if (hasScriptPower)
			{
				num ^= this.ScriptPower.GetHashCode();
			}
			bool hasScriptCallback = this.HasScriptCallback;
			if (hasScriptCallback)
			{
				num ^= this.ScriptCallback.GetHashCode();
			}
			bool hasCombatStat = this.HasCombatStat;
			if (hasCombatStat)
			{
				num ^= this.CombatStat.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000CDA18 File Offset: 0x000CBC18
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x000CDA30 File Offset: 0x000CBC30
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000CDA3C File Offset: 0x000CBC3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			bool hasAttribKey = this.HasAttribKey;
			if (hasAttribKey)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.AttribKey);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Description);
			}
			bool hasScriptPower = this.HasScriptPower;
			if (hasScriptPower)
			{
				output.WriteRawTag(37);
				output.WriteSFixed32(this.ScriptPower);
			}
			bool hasScriptCallback = this.HasScriptCallback;
			if (hasScriptCallback)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ScriptCallback);
			}
			bool hasCombatStat = this.HasCombatStat;
			if (hasCombatStat)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CombatStat);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000CDB38 File Offset: 0x000CBD38
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			bool hasAttribKey = this.HasAttribKey;
			if (hasAttribKey)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AttribKey);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool hasScriptPower = this.HasScriptPower;
			if (hasScriptPower)
			{
				num += 5;
			}
			bool hasScriptCallback = this.HasScriptCallback;
			if (hasScriptCallback)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ScriptCallback);
			}
			bool hasCombatStat = this.HasCombatStat;
			if (hasCombatStat)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CombatStat);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000CDC10 File Offset: 0x000CBE10
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCombatStatChangeReason other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				bool hasAttribKey = other.HasAttribKey;
				if (hasAttribKey)
				{
					this.AttribKey = other.AttribKey;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				bool hasScriptPower = other.HasScriptPower;
				if (hasScriptPower)
				{
					this.ScriptPower = other.ScriptPower;
				}
				bool hasScriptCallback = other.HasScriptCallback;
				if (hasScriptCallback)
				{
					this.ScriptCallback = other.ScriptCallback;
				}
				bool hasCombatStat = other.HasCombatStat;
				if (hasCombatStat)
				{
					this.CombatStat = other.CombatStat;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000CDCDF File Offset: 0x000CBEDF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000CDCEC File Offset: 0x000CBEEC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 26U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							if (num3 != 26U)
							{
								goto IL_0039;
							}
							this.Description = input.ReadString();
						}
						else
						{
							this.AttribKey = input.ReadInt64();
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else if (num3 != 37U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0039;
						}
						this.CombatStat = input.ReadInt32();
					}
					else
					{
						this.ScriptCallback = input.ReadString();
					}
				}
				else
				{
					this.ScriptPower = input.ReadSFixed32();
				}
				continue;
				IL_0039:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040017F3 RID: 6131
		private static readonly MessageParser<DebugCombatStatChangeReason> _parser = new MessageParser<DebugCombatStatChangeReason>(() => new DebugCombatStatChangeReason());

		// Token: 0x040017F4 RID: 6132
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017F5 RID: 6133
		private int _hasBits0;

		// Token: 0x040017F6 RID: 6134
		public const int TypeFieldNumber = 1;

		// Token: 0x040017F7 RID: 6135
		private static readonly int TypeDefaultValue = 0;

		// Token: 0x040017F8 RID: 6136
		private int type_;

		// Token: 0x040017F9 RID: 6137
		public const int AttribKeyFieldNumber = 2;

		// Token: 0x040017FA RID: 6138
		private static readonly long AttribKeyDefaultValue = 0L;

		// Token: 0x040017FB RID: 6139
		private long attribKey_;

		// Token: 0x040017FC RID: 6140
		public const int DescriptionFieldNumber = 3;

		// Token: 0x040017FD RID: 6141
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x040017FE RID: 6142
		private string description_;

		// Token: 0x040017FF RID: 6143
		public const int ScriptPowerFieldNumber = 4;

		// Token: 0x04001800 RID: 6144
		private static readonly int ScriptPowerDefaultValue = 0;

		// Token: 0x04001801 RID: 6145
		private int scriptPower_;

		// Token: 0x04001802 RID: 6146
		public const int ScriptCallbackFieldNumber = 5;

		// Token: 0x04001803 RID: 6147
		private static readonly string ScriptCallbackDefaultValue = "";

		// Token: 0x04001804 RID: 6148
		private string scriptCallback_;

		// Token: 0x04001805 RID: 6149
		public const int CombatStatFieldNumber = 6;

		// Token: 0x04001806 RID: 6150
		private static readonly int CombatStatDefaultValue = 0;

		// Token: 0x04001807 RID: 6151
		private int combatStat_;
	}
}

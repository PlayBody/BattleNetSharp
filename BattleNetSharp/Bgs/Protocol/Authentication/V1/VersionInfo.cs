using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000610 RID: 1552
	public sealed class VersionInfo : IMessage<VersionInfo>, IMessage, IEquatable<VersionInfo>, IDeepCloneable<VersionInfo>, IBufferMessage
	{
		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x00234028 File Offset: 0x00232228
		[DebuggerNonUserCode]
		public static MessageParser<VersionInfo> Parser
		{
			get
			{
				return VersionInfo._parser;
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x0600916B RID: 37227 RVA: 0x00234040 File Offset: 0x00232240
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x00234064 File Offset: 0x00232264
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VersionInfo.Descriptor;
			}
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x0023407B File Offset: 0x0023227B
		[DebuggerNonUserCode]
		public VersionInfo()
		{
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x00234088 File Offset: 0x00232288
		[DebuggerNonUserCode]
		public VersionInfo(VersionInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.number_ = other.number_;
			this.patch_ = other.patch_;
			this.isOptional_ = other.isOptional_;
			this.kickTime_ = other.kickTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x002340EC File Offset: 0x002322EC
		[DebuggerNonUserCode]
		public VersionInfo Clone()
		{
			return new VersionInfo(this);
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06009170 RID: 37232 RVA: 0x00234104 File Offset: 0x00232304
		// (set) Token: 0x06009171 RID: 37233 RVA: 0x00234135 File Offset: 0x00232335
		[DebuggerNonUserCode]
		public uint Number
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint numberDefaultValue;
				if (flag)
				{
					numberDefaultValue = this.number_;
				}
				else
				{
					numberDefaultValue = VersionInfo.NumberDefaultValue;
				}
				return numberDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.number_ = value;
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06009172 RID: 37234 RVA: 0x00234150 File Offset: 0x00232350
		[DebuggerNonUserCode]
		public bool HasNumber
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x0023416D File Offset: 0x0023236D
		[DebuggerNonUserCode]
		public void ClearNumber()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x00234180 File Offset: 0x00232380
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x002341A1 File Offset: 0x002323A1
		[DebuggerNonUserCode]
		public string Patch
		{
			get
			{
				return this.patch_ ?? VersionInfo.PatchDefaultValue;
			}
			set
			{
				this.patch_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x002341B8 File Offset: 0x002323B8
		[DebuggerNonUserCode]
		public bool HasPatch
		{
			get
			{
				return this.patch_ != null;
			}
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x002341D3 File Offset: 0x002323D3
		[DebuggerNonUserCode]
		public void ClearPatch()
		{
			this.patch_ = null;
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x002341E0 File Offset: 0x002323E0
		// (set) Token: 0x06009179 RID: 37241 RVA: 0x00234211 File Offset: 0x00232411
		[DebuggerNonUserCode]
		public bool IsOptional
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isOptionalDefaultValue;
				if (flag)
				{
					isOptionalDefaultValue = this.isOptional_;
				}
				else
				{
					isOptionalDefaultValue = VersionInfo.IsOptionalDefaultValue;
				}
				return isOptionalDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isOptional_ = value;
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x0023422C File Offset: 0x0023242C
		[DebuggerNonUserCode]
		public bool HasIsOptional
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x00234249 File Offset: 0x00232449
		[DebuggerNonUserCode]
		public void ClearIsOptional()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x0023425C File Offset: 0x0023245C
		// (set) Token: 0x0600917D RID: 37245 RVA: 0x0023428D File Offset: 0x0023248D
		[DebuggerNonUserCode]
		public ulong KickTime
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong kickTimeDefaultValue;
				if (flag)
				{
					kickTimeDefaultValue = this.kickTime_;
				}
				else
				{
					kickTimeDefaultValue = VersionInfo.KickTimeDefaultValue;
				}
				return kickTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.kickTime_ = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x002342A8 File Offset: 0x002324A8
		[DebuggerNonUserCode]
		public bool HasKickTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x002342C5 File Offset: 0x002324C5
		[DebuggerNonUserCode]
		public void ClearKickTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x002342D8 File Offset: 0x002324D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VersionInfo);
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x002342F8 File Offset: 0x002324F8
		[DebuggerNonUserCode]
		public bool Equals(VersionInfo other)
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
					bool flag4 = this.Number != other.Number;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Patch != other.Patch;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.IsOptional != other.IsOptional;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.KickTime != other.KickTime;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x002343A4 File Offset: 0x002325A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasNumber = this.HasNumber;
			if (hasNumber)
			{
				num ^= this.Number.GetHashCode();
			}
			bool hasPatch = this.HasPatch;
			if (hasPatch)
			{
				num ^= this.Patch.GetHashCode();
			}
			bool hasIsOptional = this.HasIsOptional;
			if (hasIsOptional)
			{
				num ^= this.IsOptional.GetHashCode();
			}
			bool hasKickTime = this.HasKickTime;
			if (hasKickTime)
			{
				num ^= this.KickTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x0023444C File Offset: 0x0023264C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x00234464 File Offset: 0x00232664
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x00234470 File Offset: 0x00232670
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasNumber = this.HasNumber;
			if (hasNumber)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Number);
			}
			bool hasPatch = this.HasPatch;
			if (hasPatch)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Patch);
			}
			bool hasIsOptional = this.HasIsOptional;
			if (hasIsOptional)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOptional);
			}
			bool hasKickTime = this.HasKickTime;
			if (hasKickTime)
			{
				output.WriteRawTag(32);
				output.WriteUInt64(this.KickTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00234524 File Offset: 0x00232724
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasNumber = this.HasNumber;
			if (hasNumber)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Number);
			}
			bool hasPatch = this.HasPatch;
			if (hasPatch)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Patch);
			}
			bool hasIsOptional = this.HasIsOptional;
			if (hasIsOptional)
			{
				num += 2;
			}
			bool hasKickTime = this.HasKickTime;
			if (hasKickTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.KickTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x002345C0 File Offset: 0x002327C0
		[DebuggerNonUserCode]
		public void MergeFrom(VersionInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasNumber = other.HasNumber;
				if (hasNumber)
				{
					this.Number = other.Number;
				}
				bool hasPatch = other.HasPatch;
				if (hasPatch)
				{
					this.Patch = other.Patch;
				}
				bool hasIsOptional = other.HasIsOptional;
				if (hasIsOptional)
				{
					this.IsOptional = other.IsOptional;
				}
				bool hasKickTime = other.HasKickTime;
				if (hasKickTime)
				{
					this.KickTime = other.KickTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x00234656 File Offset: 0x00232856
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009189 RID: 37257 RVA: 0x00234664 File Offset: 0x00232864
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 8U)
					{
						if (num3 != 18U)
						{
							goto IL_0028;
						}
						this.Patch = input.ReadString();
					}
					else
					{
						this.Number = input.ReadUInt32();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 32U)
					{
						goto IL_0028;
					}
					this.KickTime = input.ReadUInt64();
				}
				else
				{
					this.IsOptional = input.ReadBool();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041AA RID: 16810
		private static readonly MessageParser<VersionInfo> _parser = new MessageParser<VersionInfo>(() => new VersionInfo());

		// Token: 0x040041AB RID: 16811
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041AC RID: 16812
		private int _hasBits0;

		// Token: 0x040041AD RID: 16813
		public const int NumberFieldNumber = 1;

		// Token: 0x040041AE RID: 16814
		private static readonly uint NumberDefaultValue = 0U;

		// Token: 0x040041AF RID: 16815
		private uint number_;

		// Token: 0x040041B0 RID: 16816
		public const int PatchFieldNumber = 2;

		// Token: 0x040041B1 RID: 16817
		private static readonly string PatchDefaultValue = "";

		// Token: 0x040041B2 RID: 16818
		private string patch_;

		// Token: 0x040041B3 RID: 16819
		public const int IsOptionalFieldNumber = 3;

		// Token: 0x040041B4 RID: 16820
		private static readonly bool IsOptionalDefaultValue = false;

		// Token: 0x040041B5 RID: 16821
		private bool isOptional_;

		// Token: 0x040041B6 RID: 16822
		public const int KickTimeFieldNumber = 4;

		// Token: 0x040041B7 RID: 16823
		private static readonly ulong KickTimeDefaultValue = 0UL;

		// Token: 0x040041B8 RID: 16824
		private ulong kickTime_;
	}
}

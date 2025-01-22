using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003F RID: 63
	public sealed class SetLANServerMode : IMessage<SetLANServerMode>, IMessage, IEquatable<SetLANServerMode>, IDeepCloneable<SetLANServerMode>, IBufferMessage
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001798C File Offset: 0x00015B8C
		[DebuggerNonUserCode]
		public static MessageParser<SetLANServerMode> Parser
		{
			get
			{
				return SetLANServerMode._parser;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x000179A4 File Offset: 0x00015BA4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[40];
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000179C8 File Offset: 0x00015BC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetLANServerMode.Descriptor;
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000179DF File Offset: 0x00015BDF
		[DebuggerNonUserCode]
		public SetLANServerMode()
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000179E9 File Offset: 0x00015BE9
		[DebuggerNonUserCode]
		public SetLANServerMode(SetLANServerMode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this.snoWorld_ = other.snoWorld_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00017A28 File Offset: 0x00015C28
		[DebuggerNonUserCode]
		public SetLANServerMode Clone()
		{
			return new SetLANServerMode(this);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00017A40 File Offset: 0x00015C40
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00017A71 File Offset: 0x00015C71
		[DebuggerNonUserCode]
		public bool Enabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool enabledDefaultValue;
				if (flag)
				{
					enabledDefaultValue = this.enabled_;
				}
				else
				{
					enabledDefaultValue = SetLANServerMode.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00017A8C File Offset: 0x00015C8C
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00017AA9 File Offset: 0x00015CA9
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00017ABC File Offset: 0x00015CBC
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00017AED File Offset: 0x00015CED
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = SetLANServerMode.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00017B08 File Offset: 0x00015D08
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00017B25 File Offset: 0x00015D25
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00017B38 File Offset: 0x00015D38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetLANServerMode);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00017B58 File Offset: 0x00015D58
		[DebuggerNonUserCode]
		public bool Equals(SetLANServerMode other)
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
					bool flag4 = this.Enabled != other.Enabled;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoWorld != other.SnoWorld;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00017BCC File Offset: 0x00015DCC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00017C3C File Offset: 0x00015E3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00017C54 File Offset: 0x00015E54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00017C60 File Offset: 0x00015E60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoWorld);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00017CD0 File Offset: 0x00015ED0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num += 2;
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00017D30 File Offset: 0x00015F30
		[DebuggerNonUserCode]
		public void MergeFrom(SetLANServerMode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00017D92 File Offset: 0x00015F92
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00017DA0 File Offset: 0x00015FA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SnoWorld = input.ReadInt32();
					}
				}
				else
				{
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x04000214 RID: 532
		private static readonly MessageParser<SetLANServerMode> _parser = new MessageParser<SetLANServerMode>(() => new SetLANServerMode());

		// Token: 0x04000215 RID: 533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000216 RID: 534
		private int _hasBits0;

		// Token: 0x04000217 RID: 535
		public const int EnabledFieldNumber = 1;

		// Token: 0x04000218 RID: 536
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x04000219 RID: 537
		private bool enabled_;

		// Token: 0x0400021A RID: 538
		public const int SnoWorldFieldNumber = 2;

		// Token: 0x0400021B RID: 539
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x0400021C RID: 540
		private int snoWorld_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003D RID: 61
	public sealed class SetGameMode : IMessage<SetGameMode>, IMessage, IEquatable<SetGameMode>, IDeepCloneable<SetGameMode>, IBufferMessage
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00016C60 File Offset: 0x00014E60
		[DebuggerNonUserCode]
		public static MessageParser<SetGameMode> Parser
		{
			get
			{
				return SetGameMode._parser;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00016C78 File Offset: 0x00014E78
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[38];
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00016C9C File Offset: 0x00014E9C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGameMode.Descriptor;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00016CB3 File Offset: 0x00014EB3
		[DebuggerNonUserCode]
		public SetGameMode()
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00016CC0 File Offset: 0x00014EC0
		[DebuggerNonUserCode]
		public SetGameMode(SetGameMode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requestedMode_ = other.requestedMode_;
			this.snoWorld_ = other.snoWorld_;
			this.gameParts_ = other.gameParts_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00016D18 File Offset: 0x00014F18
		[DebuggerNonUserCode]
		public SetGameMode Clone()
		{
			return new SetGameMode(this);
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00016D30 File Offset: 0x00014F30
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00016D61 File Offset: 0x00014F61
		[DebuggerNonUserCode]
		public int RequestedMode
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int requestedModeDefaultValue;
				if (flag)
				{
					requestedModeDefaultValue = this.requestedMode_;
				}
				else
				{
					requestedModeDefaultValue = SetGameMode.RequestedModeDefaultValue;
				}
				return requestedModeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.requestedMode_ = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00016D7C File Offset: 0x00014F7C
		[DebuggerNonUserCode]
		public bool HasRequestedMode
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00016D99 File Offset: 0x00014F99
		[DebuggerNonUserCode]
		public void ClearRequestedMode()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00016DAC File Offset: 0x00014FAC
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00016DDD File Offset: 0x00014FDD
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
					snoWorldDefaultValue = SetGameMode.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00016DF8 File Offset: 0x00014FF8
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00016E15 File Offset: 0x00015015
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00016E28 File Offset: 0x00015028
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00016E59 File Offset: 0x00015059
		[DebuggerNonUserCode]
		public int GameParts
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int gamePartsDefaultValue;
				if (flag)
				{
					gamePartsDefaultValue = this.gameParts_;
				}
				else
				{
					gamePartsDefaultValue = SetGameMode.GamePartsDefaultValue;
				}
				return gamePartsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.gameParts_ = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00016E74 File Offset: 0x00015074
		[DebuggerNonUserCode]
		public bool HasGameParts
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00016E91 File Offset: 0x00015091
		[DebuggerNonUserCode]
		public void ClearGameParts()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00016EA4 File Offset: 0x000150A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGameMode);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00016EC4 File Offset: 0x000150C4
		[DebuggerNonUserCode]
		public bool Equals(SetGameMode other)
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
					bool flag4 = this.RequestedMode != other.RequestedMode;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoWorld != other.SnoWorld;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameParts != other.GameParts;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00016F50 File Offset: 0x00015150
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				num ^= this.RequestedMode.GetHashCode();
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasGameParts = this.HasGameParts;
			if (hasGameParts)
			{
				num ^= this.GameParts.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00016FDC File Offset: 0x000151DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00016FF4 File Offset: 0x000151F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00017000 File Offset: 0x00015200
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RequestedMode);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoWorld);
			}
			bool hasGameParts = this.HasGameParts;
			if (hasGameParts)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GameParts);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00017090 File Offset: 0x00015290
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasRequestedMode = this.HasRequestedMode;
			if (hasRequestedMode)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequestedMode);
			}
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool hasGameParts = this.HasGameParts;
			if (hasGameParts)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GameParts);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001711C File Offset: 0x0001531C
		[DebuggerNonUserCode]
		public void MergeFrom(SetGameMode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasRequestedMode = other.HasRequestedMode;
				if (hasRequestedMode)
				{
					this.RequestedMode = other.RequestedMode;
				}
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasGameParts = other.HasGameParts;
				if (hasGameParts)
				{
					this.GameParts = other.GameParts;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00017197 File Offset: 0x00015397
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000171A4 File Offset: 0x000153A4
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GameParts = input.ReadInt32();
						}
					}
					else
					{
						this.SnoWorld = input.ReadInt32();
					}
				}
				else
				{
					this.RequestedMode = input.ReadInt32();
				}
			}
		}

		// Token: 0x040001FB RID: 507
		private static readonly MessageParser<SetGameMode> _parser = new MessageParser<SetGameMode>(() => new SetGameMode());

		// Token: 0x040001FC RID: 508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001FD RID: 509
		private int _hasBits0;

		// Token: 0x040001FE RID: 510
		public const int RequestedModeFieldNumber = 1;

		// Token: 0x040001FF RID: 511
		private static readonly int RequestedModeDefaultValue = 0;

		// Token: 0x04000200 RID: 512
		private int requestedMode_;

		// Token: 0x04000201 RID: 513
		public const int SnoWorldFieldNumber = 2;

		// Token: 0x04000202 RID: 514
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04000203 RID: 515
		private int snoWorld_;

		// Token: 0x04000204 RID: 516
		public const int GamePartsFieldNumber = 3;

		// Token: 0x04000205 RID: 517
		private static readonly int GamePartsDefaultValue = 0;

		// Token: 0x04000206 RID: 518
		private int gameParts_;
	}
}

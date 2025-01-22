using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200003E RID: 62
	public sealed class ReloadGameMode : IMessage<ReloadGameMode>, IMessage, IEquatable<ReloadGameMode>, IDeepCloneable<ReloadGameMode>, IBufferMessage
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00017250 File Offset: 0x00015450
		[DebuggerNonUserCode]
		public static MessageParser<ReloadGameMode> Parser
		{
			get
			{
				return ReloadGameMode._parser;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00017268 File Offset: 0x00015468
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[39];
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001728C File Offset: 0x0001548C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReloadGameMode.Descriptor;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000172A3 File Offset: 0x000154A3
		[DebuggerNonUserCode]
		public ReloadGameMode()
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000172B0 File Offset: 0x000154B0
		[DebuggerNonUserCode]
		public ReloadGameMode(ReloadGameMode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.snoSubzone_ = other.snoSubzone_;
			this.cameraOrientation_ = ((other.cameraOrientation_ != null) ? other.cameraOrientation_.Clone() : null);
			this.playerPosition_ = ((other.playerPosition_ != null) ? other.playerPosition_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00017334 File Offset: 0x00015534
		[DebuggerNonUserCode]
		public ReloadGameMode Clone()
		{
			return new ReloadGameMode(this);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0001734C File Offset: 0x0001554C
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x0001737D File Offset: 0x0001557D
		[DebuggerNonUserCode]
		public int SnoWorld
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoWorldDefaultValue;
				if (flag)
				{
					snoWorldDefaultValue = this.snoWorld_;
				}
				else
				{
					snoWorldDefaultValue = ReloadGameMode.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00017398 File Offset: 0x00015598
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000173B5 File Offset: 0x000155B5
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000173C8 File Offset: 0x000155C8
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x000173F9 File Offset: 0x000155F9
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = ReloadGameMode.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00017414 File Offset: 0x00015614
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00017431 File Offset: 0x00015631
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00017444 File Offset: 0x00015644
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0001745C File Offset: 0x0001565C
		[DebuggerNonUserCode]
		public Quaternion CameraOrientation
		{
			get
			{
				return this.cameraOrientation_;
			}
			set
			{
				this.cameraOrientation_ = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00017468 File Offset: 0x00015668
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00017480 File Offset: 0x00015680
		[DebuggerNonUserCode]
		public Vector3 PlayerPosition
		{
			get
			{
				return this.playerPosition_;
			}
			set
			{
				this.playerPosition_ = value;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001748C File Offset: 0x0001568C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReloadGameMode);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000174AC File Offset: 0x000156AC
		[DebuggerNonUserCode]
		public bool Equals(ReloadGameMode other)
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
					bool flag4 = this.SnoWorld != other.SnoWorld;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SnoSubzone != other.SnoSubzone;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.CameraOrientation, other.CameraOrientation);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.PlayerPosition, other.PlayerPosition);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00017560 File Offset: 0x00015760
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num ^= this.SnoWorld.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this.cameraOrientation_ != null;
			if (flag)
			{
				num ^= this.CameraOrientation.GetHashCode();
			}
			bool flag2 = this.playerPosition_ != null;
			if (flag2)
			{
				num ^= this.PlayerPosition.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00017608 File Offset: 0x00015808
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00017620 File Offset: 0x00015820
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001762C File Offset: 0x0001582C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoWorld);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SnoSubzone);
			}
			bool flag = this.cameraOrientation_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CameraOrientation);
			}
			bool flag2 = this.playerPosition_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PlayerPosition);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000176E8 File Offset: 0x000158E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoWorld = this.HasSnoWorld;
			if (hasSnoWorld)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoWorld);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool flag = this.cameraOrientation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraOrientation);
			}
			bool flag2 = this.playerPosition_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerPosition);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00017798 File Offset: 0x00015998
		[DebuggerNonUserCode]
		public void MergeFrom(ReloadGameMode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoWorld = other.HasSnoWorld;
				if (hasSnoWorld)
				{
					this.SnoWorld = other.SnoWorld;
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool flag2 = other.cameraOrientation_ != null;
				if (flag2)
				{
					bool flag3 = this.cameraOrientation_ == null;
					if (flag3)
					{
						this.CameraOrientation = new Quaternion();
					}
					this.CameraOrientation.MergeFrom(other.CameraOrientation);
				}
				bool flag4 = other.playerPosition_ != null;
				if (flag4)
				{
					bool flag5 = this.playerPosition_ == null;
					if (flag5)
					{
						this.PlayerPosition = new Vector3();
					}
					this.PlayerPosition.MergeFrom(other.PlayerPosition);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001787B File Offset: 0x00015A7B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00017888 File Offset: 0x00015A88
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
							goto IL_002B;
						}
						this.SnoSubzone = input.ReadInt32();
					}
					else
					{
						this.SnoWorld = input.ReadInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002B;
					}
					bool flag = this.playerPosition_ == null;
					if (flag)
					{
						this.PlayerPosition = new Vector3();
					}
					input.ReadMessage(this.PlayerPosition);
				}
				else
				{
					bool flag2 = this.cameraOrientation_ == null;
					if (flag2)
					{
						this.CameraOrientation = new Quaternion();
					}
					input.ReadMessage(this.CameraOrientation);
				}
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000207 RID: 519
		private static readonly MessageParser<ReloadGameMode> _parser = new MessageParser<ReloadGameMode>(() => new ReloadGameMode());

		// Token: 0x04000208 RID: 520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000209 RID: 521
		private int _hasBits0;

		// Token: 0x0400020A RID: 522
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x0400020B RID: 523
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x0400020C RID: 524
		private int snoWorld_;

		// Token: 0x0400020D RID: 525
		public const int SnoSubzoneFieldNumber = 2;

		// Token: 0x0400020E RID: 526
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x0400020F RID: 527
		private int snoSubzone_;

		// Token: 0x04000210 RID: 528
		public const int CameraOrientationFieldNumber = 3;

		// Token: 0x04000211 RID: 529
		private Quaternion cameraOrientation_;

		// Token: 0x04000212 RID: 530
		public const int PlayerPositionFieldNumber = 4;

		// Token: 0x04000213 RID: 531
		private Vector3 playerPosition_;
	}
}

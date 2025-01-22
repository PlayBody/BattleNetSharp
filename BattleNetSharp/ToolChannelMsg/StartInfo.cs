using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000037 RID: 55
	public sealed class StartInfo : IMessage<StartInfo>, IMessage, IEquatable<StartInfo>, IDeepCloneable<StartInfo>, IBufferMessage
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00013AF4 File Offset: 0x00011CF4
		[DebuggerNonUserCode]
		public static MessageParser<StartInfo> Parser
		{
			get
			{
				return StartInfo._parser;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00013B0C File Offset: 0x00011D0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00013B30 File Offset: 0x00011D30
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartInfo.Descriptor;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00013B47 File Offset: 0x00011D47
		[DebuggerNonUserCode]
		public StartInfo()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00013B54 File Offset: 0x00011D54
		[DebuggerNonUserCode]
		public StartInfo(StartInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.startLocation_ = ((other.startLocation_ != null) ? other.startLocation_.Clone() : null);
			this.startOrientation_ = ((other.startOrientation_ != null) ? other.startOrientation_.Clone() : null);
			this.snoSubzone_ = other.snoSubzone_;
			this.snoScene_ = other.snoScene_;
			this.marker_ = other.marker_;
			this.seed_ = other.seed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[DebuggerNonUserCode]
		public StartInfo Clone()
		{
			return new StartInfo(this);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00013C08 File Offset: 0x00011E08
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00013C20 File Offset: 0x00011E20
		[DebuggerNonUserCode]
		public Vector3 StartLocation
		{
			get
			{
				return this.startLocation_;
			}
			set
			{
				this.startLocation_ = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00013C2C File Offset: 0x00011E2C
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00013C44 File Offset: 0x00011E44
		[DebuggerNonUserCode]
		public Quaternion StartOrientation
		{
			get
			{
				return this.startOrientation_;
			}
			set
			{
				this.startOrientation_ = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00013C50 File Offset: 0x00011E50
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00013C81 File Offset: 0x00011E81
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = StartInfo.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00013C9C File Offset: 0x00011E9C
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00013CB9 File Offset: 0x00011EB9
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00013CCC File Offset: 0x00011ECC
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00013CFD File Offset: 0x00011EFD
		[DebuggerNonUserCode]
		public int SnoScene
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int snoSceneDefaultValue;
				if (flag)
				{
					snoSceneDefaultValue = this.snoScene_;
				}
				else
				{
					snoSceneDefaultValue = StartInfo.SnoSceneDefaultValue;
				}
				return snoSceneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoScene_ = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00013D18 File Offset: 0x00011F18
		[DebuggerNonUserCode]
		public bool HasSnoScene
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00013D35 File Offset: 0x00011F35
		[DebuggerNonUserCode]
		public void ClearSnoScene()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00013D48 File Offset: 0x00011F48
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00013D69 File Offset: 0x00011F69
		[DebuggerNonUserCode]
		public string Marker
		{
			get
			{
				return this.marker_ ?? StartInfo.MarkerDefaultValue;
			}
			set
			{
				this.marker_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00013D80 File Offset: 0x00011F80
		[DebuggerNonUserCode]
		public bool HasMarker
		{
			get
			{
				return this.marker_ != null;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00013D9B File Offset: 0x00011F9B
		[DebuggerNonUserCode]
		public void ClearMarker()
		{
			this.marker_ = null;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00013DA8 File Offset: 0x00011FA8
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00013DD9 File Offset: 0x00011FD9
		[DebuggerNonUserCode]
		public int Seed
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int seedDefaultValue;
				if (flag)
				{
					seedDefaultValue = this.seed_;
				}
				else
				{
					seedDefaultValue = StartInfo.SeedDefaultValue;
				}
				return seedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.seed_ = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00013DF4 File Offset: 0x00011FF4
		[DebuggerNonUserCode]
		public bool HasSeed
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00013E11 File Offset: 0x00012011
		[DebuggerNonUserCode]
		public void ClearSeed()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00013E24 File Offset: 0x00012024
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartInfo);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00013E44 File Offset: 0x00012044
		[DebuggerNonUserCode]
		public bool Equals(StartInfo other)
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
					bool flag4 = !object.Equals(this.StartLocation, other.StartLocation);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.StartOrientation, other.StartOrientation);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnoSubzone != other.SnoSubzone;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.SnoScene != other.SnoScene;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Marker != other.Marker;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Seed != other.Seed;
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

		// Token: 0x060003FD RID: 1021 RVA: 0x00013F34 File Offset: 0x00012134
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.startLocation_ != null;
			if (flag)
			{
				num ^= this.StartLocation.GetHashCode();
			}
			bool flag2 = this.startOrientation_ != null;
			if (flag2)
			{
				num ^= this.StartOrientation.GetHashCode();
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				num ^= this.SnoScene.GetHashCode();
			}
			bool hasMarker = this.HasMarker;
			if (hasMarker)
			{
				num ^= this.Marker.GetHashCode();
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num ^= this.Seed.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00014014 File Offset: 0x00012214
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001402C File Offset: 0x0001222C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00014038 File Offset: 0x00012238
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.startLocation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.StartLocation);
			}
			bool flag2 = this.startOrientation_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.StartOrientation);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SnoSubzone);
			}
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SnoScene);
			}
			bool hasMarker = this.HasMarker;
			if (hasMarker)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Marker);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Seed);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001413C File Offset: 0x0001233C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.startLocation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StartLocation);
			}
			bool flag2 = this.startOrientation_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StartOrientation);
			}
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoScene);
			}
			bool hasMarker = this.HasMarker;
			if (hasMarker)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Marker);
			}
			bool hasSeed = this.HasSeed;
			if (hasSeed)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Seed);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00014228 File Offset: 0x00012428
		[DebuggerNonUserCode]
		public void MergeFrom(StartInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.startLocation_ != null;
				if (flag2)
				{
					bool flag3 = this.startLocation_ == null;
					if (flag3)
					{
						this.StartLocation = new Vector3();
					}
					this.StartLocation.MergeFrom(other.StartLocation);
				}
				bool flag4 = other.startOrientation_ != null;
				if (flag4)
				{
					bool flag5 = this.startOrientation_ == null;
					if (flag5)
					{
						this.StartOrientation = new Quaternion();
					}
					this.StartOrientation.MergeFrom(other.StartOrientation);
				}
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasSnoScene = other.HasSnoScene;
				if (hasSnoScene)
				{
					this.SnoScene = other.SnoScene;
				}
				bool hasMarker = other.HasMarker;
				if (hasMarker)
				{
					this.Marker = other.Marker;
				}
				bool hasSeed = other.HasSeed;
				if (hasSeed)
				{
					this.Seed = other.Seed;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00014341 File Offset: 0x00012541
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001434C File Offset: 0x0001254C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 24U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							if (num3 != 24U)
							{
								goto IL_0046;
							}
							this.SnoSubzone = input.ReadInt32();
						}
						else
						{
							bool flag = this.startOrientation_ == null;
							if (flag)
							{
								this.StartOrientation = new Quaternion();
							}
							input.ReadMessage(this.StartOrientation);
						}
					}
					else
					{
						bool flag2 = this.startLocation_ == null;
						if (flag2)
						{
							this.StartLocation = new Vector3();
						}
						input.ReadMessage(this.StartLocation);
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_0046;
						}
						this.Seed = input.ReadInt32();
					}
					else
					{
						this.Marker = input.ReadString();
					}
				}
				else
				{
					this.SnoScene = input.ReadInt32();
				}
				continue;
				IL_0046:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000196 RID: 406
		private static readonly MessageParser<StartInfo> _parser = new MessageParser<StartInfo>(() => new StartInfo());

		// Token: 0x04000197 RID: 407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000198 RID: 408
		private int _hasBits0;

		// Token: 0x04000199 RID: 409
		public const int StartLocationFieldNumber = 1;

		// Token: 0x0400019A RID: 410
		private Vector3 startLocation_;

		// Token: 0x0400019B RID: 411
		public const int StartOrientationFieldNumber = 2;

		// Token: 0x0400019C RID: 412
		private Quaternion startOrientation_;

		// Token: 0x0400019D RID: 413
		public const int SnoSubzoneFieldNumber = 3;

		// Token: 0x0400019E RID: 414
		private static readonly int SnoSubzoneDefaultValue = -1;

		// Token: 0x0400019F RID: 415
		private int snoSubzone_;

		// Token: 0x040001A0 RID: 416
		public const int SnoSceneFieldNumber = 4;

		// Token: 0x040001A1 RID: 417
		private static readonly int SnoSceneDefaultValue = 0;

		// Token: 0x040001A2 RID: 418
		private int snoScene_;

		// Token: 0x040001A3 RID: 419
		public const int MarkerFieldNumber = 5;

		// Token: 0x040001A4 RID: 420
		private static readonly string MarkerDefaultValue = "";

		// Token: 0x040001A5 RID: 421
		private string marker_;

		// Token: 0x040001A6 RID: 422
		public const int SeedFieldNumber = 6;

		// Token: 0x040001A7 RID: 423
		private static readonly int SeedDefaultValue = 0;

		// Token: 0x040001A8 RID: 424
		private int seed_;
	}
}

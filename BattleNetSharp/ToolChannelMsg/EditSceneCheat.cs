using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000EA RID: 234
	public sealed class EditSceneCheat : IMessage<EditSceneCheat>, IMessage, IEquatable<EditSceneCheat>, IDeepCloneable<EditSceneCheat>, IBufferMessage
	{
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0005226C File Offset: 0x0005046C
		[DebuggerNonUserCode]
		public static MessageParser<EditSceneCheat> Parser
		{
			get
			{
				return EditSceneCheat._parser;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00052284 File Offset: 0x00050484
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[211];
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000522AC File Offset: 0x000504AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EditSceneCheat.Descriptor;
			}
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x000522C3 File Offset: 0x000504C3
		[DebuggerNonUserCode]
		public EditSceneCheat()
		{
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000522D0 File Offset: 0x000504D0
		[DebuggerNonUserCode]
		public EditSceneCheat(EditSceneCheat other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoScene_ = other.snoScene_;
			this.cameraPos_ = ((other.cameraPos_ != null) ? other.cameraPos_.Clone() : null);
			this.cameraYpr_ = ((other.cameraYpr_ != null) ? other.cameraYpr_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00052348 File Offset: 0x00050548
		[DebuggerNonUserCode]
		public EditSceneCheat Clone()
		{
			return new EditSceneCheat(this);
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00052360 File Offset: 0x00050560
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x00052391 File Offset: 0x00050591
		[DebuggerNonUserCode]
		public int SnoScene
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSceneDefaultValue;
				if (flag)
				{
					snoSceneDefaultValue = this.snoScene_;
				}
				else
				{
					snoSceneDefaultValue = EditSceneCheat.SnoSceneDefaultValue;
				}
				return snoSceneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoScene_ = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000523AC File Offset: 0x000505AC
		[DebuggerNonUserCode]
		public bool HasSnoScene
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x000523C9 File Offset: 0x000505C9
		[DebuggerNonUserCode]
		public void ClearSnoScene()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000523DC File Offset: 0x000505DC
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x000523F4 File Offset: 0x000505F4
		[DebuggerNonUserCode]
		public Vector3 CameraPos
		{
			get
			{
				return this.cameraPos_;
			}
			set
			{
				this.cameraPos_ = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00052400 File Offset: 0x00050600
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x00052418 File Offset: 0x00050618
		[DebuggerNonUserCode]
		public Vector3 CameraYpr
		{
			get
			{
				return this.cameraYpr_;
			}
			set
			{
				this.cameraYpr_ = value;
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00052424 File Offset: 0x00050624
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EditSceneCheat);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00052444 File Offset: 0x00050644
		[DebuggerNonUserCode]
		public bool Equals(EditSceneCheat other)
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
					bool flag4 = this.SnoScene != other.SnoScene;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CameraPos, other.CameraPos);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.CameraYpr, other.CameraYpr);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000524D8 File Offset: 0x000506D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				num ^= this.SnoScene.GetHashCode();
			}
			bool flag = this.cameraPos_ != null;
			if (flag)
			{
				num ^= this.CameraPos.GetHashCode();
			}
			bool flag2 = this.cameraYpr_ != null;
			if (flag2)
			{
				num ^= this.CameraYpr.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00052564 File Offset: 0x00050764
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0005257C File Offset: 0x0005077C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00052588 File Offset: 0x00050788
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoScene);
			}
			bool flag = this.cameraPos_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CameraPos);
			}
			bool flag2 = this.cameraYpr_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CameraYpr);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00052620 File Offset: 0x00050820
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoScene = this.HasSnoScene;
			if (hasSnoScene)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoScene);
			}
			bool flag = this.cameraPos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraPos);
			}
			bool flag2 = this.cameraYpr_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CameraYpr);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x000526B0 File Offset: 0x000508B0
		[DebuggerNonUserCode]
		public void MergeFrom(EditSceneCheat other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoScene = other.HasSnoScene;
				if (hasSnoScene)
				{
					this.SnoScene = other.SnoScene;
				}
				bool flag2 = other.cameraPos_ != null;
				if (flag2)
				{
					bool flag3 = this.cameraPos_ == null;
					if (flag3)
					{
						this.CameraPos = new Vector3();
					}
					this.CameraPos.MergeFrom(other.CameraPos);
				}
				bool flag4 = other.cameraYpr_ != null;
				if (flag4)
				{
					bool flag5 = this.cameraYpr_ == null;
					if (flag5)
					{
						this.CameraYpr = new Vector3();
					}
					this.CameraYpr.MergeFrom(other.CameraYpr);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00052778 File Offset: 0x00050978
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00052784 File Offset: 0x00050984
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
					if (num3 != 18U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.cameraYpr_ == null;
							if (flag)
							{
								this.CameraYpr = new Vector3();
							}
							input.ReadMessage(this.CameraYpr);
						}
					}
					else
					{
						bool flag2 = this.cameraPos_ == null;
						if (flag2)
						{
							this.CameraPos = new Vector3();
						}
						input.ReadMessage(this.CameraPos);
					}
				}
				else
				{
					this.SnoScene = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000938 RID: 2360
		private static readonly MessageParser<EditSceneCheat> _parser = new MessageParser<EditSceneCheat>(() => new EditSceneCheat());

		// Token: 0x04000939 RID: 2361
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400093A RID: 2362
		private int _hasBits0;

		// Token: 0x0400093B RID: 2363
		public const int SnoSceneFieldNumber = 1;

		// Token: 0x0400093C RID: 2364
		private static readonly int SnoSceneDefaultValue = 0;

		// Token: 0x0400093D RID: 2365
		private int snoScene_;

		// Token: 0x0400093E RID: 2366
		public const int CameraPosFieldNumber = 2;

		// Token: 0x0400093F RID: 2367
		private Vector3 cameraPos_;

		// Token: 0x04000940 RID: 2368
		public const int CameraYprFieldNumber = 3;

		// Token: 0x04000941 RID: 2369
		private Vector3 cameraYpr_;
	}
}

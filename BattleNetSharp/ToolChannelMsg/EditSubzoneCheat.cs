using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000EB RID: 235
	public sealed class EditSubzoneCheat : IMessage<EditSubzoneCheat>, IMessage, IEquatable<EditSubzoneCheat>, IDeepCloneable<EditSubzoneCheat>, IBufferMessage
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00052864 File Offset: 0x00050A64
		[DebuggerNonUserCode]
		public static MessageParser<EditSubzoneCheat> Parser
		{
			get
			{
				return EditSubzoneCheat._parser;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0005287C File Offset: 0x00050A7C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[212];
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x000528A4 File Offset: 0x00050AA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EditSubzoneCheat.Descriptor;
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000528BB File Offset: 0x00050ABB
		[DebuggerNonUserCode]
		public EditSubzoneCheat()
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000528C8 File Offset: 0x00050AC8
		[DebuggerNonUserCode]
		public EditSubzoneCheat(EditSubzoneCheat other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoWorld_ = other.snoWorld_;
			this.snoSubzone_ = other.snoSubzone_;
			this.cameraPos_ = ((other.cameraPos_ != null) ? other.cameraPos_.Clone() : null);
			this.cameraYpr_ = ((other.cameraYpr_ != null) ? other.cameraYpr_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x0005294C File Offset: 0x00050B4C
		[DebuggerNonUserCode]
		public EditSubzoneCheat Clone()
		{
			return new EditSubzoneCheat(this);
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00052964 File Offset: 0x00050B64
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x00052995 File Offset: 0x00050B95
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
					snoWorldDefaultValue = EditSubzoneCheat.SnoWorldDefaultValue;
				}
				return snoWorldDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoWorld_ = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x000529B0 File Offset: 0x00050BB0
		[DebuggerNonUserCode]
		public bool HasSnoWorld
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000529CD File Offset: 0x00050BCD
		[DebuggerNonUserCode]
		public void ClearSnoWorld()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x000529E0 File Offset: 0x00050BE0
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x00052A11 File Offset: 0x00050C11
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
					snoSubzoneDefaultValue = EditSubzoneCheat.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00052A2C File Offset: 0x00050C2C
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00052A49 File Offset: 0x00050C49
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00052A5C File Offset: 0x00050C5C
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x00052A74 File Offset: 0x00050C74
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

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00052A80 File Offset: 0x00050C80
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x00052A98 File Offset: 0x00050C98
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

		// Token: 0x060016D3 RID: 5843 RVA: 0x00052AA4 File Offset: 0x00050CA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EditSubzoneCheat);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00052AC4 File Offset: 0x00050CC4
		[DebuggerNonUserCode]
		public bool Equals(EditSubzoneCheat other)
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
							bool flag6 = !object.Equals(this.CameraPos, other.CameraPos);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.CameraYpr, other.CameraYpr);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00052B78 File Offset: 0x00050D78
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

		// Token: 0x060016D6 RID: 5846 RVA: 0x00052C20 File Offset: 0x00050E20
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00052C38 File Offset: 0x00050E38
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00052C44 File Offset: 0x00050E44
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
			bool flag = this.cameraPos_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CameraPos);
			}
			bool flag2 = this.cameraYpr_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CameraYpr);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00052D00 File Offset: 0x00050F00
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

		// Token: 0x060016DA RID: 5850 RVA: 0x00052DB0 File Offset: 0x00050FB0
		[DebuggerNonUserCode]
		public void MergeFrom(EditSubzoneCheat other)
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

		// Token: 0x060016DB RID: 5851 RVA: 0x00052E93 File Offset: 0x00051093
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00052EA0 File Offset: 0x000510A0
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
					bool flag = this.cameraYpr_ == null;
					if (flag)
					{
						this.CameraYpr = new Vector3();
					}
					input.ReadMessage(this.CameraYpr);
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
				continue;
				IL_002B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000942 RID: 2370
		private static readonly MessageParser<EditSubzoneCheat> _parser = new MessageParser<EditSubzoneCheat>(() => new EditSubzoneCheat());

		// Token: 0x04000943 RID: 2371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000944 RID: 2372
		private int _hasBits0;

		// Token: 0x04000945 RID: 2373
		public const int SnoWorldFieldNumber = 1;

		// Token: 0x04000946 RID: 2374
		private static readonly int SnoWorldDefaultValue = 0;

		// Token: 0x04000947 RID: 2375
		private int snoWorld_;

		// Token: 0x04000948 RID: 2376
		public const int SnoSubzoneFieldNumber = 2;

		// Token: 0x04000949 RID: 2377
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x0400094A RID: 2378
		private int snoSubzone_;

		// Token: 0x0400094B RID: 2379
		public const int CameraPosFieldNumber = 3;

		// Token: 0x0400094C RID: 2380
		private Vector3 cameraPos_;

		// Token: 0x0400094D RID: 2381
		public const int CameraYprFieldNumber = 4;

		// Token: 0x0400094E RID: 2382
		private Vector3 cameraYpr_;
	}
}

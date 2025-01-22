using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000097 RID: 151
	public sealed class UITreeNode : IMessage<UITreeNode>, IMessage, IEquatable<UITreeNode>, IDeepCloneable<UITreeNode>, IBufferMessage
	{
		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000339E0 File Offset: 0x00031BE0
		[DebuggerNonUserCode]
		public static MessageParser<UITreeNode> Parser
		{
			get
			{
				return UITreeNode._parser;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000339F8 File Offset: 0x00031BF8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[128];
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00033A20 File Offset: 0x00031C20
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UITreeNode.Descriptor;
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00033A37 File Offset: 0x00031C37
		[DebuggerNonUserCode]
		public UITreeNode()
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00033A4C File Offset: 0x00031C4C
		[DebuggerNonUserCode]
		public UITreeNode(UITreeNode other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this.id_ = other.id_;
			this.controlType_ = other.controlType_;
			this.active_ = other.active_;
			this.isVisualControl_ = other.isVisualControl_;
			this.isTemplateInstance_ = other.isTemplateInstance_;
			this.isScopedId_ = other.isScopedId_;
			this.childNodes_ = other.childNodes_.Clone();
			this.absolutePos_ = ((other.absolutePos_ != null) ? other.absolutePos_.Clone() : null);
			this.relativePos_ = ((other.relativePos_ != null) ? other.relativePos_.Clone() : null);
			this.dim_ = ((other.dim_ != null) ? other.dim_.Clone() : null);
			this.clipRect_ = ((other.clipRect_ != null) ? other.clipRect_.Clone() : null);
			this.breakpointFlags_ = other.breakpointFlags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00033B60 File Offset: 0x00031D60
		[DebuggerNonUserCode]
		public UITreeNode Clone()
		{
			return new UITreeNode(this);
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00033B78 File Offset: 0x00031D78
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00033BA9 File Offset: 0x00031DA9
		[DebuggerNonUserCode]
		public ulong Hash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong hashDefaultValue;
				if (flag)
				{
					hashDefaultValue = this.hash_;
				}
				else
				{
					hashDefaultValue = UITreeNode.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00033BC4 File Offset: 0x00031DC4
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00033BE1 File Offset: 0x00031DE1
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00033BF4 File Offset: 0x00031DF4
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00033C15 File Offset: 0x00031E15
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? UITreeNode.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00033C2C File Offset: 0x00031E2C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00033C47 File Offset: 0x00031E47
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00033C54 File Offset: 0x00031E54
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00033C75 File Offset: 0x00031E75
		[DebuggerNonUserCode]
		public string ControlType
		{
			get
			{
				return this.controlType_ ?? UITreeNode.ControlTypeDefaultValue;
			}
			set
			{
				this.controlType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00033C8C File Offset: 0x00031E8C
		[DebuggerNonUserCode]
		public bool HasControlType
		{
			get
			{
				return this.controlType_ != null;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00033CA7 File Offset: 0x00031EA7
		[DebuggerNonUserCode]
		public void ClearControlType()
		{
			this.controlType_ = null;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00033CB4 File Offset: 0x00031EB4
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00033CE5 File Offset: 0x00031EE5
		[DebuggerNonUserCode]
		public bool Active
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool activeDefaultValue;
				if (flag)
				{
					activeDefaultValue = this.active_;
				}
				else
				{
					activeDefaultValue = UITreeNode.ActiveDefaultValue;
				}
				return activeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.active_ = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00033D00 File Offset: 0x00031F00
		[DebuggerNonUserCode]
		public bool HasActive
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00033D1D File Offset: 0x00031F1D
		[DebuggerNonUserCode]
		public void ClearActive()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00033D30 File Offset: 0x00031F30
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00033D61 File Offset: 0x00031F61
		[DebuggerNonUserCode]
		public bool IsVisualControl
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool isVisualControlDefaultValue;
				if (flag)
				{
					isVisualControlDefaultValue = this.isVisualControl_;
				}
				else
				{
					isVisualControlDefaultValue = UITreeNode.IsVisualControlDefaultValue;
				}
				return isVisualControlDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isVisualControl_ = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00033D7C File Offset: 0x00031F7C
		[DebuggerNonUserCode]
		public bool HasIsVisualControl
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00033D99 File Offset: 0x00031F99
		[DebuggerNonUserCode]
		public void ClearIsVisualControl()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00033DAC File Offset: 0x00031FAC
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x00033DDD File Offset: 0x00031FDD
		[DebuggerNonUserCode]
		public bool IsTemplateInstance
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool isTemplateInstanceDefaultValue;
				if (flag)
				{
					isTemplateInstanceDefaultValue = this.isTemplateInstance_;
				}
				else
				{
					isTemplateInstanceDefaultValue = UITreeNode.IsTemplateInstanceDefaultValue;
				}
				return isTemplateInstanceDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.isTemplateInstance_ = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00033DF8 File Offset: 0x00031FF8
		[DebuggerNonUserCode]
		public bool HasIsTemplateInstance
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00033E15 File Offset: 0x00032015
		[DebuggerNonUserCode]
		public void ClearIsTemplateInstance()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00033E28 File Offset: 0x00032028
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00033E5A File Offset: 0x0003205A
		[DebuggerNonUserCode]
		public bool IsScopedId
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool isScopedIdDefaultValue;
				if (flag)
				{
					isScopedIdDefaultValue = this.isScopedId_;
				}
				else
				{
					isScopedIdDefaultValue = UITreeNode.IsScopedIdDefaultValue;
				}
				return isScopedIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isScopedId_ = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00033E74 File Offset: 0x00032074
		[DebuggerNonUserCode]
		public bool HasIsScopedId
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00033E92 File Offset: 0x00032092
		[DebuggerNonUserCode]
		public void ClearIsScopedId()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00033EA4 File Offset: 0x000320A4
		[DebuggerNonUserCode]
		public RepeatedField<UITreeNode> ChildNodes
		{
			get
			{
				return this.childNodes_;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00033EBC File Offset: 0x000320BC
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00033ED4 File Offset: 0x000320D4
		[DebuggerNonUserCode]
		public Vector2 AbsolutePos
		{
			get
			{
				return this.absolutePos_;
			}
			set
			{
				this.absolutePos_ = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00033EE0 File Offset: 0x000320E0
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00033EF8 File Offset: 0x000320F8
		[DebuggerNonUserCode]
		public Vector2 RelativePos
		{
			get
			{
				return this.relativePos_;
			}
			set
			{
				this.relativePos_ = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00033F04 File Offset: 0x00032104
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00033F1C File Offset: 0x0003211C
		[DebuggerNonUserCode]
		public Vector2 Dim
		{
			get
			{
				return this.dim_;
			}
			set
			{
				this.dim_ = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00033F28 File Offset: 0x00032128
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00033F40 File Offset: 0x00032140
		[DebuggerNonUserCode]
		public Rect2D ClipRect
		{
			get
			{
				return this.clipRect_;
			}
			set
			{
				this.clipRect_ = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00033F4C File Offset: 0x0003214C
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00033F7E File Offset: 0x0003217E
		[DebuggerNonUserCode]
		public uint BreakpointFlags
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				uint breakpointFlagsDefaultValue;
				if (flag)
				{
					breakpointFlagsDefaultValue = this.breakpointFlags_;
				}
				else
				{
					breakpointFlagsDefaultValue = UITreeNode.BreakpointFlagsDefaultValue;
				}
				return breakpointFlagsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.breakpointFlags_ = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00033F98 File Offset: 0x00032198
		[DebuggerNonUserCode]
		public bool HasBreakpointFlags
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00033FB6 File Offset: 0x000321B6
		[DebuggerNonUserCode]
		public void ClearBreakpointFlags()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00033FC8 File Offset: 0x000321C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UITreeNode);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00033FE8 File Offset: 0x000321E8
		[DebuggerNonUserCode]
		public bool Equals(UITreeNode other)
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
					bool flag4 = this.Hash != other.Hash;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.ControlType != other.ControlType;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Active != other.Active;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsVisualControl != other.IsVisualControl;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.IsTemplateInstance != other.IsTemplateInstance;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.IsScopedId != other.IsScopedId;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = !this.childNodes_.Equals(other.childNodes_);
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.AbsolutePos, other.AbsolutePos);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.RelativePos, other.RelativePos);
														if (flag13)
														{
															flag2 = false;
														}
														else
														{
															bool flag14 = !object.Equals(this.Dim, other.Dim);
															if (flag14)
															{
																flag2 = false;
															}
															else
															{
																bool flag15 = !object.Equals(this.ClipRect, other.ClipRect);
																if (flag15)
																{
																	flag2 = false;
																}
																else
																{
																	bool flag16 = this.BreakpointFlags != other.BreakpointFlags;
																	flag2 = !flag16 && object.Equals(this._unknownFields, other._unknownFields);
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000341B4 File Offset: 0x000323B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasControlType = this.HasControlType;
			if (hasControlType)
			{
				num ^= this.ControlType.GetHashCode();
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num ^= this.Active.GetHashCode();
			}
			bool hasIsVisualControl = this.HasIsVisualControl;
			if (hasIsVisualControl)
			{
				num ^= this.IsVisualControl.GetHashCode();
			}
			bool hasIsTemplateInstance = this.HasIsTemplateInstance;
			if (hasIsTemplateInstance)
			{
				num ^= this.IsTemplateInstance.GetHashCode();
			}
			bool hasIsScopedId = this.HasIsScopedId;
			if (hasIsScopedId)
			{
				num ^= this.IsScopedId.GetHashCode();
			}
			num ^= this.childNodes_.GetHashCode();
			bool flag = this.absolutePos_ != null;
			if (flag)
			{
				num ^= this.AbsolutePos.GetHashCode();
			}
			bool flag2 = this.relativePos_ != null;
			if (flag2)
			{
				num ^= this.RelativePos.GetHashCode();
			}
			bool flag3 = this.dim_ != null;
			if (flag3)
			{
				num ^= this.Dim.GetHashCode();
			}
			bool flag4 = this.clipRect_ != null;
			if (flag4)
			{
				num ^= this.ClipRect.GetHashCode();
			}
			bool hasBreakpointFlags = this.HasBreakpointFlags;
			if (hasBreakpointFlags)
			{
				num ^= this.BreakpointFlags.GetHashCode();
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00034350 File Offset: 0x00032550
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00034368 File Offset: 0x00032568
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00034374 File Offset: 0x00032574
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Hash);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Id);
			}
			bool hasControlType = this.HasControlType;
			if (hasControlType)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ControlType);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Active);
			}
			bool hasIsVisualControl = this.HasIsVisualControl;
			if (hasIsVisualControl)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsVisualControl);
			}
			bool hasIsTemplateInstance = this.HasIsTemplateInstance;
			if (hasIsTemplateInstance)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsTemplateInstance);
			}
			bool hasIsScopedId = this.HasIsScopedId;
			if (hasIsScopedId)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsScopedId);
			}
			this.childNodes_.WriteTo(ref output, UITreeNode._repeated_childNodes_codec);
			bool flag = this.absolutePos_ != null;
			if (flag)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.AbsolutePos);
			}
			bool flag2 = this.relativePos_ != null;
			if (flag2)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RelativePos);
			}
			bool flag3 = this.dim_ != null;
			if (flag3)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Dim);
			}
			bool flag4 = this.clipRect_ != null;
			if (flag4)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ClipRect);
			}
			bool hasBreakpointFlags = this.HasBreakpointFlags;
			if (hasBreakpointFlags)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.BreakpointFlags);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00034568 File Offset: 0x00032768
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Hash);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasControlType = this.HasControlType;
			if (hasControlType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ControlType);
			}
			bool hasActive = this.HasActive;
			if (hasActive)
			{
				num += 2;
			}
			bool hasIsVisualControl = this.HasIsVisualControl;
			if (hasIsVisualControl)
			{
				num += 2;
			}
			bool hasIsTemplateInstance = this.HasIsTemplateInstance;
			if (hasIsTemplateInstance)
			{
				num += 2;
			}
			bool hasIsScopedId = this.HasIsScopedId;
			if (hasIsScopedId)
			{
				num += 2;
			}
			num += this.childNodes_.CalculateSize(UITreeNode._repeated_childNodes_codec);
			bool flag = this.absolutePos_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AbsolutePos);
			}
			bool flag2 = this.relativePos_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelativePos);
			}
			bool flag3 = this.dim_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Dim);
			}
			bool flag4 = this.clipRect_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClipRect);
			}
			bool hasBreakpointFlags = this.HasBreakpointFlags;
			if (hasBreakpointFlags)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BreakpointFlags);
			}
			bool flag5 = this._unknownFields != null;
			if (flag5)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000346F0 File Offset: 0x000328F0
		[DebuggerNonUserCode]
		public void MergeFrom(UITreeNode other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasControlType = other.HasControlType;
				if (hasControlType)
				{
					this.ControlType = other.ControlType;
				}
				bool hasActive = other.HasActive;
				if (hasActive)
				{
					this.Active = other.Active;
				}
				bool hasIsVisualControl = other.HasIsVisualControl;
				if (hasIsVisualControl)
				{
					this.IsVisualControl = other.IsVisualControl;
				}
				bool hasIsTemplateInstance = other.HasIsTemplateInstance;
				if (hasIsTemplateInstance)
				{
					this.IsTemplateInstance = other.IsTemplateInstance;
				}
				bool hasIsScopedId = other.HasIsScopedId;
				if (hasIsScopedId)
				{
					this.IsScopedId = other.IsScopedId;
				}
				this.childNodes_.Add(other.childNodes_);
				bool flag2 = other.absolutePos_ != null;
				if (flag2)
				{
					bool flag3 = this.absolutePos_ == null;
					if (flag3)
					{
						this.AbsolutePos = new Vector2();
					}
					this.AbsolutePos.MergeFrom(other.AbsolutePos);
				}
				bool flag4 = other.relativePos_ != null;
				if (flag4)
				{
					bool flag5 = this.relativePos_ == null;
					if (flag5)
					{
						this.RelativePos = new Vector2();
					}
					this.RelativePos.MergeFrom(other.RelativePos);
				}
				bool flag6 = other.dim_ != null;
				if (flag6)
				{
					bool flag7 = this.dim_ == null;
					if (flag7)
					{
						this.Dim = new Vector2();
					}
					this.Dim.MergeFrom(other.Dim);
				}
				bool flag8 = other.clipRect_ != null;
				if (flag8)
				{
					bool flag9 = this.clipRect_ == null;
					if (flag9)
					{
						this.ClipRect = new Rect2D();
					}
					this.ClipRect.MergeFrom(other.ClipRect);
				}
				bool hasBreakpointFlags = other.HasBreakpointFlags;
				if (hasBreakpointFlags)
				{
					this.BreakpointFlags = other.BreakpointFlags;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00034907 File Offset: 0x00032B07
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00034914 File Offset: 0x00032B14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 48U)
				{
					if (num3 <= 26U)
					{
						if (num3 != 8U)
						{
							if (num3 != 18U)
							{
								if (num3 != 26U)
								{
									goto IL_00A0;
								}
								this.ControlType = input.ReadString();
							}
							else
							{
								this.Id = input.ReadString();
							}
						}
						else
						{
							this.Hash = input.ReadUInt64();
						}
					}
					else if (num3 != 32U)
					{
						if (num3 != 40U)
						{
							if (num3 != 48U)
							{
								goto IL_00A0;
							}
							this.IsTemplateInstance = input.ReadBool();
						}
						else
						{
							this.IsVisualControl = input.ReadBool();
						}
					}
					else
					{
						this.Active = input.ReadBool();
					}
				}
				else if (num3 <= 74U)
				{
					if (num3 != 56U)
					{
						if (num3 != 66U)
						{
							if (num3 != 74U)
							{
								goto IL_00A0;
							}
							bool flag = this.absolutePos_ == null;
							if (flag)
							{
								this.AbsolutePos = new Vector2();
							}
							input.ReadMessage(this.AbsolutePos);
						}
						else
						{
							this.childNodes_.AddEntriesFrom(ref input, UITreeNode._repeated_childNodes_codec);
						}
					}
					else
					{
						this.IsScopedId = input.ReadBool();
					}
				}
				else if (num3 <= 90U)
				{
					if (num3 != 82U)
					{
						if (num3 != 90U)
						{
							goto IL_00A0;
						}
						bool flag2 = this.dim_ == null;
						if (flag2)
						{
							this.Dim = new Vector2();
						}
						input.ReadMessage(this.Dim);
					}
					else
					{
						bool flag3 = this.relativePos_ == null;
						if (flag3)
						{
							this.RelativePos = new Vector2();
						}
						input.ReadMessage(this.RelativePos);
					}
				}
				else if (num3 != 98U)
				{
					if (num3 != 104U)
					{
						goto IL_00A0;
					}
					this.BreakpointFlags = input.ReadUInt32();
				}
				else
				{
					bool flag4 = this.clipRect_ == null;
					if (flag4)
					{
						this.ClipRect = new Rect2D();
					}
					input.ReadMessage(this.ClipRect);
				}
				continue;
				IL_00A0:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400057D RID: 1405
		private static readonly MessageParser<UITreeNode> _parser = new MessageParser<UITreeNode>(() => new UITreeNode());

		// Token: 0x0400057E RID: 1406
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400057F RID: 1407
		private int _hasBits0;

		// Token: 0x04000580 RID: 1408
		public const int HashFieldNumber = 1;

		// Token: 0x04000581 RID: 1409
		private static readonly ulong HashDefaultValue = 0UL;

		// Token: 0x04000582 RID: 1410
		private ulong hash_;

		// Token: 0x04000583 RID: 1411
		public const int IdFieldNumber = 2;

		// Token: 0x04000584 RID: 1412
		private static readonly string IdDefaultValue = "";

		// Token: 0x04000585 RID: 1413
		private string id_;

		// Token: 0x04000586 RID: 1414
		public const int ControlTypeFieldNumber = 3;

		// Token: 0x04000587 RID: 1415
		private static readonly string ControlTypeDefaultValue = "";

		// Token: 0x04000588 RID: 1416
		private string controlType_;

		// Token: 0x04000589 RID: 1417
		public const int ActiveFieldNumber = 4;

		// Token: 0x0400058A RID: 1418
		private static readonly bool ActiveDefaultValue = false;

		// Token: 0x0400058B RID: 1419
		private bool active_;

		// Token: 0x0400058C RID: 1420
		public const int IsVisualControlFieldNumber = 5;

		// Token: 0x0400058D RID: 1421
		private static readonly bool IsVisualControlDefaultValue = false;

		// Token: 0x0400058E RID: 1422
		private bool isVisualControl_;

		// Token: 0x0400058F RID: 1423
		public const int IsTemplateInstanceFieldNumber = 6;

		// Token: 0x04000590 RID: 1424
		private static readonly bool IsTemplateInstanceDefaultValue = false;

		// Token: 0x04000591 RID: 1425
		private bool isTemplateInstance_;

		// Token: 0x04000592 RID: 1426
		public const int IsScopedIdFieldNumber = 7;

		// Token: 0x04000593 RID: 1427
		private static readonly bool IsScopedIdDefaultValue = false;

		// Token: 0x04000594 RID: 1428
		private bool isScopedId_;

		// Token: 0x04000595 RID: 1429
		public const int ChildNodesFieldNumber = 8;

		// Token: 0x04000596 RID: 1430
		private static readonly FieldCodec<UITreeNode> _repeated_childNodes_codec = FieldCodec.ForMessage<UITreeNode>(66U, UITreeNode.Parser);

		// Token: 0x04000597 RID: 1431
		private readonly RepeatedField<UITreeNode> childNodes_ = new RepeatedField<UITreeNode>();

		// Token: 0x04000598 RID: 1432
		public const int AbsolutePosFieldNumber = 9;

		// Token: 0x04000599 RID: 1433
		private Vector2 absolutePos_;

		// Token: 0x0400059A RID: 1434
		public const int RelativePosFieldNumber = 10;

		// Token: 0x0400059B RID: 1435
		private Vector2 relativePos_;

		// Token: 0x0400059C RID: 1436
		public const int DimFieldNumber = 11;

		// Token: 0x0400059D RID: 1437
		private Vector2 dim_;

		// Token: 0x0400059E RID: 1438
		public const int ClipRectFieldNumber = 12;

		// Token: 0x0400059F RID: 1439
		private Rect2D clipRect_;

		// Token: 0x040005A0 RID: 1440
		public const int BreakpointFlagsFieldNumber = 13;

		// Token: 0x040005A1 RID: 1441
		private static readonly uint BreakpointFlagsDefaultValue = 0U;

		// Token: 0x040005A2 RID: 1442
		private uint breakpointFlags_;
	}
}

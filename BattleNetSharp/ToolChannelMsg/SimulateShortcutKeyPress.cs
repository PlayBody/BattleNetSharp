using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000092 RID: 146
	public sealed class SimulateShortcutKeyPress : IMessage<SimulateShortcutKeyPress>, IMessage, IEquatable<SimulateShortcutKeyPress>, IDeepCloneable<SimulateShortcutKeyPress>, IBufferMessage
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0003225C File Offset: 0x0003045C
		[DebuggerNonUserCode]
		public static MessageParser<SimulateShortcutKeyPress> Parser
		{
			get
			{
				return SimulateShortcutKeyPress._parser;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00032274 File Offset: 0x00030474
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[123];
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00032298 File Offset: 0x00030498
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimulateShortcutKeyPress.Descriptor;
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000322AF File Offset: 0x000304AF
		[DebuggerNonUserCode]
		public SimulateShortcutKeyPress()
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000322BC File Offset: 0x000304BC
		[DebuggerNonUserCode]
		public SimulateShortcutKeyPress(SimulateShortcutKeyPress other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = other.key_;
			this.modifiers_ = other.modifiers_;
			this.windowId_ = other.windowId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00032314 File Offset: 0x00030514
		[DebuggerNonUserCode]
		public SimulateShortcutKeyPress Clone()
		{
			return new SimulateShortcutKeyPress(this);
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0003232C File Offset: 0x0003052C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0003235D File Offset: 0x0003055D
		[DebuggerNonUserCode]
		public int Key
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int keyDefaultValue;
				if (flag)
				{
					keyDefaultValue = this.key_;
				}
				else
				{
					keyDefaultValue = SimulateShortcutKeyPress.KeyDefaultValue;
				}
				return keyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.key_ = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00032378 File Offset: 0x00030578
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00032395 File Offset: 0x00030595
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000323A8 File Offset: 0x000305A8
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x000323D9 File Offset: 0x000305D9
		[DebuggerNonUserCode]
		public uint Modifiers
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint modifiersDefaultValue;
				if (flag)
				{
					modifiersDefaultValue = this.modifiers_;
				}
				else
				{
					modifiersDefaultValue = SimulateShortcutKeyPress.ModifiersDefaultValue;
				}
				return modifiersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.modifiers_ = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000323F4 File Offset: 0x000305F4
		[DebuggerNonUserCode]
		public bool HasModifiers
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00032411 File Offset: 0x00030611
		[DebuggerNonUserCode]
		public void ClearModifiers()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00032424 File Offset: 0x00030624
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00032455 File Offset: 0x00030655
		[DebuggerNonUserCode]
		public int WindowId
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int windowIdDefaultValue;
				if (flag)
				{
					windowIdDefaultValue = this.windowId_;
				}
				else
				{
					windowIdDefaultValue = SimulateShortcutKeyPress.WindowIdDefaultValue;
				}
				return windowIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.windowId_ = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00032470 File Offset: 0x00030670
		[DebuggerNonUserCode]
		public bool HasWindowId
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0003248D File Offset: 0x0003068D
		[DebuggerNonUserCode]
		public void ClearWindowId()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000324A0 File Offset: 0x000306A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimulateShortcutKeyPress);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000324C0 File Offset: 0x000306C0
		[DebuggerNonUserCode]
		public bool Equals(SimulateShortcutKeyPress other)
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
					bool flag4 = this.Key != other.Key;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Modifiers != other.Modifiers;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.WindowId != other.WindowId;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0003254C File Offset: 0x0003074C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				num ^= this.Modifiers.GetHashCode();
			}
			bool hasWindowId = this.HasWindowId;
			if (hasWindowId)
			{
				num ^= this.WindowId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000325D8 File Offset: 0x000307D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000325F0 File Offset: 0x000307F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000325FC File Offset: 0x000307FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Key);
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Modifiers);
			}
			bool hasWindowId = this.HasWindowId;
			if (hasWindowId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WindowId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0003268C File Offset: 0x0003088C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Key);
			}
			bool hasModifiers = this.HasModifiers;
			if (hasModifiers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Modifiers);
			}
			bool hasWindowId = this.HasWindowId;
			if (hasWindowId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WindowId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00032718 File Offset: 0x00030918
		[DebuggerNonUserCode]
		public void MergeFrom(SimulateShortcutKeyPress other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasModifiers = other.HasModifiers;
				if (hasModifiers)
				{
					this.Modifiers = other.Modifiers;
				}
				bool hasWindowId = other.HasWindowId;
				if (hasWindowId)
				{
					this.WindowId = other.WindowId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00032793 File Offset: 0x00030993
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000327A0 File Offset: 0x000309A0
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
							this.WindowId = input.ReadInt32();
						}
					}
					else
					{
						this.Modifiers = input.ReadUInt32();
					}
				}
				else
				{
					this.Key = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000551 RID: 1361
		private static readonly MessageParser<SimulateShortcutKeyPress> _parser = new MessageParser<SimulateShortcutKeyPress>(() => new SimulateShortcutKeyPress());

		// Token: 0x04000552 RID: 1362
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000553 RID: 1363
		private int _hasBits0;

		// Token: 0x04000554 RID: 1364
		public const int KeyFieldNumber = 1;

		// Token: 0x04000555 RID: 1365
		private static readonly int KeyDefaultValue = 0;

		// Token: 0x04000556 RID: 1366
		private int key_;

		// Token: 0x04000557 RID: 1367
		public const int ModifiersFieldNumber = 2;

		// Token: 0x04000558 RID: 1368
		private static readonly uint ModifiersDefaultValue = 0U;

		// Token: 0x04000559 RID: 1369
		private uint modifiers_;

		// Token: 0x0400055A RID: 1370
		public const int WindowIdFieldNumber = 3;

		// Token: 0x0400055B RID: 1371
		private static readonly int WindowIdDefaultValue = 0;

		// Token: 0x0400055C RID: 1372
		private int windowId_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000095 RID: 149
	public sealed class CollisionInfoGathering : IMessage<CollisionInfoGathering>, IMessage, IEquatable<CollisionInfoGathering>, IDeepCloneable<CollisionInfoGathering>, IBufferMessage
	{
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0003343C File Offset: 0x0003163C
		[DebuggerNonUserCode]
		public static MessageParser<CollisionInfoGathering> Parser
		{
			get
			{
				return CollisionInfoGathering._parser;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00033454 File Offset: 0x00031654
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[126];
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00033478 File Offset: 0x00031678
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CollisionInfoGathering.Descriptor;
			}
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x0003348F File Offset: 0x0003168F
		[DebuggerNonUserCode]
		public CollisionInfoGathering()
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00033499 File Offset: 0x00031699
		[DebuggerNonUserCode]
		public CollisionInfoGathering(CollisionInfoGathering other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.enabled_ = other.enabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000334CC File Offset: 0x000316CC
		[DebuggerNonUserCode]
		public CollisionInfoGathering Clone()
		{
			return new CollisionInfoGathering(this);
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x000334E4 File Offset: 0x000316E4
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00033515 File Offset: 0x00031715
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
					enabledDefaultValue = CollisionInfoGathering.EnabledDefaultValue;
				}
				return enabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.enabled_ = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00033530 File Offset: 0x00031730
		[DebuggerNonUserCode]
		public bool HasEnabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0003354D File Offset: 0x0003174D
		[DebuggerNonUserCode]
		public void ClearEnabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00033560 File Offset: 0x00031760
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CollisionInfoGathering);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00033580 File Offset: 0x00031780
		[DebuggerNonUserCode]
		public bool Equals(CollisionInfoGathering other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000335D8 File Offset: 0x000317D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num ^= this.Enabled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00033628 File Offset: 0x00031828
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00033640 File Offset: 0x00031840
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003364C File Offset: 0x0003184C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enabled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00033698 File Offset: 0x00031898
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasEnabled = this.HasEnabled;
			if (hasEnabled)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000336DC File Offset: 0x000318DC
		[DebuggerNonUserCode]
		public void MergeFrom(CollisionInfoGathering other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasEnabled = other.HasEnabled;
				if (hasEnabled)
				{
					this.Enabled = other.Enabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00033725 File Offset: 0x00031925
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00033730 File Offset: 0x00031930
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Enabled = input.ReadBool();
				}
			}
		}

		// Token: 0x04000575 RID: 1397
		private static readonly MessageParser<CollisionInfoGathering> _parser = new MessageParser<CollisionInfoGathering>(() => new CollisionInfoGathering());

		// Token: 0x04000576 RID: 1398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000577 RID: 1399
		private int _hasBits0;

		// Token: 0x04000578 RID: 1400
		public const int EnabledFieldNumber = 1;

		// Token: 0x04000579 RID: 1401
		private static readonly bool EnabledDefaultValue = false;

		// Token: 0x0400057A RID: 1402
		private bool enabled_;
	}
}

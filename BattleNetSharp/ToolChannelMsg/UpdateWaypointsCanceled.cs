using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000DE RID: 222
	public sealed class UpdateWaypointsCanceled : IMessage<UpdateWaypointsCanceled>, IMessage, IEquatable<UpdateWaypointsCanceled>, IDeepCloneable<UpdateWaypointsCanceled>, IBufferMessage
	{
		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0004EE1C File Offset: 0x0004D01C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateWaypointsCanceled> Parser
		{
			get
			{
				return UpdateWaypointsCanceled._parser;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0004EE34 File Offset: 0x0004D034
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[199];
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0004EE5C File Offset: 0x0004D05C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateWaypointsCanceled.Descriptor;
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0004EE73 File Offset: 0x0004D073
		[DebuggerNonUserCode]
		public UpdateWaypointsCanceled()
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0004EE7D File Offset: 0x0004D07D
		[DebuggerNonUserCode]
		public UpdateWaypointsCanceled(UpdateWaypointsCanceled other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.canceled_ = other.canceled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
		[DebuggerNonUserCode]
		public UpdateWaypointsCanceled Clone()
		{
			return new UpdateWaypointsCanceled(this);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0004EEC8 File Offset: 0x0004D0C8
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0004EEF9 File Offset: 0x0004D0F9
		[DebuggerNonUserCode]
		public bool Canceled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool canceledDefaultValue;
				if (flag)
				{
					canceledDefaultValue = this.canceled_;
				}
				else
				{
					canceledDefaultValue = UpdateWaypointsCanceled.CanceledDefaultValue;
				}
				return canceledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.canceled_ = value;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0004EF14 File Offset: 0x0004D114
		[DebuggerNonUserCode]
		public bool HasCanceled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0004EF31 File Offset: 0x0004D131
		[DebuggerNonUserCode]
		public void ClearCanceled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0004EF44 File Offset: 0x0004D144
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateWaypointsCanceled);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0004EF64 File Offset: 0x0004D164
		[DebuggerNonUserCode]
		public bool Equals(UpdateWaypointsCanceled other)
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
					bool flag4 = this.Canceled != other.Canceled;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0004EFBC File Offset: 0x0004D1BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
			{
				num ^= this.Canceled.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0004F00C File Offset: 0x0004D20C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0004F024 File Offset: 0x0004D224
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0004F030 File Offset: 0x0004D230
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Canceled);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0004F07C File Offset: 0x0004D27C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasCanceled = this.HasCanceled;
			if (hasCanceled)
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

		// Token: 0x060015A3 RID: 5539 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateWaypointsCanceled other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasCanceled = other.HasCanceled;
				if (hasCanceled)
				{
					this.Canceled = other.Canceled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0004F109 File Offset: 0x0004D309
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0004F114 File Offset: 0x0004D314
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
					this.Canceled = input.ReadBool();
				}
			}
		}

		// Token: 0x040008D2 RID: 2258
		private static readonly MessageParser<UpdateWaypointsCanceled> _parser = new MessageParser<UpdateWaypointsCanceled>(() => new UpdateWaypointsCanceled());

		// Token: 0x040008D3 RID: 2259
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008D4 RID: 2260
		private int _hasBits0;

		// Token: 0x040008D5 RID: 2261
		public const int CanceledFieldNumber = 1;

		// Token: 0x040008D6 RID: 2262
		private static readonly bool CanceledDefaultValue = false;

		// Token: 0x040008D7 RID: 2263
		private bool canceled_;
	}
}

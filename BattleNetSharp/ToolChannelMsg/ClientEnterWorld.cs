using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000093 RID: 147
	public sealed class ClientEnterWorld : IMessage<ClientEnterWorld>, IMessage, IEquatable<ClientEnterWorld>, IDeepCloneable<ClientEnterWorld>, IBufferMessage
	{
		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0003284C File Offset: 0x00030A4C
		[DebuggerNonUserCode]
		public static MessageParser<ClientEnterWorld> Parser
		{
			get
			{
				return ClientEnterWorld._parser;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00032864 File Offset: 0x00030A64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[124];
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00032888 File Offset: 0x00030A88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientEnterWorld.Descriptor;
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0003289F File Offset: 0x00030A9F
		[DebuggerNonUserCode]
		public ClientEnterWorld()
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000328A9 File Offset: 0x00030AA9
		[DebuggerNonUserCode]
		public ClientEnterWorld(ClientEnterWorld other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sno_ = other.sno_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000328DC File Offset: 0x00030ADC
		[DebuggerNonUserCode]
		public ClientEnterWorld Clone()
		{
			return new ClientEnterWorld(this);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000328F4 File Offset: 0x00030AF4
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00032925 File Offset: 0x00030B25
		[DebuggerNonUserCode]
		public int Sno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoDefaultValue;
				if (flag)
				{
					snoDefaultValue = this.sno_;
				}
				else
				{
					snoDefaultValue = ClientEnterWorld.SnoDefaultValue;
				}
				return snoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.sno_ = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00032940 File Offset: 0x00030B40
		[DebuggerNonUserCode]
		public bool HasSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003295D File Offset: 0x00030B5D
		[DebuggerNonUserCode]
		public void ClearSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00032970 File Offset: 0x00030B70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientEnterWorld);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00032990 File Offset: 0x00030B90
		[DebuggerNonUserCode]
		public bool Equals(ClientEnterWorld other)
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
					bool flag4 = this.Sno != other.Sno;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000329E8 File Offset: 0x00030BE8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num ^= this.Sno.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00032A38 File Offset: 0x00030C38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00032A50 File Offset: 0x00030C50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00032A5C File Offset: 0x00030C5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00032AA8 File Offset: 0x00030CA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSno = this.HasSno;
			if (hasSno)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sno);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00032AF8 File Offset: 0x00030CF8
		[DebuggerNonUserCode]
		public void MergeFrom(ClientEnterWorld other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSno = other.HasSno;
				if (hasSno)
				{
					this.Sno = other.Sno;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00032B41 File Offset: 0x00030D41
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00032B4C File Offset: 0x00030D4C
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
					this.Sno = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400055D RID: 1373
		private static readonly MessageParser<ClientEnterWorld> _parser = new MessageParser<ClientEnterWorld>(() => new ClientEnterWorld());

		// Token: 0x0400055E RID: 1374
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400055F RID: 1375
		private int _hasBits0;

		// Token: 0x04000560 RID: 1376
		public const int SnoFieldNumber = 1;

		// Token: 0x04000561 RID: 1377
		private static readonly int SnoDefaultValue = 0;

		// Token: 0x04000562 RID: 1378
		private int sno_;
	}
}

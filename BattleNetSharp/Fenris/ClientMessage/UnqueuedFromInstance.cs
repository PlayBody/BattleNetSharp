using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000285 RID: 645
	public sealed class UnqueuedFromInstance : IMessage<UnqueuedFromInstance>, IMessage, IEquatable<UnqueuedFromInstance>, IDeepCloneable<UnqueuedFromInstance>, IBufferMessage
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x00109020 File Offset: 0x00107220
		[DebuggerNonUserCode]
		public static MessageParser<UnqueuedFromInstance> Parser
		{
			get
			{
				return UnqueuedFromInstance._parser;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x00109038 File Offset: 0x00107238
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[117];
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x0010905C File Offset: 0x0010725C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnqueuedFromInstance.Descriptor;
			}
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00109073 File Offset: 0x00107273
		[DebuggerNonUserCode]
		public UnqueuedFromInstance()
		{
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0010907D File Offset: 0x0010727D
		[DebuggerNonUserCode]
		public UnqueuedFromInstance(UnqueuedFromInstance other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x001090BC File Offset: 0x001072BC
		[DebuggerNonUserCode]
		public UnqueuedFromInstance Clone()
		{
			return new UnqueuedFromInstance(this);
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x060044CB RID: 17611 RVA: 0x001090D4 File Offset: 0x001072D4
		// (set) Token: 0x060044CC RID: 17612 RVA: 0x00109105 File Offset: 0x00107305
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
					snoSubzoneDefaultValue = UnqueuedFromInstance.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x00109120 File Offset: 0x00107320
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x0010913D File Offset: 0x0010733D
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x00109150 File Offset: 0x00107350
		// (set) Token: 0x060044D0 RID: 17616 RVA: 0x00109181 File Offset: 0x00107381
		[DebuggerNonUserCode]
		public uint Reason
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint reasonDefaultValue;
				if (flag)
				{
					reasonDefaultValue = this.reason_;
				}
				else
				{
					reasonDefaultValue = UnqueuedFromInstance.ReasonDefaultValue;
				}
				return reasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x0010919C File Offset: 0x0010739C
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x001091B9 File Offset: 0x001073B9
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001091CC File Offset: 0x001073CC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnqueuedFromInstance);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x001091EC File Offset: 0x001073EC
		[DebuggerNonUserCode]
		public bool Equals(UnqueuedFromInstance other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Reason != other.Reason;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00109260 File Offset: 0x00107460
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x001092D0 File Offset: 0x001074D0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x001092E8 File Offset: 0x001074E8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x001092F4 File Offset: 0x001074F4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(13);
				output.WriteSFixed32(this.SnoSubzone);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00109364 File Offset: 0x00107564
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 5;
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001093C4 File Offset: 0x001075C4
		[DebuggerNonUserCode]
		public void MergeFrom(UnqueuedFromInstance other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00109426 File Offset: 0x00107626
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x00109434 File Offset: 0x00107634
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = input.ReadUInt32();
					}
				}
				else
				{
					this.SnoSubzone = input.ReadSFixed32();
				}
			}
		}

		// Token: 0x04001ED9 RID: 7897
		private static readonly MessageParser<UnqueuedFromInstance> _parser = new MessageParser<UnqueuedFromInstance>(() => new UnqueuedFromInstance());

		// Token: 0x04001EDA RID: 7898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EDB RID: 7899
		private int _hasBits0;

		// Token: 0x04001EDC RID: 7900
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x04001EDD RID: 7901
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x04001EDE RID: 7902
		private int snoSubzone_;

		// Token: 0x04001EDF RID: 7903
		public const int ReasonFieldNumber = 2;

		// Token: 0x04001EE0 RID: 7904
		private static readonly uint ReasonDefaultValue = 0U;

		// Token: 0x04001EE1 RID: 7905
		private uint reason_;
	}
}

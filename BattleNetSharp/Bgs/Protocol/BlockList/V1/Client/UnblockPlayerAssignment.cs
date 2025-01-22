using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000709 RID: 1801
	public sealed class UnblockPlayerAssignment : IMessage<UnblockPlayerAssignment>, IMessage, IEquatable<UnblockPlayerAssignment>, IDeepCloneable<UnblockPlayerAssignment>, IBufferMessage
	{
		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x00284090 File Offset: 0x00282290
		[DebuggerNonUserCode]
		public static MessageParser<UnblockPlayerAssignment> Parser
		{
			get
			{
				return UnblockPlayerAssignment._parser;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x002840A8 File Offset: 0x002822A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x002840CC File Offset: 0x002822CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerAssignment.Descriptor;
			}
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x002840E3 File Offset: 0x002822E3
		[DebuggerNonUserCode]
		public UnblockPlayerAssignment()
		{
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x002840ED File Offset: 0x002822ED
		[DebuggerNonUserCode]
		public UnblockPlayerAssignment(UnblockPlayerAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x00284120 File Offset: 0x00282320
		[DebuggerNonUserCode]
		public UnblockPlayerAssignment Clone()
		{
			return new UnblockPlayerAssignment(this);
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A55D RID: 42333 RVA: 0x00284138 File Offset: 0x00282338
		// (set) Token: 0x0600A55E RID: 42334 RVA: 0x00284169 File Offset: 0x00282369
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = UnblockPlayerAssignment.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x00284184 File Offset: 0x00282384
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A560 RID: 42336 RVA: 0x002841A1 File Offset: 0x002823A1
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x002841B4 File Offset: 0x002823B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerAssignment);
		}

		// Token: 0x0600A562 RID: 42338 RVA: 0x002841D4 File Offset: 0x002823D4
		[DebuggerNonUserCode]
		public bool Equals(UnblockPlayerAssignment other)
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
					bool flag4 = this.Id != other.Id;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x0028422C File Offset: 0x0028242C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x0028427C File Offset: 0x0028247C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x00284294 File Offset: 0x00282494
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x002842A0 File Offset: 0x002824A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x002842EC File Offset: 0x002824EC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x0028433C File Offset: 0x0028253C
		[DebuggerNonUserCode]
		public void MergeFrom(UnblockPlayerAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x00284385 File Offset: 0x00282585
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x00284390 File Offset: 0x00282590
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
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004A66 RID: 19046
		private static readonly MessageParser<UnblockPlayerAssignment> _parser = new MessageParser<UnblockPlayerAssignment>(() => new UnblockPlayerAssignment());

		// Token: 0x04004A67 RID: 19047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A68 RID: 19048
		private int _hasBits0;

		// Token: 0x04004A69 RID: 19049
		public const int IdFieldNumber = 1;

		// Token: 0x04004A6A RID: 19050
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04004A6B RID: 19051
		private ulong id_;
	}
}

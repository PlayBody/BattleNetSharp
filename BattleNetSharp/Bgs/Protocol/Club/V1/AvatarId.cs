using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200043C RID: 1084
	public sealed class AvatarId : IMessage<AvatarId>, IMessage, IEquatable<AvatarId>, IDeepCloneable<AvatarId>, IBufferMessage
	{
		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x0019C02C File Offset: 0x0019A22C
		[DebuggerNonUserCode]
		public static MessageParser<AvatarId> Parser
		{
			get
			{
				return AvatarId._parser;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x0019C044 File Offset: 0x0019A244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x0019C068 File Offset: 0x0019A268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarId.Descriptor;
			}
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x0019C07F File Offset: 0x0019A27F
		[DebuggerNonUserCode]
		public AvatarId()
		{
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x0019C089 File Offset: 0x0019A289
		[DebuggerNonUserCode]
		public AvatarId(AvatarId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x0019C0BC File Offset: 0x0019A2BC
		[DebuggerNonUserCode]
		public AvatarId Clone()
		{
			return new AvatarId(this);
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x0019C0D4 File Offset: 0x0019A2D4
		// (set) Token: 0x06006A57 RID: 27223 RVA: 0x0019C105 File Offset: 0x0019A305
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = AvatarId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x0019C120 File Offset: 0x0019A320
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x0019C13D File Offset: 0x0019A33D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0019C150 File Offset: 0x0019A350
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarId);
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x0019C170 File Offset: 0x0019A370
		[DebuggerNonUserCode]
		public bool Equals(AvatarId other)
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

		// Token: 0x06006A5C RID: 27228 RVA: 0x0019C1C8 File Offset: 0x0019A3C8
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

		// Token: 0x06006A5D RID: 27229 RVA: 0x0019C218 File Offset: 0x0019A418
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0019C230 File Offset: 0x0019A430
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x0019C23C File Offset: 0x0019A43C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x0019C288 File Offset: 0x0019A488
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x0019C2D8 File Offset: 0x0019A4D8
		[DebuggerNonUserCode]
		public void MergeFrom(AvatarId other)
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

		// Token: 0x06006A62 RID: 27234 RVA: 0x0019C321 File Offset: 0x0019A521
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x0019C32C File Offset: 0x0019A52C
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
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400306C RID: 12396
		private static readonly MessageParser<AvatarId> _parser = new MessageParser<AvatarId>(() => new AvatarId());

		// Token: 0x0400306D RID: 12397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400306E RID: 12398
		private int _hasBits0;

		// Token: 0x0400306F RID: 12399
		public const int IdFieldNumber = 1;

		// Token: 0x04003070 RID: 12400
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04003071 RID: 12401
		private uint id_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A6 RID: 1958
	public sealed class DeleteCharacterRequest : IMessage<DeleteCharacterRequest>, IMessage, IEquatable<DeleteCharacterRequest>, IDeepCloneable<DeleteCharacterRequest>, IBufferMessage
	{
		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x002BB820 File Offset: 0x002B9A20
		[DebuggerNonUserCode]
		public static MessageParser<DeleteCharacterRequest> Parser
		{
			get
			{
				return DeleteCharacterRequest._parser;
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B3AD RID: 45997 RVA: 0x002BB838 File Offset: 0x002B9A38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B3AE RID: 45998 RVA: 0x002BB85C File Offset: 0x002B9A5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteCharacterRequest.Descriptor;
			}
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x002BB873 File Offset: 0x002B9A73
		[DebuggerNonUserCode]
		public DeleteCharacterRequest()
		{
		}

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x002BB87D File Offset: 0x002B9A7D
		[DebuggerNonUserCode]
		public DeleteCharacterRequest(DeleteCharacterRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.unk0_ = other.unk0_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x002BB8BC File Offset: 0x002B9ABC
		[DebuggerNonUserCode]
		public DeleteCharacterRequest Clone()
		{
			return new DeleteCharacterRequest(this);
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x002BB8D4 File Offset: 0x002B9AD4
		// (set) Token: 0x0600B3B3 RID: 46003 RVA: 0x002BB905 File Offset: 0x002B9B05
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
					idDefaultValue = DeleteCharacterRequest.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x002BB920 File Offset: 0x002B9B20
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x002BB93D File Offset: 0x002B9B3D
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x002BB950 File Offset: 0x002B9B50
		// (set) Token: 0x0600B3B7 RID: 46007 RVA: 0x002BB981 File Offset: 0x002B9B81
		[DebuggerNonUserCode]
		public int Unk0
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int unk0DefaultValue;
				if (flag)
				{
					unk0DefaultValue = this.unk0_;
				}
				else
				{
					unk0DefaultValue = DeleteCharacterRequest.Unk0DefaultValue;
				}
				return unk0DefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.unk0_ = value;
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x002BB99C File Offset: 0x002B9B9C
		[DebuggerNonUserCode]
		public bool HasUnk0
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x002BB9B9 File Offset: 0x002B9BB9
		[DebuggerNonUserCode]
		public void ClearUnk0()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x002BB9CC File Offset: 0x002B9BCC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteCharacterRequest);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x002BB9EC File Offset: 0x002B9BEC
		[DebuggerNonUserCode]
		public bool Equals(DeleteCharacterRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Unk0 != other.Unk0;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x002BBA60 File Offset: 0x002B9C60
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasUnk = this.HasUnk0;
			if (hasUnk)
			{
				num ^= this.Unk0.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x002BBAD0 File Offset: 0x002B9CD0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x002BBAE8 File Offset: 0x002B9CE8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x002BBAF4 File Offset: 0x002B9CF4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasUnk = this.HasUnk0;
			if (hasUnk)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Unk0);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x002BBB64 File Offset: 0x002B9D64
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasUnk = this.HasUnk0;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Unk0);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x002BBBD0 File Offset: 0x002B9DD0
		[DebuggerNonUserCode]
		public void MergeFrom(DeleteCharacterRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasUnk = other.HasUnk0;
				if (hasUnk)
				{
					this.Unk0 = other.Unk0;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x002BBC32 File Offset: 0x002B9E32
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x002BBC40 File Offset: 0x002B9E40
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Unk0 = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400513F RID: 20799
		private static readonly MessageParser<DeleteCharacterRequest> _parser = new MessageParser<DeleteCharacterRequest>(() => new DeleteCharacterRequest());

		// Token: 0x04005140 RID: 20800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005141 RID: 20801
		private int _hasBits0;

		// Token: 0x04005142 RID: 20802
		public const int IdFieldNumber = 1;

		// Token: 0x04005143 RID: 20803
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04005144 RID: 20804
		private uint id_;

		// Token: 0x04005145 RID: 20805
		public const int Unk0FieldNumber = 2;

		// Token: 0x04005146 RID: 20806
		private static readonly int Unk0DefaultValue = 0;

		// Token: 0x04005147 RID: 20807
		private int unk0_;
	}
}

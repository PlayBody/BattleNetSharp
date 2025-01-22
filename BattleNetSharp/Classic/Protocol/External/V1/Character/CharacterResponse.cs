using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.Character
{
	// Token: 0x020007A7 RID: 1959
	public sealed class CharacterResponse : IMessage<CharacterResponse>, IMessage, IEquatable<CharacterResponse>, IDeepCloneable<CharacterResponse>, IBufferMessage
	{
		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B3C5 RID: 46021 RVA: 0x002BBCD0 File Offset: 0x002B9ED0
		[DebuggerNonUserCode]
		public static MessageParser<CharacterResponse> Parser
		{
			get
			{
				return CharacterResponse._parser;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B3C6 RID: 46022 RVA: 0x002BBCE8 File Offset: 0x002B9EE8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CharacterReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B3C7 RID: 46023 RVA: 0x002BBD0C File Offset: 0x002B9F0C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CharacterResponse.Descriptor;
			}
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x002BBD23 File Offset: 0x002B9F23
		[DebuggerNonUserCode]
		public CharacterResponse()
		{
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x002BBD2D File Offset: 0x002B9F2D
		[DebuggerNonUserCode]
		public CharacterResponse(CharacterResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x002BBD6C File Offset: 0x002B9F6C
		[DebuggerNonUserCode]
		public CharacterResponse Clone()
		{
			return new CharacterResponse(this);
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B3CB RID: 46027 RVA: 0x002BBD84 File Offset: 0x002B9F84
		// (set) Token: 0x0600B3CC RID: 46028 RVA: 0x002BBDB5 File Offset: 0x002B9FB5
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
					idDefaultValue = CharacterResponse.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B3CD RID: 46029 RVA: 0x002BBDD0 File Offset: 0x002B9FD0
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x002BBDED File Offset: 0x002B9FED
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B3CF RID: 46031 RVA: 0x002BBE00 File Offset: 0x002BA000
		// (set) Token: 0x0600B3D0 RID: 46032 RVA: 0x002BBE21 File Offset: 0x002BA021
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? CharacterResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B3D1 RID: 46033 RVA: 0x002BBE38 File Offset: 0x002BA038
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x002BBE56 File Offset: 0x002BA056
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x002BBE60 File Offset: 0x002BA060
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CharacterResponse);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x002BBE80 File Offset: 0x002BA080
		[DebuggerNonUserCode]
		public bool Equals(CharacterResponse other)
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
						bool flag5 = this.Data != other.Data;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x002BBEF4 File Offset: 0x002BA0F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x002BBF60 File Offset: 0x002BA160
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x002BBF78 File Offset: 0x002BA178
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x002BBF84 File Offset: 0x002BA184
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x002BBFF4 File Offset: 0x002BA1F4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x002BC060 File Offset: 0x002BA260
		[DebuggerNonUserCode]
		public void MergeFrom(CharacterResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x002BC0C2 File Offset: 0x002BA2C2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x002BC0D0 File Offset: 0x002BA2D0
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
					if (num3 != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Data = input.ReadBytes();
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005148 RID: 20808
		private static readonly MessageParser<CharacterResponse> _parser = new MessageParser<CharacterResponse>(() => new CharacterResponse());

		// Token: 0x04005149 RID: 20809
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400514A RID: 20810
		private int _hasBits0;

		// Token: 0x0400514B RID: 20811
		public const int IdFieldNumber = 1;

		// Token: 0x0400514C RID: 20812
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x0400514D RID: 20813
		private uint id_;

		// Token: 0x0400514E RID: 20814
		public const int DataFieldNumber = 3;

		// Token: 0x0400514F RID: 20815
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04005150 RID: 20816
		private ByteString data_;
	}
}

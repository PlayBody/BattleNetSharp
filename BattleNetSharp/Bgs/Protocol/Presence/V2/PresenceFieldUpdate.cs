using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2
{
	// Token: 0x020005BE RID: 1470
	public sealed class PresenceFieldUpdate : IMessage<PresenceFieldUpdate>, IMessage, IEquatable<PresenceFieldUpdate>, IDeepCloneable<PresenceFieldUpdate>, IBufferMessage
	{
		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06008B58 RID: 35672 RVA: 0x0021D400 File Offset: 0x0021B600
		[DebuggerNonUserCode]
		public static MessageParser<PresenceFieldUpdate> Parser
		{
			get
			{
				return PresenceFieldUpdate._parser;
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06008B59 RID: 35673 RVA: 0x0021D418 File Offset: 0x0021B618
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06008B5A RID: 35674 RVA: 0x0021D43C File Offset: 0x0021B63C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PresenceFieldUpdate.Descriptor;
			}
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x0021D453 File Offset: 0x0021B653
		[DebuggerNonUserCode]
		public PresenceFieldUpdate()
		{
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x0021D460 File Offset: 0x0021B660
		[DebuggerNonUserCode]
		public PresenceFieldUpdate(PresenceFieldUpdate other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.key_ = ((other.key_ != null) ? other.key_.Clone() : null);
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this.delete_ = other.delete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x0021D4D8 File Offset: 0x0021B6D8
		[DebuggerNonUserCode]
		public PresenceFieldUpdate Clone()
		{
			return new PresenceFieldUpdate(this);
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06008B5E RID: 35678 RVA: 0x0021D4F0 File Offset: 0x0021B6F0
		// (set) Token: 0x06008B5F RID: 35679 RVA: 0x0021D508 File Offset: 0x0021B708
		[DebuggerNonUserCode]
		public PresenceFieldKey Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = value;
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x0021D514 File Offset: 0x0021B714
		// (set) Token: 0x06008B61 RID: 35681 RVA: 0x0021D52C File Offset: 0x0021B72C
		[DebuggerNonUserCode]
		public Variant Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x06008B62 RID: 35682 RVA: 0x0021D538 File Offset: 0x0021B738
		// (set) Token: 0x06008B63 RID: 35683 RVA: 0x0021D569 File Offset: 0x0021B769
		[DebuggerNonUserCode]
		public bool Delete
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool deleteDefaultValue;
				if (flag)
				{
					deleteDefaultValue = this.delete_;
				}
				else
				{
					deleteDefaultValue = PresenceFieldUpdate.DeleteDefaultValue;
				}
				return deleteDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.delete_ = value;
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x06008B64 RID: 35684 RVA: 0x0021D584 File Offset: 0x0021B784
		[DebuggerNonUserCode]
		public bool HasDelete
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x0021D5A1 File Offset: 0x0021B7A1
		[DebuggerNonUserCode]
		public void ClearDelete()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x0021D5B4 File Offset: 0x0021B7B4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PresenceFieldUpdate);
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x0021D5D4 File Offset: 0x0021B7D4
		[DebuggerNonUserCode]
		public bool Equals(PresenceFieldUpdate other)
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
					bool flag4 = !object.Equals(this.Key, other.Key);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Value, other.Value);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Delete != other.Delete;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x0021D668 File Offset: 0x0021B868
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.key_ != null;
			if (flag)
			{
				num ^= this.Key.GetHashCode();
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				num ^= this.Value.GetHashCode();
			}
			bool hasDelete = this.HasDelete;
			if (hasDelete)
			{
				num ^= this.Delete.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x0021D6F0 File Offset: 0x0021B8F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x0021D708 File Offset: 0x0021B908
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x0021D714 File Offset: 0x0021B914
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.key_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Key);
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Value);
			}
			bool hasDelete = this.HasDelete;
			if (hasDelete)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Delete);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x0021D7AC File Offset: 0x0021B9AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.key_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Key);
			}
			bool flag2 = this.value_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			bool hasDelete = this.HasDelete;
			if (hasDelete)
			{
				num += 2;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x0021D830 File Offset: 0x0021BA30
		[DebuggerNonUserCode]
		public void MergeFrom(PresenceFieldUpdate other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.key_ != null;
				if (flag2)
				{
					bool flag3 = this.key_ == null;
					if (flag3)
					{
						this.Key = new PresenceFieldKey();
					}
					this.Key.MergeFrom(other.Key);
				}
				bool flag4 = other.value_ != null;
				if (flag4)
				{
					bool flag5 = this.value_ == null;
					if (flag5)
					{
						this.Value = new Variant();
					}
					this.Value.MergeFrom(other.Value);
				}
				bool hasDelete = other.HasDelete;
				if (hasDelete)
				{
					this.Delete = other.Delete;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x0021D8F8 File Offset: 0x0021BAF8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x0021D904 File Offset: 0x0021BB04
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Delete = input.ReadBool();
						}
					}
					else
					{
						bool flag = this.value_ == null;
						if (flag)
						{
							this.Value = new Variant();
						}
						input.ReadMessage(this.Value);
					}
				}
				else
				{
					bool flag2 = this.key_ == null;
					if (flag2)
					{
						this.Key = new PresenceFieldKey();
					}
					input.ReadMessage(this.Key);
				}
			}
		}

		// Token: 0x04003F18 RID: 16152
		private static readonly MessageParser<PresenceFieldUpdate> _parser = new MessageParser<PresenceFieldUpdate>(() => new PresenceFieldUpdate());

		// Token: 0x04003F19 RID: 16153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F1A RID: 16154
		private int _hasBits0;

		// Token: 0x04003F1B RID: 16155
		public const int KeyFieldNumber = 1;

		// Token: 0x04003F1C RID: 16156
		private PresenceFieldKey key_;

		// Token: 0x04003F1D RID: 16157
		public const int ValueFieldNumber = 2;

		// Token: 0x04003F1E RID: 16158
		private Variant value_;

		// Token: 0x04003F1F RID: 16159
		public const int DeleteFieldNumber = 3;

		// Token: 0x04003F20 RID: 16160
		private static readonly bool DeleteDefaultValue = false;

		// Token: 0x04003F21 RID: 16161
		private bool delete_;
	}
}

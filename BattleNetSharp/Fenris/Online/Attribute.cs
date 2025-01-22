using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200014B RID: 331
	public sealed class Attribute : IMessage<Attribute>, IMessage, IEquatable<Attribute>, IDeepCloneable<Attribute>, IBufferMessage
	{
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00085CDC File Offset: 0x00083EDC
		[DebuggerNonUserCode]
		public static MessageParser<Attribute> Parser
		{
			get
			{
				return Attribute._parser;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00085CF4 File Offset: 0x00083EF4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00085D18 File Offset: 0x00083F18
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Attribute.Descriptor;
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00085D2F File Offset: 0x00083F2F
		[DebuggerNonUserCode]
		public Attribute()
		{
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00085D3C File Offset: 0x00083F3C
		[DebuggerNonUserCode]
		public Attribute(Attribute other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00085D98 File Offset: 0x00083F98
		[DebuggerNonUserCode]
		public Attribute Clone()
		{
			return new Attribute(this);
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x00085DB0 File Offset: 0x00083FB0
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x00085DE1 File Offset: 0x00083FE1
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
					idDefaultValue = Attribute.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00085DFC File Offset: 0x00083FFC
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00085E19 File Offset: 0x00084019
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00085E2C File Offset: 0x0008402C
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x00085E44 File Offset: 0x00084044
		[DebuggerNonUserCode]
		public XVariant Value
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

		// Token: 0x0600225D RID: 8797 RVA: 0x00085E50 File Offset: 0x00084050
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Attribute);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00085E70 File Offset: 0x00084070
		[DebuggerNonUserCode]
		public bool Equals(Attribute other)
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
						bool flag5 = !object.Equals(this.Value, other.Value);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00085EE4 File Offset: 0x000840E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				num ^= this.Value.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00085F50 File Offset: 0x00084150
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00085F68 File Offset: 0x00084168
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00085F74 File Offset: 0x00084174
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Value);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00085FE4 File Offset: 0x000841E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this.value_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Value);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00086054 File Offset: 0x00084254
		[DebuggerNonUserCode]
		public void MergeFrom(Attribute other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.value_ != null;
				if (flag2)
				{
					bool flag3 = this.value_ == null;
					if (flag3)
					{
						this.Value = new XVariant();
					}
					this.Value.MergeFrom(other.Value);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000860D9 File Offset: 0x000842D9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x000860E4 File Offset: 0x000842E4
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.value_ == null;
						if (flag)
						{
							this.Value = new XVariant();
						}
						input.ReadMessage(this.Value);
					}
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000F25 RID: 3877
		private static readonly MessageParser<Attribute> _parser = new MessageParser<Attribute>(() => new Attribute());

		// Token: 0x04000F26 RID: 3878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F27 RID: 3879
		private int _hasBits0;

		// Token: 0x04000F28 RID: 3880
		public const int IdFieldNumber = 1;

		// Token: 0x04000F29 RID: 3881
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04000F2A RID: 3882
		private uint id_;

		// Token: 0x04000F2B RID: 3883
		public const int ValueFieldNumber = 2;

		// Token: 0x04000F2C RID: 3884
		private XVariant value_;
	}
}

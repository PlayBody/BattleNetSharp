using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005AE RID: 1454
	public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>, IBufferMessage
	{
		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x00219318 File Offset: 0x00217518
		[DebuggerNonUserCode]
		public static MessageParser<Field> Parser
		{
			get
			{
				return Field._parser;
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x06008A3F RID: 35391 RVA: 0x00219330 File Offset: 0x00217530
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x00219354 File Offset: 0x00217554
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Field.Descriptor;
			}
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x0021936B File Offset: 0x0021756B
		[DebuggerNonUserCode]
		public Field()
		{
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x00219378 File Offset: 0x00217578
		[DebuggerNonUserCode]
		public Field(Field other)
			: this()
		{
			this.key_ = ((other.key_ != null) ? other.key_.Clone() : null);
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x002193D8 File Offset: 0x002175D8
		[DebuggerNonUserCode]
		public Field Clone()
		{
			return new Field(this);
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06008A44 RID: 35396 RVA: 0x002193F0 File Offset: 0x002175F0
		// (set) Token: 0x06008A45 RID: 35397 RVA: 0x00219408 File Offset: 0x00217608
		[DebuggerNonUserCode]
		public FieldKey Key
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

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06008A46 RID: 35398 RVA: 0x00219414 File Offset: 0x00217614
		// (set) Token: 0x06008A47 RID: 35399 RVA: 0x0021942C File Offset: 0x0021762C
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

		// Token: 0x06008A48 RID: 35400 RVA: 0x00219438 File Offset: 0x00217638
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Field);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x00219458 File Offset: 0x00217658
		[DebuggerNonUserCode]
		public bool Equals(Field other)
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
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x002194D0 File Offset: 0x002176D0
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x0021953C File Offset: 0x0021773C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x00219554 File Offset: 0x00217754
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x00219560 File Offset: 0x00217760
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x002195D4 File Offset: 0x002177D4
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
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x00219648 File Offset: 0x00217848
		[DebuggerNonUserCode]
		public void MergeFrom(Field other)
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
						this.Key = new FieldKey();
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
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x002196F5 File Offset: 0x002178F5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x00219700 File Offset: 0x00217900
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
						this.Key = new FieldKey();
					}
					input.ReadMessage(this.Key);
				}
			}
		}

		// Token: 0x04003E9A RID: 16026
		private static readonly MessageParser<Field> _parser = new MessageParser<Field>(() => new Field());

		// Token: 0x04003E9B RID: 16027
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E9C RID: 16028
		public const int KeyFieldNumber = 1;

		// Token: 0x04003E9D RID: 16029
		private FieldKey key_;

		// Token: 0x04003E9E RID: 16030
		public const int ValueFieldNumber = 2;

		// Token: 0x04003E9F RID: 16031
		private Variant value_;
	}
}

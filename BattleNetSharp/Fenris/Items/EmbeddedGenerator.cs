using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x02000166 RID: 358
	public sealed class EmbeddedGenerator : IMessage<EmbeddedGenerator>, IMessage, IEquatable<EmbeddedGenerator>, IDeepCloneable<EmbeddedGenerator>, IBufferMessage
	{
		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00090F8C File Offset: 0x0008F18C
		[DebuggerNonUserCode]
		public static MessageParser<EmbeddedGenerator> Parser
		{
			get
			{
				return EmbeddedGenerator._parser;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x00090FA4 File Offset: 0x0008F1A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x00090FC8 File Offset: 0x0008F1C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EmbeddedGenerator.Descriptor;
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00090FDF File Offset: 0x0008F1DF
		[DebuggerNonUserCode]
		public EmbeddedGenerator()
		{
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00090FEC File Offset: 0x0008F1EC
		[DebuggerNonUserCode]
		public EmbeddedGenerator(EmbeddedGenerator other)
			: this()
		{
			this.id_ = other.id_;
			this.generator_ = ((other.generator_ != null) ? other.generator_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0009103C File Offset: 0x0008F23C
		[DebuggerNonUserCode]
		public EmbeddedGenerator Clone()
		{
			return new EmbeddedGenerator(this);
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00091054 File Offset: 0x0008F254
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00091075 File Offset: 0x0008F275
		[DebuggerNonUserCode]
		public ByteString Id
		{
			get
			{
				return this.id_ ?? EmbeddedGenerator.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x0009108C File Offset: 0x0008F28C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000910AA File Offset: 0x0008F2AA
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000910B4 File Offset: 0x0008F2B4
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x000910CC File Offset: 0x0008F2CC
		[DebuggerNonUserCode]
		public Generator Generator
		{
			get
			{
				return this.generator_;
			}
			set
			{
				this.generator_ = value;
			}
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000910D8 File Offset: 0x0008F2D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EmbeddedGenerator);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000910F8 File Offset: 0x0008F2F8
		[DebuggerNonUserCode]
		public bool Equals(EmbeddedGenerator other)
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
						bool flag5 = !object.Equals(this.Generator, other.Generator);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x0009116C File Offset: 0x0008F36C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				num ^= this.Generator.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000911D4 File Offset: 0x0008F3D4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000911EC File Offset: 0x0008F3EC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000911F8 File Offset: 0x0008F3F8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Id);
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Generator);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0009126C File Offset: 0x0008F46C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Id);
			}
			bool flag = this.generator_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Generator);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000912DC File Offset: 0x0008F4DC
		[DebuggerNonUserCode]
		public void MergeFrom(EmbeddedGenerator other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool flag2 = other.generator_ != null;
				if (flag2)
				{
					bool flag3 = this.generator_ == null;
					if (flag3)
					{
						this.Generator = new Generator();
					}
					this.Generator.MergeFrom(other.Generator);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00091361 File Offset: 0x0008F561
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x0009136C File Offset: 0x0008F56C
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
						bool flag = this.generator_ == null;
						if (flag)
						{
							this.Generator = new Generator();
						}
						input.ReadMessage(this.Generator);
					}
				}
				else
				{
					this.Id = input.ReadBytes();
				}
			}
		}

		// Token: 0x04001077 RID: 4215
		private static readonly MessageParser<EmbeddedGenerator> _parser = new MessageParser<EmbeddedGenerator>(() => new EmbeddedGenerator());

		// Token: 0x04001078 RID: 4216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001079 RID: 4217
		public const int IdFieldNumber = 1;

		// Token: 0x0400107A RID: 4218
		private static readonly ByteString IdDefaultValue = ByteString.Empty;

		// Token: 0x0400107B RID: 4219
		private ByteString id_;

		// Token: 0x0400107C RID: 4220
		public const int GeneratorFieldNumber = 2;

		// Token: 0x0400107D RID: 4221
		private Generator generator_;
	}
}

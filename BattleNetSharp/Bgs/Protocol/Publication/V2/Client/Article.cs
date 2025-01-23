using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000599 RID: 1433
	public sealed class Article : IMessage<Article>, IMessage, IEquatable<Article>, IDeepCloneable<Article>, IBufferMessage
	{
		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x00212F20 File Offset: 0x00211120
		[DebuggerNonUserCode]
		public static MessageParser<Article> Parser
		{
			get
			{
				return Article._parser;
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x060088B4 RID: 34996 RVA: 0x00212F38 File Offset: 0x00211138
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x00212F5C File Offset: 0x0021115C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Article.Descriptor;
			}
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x00212F73 File Offset: 0x00211173
		[DebuggerNonUserCode]
		public Article()
		{
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x00212F88 File Offset: 0x00211188
		[DebuggerNonUserCode]
		public Article(Article other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.target_ = ((other.target_ != null) ? other.target_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.creationTimeMs_ = other.creationTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x00212FF4 File Offset: 0x002111F4
		[DebuggerNonUserCode]
		public Article Clone()
		{
			return new Article(this);
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x0021300C File Offset: 0x0021120C
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x00213024 File Offset: 0x00211224
		[DebuggerNonUserCode]
		public Target Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x00213030 File Offset: 0x00211230
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x060088BC RID: 35004 RVA: 0x00213048 File Offset: 0x00211248
		// (set) Token: 0x060088BD RID: 35005 RVA: 0x00213079 File Offset: 0x00211279
		[DebuggerNonUserCode]
		public ulong CreationTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong creationTimeMsDefaultValue;
				if (flag)
				{
					creationTimeMsDefaultValue = this.creationTimeMs_;
				}
				else
				{
					creationTimeMsDefaultValue = Article.CreationTimeMsDefaultValue;
				}
				return creationTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.creationTimeMs_ = value;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x060088BE RID: 35006 RVA: 0x00213094 File Offset: 0x00211294
		[DebuggerNonUserCode]
		public bool HasCreationTimeMs
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x002130B1 File Offset: 0x002112B1
		[DebuggerNonUserCode]
		public void ClearCreationTimeMs()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x002130C4 File Offset: 0x002112C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Article);
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x002130E4 File Offset: 0x002112E4
		[DebuggerNonUserCode]
		public bool Equals(Article other)
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
					bool flag4 = !object.Equals(this.Target, other.Target);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.CreationTimeMs != other.CreationTimeMs;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x00213178 File Offset: 0x00211378
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.target_ != null;
			if (flag)
			{
				num ^= this.Target.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num ^= this.CreationTimeMs.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x002131F4 File Offset: 0x002113F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x0021320C File Offset: 0x0021140C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x00213218 File Offset: 0x00211418
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.target_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Target);
			}
			this.attribute_.WriteTo(ref output, Article._repeated_attribute_codec);
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.CreationTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x0021329C File Offset: 0x0021149C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.target_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Target);
			}
			num += this.attribute_.CalculateSize(Article._repeated_attribute_codec);
			bool hasCreationTimeMs = this.HasCreationTimeMs;
			if (hasCreationTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.CreationTimeMs);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x00213320 File Offset: 0x00211520
		[DebuggerNonUserCode]
		public void MergeFrom(Article other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.target_ != null;
				if (flag2)
				{
					bool flag3 = this.target_ == null;
					if (flag3)
					{
						this.Target = new Target();
					}
					this.Target.MergeFrom(other.Target);
				}
				this.attribute_.Add(other.attribute_);
				bool hasCreationTimeMs = other.HasCreationTimeMs;
				if (hasCreationTimeMs)
				{
					this.CreationTimeMs = other.CreationTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x002133B7 File Offset: 0x002115B7
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x002133C4 File Offset: 0x002115C4
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
							this.CreationTimeMs = input.ReadUInt64();
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, Article._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.target_ == null;
					if (flag)
					{
						this.Target = new Target();
					}
					input.ReadMessage(this.Target);
				}
			}
		}

		// Token: 0x04003DDF RID: 15839
		private static readonly MessageParser<Article> _parser = new MessageParser<Article>(() => new Article());

		// Token: 0x04003DE0 RID: 15840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DE1 RID: 15841
		private int _hasBits0;

		// Token: 0x04003DE2 RID: 15842
		public const int TargetFieldNumber = 1;

		// Token: 0x04003DE3 RID: 15843
		private Target target_;

		// Token: 0x04003DE4 RID: 15844
		public const int AttributeFieldNumber = 2;

		// Token: 0x04003DE5 RID: 15845
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003DE6 RID: 15846
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003DE7 RID: 15847
		public const int CreationTimeMsFieldNumber = 3;

		// Token: 0x04003DE8 RID: 15848
		private static readonly ulong CreationTimeMsDefaultValue = 0UL;

		// Token: 0x04003DE9 RID: 15849
		private ulong creationTimeMs_;
	}
}

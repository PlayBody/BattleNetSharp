using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GenericResource
{
	// Token: 0x02000784 RID: 1924
	public sealed class Resource : IMessage<Resource>, IMessage, IEquatable<Resource>, IDeepCloneable<Resource>, IBufferMessage
	{
		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600B08B RID: 45195 RVA: 0x002AF87C File Offset: 0x002ADA7C
		[DebuggerNonUserCode]
		public static MessageParser<Resource> Parser
		{
			get
			{
				return Resource._parser;
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600B08C RID: 45196 RVA: 0x002AF894 File Offset: 0x002ADA94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GenericResourceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600B08D RID: 45197 RVA: 0x002AF8B8 File Offset: 0x002ADAB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Resource.Descriptor;
			}
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x002AF8CF File Offset: 0x002ADACF
		[DebuggerNonUserCode]
		public Resource()
		{
		}

		// Token: 0x0600B08F RID: 45199 RVA: 0x002AF8DC File Offset: 0x002ADADC
		[DebuggerNonUserCode]
		public Resource(Resource other)
			: this()
		{
			this.name_ = other.name_;
			this.value_ = ((other.value_ != null) ? other.value_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B090 RID: 45200 RVA: 0x002AF92C File Offset: 0x002ADB2C
		[DebuggerNonUserCode]
		public Resource Clone()
		{
			return new Resource(this);
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600B091 RID: 45201 RVA: 0x002AF944 File Offset: 0x002ADB44
		// (set) Token: 0x0600B092 RID: 45202 RVA: 0x002AF965 File Offset: 0x002ADB65
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Resource.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600B093 RID: 45203 RVA: 0x002AF97C File Offset: 0x002ADB7C
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600B094 RID: 45204 RVA: 0x002AF997 File Offset: 0x002ADB97
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600B095 RID: 45205 RVA: 0x002AF9A4 File Offset: 0x002ADBA4
		// (set) Token: 0x0600B096 RID: 45206 RVA: 0x002AF9BC File Offset: 0x002ADBBC
		[DebuggerNonUserCode]
		public Data Value
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

		// Token: 0x0600B097 RID: 45207 RVA: 0x002AF9C8 File Offset: 0x002ADBC8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Resource);
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x002AF9E8 File Offset: 0x002ADBE8
		[DebuggerNonUserCode]
		public bool Equals(Resource other)
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
					bool flag4 = this.Name != other.Name;
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

		// Token: 0x0600B099 RID: 45209 RVA: 0x002AFA5C File Offset: 0x002ADC5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
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

		// Token: 0x0600B09A RID: 45210 RVA: 0x002AFAC4 File Offset: 0x002ADCC4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B09B RID: 45211 RVA: 0x002AFADC File Offset: 0x002ADCDC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B09C RID: 45212 RVA: 0x002AFAE8 File Offset: 0x002ADCE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
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

		// Token: 0x0600B09D RID: 45213 RVA: 0x002AFB5C File Offset: 0x002ADD5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
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

		// Token: 0x0600B09E RID: 45214 RVA: 0x002AFBCC File Offset: 0x002ADDCC
		[DebuggerNonUserCode]
		public void MergeFrom(Resource other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool flag2 = other.value_ != null;
				if (flag2)
				{
					bool flag3 = this.value_ == null;
					if (flag3)
					{
						this.Value = new Data();
					}
					this.Value.MergeFrom(other.Value);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x002AFC51 File Offset: 0x002ADE51
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x002AFC5C File Offset: 0x002ADE5C
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
							this.Value = new Data();
						}
						input.ReadMessage(this.Value);
					}
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04004FA4 RID: 20388
		private static readonly MessageParser<Resource> _parser = new MessageParser<Resource>(() => new Resource());

		// Token: 0x04004FA5 RID: 20389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA6 RID: 20390
		public const int NameFieldNumber = 1;

		// Token: 0x04004FA7 RID: 20391
		private static readonly string NameDefaultValue = "";

		// Token: 0x04004FA8 RID: 20392
		private string name_;

		// Token: 0x04004FA9 RID: 20393
		public const int ValueFieldNumber = 2;

		// Token: 0x04004FAA RID: 20394
		private Data value_;
	}
}

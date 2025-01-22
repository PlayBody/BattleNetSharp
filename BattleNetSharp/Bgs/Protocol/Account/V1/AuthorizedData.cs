using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000750 RID: 1872
	public sealed class AuthorizedData : IMessage<AuthorizedData>, IMessage, IEquatable<AuthorizedData>, IDeepCloneable<AuthorizedData>, IBufferMessage
	{
		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x0029F970 File Offset: 0x0029DB70
		[DebuggerNonUserCode]
		public static MessageParser<AuthorizedData> Parser
		{
			get
			{
				return AuthorizedData._parser;
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600AC5B RID: 44123 RVA: 0x0029F988 File Offset: 0x0029DB88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[32];
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x0029F9AC File Offset: 0x0029DBAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AuthorizedData.Descriptor;
			}
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x0029F9C3 File Offset: 0x0029DBC3
		[DebuggerNonUserCode]
		public AuthorizedData()
		{
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x0029F9D8 File Offset: 0x0029DBD8
		[DebuggerNonUserCode]
		public AuthorizedData(AuthorizedData other)
			: this()
		{
			this.data_ = other.data_;
			this.license_ = other.license_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x0029FA10 File Offset: 0x0029DC10
		[DebuggerNonUserCode]
		public AuthorizedData Clone()
		{
			return new AuthorizedData(this);
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x0029FA28 File Offset: 0x0029DC28
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x0029FA49 File Offset: 0x0029DC49
		[DebuggerNonUserCode]
		public string Data
		{
			get
			{
				return this.data_ ?? AuthorizedData.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x0029FA60 File Offset: 0x0029DC60
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x0029FA7B File Offset: 0x0029DC7B
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x0029FA88 File Offset: 0x0029DC88
		[DebuggerNonUserCode]
		public RepeatedField<uint> License
		{
			get
			{
				return this.license_;
			}
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x0029FAA0 File Offset: 0x0029DCA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AuthorizedData);
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x0029FAC0 File Offset: 0x0029DCC0
		[DebuggerNonUserCode]
		public bool Equals(AuthorizedData other)
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
					bool flag4 = this.Data != other.Data;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.license_.Equals(other.license_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x0029FB34 File Offset: 0x0029DD34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			num ^= this.license_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x0029FB8C File Offset: 0x0029DD8C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x0029FBA4 File Offset: 0x0029DDA4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x0029FBB0 File Offset: 0x0029DDB0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Data);
			}
			this.license_.WriteTo(ref output, AuthorizedData._repeated_license_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x0029FC10 File Offset: 0x0029DE10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Data);
			}
			num += this.license_.CalculateSize(AuthorizedData._repeated_license_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x0029FC74 File Offset: 0x0029DE74
		[DebuggerNonUserCode]
		public void MergeFrom(AuthorizedData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this.license_.Add(other.license_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC6D RID: 44141 RVA: 0x0029FCCF File Offset: 0x0029DECF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x0029FCDC File Offset: 0x0029DEDC
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
					if (num3 != 16U && num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.license_.AddEntriesFrom(ref input, AuthorizedData._repeated_license_codec);
					}
				}
				else
				{
					this.Data = input.ReadString();
				}
			}
		}

		// Token: 0x04004DA3 RID: 19875
		private static readonly MessageParser<AuthorizedData> _parser = new MessageParser<AuthorizedData>(() => new AuthorizedData());

		// Token: 0x04004DA4 RID: 19876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DA5 RID: 19877
		public const int DataFieldNumber = 1;

		// Token: 0x04004DA6 RID: 19878
		private static readonly string DataDefaultValue = "";

		// Token: 0x04004DA7 RID: 19879
		private string data_;

		// Token: 0x04004DA8 RID: 19880
		public const int LicenseFieldNumber = 2;

		// Token: 0x04004DA9 RID: 19881
		private static readonly FieldCodec<uint> _repeated_license_codec = FieldCodec.ForUInt32(16U);

		// Token: 0x04004DAA RID: 19882
		private readonly RepeatedField<uint> license_ = new RepeatedField<uint>();
	}
}

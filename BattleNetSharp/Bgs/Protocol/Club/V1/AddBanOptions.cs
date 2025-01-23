using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000439 RID: 1081
	public sealed class AddBanOptions : IMessage<AddBanOptions>, IMessage, IEquatable<AddBanOptions>, IDeepCloneable<AddBanOptions>, IBufferMessage
	{
		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06006A14 RID: 27156 RVA: 0x0019A92C File Offset: 0x00198B2C
		[DebuggerNonUserCode]
		public static MessageParser<AddBanOptions> Parser
		{
			get
			{
				return AddBanOptions._parser;
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x0019A944 File Offset: 0x00198B44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubBanReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06006A16 RID: 27158 RVA: 0x0019A968 File Offset: 0x00198B68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBanOptions.Descriptor;
			}
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0019A97F File Offset: 0x00198B7F
		[DebuggerNonUserCode]
		public AddBanOptions()
		{
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0019A994 File Offset: 0x00198B94
		[DebuggerNonUserCode]
		public AddBanOptions(AddBanOptions other)
			: this()
		{
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x0019A9F4 File Offset: 0x00198BF4
		[DebuggerNonUserCode]
		public AddBanOptions Clone()
		{
			return new AddBanOptions(this);
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x0019AA0C File Offset: 0x00198C0C
		// (set) Token: 0x06006A1B RID: 27163 RVA: 0x0019AA24 File Offset: 0x00198C24
		[DebuggerNonUserCode]
		public MemberId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06006A1C RID: 27164 RVA: 0x0019AA30 File Offset: 0x00198C30
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06006A1D RID: 27165 RVA: 0x0019AA48 File Offset: 0x00198C48
		// (set) Token: 0x06006A1E RID: 27166 RVA: 0x0019AA69 File Offset: 0x00198C69
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				return this.reason_ ?? AddBanOptions.ReasonDefaultValue;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06006A1F RID: 27167 RVA: 0x0019AA80 File Offset: 0x00198C80
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return this.reason_ != null;
			}
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0019AA9B File Offset: 0x00198C9B
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this.reason_ = null;
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0019AAA8 File Offset: 0x00198CA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBanOptions);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0019AAC8 File Offset: 0x00198CC8
		[DebuggerNonUserCode]
		public bool Equals(AddBanOptions other)
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
					bool flag4 = !object.Equals(this.TargetId, other.TargetId);
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
							bool flag6 = this.Reason != other.Reason;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x0019AB5C File Offset: 0x00198D5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num ^= this.TargetId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x0019ABD4 File Offset: 0x00198DD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x0019ABEC File Offset: 0x00198DEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x0019ABF8 File Offset: 0x00198DF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.targetId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.TargetId);
			}
			this.attribute_.WriteTo(ref output, AddBanOptions._repeated_attribute_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x0019AC7C File Offset: 0x00198E7C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.targetId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			num += this.attribute_.CalculateSize(AddBanOptions._repeated_attribute_codec);
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x0019AD00 File Offset: 0x00198F00
		[DebuggerNonUserCode]
		public void MergeFrom(AddBanOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.targetId_ != null;
				if (flag2)
				{
					bool flag3 = this.targetId_ == null;
					if (flag3)
					{
						this.TargetId = new MemberId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				this.attribute_.Add(other.attribute_);
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x0019AD97 File Offset: 0x00198F97
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x0019ADA4 File Offset: 0x00198FA4
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadString();
						}
					}
					else
					{
						this.attribute_.AddEntriesFrom(ref input, AddBanOptions._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.targetId_ == null;
					if (flag)
					{
						this.TargetId = new MemberId();
					}
					input.ReadMessage(this.TargetId);
				}
			}
		}

		// Token: 0x0400304E RID: 12366
		private static readonly MessageParser<AddBanOptions> _parser = new MessageParser<AddBanOptions>(() => new AddBanOptions());

		// Token: 0x0400304F RID: 12367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003050 RID: 12368
		public const int TargetIdFieldNumber = 1;

		// Token: 0x04003051 RID: 12369
		private MemberId targetId_;

		// Token: 0x04003052 RID: 12370
		public const int AttributeFieldNumber = 2;

		// Token: 0x04003053 RID: 12371
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x04003054 RID: 12372
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();

		// Token: 0x04003055 RID: 12373
		public const int ReasonFieldNumber = 3;

		// Token: 0x04003056 RID: 12374
		private static readonly string ReasonDefaultValue = "";

		// Token: 0x04003057 RID: 12375
		private string reason_;
	}
}

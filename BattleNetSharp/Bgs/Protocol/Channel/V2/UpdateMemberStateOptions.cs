using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x0200069F RID: 1695
	public sealed class UpdateMemberStateOptions : IMessage<UpdateMemberStateOptions>, IMessage, IEquatable<UpdateMemberStateOptions>, IDeepCloneable<UpdateMemberStateOptions>, IBufferMessage
	{
		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x00263E04 File Offset: 0x00262004
		[DebuggerNonUserCode]
		public static MessageParser<UpdateMemberStateOptions> Parser
		{
			get
			{
				return UpdateMemberStateOptions._parser;
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x00263E1C File Offset: 0x0026201C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x00263E40 File Offset: 0x00262040
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMemberStateOptions.Descriptor;
			}
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x00263E57 File Offset: 0x00262057
		[DebuggerNonUserCode]
		public UpdateMemberStateOptions()
		{
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x00263E6C File Offset: 0x0026206C
		[DebuggerNonUserCode]
		public UpdateMemberStateOptions(UpdateMemberStateOptions other)
			: this()
		{
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.attribute_ = other.attribute_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x00263EC0 File Offset: 0x002620C0
		[DebuggerNonUserCode]
		public UpdateMemberStateOptions Clone()
		{
			return new UpdateMemberStateOptions(this);
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x00263ED8 File Offset: 0x002620D8
		// (set) Token: 0x06009D5D RID: 40285 RVA: 0x00263EF0 File Offset: 0x002620F0
		[DebuggerNonUserCode]
		public GameAccountHandle MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06009D5E RID: 40286 RVA: 0x00263EFC File Offset: 0x002620FC
		[DebuggerNonUserCode]
		public RepeatedField<Bgs.Protocol.V2.Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x00263F14 File Offset: 0x00262114
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMemberStateOptions);
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x00263F34 File Offset: 0x00262134
		[DebuggerNonUserCode]
		public bool Equals(UpdateMemberStateOptions other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.attribute_.Equals(other.attribute_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x00263FAC File Offset: 0x002621AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x00264008 File Offset: 0x00262208
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x00264020 File Offset: 0x00262220
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x0026402C File Offset: 0x0026222C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			this.attribute_.WriteTo(ref output, UpdateMemberStateOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x00264090 File Offset: 0x00262290
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			num += this.attribute_.CalculateSize(UpdateMemberStateOptions._repeated_attribute_codec);
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x002640F4 File Offset: 0x002622F4
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateMemberStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new GameAccountHandle();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				this.attribute_.Add(other.attribute_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x00264172 File Offset: 0x00262372
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x00264180 File Offset: 0x00262380
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
						this.attribute_.AddEntriesFrom(ref input, UpdateMemberStateOptions._repeated_attribute_codec);
					}
				}
				else
				{
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new GameAccountHandle();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x04004707 RID: 18183
		private static readonly MessageParser<UpdateMemberStateOptions> _parser = new MessageParser<UpdateMemberStateOptions>(() => new UpdateMemberStateOptions());

		// Token: 0x04004708 RID: 18184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004709 RID: 18185
		public const int MemberIdFieldNumber = 1;

		// Token: 0x0400470A RID: 18186
		private GameAccountHandle memberId_;

		// Token: 0x0400470B RID: 18187
		public const int AttributeFieldNumber = 2;

		// Token: 0x0400470C RID: 18188
		private static readonly FieldCodec<Bgs.Protocol.V2.Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Bgs.Protocol.V2.Attribute>(18U, Bgs.Protocol.V2.Attribute.Parser);

		// Token: 0x0400470D RID: 18189
		private readonly RepeatedField<Bgs.Protocol.V2.Attribute> attribute_ = new RepeatedField<Bgs.Protocol.V2.Attribute>();
	}
}

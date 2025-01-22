using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000508 RID: 1288
	public sealed class TagOptions : IMessage<TagOptions>, IMessage, IEquatable<TagOptions>, IDeepCloneable<TagOptions>, IBufferMessage
	{
		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x001EA06C File Offset: 0x001E826C
		[DebuggerNonUserCode]
		public static MessageParser<TagOptions> Parser
		{
			get
			{
				return TagOptions._parser;
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x06007DCF RID: 32207 RVA: 0x001EA084 File Offset: 0x001E8284
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubTagReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x001EA0A8 File Offset: 0x001E82A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TagOptions.Descriptor;
			}
		}

		// Token: 0x06007DD1 RID: 32209 RVA: 0x001EA0BF File Offset: 0x001E82BF
		[DebuggerNonUserCode]
		public TagOptions()
		{
		}

		// Token: 0x06007DD2 RID: 32210 RVA: 0x001EA0D4 File Offset: 0x001E82D4
		[DebuggerNonUserCode]
		public TagOptions(TagOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.action_ = other.action_;
			this.tag_ = other.tag_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DD3 RID: 32211 RVA: 0x001EA124 File Offset: 0x001E8324
		[DebuggerNonUserCode]
		public TagOptions Clone()
		{
			return new TagOptions(this);
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x001EA13C File Offset: 0x001E833C
		// (set) Token: 0x06007DD5 RID: 32213 RVA: 0x001EA16D File Offset: 0x001E836D
		[DebuggerNonUserCode]
		public uint Action
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint actionDefaultValue;
				if (flag)
				{
					actionDefaultValue = this.action_;
				}
				else
				{
					actionDefaultValue = TagOptions.ActionDefaultValue;
				}
				return actionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.action_ = value;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x001EA188 File Offset: 0x001E8388
		[DebuggerNonUserCode]
		public bool HasAction
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007DD7 RID: 32215 RVA: 0x001EA1A5 File Offset: 0x001E83A5
		[DebuggerNonUserCode]
		public void ClearAction()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x001EA1B8 File Offset: 0x001E83B8
		[DebuggerNonUserCode]
		public RepeatedField<TagIdentifier> Tag
		{
			get
			{
				return this.tag_;
			}
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x001EA1D0 File Offset: 0x001E83D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TagOptions);
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x001EA1F0 File Offset: 0x001E83F0
		[DebuggerNonUserCode]
		public bool Equals(TagOptions other)
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
					bool flag4 = this.Action != other.Action;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.tag_.Equals(other.tag_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x001EA264 File Offset: 0x001E8464
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num ^= this.Action.GetHashCode();
			}
			num ^= this.tag_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x001EA2C4 File Offset: 0x001E84C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x001EA2DC File Offset: 0x001E84DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x001EA2E8 File Offset: 0x001E84E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Action);
			}
			this.tag_.WriteTo(ref output, TagOptions._repeated_tag_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x001EA348 File Offset: 0x001E8548
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAction = this.HasAction;
			if (hasAction)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Action);
			}
			num += this.tag_.CalculateSize(TagOptions._repeated_tag_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x001EA3AC File Offset: 0x001E85AC
		[DebuggerNonUserCode]
		public void MergeFrom(TagOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAction = other.HasAction;
				if (hasAction)
				{
					this.Action = other.Action;
				}
				this.tag_.Add(other.tag_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x001EA407 File Offset: 0x001E8607
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x001EA414 File Offset: 0x001E8614
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
						this.tag_.AddEntriesFrom(ref input, TagOptions._repeated_tag_codec);
					}
				}
				else
				{
					this.Action = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003943 RID: 14659
		private static readonly MessageParser<TagOptions> _parser = new MessageParser<TagOptions>(() => new TagOptions());

		// Token: 0x04003944 RID: 14660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003945 RID: 14661
		private int _hasBits0;

		// Token: 0x04003946 RID: 14662
		public const int ActionFieldNumber = 1;

		// Token: 0x04003947 RID: 14663
		private static readonly uint ActionDefaultValue = 0U;

		// Token: 0x04003948 RID: 14664
		private uint action_;

		// Token: 0x04003949 RID: 14665
		public const int TagFieldNumber = 2;

		// Token: 0x0400394A RID: 14666
		private static readonly FieldCodec<TagIdentifier> _repeated_tag_codec = FieldCodec.ForMessage<TagIdentifier>(18U, TagIdentifier.Parser);

		// Token: 0x0400394B RID: 14667
		private readonly RepeatedField<TagIdentifier> tag_ = new RepeatedField<TagIdentifier>();
	}
}

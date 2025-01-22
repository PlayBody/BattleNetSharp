using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V1
{
	// Token: 0x020006F7 RID: 1783
	public sealed class ChatChannelState : IMessage<ChatChannelState>, IMessage, IEquatable<ChatChannelState>, IDeepCloneable<ChatChannelState>, IBufferMessage
	{
		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600A42E RID: 42030 RVA: 0x00280310 File Offset: 0x0027E510
		[DebuggerNonUserCode]
		public static MessageParser<ChatChannelState> Parser
		{
			get
			{
				return ChatChannelState._parser;
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x00280328 File Offset: 0x0027E528
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChatTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600A430 RID: 42032 RVA: 0x0028034C File Offset: 0x0027E54C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatChannelState.Descriptor;
			}
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x00280363 File Offset: 0x0027E563
		[DebuggerNonUserCode]
		public ChatChannelState()
		{
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x00280370 File Offset: 0x0027E570
		[DebuggerNonUserCode]
		public ChatChannelState(ChatChannelState other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.identity_ = other.identity_;
			this.locale_ = other.locale_;
			this.public_ = other.public_;
			this.bucketIndex_ = other.bucketIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x002803D4 File Offset: 0x0027E5D4
		[DebuggerNonUserCode]
		public ChatChannelState Clone()
		{
			return new ChatChannelState(this);
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600A434 RID: 42036 RVA: 0x002803EC File Offset: 0x0027E5EC
		// (set) Token: 0x0600A435 RID: 42037 RVA: 0x0028040D File Offset: 0x0027E60D
		[DebuggerNonUserCode]
		public string Identity
		{
			get
			{
				return this.identity_ ?? ChatChannelState.IdentityDefaultValue;
			}
			set
			{
				this.identity_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600A436 RID: 42038 RVA: 0x00280424 File Offset: 0x0027E624
		[DebuggerNonUserCode]
		public bool HasIdentity
		{
			get
			{
				return this.identity_ != null;
			}
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x0028043F File Offset: 0x0027E63F
		[DebuggerNonUserCode]
		public void ClearIdentity()
		{
			this.identity_ = null;
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600A438 RID: 42040 RVA: 0x0028044C File Offset: 0x0027E64C
		// (set) Token: 0x0600A439 RID: 42041 RVA: 0x0028047D File Offset: 0x0027E67D
		[DebuggerNonUserCode]
		public uint Locale
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint localeDefaultValue;
				if (flag)
				{
					localeDefaultValue = this.locale_;
				}
				else
				{
					localeDefaultValue = ChatChannelState.LocaleDefaultValue;
				}
				return localeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.locale_ = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600A43A RID: 42042 RVA: 0x00280498 File Offset: 0x0027E698
		[DebuggerNonUserCode]
		public bool HasLocale
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x002804B5 File Offset: 0x0027E6B5
		[DebuggerNonUserCode]
		public void ClearLocale()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x002804C8 File Offset: 0x0027E6C8
		// (set) Token: 0x0600A43D RID: 42045 RVA: 0x002804F9 File Offset: 0x0027E6F9
		[DebuggerNonUserCode]
		public bool Public
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool publicDefaultValue;
				if (flag)
				{
					publicDefaultValue = this.public_;
				}
				else
				{
					publicDefaultValue = ChatChannelState.PublicDefaultValue;
				}
				return publicDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.public_ = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x00280514 File Offset: 0x0027E714
		[DebuggerNonUserCode]
		public bool HasPublic
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x00280531 File Offset: 0x0027E731
		[DebuggerNonUserCode]
		public void ClearPublic()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600A440 RID: 42048 RVA: 0x00280544 File Offset: 0x0027E744
		// (set) Token: 0x0600A441 RID: 42049 RVA: 0x00280575 File Offset: 0x0027E775
		[DebuggerNonUserCode]
		public uint BucketIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint bucketIndexDefaultValue;
				if (flag)
				{
					bucketIndexDefaultValue = this.bucketIndex_;
				}
				else
				{
					bucketIndexDefaultValue = ChatChannelState.BucketIndexDefaultValue;
				}
				return bucketIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.bucketIndex_ = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600A442 RID: 42050 RVA: 0x00280590 File Offset: 0x0027E790
		[DebuggerNonUserCode]
		public bool HasBucketIndex
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x002805AD File Offset: 0x0027E7AD
		[DebuggerNonUserCode]
		public void ClearBucketIndex()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x002805C0 File Offset: 0x0027E7C0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatChannelState);
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x002805E0 File Offset: 0x0027E7E0
		[DebuggerNonUserCode]
		public bool Equals(ChatChannelState other)
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
					bool flag4 = this.Identity != other.Identity;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Locale != other.Locale;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Public != other.Public;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.BucketIndex != other.BucketIndex;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x0028068C File Offset: 0x0027E88C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num ^= this.Locale.GetHashCode();
			}
			bool hasPublic = this.HasPublic;
			if (hasPublic)
			{
				num ^= this.Public.GetHashCode();
			}
			bool hasBucketIndex = this.HasBucketIndex;
			if (hasBucketIndex)
			{
				num ^= this.BucketIndex.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x00280730 File Offset: 0x0027E930
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x00280748 File Offset: 0x0027E948
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x00280754 File Offset: 0x0027E954
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Identity);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Locale);
			}
			bool hasPublic = this.HasPublic;
			if (hasPublic)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Public);
			}
			bool hasBucketIndex = this.HasBucketIndex;
			if (hasBucketIndex)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BucketIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x00280808 File Offset: 0x0027EA08
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIdentity = this.HasIdentity;
			if (hasIdentity)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Identity);
			}
			bool hasLocale = this.HasLocale;
			if (hasLocale)
			{
				num += 5;
			}
			bool hasPublic = this.HasPublic;
			if (hasPublic)
			{
				num += 2;
			}
			bool hasBucketIndex = this.HasBucketIndex;
			if (hasBucketIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BucketIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x00280898 File Offset: 0x0027EA98
		[DebuggerNonUserCode]
		public void MergeFrom(ChatChannelState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIdentity = other.HasIdentity;
				if (hasIdentity)
				{
					this.Identity = other.Identity;
				}
				bool hasLocale = other.HasLocale;
				if (hasLocale)
				{
					this.Locale = other.Locale;
				}
				bool hasPublic = other.HasPublic;
				if (hasPublic)
				{
					this.Public = other.Public;
				}
				bool hasBucketIndex = other.HasBucketIndex;
				if (hasBucketIndex)
				{
					this.BucketIndex = other.BucketIndex;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x0028092E File Offset: 0x0027EB2E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x0028093C File Offset: 0x0027EB3C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 29U)
				{
					if (num3 != 10U)
					{
						if (num3 != 29U)
						{
							goto IL_0029;
						}
						this.Locale = input.ReadFixed32();
					}
					else
					{
						this.Identity = input.ReadString();
					}
				}
				else if (num3 != 32U)
				{
					if (num3 != 40U)
					{
						goto IL_0029;
					}
					this.BucketIndex = input.ReadUInt32();
				}
				else
				{
					this.Public = input.ReadBool();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040049FC RID: 18940
		private static readonly MessageParser<ChatChannelState> _parser = new MessageParser<ChatChannelState>(() => new ChatChannelState());

		// Token: 0x040049FD RID: 18941
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FE RID: 18942
		private int _hasBits0;

		// Token: 0x040049FF RID: 18943
		public const int IdentityFieldNumber = 1;

		// Token: 0x04004A00 RID: 18944
		private static readonly string IdentityDefaultValue = "";

		// Token: 0x04004A01 RID: 18945
		private string identity_;

		// Token: 0x04004A02 RID: 18946
		public const int LocaleFieldNumber = 3;

		// Token: 0x04004A03 RID: 18947
		private static readonly uint LocaleDefaultValue = 0U;

		// Token: 0x04004A04 RID: 18948
		private uint locale_;

		// Token: 0x04004A05 RID: 18949
		public const int PublicFieldNumber = 4;

		// Token: 0x04004A06 RID: 18950
		private static readonly bool PublicDefaultValue = false;

		// Token: 0x04004A07 RID: 18951
		private bool public_;

		// Token: 0x04004A08 RID: 18952
		public const int BucketIndexFieldNumber = 5;

		// Token: 0x04004A09 RID: 18953
		private static readonly uint BucketIndexDefaultValue = 0U;

		// Token: 0x04004A0A RID: 18954
		private uint bucketIndex_;

		// Token: 0x02001206 RID: 4614
		[DebuggerNonUserCode]
		public static class Extensions
		{
			// Token: 0x0400992D RID: 39213
			public static readonly Extension<ChannelState, ChatChannelState> ChannelState_ = new Extension<ChannelState, ChatChannelState>(100, FieldCodec.ForMessage<ChatChannelState>(802U, ChatChannelState.Parser));
		}
	}
}

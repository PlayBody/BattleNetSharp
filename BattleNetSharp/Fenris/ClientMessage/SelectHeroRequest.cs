using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000228 RID: 552
	public sealed class SelectHeroRequest : IMessage<SelectHeroRequest>, IMessage, IEquatable<SelectHeroRequest>, IDeepCloneable<SelectHeroRequest>, IBufferMessage
	{
		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x000EE710 File Offset: 0x000EC910
		[DebuggerNonUserCode]
		public static MessageParser<SelectHeroRequest> Parser
		{
			get
			{
				return SelectHeroRequest._parser;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003C04 RID: 15364 RVA: 0x000EE728 File Offset: 0x000EC928
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[24];
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x000EE74C File Offset: 0x000EC94C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectHeroRequest.Descriptor;
			}
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x000EE763 File Offset: 0x000EC963
		[DebuggerNonUserCode]
		public SelectHeroRequest()
		{
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x000EE76D File Offset: 0x000EC96D
		[DebuggerNonUserCode]
		public SelectHeroRequest(SelectHeroRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroId_ = other.heroId_;
			this.worldTier_ = other.worldTier_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x000EE7AC File Offset: 0x000EC9AC
		[DebuggerNonUserCode]
		public SelectHeroRequest Clone()
		{
			return new SelectHeroRequest(this);
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000EE7C4 File Offset: 0x000EC9C4
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x000EE7E5 File Offset: 0x000EC9E5
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? SelectHeroRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000EE7FC File Offset: 0x000EC9FC
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x000EE817 File Offset: 0x000ECA17
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x000EE824 File Offset: 0x000ECA24
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x000EE855 File Offset: 0x000ECA55
		[DebuggerNonUserCode]
		public int WorldTier
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int worldTierDefaultValue;
				if (flag)
				{
					worldTierDefaultValue = this.worldTier_;
				}
				else
				{
					worldTierDefaultValue = SelectHeroRequest.WorldTierDefaultValue;
				}
				return worldTierDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.worldTier_ = value;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x000EE870 File Offset: 0x000ECA70
		[DebuggerNonUserCode]
		public bool HasWorldTier
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x000EE88D File Offset: 0x000ECA8D
		[DebuggerNonUserCode]
		public void ClearWorldTier()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x000EE8A0 File Offset: 0x000ECAA0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectHeroRequest);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x000EE8C0 File Offset: 0x000ECAC0
		[DebuggerNonUserCode]
		public bool Equals(SelectHeroRequest other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.WorldTier != other.WorldTier;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x000EE934 File Offset: 0x000ECB34
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num ^= this.WorldTier.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x000EE9A0 File Offset: 0x000ECBA0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x000EE9B8 File Offset: 0x000ECBB8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x000EE9C4 File Offset: 0x000ECBC4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.WorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x000EEA34 File Offset: 0x000ECC34
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasWorldTier = this.HasWorldTier;
			if (hasWorldTier)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldTier);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x000EEAA0 File Offset: 0x000ECCA0
		[DebuggerNonUserCode]
		public void MergeFrom(SelectHeroRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasWorldTier = other.HasWorldTier;
				if (hasWorldTier)
				{
					this.WorldTier = other.WorldTier;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x000EEB02 File Offset: 0x000ECD02
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x000EEB10 File Offset: 0x000ECD10
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WorldTier = input.ReadSInt32();
					}
				}
				else
				{
					this.HeroId = input.ReadString();
				}
			}
		}

		// Token: 0x04001BCA RID: 7114
		private static readonly MessageParser<SelectHeroRequest> _parser = new MessageParser<SelectHeroRequest>(() => new SelectHeroRequest());

		// Token: 0x04001BCB RID: 7115
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BCC RID: 7116
		private int _hasBits0;

		// Token: 0x04001BCD RID: 7117
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001BCE RID: 7118
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001BCF RID: 7119
		private string heroId_;

		// Token: 0x04001BD0 RID: 7120
		public const int WorldTierFieldNumber = 2;

		// Token: 0x04001BD1 RID: 7121
		private static readonly int WorldTierDefaultValue = 0;

		// Token: 0x04001BD2 RID: 7122
		private int worldTier_;
	}
}

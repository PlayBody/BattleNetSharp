using System;
using System.Diagnostics;
using Fenris.Profile;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000238 RID: 568
	public sealed class GetHeroProfileResponse : IMessage<GetHeroProfileResponse>, IMessage, IEquatable<GetHeroProfileResponse>, IDeepCloneable<GetHeroProfileResponse>, IBufferMessage
	{
		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06003D6F RID: 15727 RVA: 0x000F2B5C File Offset: 0x000F0D5C
		[DebuggerNonUserCode]
		public static MessageParser<GetHeroProfileResponse> Parser
		{
			get
			{
				return GetHeroProfileResponse._parser;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06003D70 RID: 15728 RVA: 0x000F2B74 File Offset: 0x000F0D74
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[40];
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06003D71 RID: 15729 RVA: 0x000F2B98 File Offset: 0x000F0D98
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeroProfileResponse.Descriptor;
			}
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x000F2BAF File Offset: 0x000F0DAF
		[DebuggerNonUserCode]
		public GetHeroProfileResponse()
		{
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x000F2BB9 File Offset: 0x000F0DB9
		[DebuggerNonUserCode]
		public GetHeroProfileResponse(GetHeroProfileResponse other)
			: this()
		{
			this.heroProfile_ = ((other.heroProfile_ != null) ? other.heroProfile_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x000F2BF0 File Offset: 0x000F0DF0
		[DebuggerNonUserCode]
		public GetHeroProfileResponse Clone()
		{
			return new GetHeroProfileResponse(this);
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x000F2C08 File Offset: 0x000F0E08
		// (set) Token: 0x06003D76 RID: 15734 RVA: 0x000F2C20 File Offset: 0x000F0E20
		[DebuggerNonUserCode]
		public HeroProfile HeroProfile
		{
			get
			{
				return this.heroProfile_;
			}
			set
			{
				this.heroProfile_ = value;
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x000F2C2C File Offset: 0x000F0E2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeroProfileResponse);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x000F2C4C File Offset: 0x000F0E4C
		[DebuggerNonUserCode]
		public bool Equals(GetHeroProfileResponse other)
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
					bool flag4 = !object.Equals(this.HeroProfile, other.HeroProfile);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x000F2CA8 File Offset: 0x000F0EA8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.heroProfile_ != null;
			if (flag)
			{
				num ^= this.HeroProfile.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x000F2CF8 File Offset: 0x000F0EF8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x000F2D10 File Offset: 0x000F0F10
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x000F2D1C File Offset: 0x000F0F1C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.heroProfile_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.HeroProfile);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x000F2D6C File Offset: 0x000F0F6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.heroProfile_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HeroProfile);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x000F2DC0 File Offset: 0x000F0FC0
		[DebuggerNonUserCode]
		public void MergeFrom(GetHeroProfileResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.heroProfile_ != null;
				if (flag2)
				{
					bool flag3 = this.heroProfile_ == null;
					if (flag3)
					{
						this.HeroProfile = new HeroProfile();
					}
					this.HeroProfile.MergeFrom(other.HeroProfile);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000F2E2C File Offset: 0x000F102C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x000F2E38 File Offset: 0x000F1038
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.heroProfile_ == null;
					if (flag)
					{
						this.HeroProfile = new HeroProfile();
					}
					input.ReadMessage(this.HeroProfile);
				}
			}
		}

		// Token: 0x04001C3F RID: 7231
		private static readonly MessageParser<GetHeroProfileResponse> _parser = new MessageParser<GetHeroProfileResponse>(() => new GetHeroProfileResponse());

		// Token: 0x04001C40 RID: 7232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C41 RID: 7233
		public const int HeroProfileFieldNumber = 1;

		// Token: 0x04001C42 RID: 7234
		private HeroProfile heroProfile_;
	}
}

using System;
using System.Diagnostics;
using Fenris.Hero;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000223 RID: 547
	public sealed class CreateHeroResponse : IMessage<CreateHeroResponse>, IMessage, IEquatable<CreateHeroResponse>, IDeepCloneable<CreateHeroResponse>, IBufferMessage
	{
		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x000ED24C File Offset: 0x000EB44C
		[DebuggerNonUserCode]
		public static MessageParser<CreateHeroResponse> Parser
		{
			get
			{
				return CreateHeroResponse._parser;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x000ED264 File Offset: 0x000EB464
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[19];
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x000ED288 File Offset: 0x000EB488
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateHeroResponse.Descriptor;
			}
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x000ED29F File Offset: 0x000EB49F
		[DebuggerNonUserCode]
		public CreateHeroResponse()
		{
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x000ED2A9 File Offset: 0x000EB4A9
		[DebuggerNonUserCode]
		public CreateHeroResponse(CreateHeroResponse other)
			: this()
		{
			this.hero_ = ((other.hero_ != null) ? other.hero_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x000ED2E0 File Offset: 0x000EB4E0
		[DebuggerNonUserCode]
		public CreateHeroResponse Clone()
		{
			return new CreateHeroResponse(this);
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x000ED2F8 File Offset: 0x000EB4F8
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x000ED310 File Offset: 0x000EB510
		[DebuggerNonUserCode]
		public Digest Hero
		{
			get
			{
				return this.hero_;
			}
			set
			{
				this.hero_ = value;
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x000ED31C File Offset: 0x000EB51C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateHeroResponse);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x000ED33C File Offset: 0x000EB53C
		[DebuggerNonUserCode]
		public bool Equals(CreateHeroResponse other)
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
					bool flag4 = !object.Equals(this.Hero, other.Hero);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x000ED398 File Offset: 0x000EB598
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num ^= this.Hero.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x000ED3E8 File Offset: 0x000EB5E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x000ED400 File Offset: 0x000EB600
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x000ED40C File Offset: 0x000EB60C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.hero_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Hero);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x000ED45C File Offset: 0x000EB65C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.hero_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Hero);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000ED4B0 File Offset: 0x000EB6B0
		[DebuggerNonUserCode]
		public void MergeFrom(CreateHeroResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.hero_ != null;
				if (flag2)
				{
					bool flag3 = this.hero_ == null;
					if (flag3)
					{
						this.Hero = new Digest();
					}
					this.Hero.MergeFrom(other.Hero);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000ED51C File Offset: 0x000EB71C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x000ED528 File Offset: 0x000EB728
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
					bool flag = this.hero_ == null;
					if (flag)
					{
						this.Hero = new Digest();
					}
					input.ReadMessage(this.Hero);
				}
			}
		}

		// Token: 0x04001BA5 RID: 7077
		private static readonly MessageParser<CreateHeroResponse> _parser = new MessageParser<CreateHeroResponse>(() => new CreateHeroResponse());

		// Token: 0x04001BA6 RID: 7078
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BA7 RID: 7079
		public const int HeroFieldNumber = 1;

		// Token: 0x04001BA8 RID: 7080
		private Digest hero_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000314 RID: 788
	public sealed class StorePurchaseBundle : IMessage<StorePurchaseBundle>, IMessage, IEquatable<StorePurchaseBundle>, IDeepCloneable<StorePurchaseBundle>, IBufferMessage
	{
		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x001404F8 File Offset: 0x0013E6F8
		[DebuggerNonUserCode]
		public static MessageParser<StorePurchaseBundle> Parser
		{
			get
			{
				return StorePurchaseBundle._parser;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x060052ED RID: 21229 RVA: 0x00140510 File Offset: 0x0013E710
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StorePurchaseBundleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x00140534 File Offset: 0x0013E734
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StorePurchaseBundle.Descriptor;
			}
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0014054B File Offset: 0x0013E74B
		[DebuggerNonUserCode]
		public StorePurchaseBundle()
		{
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00140558 File Offset: 0x0013E758
		[DebuggerNonUserCode]
		public StorePurchaseBundle(StorePurchaseBundle other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this.productInfo_ = ((other.productInfo_ != null) ? other.productInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x001405B8 File Offset: 0x0013E7B8
		[DebuggerNonUserCode]
		public StorePurchaseBundle Clone()
		{
			return new StorePurchaseBundle(this);
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x060052F2 RID: 21234 RVA: 0x001405D0 File Offset: 0x0013E7D0
		// (set) Token: 0x060052F3 RID: 21235 RVA: 0x001405E8 File Offset: 0x0013E7E8
		[DebuggerNonUserCode]
		public StoreSessionInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x001405F4 File Offset: 0x0013E7F4
		// (set) Token: 0x060052F5 RID: 21237 RVA: 0x0014060C File Offset: 0x0013E80C
		[DebuggerNonUserCode]
		public StoreProductInfo ProductInfo
		{
			get
			{
				return this.productInfo_;
			}
			set
			{
				this.productInfo_ = value;
			}
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00140618 File Offset: 0x0013E818
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StorePurchaseBundle);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00140638 File Offset: 0x0013E838
		[DebuggerNonUserCode]
		public bool Equals(StorePurchaseBundle other)
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
					bool flag4 = !object.Equals(this.SessionInfo, other.SessionInfo);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ProductInfo, other.ProductInfo);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x001406B0 File Offset: 0x0013E8B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num ^= this.SessionInfo.GetHashCode();
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				num ^= this.ProductInfo.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0014071C File Offset: 0x0013E91C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x00140734 File Offset: 0x0013E934
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00140740 File Offset: 0x0013E940
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ProductInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x001407B4 File Offset: 0x0013E9B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
			}
			bool flag2 = this.productInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ProductInfo);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00140828 File Offset: 0x0013EA28
		[DebuggerNonUserCode]
		public void MergeFrom(StorePurchaseBundle other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionInfo_ == null;
					if (flag3)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					this.SessionInfo.MergeFrom(other.SessionInfo);
				}
				bool flag4 = other.productInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.productInfo_ == null;
					if (flag5)
					{
						this.ProductInfo = new StoreProductInfo();
					}
					this.ProductInfo.MergeFrom(other.ProductInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x001408D5 File Offset: 0x0013EAD5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x001408E0 File Offset: 0x0013EAE0
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
						bool flag = this.productInfo_ == null;
						if (flag)
						{
							this.ProductInfo = new StoreProductInfo();
						}
						input.ReadMessage(this.ProductInfo);
					}
				}
				else
				{
					bool flag2 = this.sessionInfo_ == null;
					if (flag2)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					input.ReadMessage(this.SessionInfo);
				}
			}
		}

		// Token: 0x040025A0 RID: 9632
		private static readonly MessageParser<StorePurchaseBundle> _parser = new MessageParser<StorePurchaseBundle>(() => new StorePurchaseBundle());

		// Token: 0x040025A1 RID: 9633
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A2 RID: 9634
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x040025A3 RID: 9635
		private StoreSessionInfo sessionInfo_;

		// Token: 0x040025A4 RID: 9636
		public const int ProductInfoFieldNumber = 2;

		// Token: 0x040025A5 RID: 9637
		private StoreProductInfo productInfo_;
	}
}

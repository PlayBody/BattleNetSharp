using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200030E RID: 782
	public sealed class StoreInspectBundle : IMessage<StoreInspectBundle>, IMessage, IEquatable<StoreInspectBundle>, IDeepCloneable<StoreInspectBundle>, IBufferMessage
	{
		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x0013F0CC File Offset: 0x0013D2CC
		[DebuggerNonUserCode]
		public static MessageParser<StoreInspectBundle> Parser
		{
			get
			{
				return StoreInspectBundle._parser;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06005298 RID: 21144 RVA: 0x0013F0E4 File Offset: 0x0013D2E4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreInspectBundleReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x0013F108 File Offset: 0x0013D308
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreInspectBundle.Descriptor;
			}
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0013F11F File Offset: 0x0013D31F
		[DebuggerNonUserCode]
		public StoreInspectBundle()
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x0013F12C File Offset: 0x0013D32C
		[DebuggerNonUserCode]
		public StoreInspectBundle(StoreInspectBundle other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this.productInfo_ = ((other.productInfo_ != null) ? other.productInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0013F18C File Offset: 0x0013D38C
		[DebuggerNonUserCode]
		public StoreInspectBundle Clone()
		{
			return new StoreInspectBundle(this);
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x0013F1A4 File Offset: 0x0013D3A4
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x0013F1BC File Offset: 0x0013D3BC
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

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x0013F1C8 File Offset: 0x0013D3C8
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x0013F1E0 File Offset: 0x0013D3E0
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

		// Token: 0x060052A1 RID: 21153 RVA: 0x0013F1EC File Offset: 0x0013D3EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreInspectBundle);
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0013F20C File Offset: 0x0013D40C
		[DebuggerNonUserCode]
		public bool Equals(StoreInspectBundle other)
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

		// Token: 0x060052A3 RID: 21155 RVA: 0x0013F284 File Offset: 0x0013D484
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

		// Token: 0x060052A4 RID: 21156 RVA: 0x0013F2F0 File Offset: 0x0013D4F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0013F308 File Offset: 0x0013D508
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x0013F314 File Offset: 0x0013D514
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

		// Token: 0x060052A7 RID: 21159 RVA: 0x0013F388 File Offset: 0x0013D588
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

		// Token: 0x060052A8 RID: 21160 RVA: 0x0013F3FC File Offset: 0x0013D5FC
		[DebuggerNonUserCode]
		public void MergeFrom(StoreInspectBundle other)
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

		// Token: 0x060052A9 RID: 21161 RVA: 0x0013F4A9 File Offset: 0x0013D6A9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x0013F4B4 File Offset: 0x0013D6B4
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

		// Token: 0x0400257E RID: 9598
		private static readonly MessageParser<StoreInspectBundle> _parser = new MessageParser<StoreInspectBundle>(() => new StoreInspectBundle());

		// Token: 0x0400257F RID: 9599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002580 RID: 9600
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x04002581 RID: 9601
		private StoreSessionInfo sessionInfo_;

		// Token: 0x04002582 RID: 9602
		public const int ProductInfoFieldNumber = 2;

		// Token: 0x04002583 RID: 9603
		private StoreProductInfo productInfo_;
	}
}

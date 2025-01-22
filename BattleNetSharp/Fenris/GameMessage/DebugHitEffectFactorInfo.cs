using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001E2 RID: 482
	public sealed class DebugHitEffectFactorInfo : IMessage<DebugHitEffectFactorInfo>, IMessage, IEquatable<DebugHitEffectFactorInfo>, IDeepCloneable<DebugHitEffectFactorInfo>, IBufferMessage
	{
		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000CEFA4 File Offset: 0x000CD1A4
		[DebuggerNonUserCode]
		public static MessageParser<DebugHitEffectFactorInfo> Parser
		{
			get
			{
				return DebugHitEffectFactorInfo._parser;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x000CEFBC File Offset: 0x000CD1BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[39];
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x000CEFE0 File Offset: 0x000CD1E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugHitEffectFactorInfo.Descriptor;
			}
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000CEFF7 File Offset: 0x000CD1F7
		[DebuggerNonUserCode]
		public DebugHitEffectFactorInfo()
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000CF001 File Offset: 0x000CD201
		[DebuggerNonUserCode]
		public DebugHitEffectFactorInfo(DebugHitEffectFactorInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.factor_ = other.factor_;
			this.description_ = other.description_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000CF040 File Offset: 0x000CD240
		[DebuggerNonUserCode]
		public DebugHitEffectFactorInfo Clone()
		{
			return new DebugHitEffectFactorInfo(this);
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x000CF058 File Offset: 0x000CD258
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x000CF089 File Offset: 0x000CD289
		[DebuggerNonUserCode]
		public float Factor
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float factorDefaultValue;
				if (flag)
				{
					factorDefaultValue = this.factor_;
				}
				else
				{
					factorDefaultValue = DebugHitEffectFactorInfo.FactorDefaultValue;
				}
				return factorDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.factor_ = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x000CF0A4 File Offset: 0x000CD2A4
		[DebuggerNonUserCode]
		public bool HasFactor
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x000CF0C1 File Offset: 0x000CD2C1
		[DebuggerNonUserCode]
		public void ClearFactor()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x000CF0D4 File Offset: 0x000CD2D4
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x000CF0F5 File Offset: 0x000CD2F5
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				return this.description_ ?? DebugHitEffectFactorInfo.DescriptionDefaultValue;
			}
			set
			{
				this.description_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x000CF10C File Offset: 0x000CD30C
		[DebuggerNonUserCode]
		public bool HasDescription
		{
			get
			{
				return this.description_ != null;
			}
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x000CF127 File Offset: 0x000CD327
		[DebuggerNonUserCode]
		public void ClearDescription()
		{
			this.description_ = null;
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x000CF134 File Offset: 0x000CD334
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugHitEffectFactorInfo);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000CF154 File Offset: 0x000CD354
		[DebuggerNonUserCode]
		public bool Equals(DebugHitEffectFactorInfo other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Factor, other.Factor);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Description != other.Description;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000CF1D0 File Offset: 0x000CD3D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasFactor = this.HasFactor;
			if (hasFactor)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Factor);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num ^= this.Description.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000CF23C File Offset: 0x000CD43C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000CF254 File Offset: 0x000CD454
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x000CF260 File Offset: 0x000CD460
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasFactor = this.HasFactor;
			if (hasFactor)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.Factor);
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Description);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000CF2D0 File Offset: 0x000CD4D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasFactor = this.HasFactor;
			if (hasFactor)
			{
				num += 5;
			}
			bool hasDescription = this.HasDescription;
			if (hasDescription)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Description);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000CF330 File Offset: 0x000CD530
		[DebuggerNonUserCode]
		public void MergeFrom(DebugHitEffectFactorInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasFactor = other.HasFactor;
				if (hasFactor)
				{
					this.Factor = other.Factor;
				}
				bool hasDescription = other.HasDescription;
				if (hasDescription)
				{
					this.Description = other.Description;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000CF392 File Offset: 0x000CD592
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000CF3A0 File Offset: 0x000CD5A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Description = input.ReadString();
					}
				}
				else
				{
					this.Factor = input.ReadFloat();
				}
			}
		}

		// Token: 0x0400182E RID: 6190
		private static readonly MessageParser<DebugHitEffectFactorInfo> _parser = new MessageParser<DebugHitEffectFactorInfo>(() => new DebugHitEffectFactorInfo());

		// Token: 0x0400182F RID: 6191
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001830 RID: 6192
		private int _hasBits0;

		// Token: 0x04001831 RID: 6193
		public const int FactorFieldNumber = 1;

		// Token: 0x04001832 RID: 6194
		private static readonly float FactorDefaultValue = 0f;

		// Token: 0x04001833 RID: 6195
		private float factor_;

		// Token: 0x04001834 RID: 6196
		public const int DescriptionFieldNumber = 2;

		// Token: 0x04001835 RID: 6197
		private static readonly string DescriptionDefaultValue = "";

		// Token: 0x04001836 RID: 6198
		private string description_;
	}
}

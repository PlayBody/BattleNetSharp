using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FC RID: 764
	public sealed class AppInitialized : IMessage<AppInitialized>, IMessage, IEquatable<AppInitialized>, IDeepCloneable<AppInitialized>, IBufferMessage
	{
		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600503F RID: 20543 RVA: 0x00134424 File Offset: 0x00132624
		[DebuggerNonUserCode]
		public static MessageParser<AppInitialized> Parser
		{
			get
			{
				return AppInitialized._parser;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x0013443C File Offset: 0x0013263C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AppInitializedReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x00134460 File Offset: 0x00132660
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppInitialized.Descriptor;
			}
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x00134477 File Offset: 0x00132677
		[DebuggerNonUserCode]
		public AppInitialized()
		{
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x00134481 File Offset: 0x00132681
		[DebuggerNonUserCode]
		public AppInitialized(AppInitialized other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.initilizationTime_ = other.initilizationTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x001344B4 File Offset: 0x001326B4
		[DebuggerNonUserCode]
		public AppInitialized Clone()
		{
			return new AppInitialized(this);
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06005045 RID: 20549 RVA: 0x001344CC File Offset: 0x001326CC
		// (set) Token: 0x06005046 RID: 20550 RVA: 0x001344FD File Offset: 0x001326FD
		[DebuggerNonUserCode]
		public float InitilizationTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float initilizationTimeDefaultValue;
				if (flag)
				{
					initilizationTimeDefaultValue = this.initilizationTime_;
				}
				else
				{
					initilizationTimeDefaultValue = AppInitialized.InitilizationTimeDefaultValue;
				}
				return initilizationTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.initilizationTime_ = value;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06005047 RID: 20551 RVA: 0x00134518 File Offset: 0x00132718
		[DebuggerNonUserCode]
		public bool HasInitilizationTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x00134535 File Offset: 0x00132735
		[DebuggerNonUserCode]
		public void ClearInitilizationTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00134548 File Offset: 0x00132748
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppInitialized);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00134568 File Offset: 0x00132768
		[DebuggerNonUserCode]
		public bool Equals(AppInitialized other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.InitilizationTime, other.InitilizationTime);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x001345C8 File Offset: 0x001327C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasInitilizationTime = this.HasInitilizationTime;
			if (hasInitilizationTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.InitilizationTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00134618 File Offset: 0x00132818
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00134630 File Offset: 0x00132830
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x0013463C File Offset: 0x0013283C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasInitilizationTime = this.HasInitilizationTime;
			if (hasInitilizationTime)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.InitilizationTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00134688 File Offset: 0x00132888
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasInitilizationTime = this.HasInitilizationTime;
			if (hasInitilizationTime)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x001346CC File Offset: 0x001328CC
		[DebuggerNonUserCode]
		public void MergeFrom(AppInitialized other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasInitilizationTime = other.HasInitilizationTime;
				if (hasInitilizationTime)
				{
					this.InitilizationTime = other.InitilizationTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00134715 File Offset: 0x00132915
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00134720 File Offset: 0x00132920
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InitilizationTime = input.ReadFloat();
				}
			}
		}

		// Token: 0x04002414 RID: 9236
		private static readonly MessageParser<AppInitialized> _parser = new MessageParser<AppInitialized>(() => new AppInitialized());

		// Token: 0x04002415 RID: 9237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002416 RID: 9238
		private int _hasBits0;

		// Token: 0x04002417 RID: 9239
		public const int InitilizationTimeFieldNumber = 1;

		// Token: 0x04002418 RID: 9240
		private static readonly float InitilizationTimeDefaultValue = 0f;

		// Token: 0x04002419 RID: 9241
		private float initilizationTime_;
	}
}

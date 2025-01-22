using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000045 RID: 69
	public sealed class AnimPermutationInformationRequest : IMessage<AnimPermutationInformationRequest>, IMessage, IEquatable<AnimPermutationInformationRequest>, IDeepCloneable<AnimPermutationInformationRequest>, IBufferMessage
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00019AB0 File Offset: 0x00017CB0
		[DebuggerNonUserCode]
		public static MessageParser<AnimPermutationInformationRequest> Parser
		{
			get
			{
				return AnimPermutationInformationRequest._parser;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00019AC8 File Offset: 0x00017CC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[46];
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00019AEC File Offset: 0x00017CEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimPermutationInformationRequest.Descriptor;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00019B03 File Offset: 0x00017D03
		[DebuggerNonUserCode]
		public AnimPermutationInformationRequest()
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00019B0D File Offset: 0x00017D0D
		[DebuggerNonUserCode]
		public AnimPermutationInformationRequest(AnimPermutationInformationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this.permutationIndex_ = other.permutationIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00019B4C File Offset: 0x00017D4C
		[DebuggerNonUserCode]
		public AnimPermutationInformationRequest Clone()
		{
			return new AnimPermutationInformationRequest(this);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00019B64 File Offset: 0x00017D64
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00019B95 File Offset: 0x00017D95
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = AnimPermutationInformationRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00019BB0 File Offset: 0x00017DB0
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00019BCD File Offset: 0x00017DCD
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00019BE0 File Offset: 0x00017DE0
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00019C11 File Offset: 0x00017E11
		[DebuggerNonUserCode]
		public int PermutationIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int permutationIndexDefaultValue;
				if (flag)
				{
					permutationIndexDefaultValue = this.permutationIndex_;
				}
				else
				{
					permutationIndexDefaultValue = AnimPermutationInformationRequest.PermutationIndexDefaultValue;
				}
				return permutationIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.permutationIndex_ = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00019C2C File Offset: 0x00017E2C
		[DebuggerNonUserCode]
		public bool HasPermutationIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00019C49 File Offset: 0x00017E49
		[DebuggerNonUserCode]
		public void ClearPermutationIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00019C5C File Offset: 0x00017E5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimPermutationInformationRequest);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00019C7C File Offset: 0x00017E7C
		[DebuggerNonUserCode]
		public bool Equals(AnimPermutationInformationRequest other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.PermutationIndex != other.PermutationIndex;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00019CF0 File Offset: 0x00017EF0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				num ^= this.PermutationIndex.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00019D5C File Offset: 0x00017F5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00019D74 File Offset: 0x00017F74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00019D80 File Offset: 0x00017F80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PermutationIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00019DF0 File Offset: 0x00017FF0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool hasPermutationIndex = this.HasPermutationIndex;
			if (hasPermutationIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PermutationIndex);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00019E5C File Offset: 0x0001805C
		[DebuggerNonUserCode]
		public void MergeFrom(AnimPermutationInformationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				bool hasPermutationIndex = other.HasPermutationIndex;
				if (hasPermutationIndex)
				{
					this.PermutationIndex = other.PermutationIndex;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00019EBE File Offset: 0x000180BE
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00019ECC File Offset: 0x000180CC
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PermutationIndex = input.ReadInt32();
					}
				}
				else
				{
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000255 RID: 597
		private static readonly MessageParser<AnimPermutationInformationRequest> _parser = new MessageParser<AnimPermutationInformationRequest>(() => new AnimPermutationInformationRequest());

		// Token: 0x04000256 RID: 598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000257 RID: 599
		private int _hasBits0;

		// Token: 0x04000258 RID: 600
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x04000259 RID: 601
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400025A RID: 602
		private int snoHandle_;

		// Token: 0x0400025B RID: 603
		public const int PermutationIndexFieldNumber = 2;

		// Token: 0x0400025C RID: 604
		private static readonly int PermutationIndexDefaultValue = 0;

		// Token: 0x0400025D RID: 605
		private int permutationIndex_;
	}
}

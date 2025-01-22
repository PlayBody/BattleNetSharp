using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x020002FA RID: 762
	public sealed class ABTestingInfo : IMessage<ABTestingInfo>, IMessage, IEquatable<ABTestingInfo>, IDeepCloneable<ABTestingInfo>, IBufferMessage
	{
		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x00133C9C File Offset: 0x00131E9C
		[DebuggerNonUserCode]
		public static MessageParser<ABTestingInfo> Parser
		{
			get
			{
				return ABTestingInfo._parser;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x00133CB4 File Offset: 0x00131EB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ABTestInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x00133CD8 File Offset: 0x00131ED8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ABTestingInfo.Descriptor;
			}
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x00133CEF File Offset: 0x00131EEF
		[DebuggerNonUserCode]
		public ABTestingInfo()
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00133CFC File Offset: 0x00131EFC
		[DebuggerNonUserCode]
		public ABTestingInfo(ABTestingInfo other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.testSno_ = other.testSno_;
			this.variantIndex_ = other.variantIndex_;
			this.testName_ = other.testName_;
			this.variantName_ = other.variantName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00133D60 File Offset: 0x00131F60
		[DebuggerNonUserCode]
		public ABTestingInfo Clone()
		{
			return new ABTestingInfo(this);
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x00133D78 File Offset: 0x00131F78
		// (set) Token: 0x06005023 RID: 20515 RVA: 0x00133DA9 File Offset: 0x00131FA9
		[DebuggerNonUserCode]
		public int TestSno
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int testSnoDefaultValue;
				if (flag)
				{
					testSnoDefaultValue = this.testSno_;
				}
				else
				{
					testSnoDefaultValue = ABTestingInfo.TestSnoDefaultValue;
				}
				return testSnoDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.testSno_ = value;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x00133DC4 File Offset: 0x00131FC4
		[DebuggerNonUserCode]
		public bool HasTestSno
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00133DE1 File Offset: 0x00131FE1
		[DebuggerNonUserCode]
		public void ClearTestSno()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x00133DF4 File Offset: 0x00131FF4
		// (set) Token: 0x06005027 RID: 20519 RVA: 0x00133E25 File Offset: 0x00132025
		[DebuggerNonUserCode]
		public uint VariantIndex
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint variantIndexDefaultValue;
				if (flag)
				{
					variantIndexDefaultValue = this.variantIndex_;
				}
				else
				{
					variantIndexDefaultValue = ABTestingInfo.VariantIndexDefaultValue;
				}
				return variantIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.variantIndex_ = value;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x00133E40 File Offset: 0x00132040
		[DebuggerNonUserCode]
		public bool HasVariantIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00133E5D File Offset: 0x0013205D
		[DebuggerNonUserCode]
		public void ClearVariantIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x00133E70 File Offset: 0x00132070
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x00133E91 File Offset: 0x00132091
		[DebuggerNonUserCode]
		public string TestName
		{
			get
			{
				return this.testName_ ?? ABTestingInfo.TestNameDefaultValue;
			}
			set
			{
				this.testName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x00133EA8 File Offset: 0x001320A8
		[DebuggerNonUserCode]
		public bool HasTestName
		{
			get
			{
				return this.testName_ != null;
			}
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00133EC3 File Offset: 0x001320C3
		[DebuggerNonUserCode]
		public void ClearTestName()
		{
			this.testName_ = null;
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x00133ED0 File Offset: 0x001320D0
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x00133EF1 File Offset: 0x001320F1
		[DebuggerNonUserCode]
		public string VariantName
		{
			get
			{
				return this.variantName_ ?? ABTestingInfo.VariantNameDefaultValue;
			}
			set
			{
				this.variantName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x00133F08 File Offset: 0x00132108
		[DebuggerNonUserCode]
		public bool HasVariantName
		{
			get
			{
				return this.variantName_ != null;
			}
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00133F23 File Offset: 0x00132123
		[DebuggerNonUserCode]
		public void ClearVariantName()
		{
			this.variantName_ = null;
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00133F30 File Offset: 0x00132130
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ABTestingInfo);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00133F50 File Offset: 0x00132150
		[DebuggerNonUserCode]
		public bool Equals(ABTestingInfo other)
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
					bool flag4 = this.TestSno != other.TestSno;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.VariantIndex != other.VariantIndex;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TestName != other.TestName;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.VariantName != other.VariantName;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00133FFC File Offset: 0x001321FC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTestSno = this.HasTestSno;
			if (hasTestSno)
			{
				num ^= this.TestSno.GetHashCode();
			}
			bool hasVariantIndex = this.HasVariantIndex;
			if (hasVariantIndex)
			{
				num ^= this.VariantIndex.GetHashCode();
			}
			bool hasTestName = this.HasTestName;
			if (hasTestName)
			{
				num ^= this.TestName.GetHashCode();
			}
			bool hasVariantName = this.HasVariantName;
			if (hasVariantName)
			{
				num ^= this.VariantName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x001340A0 File Offset: 0x001322A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x001340B8 File Offset: 0x001322B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x001340C4 File Offset: 0x001322C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTestSno = this.HasTestSno;
			if (hasTestSno)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.TestSno);
			}
			bool hasVariantIndex = this.HasVariantIndex;
			if (hasVariantIndex)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.VariantIndex);
			}
			bool hasTestName = this.HasTestName;
			if (hasTestName)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TestName);
			}
			bool hasVariantName = this.HasVariantName;
			if (hasVariantName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.VariantName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00134178 File Offset: 0x00132378
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTestSno = this.HasTestSno;
			if (hasTestSno)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.TestSno);
			}
			bool hasVariantIndex = this.HasVariantIndex;
			if (hasVariantIndex)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VariantIndex);
			}
			bool hasTestName = this.HasTestName;
			if (hasTestName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TestName);
			}
			bool hasVariantName = this.HasVariantName;
			if (hasVariantName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VariantName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00134220 File Offset: 0x00132420
		[DebuggerNonUserCode]
		public void MergeFrom(ABTestingInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTestSno = other.HasTestSno;
				if (hasTestSno)
				{
					this.TestSno = other.TestSno;
				}
				bool hasVariantIndex = other.HasVariantIndex;
				if (hasVariantIndex)
				{
					this.VariantIndex = other.VariantIndex;
				}
				bool hasTestName = other.HasTestName;
				if (hasTestName)
				{
					this.TestName = other.TestName;
				}
				bool hasVariantName = other.HasVariantName;
				if (hasVariantName)
				{
					this.VariantName = other.VariantName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x001342B6 File Offset: 0x001324B6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x001342C4 File Offset: 0x001324C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 8U)
					{
						if (num3 != 16U)
						{
							goto IL_0028;
						}
						this.VariantIndex = input.ReadUInt32();
					}
					else
					{
						this.TestSno = input.ReadSInt32();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_0028;
					}
					this.VariantName = input.ReadString();
				}
				else
				{
					this.TestName = input.ReadString();
				}
				continue;
				IL_0028:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002404 RID: 9220
		private static readonly MessageParser<ABTestingInfo> _parser = new MessageParser<ABTestingInfo>(() => new ABTestingInfo());

		// Token: 0x04002405 RID: 9221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002406 RID: 9222
		private int _hasBits0;

		// Token: 0x04002407 RID: 9223
		public const int TestSnoFieldNumber = 1;

		// Token: 0x04002408 RID: 9224
		private static readonly int TestSnoDefaultValue = 0;

		// Token: 0x04002409 RID: 9225
		private int testSno_;

		// Token: 0x0400240A RID: 9226
		public const int VariantIndexFieldNumber = 2;

		// Token: 0x0400240B RID: 9227
		private static readonly uint VariantIndexDefaultValue = 0U;

		// Token: 0x0400240C RID: 9228
		private uint variantIndex_;

		// Token: 0x0400240D RID: 9229
		public const int TestNameFieldNumber = 3;

		// Token: 0x0400240E RID: 9230
		private static readonly string TestNameDefaultValue = "";

		// Token: 0x0400240F RID: 9231
		private string testName_;

		// Token: 0x04002410 RID: 9232
		public const int VariantNameFieldNumber = 4;

		// Token: 0x04002411 RID: 9233
		private static readonly string VariantNameDefaultValue = "";

		// Token: 0x04002412 RID: 9234
		private string variantName_;
	}
}

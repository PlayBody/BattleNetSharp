using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001F2 RID: 498
	public sealed class DebugLootValueRecord : IMessage<DebugLootValueRecord>, IMessage, IEquatable<DebugLootValueRecord>, IDeepCloneable<DebugLootValueRecord>, IBufferMessage
	{
		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x000D6EC8 File Offset: 0x000D50C8
		[DebuggerNonUserCode]
		public static MessageParser<DebugLootValueRecord> Parser
		{
			get
			{
				return DebugLootValueRecord._parser;
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x000D6EE0 File Offset: 0x000D50E0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[55];
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x000D6F04 File Offset: 0x000D5104
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DebugLootValueRecord.Descriptor;
			}
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x000D6F1B File Offset: 0x000D511B
		[DebuggerNonUserCode]
		public DebugLootValueRecord()
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x000D6F28 File Offset: 0x000D5128
		[DebuggerNonUserCode]
		public DebugLootValueRecord(DebugLootValueRecord other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.dataFloat_ = other.dataFloat_;
			this.dataInt_ = other.dataInt_;
			this.operation_ = other.operation_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x000D6F8C File Offset: 0x000D518C
		[DebuggerNonUserCode]
		public DebugLootValueRecord Clone()
		{
			return new DebugLootValueRecord(this);
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x000D6FA4 File Offset: 0x000D51A4
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x000D6FD5 File Offset: 0x000D51D5
		[DebuggerNonUserCode]
		public float DataFloat
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float dataFloatDefaultValue;
				if (flag)
				{
					dataFloatDefaultValue = this.dataFloat_;
				}
				else
				{
					dataFloatDefaultValue = DebugLootValueRecord.DataFloatDefaultValue;
				}
				return dataFloatDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.dataFloat_ = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x000D6FF0 File Offset: 0x000D51F0
		[DebuggerNonUserCode]
		public bool HasDataFloat
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x000D700D File Offset: 0x000D520D
		[DebuggerNonUserCode]
		public void ClearDataFloat()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x000D7020 File Offset: 0x000D5220
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x000D7051 File Offset: 0x000D5251
		[DebuggerNonUserCode]
		public int DataInt
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				int dataIntDefaultValue;
				if (flag)
				{
					dataIntDefaultValue = this.dataInt_;
				}
				else
				{
					dataIntDefaultValue = DebugLootValueRecord.DataIntDefaultValue;
				}
				return dataIntDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.dataInt_ = value;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x000D706C File Offset: 0x000D526C
		[DebuggerNonUserCode]
		public bool HasDataInt
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x000D7089 File Offset: 0x000D5289
		[DebuggerNonUserCode]
		public void ClearDataInt()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x000D709C File Offset: 0x000D529C
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x000D70CD File Offset: 0x000D52CD
		[DebuggerNonUserCode]
		public int Operation
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				int operationDefaultValue;
				if (flag)
				{
					operationDefaultValue = this.operation_;
				}
				else
				{
					operationDefaultValue = DebugLootValueRecord.OperationDefaultValue;
				}
				return operationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.operation_ = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x000D70E8 File Offset: 0x000D52E8
		[DebuggerNonUserCode]
		public bool HasOperation
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x000D7105 File Offset: 0x000D5305
		[DebuggerNonUserCode]
		public void ClearOperation()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x000D7118 File Offset: 0x000D5318
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x000D7139 File Offset: 0x000D5339
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				return this.reason_ ?? DebugLootValueRecord.ReasonDefaultValue;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x000D7150 File Offset: 0x000D5350
		[DebuggerNonUserCode]
		public bool HasReason
		{
			get
			{
				return this.reason_ != null;
			}
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x000D716B File Offset: 0x000D536B
		[DebuggerNonUserCode]
		public void ClearReason()
		{
			this.reason_ = null;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x000D7178 File Offset: 0x000D5378
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DebugLootValueRecord);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x000D7198 File Offset: 0x000D5398
		[DebuggerNonUserCode]
		public bool Equals(DebugLootValueRecord other)
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
					bool flag4 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DataFloat, other.DataFloat);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DataInt != other.DataInt;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Operation != other.Operation;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Reason != other.Reason;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x000D7250 File Offset: 0x000D5450
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasDataFloat = this.HasDataFloat;
			if (hasDataFloat)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DataFloat);
			}
			bool hasDataInt = this.HasDataInt;
			if (hasDataInt)
			{
				num ^= this.DataInt.GetHashCode();
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num ^= this.Operation.GetHashCode();
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x000D72F8 File Offset: 0x000D54F8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x000D7310 File Offset: 0x000D5510
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x000D731C File Offset: 0x000D551C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasDataFloat = this.HasDataFloat;
			if (hasDataFloat)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.DataFloat);
			}
			bool hasDataInt = this.HasDataInt;
			if (hasDataInt)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DataInt);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Operation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x000D73D0 File Offset: 0x000D55D0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasDataFloat = this.HasDataFloat;
			if (hasDataFloat)
			{
				num += 5;
			}
			bool hasDataInt = this.HasDataInt;
			if (hasDataInt)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DataInt);
			}
			bool hasOperation = this.HasOperation;
			if (hasOperation)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Operation);
			}
			bool hasReason = this.HasReason;
			if (hasReason)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000D746C File Offset: 0x000D566C
		[DebuggerNonUserCode]
		public void MergeFrom(DebugLootValueRecord other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasDataFloat = other.HasDataFloat;
				if (hasDataFloat)
				{
					this.DataFloat = other.DataFloat;
				}
				bool hasDataInt = other.HasDataInt;
				if (hasDataInt)
				{
					this.DataInt = other.DataInt;
				}
				bool hasOperation = other.HasOperation;
				if (hasOperation)
				{
					this.Operation = other.Operation;
				}
				bool hasReason = other.HasReason;
				if (hasReason)
				{
					this.Reason = other.Reason;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x000D7502 File Offset: 0x000D5702
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x000D7510 File Offset: 0x000D5710
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
					if (num3 != 13U)
					{
						if (num3 != 16U)
						{
							goto IL_0029;
						}
						this.DataInt = input.ReadInt32();
					}
					else
					{
						this.DataFloat = input.ReadFloat();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						goto IL_0029;
					}
					this.Reason = input.ReadString();
				}
				else
				{
					this.Operation = input.ReadInt32();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400193A RID: 6458
		private static readonly MessageParser<DebugLootValueRecord> _parser = new MessageParser<DebugLootValueRecord>(() => new DebugLootValueRecord());

		// Token: 0x0400193B RID: 6459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400193C RID: 6460
		private int _hasBits0;

		// Token: 0x0400193D RID: 6461
		public const int DataFloatFieldNumber = 1;

		// Token: 0x0400193E RID: 6462
		private static readonly float DataFloatDefaultValue = 0f;

		// Token: 0x0400193F RID: 6463
		private float dataFloat_;

		// Token: 0x04001940 RID: 6464
		public const int DataIntFieldNumber = 2;

		// Token: 0x04001941 RID: 6465
		private static readonly int DataIntDefaultValue = 0;

		// Token: 0x04001942 RID: 6466
		private int dataInt_;

		// Token: 0x04001943 RID: 6467
		public const int OperationFieldNumber = 3;

		// Token: 0x04001944 RID: 6468
		private static readonly int OperationDefaultValue = 0;

		// Token: 0x04001945 RID: 6469
		private int operation_;

		// Token: 0x04001946 RID: 6470
		public const int ReasonFieldNumber = 4;

		// Token: 0x04001947 RID: 6471
		private static readonly string ReasonDefaultValue = "";

		// Token: 0x04001948 RID: 6472
		private string reason_;
	}
}

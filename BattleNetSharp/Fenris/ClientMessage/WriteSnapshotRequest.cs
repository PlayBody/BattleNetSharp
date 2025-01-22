using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000291 RID: 657
	public sealed class WriteSnapshotRequest : IMessage<WriteSnapshotRequest>, IMessage, IEquatable<WriteSnapshotRequest>, IDeepCloneable<WriteSnapshotRequest>, IBufferMessage
	{
		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x0010BE40 File Offset: 0x0010A040
		[DebuggerNonUserCode]
		public static MessageParser<WriteSnapshotRequest> Parser
		{
			get
			{
				return WriteSnapshotRequest._parser;
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x060045CB RID: 17867 RVA: 0x0010BE58 File Offset: 0x0010A058
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[129];
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x0010BE80 File Offset: 0x0010A080
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WriteSnapshotRequest.Descriptor;
			}
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x0010BE97 File Offset: 0x0010A097
		[DebuggerNonUserCode]
		public WriteSnapshotRequest()
		{
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x0010BEA1 File Offset: 0x0010A0A1
		[DebuggerNonUserCode]
		public WriteSnapshotRequest(WriteSnapshotRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetGameAccountId_ = other.targetGameAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x0010BED4 File Offset: 0x0010A0D4
		[DebuggerNonUserCode]
		public WriteSnapshotRequest Clone()
		{
			return new WriteSnapshotRequest(this);
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x0010BEEC File Offset: 0x0010A0EC
		// (set) Token: 0x060045D1 RID: 17873 RVA: 0x0010BF1D File Offset: 0x0010A11D
		[DebuggerNonUserCode]
		public uint TargetGameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountIdDefaultValue;
				if (flag)
				{
					targetGameAccountIdDefaultValue = this.targetGameAccountId_;
				}
				else
				{
					targetGameAccountIdDefaultValue = WriteSnapshotRequest.TargetGameAccountIdDefaultValue;
				}
				return targetGameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccountId_ = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x0010BF38 File Offset: 0x0010A138
		[DebuggerNonUserCode]
		public bool HasTargetGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x0010BF55 File Offset: 0x0010A155
		[DebuggerNonUserCode]
		public void ClearTargetGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x0010BF68 File Offset: 0x0010A168
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as WriteSnapshotRequest);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x0010BF88 File Offset: 0x0010A188
		[DebuggerNonUserCode]
		public bool Equals(WriteSnapshotRequest other)
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
					bool flag4 = this.TargetGameAccountId != other.TargetGameAccountId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x0010BFE0 File Offset: 0x0010A1E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num ^= this.TargetGameAccountId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x0010C030 File Offset: 0x0010A230
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x0010C048 File Offset: 0x0010A248
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x0010C054 File Offset: 0x0010A254
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x0010C0A0 File Offset: 0x0010A2A0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetGameAccountId = this.HasTargetGameAccountId;
			if (hasTargetGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccountId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x0010C0F0 File Offset: 0x0010A2F0
		[DebuggerNonUserCode]
		public void MergeFrom(WriteSnapshotRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetGameAccountId = other.HasTargetGameAccountId;
				if (hasTargetGameAccountId)
				{
					this.TargetGameAccountId = other.TargetGameAccountId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x0010C139 File Offset: 0x0010A339
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x0010C144 File Offset: 0x0010A344
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetGameAccountId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F25 RID: 7973
		private static readonly MessageParser<WriteSnapshotRequest> _parser = new MessageParser<WriteSnapshotRequest>(() => new WriteSnapshotRequest());

		// Token: 0x04001F26 RID: 7974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F27 RID: 7975
		private int _hasBits0;

		// Token: 0x04001F28 RID: 7976
		public const int TargetGameAccountIdFieldNumber = 1;

		// Token: 0x04001F29 RID: 7977
		private static readonly uint TargetGameAccountIdDefaultValue = 0U;

		// Token: 0x04001F2A RID: 7978
		private uint targetGameAccountId_;
	}
}

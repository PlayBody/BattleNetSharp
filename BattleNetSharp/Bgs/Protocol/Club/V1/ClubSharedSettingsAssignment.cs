using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000474 RID: 1140
	public sealed class ClubSharedSettingsAssignment : IMessage<ClubSharedSettingsAssignment>, IMessage, IEquatable<ClubSharedSettingsAssignment>, IDeepCloneable<ClubSharedSettingsAssignment>, IBufferMessage
	{
		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x06006F61 RID: 28513 RVA: 0x001B1210 File Offset: 0x001AF410
		[DebuggerNonUserCode]
		public static MessageParser<ClubSharedSettingsAssignment> Parser
		{
			get
			{
				return ClubSharedSettingsAssignment._parser;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x001B1228 File Offset: 0x001AF428
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x06006F63 RID: 28515 RVA: 0x001B124C File Offset: 0x001AF44C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSharedSettingsAssignment.Descriptor;
			}
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x001B1263 File Offset: 0x001AF463
		[DebuggerNonUserCode]
		public ClubSharedSettingsAssignment()
		{
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x001B126D File Offset: 0x001AF46D
		[DebuggerNonUserCode]
		public ClubSharedSettingsAssignment(ClubSharedSettingsAssignment other)
			: this()
		{
			this.clubPosition_ = ((other.clubPosition_ != null) ? other.clubPosition_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x001B12A4 File Offset: 0x001AF4A4
		[DebuggerNonUserCode]
		public ClubSharedSettingsAssignment Clone()
		{
			return new ClubSharedSettingsAssignment(this);
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x06006F67 RID: 28519 RVA: 0x001B12BC File Offset: 0x001AF4BC
		// (set) Token: 0x06006F68 RID: 28520 RVA: 0x001B12D4 File Offset: 0x001AF4D4
		[DebuggerNonUserCode]
		public ClubPosition ClubPosition
		{
			get
			{
				return this.clubPosition_;
			}
			set
			{
				this.clubPosition_ = value;
			}
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x001B12E0 File Offset: 0x001AF4E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSharedSettingsAssignment);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x001B1300 File Offset: 0x001AF500
		[DebuggerNonUserCode]
		public bool Equals(ClubSharedSettingsAssignment other)
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
					bool flag4 = !object.Equals(this.ClubPosition, other.ClubPosition);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x001B135C File Offset: 0x001AF55C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				num ^= this.ClubPosition.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x001B13AC File Offset: 0x001AF5AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x001B13C4 File Offset: 0x001AF5C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x001B13D0 File Offset: 0x001AF5D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ClubPosition);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x001B1420 File Offset: 0x001AF620
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClubPosition);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x001B1474 File Offset: 0x001AF674
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSharedSettingsAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.clubPosition_ != null;
				if (flag2)
				{
					bool flag3 = this.clubPosition_ == null;
					if (flag3)
					{
						this.ClubPosition = new ClubPosition();
					}
					this.ClubPosition.MergeFrom(other.ClubPosition);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x001B14E0 File Offset: 0x001AF6E0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x001B14EC File Offset: 0x001AF6EC
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
					bool flag = this.clubPosition_ == null;
					if (flag)
					{
						this.ClubPosition = new ClubPosition();
					}
					input.ReadMessage(this.ClubPosition);
				}
			}
		}

		// Token: 0x0400331A RID: 13082
		private static readonly MessageParser<ClubSharedSettingsAssignment> _parser = new MessageParser<ClubSharedSettingsAssignment>(() => new ClubSharedSettingsAssignment());

		// Token: 0x0400331B RID: 13083
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400331C RID: 13084
		public const int ClubPositionFieldNumber = 1;

		// Token: 0x0400331D RID: 13085
		private ClubPosition clubPosition_;
	}
}

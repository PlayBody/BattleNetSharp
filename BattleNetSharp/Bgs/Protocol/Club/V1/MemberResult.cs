using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200045D RID: 1117
	public sealed class MemberResult : IMessage<MemberResult>, IMessage, IEquatable<MemberResult>, IDeepCloneable<MemberResult>, IBufferMessage
	{
		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x06006D5A RID: 27994 RVA: 0x001AA0D0 File Offset: 0x001A82D0
		[DebuggerNonUserCode]
		public static MessageParser<MemberResult> Parser
		{
			get
			{
				return MemberResult._parser;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x06006D5B RID: 27995 RVA: 0x001AA0E8 File Offset: 0x001A82E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x06006D5C RID: 27996 RVA: 0x001AA10C File Offset: 0x001A830C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemberResult.Descriptor;
			}
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001AA123 File Offset: 0x001A8323
		[DebuggerNonUserCode]
		public MemberResult()
		{
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001AA130 File Offset: 0x001A8330
		[DebuggerNonUserCode]
		public MemberResult(MemberResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.memberId_ = ((other.memberId_ != null) ? other.memberId_.Clone() : null);
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001AA18C File Offset: 0x001A838C
		[DebuggerNonUserCode]
		public MemberResult Clone()
		{
			return new MemberResult(this);
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06006D60 RID: 28000 RVA: 0x001AA1A4 File Offset: 0x001A83A4
		// (set) Token: 0x06006D61 RID: 28001 RVA: 0x001AA1BC File Offset: 0x001A83BC
		[DebuggerNonUserCode]
		public MemberId MemberId
		{
			get
			{
				return this.memberId_;
			}
			set
			{
				this.memberId_ = value;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x001AA1C8 File Offset: 0x001A83C8
		// (set) Token: 0x06006D63 RID: 28003 RVA: 0x001AA1F9 File Offset: 0x001A83F9
		[DebuggerNonUserCode]
		public uint Status
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint statusDefaultValue;
				if (flag)
				{
					statusDefaultValue = this.status_;
				}
				else
				{
					statusDefaultValue = MemberResult.StatusDefaultValue;
				}
				return statusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.status_ = value;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x001AA214 File Offset: 0x001A8414
		[DebuggerNonUserCode]
		public bool HasStatus
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001AA231 File Offset: 0x001A8431
		[DebuggerNonUserCode]
		public void ClearStatus()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x001AA244 File Offset: 0x001A8444
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemberResult);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x001AA264 File Offset: 0x001A8464
		[DebuggerNonUserCode]
		public bool Equals(MemberResult other)
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
					bool flag4 = !object.Equals(this.MemberId, other.MemberId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Status != other.Status;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001AA2D8 File Offset: 0x001A84D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num ^= this.MemberId.GetHashCode();
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num ^= this.Status.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x001AA344 File Offset: 0x001A8544
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x001AA35C File Offset: 0x001A855C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x001AA368 File Offset: 0x001A8568
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.memberId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.MemberId);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Status);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x001AA3DC File Offset: 0x001A85DC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.memberId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MemberId);
			}
			bool hasStatus = this.HasStatus;
			if (hasStatus)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Status);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x001AA44C File Offset: 0x001A864C
		[DebuggerNonUserCode]
		public void MergeFrom(MemberResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.memberId_ != null;
				if (flag2)
				{
					bool flag3 = this.memberId_ == null;
					if (flag3)
					{
						this.MemberId = new MemberId();
					}
					this.MemberId.MergeFrom(other.MemberId);
				}
				bool hasStatus = other.HasStatus;
				if (hasStatus)
				{
					this.Status = other.Status;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x001AA4D1 File Offset: 0x001A86D1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x001AA4DC File Offset: 0x001A86DC
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.memberId_ == null;
					if (flag)
					{
						this.MemberId = new MemberId();
					}
					input.ReadMessage(this.MemberId);
				}
			}
		}

		// Token: 0x04003256 RID: 12886
		private static readonly MessageParser<MemberResult> _parser = new MessageParser<MemberResult>(() => new MemberResult());

		// Token: 0x04003257 RID: 12887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003258 RID: 12888
		private int _hasBits0;

		// Token: 0x04003259 RID: 12889
		public const int MemberIdFieldNumber = 1;

		// Token: 0x0400325A RID: 12890
		private MemberId memberId_;

		// Token: 0x0400325B RID: 12891
		public const int StatusFieldNumber = 2;

		// Token: 0x0400325C RID: 12892
		private static readonly uint StatusDefaultValue = 0U;

		// Token: 0x0400325D RID: 12893
		private uint status_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000472 RID: 1138
	public sealed class ClubSharedSettings : IMessage<ClubSharedSettings>, IMessage, IEquatable<ClubSharedSettings>, IDeepCloneable<ClubSharedSettings>, IBufferMessage
	{
		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x001B0B40 File Offset: 0x001AED40
		[DebuggerNonUserCode]
		public static MessageParser<ClubSharedSettings> Parser
		{
			get
			{
				return ClubSharedSettings._parser;
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x06006F3C RID: 28476 RVA: 0x001B0B58 File Offset: 0x001AED58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x001B0B7C File Offset: 0x001AED7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSharedSettings.Descriptor;
			}
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x001B0B93 File Offset: 0x001AED93
		[DebuggerNonUserCode]
		public ClubSharedSettings()
		{
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x001B0B9D File Offset: 0x001AED9D
		[DebuggerNonUserCode]
		public ClubSharedSettings(ClubSharedSettings other)
			: this()
		{
			this.clubPosition_ = ((other.clubPosition_ != null) ? other.clubPosition_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x001B0BD4 File Offset: 0x001AEDD4
		[DebuggerNonUserCode]
		public ClubSharedSettings Clone()
		{
			return new ClubSharedSettings(this);
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x001B0BEC File Offset: 0x001AEDEC
		// (set) Token: 0x06006F42 RID: 28482 RVA: 0x001B0C04 File Offset: 0x001AEE04
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

		// Token: 0x06006F43 RID: 28483 RVA: 0x001B0C10 File Offset: 0x001AEE10
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSharedSettings);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x001B0C30 File Offset: 0x001AEE30
		[DebuggerNonUserCode]
		public bool Equals(ClubSharedSettings other)
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

		// Token: 0x06006F45 RID: 28485 RVA: 0x001B0C8C File Offset: 0x001AEE8C
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

		// Token: 0x06006F46 RID: 28486 RVA: 0x001B0CDC File Offset: 0x001AEEDC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x001B0CF4 File Offset: 0x001AEEF4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x001B0D00 File Offset: 0x001AEF00
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

		// Token: 0x06006F49 RID: 28489 RVA: 0x001B0D50 File Offset: 0x001AEF50
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

		// Token: 0x06006F4A RID: 28490 RVA: 0x001B0DA4 File Offset: 0x001AEFA4
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSharedSettings other)
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

		// Token: 0x06006F4B RID: 28491 RVA: 0x001B0E10 File Offset: 0x001AF010
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x001B0E1C File Offset: 0x001AF01C
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

		// Token: 0x04003312 RID: 13074
		private static readonly MessageParser<ClubSharedSettings> _parser = new MessageParser<ClubSharedSettings>(() => new ClubSharedSettings());

		// Token: 0x04003313 RID: 13075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003314 RID: 13076
		public const int ClubPositionFieldNumber = 1;

		// Token: 0x04003315 RID: 13077
		private ClubPosition clubPosition_;
	}
}

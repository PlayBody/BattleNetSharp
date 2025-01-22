using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063F RID: 1599
	public sealed class RecentPlayerRemovedAssignment : IMessage<RecentPlayerRemovedAssignment>, IMessage, IEquatable<RecentPlayerRemovedAssignment>, IDeepCloneable<RecentPlayerRemovedAssignment>, IBufferMessage
	{
		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x060094C0 RID: 38080 RVA: 0x0023FCB8 File Offset: 0x0023DEB8
		[DebuggerNonUserCode]
		public static MessageParser<RecentPlayerRemovedAssignment> Parser
		{
			get
			{
				return RecentPlayerRemovedAssignment._parser;
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x060094C1 RID: 38081 RVA: 0x0023FCD0 File Offset: 0x0023DED0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x060094C2 RID: 38082 RVA: 0x0023FCF4 File Offset: 0x0023DEF4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentPlayerRemovedAssignment.Descriptor;
			}
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x0023FD0B File Offset: 0x0023DF0B
		[DebuggerNonUserCode]
		public RecentPlayerRemovedAssignment()
		{
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x0023FD15 File Offset: 0x0023DF15
		[DebuggerNonUserCode]
		public RecentPlayerRemovedAssignment(RecentPlayerRemovedAssignment other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x0023FD48 File Offset: 0x0023DF48
		[DebuggerNonUserCode]
		public RecentPlayerRemovedAssignment Clone()
		{
			return new RecentPlayerRemovedAssignment(this);
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x0023FD60 File Offset: 0x0023DF60
		// (set) Token: 0x060094C7 RID: 38087 RVA: 0x0023FD91 File Offset: 0x0023DF91
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = RecentPlayerRemovedAssignment.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x060094C8 RID: 38088 RVA: 0x0023FDAC File Offset: 0x0023DFAC
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x0023FDC9 File Offset: 0x0023DFC9
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x0023FDDC File Offset: 0x0023DFDC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentPlayerRemovedAssignment);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x0023FDFC File Offset: 0x0023DFFC
		[DebuggerNonUserCode]
		public bool Equals(RecentPlayerRemovedAssignment other)
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
					bool flag4 = this.Id != other.Id;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x0023FE54 File Offset: 0x0023E054
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x0023FEA4 File Offset: 0x0023E0A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x0023FEBC File Offset: 0x0023E0BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x0023FEC8 File Offset: 0x0023E0C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x0023FF14 File Offset: 0x0023E114
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x0023FF64 File Offset: 0x0023E164
		[DebuggerNonUserCode]
		public void MergeFrom(RecentPlayerRemovedAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x0023FFAD File Offset: 0x0023E1AD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x0023FFB8 File Offset: 0x0023E1B8
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
					this.Id = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04004303 RID: 17155
		private static readonly MessageParser<RecentPlayerRemovedAssignment> _parser = new MessageParser<RecentPlayerRemovedAssignment>(() => new RecentPlayerRemovedAssignment());

		// Token: 0x04004304 RID: 17156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004305 RID: 17157
		private int _hasBits0;

		// Token: 0x04004306 RID: 17158
		public const int IdFieldNumber = 1;

		// Token: 0x04004307 RID: 17159
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04004308 RID: 17160
		private ulong id_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x0200048A RID: 1162
	public sealed class StreamAddedNotification : IMessage<StreamAddedNotification>, IMessage, IEquatable<StreamAddedNotification>, IDeepCloneable<StreamAddedNotification>, IBufferMessage
	{
		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x06007147 RID: 28999 RVA: 0x001B8C98 File Offset: 0x001B6E98
		[DebuggerNonUserCode]
		public static MessageParser<StreamAddedNotification> Parser
		{
			get
			{
				return StreamAddedNotification._parser;
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x001B8CB0 File Offset: 0x001B6EB0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubNotificationReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x001B8CD4 File Offset: 0x001B6ED4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamAddedNotification.Descriptor;
			}
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x001B8CEB File Offset: 0x001B6EEB
		[DebuggerNonUserCode]
		public StreamAddedNotification()
		{
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x001B8CF8 File Offset: 0x001B6EF8
		[DebuggerNonUserCode]
		public StreamAddedNotification(StreamAddedNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.clubId_ = other.clubId_;
			this.stream_ = ((other.stream_ != null) ? other.stream_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x001B8D70 File Offset: 0x001B6F70
		[DebuggerNonUserCode]
		public StreamAddedNotification Clone()
		{
			return new StreamAddedNotification(this);
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x001B8D88 File Offset: 0x001B6F88
		// (set) Token: 0x0600714E RID: 29006 RVA: 0x001B8DA0 File Offset: 0x001B6FA0
		[DebuggerNonUserCode]
		public MemberId AgentId
		{
			get
			{
				return this.agentId_;
			}
			set
			{
				this.agentId_ = value;
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600714F RID: 29007 RVA: 0x001B8DAC File Offset: 0x001B6FAC
		// (set) Token: 0x06007150 RID: 29008 RVA: 0x001B8DDD File Offset: 0x001B6FDD
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = StreamAddedNotification.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x001B8DF8 File Offset: 0x001B6FF8
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x001B8E15 File Offset: 0x001B7015
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x001B8E28 File Offset: 0x001B7028
		// (set) Token: 0x06007154 RID: 29012 RVA: 0x001B8E40 File Offset: 0x001B7040
		[DebuggerNonUserCode]
		public Stream Stream
		{
			get
			{
				return this.stream_;
			}
			set
			{
				this.stream_ = value;
			}
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x001B8E4C File Offset: 0x001B704C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamAddedNotification);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x001B8E6C File Offset: 0x001B706C
		[DebuggerNonUserCode]
		public bool Equals(StreamAddedNotification other)
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
					bool flag4 = !object.Equals(this.AgentId, other.AgentId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClubId != other.ClubId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Stream, other.Stream);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x001B8F00 File Offset: 0x001B7100
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag2 = this.stream_ != null;
			if (flag2)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x001B8F8C File Offset: 0x001B718C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x001B8FA4 File Offset: 0x001B71A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x001B8FB0 File Offset: 0x001B71B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.ClubId);
			}
			bool flag2 = this.stream_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Stream);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x001B9048 File Offset: 0x001B7248
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag2 = this.stream_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Stream);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x001B90D8 File Offset: 0x001B72D8
		[DebuggerNonUserCode]
		public void MergeFrom(StreamAddedNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.agentId_ != null;
				if (flag2)
				{
					bool flag3 = this.agentId_ == null;
					if (flag3)
					{
						this.AgentId = new MemberId();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool flag4 = other.stream_ != null;
				if (flag4)
				{
					bool flag5 = this.stream_ == null;
					if (flag5)
					{
						this.Stream = new Stream();
					}
					this.Stream.MergeFrom(other.Stream);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x001B91A0 File Offset: 0x001B73A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x001B91AC File Offset: 0x001B73AC
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
					if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.stream_ == null;
							if (flag)
							{
								this.Stream = new Stream();
							}
							input.ReadMessage(this.Stream);
						}
					}
					else
					{
						this.ClubId = input.ReadUInt64();
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new MemberId();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040033ED RID: 13293
		private static readonly MessageParser<StreamAddedNotification> _parser = new MessageParser<StreamAddedNotification>(() => new StreamAddedNotification());

		// Token: 0x040033EE RID: 13294
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033EF RID: 13295
		private int _hasBits0;

		// Token: 0x040033F0 RID: 13296
		public const int AgentIdFieldNumber = 1;

		// Token: 0x040033F1 RID: 13297
		private MemberId agentId_;

		// Token: 0x040033F2 RID: 13298
		public const int ClubIdFieldNumber = 3;

		// Token: 0x040033F3 RID: 13299
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x040033F4 RID: 13300
		private ulong clubId_;

		// Token: 0x040033F5 RID: 13301
		public const int StreamFieldNumber = 4;

		// Token: 0x040033F6 RID: 13302
		private Stream stream_;
	}
}

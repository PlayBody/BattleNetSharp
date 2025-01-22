using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000675 RID: 1653
	public sealed class GetJoinVoiceTokenRequest : IMessage<GetJoinVoiceTokenRequest>, IMessage, IEquatable<GetJoinVoiceTokenRequest>, IDeepCloneable<GetJoinVoiceTokenRequest>, IBufferMessage
	{
		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x06009966 RID: 39270 RVA: 0x00252678 File Offset: 0x00250878
		[DebuggerNonUserCode]
		public static MessageParser<GetJoinVoiceTokenRequest> Parser
		{
			get
			{
				return GetJoinVoiceTokenRequest._parser;
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x06009967 RID: 39271 RVA: 0x00252690 File Offset: 0x00250890
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelServiceReflection.Descriptor.MessageTypes[25];
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x06009968 RID: 39272 RVA: 0x002526B4 File Offset: 0x002508B4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJoinVoiceTokenRequest.Descriptor;
			}
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x002526CB File Offset: 0x002508CB
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenRequest()
		{
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x002526D8 File Offset: 0x002508D8
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenRequest(GetJoinVoiceTokenRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.agentId_ = ((other.agentId_ != null) ? other.agentId_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600996B RID: 39275 RVA: 0x00252750 File Offset: 0x00250950
		[DebuggerNonUserCode]
		public GetJoinVoiceTokenRequest Clone()
		{
			return new GetJoinVoiceTokenRequest(this);
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x00252768 File Offset: 0x00250968
		// (set) Token: 0x0600996D RID: 39277 RVA: 0x00252780 File Offset: 0x00250980
		[DebuggerNonUserCode]
		public GameAccountHandle AgentId
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

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0600996E RID: 39278 RVA: 0x0025278C File Offset: 0x0025098C
		// (set) Token: 0x0600996F RID: 39279 RVA: 0x002527A4 File Offset: 0x002509A4
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x002527B0 File Offset: 0x002509B0
		// (set) Token: 0x06009971 RID: 39281 RVA: 0x002527E1 File Offset: 0x002509E1
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = GetJoinVoiceTokenRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x002527FC File Offset: 0x002509FC
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00252819 File Offset: 0x00250A19
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x0025282C File Offset: 0x00250A2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJoinVoiceTokenRequest);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x0025284C File Offset: 0x00250A4C
		[DebuggerNonUserCode]
		public bool Equals(GetJoinVoiceTokenRequest other)
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
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Version != other.Version;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x002528E0 File Offset: 0x00250AE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num ^= this.AgentId.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00252968 File Offset: 0x00250B68
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00252980 File Offset: 0x00250B80
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x0025298C File Offset: 0x00250B8C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.agentId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Version);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00252A24 File Offset: 0x00250C24
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.agentId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AgentId);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00252AB4 File Offset: 0x00250CB4
		[DebuggerNonUserCode]
		public void MergeFrom(GetJoinVoiceTokenRequest other)
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
						this.AgentId = new GameAccountHandle();
					}
					this.AgentId.MergeFrom(other.AgentId);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x00252B7C File Offset: 0x00250D7C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00252B88 File Offset: 0x00250D88
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
					if (num3 != 18U)
					{
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Version = input.ReadUInt32();
						}
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag2 = this.agentId_ == null;
					if (flag2)
					{
						this.AgentId = new GameAccountHandle();
					}
					input.ReadMessage(this.AgentId);
				}
			}
		}

		// Token: 0x040044FC RID: 17660
		private static readonly MessageParser<GetJoinVoiceTokenRequest> _parser = new MessageParser<GetJoinVoiceTokenRequest>(() => new GetJoinVoiceTokenRequest());

		// Token: 0x040044FD RID: 17661
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044FE RID: 17662
		private int _hasBits0;

		// Token: 0x040044FF RID: 17663
		public const int AgentIdFieldNumber = 1;

		// Token: 0x04004500 RID: 17664
		private GameAccountHandle agentId_;

		// Token: 0x04004501 RID: 17665
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x04004502 RID: 17666
		private ChannelId channelId_;

		// Token: 0x04004503 RID: 17667
		public const int VersionFieldNumber = 3;

		// Token: 0x04004504 RID: 17668
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04004505 RID: 17669
		private uint version_;
	}
}

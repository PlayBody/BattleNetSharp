using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000634 RID: 1588
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x06009409 RID: 37897 RVA: 0x0023D8BC File Offset: 0x0023BABC
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600940A RID: 37898 RVA: 0x0023D8D4 File Offset: 0x0023BAD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0600940B RID: 37899 RVA: 0x0023D8F8 File Offset: 0x0023BAF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x0023D90F File Offset: 0x0023BB0F
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x0023D919 File Offset: 0x0023BB19
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x0023D950 File Offset: 0x0023BB50
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600940F RID: 37903 RVA: 0x0023D968 File Offset: 0x0023BB68
		// (set) Token: 0x06009410 RID: 37904 RVA: 0x0023D980 File Offset: 0x0023BB80
		[DebuggerNonUserCode]
		public RecentPlayersState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x0023D98C File Offset: 0x0023BB8C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x0023D9AC File Offset: 0x0023BBAC
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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
					bool flag4 = !object.Equals(this.State, other.State);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x0023DA08 File Offset: 0x0023BC08
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x0023DA58 File Offset: 0x0023BC58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x0023DA70 File Offset: 0x0023BC70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x0023DA7C File Offset: 0x0023BC7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x0023DACC File Offset: 0x0023BCCC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x0023DB20 File Offset: 0x0023BD20
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new RecentPlayersState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x0023DB8C File Offset: 0x0023BD8C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x0023DB98 File Offset: 0x0023BD98
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
					bool flag = this.state_ == null;
					if (flag)
					{
						this.State = new RecentPlayersState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x040042C8 RID: 17096
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x040042C9 RID: 17097
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042CA RID: 17098
		public const int StateFieldNumber = 1;

		// Token: 0x040042CB RID: 17099
		private RecentPlayersState state_;
	}
}

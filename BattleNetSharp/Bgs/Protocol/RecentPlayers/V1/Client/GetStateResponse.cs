using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000637 RID: 1591
	public sealed class GetStateResponse : IMessage<GetStateResponse>, IMessage, IEquatable<GetStateResponse>, IDeepCloneable<GetStateResponse>, IBufferMessage
	{
		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600943E RID: 37950 RVA: 0x0023E09C File Offset: 0x0023C29C
		[DebuggerNonUserCode]
		public static MessageParser<GetStateResponse> Parser
		{
			get
			{
				return GetStateResponse._parser;
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600943F RID: 37951 RVA: 0x0023E0B4 File Offset: 0x0023C2B4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x0023E0D8 File Offset: 0x0023C2D8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateResponse.Descriptor;
			}
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x0023E0EF File Offset: 0x0023C2EF
		[DebuggerNonUserCode]
		public GetStateResponse()
		{
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x0023E0F9 File Offset: 0x0023C2F9
		[DebuggerNonUserCode]
		public GetStateResponse(GetStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x0023E130 File Offset: 0x0023C330
		[DebuggerNonUserCode]
		public GetStateResponse Clone()
		{
			return new GetStateResponse(this);
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x0023E148 File Offset: 0x0023C348
		// (set) Token: 0x06009445 RID: 37957 RVA: 0x0023E160 File Offset: 0x0023C360
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

		// Token: 0x06009446 RID: 37958 RVA: 0x0023E16C File Offset: 0x0023C36C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateResponse);
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x0023E18C File Offset: 0x0023C38C
		[DebuggerNonUserCode]
		public bool Equals(GetStateResponse other)
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

		// Token: 0x06009448 RID: 37960 RVA: 0x0023E1E8 File Offset: 0x0023C3E8
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

		// Token: 0x06009449 RID: 37961 RVA: 0x0023E238 File Offset: 0x0023C438
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x0023E250 File Offset: 0x0023C450
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x0023E25C File Offset: 0x0023C45C
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

		// Token: 0x0600944C RID: 37964 RVA: 0x0023E2AC File Offset: 0x0023C4AC
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

		// Token: 0x0600944D RID: 37965 RVA: 0x0023E300 File Offset: 0x0023C500
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateResponse other)
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

		// Token: 0x0600944E RID: 37966 RVA: 0x0023E36C File Offset: 0x0023C56C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x0023E378 File Offset: 0x0023C578
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

		// Token: 0x040042D0 RID: 17104
		private static readonly MessageParser<GetStateResponse> _parser = new MessageParser<GetStateResponse>(() => new GetStateResponse());

		// Token: 0x040042D1 RID: 17105
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042D2 RID: 17106
		public const int StateFieldNumber = 1;

		// Token: 0x040042D3 RID: 17107
		private RecentPlayersState state_;
	}
}

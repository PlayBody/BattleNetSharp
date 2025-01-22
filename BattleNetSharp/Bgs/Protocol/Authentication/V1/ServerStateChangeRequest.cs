using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060F RID: 1551
	public sealed class ServerStateChangeRequest : IMessage<ServerStateChangeRequest>, IMessage, IEquatable<ServerStateChangeRequest>, IDeepCloneable<ServerStateChangeRequest>, IBufferMessage
	{
		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x00233B78 File Offset: 0x00231D78
		[DebuggerNonUserCode]
		public static MessageParser<ServerStateChangeRequest> Parser
		{
			get
			{
				return ServerStateChangeRequest._parser;
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06009152 RID: 37202 RVA: 0x00233B90 File Offset: 0x00231D90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x00233BB4 File Offset: 0x00231DB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerStateChangeRequest.Descriptor;
			}
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x00233BCB File Offset: 0x00231DCB
		[DebuggerNonUserCode]
		public ServerStateChangeRequest()
		{
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x00233BD5 File Offset: 0x00231DD5
		[DebuggerNonUserCode]
		public ServerStateChangeRequest(ServerStateChangeRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.state_ = other.state_;
			this.eventTime_ = other.eventTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x00233C14 File Offset: 0x00231E14
		[DebuggerNonUserCode]
		public ServerStateChangeRequest Clone()
		{
			return new ServerStateChangeRequest(this);
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06009157 RID: 37207 RVA: 0x00233C2C File Offset: 0x00231E2C
		// (set) Token: 0x06009158 RID: 37208 RVA: 0x00233C5D File Offset: 0x00231E5D
		[DebuggerNonUserCode]
		public uint State
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint stateDefaultValue;
				if (flag)
				{
					stateDefaultValue = this.state_;
				}
				else
				{
					stateDefaultValue = ServerStateChangeRequest.StateDefaultValue;
				}
				return stateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.state_ = value;
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x00233C78 File Offset: 0x00231E78
		[DebuggerNonUserCode]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x00233C95 File Offset: 0x00231E95
		[DebuggerNonUserCode]
		public void ClearState()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600915B RID: 37211 RVA: 0x00233CA8 File Offset: 0x00231EA8
		// (set) Token: 0x0600915C RID: 37212 RVA: 0x00233CD9 File Offset: 0x00231ED9
		[DebuggerNonUserCode]
		public ulong EventTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong eventTimeDefaultValue;
				if (flag)
				{
					eventTimeDefaultValue = this.eventTime_;
				}
				else
				{
					eventTimeDefaultValue = ServerStateChangeRequest.EventTimeDefaultValue;
				}
				return eventTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.eventTime_ = value;
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x0600915D RID: 37213 RVA: 0x00233CF4 File Offset: 0x00231EF4
		[DebuggerNonUserCode]
		public bool HasEventTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x00233D11 File Offset: 0x00231F11
		[DebuggerNonUserCode]
		public void ClearEventTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x00233D24 File Offset: 0x00231F24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerStateChangeRequest);
		}

		// Token: 0x06009160 RID: 37216 RVA: 0x00233D44 File Offset: 0x00231F44
		[DebuggerNonUserCode]
		public bool Equals(ServerStateChangeRequest other)
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
					bool flag4 = this.State != other.State;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.EventTime != other.EventTime;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009161 RID: 37217 RVA: 0x00233DB8 File Offset: 0x00231FB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasState = this.HasState;
			if (hasState)
			{
				num ^= this.State.GetHashCode();
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				num ^= this.EventTime.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009162 RID: 37218 RVA: 0x00233E28 File Offset: 0x00232028
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x00233E40 File Offset: 0x00232040
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x00233E4C File Offset: 0x0023204C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasState = this.HasState;
			if (hasState)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.State);
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.EventTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x00233EBC File Offset: 0x002320BC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasState = this.HasState;
			if (hasState)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.State);
			}
			bool hasEventTime = this.HasEventTime;
			if (hasEventTime)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.EventTime);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x00233F28 File Offset: 0x00232128
		[DebuggerNonUserCode]
		public void MergeFrom(ServerStateChangeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasState = other.HasState;
				if (hasState)
				{
					this.State = other.State;
				}
				bool hasEventTime = other.HasEventTime;
				if (hasEventTime)
				{
					this.EventTime = other.EventTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x00233F8A File Offset: 0x0023218A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x00233F98 File Offset: 0x00232198
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventTime = input.ReadUInt64();
					}
				}
				else
				{
					this.State = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040041A1 RID: 16801
		private static readonly MessageParser<ServerStateChangeRequest> _parser = new MessageParser<ServerStateChangeRequest>(() => new ServerStateChangeRequest());

		// Token: 0x040041A2 RID: 16802
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041A3 RID: 16803
		private int _hasBits0;

		// Token: 0x040041A4 RID: 16804
		public const int StateFieldNumber = 1;

		// Token: 0x040041A5 RID: 16805
		private static readonly uint StateDefaultValue = 0U;

		// Token: 0x040041A6 RID: 16806
		private uint state_;

		// Token: 0x040041A7 RID: 16807
		public const int EventTimeFieldNumber = 2;

		// Token: 0x040041A8 RID: 16808
		private static readonly ulong EventTimeDefaultValue = 0UL;

		// Token: 0x040041A9 RID: 16809
		private ulong eventTime_;
	}
}

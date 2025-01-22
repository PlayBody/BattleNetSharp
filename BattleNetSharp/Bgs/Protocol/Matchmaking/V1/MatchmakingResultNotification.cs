using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003FE RID: 1022
	public sealed class MatchmakingResultNotification : IMessage<MatchmakingResultNotification>, IMessage, IEquatable<MatchmakingResultNotification>, IDeepCloneable<MatchmakingResultNotification>, IBufferMessage
	{
		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x00187AEC File Offset: 0x00185CEC
		[DebuggerNonUserCode]
		public static MessageParser<MatchmakingResultNotification> Parser
		{
			get
			{
				return MatchmakingResultNotification._parser;
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x0600655C RID: 25948 RVA: 0x00187B04 File Offset: 0x00185D04
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameRequestServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x00187B28 File Offset: 0x00185D28
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchmakingResultNotification.Descriptor;
			}
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00187B3F File Offset: 0x00185D3F
		[DebuggerNonUserCode]
		public MatchmakingResultNotification()
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x00187B4C File Offset: 0x00185D4C
		[DebuggerNonUserCode]
		public MatchmakingResultNotification(MatchmakingResultNotification other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this.result_ = other.result_;
			this.connectInfo_ = ((other.connectInfo_ != null) ? other.connectInfo_.Clone() : null);
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00187BE0 File Offset: 0x00185DE0
		[DebuggerNonUserCode]
		public MatchmakingResultNotification Clone()
		{
			return new MatchmakingResultNotification(this);
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x00187BF8 File Offset: 0x00185DF8
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x00187C10 File Offset: 0x00185E10
		[DebuggerNonUserCode]
		public RequestId RequestId
		{
			get
			{
				return this.requestId_;
			}
			set
			{
				this.requestId_ = value;
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x00187C1C File Offset: 0x00185E1C
		// (set) Token: 0x06006564 RID: 25956 RVA: 0x00187C4D File Offset: 0x00185E4D
		[DebuggerNonUserCode]
		public uint Result
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint resultDefaultValue;
				if (flag)
				{
					resultDefaultValue = this.result_;
				}
				else
				{
					resultDefaultValue = MatchmakingResultNotification.ResultDefaultValue;
				}
				return resultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.result_ = value;
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x00187C68 File Offset: 0x00185E68
		[DebuggerNonUserCode]
		public bool HasResult
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x00187C85 File Offset: 0x00185E85
		[DebuggerNonUserCode]
		public void ClearResult()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x00187C98 File Offset: 0x00185E98
		// (set) Token: 0x06006568 RID: 25960 RVA: 0x00187CB0 File Offset: 0x00185EB0
		[DebuggerNonUserCode]
		public ConnectInfo ConnectInfo
		{
			get
			{
				return this.connectInfo_;
			}
			set
			{
				this.connectInfo_ = value;
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x00187CBC File Offset: 0x00185EBC
		// (set) Token: 0x0600656A RID: 25962 RVA: 0x00187CD4 File Offset: 0x00185ED4
		[DebuggerNonUserCode]
		public GameHandle GameHandle
		{
			get
			{
				return this.gameHandle_;
			}
			set
			{
				this.gameHandle_ = value;
			}
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00187CE0 File Offset: 0x00185EE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchmakingResultNotification);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00187D00 File Offset: 0x00185F00
		[DebuggerNonUserCode]
		public bool Equals(MatchmakingResultNotification other)
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
					bool flag4 = !object.Equals(this.RequestId, other.RequestId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Result != other.Result;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.ConnectInfo, other.ConnectInfo);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.GameHandle, other.GameHandle);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x00187DB8 File Offset: 0x00185FB8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num ^= this.RequestId.GetHashCode();
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num ^= this.Result.GetHashCode();
			}
			bool flag2 = this.connectInfo_ != null;
			if (flag2)
			{
				num ^= this.ConnectInfo.GetHashCode();
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00187E60 File Offset: 0x00186060
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00187E78 File Offset: 0x00186078
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x00187E84 File Offset: 0x00186084
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.requestId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RequestId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Result);
			}
			bool flag2 = this.connectInfo_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.ConnectInfo);
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GameHandle);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00187F44 File Offset: 0x00186144
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.requestId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
			}
			bool flag2 = this.connectInfo_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConnectInfo);
			}
			bool flag3 = this.gameHandle_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00187FF8 File Offset: 0x001861F8
		[DebuggerNonUserCode]
		public void MergeFrom(MatchmakingResultNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.requestId_ != null;
				if (flag2)
				{
					bool flag3 = this.requestId_ == null;
					if (flag3)
					{
						this.RequestId = new RequestId();
					}
					this.RequestId.MergeFrom(other.RequestId);
				}
				bool hasResult = other.HasResult;
				if (hasResult)
				{
					this.Result = other.Result;
				}
				bool flag4 = other.connectInfo_ != null;
				if (flag4)
				{
					bool flag5 = this.connectInfo_ == null;
					if (flag5)
					{
						this.ConnectInfo = new ConnectInfo();
					}
					this.ConnectInfo.MergeFrom(other.ConnectInfo);
				}
				bool flag6 = other.gameHandle_ != null;
				if (flag6)
				{
					bool flag7 = this.gameHandle_ == null;
					if (flag7)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00188100 File Offset: 0x00186300
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x0018810C File Offset: 0x0018630C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 16U)
				{
					if (num3 != 10U)
					{
						if (num3 != 16U)
						{
							goto IL_002F;
						}
						this.Result = input.ReadUInt32();
					}
					else
					{
						bool flag = this.requestId_ == null;
						if (flag)
						{
							this.RequestId = new RequestId();
						}
						input.ReadMessage(this.RequestId);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag2 = this.gameHandle_ == null;
					if (flag2)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
				else
				{
					bool flag3 = this.connectInfo_ == null;
					if (flag3)
					{
						this.ConnectInfo = new ConnectInfo();
					}
					input.ReadMessage(this.ConnectInfo);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E13 RID: 11795
		private static readonly MessageParser<MatchmakingResultNotification> _parser = new MessageParser<MatchmakingResultNotification>(() => new MatchmakingResultNotification());

		// Token: 0x04002E14 RID: 11796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E15 RID: 11797
		private int _hasBits0;

		// Token: 0x04002E16 RID: 11798
		public const int RequestIdFieldNumber = 1;

		// Token: 0x04002E17 RID: 11799
		private RequestId requestId_;

		// Token: 0x04002E18 RID: 11800
		public const int ResultFieldNumber = 2;

		// Token: 0x04002E19 RID: 11801
		private static readonly uint ResultDefaultValue = 0U;

		// Token: 0x04002E1A RID: 11802
		private uint result_;

		// Token: 0x04002E1B RID: 11803
		public const int ConnectInfoFieldNumber = 3;

		// Token: 0x04002E1C RID: 11804
		private ConnectInfo connectInfo_;

		// Token: 0x04002E1D RID: 11805
		public const int GameHandleFieldNumber = 4;

		// Token: 0x04002E1E RID: 11806
		private GameHandle gameHandle_;
	}
}

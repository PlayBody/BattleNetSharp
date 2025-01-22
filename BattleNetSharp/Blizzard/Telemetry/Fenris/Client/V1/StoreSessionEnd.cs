using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000316 RID: 790
	public sealed class StoreSessionEnd : IMessage<StoreSessionEnd>, IMessage, IEquatable<StoreSessionEnd>, IDeepCloneable<StoreSessionEnd>, IBufferMessage
	{
		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06005303 RID: 21251 RVA: 0x00140A38 File Offset: 0x0013EC38
		[DebuggerNonUserCode]
		public static MessageParser<StoreSessionEnd> Parser
		{
			get
			{
				return StoreSessionEnd._parser;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06005304 RID: 21252 RVA: 0x00140A50 File Offset: 0x0013EC50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreSessionEndReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x00140A74 File Offset: 0x0013EC74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreSessionEnd.Descriptor;
			}
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00140A8B File Offset: 0x0013EC8B
		[DebuggerNonUserCode]
		public StoreSessionEnd()
		{
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00140A95 File Offset: 0x0013EC95
		[DebuggerNonUserCode]
		public StoreSessionEnd(StoreSessionEnd other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00140ACC File Offset: 0x0013ECCC
		[DebuggerNonUserCode]
		public StoreSessionEnd Clone()
		{
			return new StoreSessionEnd(this);
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06005309 RID: 21257 RVA: 0x00140AE4 File Offset: 0x0013ECE4
		// (set) Token: 0x0600530A RID: 21258 RVA: 0x00140AFC File Offset: 0x0013ECFC
		[DebuggerNonUserCode]
		public StoreSessionInfo SessionInfo
		{
			get
			{
				return this.sessionInfo_;
			}
			set
			{
				this.sessionInfo_ = value;
			}
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00140B08 File Offset: 0x0013ED08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreSessionEnd);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00140B28 File Offset: 0x0013ED28
		[DebuggerNonUserCode]
		public bool Equals(StoreSessionEnd other)
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
					bool flag4 = !object.Equals(this.SessionInfo, other.SessionInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x00140B84 File Offset: 0x0013ED84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num ^= this.SessionInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00140BD4 File Offset: 0x0013EDD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00140BEC File Offset: 0x0013EDEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00140BF8 File Offset: 0x0013EDF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SessionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00140C48 File Offset: 0x0013EE48
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sessionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SessionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00140C9C File Offset: 0x0013EE9C
		[DebuggerNonUserCode]
		public void MergeFrom(StoreSessionEnd other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sessionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.sessionInfo_ == null;
					if (flag3)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					this.SessionInfo.MergeFrom(other.SessionInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00140D08 File Offset: 0x0013EF08
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00140D14 File Offset: 0x0013EF14
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
					bool flag = this.sessionInfo_ == null;
					if (flag)
					{
						this.SessionInfo = new StoreSessionInfo();
					}
					input.ReadMessage(this.SessionInfo);
				}
			}
		}

		// Token: 0x040025A7 RID: 9639
		private static readonly MessageParser<StoreSessionEnd> _parser = new MessageParser<StoreSessionEnd>(() => new StoreSessionEnd());

		// Token: 0x040025A8 RID: 9640
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A9 RID: 9641
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x040025AA RID: 9642
		private StoreSessionInfo sessionInfo_;
	}
}

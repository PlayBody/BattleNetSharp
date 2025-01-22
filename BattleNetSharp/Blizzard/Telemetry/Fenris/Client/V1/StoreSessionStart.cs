using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x0200031B RID: 795
	public sealed class StoreSessionStart : IMessage<StoreSessionStart>, IMessage, IEquatable<StoreSessionStart>, IDeepCloneable<StoreSessionStart>, IBufferMessage
	{
		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x00141BA0 File Offset: 0x0013FDA0
		[DebuggerNonUserCode]
		public static MessageParser<StoreSessionStart> Parser
		{
			get
			{
				return StoreSessionStart._parser;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x00141BB8 File Offset: 0x0013FDB8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoreSessionStartReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06005357 RID: 21335 RVA: 0x00141BDC File Offset: 0x0013FDDC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoreSessionStart.Descriptor;
			}
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x00141BF3 File Offset: 0x0013FDF3
		[DebuggerNonUserCode]
		public StoreSessionStart()
		{
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00141BFD File Offset: 0x0013FDFD
		[DebuggerNonUserCode]
		public StoreSessionStart(StoreSessionStart other)
			: this()
		{
			this.sessionInfo_ = ((other.sessionInfo_ != null) ? other.sessionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x00141C34 File Offset: 0x0013FE34
		[DebuggerNonUserCode]
		public StoreSessionStart Clone()
		{
			return new StoreSessionStart(this);
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600535B RID: 21339 RVA: 0x00141C4C File Offset: 0x0013FE4C
		// (set) Token: 0x0600535C RID: 21340 RVA: 0x00141C64 File Offset: 0x0013FE64
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

		// Token: 0x0600535D RID: 21341 RVA: 0x00141C70 File Offset: 0x0013FE70
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoreSessionStart);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00141C90 File Offset: 0x0013FE90
		[DebuggerNonUserCode]
		public bool Equals(StoreSessionStart other)
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

		// Token: 0x0600535F RID: 21343 RVA: 0x00141CEC File Offset: 0x0013FEEC
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

		// Token: 0x06005360 RID: 21344 RVA: 0x00141D3C File Offset: 0x0013FF3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00141D54 File Offset: 0x0013FF54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x00141D60 File Offset: 0x0013FF60
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

		// Token: 0x06005363 RID: 21347 RVA: 0x00141DB0 File Offset: 0x0013FFB0
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

		// Token: 0x06005364 RID: 21348 RVA: 0x00141E04 File Offset: 0x00140004
		[DebuggerNonUserCode]
		public void MergeFrom(StoreSessionStart other)
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

		// Token: 0x06005365 RID: 21349 RVA: 0x00141E70 File Offset: 0x00140070
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00141E7C File Offset: 0x0014007C
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

		// Token: 0x040025C7 RID: 9671
		private static readonly MessageParser<StoreSessionStart> _parser = new MessageParser<StoreSessionStart>(() => new StoreSessionStart());

		// Token: 0x040025C8 RID: 9672
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C9 RID: 9673
		public const int SessionInfoFieldNumber = 1;

		// Token: 0x040025CA RID: 9674
		private StoreSessionInfo sessionInfo_;
	}
}

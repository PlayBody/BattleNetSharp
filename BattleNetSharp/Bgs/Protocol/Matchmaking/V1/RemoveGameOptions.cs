using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003F2 RID: 1010
	public sealed class RemoveGameOptions : IMessage<RemoveGameOptions>, IMessage, IEquatable<RemoveGameOptions>, IDeepCloneable<RemoveGameOptions>, IBufferMessage
	{
		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x001841D0 File Offset: 0x001823D0
		[DebuggerNonUserCode]
		public static MessageParser<RemoveGameOptions> Parser
		{
			get
			{
				return RemoveGameOptions._parser;
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06006469 RID: 25705 RVA: 0x001841E8 File Offset: 0x001823E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x0018420C File Offset: 0x0018240C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameOptions.Descriptor;
			}
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00184223 File Offset: 0x00182423
		[DebuggerNonUserCode]
		public RemoveGameOptions()
		{
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x0018422D File Offset: 0x0018242D
		[DebuggerNonUserCode]
		public RemoveGameOptions(RemoveGameOptions other)
			: this()
		{
			this.gameHandle_ = ((other.gameHandle_ != null) ? other.gameHandle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x00184264 File Offset: 0x00182464
		[DebuggerNonUserCode]
		public RemoveGameOptions Clone()
		{
			return new RemoveGameOptions(this);
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x0018427C File Offset: 0x0018247C
		// (set) Token: 0x0600646F RID: 25711 RVA: 0x00184294 File Offset: 0x00182494
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

		// Token: 0x06006470 RID: 25712 RVA: 0x001842A0 File Offset: 0x001824A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameOptions);
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x001842C0 File Offset: 0x001824C0
		[DebuggerNonUserCode]
		public bool Equals(RemoveGameOptions other)
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
					bool flag4 = !object.Equals(this.GameHandle, other.GameHandle);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x0018431C File Offset: 0x0018251C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num ^= this.GameHandle.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x0018436C File Offset: 0x0018256C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x00184384 File Offset: 0x00182584
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006475 RID: 25717 RVA: 0x00184390 File Offset: 0x00182590
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x001843E0 File Offset: 0x001825E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x00184434 File Offset: 0x00182634
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveGameOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.gameHandle_ == null;
					if (flag3)
					{
						this.GameHandle = new GameHandle();
					}
					this.GameHandle.MergeFrom(other.GameHandle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x001844A0 File Offset: 0x001826A0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x001844AC File Offset: 0x001826AC
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
					bool flag = this.gameHandle_ == null;
					if (flag)
					{
						this.GameHandle = new GameHandle();
					}
					input.ReadMessage(this.GameHandle);
				}
			}
		}

		// Token: 0x04002DC1 RID: 11713
		private static readonly MessageParser<RemoveGameOptions> _parser = new MessageParser<RemoveGameOptions>(() => new RemoveGameOptions());

		// Token: 0x04002DC2 RID: 11714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DC3 RID: 11715
		public const int GameHandleFieldNumber = 1;

		// Token: 0x04002DC4 RID: 11716
		private GameHandle gameHandle_;
	}
}

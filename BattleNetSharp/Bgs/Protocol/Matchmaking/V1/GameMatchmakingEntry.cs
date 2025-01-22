using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003EA RID: 1002
	public sealed class GameMatchmakingEntry : IMessage<GameMatchmakingEntry>, IMessage, IEquatable<GameMatchmakingEntry>, IDeepCloneable<GameMatchmakingEntry>, IBufferMessage
	{
		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060063A8 RID: 25512 RVA: 0x00181524 File Offset: 0x0017F724
		[DebuggerNonUserCode]
		public static MessageParser<GameMatchmakingEntry> Parser
		{
			get
			{
				return GameMatchmakingEntry._parser;
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060063A9 RID: 25513 RVA: 0x0018153C File Offset: 0x0017F73C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x00181560 File Offset: 0x0017F760
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameMatchmakingEntry.Descriptor;
			}
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x00181577 File Offset: 0x0017F777
		[DebuggerNonUserCode]
		public GameMatchmakingEntry()
		{
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x00181584 File Offset: 0x0017F784
		[DebuggerNonUserCode]
		public GameMatchmakingEntry(GameMatchmakingEntry other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.requestId_ = ((other.requestId_ != null) ? other.requestId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x001815E4 File Offset: 0x0017F7E4
		[DebuggerNonUserCode]
		public GameMatchmakingEntry Clone()
		{
			return new GameMatchmakingEntry(this);
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x001815FC File Offset: 0x0017F7FC
		// (set) Token: 0x060063AF RID: 25519 RVA: 0x00181614 File Offset: 0x0017F814
		[DebuggerNonUserCode]
		public GameMatchmakingOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060063B0 RID: 25520 RVA: 0x00181620 File Offset: 0x0017F820
		// (set) Token: 0x060063B1 RID: 25521 RVA: 0x00181638 File Offset: 0x0017F838
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

		// Token: 0x060063B2 RID: 25522 RVA: 0x00181644 File Offset: 0x0017F844
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameMatchmakingEntry);
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x00181664 File Offset: 0x0017F864
		[DebuggerNonUserCode]
		public bool Equals(GameMatchmakingEntry other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.RequestId, other.RequestId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x001816DC File Offset: 0x0017F8DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this.requestId_ != null;
			if (flag2)
			{
				num ^= this.RequestId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00181748 File Offset: 0x0017F948
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00181760 File Offset: 0x0017F960
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x0018176C File Offset: 0x0017F96C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this.requestId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RequestId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x001817E0 File Offset: 0x0017F9E0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this.requestId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RequestId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00181854 File Offset: 0x0017FA54
		[DebuggerNonUserCode]
		public void MergeFrom(GameMatchmakingEntry other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new GameMatchmakingOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool flag4 = other.requestId_ != null;
				if (flag4)
				{
					bool flag5 = this.requestId_ == null;
					if (flag5)
					{
						this.RequestId = new RequestId();
					}
					this.RequestId.MergeFrom(other.RequestId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00181901 File Offset: 0x0017FB01
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x0018190C File Offset: 0x0017FB0C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					bool flag2 = this.options_ == null;
					if (flag2)
					{
						this.Options = new GameMatchmakingOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x04002D6F RID: 11631
		private static readonly MessageParser<GameMatchmakingEntry> _parser = new MessageParser<GameMatchmakingEntry>(() => new GameMatchmakingEntry());

		// Token: 0x04002D70 RID: 11632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D71 RID: 11633
		public const int OptionsFieldNumber = 1;

		// Token: 0x04002D72 RID: 11634
		private GameMatchmakingOptions options_;

		// Token: 0x04002D73 RID: 11635
		public const int RequestIdFieldNumber = 2;

		// Token: 0x04002D74 RID: 11636
		private RequestId requestId_;
	}
}

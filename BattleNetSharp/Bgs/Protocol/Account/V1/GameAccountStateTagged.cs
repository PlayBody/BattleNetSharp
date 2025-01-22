using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200074F RID: 1871
	public sealed class GameAccountStateTagged : IMessage<GameAccountStateTagged>, IMessage, IEquatable<GameAccountStateTagged>, IDeepCloneable<GameAccountStateTagged>, IBufferMessage
	{
		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x0029F4C4 File Offset: 0x0029D6C4
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountStateTagged> Parser
		{
			get
			{
				return GameAccountStateTagged._parser;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x0029F4DC File Offset: 0x0029D6DC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600AC47 RID: 44103 RVA: 0x0029F500 File Offset: 0x0029D700
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountStateTagged.Descriptor;
			}
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x0029F517 File Offset: 0x0029D717
		[DebuggerNonUserCode]
		public GameAccountStateTagged()
		{
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x0029F524 File Offset: 0x0029D724
		[DebuggerNonUserCode]
		public GameAccountStateTagged(GameAccountStateTagged other)
			: this()
		{
			this.gameAccountState_ = ((other.gameAccountState_ != null) ? other.gameAccountState_.Clone() : null);
			this.gameAccountTags_ = ((other.gameAccountTags_ != null) ? other.gameAccountTags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x0029F584 File Offset: 0x0029D784
		[DebuggerNonUserCode]
		public GameAccountStateTagged Clone()
		{
			return new GameAccountStateTagged(this);
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600AC4B RID: 44107 RVA: 0x0029F59C File Offset: 0x0029D79C
		// (set) Token: 0x0600AC4C RID: 44108 RVA: 0x0029F5B4 File Offset: 0x0029D7B4
		[DebuggerNonUserCode]
		public GameAccountState GameAccountState
		{
			get
			{
				return this.gameAccountState_;
			}
			set
			{
				this.gameAccountState_ = value;
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600AC4D RID: 44109 RVA: 0x0029F5C0 File Offset: 0x0029D7C0
		// (set) Token: 0x0600AC4E RID: 44110 RVA: 0x0029F5D8 File Offset: 0x0029D7D8
		[DebuggerNonUserCode]
		public GameAccountFieldTags GameAccountTags
		{
			get
			{
				return this.gameAccountTags_;
			}
			set
			{
				this.gameAccountTags_ = value;
			}
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x0029F5E4 File Offset: 0x0029D7E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountStateTagged);
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x0029F604 File Offset: 0x0029D804
		[DebuggerNonUserCode]
		public bool Equals(GameAccountStateTagged other)
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
					bool flag4 = !object.Equals(this.GameAccountState, other.GameAccountState);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccountTags, other.GameAccountTags);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x0029F67C File Offset: 0x0029D87C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				num ^= this.GameAccountState.GetHashCode();
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				num ^= this.GameAccountTags.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x0029F6E8 File Offset: 0x0029D8E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x0029F700 File Offset: 0x0029D900
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x0029F70C File Offset: 0x0029D90C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccountState);
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccountTags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x0029F780 File Offset: 0x0029D980
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccountState_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountState);
			}
			bool flag2 = this.gameAccountTags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountTags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x0029F7F4 File Offset: 0x0029D9F4
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountStateTagged other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccountState_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountState_ == null;
					if (flag3)
					{
						this.GameAccountState = new GameAccountState();
					}
					this.GameAccountState.MergeFrom(other.GameAccountState);
				}
				bool flag4 = other.gameAccountTags_ != null;
				if (flag4)
				{
					bool flag5 = this.gameAccountTags_ == null;
					if (flag5)
					{
						this.GameAccountTags = new GameAccountFieldTags();
					}
					this.GameAccountTags.MergeFrom(other.GameAccountTags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x0029F8A1 File Offset: 0x0029DAA1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x0029F8AC File Offset: 0x0029DAAC
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
						bool flag = this.gameAccountTags_ == null;
						if (flag)
						{
							this.GameAccountTags = new GameAccountFieldTags();
						}
						input.ReadMessage(this.GameAccountTags);
					}
				}
				else
				{
					bool flag2 = this.gameAccountState_ == null;
					if (flag2)
					{
						this.GameAccountState = new GameAccountState();
					}
					input.ReadMessage(this.GameAccountState);
				}
			}
		}

		// Token: 0x04004D9D RID: 19869
		private static readonly MessageParser<GameAccountStateTagged> _parser = new MessageParser<GameAccountStateTagged>(() => new GameAccountStateTagged());

		// Token: 0x04004D9E RID: 19870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D9F RID: 19871
		public const int GameAccountStateFieldNumber = 1;

		// Token: 0x04004DA0 RID: 19872
		private GameAccountState gameAccountState_;

		// Token: 0x04004DA1 RID: 19873
		public const int GameAccountTagsFieldNumber = 2;

		// Token: 0x04004DA2 RID: 19874
		private GameAccountFieldTags gameAccountTags_;
	}
}

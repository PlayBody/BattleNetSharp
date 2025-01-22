using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x0200070A RID: 1802
	public sealed class BlockListState : IMessage<BlockListState>, IMessage, IEquatable<BlockListState>, IDeepCloneable<BlockListState>, IBufferMessage
	{
		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x00284404 File Offset: 0x00282604
		[DebuggerNonUserCode]
		public static MessageParser<BlockListState> Parser
		{
			get
			{
				return BlockListState._parser;
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A56D RID: 42349 RVA: 0x0028441C File Offset: 0x0028261C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListTypesReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x00284440 File Offset: 0x00282640
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlockListState.Descriptor;
			}
		}

		// Token: 0x0600A56F RID: 42351 RVA: 0x00284457 File Offset: 0x00282657
		[DebuggerNonUserCode]
		public BlockListState()
		{
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x0028446C File Offset: 0x0028266C
		[DebuggerNonUserCode]
		public BlockListState(BlockListState other)
			: this()
		{
			this.player_ = other.player_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x00284498 File Offset: 0x00282698
		[DebuggerNonUserCode]
		public BlockListState Clone()
		{
			return new BlockListState(this);
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600A572 RID: 42354 RVA: 0x002844B0 File Offset: 0x002826B0
		[DebuggerNonUserCode]
		public RepeatedField<BlockedPlayer> Player
		{
			get
			{
				return this.player_;
			}
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x002844C8 File Offset: 0x002826C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlockListState);
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x002844E8 File Offset: 0x002826E8
		[DebuggerNonUserCode]
		public bool Equals(BlockListState other)
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
					bool flag4 = !this.player_.Equals(other.player_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x00284544 File Offset: 0x00282744
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.player_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x00284584 File Offset: 0x00282784
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x0028459C File Offset: 0x0028279C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x002845A8 File Offset: 0x002827A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.player_.WriteTo(ref output, BlockListState._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x002845E4 File Offset: 0x002827E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.player_.CalculateSize(BlockListState._repeated_player_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x0028462C File Offset: 0x0028282C
		[DebuggerNonUserCode]
		public void MergeFrom(BlockListState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.player_.Add(other.player_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x0028466E File Offset: 0x0028286E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x0028467C File Offset: 0x0028287C
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
					this.player_.AddEntriesFrom(ref input, BlockListState._repeated_player_codec);
				}
			}
		}

		// Token: 0x04004A6C RID: 19052
		private static readonly MessageParser<BlockListState> _parser = new MessageParser<BlockListState>(() => new BlockListState());

		// Token: 0x04004A6D RID: 19053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A6E RID: 19054
		public const int PlayerFieldNumber = 1;

		// Token: 0x04004A6F RID: 19055
		private static readonly FieldCodec<BlockedPlayer> _repeated_player_codec = FieldCodec.ForMessage<BlockedPlayer>(10U, BlockedPlayer.Parser);

		// Token: 0x04004A70 RID: 19056
		private readonly RepeatedField<BlockedPlayer> player_ = new RepeatedField<BlockedPlayer>();
	}
}

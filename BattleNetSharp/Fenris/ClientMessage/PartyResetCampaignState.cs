using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200025F RID: 607
	public sealed class PartyResetCampaignState : IMessage<PartyResetCampaignState>, IMessage, IEquatable<PartyResetCampaignState>, IDeepCloneable<PartyResetCampaignState>, IBufferMessage
	{
		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x000FEA9C File Offset: 0x000FCC9C
		[DebuggerNonUserCode]
		public static MessageParser<PartyResetCampaignState> Parser
		{
			get
			{
				return PartyResetCampaignState._parser;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x000FEAB4 File Offset: 0x000FCCB4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[79];
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x000FEAD8 File Offset: 0x000FCCD8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartyResetCampaignState.Descriptor;
			}
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x000FEAEF File Offset: 0x000FCCEF
		[DebuggerNonUserCode]
		public PartyResetCampaignState()
		{
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x000FEAF9 File Offset: 0x000FCCF9
		[DebuggerNonUserCode]
		public PartyResetCampaignState(PartyResetCampaignState other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x000FEB14 File Offset: 0x000FCD14
		[DebuggerNonUserCode]
		public PartyResetCampaignState Clone()
		{
			return new PartyResetCampaignState(this);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x000FEB2C File Offset: 0x000FCD2C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartyResetCampaignState);
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000FEB4C File Offset: 0x000FCD4C
		[DebuggerNonUserCode]
		public bool Equals(PartyResetCampaignState other)
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
				flag2 = flag3 || object.Equals(this._unknownFields, other._unknownFields);
			}
			return flag2;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x000FEB8C File Offset: 0x000FCD8C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x000FEBC0 File Offset: 0x000FCDC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x000FEBD8 File Offset: 0x000FCDD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x000FEBE4 File Offset: 0x000FCDE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x000FEC10 File Offset: 0x000FCE10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004153 RID: 16723 RVA: 0x000FEC44 File Offset: 0x000FCE44
		[DebuggerNonUserCode]
		public void MergeFrom(PartyResetCampaignState other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x000FEC74 File Offset: 0x000FCE74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x000FEC80 File Offset: 0x000FCE80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001DA7 RID: 7591
		private static readonly MessageParser<PartyResetCampaignState> _parser = new MessageParser<PartyResetCampaignState>(() => new PartyResetCampaignState());

		// Token: 0x04001DA8 RID: 7592
		private UnknownFieldSet _unknownFields;
	}
}

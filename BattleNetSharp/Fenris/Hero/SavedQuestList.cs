using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x020001A6 RID: 422
	public sealed class SavedQuestList : IMessage<SavedQuestList>, IMessage, IEquatable<SavedQuestList>, IDeepCloneable<SavedQuestList>, IBufferMessage
	{
		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x000AE88C File Offset: 0x000ACA8C
		[DebuggerNonUserCode]
		public static MessageParser<SavedQuestList> Parser
		{
			get
			{
				return SavedQuestList._parser;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x000AE8A4 File Offset: 0x000ACAA4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x000AE8C8 File Offset: 0x000ACAC8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavedQuestList.Descriptor;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000AE8DF File Offset: 0x000ACADF
		[DebuggerNonUserCode]
		public SavedQuestList()
		{
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000AE8F4 File Offset: 0x000ACAF4
		[DebuggerNonUserCode]
		public SavedQuestList(SavedQuestList other)
			: this()
		{
			this.savedQuests_ = other.savedQuests_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000AE920 File Offset: 0x000ACB20
		[DebuggerNonUserCode]
		public SavedQuestList Clone()
		{
			return new SavedQuestList(this);
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002C7D RID: 11389 RVA: 0x000AE938 File Offset: 0x000ACB38
		[DebuggerNonUserCode]
		public RepeatedField<SavedQuest> SavedQuests
		{
			get
			{
				return this.savedQuests_;
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000AE950 File Offset: 0x000ACB50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavedQuestList);
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000AE970 File Offset: 0x000ACB70
		[DebuggerNonUserCode]
		public bool Equals(SavedQuestList other)
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
					bool flag4 = !this.savedQuests_.Equals(other.savedQuests_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000AE9CC File Offset: 0x000ACBCC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.savedQuests_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000AEA0C File Offset: 0x000ACC0C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000AEA24 File Offset: 0x000ACC24
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000AEA30 File Offset: 0x000ACC30
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.savedQuests_.WriteTo(ref output, SavedQuestList._repeated_savedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000AEA6C File Offset: 0x000ACC6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.savedQuests_.CalculateSize(SavedQuestList._repeated_savedQuests_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000AEAB4 File Offset: 0x000ACCB4
		[DebuggerNonUserCode]
		public void MergeFrom(SavedQuestList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.savedQuests_.Add(other.savedQuests_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000AEAF6 File Offset: 0x000ACCF6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000AEB04 File Offset: 0x000ACD04
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
					this.savedQuests_.AddEntriesFrom(ref input, SavedQuestList._repeated_savedQuests_codec);
				}
			}
		}

		// Token: 0x04001414 RID: 5140
		private static readonly MessageParser<SavedQuestList> _parser = new MessageParser<SavedQuestList>(() => new SavedQuestList());

		// Token: 0x04001415 RID: 5141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001416 RID: 5142
		public const int SavedQuestsFieldNumber = 1;

		// Token: 0x04001417 RID: 5143
		private static readonly FieldCodec<SavedQuest> _repeated_savedQuests_codec = FieldCodec.ForMessage<SavedQuest>(10U, SavedQuest.Parser);

		// Token: 0x04001418 RID: 5144
		private readonly RepeatedField<SavedQuest> savedQuests_ = new RepeatedField<SavedQuest>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x0200012D RID: 301
	public sealed class QuestLuaRuntimeErrorMessage : IMessage<QuestLuaRuntimeErrorMessage>, IMessage, IEquatable<QuestLuaRuntimeErrorMessage>, IDeepCloneable<QuestLuaRuntimeErrorMessage>, IBufferMessage
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00073F38 File Offset: 0x00072138
		[DebuggerNonUserCode]
		public static MessageParser<QuestLuaRuntimeErrorMessage> Parser
		{
			get
			{
				return QuestLuaRuntimeErrorMessage._parser;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x00073F50 File Offset: 0x00072150
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuestReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00073F74 File Offset: 0x00072174
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestLuaRuntimeErrorMessage.Descriptor;
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00073F8B File Offset: 0x0007218B
		[DebuggerNonUserCode]
		public QuestLuaRuntimeErrorMessage()
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00073F95 File Offset: 0x00072195
		[DebuggerNonUserCode]
		public QuestLuaRuntimeErrorMessage(QuestLuaRuntimeErrorMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.questId_ = other.questId_;
			this.luaRuntimeError_ = other.luaRuntimeError_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00073FD4 File Offset: 0x000721D4
		[DebuggerNonUserCode]
		public QuestLuaRuntimeErrorMessage Clone()
		{
			return new QuestLuaRuntimeErrorMessage(this);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x00073FEC File Offset: 0x000721EC
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x0007401D File Offset: 0x0007221D
		[DebuggerNonUserCode]
		public int QuestId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int questIdDefaultValue;
				if (flag)
				{
					questIdDefaultValue = this.questId_;
				}
				else
				{
					questIdDefaultValue = QuestLuaRuntimeErrorMessage.QuestIdDefaultValue;
				}
				return questIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.questId_ = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00074038 File Offset: 0x00072238
		[DebuggerNonUserCode]
		public bool HasQuestId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00074055 File Offset: 0x00072255
		[DebuggerNonUserCode]
		public void ClearQuestId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00074068 File Offset: 0x00072268
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x00074089 File Offset: 0x00072289
		[DebuggerNonUserCode]
		public string LuaRuntimeError
		{
			get
			{
				return this.luaRuntimeError_ ?? QuestLuaRuntimeErrorMessage.LuaRuntimeErrorDefaultValue;
			}
			set
			{
				this.luaRuntimeError_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x000740A0 File Offset: 0x000722A0
		[DebuggerNonUserCode]
		public bool HasLuaRuntimeError
		{
			get
			{
				return this.luaRuntimeError_ != null;
			}
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000740BB File Offset: 0x000722BB
		[DebuggerNonUserCode]
		public void ClearLuaRuntimeError()
		{
			this.luaRuntimeError_ = null;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000740C8 File Offset: 0x000722C8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestLuaRuntimeErrorMessage);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000740E8 File Offset: 0x000722E8
		[DebuggerNonUserCode]
		public bool Equals(QuestLuaRuntimeErrorMessage other)
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
					bool flag4 = this.QuestId != other.QuestId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.LuaRuntimeError != other.LuaRuntimeError;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0007415C File Offset: 0x0007235C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num ^= this.QuestId.GetHashCode();
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				num ^= this.LuaRuntimeError.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000741C8 File Offset: 0x000723C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000741E0 File Offset: 0x000723E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000741EC File Offset: 0x000723EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				output.WriteRawTag(18);
				output.WriteString(this.LuaRuntimeError);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0007425C File Offset: 0x0007245C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasQuestId = this.HasQuestId;
			if (hasQuestId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			bool hasLuaRuntimeError = this.HasLuaRuntimeError;
			if (hasLuaRuntimeError)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LuaRuntimeError);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000742C8 File Offset: 0x000724C8
		[DebuggerNonUserCode]
		public void MergeFrom(QuestLuaRuntimeErrorMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasQuestId = other.HasQuestId;
				if (hasQuestId)
				{
					this.QuestId = other.QuestId;
				}
				bool hasLuaRuntimeError = other.HasLuaRuntimeError;
				if (hasLuaRuntimeError)
				{
					this.LuaRuntimeError = other.LuaRuntimeError;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0007432A File Offset: 0x0007252A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00074338 File Offset: 0x00072538
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LuaRuntimeError = input.ReadString();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000CF9 RID: 3321
		private static readonly MessageParser<QuestLuaRuntimeErrorMessage> _parser = new MessageParser<QuestLuaRuntimeErrorMessage>(() => new QuestLuaRuntimeErrorMessage());

		// Token: 0x04000CFA RID: 3322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CFB RID: 3323
		private int _hasBits0;

		// Token: 0x04000CFC RID: 3324
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04000CFD RID: 3325
		private static readonly int QuestIdDefaultValue = 0;

		// Token: 0x04000CFE RID: 3326
		private int questId_;

		// Token: 0x04000CFF RID: 3327
		public const int LuaRuntimeErrorFieldNumber = 2;

		// Token: 0x04000D00 RID: 3328
		private static readonly string LuaRuntimeErrorDefaultValue = "";

		// Token: 0x04000D01 RID: 3329
		private string luaRuntimeError_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ItemCrafting
{
	// Token: 0x02000173 RID: 371
	public sealed class CrafterTransmogData : IMessage<CrafterTransmogData>, IMessage, IEquatable<CrafterTransmogData>, IDeepCloneable<CrafterTransmogData>, IBufferMessage
	{
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x00095FFC File Offset: 0x000941FC
		[DebuggerNonUserCode]
		public static MessageParser<CrafterTransmogData> Parser
		{
			get
			{
				return CrafterTransmogData._parser;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x00096014 File Offset: 0x00094214
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ItemCraftingReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x00096038 File Offset: 0x00094238
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CrafterTransmogData.Descriptor;
			}
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0009604F File Offset: 0x0009424F
		[DebuggerNonUserCode]
		public CrafterTransmogData()
		{
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0009605C File Offset: 0x0009425C
		[DebuggerNonUserCode]
		public CrafterTransmogData(CrafterTransmogData other)
			: this()
		{
			this.unlockedTransmogs_ = ((other.unlockedTransmogs_ != null) ? other.unlockedTransmogs_.Clone() : null);
			this.achievementTransmogs_ = ((other.achievementTransmogs_ != null) ? other.achievementTransmogs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000960BC File Offset: 0x000942BC
		[DebuggerNonUserCode]
		public CrafterTransmogData Clone()
		{
			return new CrafterTransmogData(this);
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000960D4 File Offset: 0x000942D4
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x000960EC File Offset: 0x000942EC
		[DebuggerNonUserCode]
		public UnlockedTransmogs UnlockedTransmogs
		{
			get
			{
				return this.unlockedTransmogs_;
			}
			set
			{
				this.unlockedTransmogs_ = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000960F8 File Offset: 0x000942F8
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00096110 File Offset: 0x00094310
		[DebuggerNonUserCode]
		public UnlockedTransmogs AchievementTransmogs
		{
			get
			{
				return this.achievementTransmogs_;
			}
			set
			{
				this.achievementTransmogs_ = value;
			}
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0009611C File Offset: 0x0009431C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CrafterTransmogData);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0009613C File Offset: 0x0009433C
		[DebuggerNonUserCode]
		public bool Equals(CrafterTransmogData other)
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
					bool flag4 = !object.Equals(this.UnlockedTransmogs, other.UnlockedTransmogs);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.AchievementTransmogs, other.AchievementTransmogs);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000961B4 File Offset: 0x000943B4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.unlockedTransmogs_ != null;
			if (flag)
			{
				num ^= this.UnlockedTransmogs.GetHashCode();
			}
			bool flag2 = this.achievementTransmogs_ != null;
			if (flag2)
			{
				num ^= this.AchievementTransmogs.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00096220 File Offset: 0x00094420
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00096238 File Offset: 0x00094438
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00096244 File Offset: 0x00094444
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.unlockedTransmogs_ != null;
			if (flag)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UnlockedTransmogs);
			}
			bool flag2 = this.achievementTransmogs_ != null;
			if (flag2)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.AchievementTransmogs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000962B8 File Offset: 0x000944B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.unlockedTransmogs_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockedTransmogs);
			}
			bool flag2 = this.achievementTransmogs_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementTransmogs);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0009632C File Offset: 0x0009452C
		[DebuggerNonUserCode]
		public void MergeFrom(CrafterTransmogData other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.unlockedTransmogs_ != null;
				if (flag2)
				{
					bool flag3 = this.unlockedTransmogs_ == null;
					if (flag3)
					{
						this.UnlockedTransmogs = new UnlockedTransmogs();
					}
					this.UnlockedTransmogs.MergeFrom(other.UnlockedTransmogs);
				}
				bool flag4 = other.achievementTransmogs_ != null;
				if (flag4)
				{
					bool flag5 = this.achievementTransmogs_ == null;
					if (flag5)
					{
						this.AchievementTransmogs = new UnlockedTransmogs();
					}
					this.AchievementTransmogs.MergeFrom(other.AchievementTransmogs);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000963D9 File Offset: 0x000945D9
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000963E4 File Offset: 0x000945E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 34U)
				{
					if (num3 != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.achievementTransmogs_ == null;
						if (flag)
						{
							this.AchievementTransmogs = new UnlockedTransmogs();
						}
						input.ReadMessage(this.AchievementTransmogs);
					}
				}
				else
				{
					bool flag2 = this.unlockedTransmogs_ == null;
					if (flag2)
					{
						this.UnlockedTransmogs = new UnlockedTransmogs();
					}
					input.ReadMessage(this.UnlockedTransmogs);
				}
			}
		}

		// Token: 0x04001117 RID: 4375
		private static readonly MessageParser<CrafterTransmogData> _parser = new MessageParser<CrafterTransmogData>(() => new CrafterTransmogData());

		// Token: 0x04001118 RID: 4376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001119 RID: 4377
		public const int UnlockedTransmogsFieldNumber = 4;

		// Token: 0x0400111A RID: 4378
		private UnlockedTransmogs unlockedTransmogs_;

		// Token: 0x0400111B RID: 4379
		public const int AchievementTransmogsFieldNumber = 5;

		// Token: 0x0400111C RID: 4380
		private UnlockedTransmogs achievementTransmogs_;
	}
}

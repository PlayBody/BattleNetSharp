using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.DiabloClone
{
	// Token: 0x020007A0 RID: 1952
	public sealed class Progression : IMessage<Progression>, IMessage, IEquatable<Progression>, IDeepCloneable<Progression>, IBufferMessage
	{
		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600B32F RID: 45871 RVA: 0x002B9B94 File Offset: 0x002B7D94
		[DebuggerNonUserCode]
		public static MessageParser<Progression> Parser
		{
			get
			{
				return Progression._parser;
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600B330 RID: 45872 RVA: 0x002B9BAC File Offset: 0x002B7DAC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiabloCloneReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600B331 RID: 45873 RVA: 0x002B9BD0 File Offset: 0x002B7DD0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Progression.Descriptor;
			}
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x002B9BE7 File Offset: 0x002B7DE7
		[DebuggerNonUserCode]
		public Progression()
		{
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x002B9BF1 File Offset: 0x002B7DF1
		[DebuggerNonUserCode]
		public Progression(Progression other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.gameType_ = other.gameType_;
			this.progressionStatus_ = other.progressionStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x002B9C30 File Offset: 0x002B7E30
		[DebuggerNonUserCode]
		public Progression Clone()
		{
			return new Progression(this);
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600B335 RID: 45877 RVA: 0x002B9C48 File Offset: 0x002B7E48
		// (set) Token: 0x0600B336 RID: 45878 RVA: 0x002B9C79 File Offset: 0x002B7E79
		[DebuggerNonUserCode]
		public GameType GameType
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				GameType gameTypeDefaultValue;
				if (flag)
				{
					gameTypeDefaultValue = this.gameType_;
				}
				else
				{
					gameTypeDefaultValue = Progression.GameTypeDefaultValue;
				}
				return gameTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameType_ = value;
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600B337 RID: 45879 RVA: 0x002B9C94 File Offset: 0x002B7E94
		[DebuggerNonUserCode]
		public bool HasGameType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x002B9CB1 File Offset: 0x002B7EB1
		[DebuggerNonUserCode]
		public void ClearGameType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600B339 RID: 45881 RVA: 0x002B9CC4 File Offset: 0x002B7EC4
		// (set) Token: 0x0600B33A RID: 45882 RVA: 0x002B9CF5 File Offset: 0x002B7EF5
		[DebuggerNonUserCode]
		public ProgressionStatus ProgressionStatus
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ProgressionStatus progressionStatusDefaultValue;
				if (flag)
				{
					progressionStatusDefaultValue = this.progressionStatus_;
				}
				else
				{
					progressionStatusDefaultValue = Progression.ProgressionStatusDefaultValue;
				}
				return progressionStatusDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.progressionStatus_ = value;
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600B33B RID: 45883 RVA: 0x002B9D10 File Offset: 0x002B7F10
		[DebuggerNonUserCode]
		public bool HasProgressionStatus
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x002B9D2D File Offset: 0x002B7F2D
		[DebuggerNonUserCode]
		public void ClearProgressionStatus()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x002B9D40 File Offset: 0x002B7F40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Progression);
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x002B9D60 File Offset: 0x002B7F60
		[DebuggerNonUserCode]
		public bool Equals(Progression other)
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
					bool flag4 = this.GameType != other.GameType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ProgressionStatus != other.ProgressionStatus;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x002B9DD4 File Offset: 0x002B7FD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num ^= this.GameType.GetHashCode();
			}
			bool hasProgressionStatus = this.HasProgressionStatus;
			if (hasProgressionStatus)
			{
				num ^= this.ProgressionStatus.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x002B9E50 File Offset: 0x002B8050
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x002B9E68 File Offset: 0x002B8068
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x002B9E74 File Offset: 0x002B8074
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GameType);
			}
			bool hasProgressionStatus = this.HasProgressionStatus;
			if (hasProgressionStatus)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ProgressionStatus);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x002B9EE4 File Offset: 0x002B80E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameType = this.HasGameType;
			if (hasGameType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GameType);
			}
			bool hasProgressionStatus = this.HasProgressionStatus;
			if (hasProgressionStatus)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ProgressionStatus);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x002B9F50 File Offset: 0x002B8150
		[DebuggerNonUserCode]
		public void MergeFrom(Progression other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameType = other.HasGameType;
				if (hasGameType)
				{
					this.GameType = other.GameType;
				}
				bool hasProgressionStatus = other.HasProgressionStatus;
				if (hasProgressionStatus)
				{
					this.ProgressionStatus = other.ProgressionStatus;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x002B9FB2 File Offset: 0x002B81B2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x002B9FC0 File Offset: 0x002B81C0
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ProgressionStatus = (ProgressionStatus)input.ReadEnum();
					}
				}
				else
				{
					this.GameType = (GameType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005108 RID: 20744
		private static readonly MessageParser<Progression> _parser = new MessageParser<Progression>(() => new Progression());

		// Token: 0x04005109 RID: 20745
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400510A RID: 20746
		private int _hasBits0;

		// Token: 0x0400510B RID: 20747
		public const int GameTypeFieldNumber = 1;

		// Token: 0x0400510C RID: 20748
		private static readonly GameType GameTypeDefaultValue = GameType.Classic;

		// Token: 0x0400510D RID: 20749
		private GameType gameType_;

		// Token: 0x0400510E RID: 20750
		public const int ProgressionStatusFieldNumber = 2;

		// Token: 0x0400510F RID: 20751
		private static readonly ProgressionStatus ProgressionStatusDefaultValue = ProgressionStatus.TerrorGazesUponSanctuary;

		// Token: 0x04005110 RID: 20752
		private ProgressionStatus progressionStatus_;
	}
}

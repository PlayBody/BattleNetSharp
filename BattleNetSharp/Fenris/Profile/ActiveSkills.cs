using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000133 RID: 307
	public sealed class ActiveSkills : IMessage<ActiveSkills>, IMessage, IEquatable<ActiveSkills>, IDeepCloneable<ActiveSkills>, IBufferMessage
	{
		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x000766A8 File Offset: 0x000748A8
		[DebuggerNonUserCode]
		public static MessageParser<ActiveSkills> Parser
		{
			get
			{
				return ActiveSkills._parser;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x000766C0 File Offset: 0x000748C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x000766E4 File Offset: 0x000748E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveSkills.Descriptor;
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x000766FB File Offset: 0x000748FB
		[DebuggerNonUserCode]
		public ActiveSkills()
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00076710 File Offset: 0x00074910
		[DebuggerNonUserCode]
		public ActiveSkills(ActiveSkills other)
			: this()
		{
			this.snoSkills_ = other.snoSkills_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0007673C File Offset: 0x0007493C
		[DebuggerNonUserCode]
		public ActiveSkills Clone()
		{
			return new ActiveSkills(this);
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00076754 File Offset: 0x00074954
		[DebuggerNonUserCode]
		public RepeatedField<int> SnoSkills
		{
			get
			{
				return this.snoSkills_;
			}
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0007676C File Offset: 0x0007496C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveSkills);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0007678C File Offset: 0x0007498C
		[DebuggerNonUserCode]
		public bool Equals(ActiveSkills other)
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
					bool flag4 = !this.snoSkills_.Equals(other.snoSkills_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x000767E8 File Offset: 0x000749E8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.snoSkills_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00076828 File Offset: 0x00074A28
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00076840 File Offset: 0x00074A40
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0007684C File Offset: 0x00074A4C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.snoSkills_.WriteTo(ref output, ActiveSkills._repeated_snoSkills_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00076888 File Offset: 0x00074A88
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.snoSkills_.CalculateSize(ActiveSkills._repeated_snoSkills_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000768D0 File Offset: 0x00074AD0
		[DebuggerNonUserCode]
		public void MergeFrom(ActiveSkills other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.snoSkills_.Add(other.snoSkills_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00076912 File Offset: 0x00074B12
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00076920 File Offset: 0x00074B20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U && num3 != 13U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.snoSkills_.AddEntriesFrom(ref input, ActiveSkills._repeated_snoSkills_codec);
				}
			}
		}

		// Token: 0x04000D48 RID: 3400
		private static readonly MessageParser<ActiveSkills> _parser = new MessageParser<ActiveSkills>(() => new ActiveSkills());

		// Token: 0x04000D49 RID: 3401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D4A RID: 3402
		public const int SnoSkillsFieldNumber = 1;

		// Token: 0x04000D4B RID: 3403
		private static readonly FieldCodec<int> _repeated_snoSkills_codec = FieldCodec.ForSFixed32(13U);

		// Token: 0x04000D4C RID: 3404
		private readonly RepeatedField<int> snoSkills_ = new RepeatedField<int>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000381 RID: 897
	public sealed class test : IMessage<test>, IMessage, IEquatable<test>, IDeepCloneable<test>, IBufferMessage
	{
		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x00161570 File Offset: 0x0015F770
		[DebuggerNonUserCode]
		public static MessageParser<test> Parser
		{
			get
			{
				return test._parser;
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x00161588 File Offset: 0x0015F788
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InvitationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x001615AC File Offset: 0x0015F7AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return test.Descriptor;
			}
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x001615C3 File Offset: 0x0015F7C3
		[DebuggerNonUserCode]
		public test()
		{
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x001615D8 File Offset: 0x0015F7D8
		[DebuggerNonUserCode]
		public test(test other)
			: this()
		{
			this.targetBattleTag_ = other.targetBattleTag_;
			this.role_ = other.role_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x00161610 File Offset: 0x0015F810
		[DebuggerNonUserCode]
		public test Clone()
		{
			return new test(this);
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x00161628 File Offset: 0x0015F828
		// (set) Token: 0x06005B57 RID: 23383 RVA: 0x00161649 File Offset: 0x0015F849
		[DebuggerNonUserCode]
		public string TargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ ?? test.TargetBattleTagDefaultValue;
			}
			set
			{
				this.targetBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x00161660 File Offset: 0x0015F860
		[DebuggerNonUserCode]
		public bool HasTargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ != null;
			}
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x0016167B File Offset: 0x0015F87B
		[DebuggerNonUserCode]
		public void ClearTargetBattleTag()
		{
			this.targetBattleTag_ = null;
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x00161688 File Offset: 0x0015F888
		[DebuggerNonUserCode]
		public RepeatedField<uint> Role
		{
			get
			{
				return this.role_;
			}
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x001616A0 File Offset: 0x0015F8A0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as test);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x001616C0 File Offset: 0x0015F8C0
		[DebuggerNonUserCode]
		public bool Equals(test other)
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
					bool flag4 = this.TargetBattleTag != other.TargetBattleTag;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.role_.Equals(other.role_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00161734 File Offset: 0x0015F934
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num ^= this.TargetBattleTag.GetHashCode();
			}
			num ^= this.role_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x0016178C File Offset: 0x0015F98C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x001617A4 File Offset: 0x0015F9A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x001617B0 File Offset: 0x0015F9B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TargetBattleTag);
			}
			this.role_.WriteTo(ref output, test._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x00161810 File Offset: 0x0015FA10
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetBattleTag);
			}
			num += this.role_.CalculateSize(test._repeated_role_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x00161874 File Offset: 0x0015FA74
		[DebuggerNonUserCode]
		public void MergeFrom(test other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetBattleTag = other.HasTargetBattleTag;
				if (hasTargetBattleTag)
				{
					this.TargetBattleTag = other.TargetBattleTag;
				}
				this.role_.Add(other.role_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x001618CF File Offset: 0x0015FACF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x001618DC File Offset: 0x0015FADC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 48U && num3 != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.role_.AddEntriesFrom(ref input, test._repeated_role_codec);
					}
				}
				else
				{
					this.TargetBattleTag = input.ReadString();
				}
			}
		}

		// Token: 0x040029B0 RID: 10672
		private static readonly MessageParser<test> _parser = new MessageParser<test>(() => new test());

		// Token: 0x040029B1 RID: 10673
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B2 RID: 10674
		public const int TargetBattleTagFieldNumber = 2;

		// Token: 0x040029B3 RID: 10675
		private static readonly string TargetBattleTagDefaultValue = "";

		// Token: 0x040029B4 RID: 10676
		private string targetBattleTag_;

		// Token: 0x040029B5 RID: 10677
		public const int RoleFieldNumber = 6;

		// Token: 0x040029B6 RID: 10678
		private static readonly FieldCodec<uint> _repeated_role_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x040029B7 RID: 10679
		private readonly RepeatedField<uint> role_ = new RepeatedField<uint>();
	}
}

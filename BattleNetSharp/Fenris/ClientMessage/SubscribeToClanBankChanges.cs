using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000278 RID: 632
	public sealed class SubscribeToClanBankChanges : IMessage<SubscribeToClanBankChanges>, IMessage, IEquatable<SubscribeToClanBankChanges>, IDeepCloneable<SubscribeToClanBankChanges>, IBufferMessage
	{
		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x00105598 File Offset: 0x00103798
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeToClanBankChanges> Parser
		{
			get
			{
				return SubscribeToClanBankChanges._parser;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06004395 RID: 17301 RVA: 0x001055B0 File Offset: 0x001037B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[104];
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x001055D4 File Offset: 0x001037D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeToClanBankChanges.Descriptor;
			}
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x001055EB File Offset: 0x001037EB
		[DebuggerNonUserCode]
		public SubscribeToClanBankChanges()
		{
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x001055F5 File Offset: 0x001037F5
		[DebuggerNonUserCode]
		public SubscribeToClanBankChanges(SubscribeToClanBankChanges other)
			: this()
		{
			this.clanId_ = other.clanId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0010561C File Offset: 0x0010381C
		[DebuggerNonUserCode]
		public SubscribeToClanBankChanges Clone()
		{
			return new SubscribeToClanBankChanges(this);
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x00105634 File Offset: 0x00103834
		// (set) Token: 0x0600439B RID: 17307 RVA: 0x00105655 File Offset: 0x00103855
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? SubscribeToClanBankChanges.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x0600439C RID: 17308 RVA: 0x0010566C File Offset: 0x0010386C
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00105687 File Offset: 0x00103887
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00105694 File Offset: 0x00103894
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeToClanBankChanges);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x001056B4 File Offset: 0x001038B4
		[DebuggerNonUserCode]
		public bool Equals(SubscribeToClanBankChanges other)
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
					bool flag4 = this.ClanId != other.ClanId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0010570C File Offset: 0x0010390C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00105758 File Offset: 0x00103958
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00105770 File Offset: 0x00103970
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x0010577C File Offset: 0x0010397C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x001057C8 File Offset: 0x001039C8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00105818 File Offset: 0x00103A18
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeToClanBankChanges other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00105861 File Offset: 0x00103A61
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0010586C File Offset: 0x00103A6C
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
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001E69 RID: 7785
		private static readonly MessageParser<SubscribeToClanBankChanges> _parser = new MessageParser<SubscribeToClanBankChanges>(() => new SubscribeToClanBankChanges());

		// Token: 0x04001E6A RID: 7786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E6B RID: 7787
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001E6C RID: 7788
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001E6D RID: 7789
		private string clanId_;
	}
}

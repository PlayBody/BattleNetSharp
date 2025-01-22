using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FE RID: 254
	public sealed class UpdateEncryptedSnos : IMessage<UpdateEncryptedSnos>, IMessage, IEquatable<UpdateEncryptedSnos>, IDeepCloneable<UpdateEncryptedSnos>, IBufferMessage
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00056F3C File Offset: 0x0005513C
		[DebuggerNonUserCode]
		public static MessageParser<UpdateEncryptedSnos> Parser
		{
			get
			{
				return UpdateEncryptedSnos._parser;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00056F54 File Offset: 0x00055154
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[231];
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00056F7C File Offset: 0x0005517C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEncryptedSnos.Descriptor;
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00056F93 File Offset: 0x00055193
		[DebuggerNonUserCode]
		public UpdateEncryptedSnos()
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00056FA8 File Offset: 0x000551A8
		[DebuggerNonUserCode]
		public UpdateEncryptedSnos(UpdateEncryptedSnos other)
			: this()
		{
			this.encryptedSnos_ = other.encryptedSnos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00056FD4 File Offset: 0x000551D4
		[DebuggerNonUserCode]
		public UpdateEncryptedSnos Clone()
		{
			return new UpdateEncryptedSnos(this);
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00056FEC File Offset: 0x000551EC
		[DebuggerNonUserCode]
		public RepeatedField<EncryptedSno> EncryptedSnos
		{
			get
			{
				return this.encryptedSnos_;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00057004 File Offset: 0x00055204
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEncryptedSnos);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00057024 File Offset: 0x00055224
		[DebuggerNonUserCode]
		public bool Equals(UpdateEncryptedSnos other)
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
					bool flag4 = !this.encryptedSnos_.Equals(other.encryptedSnos_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00057080 File Offset: 0x00055280
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.encryptedSnos_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000570C0 File Offset: 0x000552C0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000570D8 File Offset: 0x000552D8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000570E4 File Offset: 0x000552E4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.encryptedSnos_.WriteTo(ref output, UpdateEncryptedSnos._repeated_encryptedSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00057120 File Offset: 0x00055320
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.encryptedSnos_.CalculateSize(UpdateEncryptedSnos._repeated_encryptedSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00057168 File Offset: 0x00055368
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateEncryptedSnos other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.encryptedSnos_.Add(other.encryptedSnos_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000571AA File Offset: 0x000553AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000571B8 File Offset: 0x000553B8
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
					this.encryptedSnos_.AddEntriesFrom(ref input, UpdateEncryptedSnos._repeated_encryptedSnos_codec);
				}
			}
		}

		// Token: 0x040009B9 RID: 2489
		private static readonly MessageParser<UpdateEncryptedSnos> _parser = new MessageParser<UpdateEncryptedSnos>(() => new UpdateEncryptedSnos());

		// Token: 0x040009BA RID: 2490
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009BB RID: 2491
		public const int EncryptedSnosFieldNumber = 1;

		// Token: 0x040009BC RID: 2492
		private static readonly FieldCodec<EncryptedSno> _repeated_encryptedSnos_codec = FieldCodec.ForMessage<EncryptedSno>(10U, EncryptedSno.Parser);

		// Token: 0x040009BD RID: 2493
		private readonly RepeatedField<EncryptedSno> encryptedSnos_ = new RepeatedField<EncryptedSno>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000597 RID: 1431
	public sealed class SubscribeOptions : IMessage<SubscribeOptions>, IMessage, IEquatable<SubscribeOptions>, IDeepCloneable<SubscribeOptions>, IBufferMessage
	{
		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x00212830 File Offset: 0x00210A30
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeOptions> Parser
		{
			get
			{
				return SubscribeOptions._parser;
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600888C RID: 34956 RVA: 0x00212848 File Offset: 0x00210A48
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x0021286C File Offset: 0x00210A6C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeOptions.Descriptor;
			}
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x00212883 File Offset: 0x00210A83
		[DebuggerNonUserCode]
		public SubscribeOptions()
		{
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x0021288D File Offset: 0x00210A8D
		[DebuggerNonUserCode]
		public SubscribeOptions(SubscribeOptions other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x002128A8 File Offset: 0x00210AA8
		[DebuggerNonUserCode]
		public SubscribeOptions Clone()
		{
			return new SubscribeOptions(this);
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x002128C0 File Offset: 0x00210AC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeOptions);
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x002128E0 File Offset: 0x00210AE0
		[DebuggerNonUserCode]
		public bool Equals(SubscribeOptions other)
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

		// Token: 0x06008893 RID: 34963 RVA: 0x00212920 File Offset: 0x00210B20
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

		// Token: 0x06008894 RID: 34964 RVA: 0x00212954 File Offset: 0x00210B54
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x0021296C File Offset: 0x00210B6C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x00212978 File Offset: 0x00210B78
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x002129A4 File Offset: 0x00210BA4
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

		// Token: 0x06008898 RID: 34968 RVA: 0x002129D8 File Offset: 0x00210BD8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x00212A08 File Offset: 0x00210C08
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x00212A14 File Offset: 0x00210C14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003DD5 RID: 15829
		private static readonly MessageParser<SubscribeOptions> _parser = new MessageParser<SubscribeOptions>(() => new SubscribeOptions());

		// Token: 0x04003DD6 RID: 15830
		private UnknownFieldSet _unknownFields;
	}
}

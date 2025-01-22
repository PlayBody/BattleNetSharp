using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V2.Client
{
	// Token: 0x020005C7 RID: 1479
	public sealed class UpdateRequest : IMessage<UpdateRequest>, IMessage, IEquatable<UpdateRequest>, IDeepCloneable<UpdateRequest>, IBufferMessage
	{
		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x0021F7FC File Offset: 0x0021D9FC
		[DebuggerNonUserCode]
		public static MessageParser<UpdateRequest> Parser
		{
			get
			{
				return UpdateRequest._parser;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x0021F814 File Offset: 0x0021DA14
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06008C0B RID: 35851 RVA: 0x0021F838 File Offset: 0x0021DA38
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRequest.Descriptor;
			}
		}

		// Token: 0x06008C0C RID: 35852 RVA: 0x0021F84F File Offset: 0x0021DA4F
		[DebuggerNonUserCode]
		public UpdateRequest()
		{
		}

		// Token: 0x06008C0D RID: 35853 RVA: 0x0021F864 File Offset: 0x0021DA64
		[DebuggerNonUserCode]
		public UpdateRequest(UpdateRequest other)
			: this()
		{
			this.updates_ = other.updates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x0021F890 File Offset: 0x0021DA90
		[DebuggerNonUserCode]
		public UpdateRequest Clone()
		{
			return new UpdateRequest(this);
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x0021F8A8 File Offset: 0x0021DAA8
		[DebuggerNonUserCode]
		public RepeatedField<PresenceFieldUpdate> Updates
		{
			get
			{
				return this.updates_;
			}
		}

		// Token: 0x06008C10 RID: 35856 RVA: 0x0021F8C0 File Offset: 0x0021DAC0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRequest);
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x0021F8E0 File Offset: 0x0021DAE0
		[DebuggerNonUserCode]
		public bool Equals(UpdateRequest other)
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
					bool flag4 = !this.updates_.Equals(other.updates_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x0021F93C File Offset: 0x0021DB3C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updates_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C13 RID: 35859 RVA: 0x0021F97C File Offset: 0x0021DB7C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C14 RID: 35860 RVA: 0x0021F994 File Offset: 0x0021DB94
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x0021F9A0 File Offset: 0x0021DBA0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updates_.WriteTo(ref output, UpdateRequest._repeated_updates_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C16 RID: 35862 RVA: 0x0021F9DC File Offset: 0x0021DBDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updates_.CalculateSize(UpdateRequest._repeated_updates_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C17 RID: 35863 RVA: 0x0021FA24 File Offset: 0x0021DC24
		[DebuggerNonUserCode]
		public void MergeFrom(UpdateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.updates_.Add(other.updates_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008C18 RID: 35864 RVA: 0x0021FA66 File Offset: 0x0021DC66
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x0021FA74 File Offset: 0x0021DC74
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
					this.updates_.AddEntriesFrom(ref input, UpdateRequest._repeated_updates_codec);
				}
			}
		}

		// Token: 0x04003F56 RID: 16214
		private static readonly MessageParser<UpdateRequest> _parser = new MessageParser<UpdateRequest>(() => new UpdateRequest());

		// Token: 0x04003F57 RID: 16215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F58 RID: 16216
		public const int UpdatesFieldNumber = 1;

		// Token: 0x04003F59 RID: 16217
		private static readonly FieldCodec<PresenceFieldUpdate> _repeated_updates_codec = FieldCodec.ForMessage<PresenceFieldUpdate>(10U, PresenceFieldUpdate.Parser);

		// Token: 0x04003F5A RID: 16218
		private readonly RepeatedField<PresenceFieldUpdate> updates_ = new RepeatedField<PresenceFieldUpdate>();
	}
}

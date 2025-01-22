using System;
using System.Diagnostics;
using Fenris.Clan;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000277 RID: 631
	public sealed class ClanMyInvitesApplications : IMessage<ClanMyInvitesApplications>, IMessage, IEquatable<ClanMyInvitesApplications>, IDeepCloneable<ClanMyInvitesApplications>, IBufferMessage
	{
		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x001051DC File Offset: 0x001033DC
		[DebuggerNonUserCode]
		public static MessageParser<ClanMyInvitesApplications> Parser
		{
			get
			{
				return ClanMyInvitesApplications._parser;
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x001051F4 File Offset: 0x001033F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[103];
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x00105218 File Offset: 0x00103418
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClanMyInvitesApplications.Descriptor;
			}
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x0010522F File Offset: 0x0010342F
		[DebuggerNonUserCode]
		public ClanMyInvitesApplications()
		{
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0010524F File Offset: 0x0010344F
		[DebuggerNonUserCode]
		public ClanMyInvitesApplications(ClanMyInvitesApplications other)
			: this()
		{
			this.invite_ = other.invite_.Clone();
			this.application_ = other.application_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x0010528C File Offset: 0x0010348C
		[DebuggerNonUserCode]
		public ClanMyInvitesApplications Clone()
		{
			return new ClanMyInvitesApplications(this);
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x001052A4 File Offset: 0x001034A4
		[DebuggerNonUserCode]
		public RepeatedField<ClanInvite> Invite
		{
			get
			{
				return this.invite_;
			}
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x001052BC File Offset: 0x001034BC
		[DebuggerNonUserCode]
		public RepeatedField<ClanApplication> Application
		{
			get
			{
				return this.application_;
			}
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x001052D4 File Offset: 0x001034D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClanMyInvitesApplications);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x001052F4 File Offset: 0x001034F4
		[DebuggerNonUserCode]
		public bool Equals(ClanMyInvitesApplications other)
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
					bool flag4 = !this.invite_.Equals(other.invite_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.application_.Equals(other.application_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0010536C File Offset: 0x0010356C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.invite_.GetHashCode();
			num ^= this.application_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x001053BC File Offset: 0x001035BC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x001053D4 File Offset: 0x001035D4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x001053E0 File Offset: 0x001035E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.invite_.WriteTo(ref output, ClanMyInvitesApplications._repeated_invite_codec);
			this.application_.WriteTo(ref output, ClanMyInvitesApplications._repeated_application_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00105430 File Offset: 0x00103630
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.invite_.CalculateSize(ClanMyInvitesApplications._repeated_invite_codec);
			num += this.application_.CalculateSize(ClanMyInvitesApplications._repeated_application_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00105488 File Offset: 0x00103688
		[DebuggerNonUserCode]
		public void MergeFrom(ClanMyInvitesApplications other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.invite_.Add(other.invite_);
				this.application_.Add(other.application_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x001054DC File Offset: 0x001036DC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x001054E8 File Offset: 0x001036E8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.application_.AddEntriesFrom(ref input, ClanMyInvitesApplications._repeated_application_codec);
					}
				}
				else
				{
					this.invite_.AddEntriesFrom(ref input, ClanMyInvitesApplications._repeated_invite_codec);
				}
			}
		}

		// Token: 0x04001E61 RID: 7777
		private static readonly MessageParser<ClanMyInvitesApplications> _parser = new MessageParser<ClanMyInvitesApplications>(() => new ClanMyInvitesApplications());

		// Token: 0x04001E62 RID: 7778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E63 RID: 7779
		public const int InviteFieldNumber = 1;

		// Token: 0x04001E64 RID: 7780
		private static readonly FieldCodec<ClanInvite> _repeated_invite_codec = FieldCodec.ForMessage<ClanInvite>(10U, ClanInvite.Parser);

		// Token: 0x04001E65 RID: 7781
		private readonly RepeatedField<ClanInvite> invite_ = new RepeatedField<ClanInvite>();

		// Token: 0x04001E66 RID: 7782
		public const int ApplicationFieldNumber = 2;

		// Token: 0x04001E67 RID: 7783
		private static readonly FieldCodec<ClanApplication> _repeated_application_codec = FieldCodec.ForMessage<ClanApplication>(18U, ClanApplication.Parser);

		// Token: 0x04001E68 RID: 7784
		private readonly RepeatedField<ClanApplication> application_ = new RepeatedField<ClanApplication>();
	}
}

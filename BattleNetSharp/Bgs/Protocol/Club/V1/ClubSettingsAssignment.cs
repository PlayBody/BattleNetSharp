using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000448 RID: 1096
	public sealed class ClubSettingsAssignment : IMessage<ClubSettingsAssignment>, IMessage, IEquatable<ClubSettingsAssignment>, IDeepCloneable<ClubSettingsAssignment>, IBufferMessage
	{
		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06006C28 RID: 27688 RVA: 0x001A42C0 File Offset: 0x001A24C0
		[DebuggerNonUserCode]
		public static MessageParser<ClubSettingsAssignment> Parser
		{
			get
			{
				return ClubSettingsAssignment._parser;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x001A42D8 File Offset: 0x001A24D8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06006C2A RID: 27690 RVA: 0x001A42FC File Offset: 0x001A24FC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSettingsAssignment.Descriptor;
			}
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x001A4313 File Offset: 0x001A2513
		[DebuggerNonUserCode]
		public ClubSettingsAssignment()
		{
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x001A4328 File Offset: 0x001A2528
		[DebuggerNonUserCode]
		public ClubSettingsAssignment(ClubSettingsAssignment other)
			: this()
		{
			this.stream_ = other.stream_.Clone();
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x001A437C File Offset: 0x001A257C
		[DebuggerNonUserCode]
		public ClubSettingsAssignment Clone()
		{
			return new ClubSettingsAssignment(this);
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06006C2E RID: 27694 RVA: 0x001A4394 File Offset: 0x001A2594
		[Obsolete]
		[DebuggerNonUserCode]
		public RepeatedField<StreamSettings> Stream
		{
			get
			{
				return this.stream_;
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x001A43AC File Offset: 0x001A25AC
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x001A43C4 File Offset: 0x001A25C4
		[DebuggerNonUserCode]
		public ClubSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x001A43D0 File Offset: 0x001A25D0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSettingsAssignment);
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x001A43F0 File Offset: 0x001A25F0
		[DebuggerNonUserCode]
		public bool Equals(ClubSettingsAssignment other)
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
					bool flag4 = !this.stream_.Equals(other.stream_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Settings, other.Settings);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x001A4468 File Offset: 0x001A2668
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stream_.GetHashCode();
			bool flag = this.settings_ != null;
			if (flag)
			{
				num ^= this.Settings.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x001A44C4 File Offset: 0x001A26C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x001A44DC File Offset: 0x001A26DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x001A44E8 File Offset: 0x001A26E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stream_.WriteTo(ref output, ClubSettingsAssignment._repeated_stream_codec);
			bool flag = this.settings_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Settings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C37 RID: 27703 RVA: 0x001A454C File Offset: 0x001A274C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stream_.CalculateSize(ClubSettingsAssignment._repeated_stream_codec);
			bool flag = this.settings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x001A45B0 File Offset: 0x001A27B0
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSettingsAssignment other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.stream_.Add(other.stream_);
				bool flag2 = other.settings_ != null;
				if (flag2)
				{
					bool flag3 = this.settings_ == null;
					if (flag3)
					{
						this.Settings = new ClubSettings();
					}
					this.Settings.MergeFrom(other.Settings);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C39 RID: 27705 RVA: 0x001A462E File Offset: 0x001A282E
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C3A RID: 27706 RVA: 0x001A463C File Offset: 0x001A283C
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
						bool flag = this.settings_ == null;
						if (flag)
						{
							this.Settings = new ClubSettings();
						}
						input.ReadMessage(this.Settings);
					}
				}
				else
				{
					this.stream_.AddEntriesFrom(ref input, ClubSettingsAssignment._repeated_stream_codec);
				}
			}
		}

		// Token: 0x04003187 RID: 12679
		private static readonly MessageParser<ClubSettingsAssignment> _parser = new MessageParser<ClubSettingsAssignment>(() => new ClubSettingsAssignment());

		// Token: 0x04003188 RID: 12680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003189 RID: 12681
		public const int StreamFieldNumber = 1;

		// Token: 0x0400318A RID: 12682
		private static readonly FieldCodec<StreamSettings> _repeated_stream_codec = FieldCodec.ForMessage<StreamSettings>(10U, StreamSettings.Parser);

		// Token: 0x0400318B RID: 12683
		private readonly RepeatedField<StreamSettings> stream_ = new RepeatedField<StreamSettings>();

		// Token: 0x0400318C RID: 12684
		public const int SettingsFieldNumber = 2;

		// Token: 0x0400318D RID: 12685
		private ClubSettings settings_;
	}
}

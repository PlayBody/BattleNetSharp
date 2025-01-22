using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000447 RID: 1095
	public sealed class ClubSettingsOptions : IMessage<ClubSettingsOptions>, IMessage, IEquatable<ClubSettingsOptions>, IDeepCloneable<ClubSettingsOptions>, IBufferMessage
	{
		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06006C10 RID: 27664 RVA: 0x001A3D44 File Offset: 0x001A1F44
		[DebuggerNonUserCode]
		public static MessageParser<ClubSettingsOptions> Parser
		{
			get
			{
				return ClubSettingsOptions._parser;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06006C11 RID: 27665 RVA: 0x001A3D5C File Offset: 0x001A1F5C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06006C12 RID: 27666 RVA: 0x001A3D80 File Offset: 0x001A1F80
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSettingsOptions.Descriptor;
			}
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x001A3D97 File Offset: 0x001A1F97
		[DebuggerNonUserCode]
		public ClubSettingsOptions()
		{
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x001A3DAC File Offset: 0x001A1FAC
		[DebuggerNonUserCode]
		public ClubSettingsOptions(ClubSettingsOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.stream_ = other.stream_.Clone();
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x001A3E18 File Offset: 0x001A2018
		[DebuggerNonUserCode]
		public ClubSettingsOptions Clone()
		{
			return new ClubSettingsOptions(this);
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06006C16 RID: 27670 RVA: 0x001A3E30 File Offset: 0x001A2030
		[Obsolete]
		[DebuggerNonUserCode]
		public RepeatedField<StreamSettings> Stream
		{
			get
			{
				return this.stream_;
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06006C17 RID: 27671 RVA: 0x001A3E48 File Offset: 0x001A2048
		// (set) Token: 0x06006C18 RID: 27672 RVA: 0x001A3E60 File Offset: 0x001A2060
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

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06006C19 RID: 27673 RVA: 0x001A3E6C File Offset: 0x001A206C
		// (set) Token: 0x06006C1A RID: 27674 RVA: 0x001A3E9D File Offset: 0x001A209D
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = ClubSettingsOptions.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x001A3EB8 File Offset: 0x001A20B8
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x001A3ED5 File Offset: 0x001A20D5
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x001A3EE8 File Offset: 0x001A20E8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSettingsOptions);
		}

		// Token: 0x06006C1E RID: 27678 RVA: 0x001A3F08 File Offset: 0x001A2108
		[DebuggerNonUserCode]
		public bool Equals(ClubSettingsOptions other)
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
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Version != other.Version;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006C1F RID: 27679 RVA: 0x001A3F9C File Offset: 0x001A219C
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
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x001A4018 File Offset: 0x001A2218
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C21 RID: 27681 RVA: 0x001A4030 File Offset: 0x001A2230
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x001A403C File Offset: 0x001A223C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stream_.WriteTo(ref output, ClubSettingsOptions._repeated_stream_codec);
			bool flag = this.settings_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Settings);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x001A40C0 File Offset: 0x001A22C0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stream_.CalculateSize(ClubSettingsOptions._repeated_stream_codec);
			bool flag = this.settings_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x001A4144 File Offset: 0x001A2344
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSettingsOptions other)
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
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x001A41DB File Offset: 0x001A23DB
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x001A41E8 File Offset: 0x001A23E8
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Version = input.ReadUInt32();
						}
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
					this.stream_.AddEntriesFrom(ref input, ClubSettingsOptions._repeated_stream_codec);
				}
			}
		}

		// Token: 0x0400317C RID: 12668
		private static readonly MessageParser<ClubSettingsOptions> _parser = new MessageParser<ClubSettingsOptions>(() => new ClubSettingsOptions());

		// Token: 0x0400317D RID: 12669
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400317E RID: 12670
		private int _hasBits0;

		// Token: 0x0400317F RID: 12671
		public const int StreamFieldNumber = 1;

		// Token: 0x04003180 RID: 12672
		private static readonly FieldCodec<StreamSettings> _repeated_stream_codec = FieldCodec.ForMessage<StreamSettings>(10U, StreamSettings.Parser);

		// Token: 0x04003181 RID: 12673
		private readonly RepeatedField<StreamSettings> stream_ = new RepeatedField<StreamSettings>();

		// Token: 0x04003182 RID: 12674
		public const int SettingsFieldNumber = 2;

		// Token: 0x04003183 RID: 12675
		private ClubSettings settings_;

		// Token: 0x04003184 RID: 12676
		public const int VersionFieldNumber = 3;

		// Token: 0x04003185 RID: 12677
		private static readonly uint VersionDefaultValue = 0U;

		// Token: 0x04003186 RID: 12678
		private uint version_;
	}
}

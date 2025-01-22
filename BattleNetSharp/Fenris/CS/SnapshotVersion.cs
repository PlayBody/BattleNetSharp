using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000203 RID: 515
	public sealed class SnapshotVersion : IMessage<SnapshotVersion>, IMessage, IEquatable<SnapshotVersion>, IDeepCloneable<SnapshotVersion>, IBufferMessage
	{
		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x000E0250 File Offset: 0x000DE450
		[DebuggerNonUserCode]
		public static MessageParser<SnapshotVersion> Parser
		{
			get
			{
				return SnapshotVersion._parser;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x000E0268 File Offset: 0x000DE468
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x000E028C File Offset: 0x000DE48C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SnapshotVersion.Descriptor;
			}
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x000E02A3 File Offset: 0x000DE4A3
		[DebuggerNonUserCode]
		public SnapshotVersion()
		{
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x000E02B0 File Offset: 0x000DE4B0
		[DebuggerNonUserCode]
		public SnapshotVersion(SnapshotVersion other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.version_ = other.version_;
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x000E030C File Offset: 0x000DE50C
		[DebuggerNonUserCode]
		public SnapshotVersion Clone()
		{
			return new SnapshotVersion(this);
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x000E0324 File Offset: 0x000DE524
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x000E0355 File Offset: 0x000DE555
		[DebuggerNonUserCode]
		public ulong Version
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = SnapshotVersion.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.version_ = value;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x000E0370 File Offset: 0x000DE570
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x000E038D File Offset: 0x000DE58D
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x000E03A0 File Offset: 0x000DE5A0
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x000E03B8 File Offset: 0x000DE5B8
		[DebuggerNonUserCode]
		public Snapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x000E03C4 File Offset: 0x000DE5C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SnapshotVersion);
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x000E03E4 File Offset: 0x000DE5E4
		[DebuggerNonUserCode]
		public bool Equals(SnapshotVersion other)
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
					bool flag4 = this.Version != other.Version;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Snapshot, other.Snapshot);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x000E0458 File Offset: 0x000DE658
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x000E04C4 File Offset: 0x000DE6C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x000E04DC File Offset: 0x000DE6DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000E04E8 File Offset: 0x000DE6E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.Version);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000E0558 File Offset: 0x000DE758
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Version);
			}
			bool flag = this.snapshot_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000E05C8 File Offset: 0x000DE7C8
		[DebuggerNonUserCode]
		public void MergeFrom(SnapshotVersion other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				bool flag2 = other.snapshot_ != null;
				if (flag2)
				{
					bool flag3 = this.snapshot_ == null;
					if (flag3)
					{
						this.Snapshot = new Snapshot();
					}
					this.Snapshot.MergeFrom(other.Snapshot);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000E064D File Offset: 0x000DE84D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x000E0658 File Offset: 0x000DE858
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.snapshot_ == null;
						if (flag)
						{
							this.Snapshot = new Snapshot();
						}
						input.ReadMessage(this.Snapshot);
					}
				}
				else
				{
					this.Version = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04001A72 RID: 6770
		private static readonly MessageParser<SnapshotVersion> _parser = new MessageParser<SnapshotVersion>(() => new SnapshotVersion());

		// Token: 0x04001A73 RID: 6771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A74 RID: 6772
		private int _hasBits0;

		// Token: 0x04001A75 RID: 6773
		public const int VersionFieldNumber = 1;

		// Token: 0x04001A76 RID: 6774
		private static readonly ulong VersionDefaultValue = 0UL;

		// Token: 0x04001A77 RID: 6775
		private ulong version_;

		// Token: 0x04001A78 RID: 6776
		public const int SnapshotFieldNumber = 2;

		// Token: 0x04001A79 RID: 6777
		private Snapshot snapshot_;
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x02000204 RID: 516
	public sealed class SnapshotVersions : IMessage<SnapshotVersions>, IMessage, IEquatable<SnapshotVersions>, IDeepCloneable<SnapshotVersions>, IBufferMessage
	{
		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x000E0700 File Offset: 0x000DE900
		[DebuggerNonUserCode]
		public static MessageParser<SnapshotVersions> Parser
		{
			get
			{
				return SnapshotVersions._parser;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x000E0718 File Offset: 0x000DE918
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CSReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x000E073C File Offset: 0x000DE93C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SnapshotVersions.Descriptor;
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x000E0753 File Offset: 0x000DE953
		[DebuggerNonUserCode]
		public SnapshotVersions()
		{
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x000E0768 File Offset: 0x000DE968
		[DebuggerNonUserCode]
		public SnapshotVersions(SnapshotVersions other)
			: this()
		{
			this.versions_ = other.versions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000E0794 File Offset: 0x000DE994
		[DebuggerNonUserCode]
		public SnapshotVersions Clone()
		{
			return new SnapshotVersions(this);
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x000E07AC File Offset: 0x000DE9AC
		[DebuggerNonUserCode]
		public RepeatedField<SnapshotVersion> Versions
		{
			get
			{
				return this.versions_;
			}
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x000E07C4 File Offset: 0x000DE9C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SnapshotVersions);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x000E07E4 File Offset: 0x000DE9E4
		[DebuggerNonUserCode]
		public bool Equals(SnapshotVersions other)
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
					bool flag4 = !this.versions_.Equals(other.versions_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x000E0840 File Offset: 0x000DEA40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.versions_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x000E0880 File Offset: 0x000DEA80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000E0898 File Offset: 0x000DEA98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x000E08A4 File Offset: 0x000DEAA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.versions_.WriteTo(ref output, SnapshotVersions._repeated_versions_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x000E08E0 File Offset: 0x000DEAE0
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.versions_.CalculateSize(SnapshotVersions._repeated_versions_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x000E0928 File Offset: 0x000DEB28
		[DebuggerNonUserCode]
		public void MergeFrom(SnapshotVersions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.versions_.Add(other.versions_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x000E096A File Offset: 0x000DEB6A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x000E0978 File Offset: 0x000DEB78
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
					this.versions_.AddEntriesFrom(ref input, SnapshotVersions._repeated_versions_codec);
				}
			}
		}

		// Token: 0x04001A7A RID: 6778
		private static readonly MessageParser<SnapshotVersions> _parser = new MessageParser<SnapshotVersions>(() => new SnapshotVersions());

		// Token: 0x04001A7B RID: 6779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A7C RID: 6780
		public const int VersionsFieldNumber = 1;

		// Token: 0x04001A7D RID: 6781
		private static readonly FieldCodec<SnapshotVersion> _repeated_versions_codec = FieldCodec.ForMessage<SnapshotVersion>(10U, SnapshotVersion.Parser);

		// Token: 0x04001A7E RID: 6782
		private readonly RepeatedField<SnapshotVersion> versions_ = new RepeatedField<SnapshotVersion>();
	}
}

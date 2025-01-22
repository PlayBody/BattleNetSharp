using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002E0 RID: 736
	public sealed class FileOptions : IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>, IBufferMessage
	{
		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x00128FDC File Offset: 0x001271DC
		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser
		{
			get
			{
				return FileOptions._parser;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x00128FF4 File Offset: 0x001271F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004D99 RID: 19865 RVA: 0x00129018 File Offset: 0x00127218
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FileOptions.Descriptor;
			}
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x0012902F File Offset: 0x0012722F
		[DebuggerNonUserCode]
		public FileOptions()
		{
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00129039 File Offset: 0x00127239
		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
			: this()
		{
			this.telemetryMessage_ = other.telemetryMessage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00129060 File Offset: 0x00127260
		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return new FileOptions(this);
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06004D9D RID: 19869 RVA: 0x00129078 File Offset: 0x00127278
		// (set) Token: 0x06004D9E RID: 19870 RVA: 0x00129099 File Offset: 0x00127299
		[DebuggerNonUserCode]
		public string TelemetryMessage
		{
			get
			{
				return this.telemetryMessage_ ?? FileOptions.TelemetryMessageDefaultValue;
			}
			set
			{
				this.telemetryMessage_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x001290B0 File Offset: 0x001272B0
		[DebuggerNonUserCode]
		public bool HasTelemetryMessage
		{
			get
			{
				return this.telemetryMessage_ != null;
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001290CB File Offset: 0x001272CB
		[DebuggerNonUserCode]
		public void ClearTelemetryMessage()
		{
			this.telemetryMessage_ = null;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x001290D8 File Offset: 0x001272D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FileOptions);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x001290F8 File Offset: 0x001272F8
		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
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
					bool flag4 = this.TelemetryMessage != other.TelemetryMessage;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00129150 File Offset: 0x00127350
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTelemetryMessage = this.HasTelemetryMessage;
			if (hasTelemetryMessage)
			{
				num ^= this.TelemetryMessage.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x0012919C File Offset: 0x0012739C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x001291B4 File Offset: 0x001273B4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x001291C0 File Offset: 0x001273C0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTelemetryMessage = this.HasTelemetryMessage;
			if (hasTelemetryMessage)
			{
				output.WriteRawTag(10);
				output.WriteString(this.TelemetryMessage);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x0012920C File Offset: 0x0012740C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTelemetryMessage = this.HasTelemetryMessage;
			if (hasTelemetryMessage)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TelemetryMessage);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x0012925C File Offset: 0x0012745C
		[DebuggerNonUserCode]
		public void MergeFrom(FileOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTelemetryMessage = other.HasTelemetryMessage;
				if (hasTelemetryMessage)
				{
					this.TelemetryMessage = other.TelemetryMessage;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x001292A5 File Offset: 0x001274A5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x001292B0 File Offset: 0x001274B0
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
					this.TelemetryMessage = input.ReadString();
				}
			}
		}

		// Token: 0x0400229C RID: 8860
		private static readonly MessageParser<FileOptions> _parser = new MessageParser<FileOptions>(() => new FileOptions());

		// Token: 0x0400229D RID: 8861
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400229E RID: 8862
		public const int TelemetryMessageFieldNumber = 1;

		// Token: 0x0400229F RID: 8863
		private static readonly string TelemetryMessageDefaultValue = "";

		// Token: 0x040022A0 RID: 8864
		private string telemetryMessage_;
	}
}

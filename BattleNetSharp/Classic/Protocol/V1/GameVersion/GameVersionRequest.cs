using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.GameVersion
{
	// Token: 0x02000768 RID: 1896
	public sealed class GameVersionRequest : IMessage<GameVersionRequest>, IMessage, IEquatable<GameVersionRequest>, IDeepCloneable<GameVersionRequest>, IBufferMessage
	{
		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x002A682C File Offset: 0x002A4A2C
		[DebuggerNonUserCode]
		public static MessageParser<GameVersionRequest> Parser
		{
			get
			{
				return GameVersionRequest._parser;
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600AE2C RID: 44588 RVA: 0x002A6844 File Offset: 0x002A4A44
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameVersionReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600AE2D RID: 44589 RVA: 0x002A6868 File Offset: 0x002A4A68
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameVersionRequest.Descriptor;
			}
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x002A687F File Offset: 0x002A4A7F
		[DebuggerNonUserCode]
		public GameVersionRequest()
		{
		}

		// Token: 0x0600AE2F RID: 44591 RVA: 0x002A6889 File Offset: 0x002A4A89
		[DebuggerNonUserCode]
		public GameVersionRequest(GameVersionRequest other)
			: this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x002A68B0 File Offset: 0x002A4AB0
		[DebuggerNonUserCode]
		public GameVersionRequest Clone()
		{
			return new GameVersionRequest(this);
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600AE31 RID: 44593 RVA: 0x002A68C8 File Offset: 0x002A4AC8
		// (set) Token: 0x0600AE32 RID: 44594 RVA: 0x002A68E9 File Offset: 0x002A4AE9
		[DebuggerNonUserCode]
		public string Version
		{
			get
			{
				return this.version_ ?? GameVersionRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600AE33 RID: 44595 RVA: 0x002A6900 File Offset: 0x002A4B00
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x002A691B File Offset: 0x002A4B1B
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x002A6928 File Offset: 0x002A4B28
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameVersionRequest);
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x002A6948 File Offset: 0x002A4B48
		[DebuggerNonUserCode]
		public bool Equals(GameVersionRequest other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AE37 RID: 44599 RVA: 0x002A69A0 File Offset: 0x002A4BA0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE38 RID: 44600 RVA: 0x002A69EC File Offset: 0x002A4BEC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x002A6A04 File Offset: 0x002A4C04
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x002A6A10 File Offset: 0x002A4C10
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x002A6A5C File Offset: 0x002A4C5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x002A6AAC File Offset: 0x002A4CAC
		[DebuggerNonUserCode]
		public void MergeFrom(GameVersionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x002A6AF5 File Offset: 0x002A4CF5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x002A6B00 File Offset: 0x002A4D00
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
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x04004E80 RID: 20096
		private static readonly MessageParser<GameVersionRequest> _parser = new MessageParser<GameVersionRequest>(() => new GameVersionRequest());

		// Token: 0x04004E81 RID: 20097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E82 RID: 20098
		public const int VersionFieldNumber = 1;

		// Token: 0x04004E83 RID: 20099
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04004E84 RID: 20100
		private string version_;
	}
}

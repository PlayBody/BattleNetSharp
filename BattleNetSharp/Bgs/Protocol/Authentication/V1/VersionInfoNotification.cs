using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000611 RID: 1553
	public sealed class VersionInfoNotification : IMessage<VersionInfoNotification>, IMessage, IEquatable<VersionInfoNotification>, IDeepCloneable<VersionInfoNotification>, IBufferMessage
	{
		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x0023473C File Offset: 0x0023293C
		[DebuggerNonUserCode]
		public static MessageParser<VersionInfoNotification> Parser
		{
			get
			{
				return VersionInfoNotification._parser;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x00234754 File Offset: 0x00232954
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[12];
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x00234778 File Offset: 0x00232978
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VersionInfoNotification.Descriptor;
			}
		}

		// Token: 0x0600918E RID: 37262 RVA: 0x0023478F File Offset: 0x0023298F
		[DebuggerNonUserCode]
		public VersionInfoNotification()
		{
		}

		// Token: 0x0600918F RID: 37263 RVA: 0x00234799 File Offset: 0x00232999
		[DebuggerNonUserCode]
		public VersionInfoNotification(VersionInfoNotification other)
			: this()
		{
			this.versionInfo_ = ((other.versionInfo_ != null) ? other.versionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009190 RID: 37264 RVA: 0x002347D0 File Offset: 0x002329D0
		[DebuggerNonUserCode]
		public VersionInfoNotification Clone()
		{
			return new VersionInfoNotification(this);
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x002347E8 File Offset: 0x002329E8
		// (set) Token: 0x06009192 RID: 37266 RVA: 0x00234800 File Offset: 0x00232A00
		[DebuggerNonUserCode]
		public VersionInfo VersionInfo
		{
			get
			{
				return this.versionInfo_;
			}
			set
			{
				this.versionInfo_ = value;
			}
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x0023480C File Offset: 0x00232A0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as VersionInfoNotification);
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x0023482C File Offset: 0x00232A2C
		[DebuggerNonUserCode]
		public bool Equals(VersionInfoNotification other)
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
					bool flag4 = !object.Equals(this.VersionInfo, other.VersionInfo);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x00234888 File Offset: 0x00232A88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.versionInfo_ != null;
			if (flag)
			{
				num ^= this.VersionInfo.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x002348D8 File Offset: 0x00232AD8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x002348F0 File Offset: 0x00232AF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x002348FC File Offset: 0x00232AFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.versionInfo_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.VersionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x0023494C File Offset: 0x00232B4C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.versionInfo_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VersionInfo);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x002349A0 File Offset: 0x00232BA0
		[DebuggerNonUserCode]
		public void MergeFrom(VersionInfoNotification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.versionInfo_ != null;
				if (flag2)
				{
					bool flag3 = this.versionInfo_ == null;
					if (flag3)
					{
						this.VersionInfo = new VersionInfo();
					}
					this.VersionInfo.MergeFrom(other.VersionInfo);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x00234A0C File Offset: 0x00232C0C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x00234A18 File Offset: 0x00232C18
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
					bool flag = this.versionInfo_ == null;
					if (flag)
					{
						this.VersionInfo = new VersionInfo();
					}
					input.ReadMessage(this.VersionInfo);
				}
			}
		}

		// Token: 0x040041B9 RID: 16825
		private static readonly MessageParser<VersionInfoNotification> _parser = new MessageParser<VersionInfoNotification>(() => new VersionInfoNotification());

		// Token: 0x040041BA RID: 16826
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041BB RID: 16827
		public const int VersionInfoFieldNumber = 1;

		// Token: 0x040041BC RID: 16828
		private VersionInfo versionInfo_;
	}
}

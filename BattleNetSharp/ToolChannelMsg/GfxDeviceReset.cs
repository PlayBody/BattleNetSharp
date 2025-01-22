using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000CA RID: 202
	public sealed class GfxDeviceReset : IMessage<GfxDeviceReset>, IMessage, IEquatable<GfxDeviceReset>, IDeepCloneable<GfxDeviceReset>, IBufferMessage
	{
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x000468F4 File Offset: 0x00044AF4
		[DebuggerNonUserCode]
		public static MessageParser<GfxDeviceReset> Parser
		{
			get
			{
				return GfxDeviceReset._parser;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0004690C File Offset: 0x00044B0C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[179];
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00046934 File Offset: 0x00044B34
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GfxDeviceReset.Descriptor;
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0004694B File Offset: 0x00044B4B
		[DebuggerNonUserCode]
		public GfxDeviceReset()
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00046955 File Offset: 0x00044B55
		[DebuggerNonUserCode]
		public GfxDeviceReset(GfxDeviceReset other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00046970 File Offset: 0x00044B70
		[DebuggerNonUserCode]
		public GfxDeviceReset Clone()
		{
			return new GfxDeviceReset(this);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00046988 File Offset: 0x00044B88
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GfxDeviceReset);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000469A8 File Offset: 0x00044BA8
		[DebuggerNonUserCode]
		public bool Equals(GfxDeviceReset other)
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

		// Token: 0x06001351 RID: 4945 RVA: 0x000469E8 File Offset: 0x00044BE8
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

		// Token: 0x06001352 RID: 4946 RVA: 0x00046A1C File Offset: 0x00044C1C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00046A34 File Offset: 0x00044C34
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00046A40 File Offset: 0x00044C40
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00046A6C File Offset: 0x00044C6C
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

		// Token: 0x06001356 RID: 4950 RVA: 0x00046AA0 File Offset: 0x00044CA0
		[DebuggerNonUserCode]
		public void MergeFrom(GfxDeviceReset other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00046AD0 File Offset: 0x00044CD0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00046ADC File Offset: 0x00044CDC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007D2 RID: 2002
		private static readonly MessageParser<GfxDeviceReset> _parser = new MessageParser<GfxDeviceReset>(() => new GfxDeviceReset());

		// Token: 0x040007D3 RID: 2003
		private UnknownFieldSet _unknownFields;
	}
}

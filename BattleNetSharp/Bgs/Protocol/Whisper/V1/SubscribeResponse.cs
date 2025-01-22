using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Whisper.V1
{
	// Token: 0x020003A4 RID: 932
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06005E1E RID: 24094 RVA: 0x0016CA70 File Offset: 0x0016AC70
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x0016CA88 File Offset: 0x0016AC88
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WhisperServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06005E20 RID: 24096 RVA: 0x0016CAAC File Offset: 0x0016ACAC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x0016CAC3 File Offset: 0x0016ACC3
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x0016CAD8 File Offset: 0x0016ACD8
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.view_ = other.view_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x0016CB04 File Offset: 0x0016AD04
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06005E24 RID: 24100 RVA: 0x0016CB1C File Offset: 0x0016AD1C
		[DebuggerNonUserCode]
		public RepeatedField<WhisperView> View
		{
			get
			{
				return this.view_;
			}
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x0016CB34 File Offset: 0x0016AD34
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x0016CB54 File Offset: 0x0016AD54
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResponse other)
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
					bool flag4 = !this.view_.Equals(other.view_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0016CBB0 File Offset: 0x0016ADB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.view_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x0016CBF0 File Offset: 0x0016ADF0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x0016CC08 File Offset: 0x0016AE08
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0016CC14 File Offset: 0x0016AE14
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.view_.WriteTo(ref output, SubscribeResponse._repeated_view_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0016CC50 File Offset: 0x0016AE50
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.view_.CalculateSize(SubscribeResponse._repeated_view_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0016CC98 File Offset: 0x0016AE98
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.view_.Add(other.view_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x0016CCDA File Offset: 0x0016AEDA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x0016CCE8 File Offset: 0x0016AEE8
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
					this.view_.AddEntriesFrom(ref input, SubscribeResponse._repeated_view_codec);
				}
			}
		}

		// Token: 0x04002B18 RID: 11032
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04002B19 RID: 11033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B1A RID: 11034
		public const int ViewFieldNumber = 1;

		// Token: 0x04002B1B RID: 11035
		private static readonly FieldCodec<WhisperView> _repeated_view_codec = FieldCodec.ForMessage<WhisperView>(10U, WhisperView.Parser);

		// Token: 0x04002B1C RID: 11036
		private readonly RepeatedField<WhisperView> view_ = new RepeatedField<WhisperView>();
	}
}

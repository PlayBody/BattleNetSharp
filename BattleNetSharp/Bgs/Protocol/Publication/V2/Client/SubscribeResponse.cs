using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000591 RID: 1425
	public sealed class SubscribeResponse : IMessage<SubscribeResponse>, IMessage, IEquatable<SubscribeResponse>, IDeepCloneable<SubscribeResponse>, IBufferMessage
	{
		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06008831 RID: 34865 RVA: 0x00211680 File Offset: 0x0020F880
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResponse> Parser
		{
			get
			{
				return SubscribeResponse._parser;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06008832 RID: 34866 RVA: 0x00211698 File Offset: 0x0020F898
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06008833 RID: 34867 RVA: 0x002116BC File Offset: 0x0020F8BC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResponse.Descriptor;
			}
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x002116D3 File Offset: 0x0020F8D3
		[DebuggerNonUserCode]
		public SubscribeResponse()
		{
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x002116E8 File Offset: 0x0020F8E8
		[DebuggerNonUserCode]
		public SubscribeResponse(SubscribeResponse other)
			: this()
		{
			this.failures_ = other.failures_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008836 RID: 34870 RVA: 0x00211714 File Offset: 0x0020F914
		[DebuggerNonUserCode]
		public SubscribeResponse Clone()
		{
			return new SubscribeResponse(this);
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x06008837 RID: 34871 RVA: 0x0021172C File Offset: 0x0020F92C
		[DebuggerNonUserCode]
		public RepeatedField<SubscribeResult> Failures
		{
			get
			{
				return this.failures_;
			}
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x00211744 File Offset: 0x0020F944
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResponse);
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x00211764 File Offset: 0x0020F964
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
					bool flag4 = !this.failures_.Equals(other.failures_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x002117C0 File Offset: 0x0020F9C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.failures_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x00211800 File Offset: 0x0020FA00
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x00211818 File Offset: 0x0020FA18
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x00211824 File Offset: 0x0020FA24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.failures_.WriteTo(ref output, SubscribeResponse._repeated_failures_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x00211860 File Offset: 0x0020FA60
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.failures_.CalculateSize(SubscribeResponse._repeated_failures_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x002118A8 File Offset: 0x0020FAA8
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.failures_.Add(other.failures_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x002118EA File Offset: 0x0020FAEA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x002118F8 File Offset: 0x0020FAF8
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
					this.failures_.AddEntriesFrom(ref input, SubscribeResponse._repeated_failures_codec);
				}
			}
		}

		// Token: 0x04003DB5 RID: 15797
		private static readonly MessageParser<SubscribeResponse> _parser = new MessageParser<SubscribeResponse>(() => new SubscribeResponse());

		// Token: 0x04003DB6 RID: 15798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB7 RID: 15799
		public const int FailuresFieldNumber = 1;

		// Token: 0x04003DB8 RID: 15800
		private static readonly FieldCodec<SubscribeResult> _repeated_failures_codec = FieldCodec.ForMessage<SubscribeResult>(10U, SubscribeResult.Parser);

		// Token: 0x04003DB9 RID: 15801
		private readonly RepeatedField<SubscribeResult> failures_ = new RepeatedField<SubscribeResult>();
	}
}

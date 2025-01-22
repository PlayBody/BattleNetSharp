using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Resources.V1
{
	// Token: 0x020003DC RID: 988
	public sealed class GetTitleIconsResponse : IMessage<GetTitleIconsResponse>, IMessage, IEquatable<GetTitleIconsResponse>, IDeepCloneable<GetTitleIconsResponse>, IBufferMessage
	{
		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x060062B6 RID: 25270 RVA: 0x0017E02C File Offset: 0x0017C22C
		[DebuggerNonUserCode]
		public static MessageParser<GetTitleIconsResponse> Parser
		{
			get
			{
				return GetTitleIconsResponse._parser;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x060062B7 RID: 25271 RVA: 0x0017E044 File Offset: 0x0017C244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x060062B8 RID: 25272 RVA: 0x0017E068 File Offset: 0x0017C268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTitleIconsResponse.Descriptor;
			}
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x0017E07F File Offset: 0x0017C27F
		[DebuggerNonUserCode]
		public GetTitleIconsResponse()
		{
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x0017E094 File Offset: 0x0017C294
		[DebuggerNonUserCode]
		public GetTitleIconsResponse(GetTitleIconsResponse other)
			: this()
		{
			this.titleIconContentHandles_ = other.titleIconContentHandles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x0017E0C0 File Offset: 0x0017C2C0
		[DebuggerNonUserCode]
		public GetTitleIconsResponse Clone()
		{
			return new GetTitleIconsResponse(this);
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x0017E0D8 File Offset: 0x0017C2D8
		[DebuggerNonUserCode]
		public RepeatedField<TitleIconContentHandle> TitleIconContentHandles
		{
			get
			{
				return this.titleIconContentHandles_;
			}
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x0017E0F0 File Offset: 0x0017C2F0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTitleIconsResponse);
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x0017E110 File Offset: 0x0017C310
		[DebuggerNonUserCode]
		public bool Equals(GetTitleIconsResponse other)
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
					bool flag4 = !this.titleIconContentHandles_.Equals(other.titleIconContentHandles_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x0017E16C File Offset: 0x0017C36C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.titleIconContentHandles_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x0017E1AC File Offset: 0x0017C3AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x0017E1C4 File Offset: 0x0017C3C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x0017E1D0 File Offset: 0x0017C3D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.titleIconContentHandles_.WriteTo(ref output, GetTitleIconsResponse._repeated_titleIconContentHandles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x0017E20C File Offset: 0x0017C40C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.titleIconContentHandles_.CalculateSize(GetTitleIconsResponse._repeated_titleIconContentHandles_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x0017E254 File Offset: 0x0017C454
		[DebuggerNonUserCode]
		public void MergeFrom(GetTitleIconsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.titleIconContentHandles_.Add(other.titleIconContentHandles_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x0017E296 File Offset: 0x0017C496
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x0017E2A4 File Offset: 0x0017C4A4
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
					this.titleIconContentHandles_.AddEntriesFrom(ref input, GetTitleIconsResponse._repeated_titleIconContentHandles_codec);
				}
			}
		}

		// Token: 0x04002D19 RID: 11545
		private static readonly MessageParser<GetTitleIconsResponse> _parser = new MessageParser<GetTitleIconsResponse>(() => new GetTitleIconsResponse());

		// Token: 0x04002D1A RID: 11546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D1B RID: 11547
		public const int TitleIconContentHandlesFieldNumber = 1;

		// Token: 0x04002D1C RID: 11548
		private static readonly FieldCodec<TitleIconContentHandle> _repeated_titleIconContentHandles_codec = FieldCodec.ForMessage<TitleIconContentHandle>(10U, TitleIconContentHandle.Parser);

		// Token: 0x04002D1D RID: 11549
		private readonly RepeatedField<TitleIconContentHandle> titleIconContentHandles_ = new RepeatedField<TitleIconContentHandle>();
	}
}

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005EA RID: 1514
	public sealed class GetAchievementsFileResponse : IMessage<GetAchievementsFileResponse>, IMessage, IEquatable<GetAchievementsFileResponse>, IDeepCloneable<GetAchievementsFileResponse>, IBufferMessage
	{
		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x00228B3C File Offset: 0x00226D3C
		[DebuggerNonUserCode]
		public static MessageParser<GetAchievementsFileResponse> Parser
		{
			get
			{
				return GetAchievementsFileResponse._parser;
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x06008E5A RID: 36442 RVA: 0x00228B54 File Offset: 0x00226D54
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x00228B78 File Offset: 0x00226D78
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAchievementsFileResponse.Descriptor;
			}
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00228B8F File Offset: 0x00226D8F
		[DebuggerNonUserCode]
		public GetAchievementsFileResponse()
		{
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x00228B99 File Offset: 0x00226D99
		[DebuggerNonUserCode]
		public GetAchievementsFileResponse(GetAchievementsFileResponse other)
			: this()
		{
			this.contentHandle_ = ((other.contentHandle_ != null) ? other.contentHandle_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x00228BD0 File Offset: 0x00226DD0
		[DebuggerNonUserCode]
		public GetAchievementsFileResponse Clone()
		{
			return new GetAchievementsFileResponse(this);
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x00228BE8 File Offset: 0x00226DE8
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x00228C00 File Offset: 0x00226E00
		[DebuggerNonUserCode]
		public ContentHandle ContentHandle
		{
			get
			{
				return this.contentHandle_;
			}
			set
			{
				this.contentHandle_ = value;
			}
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x00228C0C File Offset: 0x00226E0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAchievementsFileResponse);
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x00228C2C File Offset: 0x00226E2C
		[DebuggerNonUserCode]
		public bool Equals(GetAchievementsFileResponse other)
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
					bool flag4 = !object.Equals(this.ContentHandle, other.ContentHandle);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x00228C88 File Offset: 0x00226E88
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				num ^= this.ContentHandle.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x00228CD8 File Offset: 0x00226ED8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x00228CF0 File Offset: 0x00226EF0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x00228CFC File Offset: 0x00226EFC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ContentHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x00228D4C File Offset: 0x00226F4C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.contentHandle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ContentHandle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x00228DA0 File Offset: 0x00226FA0
		[DebuggerNonUserCode]
		public void MergeFrom(GetAchievementsFileResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.contentHandle_ != null;
				if (flag2)
				{
					bool flag3 = this.contentHandle_ == null;
					if (flag3)
					{
						this.ContentHandle = new ContentHandle();
					}
					this.ContentHandle.MergeFrom(other.ContentHandle);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x00228E0C File Offset: 0x0022700C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x00228E18 File Offset: 0x00227018
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
					bool flag = this.contentHandle_ == null;
					if (flag)
					{
						this.ContentHandle = new ContentHandle();
					}
					input.ReadMessage(this.ContentHandle);
				}
			}
		}

		// Token: 0x04004048 RID: 16456
		private static readonly MessageParser<GetAchievementsFileResponse> _parser = new MessageParser<GetAchievementsFileResponse>(() => new GetAchievementsFileResponse());

		// Token: 0x04004049 RID: 16457
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400404A RID: 16458
		public const int ContentHandleFieldNumber = 1;

		// Token: 0x0400404B RID: 16459
		private ContentHandle contentHandle_;
	}
}

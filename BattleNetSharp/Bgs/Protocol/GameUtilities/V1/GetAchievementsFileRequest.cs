using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E9 RID: 1513
	public sealed class GetAchievementsFileRequest : IMessage<GetAchievementsFileRequest>, IMessage, IEquatable<GetAchievementsFileRequest>, IDeepCloneable<GetAchievementsFileRequest>, IBufferMessage
	{
		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x002287D4 File Offset: 0x002269D4
		[DebuggerNonUserCode]
		public static MessageParser<GetAchievementsFileRequest> Parser
		{
			get
			{
				return GetAchievementsFileRequest._parser;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x002287EC File Offset: 0x002269EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00228810 File Offset: 0x00226A10
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAchievementsFileRequest.Descriptor;
			}
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x00228827 File Offset: 0x00226A27
		[DebuggerNonUserCode]
		public GetAchievementsFileRequest()
		{
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x00228831 File Offset: 0x00226A31
		[DebuggerNonUserCode]
		public GetAchievementsFileRequest(GetAchievementsFileRequest other)
			: this()
		{
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x00228868 File Offset: 0x00226A68
		[DebuggerNonUserCode]
		public GetAchievementsFileRequest Clone()
		{
			return new GetAchievementsFileRequest(this);
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x06008E4C RID: 36428 RVA: 0x00228880 File Offset: 0x00226A80
		// (set) Token: 0x06008E4D RID: 36429 RVA: 0x00228898 File Offset: 0x00226A98
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x002288A4 File Offset: 0x00226AA4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAchievementsFileRequest);
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x002288C4 File Offset: 0x00226AC4
		[DebuggerNonUserCode]
		public bool Equals(GetAchievementsFileRequest other)
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
					bool flag4 = !object.Equals(this.Host, other.Host);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x00228920 File Offset: 0x00226B20
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x00228970 File Offset: 0x00226B70
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00228988 File Offset: 0x00226B88
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00228994 File Offset: 0x00226B94
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x002289E4 File Offset: 0x00226BE4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x00228A38 File Offset: 0x00226C38
		[DebuggerNonUserCode]
		public void MergeFrom(GetAchievementsFileRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x00228AA4 File Offset: 0x00226CA4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x00228AB0 File Offset: 0x00226CB0
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
					bool flag = this.host_ == null;
					if (flag)
					{
						this.Host = new ProcessId();
					}
					input.ReadMessage(this.Host);
				}
			}
		}

		// Token: 0x04004044 RID: 16452
		private static readonly MessageParser<GetAchievementsFileRequest> _parser = new MessageParser<GetAchievementsFileRequest>(() => new GetAchievementsFileRequest());

		// Token: 0x04004045 RID: 16453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004046 RID: 16454
		public const int HostFieldNumber = 1;

		// Token: 0x04004047 RID: 16455
		private ProcessId host_;
	}
}

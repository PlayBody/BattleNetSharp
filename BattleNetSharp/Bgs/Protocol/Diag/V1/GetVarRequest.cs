using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Diag.V1
{
	// Token: 0x02000422 RID: 1058
	public sealed class GetVarRequest : IMessage<GetVarRequest>, IMessage, IEquatable<GetVarRequest>, IDeepCloneable<GetVarRequest>, IBufferMessage
	{
		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x00194264 File Offset: 0x00192464
		[DebuggerNonUserCode]
		public static MessageParser<GetVarRequest> Parser
		{
			get
			{
				return GetVarRequest._parser;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06006857 RID: 26711 RVA: 0x0019427C File Offset: 0x0019247C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DiagServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x001942A0 File Offset: 0x001924A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetVarRequest.Descriptor;
			}
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x001942B7 File Offset: 0x001924B7
		[DebuggerNonUserCode]
		public GetVarRequest()
		{
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x001942C1 File Offset: 0x001924C1
		[DebuggerNonUserCode]
		public GetVarRequest(GetVarRequest other)
			: this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x001942E8 File Offset: 0x001924E8
		[DebuggerNonUserCode]
		public GetVarRequest Clone()
		{
			return new GetVarRequest(this);
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x00194300 File Offset: 0x00192500
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x00194321 File Offset: 0x00192521
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? GetVarRequest.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x00194338 File Offset: 0x00192538
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00194353 File Offset: 0x00192553
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00194360 File Offset: 0x00192560
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetVarRequest);
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00194380 File Offset: 0x00192580
		[DebuggerNonUserCode]
		public bool Equals(GetVarRequest other)
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
					bool flag4 = this.Name != other.Name;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x001943D8 File Offset: 0x001925D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00194424 File Offset: 0x00192624
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x0019443C File Offset: 0x0019263C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00194448 File Offset: 0x00192648
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x00194494 File Offset: 0x00192694
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x001944E4 File Offset: 0x001926E4
		[DebuggerNonUserCode]
		public void MergeFrom(GetVarRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x0019452D File Offset: 0x0019272D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00194538 File Offset: 0x00192738
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
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04002F88 RID: 12168
		private static readonly MessageParser<GetVarRequest> _parser = new MessageParser<GetVarRequest>(() => new GetVarRequest());

		// Token: 0x04002F89 RID: 12169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8A RID: 12170
		public const int NameFieldNumber = 1;

		// Token: 0x04002F8B RID: 12171
		private static readonly string NameDefaultValue = "";

		// Token: 0x04002F8C RID: 12172
		private string name_;
	}
}

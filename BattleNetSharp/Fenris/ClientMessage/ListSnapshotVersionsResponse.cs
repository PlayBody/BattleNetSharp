using System;
using System.Diagnostics;
using Fenris.CS;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023B RID: 571
	public sealed class ListSnapshotVersionsResponse : IMessage<ListSnapshotVersionsResponse>, IMessage, IEquatable<ListSnapshotVersionsResponse>, IDeepCloneable<ListSnapshotVersionsResponse>, IBufferMessage
	{
		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x000F3810 File Offset: 0x000F1A10
		[DebuggerNonUserCode]
		public static MessageParser<ListSnapshotVersionsResponse> Parser
		{
			get
			{
				return ListSnapshotVersionsResponse._parser;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06003DB5 RID: 15797 RVA: 0x000F3828 File Offset: 0x000F1A28
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[43];
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x000F384C File Offset: 0x000F1A4C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListSnapshotVersionsResponse.Descriptor;
			}
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x000F3863 File Offset: 0x000F1A63
		[DebuggerNonUserCode]
		public ListSnapshotVersionsResponse()
		{
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x000F386D File Offset: 0x000F1A6D
		[DebuggerNonUserCode]
		public ListSnapshotVersionsResponse(ListSnapshotVersionsResponse other)
			: this()
		{
			this.versions_ = ((other.versions_ != null) ? other.versions_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x000F38A4 File Offset: 0x000F1AA4
		[DebuggerNonUserCode]
		public ListSnapshotVersionsResponse Clone()
		{
			return new ListSnapshotVersionsResponse(this);
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06003DBA RID: 15802 RVA: 0x000F38BC File Offset: 0x000F1ABC
		// (set) Token: 0x06003DBB RID: 15803 RVA: 0x000F38D4 File Offset: 0x000F1AD4
		[DebuggerNonUserCode]
		public SnapshotVersions Versions
		{
			get
			{
				return this.versions_;
			}
			set
			{
				this.versions_ = value;
			}
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x000F38E0 File Offset: 0x000F1AE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListSnapshotVersionsResponse);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x000F3900 File Offset: 0x000F1B00
		[DebuggerNonUserCode]
		public bool Equals(ListSnapshotVersionsResponse other)
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
					bool flag4 = !object.Equals(this.Versions, other.Versions);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x000F395C File Offset: 0x000F1B5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.versions_ != null;
			if (flag)
			{
				num ^= this.Versions.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x000F39AC File Offset: 0x000F1BAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000F39C4 File Offset: 0x000F1BC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x000F39D0 File Offset: 0x000F1BD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.versions_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Versions);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000F3A20 File Offset: 0x000F1C20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.versions_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Versions);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000F3A74 File Offset: 0x000F1C74
		[DebuggerNonUserCode]
		public void MergeFrom(ListSnapshotVersionsResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.versions_ != null;
				if (flag2)
				{
					bool flag3 = this.versions_ == null;
					if (flag3)
					{
						this.Versions = new SnapshotVersions();
					}
					this.Versions.MergeFrom(other.Versions);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000F3AE0 File Offset: 0x000F1CE0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000F3AEC File Offset: 0x000F1CEC
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
					bool flag = this.versions_ == null;
					if (flag)
					{
						this.Versions = new SnapshotVersions();
					}
					input.ReadMessage(this.Versions);
				}
			}
		}

		// Token: 0x04001C55 RID: 7253
		private static readonly MessageParser<ListSnapshotVersionsResponse> _parser = new MessageParser<ListSnapshotVersionsResponse>(() => new ListSnapshotVersionsResponse());

		// Token: 0x04001C56 RID: 7254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C57 RID: 7255
		public const int VersionsFieldNumber = 1;

		// Token: 0x04001C58 RID: 7256
		private SnapshotVersions versions_;
	}
}

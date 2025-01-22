using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000069 RID: 105
	public sealed class BuildPlatformDependenciesResponse : IMessage<BuildPlatformDependenciesResponse>, IMessage, IEquatable<BuildPlatformDependenciesResponse>, IDeepCloneable<BuildPlatformDependenciesResponse>, IBufferMessage
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00024940 File Offset: 0x00022B40
		[DebuggerNonUserCode]
		public static MessageParser<BuildPlatformDependenciesResponse> Parser
		{
			get
			{
				return BuildPlatformDependenciesResponse._parser;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00024958 File Offset: 0x00022B58
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[82];
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002497C File Offset: 0x00022B7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildPlatformDependenciesResponse.Descriptor;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00024993 File Offset: 0x00022B93
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesResponse()
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0002499D File Offset: 0x00022B9D
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesResponse(BuildPlatformDependenciesResponse other)
			: this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000249B8 File Offset: 0x00022BB8
		[DebuggerNonUserCode]
		public BuildPlatformDependenciesResponse Clone()
		{
			return new BuildPlatformDependenciesResponse(this);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000249D0 File Offset: 0x00022BD0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildPlatformDependenciesResponse);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000249F0 File Offset: 0x00022BF0
		[DebuggerNonUserCode]
		public bool Equals(BuildPlatformDependenciesResponse other)
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

		// Token: 0x06000913 RID: 2323 RVA: 0x00024A30 File Offset: 0x00022C30
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

		// Token: 0x06000914 RID: 2324 RVA: 0x00024A64 File Offset: 0x00022C64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00024A7C File Offset: 0x00022C7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00024A88 File Offset: 0x00022C88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00024AB4 File Offset: 0x00022CB4
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

		// Token: 0x06000918 RID: 2328 RVA: 0x00024AE8 File Offset: 0x00022CE8
		[DebuggerNonUserCode]
		public void MergeFrom(BuildPlatformDependenciesResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00024B18 File Offset: 0x00022D18
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00024B24 File Offset: 0x00022D24
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() > 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040003A5 RID: 933
		private static readonly MessageParser<BuildPlatformDependenciesResponse> _parser = new MessageParser<BuildPlatformDependenciesResponse>(() => new BuildPlatformDependenciesResponse());

		// Token: 0x040003A6 RID: 934
		private UnknownFieldSet _unknownFields;
	}
}

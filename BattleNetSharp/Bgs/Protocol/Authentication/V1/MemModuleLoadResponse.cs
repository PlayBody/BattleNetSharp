using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000613 RID: 1555
	public sealed class MemModuleLoadResponse : IMessage<MemModuleLoadResponse>, IMessage, IEquatable<MemModuleLoadResponse>, IDeepCloneable<MemModuleLoadResponse>, IBufferMessage
	{
		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x060091B9 RID: 37305 RVA: 0x00235058 File Offset: 0x00233258
		[DebuggerNonUserCode]
		public static MessageParser<MemModuleLoadResponse> Parser
		{
			get
			{
				return MemModuleLoadResponse._parser;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x00235070 File Offset: 0x00233270
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x060091BB RID: 37307 RVA: 0x00235094 File Offset: 0x00233294
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemModuleLoadResponse.Descriptor;
			}
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x002350AB File Offset: 0x002332AB
		[DebuggerNonUserCode]
		public MemModuleLoadResponse()
		{
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x002350B5 File Offset: 0x002332B5
		[DebuggerNonUserCode]
		public MemModuleLoadResponse(MemModuleLoadResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x002350DC File Offset: 0x002332DC
		[DebuggerNonUserCode]
		public MemModuleLoadResponse Clone()
		{
			return new MemModuleLoadResponse(this);
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x002350F4 File Offset: 0x002332F4
		// (set) Token: 0x060091C0 RID: 37312 RVA: 0x00235115 File Offset: 0x00233315
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? MemModuleLoadResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x0023512C File Offset: 0x0023332C
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x0023514A File Offset: 0x0023334A
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x00235154 File Offset: 0x00233354
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemModuleLoadResponse);
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x00235174 File Offset: 0x00233374
		[DebuggerNonUserCode]
		public bool Equals(MemModuleLoadResponse other)
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
					bool flag4 = this.Data != other.Data;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x002351CC File Offset: 0x002333CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x00235218 File Offset: 0x00233418
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x00235230 File Offset: 0x00233430
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x0023523C File Offset: 0x0023343C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x00235288 File Offset: 0x00233488
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x002352D8 File Offset: 0x002334D8
		[DebuggerNonUserCode]
		public void MergeFrom(MemModuleLoadResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00235321 File Offset: 0x00233521
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x0023532C File Offset: 0x0023352C
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
					this.Data = input.ReadBytes();
				}
			}
		}

		// Token: 0x040041C7 RID: 16839
		private static readonly MessageParser<MemModuleLoadResponse> _parser = new MessageParser<MemModuleLoadResponse>(() => new MemModuleLoadResponse());

		// Token: 0x040041C8 RID: 16840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C9 RID: 16841
		public const int DataFieldNumber = 1;

		// Token: 0x040041CA RID: 16842
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x040041CB RID: 16843
		private ByteString data_;
	}
}

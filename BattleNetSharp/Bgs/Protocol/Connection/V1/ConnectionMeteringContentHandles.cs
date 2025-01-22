using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042D RID: 1069
	public sealed class ConnectionMeteringContentHandles : IMessage<ConnectionMeteringContentHandles>, IMessage, IEquatable<ConnectionMeteringContentHandles>, IDeepCloneable<ConnectionMeteringContentHandles>, IBufferMessage
	{
		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x00196FA0 File Offset: 0x001951A0
		[DebuggerNonUserCode]
		public static MessageParser<ConnectionMeteringContentHandles> Parser
		{
			get
			{
				return ConnectionMeteringContentHandles._parser;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x00196FB8 File Offset: 0x001951B8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x00196FDC File Offset: 0x001951DC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectionMeteringContentHandles.Descriptor;
			}
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x00196FF3 File Offset: 0x001951F3
		[DebuggerNonUserCode]
		public ConnectionMeteringContentHandles()
		{
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x00197008 File Offset: 0x00195208
		[DebuggerNonUserCode]
		public ConnectionMeteringContentHandles(ConnectionMeteringContentHandles other)
			: this()
		{
			this.contentHandle_ = other.contentHandle_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x00197034 File Offset: 0x00195234
		[DebuggerNonUserCode]
		public ConnectionMeteringContentHandles Clone()
		{
			return new ConnectionMeteringContentHandles(this);
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600691E RID: 26910 RVA: 0x0019704C File Offset: 0x0019524C
		[DebuggerNonUserCode]
		public RepeatedField<ContentHandle> ContentHandle
		{
			get
			{
				return this.contentHandle_;
			}
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x00197064 File Offset: 0x00195264
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectionMeteringContentHandles);
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x00197084 File Offset: 0x00195284
		[DebuggerNonUserCode]
		public bool Equals(ConnectionMeteringContentHandles other)
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
					bool flag4 = !this.contentHandle_.Equals(other.contentHandle_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x001970E0 File Offset: 0x001952E0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.contentHandle_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00197120 File Offset: 0x00195320
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x00197138 File Offset: 0x00195338
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x00197144 File Offset: 0x00195344
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.contentHandle_.WriteTo(ref output, ConnectionMeteringContentHandles._repeated_contentHandle_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x00197180 File Offset: 0x00195380
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.contentHandle_.CalculateSize(ConnectionMeteringContentHandles._repeated_contentHandle_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x001971C8 File Offset: 0x001953C8
		[DebuggerNonUserCode]
		public void MergeFrom(ConnectionMeteringContentHandles other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.contentHandle_.Add(other.contentHandle_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0019720A File Offset: 0x0019540A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x00197218 File Offset: 0x00195418
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
					this.contentHandle_.AddEntriesFrom(ref input, ConnectionMeteringContentHandles._repeated_contentHandle_codec);
				}
			}
		}

		// Token: 0x04002FD8 RID: 12248
		private static readonly MessageParser<ConnectionMeteringContentHandles> _parser = new MessageParser<ConnectionMeteringContentHandles>(() => new ConnectionMeteringContentHandles());

		// Token: 0x04002FD9 RID: 12249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FDA RID: 12250
		public const int ContentHandleFieldNumber = 1;

		// Token: 0x04002FDB RID: 12251
		private static readonly FieldCodec<ContentHandle> _repeated_contentHandle_codec = FieldCodec.ForMessage<ContentHandle>(10U, Bgs.Protocol.ContentHandle.Parser);

		// Token: 0x04002FDC RID: 12252
		private readonly RepeatedField<ContentHandle> contentHandle_ = new RepeatedField<ContentHandle>();
	}
}

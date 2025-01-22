using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000592 RID: 1426
	public sealed class UnsubscribeRequest : IMessage<UnsubscribeRequest>, IMessage, IEquatable<UnsubscribeRequest>, IDeepCloneable<UnsubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06008843 RID: 34883 RVA: 0x0021197C File Offset: 0x0020FB7C
		[DebuggerNonUserCode]
		public static MessageParser<UnsubscribeRequest> Parser
		{
			get
			{
				return UnsubscribeRequest._parser;
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x00211994 File Offset: 0x0020FB94
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x002119B8 File Offset: 0x0020FBB8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnsubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x002119CF File Offset: 0x0020FBCF
		[DebuggerNonUserCode]
		public UnsubscribeRequest()
		{
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x002119E4 File Offset: 0x0020FBE4
		[DebuggerNonUserCode]
		public UnsubscribeRequest(UnsubscribeRequest other)
			: this()
		{
			this.target_ = other.target_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x00211A10 File Offset: 0x0020FC10
		[DebuggerNonUserCode]
		public UnsubscribeRequest Clone()
		{
			return new UnsubscribeRequest(this);
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x06008849 RID: 34889 RVA: 0x00211A28 File Offset: 0x0020FC28
		[DebuggerNonUserCode]
		public RepeatedField<Target> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x00211A40 File Offset: 0x0020FC40
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnsubscribeRequest);
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x00211A60 File Offset: 0x0020FC60
		[DebuggerNonUserCode]
		public bool Equals(UnsubscribeRequest other)
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
					bool flag4 = !this.target_.Equals(other.target_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x00211ABC File Offset: 0x0020FCBC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.target_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x00211AFC File Offset: 0x0020FCFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x00211B14 File Offset: 0x0020FD14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x00211B20 File Offset: 0x0020FD20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.target_.WriteTo(ref output, UnsubscribeRequest._repeated_target_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00211B5C File Offset: 0x0020FD5C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.target_.CalculateSize(UnsubscribeRequest._repeated_target_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x00211BA4 File Offset: 0x0020FDA4
		[DebuggerNonUserCode]
		public void MergeFrom(UnsubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.target_.Add(other.target_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x00211BE6 File Offset: 0x0020FDE6
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x00211BF4 File Offset: 0x0020FDF4
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
					this.target_.AddEntriesFrom(ref input, UnsubscribeRequest._repeated_target_codec);
				}
			}
		}

		// Token: 0x04003DBA RID: 15802
		private static readonly MessageParser<UnsubscribeRequest> _parser = new MessageParser<UnsubscribeRequest>(() => new UnsubscribeRequest());

		// Token: 0x04003DBB RID: 15803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DBC RID: 15804
		public const int TargetFieldNumber = 1;

		// Token: 0x04003DBD RID: 15805
		private static readonly FieldCodec<Target> _repeated_target_codec = FieldCodec.ForMessage<Target>(10U, Bgs.Protocol.Publication.V2.Client.Target.Parser);

		// Token: 0x04003DBE RID: 15806
		private readonly RepeatedField<Target> target_ = new RepeatedField<Target>();
	}
}

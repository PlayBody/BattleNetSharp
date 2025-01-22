using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GenericResource
{
	// Token: 0x02000785 RID: 1925
	public sealed class AvailableResources : IMessage<AvailableResources>, IMessage, IEquatable<AvailableResources>, IDeepCloneable<AvailableResources>, IBufferMessage
	{
		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600B0A2 RID: 45218 RVA: 0x002AFD08 File Offset: 0x002ADF08
		[DebuggerNonUserCode]
		public static MessageParser<AvailableResources> Parser
		{
			get
			{
				return AvailableResources._parser;
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x002AFD20 File Offset: 0x002ADF20
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GenericResourceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x002AFD44 File Offset: 0x002ADF44
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvailableResources.Descriptor;
			}
		}

		// Token: 0x0600B0A5 RID: 45221 RVA: 0x002AFD5B File Offset: 0x002ADF5B
		[DebuggerNonUserCode]
		public AvailableResources()
		{
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x002AFD70 File Offset: 0x002ADF70
		[DebuggerNonUserCode]
		public AvailableResources(AvailableResources other)
			: this()
		{
			this.resources_ = other.resources_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x002AFD9C File Offset: 0x002ADF9C
		[DebuggerNonUserCode]
		public AvailableResources Clone()
		{
			return new AvailableResources(this);
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x002AFDB4 File Offset: 0x002ADFB4
		[DebuggerNonUserCode]
		public RepeatedField<Resource> Resources
		{
			get
			{
				return this.resources_;
			}
		}

		// Token: 0x0600B0A9 RID: 45225 RVA: 0x002AFDCC File Offset: 0x002ADFCC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvailableResources);
		}

		// Token: 0x0600B0AA RID: 45226 RVA: 0x002AFDEC File Offset: 0x002ADFEC
		[DebuggerNonUserCode]
		public bool Equals(AvailableResources other)
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
					bool flag4 = !this.resources_.Equals(other.resources_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B0AB RID: 45227 RVA: 0x002AFE48 File Offset: 0x002AE048
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.resources_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x002AFE88 File Offset: 0x002AE088
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x002AFEA0 File Offset: 0x002AE0A0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x002AFEAC File Offset: 0x002AE0AC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.resources_.WriteTo(ref output, AvailableResources._repeated_resources_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0AF RID: 45231 RVA: 0x002AFEE8 File Offset: 0x002AE0E8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.resources_.CalculateSize(AvailableResources._repeated_resources_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x002AFF30 File Offset: 0x002AE130
		[DebuggerNonUserCode]
		public void MergeFrom(AvailableResources other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.resources_.Add(other.resources_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x002AFF72 File Offset: 0x002AE172
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x002AFF80 File Offset: 0x002AE180
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
					this.resources_.AddEntriesFrom(ref input, AvailableResources._repeated_resources_codec);
				}
			}
		}

		// Token: 0x04004FAB RID: 20395
		private static readonly MessageParser<AvailableResources> _parser = new MessageParser<AvailableResources>(() => new AvailableResources());

		// Token: 0x04004FAC RID: 20396
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FAD RID: 20397
		public const int ResourcesFieldNumber = 1;

		// Token: 0x04004FAE RID: 20398
		private static readonly FieldCodec<Resource> _repeated_resources_codec = FieldCodec.ForMessage<Resource>(10U, Resource.Parser);

		// Token: 0x04004FAF RID: 20399
		private readonly RepeatedField<Resource> resources_ = new RepeatedField<Resource>();
	}
}

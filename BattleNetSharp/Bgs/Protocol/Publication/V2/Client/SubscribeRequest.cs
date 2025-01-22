using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000590 RID: 1424
	public sealed class SubscribeRequest : IMessage<SubscribeRequest>, IMessage, IEquatable<SubscribeRequest>, IDeepCloneable<SubscribeRequest>, IBufferMessage
	{
		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600881D RID: 34845 RVA: 0x0021124C File Offset: 0x0020F44C
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeRequest> Parser
		{
			get
			{
				return SubscribeRequest._parser;
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x00211264 File Offset: 0x0020F464
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x00211288 File Offset: 0x0020F488
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeRequest.Descriptor;
			}
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x0021129F File Offset: 0x0020F49F
		[DebuggerNonUserCode]
		public SubscribeRequest()
		{
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x002112B4 File Offset: 0x0020F4B4
		[DebuggerNonUserCode]
		public SubscribeRequest(SubscribeRequest other)
			: this()
		{
			this.target_ = other.target_.Clone();
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x00211308 File Offset: 0x0020F508
		[DebuggerNonUserCode]
		public SubscribeRequest Clone()
		{
			return new SubscribeRequest(this);
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008823 RID: 34851 RVA: 0x00211320 File Offset: 0x0020F520
		[DebuggerNonUserCode]
		public RepeatedField<Target> Target
		{
			get
			{
				return this.target_;
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x00211338 File Offset: 0x0020F538
		// (set) Token: 0x06008825 RID: 34853 RVA: 0x00211350 File Offset: 0x0020F550
		[DebuggerNonUserCode]
		public SubscribeOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x0021135C File Offset: 0x0020F55C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeRequest);
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x0021137C File Offset: 0x0020F57C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Options, other.Options);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x002113F4 File Offset: 0x0020F5F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.target_.GetHashCode();
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x00211450 File Offset: 0x0020F650
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x00211468 File Offset: 0x0020F668
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x00211474 File Offset: 0x0020F674
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.target_.WriteTo(ref output, SubscribeRequest._repeated_target_codec);
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x002114D8 File Offset: 0x0020F6D8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.target_.CalculateSize(SubscribeRequest._repeated_target_codec);
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x0021153C File Offset: 0x0020F73C
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.target_.Add(other.target_);
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new SubscribeOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x002115BA File Offset: 0x0020F7BA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x002115C8 File Offset: 0x0020F7C8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.options_ == null;
						if (flag)
						{
							this.Options = new SubscribeOptions();
						}
						input.ReadMessage(this.Options);
					}
				}
				else
				{
					this.target_.AddEntriesFrom(ref input, SubscribeRequest._repeated_target_codec);
				}
			}
		}

		// Token: 0x04003DAE RID: 15790
		private static readonly MessageParser<SubscribeRequest> _parser = new MessageParser<SubscribeRequest>(() => new SubscribeRequest());

		// Token: 0x04003DAF RID: 15791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB0 RID: 15792
		public const int TargetFieldNumber = 1;

		// Token: 0x04003DB1 RID: 15793
		private static readonly FieldCodec<Target> _repeated_target_codec = FieldCodec.ForMessage<Target>(10U, Bgs.Protocol.Publication.V2.Client.Target.Parser);

		// Token: 0x04003DB2 RID: 15794
		private readonly RepeatedField<Target> target_ = new RepeatedField<Target>();

		// Token: 0x04003DB3 RID: 15795
		public const int OptionsFieldNumber = 2;

		// Token: 0x04003DB4 RID: 15796
		private SubscribeOptions options_;
	}
}

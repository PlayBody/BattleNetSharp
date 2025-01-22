using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000E9 RID: 233
	public sealed class PlantMarkersResult : IMessage<PlantMarkersResult>, IMessage, IEquatable<PlantMarkersResult>, IDeepCloneable<PlantMarkersResult>, IBufferMessage
	{
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00051F6C File Offset: 0x0005016C
		[DebuggerNonUserCode]
		public static MessageParser<PlantMarkersResult> Parser
		{
			get
			{
				return PlantMarkersResult._parser;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00051F84 File Offset: 0x00050184
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[210];
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00051FAC File Offset: 0x000501AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlantMarkersResult.Descriptor;
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00051FC3 File Offset: 0x000501C3
		[DebuggerNonUserCode]
		public PlantMarkersResult()
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00051FD8 File Offset: 0x000501D8
		[DebuggerNonUserCode]
		public PlantMarkersResult(PlantMarkersResult other)
			: this()
		{
			this.results_ = other.results_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00052004 File Offset: 0x00050204
		[DebuggerNonUserCode]
		public PlantMarkersResult Clone()
		{
			return new PlantMarkersResult(this);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0005201C File Offset: 0x0005021C
		[DebuggerNonUserCode]
		public RepeatedField<PlantMarkersSceneResult> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00052034 File Offset: 0x00050234
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlantMarkersResult);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00052054 File Offset: 0x00050254
		[DebuggerNonUserCode]
		public bool Equals(PlantMarkersResult other)
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
					bool flag4 = !this.results_.Equals(other.results_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000520B0 File Offset: 0x000502B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.results_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000520F0 File Offset: 0x000502F0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00052108 File Offset: 0x00050308
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00052114 File Offset: 0x00050314
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.results_.WriteTo(ref output, PlantMarkersResult._repeated_results_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00052150 File Offset: 0x00050350
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.results_.CalculateSize(PlantMarkersResult._repeated_results_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00052198 File Offset: 0x00050398
		[DebuggerNonUserCode]
		public void MergeFrom(PlantMarkersResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.results_.Add(other.results_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000521DA File Offset: 0x000503DA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000521E8 File Offset: 0x000503E8
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
					this.results_.AddEntriesFrom(ref input, PlantMarkersResult._repeated_results_codec);
				}
			}
		}

		// Token: 0x04000933 RID: 2355
		private static readonly MessageParser<PlantMarkersResult> _parser = new MessageParser<PlantMarkersResult>(() => new PlantMarkersResult());

		// Token: 0x04000934 RID: 2356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000935 RID: 2357
		public const int ResultsFieldNumber = 1;

		// Token: 0x04000936 RID: 2358
		private static readonly FieldCodec<PlantMarkersSceneResult> _repeated_results_codec = FieldCodec.ForMessage<PlantMarkersSceneResult>(10U, PlantMarkersSceneResult.Parser);

		// Token: 0x04000937 RID: 2359
		private readonly RepeatedField<PlantMarkersSceneResult> results_ = new RepeatedField<PlantMarkersSceneResult>();
	}
}

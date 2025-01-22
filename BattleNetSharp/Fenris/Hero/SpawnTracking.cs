using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x0200018D RID: 397
	public sealed class SpawnTracking : IMessage<SpawnTracking>, IMessage, IEquatable<SpawnTracking>, IDeepCloneable<SpawnTracking>, IBufferMessage
	{
		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x000A38B0 File Offset: 0x000A1AB0
		[DebuggerNonUserCode]
		public static MessageParser<SpawnTracking> Parser
		{
			get
			{
				return SpawnTracking._parser;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000A38C8 File Offset: 0x000A1AC8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeroReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000A38EC File Offset: 0x000A1AEC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpawnTracking.Descriptor;
			}
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000A3903 File Offset: 0x000A1B03
		[DebuggerNonUserCode]
		public SpawnTracking()
		{
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000A3923 File Offset: 0x000A1B23
		[DebuggerNonUserCode]
		public SpawnTracking(SpawnTracking other)
			: this()
		{
			this.timeBasedSpawnTracking_ = other.timeBasedSpawnTracking_.Clone();
			this.spawnTrackingMapData_ = other.spawnTrackingMapData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000A3960 File Offset: 0x000A1B60
		[DebuggerNonUserCode]
		public SpawnTracking Clone()
		{
			return new SpawnTracking(this);
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000A3978 File Offset: 0x000A1B78
		[DebuggerNonUserCode]
		public RepeatedField<TimeBasedSpawnTrackingData> TimeBasedSpawnTracking
		{
			get
			{
				return this.timeBasedSpawnTracking_;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000A3990 File Offset: 0x000A1B90
		[DebuggerNonUserCode]
		public RepeatedField<SpawnTrackingKeyValue> SpawnTrackingMapData
		{
			get
			{
				return this.spawnTrackingMapData_;
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000A39A8 File Offset: 0x000A1BA8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpawnTracking);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000A39C8 File Offset: 0x000A1BC8
		[DebuggerNonUserCode]
		public bool Equals(SpawnTracking other)
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
					bool flag4 = !this.timeBasedSpawnTracking_.Equals(other.timeBasedSpawnTracking_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.spawnTrackingMapData_.Equals(other.spawnTrackingMapData_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000A3A40 File Offset: 0x000A1C40
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.timeBasedSpawnTracking_.GetHashCode();
			num ^= this.spawnTrackingMapData_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000A3A90 File Offset: 0x000A1C90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000A3AA8 File Offset: 0x000A1CA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000A3AB4 File Offset: 0x000A1CB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.timeBasedSpawnTracking_.WriteTo(ref output, SpawnTracking._repeated_timeBasedSpawnTracking_codec);
			this.spawnTrackingMapData_.WriteTo(ref output, SpawnTracking._repeated_spawnTrackingMapData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000A3B04 File Offset: 0x000A1D04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.timeBasedSpawnTracking_.CalculateSize(SpawnTracking._repeated_timeBasedSpawnTracking_codec);
			num += this.spawnTrackingMapData_.CalculateSize(SpawnTracking._repeated_spawnTrackingMapData_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000A3B5C File Offset: 0x000A1D5C
		[DebuggerNonUserCode]
		public void MergeFrom(SpawnTracking other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.timeBasedSpawnTracking_.Add(other.timeBasedSpawnTracking_);
				this.spawnTrackingMapData_.Add(other.spawnTrackingMapData_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000A3BB0 File Offset: 0x000A1DB0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000A3BBC File Offset: 0x000A1DBC
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
						this.spawnTrackingMapData_.AddEntriesFrom(ref input, SpawnTracking._repeated_spawnTrackingMapData_codec);
					}
				}
				else
				{
					this.timeBasedSpawnTracking_.AddEntriesFrom(ref input, SpawnTracking._repeated_timeBasedSpawnTracking_codec);
				}
			}
		}

		// Token: 0x040012BF RID: 4799
		private static readonly MessageParser<SpawnTracking> _parser = new MessageParser<SpawnTracking>(() => new SpawnTracking());

		// Token: 0x040012C0 RID: 4800
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012C1 RID: 4801
		public const int TimeBasedSpawnTrackingFieldNumber = 1;

		// Token: 0x040012C2 RID: 4802
		private static readonly FieldCodec<TimeBasedSpawnTrackingData> _repeated_timeBasedSpawnTracking_codec = FieldCodec.ForMessage<TimeBasedSpawnTrackingData>(10U, TimeBasedSpawnTrackingData.Parser);

		// Token: 0x040012C3 RID: 4803
		private readonly RepeatedField<TimeBasedSpawnTrackingData> timeBasedSpawnTracking_ = new RepeatedField<TimeBasedSpawnTrackingData>();

		// Token: 0x040012C4 RID: 4804
		public const int SpawnTrackingMapDataFieldNumber = 2;

		// Token: 0x040012C5 RID: 4805
		private static readonly FieldCodec<SpawnTrackingKeyValue> _repeated_spawnTrackingMapData_codec = FieldCodec.ForMessage<SpawnTrackingKeyValue>(18U, SpawnTrackingKeyValue.Parser);

		// Token: 0x040012C6 RID: 4806
		private readonly RepeatedField<SpawnTrackingKeyValue> spawnTrackingMapData_ = new RepeatedField<SpawnTrackingKeyValue>();
	}
}

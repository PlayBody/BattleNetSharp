using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000442 RID: 1090
	public sealed class ClubView : IMessage<ClubView>, IMessage, IEquatable<ClubView>, IDeepCloneable<ClubView>, IBufferMessage
	{
		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001A08F0 File Offset: 0x0019EAF0
		[DebuggerNonUserCode]
		public static MessageParser<ClubView> Parser
		{
			get
			{
				return ClubView._parser;
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x001A0908 File Offset: 0x0019EB08
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubCoreReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001A092C File Offset: 0x0019EB2C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubView.Descriptor;
			}
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x001A0943 File Offset: 0x0019EB43
		[DebuggerNonUserCode]
		public ClubView()
		{
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x001A0950 File Offset: 0x0019EB50
		[DebuggerNonUserCode]
		public ClubView(ClubView other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clubId_ = other.clubId_;
			this.marker_ = ((other.marker_ != null) ? other.marker_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x001A09AC File Offset: 0x0019EBAC
		[DebuggerNonUserCode]
		public ClubView Clone()
		{
			return new ClubView(this);
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x001A09C4 File Offset: 0x0019EBC4
		// (set) Token: 0x06006B57 RID: 27479 RVA: 0x001A09F5 File Offset: 0x0019EBF5
		[DebuggerNonUserCode]
		public ulong ClubId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong clubIdDefaultValue;
				if (flag)
				{
					clubIdDefaultValue = this.clubId_;
				}
				else
				{
					clubIdDefaultValue = ClubView.ClubIdDefaultValue;
				}
				return clubIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.clubId_ = value;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x06006B58 RID: 27480 RVA: 0x001A0A10 File Offset: 0x0019EC10
		[DebuggerNonUserCode]
		public bool HasClubId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x001A0A2D File Offset: 0x0019EC2D
		[DebuggerNonUserCode]
		public void ClearClubId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x001A0A40 File Offset: 0x0019EC40
		// (set) Token: 0x06006B5B RID: 27483 RVA: 0x001A0A58 File Offset: 0x0019EC58
		[DebuggerNonUserCode]
		public ViewMarker Marker
		{
			get
			{
				return this.marker_;
			}
			set
			{
				this.marker_ = value;
			}
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x001A0A64 File Offset: 0x0019EC64
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubView);
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x001A0A84 File Offset: 0x0019EC84
		[DebuggerNonUserCode]
		public bool Equals(ClubView other)
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
					bool flag4 = this.ClubId != other.ClubId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Marker, other.Marker);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x001A0AF8 File Offset: 0x0019ECF8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num ^= this.ClubId.GetHashCode();
			}
			bool flag = this.marker_ != null;
			if (flag)
			{
				num ^= this.Marker.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x001A0B64 File Offset: 0x0019ED64
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x001A0B7C File Offset: 0x0019ED7C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x001A0B88 File Offset: 0x0019ED88
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(this.ClubId);
			}
			bool flag = this.marker_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Marker);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x001A0BF8 File Offset: 0x0019EDF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClubId = this.HasClubId;
			if (hasClubId)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClubId);
			}
			bool flag = this.marker_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Marker);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x001A0C68 File Offset: 0x0019EE68
		[DebuggerNonUserCode]
		public void MergeFrom(ClubView other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClubId = other.HasClubId;
				if (hasClubId)
				{
					this.ClubId = other.ClubId;
				}
				bool flag2 = other.marker_ != null;
				if (flag2)
				{
					bool flag3 = this.marker_ == null;
					if (flag3)
					{
						this.Marker = new ViewMarker();
					}
					this.Marker.MergeFrom(other.Marker);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x001A0CED File Offset: 0x0019EEED
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x001A0CF8 File Offset: 0x0019EEF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.marker_ == null;
						if (flag)
						{
							this.Marker = new ViewMarker();
						}
						input.ReadMessage(this.Marker);
					}
				}
				else
				{
					this.ClubId = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003109 RID: 12553
		private static readonly MessageParser<ClubView> _parser = new MessageParser<ClubView>(() => new ClubView());

		// Token: 0x0400310A RID: 12554
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400310B RID: 12555
		private int _hasBits0;

		// Token: 0x0400310C RID: 12556
		public const int ClubIdFieldNumber = 1;

		// Token: 0x0400310D RID: 12557
		private static readonly ulong ClubIdDefaultValue = 0UL;

		// Token: 0x0400310E RID: 12558
		private ulong clubId_;

		// Token: 0x0400310F RID: 12559
		public const int MarkerFieldNumber = 2;

		// Token: 0x04003110 RID: 12560
		private ViewMarker marker_;
	}
}

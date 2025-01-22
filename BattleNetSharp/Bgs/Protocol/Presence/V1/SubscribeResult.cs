using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
	// Token: 0x020005A7 RID: 1447
	public sealed class SubscribeResult : IMessage<SubscribeResult>, IMessage, IEquatable<SubscribeResult>, IDeepCloneable<SubscribeResult>, IBufferMessage
	{
		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x00217108 File Offset: 0x00215308
		[DebuggerNonUserCode]
		public static MessageParser<SubscribeResult> Parser
		{
			get
			{
				return SubscribeResult._parser;
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x060089B8 RID: 35256 RVA: 0x00217120 File Offset: 0x00215320
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PresenceServiceReflection.Descriptor.MessageTypes[8];
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x00217144 File Offset: 0x00215344
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscribeResult.Descriptor;
			}
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x0021715B File Offset: 0x0021535B
		[DebuggerNonUserCode]
		public SubscribeResult()
		{
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x00217168 File Offset: 0x00215368
		[DebuggerNonUserCode]
		public SubscribeResult(SubscribeResult other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x002171C4 File Offset: 0x002153C4
		[DebuggerNonUserCode]
		public SubscribeResult Clone()
		{
			return new SubscribeResult(this);
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x002171DC File Offset: 0x002153DC
		// (set) Token: 0x060089BE RID: 35262 RVA: 0x002171F4 File Offset: 0x002153F4
		[DebuggerNonUserCode]
		public EntityId EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x00217200 File Offset: 0x00215400
		// (set) Token: 0x060089C0 RID: 35264 RVA: 0x00217231 File Offset: 0x00215431
		[DebuggerNonUserCode]
		public uint Result
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint resultDefaultValue;
				if (flag)
				{
					resultDefaultValue = this.result_;
				}
				else
				{
					resultDefaultValue = SubscribeResult.ResultDefaultValue;
				}
				return resultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.result_ = value;
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x0021724C File Offset: 0x0021544C
		[DebuggerNonUserCode]
		public bool HasResult
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00217269 File Offset: 0x00215469
		[DebuggerNonUserCode]
		public void ClearResult()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x0021727C File Offset: 0x0021547C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscribeResult);
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x0021729C File Offset: 0x0021549C
		[DebuggerNonUserCode]
		public bool Equals(SubscribeResult other)
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
					bool flag4 = !object.Equals(this.EntityId, other.EntityId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Result != other.Result;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x00217310 File Offset: 0x00215510
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num ^= this.EntityId.GetHashCode();
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num ^= this.Result.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x0021737C File Offset: 0x0021557C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x00217394 File Offset: 0x00215594
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x002173A0 File Offset: 0x002155A0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.entityId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Result);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x00217414 File Offset: 0x00215614
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.entityId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
			}
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x00217484 File Offset: 0x00215684
		[DebuggerNonUserCode]
		public void MergeFrom(SubscribeResult other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.entityId_ != null;
				if (flag2)
				{
					bool flag3 = this.entityId_ == null;
					if (flag3)
					{
						this.EntityId = new EntityId();
					}
					this.EntityId.MergeFrom(other.EntityId);
				}
				bool hasResult = other.HasResult;
				if (hasResult)
				{
					this.Result = other.Result;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x00217509 File Offset: 0x00215709
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x00217514 File Offset: 0x00215714
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Result = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.entityId_ == null;
					if (flag)
					{
						this.EntityId = new EntityId();
					}
					input.ReadMessage(this.EntityId);
				}
			}
		}

		// Token: 0x04003E52 RID: 15954
		private static readonly MessageParser<SubscribeResult> _parser = new MessageParser<SubscribeResult>(() => new SubscribeResult());

		// Token: 0x04003E53 RID: 15955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E54 RID: 15956
		private int _hasBits0;

		// Token: 0x04003E55 RID: 15957
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003E56 RID: 15958
		private EntityId entityId_;

		// Token: 0x04003E57 RID: 15959
		public const int ResultFieldNumber = 2;

		// Token: 0x04003E58 RID: 15960
		private static readonly uint ResultDefaultValue = 0U;

		// Token: 0x04003E59 RID: 15961
		private uint result_;
	}
}

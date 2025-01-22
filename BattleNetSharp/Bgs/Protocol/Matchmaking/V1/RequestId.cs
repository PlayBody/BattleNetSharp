using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E7 RID: 999
	public sealed class RequestId : IMessage<RequestId>, IMessage, IEquatable<RequestId>, IDeepCloneable<RequestId>, IBufferMessage
	{
		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x00180950 File Offset: 0x0017EB50
		[DebuggerNonUserCode]
		public static MessageParser<RequestId> Parser
		{
			get
			{
				return RequestId._parser;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x00180968 File Offset: 0x0017EB68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x0018098C File Offset: 0x0017EB8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RequestId.Descriptor;
			}
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x001809A3 File Offset: 0x0017EBA3
		[DebuggerNonUserCode]
		public RequestId()
		{
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x001809AD File Offset: 0x0017EBAD
		[DebuggerNonUserCode]
		public RequestId(RequestId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x001809E0 File Offset: 0x0017EBE0
		[DebuggerNonUserCode]
		public RequestId Clone()
		{
			return new RequestId(this);
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06006371 RID: 25457 RVA: 0x001809F8 File Offset: 0x0017EBF8
		// (set) Token: 0x06006372 RID: 25458 RVA: 0x00180A29 File Offset: 0x0017EC29
		[DebuggerNonUserCode]
		public ulong Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = RequestId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06006373 RID: 25459 RVA: 0x00180A44 File Offset: 0x0017EC44
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x00180A61 File Offset: 0x0017EC61
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x00180A74 File Offset: 0x0017EC74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RequestId);
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x00180A94 File Offset: 0x0017EC94
		[DebuggerNonUserCode]
		public bool Equals(RequestId other)
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
					bool flag4 = this.Id != other.Id;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00180AEC File Offset: 0x0017ECEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00180B3C File Offset: 0x0017ED3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006379 RID: 25465 RVA: 0x00180B54 File Offset: 0x0017ED54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x00180B60 File Offset: 0x0017ED60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00180BAC File Offset: 0x0017EDAC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 9;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00180BF0 File Offset: 0x0017EDF0
		[DebuggerNonUserCode]
		public void MergeFrom(RequestId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x00180C39 File Offset: 0x0017EE39
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x00180C44 File Offset: 0x0017EE44
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 9U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadFixed64();
				}
			}
		}

		// Token: 0x04002D5B RID: 11611
		private static readonly MessageParser<RequestId> _parser = new MessageParser<RequestId>(() => new RequestId());

		// Token: 0x04002D5C RID: 11612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D5D RID: 11613
		private int _hasBits0;

		// Token: 0x04002D5E RID: 11614
		public const int IdFieldNumber = 1;

		// Token: 0x04002D5F RID: 11615
		private static readonly ulong IdDefaultValue = 0UL;

		// Token: 0x04002D60 RID: 11616
		private ulong id_;
	}
}

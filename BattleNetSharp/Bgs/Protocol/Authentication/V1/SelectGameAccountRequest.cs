using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000614 RID: 1556
	public sealed class SelectGameAccountRequest : IMessage<SelectGameAccountRequest>, IMessage, IEquatable<SelectGameAccountRequest>, IDeepCloneable<SelectGameAccountRequest>, IBufferMessage
	{
		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x002353A4 File Offset: 0x002335A4
		[DebuggerNonUserCode]
		public static MessageParser<SelectGameAccountRequest> Parser
		{
			get
			{
				return SelectGameAccountRequest._parser;
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x002353BC File Offset: 0x002335BC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x002353E0 File Offset: 0x002335E0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectGameAccountRequest.Descriptor;
			}
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x002353F7 File Offset: 0x002335F7
		[DebuggerNonUserCode]
		public SelectGameAccountRequest()
		{
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x00235401 File Offset: 0x00233601
		[DebuggerNonUserCode]
		public SelectGameAccountRequest(SelectGameAccountRequest other)
			: this()
		{
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x00235438 File Offset: 0x00233638
		[DebuggerNonUserCode]
		public SelectGameAccountRequest Clone()
		{
			return new SelectGameAccountRequest(this);
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x060091D4 RID: 37332 RVA: 0x00235450 File Offset: 0x00233650
		// (set) Token: 0x060091D5 RID: 37333 RVA: 0x00235468 File Offset: 0x00233668
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x00235474 File Offset: 0x00233674
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectGameAccountRequest);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x00235494 File Offset: 0x00233694
		[DebuggerNonUserCode]
		public bool Equals(SelectGameAccountRequest other)
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
					bool flag4 = !object.Equals(this.GameAccountId, other.GameAccountId);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x002354F0 File Offset: 0x002336F0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x00235540 File Offset: 0x00233740
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00235558 File Offset: 0x00233758
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x00235564 File Offset: 0x00233764
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x002355B4 File Offset: 0x002337B4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00235608 File Offset: 0x00233808
		[DebuggerNonUserCode]
		public void MergeFrom(SelectGameAccountRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.gameAccountId_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountId_ == null;
					if (flag3)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x00235674 File Offset: 0x00233874
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00235680 File Offset: 0x00233880
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
					bool flag = this.gameAccountId_ == null;
					if (flag)
					{
						this.GameAccountId = new EntityId();
					}
					input.ReadMessage(this.GameAccountId);
				}
			}
		}

		// Token: 0x040041CC RID: 16844
		private static readonly MessageParser<SelectGameAccountRequest> _parser = new MessageParser<SelectGameAccountRequest>(() => new SelectGameAccountRequest());

		// Token: 0x040041CD RID: 16845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041CE RID: 16846
		public const int GameAccountIdFieldNumber = 1;

		// Token: 0x040041CF RID: 16847
		private EntityId gameAccountId_;
	}
}

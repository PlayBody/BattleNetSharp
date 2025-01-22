using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x02000539 RID: 1337
	public sealed class GetSessionStateRequest : IMessage<GetSessionStateRequest>, IMessage, IEquatable<GetSessionStateRequest>, IDeepCloneable<GetSessionStateRequest>, IBufferMessage
	{
		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x001F7C10 File Offset: 0x001F5E10
		[DebuggerNonUserCode]
		public static MessageParser<GetSessionStateRequest> Parser
		{
			get
			{
				return GetSessionStateRequest._parser;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600816D RID: 33133 RVA: 0x001F7C28 File Offset: 0x001F5E28
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x001F7C4C File Offset: 0x001F5E4C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSessionStateRequest.Descriptor;
			}
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x001F7C63 File Offset: 0x001F5E63
		[DebuggerNonUserCode]
		public GetSessionStateRequest()
		{
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x001F7C70 File Offset: 0x001F5E70
		[DebuggerNonUserCode]
		public GetSessionStateRequest(GetSessionStateRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.includeBillingDisabled_ = other.includeBillingDisabled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x001F7CCC File Offset: 0x001F5ECC
		[DebuggerNonUserCode]
		public GetSessionStateRequest Clone()
		{
			return new GetSessionStateRequest(this);
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x001F7CE4 File Offset: 0x001F5EE4
		// (set) Token: 0x06008173 RID: 33139 RVA: 0x001F7CFC File Offset: 0x001F5EFC
		[DebuggerNonUserCode]
		public GameAccountHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x06008174 RID: 33140 RVA: 0x001F7D08 File Offset: 0x001F5F08
		// (set) Token: 0x06008175 RID: 33141 RVA: 0x001F7D39 File Offset: 0x001F5F39
		[DebuggerNonUserCode]
		public bool IncludeBillingDisabled
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool includeBillingDisabledDefaultValue;
				if (flag)
				{
					includeBillingDisabledDefaultValue = this.includeBillingDisabled_;
				}
				else
				{
					includeBillingDisabledDefaultValue = GetSessionStateRequest.IncludeBillingDisabledDefaultValue;
				}
				return includeBillingDisabledDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.includeBillingDisabled_ = value;
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x06008176 RID: 33142 RVA: 0x001F7D54 File Offset: 0x001F5F54
		[DebuggerNonUserCode]
		public bool HasIncludeBillingDisabled
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x001F7D71 File Offset: 0x001F5F71
		[DebuggerNonUserCode]
		public void ClearIncludeBillingDisabled()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x001F7D84 File Offset: 0x001F5F84
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSessionStateRequest);
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x001F7DA4 File Offset: 0x001F5FA4
		[DebuggerNonUserCode]
		public bool Equals(GetSessionStateRequest other)
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
					bool flag4 = !object.Equals(this.Handle, other.Handle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.IncludeBillingDisabled != other.IncludeBillingDisabled;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x001F7E18 File Offset: 0x001F6018
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				num ^= this.IncludeBillingDisabled.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x001F7E84 File Offset: 0x001F6084
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x001F7E9C File Offset: 0x001F609C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x001F7EA8 File Offset: 0x001F60A8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IncludeBillingDisabled);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x001F7F1C File Offset: 0x001F611C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool hasIncludeBillingDisabled = this.HasIncludeBillingDisabled;
			if (hasIncludeBillingDisabled)
			{
				num += 2;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x001F7F80 File Offset: 0x001F6180
		[DebuggerNonUserCode]
		public void MergeFrom(GetSessionStateRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.handle_ != null;
				if (flag2)
				{
					bool flag3 = this.handle_ == null;
					if (flag3)
					{
						this.Handle = new GameAccountHandle();
					}
					this.Handle.MergeFrom(other.Handle);
				}
				bool hasIncludeBillingDisabled = other.HasIncludeBillingDisabled;
				if (hasIncludeBillingDisabled)
				{
					this.IncludeBillingDisabled = other.IncludeBillingDisabled;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x001F8005 File Offset: 0x001F6205
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x001F8010 File Offset: 0x001F6210
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
						this.IncludeBillingDisabled = input.ReadBool();
					}
				}
				else
				{
					bool flag = this.handle_ == null;
					if (flag)
					{
						this.Handle = new GameAccountHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x04003AAE RID: 15022
		private static readonly MessageParser<GetSessionStateRequest> _parser = new MessageParser<GetSessionStateRequest>(() => new GetSessionStateRequest());

		// Token: 0x04003AAF RID: 15023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB0 RID: 15024
		private int _hasBits0;

		// Token: 0x04003AB1 RID: 15025
		public const int HandleFieldNumber = 1;

		// Token: 0x04003AB2 RID: 15026
		private GameAccountHandle handle_;

		// Token: 0x04003AB3 RID: 15027
		public const int IncludeBillingDisabledFieldNumber = 2;

		// Token: 0x04003AB4 RID: 15028
		private static readonly bool IncludeBillingDisabledDefaultValue = false;

		// Token: 0x04003AB5 RID: 15029
		private bool includeBillingDisabled_;
	}
}

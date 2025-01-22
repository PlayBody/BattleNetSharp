using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000776 RID: 1910
	public sealed class CookieUpdateResponse : IMessage<CookieUpdateResponse>, IMessage, IEquatable<CookieUpdateResponse>, IDeepCloneable<CookieUpdateResponse>, IBufferMessage
	{
		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600AFBF RID: 44991 RVA: 0x002AC710 File Offset: 0x002AA910
		[DebuggerNonUserCode]
		public static MessageParser<CookieUpdateResponse> Parser
		{
			get
			{
				return CookieUpdateResponse._parser;
			}
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600AFC0 RID: 44992 RVA: 0x002AC728 File Offset: 0x002AA928
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[10];
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x002AC74C File Offset: 0x002AA94C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CookieUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x002AC763 File Offset: 0x002AA963
		[DebuggerNonUserCode]
		public CookieUpdateResponse()
		{
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x002AC76D File Offset: 0x002AA96D
		[DebuggerNonUserCode]
		public CookieUpdateResponse(CookieUpdateResponse other)
			: this()
		{
			this.cookie_ = ((other.cookie_ != null) ? other.cookie_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x002AC7A4 File Offset: 0x002AA9A4
		[DebuggerNonUserCode]
		public CookieUpdateResponse Clone()
		{
			return new CookieUpdateResponse(this);
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600AFC5 RID: 44997 RVA: 0x002AC7BC File Offset: 0x002AA9BC
		// (set) Token: 0x0600AFC6 RID: 44998 RVA: 0x002AC7D4 File Offset: 0x002AA9D4
		[DebuggerNonUserCode]
		public OfflineCookie Cookie
		{
			get
			{
				return this.cookie_;
			}
			set
			{
				this.cookie_ = value;
			}
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x002AC7E0 File Offset: 0x002AA9E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as CookieUpdateResponse);
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x002AC800 File Offset: 0x002AAA00
		[DebuggerNonUserCode]
		public bool Equals(CookieUpdateResponse other)
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
					bool flag4 = !object.Equals(this.Cookie, other.Cookie);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x002AC85C File Offset: 0x002AAA5C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.cookie_ != null;
			if (flag)
			{
				num ^= this.Cookie.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x002AC8AC File Offset: 0x002AAAAC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x002AC8C4 File Offset: 0x002AAAC4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x002AC8D0 File Offset: 0x002AAAD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.cookie_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Cookie);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFCD RID: 45005 RVA: 0x002AC920 File Offset: 0x002AAB20
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.cookie_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Cookie);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x002AC974 File Offset: 0x002AAB74
		[DebuggerNonUserCode]
		public void MergeFrom(CookieUpdateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.cookie_ != null;
				if (flag2)
				{
					bool flag3 = this.cookie_ == null;
					if (flag3)
					{
						this.Cookie = new OfflineCookie();
					}
					this.Cookie.MergeFrom(other.Cookie);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AFCF RID: 45007 RVA: 0x002AC9E0 File Offset: 0x002AABE0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x002AC9EC File Offset: 0x002AABEC
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
					bool flag = this.cookie_ == null;
					if (flag)
					{
						this.Cookie = new OfflineCookie();
					}
					input.ReadMessage(this.Cookie);
				}
			}
		}

		// Token: 0x04004F3E RID: 20286
		private static readonly MessageParser<CookieUpdateResponse> _parser = new MessageParser<CookieUpdateResponse>(() => new CookieUpdateResponse());

		// Token: 0x04004F3F RID: 20287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F40 RID: 20288
		public const int CookieFieldNumber = 1;

		// Token: 0x04004F41 RID: 20289
		private OfflineCookie cookie_;
	}
}

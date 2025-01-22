using System;
using System.Diagnostics;
using Fenris.Client;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200022E RID: 558
	public sealed class SaveAccountPreferencesRequest : IMessage<SaveAccountPreferencesRequest>, IMessage, IEquatable<SaveAccountPreferencesRequest>, IDeepCloneable<SaveAccountPreferencesRequest>, IBufferMessage
	{
		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x000F0768 File Offset: 0x000EE968
		[DebuggerNonUserCode]
		public static MessageParser<SaveAccountPreferencesRequest> Parser
		{
			get
			{
				return SaveAccountPreferencesRequest._parser;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x000F0780 File Offset: 0x000EE980
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[30];
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06003CA0 RID: 15520 RVA: 0x000F07A4 File Offset: 0x000EE9A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SaveAccountPreferencesRequest.Descriptor;
			}
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x000F07BB File Offset: 0x000EE9BB
		[DebuggerNonUserCode]
		public SaveAccountPreferencesRequest()
		{
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x000F07C5 File Offset: 0x000EE9C5
		[DebuggerNonUserCode]
		public SaveAccountPreferencesRequest(SaveAccountPreferencesRequest other)
			: this()
		{
			this.preferences_ = ((other.preferences_ != null) ? other.preferences_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x000F07FC File Offset: 0x000EE9FC
		[DebuggerNonUserCode]
		public SaveAccountPreferencesRequest Clone()
		{
			return new SaveAccountPreferencesRequest(this);
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x000F0814 File Offset: 0x000EEA14
		// (set) Token: 0x06003CA5 RID: 15525 RVA: 0x000F082C File Offset: 0x000EEA2C
		[DebuggerNonUserCode]
		public Preferences Preferences
		{
			get
			{
				return this.preferences_;
			}
			set
			{
				this.preferences_ = value;
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x000F0838 File Offset: 0x000EEA38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SaveAccountPreferencesRequest);
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x000F0858 File Offset: 0x000EEA58
		[DebuggerNonUserCode]
		public bool Equals(SaveAccountPreferencesRequest other)
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
					bool flag4 = !object.Equals(this.Preferences, other.Preferences);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x000F08B4 File Offset: 0x000EEAB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.preferences_ != null;
			if (flag)
			{
				num ^= this.Preferences.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x000F0904 File Offset: 0x000EEB04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x000F091C File Offset: 0x000EEB1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x000F0928 File Offset: 0x000EEB28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.preferences_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Preferences);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x000F0978 File Offset: 0x000EEB78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.preferences_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Preferences);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x000F09CC File Offset: 0x000EEBCC
		[DebuggerNonUserCode]
		public void MergeFrom(SaveAccountPreferencesRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.preferences_ != null;
				if (flag2)
				{
					bool flag3 = this.preferences_ == null;
					if (flag3)
					{
						this.Preferences = new Preferences();
					}
					this.Preferences.MergeFrom(other.Preferences);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x000F0A38 File Offset: 0x000EEC38
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x000F0A44 File Offset: 0x000EEC44
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
					bool flag = this.preferences_ == null;
					if (flag)
					{
						this.Preferences = new Preferences();
					}
					input.ReadMessage(this.Preferences);
				}
			}
		}

		// Token: 0x04001C06 RID: 7174
		private static readonly MessageParser<SaveAccountPreferencesRequest> _parser = new MessageParser<SaveAccountPreferencesRequest>(() => new SaveAccountPreferencesRequest());

		// Token: 0x04001C07 RID: 7175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C08 RID: 7176
		public const int PreferencesFieldNumber = 1;

		// Token: 0x04001C09 RID: 7177
		private Preferences preferences_;
	}
}

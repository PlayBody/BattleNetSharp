using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.GameMessage
{
	// Token: 0x020001D7 RID: 471
	public sealed class AIVariableDebugSnapshot : IMessage<AIVariableDebugSnapshot>, IMessage, IEquatable<AIVariableDebugSnapshot>, IDeepCloneable<AIVariableDebugSnapshot>, IBufferMessage
	{
		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x000C90E8 File Offset: 0x000C72E8
		[DebuggerNonUserCode]
		public static MessageParser<AIVariableDebugSnapshot> Parser
		{
			get
			{
				return AIVariableDebugSnapshot._parser;
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x000C9100 File Offset: 0x000C7300
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMessageReflection.Descriptor.MessageTypes[28];
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060032CB RID: 13003 RVA: 0x000C9124 File Offset: 0x000C7324
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AIVariableDebugSnapshot.Descriptor;
			}
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000C913B File Offset: 0x000C733B
		[DebuggerNonUserCode]
		public AIVariableDebugSnapshot()
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000C915B File Offset: 0x000C735B
		[DebuggerNonUserCode]
		public AIVariableDebugSnapshot(AIVariableDebugSnapshot other)
			: this()
		{
			this.localVariables_ = other.localVariables_.Clone();
			this.remoteVariables_ = other.remoteVariables_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000C9198 File Offset: 0x000C7398
		[DebuggerNonUserCode]
		public AIVariableDebugSnapshot Clone()
		{
			return new AIVariableDebugSnapshot(this);
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060032CF RID: 13007 RVA: 0x000C91B0 File Offset: 0x000C73B0
		[DebuggerNonUserCode]
		public RepeatedField<AIDebugVariable> LocalVariables
		{
			get
			{
				return this.localVariables_;
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x000C91C8 File Offset: 0x000C73C8
		[DebuggerNonUserCode]
		public RepeatedField<AIDebugVariable> RemoteVariables
		{
			get
			{
				return this.remoteVariables_;
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000C91E0 File Offset: 0x000C73E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AIVariableDebugSnapshot);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000C9200 File Offset: 0x000C7400
		[DebuggerNonUserCode]
		public bool Equals(AIVariableDebugSnapshot other)
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
					bool flag4 = !this.localVariables_.Equals(other.localVariables_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.remoteVariables_.Equals(other.remoteVariables_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000C9278 File Offset: 0x000C7478
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.localVariables_.GetHashCode();
			num ^= this.remoteVariables_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000C92C8 File Offset: 0x000C74C8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000C92E0 File Offset: 0x000C74E0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000C92EC File Offset: 0x000C74EC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.localVariables_.WriteTo(ref output, AIVariableDebugSnapshot._repeated_localVariables_codec);
			this.remoteVariables_.WriteTo(ref output, AIVariableDebugSnapshot._repeated_remoteVariables_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000C933C File Offset: 0x000C753C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.localVariables_.CalculateSize(AIVariableDebugSnapshot._repeated_localVariables_codec);
			num += this.remoteVariables_.CalculateSize(AIVariableDebugSnapshot._repeated_remoteVariables_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000C9394 File Offset: 0x000C7594
		[DebuggerNonUserCode]
		public void MergeFrom(AIVariableDebugSnapshot other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.localVariables_.Add(other.localVariables_);
				this.remoteVariables_.Add(other.remoteVariables_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000C93E8 File Offset: 0x000C75E8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x000C93F4 File Offset: 0x000C75F4
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
						this.remoteVariables_.AddEntriesFrom(ref input, AIVariableDebugSnapshot._repeated_remoteVariables_codec);
					}
				}
				else
				{
					this.localVariables_.AddEntriesFrom(ref input, AIVariableDebugSnapshot._repeated_localVariables_codec);
				}
			}
		}

		// Token: 0x04001761 RID: 5985
		private static readonly MessageParser<AIVariableDebugSnapshot> _parser = new MessageParser<AIVariableDebugSnapshot>(() => new AIVariableDebugSnapshot());

		// Token: 0x04001762 RID: 5986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001763 RID: 5987
		public const int LocalVariablesFieldNumber = 1;

		// Token: 0x04001764 RID: 5988
		private static readonly FieldCodec<AIDebugVariable> _repeated_localVariables_codec = FieldCodec.ForMessage<AIDebugVariable>(10U, AIDebugVariable.Parser);

		// Token: 0x04001765 RID: 5989
		private readonly RepeatedField<AIDebugVariable> localVariables_ = new RepeatedField<AIDebugVariable>();

		// Token: 0x04001766 RID: 5990
		public const int RemoteVariablesFieldNumber = 2;

		// Token: 0x04001767 RID: 5991
		private static readonly FieldCodec<AIDebugVariable> _repeated_remoteVariables_codec = FieldCodec.ForMessage<AIDebugVariable>(18U, AIDebugVariable.Parser);

		// Token: 0x04001768 RID: 5992
		private readonly RepeatedField<AIDebugVariable> remoteVariables_ = new RepeatedField<AIDebugVariable>();
	}
}

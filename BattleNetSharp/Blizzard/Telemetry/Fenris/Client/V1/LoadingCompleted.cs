using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Client.V1
{
	// Token: 0x02000306 RID: 774
	public sealed class LoadingCompleted : IMessage<LoadingCompleted>, IMessage, IEquatable<LoadingCompleted>, IDeepCloneable<LoadingCompleted>, IBufferMessage
	{
		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x0013D770 File Offset: 0x0013B970
		[DebuggerNonUserCode]
		public static MessageParser<LoadingCompleted> Parser
		{
			get
			{
				return LoadingCompleted._parser;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x0013D788 File Offset: 0x0013B988
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LoadingCompletedReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06005227 RID: 21031 RVA: 0x0013D7AC File Offset: 0x0013B9AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingCompleted.Descriptor;
			}
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x0013D7C3 File Offset: 0x0013B9C3
		[DebuggerNonUserCode]
		public LoadingCompleted()
		{
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x0013D7D0 File Offset: 0x0013B9D0
		[DebuggerNonUserCode]
		public LoadingCompleted(LoadingCompleted other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.sourceLocation_ = ((other.sourceLocation_ != null) ? other.sourceLocation_.Clone() : null);
			this.currentLocation_ = ((other.currentLocation_ != null) ? other.currentLocation_.Clone() : null);
			this.loadingTime_ = other.loadingTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x0013D848 File Offset: 0x0013BA48
		[DebuggerNonUserCode]
		public LoadingCompleted Clone()
		{
			return new LoadingCompleted(this);
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x0013D860 File Offset: 0x0013BA60
		// (set) Token: 0x0600522C RID: 21036 RVA: 0x0013D878 File Offset: 0x0013BA78
		[DebuggerNonUserCode]
		public LoadingCompleted.Types.LocationInfo SourceLocation
		{
			get
			{
				return this.sourceLocation_;
			}
			set
			{
				this.sourceLocation_ = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x0013D884 File Offset: 0x0013BA84
		// (set) Token: 0x0600522E RID: 21038 RVA: 0x0013D89C File Offset: 0x0013BA9C
		[DebuggerNonUserCode]
		public LoadingCompleted.Types.LocationInfo CurrentLocation
		{
			get
			{
				return this.currentLocation_;
			}
			set
			{
				this.currentLocation_ = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x0013D8A8 File Offset: 0x0013BAA8
		// (set) Token: 0x06005230 RID: 21040 RVA: 0x0013D8D9 File Offset: 0x0013BAD9
		[DebuggerNonUserCode]
		public float LoadingTime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				float loadingTimeDefaultValue;
				if (flag)
				{
					loadingTimeDefaultValue = this.loadingTime_;
				}
				else
				{
					loadingTimeDefaultValue = LoadingCompleted.LoadingTimeDefaultValue;
				}
				return loadingTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.loadingTime_ = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x0013D8F4 File Offset: 0x0013BAF4
		[DebuggerNonUserCode]
		public bool HasLoadingTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x0013D911 File Offset: 0x0013BB11
		[DebuggerNonUserCode]
		public void ClearLoadingTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x0013D924 File Offset: 0x0013BB24
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingCompleted);
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x0013D944 File Offset: 0x0013BB44
		[DebuggerNonUserCode]
		public bool Equals(LoadingCompleted other)
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
					bool flag4 = !object.Equals(this.SourceLocation, other.SourceLocation);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.CurrentLocation, other.CurrentLocation);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LoadingTime, other.LoadingTime);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x0013D9E0 File Offset: 0x0013BBE0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.sourceLocation_ != null;
			if (flag)
			{
				num ^= this.SourceLocation.GetHashCode();
			}
			bool flag2 = this.currentLocation_ != null;
			if (flag2)
			{
				num ^= this.CurrentLocation.GetHashCode();
			}
			bool hasLoadingTime = this.HasLoadingTime;
			if (hasLoadingTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LoadingTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x0013DA6C File Offset: 0x0013BC6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x0013DA84 File Offset: 0x0013BC84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x0013DA90 File Offset: 0x0013BC90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.sourceLocation_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SourceLocation);
			}
			bool flag2 = this.currentLocation_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CurrentLocation);
			}
			bool hasLoadingTime = this.HasLoadingTime;
			if (hasLoadingTime)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.LoadingTime);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x0013DB28 File Offset: 0x0013BD28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.sourceLocation_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SourceLocation);
			}
			bool flag2 = this.currentLocation_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentLocation);
			}
			bool hasLoadingTime = this.HasLoadingTime;
			if (hasLoadingTime)
			{
				num += 5;
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x0013DBAC File Offset: 0x0013BDAC
		[DebuggerNonUserCode]
		public void MergeFrom(LoadingCompleted other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.sourceLocation_ != null;
				if (flag2)
				{
					bool flag3 = this.sourceLocation_ == null;
					if (flag3)
					{
						this.SourceLocation = new LoadingCompleted.Types.LocationInfo();
					}
					this.SourceLocation.MergeFrom(other.SourceLocation);
				}
				bool flag4 = other.currentLocation_ != null;
				if (flag4)
				{
					bool flag5 = this.currentLocation_ == null;
					if (flag5)
					{
						this.CurrentLocation = new LoadingCompleted.Types.LocationInfo();
					}
					this.CurrentLocation.MergeFrom(other.CurrentLocation);
				}
				bool hasLoadingTime = other.HasLoadingTime;
				if (hasLoadingTime)
				{
					this.LoadingTime = other.LoadingTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0013DC74 File Offset: 0x0013BE74
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x0013DC80 File Offset: 0x0013BE80
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
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LoadingTime = input.ReadFloat();
						}
					}
					else
					{
						bool flag = this.currentLocation_ == null;
						if (flag)
						{
							this.CurrentLocation = new LoadingCompleted.Types.LocationInfo();
						}
						input.ReadMessage(this.CurrentLocation);
					}
				}
				else
				{
					bool flag2 = this.sourceLocation_ == null;
					if (flag2)
					{
						this.SourceLocation = new LoadingCompleted.Types.LocationInfo();
					}
					input.ReadMessage(this.SourceLocation);
				}
			}
		}

		// Token: 0x04002551 RID: 9553
		private static readonly MessageParser<LoadingCompleted> _parser = new MessageParser<LoadingCompleted>(() => new LoadingCompleted());

		// Token: 0x04002552 RID: 9554
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002553 RID: 9555
		private int _hasBits0;

		// Token: 0x04002554 RID: 9556
		public const int SourceLocationFieldNumber = 1;

		// Token: 0x04002555 RID: 9557
		private LoadingCompleted.Types.LocationInfo sourceLocation_;

		// Token: 0x04002556 RID: 9558
		public const int CurrentLocationFieldNumber = 2;

		// Token: 0x04002557 RID: 9559
		private LoadingCompleted.Types.LocationInfo currentLocation_;

		// Token: 0x04002558 RID: 9560
		public const int LoadingTimeFieldNumber = 3;

		// Token: 0x04002559 RID: 9561
		private static readonly float LoadingTimeDefaultValue = 0f;

		// Token: 0x0400255A RID: 9562
		private float loadingTime_;

		// Token: 0x02000E08 RID: 3592
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0200148C RID: 5260
			public sealed class LocationInfo : IMessage<LoadingCompleted.Types.LocationInfo>, IMessage, IEquatable<LoadingCompleted.Types.LocationInfo>, IDeepCloneable<LoadingCompleted.Types.LocationInfo>, IBufferMessage
			{
				// Token: 0x17003B0A RID: 15114
				// (get) Token: 0x0600E788 RID: 59272 RVA: 0x004DBC9C File Offset: 0x004D9E9C
				[DebuggerNonUserCode]
				public static MessageParser<LoadingCompleted.Types.LocationInfo> Parser
				{
					get
					{
						return LoadingCompleted.Types.LocationInfo._parser;
					}
				}

				// Token: 0x17003B0B RID: 15115
				// (get) Token: 0x0600E789 RID: 59273 RVA: 0x004DBCB4 File Offset: 0x004D9EB4
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					get
					{
						return LoadingCompleted.Descriptor.NestedTypes[0];
					}
				}

				// Token: 0x17003B0C RID: 15116
				// (get) Token: 0x0600E78A RID: 59274 RVA: 0x004DBCD8 File Offset: 0x004D9ED8
				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return LoadingCompleted.Types.LocationInfo.Descriptor;
					}
				}

				// Token: 0x0600E78B RID: 59275 RVA: 0x004DBCEF File Offset: 0x004D9EEF
				[DebuggerNonUserCode]
				public LocationInfo()
				{
				}

				// Token: 0x0600E78C RID: 59276 RVA: 0x004DBCFC File Offset: 0x004D9EFC
				[DebuggerNonUserCode]
				public LocationInfo(LoadingCompleted.Types.LocationInfo other)
					: this()
				{
					this._hasBits0 = other._hasBits0;
					this.mainMenu_ = other.mainMenu_;
					this.worldSno_ = other.worldSno_;
					this.worldName_ = other.worldName_;
					this.sceneSno_ = other.sceneSno_;
					this.sceneName_ = other.sceneName_;
					this.gridX_ = other.gridX_;
					this.gridY_ = other.gridY_;
					this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
				}

				// Token: 0x0600E78D RID: 59277 RVA: 0x004DBD84 File Offset: 0x004D9F84
				[DebuggerNonUserCode]
				public LoadingCompleted.Types.LocationInfo Clone()
				{
					return new LoadingCompleted.Types.LocationInfo(this);
				}

				// Token: 0x17003B0D RID: 15117
				// (get) Token: 0x0600E78E RID: 59278 RVA: 0x004DBD9C File Offset: 0x004D9F9C
				// (set) Token: 0x0600E78F RID: 59279 RVA: 0x004DBDCD File Offset: 0x004D9FCD
				[DebuggerNonUserCode]
				public bool MainMenu
				{
					get
					{
						bool flag = (this._hasBits0 & 1) != 0;
						bool mainMenuDefaultValue;
						if (flag)
						{
							mainMenuDefaultValue = this.mainMenu_;
						}
						else
						{
							mainMenuDefaultValue = LoadingCompleted.Types.LocationInfo.MainMenuDefaultValue;
						}
						return mainMenuDefaultValue;
					}
					set
					{
						this._hasBits0 |= 1;
						this.mainMenu_ = value;
					}
				}

				// Token: 0x17003B0E RID: 15118
				// (get) Token: 0x0600E790 RID: 59280 RVA: 0x004DBDE8 File Offset: 0x004D9FE8
				[DebuggerNonUserCode]
				public bool HasMainMenu
				{
					get
					{
						return (this._hasBits0 & 1) != 0;
					}
				}

				// Token: 0x0600E791 RID: 59281 RVA: 0x004DBE05 File Offset: 0x004DA005
				[DebuggerNonUserCode]
				public void ClearMainMenu()
				{
					this._hasBits0 &= -2;
				}

				// Token: 0x17003B0F RID: 15119
				// (get) Token: 0x0600E792 RID: 59282 RVA: 0x004DBE18 File Offset: 0x004DA018
				// (set) Token: 0x0600E793 RID: 59283 RVA: 0x004DBE49 File Offset: 0x004DA049
				[DebuggerNonUserCode]
				public int WorldSno
				{
					get
					{
						bool flag = (this._hasBits0 & 2) != 0;
						int worldSnoDefaultValue;
						if (flag)
						{
							worldSnoDefaultValue = this.worldSno_;
						}
						else
						{
							worldSnoDefaultValue = LoadingCompleted.Types.LocationInfo.WorldSnoDefaultValue;
						}
						return worldSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 2;
						this.worldSno_ = value;
					}
				}

				// Token: 0x17003B10 RID: 15120
				// (get) Token: 0x0600E794 RID: 59284 RVA: 0x004DBE64 File Offset: 0x004DA064
				[DebuggerNonUserCode]
				public bool HasWorldSno
				{
					get
					{
						return (this._hasBits0 & 2) != 0;
					}
				}

				// Token: 0x0600E795 RID: 59285 RVA: 0x004DBE81 File Offset: 0x004DA081
				[DebuggerNonUserCode]
				public void ClearWorldSno()
				{
					this._hasBits0 &= -3;
				}

				// Token: 0x17003B11 RID: 15121
				// (get) Token: 0x0600E796 RID: 59286 RVA: 0x004DBE94 File Offset: 0x004DA094
				// (set) Token: 0x0600E797 RID: 59287 RVA: 0x004DBEB5 File Offset: 0x004DA0B5
				[DebuggerNonUserCode]
				public string WorldName
				{
					get
					{
						return this.worldName_ ?? LoadingCompleted.Types.LocationInfo.WorldNameDefaultValue;
					}
					set
					{
						this.worldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x17003B12 RID: 15122
				// (get) Token: 0x0600E798 RID: 59288 RVA: 0x004DBECC File Offset: 0x004DA0CC
				[DebuggerNonUserCode]
				public bool HasWorldName
				{
					get
					{
						return this.worldName_ != null;
					}
				}

				// Token: 0x0600E799 RID: 59289 RVA: 0x004DBEE7 File Offset: 0x004DA0E7
				[DebuggerNonUserCode]
				public void ClearWorldName()
				{
					this.worldName_ = null;
				}

				// Token: 0x17003B13 RID: 15123
				// (get) Token: 0x0600E79A RID: 59290 RVA: 0x004DBEF4 File Offset: 0x004DA0F4
				// (set) Token: 0x0600E79B RID: 59291 RVA: 0x004DBF25 File Offset: 0x004DA125
				[DebuggerNonUserCode]
				public int SceneSno
				{
					get
					{
						bool flag = (this._hasBits0 & 4) != 0;
						int sceneSnoDefaultValue;
						if (flag)
						{
							sceneSnoDefaultValue = this.sceneSno_;
						}
						else
						{
							sceneSnoDefaultValue = LoadingCompleted.Types.LocationInfo.SceneSnoDefaultValue;
						}
						return sceneSnoDefaultValue;
					}
					set
					{
						this._hasBits0 |= 4;
						this.sceneSno_ = value;
					}
				}

				// Token: 0x17003B14 RID: 15124
				// (get) Token: 0x0600E79C RID: 59292 RVA: 0x004DBF40 File Offset: 0x004DA140
				[DebuggerNonUserCode]
				public bool HasSceneSno
				{
					get
					{
						return (this._hasBits0 & 4) != 0;
					}
				}

				// Token: 0x0600E79D RID: 59293 RVA: 0x004DBF5D File Offset: 0x004DA15D
				[DebuggerNonUserCode]
				public void ClearSceneSno()
				{
					this._hasBits0 &= -5;
				}

				// Token: 0x17003B15 RID: 15125
				// (get) Token: 0x0600E79E RID: 59294 RVA: 0x004DBF70 File Offset: 0x004DA170
				// (set) Token: 0x0600E79F RID: 59295 RVA: 0x004DBF91 File Offset: 0x004DA191
				[DebuggerNonUserCode]
				public string SceneName
				{
					get
					{
						return this.sceneName_ ?? LoadingCompleted.Types.LocationInfo.SceneNameDefaultValue;
					}
					set
					{
						this.sceneName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
					}
				}

				// Token: 0x17003B16 RID: 15126
				// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x004DBFA8 File Offset: 0x004DA1A8
				[DebuggerNonUserCode]
				public bool HasSceneName
				{
					get
					{
						return this.sceneName_ != null;
					}
				}

				// Token: 0x0600E7A1 RID: 59297 RVA: 0x004DBFC3 File Offset: 0x004DA1C3
				[DebuggerNonUserCode]
				public void ClearSceneName()
				{
					this.sceneName_ = null;
				}

				// Token: 0x17003B17 RID: 15127
				// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x004DBFD0 File Offset: 0x004DA1D0
				// (set) Token: 0x0600E7A3 RID: 59299 RVA: 0x004DC001 File Offset: 0x004DA201
				[DebuggerNonUserCode]
				public int GridX
				{
					get
					{
						bool flag = (this._hasBits0 & 8) != 0;
						int gridXDefaultValue;
						if (flag)
						{
							gridXDefaultValue = this.gridX_;
						}
						else
						{
							gridXDefaultValue = LoadingCompleted.Types.LocationInfo.GridXDefaultValue;
						}
						return gridXDefaultValue;
					}
					set
					{
						this._hasBits0 |= 8;
						this.gridX_ = value;
					}
				}

				// Token: 0x17003B18 RID: 15128
				// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x004DC01C File Offset: 0x004DA21C
				[DebuggerNonUserCode]
				public bool HasGridX
				{
					get
					{
						return (this._hasBits0 & 8) != 0;
					}
				}

				// Token: 0x0600E7A5 RID: 59301 RVA: 0x004DC039 File Offset: 0x004DA239
				[DebuggerNonUserCode]
				public void ClearGridX()
				{
					this._hasBits0 &= -9;
				}

				// Token: 0x17003B19 RID: 15129
				// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x004DC04C File Offset: 0x004DA24C
				// (set) Token: 0x0600E7A7 RID: 59303 RVA: 0x004DC07E File Offset: 0x004DA27E
				[DebuggerNonUserCode]
				public int GridY
				{
					get
					{
						bool flag = (this._hasBits0 & 16) != 0;
						int gridYDefaultValue;
						if (flag)
						{
							gridYDefaultValue = this.gridY_;
						}
						else
						{
							gridYDefaultValue = LoadingCompleted.Types.LocationInfo.GridYDefaultValue;
						}
						return gridYDefaultValue;
					}
					set
					{
						this._hasBits0 |= 16;
						this.gridY_ = value;
					}
				}

				// Token: 0x17003B1A RID: 15130
				// (get) Token: 0x0600E7A8 RID: 59304 RVA: 0x004DC098 File Offset: 0x004DA298
				[DebuggerNonUserCode]
				public bool HasGridY
				{
					get
					{
						return (this._hasBits0 & 16) != 0;
					}
				}

				// Token: 0x0600E7A9 RID: 59305 RVA: 0x004DC0B6 File Offset: 0x004DA2B6
				[DebuggerNonUserCode]
				public void ClearGridY()
				{
					this._hasBits0 &= -17;
				}

				// Token: 0x0600E7AA RID: 59306 RVA: 0x004DC0C8 File Offset: 0x004DA2C8
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return this.Equals(other as LoadingCompleted.Types.LocationInfo);
				}

				// Token: 0x0600E7AB RID: 59307 RVA: 0x004DC0E8 File Offset: 0x004DA2E8
				[DebuggerNonUserCode]
				public bool Equals(LoadingCompleted.Types.LocationInfo other)
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
							bool flag4 = this.MainMenu != other.MainMenu;
							if (flag4)
							{
								flag2 = false;
							}
							else
							{
								bool flag5 = this.WorldSno != other.WorldSno;
								if (flag5)
								{
									flag2 = false;
								}
								else
								{
									bool flag6 = this.WorldName != other.WorldName;
									if (flag6)
									{
										flag2 = false;
									}
									else
									{
										bool flag7 = this.SceneSno != other.SceneSno;
										if (flag7)
										{
											flag2 = false;
										}
										else
										{
											bool flag8 = this.SceneName != other.SceneName;
											if (flag8)
											{
												flag2 = false;
											}
											else
											{
												bool flag9 = this.GridX != other.GridX;
												if (flag9)
												{
													flag2 = false;
												}
												else
												{
													bool flag10 = this.GridY != other.GridY;
													flag2 = !flag10 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
										}
									}
								}
							}
						}
					}
					return flag2;
				}

				// Token: 0x0600E7AC RID: 59308 RVA: 0x004DC1F0 File Offset: 0x004DA3F0
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					int num = 1;
					bool hasMainMenu = this.HasMainMenu;
					if (hasMainMenu)
					{
						num ^= this.MainMenu.GetHashCode();
					}
					bool hasWorldSno = this.HasWorldSno;
					if (hasWorldSno)
					{
						num ^= this.WorldSno.GetHashCode();
					}
					bool hasWorldName = this.HasWorldName;
					if (hasWorldName)
					{
						num ^= this.WorldName.GetHashCode();
					}
					bool hasSceneSno = this.HasSceneSno;
					if (hasSceneSno)
					{
						num ^= this.SceneSno.GetHashCode();
					}
					bool hasSceneName = this.HasSceneName;
					if (hasSceneName)
					{
						num ^= this.SceneName.GetHashCode();
					}
					bool hasGridX = this.HasGridX;
					if (hasGridX)
					{
						num ^= this.GridX.GetHashCode();
					}
					bool hasGridY = this.HasGridY;
					if (hasGridY)
					{
						num ^= this.GridY.GetHashCode();
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num ^= this._unknownFields.GetHashCode();
					}
					return num;
				}

				// Token: 0x0600E7AD RID: 59309 RVA: 0x004DC2EC File Offset: 0x004DA4EC
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return JsonFormatter.ToDiagnosticString(this);
				}

				// Token: 0x0600E7AE RID: 59310 RVA: 0x004DC304 File Offset: 0x004DA504
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
					output.WriteRawMessage(this);
				}

				// Token: 0x0600E7AF RID: 59311 RVA: 0x004DC310 File Offset: 0x004DA510
				[DebuggerNonUserCode]
				void IBufferMessage.InternalWriteTo(ref WriteContext output)
				{
					bool hasMainMenu = this.HasMainMenu;
					if (hasMainMenu)
					{
						output.WriteRawTag(8);
						output.WriteBool(this.MainMenu);
					}
					bool hasWorldSno = this.HasWorldSno;
					if (hasWorldSno)
					{
						output.WriteRawTag(16);
						output.WriteSInt32(this.WorldSno);
					}
					bool hasWorldName = this.HasWorldName;
					if (hasWorldName)
					{
						output.WriteRawTag(26);
						output.WriteString(this.WorldName);
					}
					bool hasSceneSno = this.HasSceneSno;
					if (hasSceneSno)
					{
						output.WriteRawTag(32);
						output.WriteSInt32(this.SceneSno);
					}
					bool hasSceneName = this.HasSceneName;
					if (hasSceneName)
					{
						output.WriteRawTag(42);
						output.WriteString(this.SceneName);
					}
					bool hasGridX = this.HasGridX;
					if (hasGridX)
					{
						output.WriteRawTag(48);
						output.WriteInt32(this.GridX);
					}
					bool hasGridY = this.HasGridY;
					if (hasGridY)
					{
						output.WriteRawTag(56);
						output.WriteInt32(this.GridY);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						this._unknownFields.WriteTo(ref output);
					}
				}

				// Token: 0x0600E7B0 RID: 59312 RVA: 0x004DC430 File Offset: 0x004DA630
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					int num = 0;
					bool hasMainMenu = this.HasMainMenu;
					if (hasMainMenu)
					{
						num += 2;
					}
					bool hasWorldSno = this.HasWorldSno;
					if (hasWorldSno)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.WorldSno);
					}
					bool hasWorldName = this.HasWorldName;
					if (hasWorldName)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.WorldName);
					}
					bool hasSceneSno = this.HasSceneSno;
					if (hasSceneSno)
					{
						num += 1 + CodedOutputStream.ComputeSInt32Size(this.SceneSno);
					}
					bool hasSceneName = this.HasSceneName;
					if (hasSceneName)
					{
						num += 1 + CodedOutputStream.ComputeStringSize(this.SceneName);
					}
					bool hasGridX = this.HasGridX;
					if (hasGridX)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.GridX);
					}
					bool hasGridY = this.HasGridY;
					if (hasGridY)
					{
						num += 1 + CodedOutputStream.ComputeInt32Size(this.GridY);
					}
					bool flag = this._unknownFields != null;
					if (flag)
					{
						num += this._unknownFields.CalculateSize();
					}
					return num;
				}

				// Token: 0x0600E7B1 RID: 59313 RVA: 0x004DC528 File Offset: 0x004DA728
				[DebuggerNonUserCode]
				public void MergeFrom(LoadingCompleted.Types.LocationInfo other)
				{
					bool flag = other == null;
					if (!flag)
					{
						bool hasMainMenu = other.HasMainMenu;
						if (hasMainMenu)
						{
							this.MainMenu = other.MainMenu;
						}
						bool hasWorldSno = other.HasWorldSno;
						if (hasWorldSno)
						{
							this.WorldSno = other.WorldSno;
						}
						bool hasWorldName = other.HasWorldName;
						if (hasWorldName)
						{
							this.WorldName = other.WorldName;
						}
						bool hasSceneSno = other.HasSceneSno;
						if (hasSceneSno)
						{
							this.SceneSno = other.SceneSno;
						}
						bool hasSceneName = other.HasSceneName;
						if (hasSceneName)
						{
							this.SceneName = other.SceneName;
						}
						bool hasGridX = other.HasGridX;
						if (hasGridX)
						{
							this.GridX = other.GridX;
						}
						bool hasGridY = other.HasGridY;
						if (hasGridY)
						{
							this.GridY = other.GridY;
						}
						this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
					}
				}

				// Token: 0x0600E7B2 RID: 59314 RVA: 0x004DC612 File Offset: 0x004DA812
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
					input.ReadRawMessage(this);
				}

				// Token: 0x0600E7B3 RID: 59315 RVA: 0x004DC620 File Offset: 0x004DA820
				[DebuggerNonUserCode]
				void IBufferMessage.InternalMergeFrom(ref ParseContext input)
				{
					uint num;
					while ((num = input.ReadTag()) > 0U)
					{
						uint num2 = num;
						uint num3 = num2;
						if (num3 <= 26U)
						{
							if (num3 != 8U)
							{
								if (num3 != 16U)
								{
									if (num3 != 26U)
									{
										goto IL_0045;
									}
									this.WorldName = input.ReadString();
								}
								else
								{
									this.WorldSno = input.ReadSInt32();
								}
							}
							else
							{
								this.MainMenu = input.ReadBool();
							}
						}
						else if (num3 <= 42U)
						{
							if (num3 != 32U)
							{
								if (num3 != 42U)
								{
									goto IL_0045;
								}
								this.SceneName = input.ReadString();
							}
							else
							{
								this.SceneSno = input.ReadSInt32();
							}
						}
						else if (num3 != 48U)
						{
							if (num3 != 56U)
							{
								goto IL_0045;
							}
							this.GridY = input.ReadInt32();
						}
						else
						{
							this.GridX = input.ReadInt32();
						}
						continue;
						IL_0045:
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
				}

				// Token: 0x0400A492 RID: 42130
				private static readonly MessageParser<LoadingCompleted.Types.LocationInfo> _parser = new MessageParser<LoadingCompleted.Types.LocationInfo>(() => new LoadingCompleted.Types.LocationInfo());

				// Token: 0x0400A493 RID: 42131
				private UnknownFieldSet _unknownFields;

				// Token: 0x0400A494 RID: 42132
				private int _hasBits0;

				// Token: 0x0400A495 RID: 42133
				public const int MainMenuFieldNumber = 1;

				// Token: 0x0400A496 RID: 42134
				private static readonly bool MainMenuDefaultValue = false;

				// Token: 0x0400A497 RID: 42135
				private bool mainMenu_;

				// Token: 0x0400A498 RID: 42136
				public const int WorldSnoFieldNumber = 2;

				// Token: 0x0400A499 RID: 42137
				private static readonly int WorldSnoDefaultValue = 0;

				// Token: 0x0400A49A RID: 42138
				private int worldSno_;

				// Token: 0x0400A49B RID: 42139
				public const int WorldNameFieldNumber = 3;

				// Token: 0x0400A49C RID: 42140
				private static readonly string WorldNameDefaultValue = "";

				// Token: 0x0400A49D RID: 42141
				private string worldName_;

				// Token: 0x0400A49E RID: 42142
				public const int SceneSnoFieldNumber = 4;

				// Token: 0x0400A49F RID: 42143
				private static readonly int SceneSnoDefaultValue = 0;

				// Token: 0x0400A4A0 RID: 42144
				private int sceneSno_;

				// Token: 0x0400A4A1 RID: 42145
				public const int SceneNameFieldNumber = 5;

				// Token: 0x0400A4A2 RID: 42146
				private static readonly string SceneNameDefaultValue = "";

				// Token: 0x0400A4A3 RID: 42147
				private string sceneName_;

				// Token: 0x0400A4A4 RID: 42148
				public const int GridXFieldNumber = 6;

				// Token: 0x0400A4A5 RID: 42149
				private static readonly int GridXDefaultValue = 0;

				// Token: 0x0400A4A6 RID: 42150
				private int gridX_;

				// Token: 0x0400A4A7 RID: 42151
				public const int GridYFieldNumber = 7;

				// Token: 0x0400A4A8 RID: 42152
				private static readonly int GridYDefaultValue = 0;

				// Token: 0x0400A4A9 RID: 42153
				private int gridY_;
			}
		}
	}
}

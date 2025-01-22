using System;
using System.Runtime.CompilerServices;
using Roy_T.AStar.Graphs;
using Roy_T.AStar.Primitives;

namespace Roy_T.AStar.Paths
{
	// Token: 0x020008E9 RID: 2281
	internal sealed class PathFinderNode : IComparable<PathFinderNode>
	{
		// Token: 0x0600B719 RID: 46873 RVA: 0x002D7866 File Offset: 0x002D5A66
		public PathFinderNode(INode node, Duration durationSoFar, Duration expectedRemainingTime)
		{
			this.Node = node;
			this.DurationSoFar = durationSoFar;
			this.ExpectedRemainingTime = expectedRemainingTime;
			this.ExpectedTotalTime = this.DurationSoFar + this.ExpectedRemainingTime;
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600B71A RID: 46874 RVA: 0x002D789C File Offset: 0x002D5A9C
		public INode Node { get; }

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600B71B RID: 46875 RVA: 0x002D78A4 File Offset: 0x002D5AA4
		public Duration DurationSoFar { get; }

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x002D78AC File Offset: 0x002D5AAC
		public Duration ExpectedRemainingTime { get; }

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600B71D RID: 46877 RVA: 0x002D78B4 File Offset: 0x002D5AB4
		public Duration ExpectedTotalTime { get; }

		// Token: 0x0600B71E RID: 46878 RVA: 0x002D78BC File Offset: 0x002D5ABC
		public int CompareTo(PathFinderNode other)
		{
			return this.ExpectedTotalTime.CompareTo(other.ExpectedTotalTime);
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x002D78E0 File Offset: 0x002D5AE0
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 3);
			defaultInterpolatedStringHandler.AppendLiteral("\ud83d\udccd{");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Node.Position.X);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Node.Position.Y);
			defaultInterpolatedStringHandler.AppendLiteral("}, ⏱~");
			defaultInterpolatedStringHandler.AppendFormatted<Duration>(this.ExpectedTotalTime);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}

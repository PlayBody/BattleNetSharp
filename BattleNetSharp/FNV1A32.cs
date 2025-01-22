using System;
using System.Security.Cryptography;
using System.Text;

namespace BattleNetSharp
{
	// Token: 0x02000AEE RID: 2798
	public class FNV1A32 : HashAlgorithm
	{
		// Token: 0x0600BD5B RID: 48475 RVA: 0x0048547D File Offset: 0x0048367D
		public FNV1A32()
		{
			this.HashSizeValue = 32;
			this.Initialize();
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x00485496 File Offset: 0x00483696
		public override void Initialize()
		{
			this._hash = 2166136261U;
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x004854A4 File Offset: 0x004836A4
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
			for (int i = 0; i < cbSize; i++)
			{
				this._hash = (this._hash ^ (uint)array[ibStart + i]) * 16777619U;
			}
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x004854DC File Offset: 0x004836DC
		protected override byte[] HashFinal()
		{
			return BitConverter.GetBytes(this._hash);
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x004854FC File Offset: 0x004836FC
		public new static uint Hash(string val)
		{
			return BitConverter.ToUInt32(FNV1A32.Instance.ComputeHash(Encoding.UTF8.GetBytes(val)));
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x00485530 File Offset: 0x00483730
		public new static uint Hash(byte[] val)
		{
			return BitConverter.ToUInt32(FNV1A32.Instance.ComputeHash(val));
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x00485558 File Offset: 0x00483758
		public new static uint Hash(int val)
		{
			return BitConverter.ToUInt32(FNV1A32.Instance.ComputeHash(BitConverter.GetBytes(val)));
		}

		// Token: 0x0400915E RID: 37214
		protected const uint FNV32_PRIME = 16777619U;

		// Token: 0x0400915F RID: 37215
		protected const uint FNV32_OFFSETBASIS = 2166136261U;

		// Token: 0x04009160 RID: 37216
		private uint _hash;

		// Token: 0x04009161 RID: 37217
		private static FNV1A32 Instance = new FNV1A32();
	}
}

using System;
using System.Linq;
using System.Security.Cryptography;
using Fenris.Online;
using Google.Protobuf;

namespace BattleNetSharp
{
	// Token: 0x02000AF1 RID: 2801
	public class Crypto
	{
		// Token: 0x0600BD6B RID: 48491 RVA: 0x00485D90 File Offset: 0x00483F90
		public Crypto()
		{
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x00485DBC File Offset: 0x00483FBC
		public Crypto(byte[] key, byte[] nonce)
		{
			this.Key = key;
			this.Nonce = nonce;
			this.Crypt = new AesGcm(this.Key);
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x00485E10 File Offset: 0x00484010
		public Crypto(byte[] buffer)
		{
			Array.Copy(buffer, 0, this.Nonce, 0, this.Nonce.Length);
			Array.Copy(buffer, 8, this.Key, 0, this.Key.Length);
			this.Crypt = new AesGcm(this.Key);
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x00485E84 File Offset: 0x00484084
		public byte[] IV
		{
			get
			{
				return this.Nonce.ToArray<byte>().Concat(BitConverter.GetBytes(this.Counter)).ToArray<byte>();
			}
		}

		// Token: 0x0600BD6F RID: 48495 RVA: 0x00485EB8 File Offset: 0x004840B8
		public static byte[] Encrypt(byte[] data, byte[] modulus = null, byte[] exponent = null)
		{
			byte[] array;
			using (RSA rsa = RSA.Create(2048))
			{
				bool flag = modulus != null;
				if (flag)
				{
					rsa.ImportParameters(new RSAParameters
					{
						Modulus = modulus.ToArray<byte>(),
						Exponent = exponent.ToArray<byte>()
					});
				}
				else
				{
					int num;
					rsa.ImportRSAPrivateKey(new ReadOnlySpan<byte>(Convert.FromBase64String(Crypto.rsaKey)), out num);
				}
				array = rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
			}
			return array;
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x00485F4C File Offset: 0x0048414C
		public static byte[] Decrypt(byte[] data)
		{
			byte[] array;
			using (RSA rsa = RSA.Create(2048))
			{
				int num;
				rsa.ImportRSAPrivateKey(new ReadOnlySpan<byte>(Convert.FromBase64String(Crypto.rsaKey)), out num);
				array = rsa.Decrypt(data, RSAEncryptionPadding.Pkcs1);
			}
			return array;
		}

		// Token: 0x04009163 RID: 37219
		public byte[] Key = new byte[32];

		// Token: 0x04009164 RID: 37220
		public byte[] Nonce = new byte[8];

		// Token: 0x04009165 RID: 37221
		public uint Counter = 0U;

		// Token: 0x04009166 RID: 37222
		public AesGcm Crypt;

		// Token: 0x04009167 RID: 37223
		public static ConnectionEncryptionInfo OnlineCrypto = new ConnectionEncryptionInfo
		{
			Token = 1UL,
			PresharedKey = new PresharedKey
			{
				Modulus = ByteString.CopyFrom(ByteString.FromBase64("ltKXpyL6/usfaSI82mIGu/Pq5gBXMc0PQSR9VCYV3XuFpcuMslt2QhFc92spUOYndWi+76vML0n/H5RnKw5Or9hGGUNw+efXhbwG9qPEywEFlKoWp9Me8JGlJaiowpYTiGdY6UIMXD27A/JqgmOdqTiB7NKapG+eGQK7LPMSb10KRHVQnc+3Re5hySI1fqaATx0F4z6DRmIE4bEds6sDJN/i6z07sWsWolUluufNQ64wlVoIF+qriX8F6TUvmsM66n6owiB8jkPT/khbeNuW3Gz4cHEhPaJMDqyPGQ3MFGT+SLZoVmpXpZMmIzGYQejCdgV6MuDwmXmsTKfY2ykQmQ==").Reverse<byte>().ToArray<byte>()),
				Exponent = ByteString.CopyFrom(new byte[] { 1, 0, 1 })
			}
		};

		// Token: 0x04009168 RID: 37224
		private static string rsaKey = "MIIEowIBAAKCAQEAltKXpyL6/usfaSI82mIGu/Pq5gBXMc0PQSR9VCYV3XuFpcuMslt2QhFc92spUOYndWi+76vML0n/H5RnKw5Or9hGGUNw+efXhbwG9qPEywEFlKoWp9Me8JGlJaiowpYTiGdY6UIMXD27A/JqgmOdqTiB7NKapG+eGQK7LPMSb10KRHVQnc+3Re5hySI1fqaATx0F4z6DRmIE4bEds6sDJN/i6z07sWsWolUluufNQ64wlVoIF+qriX8F6TUvmsM66n6owiB8jkPT/khbeNuW3Gz4cHEhPaJMDqyPGQ3MFGT+SLZoVmpXpZMmIzGYQejCdgV6MuDwmXmsTKfY2ykQmQIDAQABAoIBADQjAnetePSsVMRkKIMZhdhtPlNZ5Mp7Z32OXqC7Na3FqHKixbVWNrAqDmgdLEAh/5vvpKl3SvNB8iZ5h5xzqrHQ4pKTJLfO9Ervr7yM6ld+t+4nSgOj0Ls6rcsx3Xy+omvxxeOEiH9Oe5qmrzj5tKOtvAQg3YJgb1eYARpNwJ6sFCeNervgoyoKXb9nv+iCy3gnIOEJ5LkOsDZD+Nn1iMQuOBemg4WkYe7qcAdSbN0H7Y6beFERL0NcsYWepULtJEGP/YvP8sd92OTjRFOvhog26KIk5OabkX04YyxOkmY+S5FAaEiqXkfVFJigRLtl1UrghjlvOiJOXdMbcFwJpZ0CgYEAwoUOT8kQsLhsJJgg6fpTb10o2vpLHR7a/grzyCVOD2SuZ7aKUcoZMm0RWb36lYG/Z+KMx//UFSNE4Pipj212TtAmm2I1woah00LS/xeRMp66vybcr2l1EF1Tl6SzMthMLCLzW9cKRwmOpwn/Kz22jfWPoeDpatOWtDz+alzLQHMCgYEAxn3sYmnJwpN1M4hWLTI72znQid9qjFlGws1tJgeEQaT4zxv9iVgJrajwJOBA6hC6w4Rb1XNXQNdimXA7lvA+DKwzYfrBGjLWMWGn8r+xIMttIFvylXl0nR+I2e5lZLEwuO5hl5ZuWT4/I2ccjnIDh0+c37MSy06H8lDB/g3L48MCgYBICRpJtb42k7WIv8XAoHFxlmBg57wVZq3W0puBDT+hN7nWsqT6sQsvv3BjeZVo9Im7oQxdrIIP6eXCIpQ4h2L+wNrrRC2Agnc/U0nsKgAdbObfjza+xyERFF62k8nBFJTw62iQJEysDgAEIBGdI9eNLtkoK7CFXSI8UTIulXq3vQKBgArAe3OBQ3qUvj6CXhiopfFkGlW9kmnz1A9tTUJIGfPsWcXuQDeWWz/a7NcyhpGnQlag7tCLJOjQQfkJyVCNxu6szUO7b4ZZxpx6K7zMgW3DVy/vix5pq9VvBdy4OynPJ1J9JzAs5+FRq93hEfztVB+aQmcjrhrxMBACK9/1I1w9AoGBAI5bpEpZJKCzoepsaZiOH2TxwJ/JxBDxc63DVwlxZE1i+vm092cytV0zgCNpg25l22JTtax8Lbmt8K8ekFjUxffwyTMiW9uszosj8T3I4YCZL9G7FFHUK4IfXPTou4VRAzGEnvIwW2InVYDWCt+m3mxeMECTltPtJjo+KtJz0vFh";
	}
}

using System;

namespace D2Data
{
	// Token: 0x02000941 RID: 2369
	public enum ItemAffixType
	{
		// Token: 0x040071F9 RID: 29177
		NotApplicable,
		// Token: 0x040071FA RID: 29178
		Prefix,
		// Token: 0x040071FB RID: 29179
		Suffix,
		// Token: 0x040071FC RID: 29180
		Inferior = 4,
		// Token: 0x040071FD RID: 29181
		InferiorPrefix,
		// Token: 0x040071FE RID: 29182
		Superior = 8,
		// Token: 0x040071FF RID: 29183
		SuperiorPrefix,
		// Token: 0x04007200 RID: 29184
		Magic = 16,
		// Token: 0x04007201 RID: 29185
		MagicPrefix,
		// Token: 0x04007202 RID: 29186
		MagicSuffix,
		// Token: 0x04007203 RID: 29187
		Rare = 32,
		// Token: 0x04007204 RID: 29188
		RarePrefix,
		// Token: 0x04007205 RID: 29189
		RareSuffix
	}
}

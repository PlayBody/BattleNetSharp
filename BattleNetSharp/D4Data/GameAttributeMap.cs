using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace D4Data
{
	// Token: 0x020008D1 RID: 2257
	public class GameAttributeMap
	{
		// Token: 0x0600B649 RID: 46665 RVA: 0x002D4F30 File Offset: 0x002D3130
		public bool Replicateable(GameAttribute attribute)
		{
			return attribute.Flags > (ReplicationFlags)0;
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x002D4F4C File Offset: 0x002D314C
		public string Serialize()
		{
			string text = "";
			foreach (KeyValuePair<GameAttributeMap.KeyId, GameAttributeValue> keyValuePair in this._attributeValues)
			{
				GameAttribute gameAttribute = GameAttribute.Attributes[keyValuePair.Key.Id];
				bool flag = text.Length > 0;
				if (flag)
				{
					text += ";";
				}
				GameAttributeValue gameAttributeValue = this.RawGetAttributeValue(gameAttribute, keyValuePair.Key.Key);
				string text2 = Convert.ToString(gameAttributeValue.ValueF);
				float num = 0f;
				bool flag2 = !float.TryParse(text2, out num);
				if (flag2)
				{
					text2 = "0.0";
					Console.WriteLine("Could not save ValueF to DB, saving 0 instead of {0}", keyValuePair.Value.ValueF);
				}
				text += string.Format("{0},{1}:{2}|{3}", new object[]
				{
					keyValuePair.Key.Id,
					keyValuePair.Key.Key,
					gameAttributeValue.Value,
					text2
				});
			}
			return text;
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x002D5094 File Offset: 0x002D3294
		public void FillBySerialized(string serializedGameAttributeMapCompressed)
		{
			this._attributeValues.Clear();
			bool flag = serializedGameAttributeMapCompressed == "";
			if (!flag)
			{
				string[] array = serializedGameAttributeMapCompressed.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = array;
				int i = 0;
				while (i < array2.Length)
				{
					string text = array2[i];
					try
					{
						string[] array3 = text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
						bool flag2 = array3.Length != 2;
						if (flag2)
						{
							Console.WriteLine("GA Deserializated error, skipping Bad Pair.");
						}
						else
						{
							string[] array4 = array3[1].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
							int num = int.Parse(array4[0].Trim());
							float num2;
							bool flag3 = !float.TryParse(array4[1].Trim(), out num2);
							if (flag3)
							{
								Console.WriteLine("Error Parsing ValueF");
							}
							string[] array5 = array3[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
							int num3 = int.Parse(array5[0].Trim());
							GameAttribute gameAttribute = GameAttribute.Attributes[num3];
							bool flag4 = gameAttribute.ScriptFunc != null && !gameAttribute.ScriptedAndSettable;
							if (!flag4)
							{
								int? num4 = null;
								bool flag5 = array5.Length > 1;
								if (flag5)
								{
									num4 = new int?(int.Parse(array5[1].Trim()));
								}
								GameAttributeValue gameAttributeValue = this.RawGetAttributeValue(gameAttribute, num4);
								gameAttributeValue.ValueF = num2;
								gameAttributeValue.Value = num;
								this.RawSetAttributeValue(gameAttribute, num4, gameAttributeValue);
							}
						}
					}
					catch
					{
					}
					IL_017C:
					i++;
					continue;
					goto IL_017C;
				}
			}
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x002D524C File Offset: 0x002D344C
		private GameAttributeValue GetAttributeValue(GameAttribute attribute, int? key)
		{
			bool flag = attribute.ScriptFunc != null;
			GameAttributeValue gameAttributeValue;
			if (flag)
			{
				gameAttributeValue = attribute.ScriptFunc(this, key);
			}
			else
			{
				gameAttributeValue = this.RawGetAttributeValue(attribute, key);
			}
			return gameAttributeValue;
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x002D5284 File Offset: 0x002D3484
		private GameAttributeValue RawGetAttributeValue(GameAttribute attribute, int? key)
		{
			GameAttributeMap.KeyId keyId;
			keyId.Id = attribute.Id;
			keyId.Key = key;
			GameAttributeValue gameAttributeValue;
			bool flag = this._attributeValues.TryGetValue(keyId, out gameAttributeValue);
			GameAttributeValue gameAttributeValue2;
			if (flag)
			{
				gameAttributeValue2 = gameAttributeValue;
			}
			else
			{
				gameAttributeValue2 = attribute._DefaultValue;
			}
			return gameAttributeValue2;
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x002D52C8 File Offset: 0x002D34C8
		private void SetAttributeValue(GameAttribute attribute, int? key, GameAttributeValue value)
		{
			bool flag = attribute.ScriptFunc != null && !attribute.ScriptedAndSettable;
			if (flag)
			{
				StackFrame stackFrame = new StackFrame(2, true);
			}
			bool flag2 = attribute.EncodingType == GameAttributeEncoding.IntMinMax;
			if (flag2)
			{
				bool flag3 = value.Value < attribute.Min.Value || value.Value > attribute.Max.Value;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException("GameAttribute." + attribute.Name.Replace(' ', '_'), string.Concat(new string[]
					{
						"Min: ",
						attribute.Min.Value.ToString(),
						" Max: ",
						attribute.Max.Value.ToString(),
						" Tried to set: ",
						value.Value.ToString()
					}));
				}
			}
			else
			{
				bool flag4 = attribute.EncodingType == GameAttributeEncoding.Float16;
				if (flag4)
				{
					bool flag5 = value.ValueF < -65536f || value.ValueF > 65536f;
					if (flag5)
					{
						throw new ArgumentOutOfRangeException("GameAttribute." + attribute.Name.Replace(' ', '_'), string.Concat(new string[]
						{
							"Min: ",
							(-65536f).ToString(),
							" Max ",
							65536f.ToString(),
							" Tried to set: ",
							value.ValueF.ToString()
						}));
					}
				}
			}
			this.RawSetAttributeValue(attribute, key, value);
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x002D5468 File Offset: 0x002D3668
		private void RawSetAttributeValue(GameAttribute attribute, int? key, GameAttributeValue value)
		{
			GameAttributeMap.KeyId keyId;
			keyId.Id = attribute.Id;
			keyId.Key = key;
			this._attributeValues[keyId] = value;
			bool flag = !this._changedAttributes.Contains(keyId);
			if (flag)
			{
				this._changedAttributes.Add(keyId);
			}
			bool flag2 = attribute.Dependents != null;
			if (flag2)
			{
				foreach (GameAttributeDependency gameAttributeDependency in attribute.Dependents)
				{
					bool isManualDependency = gameAttributeDependency.IsManualDependency;
					int? num;
					if (isManualDependency)
					{
						num = gameAttributeDependency.Key;
					}
					else
					{
						num = (gameAttributeDependency.UsesExplicitKey ? null : key);
					}
					bool flag3;
					if (!gameAttributeDependency.IsManualDependency && gameAttributeDependency.UsesExplicitKey)
					{
						int? key2 = gameAttributeDependency.Key;
						int? num2 = key;
						flag3 = (key2.GetValueOrDefault() == num2.GetValueOrDefault()) & (key2 != null == (num2 != null));
					}
					else
					{
						flag3 = true;
					}
					bool flag4 = flag3;
					if (flag4)
					{
						this.RawSetAttributeValue(gameAttributeDependency.Attribute, num, gameAttributeDependency.Attribute.ScriptFunc(this, num));
					}
				}
			}
		}

		// Token: 0x170037E9 RID: 14313
		public int this[GameAttributeI attribute]
		{
			get
			{
				return this.GetAttributeValue(attribute, null).Value;
			}
			set
			{
				this.SetAttributeValue(attribute, null, new GameAttributeValue(value));
			}
		}

		// Token: 0x170037EA RID: 14314
		public int this[GameAttributeI attribute, int? key]
		{
			get
			{
				return this.GetAttributeValue(attribute, key).Value;
			}
			set
			{
				this.SetAttributeValue(attribute, key, new GameAttributeValue(value));
			}
		}

		// Token: 0x170037EB RID: 14315
		public float this[GameAttributeF attribute]
		{
			get
			{
				return this.GetAttributeValue(attribute, null).ValueF;
			}
			set
			{
				this.SetAttributeValue(attribute, null, new GameAttributeValue(value));
			}
		}

		// Token: 0x170037EC RID: 14316
		public float this[GameAttributeF attribute, int? key]
		{
			get
			{
				return this.GetAttributeValue(attribute, key).ValueF;
			}
			set
			{
				this.SetAttributeValue(attribute, key, new GameAttributeValue(value));
			}
		}

		// Token: 0x170037ED RID: 14317
		public bool this[GameAttributeB attribute]
		{
			get
			{
				return this.GetAttributeValue(attribute, null).Value != 0;
			}
			set
			{
				this.SetAttributeValue(attribute, null, new GameAttributeValue(value ? 1 : 0));
			}
		}

		// Token: 0x170037EE RID: 14318
		public bool this[GameAttributeB attribute, int? key]
		{
			get
			{
				return this.GetAttributeValue(attribute, key).Value != 0;
			}
			set
			{
				this.SetAttributeValue(attribute, key, new GameAttributeValue(value ? 1 : 0));
			}
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x002D5754 File Offset: 0x002D3954
		public int _RawGetAttribute(GameAttributeI attribute, int? key)
		{
			return this.RawGetAttributeValue(attribute, key).Value;
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x002D5774 File Offset: 0x002D3974
		public float _RawGetAttribute(GameAttributeF attribute, int? key)
		{
			return this.RawGetAttributeValue(attribute, key).ValueF;
		}

		// Token: 0x0600B65E RID: 46686 RVA: 0x002D5794 File Offset: 0x002D3994
		public bool _RawGetAttribute(GameAttributeB attribute, int? key)
		{
			return this.RawGetAttributeValue(attribute, key).Value != 0;
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x002D57B8 File Offset: 0x002D39B8
		public IEnumerable<int> ActiveIds
		{
			get
			{
				return this._attributeValues.Select((KeyValuePair<GameAttributeMap.KeyId, GameAttributeValue> k) => k.Key.Id);
			}
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x002D57F4 File Offset: 0x002D39F4
		public int?[] AttributeKeys(GameAttribute ga)
		{
			return (from av in this._attributeValues
				where av.Key.Id == ga.Id
				select av.Key.Key).ToArray<int?>();
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x002D5854 File Offset: 0x002D3A54
		public void LogAll()
		{
			foreach (KeyValuePair<GameAttributeMap.KeyId, GameAttributeValue> keyValuePair in this._attributeValues)
			{
				Console.WriteLine("attribute {0}, {1} => {2}", GameAttribute.Attributes[keyValuePair.Key.Id].Name, keyValuePair.Key.Key, (GameAttribute.Attributes[keyValuePair.Key.Id] is GameAttributeF) ? keyValuePair.Value.ValueF : ((float)keyValuePair.Value.Value));
			}
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x002D5914 File Offset: 0x002D3B14
		public bool Contains(GameAttribute attr)
		{
			foreach (KeyValuePair<GameAttributeMap.KeyId, GameAttributeValue> keyValuePair in this._attributeValues)
			{
				bool flag = keyValuePair.Key.Id == attr.Id;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04006995 RID: 27029
		public HashSet<GameAttributeMap.KeyId> _changedAttributes = new HashSet<GameAttributeMap.KeyId>();

		// Token: 0x04006996 RID: 27030
		public Dictionary<GameAttributeMap.KeyId, GameAttributeValue> _attributeValues = new Dictionary<GameAttributeMap.KeyId, GameAttributeValue>();

		// Token: 0x020012F1 RID: 4849
		public struct KeyId
		{
			// Token: 0x0600DEBB RID: 57019 RVA: 0x004C21AC File Offset: 0x004C03AC
			public override bool Equals(object obj)
			{
				bool flag = obj is GameAttributeMap.KeyId;
				bool flag3;
				if (flag)
				{
					GameAttributeMap.KeyId keyId = (GameAttributeMap.KeyId)obj;
					bool flag2 = this.Key != null != (keyId.Key != null);
					if (flag2)
					{
						flag3 = false;
					}
					else
					{
						bool flag4 = this.Key != null && this.Key.Value != keyId.Key.Value;
						flag3 = !flag4 && this.Id == keyId.Id;
					}
				}
				else
				{
					flag3 = false;
				}
				return flag3;
			}

			// Token: 0x0600DEBC RID: 57020 RVA: 0x004C2240 File Offset: 0x004C0440
			public override int GetHashCode()
			{
				bool flag = this.Key != null;
				int num;
				if (flag)
				{
					num = this.Id | (this.Key.Value << 12);
				}
				else
				{
					num = this.Id;
				}
				return num;
			}

			// Token: 0x04009CC1 RID: 40129
			public int Id;

			// Token: 0x04009CC2 RID: 40130
			public int? Key;
		}
	}
}

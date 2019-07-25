using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Entity : MonoBehaviour {
    #region Variables
    protected string Name;
    protected int LV;
    protected Stats stats;
    #endregion

    public string GetName()
    {
        return Name;
    }

    public Stats GetStats() {
        return stats;
    }

    #region Constructor
    public void Init(string name, int lv,
                  int str, int dex, int agi, int iNt, int mnd, int vit, int luk) {
        Name = name;
        stats.STR = str;
        if (stats.STR < 1) stats.STR = 1;
        stats.DEX = dex;
        if (stats.DEX < 1) stats.DEX = 1;
        stats.AGI = agi;
        if (stats.AGI < 1) stats.AGI = 1;
        stats.INT = iNt;
        if (stats.INT < 1) stats.INT = 1;
        stats.MND = mnd;
        if (stats.MND < 1) stats.MND = 1;
        stats.VIT = vit;
        if (stats.VIT < 1) stats.VIT = 1;
        stats.LUK = luk;
        if (stats.LUK < 1) stats.LUK = 1;

        stats.HP = stats.VIT;
        stats.MP = stats.INT;

        stats.basePDMG = (int)Mathf.Ceil((float)stats.STR * 0.1f);
        if (stats.STR > 9)
            stats.basePDMG += 1;

        stats.baseDDMG = (int)Mathf.Ceil((float)stats.DEX * 0.1f);
        if (stats.DEX > 9)
            stats.baseDDMG += 1;

        stats.baseMDMG = (int)Mathf.Ceil((float)stats.INT * 0.1f);
        if (stats.INT > 9)
            stats.baseMDMG += 1;

        stats.basePDEF = (int)Mathf.Ceil(((float)stats.VIT * 0.1f) + (float)stats.STR * 0.05f);
        if (stats.VIT > 9)
            stats.basePDEF += 1;

        stats.baseMDEF = (int)Mathf.Ceil(((float)stats.MND * 0.1f) + (float)stats.INT * 0.05f);
        if (stats.MND > 9)
            stats.baseMDEF += 1;
    }
    #endregion

    #region GetDamage
    public void GetPhysicalDamage(int damage) {
        if (damage < 0)
            return;

        stats.HP -= (damage / stats.basePDEF);

        if (stats.HP < 0)
            stats.HP = 0;
    }

    public void GetMagicalDamage(int damage) {
        if (damage < 0)
            return;

        stats.HP -= (damage / stats.baseMDEF);

        if (stats.HP < 0)
            stats.HP = 0;
    }
    #endregion

    #region Attacks
    public int MeleAttack() {
        return stats.basePDMG * stats.STR;
    }

    public int RangeAttack() {
        return stats.baseDDMG * stats.DEX;
    }

    public int MagicAttack() {
        return stats.baseMDMG * stats.INT;
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoManager : MonoBehaviour {
    public static PlayerInfoManager instance;
    public Text NameText;
    public Text HPText;
    public Text MPText;
    public Text STRText;
    public Text VITText;
    public Text DEXText;
    public Text AGIText;
    public Text INTText;
    public Text MNDText;
    public Text LUKText;

    void Awake() {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    
    public void SetTexts(string name, Stats stats) {
        NameText.text = name;
        HPText.text = "HP " + stats.HP.ToString();
        MPText.text = "MP " + stats.MP.ToString();
        STRText.text = "STR " + stats.STR.ToString();
        VITText.text = "VIT " + stats.VIT.ToString();
        DEXText.text = "DEX " + stats.DEX.ToString();
        AGIText.text = "AGI " + stats.AGI.ToString();
        INTText.text = "INT " + stats.INT.ToString();
        MNDText.text = "MND " + stats.MND.ToString();
        LUKText.text = "LUK " + stats.LUK.ToString();
}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleGameObj : MonoBehaviour {
    public GameObject GameObj;
    //public Text str, stm, vit, intel, agi, spr;

    public void switchOff() {
        GameObj.SetActive(false);
        GameInformation.quest[1] = 255;
        //Debug.Log(str.text);
        /*GameInformation.Strength = (byte)int.Parse(str.text);
        Debug.Log(stm.text);
        GameInformation.Stamina = (byte)int.Parse(stm.text);
        GameInformation.Vitality = (byte)int.Parse(vit.text);
        GameInformation.Intelect = (byte)int.Parse(intel.text);
        GameInformation.Agility = (byte)int.Parse(agi.text);
        GameInformation.Spirit = (byte)int.Parse(spr.text);*/
        SaveInformation.SaveNameBioGender();
        SaveInformation.SaveStatsInformation();
    }
    public void switchOn() { GameObj.SetActive(true); }
}

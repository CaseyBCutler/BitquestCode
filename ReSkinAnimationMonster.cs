using UnityEngine;
using System.Collections;

public class ReSkinAnimationMonster : MonoBehaviour {
    public string spriteSheetName = "Base Male";
    public int num = 0;
    // Use this for initialization

    void LateUpdate() {
        SetSprite();
    }
    private void SetSprite() {
        //Debug.Log("Sprite Name1: " + GameInformation.SpriteString);
        if(!string.IsNullOrEmpty(BattleStateMachine.monsters[num].SpriteModel)) {
            spriteSheetName = BattleStateMachine.monsters[num].SpriteModel;
            //Debug.Log("Sprite Name2: " + GameInformation.SpriteString);
        }
        var subSprites = Resources.LoadAll<Sprite>("SpriteSheets/" + spriteSheetName);
        foreach(SpriteRenderer rend in GetComponentsInChildren<SpriteRenderer>()) {
            string spriteName = rend.sprite.name;
            foreach(Sprite spriteFile in subSprites) {
                if(spriteFile.name == spriteName) {
                    rend.sprite = spriteFile;
                }
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class ReSkinAnimationPlayer : MonoBehaviour {
    public string spriteSheetName;
    // Use this for initialization

    void LateUpdate() {
        SetSprite();
    }
    private void SetSprite() {
        //Debug.Log("Sprite Name1: " + GameInformation.SpriteString);
        if(!string.IsNullOrEmpty(GameInformation.SpriteString)) {
            spriteSheetName = GameInformation.SpriteString;
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

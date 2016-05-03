using UnityEngine;
using System.Collections;

public class AIs {
    public void ChooseSkillRnd() {
        float tempRnd = Random.value;
        if(tempRnd > .75f) {
            BattleStateMachine.usedSkill = new Attack();
        }
        else if(tempRnd > .25f) {
            BattleStateMachine.usedSkill = new GiantSlash();
        }
        else {
            BattleStateMachine.usedSkill = new Defend();
        }
    }
}

using InGame.Damages;
using Log;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame.Characters.Skills
{
    public class PowerAttack : SkillData
    {
        public override SkillType skillType => SkillType.PowerAttack;
        public override string skillName => "強攻撃";
        public override string skillExplane => "通常より強力な攻撃を行う";
        public override int consumeMP => 10;
        public override TargetType targetType => TargetType.Enemy;
        public override int priority => 0;
        public override bool IsTargetableDeadCharacter => false;

        private const float AttackMagnification = 1.1f;

        public override void ExecuteSkill(BaseCharacter actor, BaseCharacter target)
        {
            var attackValue = Mathf.CeilToInt(actor.characterStatus.AttackValue * AttackMagnification);
            var damage = new Damage(actor, attackValue, DamageType.HP);
            target.ApplyDamage(damage);
        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InGame.Characters
{
    public class CharacterHealth
    {
        public int currentHP { get; private set; }

        public bool IsDead => currentHP <= 0;

        private readonly int MaxHP;

        public CharacterHealth(int maxHP)
        {
            MaxHP = maxHP;
            currentHP = maxHP;
        }

        public void ApplyDamage(int damageValue)
        {
            if (damageValue < 0)
            {
                throw new ArgumentException("ダメージ値が0未満です");
            }
            currentHP -= damageValue;
            currentHP = Mathf.Clamp(currentHP, 0, MaxHP);
        }
    }
}


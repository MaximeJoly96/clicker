using UnityEngine;
using System.Collections;

namespace Clicker.Model
{
    public enum DamageType
    {
        Melee,
        Range
    }

    public enum DamageElement
    {
        Fire, Water, Earth, Air
    }

    public class CombatStats
    {
        private int _idCombatStats;
        private int _currentHealth;
        private int _maxHealth;
        private int _damage;
        private DamageType _damageType;
        private DamageElement _damageElement;
        private int _outOfCombatRegen;
    }
}

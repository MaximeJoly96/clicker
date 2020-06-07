using UnityEngine;
using System.Collections;

namespace Clicker.Model
{
    public class RaidUnit : PlayerUnit, IBattler
    {
        public CombatStats Stats => throw new System.NotImplementedException();
    }
}

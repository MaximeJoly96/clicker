using UnityEngine;
using System.Collections;

namespace Clicker.Model
{
    public class RaidEnemy : Unit, IBattler
    {
        public CombatStats Stats => throw new System.NotImplementedException();
    }
}

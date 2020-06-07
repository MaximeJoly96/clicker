using UnityEngine;
using System.Collections;

namespace Clicker.Model
{
    public interface IBattler
    {
        CombatStats Stats { get; }
    }
}


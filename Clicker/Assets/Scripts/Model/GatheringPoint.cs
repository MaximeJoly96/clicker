using UnityEngine;
using System.Collections.Generic;

namespace Clicker.Model
{
    public class GatheringPoint
    {
        private int _idGatheringPoint;
        private List<Worker> _workers;
        private int _maxWorkers;
        private float _yieldPerClick;
        private float _yieldPerSecond;
        private UpgradeCost _upgradeCost;
    }
}

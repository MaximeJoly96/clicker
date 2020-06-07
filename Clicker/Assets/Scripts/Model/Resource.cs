using UnityEngine;

namespace Clicker.Model
{
    public enum ResourceType
    {
        Wood,
        Gold,
        Iron,
        Stone,
        Coin,
        Fame
    }

    public class Resource
    {
        private readonly int _idResource;
        private readonly Sprite _icon;
        private readonly ResourceType _resourceType;

        public Resource(int id, Sprite icon, ResourceType type)
        {
            _idResource = id;
            _icon = icon;
            _resourceType = type;
        }
    }
}

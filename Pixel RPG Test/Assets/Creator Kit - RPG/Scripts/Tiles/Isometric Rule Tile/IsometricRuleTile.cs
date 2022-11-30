using System;

namespace UnityEngine
{
    public class IsometricRuleTile<T> : IsometricRuleTileOverride
    {
        public sealed override Type m_NeighborType { get { return typeof(T); } }
    }

    [Serializable]
    [CreateAssetMenu(fileName = "New Isometric Rule Tile", menuName = "Tiles/Isometric Rule Tile")]
    public class IsometricRuleTileOverride : RuleTile
    {
        // This has no differences with the RuleTile
    }
}

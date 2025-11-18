using System;

namespace Abilities
{
    public interface IAbilities
    {
        bool IsActive { get; }
        bool CanUse { get; }
        void Activate();
    }
}
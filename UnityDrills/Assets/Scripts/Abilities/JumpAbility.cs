using UnityEngine;

namespace Abilities
{
    [CreateAssetMenu(fileName = "JumpAbility", menuName = "Abilities/JumpAbility")]
    public class JumpAbility :ScriptableObject, IAbilities
    {
        [field: SerializeField] public float cooldown { get; private set; }
        
        public bool IsActive { get; }

        public bool CanUse
        {
            get => lastUsedTime + cooldown < Time.time;
        }

        private float lastUsedTime;

        public void Activate()
        {
            if (!CanUse)
            {
                Debug.LogWarning("Can't use JumpAbility");
                return;
            }
            lastUsedTime = Time.time;
            Debug.Log("I am JUMP!");
        }
    }
}
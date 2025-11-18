using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Abilities
{
    public class Player : MonoBehaviour
    {
        [SerializeField] public List<ScriptableObject> abilities;
        
        private InputSystem_Actions  actions;
        private IAbilities jumpAbility;
        private void Start()
        {
            actions = new InputSystem_Actions();
            actions.Enable();
            actions.Player.Jump.performed+=JumpOnperformed;
            jumpAbility = abilities[0] as IAbilities;
        }

        private void JumpOnperformed(InputAction.CallbackContext obj)
        {
            jumpAbility.Activate();
        }
    }
}
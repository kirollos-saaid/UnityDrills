using System;
using UnityEngine;

namespace Input
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager instance;
        
        public InputSystem_Actions Actions;

        private void Awake()
        {
            instance = this;
        }
        
        private void Start()
        {
            Actions = new InputSystem_Actions();
            Actions.Enable();
        }
    }
}
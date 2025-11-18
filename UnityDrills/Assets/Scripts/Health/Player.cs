using UnityEngine;
using UnityEngine.InputSystem;

namespace Health
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Health health;

        private InputSystem_Actions _inputAction;

        private void Start()
        {
            _inputAction = new InputSystem_Actions();
            _inputAction.Enable();
            _inputAction.UI.Click.performed += InputActionOnperformed;
        }

        private void InputActionOnperformed(InputAction.CallbackContext obj)
        {
            health.TakeDamage(5);
        }
    }
}
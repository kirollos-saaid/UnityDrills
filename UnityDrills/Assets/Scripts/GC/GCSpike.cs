using Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GC
{
    public class GCSpike : MonoBehaviour
    {
        [SerializeField] private Bullet bulletPrefab;

        private void Start()
        {
            InputManager.instance.Actions.Player.Attack.performed += OnAttackPerformed;
        }

        private void OnAttackPerformed(InputAction.CallbackContext obj)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation, transform);
        }
    }
}
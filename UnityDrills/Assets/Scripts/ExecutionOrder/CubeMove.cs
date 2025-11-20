using UnityEngine;
using UnityEngine.InputSystem;

namespace ExecutionOrder
{
    public class CubeMove : MonoBehaviour
    {
        [SerializeField] private float speed = 5;
        private Vector3 _movementDirection =  Vector3.zero;

        private void OnMove(InputValue context)
        {
            var movement = context.Get<Vector2>();
            _movementDirection = new Vector3(movement.x, 0, movement.y);
        }

        private void Update()
        {
            transform.Translate( _movementDirection* (Time.deltaTime * speed));
        }
        
    }
}
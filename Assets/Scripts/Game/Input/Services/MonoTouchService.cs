using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

namespace Game.Input.Services
{
    public class MonoTouchService : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] private float touchSpeed = 10f;

        [Header("References")] 
        [SerializeField] private Camera camera;

        private void Awake()
        {
            EnhancedTouchSupport.Enable();
        }

        private void Update()
        {
            var fingers = Touch.activeFingers;
            var touches = fingers.Select(value => value.currentTouch);
            var positions = touches.Select(value => camera.ScreenToWorldPoint(value.screenPosition));
            var previousPositions = touches.Select(value => camera.ScreenToWorldPoint(value.screenPosition - value.delta))
            var average = positions.Sum()
        }
    }
}
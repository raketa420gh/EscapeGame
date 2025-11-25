using Atomic.Elements;
using UnityEngine;

namespace EscapeGame.Gameplay
{
    public class MovementBehaviour : IGameEntityInit, IGameContextFixedTick
    {
        private IRequest<Vector3> _moveRequest;
        private IValue<float> _moveSpeed;
        private IVariable<Vector3> _position;
        
        public void Init(IGameEntity entity)
        {
            
        }

        public void FixedTick(IGameContext entity, float deltaTime)
        {
            if (_moveRequest.Consume(out Vector3 direction))
                _position.Value += direction * (_moveSpeed.Value * deltaTime);
        }
    }
}

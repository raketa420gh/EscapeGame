using Atomic.Elements;
using UnityEngine;

namespace EscapeGame.Gameplay
{
    public sealed class MovementBehaviour : IGameEntityInit, IGameEntityFixedTick
    {
        private IRequest<Vector3> _moveRequest;
        private IValue<float> _moveSpeed; 
        private IVariable<Vector3> _position;
        
        public void Init(IGameEntity entity)
        {
            _moveRequest = entity.GetMoveRequest();
            _moveSpeed = entity.GetMoveSpeed();
            _position = entity.GetPosition();
        }

        public void FixedTick(IGameEntity entity, float deltaTime)
        {
            if (_moveRequest.Consume(out Vector3 direction))
                _position.Value += direction * (_moveSpeed.Value * deltaTime);
        }
    }
}

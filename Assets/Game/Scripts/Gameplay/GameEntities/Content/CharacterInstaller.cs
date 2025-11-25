using Atomic.Elements;
using UnityEngine;

namespace EscapeGame.Gameplay
{
    public sealed class CharacterInstaller : GameEntityInstaller
    {
        [SerializeField] 
        private Transform _transform;
        
        [SerializeField]
        private Const<float> _moveSpeed;
        
        public override void Install(IGameEntity entity)
        {
            entity.AddMoveRequest(new Request<Vector3>());
            entity.AddMoveSpeed(_moveSpeed);
            entity.AddPosition(new TransformPositionVariable(_transform));
            
        }
    }
}
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EscapeGame.Gameplay
{
    public sealed class ItemInstaller : GameEntityInstaller
    {
        [SerializeField] 
        private Const<int> _id;

        [SerializeField]
        private Variable<float>  _pickupRadius = 1;

        [SerializeField]
        private Variable<bool>  _isPickable;
        
        [ShowInInspector,  ReadOnly]
        private Variable<bool>  _isPicked;

        public override void Install(IGameEntity entity)
        {
            entity.AddItemId(_id);
            entity.AddItemPickUpRequest(new Request<IGameEntity>());
            entity.AddPickupRadius(_pickupRadius);
            entity.AddIsPickable(_isPickable);
            entity.AddIsPicked(_isPicked);
            
            entity.AddBehaviour<ItemPickupBehaviour>();
        }
    }
}

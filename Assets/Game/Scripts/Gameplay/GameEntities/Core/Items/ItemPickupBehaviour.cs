using Atomic.Elements;
using UnityEngine;

namespace EscapeGame.Gameplay
{
    public sealed class ItemPickupBehaviour : IGameEntityInit, IGameEntityTick
    {
        private IRequest<IGameEntity> _itemPickupRequest;
        private IValue<bool> _isPickable;
        private IVariable<bool> _isPicked;
        private IValue<float> _pickupRadius;
        
        public void Init(IGameEntity entity)
        {
            _itemPickupRequest = entity.GetItemPickUpRequest();
            _isPickable = entity.GetIsPickable();
            _isPicked = entity.GetIsPicked();
            _pickupRadius = entity.GetPickupRadius();
        }

        public void Tick(IGameEntity entity, float deltaTime)
        {
            if (_isPicked.Value || !_isPickable.Value)
                return;

            if (_itemPickupRequest.Consume(out IGameEntity pickerEntity))
            {
                /*// Проверяем расстояние до собирающего объекта
                var pickerApi = new GameEntityAPI(pickerEntity);
                var itemApi = new GameEntityAPI(entity.GetReference());
                
                float distance = Vector3.Distance(pickerApi.GetPosition(), itemApi.GetPosition());*/
                
                /*if (distance <= _pickupRadius.Value)
                {
                    PickupItem(entity, pickerEntity);
                }*/
            }
        }

        private void PickupItem(IGameEntity itemEntity, IGameEntity pickerEntity)
        {
            _isPicked.Value = true;
            
            /*// Триггерим сбор предмета
            var itemApi = new GameEntityAPI(itemEntity.GetReference());
            itemApi.CollectItem(pickerEntity->GetId());
            
            Debug.Log($"Item picked up! Item ID: {itemApi.GetItemId()}");*/
        }
    }
}
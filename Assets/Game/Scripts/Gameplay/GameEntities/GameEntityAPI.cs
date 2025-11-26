/**
* Code generation. Don't modify! 
**/

using Atomic.Entities;
using static Atomic.Entities.EntityNames;
using System.Runtime.CompilerServices;
#if UNITY_EDITOR
using UnityEditor;
#endif
using EscapeGame.Gameplay;
using Atomic.Elements;
using UnityEngine;

namespace EscapeGame.Gameplay
{
#if UNITY_EDITOR
	[InitializeOnLoad]
#endif
	public static class GameEntityAPI
	{
		///Values
		public static readonly int Position; // IVariable<Vector3>
		public static readonly int MoveRequest; // IRequest<Vector3>
		public static readonly int MoveSpeed; // IValue<float>
		public static readonly int ItemId; // IValue<int>
		public static readonly int ItemPickUpRequest; // IRequest<IGameEntity>
		public static readonly int IsPickable; // IValue<bool>
		public static readonly int IsPicked; // IVariable<bool>
		public static readonly int PickupRadius; // IValue<float>

		static GameEntityAPI()
		{
			//Values
			Position = NameToId(nameof(Position));
			MoveRequest = NameToId(nameof(MoveRequest));
			MoveSpeed = NameToId(nameof(MoveSpeed));
			ItemId = NameToId(nameof(ItemId));
			ItemPickUpRequest = NameToId(nameof(ItemPickUpRequest));
			IsPickable = NameToId(nameof(IsPickable));
			IsPicked = NameToId(nameof(IsPicked));
			PickupRadius = NameToId(nameof(PickupRadius));
		}


		///Value Extensions

		#region Position

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<Vector3> GetPosition(this IGameEntity entity) => entity.GetValueUnsafe<IVariable<Vector3>>(Position);

		public static ref IVariable<Vector3> RefPosition(this IGameEntity entity) => ref entity.GetValueUnsafe<IVariable<Vector3>>(Position);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPosition(this IGameEntity entity, out IVariable<Vector3> value) => entity.TryGetValueUnsafe(Position, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPosition(this IGameEntity entity, IVariable<Vector3> value) => entity.AddValue(Position, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPosition(this IGameEntity entity) => entity.HasValue(Position);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPosition(this IGameEntity entity) => entity.DelValue(Position);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPosition(this IGameEntity entity, IVariable<Vector3> value) => entity.SetValue(Position, value);

		#endregion

		#region MoveRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<Vector3> GetMoveRequest(this IGameEntity entity) => entity.GetValueUnsafe<IRequest<Vector3>>(MoveRequest);

		public static ref IRequest<Vector3> RefMoveRequest(this IGameEntity entity) => ref entity.GetValueUnsafe<IRequest<Vector3>>(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveRequest(this IGameEntity entity, out IRequest<Vector3> value) => entity.TryGetValueUnsafe(MoveRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.AddValue(MoveRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveRequest(this IGameEntity entity) => entity.HasValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveRequest(this IGameEntity entity) => entity.DelValue(MoveRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveRequest(this IGameEntity entity, IRequest<Vector3> value) => entity.SetValue(MoveRequest, value);

		#endregion

		#region MoveSpeed

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetMoveSpeed(this IGameEntity entity) => entity.GetValueUnsafe<IValue<float>>(MoveSpeed);

		public static ref IValue<float> RefMoveSpeed(this IGameEntity entity) => ref entity.GetValueUnsafe<IValue<float>>(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMoveSpeed(this IGameEntity entity, out IValue<float> value) => entity.TryGetValueUnsafe(MoveSpeed, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddMoveSpeed(this IGameEntity entity, IValue<float> value) => entity.AddValue(MoveSpeed, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMoveSpeed(this IGameEntity entity) => entity.HasValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMoveSpeed(this IGameEntity entity) => entity.DelValue(MoveSpeed);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMoveSpeed(this IGameEntity entity, IValue<float> value) => entity.SetValue(MoveSpeed, value);

		#endregion

		#region ItemId

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<int> GetItemId(this IGameEntity entity) => entity.GetValueUnsafe<IValue<int>>(ItemId);

		public static ref IValue<int> RefItemId(this IGameEntity entity) => ref entity.GetValueUnsafe<IValue<int>>(ItemId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetItemId(this IGameEntity entity, out IValue<int> value) => entity.TryGetValueUnsafe(ItemId, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddItemId(this IGameEntity entity, IValue<int> value) => entity.AddValue(ItemId, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasItemId(this IGameEntity entity) => entity.HasValue(ItemId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelItemId(this IGameEntity entity) => entity.DelValue(ItemId);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemId(this IGameEntity entity, IValue<int> value) => entity.SetValue(ItemId, value);

		#endregion

		#region ItemPickUpRequest

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IRequest<IGameEntity> GetItemPickUpRequest(this IGameEntity entity) => entity.GetValueUnsafe<IRequest<IGameEntity>>(ItemPickUpRequest);

		public static ref IRequest<IGameEntity> RefItemPickUpRequest(this IGameEntity entity) => ref entity.GetValueUnsafe<IRequest<IGameEntity>>(ItemPickUpRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetItemPickUpRequest(this IGameEntity entity, out IRequest<IGameEntity> value) => entity.TryGetValueUnsafe(ItemPickUpRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddItemPickUpRequest(this IGameEntity entity, IRequest<IGameEntity> value) => entity.AddValue(ItemPickUpRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasItemPickUpRequest(this IGameEntity entity) => entity.HasValue(ItemPickUpRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelItemPickUpRequest(this IGameEntity entity) => entity.DelValue(ItemPickUpRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemPickUpRequest(this IGameEntity entity, IRequest<IGameEntity> value) => entity.SetValue(ItemPickUpRequest, value);

		#endregion

		#region IsPickable

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<bool> GetIsPickable(this IGameEntity entity) => entity.GetValueUnsafe<IValue<bool>>(IsPickable);

		public static ref IValue<bool> RefIsPickable(this IGameEntity entity) => ref entity.GetValueUnsafe<IValue<bool>>(IsPickable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsPickable(this IGameEntity entity, out IValue<bool> value) => entity.TryGetValueUnsafe(IsPickable, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddIsPickable(this IGameEntity entity, IValue<bool> value) => entity.AddValue(IsPickable, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsPickable(this IGameEntity entity) => entity.HasValue(IsPickable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsPickable(this IGameEntity entity) => entity.DelValue(IsPickable);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsPickable(this IGameEntity entity, IValue<bool> value) => entity.SetValue(IsPickable, value);

		#endregion

		#region IsPicked

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IVariable<bool> GetIsPicked(this IGameEntity entity) => entity.GetValueUnsafe<IVariable<bool>>(IsPicked);

		public static ref IVariable<bool> RefIsPicked(this IGameEntity entity) => ref entity.GetValueUnsafe<IVariable<bool>>(IsPicked);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsPicked(this IGameEntity entity, out IVariable<bool> value) => entity.TryGetValueUnsafe(IsPicked, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddIsPicked(this IGameEntity entity, IVariable<bool> value) => entity.AddValue(IsPicked, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsPicked(this IGameEntity entity) => entity.HasValue(IsPicked);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsPicked(this IGameEntity entity) => entity.DelValue(IsPicked);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsPicked(this IGameEntity entity, IVariable<bool> value) => entity.SetValue(IsPicked, value);

		#endregion

		#region PickupRadius

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IValue<float> GetPickupRadius(this IGameEntity entity) => entity.GetValueUnsafe<IValue<float>>(PickupRadius);

		public static ref IValue<float> RefPickupRadius(this IGameEntity entity) => ref entity.GetValueUnsafe<IValue<float>>(PickupRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPickupRadius(this IGameEntity entity, out IValue<float> value) => entity.TryGetValueUnsafe(PickupRadius, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddPickupRadius(this IGameEntity entity, IValue<float> value) => entity.AddValue(PickupRadius, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPickupRadius(this IGameEntity entity) => entity.HasValue(PickupRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPickupRadius(this IGameEntity entity) => entity.DelValue(PickupRadius);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPickupRadius(this IGameEntity entity, IValue<float> value) => entity.SetValue(PickupRadius, value);

		#endregion
    }
}

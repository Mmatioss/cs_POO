using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] InputActionReference _attack;
    [SerializeField] Animator _animator;
    [SerializeField] Transform _transformComponentContainer;
    [SerializeField] BoxCollider _colliderAttack;
    [SerializeField, Range(0, 100)]
    float _attackRange;
    [SerializeField, Range(0, 100)]
    float _attackWidth;

    public event System.Action OnStartAttack;
    public event System.Action OnStopAttack;

    Coroutine AttackRoutine { get; set; }

    private void Start()
    {
        _attack.action.started += StartAttack;
        _attack.action.canceled += StopAttack;
        _colliderAttack.size = new Vector3(_attackWidth, 1, _attackRange);
        _colliderAttack.center = new Vector3(0, 0, _attackRange / 2-1);
    }

    private void OnDestroy()
    {
        _attack.action.started -= StartAttack;
        _attack.action.canceled -= StopAttack;
        
    }

    private void StartAttack(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        AttackRoutine = StartCoroutine(Attack());
        IEnumerator Attack()
        {
            OnStartAttack?.Invoke();
            while (true)
            {
                _animator.SetTrigger("Attack");
                _colliderAttack.enabled = true;
                yield return new WaitForSeconds(1f);
            }
        }
    }

    private void StopAttack(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnStopAttack?.Invoke();
        StopCoroutine(AttackRoutine);
        _colliderAttack.enabled = false;
    }
}

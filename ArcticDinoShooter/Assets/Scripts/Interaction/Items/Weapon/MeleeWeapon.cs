using UnityEngine;

public class MeleeWeapon : MonoBehaviour, Iusable
{
    [SerializeField]private Animator _animator;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Use()
    {
        print("hit");
        _animator.SetTrigger("Hit");
    }
}

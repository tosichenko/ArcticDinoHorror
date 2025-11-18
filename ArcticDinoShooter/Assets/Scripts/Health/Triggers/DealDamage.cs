using UnityEngine;

public class DealDamage : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter(Collider other)
    {
        MakeDamage(other.gameObject, _damage);
    }

    private void MakeDamage(GameObject _Character, int _damage)
    {
        if(_Character.GetComponent<IHealth>() != null)
        _Character.GetComponent<IHealth>().TakeDamage(_damage);
    }
}

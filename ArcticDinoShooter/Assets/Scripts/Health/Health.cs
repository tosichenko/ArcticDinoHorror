using UnityEngine;

public class Health : MonoBehaviour, IHealth
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _minHealth = 0;
    [SerializeField] private int _curentHealth;
    [SerializeField] private bool isDead = false;

    [SerializeField] private AudioSource _damagedSound;

    private void Awake()
    {
        _curentHealth = _maxHealth;
    }

    public int GetCurentHealth()
    {
        return _curentHealth;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    virtual public void HealthUp(int healthPoints)
    {
        _curentHealth += healthPoints;
        Debug.Log($"Уровень здоровья повышен на: {healthPoints}");
    }

    public void Kill()
    {
        _curentHealth = _minHealth;
        Death();
    }

    virtual public void Death()
    {
        print("Конец");
    }

    public void TakeDamage(int healthPoints)
    {
        _curentHealth -= healthPoints;

        if (!_damagedSound.isPlaying)
        {
            _damagedSound.Play();
        }

        if (_curentHealth <= _minHealth && !isDead)
        {
            Debug.Log("end");
            Death();
            isDead = true;
        }
        Debug.Log($"Уровень здоровья понижен на: {healthPoints}");
    }

    public void SetMaxHealth()
    {
        _curentHealth = _maxHealth;
        Debug.Log("Установлено максимальное здоровье");
    }

    public void SetMinHealth()
    {
        _curentHealth = _minHealth;
        Debug.Log("Установлено минимальное здоровье");
    }
}

public interface IHealth
{
    public void TakeDamage(int _damage);
    public void HealthUp(int _healthPoints);
    public int GetCurentHealth();
    public int GetMaxHealth();
    public void SetMaxHealth();
    public void SetMinHealth();
    public void Death();
    public void Kill();
}
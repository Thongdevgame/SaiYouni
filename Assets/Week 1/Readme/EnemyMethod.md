# Khai Báo Thêm 5 Biến Cho Class Enemy
	public int health;
	public int damage;
	public float speed;
	public bool isAlive;
	public Vector3 position;
## Mục Tiêu
Hướng dẫn này giúp bạn hiểu cách khai báo và triển khai thêm 5 biến cho class `Enemy` trong Unity C#.
Các biến này sẽ giúp quản lý các thuộc tính và trạng thái của kẻ địch trong trò chơi.

# Khai Báo Thêm 5 Phương Thức Cho Class Enemy
	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 0){
			Die();
			}
	}

	public void Attack(Player player)
	{
		if (isAlive){
			player.TakeDamage(damage);
		}
	}
	
	public void Move(Vector3 direction)
	{
		position += direction * speed * Time.deltaTime;
	}

	public void Die()
	{
		isAlive = false;
		// Thực hiện các hành động khi kẻ địch chết, như kích hoạt hiệu ứng, loại bỏ khỏi bản đồ, v.v.
	}

	public void Respawn(Vector3 newPosition)
	{
		position = newPosition;
		health = 100;  // Hồi đầy máu
		isAlive = true;
	}
## Mục Tiêu
Hướng dẫn này giúp bạn hiểu cách khai báo và triển khai thêm 5 phương thức cho class `Enemy` trong Unity C#.
Các phương thức này sẽ giúp quản lý hành vi của kẻ địch trong trò chơi.



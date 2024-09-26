# Agenda Phát Triển Game Week 1

## 1. Tìm Giá Trị Lớn Nhất Mà Int, Float và Double Trong Unity C# Có Thể Lưu Trữ
	a.Int
	- Giá trị lớn nhất: 2^31-1
	- int maxInt = int.maxValue
	b.Float
	- Giá trị lớn nhất: 3.4E+38
	- int maxFloat = float.maxValue
	c.Double
	- Giá trị lớn nhất: 1.8E+308
	- int maxDouble = double.maxValue

## 2. Nhờ AI Thiết Kế Ra Một Kế Hoạch Làm Game Trong 1 Tháng
https://actvneduvn-my.sharepoint.com/:w:/g/personal/ct060339_actvn_edu_vn/EYc2CY5PO7JHg18bdzdMdIMB3_C4L1-cNxvv9GMzdkj-9g?e=wuoDiW

## 3. Khai Báo Thêm 5 Methods Cho Class Enemy
	public void Move()
	public void Attack()
	public void TakeDamage(int damage)
	public void DetectPlayer()
	public void Die()

## 4. Khai Báo Thêm 5 Biến Cho Class Enemy
	public int health = 100;
	public float speed = 5.0f;
	public int attackPower = 10;
	public float detectionRange = 10.0f;
	public float attackCooldown = 2.0f;

## 5. Nhờ AI Giải Thích Câu Lệnh Này: `int[] scores = new int[10];`
	-Câu lệnh này tạo ra một mảng gồm 10 phần tử kiểu int,tất cả các phần tử ban đầu đều được gán giá trị là 0.
	-Bạn có thể truy cập các phần tử của mảng bằng chỉ số (index) từ 0 đến 9 (vì chỉ số của mảng trong C# bắt đầu từ 0).

## 6. Nhờ AI Giải Thích Về Rigidbody
	- Rigidbody trong Unity là một thành phần (component) được sử dụng để thêm tính năng vật lý vào đối tượng trong trò chơi.
	- Khi gắn Rigidbody vào một đối tượng, đối tượng đó sẽ chịu ảnh hưởng của các quy luật vật lý như trọng lực, lực đẩy, lực kéo, va chạm, và ma sát.
	-Các tính năng chính của Rigidbody:
		+ Trọng lực (Gravity):
			Nếu tùy chọn Use Gravity được bật, đối tượng sẽ chịu ảnh hưởng của trọng lực và sẽ rơi xuống đất nếu không có vật cản.
			Điều này mô phỏng hiện tượng trọng lực thực tế trong môi trường vật lý.
		+ Lực (Forces):
			Rigidbody cho phép bạn tác động lực lên đối tượng thông qua các phương thức như AddForce(). 
			Lực có thể được thêm vào theo nhiều hướng khác nhau để đẩy, kéo hoặc làm đối tượng di chuyển.
		+ Va chạm (Collisions):
			Khi đối tượng có Rigidbody, nó sẽ tương tác vật lý với các đối tượng khác có Collider.
			Khi va chạm xảy ra, Unity sẽ xử lý phản ứng vật lý giữa các đối tượng.
		+ Mô phỏng chuyển động thực tế:
			Unity tự động mô phỏng các chuyển động như gia tốc, tốc độ, quay, hoặc lực cản không khí khi Rigidbody được áp dụng, tạo ra hành vi tự nhiên hơn cho đối tượng.
		+ Kinematic Rigidbody:
			Nếu bạn bật thuộc tính Is Kinematic, Rigidbody sẽ không chịu ảnh hưởng của vật lý (như trọng lực hoặc lực), nhưng vẫn có thể được điều khiển qua các tập lệnh để di chuyển hoặc xoay mà không có tương tác vật lý tự động.
		+ Mass, Drag, Angular Drag:
			Mass (khối lượng): Điều khiển trọng lượng của đối tượng, ảnh hưởng đến mức độ chịu ảnh hưởng của lực.
			Drag (lực cản): Điều chỉnh mức độ giảm tốc độ chuyển động của đối tượng theo thời gian.
			Angular Drag (lực cản quay): Điều chỉnh mức độ giảm tốc độ quay của đối tượng.
	-Một số phương thức quan trọng của Rigidbody:
		+ AddForce(Vector3 force): Thêm một lực vào đối tượng để làm nó di chuyển theo hướng của vector lực.
		+ AddTorque(Vector3 torque): Thêm một lực xoay vào đối tượng để làm nó quay.
		+ MovePosition(Vector3 position): Di chuyển đối tượng tới vị trí mới mà không sử dụng lực vật lý.
		+ MoveRotation(Quaternion rotation): Xoay đối tượng tới góc quay mới.

## 7. Hỏi AI Cách Chia Lấy Dư Một Số Bất Kỳ
	-Trong lập trình, để lấy phần dư của phép chia, bạn có thể sử dụng toán tử % (modulo). Toán tử này trả về phần dư của phép chia giữa hai số.
	 Cách sử dụng chung như sau: int x = a % b
	- Trường hợp 1: Chia số nguyên
		int a = 10;
		int b = 3;
		int x = a % b;  
		Console.WriteLine(x);  // In ra: 1
	Trường hợp 2: Chia số âm
		int a = -10;
		int b = 3;
		int x = a % b;  
		Console.WriteLine(x);  // In ra: -1
	Trường hợp 3: Chia số thực
		double a = 10.5;
		double b = 3.2;
		double x = Math.IEEERemainder(a,b);  // Phần dư của 10.5 chia cho 3.2
		Console.WriteLine(x);  // In ra phần dư dưới dạng số thực

## 8. Ngoài Các Kiểu Dữ Liệu Đã Giới Thiệu, Kể Tên 5 Kiểu Dữ Liệu Khác Của Unity C#
	Các kiểu dữ liệu trong C#: int, long, float, double, bool, char, string
## 9. Ngoài Các Toán Tử Đã Giới Thiệu, Hãy Kể Tên 3 Toán Tử Khác
	- Toán tử số học: + - * /,....
	- Toán tử gán: =, +=,-=,....
	- Toán tử so sánh: ==, >=, <=, !=
	- Toán tử logic: &&, ||, !

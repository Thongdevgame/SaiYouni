# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
	- Trong Unity có 3 hàm mà Unity sẽ tự động gọi trong suốt quá trình chạy của ứng dụng.Các hàm này bao gồm:
		+ Start(): hàm này được gọi một lần khi đối tượng được kích hoạt lần đầu tiên,
				   thường được dùng để khởi tạo dữ liệu hoặc tráng thái của đối tượng trước khi trò chơi bắt đầu chạy
		+ Update(): được gọi một lần mỗi khung hình(frame) và thường được dùng để thực hiện các hành động diễn ra liên tục theo thời gian thực
					như kiểm tra đầu vào từ người chơi hoặc cập nhật vị trí của đối tượng
		+ Awake(): Được gọi ngay khi đối tượng được khởi tạo, trước cả Start(). 
				   Đây là nơi khởi động mọi giá trị và thành phần cần thiết trước khi đối tượng hoạt động trong trò chơi
## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau
	- Selection Sort
	- Bubble Sort
	- Insertion Sort
	- Merge Sort
	- Quick Sort
	- Heap sort

## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học
	- Trong buổi học đã sử dụng giải thuật sắp xếp chọn, mình sẽ trình bày thêm một giải thuật khác đó là sắp xếp hòa nhập(Merge Sort)
	- Ý tưởng: Hòa nhập 2 đường là phép hợp nhất 2 dãy khóa đã sắp xếp để ghép lại thành 1
		dãy khóa có kích thước bằng tổng kích thước 2 dãy khóa ban đầu và dãy khóa tạo
		thành cũng có thứ tự sắp xếp.
	- Nguyên tắc thực hiện: so sánh 2 khóa đứng đầu 2 dãy, chọn ra khóa nhỏ nhất đưa vào miền sắp xếp (1 dãy khóa phụ có kích thước bằng
		tổng kích thước 2 dãy khóa đầu ở vị trí thích hợp) sau đó khóa này bị loại ra khỏi
		dãy khóa chứa nó. Quá trình tiếp tục đến khi một trong 2 dãy khóa đã cạn. Khi đó
		chỉ cần chuyển toàn bộ dãy khóa còn lại vào miền sắp xếp là xong

		


## 4. Thực Hiện Random Cho Current HP

- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game.

## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.

## 6. Tìm Enemy Có Current HP Lớn Nhất

- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md

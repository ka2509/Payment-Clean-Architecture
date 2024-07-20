﻿# Payment-Clean-Architecture
https://www.notion.so/KLTN-2a5ca23b5a3248df9d15decd85d77704?showMoveTo=true&saveParent=true
1. Sinh viên có thể xem danh sách các môn học đã đăng ký ở kỳ hiện tại. (Api phía nhà trường)
2. Sinh viên có thể xem lịch học của các môn đã đăng ký. (Api phía nhà trường)
3. Sinh viên có thể xem lịch thi của các môn đã đăng ký. (Api phía nhà trường)
4. Sinh viên có thể xem điểm GPA của mình. (Api phía nhà trường)
5. Sinh viên có thể kiểm tra các khoản phí cần đóng và thực hiện đóng phí nếu có khoản nào chưa đóng. (Api phía nhà trường + Open Api từ phía cổng thanh toán trung gian)
6. Tích hợp AI để:
- Dựa vào điểm số hiện tại và số điểm mong muốn khi tốt nghiệp, đưa ra nhận xét, lời khuyên để đạt được điểm mong muốn. (Data điểm hiện tại lấy ở bên trên)
- Tổng hợp danh sách các môn có thể đăng ký ở kỳ sau và danh sách các thầy cô dạy các môn này, phân tích điểm từng môn của từng thầy cô chấm.
Đưa ra gợi ý nên đăng ký học môn nào của thầy cô nào ở kỳ sau để có thể đạt kết quả học tốt nhất.

Danh sách các môn có thể đăng ký ở kỳ sau được lấy dựa trên: 

- kỳ học sắp tới là kỳ nào
- học sinh thuộc lớp nào, ngành nào, khung chương tình đào tạo như nào
- sau đó lấy được các môn thuộc kỳ sắp tới của khung chương trình đào tạo, ngành, lớp đó (Lấy từ sổ tay học vụ của sinh viên mà nhà trường gửi, có thể tìm nguồn khác)
- sau khi có tên môn học thì tổng hợp ra danh sách thầy cô phụ trách bộ môn đấy (Lấy từ)
- sau đó lấy bảng điểm của môn đó của từng thầy cô (Lấy từ diemthiuet hiện tại đang sập )
- phân tích dữ liệu, thống kê ra tỷ lệ điểm F D C B A ⇒ kết luận (đưa vào 1 model)
- khi có kết luận tổng hợp của các thầy cô phụ trách môn đó ⇒ chọn ra top thầy cô điểm tốt nhất

Train model

1. Tạo được dataset làm input
2. Tham khảo các model tốt nhất trong task trên 
3. train
4. tích hợp vào app

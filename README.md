# Payment-Clean-Architecture
https://www.notion.so/KLTN-2a5ca23b5a3248df9d15decd85d77704?showMoveTo=true&saveParent=true
1. Sinh viên có thể xem danh sách các môn học đã đăng ký ở kỳ hiện tại. (Api phía nhà trường)
2. Sinh viên có thể xem lịch học của các môn đã đăng ký. (Api phía nhà trường)
3. Sinh viên có thể xem lịch thi của các môn đã đăng ký. (Api phía nhà trường)
4. Sinh viên có thể xem điểm GPA của mình. (Api phía nhà trường)
5. Sinh viên có thể kiểm tra các khoản phí cần đóng và thực hiện đóng phí nếu có khoản nào chưa đóng. (Api phía nhà trường + Open Api từ phía cổng thanh toán trung gian)
6. Tích hợp AI để:
- Dựa vào điểm số hiện tại và số điểm mong muốn khi tốt nghiệp, đưa ra nhận xét, lời khuyên để đạt được điểm mong muốn. (Data điểm hiện tại lấy ở bên trên) Khó về data, model NLP lấy trên paper
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

regression, recommendation, and possibly some natural language processing (NLP) techniques

Hướng giải quyết:

Nối 2 model Ai với nhau cho 2 task riêng:

- mình có gpa hiện tại rồi gpa mong muốn + số tín đã học + số tín cần học mình truyền qua 1 model xong output của nó sẽ là một số, số này tượng trưng cho tỷ lệ khả thi để đạt được cái gpa mong muốn. Xong mình lấy output đấy cho vào model nlp để đưa ra lời khuyên. (Vấn đề ở đây sẽ là, thứ nhất data để test và validate sẽ không có sẵn y output mà mình phải tự sinh ra data ⇒ không hợp lý thứ hai là module nlp khó)
- Tìm hiểu recommender lấy data là các môn mình đã học + điểm của mình trong các môn đó rồi model recommend các môn khác mà nó nghĩ mình sẽ có hứng thú và dễ điểm cao.
- ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
1. Bỏ task liên quan đến phân tích GPA, vì dữ liệu huấn luyện cần GPA của tất cả các sinh viên.
2. Task gợi ý môn học và giáo viên nên học vào kỳ sau, gồm các bước:
Crawl data:
- Lấy ra các comment của sinh viên trong các topic về review thầy cô bộ môn trong group fb SGUET(có thể sử dụng Facebook Graph Api hoặc kết hợp các thư viện khác như BeautifulSoup và Selenium để tự động thao tác với trình duyệt và lấy dữ liệu )
Dataset preparation:
- Tiền xử lý các comment để có dataset có thể là chuẩn hóa, tokenize, ...  sao cho phù hợp với mô hình sử dụng.
Model:
- Tham khảo các model NLP trên các paper và Hugging Face, đưa dataset bên trên qua model để đánh giá xem thầy cô dạy bộ môn đó là dễ hay khó dựa vào các comment của sinh viên.
Output:
- Sau khi đã có label của các thầy cô bộ môn là khó hay dễ thì sẽ sử dụng open ai để đưa ra gợi ý các môn nên học vào kỳ sau cho sinh viên để đạt được kết quả tốt.

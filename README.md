# TGMTparking
Phần mềm giữ xe nhỏ gọn với các tính năng cơ bản của 1 bãi giữ xe:
- 2 làn xe: làn vào và làn ra
- 2 phiên bản: x64 và x86
- Tích hợp module đọc biển số xe máy IPSSbike
- Tích hợp TGMTplayer: thư viện đọc camera IP ít giật lag
- Sử dụng thẻ Mifare giá rẻ & dễ mua
- Lưu trữ CSDL vào database SQlite, dễ dàng copy chương trình qua PC mới
- Phân quyền người dùng: nhân viên và Admin. Admin có quyền setup camera, password database...

## Yêu cầu kỹ thuật
- Chạy trên PC windows 10
- Camera IP các hãng: Ezviz, Hikvison, Vivotek, Vantech, KBvision.
- Đầu đọc thẻ Mifare SCL011
- Thẻ Mifare classic 13.56Mhz
- Cài đặt .Net Framework 4.7.2
- Cài đặt C++ redistributable 2015 x86 hoặc x64 tùy phiên bản bạn chọn.
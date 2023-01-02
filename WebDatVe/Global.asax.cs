using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace v2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //ds nguoi dung
            Application["dsNguoiDung"] = new List<nguoidung>();
            List<nguoidung> nd = new List<nguoidung>();

            nd.Add(new nguoidung() { Email = "nmh1@gmail.com", Sdt = "01234567", Ten = "Nguyen Manh Hung", MatKhau = "1234567" });
            nd.Add(new nguoidung() { Email = "nmh2@gmail.com", Sdt = "01234567", Ten = "Nguyen Manh Hung", MatKhau = "1234567" });

            Application["dsNguoiDung"] = nd;

            //ds phim
            Application["listPhim"] = new List<phim>();
            List<phim> f = new List<phim>();

            f.Add(new phim() { Id = "p0", Anh = "anh/phim/chungTocBatTu.jpg", Ten = "CHỦNG TỘC BẤT TỬ", DaoDien = "Chloé Zhao", DienVien = "Gemma Chan, Angelina Jolie, Salma Hayek, Richard Madden, Kit Harington, Barry Keoghan", TheLoai = "Hành Động, Phiêu Lưu, Thần thoại", KhoiChieu = "03/12/2021", ThoiLuong = "155 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Chủng Tộc Bất Tử là một chủng tộc ngoài hành tinhh đã ẩn mình trong loài người hàng nghìn năm. Từ lâu, họ đã dõi theo và giúp loài người tiến bộ, chứng kiến các đế chế trỗi dậy và lụi tàn, các thành tựu vĩ đại của con người với quy tắc không can thiệp. Nhưng sau sự kiện Avengers: Endgame (2019), mọi thứ đã thay đổi. Các thành viên giờ phải bước ra khỏi bóng tối, đoàn kết chống lại The Deviants - một kẻ thù lâu đời đe dọa Trái Đất.", GiaVe = "90000" });
            f.Add(new phim() { Id = "p1", Anh = "anh/phim/shangchi.jpg", Ten = "SHANG-CHI VÀ HUYỀN THOẠI THẬP LUÂN", DaoDien = "Destin Daniel Cretton", DienVien = "Simu Liu, Awkwafina, Tony Chiu-Wai Leung", TheLoai = "Hành Động", KhoiChieu = "26/11/2021", ThoiLuong = "136 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Shang-Chi và Huyền Thoại Thập Nhẫn là bộ phim thuộc giai đoạn 4 của Vũ trụ điện ảnh Marvel. Nhân vật này được biết đến như một bậc thầy Kung Fu, tinh thông võ thuật. Sức mạnh của Shang-Chi đến từ hàng ngàn giờ luyện tập miệt mài và sự kỷ luật cao độ với bản thân. Siêu anh hùng võ thuật này được chính bố dạy dỗ để trở thành một sát thủ chuyên nghiệp và kế thừa tập đoàn tội ác của ông.", GiaVe = "90000đ" });
            f.Add(new phim() { Id = "p2", Anh = "anh/phim/bdct.jpg", Ten = "SUICIDE SQUAD: ĐIỆP VỤ CẢM TỬ", DaoDien = "James Gunn", DienVien = "Margot Robbie, Idris Elba, John Cena", TheLoai = "Hành Động", KhoiChieu = "19/11/2021", ThoiLuong = "132 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "The Suicide Squad - Điệp Vụ Cảm Tử kể về nhóm Task Force X bao gồm các thành viên là những phần tử nguy hiểm và có siêu năng lực đặc biệt được chỉ huy bởi Amanda Waller, họ có nhiệm vụ đột kích lên 1 hòn đảo có tên là Corto Maltese, nơi diễn ra cuộc đảo chính và thành lập chính phủ chống Mỹ. Tại hòn đảo này, các nhà chức trách đang kiểm soát một con quái vật tên là Starro - có năng lực biến con người thành cái xác không hồn, điều này khiến cho an ninh thế giới bị đe dọa một cách nghiêm trọng. Nhóm bọn Task Force X buộc phải đối mặt với vô số kẻ thù trên hòn đảo, nếu xảy ra bất cứ sai lầm bọn họ sẽ phải trả giá bằng mạng sống.", GiaVe = "90000" });
            f.Add(new phim() { Id = "p4", Anh = "anh/phim/VeSiSatThu.jpg", Ten = "VỆ SĨ SÁT THỦ 2: NHÀ CÓ NÓC", DaoDien = "Patrick Hughes", DienVien = "Ryan Reynolds, Samuel L. Jackson, Frank Grillo, Salma Hayek, Morgan Freeman", TheLoai = "Hài, Hành Động", KhoiChieu = "26/11/2021", ThoiLuong = "118 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Bộ đôi chết chóc nhất quả đất: vệ sĩ Michael Bryce và sát thủ Darius Kincaid đã bung nóc trở lại cùng 'Vệ Sĩ Sát Thủ 2' Chuyên viên an ninh cao cấp Michael Bryce quyết định nghỉ xả hơi buông lơi 2 từ VỆ SĨ. Ăn chơi chưa được bao lâu, Michael Bryce một lần nữa buộc phải làm bạn thân cùng sát thủ khét tiếng Darius Kincaid trong phi vụ tréo ngoe: cứu lấy nóc nhà của tay sát thủ.", GiaVe = "90000 d" });
            f.Add(new phim() { Id = "p5", Anh = "anh/phim/KeNguyenTaChet.jpg", Ten = "KẺ NGUYỀN TA CHẾT", DaoDien = "Taylor Sheridan", DienVien = "Angelina Jolie, Jon Bernthal, Nicholas Hoult", TheLoai = "Hành Động, Hồi hộp, Tâm Lý", KhoiChieu = "05/11/2021", ThoiLuong = "100 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Angelina Jolie tái xuất với siêu phẩm hành động nghẹt thở cùng biên kịch được đề cử Oscar - Taylor Sheridan Kẻ Nguyền Ta Chết xoay quanh cuộc truy sát kinh hoàng giữa băng đảng giết thuê và cậu bé Connor - nhân chứng cuối cùng của một vụ trọng án. Với mục tiêu truy cùng giết tận, những kẻ giết người máu lạnh đã phóng hỏa khu rừng để đánh lạc hướng cảnh sát và săn lùng cậu bé. Vô tình bị cuốn vào cuộc chiến, lính cứu hỏa Hannah (Angelina Jolie) phải tìm mọi cách để giúp Connor thoát khỏi tình thế nghìn cân treo sợi tóc trước lưỡi hái tử thần của những kẻ giết người và sự chết chóc của biển lửa kinh hoàng.", GiaVe = "100000" });
            f.Add(new phim() { Id = "p6", Anh = "anh/phim/VeNom.jpg", Ten = "VENOM: ĐỐI MẶT TỬ THÙ", DaoDien = "Andy Serkis", DienVien = "Tom Hardy, Michelle Williams, Woody Harrelson, Naomie Harris", TheLoai = "Hành Động, Khoa Học Viễn Tưởng, Phiêu Lưu, Thần thoại", KhoiChieu = "10/12/2021", ThoiLuong = "97 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = " LET THERE BE CARNAGE hứa hẹn trận chiến khốc liệt nhất giữa Venom và kẻ thù truyền kiếp, Carnage.", GiaVe = "100000d" });
            f.Add(new phim() { Id = "p7", Anh = "anh/phim/doremon.jpg", Ten = "Ryuichi Yagi, Takashi Yamazaki", DaoDien = "", DienVien = "Wasabi Mizuta, Megumi Oohara, Yumi Kakazu, Subaru Kimura, Tomokazu Seki", TheLoai = "Hài, Hoạt Hình", KhoiChieu = "17/12/2022", ThoiLuong = "96 phút", NgonNgu = "Tiếng Nhật - Phụ đề Tiếng Việt; Lồng tiếng", NoiDung = "Một ngày nọ, Nobita vô tình tìm thấy chú gấu bông cũ, món đồ chơi chất chứa bao kỉ niệm cùng người bà đáng kính. Với khát khao “muốn gặp bà lần nữa”, Nobita đã trở về quá khứ bằng cổ máy thời gian, bất chấp sự phản đối của Doraemon. Dù ngạc nhiên, bà vẫn tin cậu thiếu niên lớn tướng trước mặt mình là cháu mình. Trước nguyện vọng tha thiết “mong được thấy cháu dâu một lần”, chuyến phiêu lưu của Doraemon và Nobita bắt đầu. Nobita muốn cho bà xem đám cưới của mình, nhưng đúng ngày thành hôn với Shizuka, chú rể Nobita lại trốn mất? Jaian và Suneo chạy đôn chạy đáo tìm bạn, còn Shizuka vẫn tin tưởng chờ đợi Nobita. Để thực hiện nguyện vọng của bà, đáp lại niềm tin của gia đình, bạn bà và Shizuka yêu quý, Nobita sẽ cùng Doraemon du hành vượt thời gian. Họ sẽ mang đến cho chúng ta một câu chuyện cảm động đến rơi lệ về quan hệ con người, kết nối giữa quá khứ, hiện tại và tương lai.", GiaVe = "150000" });
            f.Add(new phim() { Id = "p8", Anh = "anh/phim/BongDe.jpg", Ten = "BÓNG ĐÈ", DaoDien = "Lê Văn Kiệt", DienVien = "Lâm Thanh Mỹ, Quang Tuấn, Mai Cát Vi, Diệu Nhi", TheLoai = "Kinh Dị", KhoiChieu = "24/12/2021", ThoiLuong = "100 phút", NgonNgu = "Tiếng Việt - Phụ đề Tiếng Anh", NoiDung = "Bóng đè là trải nghiệm xảy ra khi tâm trí đã thức giấc nhưng cơ thể vẫn còn trong giấc ngủ. Đa số trường hợp không thể phân biệt được giữa thực và mơ. Theo thống kê, 40% dân số thế giới từng bị bóng đè ít nhất một lần trong đời. BÓNG ĐÈ- phim điện ảnh Việt đầu tiên khai thác về hiện tượng bóng đè, cầm trịch bởi Lê Văn Kiệt – đạo diễn Hai Phượng. Chuyển đến một căn nhà cổ ở vùng quê, ba cha con Thành (Quang Tuấn), Linh (Lâm Thanh Mỹ) và Yến (Mai Cát Vi) hy vọng về một cuộc sống mới. Nhưng chào đón họ là hàng loạt những hiện tượng kỳ dị ập đến mỗi khi chìm vào giấc ngủ ... Giờ lành đã điểm, quỷ dữ thức giấc", GiaVe = "150000" });
            f.Add(new phim() { Id = "p9", Anh = "anh/phim/Thopeter2.jpg", Ten = "THỎ PETER 2", DaoDien = "Will Gluck", DienVien = " Margot Robbie, Elizabeth Debicki, Rose Byrne", TheLoai = "Hoạt Hình, Phiêu Lưu", KhoiChieu = "12/12/2020", ThoiLuong = "101 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Trong phần tiếp theo của Thỏ Peter, những kẻ lừa đảo đáng yêu đã trở lại. Bea, Thomas và những con thỏ đã tạo ra một gia đình tạm thời, nhưng mặc dù đã cố gắng hết sức, Peter dường như không thể làm suy chuyển những thành tích nghịch ngợm tinh quái của cậu. Quyết định mở rộng cuộc phiêu lưu ra khỏi khu vườn, Peter tìm thấy chính mình ở nơi mà bản chất thật của cậu được trân trọng. Nhưng rồi gia đình cậu nhất quyết đánh đổi bằng mọi giá để tìm cậu về. Peter buộc phải tìm ra lối đi cho riêng mình và trở thành một người mà cậu luôn mong muốn.", GiaVe = "80000" });
            f.Add(new phim() { Id = "p10", Anh = "anh/phim/CanPhongTuThan.jpg", Ten = "CĂN PHÒNG TỬ THẦN: CÁI CHẾT TRỞ LẠI", DaoDien = "Adam Robitel", DienVien = "Holland Roden, Isabelle Fuhrma, Taylor Russell, Logan Miller", TheLoai = "Kinh Dị", KhoiChieu = "", ThoiLuong = "", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Căn Phòng Tử Thần: Cái Chết Trở Lại đưa những người từng thắng cuộc vào các căn phòng bị khóa kín. Hoặc họ phải tìm cách thoát ra, hoặc họ phải bỏ mạng trong đó. Ở lần trở lại này, quy mô và độ khó của căn phòng được nâng lên gấp bội, khiến các người chơi phải vận dụng cả trí óc, sức lực, tinh thần đồng đội và nhất là phải dẹp bỏ cảm giác hả hê để có thể sống đến giây phút cuối cùng.", GiaVe = "80000" });
            f.Add(new phim() { Id = "p11", Anh = "anh/phim/ff9.jpg", Ten = "FAST & FURIOUS 9", DaoDien = "Justin Lin", DienVien = "Charlize Theron, Jim Parrack, John Cena", TheLoai = "Hành Động, Phiêu Lưu", KhoiChieu = "", ThoiLuong = "", NgonNgu = "Tiếng Anh và phụ đề tiếng Việt", NoiDung = "Plot unknown. The ninth installment of the 'Fast and Furious' franchise.", GiaVe = "160000" });
            f.Add(new phim() { Id = "p12", Anh = "anh/phim/minion.jpg", Ten = "MINIONS: SỰ TRỖI DẬY CỦA GRU", DaoDien = "Kyle Balda, Brad Ableson, Jonathan del Val", DienVien = "Steve Carell, Lucy Lawless, Michelle Yeoh...", TheLoai = "Hài, Hoạt Hình, Phiêu Lưu", KhoiChieu = "", ThoiLuong = "", NgonNgu = "iếng Anh với phụ đề tiếng Việt và lồng tiếng Việt", NoiDung = "Hành trình phiêu lưu của #Gru song hành cùng với #Otto và viên đá của ác nhân MINIONS: SỰ TRỖI DẬY CỦA GRU - DCKC: 2021", GiaVe = "200000" });
            f.Add(new phim() { Id = "p13", Anh = "anh/phim/LatMat.jpg", Ten = "LẬT MẶT: 48H", DaoDien = "Lý Hải", DienVien = "Võ Thành Tâm, Mạc Văn Khoa, Huỳnh Đông.", TheLoai = "Hành Động", KhoiChieu = "30/12/2021", ThoiLuong = "110 phút", NgonNgu = "", NoiDung = "Lý Hải trở lại với dòng phim hành động sở trường của mình. Bối cảnh hoành tráng với sự đầu tư nghiêm túc, siêu phẩm hành động Việt Lật Mặt 48h sẽ kể về một hành trình trốn chạy đầy kịch tính, nghẹt thở đến phút cuối cùng.", GiaVe = "120000" });
            f.Add(new phim() { Id = "p14", Anh = "anh/phim/QuaPhuDen.jpg", Ten = "GÓA PHỤ ĐEN", DaoDien = "Cate Shortland", DienVien = "Scarlett Johansson, Florence Pugh, Robert Downey Jr...", TheLoai = "Hành Động, Phiêu Lưu", KhoiChieu = "19/11/2021", ThoiLuong = "133 phút", NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt", NoiDung = "Phần phim riêng của Natasha Romanoff bất ngờ tung teaser chính thức với những cảnh hành động mãn nhãn, mang đậm chất điệp viên. Bên cạnh đó, phần phim này cũng sẽ hé lộ quá khứ đen tối và quá trình biến cô trở thành một Black Widow.", GiaVe = "150000" });
            f.Add(new phim() { Id = "p15", Anh = "anh/phim/AmHonNhanXac.jpg", Ten = "ÂM HỒN NHẬP XÁC", DaoDien = "Banjong Pisanthanakun", DienVien = "Sawanee Utoomma, Narilya Gulmongkolpech, Sirani Yankittikan", TheLoai = "Kinh Dị", KhoiChieu = "19/11/2021", ThoiLuong = "120 phút", NgonNgu = "Tiếng Thái - Phụ đề tiếng Việt", NoiDung = "Âm Hồn Nhập Xác (tựa tiếng Anh: The Medium) theo chân nhóm quay phim thực hiện một bộ phim tài liệu về Nim – một bà đồng sống ở Isan miền bắc Thái Lan. Theo lời đồn, bà Nim được linh hồn của “Bà Nội Ba Yan” lựa chọn trở thành người kết nối giữa thần linh và con người. Câu chuyện trở nên bí hiểm và thu hút hơn khi Mink – cháu gái của Nim bắt đầu có những biểu hiện kỳ quái và ngày càng cực đoan. Cả nhóm quyết định theo dõi Mink, với hy vọng tìm hiểu thêm về dòng dõi pháp sư của gia đình bà Nim. Liệu thứ đang chế ngự Mink – hậu duệ đời tiếp theo chính là Ba Yan hay thực ra là một “âm hồn” nguy hiểm nào khác?", GiaVe = "100000" });

            Application["listPhim"] = f;

            // danh sach thanh pho
            Application["thanhPho"] = new List<thanhpho>();
            List<thanhpho> tp = new List<thanhpho>();

            tp.Add(new thanhpho() { Id = "tp0", Ten = "Hà Nội" });
            tp.Add(new thanhpho() { Id = "tp1", Ten = "Hồ Chí Minh" });
            tp.Add(new thanhpho() { Id = "tp2", Ten = "Đà Nẵng" });
            tp.Add(new thanhpho() { Id = "tp3", Ten = "Hải Phòng" });
            tp.Add(new thanhpho() { Id = "tp4", Ten = "Đồng Nai" });
            tp.Add(new thanhpho() { Id = "tp5", Ten = "Quảng Ninh" });
            tp.Add(new thanhpho() { Id = "tp6", Ten = "Cần Thơ" });


            Application["thanhPho"] = tp;

            // danh sach rap phim
            Application["rap"] = new List<rap>();
            List<rap> r = new List<rap>();
            // Hn
            r.Add(new rap() { IdTP = "tp0", IdRap = "tp0rap0", TenRap = "CGV Vincom Center Bà Triệu", DiaChiRap = "Tầng 6, Toà nhà VinCom Center Hà Nội 191 đường Bà Triệu Quận Hai Bà Trưng Hà Nội" });
            r.Add(new rap() { IdTP = "tp0", IdRap = "tp0rap1", TenRap = "CGV Mipec Tower", DiaChiRap = "Tầng 5, MIPEC Tower 229 Tây Sơn Quận Đống Đa, Hà Nội" });
            r.Add(new rap() { IdTP = "tp0", IdRap = "tp0rap2", TenRap = "CGV Hồ Gươm Plaza", DiaChiRap = "Tầng 3, TTTM Hồ Gươm Plaza, 110 Trần Phú, Phường Mỗ Lao, Quận Hà Đông, Hà Nội" });
            // HCM
            r.Add(new rap() { IdTP = "tp1", IdRap = "tp1rap0", TenRap = "CGV Hùng Vương Plaza", DiaChiRap = "Tầng 7 | Hùng Vương Plaza 126 Hùng Vương Quận 5 Tp. Hồ Chí Minh" });
            r.Add(new rap() { IdTP = "tp1", IdRap = "tp1rap1", TenRap = "CGV Crescent Mall", DiaChiRap = "Lầu 5, Crescent Mall Đại lộ Nguyễn Văn Linh, Phú Mỹ Hưng Quận 7 TP. Hồ Chí Minh" });
            r.Add(new rap() { IdTP = "tp1", IdRap = "tp1rap2", TenRap = "CGV Thảo Điền Pearl", DiaChiRap = "Tầng 2, Thảo Điền Mall, 12 Quốc Hương, Phường Thảo Điền, Quận 2, TP. Hồ Chí Minh" });
            // DN
            r.Add(new rap() { IdTP = "tp2", IdRap = "tp2rap0", TenRap = "CGV Vĩnh Trung Plaza", DiaChiRap = "255-257 đường Hùng Vương Quận Thanh Khê Tp. Đà Nẵng" });
            r.Add(new rap() { IdTP = "tp2", IdRap = "tp2rap1", TenRap = "CGV Vincom Đà Nẵng", DiaChiRap = "Tầng 4, TTTM Vincom Đà Nẵng, đường Ngô Quyền, P.An Hải Bắc, Q.Sơn Trà, TP. Đà Nẵng" });
            // HP
            r.Add(new rap() { IdTP = "tp3", IdRap = "tp3rap0", TenRap = "CGV Thùy Dương Plaza", DiaChiRap = "Tầng 5, TD Plaza Ngã 5 sân bay Cát Bi, đường Lê Hồng Phong Quận Ngô Quyền Tp. Hải Phòng" });
            r.Add(new rap() { IdTP = "tp3", IdRap = "tp3rap1", TenRap = "CGV Vincom Hải Phòng", DiaChiRap = "Tầng 4, Vincom Plaza Imperia Hải Phòng, Khu đô thị Vinhomes Imperia Hải Phòng, Phường Thượng Lý, Quận Hồng Bàng, Thành phố Hải Phòng." });
            r.Add(new rap() { IdTP = "tp3", IdRap = "tp3rap2", TenRap = "CGV Aeon Mall Hải Phòng", DiaChiRap = "Tầng 3 TTTM AEON MALL Hải Phòng Lê Chân, số 10 đường Võ Nguyên Giáp, Phường Kênh Dương, Quận Lê Chân, Thành phố Hải Phòng" });

            //Dong nai
            r.Add(new rap() { IdTP = "tp4", IdRap = "tp4rap0", TenRap = "CGV Coopmart Biên Hòa", DiaChiRap = "Tầng 3, Khu Siêu thị Co-op Mart 121 Phạm Văn Thuận, P.Tân Tiến Tp. Biên Hoà Tỉnh Đồng Nai" });
            r.Add(new rap() { IdTP = "tp4", IdRap = "tp4rap1", TenRap = "CGV Big C Đồng Nai", DiaChiRap = "Siêu thị BigC Đồng Nai, Khu phố 1, Phường Long Bình Tân, TP. Biên Hòa, Đồng Nai" });

            // QN
            r.Add(new rap() { IdTP = "tp5", IdRap = "tp5rap0", TenRap = "CGV Vincom Hạ Long", DiaChiRap = "Tầng 4, TTTM Vincom Center Hạ Long, Khu Cột Đồng Hồ, P.Bạch Đằng, Hạ Long, Quảng Ninh" });
            r.Add(new rap() { IdTP = "tp5", IdRap = "tp5rap1", TenRap = "CGV Vincom Móng Cái", DiaChiRap = "Tầng 3 & tầng 4, Vincom Plaza Móng Cái, tổ hợp TTTM & và nhà ở liền kề ( Shophouse), Phường Trần Phú, Thành Phố Móng Cái, Tỉnh Quảng Ninh, Việt Nam" });
            r.Add(new rap() { IdTP = "tp5", IdRap = "tp5rap2", TenRap = "CGV Vincom Cẩm Phả", DiaChiRap = "Tầng 4, Vincom Cẩm Phả , P. Cẩm Bình, TP. Cẩm Phả, Tỉnh Quảng Ninh" });

            // Cần Thơ
            r.Add(new rap() { IdTP = "tp6", IdRap = "tp6rap0", TenRap = "CGV Sense City", DiaChiRap = "Lầu 3, Sense City 1 Đại Lộ Hòa Bình Quận Ninh Kiều TP. Cần Thơ" });
            r.Add(new rap() { IdTP = "tp6", IdRap = "tp6rap0", TenRap = "CGV Vincom Xuân Khánh", DiaChiRap = "Tầng 5, Tòa nhà 209, Đường 30/04, Phường Xuân Khánh, Quận Ninh Kiều, Tp. Cần Thơ" });
            r.Add(new rap() { IdTP = "tp6", IdRap = "tp6rap0", TenRap = "CGV Vincom Hùng Vương", DiaChiRap = "02 Hùng Vương, Quận Ninh Kiều, TP. Cần Thơ" });


            Application["rap"] = r;

            // ds phim cua rap
            Application["phimCuaRap"] = new List<phimcuarap>();
            List<phimcuarap> fcr = new List<phimcuarap>();
            fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p0" });
            fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p1" });
            fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p2" });
            fcr.Add(new phimcuarap() { IdRap = "tp0rap1", IdPhim = "p0" });
            fcr.Add(new phimcuarap() { IdRap = "tp0rap1", IdPhim = "p1" });
            fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p0" });
            fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p1" });

            fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p4" });
            fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p4" });
            fcr.Add(new phimcuarap() { IdRap = "tp2rap0", IdPhim = "p4" });

            fcr.Add(new phimcuarap() { IdRap = "tp0rap1", IdPhim = "p5" });
            fcr.Add(new phimcuarap() { IdRap = "tp1rap1", IdPhim = "p5" });
            fcr.Add(new phimcuarap() { IdRap = "tp2rap1", IdPhim = "p5" });
            /*            // P1
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p1" });//hn
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap2", IdPhim = "p1" });
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p1" });//hcm
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap1", IdPhim = "p1" });
                        fcr.Add(new phimcuarap() { IdRap = "tp2rap0", IdPhim = "p1" });//da nang
                        fcr.Add(new phimcuarap() { IdRap = "tp3rap1", IdPhim = "p1" });//hp
                        fcr.Add(new phimcuarap() { IdRap = "tp5rap0", IdPhim = "p1" });//qn
                        fcr.Add(new phimcuarap() { IdRap = "tp6rap0", IdPhim = "p1" });//ct
                        //p2
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap1", IdPhim = "p2" });//hn
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p2" });
                        fcr.Add(new phimcuarap() { IdRap = "tp6rap2", IdPhim = "p2" });//ct
                        fcr.Add(new phimcuarap() { IdRap = "tp5rap0", IdPhim = "p2" });//qn
                        //p3
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap1", IdPhim = "p3" });//hn
                        fcr.Add(new phimcuarap() { IdRap = "tp3rap1", IdPhim = "p3" });//hp
                        fcr.Add(new phimcuarap() { IdRap = "tp4rap1", IdPhim = "p3" });//dn
                        //p4
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p4" });//hcm
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap1", IdPhim = "p4" });
                        fcr.Add(new phimcuarap() { IdRap = "tp5rap0", IdPhim = "p4" });//qn
                        //p5
                        fcr.Add(new phimcuarap() { IdRap = "tp0rap0", IdPhim = "p5" });//hn
                        //p6
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p6" });//hn
                        //p7
                        fcr.Add(new phimcuarap() { IdRap = "tp2rap0", IdPhim = "p7" });//hn
                        //p8
                        fcr.Add(new phimcuarap() { IdRap = "tp3rap0", IdPhim = "p8" });//hn
                        //p9
                        fcr.Add(new phimcuarap() { IdRap = "tp4rap0", IdPhim = "p9" });//hn
                        //p10
                        fcr.Add(new phimcuarap() { IdRap = "tp5rap0", IdPhim = "p10" });//hn
                        //p11
                        fcr.Add(new phimcuarap() { IdRap = "tp6rap0", IdPhim = "p11" });//hn
                        //p12
                        fcr.Add(new phimcuarap() { IdRap = "tp1rap0", IdPhim = "p12" });//hn
                        //p13
                        fcr.Add(new phimcuarap() { IdRap = "tp2rap0", IdPhim = "p13" });//hn
                        //p14
                        fcr.Add(new phimcuarap() { IdRap = "tp3rap0", IdPhim = "p14" });//hn
                        //p15
                        fcr.Add(new phimcuarap() { IdRap = "tp4rap0", IdPhim = "p15" });//hn*/

            Application["phimCuaRap"] = fcr;

            // ds lich chia cua phim o rap
            Application["lichChieuCuaPhim"] = new List<lichchieucuaphim>();
            List<lichchieucuaphim> lc = new List<lichchieucuaphim>();
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p0", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p0", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p1", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p1", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p2", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p2", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap1", IdPhim = "p0", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap1", IdPhim = "p0", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap1", IdPhim = "p1", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap1", IdPhim = "p1", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp1rap0", IdPhim = "p0", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp1rap0", IdPhim = "p0", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp1rap0", IdPhim = "p1", LichChieu = "10/12/2021,8:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp1rap0", IdPhim = "p1", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });

            lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p4", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp1rap0", IdPhim = "p4", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });
            lc.Add(new lichchieucuaphim() { IdRap = "tp2rap0", IdPhim = "p4", LichChieu = "10/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });

            //lc.Add(new lichchieucuaphim() { IdRap = "tp0rap0", IdPhim = "p4", LichChieu = "04/12/2021,9:00", SoGhe = "a1,a2,a3,a4,a5,a6,a7,b1,b2,b3,b4,b5,b6,b7,c1,c2,c3,c4,c5,c6,c7,d1,d2,d3,d4,d5,d6,d7" });


            Application["lichChieuCuaPhim"] = lc;


            // ds ve cua toi xac dinh theo email nguoi dung
            Application["dsVeCuaToi"] = new List<vecuatoi>();
            List<vecuatoi> vct = new List<vecuatoi>();

            vct.Add(new vecuatoi() { EmailND = "nmh1@gmail.com", IdPhim = "p0", TenPhim = "CHỦNG TỘC BẤT TỬ", AnhPhim = "anh/phim/chungTocBatTu.jpg", LichChieu = "06/12/2021,9:00", SoGhe = "a1", IdRap = "tp0rap0", TenRap = "CGV Vincom Center Bà Triệu", NgayMua = "05/12/2021" });
            vct.Add(new vecuatoi() { EmailND = "nmh2@gmail.com", IdPhim = "p0", TenPhim = "CHỦNG TỘC BẤT TỬ", AnhPhim = "anh/phim/chungTocBatTu.jpg", LichChieu = "06/12/2021,9:00", SoGhe = "a2", IdRap = "tp0rap0", TenRap = "CGV Vincom Center Bà Triệu", NgayMua = "05/12/2021" });

            Application["dsVeCuaToi"] = vct;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["VCT"] = new vecuatoi();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
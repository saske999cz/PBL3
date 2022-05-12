namespace DoAnPBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tai_Khoan",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 255),
                        matKhau = c.String(nullable: false, maxLength: 255),
                        email = c.String(nullable: false, maxLength: 255),
                        quyen = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.Quan_Tri",
                c => new
                    {
                        ID_QuanTri = c.String(nullable: false, maxLength: 100),
                        hoVaTen = c.String(nullable: false, maxLength: 255),
                        email = c.String(nullable: false, maxLength: 255),
                        ngaySinh = c.DateTime(nullable: false),
                        gioiTinh = c.String(nullable: false, maxLength: 20),
                        SDT = c.String(nullable: false, maxLength: 20),
                        CMND = c.String(nullable: false, maxLength: 50),
                        diaChi = c.String(nullable: false, maxLength: 255),
                        anh = c.Binary(),
                        taiKhoanDangNhap = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_QuanTri)
                .ForeignKey("dbo.Tai_Khoan", t => t.taiKhoanDangNhap)
                .Index(t => t.SDT, unique: true)
                .Index(t => t.taiKhoanDangNhap);
            
            CreateTable(
                "dbo.Tac_Gia",
                c => new
                    {
                        ID_TacGia = c.String(nullable: false, maxLength: 100),
                        hoVaTen = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_TacGia);
            
            CreateTable(
                "dbo.Sach",
                c => new
                    {
                        ID_Sach = c.String(nullable: false, maxLength: 100),
                        tenSach = c.String(nullable: false, maxLength: 255),
                        ngayPhatHanh = c.DateTime(nullable: false),
                        soLuong = c.Int(nullable: false),
                        giaTien = c.Int(nullable: false),
                        ISBN = c.String(nullable: false, maxLength: 50),
                        ID_TacGia = c.String(nullable: false, maxLength: 100),
                        ID_TheLoai = c.Int(nullable: false),
                        ID_NgonNgu = c.Int(nullable: false),
                        ID_NhaXuatBan = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Sach)
                .ForeignKey("dbo.Tac_Gia", t => t.ID_TacGia, cascadeDelete: true)
                .ForeignKey("dbo.The_Loai", t => t.ID_TheLoai, cascadeDelete: true)
                .ForeignKey("dbo.Ngon_Ngu", t => t.ID_TheLoai, cascadeDelete: true)
                .ForeignKey("dbo.Nha_Xuat_Ban", t => t.ID_NhaXuatBan, cascadeDelete: true)
                .Index(t => t.ID_TacGia)
                .Index(t => t.ID_TheLoai)
                .Index(t => t.ID_NhaXuatBan);
            
            CreateTable(
                "dbo.The_Loai",
                c => new
                    {
                        ID_TheLoai = c.Int(nullable: false, identity: true),
                        tenTheLoai = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_TheLoai);
            
            CreateTable(
                "dbo.Ngon_Ngu",
                c => new
                    {
                        ID_NgonNgu = c.Int(nullable: false, identity: true),
                        tenNgonNgu = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_NgonNgu);
            
            CreateTable(
                "dbo.Chi_Tiet_Hoa_Don",
                c => new
                    {
                        ID_HoaDon = c.String(nullable: false, maxLength: 100),
                        ID_Sach = c.String(nullable: false, maxLength: 100),
                        Ten_Sach = c.String(nullable: false, maxLength: 100),
                        donGia = c.Int(nullable: false),
                        soLuong = c.Int(nullable: false),
                        thanhTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_HoaDon, t.ID_Sach })
                .ForeignKey("dbo.Sach", t => t.ID_Sach, cascadeDelete: true)
                .ForeignKey("dbo.Hoa_Don", t => t.ID_HoaDon, cascadeDelete: true)
                .Index(t => t.ID_HoaDon)
                .Index(t => t.ID_Sach);
            
            CreateTable(
                "dbo.Hoa_Don",
                c => new
                    {
                        ID_HoaDon = c.String(nullable: false, maxLength: 100),
                        ngayTaoHoaDon = c.DateTime(nullable: false),
                        tongTien = c.Int(nullable: false),
                        ID_KhachHang = c.String(nullable: false, maxLength: 100),
                        ID_NhanVien = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_HoaDon)
                .ForeignKey("dbo.Khach_Hang", t => t.ID_KhachHang, cascadeDelete: true)
                .ForeignKey("dbo.Nhan_Vien", t => t.ID_KhachHang, cascadeDelete: true)
                .Index(t => t.ID_KhachHang);
            
            CreateTable(
                "dbo.Khach_Hang",
                c => new
                    {
                        ID_KhachHang = c.String(nullable: false, maxLength: 100),
                        hoVaTen = c.String(nullable: false, maxLength: 255),
                        gioiTinh = c.String(nullable: false, maxLength: 20),
                        SDT = c.String(nullable: false, maxLength: 20),
                        diaChi = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_KhachHang)
                .Index(t => t.SDT, unique: true);
            
            CreateTable(
                "dbo.Nhan_Vien",
                c => new
                    {
                        ID_NhanVien = c.String(nullable: false, maxLength: 100),
                        hoVaTen = c.String(nullable: false, maxLength: 255),
                        email = c.String(nullable: false),
                        ngaySinh = c.DateTime(nullable: false),
                        gioiTinh = c.String(nullable: false, maxLength: 20),
                        SDT = c.String(nullable: false, maxLength: 20),
                        CMND = c.String(nullable: false, maxLength: 50),
                        diaChi = c.String(nullable: false, maxLength: 255),
                        anh = c.Binary(),
                        taiKhoanDangNhap = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_NhanVien)
                .ForeignKey("dbo.Tai_Khoan", t => t.taiKhoanDangNhap)
                .Index(t => t.SDT, unique: true)
                .Index(t => t.taiKhoanDangNhap);
            
            CreateTable(
                "dbo.Nha_Xuat_Ban",
                c => new
                    {
                        ID_NhaXuatBan = c.String(nullable: false, maxLength: 100),
                        tenNhaXuatBan = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        SDT = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID_NhaXuatBan);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sach", "ID_NhaXuatBan", "dbo.Nha_Xuat_Ban");
            DropForeignKey("dbo.Chi_Tiet_Hoa_Don", "ID_HoaDon", "dbo.Hoa_Don");
            DropForeignKey("dbo.Hoa_Don", "ID_KhachHang", "dbo.Nhan_Vien");
            DropForeignKey("dbo.Nhan_Vien", "taiKhoanDangNhap", "dbo.Tai_Khoan");
            DropForeignKey("dbo.Hoa_Don", "ID_KhachHang", "dbo.Khach_Hang");
            DropForeignKey("dbo.Chi_Tiet_Hoa_Don", "ID_Sach", "dbo.Sach");
            DropForeignKey("dbo.Sach", "ID_TheLoai", "dbo.Ngon_Ngu");
            DropForeignKey("dbo.Sach", "ID_TheLoai", "dbo.The_Loai");
            DropForeignKey("dbo.Sach", "ID_TacGia", "dbo.Tac_Gia");
            DropForeignKey("dbo.Quan_Tri", "taiKhoanDangNhap", "dbo.Tai_Khoan");
            DropIndex("dbo.Nhan_Vien", new[] { "taiKhoanDangNhap" });
            DropIndex("dbo.Nhan_Vien", new[] { "SDT" });
            DropIndex("dbo.Khach_Hang", new[] { "SDT" });
            DropIndex("dbo.Hoa_Don", new[] { "ID_KhachHang" });
            DropIndex("dbo.Chi_Tiet_Hoa_Don", new[] { "ID_Sach" });
            DropIndex("dbo.Chi_Tiet_Hoa_Don", new[] { "ID_HoaDon" });
            DropIndex("dbo.Sach", new[] { "ID_NhaXuatBan" });
            DropIndex("dbo.Sach", new[] { "ID_TheLoai" });
            DropIndex("dbo.Sach", new[] { "ID_TacGia" });
            DropIndex("dbo.Quan_Tri", new[] { "taiKhoanDangNhap" });
            DropIndex("dbo.Quan_Tri", new[] { "SDT" });
            DropTable("dbo.Nha_Xuat_Ban");
            DropTable("dbo.Nhan_Vien");
            DropTable("dbo.Khach_Hang");
            DropTable("dbo.Hoa_Don");
            DropTable("dbo.Chi_Tiet_Hoa_Don");
            DropTable("dbo.Ngon_Ngu");
            DropTable("dbo.The_Loai");
            DropTable("dbo.Sach");
            DropTable("dbo.Tac_Gia");
            DropTable("dbo.Quan_Tri");
            DropTable("dbo.Tai_Khoan");
        }
    }
}

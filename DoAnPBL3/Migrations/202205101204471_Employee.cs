namespace DoAnPBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Employee : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Employee_Insert",
                p => new
                {
                    ID_NhanVien = p.String(maxLength: 100),
                    hoVaTen = p.String(maxLength: 255),
                    email = p.String(),
                    ngaySinh = p.DateTime(),
                    gioiTinh = p.String(maxLength: 20),
                    SDT = p.String(maxLength: 20),
                    CMND = p.String(maxLength: 50),
                    diaChi = p.String(maxLength: 255),
                    anh = p.Binary(),
                    taiKhoanDangNhap = p.String(maxLength: 255),
                },
                body:
                    @"INSERT [dbo].[Nhan_Vien]([ID_NhanVien], [hoVaTen], [email], [ngaySinh], [gioiTinh], [SDT], [CMND], [diaChi], [anh], [taiKhoanDangNhap])
                      VALUES (@ID_NhanVien, @hoVaTen, @email, @ngaySinh, @gioiTinh, @SDT, @CMND, @diaChi, @anh, @taiKhoanDangNhap)"
            );

            CreateStoredProcedure(
                "dbo.Employee_Update",
                p => new
                {
                    ID_NhanVien = p.String(maxLength: 100),
                    hoVaTen = p.String(maxLength: 255),
                    email = p.String(),
                    ngaySinh = p.DateTime(),
                    gioiTinh = p.String(maxLength: 20),
                    SDT = p.String(maxLength: 20),
                    CMND = p.String(maxLength: 50),
                    diaChi = p.String(maxLength: 255),
                    anh = p.Binary(),
                    taiKhoanDangNhap = p.String(maxLength: 255),
                },
                body:
                    @"UPDATE [dbo].[Nhan_Vien]
                      SET [hoVaTen] = @hoVaTen, [email] = @email, [ngaySinh] = @ngaySinh, [gioiTinh] = @gioiTinh, [SDT] = @SDT, [CMND] = @CMND, [diaChi] = @diaChi, [anh] = @anh, [taiKhoanDangNhap] = @taiKhoanDangNhap
                      WHERE ([ID_NhanVien] = @ID_NhanVien)"
            );

            CreateStoredProcedure(
                "dbo.Employee_Delete",
                p => new
                {
                    ID_NhanVien = p.String(maxLength: 100),
                },
                body:
                    @"DELETE [dbo].[Nhan_Vien]
                      WHERE ([ID_NhanVien] = @ID_NhanVien)"
            );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Employee_Delete");
            DropStoredProcedure("dbo.Employee_Update");
            DropStoredProcedure("dbo.Employee_Insert");
        }
    }
}

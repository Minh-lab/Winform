1. Nhấn vào C# goc phải màn hình có màu xanh lá cây -> add -> Form

2.Thường dùng menustrip để mở form hoặc contextMenustrip

chú ý: Form cha có thuộc tính isMdiParent = true
Form con = false

câu lệnh phải có trong sự kiện(click button, menu .. )

        private void mnuForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            LayoutMdi(MdiLayout.TileHorizontal);
            form2.Show();
        }

        private void mnuForm3_Click(object sender, EventArgs e)
        {
            Form3 form3= new Form3();
            form3.MdiParent = this;
            LayoutMdi(MdiLayout.TileHorizontal);
            form3.Show();
        }

3. sắp xếp form LayoutMdi(MdiLayout.TileHorizontal); theo chiều ngang
                LayoutMdi(MdiLayout.TileVertical); theo chiều dọc
                LayoutMdi(MdiLayout.Cascade); xếp chồng form
                LayoutMdi(MdiLayout.TileArrangeIcons); sắp xếp theo icon


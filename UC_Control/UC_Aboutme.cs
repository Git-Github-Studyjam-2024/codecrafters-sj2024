﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCrafters.UC_Control
{
    public partial class UC_Aboutme : UserControl
    {
        public UC_Aboutme()
        {
            InitializeComponent();
        }
        private void detailCongMinh_click(object sender, EventArgs e)
        {
            CongMinhDetail congminh = new CongMinhDetail();
            congminh.Show();
        }
        private void picTrieuPhi_Click(object sender, EventArgs e)
        {
            TrieuPhiDetail trieuphi =  new TrieuPhiDetail();
            trieuphi.Show();
        }

        private void detailngoctrang_Click(object sender, EventArgs e)
        {
            NgocTrangDetail ngocTrang = new NgocTrangDetail();  
            ngocTrang.Show();
        }
    }
}

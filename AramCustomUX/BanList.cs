using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramCustomUX {
    public partial class BanList : Form {

        enum BanType{
            A,
            B,
            Global
        };

        BanType banType;

        public BanList() {
            InitializeComponent();

            foreach (var champ in Program.champs) {
                ListViewItem item = new ListViewItem(champ);

                if (Program.AbannedChamps.Contains(champ))
                    item.BackColor = Color.FromArgb(255, 200, 200);
                else if (Program.BbannedChamps.Contains(champ))
                    item.BackColor = Color.FromArgb(200, 200, 255);
                else if (Program.GlobalBannedChamps.Contains(champ))
                    item.BackColor = Color.FromArgb(200, 255, 200);

                banListView.Items.Add(item);
            }
        }

        private void banListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (!e.IsSelected)
                return;
            if (Program.AbannedChamps.Contains(e.Item.Text)) {
                Program.AbannedChamps.Remove(e.Item.Text);
                e.Item.BackColor = Color.White; 
            } else if (Program.BbannedChamps.Contains(e.Item.Text)) {
                Program.BbannedChamps.Remove(e.Item.Text);
                e.Item.BackColor = Color.White;
            } else if (Program.GlobalBannedChamps.Contains(e.Item.Text)) {
                Program.GlobalBannedChamps.Remove(e.Item.Text);
                e.Item.BackColor = Color.White;
            } else {
                if (banType == BanType.A) {
                    e.Item.BackColor = Color.FromArgb(255, 200, 200);
                    Program.AbannedChamps.Add(e.Item.Text);
                } else if (banType == BanType.B) {
                    e.Item.BackColor = Color.FromArgb(200, 200, 255);
                    Program.BbannedChamps.Add(e.Item.Text);
                } else {
                    e.Item.BackColor = Color.FromArgb(200, 255, 200);
                    Program.GlobalBannedChamps.Add(e.Item.Text);
                }
            }
                
        }

        private void AbanButton_Click(object sender, EventArgs e) {
            banType = BanType.A;
        }

        private void BbanButton_Click(object sender, EventArgs e) {
            banType = BanType.B;
        }

        private void GlobalBanButton_Click(object sender, EventArgs e) {
            banType = BanType.Global;
        }
    }
}

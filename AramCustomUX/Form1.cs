using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AramCustomUX {
    public partial class Form1 : Form {

        List<string> champsTemp;
        List<string> champsReroll;
        string rerollChamp;
        bool started;

        public Form1() {

            InitializeComponent();
            Clear();
        }

        void Clear() {
            for (int i = 0; i < 10; i++) {
                // A
                (Controls.Find("AchampLabel" + i, true).FirstOrDefault() as Label).Text = string.Empty;
                (Controls.Find("Achamp" + i, true).FirstOrDefault() as PictureBox).Image = null;

                // B
                (Controls.Find("BchampLabel" + i, true).FirstOrDefault() as Label).Text = string.Empty;
                (Controls.Find("Bchamp" + i, true).FirstOrDefault() as PictureBox).Image = null;

                // reroll
                (Controls.Find("rerollLabel", true).FirstOrDefault() as Label).Text = string.Empty;
                (Controls.Find("rerollIcon", true).FirstOrDefault() as PictureBox).Image = null;
            }
        }

        private void newDraftButton_Click(object sender, EventArgs e) {

            Clear();

            champsTemp = new List<string>(Program.champs);
            try {
                // BAN
                foreach (var bannedChamp in Program.AbannedChamps) {
                    champsTemp.Remove(bannedChamp);
                }
                foreach (var bannedChamp in Program.BbannedChamps) {
                    champsTemp.Remove(bannedChamp);
                }
                foreach (var bannedChamp in Program.GlobalBannedChamps) {
                    champsTemp.Remove(bannedChamp);
                }

                TextBox textBox = Controls.Find("teamSizeTextBox", true).FirstOrDefault() as TextBox;
                if (int.TryParse(textBox.Text, out int pool)) {
                    if (pool > 10 || pool < 0) {
                        pool = 10;
                    }
                } else {
                    pool = 10;
                }

                Random rand = new Random();

                string champ;

                // Random for A
                for (int i = 0; i < pool; i++) {

                    int index = rand.Next(0, champsTemp.Count);
                    champ = champsTemp[index];

                    (Controls.Find("AchampLabel" + i, true).FirstOrDefault() as Label).Text = champ;
                    (Controls.Find("Achamp" + i, true).FirstOrDefault() as PictureBox).Image
                        = (Image)Properties.Resources.ResourceManager.GetObject(champ);

                    champsTemp.RemoveAt(index);
                }

                // Random for B
                for (int i = 0; i < pool; i++) {
                    int index = rand.Next(0, champsTemp.Count);
                    champ = champsTemp[index];

                    (Controls.Find("BchampLabel" + i, true).FirstOrDefault() as Label).Text = champ;
                    (Controls.Find("Bchamp" + i, true).FirstOrDefault() as PictureBox).Image
                        = (Image)Properties.Resources.ResourceManager.GetObject(champ);

                    champsTemp.RemoveAt(index);
                }

                champsReroll = new List<string>(champsTemp);
                started = true;
            } catch { }
        }

        void RerollChamp() {
            try {
                int index = new Random().Next(0, champsReroll.Count);
                rerollChamp = champsReroll[index];

                (Controls.Find("rerollLabel", true).FirstOrDefault() as Label).Text = rerollChamp;
                (Controls.Find("rerollIcon", true).FirstOrDefault() as PictureBox).Image
                    = (Image)Properties.Resources.ResourceManager.GetObject(rerollChamp);

                champsReroll.RemoveAt(index);
            } catch {
                // Out of champs
            }
        }

        private void rerollButton_Click(object sender, EventArgs e) {
            if (!started)
                return;

            RerollChamp();
        }

        private void newHumanButton_Click(object sender, EventArgs e) {
            if (!started)
                return;

            if (rerollChamp != null) {
                champsTemp.Remove(rerollChamp);
                champsReroll = new List<string>(champsTemp);
            }

            RerollChamp();
        }

        private void openBanList_Click(object sender, EventArgs e) {
            new BanList().Show();
        }
    }
}

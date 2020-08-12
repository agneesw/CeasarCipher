using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsInlämning2
{
    public partial class Form1 : Form
    {

        Lagring lagring;
        ReversalCipher reversal;
        CaesarChipher caesar;
        OddAndEvenChipher oddeven;
        Rövarspråket rövarspråk;
        bool isEncrypt;
        public Form1()
        {
            InitializeComponent();
            reversal = new ReversalCipher("Reversal");
            caesar = new CaesarChipher("Caesar 3", 3);
            oddeven = new OddAndEvenChipher("Odd And Even Chipher");
            rövarspråk = new Rövarspråket("Rövarspråket");
            AvailableChiffers.Items.Add(oddeven);
            AvailableChiffers.Items.Add(reversal);
            AvailableChiffers.Items.Add(caesar);
            AvailableChiffers.Items.Add(rövarspråk);
            lagring = new Lagring();
            lagring.Add(reversal);
            lagring.Add(caesar);
            lagring.Add(oddeven);
            lagring.Add(rövarspråk);
           
            isEncrypt = false;
            
        }

        /// <summary>
        /// Koden som exekveras när jag trycker på kryptera
        /// </summary>
        
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ChosedChiffers.Items.Count; i++)
            {
                Cipher cipher = (Cipher)ChosedChiffers.Items[i];
                textBox1.Text = cipher.Encrypt(textBox1.Text);
            }

            isEncrypt = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Koden som exekveras när jag trycker på decrypt
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = ChosedChiffers.Items.Count - 1; i >= 0; i--)
            {
                Cipher cipher = (Cipher)ChosedChiffers.Items[i];
                textBox1.Text = cipher.Decrypt(textBox1.Text);
            }
            isEncrypt = false;
        }

        /// <summary>
        /// Koden som exekveras när jag trycker på Add
        /// </summary>

        private void Add_Click(object sender, EventArgs e)
        {
            
            if (AvailableChiffers.SelectedItem != null)
                ChosedChiffers.Items.Add(AvailableChiffers.SelectedItem);
         
        }
        /// <summary>
        /// Koden som exekveras när jag trycker på remove
        /// </summary>

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isEncrypt )
            {
                for (int i = ChosedChiffers.Items.Count - 1; i >= 0; i--)
                {
                    Cipher cipher = (Cipher)ChosedChiffers.Items[i];
                    textBox1.Text = cipher.Decrypt(textBox1.Text);
                }
                isEncrypt = false;
            }

            ChosedChiffers.Items.Remove(ChosedChiffers.SelectedItem);
        }

    }
}

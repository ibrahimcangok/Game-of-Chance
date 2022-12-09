using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            goster(Convert.ToInt32(sayıtxt.Text));
        }
        public void goster(int a)
        {
            gizle();
            if (a >= 1) groupBox1.Visible = true;
            if (a >= 2) groupBox2.Visible = true;
            if (a >= 3) groupBox3.Visible = true;
            if (a >= 4) groupBox4.Visible = true;
            if (a >= 5) groupBox5.Visible = true;
            if (a >= 6) groupBox6.Visible = true;
            if (a >= 7) groupBox7.Visible = true;
            if (a >= 8) groupBox8.Visible = true;
            if (a >= 9) groupBox9.Visible = true;
            if (a >= 10) groupBox10.Visible = true;

        }
        public void gizle()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gizle();
        }

        int[] sayilar = new int[6];
        private void button2_Click(object sender, EventArgs e)
        {

            boyatemizle();

            Random r = new Random();
            int rastgele;
            int sayac = 0;
            
            while (sayac < 6)
            {
                rastgele = r.Next(0, 49);

                if (Array.IndexOf(sayilar, rastgele) == -1)
                {
                    sayilar[sayac] = rastgele;
                    sayac++;
                }
            }
            Array.Sort(sayilar);
            sayı1.Text = sayilar[0].ToString();
            sayı2.Text = sayilar[1].ToString();
            sayı3.Text = sayilar[2].ToString();
            sayı4.Text = sayilar[3].ToString();
            sayı5.Text = sayilar[4].ToString();
            sayı6.Text = sayilar[5].ToString();

            for (int q = 0; q <=5; q++)
            {
                boya1(q);
            }
            for (int w = 0; w <= 5; w++)
            {
                boya2(w);
            }
            for (int v = 0; v <= 5; v++)
            {
                boya3(v);
            }
            for (int j = 0; j <= 5; j++)
            {
                boya4(j);
            }
            for (int t = 0; t <= 5; t++)
            {
                boya5(t);
            }
            for (int y = 0; y <= 5; y++)
            {
                boya6(y);
            }
        }
       public void boya1(int c)
    {
        if (sayilar[c].ToString() == s1.Text)
            s1.BackColor = Color.Green;
        if (sayilar[c].ToString() == s2.Text)
            s2.BackColor = Color.Green;
        if (sayilar[c].ToString() == s3.Text)
            s3.BackColor = Color.Green;
        if (sayilar[c].ToString() == s4.Text)
           s4.BackColor = Color.Green;
        if (sayilar[c].ToString() == s5.Text)
            s5.BackColor = Color.Green;
        if (sayilar[c].ToString() == s6.Text)
            s6.BackColor = Color.Green;
        if (sayilar[c].ToString() == s7.Text)
            s7.BackColor = Color.Green;
        if (sayilar[c].ToString() == s8.Text)
            s8.BackColor = Color.Green;
        if (sayilar[c].ToString() == s9.Text)
            s9.BackColor = Color.Green;
        if (sayilar[c].ToString() == s10.Text)
            s10.BackColor = Color.Green;
    }

       public void boya2(int b)
       {
           if (sayilar[b].ToString() == s11.Text)
               s11.BackColor = Color.Green;
           if (sayilar[b].ToString() == s12.Text)
               s12.BackColor = Color.Green;
           if (sayilar[b].ToString() == s13.Text)
               s13.BackColor = Color.Green;
           if (sayilar[b].ToString() == s14.Text)
               s14.BackColor = Color.Green;
           if (sayilar[b].ToString() == s15.Text)
               s15.BackColor = Color.Green;
           if (sayilar[b].ToString() == s16.Text)
               s16.BackColor = Color.Green;
           if (sayilar[b].ToString() == s17.Text)
               s17.BackColor = Color.Green;
           if (sayilar[b].ToString() == s18.Text)
               s18.BackColor = Color.Green;
           if (sayilar[b].ToString() == s19.Text)
               s19.BackColor = Color.Green;
           if (sayilar[b].ToString() == s20.Text)
               s20.BackColor = Color.Green;
       }


       public void boya3(int d)
       {
           if (sayilar[d].ToString() == s21.Text)
               s21.BackColor = Color.Green;
           if (sayilar[d].ToString() == s22.Text)
               s22.BackColor = Color.Green;
           if (sayilar[d].ToString() == s23.Text)
               s23.BackColor = Color.Green;
           if (sayilar[d].ToString() == s24.Text)
               s24.BackColor = Color.Green;
           if (sayilar[d].ToString() == s25.Text)
               s25.BackColor = Color.Green;
           if (sayilar[d].ToString() == s26.Text)
               s26.BackColor = Color.Green;
           if (sayilar[d].ToString() == s27.Text)
               s27.BackColor = Color.Green;
           if (sayilar[d].ToString() == s28.Text)
               s28.BackColor = Color.Green;
           if (sayilar[d].ToString() == s29.Text)
               s29.BackColor = Color.Green;
           if (sayilar[d].ToString() == s30.Text)
               s30.BackColor = Color.Green;
       }

       public void boya4(int f)
       {
           if (sayilar[f].ToString() == s31.Text)
               s31.BackColor = Color.Green;
           if (sayilar[f].ToString() == s32.Text)
               s32.BackColor = Color.Green;
           if (sayilar[f].ToString() == s33.Text)
               s33.BackColor = Color.Green;
           if (sayilar[f].ToString() == s34.Text)
               s34.BackColor = Color.Green;
           if (sayilar[f].ToString() == s35.Text)
               s35.BackColor = Color.Green;
           if (sayilar[f].ToString() == s36.Text)
               s36.BackColor = Color.Green;
           if (sayilar[f].ToString() == s37.Text)
               s37.BackColor = Color.Green;
           if (sayilar[f].ToString() == s38.Text)
               s38.BackColor = Color.Green;
           if (sayilar[f].ToString() == s39.Text)
               s39.BackColor = Color.Green;
           if (sayilar[f].ToString() == s40.Text)
               s40.BackColor = Color.Green;
       }
       public void boya5(int h)
       {
           if (sayilar[h].ToString() == s41.Text)
               s41.BackColor = Color.Green;
           if (sayilar[h].ToString() == s42.Text)
               s42.BackColor = Color.Green;
           if (sayilar[h].ToString() == s43.Text)
               s43.BackColor = Color.Green;
           if (sayilar[h].ToString() == s44.Text)
               s44.BackColor = Color.Green;
           if (sayilar[h].ToString() == s45.Text)
               s45.BackColor = Color.Green;
           if (sayilar[h].ToString() == s46.Text)
               s46.BackColor = Color.Green;
           if (sayilar[h].ToString() == s47.Text)
               s47.BackColor = Color.Green;
           if (sayilar[h].ToString() == s48.Text)
               s48.BackColor = Color.Green;
           if (sayilar[h].ToString() == s49.Text)
               s49.BackColor = Color.Green;
           if (sayilar[h].ToString() == s50.Text)
               s50.BackColor = Color.Green;
       }       
        public void boya6(int k)
       {
           if (sayilar[k].ToString() == s51.Text)
               s51.BackColor = Color.Green;
           if (sayilar[k].ToString() == s52.Text)
               s52.BackColor = Color.Green;
           if (sayilar[k].ToString() == s53.Text)
               s53.BackColor = Color.Green;
           if (sayilar[k].ToString() == s54.Text)
               s54.BackColor = Color.Green;
           if (sayilar[k].ToString() == s55.Text)
               s55.BackColor = Color.Green;
           if (sayilar[k].ToString() == s56.Text)
               s56.BackColor = Color.Green;
           if (sayilar[k].ToString() == s57.Text)
               s57.BackColor = Color.Green;
           if (sayilar[k].ToString() == s58.Text)
               s58.BackColor = Color.Green;
           if (sayilar[k].ToString() == s59.Text)
               s59.BackColor = Color.Green;
           if (sayilar[k].ToString() == s60.Text)
               s60.BackColor = Color.Green;
       }
       void boyatemizle()
       {
           s1.BackColor = Color.White;
           s2.BackColor = Color.White;
           s3.BackColor = Color.White;
           s4.BackColor = Color.White;
           s5.BackColor = Color.White;
           s6.BackColor = Color.White;
           s7.BackColor = Color.White;
           s8.BackColor = Color.White;
           s9.BackColor = Color.White;
           s10.BackColor = Color.White;
           s11.BackColor = Color.White;
           s12.BackColor = Color.White;
           s13.BackColor = Color.White;
           s14.BackColor = Color.White;
           s15.BackColor = Color.White;
           s16.BackColor = Color.White;
           s17.BackColor = Color.White;
           s18.BackColor = Color.White;
           s19.BackColor = Color.White;
           s20.BackColor = Color.White;
           s21.BackColor = Color.White;
           s22.BackColor = Color.White;
           s23.BackColor = Color.White;
           s24.BackColor = Color.White;
           s25.BackColor = Color.White;
           s26.BackColor = Color.White;
           s27.BackColor = Color.White;
           s28.BackColor = Color.White;
           s29.BackColor = Color.White;
           s30.BackColor = Color.White;
           s31.BackColor = Color.White;
           s32.BackColor = Color.White;
           s33.BackColor = Color.White;
           s34.BackColor = Color.White;
           s35.BackColor = Color.White;
           s36.BackColor = Color.White;
           s37.BackColor = Color.White;
           s38.BackColor = Color.White;
           s39.BackColor = Color.White;
           s40.BackColor = Color.White;
           s41.BackColor = Color.White;
           s42.BackColor = Color.White;
           s43.BackColor = Color.White;
           s44.BackColor = Color.White;
           s45.BackColor = Color.White;
           s46.BackColor = Color.White;
           s47.BackColor = Color.White;
           s48.BackColor = Color.White;
           s49.BackColor = Color.White;
           s50.BackColor = Color.White;
           s51.BackColor = Color.White;
           s52.BackColor = Color.White;
           s53.BackColor = Color.White;
           s54.BackColor = Color.White;
           s55.BackColor = Color.White;
           s56.BackColor = Color.White;
           s57.BackColor = Color.White;
           s58.BackColor = Color.White;
           s59.BackColor = Color.White;
           s60.BackColor = Color.White;
       }
    }
}


            
                  
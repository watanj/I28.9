using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace it28
{
    public partial class Form1 : Form
    {
        /*
            Label: Pelaaja1 nopan arvo
            Label: Pelaaja2 nopan arvo
            Label: Ilmoitus, kumpi pelaaja voitti
            Button: Pelaaja1 nopan heitto
            Button: Pelaaja2 nopan heitto
            Button: Resetoi pelin 
         
            Tee sovellus, jossa kaksi pelaajaa heittää noppaa. Molempien pelaajien heitettyä noppaa,
            ilmoitetaan voittaja. Sovelluksessa on resetointi nappi, jolla peli alkaa alusta. 

            Sovelluksen vaiheet on purettu alla. Tee sovellusta mahdollisimman pitkälle ja palauta lopun ohjeiden mukaan.
            


        Lisää projektiin "Dice"-luokka, jossa property "Value" ja method "Roll".
        Sovelluksen Form:ssa luodaan kaksi objektia "Dice"-luokasta, yksi kummallekin pelaajalle.
       
        Lisää pelaajien nopan heitto Button:lle Click-event, jossa heidän noppa objekteja heitetään käyttämällä "Roll"-metodia.
        Heittojen jälkeen päivitetään pelaajien Label:ien tekstit. Lisäksi Button:eja voi klikata vain yhden kerran per kierros.
        
        Lisää resetointi Button:in toiminnallisuus. Piiloitetaan Label:it ja Button:eja voi klikata taas.
        
        Kun molemmat pelaajat ovat heittäneet nopat, ilmoita voittaja Label:ssä. Resetoidessa piiloita myös tämä Label.
        
        Korvaa Labelit PictureBoxeilla. Eli noppien arvot näytetään käyttöliittymässä kuvien avulla.
        */
        public Form1() // constructor, suoritetaan heti alussa
        {
            InitializeComponent();

            

        }
      
        Random rng = new Random();
        Dice pel1 = new Dice();
        Dice pel2 = new Dice();
      
        bool btn1 = false;
        bool btn2 = false;

        int i = 2;
        int k = 2;
        private void buttonpel1_Click(object sender, EventArgs e)
        {

            btn1 = true;
            
            i--;
                if (i <= 0)
                {

                labelpel1.Text = "Vain yksi Heitto sallittu";

                }
                else
                {
                    pel1.Roll(rng);
                    labelpel1.Text = pel1.Value.ToString();
                   
                    test();
                }
        }

        private void buttonpel2_Click(object sender, EventArgs e)
        {

            btn2 = true;
            k--;

            if (k <= 0)
            {

                labelpel2.Text = "Vain yksi Heitto sallittu";

            }
            else
            {
                pel2.Roll(rng);
                labelpel2.Text = pel2.Value.ToString();
               

                test();
            }         
        }
        public void test()
        {
            if (btn1 && btn2)
            {
                if (pel1.Value > pel2.Value)
                {

                    labelwinner.Text = "pelaaja yksi voitti";
                }
                if (pel1.Value == pel2.Value)
                {
                    labelwinner.Text = "tasapeli ";
                }
                if  (pel1.Value < pel2.Value)
                {
                    labelwinner.Text = "pelaaja kaksi voitti";
                }
            }           
        }


        private void buttonreset_Click(object sender, EventArgs e)
        {
            i = 2;
            k = 2;
            labelpel1.Text = " ";
            labelpel2.Text = " ";
            labelwinner.Text = " ";
            btn1 = false;
            btn2 = false;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}

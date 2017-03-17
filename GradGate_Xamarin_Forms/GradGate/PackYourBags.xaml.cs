using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GradGate
{
    public partial class PackYourBags : ContentPage
    {
        public PackYourBags()
        {
            InitializeComponent();
            textLabel.IsVisible = false;
            textLabel1.IsVisible = false;
            textLabel2.IsVisible = false;
            textLabel3.IsVisible = false;
            textLabel4.IsVisible = false;


            var tapGestureRecognizer = new TapGestureRecognizer();
            var tapGestureRecognizer1 = new TapGestureRecognizer();
            var tapGestureRecognizer2 = new TapGestureRecognizer();
            var tapGestureRecognizer3 = new TapGestureRecognizer();
            var tapGestureRecognizer4 = new TapGestureRecognizer();
            WebViewPage wv = new WebViewPage();


            int tapcount = 1;
            int tapcount1 = 1;
            int tapcount2 = 1;
            int tapcount3 = 1;
            int tapcount4 = 1;


            tapGestureRecognizer.Tapped += (s, e) =>
            {
                tapcount++;

                if (tapcount % 2 == 0)
                {
                    textLabel.IsVisible = true;
                    textLabel.Text = " * 5 sets of good shirts"
                + "\n * A good set of swimwear"
                + "\n * 3-4 ties and 1-2 belts for boys"
                + "\n * 10 sets of socks, handkerchiefs"
                + "\n * 3 towels and 3 handtowels"
                + "\n * 2 bedsheets"
                + "\n * 2-4 sets of thermal wear for cold places"
                + "\n * Traditional wear"
                + "\n * Formal wear"
                + "\n * Woolen sweaters,cap,socks, handgloves"
                ;
                }
                else
                {
                    textLabel.IsVisible = false;
                }
                
            };
                
            listLabel.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer1.Tapped += (s, e) =>
            {
                tapcount1++;

                if (tapcount1 % 2 == 0)
                {
                    textLabel1.IsVisible = true;
                    textLabel1.Text = " * Crocin - Fever"
                + "\n * Cyclopam - bdominal Cramps due"
                + "\n * Lomotiil/Emodium -to stop loose motions"
                + "\n * Electral Powder - For vomiting"
                + "\n * Sparta 200 mg - Mild Antibiotic(general)"
                + "\n * Erythrocin/Azee 500mg - tonsillitis"
                + "\n * Amoxicillin 500 mg - tomach/intestinal"
                + "\n * Cephalexin 500 mg - general infections"
                + "\n * Norflox 400 mg - intestinal infections"
                + "\n * Pudin Hara - stomach ache/gases"
                + "\n * Salbutomol/Ventorlin inhaler - asthma"
                + "\n * Omez/Zantac/Raciper - antacid"
                + "\n * Gelucil Liq/tab - antacid"
                + "\n * Vicks vaporub - headache"
                + "\n * Wikoril - cold"
                + "\n * Savion liquid - cleaning wounds"
                ;
                }
                else
                {
                    textLabel1.IsVisible = false;
                }
            };
            listLabel1.GestureRecognizers.Add(tapGestureRecognizer1);


            tapGestureRecognizer2.Tapped += (s, e) =>
            {
                tapcount2++;
              
                if (tapcount2 % 2 == 0)
                {
                    textLabel2.IsVisible = true;
                    textLabel2.Text = " * Pressure cooker(3- 4 litres)"
                + "\n * 2-3 Small bowls"
                + "\n * Rolling pin"
                + "\n * Knife"
                + "\n * Frying pan"
                + "\n * Plate"
                ;
            }
                else
                {
                textLabel2.IsVisible = false;
            }
        };
            listLabel2.GestureRecognizers.Add(tapGestureRecognizer2);

            tapGestureRecognizer3.Tapped += (s, e) =>
            {

                tapcount3++;

                if (tapcount3 % 2 == 0)
                {
                    textLabel3.IsVisible = true;
                    textLabel3.Text = " *Back pack"
                + "\n * Scientific calculator"
                + "\n * Clutch pencils"
                + "\n * Airmail envelopes"
                + "\n * NailCutter"
                + "\n * Harddisk"
                + "\n * Novels"
                + "\n * Laptop"
                ;
                }
                else
                {
                    textLabel3.IsVisible = false;
                }
            };
            listLabel3.GestureRecognizers.Add(tapGestureRecognizer3);

            tapGestureRecognizer4.Tapped += (s, e) =>
            {
                tapcount4++;

                if (tapcount4 % 2 == 0)
                {
                    textLabel4.IsVisible = true;
                    textLabel4.Text = " * Indian tea/coffee"
                + "\n * Common lentils(dals)"
                + "\n * Readymade masals"
                + "\n * Instant Food Products"
                + "\n * Mustard(rai/mohri)"
                + "\n * Turmeric(haldi)"
                + "\n * Red chilli powder(lal mirchi)"
                + "\n * Coriander powder(dhania powder)"
                + "\n * Asafetida(hing)"
                + "\n * Cumin seed(jeera)"
                + "\n * Ajwain(owa)"
                + "\n * Pepper(kali mirchi/kali miri)"
                + "\n * Cardamom(elaichi)"
                + "\n * Gloves (laung/ lawang)"
                ;
            }
                else
                {
                textLabel4.IsVisible = false;
            }
        };
            listLabel4.GestureRecognizers.Add(tapGestureRecognizer4);

        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;


namespace AvoidGarbageProStar {
    public partial class Form1 : Form
    {
        List<tickles> masda;
        int[] crapeau = { 960, 540, 0 };
        bool canard = true;
        int caunteur = 0;
        int caunteureur = 0;
        bool crackers = true;
        int[][] captus = new int[10][];
        public Form1()
        {
            InitializeComponent();
            captus[0] = new int[3];captus[1] = new int[3];captus[2] = new int[3];captus[3] = new int[3];captus[4] = new int[3];captus[5] = new int[3];captus[6] = new int[3];captus[7] = new int[3];captus[8] = new int[3];captus[9] = new int[3];
            captus[0][0] = -3;
            captus[0][1] = 10;
            captus[0][2] = 1080;
            captus[1][0] = -3;
            captus[1][1] = 10;
            captus[1][2] = 1080;
            captus[2][0] = -3;
            captus[2][1] = 10;
            captus[2][2] = 1080;
            captus[3][0] = -3;
            captus[3][1] = 10;
            captus[3][2] = 1080;
            captus[4][0] = -3;
            captus[4][1] = 10;
            captus[4][2] = 1080;
            captus[5][0] = -3;
            captus[5][1] = 10;
            captus[5][2] = 1080;
            captus[6][0] = -3;
            captus[6][1] = 10;
            captus[6][2] = 1080;
            captus[7][0] = -3;
            captus[7][1] = 10;
            captus[7][2] = 1080;
            captus[8][0] = -3;
            captus[8][1] = 10;
            captus[8][2] = 1080;
            captus[9][0] = -3;
            captus[9][1] = 10;
            captus[9][2] = 1080;
            

            //masda=new List<tickles>();
            while (canard)
            {

            }
            /*tristepoisson();

            gamzz();*/
            
        }
        private  gamzz()
        {
            while (I5InMyPokets(96) != "MyBadBro" && canard) {/*dommage il se passe rien, maurice modifie ça stp*/ }
            troufion();
        }
        private String I5InMyPokets(int mishail)
        {if (mishail + 2 >= 3) { cauntair(); return "Troue"; /* it didn't work in booléanne */} return "MyBadBro";}
        private void boucletteBrothers(String Sonic, int crapoteur200) { if (!string.IsNullOrEmpty(Sonic) && crapoteur200 < 300000000) { globule(crapoteur200); } else { foreach (tickles brandon in masda) { parkourierre(new int[3][],35,brandon); }}}
        private void sphinctere(int sphincter)
        {
            if (sphincter < 10)
            {
                tickles riddle = new tickles("crapo");
                riddle.rigolad = 0;
                riddle.crapeaud = 0;
                riddle.miguelcestmichel = 0;
                riddle.litshis = sphincter;
                sphinctere(sphincter+1);
            }
        }
        private void globule(int crapoteuse2lastreet) { String troi = "3"; boucletteBrothers(Int32.Parse(troi).ToString(), 300000001);}
        private void tristepoisson()
        {
            //desactiver tous les déchets, ecran de start
            baril1.Visible = false;
            baril2.Visible = false;
            baril3.Visible = false;
            baril4.Visible = false;
            baril5.Visible = false;
            baril6.Visible = false;
            baril7.Visible = false;
            baril8.Visible = false;
            baril9.Visible = false;
            baril10.Visible = false;
            poissonBas.Visible = false;
            poissonHaut.Visible = false;
            poissonDroite.Visible = false;
            gameOverBox.Visible = false;
            retryButton.Visible = false;
            quitButton.Visible = false;
        }
        private void cauntair()
        {
            if (caunteur == 30)
            {
                caunteur = 0;
                caunteureur += 1;
                ScoreLabel.Text = "Score: " + caunteureur + "S";
            }
        }
        private void parkourierre(int[][] parkourierre, int KrAkEnDaNlJardin, tickles brandonnette)
        {
            if(brandonnette.litshis%2==1){brandonnette.rigolad=brandonnette.rigolad+21;}else{brandonnette.rigolad=brandonnette.rigolad-21;}
            if (brandonnette.rigolad - 100 < crapeau[0] && crapeau[0] < brandonnette.rigolad + 100 && brandonnette.crapeaud - 100 < crapeau[1] && crapeau[1] < brandonnette.crapeaud +100)
            {
                canard = false;
            }
            brandonnette.crapeaud = brandonnette.rigolad * brandonnette.rigolad * captus[brandonnette.singe][0] + brandonnette.rigolad * captus[brandonnette.singe][1] + captus[brandonnette.singe][2]; ;
        }
        void troufion()
        {
            //affichage du game over et ecran de selection de retry avec score
        }
        //fonctions  à cacher dans le code
        private void brouette2jardin2grenob(int[] hachoir)
        {
                if (masda[hachoir[0]].litshis % 2 == 1) { masda[hachoir[0]].rigolad = masda[hachoir[0]].rigolad + 21; } else { masda[hachoir[0]].rigolad = masda[hachoir[0]].rigolad - 21; }

        }
        private void gonfreaks(int[] batracien)
        {
            //modification  de la position vers le haut
        }
        private void crapeaud(int[] baracienne)
        {
            //modifiaction de la position du poisson vers le bas
        }
        private void multipriseikea3fish(int[] miguelcestmichel)
        {
            //modification de la position du poisson vers la droite
        }
        private void litshit(int[] pizzaronde) {
            //modification de la position du poisson vers la gauche
        }

        private void Start_Click(object sender, EventArgs e)
        {
            canard = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            gamzz();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int[] nini = new int[2];
            nini[0] = 0;
            nini[1] = 0;
            brouette2jardin2grenob(nini);
            int[][] nino = new int[1][];
            nino[0] = new int[1];
            nino[0][0] = 33;
            foreach (tickles brandon in masda) { parkourierre(new int[3][], 35, brandon); }
            if (e.KeyCode == Keys.Up)
            {

                crapeau[1] += 28;
            }
            else if (e.KeyCode == Keys.Down) { crapeau[1] -= 28; }
            else if (e.KeyCode == Keys.Left) { crapeau[0] -= 28; }
            else if(e.KeyCode == Keys.Right) { crapeau[0] += 28; }
            /*poissonGauche.Location.X = crapeau[0];
            poissonGauche.Location.Y = crapeau[1];*/

        }
    }
    class tickles{ public string n;public int rigolad;public int singe;public int crapeaud;public int miguelcestmichel;public int litshis;public tickles(string nom) { n = nom; List<tradition>gateau=new List<tradition>();}public void ajouter(DateTime dt, float x, float y, float r) { int r2 = 3; int r3 = r2 + 5; int r4 = r2 + 5; int r5 = r4 + 1; int r6 = r5 + r5; int r7 = r2; int r91 = r3; int r92 = r3; int r8 = r2; int r9 = r2 + 8; int r10 = r3; int r11 = r2; } public void afficher() { Console.WriteLine($"Déplacementsdel'objet{n}:");} private void marcelpagnol(tradition tr) { for (int i = 0; i < 1; i++);Console.WriteLine("Date: 24,32, Position: (12,17), Rotation: 12 degrés"); } class tradition { public DateTime dt; public float x, y, r; public tradition(DateTime date, float xx, float yy, float rr, int rigolad, int v) { dt = date; x = xx; y = yy; r = rr; v = 4; } class schrekblurk { public void tickles() { var g = new tickles("crapeau"); g.ajouter(DateTime.Now, 0, 0, 0);g.ajouter(DateTime.Now.AddSeconds(1),1,1,45);g.ajouter(DateTime.Now.AddSeconds(2),2,2,90);for (int i=0;i<1;i++){g.afficher();}}}}}}

using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

/*
2023 - SAE 2.3 : Calculateur de masque réseau
Groupe composé de :
COIFFIN Nina
D'ALMEIDA Uriel
NORMAND Thomas
MUCHEMBLED Gaëtan
PETIT Quentin
SOUCHERE Jules
 */

namespace Sae_2._3_Réseau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Conversion d'un Binaire en Décimal
        string BinVersDec(string bins)
        {
            int bin = Convert.ToInt32(bins);
            int x = 0;
            int y = bin;
            string res = string.Empty;


            if (y >= 10000000)
            {
                x = x + 128;
                y = y - 10000000;
            }
            if (y >= 1000000)
            {
                x = x + 64;
                y = y - 1000000;
            }
            if (y >= 100000)
            {
                x = x + 32;
                y = y - 100000;
            }
            if (y >= 10000)
            {
                x = x + 16;
                y = y - 10000;
            }
            if (y >= 1000)
            {
                x = x + 8;
                y = y - 1000;
            }
            if (y >= 100)
            {
                x = x + 4;
                y = y - 100;
            }
            if (y >= 10)
            {
                x = x + 2;
                y = y - 10;
            }
            if (y >= 1)
            {
                x = x + 1;
                y = y - 1;
            }
            res = Convert.ToString(x);
            return res;
        }

        //Conversion d'un Décimal en Binaire
        string DecVersBin(string decs)
        {
            int dec = Convert.ToInt32(decs);
            int y = dec;
            int bin = 0;
            string res = string.Empty;

            if (y >= 128)
            {
                bin = bin + 10000000;
                y = y - 128;
            }
            if (y >= 64)
            {
                bin = bin + 1000000;
                y = y - 64;
            }
            if (y >= 32)
            {
                bin = bin + 100000;
                y = y - 32;
            }
            if (y >= 16)
            {
                bin = bin + 10000;
                y = y - 16;
            }
            if (y >= 8)
            {
                bin = bin + 1000;
                y = y - 8;
            }
            if (y >= 4)
            {
                bin = bin + 100;
                y = y - 4;
            }
            if (y >= 2)
            {
                bin = bin + 10;
                y = y - 2;
            }
            if (y >= 1)
            {
                bin = bin + 1;
                y = y - 1;
            }
            res = Convert.ToString(bin);
            res = RajoutDeZeros(res);
            return res;
        }

        //Conversion d'un Binaire en Hexadécimal
        string BinVersHex(string bins)
        {
            string hexa = string.Empty;
            int bin1 = 0;
            int bin2 = 0;
            int bin = Convert.ToInt32(bins);

            string hexa1 = string.Empty;
            string hexa2 = string.Empty;



            bin2 = bin % 10000;
            bin1 = bin / 10000;

            hexa1 = DemiBinVersDemiHexa(bin1);
            hexa2 = DemiBinVersDemiHexa(bin2);

            hexa = hexa1 + hexa2;

            return hexa;
        }

        //Utilisé dans la conversion d'un Bianire en Hexadécimal
        string DemiBinVersDemiHexa(int bin)
        {
            string hex = string.Empty;
            switch (bin)
            {
                case 0:
                    hex = "0";
                    break;
                case 1:
                    hex = "1";
                    break;
                case 10:
                    hex = "2";
                    break;
                case 11:
                    hex = "3";
                    break;
                case 100:
                    hex = "4";
                    break;
                case 101:
                    hex = "5";
                    break;
                case 110:
                    hex = "6";
                    break;
                case 111:
                    hex = "7";
                    break;
                case 1000:
                    hex = "8";
                    break;
                case 1001:
                    hex = "9";
                    break;
                case 1010:
                    hex = "A";
                    break;
                case 1011:
                    hex = "B";
                    break;
                case 1100:
                    hex = "C";
                    break;
                case 1101:
                    hex = "D";
                    break;
                case 1110:
                    hex = "E";
                    break;
                case 1111:
                    hex = "F";
                    break;
            }
            return hex;
        }

        //Conversion d'un Hexadécimal en Binaire
        string HexVersBin(string hex)
        {
            char hex1 = hex[0];
            char hex2 = hex[1];
            string bin = string.Empty;
            string bin1 = string.Empty;
            string bin2 = string.Empty;
            int int1 = 0;
            int int2 = 0;

            int1 = DemiHexVersDemiBin(hex1);
            int2 = DemiHexVersDemiBin(hex2);

            bin1 = IntVersString(int1);
            bin2 = IntVersString(int2);

            bin = bin1 + bin2;

            return bin;

        }

        //Fonction utilsée dans la converion d'un Hexadécimal en Binaire
        int DemiHexVersDemiBin(char hexc)
        {
            string hex = Char.ToString(hexc);
            int bin = 0;
            switch (hex)
            {
                case "0":
                    bin = 0;
                    break;
                case "1":
                    bin = 1; break;
                case "2":
                    bin = 10; break;
                case "3":
                    bin = 11; break;
                case "4":
                    bin = 100; break;
                case "5":
                    bin = 101; break;
                case "6":
                    bin = 110; break;
                case "7":
                    bin = 111; break;
                case "8":
                    bin = 1000; break;
                case "9":
                    bin = 1001; break;
                case "A":
                    bin = 1010; break;
                case "B":
                    bin = 1011; break;
                case "C":
                    bin = 1100; break;
                case "D":
                    bin = 1101; break;
                case "E":
                    bin = 1110; break;
                case "F":
                    bin = 1111; break;
            }

            return bin;
        }

        //Fonction utilisée dans la conversion d'un Hexadécimal en Binaire
        string IntVersString(int bin)
        {
            string bins = string.Empty;

            bins = bins + bin;
            if (bin < 999)
            {
                bins = "0" + bin;
            }
            if (bin < 99)
            {
                bins = "00" + bin;
            }
            if (bin < 9)
            {
                bins = "000" + bin;
            }

            return bins;
        }

        //Fonction utilisée dans la conversion d'un décimal en binaire
        string RajoutDeZeros(string bins)
        {
            string res = string.Empty;
            int bin = Convert.ToInt32(bins);

            res = bins;

            if (bin < 9999999)
            {
                res = "0" + bins;
            }
            if (bin < 999999)
            {
                res = "00" + bins;
            }
            if (bin < 99999)
            {
                res = "000" + bins;
            }
            if (bin < 9999)
            {
                res = "0000" + bins;
            }
            if (bin < 999)
            {
                res = "00000" + bins;
            }
            if (bin < 99)
            {
                res = "000000" + bins;
            }
            if (bin < 9)
            {
                res = "0000000" + bins;
            }

            return res;
        }

        //Fonction chargée de vérifier si un Hexadécimal est au bon format, de 00 à FF compris
        int VerifHexa(string hexa)
        {
            char hex1 = hexa[0];
            char hex2 = hexa[1];

            int test1 = 0;
            int test2 = 0;

            test1 = VerifUnHexa(hex1);
            test2 = VerifUnHexa(hex2);

            if (test1 == 0 && test2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //Fonctoin utilisée dans la vérification d'un Hexadécimal
        int VerifUnHexa(char hexa)
        {
            if (hexa == '0' || hexa == '1' || hexa == '2' || hexa == '3' || hexa == '4' || hexa == '5'
                || hexa == '6' || hexa == '7' || hexa == '8' || hexa == '9' || hexa == 65 || hexa == 66
                 || hexa == 67 || hexa == 68 || hexa == 69 || hexa == 70)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //Fonction chargée de vérifier le bon format d"un bianire (8 caractères de long, que des 0 et 1)
        int VerifBinaire(string bin)
        {
            int res = 0;

            if (bin.Length == 8)
            {
                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] != '0' && bin[i] != '1')
                    {
                        res = res + 1;
                    }
                }
            }
            else
            {
                res = 1;
            }

            return res;
        }

        //Fonction chargée de vérifier un masque au format décimal
        int TestMasque(string masque1, string masque2, string masque3, string masque4)
        {
            int test1 = 0;
            int test2 = 0;
            int test3 = 0;
            int test4 = 0;
            int test = 0;
            int Ptest = 0;

            Ptest = Ptest + Convert.ToInt32(int.TryParse(masque1, out int x));
            Ptest = Ptest + Convert.ToInt32(int.TryParse(masque2, out x));
            Ptest = Ptest + Convert.ToInt32(int.TryParse(masque3, out x));
            Ptest = Ptest + Convert.ToInt32(int.TryParse(masque4, out x));

            if (Ptest == 4)
            {
                int m1 = Convert.ToInt32(masque1);
                int m2 = Convert.ToInt32(masque2);
                int m3 = Convert.ToInt32(masque3);
                int m4 = Convert.ToInt32(masque4);

                test1 = TestUnMasque(masque1);
                test2 = TestUnMasque(masque2);
                test3 = TestUnMasque(masque3);
                test4 = TestUnMasque(masque4);

                if (m1 != 255)
                {
                    test = 1;
                }
                else if (m2 != 255)
                {
                    if (m3 != 0 || m4 != 0)
                    {
                        test = 1;
                    }
                }
                else if (m3 != 255)
                {
                    if (m4 != 0)
                    {
                        test = 1;
                    }
                }

                if (m4 == 255)
                {
                    test = 1;
                }

                if (test1 != 0 || test2 != 0 || test3 != 0 || test4 != 0)
                {
                    test = 1;
                }
            }

            return test;
        }

        //Fonction utilisée dans la vérification d'un masque décimal
        int TestUnMasque(string masque)
        {
            int test = 0;
            int m1 = Convert.ToInt32(masque);

            if (m1 != 255 && m1 != 254 && m1 != 252 & m1 != 248 && m1 != 240 && m1 != 224 && m1 != 192 && m1 != 128 && m1 != 0)
            {
                test = 1;
            }
            return test;

        }

        //Fonction chargée de transformer une notation CIDR en binaire
        string MasqueCIDR(int CIDR)
        {
            string masque = string.Empty;
            int i = 0;
            int j = 0;

            for (i = 0; i < CIDR; i++)
            {
                masque = masque + '1';
            }
            for (j = i; j < 32; j++)
            {
                masque = masque + "0";
            }
            return masque;
        }

        //Fonction chargée de couper une chaine binaire de longueur 32 en 1 chaine de longueur 8 selon un indice
        string CouperBin(string masque, int n)
        {
            string bmasque = string.Empty;
            int j = n * 8;

            for (int i = j; i < j + 8; i++)
            {
                if (masque[i] == '0')
                {
                    bmasque = bmasque + "0";
                }
                if (masque[i] == '1')
                {
                    bmasque = bmasque + "1";
                }
            }

            return bmasque;
        }

        string MasqueDec(string m1, string m2, string m3, string m4)
        {
            int compt = 0;
            string CIDR = string.Empty;
            m1 = DecVersBin(m1);
            m2 = DecVersBin(m2);
            m3 = DecVersBin(m3);
            m4 = DecVersBin(m4);

            compt = compt + (UnMasqueDec(m1));
            compt = compt + (UnMasqueDec(m2));
            compt = compt + (UnMasqueDec(m3));
            compt = compt + (UnMasqueDec(m4));

            CIDR = Convert.ToString(compt);

            return CIDR;
        }

        int UnMasqueDec(string masque)
        {
            int compt = 0;
            for (int i = 0; i < 8; i++)
            {
                if (masque[i] == '1')
                {
                    compt++;
                }
            }

            return compt;
        }

        //fonction Classe
        string Classe(string P1)
        {
            int x = Convert.ToInt32(P1);
            if (x >= 0 && x <= 127)
            {
                P1 = "A";
            }
            if (x >= 128 && x <= 191)
            {
                P1 = "B";
            }
            if (x >= 192 && x <= 223)
            {
                P1 = "C";
            }
            if (x >= 224 && x <= 239)
            {
                P1 = "D";
            }
            if (x >= 240 && x <= 255)
            {
                P1 = "E";
            }
            if (x < 0 || x > 255)
            {
                P1 = "Erreur";
            }

            return P1;
        }



        //fonction Nb_IP


        string Nb_IP(string ip1, string ip2, string ip3, string ip4, string m1, string m2, string m3, string m4)
        {
            string mqb1 = DecVersBin(m1);
            string mqb2 = DecVersBin(m2);
            string mqb3 = DecVersBin(m3);
            string mqb4 = DecVersBin(m4);

            int mb1 = Convert.ToInt32(m1);
            int mb2 = Convert.ToInt32(m2);
            int mb3 = Convert.ToInt32(m3);
            int mb4 = Convert.ToInt32(m4);

            double res = 0;
            int nbbitip = 32;
            int compt = 0;
            string nbip;

            /////////////////////////////////

            if (mb1 != 0)
            {
                for (int i = 0; i != 8; i++)
                {
                    if (mqb1[i] == '1')
                    {
                        compt = compt + 1;
                    }
                }

            }

            if (mb2 != 0)
            {
                for (int i = 0; i != 8; i++)
                {
                    if (mqb2[i] == '1')
                    {
                        compt = compt + 1;
                    }
                }
            }

            if (mb3 != 0)
            {
                for (int i = 0; i != 8; i++)
                {
                    if (mqb3[i] == '1')
                    {
                        compt = compt + 1;
                    }
                }
            }

            if (mb4 != 0)
            {
                for (int i = 0; i != 8; i++)
                {
                    if (mqb4[i] == '1')
                    {
                        compt = compt + 1;
                    }
                }
            }

            ////////////////////////////////

            res = nbbitip - compt;
            res = Math.Pow(2, res);
            nbip = Convert.ToString(res);

            return nbip;
        }

        //fonction Nb_Machine
        string Nb_Machine(string ip1, string ip2, string ip3, string ip4, string m1, string m2, string m3, string m4)
        {
            int res = Convert.ToInt32(Nb_IP(ip1, ip2, ip3, ip4, m1, m2, m3, m4));

            res = res - 2;

            string f = Convert.ToString(res);

            return f;
        }

        //Fonction Adresse Net

        string AdresseNet(string ip1, string ip2, string ip3, string ip4, string m1, string m2, string m3, string m4)
        {
            string adr = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if (ip1[i] == m1[i])
                {
                    adr = adr + ip1[i];
                }
                else
                {
                    adr = adr + 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip2[i] == m2[i])
                {
                    adr = adr + ip2[i];
                }
                else
                {
                    adr = adr + 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip3[i] == m3[i])
                {
                    adr = adr + ip3[i];
                }
                else
                {
                    adr = adr + 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip4[i] == m4[i])
                {
                    adr = adr + ip4[i];
                }
                else
                {
                    adr = adr + 0;
                }
            }

            return adr;
        }

        //Fonction Adresse Broadcast

        string AdresseBroad(string ip1, string ip2, string ip3, string ip4, string m1, string m2, string m3, string m4)
        {
            string adr = string.Empty;

            m1 = InverseMasque(m1);
            m2 = InverseMasque(m2);
            m3 = InverseMasque(m3);
            m4 = InverseMasque(m4);

            for (int i = 0; i < 8; i++)
            {
                if (ip1[i] == '1' || m1[i] == '1')
                {
                    adr = adr + "1";
                }
                else
                {
                    adr = adr + "0";
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip2[i] == '1' || m2[i] == '1')
                {
                    adr = adr + "1";
                }
                else
                {
                    adr = adr + "0";
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip3[i] == '1' || m3[i] == '1')
                {
                    adr = adr + "1";
                }
                else
                {
                    adr = adr + "0";
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (ip4[i] == '1' || m4[i] == '1')
                {
                    adr = adr + "1";
                }
                else
                {
                    adr = adr + "0";
                }
            }



            return adr;
        }

        //Fonction Inverse masque
        string InverseMasque(string m)
        {
            string res = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if (m[i] == '1')
                {
                    res = res + "0";
                }
                else
                {
                    res = res + "1";
                }
            }
            return res;
        }

        int r1 = 0;
        int r2 = 0;
        int r3 = 0;
        int r4 = 0;
        int r5 = 0;
        int r6 = 0;

        /*Cette fonction consiste à désactiver le vontuon Valider ou à le desactiver
        en fonction des valeurs des variables rX (X de 1 à 6) qui traduisent de
        l'état de remplisssage des lignes à remplir afin d'activer ou non ce bouton*/
        void ActiverDesactiverBoutonValider()
        {
            if (r1 == 1 && r2 == 1 && r3 == 1 && r4 == 1 && (r6 == 1 || r5 == 1))
            {
                btn_Valider.Enabled = true;
            }
            else
            {
                btn_Valider.Enabled = false;
            }
        }

        //Cette fonction vérifie si les 4 textbox désignées aux nombre décimaux sont vides ou non
        void TxtDec()
        {
            if (String.IsNullOrEmpty(txt_dec_B1.Text) && String.IsNullOrEmpty(txt_dec_B2.Text) && String.IsNullOrEmpty(txt_dec_B3.Text) && String.IsNullOrEmpty(txt_dec_B4.Text))
            {
                //Si les 4 sont vides, on active les champs de saisie pour bin et hex
                txt_hex_B1.Enabled = true;
                txt_hex_B2.Enabled = true;
                txt_hex_B3.Enabled = true;
                txt_hex_B4.Enabled = true;

                txt_bin_B1.Enabled = true;
                txt_bin_B2.Enabled = true;
                txt_bin_B3.Enabled = true;
                txt_bin_B4.Enabled = true;
            }
            else
            {
                //Sinon on désactive les champs de saisie pour bin et hex
                txt_hex_B1.Enabled = false;
                txt_hex_B2.Enabled = false;
                txt_hex_B3.Enabled = false;
                txt_hex_B4.Enabled = false;

                txt_bin_B1.Enabled = false;
                txt_bin_B2.Enabled = false;
                txt_bin_B3.Enabled = false;
                txt_bin_B4.Enabled = false;
            }
        }

        /*Dans chacun des TextChanged ci dessous, on fait la vérifiaction afin de savoir
        si la valeurs que les textbox contiennent sont valides par rapport à ce que
        les textbox doivent contenir*/

        /*Ici, les 4 textbox ci dessous fonctionnent de manière similaire
        On vérifie que la valeur est bien un entier compris entre 0 et 255*/
        private void txt_dec_B1_TextChanged(object sender, EventArgs e)
        {
            TxtDec();
            ChckMasque();
            ChckMasqueCIDR();
            bool test;
            string z = txt_dec_B1.Text;

            //On teste si le texte de la textbox est bien un entier
            test = int.TryParse(z, out int x);

            if (test == true)
            {
                //Si c'est bien un entier mais que celui ci est négatif ou supérieur à 
                //255, la saisie n'est pas valide
                if (x < 0 || x > 255)
                {
                    txt_dec_B1.BackColor = Color.Red;
                    r1 = 0;
                    /*On met la couleur d'arrière plan à rouge, pour signaler l'erreur
                    On met la variable r1 à 0. r1 représente si la première "rangée"
                    de valeurs est valide ( 1er dec ou 1er bin ou 1er hex)*/
                }
                else
                {
                    //Si c'est bien un entier et qu'il est compris entre 0 et 255
                    txt_dec_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r1 = 1;
                    /*On remet la couleur de base afin de montrer que la saisie est correcte
                     on met r1 à 1 afin de savoir que la première "rangée" est OK*/
                }
                
            }
            else
            {
                //Si la valeur saisie n'est pas un entier, on vérifie si la chaine est vide
                if (txt_dec_B1.Text == string.Empty)
                {
                    txt_dec_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r1 = 0;
                    /*Si elle est vide, on remet la couleur de base afin de montrer qu'il n'y 
                    à pas d'erreur, et on met r1 à 0 car la première rangée n'est pas OK*/
                }
                else
                {
                    txt_dec_B1.BackColor = Color.Red;
                    r1 = 0;
                    /*Si la saisie n'est pas un entier et que la chaine n'est pas vide,
                     on met la couleur en rouge afin de montrer l'erreur et on met r1
                     a 0 car la première rangée n'est pas OK*/
                }
            }
            /*On appelle cette fonction afin de savoir s'il faut activer ou desactiver
            le bouton valider*/
            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_dec_B1_TextChanged
        private void txt_dec_B2_TextChanged(object sender, EventArgs e)
        {
            TxtDec();
            bool test;
            string z = txt_dec_B2.Text;

            test = int.TryParse(z, out int x);

            if (test == true)
            {
                if (x < 0 || x > 255)
                {
                    txt_dec_B2.BackColor = Color.Red;
                    r2 = 0;
                }
                else
                {
                    txt_dec_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r2 = 1;
                }

            }
            else
            {
                if (txt_dec_B2.Text == string.Empty)
                {
                    txt_dec_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r2 = 0;
                }
                else
                {
                    txt_dec_B2.BackColor = Color.Red;
                    r2 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_dec_B1_TextChanged
        private void txt_dec_B3_TextChanged(object sender, EventArgs e)
        {
            TxtDec();
            bool test;
            string z = txt_dec_B3.Text;

            test = int.TryParse(z, out int x);

            if (test == true)
            {
                if (x < 0 || x > 255)
                {
                    txt_dec_B3.BackColor = Color.Red;
                    r3 = 0;
                }
                else
                {
                    txt_dec_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r3 = 1;
                }

            }
            else
            {
                if (txt_dec_B3.Text == string.Empty)
                {
                    txt_dec_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r3 = 0;
                }
                else
                {
                    txt_dec_B3.BackColor = Color.Red;
                    r3 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_dec_B1_TextChanged
        private void txt_dec_B4_TextChanged(object sender, EventArgs e)
        {
            TxtDec();
            bool test;
            string z = txt_dec_B4.Text;

            test = int.TryParse(z, out int x);

            if (test == true)
            {
                if (x < 0 || x > 255)
                {
                    txt_dec_B4.BackColor = Color.Red;
                    r4 = 0;
                }
                else
                {
                    txt_dec_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r4 = 1;
                }

            }
            else
            {
                if (txt_dec_B4.Text == string.Empty)
                {
                    txt_dec_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r4 = 0;
                }
                else
                {
                    txt_dec_B4.BackColor = Color.Red;
                    r4 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Cette fonction vérifie si les 4 textbox désignées aux nombre binaires sont vides ou non
        void TxtBin()
        {
            if (String.IsNullOrEmpty(txt_bin_B1.Text) && String.IsNullOrEmpty(txt_bin_B2.Text) && String.IsNullOrEmpty(txt_bin_B3.Text) && String.IsNullOrEmpty(txt_bin_B4.Text))
            {
                //Si les 4 sont vides, on active les champs de saisie pour dec et hex
                txt_hex_B1.Enabled = true;
                txt_hex_B2.Enabled = true;
                txt_hex_B3.Enabled = true;
                txt_hex_B4.Enabled = true;

                txt_dec_B1.Enabled = true;
                txt_dec_B2.Enabled = true;
                txt_dec_B3.Enabled = true;
                txt_dec_B4.Enabled = true;
            }
            else
            {
                //Sinon on désactive les champs de saisie pour bin et hex
                txt_hex_B1.Enabled = false;
                txt_hex_B2.Enabled = false;
                txt_hex_B3.Enabled = false;
                txt_hex_B4.Enabled = false;

                txt_dec_B1.Enabled = false;
                txt_dec_B2.Enabled = false;
                txt_dec_B3.Enabled = false;
                txt_dec_B4.Enabled = false;
            }
        }

        /*Ici, les 4 textbox ci dessous fonctionnent de manière similaire
        On vérifie que la valeur est bien un bianire (uniquement des 0 et des 1)
        de 8 caractères*/
        private void txt_bin_B1_TextChanged(object sender, EventArgs e)
        {
            TxtBin();
            ChckMasque();
            ChckMasqueCIDR();

            int z;

            //On vérifie si le contenu de txt_bin_B1.Text est bien un bianire de 8 caractères
            z = VerifBinaire(Convert.ToString(txt_bin_B1.Text));

            if (z == 0)
            {
                txt_bin_B1.BackColor = Color.FromArgb(232, 167, 135);
                r1 = 1;
                /*Dans le cas ou c'est bien un bianire, on remet la couleur de base afin
                 d'indiquer que la saisie est correcte, et on met r1 à 1 afin de 
                savoir que la première "rangée" de saisie de l'IP est correcte*/
            }
            else
            {
                if (txt_bin_B1.Text == string.Empty)
                {
                    txt_bin_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r1 = 0;
                    /*Si la saisie ne passe pas la saisie, mais que le contenu de
                     txt_bin_B1.Text est vide, alors on remet la couleur de base
                    et on met r1 à 0, car la première "rangée" de saisie de l'adresse
                    IP n'est pas correcte*/
                }
                else
                {
                    txt_bin_B1.BackColor = Color.Red;
                    r1 = 0;
                    /*Sinon, la saisie n'est pas correcte, alors on met la couleur en rouge
                     afin de signaler l'erreur de saisie, et on met r1 à 0, car la première
                    "rangée" de saisie de l'adresse IP n'est pas correcte*/
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_bin_B1_TextChanged
        private void txt_bin_B2_TextChanged(object sender, EventArgs e)
        {
            TxtBin();

            int z;

            z = VerifBinaire(Convert.ToString(txt_bin_B2.Text));

            if (z == 0)
            {
                txt_bin_B2.BackColor = Color.FromArgb(232, 167, 135);
                r2 = 1;
            }
            else
            {
                if (txt_bin_B2.Text == string.Empty)
                {
                    txt_bin_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r2 = 0;
                }
                else
                {
                    txt_bin_B2.BackColor = Color.Red;
                    r2 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_bin_B1_TextChanged
        private void txt_bin_B3_TextChanged(object sender, EventArgs e)
        {
            TxtBin();

            int z;

            z = VerifBinaire(Convert.ToString(txt_bin_B3.Text));

            if (z == 0)
            {
                txt_bin_B3.BackColor = Color.FromArgb(232, 167, 135);
                r3 = 1;
            }
            else
            {
                if (txt_bin_B3.Text == string.Empty)
                {
                    txt_bin_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r3 = 0;
                }
                else
                {
                    txt_bin_B3.BackColor = Color.Red;
                    r3 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_bin_B1_TextChanged
        private void txt_bin_B4_TextChanged(object sender, EventArgs e)
        {
            TxtBin();

            int z;

            z = VerifBinaire(Convert.ToString(txt_bin_B4.Text));

            if (z == 0)
            {
                txt_bin_B4.BackColor = Color.FromArgb(232, 167, 135);
                r4 = 1;
            }
            else
            {
                if (txt_bin_B4.Text == string.Empty)
                {
                    txt_bin_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r4 = 0;
                }
                else
                {
                    txt_bin_B4.BackColor = Color.Red;
                    r4 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Cette fonction vérifie si les 4 textbox désignées aux nombre hexadécimaux sont vides ou non
        void TxtHex()
        {
            if (String.IsNullOrEmpty(txt_hex_B1.Text) && String.IsNullOrEmpty(txt_hex_B2.Text) && String.IsNullOrEmpty(txt_hex_B3.Text) && String.IsNullOrEmpty(txt_hex_B4.Text))
            {
                //Si les 4 sont vides, on active les champs de saisie pour dec et hex
                txt_bin_B1.Enabled = true;
                txt_bin_B2.Enabled = true;
                txt_bin_B3.Enabled = true;
                txt_bin_B4.Enabled = true;

                txt_dec_B1.Enabled = true;
                txt_dec_B2.Enabled = true;
                txt_dec_B3.Enabled = true;
                txt_dec_B4.Enabled = true;
            }
            else
            {
                //Sinon on désactive les champs de saisie pour bin et hex
                txt_bin_B1.Enabled = false;
                txt_bin_B2.Enabled = false;
                txt_bin_B3.Enabled = false;
                txt_bin_B4.Enabled = false;

                txt_dec_B1.Enabled = false;
                txt_dec_B2.Enabled = false;
                txt_dec_B3.Enabled = false;
                txt_dec_B4.Enabled = false;
            }
        }

        /*Ici, les 4 textbox ci dessous fonctionnent de manière similaire
        On vérifie que la valeur est bien un hexadécimal de 00 à FF*/
        private void txt_hex_B1_TextChanged(object sender, EventArgs e)
        {
            TxtHex();
            ChckMasque();
            ChckMasqueCIDR();

            int z;
            if (txt_hex_B1.Text.Length == 2)
            {
                /*Si la longueur du contenu de txt_hex_B1.Text est bien de 2 caractères,
                 on peut donc vérifier si cette valeur est bien un hexadécimal*/
                z = VerifHexa(Convert.ToString(txt_hex_B1.Text));

                if (z == 0)
                {
                    txt_hex_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r1 = 1;
                    /*Dans ce cas, on a bien un hexadécimal, on remet alors la couleur
                     de base, et on met r1 à 1, car la première "rangée" de la saisie
                    de l'adressz IP est correcte*/
                }
                else
                {
                    txt_hex_B1.BackColor = Color.Red;
                    r1 = 0;
                    /*Si la vérification n'est pas correcte, on met la couleur à rouge
                     afin de montrer l'erreur, puis on met r1 à 0, car la première
                    "rangée" de saisie de l'adresse IP n'est pas correcte*/
                }
            }
            else
            {
                /*Puisque qu'un hexadéciaml correct est composé de 2 caractères, si le
                contenu de txt_hex_B1.Text ne contient pas 2 caractères, la saisie peut
                être fausse*/
                if (txt_hex_B1.Text == string.Empty)
                {
                    txt_hex_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r1 = 0;
                    /*Si le contenu de txt_hex_B1.Text est vide, on remet la couleur de base
                     puis on met r1 à 0, car la première "rangée" de saisie de l'adresse IP
                    n'est pas correcte*/
                }
                else
                {
                    txt_hex_B1.BackColor = Color.Red;
                    r1 = 0;
                    /*Si la vérification n'est pas correcte, on met la couleur à rouge
                     afin de montrer l'erreur, puis on met r1 à 0, car la première
                    "rangée" de saisie de l'adresse IP n'est pas correcte*/
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_hex_B1_TextChanged
        private void txt_hex_B2_TextChanged(object sender, EventArgs e)
        {
            TxtHex();

            int z;
            if (txt_hex_B2.Text.Length == 2)
            {
                z = VerifHexa(Convert.ToString(txt_hex_B2.Text));

                if (z == 0)
                {
                    txt_hex_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r2 = 1;
                }
                else
                {
                    txt_hex_B2.BackColor = Color.Red;
                    r2 = 0;
                }
            }
            else
            {
                if (txt_hex_B2.Text == string.Empty)
                {
                    txt_hex_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r2 = 0;
                }
                else
                {
                    txt_hex_B2.BackColor = Color.Red;
                    r2 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_hex_B1_TextChanged
        private void txt_hex_B3_TextChanged(object sender, EventArgs e)
        {
            TxtHex();

            int z;
            if (txt_hex_B3.Text.Length == 2)
            {
                z = VerifHexa(Convert.ToString(txt_hex_B3.Text));

                if (z == 0)
                {
                    txt_hex_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r3 = 1;
                }
                else
                {
                    txt_hex_B3.BackColor = Color.Red;
                    r3 = 0;
                }
            }
            else
            {
                if (txt_hex_B3.Text == string.Empty)
                {
                    txt_hex_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r3 = 0;
                }
                else
                {
                    txt_hex_B3.BackColor = Color.Red;
                    r3 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        //Fonctionnement similaire à txt_hex_B1_TextChanged
        private void txt_hex_B4_TextChanged(object sender, EventArgs e)
        {
            TxtHex();

            int z;
            if (txt_hex_B4.Text.Length == 2)
            {
                z = VerifHexa(Convert.ToString(txt_hex_B4.Text));

                if (z == 0)
                {
                    txt_hex_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r4 = 1;
                }
                else
                {
                    txt_hex_B4.BackColor = Color.Red;
                    r4 = 0;
                }
            }
            else
            {
                if (txt_hex_B4.Text == string.Empty)
                {
                    txt_hex_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r4 = 0;
                }
                else
                {
                    txt_hex_B4.BackColor = Color.Red;
                    r4 = 0;
                }
            }

            ActiverDesactiverBoutonValider();
        }

        void ChckMasqueCIDR()
        {


            bool test;
            string z = txt_CIDR_B1.Text;

            test = int.TryParse(z, out int x);
            if (test == true)
            {
                /*Si le contenu de txt_CIDR_B1.Text est un entier, on vérifie si il est
                compris entre 8 et 32*/
                if (Convert.ToInt32(txt_CIDR_B1.Text) >= 8 && Convert.ToInt32(txt_CIDR_B1.Text) <= 31)
                {
                    txt_CIDR_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r5 = 1;
                    /*Si le contenu est bien compris entre 8 et 32, on remet la couleur de
                     base, et on met r5 à 1 car le masque CIDR est bon*/
                }
                else
                {
                    txt_CIDR_B1.BackColor = Color.Red;
                    r5 = 0;
                    /*Sinon, on met la couleur à rouge pour indiquer une erreur, et on met
                     r5 à 0, car le masque CIDR n'est pas bon*/
                }
            }
            else
            {
                if (txt_CIDR_B1.Text == string.Empty)
                {
                    txt_CIDR_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r5 = 0;
                    /*Si le contenu de txt_CIDR_B1.Text est vide, on remet la couleur de base,
                    et on met r5 à 0 car la saisie n'est vaalide*/
                }
                else
                {
                    txt_CIDR_B1.BackColor = Color.Red;
                    r5 = 0;
                    /*Sinon, on emt la couleur à rouge pour montrer l'erreur, et on met r5 à
                     0 car la saisie n'est pas valide*/
                }
            }
            string classe = string.Empty;

            bool test1 = int.TryParse(txt_dec_B1.Text, out int xi);

            if (test1 == true)
            {
                if (txt_dec_B1.Text != string.Empty)
                {
                    classe = Classe(txt_dec_B1.Text);
                }
            }
            if (txt_bin_B1.Text != string.Empty && txt_bin_B1.Text.Length == 8)
            {
                classe = Classe(BinVersDec(txt_bin_B1.Text));
            }
            if (txt_hex_B1.Text != string.Empty && txt_hex_B1.Text.Length == 2)
            {
                classe = Classe(BinVersDec(HexVersBin(txt_hex_B1.Text)));
            }

            test1 = int.TryParse(txt_CIDR_B1.Text, out xi);

            if (txt_CIDR_B1.Text != string.Empty)
            {
                if (classe != "A" && classe != "B" && classe != "C")
                {
                    r5 = 0;
                    lbl_Erreur.Text = "Uniquement des adresses de classe A, B ou C";
                }
                else
                {
                    lbl_Erreur.Text = "";
                    if (classe == "A" && test1 == true)
                    {
                        if (Convert.ToInt32(txt_CIDR_B1.Text) < 8)
                        {
                            r5 = 0;
                            txt_CIDR_B1.BackColor = Color.Red;
                        }
                    }
                    if (classe == "B" && test1 == true)
                    {
                        if (Convert.ToInt32(txt_CIDR_B1.Text) < 16)
                        {
                            r5 = 0;
                            txt_CIDR_B1.BackColor = Color.Red;
                        }
                    }
                    if (classe == "C" && test1 == true)
                    {
                        if (Convert.ToInt32(txt_CIDR_B1.Text) < 24)
                        {
                            r5 = 0;
                            txt_CIDR_B1.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void txt_CIDR_B1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_CIDR_B1.Text))
            {
                /*Si le contenu de txt_CIDR_B1.Text est vide, on active les champs de saisie
                pour le masque standard*/
                txt_Stdr_B1.Enabled = true;
                txt_Stdr_B2.Enabled = true;
                txt_Stdr_B3.Enabled = true;
                txt_Stdr_B4.Enabled = true;
            }
            else
            {
                /*Si le contenu de txt_CIDR_B1.Text n'est vide, on desactive les champs de
                saisie pour le masque standard*/
                txt_Stdr_B1.Enabled = false;
                txt_Stdr_B2.Enabled = false;
                txt_Stdr_B3.Enabled = false;
                txt_Stdr_B4.Enabled = false;
            }

            ChckMasqueCIDR();

            ActiverDesactiverBoutonValider();
        }


        //Cette fonction vérifie si les 4 textbox désignées aux nombre hexadécimaux sont vides ou non
        void TxtStdr()
        {
            if (String.IsNullOrEmpty(txt_Stdr_B1.Text) && String.IsNullOrEmpty(txt_Stdr_B2.Text) && String.IsNullOrEmpty(txt_Stdr_B3.Text) && String.IsNullOrEmpty(txt_Stdr_B4.Text))
            {
                /*Si les champs correspondant au masque standard sont vides, on active 
                la saisie dans le masque CIDR*/
                txt_CIDR_B1.Enabled = true;
            }
            else
            {
                /*Sinon, on désactive la saisie dans le masque CIDR*/
                txt_CIDR_B1.Enabled = false;
            }
        }

        //CREER UNE FONCTION POUR LA VERIF DES MASQUES APPELLE TOUT LE TEMPS DANS LES TEXT CHANGED

        void ChckMasque()
        {
            bool test;
            int m = 0;
            string classe = string.Empty;

            bool test1 = int.TryParse(txt_dec_B1.Text, out int xi);

            if (test1 == true)
            {
                if (txt_dec_B1.Text != string.Empty)
                {
                    classe = Classe(txt_dec_B1.Text);
                }
            }
            if (txt_bin_B1.Text != string.Empty && txt_bin_B1.Text.Length == 8)
            {
                classe = Classe(BinVersDec(txt_bin_B1.Text));
            }
            if (txt_hex_B1.Text != string.Empty && txt_hex_B1.Text.Length == 2)
            {
                classe = Classe(BinVersDec(HexVersBin(txt_hex_B1.Text)));
            }

            test = int.TryParse(txt_Stdr_B1.Text, out int x);
            if (test == true)
            {
                if (Convert.ToInt32(txt_Stdr_B1.Text) != 255)
                {
                    txt_Stdr_B1.BackColor = Color.Red;
                    r6 = 0;
                }
                else
                {
                    m = TestUnMasque(Convert.ToString(txt_Stdr_B1.Text));
                    if (m == 0)
                    {
                        txt_Stdr_B1.BackColor = Color.FromArgb(232, 167, 135);
                        r6 = 0;
                        if (txt_Stdr_B1.Text != string.Empty && txt_Stdr_B2.Text != string.Empty && txt_Stdr_B3.Text != string.Empty && txt_Stdr_B4.Text != string.Empty)
                        {
                            m = TestMasque(Convert.ToString(txt_Stdr_B1.Text), Convert.ToString(txt_Stdr_B2.Text), Convert.ToString(txt_Stdr_B3.Text), Convert.ToString(txt_Stdr_B4.Text));
                            if (m == 0)
                                if (txt_Stdr_B1.BackColor != Color.Red && txt_Stdr_B2.BackColor != Color.Red && txt_Stdr_B3.BackColor != Color.Red && txt_Stdr_B4.BackColor != Color.Red)
                                {
                                    r6 = 1;
                                }
                                else
                                {
                                    r6 = 0;
                                }
                            else
                            {
                                r6 = 0;
                            }
                        }
                    }
                    else
                    {
                        txt_Stdr_B1.BackColor = Color.Red;
                        r6 = 0;
                    }
                }
            }
            else
            {
                if (txt_Stdr_B1.Text == string.Empty)
                {
                    txt_Stdr_B1.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                }
                else
                {
                    txt_Stdr_B1.BackColor = Color.Red;
                    r6 = 0;
                }
            }

            test = int.TryParse(txt_Stdr_B2.Text, out x);
            if (test == true)
            {
                m = TestUnMasque(Convert.ToString(txt_Stdr_B2.Text));
                if (m == 0)
                {
                    txt_Stdr_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                    if (txt_Stdr_B1.Text != string.Empty && txt_Stdr_B2.Text != string.Empty && txt_Stdr_B3.Text != string.Empty && txt_Stdr_B4.Text != string.Empty)
                    {
                        m = TestMasque(Convert.ToString(txt_Stdr_B1.Text), Convert.ToString(txt_Stdr_B2.Text), Convert.ToString(txt_Stdr_B3.Text), Convert.ToString(txt_Stdr_B4.Text));
                        if (m == 0)
                            if (txt_Stdr_B1.BackColor != Color.Red && txt_Stdr_B2.BackColor != Color.Red && txt_Stdr_B3.BackColor != Color.Red && txt_Stdr_B4.BackColor != Color.Red)
                            {
                                r6 = 1;
                            }
                            else
                            {
                                r6 = 0;
                            }
                        else
                        {
                            r6 = 0;
                        }
                    }
                }
                else
                {
                    txt_Stdr_B2.BackColor = Color.Red;
                    r6 = 0;
                }
                if (!String.IsNullOrEmpty(txt_Stdr_B1.Text) && (int.TryParse(txt_Stdr_B1.Text, out x) == true))
                {
                    if (Convert.ToInt32(txt_Stdr_B1.Text) != 255)
                    {
                        if (Convert.ToInt32(txt_Stdr_B2.Text) != 0)
                        {
                            txt_Stdr_B2.BackColor = Color.Red;
                            r6 = 0;
                        }
                    }
                }
            }
            else
            {
                if (txt_Stdr_B2.Text == string.Empty)
                {
                    txt_Stdr_B2.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                }
                else
                {
                    txt_Stdr_B2.BackColor = Color.Red;
                    r6 = 0;
                }
            }
            if (classe == "B" || classe == "C")
            {
                if (txt_Stdr_B2.Text != string.Empty)
                {
                    if (Convert.ToInt32(txt_Stdr_B2.Text) != 255)
                    {
                        txt_Stdr_B2.BackColor = Color.Red;
                        r6 = 0;
                    }
                }
            }

            test = int.TryParse(txt_Stdr_B3.Text, out x);
            if (test == true)
            {
                m = TestUnMasque(Convert.ToString(txt_Stdr_B3.Text));
                if (m == 0)
                {
                    txt_Stdr_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                    if (txt_Stdr_B1.Text != string.Empty && txt_Stdr_B2.Text != string.Empty && txt_Stdr_B3.Text != string.Empty && txt_Stdr_B4.Text != string.Empty)
                    {
                        m = TestMasque(Convert.ToString(txt_Stdr_B1.Text), Convert.ToString(txt_Stdr_B2.Text), Convert.ToString(txt_Stdr_B3.Text), Convert.ToString(txt_Stdr_B4.Text));
                        if (m == 0)
                            if (txt_Stdr_B1.BackColor != Color.Red && txt_Stdr_B2.BackColor != Color.Red && txt_Stdr_B3.BackColor != Color.Red && txt_Stdr_B4.BackColor != Color.Red)
                            {
                                r6 = 1;
                            }
                            else
                            {
                                r6 = 0;
                            }
                        else
                        {
                            r6 = 0;
                        }
                    }
                }
                else
                {
                    txt_Stdr_B3.BackColor = Color.Red;
                    r6 = 0;
                }
                if (!String.IsNullOrEmpty(txt_Stdr_B2.Text) && (int.TryParse(txt_Stdr_B2.Text, out x) == true))
                {
                    if (Convert.ToInt32(txt_Stdr_B2.Text) != 255)
                    {
                        if (Convert.ToInt32(txt_Stdr_B3.Text) != 0)
                        {
                            txt_Stdr_B3.BackColor = Color.Red;
                            r6 = 0;
                        }
                    }
                }
            }
            else
            {
                if (txt_Stdr_B3.Text == string.Empty)
                {
                    txt_Stdr_B3.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                }
                else
                {
                    txt_Stdr_B3.BackColor = Color.Red;
                    r6 = 0;
                }
            }
            if (txt_Stdr_B3.Text != string.Empty)
            {
                if (classe == "C")
                {
                    if (Convert.ToInt32(txt_Stdr_B3.Text) != 255)
                    {
                        txt_Stdr_B3.BackColor = Color.Red;
                        r6 = 0;
                    }
                }
            }
            test = int.TryParse(txt_Stdr_B4.Text, out x);
            if (test == true)
            {
                m = TestUnMasque(Convert.ToString(txt_Stdr_B4.Text));
                if (m == 0 && Convert.ToInt32(txt_Stdr_B4.Text) != 255)
                {
                    txt_Stdr_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                    if (txt_Stdr_B1.Text != string.Empty && txt_Stdr_B2.Text != string.Empty && txt_Stdr_B3.Text != string.Empty && txt_Stdr_B4.Text != string.Empty)
                    {
                        m = TestMasque(Convert.ToString(txt_Stdr_B1.Text), Convert.ToString(txt_Stdr_B2.Text), Convert.ToString(txt_Stdr_B3.Text), Convert.ToString(txt_Stdr_B4.Text));
                        if (m == 0)
                        {
                            if (txt_Stdr_B1.BackColor != Color.Red && txt_Stdr_B2.BackColor != Color.Red && txt_Stdr_B3.BackColor != Color.Red && txt_Stdr_B4.BackColor != Color.Red)
                            {
                                r6 = 1;
                            }
                            else
                            {
                                r6 = 0;
                            }
                        }
                        else
                        {
                            r6 = 0;
                        }
                    }
                }
                else
                {
                    txt_Stdr_B4.BackColor = Color.Red;
                    r6 = 0;
                }
                if (!String.IsNullOrEmpty(txt_Stdr_B3.Text) && (int.TryParse(txt_Stdr_B3.Text, out x) == true))
                {
                    if (Convert.ToInt32(txt_Stdr_B3.Text) != 255)
                    {
                        if (Convert.ToInt32(txt_Stdr_B4.Text) != 0)
                        {
                            txt_Stdr_B4.BackColor = Color.Red;
                            r6 = 0;
                        }
                    }
                }
            }
            else
            {
                if (txt_Stdr_B4.Text == string.Empty)
                {
                    txt_Stdr_B4.BackColor = Color.FromArgb(232, 167, 135);
                    r6 = 0;
                }
                else
                {
                    txt_Stdr_B4.BackColor = Color.Red;
                    r6 = 0;
                }
            }
            if (classe != "A" && classe != "B" && classe != "C")
            {
                if (txt_bin_B1.Text != string.Empty || txt_dec_B1.Text != string.Empty || txt_hex_B1.Text != string.Empty)
                {
                    lbl_Erreur.Text = "Uniquement des adresses de classe A, B ou C";
                }
                else
                {
                    lbl_Erreur.Text = "";
                }
            }
            else
            {
                lbl_Erreur.Text = "";
            }

            if (classe != "A" && classe != "B" && classe != "C")
            {
                r6 = 0;
                lbl_Erreur.Text = "Uniquement des adresses de classe A, B ou C";
            }
            else
            {
                lbl_Erreur.Text = "";
            }
        }
        private void txt_Stdr_B1_TextChanged(object sender, EventArgs e)
        {
            TxtStdr();

            ChckMasque();

            ActiverDesactiverBoutonValider();
        }

        private void txt_Stdr_B2_TextChanged(object sender, EventArgs e)
        {
            TxtStdr();

            ChckMasque();

            ActiverDesactiverBoutonValider();
        }

        private void txt_Stdr_B3_TextChanged(object sender, EventArgs e)
        {
            TxtStdr();

            ChckMasque();

            ActiverDesactiverBoutonValider();
        }

        private void txt_Stdr_B4_TextChanged(object sender, EventArgs e)
        {
            TxtStdr();

            ChckMasque();

            ActiverDesactiverBoutonValider();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_dec_B1.Text) && !String.IsNullOrEmpty(txt_dec_B2.Text)&& !String.IsNullOrEmpty(txt_dec_B3.Text) && !String.IsNullOrEmpty(txt_dec_B4.Text)) 
            { 
                txt_bin_B1.Text = DecVersBin(txt_dec_B1.Text);
                txt_bin_B2.Text = DecVersBin(txt_dec_B2.Text);
                txt_bin_B3.Text = DecVersBin(txt_dec_B3.Text);
                txt_bin_B4.Text = DecVersBin(txt_dec_B4.Text);

                txt_hex_B1.Text = BinVersHex(txt_bin_B1.Text);
                txt_hex_B2.Text = BinVersHex(txt_bin_B2.Text);
                txt_hex_B3.Text = BinVersHex(txt_bin_B3.Text);
                txt_hex_B4.Text = BinVersHex(txt_bin_B4.Text);

            }
            else
            {
                if (!String.IsNullOrEmpty(txt_bin_B1.Text) && !String.IsNullOrEmpty(txt_bin_B2.Text) && !String.IsNullOrEmpty(txt_bin_B3.Text) && !String.IsNullOrEmpty(txt_bin_B4.Text))
                {
                    txt_hex_B1.Text = BinVersHex(txt_bin_B1.Text);
                    txt_hex_B2.Text = BinVersHex(txt_bin_B2.Text);
                    txt_hex_B3.Text = BinVersHex(txt_bin_B3.Text);
                    txt_hex_B4.Text = BinVersHex(txt_bin_B4.Text);

                    txt_dec_B1.Text = BinVersDec(txt_bin_B1.Text);
                    txt_dec_B2.Text = BinVersDec(txt_bin_B2.Text);
                    txt_dec_B3.Text = BinVersDec(txt_bin_B3.Text);
                    txt_dec_B4.Text = BinVersDec(txt_bin_B4.Text);
                }
                else
                {
                    if (!String.IsNullOrEmpty(txt_hex_B1.Text) && !String.IsNullOrEmpty(txt_hex_B2.Text) && !String.IsNullOrEmpty(txt_hex_B3.Text) && !String.IsNullOrEmpty(txt_hex_B4.Text))
                    {
                        txt_bin_B1.Text = HexVersBin(txt_hex_B1.Text);
                        txt_bin_B2.Text = HexVersBin(txt_hex_B2.Text);
                        txt_bin_B3.Text = HexVersBin(txt_hex_B3.Text);
                        txt_bin_B4.Text = HexVersBin(txt_hex_B4.Text);

                        txt_dec_B1.Text = BinVersDec(txt_bin_B1.Text);
                        txt_dec_B2.Text = BinVersDec(txt_bin_B2.Text);
                        txt_dec_B3.Text = BinVersDec(txt_bin_B3.Text);
                        txt_dec_B4.Text = BinVersDec(txt_bin_B4.Text);
                    }
                }
            }
            if (!String.IsNullOrEmpty(txt_CIDR_B1.Text))
            {
                int z = Convert.ToInt32(txt_CIDR_B1.Text);
                if (z > 7 && z < 33)
                {
                    string masque = MasqueCIDR(z);
                    txt_Stdr_B1.Text = BinVersDec(CouperBin(masque, 0));
                    txt_Stdr_B2.Text = BinVersDec(CouperBin(masque, 1));
                    txt_Stdr_B3.Text = BinVersDec(CouperBin(masque, 2));
                    txt_Stdr_B4.Text = BinVersDec(CouperBin(masque, 3));
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(txt_Stdr_B1.Text) && !String.IsNullOrEmpty(txt_Stdr_B2.Text) && !String.IsNullOrEmpty(txt_Stdr_B3.Text) && !String.IsNullOrEmpty(txt_Stdr_B4.Text))
                {
                    int z = TestMasque(txt_Stdr_B1.Text, txt_Stdr_B2.Text, txt_Stdr_B3.Text, txt_Stdr_B4.Text);
                    if (z == 0)
                    {
                        txt_CIDR_B1.Text = MasqueDec(txt_Stdr_B1.Text, txt_Stdr_B2.Text, txt_Stdr_B3.Text, txt_Stdr_B4.Text);
                    }
                }
            }

            lbl_Classe_B1.Text = Classe(txt_dec_B1.Text);

            lbl_NbIP_B1.Text = Nb_IP(txt_dec_B1.Text, txt_dec_B2.Text, txt_dec_B3.Text, txt_dec_B4.Text, txt_Stdr_B1.Text, txt_Stdr_B2.Text, txt_Stdr_B3.Text, txt_Stdr_B4.Text);

            lbl_NbMachine_B1.Text = Nb_Machine(txt_dec_B1.Text, txt_dec_B2.Text, txt_dec_B3.Text, txt_dec_B4.Text, txt_Stdr_B1.Text, txt_Stdr_B2.Text, txt_Stdr_B3.Text, txt_Stdr_B4.Text);

            string adr = AdresseNet(txt_bin_B1.Text, txt_bin_B2.Text, txt_bin_B3.Text, txt_bin_B4.Text, DecVersBin(txt_Stdr_B1.Text), DecVersBin(txt_Stdr_B2.Text), DecVersBin(txt_Stdr_B3.Text), DecVersBin(txt_Stdr_B4.Text));

            lbl_AdrNet_B1.Text = BinVersDec(CouperBin(adr, 0));
            lbl_AdrNet_B2.Text = BinVersDec(CouperBin(adr, 1));
            lbl_AdrNet_B3.Text = BinVersDec(CouperBin(adr, 2));
            lbl_AdrNet_B4.Text = BinVersDec(CouperBin(adr, 3));

            adr = AdresseBroad(txt_bin_B1.Text, txt_bin_B2.Text, txt_bin_B3.Text, txt_bin_B4.Text, DecVersBin(txt_Stdr_B1.Text), DecVersBin(txt_Stdr_B2.Text), DecVersBin(txt_Stdr_B3.Text), DecVersBin(txt_Stdr_B4.Text));

            lbl_AdrBroad_B1.Text = BinVersDec(CouperBin(adr, 0));
            lbl_AdrBroad_B2.Text = BinVersDec(CouperBin(adr, 1));
            lbl_AdrBroad_B3.Text = BinVersDec(CouperBin(adr, 2));
            lbl_AdrBroad_B4.Text = BinVersDec(CouperBin(adr, 3));

            lbl_1ereIP_B1.Text = lbl_AdrNet_B1.Text;
            lbl_1ereIP_B2.Text = lbl_AdrNet_B2.Text;
            lbl_1ereIP_B3.Text = lbl_AdrNet_B3.Text;
            lbl_1ereIP_B4.Text = Convert.ToString(Convert.ToInt32(lbl_AdrNet_B4.Text) + 1);

            lbl_DerIP_B1.Text = lbl_AdrBroad_B1.Text;
            lbl_DerIP_B2.Text = lbl_AdrBroad_B2.Text;
            lbl_DerIP_B3.Text = lbl_AdrBroad_B3.Text;
            lbl_DerIP_B4.Text = Convert.ToString(Convert.ToInt32(lbl_AdrBroad_B4.Text) - 1);

            if (txt_CIDR_B1.Text == "31")
            {
                lbl_1ereIP_B1.Text = "N/A";
                lbl_1ereIP_B2.Text = "N/A";
                lbl_1ereIP_B3.Text = "N/A";
                lbl_1ereIP_B4.Text = "N/A";

                lbl_DerIP_B1.Text = "N/A";
                lbl_DerIP_B2.Text = "N/A";
                lbl_DerIP_B3.Text = "N/A";
                lbl_DerIP_B4.Text = "N/A";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Valider.Enabled = false;
        }

        private void btn_Aide_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btn_rea_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
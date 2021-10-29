using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SSR_COLOMBIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //VARIABLES GLOBALES
        float bga = 1001,pei=1040,cuc=0001,eyp=0030,let=0060,nva=0740,andes=7650,bogi=2301,rngi=2401,cloi=2440,baqi=6601,sppi=6670,bogd=1301,rngd=1401,clod=1601,vvcd=1501,baqd=1701,sppd=1560,vvcl=0701,bogf=7201,rngf=7301,clof=7340,vvcf=7601,baqf=7520,sppf=7510,opbog=2020,opbaq=2050,hosp=2001,sar=7711,head=7501,vip2=7504,bogi2=2201,bogd2=1201,bogf2=7101;
        string tma = "";
        int sked = 0,devuelve=-1, jueputa=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //MAIN FORM
            logo.SendToBack();

            botonitlbog2.Visible = false;
            botondombog2.Visible = false;
            botonfacbog2.Visible = false;

            textorecomendaciones.Visible = false;
            textoacercade.Visible = false;
            fondomenu1.Visible = false;
            fondomenu2.Visible = false;
            botonmenu.Visible = false;
            linktma.Visible = false;
            labeltma.Visible = false;
            linkcerrartma.Visible = false;

            txticao.Visible = false;
            botonregresar.Visible = false;
            fondoreinicio.Visible = false;
            botoncontinuar.Visible = false;

            botonbuscar.Visible = false;
            labeladvertencia.Visible = false;
            botondevolver.Visible = false;
            botoncambiartma.Visible = false;

            botonreiniciar.Visible = false;
            fondoadvertencia.Visible=false;
            fondomenu4.Visible = false;

            botonspp.Visible = false;
            botonaccbaq.Visible = false;
            botonsi.Visible = false;
            botonno.Visible = false;

            labelcodigo.Visible = false;
            labelnumero.Visible = false;
            labelprioridad.Visible = false;
            labelerror.Visible = false;
            labelfirbaq.Visible = false;
            labelfirbog.Visible = false;
            labelsalaspp.Visible = false;
            labelaccbaq.Visible = false;

            botonopbog.Visible = false;
            botonopbq.Visible = false;
            botonskboapp.Visible = false;
            botondoradotorre.Visible = false;

            botonhosp.Visible = false;
            botonhead.Visible = false;
            botonvip2.Visible = false;
            botonsar.Visible=false;

            botonitlbaq.Visible = false;
            botonitlspp.Visible = false;
            botonitlbog.Visible = false;
            botonitlrng.Visible = false;
            botonitlclo.Visible = false;
            botondombog.Visible = false;
            botondomrng.Visible = false;
            botondomclo.Visible = false;
            botondomvvc.Visible = false;
            botondombaq.Visible = false;
            botondomspp.Visible = false;
            botonlocalvvc.Visible = false;
            botonfacbog.Visible = false;
            botonfacrng.Visible = false;
            botonfacclo.Visible = false;
            botonfacvvc.Visible = false;
            botonfacbaq.Visible = false;
            botonfacspp.Visible = false;
        }

        private void txticao_changed(object sender, EventArgs e)
        {
            //TXT ICAO
        }

        private void botonbuscar_click(object sender, EventArgs e)
        {
            //FIR Bogotá
            if (sked == 1)
            {
                tma = txticao.Text;
                tma.ToUpper();
                switch (tma)
                {
                    //TMA BUCARAMANGA d0
                    case "BGA":
                        devuelve = 0;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        string compara = bga.ToString();
                        if (compara.Contains("8") || compara.Contains("9")) {

                        } else
                        {
                            labelnumero.Text = compara;
                        } 
                        if (bga > 1037)
                        {
                            labelnumero.Text = "SSR COMPLETOS";
                            bga = 1001;
                        }
                        bga = bga + 1;
                        break;
                    case "BUCARAMANGA":
                        devuelve = 0;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = bga.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            labelnumero.Text = compara;
                        }
                        bga = bga + 1;
                        if (bga > 1037)
                        {
                            labelnumero.Text = "1037-SSR COMPLETOS";
                            bga = 1001;
                        }
                        break;

                    //TMA PEREIRA d1
                    case "PEI":
                        devuelve = 1;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = pei.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            labelnumero.Text = compara;
                        }
                        pei = pei + 1;
                        if (pei > 1077)
                        {
                            labelnumero.Text = "1077-SSR COMPLETOS";
                            pei=1040;
                        }
                        break;
                    case "PEREIRA":
                        devuelve = 1;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = pei.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            labelnumero.Text = compara;
                        }
                        pei = pei + 1;
                        if (pei > 1077)
                        {
                            labelnumero.Text = "1077-SSR COMPLETOS";
                            pei = 1040;
                        }
                        break;
                    //TMA CUCUTA d2
                    case "CUC":
                        devuelve = 2;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = cuc.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            if (cuc < 9)
                            {
                                compara = "000" + compara;
                                labelnumero.Text = compara;
                            }
                            else
                            {
                                compara = "00" + compara;
                                labelnumero.Text = compara;
                            }
                        }
                        cuc = cuc + 1;
                        if (cuc > 27)
                        {
                            labelnumero.Text = "0027-SSR COMPLETOS";
                            cuc = 0001;
                        }
                        break;
                    case "CUCUTA":
                        devuelve = 2;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = cuc.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            if (cuc < 9)
                            {
                                compara = "000" + compara;
                                labelnumero.Text = compara;
                            }
                            else
                            {
                                compara = "00" + compara;
                                labelnumero.Text = compara;
                            }
                        }
                        cuc = cuc + 1;
                        if (cuc > 27)
                        {
                            labelnumero.Text = "0027-SSR COMPLETOS";
                            cuc = 0001;
                        }
                        break;
                    //TMA EL YOPAL d3
                    case "EYP":
                        devuelve = 3;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = eyp.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "00" + compara;
                            labelnumero.Text = compara;
                        }
                        eyp = eyp + 1;
                        if (eyp > 57)
                        {
                            labelnumero.Text = "0057-SSR COMPLETOS";
                            eyp = 0030;
                        }
                        break;
                    case "EL YOPAL":
                        devuelve = 3;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = eyp.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "00" + compara;
                            labelnumero.Text = compara;
                        }
                        eyp = eyp + 1;
                        if (eyp > 57)
                        {
                            labelnumero.Text = "0057-SSR COMPLETOS";
                            eyp = 0030;
                        }
                        break;
                    //TMA LETICIA d4
                    case "LET":
                        devuelve = 4;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = let.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "00" + compara;
                            labelnumero.Text = compara;
                        }
                        let = let + 1;
                        if (let > 77)
                        {
                            labelnumero.Text = "0077-SSR COMPLETOS";
                            let = 0060;
                        }
                        break;
                    case "LETICIA":
                        devuelve = 4;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = let.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "00" + compara;
                            labelnumero.Text = compara;
                        }
                        let = let + 1;
                        if (let > 77)
                        {
                            labelnumero.Text = "0077-SSR COMPLETOS";
                            let = 0060;
                        }
                        break;
                    //TMA NEIVA d5
                    case "NVA":
                        devuelve = 5;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = nva.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "0" + compara;
                            labelnumero.Text = compara;
                        }
                        nva = nva + 1;
                        if (nva > 777)
                        {
                            labelnumero.Text = "0777-SSR COMPLETOS";
                            nva = 0740;
                        }
                        break;
                    case "NEIVA":
                        devuelve = 5;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = nva.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            compara = "0" + compara;
                            labelnumero.Text = compara;
                        }
                        nva = nva + 1;
                        if (nva > 777)
                        {
                            labelnumero.Text = "0777-SSR COMPLETOS";
                            nva = 0740;
                        }
                        break;
                    //TMA ANDES d6
                    case "ANDES":
                        devuelve = 6;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        compara = andes.ToString();
                        if (compara.Contains("8") || compara.Contains("9"))
                        {

                        }
                        else
                        {
                            labelnumero.Text = compara;
                        }
                        andes = andes + 1;
                        if (nva > 7677)
                        {
                            labelnumero.Text = "7677-SSR COMPLETOS";
                            andes = 7650;
                        }
                        break;
                    //TMA BOGOTÁ d7
                    case "BOG":
                        devuelve = 7;
                        botonbuscar.Visible = false;
                        txticao.Visible = false;
                        botoncambiartma.Visible = true;
                        botondoradotorre.Visible = true;
                        botonskboapp.Visible = true;
                        labelerror.Visible = false;
                        break;
                    case "BOGOTA":
                        devuelve = 7;
                        botonbuscar.Visible = false;
                        txticao.Visible = false;
                        botoncambiartma.Visible = true;
                        botondoradotorre.Visible = true;
                        botonskboapp.Visible = true;
                        labelerror.Visible = false;
                        break;
                    //TMA MEDELLÍN d8
                    case "RNG":
                        devuelve = 8;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomrng.Visible = true;
                        botonitlrng.Visible = true;
                        botonfacrng.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    case "RIONEGRO":
                        devuelve = 8;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomrng.Visible = true;
                        botonitlrng.Visible = true;
                        botonfacrng.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    case "MDE":
                        devuelve = 8;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomrng.Visible = true;
                        botonitlrng.Visible = true;
                        botonfacrng.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    case "MEDELLIN":
                        devuelve = 8;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomrng.Visible = true;
                        botonitlrng.Visible = true;
                        botonfacrng.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    //TMA CLO d9
                    case "CLO":
                        devuelve = 9;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomclo.Visible = true;
                        botonitlclo.Visible = true;
                        botonfacclo.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    case "CALI":
                        devuelve = 9;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomclo.Visible = true;
                        botonitlclo.Visible = true;
                        botonfacclo.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    //TMA VVC d10
                    case "VVC":
                        devuelve = 10;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomvvc.Visible = true;
                        botonlocalvvc.Visible = true;
                        botonfacvvc.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    case "VILLAVICENCIO":
                        devuelve = 10;
                        labelerror.Visible = false;
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        botondomvvc.Visible = true;
                        botonlocalvvc.Visible = true;
                        botonfacvvc.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                    //TMA NO ENCONTRADO
                    default:
                        botonitlbaq.Visible = false;
                        botonitlspp.Visible = false;
                        botonitlbog.Visible = false;
                        botonitlrng.Visible = false;
                        botonitlclo.Visible = false;
                        botondombog.Visible = false;
                        botondomrng.Visible = false;
                        botondomclo.Visible = false;
                        botondomvvc.Visible = false;
                        botondombaq.Visible = false;
                        botondomspp.Visible = false;
                        botonlocalvvc.Visible = false;
                        botonfacbog.Visible = false;
                        botonfacrng.Visible = false;
                        botonfacclo.Visible = false;
                        botonfacvvc.Visible = false;
                        botonfacbaq.Visible = false;
                        botonfacspp.Visible = false;
                        labelerror.Visible = true;
                        labelnumero.Text = "- - - -";
                        break;
                }
            }
        }

        private void botonfirbog_click(object sender, EventArgs e)
        {
            //BOTON FIR BOG
            botondevolver.Visible = true;
            txticao.Visible = true;
            botonbuscar.Visible = true;
            botonfirbaq.Visible = false;
            botonfirbog.Visible = false;
            label1.Visible = false;
            labelprioridad.Visible = true;
            botonopbog.Visible = true;
            botonopbq.Visible = false;
            botonhosp.Visible = true;
            botonhead.Visible = true;
            botonvip2.Visible = true;
            botonsar.Visible = true;
            labelcodigo.Visible = true;
            labelnumero.Visible = true;
            labelfirbog.Visible = true;
            botonregresar.Visible = true;
            botonreiniciar.Visible = true;
            sked = 1;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void recomenacionesclick(object sender, EventArgs e)
        {
            //recomendaciones
        }

        private void acercadeclick(object sender, EventArgs e)
        {
            //acerca de
        }

        private void abrirrecomendaciones_click(object sender, EventArgs e)
        {
            //recomendaciones abrir
            botondoradotorre.Visible = false;
            botonskboapp.Visible = false;
            botoncambiartma.Visible = false;
            botonitlbog2.Visible = false;
            botondombog2.Visible = false;
            botonfacbog2.Visible = false;
            textorecomendaciones.Visible = true;
            textoacercade.Visible = false;
            fondoreinicio.Visible = true;
            fondomenu1.Visible = true;
            fondomenu2.Visible = true;
            fondomenu4.Visible = true;
            botonmenu.Visible = true;
            linktma.Visible = true;
        }


        private void abriracercade_click(object sender, EventArgs e)
        {
            //acerca de abrir
            botondoradotorre.Visible = false;
            botonskboapp.Visible = false;
            botoncambiartma.Visible = false;
            botonitlbog2.Visible = false;
            botondombog2.Visible = false;
            botonfacbog2.Visible = false;
            textorecomendaciones.Visible = false;
            textoacercade.Visible = true;
            fondoreinicio.Visible = true;
            fondomenu1.Visible = true;
            fondomenu2.Visible = true;
            fondomenu4.Visible = true;
            botonmenu.Visible = true;
            linktma.Visible = false;
        }

        private void botonmenu_click(object sender, EventArgs e)
        {
            //clic boton menu
            if (jueputa == 1)
            {
                botondoradotorre.Visible = true;
                botonskboapp.Visible = true;
                botoncambiartma.Visible = true;
                botonitlbog2.Visible = false;
                botondombog2.Visible = false;
                botonfacbog2.Visible = false;
            }
            else if (jueputa == 2)
            {
                botondoradotorre.Visible = true;
                botonskboapp.Visible = true;
                botoncambiartma.Visible = true;
                botonitlbog2.Visible = true;
                botondombog2.Visible = true;
                botonfacbog2.Visible = true;
            }
            else if (jueputa == 3)
            {
                botondoradotorre.Visible = false;
                botonskboapp.Visible = false;
                botoncambiartma.Visible = false;
                botonitlbog2.Visible = false;
                botondombog2.Visible = false;
                botonfacbog2.Visible = false;
            }
            textorecomendaciones.Visible = false;
            fondoreinicio.Visible = false;
            textoacercade.Visible = false;
            fondomenu1.Visible = false;
            fondomenu2.Visible = false;
            fondomenu4.Visible = false;
            botonmenu.Visible = false;
            linktma.Visible = false;
        }

        private void textorecomendaciones_Click(object sender, EventArgs e)
        {

        }

        private void linktmaclic(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //link tma
            linktma.Visible = false;
            labeltma.Visible = true;
            botonmenu.Visible = false;
            linkcerrartma.Visible = true;
        }

        private void labeltma_click(object sender, EventArgs e)
        {
            //label tma
        }

        private void linkcerrartma_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //cerrar tma
            botonmenu.Visible = true;
            linktma.Visible = true;
            labeltma.Visible = false;
            linkcerrartma.Visible = false;
        }

        private void botonregresar_click(object sender, EventArgs e)
        {
            //botonregresar
            labelfirbog.Text = "FIR SKED";
            jueputa = 3;
            label1.Visible = true;
            botonfirbaq.Visible = true;
            botonfirbog.Visible = true;
            botonitlbog2.Visible = false;
            botondombog2.Visible = false;
            botonfacbog2.Visible = false;

            textorecomendaciones.Visible = false;
            textoacercade.Visible = false;
            fondomenu1.Visible = false;
            fondomenu2.Visible = false;
            botonmenu.Visible = false;
            linktma.Visible = false;
            labeltma.Visible = false;
            linkcerrartma.Visible = false;

            txticao.Visible = false;
            botonregresar.Visible = false;
            fondoreinicio.Visible = false;
            botoncontinuar.Visible = false;

            botonbuscar.Visible = false;
            labeladvertencia.Visible = false;
            botondevolver.Visible = false;
            botoncambiartma.Visible = false;

            botonreiniciar.Visible = false;
            fondoadvertencia.Visible = false;
            fondomenu4.Visible = false;

            botonspp.Visible = false;
            botonaccbaq.Visible = false;
            botonsi.Visible = false;
            botonno.Visible = false;

            labelcodigo.Visible = false;
            labelnumero.Visible = false;
            labelprioridad.Visible = false;
            labelerror.Visible = false;
            labelfirbaq.Visible = false;
            labelfirbog.Visible = false;
            labelsalaspp.Visible = false;
            labelaccbaq.Visible = false;

            botonopbog.Visible = false;
            botonopbq.Visible = false;
            botonskboapp.Visible = false;
            botondoradotorre.Visible = false;

            botonhosp.Visible = false;
            botonhead.Visible = false;
            botonvip2.Visible = false;
            botonsar.Visible = false;

            botonitlbaq.Visible = false;
            botonitlspp.Visible = false;
            botonitlbog.Visible = false;
            botonitlrng.Visible = false;
            botonitlclo.Visible = false;
            botondombog.Visible = false;
            botondomrng.Visible = false;
            botondomclo.Visible = false;
            botondomvvc.Visible = false;
            botondombaq.Visible = false;
            botondomspp.Visible = false;
            botonlocalvvc.Visible = false;
            botonfacbog.Visible = false;
            botonfacrng.Visible = false;
            botonfacclo.Visible = false;
            botonfacvvc.Visible = false;
            botonfacbaq.Visible = false;
            botonfacspp.Visible = false;
        }

        private void botonskbo_app(object sender, EventArgs e)
        {
            //boton skbo_app
            jueputa = 2;
            labelerror.Visible = false;
            botonitlbaq.Visible = false;
            botonitlspp.Visible = false;
            botonitlrng.Visible = false;
            botonitlclo.Visible = false;
            botondomrng.Visible = false;
            botondomclo.Visible = false;
            botondomvvc.Visible = false;
            botondombaq.Visible = false;
            botondomspp.Visible = false;
            botonlocalvvc.Visible = false;
            botonfacrng.Visible = false;
            botonfacclo.Visible = false;
            botonfacvvc.Visible = false;
            botonfacbaq.Visible = false;
            botonfacspp.Visible = false;
            botondombog2.Visible = true;
            botonitlbog2.Visible = true;
            botonfacbog2.Visible = true;
            botondombog.Visible = false;
            botonitlbog.Visible = false;
            botonfacbog.Visible = false;
            labelfirbog.Text = "SKED_CTR / SKBO_APP";
        }

        private void botonskbotwr_click(object sender, EventArgs e)
        {
            //boton skbo_twr
            jueputa = 1;
            labelerror.Visible = false;
            botonitlbaq.Visible = false;
            botonitlspp.Visible = false;
            botonitlrng.Visible = false;
            botonitlclo.Visible = false;
            botondomrng.Visible = false;
            botondomclo.Visible = false;
            botondomvvc.Visible = false;
            botondombaq.Visible = false;
            botondomspp.Visible = false;
            botonlocalvvc.Visible = false;
            botonfacrng.Visible = false;
            botonfacclo.Visible = false;
            botonfacvvc.Visible = false;
            botonfacbaq.Visible = false;
            botonfacspp.Visible = false;
            botondombog.Visible = true;
            botonitlbog.Visible = true;
            botonfacbog.Visible = true;
            botondombog2.Visible = false;
            botonitlbog2.Visible = false;
            botonfacbog2.Visible = false;
            labelfirbog.Text = "SKED - SKBO_TWR";
        }

        private void botoncambiartma_click(object sender, EventArgs e)
        {
            //boton cambiar tma
            labelfirbog.Text = "FIR SKED";
            botonbuscar.Visible = true;
            txticao.Visible = true;
            botoncambiartma.Visible = false;
            botondoradotorre.Visible = false;
            botonskboapp.Visible = false;
            botonitlbog2.Visible = false;
            botondombog2.Visible = false;
            botonfacbog2.Visible = false;
            botonitlbog.Visible = false;
            botondombog.Visible = false;
            botonfacbog.Visible = false;
            labelfirbog.Text = "FIR SKED";
        }

        private void botonitlbog2_click(object sender, EventArgs e)
        {
            //int bog SKED
            devuelve = 1444;
            string compara = bogi2.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogi2 > 2277)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogi2 = 2201;
            }
            bogi2 = bogi2 + 1;
        }

        private void botondombog2_click(object sender, EventArgs e)
        {
            //dom bog SKED
            devuelve = 2000;
            string compara = bogd2.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogd2 > 1377)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogd2 = 2301;
            }
            bogd2 = bogd2 + 1;
        }

        private void botonfacbog2_click(object sender, EventArgs e)
        {
            //fac bog SKED
            devuelve = 266;
            string compara = bogf2.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogf2 > 7177)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogf2 = 7101;
            }
            bogf2 = bogf2 + 1;
        }

        private void botonreiniciar_click(object sender, EventArgs e)
        {
            //click reiniciar
            fondoadvertencia.Visible = true;
            labeladvertencia.Visible = true;
            botonsi.Visible = true;
            botonno.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer 1
            DateTime dateNow = DateTime.Now;
            DateTime date=TimeZoneInfo.ConvertTimeToUtc(dateNow);
            labelhora.Text = (String.Format("{0:HH:mm:ss}",date))+" UTC";
            labelhora2.Text = (String.Format("{0:HH:mm:ss}", dateNow))+" HLC";
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void botonsi_click(object sender, EventArgs e)
        {
            //click si
            labelnumero.Text = "0000";
            labeladvertencia.Text = "Códigos reiniciados";
            botonsi.Visible = false;
            botonno.Visible = false;
            botoncontinuar.Visible = true;
            bogi2 = 2201;
            bogd2 = 1201;
            bogf2 = 7101;
            bga = 1001;
            pei = 1040;
            cuc = 0001;
            eyp = 0030;
            let = 0060;
            nva = 0740;
            andes = 7650;
            bogi = 2201;
            rngi = 2401;
            cloi = 2440;
            baqi = 6601;
            sppi = 6670;
            bogd = 1201;
            rngd = 1401;
            clod = 1601;
            vvcd = 1501;
            baqd = 1701;
            sppd = 1560;
            vvcl = 0701;
            bogf = 7101;
            rngf = 7301;
            clof = 7340;
            vvcf = 7601;
            baqf = 7520;
            sppf = 7510;
            opbog = 2020;
            opbaq = 2050;
            hosp = 2001;
            sar = 7711;
            head = 7501;
            vip2 = 7504;
        }

        private void botonno_click(object sender, EventArgs e)
        {
            //click no
            labeladvertencia.Visible = false;
            botonsi.Visible = false;
            fondoadvertencia.Visible = false;
            botonno.Visible = false;
        }

        private void botoncontinuar_click(object sender, EventArgs e)
        {
            //boton continuar
            fondoadvertencia.Visible = false;
            botoncontinuar.Visible = false;
            labeladvertencia.Text = "Se reiniciarán todos los códigos\n¿Desea continuar?";
            labeladvertencia.Visible = false;
            labelnumero.Text = "- - - -";
        }

        private void botondevolver_click(object sender, EventArgs e)
        {
            //boton devolver
            switch (devuelve)
            {
                //bga
                case 0:
                    string muestra0 = "",compara0="";
                    bga = bga - 1;
                    compara0 = bga.ToString();
                    if (compara0.Contains("8") || compara0.Contains("9"))
                    {

                    }
                    else
                    {

                    
                        if (bga < 1001)
                    {
                        bga = 1001;
                        muestra0 = bga.ToString();
                        labelnumero.Text = muestra0;
                    }
                    else
                    {
                        muestra0 = bga.ToString();
                        labelnumero.Text = muestra0;
                    }
                    }
                    break;
                //pei
                case 1:
                    string muestra = "", compara = "";
                    pei = pei - 1;
                    compara = bga.ToString();
                    if (compara.Contains("8") || compara.Contains("9"))
                    {

                    }
                    else
                    {


                        if (pei < 1040)
                        {
                            pei = 1040;
                            muestra = pei.ToString();
                            labelnumero.Text = muestra;
                        }
                        else
                        {
                            muestra = pei.ToString();
                            labelnumero.Text = muestra;
                        }
                    }
                    break;
                //cuc
                case 2:
                    string muestra1 = "", compara1 = "";
                    cuc = cuc - 1;
                    compara1 = cuc.ToString();
                    if (compara1.Contains("8") || compara1.Contains("9"))
                    {

                    }
                    else
                    {
                        if (cuc < 0001)
                        {
                            cuc = 0001;
                            muestra1 = "000" + cuc.ToString();
                            labelnumero.Text = muestra1;
                        }
                        else { 
                        if (cuc < 9)
                        {
                            muestra1 = "000" + cuc.ToString();
                            labelnumero.Text = muestra1;
                        }
                        else
                        {
                            muestra1 = "00" + cuc.ToString();
                            labelnumero.Text = muestra1;
                        }
                        if (cuc < 0001)
                        {
                            cuc = 0001;
                            muestra1 = "000"+cuc.ToString();
                            labelnumero.Text = muestra1;
                        }
                        }
                    }
                    break;
                //eyp
                case 3:
                    string muestra3 = "", compara3 = "";
                    eyp = eyp - 1;
                    compara3 = eyp.ToString();
                    if (compara3.Contains("8") || compara3.Contains("9"))
                    {

                    }
                    else
                    {


                        if (eyp < 0030)
                        {
                            eyp = 0030;
                            muestra3 = "00"+eyp.ToString();
                            labelnumero.Text = muestra3;
                        }
                        else
                        {
                            muestra3 = "00"+ eyp.ToString();
                            labelnumero.Text = muestra3;
                        }
                    }
                    break;
                //let
                case 4:
                    string muestra4 = "", compara4 = "";
                    let = let - 1;
                    compara4 = let.ToString();
                    if (compara4.Contains("8") || compara4.Contains("9"))
                    {

                    }
                    else
                    {


                        if (let < 0060)
                        {
                            let = 0060;
                            muestra4 = "00" + let.ToString();
                            labelnumero.Text = muestra4;
                        }
                        else
                        {
                            muestra4 = "00" + let.ToString();
                            labelnumero.Text = muestra4;
                        }
                    }
                    break;
                //nva
                case 5:
                    string muestra5 = "", compara5 = "";
                    nva = nva - 1;
                    compara5 = nva.ToString();
                    if (compara5.Contains("8") || compara5.Contains("9"))
                    {

                    }
                    else
                    {
                        if (nva < 0740)
                        {
                            nva = 0740;
                            muestra5 = "0" + nva.ToString();
                            labelnumero.Text = muestra5;
                        }
                        else
                        {
                            muestra5 = "0" + nva.ToString();
                            labelnumero.Text = muestra5;
                        }
                    }
                    break;
                //andes
                case 6:
                    string muestra6 = "", compara6 = "";
                    andes = andes - 1;
                    compara6 = andes.ToString();
                    if (compara6.Contains("8") || compara6.Contains("9"))
                    {

                    }
                    else
                    {
                        if (andes < 7650)
                        {
                            andes = 7650;
                            muestra6 =andes.ToString();
                            labelnumero.Text = muestra6;
                        }
                        else
                        {
                            muestra6 =andes.ToString();
                            labelnumero.Text = muestra6;
                        }
                    }
                    break;
                //bog int
                case 14:
                    string muestra14 = "", compara14 = "";
                    bogi = bogi - 1;
                    compara14 = bogi.ToString();
                    if (compara14.Contains("8") || compara14.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogi < 2301)
                        {
                            bogi = 2301;
                            muestra14 =bogi.ToString();
                            labelnumero.Text = muestra14;
                        }
                        else
                        {
                            muestra14 = bogi.ToString();
                            labelnumero.Text = muestra14;
                        }
                    }
                    break;
                case 1444:
                    string muestra1444 = "", compara1444 = "";
                    bogi2 = bogi2 - 1;
                    compara1444 = bogi2.ToString();
                    if (compara1444.Contains("8") || compara1444.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogi2 < 2201)
                        {
                            bogi2 = 2201;
                            muestra1444 = bogi2.ToString();
                            labelnumero.Text = muestra1444;
                        }
                        else
                        {
                            muestra1444 = bogi2.ToString();
                            labelnumero.Text = muestra1444;
                        }
                    }
                    break;
                //bog dom
                case 20:
                    string muestra20 = "", compara20 = "";
                    bogd = bogd - 1;
                    compara20 = bogd.ToString();
                    if (compara20.Contains("8") || compara20.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogd < 1301)
                        {
                            bogd = 1301;
                            muestra20 = bogd.ToString();
                            labelnumero.Text = muestra20;
                        }
                        else
                        {
                            muestra20 = bogd.ToString();
                            labelnumero.Text = muestra20;
                        }
                    }
                    break;
                case 2000:
                    string muestra2000 = "", compara2000 = "";
                    bogd2 = bogd2 - 1;
                    compara2000 = bogd2.ToString();
                    if (compara2000.Contains("8") || compara2000.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogd2 < 1201)
                        {
                            bogd2 = 1201;
                            muestra2000 = bogd2.ToString();
                            labelnumero.Text = muestra2000;
                        }
                        else
                        {
                            muestra2000 = bogd2.ToString();
                            labelnumero.Text = muestra2000;
                        }
                    }
                    break;
                //bog fac
                case 26:
                    string muestra26 = "", compara26 = "";
                    bogf = bogf - 1;
                    compara26 = bogf.ToString();
                    if (compara26.Contains("8") || compara26.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogf < 7201)
                        {
                            bogf = 7201;
                            muestra26 = bogd.ToString();
                            labelnumero.Text = muestra26;
                        }
                        else
                        {
                            muestra26 = bogf.ToString();
                            labelnumero.Text = muestra26;
                        }
                    }
                    break;
                case 266:
                    string muestra266 = "", compara266 = "";
                    bogf2 = bogf2 - 1;
                    compara266 = bogf2.ToString();
                    if (compara266.Contains("8") || compara266.Contains("9"))
                    {

                    }
                    else
                    {
                        if (bogf2 < 7101)
                        {
                            bogf2 = 7101;
                            muestra266 = bogf2.ToString();
                            labelnumero.Text = muestra266;
                        }
                        else
                        {
                            muestra266 = bogf2.ToString();
                            labelnumero.Text = muestra266;
                        }
                    }
                    break;
                //mde int
                case 15:
                    string muestra15 = "", compara15 = "";
                    rngi = rngi - 1;
                    compara15 = rngi.ToString();
                    if (compara15.Contains("8") || compara15.Contains("9"))
                    {

                    }
                    else
                    {
                        if (rngi < 2401)
                        {
                            rngi = 2401;
                            muestra15 = rngi.ToString();
                            labelnumero.Text = muestra15;
                        }
                        else
                        {
                            muestra15 = rngi.ToString();
                            labelnumero.Text = muestra15;
                        }
                    }
                    break;
                //mde dom
                case 19:
                    string muestra19 = "", compara19 = "";
                    rngd = rngd - 1;
                    compara19 = rngd.ToString();
                    if (compara19.Contains("8") || compara19.Contains("9"))
                    {

                    }
                    else
                    {
                        if (rngd < 1401)
                        {
                            rngd = 1401;
                            muestra19 = rngd.ToString();
                            labelnumero.Text = muestra19;
                        }
                        else
                        {
                            muestra19 = rngd.ToString();
                            labelnumero.Text = muestra19;
                        }
                    }
                    break;
                //mde fac
                case 27:
                    string muestra27 = "", compara27 = "";
                    rngf = rngf - 1;
                    compara27 = rngf.ToString();
                    if (compara27.Contains("8") || compara27.Contains("9"))
                    {

                    }
                    else
                    {
                        if (rngf < 7301)
                        {
                            rngf = 7301;
                            muestra27 = rngf.ToString();
                            labelnumero.Text = muestra27;
                        }
                        else
                        {
                            muestra27 = rngf.ToString();
                            labelnumero.Text = muestra27;
                        }
                    }
                    break;
                //clo int
                case 16:
                    string muestra16 = "", compara16 = "";
                    cloi = cloi - 1;
                    compara16 = cloi.ToString();
                    if (compara16.Contains("8") || compara16.Contains("9"))
                    {

                    }
                    else
                    {
                        if (cloi < 2440)
                        {
                            cloi = 2440;
                            muestra16 = cloi.ToString();
                            labelnumero.Text = muestra16;
                        }
                        else
                        {
                            muestra16 = cloi.ToString();
                            labelnumero.Text = muestra16;
                        }
                    }
                    break;
                //clo dom
                case 21:
                    string muestra21 = "", compara21 = "";
                    clod = clod - 1;
                    compara21 = cloi.ToString();
                    if (compara21.Contains("8") || compara21.Contains("9"))
                    {

                    }
                    else
                    {
                        if (clod < 1601)
                        {
                            clod = 1601;
                            muestra21 = clod.ToString();
                            labelnumero.Text = muestra21;
                        }
                        else
                        {
                            muestra21 = clod.ToString();
                            labelnumero.Text = muestra21;
                        }
                    }
                    break;
                //clo fac
                case 28:
                    string muestra28 = "", compara28 = "";
                    clof = clof - 1;
                    compara28 = clod.ToString();
                    if (compara28.Contains("8") || compara28.Contains("9"))
                    {

                    }
                    else
                    {
                        if (clof < 7340)
                        {
                            clof = 7340;
                            muestra28 = clof.ToString();
                            labelnumero.Text = muestra28;
                        }
                        else
                        {
                            muestra28 = clof.ToString();
                            labelnumero.Text = muestra28;
                        }
                    }
                    break;
                //vvc dom
                case 22:
                    string muestra22 = "", compara22 = "";
                    vvcd = vvcd - 1;
                    compara22 = vvcd.ToString();
                    if (compara22.Contains("8") || compara22.Contains("9"))
                    {

                    }
                    else
                    {
                        if (vvcd < 1501)
                        {
                            vvcd = 1501;
                            muestra22 = vvcd.ToString();
                            labelnumero.Text = muestra22;
                        }
                        else
                        {
                            muestra22 = vvcd.ToString();
                            labelnumero.Text = muestra22;
                        }
                    }
                    break;
                //vvc loc
                case 25:
                    string muestra25 = "", compara25 = "";
                    vvcl = vvcl - 1;
                    compara25 = vvcl.ToString();
                    if (compara25.Contains("8") || compara25.Contains("9"))
                    {

                    }
                    else
                    {
                        if (vvcl < 0701)
                        {
                            vvcl = 0701;
                            muestra25 = "0"+vvcl.ToString();
                            labelnumero.Text = muestra25;
                        }
                        else
                        {
                            muestra25 ="0"+ vvcl.ToString();
                            labelnumero.Text = muestra25;
                        }
                    }
                    break;
                //vvc fac
                case 29:
                    string muestra29 = "", compara29 = "";
                    vvcf = vvcf - 1;
                    compara29 = vvcf.ToString();
                    if (compara29.Contains("8") || compara29.Contains("9"))
                    {

                    }
                    else
                    {
                        if (vvcf < 7601)
                        {
                            vvcf = 7601;
                            muestra29 = vvcf.ToString();
                            labelnumero.Text = muestra29;
                        }
                        else
                        {
                            muestra29 = vvcf.ToString();
                            labelnumero.Text = muestra29;
                        }
                    }
                    break;
                //baq int
                case 17:
                    string muestra17 = "", compara17 = "";
                    baqi = baqi - 1;
                    compara17 = baqi.ToString();
                    if (compara17.Contains("8") || compara17.Contains("9"))
                    {

                    }
                    else
                    {
                        if (baqi < 6601)
                        {
                            baqi = 6601;
                            muestra17 = baqi.ToString();
                            labelnumero.Text = muestra17;
                        }
                        else
                        {
                            muestra17 = baqi.ToString();
                            labelnumero.Text = muestra17;
                        }
                    }
                    break;
                //baq dom
                case 23:
                    string muestra23= "", compara23 = "";
                    baqd = baqd - 1;
                    compara23 = baqd.ToString();
                    if (compara23.Contains("8") || compara23.Contains("9"))
                    {

                    }
                    else
                    {
                        if (baqd < 1701)
                        {
                            baqd = 1701;
                            muestra23 = baqd.ToString();
                            labelnumero.Text = muestra23;
                        }
                        else
                        {
                            muestra23 = baqd.ToString();
                            labelnumero.Text = muestra23;
                        }
                    }
                    break;
                //baq fac
                case 30:
                    string muestra30 = "", compara30 = "";
                    baqf = baqf - 1;
                    compara30 = baqf.ToString();
                    if (compara30.Contains("8") || compara30.Contains("9"))
                    {

                    }
                    else
                    {
                        if (baqf < 7520)
                        {
                            baqf = 7520;
                            muestra30 = baqf.ToString();
                            labelnumero.Text = muestra30;
                        }
                        else
                        {
                            muestra30 = baqf.ToString();
                            labelnumero.Text = muestra30;
                        }
                    }
                    break;
                //spp int
                case 18:
                    string muestra18 = "", compara18 = "";
                    sppi = sppi - 1;
                    compara18 = sppi.ToString();
                    if (compara18.Contains("8") || compara18.Contains("9"))
                    {

                    }
                    else
                    {
                        if (sppi < 6670)
                        {
                            sppi = 6670;
                            muestra18 = sppi.ToString();
                            labelnumero.Text = muestra18;
                        }
                        else
                        {
                            muestra18 = sppi.ToString();
                            labelnumero.Text = muestra18;
                        }
                    }
                    break;
                //spp dom
                case 24:
                    string muestra24 = "", compara24 = "";
                    sppd = sppd - 1;
                    compara24 = sppd.ToString();
                    if (compara24.Contains("8") || compara24.Contains("9"))
                    {

                    }
                    else
                    {
                        if (sppd < 1560)
                        {
                            sppd = 1560;
                            muestra24 = sppd.ToString();
                            labelnumero.Text = muestra24;
                        }
                        else
                        {
                            muestra24 = sppd.ToString();
                            labelnumero.Text = muestra24;
                        }
                    }
                    break;
                //spp fac
                case 31:
                    string muestra31 = "", compara31 = "";
                    sppf = sppf - 1;
                    compara31 = sppf.ToString();
                    if (compara31.Contains("8") || compara31.Contains("9"))
                    {

                    }
                    else
                    {
                        if (sppf < 7510)
                        {
                            sppf = 7510;
                            muestra31 = sppf.ToString();
                            labelnumero.Text = muestra31;
                        }
                        else
                        {
                            muestra31 = sppf.ToString();
                            labelnumero.Text = muestra31;
                        }
                    }
                    break;
                //hosp
                case 11:
                    string muestra11 = "", compara11 = "";
                    hosp = hosp - 1;
                    compara11 = hosp.ToString();
                    if (compara11.Contains("8") || compara11.Contains("9"))
                    {

                    }
                    else
                    {
                        if (hosp < 2001)
                        {
                            hosp = 2001;
                            muestra11 = hosp.ToString();
                            labelnumero.Text = muestra11;
                        }
                        else
                        {
                            muestra11 = hosp.ToString();
                            labelnumero.Text = muestra11;
                        }
                    }
                    break;
                //hosp
                case 111:
                    string muestra111 = "", compara111 = "";
                    hosp = hosp - 1;
                    compara111 = hosp.ToString();
                    if (compara111.Contains("8") || compara111.Contains("9"))
                    {

                    }
                    else
                    {
                        if (hosp < 2001)
                        {
                            hosp = 2001;
                            muestra111 = hosp.ToString();
                            labelnumero.Text = muestra111;
                        }
                        else
                        {
                            muestra111 = hosp.ToString();
                            labelnumero.Text = muestra111;
                        }
                    }
                    break;
                //sar
                case 12:
                    string muestra12 = "", compara12 = "";
                    sar = sar - 1;
                    compara12 = sar.ToString();
                    if (compara12.Contains("8") || compara12.Contains("9"))
                    {

                    }
                    else
                    {
                        if (sar < 7711)
                        {
                            sar = 7711;
                            muestra12 = sar.ToString();
                            labelnumero.Text = muestra12;
                        }
                        else
                        {
                            muestra12 = sar.ToString();
                            labelnumero.Text = muestra12;
                        }
                    }
                    break;
                //op bog
                case 32:
                    string muestra32 = "", compara32 = "";
                    opbog = opbog - 1;
                    compara32 = opbog.ToString();
                    if (compara32.Contains("8") || compara32.Contains("9"))
                    {

                    }
                    else
                    {
                        if (opbog < 2020)
                        {
                            opbog = 2020;
                            muestra32 = opbog.ToString();
                            labelnumero.Text = muestra32;
                        }
                        else
                        {
                            muestra32 = opbog.ToString();
                            labelnumero.Text = muestra32;
                        }
                    }
                    break;
                //op baq
                case 33:
                    string muestra33 = "", compara33 = "";
                    opbaq = opbaq - 1;
                    compara33 = opbaq.ToString();
                    if (compara33.Contains("8") || compara33.Contains("9"))
                    {

                    }
                    else
                    {
                        if (opbaq < 2050)
                        {
                            opbaq = 2050;
                            muestra33 = opbaq.ToString();
                            labelnumero.Text = muestra33;
                        }
                        else
                        {
                            muestra33 = opbaq.ToString();
                            labelnumero.Text = muestra33;
                        }
                    }
                    break;
                //head
                case 13:
                    string muestra13 = "", compara13 = "";
                    head = head - 1;
                    compara13 = head.ToString();
                    if (compara13.Contains("8") || compara13.Contains("9"))
                    {

                    }
                    else
                    {
                        if (head < 7501)
                        {
                            head = 7501;
                            muestra13 = head.ToString();
                            labelnumero.Text = muestra13;
                        }
                        else
                        {
                            muestra13 = head.ToString();
                            labelnumero.Text = muestra13;
                        }
                    }
                    break;
                //vip2
                case 34:
                    string muestra34 = "", compara34 = "";
                    vip2 = vip2 - 1;
                    compara34 = vip2.ToString();
                    if (compara34.Contains("8") || compara34.Contains("9"))
                    {

                    }
                    else
                    {
                        if (vip2 < 7504)
                        {
                            vip2 = 7504;
                            muestra34 = vip2.ToString();
                            labelnumero.Text = muestra34;
                        }
                        else
                        {
                            muestra34 = vip2.ToString();
                            labelnumero.Text = muestra34;
                        }
                    }
                    break;
            }
        }

        private void fondoreinicio_Click(object sender, EventArgs e)
        {

        }

        private void botonaccbaq_click(object sender, EventArgs e)
        {
            //ACC BAQ
            botondombaq.Visible = true;
            botonitlbaq.Visible = true;
            botonfacbaq.Visible = true;
            botondomvvc.Visible = false;
            botonlocalvvc.Visible = false;
            botonfacvvc.Visible = false;
            labelsalaspp.Visible = false;
            labelaccbaq.Visible = true;
        }

        private void botonspp_click(object sender, EventArgs e)
        {
            //SALA SPP
            botondombaq.Visible = false;
            botonitlbaq.Visible = false;
            botonfacbaq.Visible = false;
            botonitlspp.Visible = true;
            botondomspp.Visible = true;
            botonfacspp.Visible = true;
            labelsalaspp.Visible = true;
            labelaccbaq.Visible = false;
        }

        private void botonhosp_click(object sender, EventArgs e)
        {
            //BOTON HOSP d11
            devuelve = 111;
            string compara = hosp.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            hosp = hosp + 1;
            if (hosp > 2017)
            {
                labelnumero.Text = "2017-SSR COMPLETOS";
                hosp = 2001;
            }
        }

        private void botonsar_click(object sender, EventArgs e)
        {
            //VUELOS SAR d12
            devuelve = 12;
            string compara = sar.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            sar = sar + 1;
            if (sar > 7717)
            {
                labelnumero.Text = "7717-SSR COMPLETOS";
                sar = 7711;
            }
        }

        private void labelprioridad_Click(object sender, EventArgs e)
        {
            //LABEL PRIORIDAD
        }

        private void botonhead_click(object sender, EventArgs e)
        {
            //VUELOS HEAD d13
            devuelve = 13;
            string compara = head.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            head = head + 1;
            if (head > 7503)
            {
                labelnumero.Text = "7503-SSR COMPLETOS";
                head = 7501; 
            }
        }

        private void botonitlbog_clic(object sender, EventArgs e)
        {
            //BOTON INTL  TWR BOG  d14
            devuelve = 14;
            string compara = bogi.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogi > 2377)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogi = 2301;
            }
            bogi = bogi + 1;
        }

        private void botonitlrng_click(object sender, EventArgs e)
        {
            //BOTON INTL RNG d15
            devuelve = 15;
            string compara = rngi.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            rngi = rngi + 1;
            if (rngi > 2437)
            {
                labelnumero.Text = "2437-SSR COMPLETOS";
                rngi = 2401;
            }
        }

        private void botonitlclo_click(object sender, EventArgs e)
        {
            //BOTON INTL CLO d16
            devuelve = 16;
            string compara = cloi.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            cloi = cloi + 1;
            if (cloi > 2477)
            {
                labelnumero.Text = "2477-SSR COMPLETOS";
                cloi = 2440;
            }
        }

        private void botonitlbaq_click(object sender, EventArgs e)
        {
            //BOTON INTL BAQ d17
            devuelve = 17;
            string compara = baqi.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            baqi = baqi + 1;
            if (baqi > 6667)
            {
                labelnumero.Text = "6667-SSR COMPLETOS";
                baqi = 6601;
            }
        }

        private void botonitlspp_click(object sender, EventArgs e)
        {
            //BOTON INTL SPP d18
            devuelve = 18;
            string compara = sppi.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            sppi = sppi + 1;
            if (sppi > 6677)
            {
                labelnumero.Text = "6677-SSR COMPLETOS";
                sppi = 6670;
            }
        }

        private void botondomrng_click(object sender, EventArgs e)
        {
            //BOTON DOM RNG d19
            devuelve = 19;
            string compara = rngd.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            rngd = rngd + 1;
            if (rngd > 1477)
            {
                labelnumero.Text = "1477-SSR COMPLETOS";
                rngd = 1401;
            }
        }

        private void botondombog_click(object sender, EventArgs e)
        {
            //BOTON DOM BOG d20
            devuelve = 20;
            string compara = bogd.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogd > 1377)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogd = 1301;
            }
            bogd = bogd + 1;
        }

        private void botondomclo_click(object sender, EventArgs e)
        {
            //BOTON DOM CLO d21
            devuelve = 21;
            string compara = clod.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            clod = clod + 1;
            if (clod > 1677)
            {
                labelnumero.Text = "1677-SSR COMPLETOS";
                clod = 1601;
            }
        }
            private void botondomvvc_click(object sender, EventArgs e)
        {
            //BOTON DOM VVC d22
            devuelve = 22;
            string compara = vvcd.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            vvcd = vvcd + 1;
            if (vvcd > 1577)
            {
                labelnumero.Text = "1577-SSR COMPLETOS";
                vvcd = 1501;
            }
        }

        private void botondombaq_clic(object sender, EventArgs e)
        {
            //BOTON DOM BAQ d23
            devuelve = 23;
            string compara = baqd.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            baqd = baqd + 1;
            if (baqd > 1777)
            {
                labelnumero.Text = "1777-SSR COMPLETOS";
                baqd = 1701;
            }
        }

        private void botondomspp_click(object sender, EventArgs e)
        {
            //BOTON DOM SPP d24
            devuelve = 24;
            string compara = sppd.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            sppd = sppd + 1;
            if (sppd > 1577)
            {
                labelnumero.Text = "1577-SSR COMPLETOS";
                sppd = 1560;
            }
        }

        private void botonlocalvvc_click(object sender, EventArgs e)
        {
            //BOTON LOCAL VVC d25
            devuelve = 25;
            string compara = vvcl.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                compara = "0" + compara;
                labelnumero.Text = compara;
            }
            vvcl = vvcl + 1;
            if (vvcl > 737)
            {
                labelnumero.Text = "0737-SSR COMPLETOS";
                vvcl = 0701; 
            }
        }

        private void botonfacbog_click(object sender, EventArgs e)
        {
            //BOTON FAC  TWR BOG d26
            devuelve = 26;
            string compara = bogf.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            if (bogf > 7277)
            {
                labelnumero.Text = "SSR COMPLETOS";
                bogf = 7201;
            }
            bogf = bogf + 1;
        }

        private void botonfacrng_click(object sender, EventArgs e)
        {
            //BOTON FAC RNG d27
            devuelve = 27;
            string compara = rngf.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            rngf = rngf + 1;
            if (rngf > 7337)
            {
                labelnumero.Text = "7337-SSR COMPLETOS";
                rngf = 7301;
            }
        }

        private void botonfacclo_click(object sender, EventArgs e)
        {
            //BOTON FAC CLO d28
            devuelve = 28;
            string compara = clof.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            clof = clof + 1;
            if (clof > 7377)
            {
                labelnumero.Text = "7377-SSR COMPLETOS";
                clof = 7340;
            }
        }

        private void botonfacvvc_click(object sender, EventArgs e)
        {
            //BOTON FAC VVC d29
            devuelve = 29;
            string compara = vvcf.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            vvcf = vvcf + 1;
            if (vvcf > 7647)
            {
                labelnumero.Text = "7647-SSR COMPLETOS";
                vvcf = 7601;
            }
        }

        private void botonfacbaq_click(object sender, EventArgs e)
        {
            //BOTON FAC BAQ d30
            devuelve = 30;
            string compara = baqf.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            baqf = baqf + 1;
            if (baqf > 7577)
            {
                labelnumero.Text = "7577-SSR COMPLETOS";
                baqf = 7520;
            }
        }

        private void botonfacspp_click(object sender, EventArgs e)
        {
            //BOTON FAC SPP d31
            devuelve = 31;
            string compara = sppf.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            sppf = sppf + 1;
            if (sppf > 7517)
            {
                labelnumero.Text = "7517-SSR COMPLETOS";
                sppf = 7510;
            }
        }

        private void botonopbog_click(object sender, EventArgs e)
        {
            //VUELOS OP BOG d32
            devuelve = 32;
            string compara = opbog.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
             opbog= opbog + 1;
            if (opbog > 2047)
            {
                labelnumero.Text = "2047-SSR COMPLETOS";
                opbog = 2020;
            }
        }

        private void botonopbq_click(object sender, EventArgs e)
        {
            //VUELOS OP BAQ d33
            devuelve = 33;
            string compara = opbaq.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            opbaq = opbaq + 1;
            if (opbaq > 2077)
            {
                labelnumero.Text = "2077-SSR COMPLETOS";
                opbaq = 2050;
            }
        }

        private void botonvip2_click(object sender, EventArgs e)
        {
            //VIP 2 d34
            devuelve = 34;
            string compara = vip2.ToString();
            if (compara.Contains("8") || compara.Contains("9"))
            {

            }
            else
            {
                labelnumero.Text = compara;
            }
            vip2 = vip2 + 1;
            if (vip2 > 7507)
            {
                labelnumero.Text = "7507-SSR COMPLETOS";
                vip2 = 7504;
            }
        }

        private void labelcodigo_Click(object sender, EventArgs e)
        {
            //label codigo
        }

        private void labelnumero_Click(object sender, EventArgs e)
        {
            //label numero
        }

        private void botonfirbaq_click(object sender, EventArgs e)
        {
            //BOTON FIR BAQ
            botondevolver.Visible = true;
            botonspp.Visible = true;
            botonaccbaq.Visible = true;
            botonfirbaq.Visible = false;
            botonfirbog.Visible = false;
            label1.Visible = false;
            labelprioridad.Visible = true;
            botonopbog.Visible = false;
            botonopbq.Visible = true;
            botonhosp.Visible = true;
            botonhead.Visible = true;
            botonvip2.Visible = true;
            botonsar.Visible = true;
            labelcodigo.Visible = true;
            labelnumero.Visible = true;
            labelfirbaq.Visible = true;
            botonregresar.Visible = true;
            botonreiniciar.Visible = true;
            sked = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simulator
{
    public partial class Form1 : Form
    {
        String fisier, xreads;
        string[] words;
        string[] words1;
        int j = 0;
        int ticks = 0, index, PC = 0, hit = 0, miss = 0;



        public struct TipInstr //structura pentru fiecare instructiune
        {
            public char tipInstructiune;
            public int AdrCrt;
            public int AdrDest;
        };
        TipInstr[] l = new TipInstr[1000000];

        public struct TipDCache
        {
            public int Data;
            public int TagC;
            public int V;
            public int D;
        };

        public struct TipICache
        {
            public int TagC;
            public int V;
        };
        public struct TipFetch
        {
            public int PC;
            public char Tip;
            public int AdrCrtt;
            public int AdrDest;
        };
        /* public struct instrCache
         {
             public double Size_IC;
             public double Bloc_Size;

             public int tip;
         };
         instrCache TipCacheInstruction;

         public struct IC
         {
             public double Tag;
             public double Bloc_Offset;
         };
         IC[] ci;

         public struct DC
         {
             public double Tag;
             public double Bloc_Offset;
         };
         DC[] cd;

         public struct dataCache
         {
             public double Size_DC;
             public double Bloc_Size;

         };
         dataCache TipCacheData;

         public struct TipSim
         {
             public double FR;//rata fetch
             public double IRmax;//rata maxima
             public int IBS;//dimensiune buffer
             public double latenta;
             public double nrRegistri;
             public double Mem;
         };
         TipSim TipSimulare;

         public struct Ibs
         {
             public char tipInstr;
             public int PC_Crt;
             public int Target;
         };
         */

        TipFetch[] One_Fetch;
        TipDCache[] D_Cache;
        int SIZE_DC;
        int D_CacheHit;
        int D_CacheMiss;

        public Form1()
        {
            InitializeComponent();
            InitializareValori();
        }
        bool ready = false;


        private void file_btn_Click(object sender, EventArgs e)
        {
            int i = 0, k = 0;
            words1 = new string[20];
            string nmfis;
            string[] nm = new string[8];



            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = "TrC Files (*.trc)|*.trc|Text Files (*.txt)|*.txt";
            if (ofn.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                fisier = ofn.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            nmfis = fisier;
            start_btn.Enabled = true;
            nm = nmfis.Split('\\');
            NumeFisier.Text = nm[nm.Length - 1];
            StreamReader file = new StreamReader(fisier);

            while (!file.EndOfStream)
            {
                i = 0;
                k = 0;
                xreads = file.ReadLine();
                words = xreads.Split(' ');

                while (i < words.Length)
                {
                    if (words[i] != "") { words1[k] = words[i]; k++; }
                    i++;

                }
                k = 1;
                i = 0;
                //for (i = 0; i < 15; i++)
                while (words1[i] != null)
                {
                    if (k == 1) { l[j].tipInstructiune = Convert.ToChar(words1[i]); k++; }
                    else
                    if (k == 2) { l[j].pc_Curent = Convert.ToInt32(words1[i]); k++; }
                    else
                    if (k == 3) { l[j].target = Convert.ToInt32(words1[i]); k = 1; j++; }
                    i++;
                }
            }
            TipInstr[] copie_l = l;
            file.Close();
            // write.Close();
        }


        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {   //atribuirea parametrilor cache instruction


            //atribuirea parametrilor cache data

            TipCacheData.Bloc_Size = Convert.ToDouble(this.block_size.Text);
            TipCacheData.Size_DC = Convert.ToDouble(this.SizeDC.Text);

            //atribuire parametri
            TipSimulare.FR = Convert.ToInt32(this.FR.Text);
            TipSimulare.IBS = Convert.ToInt32(this.IBS.Text);
            TipSimulare.IRmax = Convert.ToInt32(this.IR_max.Text);
            TipSimulare.latenta = Convert.ToInt32(this.Latenta.Text);
            TipSimulare.Mem = Convert.ToInt32(this.Memory.Text);
            TipSimulare.nrRegistri = Convert.ToInt32(this.NrRegistri.Text);

            //atribuirea nr. de intructiuni

            int nrInstrProcesate = 0;
            int nrBranchProcesate = 0;
            int nrStoreProcesate = 0;
            int nrLoadProcesate = 0;
            int nrOneCycleProcesate = 0;
            int I_Cache_Hit = 0;
            int I_Cache_Miss = 0;
            int D_Cache_Hit = 0;
            int D_Cache_Miss = 0;







        }

        private void FR_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeBloc.Text = FR.Text;
            //   if ((Convert.ToInt32(FR.Text) > Convert.ToInt32(IBS.Text))) IBS.Text = FR.Text;
            if (ready)
            {
                if (Convert.ToInt32(FR.Text) > Convert.ToInt32(IR_max.Text)) IR_max.Text = FR.Text;
                if (Convert.ToInt32(FR.Text) < Convert.ToInt32(IBS.Text)) IBS.Text = FR.Text;
            }
        }

        private void SizeBloc_SelectedIndexChanged(object sender, EventArgs e)
        {

            IR_max.Text = FR.Text;

        }

        private void IBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(IBS.Text) < Convert.ToInt32(FR.Text)) IBS.Text = FR.Text;
        }

        private void IR_max_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(IR_max.Text) > Convert.ToInt32(FR.Text)) IR_max.Text = FR.Text;
        }

        private void InitializareValori()
        {

            FR.Text = FR.Items[0].ToString();
            IBS.Text = IBS.Items[0].ToString();
            IR_max.Text = IR_max.Items[0].ToString();
            Memory.Text = Memory.Items[0].ToString();
            NrRegistri.Text = NrRegistri.Items[0].ToString();
            size_ic.Text = size_ic.Items[0].ToString();
            block_size.Text = block_size.Items[0].ToString();
            SizeDC.Text = SizeDC.Items[0].ToString();
            ready = true;

        }


    }


}





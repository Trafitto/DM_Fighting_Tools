using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DM_Fighting_Tools
{
   
    public partial class Form1 : Form
    {
         
        private void readFile(string path, List<Personaggi> pg, bool reset)
        {
            StreamReader stReader;
            if (reset)
            {
                Personaggi.Clear();
            }
            
            if (File.Exists(path))
            {
                try
                {

               
                    stReader = new StreamReader(path);
                    string line;
                    while ((line=stReader.ReadLine())!=null)
                    {
                        string[] parametro = line.Split('#');
                        pg.Add(new Personaggi(parametro[0],Convert.ToInt32(parametro[1]),Convert.ToInt32(parametro[2]), Convert.ToInt32(parametro[3]), Convert.ToInt32(parametro[4]), Convert.ToInt32(parametro[5])));

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("File non trovato:\n"+ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File non trovato", "Errore",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            LoadDB();
        }

 

        
        private void LoadDB()
        {
            TablePG.Clear();
            foreach (Personaggi pg in Personaggi)
            {
                TablePG.Rows.Add(pg.Name, pg.Iniziativa, pg.Life,pg.ClasseArmatura,pg.CAContatto,pg.CASprovvista);

            }
           
            grdPG.Refresh();
            grdPG.Sort(grdPG.Columns["iniziativa"], ListSortDirection.Descending);
            
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        private List<Personaggi> personaggi = new List<Personaggi>();

        internal List<Personaggi> Personaggi
        {
            get
            {
                return personaggi;
            }

            set
            {
                personaggi = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileLoad = "Personaggi.txt";
            
            readFile(fileLoad, Personaggi,true);
            

            
            
            
        }

   
    
    
        private void grdPG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = grdPG.Rows[e.RowIndex].Cells[0]; //indice colonna nome
                string nome = Convert.ToString(cell.Value);
                lblNomePG.Text = nome;
            }
            catch (Exception ex)
            {
               
            }
            if (e.ColumnIndex==2) //indice colonna vita
            {
                //DataGridViewCell cell = grdPG.Rows[e.RowIndex].Cells[e.ColumnIndex];
                
                grupDanni.Visible = true;
                groupIniziativa.Visible = false;
                

            }
            if (e.ColumnIndex==1)
            {
                groupIniziativa.Visible = true;
                grupDanni.Visible = false;
              
            }
          

        }

        private void button1_Click(object sender, EventArgs e) //btnsottrai
        {
            int danniSubiti = Convert.ToInt32(txtmodVita.Text);
            foreach(Personaggi pg in Personaggi)
            {
                if (pg.Name==lblNomePG.Text)
                {
                    pg.Life -= danniSubiti;
                }
            }
            LoadDB();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int danniAggiunti = Convert.ToInt32(txtmodVita.Text);
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    pg.Life += danniAggiunti;
                }
            }
            LoadDB();
        }

        private void txtIniziativa_TextChanged(object sender, EventArgs e)
        {
           
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    pg.Iniziativa= Convert.ToInt32(txtIniziativa.Text);
                }
            }
            LoadDB();
        }

        private void nuovoMenu_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                readFile(openFile.FileName, Personaggi,true);
            }
        }

        private void aggiungiAccodaMenu_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                readFile(openFile.FileName, Personaggi,false);
            }
        }
    }
    
}

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
using System.Text.RegularExpressions;

namespace DM_Fighting_Tools
{
   //BUONA FORTUNA °3°
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
                    stReader.ReadLine(); //salto la prima riga d'intestazione
                    while ((line = stReader.ReadLine()) != null)
                    {

                        string[] parametro = line.Split(';');
                        pg.Add(new Personaggi(parametro[0], Convert.ToInt32(parametro[1]), Convert.ToInt32(parametro[2]), Convert.ToInt32(parametro[3]), Convert.ToInt32(parametro[4]), Convert.ToInt32(parametro[5]),parametro[6],parametro[7]));

                    }
                    stReader.Close();
                    LoadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nella lettura del file:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File non trovato: "+path, "Errore",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
           
        }

      



       private void LoadDB()
       {

            try
            {
                TablePG.Clear();
               
                foreach (Personaggi pg in Personaggi)
                {
                    TablePG.Rows.Add(pg.Name, pg.Iniziativa, pg.Life, pg.ClasseArmatura, pg.CAContatto, pg.CASprovvista);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'inserimento dei dati:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            grdPG.Sort(grdPG.Columns["iniziativa"], ListSortDirection.Descending);
            if (TablePG.Rows.Count>0)
            {
                grdPG.Rows[rowindex].Selected = true;
            }
           
           

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
        int rowindex;
        private void Form1_Load(object sender, EventArgs e)
        {
            //automatic file loaded 
            string fileLoad = "StartingFile.csv";
          
            readFile(fileLoad, Personaggi, true);
            
        }
        //legge i vari attacchi ogni virgola inserisce un rigo accapo  
        private void SelectAtk()
          {
              foreach (Personaggi pg in Personaggi)
              {
                  if (pg.Name == lblNomePG.Text)
                  {
                      riTxtAtk.Text = "";
                      string[] AtkNome = pg.Attacchi.Split(',');
                      for (int i = 0; i < AtkNome.Length; i++)
                      {
                          
                         
                        riTxtAtk.Text += AtkNome[i]  + "\n";
                          
                      }

                  }
              }
          }
        //legge le note ogni virgola inserisce un rigo accapo  
        private void ReadNote()
        {
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    richNote.Text = "";
                    string[] note = pg.Note.Split(',');
                    for (int i = 0; i < note.Length; i++)
                    {


                        richNote.Text += note[i] + "\n";

                    }

                }
            }
        }


        //TODO: Clear text box when changing selected enemy
        private void ClearTextBox()
        {
            txtmodVita.Text = null;
            txtIniziativa.Text = null;
            txtCA.Text = "";
            txtCAcontatto.Text = "";
            txtCAsprovvista.Text = "";
            riTxtAtk.Text = "";
            richNote.Text = "";
           
           
        }
    
        private void grdPG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewCell cell = grdPG.Rows[e.RowIndex].Cells[0]; //indice colonna nome
                rowindex = e.RowIndex;
                string nome = Convert.ToString(cell.Value);
                lblNomePG.Text = nome;
            }
            catch
            {
                
            }
        
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                groupIniziativa.Visible = true;
                //ClearTextBox();
            }
            else
            {
                groupIniziativa.Visible = false;
            }

             

                SelectAtk();
                ReadNote();
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
                    if (txtIniziativa.Text != null || txtIniziativa.Text!="" )
                    {
                        pg.Iniziativa = Convert.ToInt32(txtIniziativa.Text);
                    }
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

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();


            helpForm.Show();
        }

        private void txtCA_TextChanged(object sender, EventArgs e)
        {
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    if (txtCA.Text != null || txtCA.Text!="")
                    {
                        pg.ClasseArmatura = Convert.ToInt32(txtCA.Text);
                    }
                       
                }
            }
            LoadDB();
        }

        private void txtCAcontatto_TextChanged(object sender, EventArgs e)
        {
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    if (txtCAcontatto.Text != null || txtCAcontatto.Text!="")
                    {
                        pg.CAContatto = Convert.ToInt32(txtCAcontatto.Text);
                    }
                       
                }
            }
            LoadDB();
        }

        private void txtCAsprovvista_TextChanged(object sender, EventArgs e)
        {
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    if (txtCAsprovvista.Text != null || txtCAsprovvista.Text!="")
                    {
                        pg.CASprovvista = Convert.ToInt32(txtCAsprovvista.Text);
                    }
                   
                }
            }
            LoadDB();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (Personaggi pg in Personaggi)
            {
                if (pg.Name == lblNomePG.Text)
                {
                    personaggi.Remove(pg);
                    break;
                }
            }
            LoadDB();
            ClearTextBox();
        }

      
    }
    
}

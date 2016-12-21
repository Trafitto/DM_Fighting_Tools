using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Fighting_Tools
{
    class Personaggi
    {
        string name;
        int iniziativa;
        int life;
        int classeArmatura;
        int CAcontatto;
        int CAsprovvista;
      
        string attacchi;
        string note;


        public Personaggi (string name,int iniziativa,int life, int classeArmatura,int CAcontatto, int CAsprovvista,string attacchi,string note)
        {
            this.name = name;
            this.iniziativa = iniziativa;
            this.life = life;
            this.classeArmatura = classeArmatura;
            this.CAcontatto = CAcontatto;
            this.CAsprovvista = CAsprovvista;
            this.attacchi = attacchi;
            this.note = note;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Iniziativa
        {
            get { return iniziativa; }
            set { iniziativa = value; }
        }
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public int CAContatto
        {
            get { return CAcontatto; }
            set { CAcontatto = value; }
        }
        public int ClasseArmatura
        {
            get { return classeArmatura; }
            set { classeArmatura = value; }
        }
        public int CASprovvista
        {
            get { return CAsprovvista; }
            set { CAsprovvista = value; }
        }
        public string Attacchi
        {
            get { return attacchi; }
            set { attacchi = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }


    }


}

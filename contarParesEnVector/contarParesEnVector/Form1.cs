using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contarParesEnVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] vector = new []{ 42, 40, 41, 41,42, 36, 41, 36, 36 , 41,41,41};
            int num = GetCount(vector);
            MessageBox.Show("La cantidad de pares del vector es de "+num.ToString());
        }

        int GetCount(int[] zapatos)
        {
            int cantidadDePares = 0;

            var groups = zapatos.GroupBy(v => v);
            foreach (var group in groups)
            {
                if (group.Count() >1)
                {
                    cantidadDePares+=group.Count()/2;
                }        
            }

            return cantidadDePares;
        }

        


    }
}

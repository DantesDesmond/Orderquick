﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Primera lista
namespace Orderquick
{
    public partial class QuickOrder : Form
    {
        int[] array = new int[] { 8, 2, 9, 25, 80, 13, 85, 99, 1 };
        public QuickOrder()
        {
            InitializeComponent();
          

            for (int a = 0; a < array.Length; a++)

            {
                listOne.Items.Add(array[a]);
            }

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
          

            int auxiliar;
            for (int q = 0; q < array.Length; q++)
            {

                for (int d = 0; d < array.Length; d++)

                {

                    if (array[q] > array[d])

                    {

                        auxiliar = array[q];
                        array[q] = array[d];
                        array[d] = auxiliar;


                    }

                }

            }
//Segunda lista
            for (int m = 0; m < array.Length; m++)

            {
                Listwo.Items.Add(array[m]);
            }


        }
    }
}
